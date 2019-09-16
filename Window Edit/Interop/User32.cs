using System;
using System.Runtime.InteropServices;
using System.Text;
using Window_Edit;
using Window_Edit.Annotations;

namespace WindowEdit.Interop {
	public class User32 {
		public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
		public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
		public static readonly IntPtr HWND_TOP = new IntPtr(0);
		public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

		#region Delegates

		/// <summary>
		///     An application-defined callback function used with the
		///     <see cref="M:PInvoke.User32.EnumWindows(PInvoke.User32.WNDENUMPROC,System.IntPtr)" /> or
		///     <see
		///         cref="M:PInvoke.User32.EnumDesktopWindows(PInvoke.User32.SafeDesktopHandle,PInvoke.User32.WNDENUMPROC,System.IntPtr)" />
		///     function.
		/// </summary>
		/// <param name="hwnd">A handle to a top-level window.</param>
		/// <param name="lParam">
		///     The application-defined value given in
		///     <see cref="M:PInvoke.User32.EnumWindows(PInvoke.User32.WNDENUMPROC,System.IntPtr)" /> or
		///     <see
		///         cref="M:PInvoke.User32.EnumDesktopWindows(PInvoke.User32.SafeDesktopHandle,PInvoke.User32.WNDENUMPROC,System.IntPtr)" />
		///     .
		/// </param>
		/// <returns>To continue enumeration, the callback function must return TRUE; to stop enumeration, it must return FALSE.</returns>
		/// <remarks>
		///     An application must register this callback function by passing its address to
		///     <see cref="M:PInvoke.User32.EnumWindows(PInvoke.User32.WNDENUMPROC,System.IntPtr)" /> or
		///     <see
		///         cref="M:PInvoke.User32.EnumDesktopWindows(PInvoke.User32.SafeDesktopHandle,PInvoke.User32.WNDENUMPROC,System.IntPtr)" />
		///     .
		///     The callback function can call SetLastError to set an error code for the caller to retrieve by calling
		///     GetLastError.
		/// </remarks>
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public delegate bool WNDENUMPROC(IntPtr hwnd, IntPtr lParam);

		#endregion

		#region ChildWindowFromPointExFlags enum

		/// <summary>
		///     For use with
		///     <see
		///         cref="M:PInvoke.User32.ChildWindowFromPointEx(System.IntPtr,PInvoke.POINT,PInvoke.User32.ChildWindowFromPointExFlags)" />
		/// </summary>
		[Flags]
		public enum ChildWindowFromPointExFlags {
			CWP_ALL = 0,
			CWP_SKIPINVISIBLE = 1,
			CWP_SKIPDISABLED = 2,
			CWP_SKIPTRANSPARENT = 4,
		}

		#endregion

		#region GetAncestorFlags enum

		/// <summary>
		///     The ancestor to be retrieved by
		///     <see cref="M:PInvoke.User32.GetAncestor(System.IntPtr,PInvoke.User32.GetAncestorFlags)" />.
		/// </summary>
		public enum GetAncestorFlags {
			GA_PARENT = 1,
			GA_ROOT = 2,
			GA_ROOTOWNER = 3,
		}

		#endregion

		#region GetNextWindowCommands enum

		/// <summary>
		///     The commands that can be used as arguments to
		///     <see cref="M:PInvoke.User32.GetNextWindow(System.IntPtr,PInvoke.User32.GetNextWindowCommands)" />.
		/// </summary>
		public enum GetNextWindowCommands {
			GW_HWNDNEXT = 2,
			GW_HWNDPREV = 3,
		}

		#endregion

		#region GetWindowCommands enum

		/// <summary>
		///     The commands that can be used as arguments to
		///     <see cref="M:PInvoke.User32.GetWindow(System.IntPtr,PInvoke.User32.GetWindowCommands)" />.
		/// </summary>
		public enum GetWindowCommands {
			GW_HWNDFIRST,
			GW_HWNDLAST,
			GW_HWNDNEXT,
			GW_HWNDPREV,
			GW_OWNER,
			GW_CHILD,
			GW_ENABLEDPOPUP,
		}

		#endregion

		#region MonitorOptions enum

		public enum MonitorOptions : uint {
			MONITOR_DEFAULTTONULL,
			MONITOR_DEFAULTTOPRIMARY,
			MONITOR_DEFAULTTONEAREST,
		}

		#endregion

		#region SetWindowLongFlags enum

		[Flags]
		public enum SetWindowLongFlags : uint {
			WS_OVERLAPPED = 0,
			WS_POPUP = 2147483648, // 0x80000000
			WS_CHILD = 1073741824, // 0x40000000
			WS_MINIMIZE = 536870912, // 0x20000000
			WS_VISIBLE = 268435456, // 0x10000000
			WS_DISABLED = 134217728, // 0x08000000
			WS_CLIPSIBLINGS = 67108864, // 0x04000000
			WS_CLIPCHILDREN = 33554432, // 0x02000000
			WS_MAXIMIZE = 16777216, // 0x01000000
			WS_CAPTION = 12582912, // 0x00C00000
			WS_BORDER = 8388608, // 0x00800000
			WS_DLGFRAME = 4194304, // 0x00400000
			WS_VSCROLL = 2097152, // 0x00200000
			WS_HSCROLL = 1048576, // 0x00100000
			WS_SYSMENU = 524288, // 0x00080000
			WS_THICKFRAME = 262144, // 0x00040000
			WS_GROUP = 131072, // 0x00020000
			WS_TABSTOP = 65536, // 0x00010000
			WS_MINIMIZEBOX = WS_GROUP, // 0x00020000
			WS_MAXIMIZEBOX = WS_TABSTOP, // 0x00010000
			WS_TILED = 0,
			WS_ICONIC = WS_MINIMIZE, // 0x20000000
			WS_SIZEBOX = WS_THICKFRAME, // 0x00040000
			WS_EX_DLGMODALFRAME = 1,
			WS_EX_NOPARENTNOTIFY = 4,
			WS_EX_TOPMOST = 8,
			WS_EX_ACCEPTFILES = 16, // 0x00000010
			WS_EX_TRANSPARENT = 32, // 0x00000020
			WS_EX_MDICHILD = 64, // 0x00000040
			WS_EX_TOOLWINDOW = 128, // 0x00000080
			WS_EX_WINDOWEDGE = 256, // 0x00000100
			WS_EX_CLIENTEDGE = 512, // 0x00000200
			WS_EX_CONTEXTHELP = 1024, // 0x00000400
			WS_EX_RIGHT = 4096, // 0x00001000
			WS_EX_LEFT = 0,
			WS_EX_RTLREADING = 8192, // 0x00002000
			WS_EX_LTRREADING = 0,
			WS_EX_LEFTSCROLLBAR = 16384, // 0x00004000
			WS_EX_RIGHTSCROLLBAR = 0,
			WS_EX_CONTROLPARENT = WS_MAXIMIZEBOX, // 0x00010000
			WS_EX_STATICEDGE = WS_MINIMIZEBOX, // 0x00020000
			WS_EX_APPWINDOW = WS_SIZEBOX, // 0x00040000
			WS_EX_OVERLAPPEDWINDOW = WS_EX_CLIENTEDGE | WS_EX_WINDOWEDGE, // 0x00000300
			WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST, // 0x00000188
			WS_EX_LAYERED = WS_SYSMENU, // 0x00080000
			WS_EX_NOINHERITLAYOUT = WS_HSCROLL, // 0x00100000
			WS_EX_LAYOUTRTL = WS_DLGFRAME, // 0x00400000
			WS_EX_COMPOSITED = WS_CLIPCHILDREN, // 0x02000000
			WS_EX_NOACTIVATE = WS_DISABLED, // 0x08000000
		}

		#endregion

		#region SetWindowPosFlags enum

		[Flags]
		public enum SetWindowPosFlags : uint {
			SWP_ASYNCWINDOWPOS = 16384, // 0x00004000
			SWP_DEFERERASE = 8192, // 0x00002000
			SWP_DRAWFRAME = 32, // 0x00000020
			SWP_FRAMECHANGED = SWP_DRAWFRAME, // 0x00000020
			SWP_HIDEWINDOW = 128, // 0x00000080
			SWP_NOACTIVATE = 16, // 0x00000010
			SWP_NOCOPYBITS = 256, // 0x00000100
			SWP_NOMOVE = 2,
			SWP_NOOWNERZORDER = 512, // 0x00000200
			SWP_NOREDRAW = 8,
			SWP_NOREPOSITION = SWP_NOOWNERZORDER, // 0x00000200
			SWP_NOSENDCHANGING = 1024, // 0x00000400
			SWP_NOSIZE = 1,
			SWP_NOZORDER = 4,
			SWP_SHOWWINDOW = 64, // 0x00000040
		}

		#endregion

		#region SysCommands enum

		/// <summary>
		///     wParam options for <see cref="F:PInvoke.User32.WindowMessage.WM_SYSCOMMAND" />
		/// </summary>
		public enum SysCommands {
			SCF_ISSECURE = 1,
			SC_SIZE = 61440, // 0x0000F000
			SC_MOVE = 61456, // 0x0000F010
			SC_MINIMIZE = 61472, // 0x0000F020
			SC_MAXIMIZE = 61488, // 0x0000F030
			SC_NEXTWINDOW = 61504, // 0x0000F040
			SC_PREVWINDOW = 61520, // 0x0000F050
			SC_CLOSE = 61536, // 0x0000F060
			SC_VSCROLL = 61552, // 0x0000F070
			SC_HSCROLL = 61568, // 0x0000F080
			SC_MOUSEMENU = 61584, // 0x0000F090
			SC_KEYMENU = 61696, // 0x0000F100
			SC_RESTORE = 61728, // 0x0000F120
			SC_TASKLIST = 61744, // 0x0000F130
			SC_SCREENSAVE = 61760, // 0x0000F140
			SC_HOTKEY = 61776, // 0x0000F150
			SC_DEFAULT = 61792, // 0x0000F160
			SC_MONITORPOWER = 61808, // 0x0000F170
			SC_CONTEXTHELP = 61824, // 0x0000F180
		}

		#endregion

		#region SystemMetric enum

		/// <summary>
		///     Flags used in the <see cref="M:PInvoke.User32.GetSystemMetrics(PInvoke.User32.SystemMetric)" /> function
		/// </summary>
		public enum SystemMetric {
			SM_CXSCREEN = 0,
			SM_CYSCREEN = 1,
			SM_CXVSCROLL = 2,
			SM_CYHSCROLL = 3,
			SM_CYCAPTION = 4,
			SM_CXBORDER = 5,
			SM_CYBORDER = 6,
			SM_CXDLGFRAME = 7,
			SM_CXFIXEDFRAME = 7,
			SM_CYDLGFRAME = 8,
			SM_CYFIXEDFRAME = 8,
			SM_CYVTHUMB = 9,
			SM_CXHTHUMB = 10, // 0x0000000A
			SM_CXICON = 11, // 0x0000000B
			SM_CYICON = 12, // 0x0000000C
			SM_CXCURSOR = 13, // 0x0000000D
			SM_CYCURSOR = 14, // 0x0000000E
			SM_CYMENU = 15, // 0x0000000F
			SM_CXFULLSCREEN = 16, // 0x00000010
			SM_CYFULLSCREEN = 17, // 0x00000011
			SM_CYKANJIWINDOW = 18, // 0x00000012
			SM_MOUSEPRESENT = 19, // 0x00000013
			SM_CYVSCROLL = 20, // 0x00000014
			SM_CXHSCROLL = 21, // 0x00000015
			SM_DEBUG = 22, // 0x00000016
			SM_SWAPBUTTON = 23, // 0x00000017
			SM_CXMIN = 28, // 0x0000001C
			SM_CYMIN = 29, // 0x0000001D
			SM_CXSIZE = 30, // 0x0000001E
			SM_CYSIZE = 31, // 0x0000001F
			SM_CXFRAME = 32, // 0x00000020
			SM_CXSIZEFRAME = 32, // 0x00000020
			SM_CYFRAME = 33, // 0x00000021
			SM_CYSIZEFRAME = 33, // 0x00000021
			SM_CXMINTRACK = 34, // 0x00000022
			SM_CYMINTRACK = 35, // 0x00000023
			SM_CXDOUBLECLK = 36, // 0x00000024
			SM_CYDOUBLECLK = 37, // 0x00000025
			SM_CXICONSPACING = 38, // 0x00000026
			SM_CYICONSPACING = 39, // 0x00000027
			SM_MENUDROPALIGNMENT = 40, // 0x00000028
			SM_PENWINDOWS = 41, // 0x00000029
			SM_DBCSENABLED = 42, // 0x0000002A
			SM_CMOUSEBUTTONS = 43, // 0x0000002B
			SM_SECURE = 44, // 0x0000002C
			SM_CXEDGE = 45, // 0x0000002D
			SM_CYEDGE = 46, // 0x0000002E
			SM_CXMINSPACING = 47, // 0x0000002F
			SM_CYMINSPACING = 48, // 0x00000030
			SM_CXSMICON = 49, // 0x00000031
			SM_CYSMICON = 50, // 0x00000032
			SM_CYSMCAPTION = 51, // 0x00000033
			SM_CXSMSIZE = 52, // 0x00000034
			SM_CYSMSIZE = 53, // 0x00000035
			SM_CXMENUSIZE = 54, // 0x00000036
			SM_CYMENUSIZE = 55, // 0x00000037
			SM_ARRANGE = 56, // 0x00000038
			SM_CXMINIMIZED = 57, // 0x00000039
			SM_CYMINIMIZED = 58, // 0x0000003A
			SM_CXMAXTRACK = 59, // 0x0000003B
			SM_CYMAXTRACK = 60, // 0x0000003C
			SM_CXMAXIMIZED = 61, // 0x0000003D
			SM_CYMAXIMIZED = 62, // 0x0000003E
			SM_NETWORK = 63, // 0x0000003F
			SM_CLEANBOOT = 67, // 0x00000043
			SM_CXDRAG = 68, // 0x00000044
			SM_CYDRAG = 69, // 0x00000045
			SM_SHOWSOUNDS = 70, // 0x00000046
			SM_CXMENUCHECK = 71, // 0x00000047
			SM_CYMENUCHECK = 72, // 0x00000048
			SM_SLOWMACHINE = 73, // 0x00000049
			SM_MIDEASTENABLED = 74, // 0x0000004A
			SM_MOUSEWHEELPRESENT = 75, // 0x0000004B
			SM_XVIRTUALSCREEN = 76, // 0x0000004C
			SM_YVIRTUALSCREEN = 77, // 0x0000004D
			SM_CXVIRTUALSCREEN = 78, // 0x0000004E
			SM_CYVIRTUALSCREEN = 79, // 0x0000004F
			SM_CMONITORS = 80, // 0x00000050
			SM_SAMEDISPLAYFORMAT = 81, // 0x00000051
			SM_IMMENABLED = 82, // 0x00000052
			SM_CXFOCUSBORDER = 83, // 0x00000053
			SM_CYFOCUSBORDER = 84, // 0x00000054
			SM_TABLETPC = 86, // 0x00000056
			SM_MEDIACENTER = 87, // 0x00000057
			SM_STARTER = 88, // 0x00000058
			SM_SERVERR2 = 89, // 0x00000059
			SM_MOUSEHORIZONTALWHEELPRESENT = 91, // 0x0000005B
			SM_CXPADDEDBORDER = 92, // 0x0000005C
			SM_DIGITIZER = 94, // 0x0000005E
			SM_MAXIMUMTOUCHES = 95, // 0x0000005F
			SM_REMOTESESSION = 4096, // 0x00001000
			SM_SHUTTINGDOWN = 8192, // 0x00002000
			SM_REMOTECONTROL = 8193, // 0x00002001
		}

		#endregion

		#region WindowLongIndexFlags enum

		[Flags]
		public enum WindowLongIndexFlags {
			GWL_EXSTYLE = -20, // -0x00000014
			GWLP_HINSTANCE = -6,
			GWLP_HWNDPARENT = -8,
			GWL_ID = -12, // -0x0000000C
			GWLP_ID = GWL_ID, // -0x0000000C
			GWL_STYLE = -16, // -0x00000010
			GWL_USERDATA = -21, // -0x00000015
			GWLP_USERDATA = GWL_USERDATA, // -0x00000015
			GWL_WNDPROC = -4,
			GWLP_WNDPROC = GWL_WNDPROC, // -0x00000004
			DWLP_USER = 8,
			DWLP_MSGRESULT = 0,
			DWLP_DLGPROC = 4,
		}

		#endregion

		#region WindowMessage enum

		public enum WindowMessage {
			WM_NULL = 0,
			WM_CREATE = 1,
			WM_HSHELL_WINDOWCREATED = 1,
			WM_DESTROY = 2,
			WM_HSHELL_WINDOWDESTROYED = 2,
			WM_HSHELL_ACTIVATESHELLWINDOW = 3,
			WM_MOVE = 3,
			WM_HSHELL_WINDOWACTIVATED = 4,
			WM_HSHELL_GETMINRECT = 5,
			WM_SIZE = 5,
			WM_ACTIVATE = 6,
			WM_HSHELL_REDRAW = 6,
			WM_HSHELL_TASKMAN = 7,
			WM_SETFOCUS = 7,
			WM_HSHELL_LANGUAGE = 8,
			WM_KILLFOCUS = 8,
			WM_ENABLE = 10, // 0x0000000A
			WM_HSHELL_ACCESSIBILITYSTATE = 11, // 0x0000000B
			WM_SETREDRAW = 11, // 0x0000000B
			WM_HSHELL_APPCOMMAND = 12, // 0x0000000C
			WM_SETTEXT = 12, // 0x0000000C
			WM_GETTEXT = 13, // 0x0000000D
			WM_HSHELL_WINDOWREPLACED = 13, // 0x0000000D
			WM_GETTEXTLENGTH = 14, // 0x0000000E
			WM_PAINT = 15, // 0x0000000F
			WM_CLOSE = 16, // 0x00000010
			WM_QUERYENDSESSION = 17, // 0x00000011
			WM_QUIT = 18, // 0x00000012
			WM_QUERYOPEN = 19, // 0x00000013
			WM_ERASEBKGND = 20, // 0x00000014
			WM_SYSCOLORCHANGE = 21, // 0x00000015
			WM_ENDSESSION = 22, // 0x00000016
			WM_SHOWWINDOW = 24, // 0x00000018
			WM_SETTINGCHANGE = 26, // 0x0000001A
			WM_WININICHANGE = 26, // 0x0000001A
			WM_DEVMODECHANGE = 27, // 0x0000001B
			WM_ACTIVATEAPP = 28, // 0x0000001C
			WM_FONTCHANGE = 29, // 0x0000001D
			WM_TIMECHANGE = 30, // 0x0000001E
			WM_CANCELMODE = 31, // 0x0000001F
			WM_SETCURSOR = 32, // 0x00000020
			WM_MOUSEACTIVATE = 33, // 0x00000021
			WM_CHILDACTIVATE = 34, // 0x00000022
			WM_QUEUESYNC = 35, // 0x00000023
			WM_GETMINMAXINFO = 36, // 0x00000024
			WM_PAINTICON = 38, // 0x00000026
			WM_ICONERASEBKGND = 39, // 0x00000027
			WM_NEXTDLGCTL = 40, // 0x00000028
			WM_SPOOLERSTATUS = 42, // 0x0000002A
			WM_DRAWITEM = 43, // 0x0000002B
			WM_MEASUREITEM = 44, // 0x0000002C
			WM_DELETEITEM = 45, // 0x0000002D
			WM_VKEYTOITEM = 46, // 0x0000002E
			WM_CHARTOITEM = 47, // 0x0000002F
			WM_SETFONT = 48, // 0x00000030
			WM_GETFONT = 49, // 0x00000031
			WM_SETHOTKEY = 50, // 0x00000032
			WM_GETHOTKEY = 51, // 0x00000033
			WM_QUERYDRAGICON = 55, // 0x00000037
			WM_COMPAREITEM = 57, // 0x00000039
			WM_GETOBJECT = 61, // 0x0000003D
			WM_COMPACTING = 65, // 0x00000041
			[Obsolete] WM_COMMNOTIFY = 68, // 0x00000044
			WM_WINDOWPOSCHANGING = 70, // 0x00000046
			WM_WINDOWPOSCHANGED = 71, // 0x00000047
			[Obsolete] WM_POWER = 72, // 0x00000048
			WM_COPYDATA = 74, // 0x0000004A
			WM_CANCELJOURNAL = 75, // 0x0000004B
			WM_NOTIFY = 78, // 0x0000004E
			WM_INPUTLANGCHANGEREQUEST = 80, // 0x00000050
			WM_INPUTLANGCHANGE = 81, // 0x00000051
			WM_TCARD = 82, // 0x00000052
			WM_HELP = 83, // 0x00000053
			WM_USERCHANGED = 84, // 0x00000054
			WM_NOTIFYFORMAT = 85, // 0x00000055
			WM_CONTEXTMENU = 123, // 0x0000007B
			WM_STYLECHANGING = 124, // 0x0000007C
			WM_STYLECHANGED = 125, // 0x0000007D
			WM_DISPLAYCHANGE = 126, // 0x0000007E
			WM_GETICON = 127, // 0x0000007F
			WM_SETICON = 128, // 0x00000080
			WM_NCCREATE = 129, // 0x00000081
			WM_NCDESTROY = 130, // 0x00000082
			WM_NCCALCSIZE = 131, // 0x00000083
			WM_NCHITTEST = 132, // 0x00000084
			WM_NCPAINT = 133, // 0x00000085
			WM_NCACTIVATE = 134, // 0x00000086
			WM_GETDLGCODE = 135, // 0x00000087
			WM_SYNCPAINT = 136, // 0x00000088
			WM_NCMOUSEMOVE = 160, // 0x000000A0
			WM_NCLBUTTONDOWN = 161, // 0x000000A1
			WM_NCLBUTTONUP = 162, // 0x000000A2
			WM_NCLBUTTONDBLCLK = 163, // 0x000000A3
			WM_NCRBUTTONDOWN = 164, // 0x000000A4
			WM_NCRBUTTONUP = 165, // 0x000000A5
			WM_NCRBUTTONDBLCLK = 166, // 0x000000A6
			WM_NCMBUTTONDOWN = 167, // 0x000000A7
			WM_NCMBUTTONUP = 168, // 0x000000A8
			WM_NCMBUTTONDBLCLK = 169, // 0x000000A9
			WM_NCXBUTTONDOWN = 171, // 0x000000AB
			WM_NCXBUTTONUP = 172, // 0x000000AC
			WM_NCXBUTTONDBLCLK = 173, // 0x000000AD
			WM_BM_CLICK = 245, // 0x000000F5
			WM_INPUT_DEVICE_CHANGE = 254, // 0x000000FE
			WM_INPUT = 255, // 0x000000FF
			WM_KEYDOWN = 256, // 0x00000100
			WM_KEYFIRST = 256, // 0x00000100
			WM_KEYUP = 257, // 0x00000101
			WM_CHAR = 258, // 0x00000102
			WM_DEADCHAR = 259, // 0x00000103
			WM_SYSKEYDOWN = 260, // 0x00000104
			WM_SYSKEYUP = 261, // 0x00000105
			WM_SYSCHAR = 262, // 0x00000106
			WM_SYSDEADCHAR = 263, // 0x00000107
			WM_KEYLAST = 265, // 0x00000109
			WM_UNICHAR = 265, // 0x00000109
			WM_IME_STARTCOMPOSITION = 269, // 0x0000010D
			WM_IME_ENDCOMPOSITION = 270, // 0x0000010E
			WM_IME_COMPOSITION = 271, // 0x0000010F
			WM_IME_KEYLAST = 271, // 0x0000010F
			WM_INITDIALOG = 272, // 0x00000110
			WM_COMMAND = 273, // 0x00000111
			WM_SYSCOMMAND = 274, // 0x00000112
			WM_TIMER = 275, // 0x00000113
			WM_HSCROLL = 276, // 0x00000114
			WM_VSCROLL = 277, // 0x00000115
			WM_INITMENU = 278, // 0x00000116
			WM_INITMENUPOPUP = 279, // 0x00000117
			WM_SYSTIMER = 280, // 0x00000118
			WM_MENUSELECT = 287, // 0x0000011F
			WM_MENUCHAR = 288, // 0x00000120
			WM_ENTERIDLE = 289, // 0x00000121
			WM_MENURBUTTONUP = 290, // 0x00000122
			WM_MENUDRAG = 291, // 0x00000123
			WM_MENUGETOBJECT = 292, // 0x00000124
			WM_UNINITMENUPOPUP = 293, // 0x00000125
			WM_MENUCOMMAND = 294, // 0x00000126
			WM_CHANGEUISTATE = 295, // 0x00000127
			WM_UPDATEUISTATE = 296, // 0x00000128
			WM_QUERYUISTATE = 297, // 0x00000129
			WM_CTLCOLORMSGBOX = 306, // 0x00000132
			WM_CTLCOLOREDIT = 307, // 0x00000133
			WM_CTLCOLORLISTBOX = 308, // 0x00000134
			WM_CTLCOLORBTN = 309, // 0x00000135
			WM_CTLCOLORDLG = 310, // 0x00000136
			WM_CTLCOLORSCROLLBAR = 311, // 0x00000137
			WM_CTLCOLORSTATIC = 312, // 0x00000138
			WM_MOUSEFIRST = 512, // 0x00000200
			WM_MOUSEMOVE = 512, // 0x00000200
			WM_LBUTTONDOWN = 513, // 0x00000201
			WM_LBUTTONUP = 514, // 0x00000202
			WM_LBUTTONDBLCLK = 515, // 0x00000203
			WM_RBUTTONDOWN = 516, // 0x00000204
			WM_RBUTTONUP = 517, // 0x00000205
			WM_RBUTTONDBLCLK = 518, // 0x00000206
			WM_MBUTTONDOWN = 519, // 0x00000207
			WM_MBUTTONUP = 520, // 0x00000208
			WM_MBUTTONDBLCLK = 521, // 0x00000209
			WM_MOUSEWHEEL = 522, // 0x0000020A
			WM_XBUTTONDOWN = 523, // 0x0000020B
			WM_XBUTTONUP = 524, // 0x0000020C
			WM_XBUTTONDBLCLK = 525, // 0x0000020D
			WM_MOUSEHWHEEL = 526, // 0x0000020E
			WM_MOUSELAST = 526, // 0x0000020E
			WM_PARENTNOTIFY = 528, // 0x00000210
			WM_ENTERMENULOOP = 529, // 0x00000211
			WM_EXITMENULOOP = 530, // 0x00000212
			WM_NEXTMENU = 531, // 0x00000213
			WM_SIZING = 532, // 0x00000214
			WM_CAPTURECHANGED = 533, // 0x00000215
			WM_MOVING = 534, // 0x00000216
			WM_POWERBROADCAST = 536, // 0x00000218
			WM_DEVICECHANGE = 537, // 0x00000219
			WM_MDICREATE = 544, // 0x00000220
			WM_MDIDESTROY = 545, // 0x00000221
			WM_MDIACTIVATE = 546, // 0x00000222
			WM_MDIRESTORE = 547, // 0x00000223
			WM_MDINEXT = 548, // 0x00000224
			WM_MDIMAXIMIZE = 549, // 0x00000225
			WM_MDITILE = 550, // 0x00000226
			WM_MDICASCADE = 551, // 0x00000227
			WM_MDIICONARRANGE = 552, // 0x00000228
			WM_MDIGETACTIVE = 553, // 0x00000229
			WM_MDISETMENU = 560, // 0x00000230
			WM_ENTERSIZEMOVE = 561, // 0x00000231
			WM_EXITSIZEMOVE = 562, // 0x00000232
			WM_DROPFILES = 563, // 0x00000233
			WM_MDIREFRESHMENU = 564, // 0x00000234
			WM_IME_SETCONTEXT = 641, // 0x00000281
			WM_IME_NOTIFY = 642, // 0x00000282
			WM_IME_CONTROL = 643, // 0x00000283
			WM_IME_COMPOSITIONFULL = 644, // 0x00000284
			WM_IME_SELECT = 645, // 0x00000285
			WM_IME_CHAR = 646, // 0x00000286
			WM_IME_REQUEST = 648, // 0x00000288
			WM_IME_KEYDOWN = 656, // 0x00000290
			WM_IME_KEYUP = 657, // 0x00000291
			WM_NCMOUSEHOVER = 672, // 0x000002A0
			WM_MOUSEHOVER = 673, // 0x000002A1
			WM_NCMOUSELEAVE = 674, // 0x000002A2
			WM_MOUSELEAVE = 675, // 0x000002A3
			WM_WTSSESSION_CHANGE = 689, // 0x000002B1
			WM_TABLET_FIRST = 704, // 0x000002C0
			WM_TABLET_LAST = 735, // 0x000002DF
			WM_DPICHANGED = 736, // 0x000002E0
			WM_DPICHANGED_BEFOREPARENT = 738, // 0x000002E2
			WM_DPICHANGED_AFTERPARENT = 739, // 0x000002E3
			WM_GETDPISCALEDSIZE = 740, // 0x000002E4
			WM_CUT = 768, // 0x00000300
			WM_COPY = 769, // 0x00000301
			WM_PASTE = 770, // 0x00000302
			WM_CLEAR = 771, // 0x00000303
			WM_UNDO = 772, // 0x00000304
			WM_RENDERFORMAT = 773, // 0x00000305
			WM_RENDERALLFORMATS = 774, // 0x00000306
			WM_DESTROYCLIPBOARD = 775, // 0x00000307
			WM_DRAWCLIPBOARD = 776, // 0x00000308
			WM_PAINTCLIPBOARD = 777, // 0x00000309
			WM_VSCROLLCLIPBOARD = 778, // 0x0000030A
			WM_SIZECLIPBOARD = 779, // 0x0000030B
			WM_ASKCBFORMATNAME = 780, // 0x0000030C
			WM_CHANGECBCHAIN = 781, // 0x0000030D
			WM_HSCROLLCLIPBOARD = 782, // 0x0000030E
			WM_QUERYNEWPALETTE = 783, // 0x0000030F
			WM_PALETTEISCHANGING = 784, // 0x00000310
			WM_PALETTECHANGED = 785, // 0x00000311
			WM_HOTKEY = 786, // 0x00000312
			WM_PRINT = 791, // 0x00000317
			WM_PRINTCLIENT = 792, // 0x00000318
			WM_APPCOMMAND = 793, // 0x00000319
			WM_THEMECHANGED = 794, // 0x0000031A
			WM_CLIPBOARDUPDATE = 797, // 0x0000031D
			WM_DWMCOMPOSITIONCHANGED = 798, // 0x0000031E
			WM_DWMNCRENDERINGCHANGED = 799, // 0x0000031F
			WM_DWMCOLORIZATIONCOLORCHANGED = 800, // 0x00000320
			WM_DWMWINDOWMAXIMIZEDCHANGE = 801, // 0x00000321
			WM_GETTITLEBARINFOEX = 831, // 0x0000033F
			WM_HANDHELDFIRST = 856, // 0x00000358
			WM_HANDHELDLAST = 863, // 0x0000035F
			WM_AFXFIRST = 864, // 0x00000360
			WM_AFXLAST = 895, // 0x0000037F
			WM_PENWINFIRST = 896, // 0x00000380
			WM_PENWINLAST = 911, // 0x0000038F
			WM_USER = 1024, // 0x00000400
			WM_CPL_LAUNCH = 5120, // 0x00001400
			WM_CPL_LAUNCHED = 5121, // 0x00001401
			WM_APP = 32768, // 0x00008000
		}

		#endregion

		#region WindowShowStyle enum

		/// <summary>
		///     Enumeration of the different ways of showing a window using
		///     ShowWindow
		/// </summary>
		public enum WindowShowStyle : uint {
			SW_HIDE = 0,
			SW_SHOWNORMAL = 1,
			SW_SHOWMINIMIZED = 2,
			SW_MAXIMIZE = 3,
			SW_SHOWMAXIMIZED = 3,
			SW_SHOWNOACTIVATE = 4,
			SW_SHOW = 5,
			SW_MINIMIZE = 6,
			SW_SHOWMINNOACTIVE = 7,
			SW_SHOWNA = 8,
			SW_RESTORE = 9,
			SW_SHOWDEFAULT = 10, // 0x0000000A
			SW_FORCEMINIMIZE = 11, // 0x0000000B
		}

		#endregion

		#region WindowStyles enum

		/// <summary>
		///     Window Styles. The following styles can be specified wherever a window style is required.
		///     After the control has been created, these styles cannot be modified, except as noted.
		/// </summary>
		[Flags]
		public enum WindowStyles : uint {
			WS_BORDER = 8388608, // 0x00800000
			WS_CAPTION = 12582912, // 0x00C00000
			WS_CHILD = 1073741824, // 0x40000000
			WS_CLIPCHILDREN = 33554432, // 0x02000000
			WS_CLIPSIBLINGS = 67108864, // 0x04000000
			WS_DISABLED = 134217728, // 0x08000000
			WS_DLGFRAME = 4194304, // 0x00400000
			WS_GROUP = 131072, // 0x00020000
			WS_HSCROLL = 1048576, // 0x00100000
			WS_MAXIMIZE = 16777216, // 0x01000000
			WS_MAXIMIZEBOX = 65536, // 0x00010000
			WS_MINIMIZE = 536870912, // 0x20000000
			WS_MINIMIZEBOX = WS_GROUP, // 0x00020000
			WS_OVERLAPPED = 0,
			WS_OVERLAPPEDWINDOW = 13565952, // 0x00CF0000
			WS_POPUP = 2147483648, // 0x80000000
			WS_POPUPWINDOW = 2156396544, // 0x80880000
			WS_SIZEBOX = 262144, // 0x00040000
			WS_THICKFRAME = WS_SIZEBOX, // 0x00040000
			WS_SYSMENU = 524288, // 0x00080000
			WS_TABSTOP = WS_MAXIMIZEBOX, // 0x00010000
			WS_VISIBLE = 268435456, // 0x10000000
			WS_VSCROLL = 2097152, // 0x00200000
		}

		#endregion

		#region WindowStylesEx enum

		[Flags]
		public enum WindowStylesEx : uint {
			WS_EX_ACCEPTFILES = 16, // 0x00000010
			WS_EX_APPWINDOW = 262144, // 0x00040000
			WS_EX_CLIENTEDGE = 512, // 0x00000200
			WS_EX_COMPOSITED = 33554432, // 0x02000000
			WS_EX_CONTEXTHELP = 1024, // 0x00000400
			WS_EX_CONTROLPARENT = 65536, // 0x00010000
			WS_EX_DLGMODALFRAME = 1,
			WS_EX_LAYERED = 524288, // 0x00080000
			WS_EX_LAYOUTRTL = 4194304, // 0x00400000
			WS_EX_LEFT = 0,
			WS_EX_LEFTSCROLLBAR = 16384, // 0x00004000
			WS_EX_LTRREADING = 0,
			WS_EX_MDICHILD = 64, // 0x00000040
			WS_EX_NOACTIVATE = 134217728, // 0x08000000
			WS_EX_NOINHERITLAYOUT = 1048576, // 0x00100000
			WS_EX_NOPARENTNOTIFY = 4,
			WS_EX_OVERLAPPEDWINDOW = 768, // 0x00000300
			WS_EX_PALETTEWINDOW = 392, // 0x00000188
			WS_EX_RIGHT = 4096, // 0x00001000
			WS_EX_RIGHTSCROLLBAR = 0,
			WS_EX_RTLREADING = 8192, // 0x00002000
			WS_EX_STATICEDGE = 131072, // 0x00020000
			WS_EX_TOOLWINDOW = 128, // 0x00000080
			WS_EX_TOPMOST = 8,
			WS_EX_TRANSPARENT = 32, // 0x00000020
			WS_EX_WINDOWEDGE = 256, // 0x00000100
		}

		#endregion

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, WindowLongIndexFlags nIndex);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int SetWindowLong(IntPtr hWnd, WindowLongIndexFlags nIndex,
		                                       int dwNewLong);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		[CanBeNull]
		public static string GetWindowText(IntPtr hwnd) {
			int length = GetWindowTextLength(hwnd);
			StringBuilder sb = new StringBuilder(length + 1);
			return GetWindowText(hwnd, sb, sb.Capacity) != 0 ? sb.ToString() : null;
		}

		/// <summary>
		///     Retrieves the identifier of the thread that created the specified window and, optionally, the identifier of the
		///     process that created the window.
		/// </summary>
		/// <param name="hWnd">A handle to the window. </param>
		/// <param name="lpdwProcessId">
		///     A pointer to a variable that receives the process identifier. If this parameter is not
		///     NULL, GetWindowThreadProcessId copies the identifier of the process to the variable; otherwise, it does not.
		/// </param>
		/// <returns>The return value is the identifier of the thread that created the window. </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		/// <summary>
		///     Retrieves the coordinates of a window's client area. The client coordinates specify the upper-left and lower-right
		///     corners of the client area. Because client coordinates are relative to the upper-left corner of a window's client
		///     area, the coordinates of the upper-left corner are (0,0).
		/// </summary>
		/// <param name="hWnd">A handle to the window whose client coordinates are to be retrieved.</param>
		/// <param name="lpRect">
		///     A pointer to a RECT structure that receives the client coordinates. The left and top members are
		///     zero. The right and bottom members contain the width and height of the window.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     If the function fails, the return value is zero.To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool GetCursorPos(out POINT lpPoint);

		/// <summary>
		///     Retrieves a handle to the foreground window (the window with which the user is currently
		///     working). The system assigns a slightly higher priority to the thread that creates the
		///     foreground window than it does to other threads.
		///     <para>
		///         See https://msdn.microsoft.com/en-us/library/windows/desktop/ms633505%28v=vs.85%29.aspx
		///         for more information.
		///     </para>
		/// </summary>
		/// <returns>
		///     C++ ( Type: Type: HWND ) <br /> The return value is a handle to the foreground window. The
		///     foreground window can be NULL in certain circumstances, such as when a window is losing activation.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetForegroundWindow();

		/// <summary>
		///     Changes the size, position, and Z order of a child, pop-up, or top-level window. These
		///     windows are ordered according to their appearance on the screen. The topmost window
		///     receives the highest rank and is the first window in the Z order.
		///     <para>
		///         See https://msdn.microsoft.com/en-us/library/windows/desktop/ms633545%28v=vs.85%29.aspx
		///         for more information.
		///     </para>
		/// </summary>
		/// <param name="hWnd">C++ ( hWnd Type: HWND ) <br /> A handle to the window.</param>
		/// <param name="hWndInsertAfter">
		///     C++ ( hWndInsertAfter Type: HWND ) <br /> A handle to the window to
		///     precede the positioned window in the Z order. This parameter must be a window handle or
		///     one of the following values.
		///     <list type="table">
		///         <itemheader>
		///             <term>HWND placement</term>
		///             <description>Window to precede placement</description>
		///         </itemheader>
		///         <item>
		///             <term>HWND_BOTTOM ((HWND)1)</term>
		///             <description>
		///                 Places the window at the bottom of the Z order. If the hWnd parameter identifies a
		///                 topmost window, the window loses its topmost status and is placed at the bottom of all
		///                 other windows.
		///             </description>
		///         </item>
		///         <item>
		///             <term>HWND_NOTOPMOST ((HWND)-2)</term>
		///             <description>
		///                 Places the window above all non-topmost windows (that is, behind all topmost windows).
		///                 This flag has no effect if the window is already a non-topmost window.
		///             </description>
		///         </item>
		///         <item>
		///             <term>HWND_TOP ((HWND)0)</term>
		///             <description>Places the window at the top of the Z order.</description>
		///         </item>
		///         <item>
		///             <term>HWND_TOPMOST ((HWND)-1)</term>
		///             <description>
		///                 Places the window above all non-topmost windows. The window maintains its topmost
		///                 position even when it is deactivated.
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         For more information about how this parameter is used, see the following Remarks section.
		///     </para>
		/// </param>
		/// <param name="X">
		///     C++ ( X Type: int ) <br /> The new position of the left side of the window, in
		///     client coordinates.
		/// </param>
		/// <param name="Y">
		///     C++ ( Y Type: int ) <br /> The new position of the top of the window, in client coordinates.
		/// </param>
		/// <param name="cx">C++ ( cx Type: int ) <br /> The new width of the window, in pixels.</param>
		/// <param name="cy">
		///     C++ ( cy Type: int ) <br /> The new height of the window, in pixels.
		/// </param>
		/// <param name="uFlags">
		///     C++ ( uFlags Type: UINT ) <br /> The window sizing and positioning flags. This
		///     parameter can be a combination of the following values.
		///     <list type="table">
		///         <itemheader>
		///             <term>HWND sizing and positioning flags</term>
		///             <description>Where to place and size window. Can be a combination of any</description>
		///         </itemheader>
		///         <item>
		///             <term>SWP_ASYNCWINDOWPOS (0x4000)</term>
		///             <description>
		///                 If the calling thread and the thread that owns the window are attached to different input
		///                 queues, the system posts the request to the thread that owns the window. This prevents
		///                 the calling thread from blocking its execution while other threads process the request.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SWP_DEFERERASE (0x2000)</term>
		///             <description>Prevents generation of the WM_SYNCPAINT message.</description>
		///         </item>
		///         <item>
		///             <term>SWP_DRAWFRAME (0x0020)</term>
		///             <description>
		///                 Draws a frame (defined in the window's class description) around the window.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SWP_FRAMECHANGED (0x0020)</term>
		///             <description>
		///                 Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE
		///                 message to the window, even if the window's size is not being changed. If this flag is
		///                 not specified, WM_NCCALCSIZE is sent only when the window's size is being changed
		///             </description>
		///         </item>
		///         <item>
		///             <term>SWP_HIDEWINDOW (0x0080)</term>
		///             <description>Hides the window.</description>
		///         </item>
		///         <item>
		///             <term>SWP_NOACTIVATE (0x0010)</term>
		///             <description>
		///                 Does not activate the window. If this flag is not set, the window is activated and moved
		///                 to the top of either the topmost or non-topmost group (depending on the setting of the
		///                 hWndInsertAfter parameter).
		///             </description>
		///         </item>
		///         <item>
		///             <term>SWP_NOCOPYBITS (0x0100)</term>
		///             <description>
		///                 Discards the entire contents of the client area. If this flag is not specified, the valid
		///                 contents of the client area are saved and copied back into the client area after the
		///                 window is sized or repositioned.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SWP_NOMOVE (0x0002)</term>
		///             <description>Retains the current position (ignores X and Y parameters).</description>
		///         </item>
		///         <item>
		///             <term>SWP_NOOWNERZORDER (0x0200)</term>
		///             <description>Does not change the owner window's position in the Z order.</description>
		///         </item>
		///         <item>
		///             <term>SWP_NOREDRAW (0x0008)</term>
		///             <description>
		///                 Does not redraw changes. If this flag is set, no repainting of any kind occurs. This
		///                 applies to the client area, the nonclient area (including the title bar and scroll bars),
		///                 and any part of the parent window uncovered as a result of the window being moved. When
		///                 this flag is set, the application must explicitly invalidate or redraw any parts of the
		///                 window and parent window that need redrawing.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SWP_NOREPOSITION (0x0200)</term>
		///             <description>Same as the SWP_NOOWNERZORDER flag.</description>
		///         </item>
		///         <item>
		///             <term>SWP_NOSENDCHANGING (0x0400)</term>
		///             <description>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</description>
		///         </item>
		///         <item>
		///             <term>SWP_NOSIZE (0x0001)</term>
		///             <description>Retains the current size (ignores the cx and cy parameters).</description>
		///         </item>
		///         <item>
		///             <term>SWP_NOZORDER (0x0004)</term>
		///             <description>Retains the current Z order (ignores the hWndInsertAfter parameter).</description>
		///         </item>
		///         <item>
		///             <term>SWP_SHOWWINDOW (0x0040)</term>
		///             <description>Displays the window.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <c>true</c> or nonzero if the function succeeds, <c>false</c> or zero otherwise or if
		///     function fails.
		/// </returns>
		/// <remarks>
		///     <para>
		///         As part of the Vista re-architecture, all services were moved off the interactive desktop
		///         into Session 0. hwnd and window manager operations are only effective inside a session
		///         and cross-session attempts to manipulate the hwnd will fail. For more information, see
		///         The Windows Vista Developer Story: Application Compatibility Cookbook.
		///     </para>
		///     <para>
		///         If you have changed certain window data using SetWindowLong, you must call SetWindowPos
		///         for the changes to take effect. Use the following combination for uFlags: SWP_NOMOVE |
		///         SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED.
		///     </para>
		///     <para>
		///         A window can be made a topmost window either by setting the hWndInsertAfter parameter to
		///         HWND_TOPMOST and ensuring that the SWP_NOZORDER flag is not set, or by setting a window's
		///         position in the Z order so that it is above any existing topmost windows. When a
		///         non-topmost window is made topmost, its owned windows are also made topmost. Its owners,
		///         however, are not changed.
		///     </para>
		///     <para>
		///         If neither the SWP_NOACTIVATE nor SWP_NOZORDER flag is specified (that is, when the
		///         application requests that a window be simultaneously activated and its position in the Z
		///         order changed), the value specified in hWndInsertAfter is used only in the following circumstances.
		///     </para>
		///     <list type="bullet">
		///         <item>Neither the HWND_TOPMOST nor HWND_NOTOPMOST flag is specified in hWndInsertAfter.</item>
		///         <item>The window identified by hWnd is not the active window.</item>
		///     </list>
		///     <para>
		///         An application cannot activate an inactive window without also bringing it to the top of
		///         the Z order. Applications can change an activated window's position in the Z order
		///         without restrictions, or it can activate a window and then move it to the top of the
		///         topmost or non-topmost windows.
		///     </para>
		///     <para>
		///         If a topmost window is repositioned to the bottom (HWND_BOTTOM) of the Z order or after
		///         any non-topmost window, it is no longer topmost. When a topmost window is made
		///         non-topmost, its owners and its owned windows are also made non-topmost windows.
		///     </para>
		///     <para>
		///         A non-topmost window can own a topmost window, but the reverse cannot occur. Any window
		///         (for example, a dialog box) owned by a topmost window is itself made a topmost window, to
		///         ensure that all owned windows stay above their owner.
		///     </para>
		///     <para>
		///         If an application is not in the foreground, and should be in the foreground, it must call
		///         the SetForegroundWindow function.
		///     </para>
		///     <para>
		///         To use SetWindowPos to bring a window to the top, the process that owns the window must
		///         have SetForegroundWindow permission.
		///     </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy,
		                                       SetWindowPosFlags uFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight,
		                                     [MarshalAs(UnmanagedType.Bool)] bool bRepaint);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		/// <summary>
		///     Retrieves a handle to the top-level window whose class name and window name match the specified strings. This
		///     function does not search child windows. This function does not perform a case-sensitive search. To search child
		///     windows, beginning with a specified child window, use the FindWindowEx function.
		/// </summary>
		/// <param name="lpClassName">
		///     The window class name. If lpClassName is NULL, it finds any window whose title matches the
		///     lpWindowName parameter.
		/// </param>
		/// <param name="lpWindowName">The window name (the window's title). If this parameter is NULL, all window names match.</param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the window that has the specified
		///     class name and window name. If the function fails, the return value is NULL.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className,
		                                         string windowTitle);

		/// <summary>Shows a Window</summary>
		/// <remarks>
		///     <para>To perform certain special effects when showing or hiding a window, use AnimateWindow.</para>
		///     <para>
		///         The first time an application calls ShowWindow, it should use the WinMain function's
		///         nCmdShow parameter as its nCmdShow parameter. Subsequent calls to ShowWindow must use one
		///         of the values in the given list, instead of the one specified by the WinMain function's
		///         nCmdShow parameter.
		///     </para>
		///     <para>
		///         As noted in the discussion of the nCmdShow parameter, the nCmdShow value is ignored in
		///         the first call to ShowWindow if the program that launched the application specifies
		///         startup information in the structure. In this case, ShowWindow uses the information
		///         specified in the STARTUPINFO structure to show the window. On subsequent calls, the
		///         application must call ShowWindow with nCmdShow set to SW_SHOWDEFAULT to use the startup
		///         information provided by the program that launched the application. This behavior is
		///         designed for the following situations:
		///     </para>
		///     <list type="">
		///         <item>
		///             Applications create their main window by calling CreateWindow with the WS_VISIBLE flag set.
		///         </item>
		///         <item>
		///             Applications create their main window by calling CreateWindow with the WS_VISIBLE flag
		///             cleared, and later call ShowWindow with the SW_SHOW flag set to make it visible.
		///         </item>
		///     </list>
		/// </remarks>
		/// <param name="hWnd">Handle to the window.</param>
		/// <param name="nCmdShow">
		///     Specifies how the window is to be shown. This parameter is ignored the first time an
		///     application calls ShowWindow, if the program that launched the application provides a
		///     STARTUPINFO structure. Otherwise, the first time ShowWindow is called, the value should
		///     be the value obtained by the WinMain function in its nCmdShow parameter. In subsequent
		///     calls, this parameter can be one of the WindowShowStyle members.
		/// </param>
		/// <returns>
		///     If the window was previously visible, the return value is nonzero. If the window was
		///     previously hidden, the return value is zero.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

		/// <summary>
		///     Retrieves a handle to the desktop window. The desktop window covers the entire screen. The desktop window is the
		///     area on top of which other windows are painted.
		/// </summary>
		/// <returns>The return value is a handle to the desktop window.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetDesktopWindow();

		/// <summary>Retrieves a handle to the Shell's desktop window.</summary>
		/// <returns>
		///     The return value is the handle of the Shell's desktop window. If no Shell process is present, the return value
		///     is NULL.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetShellWindow();

		/// <summary>
		///     Brings the thread that created the specified window into the foreground and activates the window. Keyboard
		///     input is directed to the window, and various visual cues are changed for the user. The system assigns a slightly
		///     higher priority to the thread that created the foreground window than it does to other threads.
		/// </summary>
		/// <param name="hWnd">A handle to the window that should be activated and brought to the foreground.</param>
		/// <returns>
		///     If the window was brought to the foreground, the return value is true.
		///     <para>If the window was not brought to the foreground, the return value is false.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		/// <summary>Retrieves the handle to the ancestor of the specified window.</summary>
		/// <param name="hWnd">
		///     A handle to the window whose ancestor is to be retrieved. If this parameter is the desktop window,
		///     the function returns <see cref="F:System.IntPtr.Zero" />.
		/// </param>
		/// <param name="gaFlags">The ancestor to be retrieved.</param>
		/// <returns>The handle to the ancestor window.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetAncestor(IntPtr hWnd, GetAncestorFlags gaFlags);


		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr RealChildWindowFromPoint(IntPtr hwndParent, POINT ptParentClientCoords);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowDisplayAffinity(IntPtr hWnd, int dwAffinity);

		/// <summary>Retrieves the window handle to the active window attached to the calling thread's message queue.</summary>
		/// <returns>
		///     The return value is the handle to the active window attached to the calling thread's message queue. Otherwise,
		///     the return value is <see cref="F:System.IntPtr.Zero" />.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetActiveWindow();

		/// <summary>
		///     Determines whether the specified window handle identifies an existing window.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>If the window handle identifies an existing window, the return value is true, otherwise it is false.</returns>
		/// <remarks>
		///     A thread should not use IsWindow for a window that it did not create because the window could be destroyed after
		///     this function was called.
		///     Further, because window handles are recycled the handle could even point to a different window.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindow(IntPtr hWnd);

		/// <summary>
		///     Determines whether a window is a child window or descendant window of a specified parent window.
		///     A child window is the direct descendant of a specified parent window if that parent window is in the chain of
		///     parent windows;
		///     the chain of parent windows leads from the original overlapped or pop-up window to the child window.
		/// </summary>
		/// <param name="hWndParent">A handle to the parent window.</param>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>
		///     If the window is a child or descendant window of the specified parent window, the return value is true,
		///     otherwise it is false.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

		/// <summary>
		///     Determines whether the system considers that a specified application is not responding.
		///     An application is considered to be not responding if it is not waiting for input, is not in startup processing,
		///     and has not called
		///     <see
		///         cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" />
		///     within the internal timeout period of 5 seconds.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>
		///     If the window handle identifies an existing window, the return value is true, otherwise it is false.
		///     Ghost windows always return true.
		/// </returns>
		/// <remarks>
		///     The Windows timeout criteria of 5 seconds is subject to change.
		///     This function was not included in the SDK headers and libraries until Windows XP Service Pack 1 (SP1) and Windows
		///     Server 2003.
		///     If you do not have a header file and import library for this function, you can call the function using
		///     <see cref="M:PInvoke.Kernel32.LoadLibrary(System.String)" /> and
		///     <see cref="M:PInvoke.Kernel32.GetProcAddress(PInvoke.Kernel32.SafeLibraryHandle,System.String)" />.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsHungAppWindow(IntPtr hWnd);

		/// <summary>
		///     Determines whether the specified window is minimized (iconic).
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>If the window is iconic, the return value is true, otherwise it is false.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsIconic(IntPtr hWnd);

		/// <summary>
		///     Determines whether the specified window is a native Unicode window.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>
		///     If the window is a native Unicode window, the return value is true, otherwise it is false (the window is a
		///     native ANSI window).
		/// </returns>
		/// <remarks>
		///     <para>
		///         The character set of a window is determined by the use of the
		///         <see cref="M:PInvoke.User32.RegisterClass(PInvoke.User32.WNDCLASS@)" /> function.
		///         If the window class was registered with the ANSI version of
		///         <see cref="M:PInvoke.User32.RegisterClass(PInvoke.User32.WNDCLASS@)" /> (RegisterClassA), the character set of
		///         the window is ANSI.
		///         If the window class was registered with the Unicode version of
		///         <see cref="M:PInvoke.User32.RegisterClass(PInvoke.User32.WNDCLASS@)" /> (RegisterClassW), the character set of
		///         the window is Unicode.
		///     </para>
		///     <para>
		///         The system does automatic two-way translation (Unicode to ANSI) for window messages. For example,
		///         if an ANSI window message is sent to a window that uses the Unicode character set,
		///         the system translates that message into a Unicode message before calling the window procedure.
		///         The system calls IsWindowUnicode to determine whether to translate the message or not.
		///     </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowUnicode(IntPtr hWnd);

		/// <summary>
		///     Determines the visibility state of the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>
		///     If the specified window, its parent window, its parent's parent window, and so forth, have the WS_VISIBLE style,
		///     the return value is true, otherwise it is false.
		///     Because the return value specifies whether the window has the WS_VISIBLE style, it may be nonzero even if the
		///     window is totally obscured by other windows.
		/// </returns>
		/// <remarks>
		///     The visibility state of a window is indicated by the WS_VISIBLE style bit.
		///     When WS_VISIBLE is set, the window is displayed and subsequent drawing into it is displayed as long as the window
		///     has the WS_VISIBLE style.
		///     Any drawing to a window with the WS_VISIBLE style will not be displayed if the window is obscured by other windows
		///     or is clipped by its parent window.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowVisible(IntPtr hWnd);

		/// <summary>Determines whether a window is maximized.</summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>If the window is zoomed, the return value is true, otherwise it is false.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsZoomed(IntPtr hWnd);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowDisplayAffinity(IntPtr hWnd, out int dwAffinity);


		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetSystemMetrics(SystemMetric smIndex);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowInfo(IntPtr hwnd, ref WINDOWINFO pwi);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, ref RECT rect,
		                                         [MarshalAs(UnmanagedType.U4)] int cPoints);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromPoint(POINT pt, MonitorOptions dwFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromPoint(POINT point, int flags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromRect(ref RECT lprc, MonitorOptions dwFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromWindow(IntPtr hwnd, MonitorOptions dwFlags);

		/// <summary>
		///     Enumerates all top-level windows on the screen by passing the handle to each window, in turn, to an
		///     application-defined callback function. EnumWindows continues until the last top-level window is enumerated or the
		///     callback function returns FALSE.
		/// </summary>
		/// <param name="lpEnumFunc">An application-defined <see cref="T:PInvoke.User32.WNDENUMPROC" /> callback function.</param>
		/// <param name="lParam">An application-defined value to be passed to the callback function.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     If the function fails, the return value is zero.To get extended error information, call GetLastError.
		///     If <see cref="T:PInvoke.User32.WNDENUMPROC" /> returns zero, the return value is also zero. In this case, the
		///     callback function should call SetLastError to obtain a meaningful error code to be returned to the caller of
		///     EnumWindows.
		/// </returns>
		/// <remarks>
		///     The EnumWindows function does not enumerate child windows, with the exception of a few top-level windows owned by
		///     the system that have the WS_CHILD style.
		///     This function is more reliable than calling the GetWindow function in a loop. An application that calls GetWindow
		///     to perform this task risks being caught in an infinite loop or referencing a handle to a window that has been
		///     destroyed.
		///     Note that for Windows 8 and later, EnumWindows enumerates only top-level windows of desktop apps.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, IntPtr lParam);

		/// <summary>
		///     Retrieves the length, in characters, of the specified window's title bar text (if the window has a title bar).
		///     If the specified window is a control, the function retrieves the length of the text within the control. However,
		///     GetWindowTextLength cannot retrieve the length of the text of an edit control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control.</param>
		/// <returns>
		///     If the function succeeds, the return value is the length, in characters, of the text. Under certain
		///     conditions, this value may actually be greater than the length of the text. For more information, see the following
		///     Remarks section.
		///     <para>If the window has no text, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetWindowTextLength(IntPtr hWnd);


		/// <summary>
		///     Changes the text of the specified window's title bar (if it has one). If the specified window is a control, the
		///     text of the control is changed. However, SetWindowText cannot change the text of a control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control whose text is to be changed. </param>
		/// <param name="lpString">The new title or control text. </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowText(IntPtr hWnd, string lpString);

		/// <summary>
		///     Examines the Z order of the child windows associated with the specified parent window and retrieves a handle to the
		///     child window at the top of the Z order.
		/// </summary>
		/// <param name="hWnd">
		///     A handle to the parent window whose child windows are to be examined. If this parameter is NULL, the
		///     function returns a handle to the window at the top of the Z order.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the child window at the top of the Z order. If the
		///     specified window has no child windows, the return value is NULL. To get extended error information, use the
		///     GetLastError function.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetTopWindow(IntPtr hWnd);

		/// <summary>
		///     Retrieves a handle to a window that has the specified relationship (Z-Order or owner) to the specified window.
		/// </summary>
		/// <param name="hWnd">
		///     A handle to a window. The window handle retrieved is relative to this window, based on the value of
		///     the wCmd parameter.
		/// </param>
		/// <param name="wCmd">The relationship between the specified window and the window whose handle is to be retrieved.</param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the next (or previous) window. If there is no next
		///     (or previous) window, the return value is NULL. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetWindow(IntPtr hWnd, GetWindowCommands wCmd);

		/// <summary>
		///     Retrieves a handle to the next or previous window in the Z-Order. The next window is below the specified window;
		///     the previous window is above.
		///     If the specified window is a topmost window, the function searches for a topmost window. If the specified window is
		///     a top-level window, the function searches for a top-level window. If the specified window is a child window, the
		///     function searches for a child window.
		/// </summary>
		/// <param name="hWnd">
		///     A handle to a window. The window handle retrieved is relative to this window, based on the value of
		///     the wCmd parameter.
		/// </param>
		/// <param name="wCmd">Indicates whether the function returns a handle to the next window or the previous window.</param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the next (or previous) window. If there is no next
		///     (or previous) window, the return value is NULL. To get extended error information, call GetLastError.
		/// </returns>
		public static IntPtr GetNextWindow(IntPtr hWnd, GetNextWindowCommands wCmd) {
			return GetWindow(hWnd, (GetWindowCommands) wCmd);
		}

		/// <summary>
		///     Moves the cursor to the specified screen coordinates. If the new coordinates are not within the screen
		///     rectangle set by the most recent ClipCursor function call, the system automatically adjusts the coordinates so that
		///     the
		///     cursor stays within the rectangle.
		/// </summary>
		/// <param name="X">The new x-coordinate of the cursor, in screen coordinates.</param>
		/// <param name="Y">The new y-coordinate of the cursor, in screen coordinates.</param>
		/// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetCursorPos(int X, int Y);


		/// <summary>
		///     Retrieves a handle to the window that contains the specified point.
		/// </summary>
		/// <param name="Point">The point to be checked.</param>
		/// <returns>
		///     The return value is a handle to the window that contains the point. If no window exists at the given point,
		///     the return value is <see cref="F:System.IntPtr.Zero" />. If the point is over a static text control, the return
		///     value is a handle to the window under the static text control.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr WindowFromPoint(POINT Point);


		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, POINT Point);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr ChildWindowFromPointEx(IntPtr hWndParent, POINT pt,
		                                                   ChildWindowFromPointExFlags uFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateWindow(IntPtr hWnd);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr WindowFromPhysicalPoint(POINT pt);

		/// <summary>
		///     Destroys the specified window. The function sends WM_DESTROY and WM_NCDESTROY messages to the window to deactivate
		///     it and remove the keyboard focus from it. The function also destroys the window's menu, flushes the thread message
		///     queue, destroys timers, removes clipboard ownership, and breaks the clipboard viewer chain (if the window is at the
		///     top of the viewer chain).
		///     If the specified window is a parent or owner window, DestroyWindow automatically destroys the associated child or
		///     owned windows when it destroys the parent or owner window. The function first destroys child or owned windows, and
		///     then it destroys the parent or owner window.
		///     DestroyWindow also destroys modeless dialog boxes created by the CreateDialog function.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be destroyed. </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyWindow(IntPtr hWnd);

		#region Nested type: COORD

		/// <summary>
		///     The COORD structure defines the X- and Y- coordinates of a point.
		/// </summary>
		public struct COORD {
			/// <summary>The x-coordinate of the point.</summary>
			public short X;

			/// <summary>The x-coordinate of the point.</summary>
			public short Y;
		}

		#endregion

		#region Nested type: MINMAXINFO

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MINMAXINFO {
			public POINT ptReserved;
			public POINT ptMaxSize;
			public POINT ptMaxPosition;
			public POINT ptMinTrackSize;
			public POINT ptMaxTrackSize;
		}

		#endregion

		#region Nested type: RECT

		/// <summary>
		///     The RECT structure defines the coordinates of the upper-left and lower-right corners of a rectangle.
		/// </summary>
		/// <remarks>
		///     By convention, the right and bottom edges of the rectangle are normally considered exclusive.
		///     In other words, the pixel whose coordinates are ( right, bottom ) lies immediately outside of the rectangle.
		///     For example, when RECT is passed to the FillRect function, the rectangle is filled up to, but not including,
		///     the right column and bottom row of pixels. This structure is identical to the RECTL structure.
		/// </remarks>
		public struct RECT {
			/// <summary>
			///     The x-coordinate of the upper-left corner of the rectangle.
			/// </summary>
			public int left;

			/// <summary>
			///     The y-coordinate of the upper-left corner of the rectangle.
			/// </summary>
			public int top;

			/// <summary>
			///     The x-coordinate of the lower-right corner of the rectangle.
			/// </summary>
			public int right;

			/// <summary>
			///     The y-coordinate of the lower-right corner of the rectangle.
			/// </summary>
			public int bottom;

			public int Width => right - left;
			public int Height => bottom - top;

			public int X => left;
			public int Y => top;

			public POINT Position => new POINT(X, Y);
			public SIZE Size => new SIZE(Width, Height);
		}

		#endregion

		#region Nested type: SMALL_RECT

		/// <summary>
		///     The RECT structure defines the coordinates of the upper-left and lower-right corners of a rectangle.
		/// </summary>
		/// <remarks>
		///     This structure is used by console functions to specify rectangular areas of console screen buffers,
		///     where the coordinates specify the rows and columns of screen-buffer character cells.
		/// </remarks>
		public struct SMALL_RECT {
			/// <summary>
			///     The x-coordinate of the upper-left corner of the rectangle.
			/// </summary>
			public short Left;

			/// <summary>
			///     The y-coordinate of the upper-left corner of the rectangle.
			/// </summary>
			public short Top;

			/// <summary>
			///     The x-coordinate of the lower-right corner of the rectangle.
			/// </summary>
			public short Right;

			/// <summary>
			///     The y-coordinate of the lower-right corner of the rectangle.
			/// </summary>
			public short Bottom;
		}

		#endregion

		#region Nested type: WINDOWINFO

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct WINDOWINFO {
			public uint cbSize;
			public RECT rcWindow;
			public RECT rcClient;
			public uint dwStyle;
			public uint dwExStyle;
			public uint dwWindowStatus;
			public uint cxWindowBorders;
			public uint cyWindowBorders;
			public ushort atomWindowType;
			public ushort wCreatorVersion;

			public static WINDOWINFO Create() {
				return new WINDOWINFO() {
					cbSize = (uint) Marshal.SizeOf(typeof(WINDOWINFO))
				};
			}
		}

		#endregion

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MONITORINFO {
			public int cbSize;
			public RECT rcMonitor;
			public RECT rcWork;
			public uint dwFlags;

			public static MONITORINFO Create() {
				return new MONITORINFO {
					cbSize = Marshal.SizeOf<MONITORINFO>()
				};
			}
		}

		/// <summary>
		/// The MONITORINFOEX structure contains information about a display monitor. The GetMonitorInfo
		/// function stores information into a MONITORINFOEX structure or a MONITORINFO structure. The
		/// MONITORINFOEX structure is a superset of the MONITORINFO structure. The MONITORINFOEX
		/// structure adds a string member to contain a name for the display monitor.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct MONITORINFOEX {
			/// <summary>
			/// The size, in bytes, of the structure. Set this member to sizeof(MONITORINFOEX) (72)
			/// before calling the GetMonitorInfo function. Doing so lets the function determine the type
			/// of structure you are passing to it.
			/// </summary>
			public int cbSize;

			/// <summary>
			/// A <see cref="T:PInvoke.RECT" /> structure that specifies the display monitor rectangle, expressed in
			/// virtual-screen coordinates. Note that if the monitor is not the primary display monitor,
			/// some of the rectangle's coordinates may be negative values.
			/// </summary>
			public RECT Monitor;

			/// <summary>
			/// A <see cref="T:PInvoke.RECT" /> structure that specifies the work area rectangle of the display monitor that can
			/// be used by applications, expressed in virtual-screen coordinates. Windows uses this
			/// rectangle to maximize an application on the monitor. The rest of the area in rcMonitor
			/// contains system windows such as the task bar and side bars. Note that if the monitor is
			/// not the primary display monitor, some of the rectangle's coordinates may be negative values.
			/// </summary>
			public RECT WorkArea;

			/// <summary>The attributes of the display monitor.</summary>
			/// <remarks>This member can be the following value: 1 : MONITORINFOF_PRIMARY</remarks>
			public uint Flags;

			/// <summary>
			/// A string that specifies the device name of the monitor being used. Most applications have
			/// no use for a display monitor name, and so can save some bytes by using a MONITORINFO structure.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string DeviceName;
			//public unsafe fixed char DeviceName[32];

			public static MONITORINFOEX Create() {
				return new MONITORINFOEX {
					cbSize = Marshal.SizeOf(typeof(User32.MONITORINFOEX))
				};
			}
		}

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

		[DllImport("User32", EntryPoint = "GetMonitorInfo", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool GetMonitorInfoEx(IntPtr hMonitor, ref MONITORINFOEX lpmi);
	}
}
