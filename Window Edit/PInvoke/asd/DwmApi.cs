// Decompiled with JetBrains decompiler
// Type: PInvoke.DwmApi
// Assembly: PInvoke.DwmApi, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: 85A5FC1D-3F10-4378-8870-4A6070FEF9F0
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.dwmapi\0.5.152\lib\net40\PInvoke.DwmApi.dll

using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PInvoke {
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DwmEnableCompositionFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DWMWINDOWATTRIBUTE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DWM_BLURBEHIND" /> nested type.
	/// </content>
	/// <content>
	/// Exported functions from the DwmApi.dll Windows library
	/// that are available to Desktop apps only.
	/// </content>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DWM_BLURBEHINDFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DwmEnableCompositionFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DWMWINDOWATTRIBUTE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DWM_BLURBEHIND" /> nested type.
	/// </content>
	/// <content>
	/// Exported functions from the DwmApi.dll Windows library
	/// that are available to Desktop apps only.
	/// </content>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.DwmApi.DWM_BLURBEHINDFlags" /> nested type.
	/// </content>
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public static class DwmApi {
		/// <summary>Enables the blur effect on a specified window.</summary>
		/// <param name="hWnd">The handle to the window on which the blur behind data is applied.</param>
		/// <param name="pBlurBehind">A pointer to a <see cref="T:PInvoke.DwmApi.DWM_BLURBEHIND" /> structure that provides blur behind data.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("DwmApi", CharSet = CharSet.Unicode)]
		public static extern unsafe HResult DwmEnableBlurBehindWindow(IntPtr hWnd, DwmApi.DWM_BLURBEHIND* pBlurBehind);

		/// <summary>
		/// Enables or disables Desktop Window Manager (DWM) composition.
		/// </summary>
		/// <param name="uCompositionAction">The flag to enable or disable composition.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		/// As of Windows 8, calling this function with <see cref="F:PInvoke.DwmApi.DwmEnableCompositionFlags.DWM_EC_DISABLECOMPOSITION" /> has no effect.
		/// However, the function will still return a success code.
		/// </remarks>
		[DllImport("DwmApi", CharSet = CharSet.Unicode)]
		public static extern HResult DwmEnableComposition(DwmApi.DwmEnableCompositionFlags uCompositionAction);

		/// <summary>
		/// Default window procedure for Desktop Window Manager (DWM) hit testing within the non-client area.
		/// </summary>
		/// <param name="hwnd">A handle to the window procedure that received the message.</param>
		/// <param name="msg">The message.</param>
		/// <param name="wParam">Specifies additional message information. The content of this parameter depends on the value of the <paramref name="msg" /> parameter.</param>
		/// <param name="lParam">Specifies additional message information. The content of this parameter depends on the value of the <paramref name="msg" /> parameter.</param>
		/// <param name="plResult">A pointer to an LRESULT value that, when this method returns successfully,receives the result of the hit test.</param>
		/// <returns>TRUE if DwmDefWindowProc handled the message; otherwise, FALSE.</returns>
		[DllImport("DwmApi", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DwmDefWindowProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam,
		                                           out IntPtr plResult);

		/// <summary>
		/// Issues a flush call that blocks the caller until the next present, when all of the Microsoft DirectX surface updates that are currently outstanding have been made. This compensates for very complex scenes or calling processes with very low priority.
		/// </summary>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		/// DwmFlush waits for any queued DirectX changes that were queued by the calling application to be drawn to the screen before returning. It does not flush the entire session rendering batch.
		/// </remarks>
		[DllImport("DwmApi", CharSet = CharSet.Unicode)]
		public static extern HResult DwmFlush();

		/// <summary>
		/// Retrieves the current color used for Desktop Window Manager (DWM) glass composition. This value is based on the current color scheme and can be modified by the user. Applications can listen for color changes by handling the WM_DWMCOLORIZATIONCOLORCHANGED notification.
		/// </summary>
		/// <param name="pcrColorization">A pointer to a value that, when this function returns successfully, receives the current color used for glass composition. The color format of the value is 0xAARRGGBB.</param>
		/// <param name="pfOpaqueBlend">A pointer to a value that, when this function returns successfully, indicates whether the color is an opaque blend. TRUE if the color is an opaque blend; otherwise, FALSE.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("DwmApi", CharSet = CharSet.Unicode)]
		public static extern HResult DwmGetColorizationColor(out uint pcrColorization,
		                                                     [MarshalAs(UnmanagedType.Bool)] out bool pfOpaqueBlend);

		/// <summary>
		/// Retrieves the current value of a specified attribute applied to a window.
		/// </summary>
		/// <param name="hwnd">The handle to the window from which the attribute data is retrieved.</param>
		/// <param name="dwAttribute">The attribute to retrieve, specified as a <see cref="T:PInvoke.DwmApi.DWMWINDOWATTRIBUTE" /> value.</param>
		/// <param name="pvAttribute">A pointer to a value that, when this function returns successfully, receives the current value of the attribute. The type of the retrieved value depends on the value of the <paramref name="dwAttribute" /> parameter.</param>
		/// <param name="cbAttribute">The size of the <see cref="T:PInvoke.DwmApi.DWMWINDOWATTRIBUTE" /> value being retrieved. The size is dependent on the type of the <paramref name="pvAttribute" /> parameter.</param>
		/// <returns>If this function succeeds, it returns <see cref="F:PInvoke.HResult.Code.S_OK" />. Otherwise, it returns an <see cref="T:PInvoke.HResult" /> error code.</returns>
		[DllImport("DwmApi", CharSet = CharSet.Unicode)]
		public static extern HResult DwmGetWindowAttribute(IntPtr hwnd, DwmApi.DWMWINDOWATTRIBUTE dwAttribute,
		                                                   out void* pvAttribute, int cbAttribute);

		[DllImport("DwmApi", CharSet = CharSet.Unicode)]
		public static extern HResult DwmExtendFrameIntoClientArea(IntPtr hWnd, UxTheme.MARGINS margins);

		/// <summary>Enables the blur effect on a specified window.</summary>
		/// <param name="hWnd">The handle to the window on which the blur behind data is applied.</param>
		/// <param name="pBlurBehind">A pointer to a <see cref="T:PInvoke.DwmApi.DWM_BLURBEHIND" /> structure that provides blur behind data.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		public static unsafe HResult DwmEnableBlurBehindWindow(IntPtr hWnd, IntPtr pBlurBehind) {
			DwmApi.DWM_BLURBEHIND* pointer = (DwmApi.DWM_BLURBEHIND*) pBlurBehind.ToPointer();
			return DwmApi.DwmEnableBlurBehindWindow(hWnd, pointer);
		}

		/// <summary>Enables the blur effect on a specified window.</summary>
		/// <param name="hWnd">The handle to the window on which the blur behind data is applied.</param>
		/// <param name="pBlurBehind">A pointer to a <see cref="T:PInvoke.DwmApi.DWM_BLURBEHIND" /> structure that provides blur behind data.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		public static unsafe HResult DwmEnableBlurBehindWindow(IntPtr hWnd, DwmApi.DWM_BLURBEHIND pBlurBehind) {
			return DwmApi.DwmEnableBlurBehindWindow(hWnd, &pBlurBehind);
		}

		/// <summary>
		/// Retrieves the current value of a specified attribute applied to a window.
		/// </summary>
		/// <param name="hwnd">The handle to the window from which the attribute data is retrieved.</param>
		/// <param name="dwAttribute">The attribute to retrieve, specified as a <see cref="T:PInvoke.DwmApi.DWMWINDOWATTRIBUTE" /> value.</param>
		/// <param name="pvAttribute">A pointer to a value that, when this function returns successfully, receives the current value of the attribute. The type of the retrieved value depends on the value of the <paramref name="dwAttribute" /> parameter.</param>
		/// <param name="cbAttribute">The size of the <see cref="T:PInvoke.DwmApi.DWMWINDOWATTRIBUTE" /> value being retrieved. The size is dependent on the type of the <paramref name="pvAttribute" /> parameter.</param>
		/// <returns>If this function succeeds, it returns <see cref="F:PInvoke.HResult.Code.S_OK" />. Otherwise, it returns an <see cref="T:PInvoke.HResult" /> error code.</returns>
		public static unsafe HResult DwmGetWindowAttribute(IntPtr hwnd, DwmApi.DWMWINDOWATTRIBUTE dwAttribute,
		                                                   out IntPtr pvAttribute, int cbAttribute) {
			void* pvAttribute1;
			HResult windowAttribute = DwmApi.DwmGetWindowAttribute(hwnd, dwAttribute, out pvAttribute1, cbAttribute);
			pvAttribute = new IntPtr(pvAttribute1);
			return windowAttribute;
		}

		/// <summary>
		/// Flags that may be passed to the <see cref="M:PInvoke.DwmApi.DwmEnableComposition(PInvoke.DwmApi.DwmEnableCompositionFlags)" /> function.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DwmEnableCompositionFlags : uint {
			DWM_EC_DISABLECOMPOSITION,
			DWM_EC_ENABLECOMPOSITION,
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DWMWINDOWATTRIBUTE : uint {
			DWMWA_NCRENDERING_ENABLED = 1,
			DWMWA_NCRENDERING_POLICY = 2,
			DWMWA_TRANSITIONS_FORCEDISABLED = 3,
			DWMWA_ALLOW_NCPAINT = 4,
			DWMWA_CAPTION_BUTTON_BOUNDS = 5,
			DWMWA_NONCLIENT_RTL_LAYOUT = 6,
			DWMWA_FORCE_ICONIC_REPRESENTATION = 7,
			DWMWA_FLIP3D_POLICY = 8,
			DWMWA_EXTENDED_FRAME_BOUNDS = 9,
			DWMWA_HAS_ICONIC_BITMAP = 10, // 0x0000000A
			DWMWA_DISALLOW_PEEK = 11, // 0x0000000B
			DWMWA_EXCLUDED_FROM_PEEK = 12, // 0x0000000C
			DWMWA_CLOAK = 13, // 0x0000000D
			DWMWA_CLOAKED = 14, // 0x0000000E
			DWMWA_FREEZE_REPRESENTATION = 15, // 0x0000000F
			DWMWA_LAST = 16, // 0x00000010
		}

		/// <summary>
		/// Specifies Desktop Window Manager (DWM) blur-behind properties. Used by the <see cref="M:PInvoke.DwmApi.DwmEnableBlurBehindWindow(System.IntPtr,PInvoke.DwmApi.DWM_BLURBEHIND*)" /> function.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DWM_BLURBEHIND {
			/// <summary>
			/// A bitwise combination of <see cref="T:PInvoke.DwmApi.DWM_BLURBEHINDFlags" /> constant values that indicates which of the members of this structure have been set.
			/// </summary>
			public DwmApi.DWM_BLURBEHINDFlags dwFlags;

			/// <summary>
			/// TRUE to register the window handle to DWM blur behind; FALSE to unregister the window handle from DWM blur behind.
			/// </summary>
			public byte fEnable;

			/// <summary>
			/// The region within the client area where the blur behind will be applied. A NULL value will apply the blur behind the entire client area.
			/// </summary>
			public IntPtr hRgnBlur;

			/// <summary>
			/// TRUE if the window's colorization should transition to match the maximized windows; otherwise, FALSE.
			/// </summary>
			public byte fTransitionOnMaximized;

			/// <summary>
			/// Gets or sets a value indicating whether to register the window handle to DWM blur behind;
			/// Use <c>false</c> to unregister the window handle from DWM blur behind.
			/// </summary>
			public bool Enable {
				get { return this.fEnable > (byte) 0; }
				set { this.fEnable = value ? (byte) 1 : (byte) 0; }
			}

			/// <summary>
			/// Gets a <see cref="P:PInvoke.DwmApi.DWM_BLURBEHIND.Region" /> object from the <see cref="F:PInvoke.DwmApi.DWM_BLURBEHIND.hRgnBlur" /> handle.
			/// </summary>
			public Region Region {
				get { return Region.FromHrgn(this.hRgnBlur); }
			}

			/// <summary>
			/// Gets or sets a value indicating whether the window's colorization should transition to match the maximized windows.
			/// </summary>
			public bool TransitionOnMaximized {
				get { return this.fTransitionOnMaximized > (byte) 0; }
				set { this.fTransitionOnMaximized = value ? (byte) 1 : (byte) 0; }
			}
		}

		/// <summary>
		/// Flags used by the <see cref="T:PInvoke.DwmApi.DWM_BLURBEHIND" /> structure to indicate which of its members contain valid information.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DWM_BLURBEHINDFlags : uint {
			DWM_BB_ENABLE = 1,
			DWM_BB_BLURREGION = 2,
			DWM_BB_TRANSITIONONMAXIMIZED = 4,
		}
	}
}