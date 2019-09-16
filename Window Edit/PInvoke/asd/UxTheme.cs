﻿// Decompiled with JetBrains decompiler
// Type: PInvoke.UxTheme
// Assembly: PInvoke.UxTheme, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: EB49E8C6-DF84-4452-B825-A82D39BC4280
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.uxtheme\0.5.152\lib\net40\PInvoke.UxTheme.dll

using System;
using System.Runtime.InteropServices;

namespace PInvoke {
	/// <content>
	/// Contains the <see cref="T:PInvoke.UxTheme.MARGINS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.UxTheme.SafeThemeHandle" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the UxTheme.dll Windows library
	/// that are available to Desktop and Store apps.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.UxTheme.MARGINS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.UxTheme.SafeThemeHandle" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the UxTheme.dll Windows library
	/// that are available to Desktop and Store apps.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public static class UxTheme {
		/// <summary>
		/// Opens the theme data for a window and its associated class.
		/// </summary>
		/// <param name="hwnd">Handle of the window for which theme data is required.</param>
		/// <param name="pszClassList">
		/// A string that contains a semicolon-separated list of classes.
		/// The pszClassList parameter contains a list, not just a single name, to provide the class an opportunity to get the best match between the class and the current visual style. For example, a button might pass L"OkButton;Button" if its ID is ID_OK. If the current visual style has an entry for OkButton, that is used; otherwise no visual style is applied.
		/// Class names for the Aero theme are defined in AeroStyle.xml.
		/// </param>
		/// <returns>
		/// OpenThemeData tries to match each class, one at a time, to a class data section in the active theme. If a match is found, an associated HTHEME handle is returned. If no match is found NULL is returned.
		/// </returns>
		[DllImport("UxTheme", CharSet = CharSet.Unicode)]
		public static extern UxTheme.SafeThemeHandle OpenThemeData(IntPtr hwnd, string pszClassList);

		/// <summary>
		/// A variant of OpenThemeData that opens a theme handle associated with a specific DPI.
		/// </summary>
		/// <param name="hwnd">The handle of the window for which theme data is required.</param>
		/// <param name="pszClassIdList">A pointer to a string that contains a semicolon-separated list of classes.</param>
		/// <param name="dpi">The specified DPI value with which to associate the theme handle. The function will return an error if this value is outside of those that correspond to the set of connected monitors.</param>
		/// <returns>See OpenThemeData</returns>
		/// <remarks>
		/// <list type="bullet">
		/// <item>
		/// uxtheme!OpenThemeData will create theme handles associated with the DPI of a window when used with Per Monitor v2 windows. OpenThemeDataForDpi
		/// allows you to open a theme handle for a specific DPI when you do not have a window at that DPI.
		/// The behavior of the returned theme handle will be undermined if the requested DPI value does not correspond to a currently connected display.The theming system only loads theme assets
		/// for the set of DPI values corresponding to the currently connected displays.
		/// The theme handle will become invalid anytime the system reloads the theme data.Applications are required to monitor <see cref="F:PInvoke.User32.WindowMessage.WM_THEMECHANGED" /> and close and reopen all
		/// theme handles in response.This behavior is the same regardless of whether the handles were opened via OpenThemeData or OpenThemeDataForDpi.
		/// </item>
		/// <item>The <see cref="T:PInvoke.UxTheme.SafeThemeHandle" /> returned by this method is not the same one as those used within the UxTheme library,  but it can be passed to
		/// UxTheme API's seamlessly</item>
		/// </list>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern UxTheme.SafeThemeHandle OpenThemeDataForDpi(
			IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string pszClassIdList, int dpi);

		/// <summary>
		/// Retrieves the value of a <see cref="T:PInvoke.UxTheme.MARGINS" /> property.
		/// </summary>
		/// <param name="hTheme">Handle to a window's specified theme data. Use <see cref="M:PInvoke.UxTheme.OpenThemeData(System.IntPtr,System.String)" /> to create an HTHEME.</param>
		/// <param name="hdc">HDC to select fonts into. This parameter may be set to <see cref="F:PInvoke.User32.SafeDCHandle.Null" />.</param>
		/// <param name="iPartId">Value of type int that specifies the part that contains the MARGINS property. See Parts and States.</param>
		/// <param name="iStateId">Value of type int that specifies the state of the part. See Parts and States.</param>
		/// <param name="iPropId">Value of type int that specifies the property to retrieve. For a list of possible values, see Property Identifiers.</param>
		/// <param name="prc">Pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the rectangle that specifies the area to be drawn into. This parameter may be set to NULL.</param>
		/// <param name="pMargins">Pointer to a <see cref="T:PInvoke.UxTheme.MARGINS" /> structure that receives the retrieved value.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("UxTheme", CharSet = CharSet.Unicode)]
		public static extern unsafe HResult GetThemeMargins(UxTheme.SafeThemeHandle hTheme, User32.SafeDCHandle hdc,
		                                                    int iPartId, int iStateId, int iPropId, RECT* prc,
		                                                    out UxTheme.MARGINS pMargins);

		/// <summary>Closes the theme data handle.</summary>
		/// <param name="hTheme">Handle to a window's specified theme data. Use <see cref="M:PInvoke.UxTheme.OpenThemeData(System.IntPtr,System.String)" /> to create an HTHEME.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("UxTheme", CharSet = CharSet.Unicode)]
		private static extern HResult CloseThemeData(IntPtr hTheme);

		/// <summary>
		/// Retrieves the value of a <see cref="T:PInvoke.UxTheme.MARGINS" /> property.
		/// </summary>
		/// <param name="hTheme">Handle to a window's specified theme data. Use <see cref="M:PInvoke.UxTheme.OpenThemeData(System.IntPtr,System.String)" /> to create an HTHEME.</param>
		/// <param name="hdc">HDC to select fonts into. This parameter may be set to <see cref="F:PInvoke.User32.SafeDCHandle.Null" />.</param>
		/// <param name="iPartId">Value of type int that specifies the part that contains the MARGINS property. See Parts and States.</param>
		/// <param name="iStateId">Value of type int that specifies the state of the part. See Parts and States.</param>
		/// <param name="iPropId">Value of type int that specifies the property to retrieve. For a list of possible values, see Property Identifiers.</param>
		/// <param name="prc">Pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the rectangle that specifies the area to be drawn into. This parameter may be set to NULL.</param>
		/// <param name="pMargins">Pointer to a <see cref="T:PInvoke.UxTheme.MARGINS" /> structure that receives the retrieved value.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		public static unsafe HResult GetThemeMargins(UxTheme.SafeThemeHandle hTheme, User32.SafeDCHandle hdc,
		                                             int iPartId, int iStateId, int iPropId, IntPtr prc,
		                                             out UxTheme.MARGINS pMargins) {
			RECT* pointer = (RECT*) prc.ToPointer();
			return UxTheme.GetThemeMargins(hTheme, hdc, iPartId, iStateId, iPropId, pointer, out pMargins);
		}

		/// <summary>
		/// Retrieves the value of a <see cref="T:PInvoke.UxTheme.MARGINS" /> property.
		/// </summary>
		/// <param name="hTheme">Handle to a window's specified theme data. Use <see cref="M:PInvoke.UxTheme.OpenThemeData(System.IntPtr,System.String)" /> to create an HTHEME.</param>
		/// <param name="hdc">HDC to select fonts into. This parameter may be set to <see cref="F:PInvoke.User32.SafeDCHandle.Null" />.</param>
		/// <param name="iPartId">Value of type int that specifies the part that contains the MARGINS property. See Parts and States.</param>
		/// <param name="iStateId">Value of type int that specifies the state of the part. See Parts and States.</param>
		/// <param name="iPropId">Value of type int that specifies the property to retrieve. For a list of possible values, see Property Identifiers.</param>
		/// <param name="prc">Pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the rectangle that specifies the area to be drawn into. This parameter may be set to NULL.</param>
		/// <param name="pMargins">Pointer to a <see cref="T:PInvoke.UxTheme.MARGINS" /> structure that receives the retrieved value.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		public static unsafe HResult GetThemeMargins(UxTheme.SafeThemeHandle hTheme, User32.SafeDCHandle hdc,
		                                             int iPartId, int iStateId, int iPropId, RECT? prc,
		                                             out UxTheme.MARGINS pMargins) {
			RECT rect = prc.HasValue ? prc.Value : new RECT();
			return UxTheme.GetThemeMargins(hTheme, hdc, iPartId, iStateId, iPropId, prc.HasValue ? &rect : (RECT*) null,
				out pMargins);
		}

		/// <summary>
		/// Returned by the <see cref="M:PInvoke.UxTheme.GetThemeMargins(PInvoke.UxTheme.SafeThemeHandle,PInvoke.User32.SafeDCHandle,System.Int32,System.Int32,System.Int32,PInvoke.RECT*,PInvoke.UxTheme.MARGINS@)" /> function to define the margins of windows that have visual styles applied.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MARGINS {
			/// <summary>Width of the left border that retains its size.</summary>
			public int cxLeftWidth;

			/// <summary>Width of the right border that retains its size.</summary>
			public int cxRightWidth;

			/// <summary>Height of the top border that retains its size.</summary>
			public int cyTopHeight;

			/// <summary>Height of the bottom border that retains its size.</summary>
			public int cyBottomHeight;
		}

		/// <summary>
		/// Represents a windows Hook that can be removed with <see cref="M:PInvoke.UxTheme.CloseThemeData(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeThemeHandle : SafeHandle {
			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly UxTheme.SafeThemeHandle Null = new UxTheme.SafeThemeHandle();

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.UxTheme.SafeThemeHandle" /> class.
			/// </summary>
			public SafeThemeHandle()
				: base(IntPtr.Zero, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.UxTheme.SafeThemeHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeThemeHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			/// <inheritdoc />
			public override bool IsInvalid {
				get { return this.handle == IntPtr.Zero; }
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return UxTheme.CloseThemeData(this.handle).Succeeded;
			}
		}
	}
}