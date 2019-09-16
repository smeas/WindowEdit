// Decompiled with JetBrains decompiler
// Type: PInvoke.Gdi32
// Assembly: PInvoke.Gdi32, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: 21C195AD-BA94-45C3-BFC1-1854C2B7FE50
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.gdi32\0.5.152\lib\net40\PInvoke.Gdi32.dll

using System;
using System.Runtime.InteropServices;

namespace PInvoke {
	/// <content>
	/// Contains the <see cref="T:PInvoke.Gdi32.DeviceCap" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Gdi32.StockObject" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the Gdi32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Gdi32.DeviceCap" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Gdi32.StockObject" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the Gdi32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public static class Gdi32 {
		/// <summary>
		/// The GetDeviceCaps function retrieves device-specific information for the specified device.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="nIndex">The item to be returned.</param>
		/// <returns>
		/// The return value specifies the value of the desired item.
		/// When nIndex is <see cref="F:PInvoke.Gdi32.DeviceCap.BITSPIXEL" /> and the device has 15bpp or 16bpp, the return value is 16.
		/// </returns>
		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		public static extern int GetDeviceCaps(User32.SafeDCHandle hdc, Gdi32.DeviceCap nIndex);

		/// <summary>
		/// The GetDeviceCaps function retrieves device-specific information for the specified device.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="nIndex">The item to be returned.</param>
		/// <returns>
		/// The return value specifies the value of the desired item.
		/// When nIndex is BITSPIXEL (12) and the device has 15bpp or 16bpp, the return value is 16.
		/// </returns>
		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		public static extern int GetDeviceCaps(User32.SafeDCHandle hdc, int nIndex);

		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetStockObject(Gdi32.StockObject fnObject);

		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteObject(IntPtr hObject);

		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteDC(User32.SafeDCHandle hDC);

		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		public static extern IntPtr SelectObject(User32.SafeDCHandle hDC, IntPtr hObject);

		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight,
		                                 IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		public static extern IntPtr CreateCompatibleBitmap(User32.SafeDCHandle hDC, int nWidth, int nHeight);

		[DllImport("Gdi32", CharSet = CharSet.Unicode)]
		public static extern User32.SafeDCHandle CreateCompatibleDC(User32.SafeDCHandle hDC);

		/// <summary>
		/// Describes the values that may be returned from <see cref="M:PInvoke.Gdi32.GetDeviceCaps(PInvoke.User32.SafeDCHandle,PInvoke.Gdi32.DeviceCap)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DeviceCap {
			DRIVERVERSION = 0,
			TECHNOLOGY = 2,
			HORZSIZE = 4,
			VERTSIZE = 6,
			HORZRES = 8,
			VERTRES = 10, // 0x0000000A
			BITSPIXEL = 12, // 0x0000000C
			PLANES = 14, // 0x0000000E
			NUMBRUSHES = 16, // 0x00000010
			NUMPENS = 18, // 0x00000012
			NUMMARKERS = 20, // 0x00000014
			NUMFONTS = 22, // 0x00000016
			NUMCOLORS = 24, // 0x00000018
			PDEVICESIZE = 26, // 0x0000001A
			CURVECAPS = 28, // 0x0000001C
			LINECAPS = 30, // 0x0000001E
			POLYGONALCAPS = 32, // 0x00000020
			TEXTCAPS = 34, // 0x00000022
			CLIPCAPS = 36, // 0x00000024
			RASTERCAPS = 38, // 0x00000026
			ASPECTX = 40, // 0x00000028
			ASPECTY = 42, // 0x0000002A
			ASPECTXY = 44, // 0x0000002C
			SHADEBLENDCAPS = 45, // 0x0000002D
			LOGPIXELSX = 88, // 0x00000058
			LOGPIXELSY = 90, // 0x0000005A
			SIZEPALETTE = 104, // 0x00000068
			NUMRESERVED = 106, // 0x0000006A
			COLORRES = 108, // 0x0000006C
			PHYSICALWIDTH = 110, // 0x0000006E
			PHYSICALHEIGHT = 111, // 0x0000006F
			PHYSICALOFFSETX = 112, // 0x00000070
			PHYSICALOFFSETY = 113, // 0x00000071
			SCALINGFACTORX = 114, // 0x00000072
			SCALINGFACTORY = 115, // 0x00000073
			VREFRESH = 116, // 0x00000074
			DESKTOPVERTRES = 117, // 0x00000075
			DESKTOPHORZRES = 118, // 0x00000076
			BLTALIGNMENT = 119, // 0x00000077
		}

		/// <summary>
		/// Describes the values that may be supplied to the <see cref="M:PInvoke.Gdi32.GetStockObject(PInvoke.Gdi32.StockObject)" /> method.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum StockObject {
			WHITE_BRUSH = 0,
			LTGRAY_BRUSH = 1,
			GRAY_BRUSH = 2,
			DKGRAY_BRUSH = 3,
			BLACK_BRUSH = 4,
			HOLLOW_BRUSH = 5,
			NULL_BRUSH = 5,
			WHITE_PEN = 6,
			BLACK_PEN = 7,
			NULL_PEN = 8,
			OEM_FIXED_FONT = 10, // 0x0000000A
			ANSI_FIXED_FONT = 11, // 0x0000000B
			ANSI_VAR_FONT = 12, // 0x0000000C
			SYSTEM_FONT = 13, // 0x0000000D
			DEVICE_DEFAULT_FONT = 14, // 0x0000000E
			DEFAULT_PALETTE = 15, // 0x0000000F
			SYSTEM_FIXED_FONT = 16, // 0x00000010
			DEFAULT_GUI_FONT = 17, // 0x00000011
			DC_BRUSH = 18, // 0x00000012
			DC_PEN = 19, // 0x00000013
		}
	}
}