using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Newtonsoft.Json;
using Window_Edit;
using Window_Edit.Annotations;
using WindowEdit.Interop;
using WindowEdit.Properties;
using Xceed.Wpf.Toolkit;

namespace WindowEdit {
	internal class Model : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		private WindowInfo targetWindow;
		private SIZE windowSize;
		private POINT windowPosition;
		private bool topmost;

		private string profileName = "New Profile";

		private readonly DispatcherTimer windowCheckTimer = new DispatcherTimer {
			Interval = TimeSpan.FromSeconds(1)
		};

		#region Properties

		public ObservableCollection<WindowInfo> WindowList { get; } = new ObservableCollection<WindowInfo>();

		public ObservableCollection<WindowProfile> WindowProfiles { get; } = new ObservableCollection<WindowProfile>() {
			new WindowProfile(),
			new WindowProfile(),
			new WindowProfile(),
		};

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


		public string ProfileName {
			get => profileName;
			set {
				if (value == profileName) return;
				profileName = value;
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
		public Command RefreshWindowDataCommand => new Command(RefreshWindowData);
		public ParamCommand SelectWindowCommand => new ParamCommand(SelectWindow);

		public Command CreateProfile => new Command(DoCreateProfile);
		public Command1<WindowProfile> RemoveProfile => new Command1<WindowProfile>(DeleteProfile);
		public Command1<WindowProfile> SelectProfile => new Command1<WindowProfile>(ApplyProfile);

		private void SetPos() {
			User32.SetWindowPos(TargetWindow.Handle, IntPtr.Zero, WinPosX, WinPosY, 0, 0,
				User32.SetWindowPosFlags.SWP_NOSIZE | User32.SetWindowPosFlags.SWP_NOACTIVATE);
		}

		private void SetSize() {
			User32.SetWindowPos(TargetWindow.Handle, IntPtr.Zero, 0, 0, WinWidth, WinHeight,
				User32.SetWindowPosFlags.SWP_NOMOVE | User32.SetWindowPosFlags.SWP_NOACTIVATE);
		}

		private void TopMostCheck() {
			SetWindowTopMost(TargetWindow.Handle, Topmost);
		}

		private void TopLeft() {
			IntPtr hwnd = TargetWindow.Handle;
			if (hwnd == IntPtr.Zero) return;

			IntPtr hmon = User32.MonitorFromWindow(hwnd, User32.MonitorOptions.MONITOR_DEFAULTTONEAREST);
			User32.MONITORINFO mon = User32.MONITORINFO.Create();

			if (!User32.GetWindowRect(hwnd, out User32.RECT wr) ||
				!User32.GetClientRect(hwnd, out User32.RECT cr) ||
				!User32.GetMonitorInfo(hmon, ref mon))
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

			User32.SetWindowPos(hwnd, IntPtr.Zero, nx, ny, 0, 0,
				User32.SetWindowPosFlags.SWP_NOSIZE | User32.SetWindowPosFlags.SWP_NOACTIVATE);

			RefreshWindowData();
		}

		private void RemoveBorder() {
			IntPtr hwnd = TargetWindow.Handle;
			int style = User32.GetWindowLong(hwnd, User32.WindowLongIndexFlags.GWL_STYLE);
			style &= unchecked((int)~(User32.WindowStyles.WS_CAPTION | User32.WindowStyles.WS_THICKFRAME | User32.WindowStyles.WS_MINIMIZEBOX |
				User32.WindowStyles.WS_MAXIMIZEBOX | User32.WindowStyles.WS_SYSMENU));
			User32.SetWindowLong(hwnd, User32.WindowLongIndexFlags.GWL_STYLE, style);

			style = User32.GetWindowLong(hwnd, User32.WindowLongIndexFlags.GWL_EXSTYLE);
			style &= unchecked((int)~(User32.WindowStylesEx.WS_EX_DLGMODALFRAME | User32.WindowStylesEx.WS_EX_CLIENTEDGE |
				User32.WindowStylesEx.WS_EX_STATICEDGE));
			User32.SetWindowLong(hwnd, User32.WindowLongIndexFlags.GWL_EXSTYLE, style);
			RefreshWindowData();
		}

		private void BorderlessFullscreen() {
			IntPtr hwnd = TargetWindow.Handle;
			
			IntPtr hmon = User32.MonitorFromWindow(hwnd, User32.MonitorOptions.MONITOR_DEFAULTTONEAREST);
			User32.MONITORINFO mon = User32.MONITORINFO.Create();

			RemoveBorder();

			if (!User32.GetWindowRect(hwnd, out User32.RECT wr) ||
				!User32.GetClientRect(hwnd, out User32.RECT cr) ||
				!User32.GetMonitorInfo(hmon, ref mon))
				return;

			if (wr.Size == mon.rcMonitor.Size)
				User32.SetWindowPos(hwnd, IntPtr.Zero, 0, 0, wr.Width - 1, wr.Height - 1,
					User32.SetWindowPosFlags.SWP_NOMOVE | User32.SetWindowPosFlags.SWP_NOACTIVATE);

			//SetWindowTopMost(hwnd, true);
			User32.SetWindowPos(hwnd, IntPtr.Zero, mon.rcMonitor.X, mon.rcMonitor.Y, mon.rcMonitor.Width, mon.rcMonitor.Height,
				User32.SetWindowPosFlags.SWP_NOACTIVATE);

			RefreshWindowData();
		}

		private void RefreshWindowList() {
			WindowList.Clear();
			User32.EnumWindows(delegate(IntPtr hwnd, IntPtr lParam) {
				if (hwnd != IntPtr.Zero && User32.IsWindow(hwnd) && User32.IsWindowVisible(hwnd))
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


		private void DoCreateProfile() {
			if (string.IsNullOrEmpty(profileName))
				return;

			WindowProfiles.Add(new WindowProfile() {
				Name = profileName,
				PosX = WinPosX, PosY = WinPosY,
				SizeX = WinWidth, SizeY = WinHeight,
				Topmost = Topmost,
			});
			SaveProfiles();
		}

		private void ApplyProfile(WindowProfile profile) {
			if (profile == null)
				return;

			WinPosX = profile.PosX;
			WinPosY = profile.PosY;
			WinWidth = profile.SizeX;
			WinHeight = profile.SizeY;
			Topmost = profile.Topmost;
			SetPos();
			SetSize();
			TopMostCheck();
		}

		private void DeleteProfile(WindowProfile profile) {

			WindowProfiles.Remove(profile);
			SaveProfiles();
		}

		#endregion

		#region Helpers

		private static bool GetWindowTopMost(IntPtr hwnd) {
			int style = User32.GetWindowLong(hwnd, User32.WindowLongIndexFlags.GWL_EXSTYLE);
			return (style & (int)User32.WindowStylesEx.WS_EX_TOPMOST) != 0;
		}

		private static void SetWindowTopMost(IntPtr hwnd, bool top) {
			User32.SetWindowPos(hwnd, top ? User32.HWND_TOPMOST : User32.HWND_NOTOPMOST, 0, 0, 0, 0,
				User32.SetWindowPosFlags.SWP_NOMOVE | User32.SetWindowPosFlags.SWP_NOSIZE | User32.SetWindowPosFlags.SWP_NOACTIVATE);
		}

		#endregion

		public Model() {
			windowCheckTimer.Tick += WindowCheck;
			RefreshWindowList();
			LoadProfiles();
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
			if (User32.GetWindowRect(TargetWindow.Handle, out User32.RECT wr)) {
				WindowPosition = wr.Position;
				WindowSize = wr.Size;
			}

			Topmost = GetWindowTopMost(TargetWindow.Handle);
		}

		private void LoadProfiles() {
			WindowProfiles.Clear();

			string json = Settings.Default.SavedProfiles;
			if (string.IsNullOrWhiteSpace(json))
				return;

			List<WindowProfile> loadedProfiles;
			try {
				 loadedProfiles = JsonConvert.DeserializeObject<List<WindowProfile>>(json);
			} catch (Exception) {
				/* do nothing */
				return;
			}

			foreach (WindowProfile profile in loadedProfiles) {
				WindowProfiles.Add(profile);
			}
		}

		private void SaveProfiles() {
			string json = JsonConvert.SerializeObject(WindowProfiles);
			Settings.Default.SavedProfiles = json;
			Settings.Default.Save();
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
