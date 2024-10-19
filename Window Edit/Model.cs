using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Window_Edit;
using Window_Edit.Annotations;
using WindowEdit.Interop;

namespace WindowEdit {
	internal class Model : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		private WindowInfo targetWindow;
		private SIZE windowSize;
		private POINT windowPosition;
		private bool topmost;

		private readonly DispatcherTimer windowCheckTimer = new DispatcherTimer {
			Interval = TimeSpan.FromSeconds(1)
		};

		#region Properties

		public ObservableCollection<WindowInfo> WindowList { get; } = new ObservableCollection<WindowInfo>();

		public WindowInfo TargetWindow {
			get => targetWindow;
			set {
				if (value == targetWindow) return;
				targetWindow = value;
				OnPropertyChanged();

				if (value != null && !windowCheckTimer.IsEnabled)
					windowCheckTimer.Start();
			}
		}

		public SIZE WindowSize {
			get => windowSize;
			set {
				if (value == windowSize) return;
				windowSize = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(WinWidth));
				OnPropertyChanged(nameof(WinHeight));
			}
		}

		public POINT WindowPosition {
			get => windowPosition;
			set {
				if (value == windowPosition) return;
				windowPosition = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(WinPosX));
				OnPropertyChanged(nameof(WinPosY));
			}
		}

		public int WinPosX {
			get => windowPosition.X;
			set {
				if (value == windowPosition.X) return;
				windowPosition.x = value;
				OnPropertyChanged();
			}
		}

		public int WinPosY {
			get => windowPosition.y;
			set {
				if (value == windowPosition.y) return;
				windowPosition.y = value;
				OnPropertyChanged();
			}
		}

		public int WinWidth {
			get => windowSize.cx;
			set {
				if (value == windowSize.cx) return;
				windowSize.cx = value;
				OnPropertyChanged();
			}
		}

		public int WinHeight {
			get => windowSize.cy;
			set {
				if (value == windowSize.cy) return;
				windowSize.cy = value;
				OnPropertyChanged();
			}
		}

		public bool Topmost {
			get => topmost;
			set {
				if (value == topmost) return;
				topmost = value;
				OnPropertyChanged();
				
			}
		}

		#endregion

		#region Commands

		public Command SetPosCommand => new Command(SetPos);
		public Command SetSizeCommand => new Command(SetSize);
		public Command TopMostCheckCommand => new Command(TopMostCheck);
		public Command TopLeftCommand => new Command(TopLeft);
		public Command RemoveBorderCommand => new Command(RemoveBorder);
		public Command BorderlessFullscreenCommand => new Command(BorderlessFullscreen);
		public Command RefreshWindowsCommand => new Command(RefreshWindowList);
		public ParamCommand SelectWindowCommand => new ParamCommand(SelectWindow);

		private void SetPos() {
			MUser32.SetWindowPos(TargetWindow.Handle, IntPtr.Zero, WinPosX, WinPosY, 0, 0,
				MUser32.SetWindowPosFlags.SWP_NOSIZE | MUser32.SetWindowPosFlags.SWP_NOACTIVATE);
		}

		private void SetSize() {
			MUser32.SetWindowPos(TargetWindow.Handle, IntPtr.Zero, 0, 0, WinWidth, WinHeight,
				MUser32.SetWindowPosFlags.SWP_NOMOVE | MUser32.SetWindowPosFlags.SWP_NOACTIVATE);
		}

		private void TopMostCheck() {
			SetWindowTopMost(TargetWindow.Handle, Topmost);
		}

		private void TopLeft() {
			IntPtr hwnd = TargetWindow.Handle;
			if (hwnd == IntPtr.Zero) return;

			IntPtr hmon = MUser32.MonitorFromWindow(hwnd, MUser32.MonitorOptions.MONITOR_DEFAULTTONEAREST);
			MUser32.MONITORINFO mon = MUser32.MONITORINFO.Create();

			if (!MUser32.GetWindowRect(hwnd, out MUser32.RECT wr) ||
				!MUser32.GetClientRect(hwnd, out MUser32.RECT cr) ||
				!MUser32.GetMonitorInfo(hmon, ref mon))
				return;

			SIZE ws = wr.Size;
			SIZE cs = cr.Size;

			int border = (ws.cx - cs.cx) / 2;
			int capbar = (ws.cy - cs.cy) - (ws.cx - cs.cx);

			int nx = mon.rcMonitor.X - border;
			int ny = mon.rcMonitor.Y - (border + capbar);

			if (wr.left == nx && wr.top == ny) {
				nx = mon.rcMonitor.X + 2 - border;
				ny = mon.rcMonitor.Y;
			}

			MUser32.SetWindowPos(hwnd, IntPtr.Zero, nx, ny, 0, 0,
				MUser32.SetWindowPosFlags.SWP_NOSIZE | MUser32.SetWindowPosFlags.SWP_NOACTIVATE);

			RefreshWindowData();
		}

		private void RemoveBorder() {
			IntPtr hwnd = TargetWindow.Handle;
			int style = MUser32.GetWindowLong(hwnd, MUser32.WindowLongIndexFlags.GWL_STYLE);
			style &= unchecked((int)~(MUser32.WindowStyles.WS_CAPTION | MUser32.WindowStyles.WS_THICKFRAME | MUser32.WindowStyles.WS_MINIMIZEBOX |
				MUser32.WindowStyles.WS_MAXIMIZEBOX | MUser32.WindowStyles.WS_SYSMENU));
			MUser32.SetWindowLong(hwnd, MUser32.WindowLongIndexFlags.GWL_STYLE, style);

			style = MUser32.GetWindowLong(hwnd, MUser32.WindowLongIndexFlags.GWL_EXSTYLE);
			style &= unchecked((int)~(MUser32.WindowStylesEx.WS_EX_DLGMODALFRAME | MUser32.WindowStylesEx.WS_EX_CLIENTEDGE |
				MUser32.WindowStylesEx.WS_EX_STATICEDGE));
			MUser32.SetWindowLong(hwnd, MUser32.WindowLongIndexFlags.GWL_EXSTYLE, style);
			RefreshWindowData();
		}

		private void BorderlessFullscreen() {
			IntPtr hwnd = TargetWindow.Handle;
			
			IntPtr hmon = MUser32.MonitorFromWindow(hwnd, MUser32.MonitorOptions.MONITOR_DEFAULTTONEAREST);
			MUser32.MONITORINFO mon = MUser32.MONITORINFO.Create();

			RemoveBorder();

			if (!MUser32.GetWindowRect(hwnd, out MUser32.RECT wr) ||
				!MUser32.GetClientRect(hwnd, out MUser32.RECT cr) ||
				!MUser32.GetMonitorInfo(hmon, ref mon))
				return;

			if (wr.Size == mon.rcMonitor.Size)
				MUser32.SetWindowPos(hwnd, IntPtr.Zero, 0, 0, wr.Width - 1, wr.Height - 1,
					MUser32.SetWindowPosFlags.SWP_NOMOVE | MUser32.SetWindowPosFlags.SWP_NOACTIVATE);

			//SetWindowTopMost(hwnd, true);
			MUser32.SetWindowPos(hwnd, IntPtr.Zero, mon.rcMonitor.X, mon.rcMonitor.Y, mon.rcMonitor.Width, mon.rcMonitor.Height,
				MUser32.SetWindowPosFlags.SWP_NOACTIVATE);

			RefreshWindowData();
		}

		private void RefreshWindowList() {
			WindowList.Clear();
			MUser32.EnumWindows(delegate(IntPtr hwnd, IntPtr lParam) {
				if (hwnd != IntPtr.Zero && MUser32.IsWindow(hwnd) && MUser32.IsWindowVisible(hwnd))
					WindowList.Add(new WindowInfo(hwnd));

				return true;
			}, IntPtr.Zero);
		}

		private void SelectWindow(object param) {
			if (param is WindowInfo win) {
				TargetWindow = win;
				RefreshWindowData();
			}
		}

		#endregion

		#region Helpers

		private static bool GetWindowTopMost(IntPtr hwnd) {
			int style = MUser32.GetWindowLong(hwnd, MUser32.WindowLongIndexFlags.GWL_EXSTYLE);
			return (style & (int)MUser32.WindowStylesEx.WS_EX_TOPMOST) != 0;
		}

		private static void SetWindowTopMost(IntPtr hwnd, bool top) {
			MUser32.SetWindowPos(hwnd, top ? MUser32.HWND_TOPMOST : MUser32.HWND_NOTOPMOST, 0, 0, 0, 0,
				MUser32.SetWindowPosFlags.SWP_NOMOVE | MUser32.SetWindowPosFlags.SWP_NOSIZE | MUser32.SetWindowPosFlags.SWP_NOACTIVATE);
		}

		#endregion

		public Model() {
			windowCheckTimer.Tick += WindowCheck;
			RefreshWindowList();
		}

		private void WindowCheck(object sender, EventArgs e) {
			if (!TargetWindow.IsValid) {
				TargetWindow = null;
				windowCheckTimer.Stop();
				RefreshWindowList();
			}
		}

		private void RefreshWindowData() {
			if (TargetWindow == null) return;
			if (MUser32.GetWindowRect(TargetWindow.Handle, out MUser32.RECT wr)) {
				WindowPosition = wr.Position;
				WindowSize = wr.Size;
			}

			Topmost = GetWindowTopMost(TargetWindow.Handle);
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
