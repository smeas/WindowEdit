// Decompiled with JetBrains decompiler
// Type: PInvoke.User32
// Assembly: PInvoke.User32, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: 374973E4-6477-4D50-B3F1-781380E5FE15
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.user32\0.5.155\lib\net40\PInvoke.User32.dll

using System;
using System.Runtime.InteropServices;
using Validation;

namespace PInvoke {
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.ChildWindowFromPointExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.ClassStyles" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DesktopCreationFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DeviceContextValues" /> nested type.
	/// </content>
	/// <content>
	/// Contains nested type <see cref="T:PInvoke.User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS" />
	/// </content>
	/// <content>
	/// Contains nested type <see cref="T:PInvoke.User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS" />
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_2DREGION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_VIDEO_SIGNAL_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_DESKTOP_IMAGE_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_MODE_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_MODE_INFO_TYPE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_SOURCE_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_TARGET_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PIXELFORMAT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_RATIONAL" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_ROTATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_SCALING" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_SCANLINE_ORDERING" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_SOURCE_MODE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_TARGET_MODE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_TOPOLOGY_ID" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_VIDEO_SIGNAL_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_TARGET_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DLGITEMTEMPLATE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DLGTEMPLATE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DPI_AWARENESS" /> nested type.
	/// </content>
	/// <content>
	/// Contains nested type <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" />
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DRAWTEXTPARAMS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.FlashWindowFlags" /> nested type.
	/// </content>
	/// <content>Contains the <see cref="T:PInvoke.User32.FLASHWINFO" /> nested type.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.GetAncestorFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.GetNextWindowCommands" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.GetWindowCommands" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.HARDWAREINPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.HELPINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.INPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.InputType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.KEYBDINPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.KEYEVENTF" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.LookupIconIdFromDirectoryExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.LUID" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MapVirtualKeyTranslation" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuItemFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MENUITEMINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuItemState" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuItemType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuMembersMask" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MessageBoxOptions" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MessageBeepType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MessageBoxResult" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MONITORINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MONITORINFOEX" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MonitorOptions" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MOUSEEVENTF" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MOUSEINPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.mouse_eventFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MSG" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MSGBOXPARAMS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.ObjectInformationType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.PeekMessageParams" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.PeekMessageRemoveFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="M:PInvoke.User32.PrintWindow(System.IntPtr,System.IntPtr,PInvoke.User32.PrintWindowFlags)" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.QueueStatusFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeDCHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeDesktopHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeEventHookHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeHookHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeWindowStationHandle" /> nested type.
	/// </content>
	/// <content>Contains the Keyboard scan code constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SendMessageTimeoutFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SetWindowLongFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SetWindowPosFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SpecialWindowHandles" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SysCommands" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SystemMetric" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SystemParametersInfoAction" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SystemParametersInfoFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.TextFormats" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.USEROBJECTFLAGS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.UserObjectFlagsEnum" /> nested type.
	/// </content>
	/// <content>Contains the virtual-key code constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WINDOWINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowLongIndexFlags" /> nested type.
	/// </content>
	/// <content>Contains the Windows Messages constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> nested type.
	/// </content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowPlacementFlags" /> nested type.</content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowsEventHookType" /> nested type.</content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowsEventHookType" /> nested type.</content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowsHookType" /> nested type.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowShowStyle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowStationCreationFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowStyles" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowStylesEx" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MINMAXINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WNDCLASS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WNDCLASSEX" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the User32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.ChildWindowFromPointExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.ClassStyles" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DesktopCreationFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DeviceContextValues" /> nested type.
	/// </content>
	/// <content>
	/// Contains nested type <see cref="T:PInvoke.User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS" />
	/// </content>
	/// <content>
	/// Contains nested type <see cref="T:PInvoke.User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS" />
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_2DREGION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_VIDEO_SIGNAL_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_DESKTOP_IMAGE_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_MODE_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_MODE_INFO_TYPE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_SOURCE_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_TARGET_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PIXELFORMAT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_RATIONAL" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_ROTATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_SCALING" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_SCANLINE_ORDERING" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_SOURCE_MODE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_TARGET_MODE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_TOPOLOGY_ID" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_VIDEO_SIGNAL_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DISPLAYCONFIG_PATH_TARGET_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DLGITEMTEMPLATE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DLGTEMPLATE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DPI_AWARENESS" /> nested type.
	/// </content>
	/// <content>
	/// Contains nested type <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" />
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.DRAWTEXTPARAMS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.FlashWindowFlags" /> nested type.
	/// </content>
	/// <content>Contains the <see cref="T:PInvoke.User32.FLASHWINFO" /> nested type.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.GetAncestorFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.GetNextWindowCommands" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.GetWindowCommands" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.HARDWAREINPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.HELPINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.INPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.InputType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.KEYBDINPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.KEYEVENTF" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.LookupIconIdFromDirectoryExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.LUID" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MapVirtualKeyTranslation" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuItemFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MENUITEMINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuItemState" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuItemType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MenuMembersMask" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MessageBoxOptions" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MessageBeepType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MessageBoxResult" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MONITORINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MONITORINFOEX" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MonitorOptions" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MOUSEEVENTF" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MOUSEINPUT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.mouse_eventFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MSG" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MSGBOXPARAMS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.ObjectInformationType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.PeekMessageParams" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.PeekMessageRemoveFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="M:PInvoke.User32.PrintWindow(System.IntPtr,System.IntPtr,PInvoke.User32.PrintWindowFlags)" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.QueueStatusFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeDCHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeDesktopHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeEventHookHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeHookHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SafeWindowStationHandle" /> nested type.
	/// </content>
	/// <content>Contains the Keyboard scan code constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SendMessageTimeoutFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SetWindowLongFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SetWindowPosFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SpecialWindowHandles" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SysCommands" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SystemMetric" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SystemParametersInfoAction" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.SystemParametersInfoFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.TextFormats" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.USEROBJECTFLAGS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.UserObjectFlagsEnum" /> nested type.
	/// </content>
	/// <content>Contains the virtual-key code constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WINDOWINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowLongIndexFlags" /> nested type.
	/// </content>
	/// <content>Contains the Windows Messages constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> nested type.
	/// </content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowPlacementFlags" /> nested type.</content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowsEventHookType" /> nested type.</content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowsEventHookType" /> nested type.</content>
	/// <content>Contains the <see cref="T:PInvoke.User32.WindowsHookType" /> nested type.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowShowStyle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowStationCreationFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowStyles" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WindowStylesEx" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.MINMAXINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WNDCLASS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.User32.WNDCLASSEX" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the User32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public static class User32 {
		/// <summary>
		///     A bitmap that is drawn by the window that owns the menu. The application must process the WM_MEASUREITEM and
		///     WM_DRAWITEM messages.
		/// </summary>
		public static readonly IntPtr HBMMENU_CALLBACK = new IntPtr(-1);

		/// <summary>Close button for the menu bar.</summary>
		public static readonly IntPtr HBMMENU_MBAR_CLOSE = new IntPtr(5);

		/// <summary>Disabled close button for the menu bar.</summary>
		public static readonly IntPtr HBMMENU_MBAR_CLOSE_D = new IntPtr(6);

		/// <summary>Minimize button for the menu bar.</summary>
		public static readonly IntPtr HBMMENU_MBAR_MINIMIZE = new IntPtr(3);

		/// <summary>Disabled minimize button for the menu bar.</summary>
		public static readonly IntPtr HBMMENU_MBAR_MINIMIZE_D = new IntPtr(7);

		/// <summary>Restore button for the menu bar.</summary>
		public static readonly IntPtr HBMMENU_MBAR_RESTORE = new IntPtr(2);

		/// <summary>Close button for the submenu.</summary>
		public static readonly IntPtr HBMMENU_POPUP_CLOSE = new IntPtr(8);

		/// <summary>Maximize button for the submenu.</summary>
		public static readonly IntPtr HBMMENU_POPUP_MAXIMIZE = new IntPtr(10);

		/// <summary>Minimize button for the submenu.</summary>
		public static readonly IntPtr HBMMENU_POPUP_MINIMIZE = new IntPtr(11);

		/// <summary>Restore button for the submenu.</summary>
		public static readonly IntPtr HBMMENU_POPUP_RESTORE = new IntPtr(9);

		/// <summary>Windows icon or the icon of the window specified in <see cref="F:PInvoke.User32.MENUITEMINFO.dwItemData" />.</summary>
		public static readonly IntPtr HBMMENU_SYSTEM = new IntPtr(1);

		/// <summary>
		/// Gets the predefined DPI_AWARENESS_CONTEXT handle for DPI unaware mode. These windows do not scale
		/// for DPI changes and are always assumed to have a scale factor of 100% (96 DPI). They will be automatically scaled by
		/// the system on any other DPI setting.
		/// </summary>
		/// <remarks>DPI_AWARENESS_CONTEXT values should never be compared directly. Instead, use AreDpiAwarenessContextsEqual function</remarks>
		public static readonly IntPtr DPI_AWARENESS_CONTEXT_UNAWARE = new IntPtr(-1);

		/// <summary>
		/// Gets the predefined DPI_AWARENESS_CONTEXT handle for System aware mode. These windows do not scale for DPI changes.
		/// They will query for the DPI once and use that value for the lifetime of the process. If the DPI changes,
		/// the process will not adjust to the new DPI value. It will be automatically scaled up or down by the system
		/// when the DPI changes from the system value.
		/// </summary>
		/// <remarks>DPI_AWARENESS_CONTEXT values should never be compared directly. Instead, use AreDpiAwarenessContextsEqual function</remarks>
		public static readonly IntPtr DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = new IntPtr(-2);

		/// <summary>
		/// Gets the predefined DPI_AWARENESS_CONTEXT handle for the Per Monitor mode. These windows check for the DPI when
		/// they are created and adjust the scale factor whenever the DPI changes. These processes are not automatically
		/// scaled by the system.
		/// </summary>
		/// <remarks>DPI_AWARENESS_CONTEXT values should never be compared directly. Instead, use AreDpiAwarenessContextsEqual function</remarks>
		public static readonly IntPtr DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = new IntPtr(-3);

		/// <summary>
		/// Gets the predefined DPI_AWARENESS_CONTEXT handle for Per Monitor v2 mode.
		/// Per Monitor v2 is an advancement over the original Per Monitor DPI awareness mode, which enables applications to access
		/// new DPI-related scaling behaviors on a per top-level window basis. Per Monitor v2 was made available in the
		/// Creators Update of Windows 10, and is not available on earlier versions of the operating system. The additional behaviors
		/// introduced are as follows:
		/// <list type="bullet">
		/// <item>Child window DPI change notifications - In Per Monitor v2 contexts, the entire window tree is notified of any DPI changes that occur.</item>
		/// <item>Scaling of non-client area - All windows will automatically have their non-client area drawn in a DPI sensitive fashion. Calls to EnableNonClientDpiScaling are unnecessary.</item>
		/// <item>Scaling of Win32 menus - All NTUSER menus created in Per Monitor v2 contexts will be scaling in a per-monitor fashion.</item>
		/// <item>Dialog Scaling - Win32 dialogs created in Per Monitor v2 contexts will automatically respond to DPI changes.</item>
		/// <item>Improved scaling of comctl32 controls - Various comctl32 controls have improved DPI scaling behavior in Per Monitor v2 contexts.</item>
		/// <item>Improved theming behavior - UxTheme handles opened in the context of a Per Monitor v2 window will operate in terms of the DPI associated with that window.</item>
		/// </list>
		/// </summary>
		/// <remarks>DPI_AWARENESS_CONTEXT values should never be compared directly. Instead, use AreDpiAwarenessContextsEqual function</remarks>
		public static readonly IntPtr DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = new IntPtr(-4);

		/// <summary>
		/// A special windows handle used to indicate to <see cref="M:PInvoke.User32.SendMessage(System.IntPtr,PInvoke.User32.WindowMessage,System.IntPtr,System.IntPtr)" />
		/// that the message is sent to all top-level windows in the system, including disabled or invisible unowned windows,
		/// overlapped windows, and pop-up windows.
		/// </summary>
		public static readonly IntPtr HWND_BROADCAST = (IntPtr) ((int) ushort.MaxValue);

		/// <summary>
		/// The multiplicative constant 120 for calculating mouse wheel movement.
		/// </summary>
		/// <remarks>
		/// See https://msdn.microsoft.com/en-us/library/windows/desktop/ms646254(v=vs.85).aspx
		/// </remarks>
		public const int WHEEL_DELTA = 120;

		/// <summary>Size of a device name string</summary>
		public const int CCHDEVICENAME = 32;

		/// <summary>
		/// Default parameters for <see cref="M:PInvoke.User32.CreateWindowEx(PInvoke.User32.WindowStylesEx,System.String,System.String,PInvoke.User32.WindowStyles,System.Int32,System.Int32,System.Int32,System.Int32,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr)" />
		/// </summary>
		public const int CW_USEDEFAULT = -2147483648;

		/// <summary>Size of a font name or a font family name</summary>
		public const int LF_FACESIZE = 32;

		/// <summary>
		/// Plays a waveform sound. The waveform sound for each sound type is identified by an entry in the registry.
		/// </summary>
		/// <param name="uType">The sound to be played. The sounds are set by the user through the Sound control panel application, and then stored in the registry.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MessageBeep(User32.MessageBeepType uType);

		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern User32.MessageBoxResult MessageBox(IntPtr hWnd, string text, string caption,
		                                                        User32.MessageBoxOptions options);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int MessageBoxIndirect(ref User32.MSGBOXPARAMS lpMsgBoxParams);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int SetWindowLong(IntPtr hWnd, User32.WindowLongIndexFlags nIndex,
		                                       User32.SetWindowLongFlags dwNewLong);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, User32.WindowLongIndexFlags nIndex);

		/// <summary>
		/// Retrieves the name of the class to which the specified window belongs.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="lpClassName">The class name string.</param>
		/// <param name="nMaxCount">
		/// The length of the <paramref name="lpClassName" /> buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the class name string is truncated to <paramref name="nMaxCount" />-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer, not including the terminating null character.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetClassName(IntPtr hWnd, char* lpClassName, int nMaxCount);

		/// <summary>
		/// Retrieves the identifier of the thread that created the specified window and, optionally, the identifier of the process that created the window.
		/// </summary>
		/// <param name="hWnd">A handle to the window. </param>
		/// <param name="lpdwProcessId">A pointer to a variable that receives the process identifier. If this parameter is not NULL, GetWindowThreadProcessId copies the identifier of the process to the variable; otherwise, it does not.</param>
		/// <returns>The return value is the identifier of the thread that created the window. </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		/// <summary>
		/// Attaches or detaches the input processing mechanism of one thread to that of another thread.
		/// </summary>
		/// <param name="idAttach">The identifier of the thread to be attached to another thread. The thread to be attached cannot be a system thread.</param>
		/// <param name="idAttachTo">The identifier of the thread to which idAttach will be attached. This thread cannot be a system thread. A thread cannot attach to itself. Therefore, idAttachTo cannot equal idAttach.</param>
		/// <param name="fAttach">If this parameter is TRUE, the two threads are attached. If the parameter is FALSE, the threads are detached.</param>
		/// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call GetLastError. Windows Server2003 and WindowsXP: There is no extended error information; do not call GetLastError. This behavior changed as of WindowsVista.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool AttachThreadInput(int idAttach, int idAttachTo,
		                                            [MarshalAs(UnmanagedType.Bool)] bool fAttach);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		/// <summary>
		/// Retrieves the coordinates of a window's client area. The client coordinates specify the upper-left and lower-right corners of the client area. Because client coordinates are relative to the upper-left corner of a window's client area, the coordinates of the upper-left corner are (0,0).
		/// </summary>
		/// <param name="hWnd">A handle to the window whose client coordinates are to be retrieved.</param>
		/// <param name="lpRect">A pointer to a RECT structure that receives the client coordinates. The left and top members are zero. The right and bottom members contain the width and height of the window.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool GetCursorPos(out POINT lpPoint);

		/// <summary>
		/// Retrieves a handle to the foreground window (the window with which the user is currently
		/// working). The system assigns a slightly higher priority to the thread that creates the
		/// foreground window than it does to other threads.
		/// <para>
		/// See https://msdn.microsoft.com/en-us/library/windows/desktop/ms633505%28v=vs.85%29.aspx
		/// for more information.
		/// </para>
		/// </summary>
		/// <returns>
		/// C++ ( Type: Type: HWND ) <br /> The return value is a handle to the foreground window. The
		/// foreground window can be NULL in certain circumstances, such as when a window is losing activation.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetForegroundWindow();

		/// <summary>
		/// Changes the size, position, and Z order of a child, pop-up, or top-level window. These
		/// windows are ordered according to their appearance on the screen. The topmost window
		/// receives the highest rank and is the first window in the Z order.
		/// <para>
		/// See https://msdn.microsoft.com/en-us/library/windows/desktop/ms633545%28v=vs.85%29.aspx
		/// for more information.
		/// </para>
		/// </summary>
		/// <param name="hWnd">C++ ( hWnd Type: HWND ) <br /> A handle to the window.</param>
		/// <param name="hWndInsertAfter">
		/// C++ ( hWndInsertAfter Type: HWND ) <br /> A handle to the window to
		/// precede the positioned window in the Z order. This parameter must be a window handle or
		/// one of the following values.
		/// <list type="table">
		/// <itemheader>
		/// <term>HWND placement</term>
		/// <description>Window to precede placement</description>
		/// </itemheader>
		/// <item>
		/// <term>HWND_BOTTOM ((HWND)1)</term>
		/// <description>
		/// Places the window at the bottom of the Z order. If the hWnd parameter identifies a
		/// topmost window, the window loses its topmost status and is placed at the bottom of all
		/// other windows.
		/// </description>
		/// </item>
		/// <item>
		/// <term>HWND_NOTOPMOST ((HWND)-2)</term>
		/// <description>
		/// Places the window above all non-topmost windows (that is, behind all topmost windows).
		/// This flag has no effect if the window is already a non-topmost window.
		/// </description>
		/// </item>
		/// <item>
		/// <term>HWND_TOP ((HWND)0)</term>
		/// <description>Places the window at the top of the Z order.</description>
		/// </item>
		/// <item>
		/// <term>HWND_TOPMOST ((HWND)-1)</term>
		/// <description>
		/// Places the window above all non-topmost windows. The window maintains its topmost
		/// position even when it is deactivated.
		/// </description>
		/// </item>
		/// </list>
		/// <para>
		/// For more information about how this parameter is used, see the following Remarks section.
		/// </para>
		/// </param>
		/// <param name="X">
		/// C++ ( X Type: int ) <br /> The new position of the left side of the window, in
		/// client coordinates.
		/// </param>
		/// <param name="Y">
		/// C++ ( Y Type: int ) <br /> The new position of the top of the window, in client coordinates.
		/// </param>
		/// <param name="cx">C++ ( cx Type: int ) <br /> The new width of the window, in pixels.</param>
		/// <param name="cy">
		/// C++ ( cy Type: int ) <br /> The new height of the window, in pixels.
		/// </param>
		/// <param name="uFlags">
		/// C++ ( uFlags Type: UINT ) <br /> The window sizing and positioning flags. This
		/// parameter can be a combination of the following values.
		/// <list type="table">
		/// <itemheader>
		/// <term>HWND sizing and positioning flags</term>
		/// <description>Where to place and size window. Can be a combination of any</description>
		/// </itemheader>
		/// <item>
		/// <term>SWP_ASYNCWINDOWPOS (0x4000)</term>
		/// <description>
		/// If the calling thread and the thread that owns the window are attached to different input
		/// queues, the system posts the request to the thread that owns the window. This prevents
		/// the calling thread from blocking its execution while other threads process the request.
		/// </description>
		/// </item>
		/// <item>
		/// <term>SWP_DEFERERASE (0x2000)</term>
		/// <description>Prevents generation of the WM_SYNCPAINT message.</description>
		/// </item>
		/// <item>
		/// <term>SWP_DRAWFRAME (0x0020)</term>
		/// <description>
		/// Draws a frame (defined in the window's class description) around the window.
		/// </description>
		/// </item>
		/// <item>
		/// <term>SWP_FRAMECHANGED (0x0020)</term>
		/// <description>
		/// Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE
		/// message to the window, even if the window's size is not being changed. If this flag is
		/// not specified, WM_NCCALCSIZE is sent only when the window's size is being changed
		/// </description>
		/// </item>
		/// <item>
		/// <term>SWP_HIDEWINDOW (0x0080)</term>
		/// <description>Hides the window.</description>
		/// </item>
		/// <item>
		/// <term>SWP_NOACTIVATE (0x0010)</term>
		/// <description>
		/// Does not activate the window. If this flag is not set, the window is activated and moved
		/// to the top of either the topmost or non-topmost group (depending on the setting of the
		/// hWndInsertAfter parameter).
		/// </description>
		/// </item>
		/// <item>
		/// <term>SWP_NOCOPYBITS (0x0100)</term>
		/// <description>
		/// Discards the entire contents of the client area. If this flag is not specified, the valid
		/// contents of the client area are saved and copied back into the client area after the
		/// window is sized or repositioned.
		/// </description>
		/// </item>
		/// <item>
		/// <term>SWP_NOMOVE (0x0002)</term>
		/// <description>Retains the current position (ignores X and Y parameters).</description>
		/// </item>
		/// <item>
		/// <term>SWP_NOOWNERZORDER (0x0200)</term>
		/// <description>Does not change the owner window's position in the Z order.</description>
		/// </item>
		/// <item>
		/// <term>SWP_NOREDRAW (0x0008)</term>
		/// <description>
		/// Does not redraw changes. If this flag is set, no repainting of any kind occurs. This
		/// applies to the client area, the nonclient area (including the title bar and scroll bars),
		/// and any part of the parent window uncovered as a result of the window being moved. When
		/// this flag is set, the application must explicitly invalidate or redraw any parts of the
		/// window and parent window that need redrawing.
		/// </description>
		/// </item>
		/// <item>
		/// <term>SWP_NOREPOSITION (0x0200)</term>
		/// <description>Same as the SWP_NOOWNERZORDER flag.</description>
		/// </item>
		/// <item>
		/// <term>SWP_NOSENDCHANGING (0x0400)</term>
		/// <description>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</description>
		/// </item>
		/// <item>
		/// <term>SWP_NOSIZE (0x0001)</term>
		/// <description>Retains the current size (ignores the cx and cy parameters).</description>
		/// </item>
		/// <item>
		/// <term>SWP_NOZORDER (0x0004)</term>
		/// <description>Retains the current Z order (ignores the hWndInsertAfter parameter).</description>
		/// </item>
		/// <item>
		/// <term>SWP_SHOWWINDOW (0x0040)</term>
		/// <description>Displays the window.</description>
		/// </item>
		/// </list>
		/// </param>
		/// <returns>
		/// <c>true</c> or nonzero if the function succeeds, <c>false</c> or zero otherwise or if
		/// function fails.
		/// </returns>
		/// <remarks>
		/// <para>
		/// As part of the Vista re-architecture, all services were moved off the interactive desktop
		/// into Session 0. hwnd and window manager operations are only effective inside a session
		/// and cross-session attempts to manipulate the hwnd will fail. For more information, see
		/// The Windows Vista Developer Story: Application Compatibility Cookbook.
		/// </para>
		/// <para>
		/// If you have changed certain window data using SetWindowLong, you must call SetWindowPos
		/// for the changes to take effect. Use the following combination for uFlags: SWP_NOMOVE |
		/// SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED.
		/// </para>
		/// <para>
		/// A window can be made a topmost window either by setting the hWndInsertAfter parameter to
		/// HWND_TOPMOST and ensuring that the SWP_NOZORDER flag is not set, or by setting a window's
		/// position in the Z order so that it is above any existing topmost windows. When a
		/// non-topmost window is made topmost, its owned windows are also made topmost. Its owners,
		/// however, are not changed.
		/// </para>
		/// <para>
		/// If neither the SWP_NOACTIVATE nor SWP_NOZORDER flag is specified (that is, when the
		/// application requests that a window be simultaneously activated and its position in the Z
		/// order changed), the value specified in hWndInsertAfter is used only in the following circumstances.
		/// </para>
		/// <list type="bullet">
		/// <item>Neither the HWND_TOPMOST nor HWND_NOTOPMOST flag is specified in hWndInsertAfter.</item>
		/// <item>The window identified by hWnd is not the active window.</item>
		/// </list>
		/// <para>
		/// An application cannot activate an inactive window without also bringing it to the top of
		/// the Z order. Applications can change an activated window's position in the Z order
		/// without restrictions, or it can activate a window and then move it to the top of the
		/// topmost or non-topmost windows.
		/// </para>
		/// <para>
		/// If a topmost window is repositioned to the bottom (HWND_BOTTOM) of the Z order or after
		/// any non-topmost window, it is no longer topmost. When a topmost window is made
		/// non-topmost, its owners and its owned windows are also made non-topmost windows.
		/// </para>
		/// <para>
		/// A non-topmost window can own a topmost window, but the reverse cannot occur. Any window
		/// (for example, a dialog box) owned by a topmost window is itself made a topmost window, to
		/// ensure that all owned windows stay above their owner.
		/// </para>
		/// <para>
		/// If an application is not in the foreground, and should be in the foreground, it must call
		/// the SetForegroundWindow function.
		/// </para>
		/// <para>
		/// To use SetWindowPos to bring a window to the top, the process that owns the window must
		/// have SetForegroundWindow permission.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy,
		                                       User32.SetWindowPosFlags uFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight,
		                                     [MarshalAs(UnmanagedType.Bool)] bool bRepaint);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		/// <summary>
		/// The ReleaseDC function releases a device context (DC), freeing it for use by other applications. The effect of the ReleaseDC function depends on the type of DC. It frees only common and window DCs. It has no effect on class or private DCs.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be released.</param>
		/// <param name="hDC">A handle to the DC to be released.</param>
		/// <returns>
		/// The return value indicates whether the DC was released. If the DC was released, the return value is 1.
		/// If the DC was not released, the return value is zero.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

		/// <summary>
		/// Retrieves a handle to the top-level window whose class name and window name match the specified strings. This function does not search child windows. This function does not perform a case-sensitive search. To search child windows, beginning with a specified child window, use the FindWindowEx function.
		/// </summary>
		/// <param name="lpClassName">The window class name. If lpClassName is NULL, it finds any window whose title matches the lpWindowName parameter. </param>
		/// <param name="lpWindowName">The window name (the window's title). If this parameter is NULL, all window names match.</param>
		/// <returns>If the function succeeds, the return value is a handle to the window that has the specified
		/// class name and window name. If the function fails, the return value is NULL.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className,
		                                         string windowTitle);

		/// <summary>Shows a Window</summary>
		/// <remarks>
		/// <para>To perform certain special effects when showing or hiding a window, use AnimateWindow.</para>
		/// <para>
		/// The first time an application calls ShowWindow, it should use the WinMain function's
		/// nCmdShow parameter as its nCmdShow parameter. Subsequent calls to ShowWindow must use one
		/// of the values in the given list, instead of the one specified by the WinMain function's
		/// nCmdShow parameter.
		/// </para>
		/// <para>
		/// As noted in the discussion of the nCmdShow parameter, the nCmdShow value is ignored in
		/// the first call to ShowWindow if the program that launched the application specifies
		/// startup information in the structure. In this case, ShowWindow uses the information
		/// specified in the STARTUPINFO structure to show the window. On subsequent calls, the
		/// application must call ShowWindow with nCmdShow set to SW_SHOWDEFAULT to use the startup
		/// information provided by the program that launched the application. This behavior is
		/// designed for the following situations:
		/// </para>
		/// <list type="">
		/// <item>
		/// Applications create their main window by calling CreateWindow with the WS_VISIBLE flag set.
		/// </item>
		/// <item>
		/// Applications create their main window by calling CreateWindow with the WS_VISIBLE flag
		/// cleared, and later call ShowWindow with the SW_SHOW flag set to make it visible.
		/// </item>
		/// </list>
		/// </remarks>
		/// <param name="hWnd">Handle to the window.</param>
		/// <param name="nCmdShow">
		/// Specifies how the window is to be shown. This parameter is ignored the first time an
		/// application calls ShowWindow, if the program that launched the application provides a
		/// STARTUPINFO structure. Otherwise, the first time ShowWindow is called, the value should
		/// be the value obtained by the WinMain function in its nCmdShow parameter. In subsequent
		/// calls, this parameter can be one of the WindowShowStyle members.
		/// </param>
		/// <returns>
		/// If the window was previously visible, the return value is nonzero. If the window was
		/// previously hidden, the return value is zero.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowWindow(IntPtr hWnd, User32.WindowShowStyle nCmdShow);

		/// <summary>
		/// Retrieves a handle to the desktop window. The desktop window covers the entire screen. The desktop window is the area on top of which other windows are painted.
		/// </summary>
		/// <returns>The return value is a handle to the desktop window.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetDesktopWindow();

		/// <summary>Retrieves a handle to the Shell's desktop window.</summary>
		/// <returns>The return value is the handle of the Shell's desktop window. If no Shell process is present, the return value is NULL.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetShellWindow();

		/// <summary>
		/// Sends the specified message to a window or windows. The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function. To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </param>
		/// <param name="wMsg">
		/// The message to be sent.
		/// For lists of the system-provided messages, see <see cref="T:PInvoke.User32.WindowMessage" />.
		/// </param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe IntPtr SendMessage(IntPtr hWnd, User32.WindowMessage wMsg, void* wParam,
		                                               void* lParam);

		/// <summary>
		/// Places (posts) a message in the message queue associated with the thread that created the specified window and returns without waiting for the thread to process the message.
		/// To post a message in the message queue associated with a thread, use the PostThreadMessage function.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure is to receive the message.
		/// </param>
		/// <param name="wMsg">
		/// The message to be posted.
		/// For lists of the system-provided messages, see <see cref="T:PInvoke.User32.WindowMessage" />.
		/// </param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. GetLastError returns ERROR_NOT_ENOUGH_QUOTA when the limit is hit.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool
			PostMessage(IntPtr hWnd, User32.WindowMessage wMsg, void* wParam, void* lParam);

		/// <summary>Sends the specified message to one or more windows.</summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message.
		/// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows.
		/// The function does not return until each window has timed out.
		/// Therefore, the total wait time can be up to the value of uTimeout multiplied by the number of top-level windows.
		/// </param>
		/// <param name="msg">
		/// The message to be sent.
		/// For lists of the system-provided messages, see <see cref="T:PInvoke.User32.WindowMessage" />.
		/// </param>
		/// <param name="wParam">Any additional message-specific information.</param>
		/// <param name="lParam">Any additional message-specific information.</param>
		/// <param name="flags">The behavior of this function. This parameter can be one or more of the following values: <see cref="T:PInvoke.User32.SendMessageTimeoutFlags" />. </param>
		/// <param name="timeout">The duration of the time-out period, in milliseconds.
		/// If the message is a broadcast message, each window can use the full time-out period.
		/// For example, if you specify a five second time-out period and there are three top-level windows that fail to process the message, you could have up to a 15 second delay.
		/// </param>
		/// <param name="pdwResult">The result of the message processing. The value of this parameter depends on the message that is specified.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// SendMessageTimeout does not provide information about individual windows timing out if HWND_BROADCAST is used.
		/// If the function fails or times out, the return value is 0.
		/// To get extended error information, call GetLastError.
		/// If GetLastError returns ERROR_TIMEOUT, then the function timed out.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr SendMessageTimeout(IntPtr hWnd, User32.WindowMessage msg, IntPtr wParam,
		                                               IntPtr lParam, User32.SendMessageTimeoutFlags flags, int timeout,
		                                               out IntPtr pdwResult);

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
		public static extern IntPtr GetAncestor(IntPtr hWnd, User32.GetAncestorFlags gaFlags);

		/// <summary>
		///     Installs an application-defined hook procedure into a hook chain. You would install a hook procedure to
		///     monitor the system for certain types of events. These events are associated either with a specific thread or with
		///     all threads in the same desktop as the calling thread.
		/// </summary>
		/// <param name="idHook">The type of hook procedure to be installed.</param>
		/// <param name="lpfn">
		///     A pointer to the hook procedure. If the <paramref name="dwThreadId" /> parameter is zero or
		///     specifies the identifier of a thread created by a different process, the <paramref name="lpfn" /> parameter must
		///     point to a hook procedure in a DLL. Otherwise, <paramref name="lpfn" /> can point to a hook procedure in the code
		///     associated with the current process.
		/// </param>
		/// <param name="hMod">
		///     A handle to the DLL containing the hook procedure pointed to by the <paramref name="lpfn" />
		///     parameter. The <paramref name="hMod" /> parameter must be set to <see cref="F:System.IntPtr.Zero" /> if the
		///     <paramref name="dwThreadId" /> parameter specifies a thread created by the current process and if the hook
		///     procedure is within the code associated with the current process.
		/// </param>
		/// <param name="dwThreadId">
		///     The identifier of the thread with which the hook procedure is to be associated. For desktop
		///     apps, if this parameter is zero, the hook procedure is associated with all existing threads running in the same
		///     desktop as the calling thread. For Windows Store apps, see the Remarks section.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is the handle to the hook procedure.
		///     <para>
		///         If the function fails, the return value is an invalid handle. To get extended error information,
		///         call GetLastError.
		///     </para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeHookHandle SetWindowsHookEx(User32.WindowsHookType idHook,
		                                                            User32.WindowsHookDelegate lpfn, IntPtr hMod,
		                                                            int dwThreadId);

		/// <summary>
		///     Installs an application-defined hook procedure into a hook chain. You would install a hook procedure to
		///     monitor the system for certain types of events. These events are associated either with a specific thread or with
		///     all threads in the same desktop as the calling thread.
		/// </summary>
		/// <param name="idHook">The type of hook procedure to be installed.</param>
		/// <param name="lpfn">
		///     A pointer to the hook procedure. If the <paramref name="dwThreadId" /> parameter is zero or
		///     specifies the identifier of a thread created by a different process, the <paramref name="lpfn" /> parameter must
		///     point to a hook procedure in a DLL. Otherwise, <paramref name="lpfn" /> can point to a hook procedure in the code
		///     associated with the current process.
		/// </param>
		/// <param name="hMod">
		///     A handle to the DLL containing the hook procedure pointed to by the <paramref name="lpfn" />
		///     parameter. The <paramref name="hMod" /> parameter must be set to <see cref="F:System.IntPtr.Zero" /> if the
		///     <paramref name="dwThreadId" /> parameter specifies a thread created by the current process and if the hook
		///     procedure is within the code associated with the current process.
		/// </param>
		/// <param name="dwThreadId">
		///     The identifier of the thread with which the hook procedure is to be associated. For desktop
		///     apps, if this parameter is zero, the hook procedure is associated with all existing threads running in the same
		///     desktop as the calling thread. For Windows Store apps, see the Remarks section.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is the handle to the hook procedure.
		///     <para>
		///         If the function fails, the return value is an invalid handle. To get extended error information,
		///         call GetLastError.
		///     </para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeHookHandle SetWindowsHookEx(User32.WindowsHookType idHook, IntPtr lpfn,
		                                                            IntPtr hMod, int dwThreadId);

		/// <summary>Sets an event hook function for a range of events.</summary>
		/// <param name="eventMin">Specifies the event constant for the lowest event value in the range of events that are handled by
		/// the hook function. This parameter can be set to EVENT_MIN to indicate the lowest possible event value.</param>
		/// <param name="eventMax">Specifies the event constant for the highest event value in the range of events that are handled by
		/// the hook function. This parameter can be set to EVENT_MAX to indicate the highest possible event value.</param>
		/// <param name="hmodWinEventProc">Handle to the DLL that contains the hook function at lpfnWinEventProc, if the WINEVENT_INCONTEXT
		/// flag is specified in the dwFlags parameter. If the hook function is not located in a DLL, or if the WINEVENT_OUTOFCONTEXT flag
		/// is specified, this parameter is NULL.</param>
		/// <param name="lpfnWinEventProc">Pointer to the event hook function. For more information about this function, see WinEventProc.</param>
		/// <param name="idProcess">Specifies the ID of the process from which the hook function receives events. Specify zero (0) to
		/// receive events from all processes on the current desktop.</param>
		/// <param name="idThread">Specifies the ID of the thread from which the hook function receives events. If this parameter is zero,
		/// the hook function is associated with all existing threads on the current desktop.</param>
		/// <param name="dwflags">Flag values that specify the location of the hook function and of the events to be skipped. </param>
		/// <returns>If successful, returns an <see cref="T:PInvoke.User32.SafeEventHookHandle" /> value that identifies this event hook instance.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeEventHookHandle SetWinEventHook(User32.WindowsEventHookType eventMin,
		                                                                User32.WindowsEventHookType eventMax,
		                                                                IntPtr hmodWinEventProc,
		                                                                IntPtr lpfnWinEventProc, int idProcess,
		                                                                int idThread,
		                                                                User32.WindowsEventHookFlags dwflags);

		/// <summary>Sets an event hook function for a range of events.</summary>
		/// <param name="eventMin">Specifies the event constant for the lowest event value in the range of events that are handled by
		/// the hook function. This parameter can be set to EVENT_MIN to indicate the lowest possible event value.</param>
		/// <param name="eventMax">Specifies the event constant for the highest event value in the range of events that are handled by
		/// the hook function. This parameter can be set to EVENT_MAX to indicate the highest possible event value.</param>
		/// <param name="hmodWinEventProc">Handle to the DLL that contains the hook function at lpfnWinEventProc, if the WINEVENT_INCONTEXT
		/// flag is specified in the dwFlags parameter. If the hook function is not located in a DLL, or if the WINEVENT_OUTOFCONTEXT flag
		/// is specified, this parameter is NULL.</param>
		/// <param name="lpfnWinEventProc">Pointer to the event hook function. For more information about this function, see WinEventProc.</param>
		/// <param name="idProcess">Specifies the ID of the process from which the hook function receives events. Specify zero (0) to
		/// receive events from all processes on the current desktop.</param>
		/// <param name="idThread">Specifies the ID of the thread from which the hook function receives events. If this parameter is zero,
		/// the hook function is associated with all existing threads on the current desktop.</param>
		/// <param name="dwflags">Flag values that specify the location of the hook function and of the events to be skipped. </param>
		/// <returns>If successful, returns an <see cref="T:PInvoke.User32.SafeEventHookHandle" /> value that identifies this event hook instance.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeEventHookHandle SetWinEventHook(User32.WindowsEventHookType eventMin,
		                                                                User32.WindowsEventHookType eventMax,
		                                                                IntPtr hmodWinEventProc,
		                                                                User32.WinEventProc lpfnWinEventProc,
		                                                                int idProcess, int idThread,
		                                                                User32.WindowsEventHookFlags dwflags);

		/// <summary>
		///     Passes the hook information to the next hook procedure in the current hook chain. A hook procedure can call
		///     this function either before or after processing the hook information.
		/// </summary>
		/// <param name="hhk">This parameter is ignored.</param>
		/// <param name="nCode">
		///     The hook code passed to the current hook procedure. The next hook procedure uses this code to
		///     determine how to process the hook information.
		/// </param>
		/// <param name="wParam">
		///     The wParam value passed to the current hook procedure. The meaning of this parameter depends on
		///     the type of hook associated with the current hook chain.
		/// </param>
		/// <param name="lParam">
		///     The lParam value passed to the current hook procedure. The meaning of this parameter depends on
		///     the type of hook associated with the current hook chain.
		/// </param>
		/// <returns>
		///     This value is returned by the next hook procedure in the chain. The current hook procedure must also return
		///     this value. The meaning of the return value depends on the hook type. For more information, see the descriptions of
		///     the individual hook procedures.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		/// <summary>
		///     Sets the mouse capture to the specified window belonging to the current thread.SetCapture captures mouse input
		///     either when the mouse is over the capturing window, or when the mouse button was pressed while the mouse was over
		///     the capturing window and the button is still down. Only one window at a time can capture the mouse.
		///     <para>
		///         If the mouse cursor is over a window created by another thread, the system will direct mouse input to the
		///         specified window only if a mouse button is down.
		///     </para>
		/// </summary>
		/// <param name="hWnd">A handle to the window in the current thread that is to capture the mouse.</param>
		/// <returns>
		///     The return value is a handle to the window that had previously captured the mouse. If there is no such window,
		///     the return value is <see cref="F:System.IntPtr.Zero" />.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr SetCapture(IntPtr hWnd);

		/// <summary>
		///     Releases the mouse capture from a window in the current thread and restores normal mouse input processing. A
		///     window that has captured the mouse receives all mouse input, regardless of the position of the cursor, except when
		///     a mouse button is clicked while the cursor hot spot is in the window of another thread.
		/// </summary>
		/// <returns>
		///     If the function succeeds, the return value is true.
		///     <para>If the function fails, the return value is false. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ReleaseCapture();

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, User32.PrintWindowFlags nFlags);

		/// <summary>Flashes the specified window. It does not change the active state of the window.</summary>
		/// <param name="pwfi">A pointer to a <see cref="T:PInvoke.User32.FLASHWINFO" /> structure.</param>
		/// <returns>
		///     The return value specifies the window's state before the call to the FlashWindowEx function. If the window
		///     caption was drawn as active before the call, the return value is nonzero. Otherwise, the return value is zero.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlashWindowEx(ref User32.FLASHWINFO pwfi);

		/// <summary>
		///     Enables the application to access the window menu (also known as the system menu or the control menu) for
		///     copying and modifying.
		/// </summary>
		/// <param name="hWnd">A handle to the window that will own a copy of the window menu.</param>
		/// <param name="bRevert">
		///     The action to be taken. If this parameter is FALSE, GetSystemMenu returns a handle to the copy of
		///     the window menu currently in use. The copy is initially identical to the window menu, but it can be modified. If
		///     this parameter is TRUE, GetSystemMenu resets the window menu back to the default state. The previous window menu,
		///     if any, is destroyed.
		/// </param>
		/// <returns>
		///     If the bRevert parameter is FALSE, the return value is a handle to a copy of the window menu. If the bRevert
		///     parameter is TRUE, the return value is NULL.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetSystemMenu(IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bRevert);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadCursor(IntPtr hInstance, IntPtr lpCursorName);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadIcon(IntPtr hInstance, string lpIconName);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr lpIconName);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr RealChildWindowFromPoint(IntPtr hwndParent, POINT ptParentClientCoords);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowDisplayAffinity(IntPtr hWnd, int dwAffinity);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe uint RealGetWindowClass(IntPtr hwnd, char* pszType, uint cchType);

		/// <summary>
		///     Appends a new item to the end of the specified menu bar, drop-down menu, submenu, or shortcut menu. You can
		///     use this function to specify the content, appearance, and behavior of the menu item.
		/// </summary>
		/// <param name="hMenu">A handle to the menu bar, drop-down menu, submenu, or shortcut menu to be changed.</param>
		/// <param name="uFlags">Controls the appearance and behavior of the new menu item</param>
		/// <param name="uIdNewItem">
		///     The identifier of the new menu item or, if the uFlags parameter is set to
		///     <see cref="F:PInvoke.User32.MenuItemFlags.MF_POPUP" />, a handle to the drop-down menu or submenu.
		/// </param>
		/// <param name="lpNewItem">
		///     The content of the new menu item. The interpretation of lpNewItem depends on whether the uFlags parameter includes
		///     the following values.
		///     <para><see cref="F:PInvoke.User32.MenuItemFlags.MF_BITMAP" />: Contains a bitmap handle.</para>
		///     <para>
		///         <see cref="F:PInvoke.User32.MenuItemFlags.MF_OWNERDRAW" />: Contains an application-supplied value that can be used to
		///         maintain additional data related to the menu item. The value is in the itemData member of the structure pointed
		///         to by the lParam parameter of the WM_MEASUREITEM or WM_DRAWITEM message sent when the menu is created or its
		///         appearance is updated.
		///     </para>
		///     <para><see cref="F:PInvoke.User32.MenuItemFlags.MF_STRING" />: Contains a pointer to a null-terminated string.</para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is true.
		///     <para>If the function fails, the return value is false. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AppendMenu(IntPtr hMenu, User32.MenuItemFlags uFlags, IntPtr uIdNewItem,
		                                     string lpNewItem);

		/// <summary>Changes information about a menu item.</summary>
		/// <param name="hMenu">A handle to the menu that contains the menu item.</param>
		/// <param name="uItem">
		///     The identifier or position of the menu item to change. The meaning of this parameter depends on the
		///     value of <paramref name="fByPosition" />.
		/// </param>
		/// <param name="fByPosition">
		///     The meaning of uItem. If this parameter is FALSE, uItem is a menu item identifier. Otherwise,
		///     it is a menu item position.
		/// </param>
		/// <param name="lpmii">
		///     A <see cref="T:PInvoke.User32.MENUITEMINFO" /> structure that contains information about the menu item and specifies
		///     which menu item attributes to change.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is true.
		///     <para>If the function fails, the return value is false. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMenuItemInfo(IntPtr hMenu, uint uItem,
		                                          [MarshalAs(UnmanagedType.Bool)] bool fByPosition,
		                                          [In] ref User32.MENUITEMINFO lpmii);

		/// <summary>Retrieves information about a menu item.</summary>
		/// <param name="hMenu">A handle to the menu that contains the menu item.</param>
		/// <param name="uItem">
		///     The identifier or position of the menu item to get information about. The meaning of this parameter
		///     depends on the value of <paramref name="fByPosition" />.
		/// </param>
		/// <param name="fByPosition">
		///     The meaning of <paramref name="uItem" />. If this parameter is FALSE,
		///     <paramref name="uItem" /> is a menu item identifier. Otherwise, it is a menu item position.
		/// </param>
		/// <param name="lpmii">
		///     A <see cref="T:PInvoke.User32.MENUITEMINFO" /> structure that specifies the information to retrieve and receives
		///     information about the menu item. Note that you must set the cbSize member to <code>sizeof(MENUITEMINFO)</code>
		///     before calling this function (Either manually or by using <see cref="M:PInvoke.User32.MENUITEMINFO.Create" />).
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is true.
		///     <para>If the function fails, the return value is false. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMenuItemInfo(IntPtr hMenu, uint uItem,
		                                          [MarshalAs(UnmanagedType.Bool)] bool fByPosition,
		                                          ref User32.MENUITEMINFO lpmii);

		/// <summary>
		///     Translates (maps) a virtual-key code into a scan code or character value, or translates a scan code into a
		///     virtual-key code.
		///     <para>
		///         To specify a handle to the keyboard layout to use for translating the specified code, use the MapVirtualKeyEx
		///         function.
		///     </para>
		/// </summary>
		/// <param name="uCode">
		///     The virtual key code or scan code for a key. How this value is interpreted depends on the value of
		///     the uMapType parameter.
		/// </param>
		/// <param name="uMapType">
		///     The translation to be performed. The value of this parameter depends on the value of the uCode
		///     parameter.
		/// </param>
		/// <returns>
		///     The return value is either a scan code, a virtual-key code, or a character value, depending on the value of
		///     <paramref name="uCode" /> and <paramref name="uMapType" />. If there is no translation, the return value is zero.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int MapVirtualKey(int uCode, User32.MapVirtualKeyTranslation uMapType);

		/// <summary>Retrieves the window handle to the active window attached to the calling thread's message queue.</summary>
		/// <returns>
		///     The return value is the handle to the active window attached to the calling thread's message queue. Otherwise,
		///     the return value is <see cref="F:System.IntPtr.Zero" />.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetActiveWindow();

		/// <summary>
		/// Determines whether the specified window handle identifies an existing window.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>If the window handle identifies an existing window, the return value is true, otherwise it is false.</returns>
		/// <remarks>
		/// A thread should not use IsWindow for a window that it did not create because the window could be destroyed after this function was called.
		/// Further, because window handles are recycled the handle could even point to a different window.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindow(IntPtr hWnd);

		/// <summary>
		/// Determines whether the calling thread is already a GUI thread. It can also optionally convert the thread to a GUI thread.
		/// </summary>
		/// <param name="bConvert">If TRUE and the thread is not a GUI thread, convert the thread to a GUI thread.</param>
		/// <returns>The function returns a nonzero value (different from <see cref="F:PInvoke.HResult.Code.S_OK" /> but not specified on MSDN documentation) in the following situations:
		/// <list>
		/// <item>If the calling thread is already a GUI thread.</item>
		/// <item>If <paramref name="bConvert" /> is TRUE and the function successfully converts the thread to a GUI thread.</item>
		/// </list>
		/// Otherwise, the function returns <see cref="F:PInvoke.HResult.Code.S_OK" />.
		/// If <paramref name="bConvert" /> is TRUE and the function cannot successfully convert the thread to a GUI thread,
		/// IsGUIThread returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_NOT_ENOUGH_MEMORY" />.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern HResult IsGUIThread([MarshalAs(UnmanagedType.Bool)] bool bConvert);

		/// <summary>
		/// Determines whether a window is a child window or descendant window of a specified parent window.
		/// A child window is the direct descendant of a specified parent window if that parent window is in the chain of parent windows;
		/// the chain of parent windows leads from the original overlapped or pop-up window to the child window.
		/// </summary>
		/// <param name="hWndParent">A handle to the parent window.</param>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>If the window is a child or descendant window of the specified parent window, the return value is true, otherwise it is false.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

		/// <summary>
		/// Determines whether the system considers that a specified application is not responding.
		/// An application is considered to be not responding if it is not waiting for input, is not in startup processing,
		/// and has not called <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> within the internal timeout period of 5 seconds.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>
		/// If the window handle identifies an existing window, the return value is true, otherwise it is false.
		/// Ghost windows always return true.
		/// </returns>
		/// <remarks>
		/// The Windows timeout criteria of 5 seconds is subject to change.
		/// This function was not included in the SDK headers and libraries until Windows XP Service Pack 1 (SP1) and Windows Server 2003.
		/// If you do not have a header file and import library for this function, you can call the function using <see cref="M:PInvoke.Kernel32.LoadLibrary(System.String)" /> and <see cref="M:PInvoke.Kernel32.GetProcAddress(PInvoke.Kernel32.SafeLibraryHandle,System.String)" />.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsHungAppWindow(IntPtr hWnd);

		/// <summary>
		/// Determines whether the specified window is minimized (iconic).
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>If the window is iconic, the return value is true, otherwise it is false.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsIconic(IntPtr hWnd);

		/// <summary>
		/// Determines whether the specified window is a native Unicode window.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>If the window is a native Unicode window, the return value is true, otherwise it is false (the window is a native ANSI window).</returns>
		/// <remarks>
		/// <para>
		/// The character set of a window is determined by the use of the <see cref="M:PInvoke.User32.RegisterClass(PInvoke.User32.WNDCLASS@)" /> function.
		/// If the window class was registered with the ANSI version of <see cref="M:PInvoke.User32.RegisterClass(PInvoke.User32.WNDCLASS@)" /> (RegisterClassA), the character set of the window is ANSI.
		/// If the window class was registered with the Unicode version of <see cref="M:PInvoke.User32.RegisterClass(PInvoke.User32.WNDCLASS@)" /> (RegisterClassW), the character set of the window is Unicode.
		/// </para>
		/// <para>
		/// The system does automatic two-way translation (Unicode to ANSI) for window messages. For example,
		/// if an ANSI window message is sent to a window that uses the Unicode character set,
		/// the system translates that message into a Unicode message before calling the window procedure.
		/// The system calls IsWindowUnicode to determine whether to translate the message or not.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowUnicode(IntPtr hWnd);

		/// <summary>
		/// Determines the visibility state of the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be tested.</param>
		/// <returns>
		/// If the specified window, its parent window, its parent's parent window, and so forth, have the WS_VISIBLE style, the return value is true, otherwise it is false.
		/// Because the return value specifies whether the window has the WS_VISIBLE style, it may be nonzero even if the window is totally obscured by other windows.
		/// </returns>
		/// <remarks>
		/// The visibility state of a window is indicated by the WS_VISIBLE style bit.
		/// When WS_VISIBLE is set, the window is displayed and subsequent drawing into it is displayed as long as the window has the WS_VISIBLE style.
		/// Any drawing to a window with the WS_VISIBLE style will not be displayed if the window is obscured by other windows or is clipped by its parent window.
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

		/// <summary>
		/// Searches through icon or cursor data for the icon or cursor that best fits the current display device.
		/// To specify a desired height or width, use the LookupIconIdFromDirectoryEx function.
		/// </summary>
		/// <param name="presbits">
		/// The icon or cursor directory data. Because this function does not validate the resource data, it causes a general protection (GP) fault or returns an undefined value if <paramref name="presbits" /> is not pointing to valid resource data.
		/// </param>
		/// <param name="fIcon">
		/// Indicates whether an icon or a cursor is sought. If this parameter is TRUE, the function is searching for an icon; if the parameter is FALSE, the function is searching for a cursor.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is an integer resource identifier for the icon or cursor that best fits the current display device.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int LookupIconIdFromDirectory(byte* presbits,
		                                                          [MarshalAs(UnmanagedType.Bool)] bool fIcon);

		/// <summary>
		/// Searches through icon or cursor data for the icon or cursor that best fits the current display device.
		/// To specify a desired height or width, use the LookupIconIdFromDirectoryEx function.
		/// </summary>
		/// <param name="presbits">
		/// The icon or cursor directory data. Because this function does not validate the resource data, it causes a general protection (GP) fault or returns an undefined value if <paramref name="presbits" /> is not pointing to valid resource data.
		/// </param>
		/// <param name="fIcon">
		/// Indicates whether an icon or a cursor is sought. If this parameter is TRUE, the function is searching for an icon; if the parameter is FALSE, the function is searching for a cursor.
		/// </param>
		/// <param name="cxDesired">The desired width, in pixels, of the icon. If this parameter is zero, the function uses the SM_CXICON or SM_CXCURSOR system metric value.</param>
		/// <param name="cyDesired">The desired height, in pixels, of the icon. If this parameter is zero, the function uses the SM_CYICON or SM_CYCURSOR system metric value.</param>
		/// <param name="Flags">A combination of the following values.</param>
		/// <returns>
		/// If the function succeeds, the return value is an integer resource identifier for the icon or cursor that best fits the current display device.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int LookupIconIdFromDirectoryEx(byte* presbits,
		                                                            [MarshalAs(UnmanagedType.Bool)] bool fIcon,
		                                                            int cxDesired, int cyDesired,
		                                                            User32.LookupIconIdFromDirectoryExFlags Flags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int RegisterWindowMessage(string lpString);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowDisplayAffinity(IntPtr hWnd, out int dwAffinity);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool EnumDisplayMonitors(IntPtr hdc, RECT* lprcClip,
		                                                     User32.MONITORENUMPROC lpfnEnum, void* dwData);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClassInfoEx(IntPtr hInstance, string lpClassName,
		                                         ref User32.WNDCLASSEX lpWndClass);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool GetMonitorInfo(IntPtr hMonitor, User32.MONITORINFO* lpmi);

		[DllImport("User32", EntryPoint = "GetMonitorInfo", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool GetMonitorInfoEx(IntPtr hMonitor, User32.MONITORINFOEX* lpmi);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetSystemMetrics(User32.SystemMetric smIndex);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowInfo(IntPtr hwnd, ref User32.WINDOWINFO pwi);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, ref RECT rect,
		                                         [MarshalAs(UnmanagedType.U4)] int cPoints);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromPoint(POINT pt, User32.MonitorOptions dwFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromPoint(POINT point, int flags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromRect(ref RECT lprc, User32.MonitorOptions dwFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr MonitorFromWindow(IntPtr hwnd, User32.MonitorOptions dwFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool SystemParametersInfo(User32.SystemParametersInfoAction uiAction, uint uiParam,
		                                                      void* pvParam, User32.SystemParametersInfoFlags fWinIni);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int QueryDisplayConfig(uint Flags, ref int pNumPathArrayElements,
		                                                   User32.DISPLAYCONFIG_PATH_INFO* pPathInfoArray,
		                                                   ref int pNumModeInfoArrayElements,
		                                                   User32.DISPLAYCONFIG_MODE_INFO* pModeInfoArray,
		                                                   User32.DISPLAYCONFIG_TOPOLOGY_ID pCurrentTopologyId);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern ushort RegisterClass(ref User32.WNDCLASS lpWndClass);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.U2)]
		public static extern short RegisterClassEx(ref User32.WNDCLASSEX lpwcx);

		/// <summary>Retrieves the name of the format from the clipboard.</summary>
		/// <param name="format">The type of format to be retrieved. This parameter must not specify any of the predefined clipboard formats.</param>
		/// <param name="lpszFormatName">The format name string.</param>
		/// <param name="cchMaxCount">
		/// The length of the <paramref name="lpszFormatName" /> buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the format name string is truncated to <paramref name="cchMaxCount" />-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetClipboardFormatName(int format, char* lpszFormatName, int cchMaxCount);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* GetClipboardData(int uFormat);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* SetClipboardData(int uFormat, void* hMem);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OpenClipboard(IntPtr hWndNewOwner);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseClipboard();

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EmptyClipboard();

		/// <summary>
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="nInputs">The number of structures in the <paramref name="pInputs" /> array.</param>
		/// <param name="pInputs">An array of  structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
		/// <param name="cbSize">The size, in bytes, of an <see cref="T:PInvoke.User32.INPUT" /> structure. If cbSize is not the size of an <see cref="T:PInvoke.User32.INPUT" /> structure, the function fails.</param>
		/// <returns>
		/// The function returns the number of events that it successfully inserted into the keyboard or mouse input stream.
		/// If the function returns zero, the input was already blocked by another thread. To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// This function is subject to UIPI. Applications are permitted to inject input only into applications that are at an equal or lesser integrity level.
		/// This function fails when it is blocked by UIPI. Note that neither GetLastError nor the return value will indicate the failure was caused by UIPI blocking.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe uint SendInput(int nInputs, User32.INPUT* pInputs, int cbSize);

		/// <summary>
		/// Waits until the specified process has finished processing its initial input and is waiting for user input with no input pending, or until the time-out interval has elapsed.
		/// </summary>
		/// <param name="hProcess">A handle to the process. If this process is a console application or does not have a message queue, WaitForInputIdle returns immediately.</param>
		/// <param name="dwMilliseconds">The time-out interval, in milliseconds. If dwMilliseconds is INFINITE, the function does not return until the process is idle.</param>
		/// <returns>0 if the wait was satisfied successfully., WAIT_TIMEOUT if the wait was terminated because the time-out interval elapsed, and WAIT_FAILED if an error occurred.</returns>
		/// <remarks>Raymond Chen has a series of articles that give a bit more depth to how this function was intended to be used.
		/// <a href="http://blogs.msdn.com/b/oldnewthing/archive/2010/03/25/9984720.aspx">Here</a> and <a href="http://blogs.msdn.com/b/oldnewthing/archive/2010/03/26/9985422.aspx">here</a>.
		/// The jist of it is that this function should have been really called WaitForProcessStartupComplete, as this is all it does.</remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int WaitForInputIdle(IntPtr hProcess, int dwMilliseconds);

		/// <summary>
		/// Determines whether a key is up or down at the time the function is called, and whether the key was pressed after a previous call to GetAsyncKeyState.
		/// </summary>
		/// <param name="vKey">
		/// The virtual-key code from the <see cref="T:PInvoke.User32.VirtualKey" /> enum.
		/// You can use left- and right-distinguishing constants to specify certain keys.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value specifies whether the key was pressed since the last call to GetAsyncKeyState, and whether the key is currently up or down. If the most significant bit is set, the key is down, and if the least significant bit is set, the key was pressed after /// the previous call to GetAsyncKeyState. However, you should not rely on this last behavior; for more information, see the Remarks on MSDN.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern short GetAsyncKeyState(int vKey);

		/// <summary>
		/// Retrieves the status of the specified virtual key. The status specifies whether the key is up, down, or toggled (on, off—alternating each time the key is pressed).
		/// </summary>
		/// <param name="nVirtKey">
		/// A virtual key code from the <see cref="T:PInvoke.User32.VirtualKey" /> enum. If the desired virtual key is a letter or digit (A through Z, a through z, or 0 through 9), nVirtKey must be set to the ASCII value of that character. For other keys, it must be a virtual-key code.
		/// If a non-English keyboard layout is used, virtual keys with values in the range ASCII A through Z and 0 through 9 are used to specify most of the character keys. For example, for the German keyboard layout,
		/// the virtual key of value ASCII O (0x4F) refers to the "o" key, whereas VK_OEM_1 refers to the "o with umlaut" key.
		/// </param>
		/// <returns>
		/// The return value specifies the status of the specified virtual key, as follows:
		/// If the high-order bit is 1, the key is down; otherwise, it is up.
		/// If the low-order bit is 1, the key is toggled. A key, such as the CAPS LOCK key, is toggled if it is turned on. The key is off and untoggled if the low-order bit is 0. A toggle key's indicator light (if any) on the keyboard will be on when the key is toggled,
		/// and off when the key is untoggled.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern short GetKeyState(int nVirtKey);

		/// <summary>
		/// <para>
		/// Converts a point in a window from logical coordinates into physical coordinates, regardless of the dots per inch (dpi) awareness of the caller.
		/// For more information about DPI awareness levels, see <see cref="T:PInvoke.PROCESS_DPI_AWARENESS" />
		/// </para>
		/// <para>
		/// Tip: Since an application with a value of <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" /> uses the actual DPI of the monitor,
		/// physical and logical coordinates are the same for this app.
		/// </para>
		/// </summary>
		/// <param name="hwnd">A handle to the window whose transform is used for the conversion</param>
		/// <param name="lpPoint">
		/// A pointer to a <see cref="T:PInvoke.POINT" /> structure that specifies the physical/screen coordinates to be converted.
		/// The new logical coordinates are copied into this structure if the function succeeds
		/// </param>
		/// <returns>Returns TRUE if successful, or FALSE otherwise</returns>
		/// <remarks>
		/// <para>
		/// In Windows 8, system–DPI aware applications translated between physical and logical space using
		/// <see cref="M:PInvoke.User32.PhysicalToLogicalPoint(System.IntPtr,PInvoke.POINT@)" /> and <see cref="M:PInvoke.User32.LogicalToPhysicalPoint(System.IntPtr,PInvoke.POINT@)" />.
		/// In Windows 8.1, the additional virtualization of the system and inter-process communications means that for the majority of applications, you do not need these APIs.
		/// As a result, in Windows 8.1, these APIs no longer transform points.
		/// The system returns all points to an application in its own coordinate space.
		/// This behavior preserves functionality for the majority of applications,
		/// but there are some exceptions in which you must make changes to ensure that the application works as expected.
		/// </para>
		/// <para>
		/// For example, an application might need to walk the entire window tree of another process and ask the system for DPI-dependent information about the window.
		/// By default, the system will return the information based on the DPI awareness of the caller. This is ideal for most applications.
		/// However, the caller might need the information based on the DPI awareness of the application associated with the window.
		/// This might be necessary because the two applications send DPI-dependent information between each other directly.
		/// In this case, the application can use <see cref="M:PInvoke.User32.LogicalToPhysicalPointForPerMonitorDPI(System.IntPtr,PInvoke.POINT@)" /> to get physical coordinates and
		/// then use PhysicalToLogicalPointForPerMonitorDPI to convert the physical coordinates
		/// into logical coordinates based on the DPI-awareness of the provided <paramref name="hwnd" />.
		/// </para>
		/// <para>
		/// Consider two applications, one has value of  and the other has a value of <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" />.
		/// The <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app creates a window on a single monitor where the scale factor is 200% (192 DPI).
		/// If both apps call <see cref="M:PInvoke.User32.GetWindowRect(System.IntPtr,PInvoke.RECT@)" /> on this window, they will receive different values.
		/// The <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" /> app will receive a rect based on 96 DPI coordinates,
		/// while the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app will receive coordinates matching the actual DPI of the monitor.
		/// If the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" /> needs the <see cref="T:PInvoke.RECT" /> that the system returned
		/// to the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app, it could call <see cref="M:PInvoke.User32.LogicalToPhysicalPointForPerMonitorDPI(System.IntPtr,PInvoke.POINT@)" />
		/// for the corners of its <see cref="T:PInvoke.RECT" /> and pass in the handle to the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app's window.
		/// This will return points based on the other app's awareness that can be used to create a <see cref="T:PInvoke.RECT" />.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PhysicalToLogicalPointForPerMonitorDPI(IntPtr hwnd, ref POINT lpPoint);

		/// <summary>
		/// Converts the physical coordinates of a point in a window to logical coordinates
		/// </summary>
		/// <param name="hwnd">
		/// A handle to the window whose transform is used for the conversion. Top level windows are fully supported.
		/// In the case of child windows, only the area of overlap between the parent and the child window is converted
		/// </param>
		/// <param name="lpPoint">
		/// A pointer to a <see cref="T:PInvoke.POINT" /> structure that specifies the physical/screen coordinates to be converted.
		/// The new logical coordinates are copied into this structure if the function succeeds
		/// </param>
		/// <returns>Returns TRUE if successful, or FALSE otherwise</returns>
		/// <remarks>
		/// <para>
		/// The function uses the window identified by the <paramref name="hwnd" /> parameter and the physical coordinates
		/// given in the <see cref="T:PInvoke.POINT" /> structure to compute the logical coordinates.
		/// The logical coordinates are the unscaled coordinates that appear to the application in a programmatic way.
		/// In other words, the logical coordinates are the coordinates the application recognizes, which can be different from the physical coordinates.
		/// The API then replaces the physical coordinates with the logical coordinates.
		/// The new coordinates are in the world coordinates whose origin is (0, 0) on the desktop.
		/// The coordinates passed to the API have to be on the <paramref name="hwnd" />.
		/// </para>
		/// <para>
		/// On all platforms, PhysicalToLogicalPoint will fail on a window that has either 0 width or height;
		/// an application must first establish a non-0 width and height by calling, for example, <see cref="M:PInvoke.User32.MoveWindow(System.IntPtr,System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean)" />.
		/// On some versions of Windows (including Windows 7), PhysicalToLogicalPointwill still fail if <see cref="M:PInvoke.User32.MoveWindow(System.IntPtr,System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean)" /> has been called
		/// after a call to <see cref="M:PInvoke.User32.ShowWindow(System.IntPtr,PInvoke.User32.WindowShowStyle)" /> with <see cref="F:PInvoke.User32.WindowShowStyle.SW_HIDE" /> has hidden the window.
		/// </para>
		/// <para>
		/// In Windows 8, system–DPI aware applications translate between physical and logical space using PhysicalToLogicalPoint and <see cref="M:PInvoke.User32.LogicalToPhysicalPoint(System.IntPtr,PInvoke.POINT@)" />.
		/// In Windows 8.1, the additional virtualization of the system and inter-process communications means that for the majority of applications,
		/// you do not need these APIs. As a result, in Windows 8.1, PhysicalToLogicalPoint and <see cref="M:PInvoke.User32.LogicalToPhysicalPoint(System.IntPtr,PInvoke.POINT@)" /> no longer transform points.
		/// The system returns all points to an application in its own coordinate space.
		/// This behavior preserves functionality for the majority of applications,
		/// but there are some exceptions in which you must make changes to ensure that the application works as expected.
		/// In those cases, use <see cref="M:PInvoke.User32.PhysicalToLogicalPointForPerMonitorDPI(System.IntPtr,PInvoke.POINT@)" /> and <see cref="M:PInvoke.User32.LogicalToPhysicalPointForPerMonitorDPI(System.IntPtr,PInvoke.POINT@)" />.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PhysicalToLogicalPoint(IntPtr hwnd, ref POINT lpPoint);

		/// <summary>
		/// Converts a point in a window from logical coordinates into physical coordinates, regardless of the dots per inch (dpi) awareness of the caller.
		/// For more information about DPI awareness levels, see <see cref="T:PInvoke.PROCESS_DPI_AWARENESS" />.
		/// <para>
		/// Tip: Since an application with a value of <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" /> uses the actual DPI of the monitor,
		/// physical and logical coordinates are the same for this app.
		/// </para>
		/// </summary>
		/// <param name="hwnd">A handle to the window whose transform is used for the conversion</param>
		/// <param name="lpPoint">
		/// A pointer to a <see cref="T:PInvoke.POINT" /> structure that specifies the logical coordinates to be converted.
		/// The new physical coordinates are copied into this structure if the function succeeds
		/// </param>
		/// <returns>Returns true if successful, or false otherwise</returns>
		/// <remarks>
		/// <para>
		/// In Windows 8, system–DPI aware applications translated between physical and logical space using
		/// <see cref="M:PInvoke.User32.PhysicalToLogicalPoint(System.IntPtr,PInvoke.POINT@)" /> and <see cref="M:PInvoke.User32.LogicalToPhysicalPoint(System.IntPtr,PInvoke.POINT@)" />.
		/// In Windows 8.1, the additional virtualization of the system and inter-process communications means that for the majority of applications, you do not need these APIs.
		/// As a result, in Windows 8.1, these APIs no longer transform points.
		/// The system returns all points to an application in its own coordinate space.
		/// This behavior preserves functionality for the majority of applications,
		/// but there are some exceptions in which you must make changes to ensure that the application works as expected.
		/// </para>
		/// <para>
		/// For example, an application might need to walk the entire window tree of another process and ask the system for DPI-dependent information about the window.
		/// By default, the system will return the information based on the DPI awareness of the caller. This is ideal for most applications.
		/// However, the caller might need the information based on the DPI awareness of the application associated with the window.
		/// This might be necessary because the two applications send DPI-dependent information between each other directly.
		/// In this case, the application can use LogicalToPhysicalPointForPerMonitorDPI to get physical coordinates and
		/// then use <see cref="M:PInvoke.User32.PhysicalToLogicalPointForPerMonitorDPI(System.IntPtr,PInvoke.POINT@)" /> to convert the physical coordinates
		/// into logical coordinates based on the DPI-awareness of the provided <paramref name="hwnd" />.
		/// </para>
		/// <para>
		/// Consider two applications, one has value of  and the other has a value of <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" />.
		/// The <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app creates a window on a single monitor where the scale factor is 200% (192 DPI).
		/// If both apps call <see cref="M:PInvoke.User32.GetWindowRect(System.IntPtr,PInvoke.RECT@)" /> on this window, they will receive different values.
		/// The <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" /> app will receive a rect based on 96 DPI coordinates,
		/// while the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app will receive coordinates matching the actual DPI of the monitor.
		/// If the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_PER_MONITOR_DPI_AWARE" /> needs the <see cref="T:PInvoke.RECT" /> that the system returned
		/// to the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app, it could call LogicalToPhysicalPointForPerMonitorDPI
		/// for the corners of its <see cref="T:PInvoke.RECT" /> and pass in the handle to the <see cref="F:PInvoke.PROCESS_DPI_AWARENESS.PROCESS_DPI_UNAWARE" /> app's window.
		/// This will return points based on the other app's awareness that can be used to create a <see cref="T:PInvoke.RECT" />.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LogicalToPhysicalPointForPerMonitorDPI(IntPtr hwnd, ref POINT lpPoint);

		/// <summary>
		/// Converts the logical coordinates of a point in a window to physical coordinates
		/// </summary>
		/// <param name="hwnd">
		/// A handle to the window whose transform is used for the conversion. Top level windows are fully supported.
		/// In the case of child windows, only the area of overlap between the parent and the child window is converted
		/// </param>
		/// <param name="lpPoint">
		/// A pointer to a <see cref="T:PInvoke.POINT" /> structure that specifies the logical coordinates to be converted.
		/// The new physical coordinates are copied into this structure if the function succeeds
		/// </param>
		/// <returns>Returns TRUE if successful, or FALSE otherwise</returns>
		/// <remarks>
		/// <para>
		/// LogicalToPhysicalPoint is a transformation API that can be called by a process that declares itself as dpi aware.
		/// The function uses the window identified by the hWnd parameter and the logical coordinates given in the <see cref="T:PInvoke.POINT" /> structure to compute the physical coordinates.
		/// The LogicalToPhysicalPoint function replaces the logical coordinates in the <see cref="T:PInvoke.POINT" /> structure with the physical coordinates.
		/// The physical coordinates are relative to the upper-left corner of the screen.
		/// The coordinates have to be inside the client area of <paramref name="hwnd" />.
		/// </para>
		/// <para>
		/// On all platforms, LogicalToPhysicalPoint will fail on a window that has either 0 width or height;
		/// an application must first establish a non-0 width and height by calling, for example, <see cref="M:PInvoke.User32.MoveWindow(System.IntPtr,System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean)" />.
		/// On some versions of Windows (including Windows 7), LogicalToPhysicalPoint will still fail if <see cref="M:PInvoke.User32.MoveWindow(System.IntPtr,System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean)" /> has been called
		/// after a call to <see cref="M:PInvoke.User32.ShowWindow(System.IntPtr,PInvoke.User32.WindowShowStyle)" /> with <see cref="F:PInvoke.User32.WindowShowStyle.SW_HIDE" /> has hidden the window.
		/// </para>
		/// <para>
		/// In Windows 8, system–DPI aware applications translate between physical and logical space using <see cref="M:PInvoke.User32.PhysicalToLogicalPoint(System.IntPtr,PInvoke.POINT@)" /> and LogicalToPhysicalPoint.
		/// In Windows 8.1, the additional virtualization of the system and inter-process communications means that for the majority of applications,
		/// you do not need these APIs. As a result, in Windows 8.1, <see cref="M:PInvoke.User32.PhysicalToLogicalPoint(System.IntPtr,PInvoke.POINT@)" /> and LogicalToPhysicalPoint no longer transform points.
		/// The system returns all points to an application in its own coordinate space.
		/// This behavior preserves functionality for the majority of applications,
		/// but there are some exceptions in which you must make changes to ensure that the application works as expected.
		/// In those cases, use <see cref="M:PInvoke.User32.PhysicalToLogicalPointForPerMonitorDPI(System.IntPtr,PInvoke.POINT@)" /> and <see cref="M:PInvoke.User32.LogicalToPhysicalPointForPerMonitorDPI(System.IntPtr,PInvoke.POINT@)" />.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LogicalToPhysicalPoint(IntPtr hwnd, ref POINT lpPoint);

		/// <summary>
		/// Determines whether the current process is dots per inch (dpi) aware such that it adjusts the sizes of UI elements to compensate for the dpi setting.
		/// </summary>
		/// <returns>TRUE if the process is dpi aware; otherwise, FALSE</returns>
		/// <remarks>
		/// IsProcessDPIAware is available for use in Windows Vista or superior the operating systems.
		/// It may be altered or unavailable in subsequent versions.
		/// For Windows 8.1 or superior operating systems, use GetProcessDPIAwareness/&gt;.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsProcessDPIAware();

		/// <summary>
		/// Sets the current process as dots per inch (dpi) awareness.
		/// </summary>
		/// <returns>If the function succeeds, the return value is true. Otherwise, the return value is false.</returns>
		/// <remarks>
		/// <para>
		/// SetProcessDPIAware is available for use in Windows Vista or superior the operating systems.
		/// It may be altered or unavailable in subsequent versions.
		/// For Windows 8.1 or superior operating systems, use SetProcessDpiAwareness/&gt;.
		/// </para>
		/// <para>
		/// SetProcessDPIAware is subject to a possible race condition if a DLL caches dpi settings during initialization.
		/// For this reason, it is recommended that dpi-aware be set through the application (.exe) manifest rather than by calling SetProcessDPIAware.
		/// DLLs should accept the dpi setting of the host process rather than call SetProcessDPIAware themselves.
		/// To be set properly, dpiAware should be specified as part of the application (.exe) manifest.
		/// IMPORTANT: dpiAware defined in an embedded DLL manifest has no affect.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool SetProcessDPIAware();

		/// <summary>
		/// The GetDC function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen. You can use the returned handle in subsequent GDI functions to draw in the DC. The device context is an opaque data structure, whose values are used internally by GDI.
		/// The GetDCEx function is an extension to GetDC, which gives an application more control over how and whether clipping occurs in the client area.
		/// Makes the specified desktop visible and activates it. This enables the desktop to receive input from the user.
		/// The calling process must have DESKTOP_SWITCHDESKTOP access to the desktop for the SwitchDesktop function to succeed.
		/// </summary>
		/// <param name="hDesktop">
		/// A handle to the desktop. This handle is returned by the <see cref="M:PInvoke.User32.CreateDesktop(System.String,System.String,System.IntPtr,PInvoke.User32.DesktopCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> and <see cref="M:PInvoke.User32.OpenDesktop(System.String,PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> functions.
		/// This desktop must be associated with the current window station for the process.</param>
		/// <returns>If the function succeeds, the return value is true, if it fails, the return value is false.</returns>
		/// <remarks>
		/// <para>
		/// SwitchDesktop only sets the last error for the following cases:
		/// <list>
		/// <item>When the desktop belongs to an invisible window station</item>
		/// <item>When hDesktop is an invalid handle, refers to a destroyed desktop, or belongs to a different session than that of the calling process</item>
		/// </list>
		/// </para>
		/// <para>
		/// The SwitchDesktop function fails if the desktop belongs to an invisible window station.
		/// SwitchDesktop also fails when called from a process that is associated with a secured desktop such as the WinLogon and ScreenSaver desktops.
		/// Processes that are associated with a secured desktop include custom UserInit processes. Such calls typically fail with an "access denied" error.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SwitchDesktop(User32.SafeDesktopHandle hDesktop);

		/// <summary>
		/// Assigns the specified desktop to the calling thread. All subsequent operations on the desktop use the access rights granted to the desktop.
		/// </summary>
		/// <param name="hDesktop">
		/// A handle to the desktop to be assigned to the calling thread.
		/// This handle is returned by the <see cref="M:PInvoke.User32.CreateDesktop(System.String,System.String,System.IntPtr,PInvoke.User32.DesktopCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, <see cref="M:PInvoke.User32.GetThreadDesktop(System.UInt32)" />, <see cref="M:PInvoke.User32.OpenDesktop(System.String,PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" />, or <see cref="M:PInvoke.User32.OpenInputDesktop(PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> function.
		/// This desktop must be associated with the current window station for the process.
		/// </param>
		/// <returns>If the function succeeds, the return value is true, if it fails, the return value is false.</returns>
		/// <remarks>
		/// The function will fail if the calling thread has any windows or hooks on its current desktop (unless the <paramref name="hDesktop" /> parameter is a handle to the current desktop).
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetThreadDesktop(User32.SafeDesktopHandle hDesktop);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeDesktopHandle OpenDesktop(string lpszDesktop,
		                                                          User32.DesktopCreationFlags dwFlags,
		                                                          [MarshalAs(UnmanagedType.Bool)] bool fInherit,
		                                                          Kernel32.ACCESS_MASK dwDesiredAccess);

		/// <summary>
		/// Enumerates all top-level windows associated with the specified desktop. It passes the handle to each window, in turn, to an application-defined callback function.
		/// </summary>
		/// <param name="hDesktop">
		/// A handle to the desktop whose top-level windows are to be enumerated. This handle is returned by the <see cref="M:PInvoke.User32.CreateDesktop(System.String,System.String,System.IntPtr,PInvoke.User32.DesktopCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, <see cref="M:PInvoke.User32.GetThreadDesktop(System.UInt32)" />, <see cref="M:PInvoke.User32.OpenDesktop(System.String,PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" />, or <see cref="M:PInvoke.User32.OpenInputDesktop(PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> function,
		/// and must have the <see cref="F:PInvoke.Kernel32.ACCESS_MASK.DesktopSpecificRight.DESKTOP_READOBJECTS" /> access right.
		/// If this parameter is NULL, the current desktop is used.
		/// </param>
		/// <param name="lpfn">An application-defined <see cref="T:PInvoke.User32.WNDENUMPROC" /> callback function.</param>
		/// <param name="lParam">An application-defined value to be passed to the callback function.</param>
		/// <returns>
		/// If the function is unable to perform the enumeration, the return value is zero. Call GetLastError to get extended error information.
		/// If the function succeeds, it returns the nonzero value returned by the callback function that was pointed to by <paramref name="lpfn" />.
		/// If the callback function fails, the return value is zero. The callback function can call SetLastError to set an error code for the caller to retrieve by calling GetLastError.
		/// Windows Server 2003 and Windows XP/2000:  If there are no windows on the desktop, GetLastError returns ERROR_INVALID_HANDLE.
		/// </returns>
		/// <remarks>The EnumDesktopWindows function repeatedly invokes the <paramref name="lpfn" /> callback function until the last top-level window is enumerated or the callback function returns FALSE.</remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDesktopWindows(User32.SafeDesktopHandle hDesktop, User32.WNDENUMPROC lpfn,
		                                             IntPtr lParam);

		/// <summary>
		/// Enumerates all top-level windows on the screen by passing the handle to each window, in turn, to an application-defined callback function. EnumWindows continues until the last top-level window is enumerated or the callback function returns FALSE.
		/// </summary>
		/// <param name="lpEnumFunc">An application-defined <see cref="T:PInvoke.User32.WNDENUMPROC" /> callback function.</param>
		/// <param name="lParam">An application-defined value to be passed to the callback function.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.To get extended error information, call GetLastError.
		/// If <see cref="T:PInvoke.User32.WNDENUMPROC" /> returns zero, the return value is also zero. In this case, the callback function should call SetLastError to obtain a meaningful error code to be returned to the caller of EnumWindows.
		/// </returns>
		/// <remarks>
		/// The EnumWindows function does not enumerate child windows, with the exception of a few top-level windows owned by the system that have the WS_CHILD style.
		/// This function is more reliable than calling the GetWindow function in a loop. An application that calls GetWindow to perform this task risks being caught in an infinite loop or referencing a handle to a window that has been destroyed.
		/// Note that for Windows 8 and later, EnumWindows enumerates only top-level windows of desktop apps.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumWindows(User32.WNDENUMPROC lpEnumFunc, IntPtr lParam);

		/// <summary>
		/// Enumerates all desktops associated with the specified window station of the calling process. The function passes the name of each desktop, in turn, to an application-defined callback function.
		/// </summary>
		/// <param name="hWinsta">A handle to the window station whose desktops are to be enumerated. This handle is returned by the <see cref="M:PInvoke.User32.CreateWindowStation(System.String,PInvoke.User32.WindowStationCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, <see cref="M:PInvoke.User32.GetProcessWindowStation" />, or <see cref="M:PInvoke.User32.OpenWindowStation(System.String,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> function, and must have the WINSTA_ENUMDESKTOPS access right.</param>
		/// <param name="lpEnumFunc">An application-defined <see cref="T:PInvoke.User32.DESKTOPENUMPROC" /> callback function.</param>
		/// <param name="lParam">An application-defined value to be passed to the callback function.</param>
		/// <returns>
		/// If the function succeeds, it returns the nonzero value returned by the callback function that was pointed to by <paramref name="lpEnumFunc" />.
		/// If the function is unable to perform the enumeration, the return value is zero. Call GetLastError to get extended error information.
		/// If the callback function fails, the return value is zero. The callback function can call SetLastError to set an error code for the caller to retrieve by calling GetLastError.
		/// </returns>
		/// <remarks>
		/// The EnumDesktops function enumerates only those desktops for which the calling process has the <see cref="F:PInvoke.Kernel32.ACCESS_MASK.DesktopSpecificRight.DESKTOP_ENUMERATE" /> access right.
		/// The EnumDesktops function repeatedly invokes the lpEnumFunc callback function until the last desktop is enumerated or the callback function returns zero.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern int EnumDesktops(User32.SafeWindowStationHandle hWinsta, User32.DESKTOPENUMPROC lpEnumFunc,
		                                      IntPtr lParam);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeDesktopHandle OpenInputDesktop(User32.DesktopCreationFlags dwFlags,
		                                                               [MarshalAs(UnmanagedType.Bool)] bool fInherit,
		                                                               Kernel32.ACCESS_MASK dwDesiredAccess);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe User32.SafeDesktopHandle CreateDesktopEx(
			string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, User32.DesktopCreationFlags dwFlags,
			Kernel32.ACCESS_MASK dwDesiredAccess, Kernel32.SECURITY_ATTRIBUTES* lpsa, uint ulHeapSize,
			IntPtr pvoid = default(IntPtr));

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe User32.SafeDesktopHandle CreateDesktop(
			string lpszDesktop, string lpszDevice, IntPtr pDevmode, User32.DesktopCreationFlags dwFlags,
			Kernel32.ACCESS_MASK dwDesiredAccess, Kernel32.SECURITY_ATTRIBUTES* lpsa);

		/// <summary>
		/// Retrieves a handle to the desktop assigned to the specified thread.
		/// </summary>
		/// <param name="dwThreadId">The thread identifier. The <see cref="M:PInvoke.Kernel32.GetCurrentThreadId" /> and CreateProcess functions return thread identifiers.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the desktop associated with the specified thread.
		/// You do not need to call the <see cref="M:PInvoke.User32.CloseDesktop(System.IntPtr)" /> function to close the returned handle.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The system associates a desktop with a thread when that thread is created. A thread can use the SetThreadDesktop function to change its desktop. The desktop associated with a thread must be on the window station associated with the thread's process.
		/// </para>
		/// <para>
		/// The calling process can use the returned handle in calls to the <see cref="M:PInvoke.User32.GetUserObjectInformation(System.IntPtr,PInvoke.User32.ObjectInformationType,System.Void*,System.UInt32,System.UInt32*)" />, GetUserObjectSecurity, SetUserObjectInformation, and SetUserObjectSecurity functions.
		/// </para>
		/// <para>
		/// A service application is created with an associated window station and desktop, so there is no need to call a USER or GDI function to connect the service to a window station and desktop.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeDesktopHandle GetThreadDesktop(uint dwThreadId);

		/// <summary>Closes an open handle to a desktop object.</summary>
		/// <param name="hDesktop">
		/// A handle to the desktop to be closed. This can be a handle returned by the <see cref="M:PInvoke.User32.CreateDesktop(System.String,System.String,System.IntPtr,PInvoke.User32.DesktopCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, <see cref="M:PInvoke.User32.OpenDesktop(System.String,PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" />, or <see cref="M:PInvoke.User32.OpenInputDesktop(PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> functions.
		/// Do not specify the handle returned by the <see cref="M:PInvoke.User32.GetThreadDesktop(System.UInt32)" /> function.
		/// </param>
		/// <returns>If the function succeeds, the return value is true, if it fails, the return value is false.</returns>
		/// <remarks>The CloseDesktop function will fail if any thread in the calling process is using the specified desktop handle or if the handle refers to the initial desktop of the calling process.</remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseDesktop(IntPtr hDesktop);

		/// <summary>
		/// Retrieves information about the specified window station or desktop object.
		/// </summary>
		/// <param name="hObj">A handle to the window station or desktop object. This handle is returned by the <see cref="M:PInvoke.User32.CreateWindowStation(System.String,PInvoke.User32.WindowStationCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, <see cref="M:PInvoke.User32.OpenWindowStation(System.String,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" />, <see cref="M:PInvoke.User32.CreateDesktop(System.String,System.String,System.IntPtr,PInvoke.User32.DesktopCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, or <see cref="M:PInvoke.User32.OpenDesktop(System.String,PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> function.</param>
		/// <param name="nIndex">The information to be retrieved.</param>
		/// <param name="pvInfo">A pointer to a buffer to receive the object information.</param>
		/// <param name="nLength">The size of the buffer pointed to by the <paramref name="pvInfo" /> parameter, in bytes.</param>
		/// <param name="lpnLengthNeeded">
		/// A pointer to a variable receiving the number of bytes required to store the requested information.
		/// If this variable's value is greater than the value of the <paramref name="nLength" /> parameter when the function returns, the function returns false, and none of the information is copied to the <paramref name="pvInfo" /> buffer.
		/// If the value of the variable pointed to by lpnLengthNeeded is less than or equal to the value of <paramref name="nLength" />, the entire information block is copied.</param>
		/// <returns>If the function succeeds, the return value is true, if it fails, the return value is false.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetUserObjectInformation(IntPtr hObj, User32.ObjectInformationType nIndex,
		                                                          void* pvInfo, uint nLength, uint* lpnLengthNeeded);

		/// <summary>
		/// Assigns the specified window station to the calling process.
		/// This enables the process to access objects in the window station such as desktops, the clipboard, and global atoms. All subsequent operations on the window station use the access rights granted to <paramref name="hWinSta" />.
		/// </summary>
		/// <param name="hWinSta">
		/// A handle to the window station. This can be a handle returned by the <see cref="M:PInvoke.User32.CreateWindowStation(System.String,PInvoke.User32.WindowStationCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, <see cref="M:PInvoke.User32.OpenWindowStation(System.String,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" />, or <see cref="M:PInvoke.User32.GetProcessWindowStation" /> function.
		/// This window station must be associated with the current session.
		/// </param>
		/// <returns>If the function succeeds, the return value is true, if it fails, the return value is false.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetProcessWindowStation(User32.SafeWindowStationHandle hWinSta);

		/// <summary>Closes an open window station handle.</summary>
		/// <param name="hWinsta">
		/// A handle to the window station to be closed.
		/// This handle is returned by the <see cref="M:PInvoke.User32.CreateWindowStation(System.String,PInvoke.User32.WindowStationCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> or <see cref="M:PInvoke.User32.OpenWindowStation(System.String,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> function.
		/// Do not specify the handle returned by the <see cref="M:PInvoke.User32.GetProcessWindowStation" /> function.
		/// </param>
		/// <returns>If the function succeeds, the return value is true, if it fails, the return value is false.</returns>
		/// <remarks>
		/// <para>
		/// Windows Server 2003 and Windows XP/2000:  This function does not set the last error code on failure.
		/// </para>
		/// <para>
		/// The CloseWindowStation function will fail if the handle being closed is for the window station assigned to the calling process.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseWindowStation(IntPtr hWinsta);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe User32.SafeWindowStationHandle CreateWindowStation(
			string lpwinsta, User32.WindowStationCreationFlags dwFlags, Kernel32.ACCESS_MASK dwDesiredAccess,
			Kernel32.SECURITY_ATTRIBUTES* lpsa);

		/// <summary>
		/// Retrieves a handle to the current window station for the calling process.
		/// </summary>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the window station. If the function fails, the return value is an invalid handle.
		/// Do not close the handle returned by this function.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The system associates a window station with a process when the process is created. A process can use the <see cref="M:PInvoke.User32.SetProcessWindowStation(PInvoke.User32.SafeWindowStationHandle)" /> function to change its window station.
		/// </para>
		/// <para>
		/// The calling process can use the returned handle in calls to the <see cref="M:PInvoke.User32.GetUserObjectInformation(System.IntPtr,PInvoke.User32.ObjectInformationType,System.Void*,System.UInt32,System.UInt32*)" />, GetUserObjectSecurity, SetUserObjectInformation, and SetUserObjectSecurity functions.
		/// </para>
		/// <para>
		/// A service application is created with an associated window station and desktop, so there is no need to call a USER or GDI function to connect the service to a window station and desktop.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeWindowStationHandle GetProcessWindowStation();

		/// <summary>
		/// Enumerates all window stations in the current session. The function passes the name of each window station, in turn, to an application-defined callback function.
		/// </summary>
		/// <param name="lpEnumFunc">An application-defined <see cref="T:PInvoke.User32.WINSTAENUMPROC" /> callback function.</param>
		/// <param name="lParam">An application-defined value to be passed to the callback function.</param>
		/// <returns>
		/// If the function is unable to perform the enumeration, the return value is zero. Call GetLastError to get extended error information.
		/// If the function succeeds, it returns the nonzero value returned by the callback function that was pointed to by <paramref name="lpEnumFunc" />.
		/// If the callback function fails, the return value is zero. The callback function can call SetLastError to set an error code for the caller to retrieve by calling GetLastError.
		/// </returns>
		/// <remarks>
		/// The EnumWindowStations function enumerates only those window stations for which the calling process has the <see cref="F:PInvoke.Kernel32.ACCESS_MASK.WindowStationSpecificRight.WINSTA_ENUMERATE" /> access right.
		///  EnumWindowStations repeatedly invokes the <paramref name="lpEnumFunc" /> callback function until the last window station is enumerated or the callback function returns FALSE.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumWindowStations(User32.WINSTAENUMPROC lpEnumFunc, IntPtr lParam);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.SafeWindowStationHandle OpenWindowStation(
			string lpszWinSta, [MarshalAs(UnmanagedType.Bool)] bool fInherit, Kernel32.ACCESS_MASK dwDesiredAccess);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe IntPtr CreateDialogIndirectParam(Kernel32.SafeLibraryHandle hInstance,
		                                                             User32.DLGTEMPLATE* lpTemplate, IntPtr hWndParent,
		                                                             User32.DialogProc lpDialogFunc, IntPtr lParamInit);

		/// <summary>
		///     Retrieves a message from the calling thread's message queue. The function dispatches incoming sent messages until a
		///     posted message is available for retrieval.
		///     <para>
		///         Unlike <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" />, the <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> function does not wait for a message to be
		///         posted before returning.
		///     </para>
		/// </summary>
		/// <param name="lpMsg">A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that receives message information.</param>
		/// <param name="hWnd">
		///     A handle to the window whose messages are to be retrieved. The window must belong to the current thread.
		///     <para>
		///         If hWnd is <see cref="F:System.IntPtr.Zero" />, PeekMessage retrieves messages for any window that belongs to the
		///         current thread, and any messages on the current thread's message queue whose hwnd value is NULL (see the MSG
		///         structure). Therefore if hWnd is <see cref="F:System.IntPtr.Zero" />, both window messages and thread messages are
		///         processed.
		///     </para>
		///     <para>
		///         If hWnd is -1, PeekMessage retrieves only messages on the current thread's message queue whose hwnd value is
		///         NULL, that is, thread messages as posted by <see cref="M:PInvoke.User32.PostMessage(System.IntPtr,PInvoke.User32.WindowMessage,System.Void*,System.Void*)" />
		///         (when the hWnd parameter is <see cref="F:System.IntPtr.Zero" />) or <see cref="M:PInvoke.User32.PostThreadMessage(System.Int32,PInvoke.User32.WindowMessage,System.IntPtr,System.IntPtr)" />.
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMin">
		///     <para>
		///         The value of the first message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYFIRST" /> to specify the first keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSEFIRST" /> to specify the first mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMax">
		///     <para>
		///         The value of the last message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYLAST" /> to specify the last keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSELAST" /> to specify the last mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <returns>
		///     If the function retrieves a message other than <see cref="F:PInvoke.User32.WindowMessage.WM_QUIT" />, the return value is nonzero.
		///     <para>If the function retrieves the <see cref="F:PInvoke.User32.WindowMessage.WM_QUIT" /> message, the return value is zero.</para>
		///     <para>
		///         If there is an error, the return value is -1. For example, the function fails if <paramref name="hWnd" /> is
		///         an invalid window handle or <paramref name="lpMsg" /> is an invalid pointer. To get extended error information,
		///         call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetMessage(User32.MSG* lpMsg, IntPtr hWnd, User32.WindowMessage wMsgFilterMin,
		                                           User32.WindowMessage wMsgFilterMax);

		/// <summary>
		///     Dispatches incoming sent messages, checks the thread message queue for a posted message, and retrieves the message
		///     (if any exist).
		/// </summary>
		/// <param name="lpMsg">A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that receives message information.</param>
		/// <param name="hWnd">
		///     A handle to the window whose messages are to be retrieved. The window must belong to the current thread.
		///     <para>
		///         If hWnd is <see cref="F:System.IntPtr.Zero" />, PeekMessage retrieves messages for any window that belongs to the
		///         current thread, and any messages on the current thread's message queue whose hwnd value is NULL (see the MSG
		///         structure). Therefore if hWnd is <see cref="F:System.IntPtr.Zero" />, both window messages and thread messages are
		///         processed.
		///     </para>
		///     <para>
		///         If hWnd is -1, PeekMessage retrieves only messages on the current thread's message queue whose hwnd value is
		///         NULL, that is, thread messages as posted by <see cref="M:PInvoke.User32.PostMessage(System.IntPtr,PInvoke.User32.WindowMessage,System.Void*,System.Void*)" /> (when the hWnd parameter is
		///         <see cref="F:System.IntPtr.Zero" />) or <see cref="M:PInvoke.User32.PostThreadMessage(System.Int32,PInvoke.User32.WindowMessage,System.IntPtr,System.IntPtr)" />.
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMin">
		///     <para>
		///         The value of the first message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYFIRST" /> to specify the first keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSEFIRST" /> to specify the first mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMax">
		///     <para>
		///         The value of the last message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYLAST" /> to specify the last keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSELAST" /> to specify the last mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <param name="wRemoveMsg">Specifies how messages are to be handled</param>
		/// <returns>
		///     If a message is available, the return value is true.
		///     <para>If no messages are available, the return value is false.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool PeekMessage(User32.MSG* lpMsg, IntPtr hWnd, User32.WindowMessage wMsgFilterMin,
		                                             User32.WindowMessage wMsgFilterMax,
		                                             User32.PeekMessageRemoveFlags wRemoveMsg);

		/// <summary>
		///     Posts a message to the message queue of the specified thread. It returns without waiting for the thread to process
		///     the message.
		/// </summary>
		/// <param name="idThread">
		///     The identifier of the thread to which the message is to be posted.
		///     <para>
		///         The function fails if the specified thread does not have a message queue. The system creates a thread's
		///         message queue when the thread makes its first call to one of the User or GDI functions.
		///     </para>
		///     <para>
		///         Message posting is subject to UIPI. The thread of a process can post messages only to posted-message queues
		///         of threads in processes of lesser or equal integrity level.
		///     </para>
		///     <para>
		///         This thread must have the SE_TCB_NAME privilege to post a message to a thread that belongs to a process with
		///         the same locally unique identifier (LUID) but is in a different desktop. Otherwise, the function fails and
		///         returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_THREAD_ID" />.
		///     </para>
		///     <para>
		///         This thread must either belong to the same desktop as the calling thread or to a process with the same LUID.
		///         Otherwise, the function fails and returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_THREAD_ID" />.
		///     </para>
		/// </param>
		/// <param name="Msg">The type of message to be posted.</param>
		/// <param name="wParam">First additional message-specific information.</param>
		/// <param name="lParam">Second additional message-specific information.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />. GetLastError returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_THREAD_ID" /> if idThread is not a valid thread identifier, or if the
		///         thread specified by idThread does not have a message queue. GetLastError returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_NOT_ENOUGH_QUOTA" /> when the message limit is hit.
		///     </para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PostThreadMessage(int idThread, User32.WindowMessage Msg, IntPtr wParam,
		                                            IntPtr lParam);

		/// <summary>
		///     Calls the default window procedure to provide default processing for any window messages that an application does
		///     not process. This function ensures that every message is processed. DefWindowProc is called with the same
		///     parameters received by the window procedure.
		/// </summary>
		/// <param name="hWnd">A handle to the window procedure that received the message.</param>
		/// <param name="Msg">The message.</param>
		/// <param name="wParam">First additional message information. The content of this parameter depends on the value of the <paramref name="Msg" /> parameter.</param>
		/// <param name="lParam">Second additional message information. The content of this parameter depends on the value of the <paramref name="Msg" /> parameter.</param>
		/// <returns>The return value is the result of the message processing and depends on the message.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr DefWindowProc(IntPtr hWnd, User32.WindowMessage Msg, IntPtr wParam, IntPtr lParam);

		/// <summary>
		///     Retrieves the type of messages found in the calling thread's message queue.
		/// </summary>
		/// <param name="flags">The types of messages for which to check</param>
		/// <returns>
		///     The high-order word of the return value indicates the types of messages currently in the queue. The low-order word
		///     indicates the types of messages that have been added to the queue and that are still in the queue since the last
		///     call to the <see cref="M:PInvoke.User32.GetQueueStatus(PInvoke.User32.QueueStatusFlags)" />, <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" />, or <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> function.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern int GetQueueStatus(User32.QueueStatusFlags flags);

		/// <summary>
		///     Translates virtual-key messages into character messages. The character messages are posted to the calling thread's
		///     message queue, to be read the next time the thread calls the <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" /> or
		///     <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> function.
		/// </summary>
		/// <param name="lpMsg">
		///     A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that contains message information retrieved from the
		///     calling thread's message queue by using the <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" /> or <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> function.
		/// </param>
		/// <returns>
		///     If the message is translated (that is, a character message is posted to the thread's message queue), the return
		///     value is nonzero.
		///     <para>
		///         If the message is <see cref="F:PInvoke.User32.WindowMessage.WM_KEYDOWN" />, <see cref="F:PInvoke.User32.WindowMessage.WM_KEYUP" />,
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_SYSKEYDOWN" />, or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_SYSKEYUP" />, the return value is nonzero, regardless of the translation.
		///     </para>
		///     <para>
		///         If the message is not translated (that is, a character message is not posted to the thread's message queue),
		///         the return value is zero.
		///     </para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool TranslateMessage(User32.MSG* lpMsg);

		/// <summary>
		///     Dispatches a message to a window procedure. It is typically used to dispatch a message retrieved by the
		///     <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" /> function.
		/// </summary>
		/// <param name="lpMsg">A pointer to a structure that contains the message.</param>
		/// <returns>
		///     The return value specifies the value returned by the window procedure. Although its meaning depends on the
		///     message being dispatched, the return value generally is ignored.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe IntPtr DispatchMessage(User32.MSG* lpMsg);

		/// <summary>
		///     Indicates to the system that a thread has made a request to terminate (quit). It is typically used in response to a
		///     <see cref="F:PInvoke.User32.WindowMessage.WM_DESTROY" /> message.
		/// </summary>
		/// <param name="nExitCode">
		///     The application exit code. This value is used as the wParam parameter of the
		///     <see cref="F:PInvoke.User32.WindowMessage.WM_QUIT" /> message.
		/// </param>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern void PostQuitMessage(int nExitCode);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TranslateMessage(ref User32.MSG lpMsg);

		/// <summary>
		///     Determines whether a message is intended for the specified dialog box and, if it is, processes the message.
		/// </summary>
		/// <param name="hDlg">A handle to the dialog box.</param>
		/// <param name="lpMsg">A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that contains the message to be checked.</param>
		/// <returns>
		///     If the message has been processed, the return value is nonzero.
		///     <para>If the message has not been processed, the return value is zero.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool IsDialogMessage(IntPtr hDlg, User32.MSG* lpMsg);

		/// <summary>
		///     Loads a string resource from the executable file associated with a specified module, copies the string into
		///     a buffer, and appends a terminating null character.
		/// </summary>
		/// <param name="hInstance">
		///     A handle to an instance of the module whose executable file contains the string resource. To get the handle
		///     to the application itself, call the <see cref="M:PInvoke.Kernel32.GetModuleHandle(System.String)" /> function with NULL.
		/// </param>
		/// <param name="uID">The identifier of the string to be loaded.</param>
		/// <param name="lpBuffer">
		///     The buffer is to receive the string. Must be of sufficient length to hold a pointer (8 bytes).
		/// </param>
		/// <param name="cchBufferMax">
		///     The size of the buffer, in characters. The string is truncated and null-terminated if it is longer than the
		///     number of characters specified. If this parameter is 0, then lpBuffer receives a read-only pointer to the
		///     resource itself.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is the number of characters copied into the buffer, not
		///     including the terminating null character, or zero if the string resource does not exist. To get extended
		///     error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int LoadString(IntPtr hInstance, uint uID, out char* lpBuffer, int cchBufferMax);

		/// <summary>
		/// Retrieves the length, in characters, of the specified window's title bar text (if the window has a title bar).
		/// If the specified window is a control, the function retrieves the length of the text within the control. However,
		/// GetWindowTextLength cannot retrieve the length of the text of an edit control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control.</param>
		/// <returns>
		/// If the function succeeds, the return value is the length, in characters, of the text. Under certain
		/// conditions, this value may actually be greater than the length of the text. For more information, see the following
		/// Remarks section.
		/// <para>If the window has no text, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetWindowTextLength(IntPtr hWnd);

		/// <summary>
		/// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is
		/// a control, the text of the control is copied. However, GetWindowText cannot retrieve the text of a control in another
		/// application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control containing the text.</param>
		/// <param name="lpString">
		/// The buffer that will receive the text. If the string is as long or longer than the buffer, the
		/// string is truncated and terminated with a null character.
		/// </param>
		/// <param name="nMaxCount">
		/// The maximum number of characters to copy to the buffer, including the null character. If the
		/// text exceeds this limit, it is truncated.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the length, in characters, of the copied string, not including
		/// the terminating null character. If the window has no title bar or text, if the title bar is empty, or if the window or
		/// control handle is invalid, the return value is zero. To get extended error information, call GetLastError.
		/// <para>This function cannot retrieve the text of an edit control in another application.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetWindowText(IntPtr hWnd, char* lpString, int nMaxCount);

		/// <summary>
		/// Changes the text of the specified window's title bar (if it has one). If the specified window is a control, the text of the control is changed. However, SetWindowText cannot change the text of a control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control whose text is to be changed. </param>
		/// <param name="lpString">The new title or control text. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowText(IntPtr hWnd, string lpString);

		/// <summary>
		/// Examines the Z order of the child windows associated with the specified parent window and retrieves a handle to the child window at the top of the Z order.
		/// </summary>
		/// <param name="hWnd">A handle to the parent window whose child windows are to be examined. If this parameter is NULL, the function returns a handle to the window at the top of the Z order.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the child window at the top of the Z order. If the specified window has no child windows, the return value is NULL. To get extended error information, use the GetLastError function.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetTopWindow(IntPtr hWnd);

		/// <summary>
		/// Retrieves a handle to a window that has the specified relationship (Z-Order or owner) to the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to a window. The window handle retrieved is relative to this window, based on the value of the wCmd parameter. </param>
		/// <param name="wCmd">The relationship between the specified window and the window whose handle is to be retrieved.</param>
		/// <returns>If the function succeeds, the return value is a handle to the next (or previous) window. If there is no next (or previous) window, the return value is NULL. To get extended error information, call GetLastError.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetWindow(IntPtr hWnd, User32.GetWindowCommands wCmd);

		/// <summary>
		/// Retrieves a handle to the next or previous window in the Z-Order. The next window is below the specified window; the previous window is above.
		/// If the specified window is a topmost window, the function searches for a topmost window. If the specified window is a top-level window, the function searches for a top-level window. If the specified window is a child window, the function searches for a child window.
		/// </summary>
		/// <param name="hWnd">A handle to a window. The window handle retrieved is relative to this window, based on the value of the wCmd parameter. </param>
		/// <param name="wCmd">Indicates whether the function returns a handle to the next window or the previous window.</param>
		/// <returns>If the function succeeds, the return value is a handle to the next (or previous) window. If there is no next (or previous) window, the return value is NULL. To get extended error information, call GetLastError.</returns>
		public static IntPtr GetNextWindow(IntPtr hWnd, User32.GetNextWindowCommands wCmd) {
			return User32.GetWindow(hWnd, (User32.GetWindowCommands) wCmd);
		}

		/// <summary>
		/// Moves the cursor to the specified screen coordinates. If the new coordinates are not within the screen
		/// rectangle set by the most recent ClipCursor function call, the system automatically adjusts the coordinates so that the
		/// cursor stays within the rectangle.
		/// </summary>
		/// <param name="X">The new x-coordinate of the cursor, in screen coordinates.</param>
		/// <param name="Y">The new y-coordinate of the cursor, in screen coordinates.</param>
		/// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetCursorPos(int X, int Y);

		/// <summary>
		/// Retrieves the position of the mouse cursor, in screen coordinates.
		/// </summary>
		/// <param name="lpPoint">A pointer to a POINT structure that receives the screen coordinates of the cursor.</param>
		/// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetCursorPos(POINT* lpPoint);

		/// <summary>
		/// Retrieves a handle to the window that contains the specified point.
		/// </summary>
		/// <param name="Point">The point to be checked.</param>
		/// <returns>The return value is a handle to the window that contains the point. If no window exists at the given point, the return value is <see cref="F:System.IntPtr.Zero" />. If the point is over a static text control, the return value is a handle to the window under the static text control.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr WindowFromPoint(POINT Point);

		/// <summary>Retrieves the show state and the restored, minimized, and maximized positions of the specified window.</summary>
		/// <param name="hWnd">A handle to the window.</param>
		/// <param name="lpwndpl">
		/// A pointer to the WINDOWPLACEMENT structure that receives the show state and position information.
		/// Before calling GetWindowPlacement, set the length member to sizeof(WINDOWPLACEMENT). GetWindowPlacement fails if
		/// lpwndpl-&gt; length is not set correctly.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetWindowPlacement(IntPtr hWnd, User32.WINDOWPLACEMENT* lpwndpl);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, POINT Point);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr ChildWindowFromPointEx(IntPtr hWndParent, POINT pt,
		                                                   User32.ChildWindowFromPointExFlags uFlags);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateWindow(IntPtr hWnd);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr WindowFromPhysicalPoint(POINT pt);

		/// <summary>
		/// Creates an overlapped, pop-up, or child window with an
		/// extended window style; otherwise, this function is identical to the CreateWindow function.
		/// </summary>
		/// <param name="dwExStyle">Specifies the extended window style of the window being created.</param>
		/// <param name="lpClassName">
		/// Pointer to a null-terminated string that specifies
		/// the window class name. The class name can be any name registered with RegisterClass or
		/// RegisterClassEx, provided that the module that registers the class is also the module
		/// that creates the window. The class name can also be any of the predefined system class names.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe IntPtr CreateWindowEx(User32.WindowStylesEx dwExStyle, string lpClassName,
		                                                  string lpWindowName, User32.WindowStyles dwStyle, int x,
		                                                  int y, int nWidth, int nHeight, IntPtr hWndParent,
		                                                  IntPtr hMenu, IntPtr hInstance, void* lpParam);

		/// <summary>
		/// Creates an overlapped, pop-up, or child window with an
		/// extended window style; otherwise, this function is identical to the CreateWindow function.
		/// </summary>
		/// <param name="dwExStyle">Specifies the extended window style of the window being created.</param>
		/// <param name="lpClassName">
		/// Pointer to a class atom created by a previous call to the
		/// RegisterClass or RegisterClassEx function. The atom must be in the low-order word of
		/// lpClassName; the high-order word must be zero.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		public static unsafe IntPtr CreateWindowEx(User32.WindowStylesEx dwExStyle, short lpClassName,
		                                           string lpWindowName, User32.WindowStyles dwStyle, int x, int y,
		                                           int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu,
		                                           IntPtr hInstance, void* lpParam) {
			return User32.CreateWindowEx(dwExStyle, (IntPtr) ((int) lpClassName), lpWindowName, dwStyle, x, y, nWidth,
				nHeight, hWndParent, hMenu, hInstance, lpParam);
		}

		/// <summary>
		/// Destroys the specified window. The function sends WM_DESTROY and WM_NCDESTROY messages to the window to deactivate it and remove the keyboard focus from it. The function also destroys the window's menu, flushes the thread message queue, destroys timers, removes clipboard ownership, and breaks the clipboard viewer chain (if the window is at the top of the viewer chain).
		/// If the specified window is a parent or owner window, DestroyWindow automatically destroys the associated child or owned windows when it destroys the parent or owner window. The function first destroys child or owned windows, and then it destroys the parent or owner window.
		/// DestroyWindow also destroys modeless dialog boxes created by the CreateDialog function.
		/// </summary>
		/// <param name="hWnd">A handle to the window to be destroyed. </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyWindow(IntPtr hWnd);

		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr DispatchMessage(ref User32.MSG lpmsg);

		/// <summary>
		/// The DrawText function draws formatted text in the specified rectangle.
		/// It formats the text according to the specified method (expanding tabs, justifying characters, breaking lines, and so forth).
		/// To specify additional formatting options, use the <see cref="M:PInvoke.User32.DrawTextEx(PInvoke.User32.SafeDCHandle,System.Char*,System.Int32,PInvoke.RECT*,System.UInt32,PInvoke.User32.DRAWTEXTPARAMS*)" /> function.
		/// </summary>
		/// <param name="hDC">A handle to the device context.</param>
		/// <param name="lpString">
		/// A pointer to the string that specifies the text to be drawn.
		/// If the <paramref name="nCount" /> parameter is -1, the string must be null-terminated.
		/// If <paramref name="uFormat" /> includes <see cref="F:PInvoke.User32.TextFormats.DT_MODIFYSTRING" />, the function could add up to four additional characters to this string.
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </param>
		/// <param name="nCount">The length, in characters, of the string. If nCount is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and DrawText computes the character count automatically.</param>
		/// <param name="lpRect">A pointer to a RECT structure that contains the rectangle (in logical coordinates) in which the text is to be formatted.</param>
		/// <param name="uFormat">The method of formatting the text.</param>
		/// <returns>
		/// If the function succeeds, the return value is the height of the text in logical units.
		/// If <see cref="F:PInvoke.User32.TextFormats.DT_VCENTER" /> or <see cref="F:PInvoke.User32.TextFormats.DT_BOTTOM" /> is specified, the return value is the offset from <see cref="F:PInvoke.RECT.top" /> (<paramref name="lpRect" />) to the bottom of the drawn text.
		/// If the function fails, the return value is zero.</returns>
		/// <remarks>
		/// <para>
		/// The DrawText function uses the device context's selected font, text color, and background color to draw the text.
		/// Unless the <see cref="F:PInvoke.User32.TextFormats.DT_NOCLIP" /> format is used, DrawText clips the text so that it does not appear outside the specified rectangle.
		/// Note that text with significant overhang may be clipped, for example, an initial "W" in the text string or text that is in italics.
		/// All formatting is assumed to have multiple lines unless the <see cref="F:PInvoke.User32.TextFormats.DT_SINGLELINE" /> format is specified.
		/// </para>
		/// <para>
		/// If the selected font is too large for the specified rectangle, the DrawText function does not attempt to substitute a smaller font.
		/// The text alignment mode for the device context must include the TA_LEFT, TA_TOP, and TA_NOUPDATECP flags.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int DrawText(User32.SafeDCHandle hDC, char* lpString, int nCount, RECT* lpRect,
		                                         User32.TextFormats uFormat);

		/// <summary>
		/// The DrawTextEx function draws formatted text in the specified rectangle.
		/// </summary>
		/// <param name="hdc">A handle to the device context in which to draw.</param>
		/// <param name="lpchText">
		/// A pointer to the string that contains the text to draw. If the <paramref name="cchText" /> parameter is -1, the string must be null-terminated.
		/// If <paramref name="dwDTFormat" /> includes <see cref="F:PInvoke.User32.TextFormats.DT_MODIFYSTRING" />, the function could add up to four additional characters to this string.
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </param>
		/// <param name="cchText">
		/// The length of the string pointed to by <paramref name="lpchText" />.
		/// If cchText is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and DrawTextEx computes the character count automatically.
		/// </param>
		/// <param name="lprc">A pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the rectangle, in logical coordinates, in which the text is to be formatted.</param>
		/// <param name="dwDTFormat">The formatting options.</param>
		/// <param name="lpDTParams">A pointer to a <see cref="T:PInvoke.User32.DRAWTEXTPARAMS" /> structure that specifies additional formatting options. This parameter can be NULL.</param>
		/// <returns>
		/// If the function succeeds, the return value is the text height in logical units.
		/// If <see cref="F:PInvoke.User32.TextFormats.DT_VCENTER" /> or <see cref="F:PInvoke.User32.TextFormats.DT_BOTTOM" /> is specified, the return value is the offset from  <see cref="F:PInvoke.RECT.top" /> (<paramref name="lprc" />) to the bottom of the drawn text
		/// If the function fails, the return value is zero.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int DrawTextEx(User32.SafeDCHandle hdc, char* lpchText, int cchText, RECT* lprc,
		                                           uint dwDTFormat, User32.DRAWTEXTPARAMS* lpDTParams);

		/// <summary>
		/// The EndPaint function marks the end of painting in the specified window. This function is required for each call to the <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function, but only after painting is complete.
		/// </summary>
		/// <param name="hWnd">Handle to the window that has been repainted.</param>
		/// <param name="lpPaint">Pointer to a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that contains the painting information retrieved by <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" />.</param>
		/// <returns>The return value is always nonzero.</returns>
		/// <remarks>
		/// If the caret was hidden by <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" />, EndPaint restores the caret to the screen.
		/// EndPaint releases the display device context that <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> retrieved.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool EndPaint(IntPtr hWnd, User32.PAINTSTRUCT* lpPaint);

		/// <summary>
		/// Sets the show state and the restored, minimized, and maximized positions of the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to the window.</param>
		/// <param name="lpwndpl">A pointer to a WINDOWPLACEMENT structure that specifies the new show state and window positions.
		/// Before calling SetWindowPlacement, set the <see cref="F:PInvoke.User32.WINDOWPLACEMENT.length" /> member of the <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> structure to sizeof(WINDOWPLACEMENT).
		/// SetWindowPlacement fails if the length member is not set correctly.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool SetWindowPlacement(IntPtr hWnd, User32.WINDOWPLACEMENT* lpwndpl);

		/// <summary>
		///     Synthesizes a keystroke. The system can use such a synthesized keystroke to generate a WM_KEYUP or WM_KEYDOWN message. The keyboard driver's interrupt handler calls the keybd_event function.
		/// </summary>
		/// <param name="bVk">
		///     A virtual-key code from <see cref="T:PInvoke.User32.VirtualKey" />. The code must be a value in the range 1 to 254.
		/// </param>
		/// <param name="bScan">
		///     A hardware scan code for the key from <see cref="T:PInvoke.User32.ScanCode" />.
		/// </param>
		/// <param name="dwFlags">
		///     Controls various aspects of function operation. This parameter can be one or more of the following values.
		/// </param>
		/// <param name="dwExtraInfo">
		///     An additional value associated with the key stroke.
		/// </param>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void keybd_event(byte bVk, byte bScan, User32.KEYEVENTF dwFlags, void* dwExtraInfo);

		/// <summary>
		/// Sets the last-error code for the calling thread.
		/// Currently, this function is identical to the SetLastError function. The second parameter is ignored.
		/// </summary>
		/// <param name="dwErrCode">The last-error code for the thread.</param>
		/// <param name="dwType">This parameter is ignored.</param>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern void SetLastErrorEx(uint dwErrCode, uint dwType);

		/// <summary>
		/// The <see cref="M:PInvoke.User32.mouse_event(PInvoke.User32.mouse_eventFlags,System.Int32,System.Int32,System.Int32,System.Void*)" /> function synthesizes mouse motion and button clicks.
		/// </summary>
		/// <param name="dwFlags">Controls various aspects of mouse motion and button clicking.</param>
		/// <param name="dx">The mouse's absolute position along the x-axis or its amount of motion since the last mouse event was generated, depending on the setting of <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_ABSOLUTE" />. Absolute data is specified as the mouse's actual x-coordinate; relative data is specified as the number of mickeys moved. A mickey is the amount that a mouse has to move for it to report that it has moved.</param>
		/// <param name="dy">The mouse's absolute position along the y-axis or its amount of motion since the last mouse event was generated, depending on the setting of <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_ABSOLUTE" />. Absolute data is specified as the mouse's actual y-coordinate; relative data is specified as the number of mickeys moved.</param>
		/// <param name="dwData">
		/// If <paramref name="dwFlags" /> contains <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_WHEEL" />, then dwData specifies the amount of wheel movement. A positive value indicates that the wheel was rotated forward, away from the user; a negative value indicates that the wheel was rotated backward, toward the user. One wheel click is defined as WHEEL_DELTA, which is 120.
		/// If <paramref name="dwFlags" /> contains <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_HWHEEL" />, then dwData specifies the amount of wheel movement. A positive value indicates that the wheel was tilted to the right; a negative value indicates that the wheel was tilted to the left.
		/// If <paramref name="dwFlags" /> contains <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XDOWN" /> or <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XUP" />, then <paramref name="dwData" /> specifies which X buttons were pressed or released. This value may be any combination of the following flags.
		/// If <paramref name="dwFlags" /> is not <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_WHEEL" />, <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XDOWN" />, or <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XUP" />, then <paramref name="dwData" /> should be zero.
		/// </param>
		/// <param name="dwExtraInfo">An additional value associated with the mouse event. An application calls GetMessageExtraInfo to obtain this extra information.</param>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern unsafe void mouse_event(User32.mouse_eventFlags dwFlags, int dx, int dy, int dwData,
		                                             void* dwExtraInfo);

		/// <summary>
		/// Calculates the required size of the window rectangle, based on the desired size of the client rectangle and the provided DPI. This window rectangle can then be passed to the CreateWindowEx function to create a window with a client area of the desired size.
		/// </summary>
		/// <param name="lpRect">A pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the coordinates of the top-left and bottom-right corners of the desired client area. When the function returns, the structure contains the coordinates of the top-left and bottom-right corners of the window to accommodate the desired client area.</param>
		/// <param name="dwStyle">The Window Style of the window whose required size is to be calculated. Note that you cannot specify the <see cref="F:PInvoke.User32.WindowStyles.WS_OVERLAPPED" /> style.</param>
		/// <param name="bMenu">Indicates whether the window has a menu.</param>
		/// <param name="dwExStyle">The Extended Window Style of the window whose required size is to be calculated.</param>
		/// <param name="dpi">The DPI to use for scaling.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool AdjustWindowRectExForDpi(RECT* lpRect, User32.WindowStyles dwStyle,
		                                                          [MarshalAs(UnmanagedType.Bool)] bool bMenu,
		                                                          User32.WindowStylesEx dwExStyle, int dpi);

		/// <summary>
		/// Determines whether two DPI_AWARENESS_CONTEXT values are identical.
		/// </summary>
		/// <param name="dpiContextA">The first value to compare.</param>
		/// <param name="dpiContextB">The second value to compare.</param>
		/// <returns>Returns true if the values are equal, otherwise false.</returns>
		/// <remarks>
		/// A DPI_AWARENESS_CONTEXT contains multiple pieces of information. For example, it includes both the current and the inherited <see cref="T:PInvoke.User32.DPI_AWARENESS" /> values.
		/// AreDpiAwarenessContextsEqual ignores informational flags and determines if the values are equal. You can't use a direct bitwise comparison because of these informational flags.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AreDpiAwarenessContextsEqual(IntPtr dpiContextA, IntPtr dpiContextB);

		/// <summary>
		/// In high-DPI displays, enables automatic display scaling of the non-client area portions of the specified top-level window. Must be called during the initialization of that window.
		/// </summary>
		/// <param name="hwnd">The window that should have automatic scaling enabled.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnableNonClientDpiScaling(IntPtr hwnd);

		/// <summary>
		/// Retrieves the <see cref="T:PInvoke.User32.DPI_AWARENESS" /> value from a DPI_AWARENESS_CONTEXT.
		/// </summary>
		/// <param name="dpiAwarenessContext">The DPI_AWARENESS_CONTEXT you want to examine.</param>
		/// <returns>The <see cref="T:PInvoke.User32.DPI_AWARENESS" />. If the provided <paramref name="dpiAwarenessContext" /> is null or invalid, this method will return <see cref="F:PInvoke.User32.DPI_AWARENESS.DPI_AWARENESS_INVALID" />.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern User32.DPI_AWARENESS GetAwarenessFromDpiAwarenessContext(IntPtr dpiAwarenessContext);

		/// <summary>Returns the system DPI.</summary>
		/// <returns>The system DPI value.</returns>
		/// <remarks>
		/// The return value will be dependent based upon the calling context. If the current thread has a <see cref="T:PInvoke.User32.DPI_AWARENESS" /> value of <see cref="F:PInvoke.User32.DPI_AWARENESS.DPI_AWARENESS_UNAWARE" />, the return value will be 96. That is because the current context always assumes a DPI of 96. For any other <see cref="T:PInvoke.User32.DPI_AWARENESS" /> value, the return value will be the actual system DPI.
		/// You should not cache the system DPI, but should use GetDpiForSystem whenever you need the system DPI value.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern int GetDpiForSystem();

		/// <summary>
		/// Returns the dots per inch (dpi) value for the associated window.
		/// </summary>
		/// <param name="hwnd">The window you want to get information about.</param>
		/// <returns>The DPI for the window which depends on the <see cref="T:PInvoke.User32.DPI_AWARENESS" /> of the window. An invalid <paramref name="hwnd" /> value will result in a return value of 0.</returns>
		/// <remarks>
		/// The following table indicates the return value of GetDpiForWindow based on the <see cref="T:PInvoke.User32.DPI_AWARENESS" /> of the provided <paramref name="hwnd" />.
		/// +---------------------------------+-----------------------------------------------------+
		/// |          DPI_AWARENESS          |                    Return value                     |
		/// +---------------------------------+-----------------------------------------------------+
		/// | DPI_AWARENESS_UNAWARE           | 96                                                  |
		/// | DPI_AWARENESS_SYSTEM_AWARE      | The system DPI.                                     |
		/// | DPI_AWARENESS_PER_MONITOR_AWARE | The DPI of the monitor where the window is located. |
		/// +---------------------------------+-----------------------------------------------------+
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern int GetDpiForWindow(IntPtr hwnd);

		/// <summary>
		/// Retrieves the specified system metric or system configuration setting taking into account a provided DPI.
		/// </summary>
		/// <param name="nIndex">The system metric or configuration setting to be retrieved. See <see cref="M:PInvoke.User32.GetSystemMetrics(PInvoke.User32.SystemMetric)" /> for the possible values.</param>
		/// <param name="dpi">The DPI to use for scaling the metric.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>This function returns the same result as <see cref="M:PInvoke.User32.GetSystemMetrics(PInvoke.User32.SystemMetric)" /> but scales it according to an arbitrary DPI you provide if appropriate.</remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetSystemMetricsForDpi(int nIndex, int dpi);

		/// <summary>
		/// Gets the DPI_AWARENESS_CONTEXT for the current thread.
		/// </summary>
		/// <returns>The current DPI_AWARENESS_CONTEXT for the thread.</returns>
		/// <remarks>
		/// This method will return the latest DPI_AWARENESS_CONTEXT sent to SetThreadDpiAwarenessContext. If SetThreadDpiAwarenessContext was never called for this thread, then the return value will equal the default DPI_AWARENESS_CONTEXT for the process.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetThreadDpiAwarenessContext();

		/// <summary>
		/// Returns the DPI_AWARENESS_CONTEXT associated with a window.
		/// </summary>
		/// <param name="hwnd">The window to query.</param>
		/// <returns>The DPI_AWARENESS_CONTEXT for the provided window. If the window is not valid, the return value is NULL.</returns>
		/// <remarks>
		/// The return value of GetWindowDpiAwarenessContext is not affected by the <see cref="T:PInvoke.User32.DPI_AWARENESS" /> of the current thread. It only indicates the context of the window specified by the <paramref name="hwnd" /> input parameter.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetWindowDpiAwarenessContext(IntPtr hwnd);

		/// <summary>
		/// Determines if a specified DPI_AWARENESS_CONTEXT is valid and supported by the current system.
		/// </summary>
		/// <param name="dpiAwarenessContext">The context that you want to determine if it is supported.</param>
		/// <returns>true if the provided context is supported, otherwise false.</returns>
		/// <remarks>
		/// IsValidDpiAwarenessContext determines the validity of any provided DPI_AWARENESS_CONTEXT. You should make sure a context is valid before using SetThreadDpiAwarenessContext to that context.
		/// An input value of NULL is considered to be an invalid context and will result in a return value of false.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsValidDpiAwarenessContext(IntPtr dpiAwarenessContext);

		/// <summary>
		/// Set the DPI awareness for the current thread to the provided value.
		/// </summary>
		/// <param name="dpiContext">The new DPI_AWARENESS_CONTEXT for the current thread. This context includes the <see cref="T:PInvoke.User32.DPI_AWARENESS" /> value.</param>
		/// <returns>The old DPI_AWARENESS_CONTEXT for the thread. If the <paramref name="dpiContext" /> is invalid, the thread will not be updated and the return value will be NULL. You can use this value to restore the old DPI_AWARENESS_CONTEXT after overriding it with a predefined value.</returns>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern IntPtr SetThreadDpiAwarenessContext(IntPtr dpiContext);

		/// <summary>
		/// Retrieves the value of one of the system-wide parameters, taking into account the provided DPI value.
		/// </summary>
		/// <param name="uiAction">The system-wide parameter to be retrieved. This function is only intended for use with <see cref="F:PInvoke.User32.SystemParametersInfoAction.SPI_GETICONTITLELOGFONT" />, <see cref="F:PInvoke.User32.SystemParametersInfoAction.SPI_GETICONMETRICS" />, or <see cref="F:PInvoke.User32.SystemParametersInfoAction.SPI_GETNONCLIENTMETRICS" />. See <see cref="T:PInvoke.User32.SystemParametersInfoAction" /> for more information on these values.</param>
		/// <param name="uiParam">A parameter whose usage and format depends on the system parameter being queried. For more information about system-wide parameters, see the <paramref name="uiAction" /> parameter. If not otherwise indicated, you must specify zero for this parameter.</param>
		/// <param name="pvParam">A parameter whose usage and format depends on the system parameter being queried. For more information about system-wide parameters, see the <paramref name="uiAction" /> parameter. If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// <param name="fWinIni">Has no effect for with this API. This parameter only has an effect if you're setting parameter.</param>
		/// <param name="dpi">The DPI to use for scaling the metric.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// This function returns a similar result as SystemParametersInfo, but scales it according to an arbitrary DPI you provide (if appropriate). It only scales with the following possible values for uiAction:
		///     SPI_GETICONTITLELOGFONT, SPI_GETICONMETRICS, SPI_GETNONCLIENTMETRICS.
		/// Other possible uiAction values do not provide ForDPI behavior, and therefore this function returns 0 if called with them.
		/// For uiAction values that contain strings within their associated structures, only Unicode(LOGFONTW) strings are supported in this function.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool SystemParametersInfoForDpi(User32.SystemParametersInfoAction uiAction,
		                                                            int uiParam, void* pvParam,
		                                                            User32.SystemParametersInfoFlags fWinIni, int dpi);

		/// <summary>
		/// Sets the current process to a specified dots per inch (dpi) awareness context.
		/// </summary>
		/// <param name="dpiAWarenessContext">The DPI awareness value to set.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// 
		/// Possible errors are <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_PARAMETER" /> for an invalid input, and <see cref="F:PInvoke.Win32ErrorCode.ERROR_ACCESS_DENIED" /> if the default API awareness mode for the process has already been set (via a previous API call or within the application manifest).
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetProcessDpiAwarenessContext(IntPtr dpiAWarenessContext);

		/// <summary>
		/// Dialogs in Per-Monitor v2 contexts are automatically DPI scaled. This method lets you customize their DPI change behavior.
		/// This function works in conjunction with the <see cref="T:PInvoke.User32.DIALOG_DPI_CHANGE_BEHAVIORS" /> enum in order to override the default DPI scaling behavior for
		/// dialogs.This function is called on a specified dialog, for which the specified flags are individually saved.
		/// This function does not affect the DPI scaling behavior for the child windows of the dialog in question - that is done with SetDialogControlDpiChangeBehavior.
		/// </summary>
		/// <param name="hDlg">A handle for the dialog whose behavior will be modified.</param>
		/// <param name="mask">A mask specifying the subset of flags to be changed.</param>
		/// <param name="values">The desired value to be set for the specified subset of flags.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// 
		/// Possible errors are <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_HANDLE" /> for an invalid dialog HWND, and <see cref="F:PInvoke.Win32ErrorCode.ERROR_ACCESS_DENIED" /> if if the dialog belongs to another process.
		/// </returns>
		/// <remarks>
		/// For extensibility, <see cref="T:PInvoke.User32.DIALOG_DPI_CHANGE_BEHAVIORS" /> was modeled as a set of bit-flags representing separate behaviors. This function
		/// follows the typical two-parameter approach to setting flags, where a mask specifies the subset of the flags to be changed.
		/// It is not an error to call this API outside of Per Monitor v2 contexts, though the flags will have no effect on the behavior of the
		/// specified dialog until the context is changed to Per Monitor v2.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDialogDpiChangeBehavior(IntPtr hDlg, User32.DIALOG_DPI_CHANGE_BEHAVIORS mask,
		                                                     User32.DIALOG_DPI_CHANGE_BEHAVIORS values);

		/// <summary>
		/// Returns the flags that might have been set on a given dialog by an earlier call to SetDialogDpiChangeBehavior.
		/// If that function was never called on the dialog, the return value will be 0.
		/// </summary>
		/// <param name="hDlg">The handle for the dialog to examine.</param>
		/// <returns>The flags set on the given dialog. If passed an invalid handle, this function will return 0, and set its last error to <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_HANDLE" />.</returns>
		/// <remarks>
		/// It can be difficult to distinguish between a return value of <see cref="F:PInvoke.User32.DIALOG_DPI_CHANGE_BEHAVIORS.DDC_DEFAULT" /> and the error case, which is zero. To determine between the two, it is recommended that you call <see cref="M:PInvoke.Kernel32.GetLastError" /> to check the error.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior(IntPtr hDlg);

		/// <summary>
		/// Overrides the default per-monitor DPI scaling behavior of a child window in a dialog.
		/// </summary>
		/// <param name="hwnd">A handle for the window whose behavior will be modified.</param>
		/// <param name="mask">A mask specifying the subset of flags to be changed.</param>
		/// <param name="values">The desired value to be set for the specified subset of flags.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// 
		/// Possible errors are <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_HANDLE" /> if passed an invalid HWND, and <see cref="F:PInvoke.Win32ErrorCode.ERROR_ACCESS_DENIED" /> if the windows belongs to another process.
		/// </returns>
		/// <remarks>
		/// The behaviors are specified as values from the <see cref="T:PInvoke.User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS" /> enum. This function follows the typical two-parameter approach
		/// to setting flags, where a mask specifies the subset of the flags to be changed.
		/// It is valid to set these behaviors on any window.It does not matter if the window is currently a child of a dialog at the point in time that SetDialogControlDpiChangeBehavior is
		/// called.The behaviors are retained and will take effect only when the window is an immediate child of a dialog that has per-monitor DPI scaling enabled.
		/// This API influences individual controls within dialogs.The dialog-wide per-monitor DPI scaling behavior is controlled by SetDialogDpiChangeBehavior.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDialogControlDpiChangeBehavior(IntPtr hwnd,
		                                                            User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask,
		                                                            User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);

		/// <summary>
		/// Retrieves and per-monitor DPI scaling behavior overrides of a child window in a dialog.
		/// </summary>
		/// <param name="hWnd">The handle for the window to examine.</param>
		/// <returns>The flags set on the given window. If passed an invalid handle, this function will return zero, and set its last error to <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_HANDLE" />.</returns>
		/// <remarks>It can be difficult to distinguish between a return value of <see cref="F:PInvoke.User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.DCDC_DEFAULT" /> and the error case, which is zero. To determine between the two, it is recommended that you call <see cref="M:PInvoke.Kernel32.GetLastError" /> to check the error.</remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior(IntPtr hWnd);

		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern int GetSystemDpiForProcess(Kernel32.SafeObjectHandle hProcess);

		/// <summary>
		/// Retrieves the DPI from a given DPI_AWARENESS_CONTEXT handle. This enables you to determine the DPI of a thread without needed to examine a window created within that thread.
		/// </summary>
		/// <param name="dpiAwarenessContext">The DPI_AWARENESS_CONTEXT handle to examine.</param>
		/// <returns>The DPI value associated with the DPI_AWARENESS_CONTEXT handle</returns>
		/// <remarks>
		/// DPI_AWARENESS_CONTEXT handles associated with values of <see cref="F:PInvoke.User32.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE" /> and
		/// <see cref="F:PInvoke.User32.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2" /> will return a value of 0 for their DPI. This is because the DPI of a
		/// per-monitor-aware window can change, and the actual DPI cannot be returned without the window's HWND.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern int GetDpiFromDpiAwarenessContext(IntPtr dpiAwarenessContext);

		/// <summary>
		/// Sets the thread's <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" />. This behavior allows windows created in the thread to host child windows with a different DPI_AWARENESS_CONTEXT.
		/// </summary>
		/// <param name="dpiHostingBehavior">The new <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> value for the current thread.</param>
		/// <returns>
		/// The previous <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> for the thread. If the hosting behavior passed in is invalid, the thread will not be updated and the return value will be
		/// <see cref="F:PInvoke.User32.DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_INVALID" />. You can use this value to restore the old <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> after overriding it with a predefined value.
		/// </returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> enables a mixed content hosting behavior, which allows parent windows created in the thread to host child windows with a different DPI_AWARENESS_CONTEXT value.
		/// This property only effects new windows created within this thread while the mixed hosting behavior is active. A parent window with this hosting behavior is able to host child windows with
		/// different DPI_AWARENESS_CONTEXT values, regardless of whether the child windows have mixed hosting behavior enabled
		/// </para>
		/// <para>
		/// This hosting behavior does not allow for windows with per-monitor DPI_AWARENESS_CONTEXT values to be hosted until windows with DPI_AWARENESS_CONTEXT values of system or unaware.
		/// </para>
		/// <para>
		/// To avoid unexpected outcomes, a thread's <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> should be changed to support mixed hosting behaviors only when creating a new window which needs to support those behaviors.
		/// Once that window is created, the hosting behavior should be switched back to its default value.
		/// </para>
		/// <para>
		/// This API is used to change the thread's <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> from its default value. This is only necessary if your app needs to host child windows from plugins and third-party
		/// components that do not support per-monitor-aware context. This is most likely to occur if you are updating complex applications to support per-monitor DPI_AWARENESS_CONTEXT behaviors.
		/// </para>
		/// <para>
		/// Enabling mixed hosting behavior will not automatically adjust the thread's DPI_AWARENESS_CONTEXT to be compatible with legacy content. The thread's awareness context must
		/// still be manually changed before new windows are created to host such content.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern User32.DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(
			User32.DPI_HOSTING_BEHAVIOR dpiHostingBehavior);

		/// <summary>
		/// Retrieves the <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> from the current thread.
		/// </summary>
		/// <returns>The <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> of the current thread.</returns>
		/// <remarks>
		/// This API returns the hosting behavior set by an earlier call of <see cref="M:PInvoke.User32.SetThreadDpiHostingBehavior(PInvoke.User32.DPI_HOSTING_BEHAVIOR)" />,
		/// or <see cref="F:PInvoke.User32.DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_DEFAULT" /> if no earlier call has been made.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern User32.DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior();

		/// <summary>
		/// Returns the <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> of the specified window.
		/// </summary>
		/// <param name="hwnd">The handle for the window to examine.</param>
		/// <returns>The <see cref="T:PInvoke.User32.DPI_HOSTING_BEHAVIOR" /> of the specified window.</returns>
		/// <remarks>
		/// This API allows you to examine the hosting behavior of a window after it has been created. A window's hosting behavior
		/// is the hosting behavior of the thread in which the window was created, as set by a call to <see cref="M:PInvoke.User32.SetThreadDpiHostingBehavior(PInvoke.User32.DPI_HOSTING_BEHAVIOR)" />.
		/// This is a permanent value and cannot be changed after the window is created, even if the thread's hosting behavior is changed.
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode)]
		public static extern User32.DPI_HOSTING_BEHAVIOR GetWindowDpiHostingBehavior(IntPtr hwnd);

		/// <summary>
		/// Calculates the required size of the window rectangle, based on the desired size of the client rectangle.
		/// The window rectangle can then be passed to the CreateWindowEx function to create a window whose client area
		/// is the desired size.
		/// </summary>
		/// <param name="lpRect">
		/// A pointer to a RECT structure that contains the coordinates of the top-left and bottom-right corners
		/// of the desired client area. When the function returns, the structure contains the coordinates of the top-left
		/// and bottom-right corners of the window to accommodate the desired client area.
		/// </param>
		/// <param name="dwStyle">
		/// The window style of the window whose required size is to be calculated. Note that you cannot specify
		/// the <see cref="F:PInvoke.User32.WindowStyles.WS_OVERLAPPED" /> style.</param>
		/// <param name="bMenu">Indicates whether the window has a menu.</param>
		/// <param name="dwExStyle">The extended window style of the window whose required size is to be calculated.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false.
		/// To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// <para>
		/// A client rectangle is the smallest rectangle that completely encloses a client area.
		/// A window rectangle is the smallest rectangle that completely encloses the window, which includes
		/// the client area and the nonclient area.
		/// </para>
		/// <para>
		/// The AdjustWindowRectEx function does not add extra space when a menu bar wraps to two or more rows.
		/// </para>
		/// <para>
		/// The AdjustWindowRectEx function does not take the <see cref="F:PInvoke.User32.WindowStyles.WS_VSCROLL" /> or
		/// <see cref="F:PInvoke.User32.WindowStyles.WS_HSCROLL" /> styles into account.
		/// To account for the scroll bars, call the GetSystemMetrics function with <see cref="F:PInvoke.User32.SystemMetric.SM_CXVSCROLL" /> or
		/// <see cref="F:PInvoke.User32.SystemMetric.SM_CYHSCROLL" />.
		/// </para>
		/// <para>
		/// This API is not DPI aware, and should not be used if the calling thread is per-monitor DPI aware.
		/// For the DPI-aware version of this API, see AdjustWindowsRectExForDPI.
		/// </para>
		/// </remarks>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool AdjustWindowRectEx(RECT* lpRect, User32.WindowStyles dwStyle,
		                                                    [MarshalAs(UnmanagedType.Bool)] bool bMenu,
		                                                    User32.WindowStylesEx dwExStyle);

		/// <summary>
		/// The BeginPaint function prepares the specified window for painting and fills a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure with information about the painting.
		/// </summary>
		/// <param name="hwnd">Handle to the window to be repainted.</param>
		/// <param name="lpPaint">Pointer to the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that will receive painting information.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to a display device context for the specified window.
		/// If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />, indicating that no display device context is available..</returns>
		/// <remarks>
		/// <para>
		/// The BeginPaint function automatically sets the clipping region of the device context to exclude any area outside the update region.
		/// The update region is set by the InvalidateRect or InvalidateRgn function and by the system after sizing, moving, creating, scrolling,
		/// or any other operation that affects the client area. If the update region is marked for erasing, BeginPaint sends a <see cref="F:PInvoke.User32.WindowMessage.WM_ERASEBKGND" /> message to the window.
		/// </para>
		/// <para>
		/// An application should not call BeginPaint except in response to a <see cref="F:PInvoke.User32.WindowMessage.WM_PAINT" /> message.
		/// Each call to BeginPaint must have a corresponding call to the <see cref="M:PInvoke.User32.EndPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function.
		/// </para>
		/// <para>
		/// If the caret is in the area to be painted, BeginPaint automatically hides the caret to prevent it from being erased.
		/// If the window's class has a background brush, BeginPaint uses that brush to erase the background of the update region before returning.
		/// </para>
		/// </remarks>
		[DllImport("User32", EntryPoint = "BeginPaint", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern unsafe IntPtr BeginPaint_IntPtr(IntPtr hwnd, User32.PAINTSTRUCT* lpPaint);

		/// <summary>
		/// The <see cref="M:PInvoke.User32.GetDC(System.IntPtr)" /> function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen.
		/// You can use the returned handle in subsequent GDI functions to draw in the DC. The device context is an opaque data structure, whose values are used internally by GDI.
		/// The GetDCEx function is an extension to <see cref="M:PInvoke.User32.GetDC(System.IntPtr)" />, which gives an application more control over how and whether clipping occurs in the client area.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be retrieved. If this value is NULL, <see cref="M:PInvoke.User32.GetDC(System.IntPtr)" /> retrieves the DC for the entire screen.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the DC for the specified window's client area.
		/// If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />.
		/// </returns>
		[DllImport("User32", EntryPoint = "GetDC", CharSet = CharSet.Unicode)]
		private static extern IntPtr GetDC_IntPtr(IntPtr hWnd);

		/// <summary>
		/// The GetDCEx function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen.
		/// You can use the returned handle in subsequent GDI functions to draw in the DC. The device context is an opaque data structure, whose values are used internally by GDI.
		/// This function is an extension to the <see cref="M:PInvoke.User32.GetDC(System.IntPtr)" /> function, which gives an application more control over how and whether clipping occurs in the client area.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be retrieved. If this value is <see cref="F:System.IntPtr.Zero" />, GetDCEx retrieves the DC for the entire screen.</param>
		/// <param name="hrgnClip">
		/// A clipping region that may be combined with the visible region of the DC.
		/// If the value of flags is <see cref="F:PInvoke.User32.DeviceContextValues.DCX_INTERSECTRGN" /> or <see cref="F:PInvoke.User32.DeviceContextValues.DCX_EXCLUDERGN" />,
		/// then the operating system assumes ownership of the region and will automatically delete it when it is no longer needed.
		/// In this case, the application should not use or delete the region after a successful call to GetDCEx.</param>
		/// <param name="flags">Specifies how the DC is created.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to the DC for the specified window. If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />.
		/// An invalid value for the hWnd parameter will cause the function to fail.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Unless the display DC belongs to a window class, the <see cref="M:PInvoke.User32.ReleaseDC(System.IntPtr,System.IntPtr)" /> function must be called to release the DC after painting.
		/// Also, <see cref="M:PInvoke.User32.ReleaseDC(System.IntPtr,System.IntPtr)" /> must be called from the same thread that called GetDCEx. The number of DCs is limited only by available memory.
		/// </para>
		/// <para>
		/// The function returns a handle to a DC that belongs to the window's class if CS_CLASSDC, CS_OWNDC or CS_PARENTDC was specified as a style in the WNDCLASS structure when the class was registered.
		/// </para>
		/// </remarks>
		[DllImport("User32", EntryPoint = "GetDCEx", CharSet = CharSet.Unicode)]
		private static extern IntPtr GetDCEx_IntPtr(IntPtr hWnd, IntPtr hrgnClip, User32.DeviceContextValues flags);

		/// <summary>
		/// The GetWindowDC function retrieves the device context (DC) for the entire window, including title bar, menus, and scroll bars.
		/// A window device context permits painting anywhere in a window, because the origin of the device context is the upper-left corner of the window instead of the client area.
		/// GetWindowDC assigns default attributes to the window device context each time it retrieves the device context. Previous attributes are lost.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window with a device context that is to be retrieved. If this value is <see cref="F:System.IntPtr.Zero" />, GetWindowDC retrieves the device context for the entire screen.
		/// If this parameter is <see cref="F:System.IntPtr.Zero" />, GetWindowDC retrieves the device context for the primary display monitor.
		/// To get the device context for other display monitors, use the <see cref="M:PInvoke.User32.EnumDisplayMonitors(System.IntPtr,PInvoke.RECT*,PInvoke.User32.MONITORENUMPROC,System.Void*)" /> and CreateDC functions.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to a device context for the specified window.
		/// If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />, indicating an error or an invalid hWnd parameter.
		/// </returns>
		/// <remarks>
		/// <para>
		/// GetWindowDC is intended for special painting effects within a window's nonclient area. Painting in nonclient areas of any window is not recommended.
		/// </para>
		/// <para>
		/// The <see cref="M:PInvoke.User32.GetSystemMetrics(PInvoke.User32.SystemMetric)" /> function can be used to retrieve the dimensions of various parts of the nonclient area, such as the title bar, menu, and scroll bars.
		/// The <see cref="M:PInvoke.User32.GetDC(System.IntPtr)" /> function can be used to retrieve a device context for the entire screen.
		/// After painting is complete, the <see cref="M:PInvoke.User32.ReleaseDC(System.IntPtr,System.IntPtr)" /> function must be called to release the device context.
		/// Not releasing the window device context has serious effects on painting requested by applications.
		/// </para>
		/// </remarks>
		[DllImport("User32", EntryPoint = "GetWindowDC", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern IntPtr GetWindowDC_IntPtr(IntPtr hWnd);

		/// <summary>
		///     Removes a hook procedure installed in a hook chain by the
		///     <see cref="M:PInvoke.User32.SetWindowsHookEx(PInvoke.User32.WindowsHookType,System.IntPtr,System.IntPtr,System.Int32)" /> function.
		/// </summary>
		/// <param name="hhk">
		///     A handle to the hook to be removed. This parameter is a hook handle obtained by a previous call to
		///     <see cref="M:PInvoke.User32.SetWindowsHookEx(PInvoke.User32.WindowsHookType,System.IntPtr,System.IntPtr,System.Int32)" />.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is true.
		///     <para>If the function fails, the return value is false. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		/// <summary>
		///     Removes a hook procedure installed in a hook chain by the
		///     <see cref="M:PInvoke.User32.SetWinEventHook(PInvoke.User32.WindowsEventHookType,PInvoke.User32.WindowsEventHookType,System.IntPtr,System.IntPtr,System.Int32,System.Int32,PInvoke.User32.WindowsEventHookFlags)" /> function.
		/// </summary>
		/// <param name="hWinEventHook">
		///     A handle to the hook to be removed. This parameter is a hook handle obtained by a previous call to
		///     <see cref="M:PInvoke.User32.SetWinEventHook(PInvoke.User32.WindowsEventHookType,PInvoke.User32.WindowsEventHookType,System.IntPtr,System.IntPtr,System.Int32,System.Int32,PInvoke.User32.WindowsEventHookFlags)" />.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is true.
		///     <para>If the function fails, the return value is false. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWinEvent(IntPtr hWinEventHook);

		/// <summary>
		/// Creates an overlapped, pop-up, or child window with an
		/// extended window style; otherwise, this function is identical to the CreateWindow function.
		/// </summary>
		/// <param name="dwExStyle">Specifies the extended window style of the window being created.</param>
		/// <param name="lpClassName">
		/// Pointer to a class atom created by a previous call to the
		/// RegisterClass or RegisterClassEx function. The atom must be in the low-order word of
		/// lpClassName; the high-order word must be zero.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		[DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern unsafe IntPtr CreateWindowEx(User32.WindowStylesEx dwExStyle, IntPtr lpClassName,
		                                                   string lpWindowName, User32.WindowStyles dwStyle, int x,
		                                                   int y, int nWidth, int nHeight, IntPtr hWndParent,
		                                                   IntPtr hMenu, IntPtr hInstance, void* lpParam);

		/// <summary>
		/// Changes an attribute of the specified window. The function also sets a value at the specified
		/// offset in the extra window memory.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="nIndex">The zero-based offset to the value to be set.</param>
		/// <param name="dwNewLong">The replacement value.</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is the previous value of the specified offset.</para>
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// <para>If the previous value is zero and the function succeeds, the return value is zero, but the function does
		/// not clear the last error information. To determine success or failure, clear the last error information by
		/// calling SetLastError with 0, then call SetWindowLongPtr. Function failure will be indicated by a return value of
		/// zero and a GetLastError result that is nonzero.</para>
		/// </returns>
		/// <remarks>
		/// When compiling for 32-bit Windows, SetWindowLongPtr is defined as a call to the SetWindowLong function. This
		/// function is exposed using a helper that conditionally calls SetWindowLong in 32-bit processes.
		/// </remarks>
		[DllImport("User32", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern unsafe void* SetWindowLongPtr64(IntPtr hWnd, User32.WindowLongIndexFlags nIndex,
		                                                      void* dwNewLong);

		/// <summary>
		/// The BeginPaint function prepares the specified window for painting and fills a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure with information about the painting.
		/// </summary>
		/// <param name="hwnd">Handle to the window to be repainted.</param>
		/// <param name="lpPaint">Pointer to the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that will receive painting information.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to a display device context for the specified window.
		/// If the function fails, the return value is <see cref="F:PInvoke.User32.SafeDCHandle.Null" />, indicating that no display device context is available..</returns>
		/// <remarks>
		/// <para>
		/// The BeginPaint function automatically sets the clipping region of the device context to exclude any area outside the update region.
		/// The update region is set by the InvalidateRect or InvalidateRgn function and by the system after sizing, moving, creating, scrolling,
		/// or any other operation that affects the client area. If the update region is marked for erasing, BeginPaint sends a <see cref="F:PInvoke.User32.WindowMessage.WM_ERASEBKGND" /> message to the window.
		/// </para>
		/// <para>
		/// An application should not call BeginPaint except in response to a <see cref="F:PInvoke.User32.WindowMessage.WM_PAINT" /> message.
		/// Each call to BeginPaint must have a corresponding call to the <see cref="M:PInvoke.User32.EndPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function.
		/// </para>
		/// <para>
		/// If the caret is in the area to be painted, BeginPaint automatically hides the caret to prevent it from being erased.
		/// If the window's class has a background brush, BeginPaint uses that brush to erase the background of the update region before returning.
		/// </para>
		/// </remarks>
		public static unsafe User32.SafeDCHandle BeginPaint(IntPtr hwnd, User32.PAINTSTRUCT* lpPaint) {
			IntPtr hDC = User32.BeginPaint_IntPtr(hwnd, lpPaint);
			if (!(hDC != IntPtr.Zero))
				return (User32.SafeDCHandle) null;
			return new User32.SafeDCHandle(hwnd, hDC, true);
		}

		/// <summary>
		/// The GetDC function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen.
		/// You can use the returned handle in subsequent GDI functions to draw in the DC. The device context is an opaque data structure, whose values are used internally by GDI.
		/// The GetDCEx function is an extension to GetDC, which gives an application more control over how and whether clipping occurs in the client area.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be retrieved. If this value is NULL, GetDC retrieves the DC for the entire screen.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the DC for the specified window's client area.
		/// If the function fails, the return value is <see cref="F:PInvoke.User32.SafeDCHandle.Null" />.
		/// </returns>
		public static User32.SafeDCHandle GetDC(IntPtr hWnd) {
			IntPtr dcIntPtr = User32.GetDC_IntPtr(hWnd);
			if (!(dcIntPtr != IntPtr.Zero))
				return (User32.SafeDCHandle) null;
			return new User32.SafeDCHandle(hWnd, dcIntPtr, true);
		}

		/// <summary>
		/// The GetDCEx function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen.
		/// You can use the returned handle in subsequent GDI functions to draw in the DC. The device context is an opaque data structure, whose values are used internally by GDI.
		/// This function is an extension to the <see cref="M:PInvoke.User32.GetDC(System.IntPtr)" /> function, which gives an application more control over how and whether clipping occurs in the client area.
		/// </summary>
		/// <param name="hWnd">A handle to the window whose DC is to be retrieved. If this value is <see cref="F:System.IntPtr.Zero" />, GetDCEx retrieves the DC for the entire screen.</param>
		/// <param name="hrgnClip">
		/// A clipping region that may be combined with the visible region of the DC.
		/// If the value of flags is <see cref="F:PInvoke.User32.DeviceContextValues.DCX_INTERSECTRGN" /> or <see cref="F:PInvoke.User32.DeviceContextValues.DCX_EXCLUDERGN" />,
		/// then the operating system assumes ownership of the region and will automatically delete it when it is no longer needed.
		/// In this case, the application should not use or delete the region after a successful call to GetDCEx.</param>
		/// <param name="flags">Specifies how the DC is created.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to the DC for the specified window. If the function fails, the return value is <see cref="F:PInvoke.User32.SafeDCHandle.Null" />.
		/// An invalid value for the hWnd parameter will cause the function to fail.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Unless the display DC belongs to a window class, the <see cref="M:PInvoke.User32.ReleaseDC(System.IntPtr,System.IntPtr)" /> function must be called to release the DC after painting.
		/// Also, <see cref="M:PInvoke.User32.ReleaseDC(System.IntPtr,System.IntPtr)" /> must be called from the same thread that called GetDCEx. The number of DCs is limited only by available memory.
		/// </para>
		/// <para>
		/// The function returns a handle to a DC that belongs to the window's class if CS_CLASSDC, CS_OWNDC or CS_PARENTDC was specified as a style in the WNDCLASS structure when the class was registered.
		/// </para>
		/// </remarks>
		public static User32.SafeDCHandle GetDCEx(IntPtr hWnd, IntPtr hrgnClip, User32.DeviceContextValues flags) {
			IntPtr dcExIntPtr = User32.GetDCEx_IntPtr(hWnd, hrgnClip, flags);
			if (!(dcExIntPtr != IntPtr.Zero))
				return (User32.SafeDCHandle) null;
			return new User32.SafeDCHandle(hWnd, dcExIntPtr, true);
		}

		/// <summary>
		/// The GetWindowDC function retrieves the device context (DC) for the entire window, including title bar, menus, and scroll bars.
		/// A window device context permits painting anywhere in a window, because the origin of the device context is the upper-left corner of the window instead of the client area.
		/// GetWindowDC assigns default attributes to the window device context each time it retrieves the device context. Previous attributes are lost.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window with a device context that is to be retrieved. If this value is <see cref="F:System.IntPtr.Zero" />, GetWindowDC retrieves the device context for the entire screen.
		/// If this parameter is <see cref="F:System.IntPtr.Zero" />, GetWindowDC retrieves the device context for the primary display monitor.
		/// To get the device context for other display monitors, use the <see cref="M:PInvoke.User32.EnumDisplayMonitors(System.IntPtr,PInvoke.RECT*,PInvoke.User32.MONITORENUMPROC,System.Void*)" /> and CreateDC functions.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to a device context for the specified window.
		/// If the function fails, the return value is <see cref="F:PInvoke.User32.SafeDCHandle.Null" />, indicating an error or an invalid hWnd parameter.
		/// </returns>
		/// <remarks>
		/// <para>
		/// GetWindowDC is intended for special painting effects within a window's nonclient area. Painting in nonclient areas of any window is not recommended.
		/// </para>
		/// <para>
		/// The <see cref="M:PInvoke.User32.GetSystemMetrics(PInvoke.User32.SystemMetric)" /> function can be used to retrieve the dimensions of various parts of the nonclient area, such as the title bar, menu, and scroll bars.
		/// The <see cref="M:PInvoke.User32.GetDC(System.IntPtr)" /> function can be used to retrieve a device context for the entire screen.
		/// After painting is complete, the <see cref="M:PInvoke.User32.ReleaseDC(System.IntPtr,System.IntPtr)" /> function must be called to release the device context.
		/// Not releasing the window device context has serious effects on painting requested by applications.
		/// </para>
		/// </remarks>
		public static User32.SafeDCHandle GetWindowDC(IntPtr hWnd) {
			IntPtr windowDcIntPtr = User32.GetWindowDC_IntPtr(hWnd);
			if (!(windowDcIntPtr != IntPtr.Zero))
				return (User32.SafeDCHandle) null;
			return new User32.SafeDCHandle(hWnd, windowDcIntPtr, true);
		}

		/// <summary>
		/// The CreateWindow is identical to the CreateWindowEx function, actually it is a macro on C/C++
		/// </summary>
		/// <param name="lpClassName">
		/// Pointer to a null-terminated string or a class atom created by a previous call to the
		/// RegisterClass or RegisterClassEx function. The atom must be in the low-order word of
		/// lpClassName; the high-order word must be zero. If lpClassName is a string, it specifies
		/// the window class name. The class name can be any name registered with RegisterClass or
		/// RegisterClassEx, provided that the module that registers the class is also the module
		/// that creates the window. The class name can also be any of the predefined system class names.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		public static unsafe IntPtr CreateWindow(string lpClassName, string lpWindowName, User32.WindowStyles dwStyle,
		                                         int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu,
		                                         IntPtr hInstance, void* lpParam) {
			return User32.CreateWindowEx(User32.WindowStylesEx.WS_EX_LEFT, lpClassName, lpWindowName, dwStyle, x, y,
				nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);
		}

		/// <summary>
		/// Retrieves the name of the class to which the specified window belongs.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="maxLength">The size of the string to return</param>
		/// <returns>The class name string.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown when an error occurs.</exception>
		/// <remarks>The maximum length for lpszClassName is 256. See WNDCLASS structure documentation: https://msdn.microsoft.com/en-us/library/windows/desktop/ms633576(v=vs.85).aspx</remarks>
		public static unsafe string GetClassName(IntPtr hWnd, int maxLength = 256) {
			char* lpClassName = stackalloc char[maxLength];
			int className = User32.GetClassName(hWnd, lpClassName, maxLength);
			if (className == 0)
				throw new Win32Exception();
			return new string(lpClassName, 0, className);
		}

		/// <summary>
		/// Retrieves from the clipboard the name of the specified registered format.
		/// </summary>
		/// <param name="format">The type of format to be retrieved. This parameter must not specify any of the predefined clipboard formats.</param>
		/// <returns>The format name string.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown when an error occurs.</exception>
		public static unsafe string GetClipboardFormatName(int format) {
			// ISSUE: untyped stack allocation
			char* lpszFormatName = (char*) __untypedstackalloc(new IntPtr(512));
			int clipboardFormatName = User32.GetClipboardFormatName(format, lpszFormatName, 256);
			if (clipboardFormatName == 0)
				throw new Win32Exception();
			return new string(lpszFormatName, 0, clipboardFormatName);
		}

		/// <summary>
		/// Get the text of the specified window's title bar (if it has one). If the specified window is a control, the
		/// text of the control is returned. However, GetWindowText cannot retrieve the text of a control in another application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control containing the text.</param>
		/// <returns>
		/// The text of the specified window's title bar. If the specified window is a control, the text of the control is
		/// returned.
		/// </returns>
		public static string GetWindowText(IntPtr hWnd) {
			int windowTextLength = User32.GetWindowTextLength(hWnd);
			if (windowTextLength == 0) {
				Win32ErrorCode lastError = Kernel32.GetLastError();
				if (lastError != null)
					throw new Win32Exception(lastError);
				return string.Empty;
			}

			char[] lpString = new char[windowTextLength + 1];
			int windowText = User32.GetWindowText(hWnd, lpString, windowTextLength + 1);
			if (windowText != 0)
				return new string(lpString, 0, windowText);
			Win32ErrorCode lastError1 = Kernel32.GetLastError();
			if (lastError1 != null)
				throw new Win32Exception(lastError1);
			return string.Empty;
		}

		/// <summary>
		/// Retrieves the position of the mouse cursor, in screen coordinates.
		/// </summary>
		/// <returns>The screen coordinates of the cursor</returns>
		public static unsafe POINT GetCursorPos() {
			POINT point = (POINT) null;
			if (!User32.GetCursorPos(&point))
				throw new Win32Exception();
			return point;
		}

		/// <summary>Retrieves the show state and the restored, minimized, and maximized positions of the specified window.</summary>
		/// <param name="hWnd">A handle to the window.</param>
		/// <returns>
		/// A WINDOWPLACEMENT structure with the show state and position information.
		/// </returns>
		public static unsafe User32.WINDOWPLACEMENT GetWindowPlacement(IntPtr hWnd) {
			User32.WINDOWPLACEMENT windowplacement = User32.WINDOWPLACEMENT.Create();
			if (!User32.GetWindowPlacement(hWnd, &windowplacement))
				throw new Win32Exception();
			return windowplacement;
		}

		/// <summary>
		/// Changes an attribute of the specified window. The function also sets a value at the specified
		/// offset in the extra window memory.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.
		/// The SetWindowLongPtr function fails if the process that owns the window specified by the
		/// <paramref name="hWnd" /> parameter is at a higher process privilege in the UIPI hierarchy than the
		/// process the calling thread resides in.</param>
		/// <param name="nIndex">The zero-based offset to the value to be set. Valid values are in the range zero
		/// through the number of bytes of extra window memory, minus the size of a LONG_PTR. To set any other value,
		/// specify one of the following values.
		/// 
		/// <list type="table">
		/// <listheader><term>Value</term><term>Meaning</term></listheader>
		/// <item><term>GWL_EXSTYLE(-20)</term><term>Sets a new extended window style.</term></item>
		/// <item><term>GWLP_HINSTANCE(-6)</term><term>Sets a new application instance handle.</term></item>
		/// <item><term>GWLP_ID(-12)</term><term>Sets a new identifier of the child window.The window cannot be a top-level window.</term></item>
		/// <item><term>GWL_STYLE (-16)</term><term>Sets a new window style.</term></item>
		/// <item><term>GWLP_USERDATA</term><term>Sets the user data associated with the window.This data is intended for use by the application that created the window. Its value is initially zero.</term></item>
		/// <item><term>GWLP_WNDPROC (-4)</term><term>Sets a new address for the window procedure.</term></item>
		/// </list>
		/// 
		/// The following values are also available when the hWnd parameter identifies a dialog box.
		/// 
		/// <list type="table">
		/// <listheader><term>Value</term><term>Meaning</term></listheader>
		/// <item><term>DWLP_DLGPROC (DWLP_MSGRESULT + sizeof(LRESULT))</term><term>Sets the new pointer to the dialog box procedure.</term></item>
		/// <item><term>DWLP_MSGRESULT (0)</term><term>Sets the return value of a message processed in the dialog box procedure.</term></item>
		/// <item><term>DWLP_USER (DWLP_DLGPROC + sizeof(DLGPROC))</term><term>Sets new extra info</term></item>
		/// </list>
		/// 
		/// </param>
		/// <param name="dwNewLong">The replacement value.</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is the previous value of the specified offset.</para>
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// <para>If the previous value is zero and the function succeeds, the return value is zero, but the function does
		/// not clear the last error information. To determine success or failure, clear the last error information by
		/// calling SetLastError with 0, then call SetWindowLongPtr. Function failure will be indicated by a return value of
		/// zero and a GetLastError result that is nonzero.</para>
		/// </returns>
		/// <remarks>
		/// <list type="bullet">
		/// <item>The return type, and the type of <paramref name="dwNewLong" /> are both LONG_PTR.
		/// LONG_PTR is defined as <code>__int64</code> on 64-bit platforms, and it is defined as <code>long</code>
		/// on 32-bit platforms. This definition fits nicely with now <see cref="T:System.IntPtr" /> works on 32-bit vs. 64-bit
		/// platforms.</item>
		/// <item>Windows XP/2000: The SetWindowLongPtr function fails if the window specified by the
		/// <paramref name="hWnd" /> parameter does not belong to the same process as the calling thread.</item>
		/// <item>When compiling for 32-bit Windows, SetWindowLongPtr is defined as a call to the SetWindowLong function.</item>
		/// <item>
		/// <para>Certain window data is cached, so changes you make using SetWindowLongPtr will not take effect until you call
		/// the SetWindowPos function.</para>
		/// <para>If you use SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.GWLP_WNDPROC" /> index to replace the window procedure,
		/// the window procedure must conform to the guidelines specified in the description of the WindowProc callback function.</para>
		/// <para>If you use SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.DWLP_MSGRESULT" /> index to set the return value for a
		/// message processed by a dialog box procedure, the dialog box procedure should return TRUE directly afterward. Otherwise, if you call
		/// any function that results in your dialog box procedure receiving a window message, the nested window message could overwrite the return value
		/// you set by using <see cref="F:PInvoke.User32.WindowLongIndexFlags.DWLP_MSGRESULT" />.</para>
		/// <para>Calling SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.GWLP_WNDPROC" /> index creates a subclass of the window
		/// class used to create the window. An application can subclass a system class, but should not subclass a window class created by another process.
		/// The SetWindowLongPtr function creates the window subclass by changing the window procedure associated with a particular
		/// window class, causing the system to call the new window procedure instead of the previous one. An application must pass
		/// any messages not processed by the new window procedure to the previous window procedure by calling CallWindowProc.
		/// This allows the application to create a chain of window procedures.</para>
		/// <para>Reserve extra window memory by specifying a nonzero value in the <see cref="F:PInvoke.User32.WNDCLASSEX.cbWndExtra" /> member of the
		/// <see cref="T:PInvoke.User32.WNDCLASSEX" /> structure used with the RegisterClassEx function.</para>
		/// <para>Do not call SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.GWLP_HWNDPARENT" /> index to change the parent of a
		/// child window. Instead, use the SetParent function.</para>
		/// <para>If the window has a class style of <see cref="F:PInvoke.User32.ClassStyles.CS_CLASSDC" /> or <see cref="F:PInvoke.User32.ClassStyles.CS_PARENTDC" />, do not set
		/// the extended window styles <see cref="F:PInvoke.User32.WindowStylesEx.WS_EX_COMPOSITED" /> or <see cref="F:PInvoke.User32.WindowStylesEx.WS_EX_LAYERED" />.</para>
		/// <para>Calling SetWindowLongPtr to set the style on a progressbar will reset its position.</para>
		/// </item>
		/// </list>
		/// </remarks>
		public static unsafe void* SetWindowLongPtr(IntPtr hWnd, User32.WindowLongIndexFlags nIndex, void* dwNewLong) {
			if (IntPtr.Size == 8)
				return User32.SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
			User32.SetWindowLongFlags dwNewLong1 = (User32.SetWindowLongFlags) (int) dwNewLong;
			return (void*) User32.SetWindowLong(hWnd, nIndex, dwNewLong1);
		}

		/// <summary>
		/// Retrieves the name of the class to which the specified window belongs.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="lpClassName">The class name string.</param>
		/// <param name="nMaxCount">
		/// The length of the <paramref name="lpClassName" /> buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the class name string is truncated to <paramref name="nMaxCount" />-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer, not including the terminating null character.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int GetClassName(IntPtr hWnd, IntPtr lpClassName, int nMaxCount) {
			char* pointer = (char*) lpClassName.ToPointer();
			return User32.GetClassName(hWnd, pointer, nMaxCount);
		}

		/// <summary>
		/// Retrieves the name of the class to which the specified window belongs.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="lpClassName">The class name string.</param>
		/// <param name="nMaxCount">
		/// The length of the <paramref name="lpClassName" /> buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the class name string is truncated to <paramref name="nMaxCount" />-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer, not including the terminating null character.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int GetClassName(IntPtr hWnd, char[] lpClassName, int nMaxCount) {
			char[] chArray;
			char* lpClassName1 = (chArray = lpClassName) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return User32.GetClassName(hWnd, lpClassName1, nMaxCount);
		}

		/// <summary>
		/// Sends the specified message to a window or windows. The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		/// To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function. To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure will receive the message. If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.
		/// Message sending is subject to UIPI. The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
		/// </param>
		/// <param name="wMsg">
		/// The message to be sent.
		/// For lists of the system-provided messages, see <see cref="T:PInvoke.User32.WindowMessage" />.
		/// </param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
		public static unsafe IntPtr SendMessage(IntPtr hWnd, User32.WindowMessage wMsg, IntPtr wParam, IntPtr lParam) {
			void* pointer1 = wParam.ToPointer();
			void* pointer2 = lParam.ToPointer();
			return User32.SendMessage(hWnd, wMsg, pointer1, pointer2);
		}

		/// <summary>
		/// Places (posts) a message in the message queue associated with the thread that created the specified window and returns without waiting for the thread to process the message.
		/// To post a message in the message queue associated with a thread, use the PostThreadMessage function.
		/// </summary>
		/// <param name="hWnd">
		/// A handle to the window whose window procedure is to receive the message.
		/// </param>
		/// <param name="wMsg">
		/// The message to be posted.
		/// For lists of the system-provided messages, see <see cref="T:PInvoke.User32.WindowMessage" />.
		/// </param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError. GetLastError returns ERROR_NOT_ENOUGH_QUOTA when the limit is hit.
		/// </returns>
		public static unsafe bool PostMessage(IntPtr hWnd, User32.WindowMessage wMsg, IntPtr wParam, IntPtr lParam) {
			void* pointer1 = wParam.ToPointer();
			void* pointer2 = lParam.ToPointer();
			return User32.PostMessage(hWnd, wMsg, pointer1, pointer2);
		}

		public static unsafe uint RealGetWindowClass(IntPtr hwnd, IntPtr pszType, uint cchType) {
			char* pointer = (char*) pszType.ToPointer();
			return User32.RealGetWindowClass(hwnd, pointer, cchType);
		}

		public static unsafe uint RealGetWindowClass(IntPtr hwnd, char[] pszType, uint cchType) {
			char[] chArray;
			char* pszType1 = (chArray = pszType) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return User32.RealGetWindowClass(hwnd, pszType1, cchType);
		}

		/// <summary>
		/// Searches through icon or cursor data for the icon or cursor that best fits the current display device.
		/// To specify a desired height or width, use the LookupIconIdFromDirectoryEx function.
		/// </summary>
		/// <param name="presbits">
		/// The icon or cursor directory data. Because this function does not validate the resource data, it causes a general protection (GP) fault or returns an undefined value if <paramref name="presbits" /> is not pointing to valid resource data.
		/// </param>
		/// <param name="fIcon">
		/// Indicates whether an icon or a cursor is sought. If this parameter is TRUE, the function is searching for an icon; if the parameter is FALSE, the function is searching for a cursor.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is an integer resource identifier for the icon or cursor that best fits the current display device.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int
			LookupIconIdFromDirectory(IntPtr presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon) {
			return User32.LookupIconIdFromDirectory((byte*) presbits.ToPointer(), fIcon);
		}

		/// <summary>
		/// Searches through icon or cursor data for the icon or cursor that best fits the current display device.
		/// To specify a desired height or width, use the LookupIconIdFromDirectoryEx function.
		/// </summary>
		/// <param name="presbits">
		/// The icon or cursor directory data. Because this function does not validate the resource data, it causes a general protection (GP) fault or returns an undefined value if <paramref name="presbits" /> is not pointing to valid resource data.
		/// </param>
		/// <param name="fIcon">
		/// Indicates whether an icon or a cursor is sought. If this parameter is TRUE, the function is searching for an icon; if the parameter is FALSE, the function is searching for a cursor.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is an integer resource identifier for the icon or cursor that best fits the current display device.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int
			LookupIconIdFromDirectory(byte[] presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon) {
			byte[] numArray;
			return User32.LookupIconIdFromDirectory(
				(numArray = presbits) == null || numArray.Length == 0 ? (byte*) null : &numArray[0], fIcon);
		}

		/// <summary>
		/// Searches through icon or cursor data for the icon or cursor that best fits the current display device.
		/// To specify a desired height or width, use the LookupIconIdFromDirectoryEx function.
		/// </summary>
		/// <param name="presbits">
		/// The icon or cursor directory data. Because this function does not validate the resource data, it causes a general protection (GP) fault or returns an undefined value if <paramref name="presbits" /> is not pointing to valid resource data.
		/// </param>
		/// <param name="fIcon">
		/// Indicates whether an icon or a cursor is sought. If this parameter is TRUE, the function is searching for an icon; if the parameter is FALSE, the function is searching for a cursor.
		/// </param>
		/// <param name="cxDesired">The desired width, in pixels, of the icon. If this parameter is zero, the function uses the SM_CXICON or SM_CXCURSOR system metric value.</param>
		/// <param name="cyDesired">The desired height, in pixels, of the icon. If this parameter is zero, the function uses the SM_CYICON or SM_CYCURSOR system metric value.</param>
		/// <param name="Flags">A combination of the following values.</param>
		/// <returns>
		/// If the function succeeds, the return value is an integer resource identifier for the icon or cursor that best fits the current display device.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int LookupIconIdFromDirectoryEx(IntPtr presbits,
		                                                     [MarshalAs(UnmanagedType.Bool)] bool fIcon, int cxDesired,
		                                                     int cyDesired,
		                                                     User32.LookupIconIdFromDirectoryExFlags Flags) {
			return User32.LookupIconIdFromDirectoryEx((byte*) presbits.ToPointer(), fIcon, cxDesired, cyDesired, Flags);
		}

		/// <summary>
		/// Searches through icon or cursor data for the icon or cursor that best fits the current display device.
		/// To specify a desired height or width, use the LookupIconIdFromDirectoryEx function.
		/// </summary>
		/// <param name="presbits">
		/// The icon or cursor directory data. Because this function does not validate the resource data, it causes a general protection (GP) fault or returns an undefined value if <paramref name="presbits" /> is not pointing to valid resource data.
		/// </param>
		/// <param name="fIcon">
		/// Indicates whether an icon or a cursor is sought. If this parameter is TRUE, the function is searching for an icon; if the parameter is FALSE, the function is searching for a cursor.
		/// </param>
		/// <param name="cxDesired">The desired width, in pixels, of the icon. If this parameter is zero, the function uses the SM_CXICON or SM_CXCURSOR system metric value.</param>
		/// <param name="cyDesired">The desired height, in pixels, of the icon. If this parameter is zero, the function uses the SM_CYICON or SM_CYCURSOR system metric value.</param>
		/// <param name="Flags">A combination of the following values.</param>
		/// <returns>
		/// If the function succeeds, the return value is an integer resource identifier for the icon or cursor that best fits the current display device.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int LookupIconIdFromDirectoryEx(byte[] presbits,
		                                                     [MarshalAs(UnmanagedType.Bool)] bool fIcon, int cxDesired,
		                                                     int cyDesired,
		                                                     User32.LookupIconIdFromDirectoryExFlags Flags) {
			byte[] numArray;
			return User32.LookupIconIdFromDirectoryEx(
				(numArray = presbits) == null || numArray.Length == 0 ? (byte*) null : &numArray[0], fIcon, cxDesired,
				cyDesired, Flags);
		}

		public static unsafe bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, User32.MONITORENUMPROC lpfnEnum,
		                                              IntPtr dwData) {
			RECT* pointer1 = (RECT*) lprcClip.ToPointer();
			void* pointer2 = dwData.ToPointer();
			return User32.EnumDisplayMonitors(hdc, pointer1, lpfnEnum, pointer2);
		}

		public static unsafe bool GetMonitorInfo(IntPtr hMonitor, IntPtr lpmi) {
			User32.MONITORINFO* pointer = (User32.MONITORINFO*) lpmi.ToPointer();
			return User32.GetMonitorInfo(hMonitor, pointer);
		}

		public static unsafe bool GetMonitorInfo(IntPtr hMonitor, out User32.MONITORINFO lpmi) {
			fixed (User32.MONITORINFO* lpmi1 = &lpmi)
				return User32.GetMonitorInfo(hMonitor, lpmi1);
		}

		public static unsafe bool GetMonitorInfoEx(IntPtr hMonitor, IntPtr lpmi) {
			User32.MONITORINFOEX* pointer = (User32.MONITORINFOEX*) lpmi.ToPointer();
			return User32.GetMonitorInfoEx(hMonitor, pointer);
		}

		public static unsafe bool GetMonitorInfoEx(IntPtr hMonitor, out User32.MONITORINFOEX lpmi) {
			fixed (User32.MONITORINFOEX* lpmi1 = &lpmi)
				return User32.GetMonitorInfoEx(hMonitor, lpmi1);
		}

		public static unsafe bool SystemParametersInfo(User32.SystemParametersInfoAction uiAction, uint uiParam,
		                                               IntPtr pvParam, User32.SystemParametersInfoFlags fWinIni) {
			void* pointer = pvParam.ToPointer();
			return User32.SystemParametersInfo(uiAction, uiParam, pointer, fWinIni);
		}

		public static unsafe int QueryDisplayConfig(uint Flags, ref int pNumPathArrayElements, IntPtr pPathInfoArray,
		                                            ref int pNumModeInfoArrayElements, IntPtr pModeInfoArray,
		                                            User32.DISPLAYCONFIG_TOPOLOGY_ID pCurrentTopologyId) {
			User32.DISPLAYCONFIG_PATH_INFO* pointer1 = (User32.DISPLAYCONFIG_PATH_INFO*) pPathInfoArray.ToPointer();
			User32.DISPLAYCONFIG_MODE_INFO* pointer2 = (User32.DISPLAYCONFIG_MODE_INFO*) pModeInfoArray.ToPointer();
			return User32.QueryDisplayConfig(Flags, ref pNumPathArrayElements, pointer1, ref pNumModeInfoArrayElements,
				pointer2, pCurrentTopologyId);
		}

		public static unsafe int QueryDisplayConfig(uint Flags, ref int pNumPathArrayElements,
		                                            User32.DISPLAYCONFIG_PATH_INFO[] pPathInfoArray,
		                                            ref int pNumModeInfoArrayElements,
		                                            User32.DISPLAYCONFIG_MODE_INFO[] pModeInfoArray,
		                                            User32.DISPLAYCONFIG_TOPOLOGY_ID pCurrentTopologyId) {
			User32.DISPLAYCONFIG_MODE_INFO[] displayconfigModeInfoArray;
			User32.DISPLAYCONFIG_MODE_INFO* pModeInfoArray1 =
				(displayconfigModeInfoArray = pModeInfoArray) == null || displayconfigModeInfoArray.Length == 0
					? (User32.DISPLAYCONFIG_MODE_INFO*) null
					: &displayconfigModeInfoArray[0];
			User32.DISPLAYCONFIG_PATH_INFO[] displayconfigPathInfoArray;
			User32.DISPLAYCONFIG_PATH_INFO* pPathInfoArray1 =
				(displayconfigPathInfoArray = pPathInfoArray) == null || displayconfigPathInfoArray.Length == 0
					? (User32.DISPLAYCONFIG_PATH_INFO*) null
					: &displayconfigPathInfoArray[0];
			return User32.QueryDisplayConfig(Flags, ref pNumPathArrayElements, pPathInfoArray1,
				ref pNumModeInfoArrayElements, pModeInfoArray1, pCurrentTopologyId);
		}

		/// <summary>Retrieves the name of the format from the clipboard.</summary>
		/// <param name="format">The type of format to be retrieved. This parameter must not specify any of the predefined clipboard formats.</param>
		/// <param name="lpszFormatName">The format name string.</param>
		/// <param name="cchMaxCount">
		/// The length of the <paramref name="lpszFormatName" /> buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the format name string is truncated to <paramref name="cchMaxCount" />-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int GetClipboardFormatName(int format, IntPtr lpszFormatName, int cchMaxCount) {
			char* pointer = (char*) lpszFormatName.ToPointer();
			return User32.GetClipboardFormatName(format, pointer, cchMaxCount);
		}

		/// <summary>Retrieves the name of the format from the clipboard.</summary>
		/// <param name="format">The type of format to be retrieved. This parameter must not specify any of the predefined clipboard formats.</param>
		/// <param name="lpszFormatName">The format name string.</param>
		/// <param name="cchMaxCount">
		/// The length of the <paramref name="lpszFormatName" /> buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the format name string is truncated to <paramref name="cchMaxCount" />-1 characters.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of characters copied to the buffer.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe int GetClipboardFormatName(int format, char[] lpszFormatName, int cchMaxCount) {
			char[] chArray;
			char* lpszFormatName1 =
				(chArray = lpszFormatName) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return User32.GetClipboardFormatName(format, lpszFormatName1, cchMaxCount);
		}

		public static unsafe IntPtr GetClipboardData_IntPtr(int uFormat) {
			return new IntPtr(User32.GetClipboardData(uFormat));
		}

		public static unsafe IntPtr SetClipboardData(int uFormat, IntPtr hMem) {
			void* pointer = hMem.ToPointer();
			return new IntPtr(User32.SetClipboardData(uFormat, pointer));
		}

		/// <summary>
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="nInputs">The number of structures in the <paramref name="pInputs" /> array.</param>
		/// <param name="pInputs">An array of  structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
		/// <param name="cbSize">The size, in bytes, of an <see cref="T:PInvoke.User32.INPUT" /> structure. If cbSize is not the size of an <see cref="T:PInvoke.User32.INPUT" /> structure, the function fails.</param>
		/// <returns>
		/// The function returns the number of events that it successfully inserted into the keyboard or mouse input stream.
		/// If the function returns zero, the input was already blocked by another thread. To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// This function is subject to UIPI. Applications are permitted to inject input only into applications that are at an equal or lesser integrity level.
		/// This function fails when it is blocked by UIPI. Note that neither GetLastError nor the return value will indicate the failure was caused by UIPI blocking.
		/// </remarks>
		public static unsafe uint SendInput(int nInputs, IntPtr pInputs, int cbSize) {
			User32.INPUT* pointer = (User32.INPUT*) pInputs.ToPointer();
			return User32.SendInput(nInputs, pointer, cbSize);
		}

		/// <summary>
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="nInputs">The number of structures in the <paramref name="pInputs" /> array.</param>
		/// <param name="pInputs">An array of  structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
		/// <param name="cbSize">The size, in bytes, of an <see cref="T:PInvoke.User32.INPUT" /> structure. If cbSize is not the size of an <see cref="T:PInvoke.User32.INPUT" /> structure, the function fails.</param>
		/// <returns>
		/// The function returns the number of events that it successfully inserted into the keyboard or mouse input stream.
		/// If the function returns zero, the input was already blocked by another thread. To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// This function is subject to UIPI. Applications are permitted to inject input only into applications that are at an equal or lesser integrity level.
		/// This function fails when it is blocked by UIPI. Note that neither GetLastError nor the return value will indicate the failure was caused by UIPI blocking.
		/// </remarks>
		public static unsafe uint SendInput(int nInputs, User32.INPUT[] pInputs, int cbSize) {
			User32.INPUT[] inputArray;
			User32.INPUT* pInputs1 = (inputArray = pInputs) == null || inputArray.Length == 0
				? (User32.INPUT*) null
				: &inputArray[0];
			return User32.SendInput(nInputs, pInputs1, cbSize);
		}

		public static unsafe User32.SafeDesktopHandle CreateDesktopEx(string lpszDesktop, IntPtr lpszDevice,
		                                                              IntPtr pDevmode,
		                                                              User32.DesktopCreationFlags dwFlags,
		                                                              Kernel32.ACCESS_MASK dwDesiredAccess, IntPtr lpsa,
		                                                              uint ulHeapSize, IntPtr pvoid = default(IntPtr)) {
			Kernel32.SECURITY_ATTRIBUTES* pointer = (Kernel32.SECURITY_ATTRIBUTES*) lpsa.ToPointer();
			return User32.CreateDesktopEx(lpszDesktop, lpszDevice, pDevmode, dwFlags, dwDesiredAccess, pointer,
				ulHeapSize, pvoid);
		}

		public static unsafe User32.SafeDesktopHandle CreateDesktopEx(string lpszDesktop, IntPtr lpszDevice,
		                                                              IntPtr pDevmode,
		                                                              User32.DesktopCreationFlags dwFlags,
		                                                              Kernel32.ACCESS_MASK dwDesiredAccess,
		                                                              Kernel32.SECURITY_ATTRIBUTES? lpsa,
		                                                              uint ulHeapSize, IntPtr pvoid = default(IntPtr)) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes =
				lpsa.HasValue ? lpsa.Value : (Kernel32.SECURITY_ATTRIBUTES) null;
			return User32.CreateDesktopEx(lpszDesktop, lpszDevice, pDevmode, dwFlags, dwDesiredAccess,
				lpsa.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null, ulHeapSize, pvoid);
		}

		public static unsafe User32.SafeDesktopHandle CreateDesktop(string lpszDesktop, string lpszDevice,
		                                                            IntPtr pDevmode,
		                                                            User32.DesktopCreationFlags dwFlags,
		                                                            Kernel32.ACCESS_MASK dwDesiredAccess, IntPtr lpsa) {
			Kernel32.SECURITY_ATTRIBUTES* pointer = (Kernel32.SECURITY_ATTRIBUTES*) lpsa.ToPointer();
			return User32.CreateDesktop(lpszDesktop, lpszDevice, pDevmode, dwFlags, dwDesiredAccess, pointer);
		}

		public static unsafe User32.SafeDesktopHandle CreateDesktop(string lpszDesktop, string lpszDevice,
		                                                            IntPtr pDevmode,
		                                                            User32.DesktopCreationFlags dwFlags,
		                                                            Kernel32.ACCESS_MASK dwDesiredAccess,
		                                                            Kernel32.SECURITY_ATTRIBUTES? lpsa) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes =
				lpsa.HasValue ? lpsa.Value : (Kernel32.SECURITY_ATTRIBUTES) null;
			return User32.CreateDesktop(lpszDesktop, lpszDevice, pDevmode, dwFlags, dwDesiredAccess,
				lpsa.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null);
		}

		/// <summary>
		/// Retrieves information about the specified window station or desktop object.
		/// </summary>
		/// <param name="hObj">A handle to the window station or desktop object. This handle is returned by the <see cref="M:PInvoke.User32.CreateWindowStation(System.String,PInvoke.User32.WindowStationCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, <see cref="M:PInvoke.User32.OpenWindowStation(System.String,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" />, <see cref="M:PInvoke.User32.CreateDesktop(System.String,System.String,System.IntPtr,PInvoke.User32.DesktopCreationFlags,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />, or <see cref="M:PInvoke.User32.OpenDesktop(System.String,PInvoke.User32.DesktopCreationFlags,System.Boolean,PInvoke.Kernel32.ACCESS_MASK)" /> function.</param>
		/// <param name="nIndex">The information to be retrieved.</param>
		/// <param name="pvInfo">A pointer to a buffer to receive the object information.</param>
		/// <param name="nLength">The size of the buffer pointed to by the <paramref name="pvInfo" /> parameter, in bytes.</param>
		/// <param name="lpnLengthNeeded">
		/// A pointer to a variable receiving the number of bytes required to store the requested information.
		/// If this variable's value is greater than the value of the <paramref name="nLength" /> parameter when the function returns, the function returns false, and none of the information is copied to the <paramref name="pvInfo" /> buffer.
		/// If the value of the variable pointed to by lpnLengthNeeded is less than or equal to the value of <paramref name="nLength" />, the entire information block is copied.</param>
		/// <returns>If the function succeeds, the return value is true, if it fails, the return value is false.</returns>
		public static unsafe bool GetUserObjectInformation(IntPtr hObj, User32.ObjectInformationType nIndex,
		                                                   IntPtr pvInfo, uint nLength, IntPtr lpnLengthNeeded) {
			void* pointer1 = pvInfo.ToPointer();
			uint* pointer2 = (uint*) lpnLengthNeeded.ToPointer();
			return User32.GetUserObjectInformation(hObj, nIndex, pointer1, nLength, pointer2);
		}

		public static unsafe User32.SafeWindowStationHandle CreateWindowStation(
			string lpwinsta, User32.WindowStationCreationFlags dwFlags, Kernel32.ACCESS_MASK dwDesiredAccess,
			IntPtr lpsa) {
			Kernel32.SECURITY_ATTRIBUTES* pointer = (Kernel32.SECURITY_ATTRIBUTES*) lpsa.ToPointer();
			return User32.CreateWindowStation(lpwinsta, dwFlags, dwDesiredAccess, pointer);
		}

		public static unsafe User32.SafeWindowStationHandle CreateWindowStation(
			string lpwinsta, User32.WindowStationCreationFlags dwFlags, Kernel32.ACCESS_MASK dwDesiredAccess,
			Kernel32.SECURITY_ATTRIBUTES? lpsa) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes =
				lpsa.HasValue ? lpsa.Value : (Kernel32.SECURITY_ATTRIBUTES) null;
			return User32.CreateWindowStation(lpwinsta, dwFlags, dwDesiredAccess,
				lpsa.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null);
		}

		public static unsafe IntPtr CreateDialogIndirectParam(Kernel32.SafeLibraryHandle hInstance, IntPtr lpTemplate,
		                                                      IntPtr hWndParent, User32.DialogProc lpDialogFunc,
		                                                      IntPtr lParamInit) {
			User32.DLGTEMPLATE* pointer = (User32.DLGTEMPLATE*) lpTemplate.ToPointer();
			return User32.CreateDialogIndirectParam(hInstance, pointer, hWndParent, lpDialogFunc, lParamInit);
		}

		/// <summary>
		///     Retrieves a message from the calling thread's message queue. The function dispatches incoming sent messages until a
		///     posted message is available for retrieval.
		///     <para>
		///         Unlike <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" />, the <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> function does not wait for a message to be
		///         posted before returning.
		///     </para>
		/// </summary>
		/// <param name="lpMsg">A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that receives message information.</param>
		/// <param name="hWnd">
		///     A handle to the window whose messages are to be retrieved. The window must belong to the current thread.
		///     <para>
		///         If hWnd is <see cref="F:System.IntPtr.Zero" />, PeekMessage retrieves messages for any window that belongs to the
		///         current thread, and any messages on the current thread's message queue whose hwnd value is NULL (see the MSG
		///         structure). Therefore if hWnd is <see cref="F:System.IntPtr.Zero" />, both window messages and thread messages are
		///         processed.
		///     </para>
		///     <para>
		///         If hWnd is -1, PeekMessage retrieves only messages on the current thread's message queue whose hwnd value is
		///         NULL, that is, thread messages as posted by <see cref="M:PInvoke.User32.PostMessage(System.IntPtr,PInvoke.User32.WindowMessage,System.Void*,System.Void*)" />
		///         (when the hWnd parameter is <see cref="F:System.IntPtr.Zero" />) or <see cref="M:PInvoke.User32.PostThreadMessage(System.Int32,PInvoke.User32.WindowMessage,System.IntPtr,System.IntPtr)" />.
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMin">
		///     <para>
		///         The value of the first message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYFIRST" /> to specify the first keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSEFIRST" /> to specify the first mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMax">
		///     <para>
		///         The value of the last message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYLAST" /> to specify the last keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSELAST" /> to specify the last mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <returns>
		///     If the function retrieves a message other than <see cref="F:PInvoke.User32.WindowMessage.WM_QUIT" />, the return value is nonzero.
		///     <para>If the function retrieves the <see cref="F:PInvoke.User32.WindowMessage.WM_QUIT" /> message, the return value is zero.</para>
		///     <para>
		///         If there is an error, the return value is -1. For example, the function fails if <paramref name="hWnd" /> is
		///         an invalid window handle or <paramref name="lpMsg" /> is an invalid pointer. To get extended error information,
		///         call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe int GetMessage(IntPtr lpMsg, IntPtr hWnd, User32.WindowMessage wMsgFilterMin,
		                                    User32.WindowMessage wMsgFilterMax) {
			return User32.GetMessage((User32.MSG*) lpMsg.ToPointer(), hWnd, wMsgFilterMin, wMsgFilterMax);
		}

		/// <summary>
		///     Dispatches incoming sent messages, checks the thread message queue for a posted message, and retrieves the message
		///     (if any exist).
		/// </summary>
		/// <param name="lpMsg">A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that receives message information.</param>
		/// <param name="hWnd">
		///     A handle to the window whose messages are to be retrieved. The window must belong to the current thread.
		///     <para>
		///         If hWnd is <see cref="F:System.IntPtr.Zero" />, PeekMessage retrieves messages for any window that belongs to the
		///         current thread, and any messages on the current thread's message queue whose hwnd value is NULL (see the MSG
		///         structure). Therefore if hWnd is <see cref="F:System.IntPtr.Zero" />, both window messages and thread messages are
		///         processed.
		///     </para>
		///     <para>
		///         If hWnd is -1, PeekMessage retrieves only messages on the current thread's message queue whose hwnd value is
		///         NULL, that is, thread messages as posted by <see cref="M:PInvoke.User32.PostMessage(System.IntPtr,PInvoke.User32.WindowMessage,System.Void*,System.Void*)" /> (when the hWnd parameter is
		///         <see cref="F:System.IntPtr.Zero" />) or <see cref="M:PInvoke.User32.PostThreadMessage(System.Int32,PInvoke.User32.WindowMessage,System.IntPtr,System.IntPtr)" />.
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMin">
		///     <para>
		///         The value of the first message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYFIRST" /> to specify the first keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSEFIRST" /> to specify the first mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <param name="wMsgFilterMax">
		///     <para>
		///         The value of the last message in the range of messages to be examined. Use
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_KEYLAST" /> to specify the last keyboard message or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_MOUSELAST" /> to specify the last mouse message.
		///     </para>
		///     <para>
		///         If wMsgFilterMin and wMsgFilterMax are both <see cref="F:PInvoke.User32.WindowMessage.WM_NULL" />, PeekMessage returns all
		///         available messages (that is, no range filtering is performed).
		///     </para>
		/// </param>
		/// <param name="wRemoveMsg">Specifies how messages are to be handled</param>
		/// <returns>
		///     If a message is available, the return value is true.
		///     <para>If no messages are available, the return value is false.</para>
		/// </returns>
		public static unsafe bool PeekMessage(IntPtr lpMsg, IntPtr hWnd, User32.WindowMessage wMsgFilterMin,
		                                      User32.WindowMessage wMsgFilterMax,
		                                      User32.PeekMessageRemoveFlags wRemoveMsg) {
			return User32.PeekMessage((User32.MSG*) lpMsg.ToPointer(), hWnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg);
		}

		/// <summary>
		///     Translates virtual-key messages into character messages. The character messages are posted to the calling thread's
		///     message queue, to be read the next time the thread calls the <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" /> or
		///     <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> function.
		/// </summary>
		/// <param name="lpMsg">
		///     A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that contains message information retrieved from the
		///     calling thread's message queue by using the <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" /> or <see cref="M:PInvoke.User32.PeekMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" /> function.
		/// </param>
		/// <returns>
		///     If the message is translated (that is, a character message is posted to the thread's message queue), the return
		///     value is nonzero.
		///     <para>
		///         If the message is <see cref="F:PInvoke.User32.WindowMessage.WM_KEYDOWN" />, <see cref="F:PInvoke.User32.WindowMessage.WM_KEYUP" />,
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_SYSKEYDOWN" />, or
		///         <see cref="F:PInvoke.User32.WindowMessage.WM_SYSKEYUP" />, the return value is nonzero, regardless of the translation.
		///     </para>
		///     <para>
		///         If the message is not translated (that is, a character message is not posted to the thread's message queue),
		///         the return value is zero.
		///     </para>
		/// </returns>
		public static unsafe bool TranslateMessage(IntPtr lpMsg) {
			return User32.TranslateMessage((User32.MSG*) lpMsg.ToPointer());
		}

		/// <summary>
		///     Dispatches a message to a window procedure. It is typically used to dispatch a message retrieved by the
		///     <see cref="M:PInvoke.User32.GetMessage(PInvoke.User32.MSG*,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage)" /> function.
		/// </summary>
		/// <param name="lpMsg">A pointer to a structure that contains the message.</param>
		/// <returns>
		///     The return value specifies the value returned by the window procedure. Although its meaning depends on the
		///     message being dispatched, the return value generally is ignored.
		/// </returns>
		public static unsafe IntPtr DispatchMessage(IntPtr lpMsg) {
			return User32.DispatchMessage((User32.MSG*) lpMsg.ToPointer());
		}

		/// <summary>
		///     Determines whether a message is intended for the specified dialog box and, if it is, processes the message.
		/// </summary>
		/// <param name="hDlg">A handle to the dialog box.</param>
		/// <param name="lpMsg">A pointer to an <see cref="T:PInvoke.User32.MSG" /> structure that contains the message to be checked.</param>
		/// <returns>
		///     If the message has been processed, the return value is nonzero.
		///     <para>If the message has not been processed, the return value is zero.</para>
		/// </returns>
		public static unsafe bool IsDialogMessage(IntPtr hDlg, IntPtr lpMsg) {
			User32.MSG* pointer = (User32.MSG*) lpMsg.ToPointer();
			return User32.IsDialogMessage(hDlg, pointer);
		}

		/// <summary>
		///     Loads a string resource from the executable file associated with a specified module, copies the string into
		///     a buffer, and appends a terminating null character.
		/// </summary>
		/// <param name="hInstance">
		///     A handle to an instance of the module whose executable file contains the string resource. To get the handle
		///     to the application itself, call the <see cref="M:PInvoke.Kernel32.GetModuleHandle(System.String)" /> function with NULL.
		/// </param>
		/// <param name="uID">The identifier of the string to be loaded.</param>
		/// <param name="lpBuffer">
		///     The buffer is to receive the string. Must be of sufficient length to hold a pointer (8 bytes).
		/// </param>
		/// <param name="cchBufferMax">
		///     The size of the buffer, in characters. The string is truncated and null-terminated if it is longer than the
		///     number of characters specified. If this parameter is 0, then lpBuffer receives a read-only pointer to the
		///     resource itself.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is the number of characters copied into the buffer, not
		///     including the terminating null character, or zero if the string resource does not exist. To get extended
		///     error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe int LoadString(IntPtr hInstance, uint uID, out IntPtr lpBuffer, int cchBufferMax) {
			char* lpBuffer1;
			int num = User32.LoadString(hInstance, uID, out lpBuffer1, cchBufferMax);
			lpBuffer = new IntPtr((void*) lpBuffer1);
			return num;
		}

		/// <summary>
		/// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is
		/// a control, the text of the control is copied. However, GetWindowText cannot retrieve the text of a control in another
		/// application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control containing the text.</param>
		/// <param name="lpString">
		/// The buffer that will receive the text. If the string is as long or longer than the buffer, the
		/// string is truncated and terminated with a null character.
		/// </param>
		/// <param name="nMaxCount">
		/// The maximum number of characters to copy to the buffer, including the null character. If the
		/// text exceeds this limit, it is truncated.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the length, in characters, of the copied string, not including
		/// the terminating null character. If the window has no title bar or text, if the title bar is empty, or if the window or
		/// control handle is invalid, the return value is zero. To get extended error information, call GetLastError.
		/// <para>This function cannot retrieve the text of an edit control in another application.</para>
		/// </returns>
		public static unsafe int GetWindowText(IntPtr hWnd, IntPtr lpString, int nMaxCount) {
			char* pointer = (char*) lpString.ToPointer();
			return User32.GetWindowText(hWnd, pointer, nMaxCount);
		}

		/// <summary>
		/// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is
		/// a control, the text of the control is copied. However, GetWindowText cannot retrieve the text of a control in another
		/// application.
		/// </summary>
		/// <param name="hWnd">A handle to the window or control containing the text.</param>
		/// <param name="lpString">
		/// The buffer that will receive the text. If the string is as long or longer than the buffer, the
		/// string is truncated and terminated with a null character.
		/// </param>
		/// <param name="nMaxCount">
		/// The maximum number of characters to copy to the buffer, including the null character. If the
		/// text exceeds this limit, it is truncated.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the length, in characters, of the copied string, not including
		/// the terminating null character. If the window has no title bar or text, if the title bar is empty, or if the window or
		/// control handle is invalid, the return value is zero. To get extended error information, call GetLastError.
		/// <para>This function cannot retrieve the text of an edit control in another application.</para>
		/// </returns>
		public static unsafe int GetWindowText(IntPtr hWnd, char[] lpString, int nMaxCount) {
			char[] chArray;
			char* lpString1 = (chArray = lpString) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return User32.GetWindowText(hWnd, lpString1, nMaxCount);
		}

		/// <summary>
		/// Retrieves the position of the mouse cursor, in screen coordinates.
		/// </summary>
		/// <param name="lpPoint">A pointer to a POINT structure that receives the screen coordinates of the cursor.</param>
		/// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
		public static unsafe bool GetCursorPos(IntPtr lpPoint) {
			return User32.GetCursorPos((POINT*) lpPoint.ToPointer());
		}

		/// <summary>Retrieves the show state and the restored, minimized, and maximized positions of the specified window.</summary>
		/// <param name="hWnd">A handle to the window.</param>
		/// <param name="lpwndpl">
		/// A pointer to the WINDOWPLACEMENT structure that receives the show state and position information.
		/// Before calling GetWindowPlacement, set the length member to sizeof(WINDOWPLACEMENT). GetWindowPlacement fails if
		/// lpwndpl-&gt; length is not set correctly.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		public static unsafe bool GetWindowPlacement(IntPtr hWnd, IntPtr lpwndpl) {
			User32.WINDOWPLACEMENT* pointer = (User32.WINDOWPLACEMENT*) lpwndpl.ToPointer();
			return User32.GetWindowPlacement(hWnd, pointer);
		}

		/// <summary>
		/// Creates an overlapped, pop-up, or child window with an
		/// extended window style; otherwise, this function is identical to the CreateWindow function.
		/// </summary>
		/// <param name="dwExStyle">Specifies the extended window style of the window being created.</param>
		/// <param name="lpClassName">
		/// Pointer to a null-terminated string that specifies
		/// the window class name. The class name can be any name registered with RegisterClass or
		/// RegisterClassEx, provided that the module that registers the class is also the module
		/// that creates the window. The class name can also be any of the predefined system class names.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		public static unsafe IntPtr CreateWindowEx(User32.WindowStylesEx dwExStyle, string lpClassName,
		                                           string lpWindowName, User32.WindowStyles dwStyle, int x, int y,
		                                           int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu,
		                                           IntPtr hInstance, IntPtr lpParam) {
			void* pointer = lpParam.ToPointer();
			return User32.CreateWindowEx(dwExStyle, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight,
				hWndParent, hMenu, hInstance, pointer);
		}

		/// <summary>
		/// Creates an overlapped, pop-up, or child window with an
		/// extended window style; otherwise, this function is identical to the CreateWindow function.
		/// </summary>
		/// <param name="dwExStyle">Specifies the extended window style of the window being created.</param>
		/// <param name="lpClassName">
		/// Pointer to a class atom created by a previous call to the
		/// RegisterClass or RegisterClassEx function. The atom must be in the low-order word of
		/// lpClassName; the high-order word must be zero.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		public static unsafe IntPtr CreateWindowEx(User32.WindowStylesEx dwExStyle, short lpClassName,
		                                           string lpWindowName, User32.WindowStyles dwStyle, int x, int y,
		                                           int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu,
		                                           IntPtr hInstance, IntPtr lpParam) {
			void* pointer = lpParam.ToPointer();
			return User32.CreateWindowEx(dwExStyle, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight,
				hWndParent, hMenu, hInstance, pointer);
		}

		/// <summary>
		/// The DrawText function draws formatted text in the specified rectangle.
		/// It formats the text according to the specified method (expanding tabs, justifying characters, breaking lines, and so forth).
		/// To specify additional formatting options, use the <see cref="M:PInvoke.User32.DrawTextEx(PInvoke.User32.SafeDCHandle,System.Char*,System.Int32,PInvoke.RECT*,System.UInt32,PInvoke.User32.DRAWTEXTPARAMS*)" /> function.
		/// </summary>
		/// <param name="hDC">A handle to the device context.</param>
		/// <param name="lpString">
		/// A pointer to the string that specifies the text to be drawn.
		/// If the <paramref name="nCount" /> parameter is -1, the string must be null-terminated.
		/// If <paramref name="uFormat" /> includes <see cref="F:PInvoke.User32.TextFormats.DT_MODIFYSTRING" />, the function could add up to four additional characters to this string.
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </param>
		/// <param name="nCount">The length, in characters, of the string. If nCount is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and DrawText computes the character count automatically.</param>
		/// <param name="lpRect">A pointer to a RECT structure that contains the rectangle (in logical coordinates) in which the text is to be formatted.</param>
		/// <param name="uFormat">The method of formatting the text.</param>
		/// <returns>
		/// If the function succeeds, the return value is the height of the text in logical units.
		/// If <see cref="F:PInvoke.User32.TextFormats.DT_VCENTER" /> or <see cref="F:PInvoke.User32.TextFormats.DT_BOTTOM" /> is specified, the return value is the offset from <see cref="F:PInvoke.RECT.top" /> (<paramref name="lpRect" />) to the bottom of the drawn text.
		/// If the function fails, the return value is zero.</returns>
		/// <remarks>
		/// <para>
		/// The DrawText function uses the device context's selected font, text color, and background color to draw the text.
		/// Unless the <see cref="F:PInvoke.User32.TextFormats.DT_NOCLIP" /> format is used, DrawText clips the text so that it does not appear outside the specified rectangle.
		/// Note that text with significant overhang may be clipped, for example, an initial "W" in the text string or text that is in italics.
		/// All formatting is assumed to have multiple lines unless the <see cref="F:PInvoke.User32.TextFormats.DT_SINGLELINE" /> format is specified.
		/// </para>
		/// <para>
		/// If the selected font is too large for the specified rectangle, the DrawText function does not attempt to substitute a smaller font.
		/// The text alignment mode for the device context must include the TA_LEFT, TA_TOP, and TA_NOUPDATECP flags.
		/// </para>
		/// </remarks>
		public static unsafe int DrawText(User32.SafeDCHandle hDC, IntPtr lpString, int nCount, IntPtr lpRect,
		                                  User32.TextFormats uFormat) {
			char* pointer1 = (char*) lpString.ToPointer();
			RECT* pointer2 = (RECT*) lpRect.ToPointer();
			return User32.DrawText(hDC, pointer1, nCount, pointer2, uFormat);
		}

		/// <summary>
		/// The DrawText function draws formatted text in the specified rectangle.
		/// It formats the text according to the specified method (expanding tabs, justifying characters, breaking lines, and so forth).
		/// To specify additional formatting options, use the <see cref="M:PInvoke.User32.DrawTextEx(PInvoke.User32.SafeDCHandle,System.Char*,System.Int32,PInvoke.RECT*,System.UInt32,PInvoke.User32.DRAWTEXTPARAMS*)" /> function.
		/// </summary>
		/// <param name="hDC">A handle to the device context.</param>
		/// <param name="lpString">
		/// A pointer to the string that specifies the text to be drawn.
		/// If the <paramref name="nCount" /> parameter is -1, the string must be null-terminated.
		/// If <paramref name="uFormat" /> includes <see cref="F:PInvoke.User32.TextFormats.DT_MODIFYSTRING" />, the function could add up to four additional characters to this string.
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </param>
		/// <param name="nCount">The length, in characters, of the string. If nCount is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and DrawText computes the character count automatically.</param>
		/// <param name="lpRect">A pointer to a RECT structure that contains the rectangle (in logical coordinates) in which the text is to be formatted.</param>
		/// <param name="uFormat">The method of formatting the text.</param>
		/// <returns>
		/// If the function succeeds, the return value is the height of the text in logical units.
		/// If <see cref="F:PInvoke.User32.TextFormats.DT_VCENTER" /> or <see cref="F:PInvoke.User32.TextFormats.DT_BOTTOM" /> is specified, the return value is the offset from <see cref="F:PInvoke.RECT.top" /> (<paramref name="lpRect" />) to the bottom of the drawn text.
		/// If the function fails, the return value is zero.</returns>
		/// <remarks>
		/// <para>
		/// The DrawText function uses the device context's selected font, text color, and background color to draw the text.
		/// Unless the <see cref="F:PInvoke.User32.TextFormats.DT_NOCLIP" /> format is used, DrawText clips the text so that it does not appear outside the specified rectangle.
		/// Note that text with significant overhang may be clipped, for example, an initial "W" in the text string or text that is in italics.
		/// All formatting is assumed to have multiple lines unless the <see cref="F:PInvoke.User32.TextFormats.DT_SINGLELINE" /> format is specified.
		/// </para>
		/// <para>
		/// If the selected font is too large for the specified rectangle, the DrawText function does not attempt to substitute a smaller font.
		/// The text alignment mode for the device context must include the TA_LEFT, TA_TOP, and TA_NOUPDATECP flags.
		/// </para>
		/// </remarks>
		public static unsafe int DrawText(User32.SafeDCHandle hDC, char[] lpString, int nCount, ref RECT lpRect,
		                                  User32.TextFormats uFormat) {
			fixed (RECT* lpRect1 = &lpRect) {
				char[] chArray;
				char* lpString1 = (chArray = lpString) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
				return User32.DrawText(hDC, lpString1, nCount, lpRect1, uFormat);
			}
		}

		/// <summary>
		/// The DrawTextEx function draws formatted text in the specified rectangle.
		/// </summary>
		/// <param name="hdc">A handle to the device context in which to draw.</param>
		/// <param name="lpchText">
		/// A pointer to the string that contains the text to draw. If the <paramref name="cchText" /> parameter is -1, the string must be null-terminated.
		/// If <paramref name="dwDTFormat" /> includes <see cref="F:PInvoke.User32.TextFormats.DT_MODIFYSTRING" />, the function could add up to four additional characters to this string.
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </param>
		/// <param name="cchText">
		/// The length of the string pointed to by <paramref name="lpchText" />.
		/// If cchText is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and DrawTextEx computes the character count automatically.
		/// </param>
		/// <param name="lprc">A pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the rectangle, in logical coordinates, in which the text is to be formatted.</param>
		/// <param name="dwDTFormat">The formatting options.</param>
		/// <param name="lpDTParams">A pointer to a <see cref="T:PInvoke.User32.DRAWTEXTPARAMS" /> structure that specifies additional formatting options. This parameter can be NULL.</param>
		/// <returns>
		/// If the function succeeds, the return value is the text height in logical units.
		/// If <see cref="F:PInvoke.User32.TextFormats.DT_VCENTER" /> or <see cref="F:PInvoke.User32.TextFormats.DT_BOTTOM" /> is specified, the return value is the offset from  <see cref="F:PInvoke.RECT.top" /> (<paramref name="lprc" />) to the bottom of the drawn text
		/// If the function fails, the return value is zero.
		/// </returns>
		public static unsafe int DrawTextEx(User32.SafeDCHandle hdc, IntPtr lpchText, int cchText, IntPtr lprc,
		                                    uint dwDTFormat, IntPtr lpDTParams) {
			char* pointer1 = (char*) lpchText.ToPointer();
			RECT* pointer2 = (RECT*) lprc.ToPointer();
			User32.DRAWTEXTPARAMS* pointer3 = (User32.DRAWTEXTPARAMS*) lpDTParams.ToPointer();
			return User32.DrawTextEx(hdc, pointer1, cchText, pointer2, dwDTFormat, pointer3);
		}

		/// <summary>
		/// The DrawTextEx function draws formatted text in the specified rectangle.
		/// </summary>
		/// <param name="hdc">A handle to the device context in which to draw.</param>
		/// <param name="lpchText">
		/// A pointer to the string that contains the text to draw. If the <paramref name="cchText" /> parameter is -1, the string must be null-terminated.
		/// If <paramref name="dwDTFormat" /> includes <see cref="F:PInvoke.User32.TextFormats.DT_MODIFYSTRING" />, the function could add up to four additional characters to this string.
		/// The buffer containing the string should be large enough to accommodate these extra characters.
		/// </param>
		/// <param name="cchText">
		/// The length of the string pointed to by <paramref name="lpchText" />.
		/// If cchText is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and DrawTextEx computes the character count automatically.
		/// </param>
		/// <param name="lprc">A pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the rectangle, in logical coordinates, in which the text is to be formatted.</param>
		/// <param name="dwDTFormat">The formatting options.</param>
		/// <param name="lpDTParams">A pointer to a <see cref="T:PInvoke.User32.DRAWTEXTPARAMS" /> structure that specifies additional formatting options. This parameter can be NULL.</param>
		/// <returns>
		/// If the function succeeds, the return value is the text height in logical units.
		/// If <see cref="F:PInvoke.User32.TextFormats.DT_VCENTER" /> or <see cref="F:PInvoke.User32.TextFormats.DT_BOTTOM" /> is specified, the return value is the offset from  <see cref="F:PInvoke.RECT.top" /> (<paramref name="lprc" />) to the bottom of the drawn text
		/// If the function fails, the return value is zero.
		/// </returns>
		public static unsafe int DrawTextEx(User32.SafeDCHandle hdc, char[] lpchText, int cchText, ref RECT lprc,
		                                    uint dwDTFormat, User32.DRAWTEXTPARAMS? lpDTParams) {
			fixed (RECT* lprc1 = &lprc) {
				char[] chArray;
				char* lpchText1 = (chArray = lpchText) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
				User32.DRAWTEXTPARAMS drawtextparams =
					lpDTParams.HasValue ? lpDTParams.Value : new User32.DRAWTEXTPARAMS();
				return User32.DrawTextEx(hdc, lpchText1, cchText, lprc1, dwDTFormat,
					lpDTParams.HasValue ? &drawtextparams : (User32.DRAWTEXTPARAMS*) null);
			}
		}

		/// <summary>
		/// The EndPaint function marks the end of painting in the specified window. This function is required for each call to the <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function, but only after painting is complete.
		/// </summary>
		/// <param name="hWnd">Handle to the window that has been repainted.</param>
		/// <param name="lpPaint">Pointer to a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that contains the painting information retrieved by <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" />.</param>
		/// <returns>The return value is always nonzero.</returns>
		/// <remarks>
		/// If the caret was hidden by <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" />, EndPaint restores the caret to the screen.
		/// EndPaint releases the display device context that <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> retrieved.
		/// </remarks>
		public static unsafe bool EndPaint(IntPtr hWnd, IntPtr lpPaint) {
			User32.PAINTSTRUCT* pointer = (User32.PAINTSTRUCT*) lpPaint.ToPointer();
			return User32.EndPaint(hWnd, pointer);
		}

		/// <summary>
		/// The EndPaint function marks the end of painting in the specified window. This function is required for each call to the <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function, but only after painting is complete.
		/// </summary>
		/// <param name="hWnd">Handle to the window that has been repainted.</param>
		/// <param name="lpPaint">Pointer to a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that contains the painting information retrieved by <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" />.</param>
		/// <returns>The return value is always nonzero.</returns>
		/// <remarks>
		/// If the caret was hidden by <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" />, EndPaint restores the caret to the screen.
		/// EndPaint releases the display device context that <see cref="M:PInvoke.User32.BeginPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> retrieved.
		/// </remarks>
		public static unsafe bool EndPaint(IntPtr hWnd, User32.PAINTSTRUCT lpPaint) {
			return User32.EndPaint(hWnd, &lpPaint);
		}

		/// <summary>
		/// Sets the show state and the restored, minimized, and maximized positions of the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to the window.</param>
		/// <param name="lpwndpl">A pointer to a WINDOWPLACEMENT structure that specifies the new show state and window positions.
		/// Before calling SetWindowPlacement, set the <see cref="F:PInvoke.User32.WINDOWPLACEMENT.length" /> member of the <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> structure to sizeof(WINDOWPLACEMENT).
		/// SetWindowPlacement fails if the length member is not set correctly.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe bool SetWindowPlacement(IntPtr hWnd, IntPtr lpwndpl) {
			User32.WINDOWPLACEMENT* pointer = (User32.WINDOWPLACEMENT*) lpwndpl.ToPointer();
			return User32.SetWindowPlacement(hWnd, pointer);
		}

		/// <summary>
		/// Sets the show state and the restored, minimized, and maximized positions of the specified window.
		/// </summary>
		/// <param name="hWnd">A handle to the window.</param>
		/// <param name="lpwndpl">A pointer to a WINDOWPLACEMENT structure that specifies the new show state and window positions.
		/// Before calling SetWindowPlacement, set the <see cref="F:PInvoke.User32.WINDOWPLACEMENT.length" /> member of the <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> structure to sizeof(WINDOWPLACEMENT).
		/// SetWindowPlacement fails if the length member is not set correctly.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call GetLastError.
		/// </returns>
		public static unsafe bool SetWindowPlacement(IntPtr hWnd, User32.WINDOWPLACEMENT lpwndpl) {
			return User32.SetWindowPlacement(hWnd, &lpwndpl);
		}

		/// <summary>
		///     Synthesizes a keystroke. The system can use such a synthesized keystroke to generate a WM_KEYUP or WM_KEYDOWN message. The keyboard driver's interrupt handler calls the keybd_event function.
		/// </summary>
		/// <param name="bVk">
		///     A virtual-key code from <see cref="T:PInvoke.User32.VirtualKey" />. The code must be a value in the range 1 to 254.
		/// </param>
		/// <param name="bScan">
		///     A hardware scan code for the key from <see cref="T:PInvoke.User32.ScanCode" />.
		/// </param>
		/// <param name="dwFlags">
		///     Controls various aspects of function operation. This parameter can be one or more of the following values.
		/// </param>
		/// <param name="dwExtraInfo">
		///     An additional value associated with the key stroke.
		/// </param>
		public static unsafe void keybd_event(byte bVk, byte bScan, User32.KEYEVENTF dwFlags, IntPtr dwExtraInfo) {
			void* pointer = dwExtraInfo.ToPointer();
			User32.keybd_event(bVk, bScan, dwFlags, pointer);
		}

		/// <summary>
		/// The <see cref="M:PInvoke.User32.mouse_event(PInvoke.User32.mouse_eventFlags,System.Int32,System.Int32,System.Int32,System.Void*)" /> function synthesizes mouse motion and button clicks.
		/// </summary>
		/// <param name="dwFlags">Controls various aspects of mouse motion and button clicking.</param>
		/// <param name="dx">The mouse's absolute position along the x-axis or its amount of motion since the last mouse event was generated, depending on the setting of <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_ABSOLUTE" />. Absolute data is specified as the mouse's actual x-coordinate; relative data is specified as the number of mickeys moved. A mickey is the amount that a mouse has to move for it to report that it has moved.</param>
		/// <param name="dy">The mouse's absolute position along the y-axis or its amount of motion since the last mouse event was generated, depending on the setting of <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_ABSOLUTE" />. Absolute data is specified as the mouse's actual y-coordinate; relative data is specified as the number of mickeys moved.</param>
		/// <param name="dwData">
		/// If <paramref name="dwFlags" /> contains <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_WHEEL" />, then dwData specifies the amount of wheel movement. A positive value indicates that the wheel was rotated forward, away from the user; a negative value indicates that the wheel was rotated backward, toward the user. One wheel click is defined as WHEEL_DELTA, which is 120.
		/// If <paramref name="dwFlags" /> contains <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_HWHEEL" />, then dwData specifies the amount of wheel movement. A positive value indicates that the wheel was tilted to the right; a negative value indicates that the wheel was tilted to the left.
		/// If <paramref name="dwFlags" /> contains <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XDOWN" /> or <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XUP" />, then <paramref name="dwData" /> specifies which X buttons were pressed or released. This value may be any combination of the following flags.
		/// If <paramref name="dwFlags" /> is not <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_WHEEL" />, <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XDOWN" />, or <see cref="F:PInvoke.User32.mouse_eventFlags.MOUSEEVENTF_XUP" />, then <paramref name="dwData" /> should be zero.
		/// </param>
		/// <param name="dwExtraInfo">An additional value associated with the mouse event. An application calls GetMessageExtraInfo to obtain this extra information.</param>
		public static unsafe void mouse_event(User32.mouse_eventFlags dwFlags, int dx, int dy, int dwData,
		                                      IntPtr dwExtraInfo) {
			void* pointer = dwExtraInfo.ToPointer();
			User32.mouse_event(dwFlags, dx, dy, dwData, pointer);
		}

		/// <summary>
		/// Calculates the required size of the window rectangle, based on the desired size of the client rectangle and the provided DPI. This window rectangle can then be passed to the CreateWindowEx function to create a window with a client area of the desired size.
		/// </summary>
		/// <param name="lpRect">A pointer to a <see cref="T:PInvoke.RECT" /> structure that contains the coordinates of the top-left and bottom-right corners of the desired client area. When the function returns, the structure contains the coordinates of the top-left and bottom-right corners of the window to accommodate the desired client area.</param>
		/// <param name="dwStyle">The Window Style of the window whose required size is to be calculated. Note that you cannot specify the <see cref="F:PInvoke.User32.WindowStyles.WS_OVERLAPPED" /> style.</param>
		/// <param name="bMenu">Indicates whether the window has a menu.</param>
		/// <param name="dwExStyle">The Extended Window Style of the window whose required size is to be calculated.</param>
		/// <param name="dpi">The DPI to use for scaling.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool AdjustWindowRectExForDpi(IntPtr lpRect, User32.WindowStyles dwStyle,
		                                                   [MarshalAs(UnmanagedType.Bool)] bool bMenu,
		                                                   User32.WindowStylesEx dwExStyle, int dpi) {
			return User32.AdjustWindowRectExForDpi((RECT*) lpRect.ToPointer(), dwStyle, bMenu, dwExStyle, dpi);
		}

		/// <summary>
		/// Retrieves the value of one of the system-wide parameters, taking into account the provided DPI value.
		/// </summary>
		/// <param name="uiAction">The system-wide parameter to be retrieved. This function is only intended for use with <see cref="F:PInvoke.User32.SystemParametersInfoAction.SPI_GETICONTITLELOGFONT" />, <see cref="F:PInvoke.User32.SystemParametersInfoAction.SPI_GETICONMETRICS" />, or <see cref="F:PInvoke.User32.SystemParametersInfoAction.SPI_GETNONCLIENTMETRICS" />. See <see cref="T:PInvoke.User32.SystemParametersInfoAction" /> for more information on these values.</param>
		/// <param name="uiParam">A parameter whose usage and format depends on the system parameter being queried. For more information about system-wide parameters, see the <paramref name="uiAction" /> parameter. If not otherwise indicated, you must specify zero for this parameter.</param>
		/// <param name="pvParam">A parameter whose usage and format depends on the system parameter being queried. For more information about system-wide parameters, see the <paramref name="uiAction" /> parameter. If not otherwise indicated, you must specify NULL for this parameter.</param>
		/// <param name="fWinIni">Has no effect for with this API. This parameter only has an effect if you're setting parameter.</param>
		/// <param name="dpi">The DPI to use for scaling the metric.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// This function returns a similar result as SystemParametersInfo, but scales it according to an arbitrary DPI you provide (if appropriate). It only scales with the following possible values for uiAction:
		///     SPI_GETICONTITLELOGFONT, SPI_GETICONMETRICS, SPI_GETNONCLIENTMETRICS.
		/// Other possible uiAction values do not provide ForDPI behavior, and therefore this function returns 0 if called with them.
		/// For uiAction values that contain strings within their associated structures, only Unicode(LOGFONTW) strings are supported in this function.
		/// </remarks>
		public static unsafe bool SystemParametersInfoForDpi(User32.SystemParametersInfoAction uiAction, int uiParam,
		                                                     IntPtr pvParam, User32.SystemParametersInfoFlags fWinIni,
		                                                     int dpi) {
			void* pointer = pvParam.ToPointer();
			return User32.SystemParametersInfoForDpi(uiAction, uiParam, pointer, fWinIni, dpi);
		}

		/// <summary>
		/// Calculates the required size of the window rectangle, based on the desired size of the client rectangle.
		/// The window rectangle can then be passed to the CreateWindowEx function to create a window whose client area
		/// is the desired size.
		/// </summary>
		/// <param name="lpRect">
		/// A pointer to a RECT structure that contains the coordinates of the top-left and bottom-right corners
		/// of the desired client area. When the function returns, the structure contains the coordinates of the top-left
		/// and bottom-right corners of the window to accommodate the desired client area.
		/// </param>
		/// <param name="dwStyle">
		/// The window style of the window whose required size is to be calculated. Note that you cannot specify
		/// the <see cref="F:PInvoke.User32.WindowStyles.WS_OVERLAPPED" /> style.</param>
		/// <param name="bMenu">Indicates whether the window has a menu.</param>
		/// <param name="dwExStyle">The extended window style of the window whose required size is to be calculated.</param>
		/// <returns>
		/// If the function succeeds, the return value is true.
		/// If the function fails, the return value is false.
		/// To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// <para>
		/// A client rectangle is the smallest rectangle that completely encloses a client area.
		/// A window rectangle is the smallest rectangle that completely encloses the window, which includes
		/// the client area and the nonclient area.
		/// </para>
		/// <para>
		/// The AdjustWindowRectEx function does not add extra space when a menu bar wraps to two or more rows.
		/// </para>
		/// <para>
		/// The AdjustWindowRectEx function does not take the <see cref="F:PInvoke.User32.WindowStyles.WS_VSCROLL" /> or
		/// <see cref="F:PInvoke.User32.WindowStyles.WS_HSCROLL" /> styles into account.
		/// To account for the scroll bars, call the GetSystemMetrics function with <see cref="F:PInvoke.User32.SystemMetric.SM_CXVSCROLL" /> or
		/// <see cref="F:PInvoke.User32.SystemMetric.SM_CYHSCROLL" />.
		/// </para>
		/// <para>
		/// This API is not DPI aware, and should not be used if the calling thread is per-monitor DPI aware.
		/// For the DPI-aware version of this API, see AdjustWindowsRectExForDPI.
		/// </para>
		/// </remarks>
		public static unsafe bool AdjustWindowRectEx(IntPtr lpRect, User32.WindowStyles dwStyle,
		                                             [MarshalAs(UnmanagedType.Bool)] bool bMenu,
		                                             User32.WindowStylesEx dwExStyle) {
			return User32.AdjustWindowRectEx((RECT*) lpRect.ToPointer(), dwStyle, bMenu, dwExStyle);
		}

		/// <summary>
		/// The BeginPaint function prepares the specified window for painting and fills a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure with information about the painting.
		/// </summary>
		/// <param name="hwnd">Handle to the window to be repainted.</param>
		/// <param name="lpPaint">Pointer to the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that will receive painting information.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to a display device context for the specified window.
		/// If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />, indicating that no display device context is available..</returns>
		/// <remarks>
		/// <para>
		/// The BeginPaint function automatically sets the clipping region of the device context to exclude any area outside the update region.
		/// The update region is set by the InvalidateRect or InvalidateRgn function and by the system after sizing, moving, creating, scrolling,
		/// or any other operation that affects the client area. If the update region is marked for erasing, BeginPaint sends a <see cref="F:PInvoke.User32.WindowMessage.WM_ERASEBKGND" /> message to the window.
		/// </para>
		/// <para>
		/// An application should not call BeginPaint except in response to a <see cref="F:PInvoke.User32.WindowMessage.WM_PAINT" /> message.
		/// Each call to BeginPaint must have a corresponding call to the <see cref="M:PInvoke.User32.EndPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function.
		/// </para>
		/// <para>
		/// If the caret is in the area to be painted, BeginPaint automatically hides the caret to prevent it from being erased.
		/// If the window's class has a background brush, BeginPaint uses that brush to erase the background of the update region before returning.
		/// </para>
		/// </remarks>
		private static unsafe IntPtr BeginPaint_IntPtr(IntPtr hwnd, IntPtr lpPaint) {
			User32.PAINTSTRUCT* pointer = (User32.PAINTSTRUCT*) lpPaint.ToPointer();
			return User32.BeginPaint_IntPtr(hwnd, pointer);
		}

		/// <summary>
		/// The BeginPaint function prepares the specified window for painting and fills a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure with information about the painting.
		/// </summary>
		/// <param name="hwnd">Handle to the window to be repainted.</param>
		/// <param name="lpPaint">Pointer to the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that will receive painting information.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to a display device context for the specified window.
		/// If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />, indicating that no display device context is available..</returns>
		/// <remarks>
		/// <para>
		/// The BeginPaint function automatically sets the clipping region of the device context to exclude any area outside the update region.
		/// The update region is set by the InvalidateRect or InvalidateRgn function and by the system after sizing, moving, creating, scrolling,
		/// or any other operation that affects the client area. If the update region is marked for erasing, BeginPaint sends a <see cref="F:PInvoke.User32.WindowMessage.WM_ERASEBKGND" /> message to the window.
		/// </para>
		/// <para>
		/// An application should not call BeginPaint except in response to a <see cref="F:PInvoke.User32.WindowMessage.WM_PAINT" /> message.
		/// Each call to BeginPaint must have a corresponding call to the <see cref="M:PInvoke.User32.EndPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function.
		/// </para>
		/// <para>
		/// If the caret is in the area to be painted, BeginPaint automatically hides the caret to prevent it from being erased.
		/// If the window's class has a background brush, BeginPaint uses that brush to erase the background of the update region before returning.
		/// </para>
		/// </remarks>
		private static unsafe IntPtr BeginPaint_IntPtr(IntPtr hwnd, out User32.PAINTSTRUCT lpPaint) {
			fixed (User32.PAINTSTRUCT* lpPaint1 = &lpPaint)
				return User32.BeginPaint_IntPtr(hwnd, lpPaint1);
		}

		/// <summary>
		/// Creates an overlapped, pop-up, or child window with an
		/// extended window style; otherwise, this function is identical to the CreateWindow function.
		/// </summary>
		/// <param name="dwExStyle">Specifies the extended window style of the window being created.</param>
		/// <param name="lpClassName">
		/// Pointer to a class atom created by a previous call to the
		/// RegisterClass or RegisterClassEx function. The atom must be in the low-order word of
		/// lpClassName; the high-order word must be zero.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		private static unsafe IntPtr CreateWindowEx(User32.WindowStylesEx dwExStyle, IntPtr lpClassName,
		                                            string lpWindowName, User32.WindowStyles dwStyle, int x, int y,
		                                            int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu,
		                                            IntPtr hInstance, IntPtr lpParam) {
			void* pointer = lpParam.ToPointer();
			return User32.CreateWindowEx(dwExStyle, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight,
				hWndParent, hMenu, hInstance, pointer);
		}

		/// <summary>
		/// Changes an attribute of the specified window. The function also sets a value at the specified
		/// offset in the extra window memory.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
		/// <param name="nIndex">The zero-based offset to the value to be set.</param>
		/// <param name="dwNewLong">The replacement value.</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is the previous value of the specified offset.</para>
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// <para>If the previous value is zero and the function succeeds, the return value is zero, but the function does
		/// not clear the last error information. To determine success or failure, clear the last error information by
		/// calling SetLastError with 0, then call SetWindowLongPtr. Function failure will be indicated by a return value of
		/// zero and a GetLastError result that is nonzero.</para>
		/// </returns>
		/// <remarks>
		/// When compiling for 32-bit Windows, SetWindowLongPtr is defined as a call to the SetWindowLong function. This
		/// function is exposed using a helper that conditionally calls SetWindowLong in 32-bit processes.
		/// </remarks>
		private static unsafe IntPtr SetWindowLongPtr64(IntPtr hWnd, User32.WindowLongIndexFlags nIndex,
		                                                IntPtr dwNewLong) {
			void* pointer = dwNewLong.ToPointer();
			return new IntPtr(User32.SetWindowLongPtr64(hWnd, nIndex, pointer));
		}

		/// <summary>
		/// The BeginPaint function prepares the specified window for painting and fills a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure with information about the painting.
		/// </summary>
		/// <param name="hwnd">Handle to the window to be repainted.</param>
		/// <param name="lpPaint">Pointer to the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that will receive painting information.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to a display device context for the specified window.
		/// If the function fails, the return value is <see cref="F:PInvoke.User32.SafeDCHandle.Null" />, indicating that no display device context is available..</returns>
		/// <remarks>
		/// <para>
		/// The BeginPaint function automatically sets the clipping region of the device context to exclude any area outside the update region.
		/// The update region is set by the InvalidateRect or InvalidateRgn function and by the system after sizing, moving, creating, scrolling,
		/// or any other operation that affects the client area. If the update region is marked for erasing, BeginPaint sends a <see cref="F:PInvoke.User32.WindowMessage.WM_ERASEBKGND" /> message to the window.
		/// </para>
		/// <para>
		/// An application should not call BeginPaint except in response to a <see cref="F:PInvoke.User32.WindowMessage.WM_PAINT" /> message.
		/// Each call to BeginPaint must have a corresponding call to the <see cref="M:PInvoke.User32.EndPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function.
		/// </para>
		/// <para>
		/// If the caret is in the area to be painted, BeginPaint automatically hides the caret to prevent it from being erased.
		/// If the window's class has a background brush, BeginPaint uses that brush to erase the background of the update region before returning.
		/// </para>
		/// </remarks>
		public static unsafe User32.SafeDCHandle BeginPaint(IntPtr hwnd, IntPtr lpPaint) {
			User32.PAINTSTRUCT* pointer = (User32.PAINTSTRUCT*) lpPaint.ToPointer();
			return User32.BeginPaint(hwnd, pointer);
		}

		/// <summary>
		/// The BeginPaint function prepares the specified window for painting and fills a <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure with information about the painting.
		/// </summary>
		/// <param name="hwnd">Handle to the window to be repainted.</param>
		/// <param name="lpPaint">Pointer to the <see cref="T:PInvoke.User32.PAINTSTRUCT" /> structure that will receive painting information.</param>
		/// <returns>
		/// If the function succeeds, the return value is the handle to a display device context for the specified window.
		/// If the function fails, the return value is <see cref="F:PInvoke.User32.SafeDCHandle.Null" />, indicating that no display device context is available..</returns>
		/// <remarks>
		/// <para>
		/// The BeginPaint function automatically sets the clipping region of the device context to exclude any area outside the update region.
		/// The update region is set by the InvalidateRect or InvalidateRgn function and by the system after sizing, moving, creating, scrolling,
		/// or any other operation that affects the client area. If the update region is marked for erasing, BeginPaint sends a <see cref="F:PInvoke.User32.WindowMessage.WM_ERASEBKGND" /> message to the window.
		/// </para>
		/// <para>
		/// An application should not call BeginPaint except in response to a <see cref="F:PInvoke.User32.WindowMessage.WM_PAINT" /> message.
		/// Each call to BeginPaint must have a corresponding call to the <see cref="M:PInvoke.User32.EndPaint(System.IntPtr,PInvoke.User32.PAINTSTRUCT*)" /> function.
		/// </para>
		/// <para>
		/// If the caret is in the area to be painted, BeginPaint automatically hides the caret to prevent it from being erased.
		/// If the window's class has a background brush, BeginPaint uses that brush to erase the background of the update region before returning.
		/// </para>
		/// </remarks>
		public static unsafe User32.SafeDCHandle BeginPaint(IntPtr hwnd, out User32.PAINTSTRUCT lpPaint) {
			fixed (User32.PAINTSTRUCT* lpPaint1 = &lpPaint)
				return User32.BeginPaint(hwnd, lpPaint1);
		}

		/// <summary>
		/// The CreateWindow is identical to the CreateWindowEx function, actually it is a macro on C/C++
		/// </summary>
		/// <param name="lpClassName">
		/// Pointer to a null-terminated string or a class atom created by a previous call to the
		/// RegisterClass or RegisterClassEx function. The atom must be in the low-order word of
		/// lpClassName; the high-order word must be zero. If lpClassName is a string, it specifies
		/// the window class name. The class name can be any name registered with RegisterClass or
		/// RegisterClassEx, provided that the module that registers the class is also the module
		/// that creates the window. The class name can also be any of the predefined system class names.
		/// </param>
		/// <param name="lpWindowName">
		/// Pointer to a null-terminated string that specifies the window name. If the window style
		/// specifies a title bar, the window title pointed to by lpWindowName is displayed in the
		/// title bar. When using CreateWindow to create controls, such as buttons, check boxes, and
		/// static controls, use lpWindowName to specify the text of the control. When creating a
		/// static control with the SS_ICON style, use lpWindowName to specify the icon name or
		/// identifier. To specify an identifier, use the syntax "#num".
		/// </param>
		/// <param name="dwStyle">
		/// Specifies the style of the window being created. This parameter can be a combination of
		/// window styles, plus the control styles indicated in the Remarks section.
		/// </param>
		/// <param name="x">
		/// Specifies the initial horizontal position of the window. For an overlapped or pop-up
		/// window, the x parameter is the initial x-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of
		/// the window relative to the upper-left corner of the parent window's client area. If x is
		/// set to CW_USEDEFAULT, the system selects the default position for the window's upper-left
		/// corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows;
		/// if it is specified for a pop-up or child window, the x and y parameters are set to zero.
		/// </param>
		/// <param name="y">
		/// Specifies the initial vertical position of the window. For an overlapped or pop-up
		/// window, the y parameter is the initial y-coordinate of the window's upper-left corner, in
		/// screen coordinates. For a child window, y is the initial y-coordinate of the upper-left
		/// corner of the child window relative to the upper-left corner of the parent window's
		/// client area. For a list box y is the initial y-coordinate of the upper-left corner of the
		/// list box's client area relative to the upper-left corner of the parent window's client area.
		/// <para>
		/// If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter
		/// is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the
		/// y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW
		/// flag after the window has been created. If the y parameter is some other value, then the
		/// window manager calls ShowWindow with that value as the nCmdShow parameter.
		/// </para>
		/// </param>
		/// <param name="nWidth">
		/// Specifies the width, in device units, of the window. For overlapped windows, nWidth is
		/// the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT,
		/// the system selects a default width and height for the window; the default width extends
		/// from the initial x-coordinates to the right edge of the screen; the default height
		/// extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid
		/// only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window,
		/// the nWidth and nHeight parameter are set to zero.
		/// </param>
		/// <param name="nHeight">
		/// Specifies the height, in device units, of the window. For overlapped windows, nHeight is
		/// the window's height, in screen coordinates. If the nWidth parameter is set to
		/// CW_USEDEFAULT, the system ignores nHeight.
		/// </param>
		/// <param name="hWndParent">
		/// Handle to the parent or owner window of the window being created. To create a child
		/// window or an owned window, supply a valid window handle. This parameter is optional for
		/// pop-up windows.
		/// <para>
		/// Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an
		/// existing message-only window.
		/// </para>
		/// </param>
		/// <param name="hMenu">
		/// Handle to a menu, or specifies a child-window identifier, depending on the window style.
		/// For an overlapped or pop-up window, hMenu identifies the menu to be used with the window;
		/// it can be NULL if the class menu is to be used. For a child window, hMenu specifies the
		/// child-window identifier, an integer value used by a dialog box control to notify its
		/// parent about events. The application determines the child-window identifier; it must be
		/// unique for all child windows with the same parent window.
		/// </param>
		/// <param name="hInstance">
		/// Handle to the instance of the module to be associated with the window.
		/// </param>
		/// <param name="lpParam">
		/// Pointer to a value to be passed to the window through the CREATESTRUCT structure
		/// (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This
		/// message is sent to the created window by this function before it returns.
		/// <para>
		/// If an application calls CreateWindow to create a MDI client window, lpParam should point
		/// to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create
		/// an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be
		/// NULL if no additional data is needed.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the new window.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// <para>This function typically fails for one of the following reasons:</para>
		/// <list type="">
		/// <item>an invalid parameter value</item>
		/// <item>the system class was registered by a different module</item>
		/// <item>The WH_CBT hook is installed and returns a failure code</item>
		/// <item>
		/// if one of the controls in the dialog template is not registered, or its window window
		/// procedure fails WM_CREATE or WM_NCCREATE
		/// </item>
		/// </list>
		/// </returns>
		public static unsafe IntPtr CreateWindow(string lpClassName, string lpWindowName, User32.WindowStyles dwStyle,
		                                         int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu,
		                                         IntPtr hInstance, IntPtr lpParam) {
			void* pointer = lpParam.ToPointer();
			return User32.CreateWindow(lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, hMenu,
				hInstance, pointer);
		}

		/// <summary>
		/// Changes an attribute of the specified window. The function also sets a value at the specified
		/// offset in the extra window memory.
		/// </summary>
		/// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.
		/// The SetWindowLongPtr function fails if the process that owns the window specified by the
		/// <paramref name="hWnd" /> parameter is at a higher process privilege in the UIPI hierarchy than the
		/// process the calling thread resides in.</param>
		/// <param name="nIndex">The zero-based offset to the value to be set. Valid values are in the range zero
		/// through the number of bytes of extra window memory, minus the size of a LONG_PTR. To set any other value,
		/// specify one of the following values.
		/// 
		/// <list type="table">
		/// <listheader><term>Value</term><term>Meaning</term></listheader>
		/// <item><term>GWL_EXSTYLE(-20)</term><term>Sets a new extended window style.</term></item>
		/// <item><term>GWLP_HINSTANCE(-6)</term><term>Sets a new application instance handle.</term></item>
		/// <item><term>GWLP_ID(-12)</term><term>Sets a new identifier of the child window.The window cannot be a top-level window.</term></item>
		/// <item><term>GWL_STYLE (-16)</term><term>Sets a new window style.</term></item>
		/// <item><term>GWLP_USERDATA</term><term>Sets the user data associated with the window.This data is intended for use by the application that created the window. Its value is initially zero.</term></item>
		/// <item><term>GWLP_WNDPROC (-4)</term><term>Sets a new address for the window procedure.</term></item>
		/// </list>
		/// 
		/// The following values are also available when the hWnd parameter identifies a dialog box.
		/// 
		/// <list type="table">
		/// <listheader><term>Value</term><term>Meaning</term></listheader>
		/// <item><term>DWLP_DLGPROC (DWLP_MSGRESULT + sizeof(LRESULT))</term><term>Sets the new pointer to the dialog box procedure.</term></item>
		/// <item><term>DWLP_MSGRESULT (0)</term><term>Sets the return value of a message processed in the dialog box procedure.</term></item>
		/// <item><term>DWLP_USER (DWLP_DLGPROC + sizeof(DLGPROC))</term><term>Sets new extra info</term></item>
		/// </list>
		/// 
		/// </param>
		/// <param name="dwNewLong">The replacement value.</param>
		/// <returns>
		/// <para>If the function succeeds, the return value is the previous value of the specified offset.</para>
		/// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// <para>If the previous value is zero and the function succeeds, the return value is zero, but the function does
		/// not clear the last error information. To determine success or failure, clear the last error information by
		/// calling SetLastError with 0, then call SetWindowLongPtr. Function failure will be indicated by a return value of
		/// zero and a GetLastError result that is nonzero.</para>
		/// </returns>
		/// <remarks>
		/// <list type="bullet">
		/// <item>The return type, and the type of <paramref name="dwNewLong" /> are both LONG_PTR.
		/// LONG_PTR is defined as <code>__int64</code> on 64-bit platforms, and it is defined as <code>long</code>
		/// on 32-bit platforms. This definition fits nicely with now <see cref="T:System.IntPtr" /> works on 32-bit vs. 64-bit
		/// platforms.</item>
		/// <item>Windows XP/2000: The SetWindowLongPtr function fails if the window specified by the
		/// <paramref name="hWnd" /> parameter does not belong to the same process as the calling thread.</item>
		/// <item>When compiling for 32-bit Windows, SetWindowLongPtr is defined as a call to the SetWindowLong function.</item>
		/// <item>
		/// <para>Certain window data is cached, so changes you make using SetWindowLongPtr will not take effect until you call
		/// the SetWindowPos function.</para>
		/// <para>If you use SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.GWLP_WNDPROC" /> index to replace the window procedure,
		/// the window procedure must conform to the guidelines specified in the description of the WindowProc callback function.</para>
		/// <para>If you use SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.DWLP_MSGRESULT" /> index to set the return value for a
		/// message processed by a dialog box procedure, the dialog box procedure should return TRUE directly afterward. Otherwise, if you call
		/// any function that results in your dialog box procedure receiving a window message, the nested window message could overwrite the return value
		/// you set by using <see cref="F:PInvoke.User32.WindowLongIndexFlags.DWLP_MSGRESULT" />.</para>
		/// <para>Calling SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.GWLP_WNDPROC" /> index creates a subclass of the window
		/// class used to create the window. An application can subclass a system class, but should not subclass a window class created by another process.
		/// The SetWindowLongPtr function creates the window subclass by changing the window procedure associated with a particular
		/// window class, causing the system to call the new window procedure instead of the previous one. An application must pass
		/// any messages not processed by the new window procedure to the previous window procedure by calling CallWindowProc.
		/// This allows the application to create a chain of window procedures.</para>
		/// <para>Reserve extra window memory by specifying a nonzero value in the <see cref="F:PInvoke.User32.WNDCLASSEX.cbWndExtra" /> member of the
		/// <see cref="T:PInvoke.User32.WNDCLASSEX" /> structure used with the RegisterClassEx function.</para>
		/// <para>Do not call SetWindowLongPtr with the <see cref="F:PInvoke.User32.WindowLongIndexFlags.GWLP_HWNDPARENT" /> index to change the parent of a
		/// child window. Instead, use the SetParent function.</para>
		/// <para>If the window has a class style of <see cref="F:PInvoke.User32.ClassStyles.CS_CLASSDC" /> or <see cref="F:PInvoke.User32.ClassStyles.CS_PARENTDC" />, do not set
		/// the extended window styles <see cref="F:PInvoke.User32.WindowStylesEx.WS_EX_COMPOSITED" /> or <see cref="F:PInvoke.User32.WindowStylesEx.WS_EX_LAYERED" />.</para>
		/// <para>Calling SetWindowLongPtr to set the style on a progressbar will reset its position.</para>
		/// </item>
		/// </list>
		/// </remarks>
		public static unsafe IntPtr
			SetWindowLongPtr(IntPtr hWnd, User32.WindowLongIndexFlags nIndex, IntPtr dwNewLong) {
			void* pointer = dwNewLong.ToPointer();
			return new IntPtr(User32.SetWindowLongPtr(hWnd, nIndex, pointer));
		}

		/// <summary>
		/// For use with <see cref="M:PInvoke.User32.ChildWindowFromPointEx(System.IntPtr,PInvoke.POINT,PInvoke.User32.ChildWindowFromPointExFlags)" />
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ChildWindowFromPointExFlags {
			CWP_ALL = 0,
			CWP_SKIPINVISIBLE = 1,
			CWP_SKIPDISABLED = 2,
			CWP_SKIPTRANSPARENT = 4,
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ClassStyles : uint {
			CS_BYTEALIGNCLIENT = 4096, // 0x00001000
			CS_BYTEALIGNWINDOW = 8192, // 0x00002000
			CS_CLASSDC = 64, // 0x00000040
			CS_DBLCLKS = 8,
			CS_DROPSHADOW = 131072, // 0x00020000
			CS_GLOBALCLASS = 16384, // 0x00004000
			CS_HREDRAW = 2,
			CS_NOCLOSE = 512, // 0x00000200
			CS_OWNDC = 32, // 0x00000020
			CS_PARENTDC = 128, // 0x00000080
			CS_SAVEBITS = 2048, // 0x00000800
			CS_VREDRAW = 1,
		}

		/// <summary>
		/// Controls the access of other processes to the created desktop
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DesktopCreationFlags : uint {
			None,
			DF_ALLOWOTHERACCOUNTHOOK,
		}

		/// <summary>
		/// Values to pass to the <see cref="M:PInvoke.User32.GetDCEx(System.IntPtr,System.IntPtr,PInvoke.User32.DeviceContextValues)" /> method describing how to create the DC.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DeviceContextValues : uint {
			DCX_WINDOW = 1,
			DCX_CACHE = 2,
			DCX_NORESETATTRS = 4,
			DCX_CLIPCHILDREN = 8,
			DCX_CLIPSIBLINGS = 16, // 0x00000010
			DCX_PARENTCLIP = 32, // 0x00000020
			DCX_EXCLUDERGN = 64, // 0x00000040
			DCX_INTERSECTRGN = 128, // 0x00000080
			DCX_EXCLUDEUPDATE = 256, // 0x00000100
			DCX_INTERSECTUPDATE = 512, // 0x00000200
			DCX_LOCKWINDOWUPDATE = 1024, // 0x00000400
			DCX_USESTYLE = 65536, // 0x00010000
			DCX_VALIDATE = 2097152, // 0x00200000
		}

		/// <summary>
		/// Describes per-monitor DPI scaling behavior overrides for child windows within dialogs. The values in this enumeration are bitfields and can be combined.
		/// </summary>
		/// <remarks>
		/// This enum is used with SetDialogControlDpiChangeBehavior in order to override the default per-monitor DPI scaling behavior for a child window within a dialog.
		/// 
		/// These settings only apply to individual controls within dialogs. The dialog-wide per-monitor DPI scaling behavior of a dialog is controlled by <see cref="T:PInvoke.User32.DIALOG_DPI_CHANGE_BEHAVIORS" />.
		/// </remarks>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS {
			DCDC_DEFAULT = 0,
			DCDC_DISABLE_FONT_UPDATE = 1,
			DCDC_DISABLE_RELAYOUT = 2,
		}

		/// <summary>
		/// In Per Monitor v2 contexts, dialogs will automatically respond to DPI changes by resizing themselves and re-computing the positions of their child windows (here referred to as re-layouting).
		/// This enum works in conjunction with SetDialogDpiChangeBehavior in order to override the default DPI scaling behavior for dialogs.
		/// This does not affect DPI scaling behavior for the child windows of dialogs(beyond re-layouting), which is controlled by <see cref="T:PInvoke.User32.DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS" />.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DIALOG_DPI_CHANGE_BEHAVIORS {
			DDC_DEFAULT = 0,
			DDC_DISABLE_ALL = 1,
			DDC_DISABLE_RESIZE = 2,
			DDC_DISABLE_CONTROL_RELAYOUT = DDC_DISABLE_RESIZE | DDC_DISABLE_ALL, // 0x00000003
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_2DREGION {
			public uint cx;
			public uint cy;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_ADDITIONAL_SIGNAL_INFO {
			private const int vSyncFreqDividerBitMask = 63;
			public ushort videoStandard;
			private ushort split;

			public int vSyncFreqDivider {
				get { return (int) this.split & 63; }
				set {
					Requires.Range(value <= 63, nameof(value), (string) null);
					this.split = (ushort) ((int) this.split & -64 | value);
				}
			}
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_DESKTOP_IMAGE_INFO {
			public POINT PathSourceSize;
			public RECT DesktopImageRegion;
			public RECT DesktopImageClip;
		}

		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_MODE_INFO {
			[FieldOffset(0)] public User32.DISPLAYCONFIG_MODE_INFO_TYPE infoType;
			[FieldOffset(4)] public uint id;
			[FieldOffset(8)] public User32.LUID adapterId;
			[FieldOffset(16)] public User32.DISPLAYCONFIG_TARGET_MODE targetMode;
			[FieldOffset(16)] public User32.DISPLAYCONFIG_SOURCE_MODE sourceMode;
			[FieldOffset(16)] public User32.DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_MODE_INFO_TYPE {
			DISPLAYCONFIG_MODE_INFO_TYPE_FORCE_UINT32 = -1,
			DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE = 1,
			DISPLAYCONFIG_MODE_INFO_TYPE_TARGET = 2,
			DISPLAYCONFIG_MODE_INFO_TYPE_DESKTOP_IMAGE = 3,
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_PATH_INFO {
			public User32.DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;
			public User32.DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;
			public uint flags;
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_PATH_SOURCE_INFOFlags {
			None = 0,
			DISPLAYCONFIG_SOURCE_IN_USE = 1,
		}

		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_PATH_SOURCE_INFO {
			[FieldOffset(0)] public User32.LUID adapterId;
			[FieldOffset(8)] public uint id;
			[FieldOffset(12)] public uint modeInfoIdx;
			[FieldOffset(12)] public ushort cloneGroupId;
			[FieldOffset(14)] public ushort sourceModeInfoIdx;
			[FieldOffset(16)] public User32.DISPLAYCONFIG_PATH_SOURCE_INFOFlags statusFlags;
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_PATH_TARGET_INFOFlags {
			None = 0,
			DISPLAYCONFIG_TARGET_IN_USE = 1,
			DISPLAYCONFIG_TARGET_FORCIBLE = 2,
			DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_BOOT = 4,
			DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_PATH = 8,
			DISPLAYCONFIG_TARGET_FORCED_AVAILABILITY_SYSTEM = 16, // 0x00000010
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_PATH_TARGET_INFO {
			public User32.LUID adapterId;
			public uint id;
			public User32.DISPLAYCONFIG_TARGET_MODE_INFO targetModeInfo;
			public User32.DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
			public User32.DISPLAYCONFIG_ROTATION rotation;
			public User32.DISPLAYCONFIG_SCALING scaling;
			public User32.DISPLAYCONFIG_RATIONAL refreshRate;
			public User32.DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
			[MarshalAs(UnmanagedType.Bool)] public bool targetAvailable;
			public User32.DISPLAYCONFIG_PATH_TARGET_INFOFlags statusFlags;
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_PIXELFORMAT {
			DISPLAYCONFIG_PIXELFORMAT_FORCE_UINT32 = -1,
			DISPLAYCONFIG_PIXELFORMAT_8BPP = 1,
			DISPLAYCONFIG_PIXELFORMAT_16BPP = 2,
			DISPLAYCONFIG_PIXELFORMAT_24BPP = 3,
			DISPLAYCONFIG_PIXELFORMAT_32BPP = 4,
			DISPLAYCONFIG_PIXELFORMAT_NONGDI = 5,
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_RATIONAL {
			public uint Numerator;
			public uint Denominator;
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_ROTATION {
			DISPLAYCONFIG_ROTATION_FORCE_UINT32 = -1,
			DISPLAYCONFIG_ROTATION_IDENTITY = 1,
			DISPLAYCONFIG_ROTATION_ROTATE90 = 2,
			DISPLAYCONFIG_ROTATION_ROTATE180 = 3,
			DISPLAYCONFIG_ROTATION_ROTATE270 = 4,
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_SCALING {
			DISPLAYCONFIG_SCALING_FORCE_UINT32 = -1,
			DISPLAYCONFIG_SCALING_IDENTITY = 1,
			DISPLAYCONFIG_SCALING_CENTERED = 2,
			DISPLAYCONFIG_SCALING_STRETCHED = 3,
			DISPLAYCONFIG_SCALING_ASPECTRATIOCENTEREDMAX = 4,
			DISPLAYCONFIG_SCALING_CUSTOM = 5,
			DISPLAYCONFIG_SCALING_PREFERRED = 128, // 0x00000080
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_SCANLINE_ORDERING {
			DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32 = -1,
			DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED = 0,
			DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE = 1,
			DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED = 2,
			DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST = 2,
			DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST = 3,
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_SOURCE_MODE {
			public uint width;
			public uint height;
			public User32.DISPLAYCONFIG_PIXELFORMAT pixelFormat;
			public POINT position;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_TARGET_MODE {
			public User32.DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_TOPOLOGY_ID {
			DISPLAYCONFIG_TOPOLOGY_FORCE_UINT32 = -1,
			DISPLAYCONFIG_TOPOLOGY_INTERNAL = 1,
			DISPLAYCONFIG_TOPOLOGY_CLONE = 2,
			DISPLAYCONFIG_TOPOLOGY_EXTEND = 4,
			DISPLAYCONFIG_TOPOLOGY_EXTERNAL = 8,
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY {
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL = -2147483648, // -0x80000000
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32 = -1,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER = -1,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15 = 0,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO = 1,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO = 2,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO = 3,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI = 4,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI = 5,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS = 6,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN = 8,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI = 9,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL = 10, // 0x0000000A
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED = 11, // 0x0000000B
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL = 12, // 0x0000000C
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED = 13, // 0x0000000D
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE = 14, // 0x0000000E
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST = 15, // 0x0000000F
		}

		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO {
			[FieldOffset(0)] public ulong pixelRate;
			[FieldOffset(8)] public User32.DISPLAYCONFIG_RATIONAL hSyncFreq;
			[FieldOffset(16)] public User32.DISPLAYCONFIG_RATIONAL vSyncFreq;
			[FieldOffset(24)] public User32.DISPLAYCONFIG_2DREGION activeSize;
			[FieldOffset(32)] public User32.DISPLAYCONFIG_2DREGION totalSize;
			[FieldOffset(40)] public User32.DISPLAYCONFIG_ADDITIONAL_SIGNAL_INFO AdditionalSignalInfo;
			[FieldOffset(40)] public uint videoStandard;
			[FieldOffset(44)] public User32.DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DISPLAYCONFIG_TARGET_MODE_INFO {
			private uint bitvector;

			public uint DesktopModeInfoIdx {
				get { return this.bitvector & (uint) ushort.MaxValue; }
				set { this.bitvector = value | this.bitvector; }
			}

			public uint TargetModeInfoIdx {
				get { return (this.bitvector & 4294901760U) / 65536U; }
				set { this.bitvector = value * 65536U | this.bitvector; }
			}
		}

		/// <summary>
		///     Defines the dimensions and style of a control in a dialog box. One or more of these structures are combined with a
		///     <see cref="T:PInvoke.User32.DLGTEMPLATE" /> structure to form a standard template for a dialog box.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, Pack = 2, CharSet = CharSet.Unicode)]
		public struct DLGITEMTEMPLATE {
			/// <summary>
			///     The style of the control. This member can be a combination of window style values (such as WS_BORDER) and one or
			///     more of the control style values (such as BS_PUSHBUTTON and ES_LEFT).
			/// </summary>
			public int style;

			/// <summary>
			///     The extended styles for a window. This member is not used to create controls in dialog boxes, but applications that
			///     use dialog box templates can use it to create other types of windows.
			/// </summary>
			public int dwExtendedStyle;

			/// <summary>
			///     The x-coordinate, in dialog box units, of the upper-left corner of the control. This coordinate is always relative
			///     to the upper-left corner of the dialog box's client area.
			/// </summary>
			public byte x;

			/// <summary>
			///     The y-coordinate, in dialog box units, of the upper-left corner of the control. This coordinate is always relative
			///     to the upper-left corner of the dialog box's client area.
			/// </summary>
			public byte y;

			/// <summary>The width, in dialog box units, of the control.</summary>
			public byte cx;

			/// <summary>The height, in dialog box units, of the control.</summary>
			public byte cy;

			/// <summary>The control identifier.</summary>
			public short id;
		}

		/// <summary>
		///     Defines the dimensions and style of a dialog box. This structure, always the first in a standard template for a
		///     dialog box, also specifies the number of controls in the dialog box and therefore specifies the number of
		///     subsequent <see cref="T:PInvoke.User32.DLGITEMTEMPLATE" /> structures in the template.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, Pack = 2, CharSet = CharSet.Unicode)]
		public struct DLGTEMPLATE {
			/// <summary>
			///     The style of the dialog box. This member can be a combination of window style values (such as WS_CAPTION and
			///     WS_SYSMENU) and dialog box style values (such as DS_CENTER).
			///     <para>
			///         If the style member includes the DS_SETFONT style, the header of the dialog box template contains additional
			///         data specifying the font to use for text in the client area and controls of the dialog box. The font data
			///         begins on the WORD boundary that follows the title array. The font data specifies a 16-bit point size value and
			///         a Unicode font name string. If possible, the system creates a font according to the specified values. Then the
			///         system sends a WM_SETFONT message to the dialog box and to each control to provide a handle to the font. If
			///         DS_SETFONT is not specified, the dialog box template does not include the font data.
			///     </para>
			///     <para>The DS_SHELLFONT style is not supported in the DLGTEMPLATE header.</para>
			/// </summary>
			public int style;

			/// <summary>
			///     The extended styles for a window. This member is not used to create dialog boxes, but applications that use dialog
			///     box templates can use it to create other types of windows.
			/// </summary>
			public int dwExtendedStyle;

			/// <summary>The number of items in the dialog box.</summary>
			public short cdit;

			/// <summary>
			///     The x-coordinate, in dialog box units, of the upper-left corner of the dialog box.
			/// </summary>
			public byte x;

			/// <summary>
			///     The y-coordinate, in dialog box units, of the upper-left corner of the dialog box.
			/// </summary>
			public byte y;

			/// <summary>
			///     The width, in dialog box units, of the dialog box.
			/// </summary>
			public byte cx;

			/// <summary>
			///     The height, in dialog box units, of the dialog box.
			/// </summary>
			public byte cy;
		}

		/// <summary>
		/// Identifies the dots per inch (dpi) setting for a thread, process, or window.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DPI_AWARENESS {
			DPI_AWARENESS_INVALID = -1,
			DPI_AWARENESS_UNAWARE = 0,
			DPI_AWARENESS_SYSTEM_AWARE = 1,
			DPI_AWARENESS_PER_MONITOR_AWARE = 2,
		}

		/// <summary>
		/// Identifies the DPI hosting behavior for a window. This behavior allows windows created in the thread to host child windows with a different DPI_AWARENESS_CONTEXT.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum DPI_HOSTING_BEHAVIOR {
			DPI_HOSTING_BEHAVIOR_INVALID = -1,
			DPI_HOSTING_BEHAVIOR_DEFAULT = 0,
			DPI_HOSTING_BEHAVIOR_MIXED = 1,
		}

		/// <summary>
		/// Values to pass to the <see cref="M:PInvoke.User32.DrawTextEx(PInvoke.User32.SafeDCHandle,System.Char*,System.Int32,PInvoke.RECT*,System.UInt32,PInvoke.User32.DRAWTEXTPARAMS*)" /> method describing extended formatting options for the text.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DRAWTEXTPARAMS {
			/// <summary>The structure size, in bytes.</summary>
			public uint cbSize;

			/// <summary>
			/// The size of each tab stop, in units equal to the average character width.
			/// </summary>
			public int iTabLength;

			/// <summary>
			/// The left margin, in units equal to the average character width.
			/// </summary>
			public int iLeftMargin;

			/// <summary>
			/// The right margin, in units equal to the average character width.
			/// </summary>
			public int iRightMargin;

			/// <summary>
			/// Receives the number of characters processed by <see cref="M:PInvoke.User32.DrawTextEx(PInvoke.User32.SafeDCHandle,System.Char*,System.Int32,PInvoke.RECT*,System.UInt32,PInvoke.User32.DRAWTEXTPARAMS*)" />,
			/// including white-space characters. The number can be the length of the string or the index of the first line that falls below the drawing area.
			/// Note that <see cref="M:PInvoke.User32.DrawTextEx(PInvoke.User32.SafeDCHandle,System.Char*,System.Int32,PInvoke.RECT*,System.UInt32,PInvoke.User32.DRAWTEXTPARAMS*)" /> always processes the entire string if the <see cref="F:PInvoke.User32.TextFormats.DT_NOCLIP" /> formatting flag is specified.
			/// </summary>
			public uint uiLengthDrawn;
		}

		/// <summary>The flash status stored in <see cref="T:PInvoke.User32.FLASHWINFO" /> and used in <see cref="M:PInvoke.User32.FlashWindowEx(PInvoke.User32.FLASHWINFO@)" />.</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum FlashWindowFlags {
			FLASHW_STOP = 0,
			FLASHW_CAPTION = 1,
			FLASHW_TRAY = 2,
			FLASHW_ALL = 3,
			FLASHW_TIMER = 4,
			FLASHW_TIMERNOFG = 12, // 0x0000000C
		}

		/// <summary>
		///     Contains the flash status for a window and the number of times the system should flash the window. Used in
		///     <see cref="M:PInvoke.User32.FlashWindowEx(PInvoke.User32.FLASHWINFO@)" />.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct FLASHWINFO {
			/// <summary>The size of the structure, in bytes.</summary>
			public int cbSize;

			/// <summary>A handle to the window to be flashed. The window can be either opened or minimized.</summary>
			public IntPtr hwnd;

			/// <summary>The flash status</summary>
			public User32.FlashWindowFlags dwFlags;

			/// <summary>The number of times to flash the window.</summary>
			public int uCount;

			/// <summary>
			///     The rate at which the window is to be flashed, in milliseconds. If <see cref="F:PInvoke.User32.FLASHWINFO.dwTimeout" /> is zero, the
			///     function uses the default cursor blink rate.
			/// </summary>
			public int dwTimeout;

			/// <summary>
			/// Create a new instance of <see cref="T:PInvoke.User32.FLASHWINFO" /> with <see cref="F:PInvoke.User32.FLASHWINFO.cbSize" /> set to the correct value.
			/// </summary>
			/// <returns>A new instance of <see cref="T:PInvoke.User32.FLASHWINFO" /> with <see cref="F:PInvoke.User32.FLASHWINFO.cbSize" /> set to the correct value.</returns>
			public static User32.FLASHWINFO Create() {
				return new User32.FLASHWINFO() {
					cbSize = Marshal.SizeOf(typeof(User32.FLASHWINFO))
				};
			}
		}

		/// <summary>The ancestor to be retrieved by <see cref="M:PInvoke.User32.GetAncestor(System.IntPtr,PInvoke.User32.GetAncestorFlags)" />.</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum GetAncestorFlags {
			GA_PARENT = 1,
			GA_ROOT = 2,
			GA_ROOTOWNER = 3,
		}

		/// <summary>The commands that can be used as arguments to <see cref="M:PInvoke.User32.GetNextWindow(System.IntPtr,PInvoke.User32.GetNextWindowCommands)" />.</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum GetNextWindowCommands {
			GW_HWNDNEXT = 2,
			GW_HWNDPREV = 3,
		}

		/// <summary>The commands that can be used as arguments to <see cref="M:PInvoke.User32.GetWindow(System.IntPtr,PInvoke.User32.GetWindowCommands)" />.</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum GetWindowCommands {
			GW_HWNDFIRST,
			GW_HWNDLAST,
			GW_HWNDNEXT,
			GW_HWNDPREV,
			GW_OWNER,
			GW_CHILD,
			GW_ENABLEDPOPUP,
		}

		/// <summary>
		/// Contains information about a simulated message generated by an input device other than a keyboard or mouse.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct HARDWAREINPUT {
			/// <summary>The message generated by the input hardware.</summary>
			public uint uMsg;

			/// <summary>
			/// The low-order word of the lParam parameter for <see cref="F:PInvoke.User32.HARDWAREINPUT.uMsg" />.
			/// </summary>
			public ushort wParamL;

			/// <summary>
			/// The high-order word of the lParam parameter for <see cref="F:PInvoke.User32.HARDWAREINPUT.uMsg" />.
			/// </summary>
			public ushort wParamH;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct HELPINFO {
			public int cbSize;
			public int iContextType;
			public int iCtrlId;
			public IntPtr hItemHandle;
			public uint dwContextId;
			public POINT MousePos;

			public static User32.HELPINFO Create() {
				return new User32.HELPINFO() {
					cbSize = Marshal.SizeOf(typeof(User32.HELPINFO))
				};
			}
		}

		/// <summary>
		/// Used by <see cref="M:PInvoke.User32.SendInput(System.Int32,PInvoke.User32.INPUT*,System.Int32)" /> to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct INPUT {
			/// <summary>The type of the input event.</summary>
			public User32.InputType type;

			/// <summary>The union of mouse, keyboard and hardware input.</summary>
			public User32.INPUT.InputUnion Inputs;

			/// <summary>Describes some kind of input.</summary>
			/// <remarks>
			/// This struct is a union where all fields share memory address space.
			/// </remarks>
			/// <devremarks>
			/// From http://www.pinvoke.net/default.aspx/Structures/INPUT.html:
			/// The last 3 fields are a union, which is why they are all at the same memory offset.
			/// On 64-Bit systems, the offset of the <see cref="F:PInvoke.User32.INPUT.InputUnion.mi" />, <see cref="F:PInvoke.User32.INPUT.InputUnion.ki" /> and <see cref="F:PInvoke.User32.INPUT.InputUnion.hi" /> fields is 8,
			/// because the nested struct uses the alignment of its biggest member, which is 8
			/// (due to the 64-bit pointer in <see cref="F:PInvoke.User32.KEYBDINPUT.dwExtraInfo" />).
			/// By separating the union into its own structure, rather than placing the
			/// <see cref="F:PInvoke.User32.INPUT.InputUnion.mi" />, <see cref="F:PInvoke.User32.INPUT.InputUnion.ki" /> and <see cref="F:PInvoke.User32.INPUT.InputUnion.hi" /> fields directly in the INPUT structure,
			/// we assure that the .NET structure will have the correct alignment on both 32 and 64 bit.
			/// </devremarks>
			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			public struct InputUnion {
				/// <summary>
				/// The information about a simulated mouse event.
				/// This field shares memory with the <see cref="F:PInvoke.User32.INPUT.InputUnion.ki" /> and <see cref="F:PInvoke.User32.INPUT.InputUnion.hi" /> fields.
				/// </summary>
				[FieldOffset(0)] public User32.MOUSEINPUT mi;

				/// <summary>
				/// The information about a simulated keyboard event.
				/// This field shares memory with the <see cref="F:PInvoke.User32.INPUT.InputUnion.mi" /> and <see cref="F:PInvoke.User32.INPUT.InputUnion.hi" /> fields.
				/// </summary>
				[FieldOffset(0)] public User32.KEYBDINPUT ki;

				/// <summary>
				/// The information about a simulated hardware event.
				/// This field shares memory with the <see cref="F:PInvoke.User32.INPUT.InputUnion.mi" /> and <see cref="F:PInvoke.User32.INPUT.InputUnion.ki" /> fields.
				/// </summary>
				[FieldOffset(0)] public User32.HARDWAREINPUT hi;
			}
		}

		/// <summary>
		/// The type of the input event used by <see cref="F:PInvoke.User32.INPUT.type" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum InputType : uint {
			INPUT_MOUSE,
			INPUT_KEYBOARD,
			INPUT_HARDWARE,
		}

		/// <summary>
		/// Contains information about a simulated keyboard event.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct KEYBDINPUT {
			/// <summary>
			/// A virtual-key code. The code must be a value in the range 1 to 254. If the dwFlags member specifies KEYEVENTF_UNICODE, wVk must be 0.
			/// </summary>
			public User32.VirtualKey wVk;

			/// <summary>
			/// A hardware scan code for the key.
			/// If <see cref="F:PInvoke.User32.KEYBDINPUT.dwFlags" /> specifies <see cref="F:PInvoke.User32.KEYEVENTF.KEYEVENTF_UNICODE" />,
			/// <see cref="F:PInvoke.User32.KEYBDINPUT.wScan" /> specifies a Unicode character which is to be sent to the foreground application.
			/// </summary>
			public User32.ScanCode wScan;

			/// <summary>
			/// Specifies various aspects of a keystroke.
			/// This member can be certain combinations of the following values.
			/// </summary>
			public User32.KEYEVENTF dwFlags;

			/// <summary>
			/// The time stamp for the event, in milliseconds. If this parameter is zero, the system will provide its own time stamp.
			/// </summary>
			public uint time;

			/// <summary>
			/// An additional value associated with the keystroke.
			/// Use the GetMessageExtraInfo function to obtain this information.
			/// </summary>
			public unsafe void* dwExtraInfo;

			/// <summary>
			/// An additional value associated with the keystroke.
			/// Use the GetMessageExtraInfo function to obtain this information.
			/// </summary>
			public unsafe IntPtr dwExtraInfo_IntPtr {
				get { return new IntPtr(this.dwExtraInfo); }
				set { this.dwExtraInfo = value.ToPointer(); }
			}
		}

		/// <summary>
		/// Specifies various aspects of a keystroke. This member can be certain combinations of the following values.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum KEYEVENTF : uint {
			KEYEVENTF_EXTENDED_KEY = 1,
			KEYEVENTF_KEYUP = 2,
			KEYEVENTF_SCANCODE = 8,
			KEYEVENTF_UNICODE = 4,
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.User32.LookupIconIdFromDirectoryEx(System.Byte*,System.Boolean,System.Int32,System.Int32,PInvoke.User32.LookupIconIdFromDirectoryExFlags)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum LookupIconIdFromDirectoryExFlags {
			LR_DEFAULTCOLOR = 0,
			LR_MONOCHROME = 1,
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct LUID {
			public uint LowPart;
			public int HighPart;
		}

		/// <summary>The translation to be performed in <see cref="M:PInvoke.User32.MapVirtualKey(System.Int32,PInvoke.User32.MapVirtualKeyTranslation)" />.</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MapVirtualKeyTranslation {
			MAPVK_VK_TO_VSC,
			MAPVK_VSC_TO_VK,
			MAPVK_VK_TO_CHAR,
			MAPVK_VSC_TO_VK_EX,
		}

		/// <summary>Controls the appearance and behavior of a menu item</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MenuItemFlags {
			MF_BITMAP = 4,
			MF_CHECKED = 8,
			MF_DISABLED = 2,
			MF_ENABLED = 0,
			MF_GRAYED = 1,
			MF_MENUBARBREAK = 32, // 0x00000020
			MF_MENUBREAK = 64, // 0x00000040
			MF_OWNERDRAW = 256, // 0x00000100
			MF_POPUP = 16, // 0x00000010
			MF_SEPARATOR = 2048, // 0x00000800
			MF_STRING = 0,
			MF_UNCHECKED = 0,
			MF_BYCOMMAND = 0,
			MF_BYPOSITION = 1024, // 0x00000400
			MF_UNHILITE = 0,
			MF_HILITE = 128, // 0x00000080
			MF_END = MF_HILITE, // 0x00000080
			MF_USECHECKBITMAPS = 512, // 0x00000200
			MF_INSERT = 0,
			MF_CHANGE = MF_END, // 0x00000080
			MF_APPEND = MF_OWNERDRAW, // 0x00000100
			MF_DELETE = MF_USECHECKBITMAPS, // 0x00000200
			MF_REMOVE = 4096, // 0x00001000
			MF_DEFAULT = MF_REMOVE, // 0x00001000
			MF_SYSMENU = 8192, // 0x00002000
			MF_HELP = 16384, // 0x00004000
			MF_RIGHTJUSTIFY = MF_HELP, // 0x00004000
			MF_MOUSESELECT = 32768, // 0x00008000
		}

		/// <summary>Contains information about a menu item.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct MENUITEMINFO {
			/// <summary>The size of the structure, in bytes.</summary>
			public int cbSize;

			/// <summary>Indicates the members to be retrieved or set.</summary>
			public User32.MenuMembersMask fMask;

			/// <summary>The menu item type.</summary>
			public User32.MenuItemType fType;

			/// <summary>The menu item state.</summary>
			public User32.MenuItemState fState;

			/// <summary>
			///     An application-defined value that identifies the menu item. Set <see cref="F:PInvoke.User32.MENUITEMINFO.fMask" /> to
			///     <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_ID" /> to use <see cref="F:PInvoke.User32.MENUITEMINFO.wID" />.
			/// </summary>
			public int wID;

			/// <summary>
			///     A handle to the drop-down menu or submenu associated with the menu item. If the menu item is not an item that
			///     opens a drop-down menu or submenu, this member is <see cref="F:System.IntPtr.Zero" />. Set <see cref="F:PInvoke.User32.MENUITEMINFO.fMask" /> to
			///     <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_SUBMENU" /> to use hSubMenu.
			/// </summary>
			public IntPtr hSubMenu;

			/// <summary>
			///     A handle to the bitmap to display next to the item if it is selected. If this member is
			///     <see cref="F:System.IntPtr.Zero" />, a default bitmap is used. If the <see cref="F:PInvoke.User32.MenuItemType.MFT_RADIOCHECK" /> type value
			///     is specified, the default bitmap is a bullet. Otherwise, it is a check mark. Set fMask to
			///     <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_CHECKMARKS" /> to use <see cref="F:PInvoke.User32.MENUITEMINFO.hbmpChecked" />.
			/// </summary>
			public IntPtr hbmpChecked;

			/// <summary>
			///     A handle to the bitmap to display next to the item if it is not selected. If this member is
			///     <see cref="F:System.IntPtr.Zero" />, no bitmap is used. Set <see cref="F:PInvoke.User32.MENUITEMINFO.fMask" /> to
			///     <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_CHECKMARKS" /> to use <see cref="F:PInvoke.User32.MENUITEMINFO.hbmpUnchecked" />.
			/// </summary>
			public IntPtr hbmpUnchecked;

			/// <summary>
			///     An application-defined value associated with the menu item. Set <see cref="F:PInvoke.User32.MENUITEMINFO.fMask" /> to
			///     <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_DATA" /> to use <see cref="F:PInvoke.User32.MENUITEMINFO.dwItemData" />.
			/// </summary>
			public IntPtr dwItemData;

			/// <summary>
			///     The contents of the menu item. The meaning of this member depends on the value of fType and is used only if the
			///     MIIM_TYPE flag is set in the fMask member.
			///     <para>
			///         To retrieve a menu item of type <see cref="F:PInvoke.User32.MenuItemType.MFT_STRING" />, first find the size of the string by
			///         setting the <see cref="F:PInvoke.User32.MENUITEMINFO.dwTypeData" />
			///         member of <see cref="T:PInvoke.User32.MENUITEMINFO" /> to <see cref="F:System.IntPtr.Zero" /> and then calling
			///         <see cref="M:PInvoke.User32.GetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" />. The value of <see cref="F:PInvoke.User32.MENUITEMINFO.cch" />+1 is the size needed. Then allocate a buffer of
			///         this size, place the pointer to the buffer in dwTypeData, increment cch, and call
			///         <see cref="M:PInvoke.User32.GetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" /> once again to fill the buffer with the string. If the retrieved menu item is of
			///         some other type, then <see cref="M:PInvoke.User32.GetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" /> sets the <see cref="F:PInvoke.User32.MENUITEMINFO.dwTypeData" /> member to a value whose
			///         type is specified by the <see cref="F:PInvoke.User32.MENUITEMINFO.fType" /> member.
			///     </para>
			///     <para>
			///         When using with the <see cref="M:PInvoke.User32.SetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" /> function, this member should contain a value whose type is
			///         specified by the <see cref="F:PInvoke.User32.MENUITEMINFO.fType" /> member.
			///     </para>
			///     <para>
			///         dwTypeData is used only if the <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_STRING" /> flag is set in the
			///         <see cref="F:PInvoke.User32.MENUITEMINFO.fMask" /> member
			///     </para>
			/// </summary>
			public string dwTypeData;

			/// <summary>
			///     The length of the menu item text, in characters, when information is received about a menu item of the
			///     <see cref="F:PInvoke.User32.MenuItemType.MFT_STRING" />
			///     type. However, <see cref="F:PInvoke.User32.MENUITEMINFO.cch" /> is used only if the <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_TYPE" /> flag is set in the
			///     <see cref="F:PInvoke.User32.MENUITEMINFO.fMask" /> member and is zero otherwise. Also, <see cref="F:PInvoke.User32.MENUITEMINFO.cch" />
			///     is ignored when the content of a menu item is set by calling <see cref="M:PInvoke.User32.SetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" />.
			///     <para>
			///         Note that, before calling <see cref="M:PInvoke.User32.GetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" />, the application must set <see cref="F:PInvoke.User32.MENUITEMINFO.cch" /> to the
			///         length of the buffer pointed to by the <see cref="F:PInvoke.User32.MENUITEMINFO.dwTypeData" /> member. If the retrieved menu item is of type
			///         <see cref="F:PInvoke.User32.MenuItemType.MFT_STRING" /> (as indicated by the <see cref="F:PInvoke.User32.MENUITEMINFO.fType" />
			///         member), then <see cref="M:PInvoke.User32.GetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" /> changes <see cref="F:PInvoke.User32.MENUITEMINFO.cch" /> to the length of the menu item text. If
			///         the retrieved menu item is of some other type, <see cref="M:PInvoke.User32.GetMenuItemInfo(System.IntPtr,System.UInt32,System.Boolean,PInvoke.User32.MENUITEMINFO@)" /> sets the <see cref="F:PInvoke.User32.MENUITEMINFO.cch" /> field
			///         to zero.
			///     </para>
			///     <para>
			///         The <see cref="F:PInvoke.User32.MENUITEMINFO.cch" /> member is used when the <see cref="F:PInvoke.User32.MenuMembersMask.MIIM_STRING" /> flag is set in the
			///         <see cref="F:PInvoke.User32.MENUITEMINFO.fMask" /> member.
			///     </para>
			/// </summary>
			public int cch;

			/// <summary>
			///     A handle to the bitmap to be displayed, or it can be one of the following values :
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_CALLBACK" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_MBAR_CLOSE" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_MBAR_CLOSE_D" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_MBAR_MINIMIZE" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_MBAR_MINIMIZE_D" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_MBAR_RESTORE" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_POPUP_CLOSE" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_POPUP_MAXIMIZE" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_POPUP_MINIMIZE" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_POPUP_RESTORE" />
			///     </para>
			///     <para>
			///         <see cref="F:PInvoke.User32.HBMMENU_SYSTEM" />
			///     </para>
			/// </summary>
			public IntPtr hbmpItem;

			/// <summary>
			/// Create a new instance of <see cref="T:PInvoke.User32.MENUITEMINFO" /> with <see cref="F:PInvoke.User32.MENUITEMINFO.cbSize" /> set to the correct value.
			/// </summary>
			/// <returns>A new instance of <see cref="T:PInvoke.User32.MENUITEMINFO" /> with <see cref="F:PInvoke.User32.MENUITEMINFO.cbSize" /> set to the correct value.</returns>
			public User32.MENUITEMINFO Create() {
				return new User32.MENUITEMINFO() {
					cbSize = Marshal.SizeOf(typeof(User32.MENUITEMINFO))
				};
			}
		}

		/// <summary>The menu item state in <see cref="T:PInvoke.User32.MENUITEMINFO" />.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MenuItemState {
			MFS_CHECKED = 8,
			MFS_DEFAULT = 4096, // 0x00001000
			MFS_DISABLED = 3,
			MFS_ENABLED = 0,
			MFS_GRAYED = MFS_DISABLED, // 0x00000003
			MFS_HILITE = 128, // 0x00000080
			MFS_UNCHECKED = 0,
			MFS_UNHILITE = 0,
		}

		/// <summary>
		/// The menu item type in <see cref="T:PInvoke.User32.MENUITEMINFO" />.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MenuItemType {
			MFT_BITMAP = 4,
			MFT_MENUBARBREAK = 32, // 0x00000020
			MFT_MENUBREAK = 64, // 0x00000040
			MFT_OWNERDRAW = 256, // 0x00000100
			MFT_RADIOCHECK = 512, // 0x00000200
			MFT_RIGHTJUSTIFY = 16384, // 0x00004000
			MFT_RIGHTORDER = 8192, // 0x00002000
			MFT_SEPARATOR = 2048, // 0x00000800
			MFT_STRING = 0,
		}

		/// <summary>Indicates the members to be retrieved or set in <see cref="T:PInvoke.User32.MENUITEMINFO" />.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MenuMembersMask {
			MIIM_BITMAP = 128, // 0x00000080
			MIIM_CHECKMARKS = 8,
			MIIM_DATA = 32, // 0x00000020
			MIIM_FTYPE = 256, // 0x00000100
			MIIM_ID = 2,
			MIIM_STATE = 1,
			MIIM_STRING = 64, // 0x00000040
			MIIM_SUBMENU = 4,
			MIIM_TYPE = 16, // 0x00000010
		}

		/// <summary>
		/// Flags that define appearance and behavior of a standard message box
		/// displayed by a call to the <see cref="M:PInvoke.User32.MessageBox(System.IntPtr,System.String,System.String,PInvoke.User32.MessageBoxOptions)" /> function.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MessageBoxOptions : uint {
			MB_OK = 0,
			MB_OKCANCEL = 1,
			MB_ABORTRETRYIGNORE = 2,
			MB_YESNOCANCEL = MB_ABORTRETRYIGNORE | MB_OKCANCEL, // 0x00000003
			MB_YESNO = 4,
			MB_RETRYCANCEL = MB_YESNO | MB_OKCANCEL, // 0x00000005
			MB_CANCELTRYCONTINUE = MB_YESNO | MB_ABORTRETRYIGNORE, // 0x00000006
			MB_ICONSTOP = 16, // 0x00000010
			MB_ICONERROR = MB_ICONSTOP, // 0x00000010
			MB_ICONHAND = MB_ICONERROR, // 0x00000010
			MB_ICONQUESTION = 32, // 0x00000020
			MB_ICONWARNING = MB_ICONQUESTION | MB_ICONHAND, // 0x00000030
			MB_ICONEXCLAMATION = MB_ICONWARNING, // 0x00000030
			MB_ICONASTERISK = 64, // 0x00000040
			MB_ICONINFORMATION = MB_ICONASTERISK, // 0x00000040
			MB_USERICON = 128, // 0x00000080
			MB_DEFBUTTON1 = 0,
			MB_DEFBUTTON2 = 256, // 0x00000100
			MB_DEFBUTTON3 = 512, // 0x00000200
			MB_DEFBUTTON4 = MB_DEFBUTTON3 | MB_DEFBUTTON2, // 0x00000300
			MB_APPLMODAL = 0,
			MB_SYSTEMMODAL = 4096, // 0x00001000
			MB_TASKMODAL = 8192, // 0x00002000
			MB_HELP = 16384, // 0x00004000
			MB_NOFOCUS = 32768, // 0x00008000
			MB_SETFOREGROUND = 65536, // 0x00010000
			MB_DEFAULT_DESKTOP_ONLY = 131072, // 0x00020000
			MB_TOPMOST = 262144, // 0x00040000
			MB_RIGHT = 524288, // 0x00080000
			MB_RTLREADING = 1048576, // 0x00100000
			MB_SERVICE_NOTIFICATION = 2097152, // 0x00200000
		}

		/// <summary>
		/// Types of sounds that can be emitted by the <see cref="M:PInvoke.User32.MessageBeep(PInvoke.User32.MessageBeepType)" /> method.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MessageBeepType : uint {
			MB_OK = 0,
			MB_ICONERROR = 16, // 0x00000010
			MB_ICONHAND = 16, // 0x00000010
			MB_ICONSTOP = 16, // 0x00000010
			MB_ICONQUESTION = 32, // 0x00000020
			MB_ICONEXCLAMATION = 48, // 0x00000030
			MB_ICONWARNING = 48, // 0x00000030
			MB_ICONASTERISK = 64, // 0x00000040
			MB_ICONINFORMATION = 64, // 0x00000040
			SimpleBeep = 4294967295, // 0xFFFFFFFF
		}

		/// <summary>
		/// Represents possible values returned by the <see cref="M:PInvoke.User32.MessageBox(System.IntPtr,System.String,System.String,PInvoke.User32.MessageBoxOptions)" /> function.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MessageBoxResult : uint {
			IDOK = 1,
			IDCANCEL = 2,
			IDABORT = 3,
			IDRETRY = 4,
			IDIGNORE = 5,
			IDYES = 6,
			IDNO = 7,
			IDCLOSE = 8,
			IDHELP = 9,
			IDTRYAGAIN = 10, // 0x0000000A
			IDCONTINUE = 11, // 0x0000000B
			IDTIMEOUT = 32000, // 0x00007D00
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MONITORINFO {
			public int cbSize;
			public uint dwFlags;
			public RECT rcMonitor;
			public RECT rcWork;
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
			public unsafe fixed char DeviceName[32];

			public static User32.MONITORINFOEX Create() {
				return new User32.MONITORINFOEX() {
					cbSize = Marshal.SizeOf(typeof(User32.MONITORINFOEX))
				};
			}
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MonitorOptions : uint {
			MONITOR_DEFAULTTONULL,
			MONITOR_DEFAULTTOPRIMARY,
			MONITOR_DEFAULTTONEAREST,
		}

		/// <summary>
		/// A set of bit flags that specify various aspects of mouse motion and button clicks. The bits in this member can be any reasonable combination of the following values.
		/// </summary>
		/// <remarks>
		/// The bit flags that specify mouse button status are set to indicate changes in status, not ongoing conditions.
		/// For example, if the left mouse button is pressed and held down, MOUSEEVENTF_LEFTDOWN is set when the left button is first pressed, but not for subsequent motions.
		/// Similarly, MOUSEEVENTF_LEFTUP is set only when the button is first released.
		/// You cannot specify both the MOUSEEVENTF_WHEEL flag and either MOUSEEVENTF_XDOWN or MOUSEEVENTF_XUP flags simultaneously in the <see cref="F:PInvoke.User32.MOUSEINPUT.dwFlags" /> parameter,
		/// because they both require use of the <see cref="F:PInvoke.User32.MOUSEINPUT.mouseData" /> field.
		/// </remarks>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MOUSEEVENTF : uint {
			MOUSEEVENTF_ABSOLUTE = 32768, // 0x00008000
			MOUSEEVENTF_HWHEEL = 4096, // 0x00001000
			MOUSEEVENTF_MOVE = 1,
			MOUSEEVENTF_MOVE_NOCOALESCE = 8192, // 0x00002000
			MOUSEEVENTF_LEFTDOWN = 2,
			MOUSEEVENTF_LEFTUP = 4,
			MOUSEEVENTF_RIGHTDOWN = 8,
			MOUSEEVENTF_RIGHTUP = 16, // 0x00000010
			MOUSEEVENTF_MIDDLEDOWN = 32, // 0x00000020
			MOUSEEVENTF_MIDDLEUP = 64, // 0x00000040
			MOUSEEVENTF_VIRTUALDESK = 16384, // 0x00004000
			MOUSEEVENTF_WHEEL = 2048, // 0x00000800
			MOUSEEVENTF_XDOWN = 128, // 0x00000080
			MOUSEEVENTF_XUP = 256, // 0x00000100
		}

		/// <summary>Contains information about a simulated mouse event.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MOUSEINPUT {
			/// <summary>
			/// The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the dwFlags member. Absolute data is specified as the x coordinate of the mouse; relative data is specified as the number of pixels moved.
			/// </summary>
			public int dx;

			/// <summary>
			/// The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the dwFlags member. Absolute data is specified as the y coordinate of the mouse; relative data is specified as the number of pixels moved.
			/// </summary>
			public int dy;

			/// <summary>
			/// If dwFlags contains <see cref="F:PInvoke.User32.MOUSEEVENTF.MOUSEEVENTF_WHEEL" />, then <see cref="F:PInvoke.User32.MOUSEINPUT.mouseData" /> specifies the amount of wheel movement. A positive value indicates that the wheel was rotated forward, away from the user; a negative value indicates that the wheel was rotated backward, toward the user. One wheel click is defined as <see cref="F:PInvoke.User32.WHEEL_DELTA" />, which is 120.
			/// If dwFlags does not contain <see cref="F:PInvoke.User32.MOUSEEVENTF.MOUSEEVENTF_WHEEL" />, <see cref="F:PInvoke.User32.MOUSEEVENTF.MOUSEEVENTF_XDOWN" />, or <see cref="F:PInvoke.User32.MOUSEEVENTF.MOUSEEVENTF_XUP" />, then mouseData should be zero.
			/// If dwFlags contains <see cref="F:PInvoke.User32.MOUSEEVENTF.MOUSEEVENTF_XDOWN" /> or <see cref="F:PInvoke.User32.MOUSEEVENTF.MOUSEEVENTF_XUP" />, then mouseData specifies which X buttons were pressed or released.
			/// </summary>
			public uint mouseData;

			/// <summary>
			/// A set of bit flags that specify various aspects of mouse motion and button clicks. The bits in this member can be any reasonable combination of the following values.
			/// See MSDN docs for more info.
			/// </summary>
			public User32.MOUSEEVENTF dwFlags;

			/// <summary>
			/// The time stamp for the event, in milliseconds. If this parameter is 0, the system will provide its own time stamp.
			/// </summary>
			public uint time;

			/// <summary>
			/// An additional value associated with the mouse event. An application calls GetMessageExtraInfo to obtain this extra information.
			/// </summary>
			public unsafe void* dwExtraInfo;

			/// <summary>
			/// An additional value associated with the mouse event. An application calls GetMessageExtraInfo to obtain this extra information.
			/// </summary>
			public unsafe IntPtr dwExtraInfo_IntPtr {
				get { return new IntPtr(this.dwExtraInfo); }
				set { this.dwExtraInfo = value.ToPointer(); }
			}
		}

		/// <summary>
		/// Controls various aspects of mouse motion and button clicking.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum mouse_eventFlags : uint {
			MOUSEEVENTF_ABSOLUTE = 32768, // 0x00008000
			MOUSEEVENTF_LEFTDOWN = 2,
			MOUSEEVENTF_LEFTUP = 4,
			MOUSEEVENTF_MIDDLEDOWN = 32, // 0x00000020
			MOUSEEVENTF_MIDDLEUP = 64, // 0x00000040
			MOUSEEVENTF_MOVE = 1,
			MOUSEEVENTF_RIGHTDOWN = 8,
			MOUSEEVENTF_RIGHTUP = 16, // 0x00000010
			MOUSEEVENTF_WHEEL = 2048, // 0x00000800
			MOUSEEVENTF_XDOWN = 128, // 0x00000080
			MOUSEEVENTF_XUP = 256, // 0x00000100
			MOUSEEVENTF_HWHEEL = 4096, // 0x00001000
		}

		/// <summary>
		/// Contains message information from a thread's message queue.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MSG {
			/// <summary>
			/// A handle to the window whose window procedure receives the message. This member is <see cref="F:System.IntPtr.Zero" /> when
			/// the message is a thread message.
			/// </summary>
			public IntPtr hwnd;

			/// <summary>
			/// The message identifier. Applications can only use the low word; the high word is reserved by the system.
			/// </summary>
			public User32.WindowMessage message;

			/// <summary>
			/// Additional information about the message. The exact meaning depends on the value of the message member.
			/// </summary>
			public IntPtr wParam;

			/// <summary>
			/// Additional information about the message. The exact meaning depends on the value of the message member.
			/// </summary>
			public IntPtr lParam;

			/// <summary>The time at which the message was posted.</summary>
			public int time;

			/// <summary>
			/// The cursor position, in screen coordinates, when the message was posted.
			/// </summary>
			public POINT pt;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MSGBOXPARAMS {
			public int cbSize;
			public IntPtr hwndOwner;
			public IntPtr hInstance;
			public unsafe char* lpszText;
			public unsafe char* lpszCaption;
			public uint dwStyle;
			public IntPtr lpszIcon;
			public IntPtr dwContextHelpId;
			[MarshalAs(UnmanagedType.FunctionPtr)] public User32.MSGBOXCALLBACK lpfnMsgBoxCallback;
			public uint dwLanguageId;

			public static User32.MSGBOXPARAMS Create() {
				return new User32.MSGBOXPARAMS() {
					cbSize = Marshal.SizeOf(typeof(User32.MSGBOXPARAMS))
				};
			}
		}

		/// <summary>
		/// The information to be retrieved by <see cref="M:PInvoke.User32.GetUserObjectInformation(System.IntPtr,PInvoke.User32.ObjectInformationType,System.Void*,System.UInt32,System.UInt32*)" />
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ObjectInformationType {
			UOI_FLAGS = 1,
			UOI_NAME = 2,
			UOI_TYPE = 3,
			UOI_USER_SID = 4,
			UOI_HEAPSIZE = 5,
			UOI_IO = 6,
		}

		/// <summary>
		///  Contains information for an application. This information can be used to paint the client area of a window owned by that application.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct PAINTSTRUCT {
			/// <summary>A handle to the display DC to be used for painting.</summary>
			public IntPtr hdc;

			/// <summary>
			/// Indicates whether the background must be erased. This value is nonzero if the application should erase the background.
			/// The application is responsible for erasing the background if a window class is created without a background brush.
			/// For more information, see the description of the <see cref="F:PInvoke.User32.WNDCLASS.hbrBackground" /> member.
			/// </summary>
			[MarshalAs(UnmanagedType.Bool)] public bool fErase;

			/// <summary>
			/// A <see cref="T:PInvoke.RECT" /> structure that specifies the upper left and lower right corners of the rectangle in which the painting is requested,
			/// in device units relative to the upper-left corner of the client area.
			/// </summary>
			public RECT rcPaint;

			/// <summary>Reserved; used internally by the system.</summary>
			[MarshalAs(UnmanagedType.Bool)] public bool fRestore;

			/// <summary>Reserved; used internally by the system.</summary>
			[MarshalAs(UnmanagedType.Bool)] public bool fIncUpdate;

			/// <summary>Reserved; used internally by the system.</summary>
			public unsafe fixed byte rgbReserved[32];
		}

		/// <summary>Specifies how messages are to be handled.</summary>
		/// <remarks>By default, all message types are processed. To specify that only certain message should be processed, specify one or more of the PM_QS_* values.</remarks>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum PeekMessageParams : uint {
			PM_NOREMOVE = 0,
			PM_REMOVE = 1,
			PM_NOYIELD = 2,
			PM_QS_INPUT = 67567616, // 0x04070000
			PM_QS_PAINT = 2097152, // 0x00200000
			PM_QS_POSTMESSAGE = 9961472, // 0x00980000
			PM_QS_SENDMESSAGE = 4194304, // 0x00400000
		}

		/// <summary>
		/// Flags to be passed to the <code>wRemoveMsg</code> parameter of
		/// <see cref="M:PInvoke.User32.PeekMessage(System.IntPtr,System.IntPtr,PInvoke.User32.WindowMessage,PInvoke.User32.WindowMessage,PInvoke.User32.PeekMessageRemoveFlags)" />
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum PeekMessageRemoveFlags : uint {
			PM_NOREMOVE = 0,
			PM_REMOVE = 1,
			PM_NOYIELD = 2,
			PM_QS_INPUT = 67567616, // 0x04070000
			PM_QS_PAINT = 2097152, // 0x00200000
			PM_QS_POSTMESSAGE = 9961472, // 0x00980000
			PM_QS_SENDMESSAGE = 4194304, // 0x00400000
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum PrintWindowFlags : uint {
			PW_FULLWINDOW,
			PW_CLIENTONLY,
		}

		/// <summary>The types of messages for which to check.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum QueueStatusFlags : uint {
			QS_ALLEVENTS = 1215, // 0x000004BF
			QS_ALLINPUT = 1279, // 0x000004FF
			QS_ALLPOSTMESSAGE = 256, // 0x00000100
			QS_HOTKEY = 128, // 0x00000080
			QS_INPUT = 1031, // 0x00000407
			QS_KEY = 1,
			QS_MOUSE = 6,
			QS_MOUSEBUTTON = 4,
			QS_MOUSEMOVE = 2,
			QS_PAINT = 32, // 0x00000020
			QS_POSTMESSAGE = 8,
			QS_RAWINPUT = 1024, // 0x00000400
			QS_SENDMESSAGE = 64, // 0x00000040
			QS_TIMER = 16, // 0x00000010
		}

		/// <summary>A SafeHandle to track DC handles.</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeDCHandle : SafeHandle {
			/// <summary>A null handle.</summary>
			public static readonly User32.SafeDCHandle Null = new User32.SafeDCHandle(IntPtr.Zero, IntPtr.Zero, true);

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeDCHandle" /> class.
			/// </summary>
			/// <param name="hWnd">The HWND this handle is associated with and must be released with.</param>
			/// <param name="hDC">The handle to the DC.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeDCHandle(IntPtr hWnd, IntPtr hDC, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.HWnd = hWnd;
				this.SetHandle(hDC);
			}

			/// <summary>Gets the HWND this handle is associated with.</summary>
			public IntPtr HWnd { get; }

			/// <inheritdoc />
			public override bool IsInvalid {
				get { return this.handle == IntPtr.Zero; }
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return User32.ReleaseDC(this.HWnd, this.handle) == 1;
			}
		}

		/// <summary>
		/// Represents a Desktop handle that can be closed with <see cref="M:PInvoke.User32.CloseDesktop(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeDesktopHandle : SafeHandle {
			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly User32.SafeDesktopHandle Null = new User32.SafeDesktopHandle(IntPtr.Zero, false);

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeDesktopHandle" /> class.
			/// </summary>
			public SafeDesktopHandle()
				: base(IntPtr.Zero, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeDesktopHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeDesktopHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			public override bool IsInvalid {
				get { return this.handle == IntPtr.Zero; }
			}

			protected override bool ReleaseHandle() {
				return User32.CloseDesktop(this.handle);
			}
		}

		/// <summary>
		/// Represents a windows event Hook that can be removed with <see cref="M:PInvoke.User32.UnhookWinEvent(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeEventHookHandle : SafeHandle {
			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly User32.SafeEventHookHandle Null = new User32.SafeEventHookHandle();

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeEventHookHandle" /> class.
			/// </summary>
			public SafeEventHookHandle()
				: base(IntPtr.Zero, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeEventHookHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeEventHookHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			/// <inheritdoc />
			public override bool IsInvalid {
				get { return this.handle == IntPtr.Zero; }
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return User32.UnhookWinEvent(this.handle);
			}
		}

		/// <summary>
		/// Represents a windows Hook that can be removed with <see cref="M:PInvoke.User32.UnhookWindowsHookEx(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeHookHandle : SafeHandle {
			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly User32.SafeHookHandle Null = new User32.SafeHookHandle();

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeHookHandle" /> class.
			/// </summary>
			public SafeHookHandle()
				: base(IntPtr.Zero, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeHookHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeHookHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			/// <inheritdoc />
			public override bool IsInvalid {
				get { return this.handle == IntPtr.Zero; }
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return User32.UnhookWindowsHookEx(this.handle);
			}
		}

		/// <summary>
		/// Represents a Desktop handle that can be closed with <see cref="M:PInvoke.User32.CloseWindowStation(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeWindowStationHandle : SafeHandle {
			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly User32.SafeWindowStationHandle Null =
				new User32.SafeWindowStationHandle(IntPtr.Zero, false);

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeWindowStationHandle" /> class.
			/// </summary>
			public SafeWindowStationHandle()
				: base(IntPtr.Zero, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.User32.SafeWindowStationHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeWindowStationHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			public override bool IsInvalid {
				get { return this.handle == IntPtr.Zero; }
			}

			protected override bool ReleaseHandle() {
				return User32.CloseWindowStation(this.handle);
			}
		}

		/// <summary>
		/// General keyboard scan code constants on the same order that it can be found on <see cref="T:PInvoke.User32.VirtualKey" /> constants
		/// </summary>
		/// <remarks>Scan codes are device-dependant values, these are general values used by most keyboards.</remarks>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ScanCode : ushort {
			NONAME = 0,
			ESCAPE = 1,
			KEY_1 = 2,
			KEY_2 = 3,
			KEY_3 = 4,
			KEY_4 = 5,
			KEY_5 = 6,
			KEY_6 = 7,
			KEY_7 = 8,
			KEY_8 = 9,
			KEY_9 = 10, // 0x000A
			KEY_0 = 11, // 0x000B
			OEM_MINUS = 12, // 0x000C
			OEM_PLUS = 13, // 0x000D
			BACK = 14, // 0x000E
			TAB = 15, // 0x000F
			KEY_Q = 16, // 0x0010
			MEDIA_PREV_TRACK = 16, // 0x0010
			KEY_W = 17, // 0x0011
			KEY_E = 18, // 0x0012
			KEY_R = 19, // 0x0013
			KEY_T = 20, // 0x0014
			KEY_Y = 21, // 0x0015
			KEY_U = 22, // 0x0016
			KEY_I = 23, // 0x0017
			KEY_O = 24, // 0x0018
			KEY_P = 25, // 0x0019
			MEDIA_NEXT_TRACK = 25, // 0x0019
			OEM_4 = 26, // 0x001A
			OEM_6 = 27, // 0x001B
			RETURN = 28, // 0x001C
			CONTROL = 29, // 0x001D
			LCONTROL = 29, // 0x001D
			RCONTROL = 29, // 0x001D
			KEY_A = 30, // 0x001E
			KEY_S = 31, // 0x001F
			KEY_D = 32, // 0x0020
			VOLUME_MUTE = 32, // 0x0020
			KEY_F = 33, // 0x0021
			LAUNCH_APP2 = 33, // 0x0021
			KEY_G = 34, // 0x0022
			MEDIA_PLAY_PAUSE = 34, // 0x0022
			KEY_H = 35, // 0x0023
			KEY_J = 36, // 0x0024
			MEDIA_STOP = 36, // 0x0024
			KEY_K = 37, // 0x0025
			KEY_L = 38, // 0x0026
			OEM_1 = 39, // 0x0027
			OEM_7 = 40, // 0x0028
			OEM_3 = 41, // 0x0029
			LSHIFT = 42, // 0x002A
			SHIFT = 42, // 0x002A
			OEM_5 = 43, // 0x002B
			KEY_Z = 44, // 0x002C
			KEY_X = 45, // 0x002D
			KEY_C = 46, // 0x002E
			VOLUME_DOWN = 46, // 0x002E
			KEY_V = 47, // 0x002F
			KEY_B = 48, // 0x0030
			VOLUME_UP = 48, // 0x0030
			KEY_N = 49, // 0x0031
			BROWSER_HOME = 50, // 0x0032
			KEY_M = 50, // 0x0032
			OEM_COMMA = 51, // 0x0033
			OEM_PERIOD = 52, // 0x0034
			DIVIDE = 53, // 0x0035
			OEM_2 = 53, // 0x0035
			RSHIFT = 54, // 0x0036
			MULTIPLY = 55, // 0x0037
			LMENU = 56, // 0x0038
			MENU = 56, // 0x0038
			RMENU = 56, // 0x0038
			SPACE = 57, // 0x0039
			CAPITAL = 58, // 0x003A
			F1 = 59, // 0x003B
			F2 = 60, // 0x003C
			F3 = 61, // 0x003D
			F4 = 62, // 0x003E
			F5 = 63, // 0x003F
			F6 = 64, // 0x0040
			F7 = 65, // 0x0041
			F8 = 66, // 0x0042
			F9 = 67, // 0x0043
			F10 = 68, // 0x0044
			NUMLOCK = 69, // 0x0045
			CANCEL = 70, // 0x0046
			SCROLL = 70, // 0x0046
			HOME = 71, // 0x0047
			NUMPAD7 = 71, // 0x0047
			NUMPAD8 = 72, // 0x0048
			UP = 72, // 0x0048
			NUMPAD9 = 73, // 0x0049
			PRIOR = 73, // 0x0049
			SUBTRACT = 74, // 0x004A
			LEFT = 75, // 0x004B
			NUMPAD4 = 75, // 0x004B
			CLEAR = 76, // 0x004C
			NUMPAD5 = 76, // 0x004C
			NUMPAD6 = 77, // 0x004D
			RIGHT = 77, // 0x004D
			ADD = 78, // 0x004E
			END = 79, // 0x004F
			NUMPAD1 = 79, // 0x004F
			DOWN = 80, // 0x0050
			NUMPAD2 = 80, // 0x0050
			NEXT = 81, // 0x0051
			NUMPAD3 = 81, // 0x0051
			INSERT = 82, // 0x0052
			NUMPAD0 = 82, // 0x0052
			DECIMAL = 83, // 0x0053
			DELETE = 83, // 0x0053
			SNAPSHOT = 84, // 0x0054
			OEM_102 = 86, // 0x0056
			F11 = 87, // 0x0057
			F12 = 88, // 0x0058
			LWIN = 91, // 0x005B
			RWIN = 92, // 0x005C
			APPS = 93, // 0x005D
			EREOF = 93, // 0x005D
			SLEEP = 95, // 0x005F
			ZOOM = 98, // 0x0062
			HELP = 99, // 0x0063
			F13 = 100, // 0x0064
			BROWSER_SEARCH = 101, // 0x0065
			F14 = 101, // 0x0065
			BROWSER_FAVORITES = 102, // 0x0066
			F15 = 102, // 0x0066
			BROWSER_REFRESH = 103, // 0x0067
			F16 = 103, // 0x0067
			BROWSER_STOP = 104, // 0x0068
			F17 = 104, // 0x0068
			BROWSER_FORWARD = 105, // 0x0069
			F18 = 105, // 0x0069
			BROWSER_BACK = 106, // 0x006A
			F19 = 106, // 0x006A
			F20 = 107, // 0x006B
			LAUNCH_APP1 = 107, // 0x006B
			F21 = 108, // 0x006C
			LAUNCH_MAIL = 108, // 0x006C
			F22 = 109, // 0x006D
			LAUNCH_MEDIA_SELECT = 109, // 0x006D
			F23 = 110, // 0x006E
			F24 = 118, // 0x0076
		}

		/// <summary>
		/// Possible flag values for <see cref="M:PInvoke.User32.SendMessageTimeout(System.IntPtr,PInvoke.User32.WindowMessage,System.IntPtr,System.IntPtr,PInvoke.User32.SendMessageTimeoutFlags,System.Int32,System.IntPtr@)" />
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum SendMessageTimeoutFlags {
			SMTO_NORMAL = 0,
			SMTO_BLOCK = 1,
			SMTO_ABORTIFHUNG = 2,
			SMTO_NOTIMEOUTIFNOTHUNG = 8,
			SMTO_ERRORONEXIT = 32, // 0x00000020
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		/// <summary>Special window handles</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public static class SpecialWindowHandles {
			/// <summary>Places the window at the top of the Z order.</summary>
			public static readonly IntPtr HWND_TOP = new IntPtr(0);

			/// <summary>
			/// Places the window at the bottom of the Z order. If the hWnd parameter identifies a
			/// topmost window, the window loses its topmost status and is placed at the bottom of all
			/// other windows.
			/// </summary>
			public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

			/// <summary>
			/// Places the window above all non-topmost windows. The window maintains its topmost
			/// position even when it is deactivated.
			/// </summary>
			public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

			/// <summary>
			/// Places the window above all non-topmost windows (that is, behind all topmost windows).
			/// This flag has no effect if the window is already a non-topmost window.
			/// </summary>
			public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
		}

		/// <summary>
		/// wParam options for <see cref="F:PInvoke.User32.WindowMessage.WM_SYSCOMMAND" />
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		/// <summary>
		/// Flags used in the <see cref="M:PInvoke.User32.GetSystemMetrics(PInvoke.User32.SystemMetric)" /> function
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		/// <summary>
		/// Used to inform the <see cref="M:PInvoke.User32.SystemParametersInfo(PInvoke.User32.SystemParametersInfoAction,System.UInt32,System.Void*,PInvoke.User32.SystemParametersInfoFlags)" /> function of the action to be executed
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum SystemParametersInfoAction : uint {
			SPI_GETBEEP = 1,
			SPI_SETBEEP = 2,
			SPI_GETMOUSE = 3,
			SPI_SETMOUSE = 4,
			SPI_GETBORDER = 5,
			SPI_SETBORDER = 6,
			SPI_GETKEYBOARDSPEED = 10, // 0x0000000A
			SPI_SETKEYBOARDSPEED = 11, // 0x0000000B
			SPI_LANGDRIVER = 12, // 0x0000000C
			SPI_ICONHORIZONTALSPACING = 13, // 0x0000000D
			SPI_GETSCREENSAVETIMEOUT = 14, // 0x0000000E
			SPI_SETSCREENSAVETIMEOUT = 15, // 0x0000000F
			SPI_GETSCREENSAVEACTIVE = 16, // 0x00000010
			SPI_SETSCREENSAVEACTIVE = 17, // 0x00000011
			SPI_GETGRIDGRANULARITY = 18, // 0x00000012
			SPI_SETGRIDGRANULARITY = 19, // 0x00000013
			SPI_SETDESKWALLPAPER = 20, // 0x00000014
			SPI_SETDESKPATTERN = 21, // 0x00000015
			SPI_GETKEYBOARDDELAY = 22, // 0x00000016
			SPI_SETKEYBOARDDELAY = 23, // 0x00000017
			SPI_ICONVERTICALSPACING = 24, // 0x00000018
			SPI_GETICONTITLEWRAP = 25, // 0x00000019
			SPI_SETICONTITLEWRAP = 26, // 0x0000001A
			SPI_GETMENUDROPALIGNMENT = 27, // 0x0000001B
			SPI_SETMENUDROPALIGNMENT = 28, // 0x0000001C
			SPI_SETDOUBLECLKWIDTH = 29, // 0x0000001D
			SPI_SETDOUBLECLKHEIGHT = 30, // 0x0000001E
			SPI_GETICONTITLELOGFONT = 31, // 0x0000001F
			SPI_SETDOUBLECLICKTIME = 32, // 0x00000020
			SPI_SETMOUSEBUTTONSWAP = 33, // 0x00000021
			SPI_SETICONTITLELOGFONT = 34, // 0x00000022
			SPI_GETFASTTASKSWITCH = 35, // 0x00000023
			SPI_SETFASTTASKSWITCH = 36, // 0x00000024
			SPI_SETDRAGFULLWINDOWS = 37, // 0x00000025
			SPI_GETDRAGFULLWINDOWS = 38, // 0x00000026
			SPI_GETNONCLIENTMETRICS = 41, // 0x00000029
			SPI_SETNONCLIENTMETRICS = 42, // 0x0000002A
			SPI_GETMINIMIZEDMETRICS = 43, // 0x0000002B
			SPI_SETMINIMIZEDMETRICS = 44, // 0x0000002C
			SPI_GETICONMETRICS = 45, // 0x0000002D
			SPI_SETICONMETRICS = 46, // 0x0000002E
			SPI_SETWORKAREA = 47, // 0x0000002F
			SPI_GETWORKAREA = 48, // 0x00000030
			SPI_SETPENWINDOWS = 49, // 0x00000031
			SPI_GETFILTERKEYS = 50, // 0x00000032
			SPI_SETFILTERKEYS = 51, // 0x00000033
			SPI_GETTOGGLEKEYS = 52, // 0x00000034
			SPI_SETTOGGLEKEYS = 53, // 0x00000035
			SPI_GETMOUSEKEYS = 54, // 0x00000036
			SPI_SETMOUSEKEYS = 55, // 0x00000037
			SPI_GETSHOWSOUNDS = 56, // 0x00000038
			SPI_SETSHOWSOUNDS = 57, // 0x00000039
			SPI_GETSTICKYKEYS = 58, // 0x0000003A
			SPI_SETSTICKYKEYS = 59, // 0x0000003B
			SPI_GETACCESSTIMEOUT = 60, // 0x0000003C
			SPI_SETACCESSTIMEOUT = 61, // 0x0000003D
			SPI_GETSERIALKEYS = 62, // 0x0000003E
			SPI_SETSERIALKEYS = 63, // 0x0000003F
			SPI_GETSOUNDSENTRY = 64, // 0x00000040
			SPI_SETSOUNDSENTRY = 65, // 0x00000041
			SPI_GETHIGHCONTRAST = 66, // 0x00000042
			SPI_SETHIGHCONTRAST = 67, // 0x00000043
			SPI_GETKEYBOARDPREF = 68, // 0x00000044
			SPI_SETKEYBOARDPREF = 69, // 0x00000045
			SPI_GETSCREENREADER = 70, // 0x00000046
			SPI_SETSCREENREADER = 71, // 0x00000047
			SPI_GETANIMATION = 72, // 0x00000048
			SPI_SETANIMATION = 73, // 0x00000049
			SPI_GETFONTSMOOTHING = 74, // 0x0000004A
			SPI_SETFONTSMOOTHING = 75, // 0x0000004B
			SPI_SETDRAGWIDTH = 76, // 0x0000004C
			SPI_SETDRAGHEIGHT = 77, // 0x0000004D
			SPI_SETHANDHELD = 78, // 0x0000004E
			SPI_GETLOWPOWERTIMEOUT = 79, // 0x0000004F
			SPI_GETPOWEROFFTIMEOUT = 80, // 0x00000050
			SPI_SETLOWPOWERTIMEOUT = 81, // 0x00000051
			SPI_SETPOWEROFFTIMEOUT = 82, // 0x00000052
			SPI_GETLOWPOWERACTIVE = 83, // 0x00000053
			SPI_GETPOWEROFFACTIVE = 84, // 0x00000054
			SPI_SETLOWPOWERACTIVE = 85, // 0x00000055
			SPI_SETPOWEROFFACTIVE = 86, // 0x00000056
			SPI_SETCURSORS = 87, // 0x00000057
			SPI_SETICONS = 88, // 0x00000058
			SPI_GETDEFAULTINPUTLANG = 89, // 0x00000059
			SPI_SETDEFAULTINPUTLANG = 90, // 0x0000005A
			SPI_SETLANGTOGGLE = 91, // 0x0000005B
			SPI_GETWINDOWSEXTENSION = 92, // 0x0000005C
			SPI_SETMOUSETRAILS = 93, // 0x0000005D
			SPI_GETMOUSETRAILS = 94, // 0x0000005E
			SPI_SETSNAPTODEFBUTTON = 96, // 0x00000060
			SPI_SCREENSAVERRUNNING = 97, // 0x00000061
			SPI_SETSCREENSAVERRUNNING = 97, // 0x00000061
			SPI_GETMOUSEHOVERWIDTH = 98, // 0x00000062
			SPI_SETMOUSEHOVERWIDTH = 99, // 0x00000063
			SPI_GETMOUSEHOVERHEIGHT = 100, // 0x00000064
			SPI_SETMOUSEHOVERHEIGHT = 101, // 0x00000065
			SPI_GETMOUSEHOVERTIME = 102, // 0x00000066
			SPI_SETMOUSEHOVERTIME = 103, // 0x00000067
			SPI_GETWHEELSCROLLLINES = 104, // 0x00000068
			SPI_SETWHEELSCROLLLINES = 105, // 0x00000069
			SPI_GETMENUSHOWDELAY = 106, // 0x0000006A
			SPI_SETMENUSHOWDELAY = 107, // 0x0000006B
			SPI_GETSHOWIMEUI = 110, // 0x0000006E
			SPI_SETSHOWIMEUI = 111, // 0x0000006F
			SPI_GETMOUSESPEED = 112, // 0x00000070
			SPI_SETMOUSESPEED = 113, // 0x00000071
			SPI_GETSCREENSAVERRUNNING = 114, // 0x00000072
			SPI_GETDESKWALLPAPER = 115, // 0x00000073
			SPI_GETACTIVEWINDOWTRACKING = 4096, // 0x00001000
			SPI_SETACTIVEWINDOWTRACKING = 4097, // 0x00001001
			SPI_GETMENUANIMATION = 4098, // 0x00001002
			SPI_SETMENUANIMATION = 4099, // 0x00001003
			SPI_GETCOMBOBOXANIMATION = 4100, // 0x00001004
			SPI_SETCOMBOBOXANIMATION = 4101, // 0x00001005
			SPI_GETLISTBOXSMOOTHSCROLLING = 4102, // 0x00001006
			SPI_SETLISTBOXSMOOTHSCROLLING = 4103, // 0x00001007
			SPI_GETGRADIENTCAPTIONS = 4104, // 0x00001008
			SPI_SETGRADIENTCAPTIONS = 4105, // 0x00001009
			SPI_GETKEYBOARDCUES = 4106, // 0x0000100A
			SPI_GETMENUUNDERLINES = 4106, // 0x0000100A
			SPI_SETKEYBOARDCUES = 4107, // 0x0000100B
			SPI_SETMENUUNDERLINES = 4107, // 0x0000100B
			SPI_GETACTIVEWNDTRKZORDER = 4108, // 0x0000100C
			SPI_SETACTIVEWNDTRKZORDER = 4109, // 0x0000100D
			SPI_GETHOTTRACKING = 4110, // 0x0000100E
			SPI_SETHOTTRACKING = 4111, // 0x0000100F
			SPI_GETMENUFADE = 4114, // 0x00001012
			SPI_SETMENUFADE = 4115, // 0x00001013
			SPI_GETSELECTIONFADE = 4116, // 0x00001014
			SPI_SETSELECTIONFADE = 4117, // 0x00001015
			SPI_GETTOOLTIPANIMATION = 4118, // 0x00001016
			SPI_SETTOOLTIPANIMATION = 4119, // 0x00001017
			SPI_GETTOOLTIPFADE = 4120, // 0x00001018
			SPI_SETTOOLTIPFADE = 4121, // 0x00001019
			SPI_GETCURSORSHADOW = 4122, // 0x0000101A
			SPI_SETCURSORSHADOW = 4123, // 0x0000101B
			SPI_GETMOUSESONAR = 4124, // 0x0000101C
			SPI_SETMOUSESONAR = 4125, // 0x0000101D
			SPI_GETMOUSECLICKLOCK = 4126, // 0x0000101E
			SPI_SETMOUSECLICKLOCK = 4127, // 0x0000101F
			SPI_GETMOUSEVANISH = 4128, // 0x00001020
			SPI_SETMOUSEVANISH = 4129, // 0x00001021
			SPI_GETFLATMENU = 4130, // 0x00001022
			SPI_SETFLATMENU = 4131, // 0x00001023
			SPI_GETDROPSHADOW = 4132, // 0x00001024
			SPI_SETDROPSHADOW = 4133, // 0x00001025
			SPI_GETBLOCKSENDINPUTRESETS = 4134, // 0x00001026
			SPI_SETBLOCKSENDINPUTRESETS = 4135, // 0x00001027
			SPI_GETUIEFFECTS = 4158, // 0x0000103E
			SPI_SETUIEFFECTS = 4159, // 0x0000103F
			SPI_GETFOREGROUNDLOCKTIMEOUT = 8192, // 0x00002000
			SPI_SETFOREGROUNDLOCKTIMEOUT = 8193, // 0x00002001
			SPI_GETACTIVEWNDTRKTIMEOUT = 8194, // 0x00002002
			SPI_SETACTIVEWNDTRKTIMEOUT = 8195, // 0x00002003
			SPI_GETFOREGROUNDFLASHCOUNT = 8196, // 0x00002004
			SPI_SETFOREGROUNDFLASHCOUNT = 8197, // 0x00002005
			SPI_GETCARETWIDTH = 8198, // 0x00002006
			SPI_SETCARETWIDTH = 8199, // 0x00002007
			SPI_GETMOUSECLICKLOCKTIME = 8200, // 0x00002008
			SPI_SETMOUSECLICKLOCKTIME = 8201, // 0x00002009
			SPI_GETFONTSMOOTHINGTYPE = 8202, // 0x0000200A
			SPI_SETFONTSMOOTHINGTYPE = 8203, // 0x0000200B
			SPI_GETFONTSMOOTHINGCONTRAST = 8204, // 0x0000200C
			SPI_SETFONTSMOOTHINGCONTRAST = 8205, // 0x0000200D
			SPI_GETFOCUSBORDERWIDTH = 8206, // 0x0000200E
			SPI_SETFOCUSBORDERWIDTH = 8207, // 0x0000200F
			SPI_GETFOCUSBORDERHEIGHT = 8208, // 0x00002010
			SPI_SETFOCUSBORDERHEIGHT = 8209, // 0x00002011
			SPI_GETFONTSMOOTHINGORIENTATION = 8210, // 0x00002012
			SPI_SETFONTSMOOTHINGORIENTATION = 8211, // 0x00002013
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum SystemParametersInfoFlags {
			None = 0,
			SPIF_UPDATEINIFILE = 1,
			SPIF_SENDCHANGE = 2,
			SPIF_SENDWININICHANGE = SPIF_SENDCHANGE, // 0x00000002
		}

		/// <summary>
		/// Values to pass to the <see cref="M:PInvoke.User32.DrawText(PInvoke.User32.SafeDCHandle,System.Char*,System.Int32,PInvoke.RECT*,PInvoke.User32.TextFormats)" /> method describing format the text.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum TextFormats : uint {
			DT_TOP = 0,
			DT_LEFT = 0,
			DT_CENTER = 1,
			DT_RIGHT = 2,
			DT_VCENTER = 4,
			DT_BOTTOM = 8,
			DT_WORDBREAK = 16, // 0x00000010
			DT_SINGLELINE = 32, // 0x00000020
			DT_EXPANDTABS = 64, // 0x00000040
			DT_TABSTOP = 128, // 0x00000080
			TABSTOP_1CHAR = 256, // 0x00000100
			TABSTOP_2CHAR = 512, // 0x00000200
			TABSTOP_4CHAR = 1024, // 0x00000400
			TABSTOP_8CHAR = 2048, // 0x00000800
			TABSTOP_16CHAR = 4096, // 0x00001000
			TABSTOP_32CHAR = 8192, // 0x00002000
			TABSTOP_64CHAR = 16384, // 0x00004000
			TABSTOP_128CHAR = 32768, // 0x00008000
			DT_NOCLIP = TABSTOP_1CHAR, // 0x00000100
			DT_EXTERNALLEADING = TABSTOP_2CHAR, // 0x00000200
			DT_CALCRECT = TABSTOP_4CHAR, // 0x00000400
			DT_NOPREFIX = TABSTOP_8CHAR, // 0x00000800
			DT_INTERNAL = TABSTOP_16CHAR, // 0x00001000
			DT_EDITCONTROL = TABSTOP_32CHAR, // 0x00002000
			DT_PATH_ELLIPSIS = TABSTOP_64CHAR, // 0x00004000
			DT_END_ELLIPSIS = TABSTOP_128CHAR, // 0x00008000
			DT_MODIFYSTRING = 65536, // 0x00010000
			DT_RTLREADING = 131072, // 0x00020000
			DT_WORD_ELLIPSIS = 262144, // 0x00040000
			DT_NOFULLWIDTHCHARBREAK = 524288, // 0x00080000
			DT_HIDEPREFIX = 1048576, // 0x00100000
			DT_PREFIXONLY = 2097152, // 0x00200000
		}

		/// <summary>
		/// Contains information about a window station or desktop handle.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct USEROBJECTFLAGS {
			/// <summary>
			/// If this member is TRUE, new processes inherit the handle. Otherwise, the handle is not inherited.
			/// </summary>
			[MarshalAs(UnmanagedType.Bool)] public bool fInherit;

			/// <summary>Reserved for future use. This member must be FALSE.</summary>
			[MarshalAs(UnmanagedType.Bool)] public bool fReserved;

			/// <summary>Flags indicating object specific characteristics</summary>
			public User32.UserObjectFlagsEnum dwFlags;
		}

		/// <summary>Flags indicating user object specific characteristics</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum UserObjectFlagsEnum : uint {
			None = 0,
			DF_ALLOWOTHERACCOUNTHOOK = 1,
			WSF_VISIBLE = 1,
		}

		/// <summary>Virtual-key codes</summary>
		/// <remarks>Defined in winuser.h from Windows SDK v6.1</remarks>
		/// <devremarks>
		/// APIs vary in the length they expect a parameter for virtual keys to be.
		/// Be sure to type the parameter as byte, ushort, or int as appropriate and document
		/// that the user should get the value from this enum and cast the result to ensure
		/// the method signature is compatible.
		/// </devremarks>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum VirtualKey : ushort {
			VK_NO_KEY = 0,
			VK_LBUTTON = 1,
			VK_RBUTTON = 2,
			VK_CANCEL = 3,
			VK_MBUTTON = 4,
			VK_XBUTTON1 = 5,
			VK_XBUTTON2 = 6,
			VK_BACK = 8,
			VK_TAB = 9,
			VK_CLEAR = 12, // 0x000C
			VK_RETURN = 13, // 0x000D
			VK_SHIFT = 16, // 0x0010
			VK_CONTROL = 17, // 0x0011
			VK_MENU = 18, // 0x0012
			VK_PAUSE = 19, // 0x0013
			VK_CAPITAL = 20, // 0x0014
			[Obsolete("Use VK_HANGUL instead")] VK_HANGEUL = 21, // 0x0015
			VK_HANGUL = 21, // 0x0015
			VK_KANA = 21, // 0x0015
			VK_JUNJA = 23, // 0x0017
			VK_FINAL = 24, // 0x0018
			VK_HANJA = 25, // 0x0019
			VK_KANJI = 25, // 0x0019
			VK_ESCAPE = 27, // 0x001B
			VK_CONVERT = 28, // 0x001C
			VK_NONCONVERT = 29, // 0x001D
			VK_ACCEPT = 30, // 0x001E
			VK_MODECHANGE = 31, // 0x001F
			VK_SPACE = 32, // 0x0020
			VK_PRIOR = 33, // 0x0021
			VK_NEXT = 34, // 0x0022
			VK_END = 35, // 0x0023
			VK_HOME = 36, // 0x0024
			VK_LEFT = 37, // 0x0025
			VK_UP = 38, // 0x0026
			VK_RIGHT = 39, // 0x0027
			VK_DOWN = 40, // 0x0028
			VK_SELECT = 41, // 0x0029
			VK_PRINT = 42, // 0x002A
			VK_EXECUTE = 43, // 0x002B
			VK_SNAPSHOT = 44, // 0x002C
			VK_INSERT = 45, // 0x002D
			VK_DELETE = 46, // 0x002E
			VK_HELP = 47, // 0x002F
			VK_KEY_0 = 48, // 0x0030
			VK_KEY_1 = 49, // 0x0031
			VK_KEY_2 = 50, // 0x0032
			VK_KEY_3 = 51, // 0x0033
			VK_KEY_4 = 52, // 0x0034
			VK_KEY_5 = 53, // 0x0035
			VK_KEY_6 = 54, // 0x0036
			VK_KEY_7 = 55, // 0x0037
			VK_KEY_8 = 56, // 0x0038
			VK_KEY_9 = 57, // 0x0039
			VK_A = 65, // 0x0041
			VK_B = 66, // 0x0042
			VK_C = 67, // 0x0043
			VK_D = 68, // 0x0044
			VK_E = 69, // 0x0045
			VK_F = 70, // 0x0046
			VK_G = 71, // 0x0047
			VK_H = 72, // 0x0048
			VK_I = 73, // 0x0049
			VK_J = 74, // 0x004A
			VK_K = 75, // 0x004B
			VK_L = 76, // 0x004C
			VK_M = 77, // 0x004D
			VK_N = 78, // 0x004E
			VK_O = 79, // 0x004F
			VK_P = 80, // 0x0050
			VK_Q = 81, // 0x0051
			VK_R = 82, // 0x0052
			VK_S = 83, // 0x0053
			VK_T = 84, // 0x0054
			VK_U = 85, // 0x0055
			VK_V = 86, // 0x0056
			VK_W = 87, // 0x0057
			VK_X = 88, // 0x0058
			VK_Y = 89, // 0x0059
			VK_Z = 90, // 0x005A
			VK_LWIN = 91, // 0x005B
			VK_RWIN = 92, // 0x005C
			VK_APPS = 93, // 0x005D
			VK_SLEEP = 95, // 0x005F
			VK_NUMPAD0 = 96, // 0x0060
			VK_NUMPAD1 = 97, // 0x0061
			VK_NUMPAD2 = 98, // 0x0062
			VK_NUMPAD3 = 99, // 0x0063
			VK_NUMPAD4 = 100, // 0x0064
			VK_NUMPAD5 = 101, // 0x0065
			VK_NUMPAD6 = 102, // 0x0066
			VK_NUMPAD7 = 103, // 0x0067
			VK_NUMPAD8 = 104, // 0x0068
			VK_NUMPAD9 = 105, // 0x0069
			VK_MULTIPLY = 106, // 0x006A
			VK_ADD = 107, // 0x006B
			VK_SEPARATOR = 108, // 0x006C
			VK_SUBTRACT = 109, // 0x006D
			VK_DECIMAL = 110, // 0x006E
			VK_DIVIDE = 111, // 0x006F
			VK_F1 = 112, // 0x0070
			VK_F2 = 113, // 0x0071
			VK_F3 = 114, // 0x0072
			VK_F4 = 115, // 0x0073
			VK_F5 = 116, // 0x0074
			VK_F6 = 117, // 0x0075
			VK_F7 = 118, // 0x0076
			VK_F8 = 119, // 0x0077
			VK_F9 = 120, // 0x0078
			VK_F10 = 121, // 0x0079
			VK_F11 = 122, // 0x007A
			VK_F12 = 123, // 0x007B
			VK_F13 = 124, // 0x007C
			VK_F14 = 125, // 0x007D
			VK_F15 = 126, // 0x007E
			VK_F16 = 127, // 0x007F
			VK_F17 = 128, // 0x0080
			VK_F18 = 129, // 0x0081
			VK_F19 = 130, // 0x0082
			VK_F20 = 131, // 0x0083
			VK_F21 = 132, // 0x0084
			VK_F22 = 133, // 0x0085
			VK_F23 = 134, // 0x0086
			VK_F24 = 135, // 0x0087
			VK_NUMLOCK = 144, // 0x0090
			VK_SCROLL = 145, // 0x0091
			VK_OEM_FJ_JISHO = 146, // 0x0092
			VK_OEM_NEC_EQUAL = 146, // 0x0092
			VK_OEM_FJ_MASSHOU = 147, // 0x0093
			VK_OEM_FJ_TOUROKU = 148, // 0x0094
			VK_OEM_FJ_LOYA = 149, // 0x0095
			VK_OEM_FJ_ROYA = 150, // 0x0096
			VK_LSHIFT = 160, // 0x00A0
			VK_RSHIFT = 161, // 0x00A1
			VK_LCONTROL = 162, // 0x00A2
			VK_RCONTROL = 163, // 0x00A3
			VK_LMENU = 164, // 0x00A4
			VK_RMENU = 165, // 0x00A5
			VK_BROWSER_BACK = 166, // 0x00A6
			VK_BROWSER_FORWARD = 167, // 0x00A7
			VK_BROWSER_REFRESH = 168, // 0x00A8
			VK_BROWSER_STOP = 169, // 0x00A9
			VK_BROWSER_SEARCH = 170, // 0x00AA
			VK_BROWSER_FAVORITES = 171, // 0x00AB
			VK_BROWSER_HOME = 172, // 0x00AC
			VK_VOLUME_MUTE = 173, // 0x00AD
			VK_VOLUME_DOWN = 174, // 0x00AE
			VK_VOLUME_UP = 175, // 0x00AF
			VK_MEDIA_NEXT_TRACK = 176, // 0x00B0
			VK_MEDIA_PREV_TRACK = 177, // 0x00B1
			VK_MEDIA_STOP = 178, // 0x00B2
			VK_MEDIA_PLAY_PAUSE = 179, // 0x00B3
			VK_LAUNCH_MAIL = 180, // 0x00B4
			VK_LAUNCH_MEDIA_SELECT = 181, // 0x00B5
			VK_LAUNCH_APP1 = 182, // 0x00B6
			VK_LAUNCH_APP2 = 183, // 0x00B7
			VK_OEM_1 = 186, // 0x00BA
			VK_OEM_PLUS = 187, // 0x00BB
			VK_OEM_COMMA = 188, // 0x00BC
			VK_OEM_MINUS = 189, // 0x00BD
			VK_OEM_PERIOD = 190, // 0x00BE
			VK_OEM_2 = 191, // 0x00BF
			VK_OEM_3 = 192, // 0x00C0
			VK_OEM_4 = 219, // 0x00DB
			VK_OEM_5 = 220, // 0x00DC
			VK_OEM_6 = 221, // 0x00DD
			VK_OEM_7 = 222, // 0x00DE
			VK_OEM_8 = 223, // 0x00DF
			VK_OEM_AX = 225, // 0x00E1
			VK_OEM_102 = 226, // 0x00E2
			VK_ICO_HELP = 227, // 0x00E3
			VK_ICO_00 = 228, // 0x00E4
			VK_PROCESSKEY = 229, // 0x00E5
			VK_ICO_CLEAR = 230, // 0x00E6
			VK_PACKET = 231, // 0x00E7
			VK_OEM_RESET = 233, // 0x00E9
			VK_OEM_JUMP = 234, // 0x00EA
			VK_OEM_PA1 = 235, // 0x00EB
			VK_OEM_PA2 = 236, // 0x00EC
			VK_OEM_PA3 = 237, // 0x00ED
			VK_OEM_WSCTRL = 238, // 0x00EE
			VK_OEM_CUSEL = 239, // 0x00EF
			VK_OEM_ATTN = 240, // 0x00F0
			VK_OEM_FINISH = 241, // 0x00F1
			VK_OEM_COPY = 242, // 0x00F2
			VK_OEM_AUTO = 243, // 0x00F3
			VK_OEM_ENLW = 244, // 0x00F4
			VK_OEM_BACKTAB = 245, // 0x00F5
			VK_ATTN = 246, // 0x00F6
			VK_CRSEL = 247, // 0x00F7
			VK_EXSEL = 248, // 0x00F8
			VK_EREOF = 249, // 0x00F9
			VK_PLAY = 250, // 0x00FA
			VK_ZOOM = 251, // 0x00FB
			VK_NONAME = 252, // 0x00FC
			VK_PA1 = 253, // 0x00FD
			VK_OEM_CLEAR = 254, // 0x00FE
		}

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

			public static User32.WINDOWINFO Create() {
				return new User32.WINDOWINFO() {
					cbSize = (uint) Marshal.SizeOf(typeof(User32.WINDOWINFO))
				};
			}
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		/// <summary>
		/// Windows Messages
		/// Defined in winuser.h from Windows SDK v6.1
		/// Documentation pulled from MSDN.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		/// <summary>
		/// Contains information about the placement of a window on the screen.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct WINDOWPLACEMENT {
			/// <summary>
			/// The length of the structure, in bytes. Before calling the GetWindowPlacement or SetWindowPlacement functions,
			/// set this member to sizeof(WINDOWPLACEMENT).
			/// <para>GetWindowPlacement and SetWindowPlacement fail if this member is not set correctly.</para>
			/// </summary>
			public int length;

			/// <summary>The flags that control the position of the minimized window and the method by which the window is restored.</summary>
			public User32.WindowPlacementFlags flags;

			/// <summary>The current show state of the window.</summary>
			public User32.WindowShowStyle showCmd;

			/// <summary>The coordinates of the window's upper-left corner when the window is minimized.</summary>
			public POINT ptMinPosition;

			/// <summary>The coordinates of the window's upper-left corner when the window is maximized.</summary>
			public POINT ptMaxPosition;

			/// <summary>The window's coordinates when the window is in the restored position.</summary>
			public RECT rcNormalPosition;

			/// <summary>
			/// Create a new instance of <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> with <see cref="F:PInvoke.User32.WINDOWPLACEMENT.length" /> set to the correct value.
			/// </summary>
			/// <returns>A new instance of <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> with <see cref="F:PInvoke.User32.WINDOWPLACEMENT.length" /> set to the correct value.</returns>
			public static User32.WINDOWPLACEMENT Create() {
				return new User32.WINDOWPLACEMENT() {
					length = Marshal.SizeOf(typeof(User32.WINDOWPLACEMENT))
				};
			}
		}

		/// <summary>Flags for the flags member of <see cref="T:PInvoke.User32.WINDOWPLACEMENT" /> structure.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum WindowPlacementFlags {
			None = 0,
			WPF_SETMINPOSITION = 1,
			WPF_RESTORETOMAXIMIZED = 2,
			WPF_ASYNCWINDOWPLACEMENT = 4,
		}

		/// <summary>Flag values that specify the location of the hook function and of the events to be skipped. <see cref="M:PInvoke.User32.SetWinEventHook(PInvoke.User32.WindowsEventHookType,PInvoke.User32.WindowsEventHookType,System.IntPtr,System.IntPtr,System.Int32,System.Int32,PInvoke.User32.WindowsEventHookFlags)" />.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum WindowsEventHookFlags {
			WINEVENT_OUTOFCONTEXT = 0,
			WINEVENT_SKIPOWNTHREAD = 1,
			WINEVENT_SKIPOWNPROCESS = 2,
			WINEVENT_INCONTEXT = 4,
		}

		/// <summary>
		///     The type of hook procedure to be installed by <see cref="M:PInvoke.User32.SetWinEventHook(PInvoke.User32.WindowsEventHookType,PInvoke.User32.WindowsEventHookType,System.IntPtr,System.IntPtr,System.Int32,System.Int32,PInvoke.User32.WindowsEventHookFlags)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum WindowsEventHookType {
			EVENT_MIN = 1,
			EVENT_SYSTEM_SOUND = 1,
			EVENT_SYSTEM_ALERT = 2,
			EVENT_SYSTEM_FOREGROUND = 3,
			EVENT_SYSTEM_MENUSTART = 4,
			EVENT_SYSTEM_MENUEND = 5,
			EVENT_SYSTEM_MENUPOPUPSTART = 6,
			EVENT_SYSTEM_MENUPOPUPEND = 7,
			EVENT_SYSTEM_CAPTURESTART = 8,
			EVENT_SYSTEM_CAPTUREEND = 9,
			EVENT_SYSTEM_MOVESIZESTART = 10, // 0x0000000A
			EVENT_SYSTEM_MOVESIZEEND = 11, // 0x0000000B
			EVENT_SYSTEM_CONTEXTHELPSTART = 12, // 0x0000000C
			EVENT_SYSTEM_CONTEXTHELPEND = 13, // 0x0000000D
			EVENT_SYSTEM_DRAGDROPSTART = 14, // 0x0000000E
			EVENT_SYSTEM_DRAGDROPEND = 15, // 0x0000000F
			EVENT_SYSTEM_DIALOGSTART = 16, // 0x00000010
			EVENT_SYSTEM_DIALOGEND = 17, // 0x00000011
			EVENT_SYSTEM_SCROLLINGSTART = 18, // 0x00000012
			EVENT_SYSTEM_SCROLLINGEND = 19, // 0x00000013
			EVENT_SYSTEM_SWITCHSTART = 20, // 0x00000014
			EVENT_SYSTEM_SWITCHEND = 21, // 0x00000015
			EVENT_SYSTEM_MINIMIZESTART = 22, // 0x00000016
			EVENT_SYSTEM_MINIMIZEEND = 23, // 0x00000017
			EVENT_SYSTEM_DESKTOPSWITCH = 32, // 0x00000020
			EVENT_SYSTEM_END = 255, // 0x000000FF
			EVENT_OEM_DEFINED_START = 257, // 0x00000101
			EVENT_OEM_DEFINED_END = 511, // 0x000001FF
			EVENT_UIA_EVENTID_START = 19968, // 0x00004E00
			EVENT_UIA_EVENTID_END = 20223, // 0x00004EFF
			EVENT_UIA_PROPID_START = 29952, // 0x00007500
			EVENT_UIA_PROPID_END = 30207, // 0x000075FF
			EVENT_OBJECT_CREATE = 32768, // 0x00008000
			EVENT_OBJECT_DESTROY = 32769, // 0x00008001
			EVENT_OBJECT_SHOW = 32770, // 0x00008002
			EVENT_OBJECT_HIDE = 32771, // 0x00008003
			EVENT_OBJECT_REORDER = 32772, // 0x00008004
			EVENT_OBJECT_FOCUS = 32773, // 0x00008005
			EVENT_OBJECT_SELECTION = 32774, // 0x00008006
			EVENT_OBJECT_SELECTIONADD = 32775, // 0x00008007
			EVENT_OBJECT_SELECTIONREMOVE = 32776, // 0x00008008
			EVENT_OBJECT_SELECTIONWITHIN = 32777, // 0x00008009
			EVENT_OBJECT_STATECHANGE = 32778, // 0x0000800A
			EVENT_OBJECT_LOCATIONCHANGE = 32779, // 0x0000800B
			EVENT_OBJECT_NAMECHANGE = 32780, // 0x0000800C
			EVENT_OBJECT_DESCRIPTIONCHANGE = 32781, // 0x0000800D
			EVENT_OBJECT_VALUECHANGE = 32782, // 0x0000800E
			EVENT_OBJECT_PARENTCHANGE = 32783, // 0x0000800F
			EVENT_OBJECT_HELPCHANGE = 32784, // 0x00008010
			EVENT_OBJECT_DEFACTIONCHANGE = 32785, // 0x00008011
			EVENT_OBJECT_ACCELERATORCHANGE = 32786, // 0x00008012
			EVENT_OBJECT_INVOKED = 32787, // 0x00008013
			EVENT_OBJECT_TEXTSELECTIONCHANGED = 32788, // 0x00008014
			EVENT_OBJECT_CONTENTSCROLLED = 32789, // 0x00008015
			EVENT_SYSTEM_ARRANGMENTPREVIEW = 32790, // 0x00008016
			EVENT_OBJECT_LIVEREGIONCHANGED = 32793, // 0x00008019
			EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED = 32800, // 0x00008020
			EVENT_OBJECT_DRAGSTART = 32801, // 0x00008021
			EVENT_OBJECT_DRAGCANCEL = 32802, // 0x00008022
			EVENT_OBJECT_DRAGCOMPLETE = 32803, // 0x00008023
			EVENT_OBJECT_DRAGENTER = 32804, // 0x00008024
			EVENT_OBJECT_DRAGLEAVE = 32805, // 0x00008025
			EVENT_OBJECT_DRAGDROPPED = 32806, // 0x00008026
			EVENT_OBJECT_IME_SHOW = 32807, // 0x00008027
			EVENT_OBJECT_IME_HIDE = 32808, // 0x00008028
			EVENT_OBJECT_IME_CHANGE = 32809, // 0x00008029
			EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED = 32816, // 0x00008030
			EVENT_OBJECT_END = 33023, // 0x000080FF
			EVENT_AIA_START = 40960, // 0x0000A000
			EVENT_AIA_END = 45055, // 0x0000AFFF
			EVENT_MAX = 2147483647, // 0x7FFFFFFF
		}

		/// <summary>The type of hook procedure to be installed by <see cref="M:PInvoke.User32.SetWindowsHookEx(PInvoke.User32.WindowsHookType,System.IntPtr,System.IntPtr,System.Int32)" />.</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum WindowsHookType {
			WH_MSGFILTER = -1,
			WH_JOURNALRECORD = 0,
			WH_JOURNALPLAYBACK = 1,
			WH_KEYBOARD = 2,
			WH_GETMESSAGE = 3,
			WH_CALLWNDPROC = 4,
			WH_CBT = 5,
			WH_SYSMSGFILTER = 6,
			WH_MOUSE = 7,
			WH_HARDWARE = 8,
			WH_DEBUG = 9,
			WH_SHELL = 10, // 0x0000000A
			WH_FOREGROUNDIDLE = 11, // 0x0000000B
			WH_CALLWNDPROCRET = 12, // 0x0000000C
			WH_KEYBOARD_LL = 13, // 0x0000000D
			WH_MOUSE_LL = 14, // 0x0000000E
		}

		/// <summary>Enumeration of the different ways of showing a window using
		/// ShowWindow</summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		/// <summary>
		/// Controls the behaviour of <see cref="M:PInvoke.User32.CreateWindowStation(System.String,PInvoke.User32.WindowStationCreationFlags,PInvoke.Kernel32.ACCESS_MASK,System.Nullable{PInvoke.Kernel32.SECURITY_ATTRIBUTES})" /> when a window station with the desired name already exists/&gt;
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum WindowStationCreationFlags : uint {
			None,
			CWF_CREATE_ONLY,
		}

		/// <summary>
		/// Window Styles. The following styles can be specified wherever a window style is required.
		/// After the control has been created, these styles cannot be modified, except as noted.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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
			WS_SIZEFRAME = 262144, // 0x00040000
			WS_SYSMENU = 524288, // 0x00080000
			WS_TABSTOP = WS_MAXIMIZEBOX, // 0x00010000
			WS_VISIBLE = 268435456, // 0x10000000
			WS_VSCROLL = 2097152, // 0x00200000
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
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

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MINMAXINFO {
			public POINT ptReserved;
			public POINT ptMaxSize;
			public POINT ptMaxPosition;
			public POINT ptMinTrackSize;
			public POINT ptMaxTrackSize;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct WNDCLASS {
			public User32.ClassStyles style;
			[MarshalAs(UnmanagedType.FunctionPtr)] public User32.WndProc lpfnWndProc;
			public int cbClsExtra;
			public int cbWndExtra;
			public IntPtr hInstance;
			public IntPtr hIcon;
			public IntPtr hCursor;
			public IntPtr hbrBackground;
			public unsafe char* lpszMenuName;
			public unsafe char* lpszClassName;
		}

		/// <summary>
		/// Contains window class information. It is used with the <see cref="M:PInvoke.User32.RegisterClassEx(PInvoke.User32.WNDCLASSEX@)" /> and <see cref="M:PInvoke.User32.GetClassInfoEx(System.IntPtr,System.String,PInvoke.User32.WNDCLASSEX@)" /> functions.
		/// The <see cref="T:PInvoke.User32.WNDCLASSEX" /> structure is similar to the <see cref="T:PInvoke.User32.WNDCLASS" /> structure. There are two differences. <see cref="T:PInvoke.User32.WNDCLASSEX" /> includes the <see cref="F:PInvoke.User32.WNDCLASSEX.cbSize" /> member, which specifies the size of the structure, and the <see cref="F:PInvoke.User32.WNDCLASSEX.hIconSm" /> member, which contains a handle to a small icon associated with the window class.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct WNDCLASSEX {
			public int cbSize;
			public User32.ClassStyles style;
			[MarshalAs(UnmanagedType.FunctionPtr)] public User32.WndProc lpfnWndProc;
			public int cbClsExtra;
			public int cbWndExtra;
			public IntPtr hInstance;
			public IntPtr hIcon;
			public IntPtr hCursor;
			public IntPtr hbrBackground;
			public unsafe char* lpszMenuName;
			public unsafe char* lpszClassName;
			public IntPtr hIconSm;

			public static User32.WNDCLASSEX Create() {
				return new User32.WNDCLASSEX() {
					cbSize = Marshal.SizeOf(typeof(User32.WNDCLASSEX))
				};
			}

			public unsafe IntPtr lpszMenuName_IntPtr {
				get { return new IntPtr((void*) this.lpszMenuName); }
				set { this.lpszMenuName = (char*) value.ToPointer(); }
			}

			public unsafe IntPtr lpszClassName_IntPtr {
				get { return new IntPtr((void*) this.lpszClassName); }
				set { this.lpszClassName = (char*) value.ToPointer(); }
			}
		}

		/// <summary>
		/// An application-defined or library-defined callback function used with the <see cref="M:PInvoke.User32.SetWindowsHookEx(PInvoke.User32.WindowsHookType,System.IntPtr,System.IntPtr,System.Int32)" /> function.
		/// This is a generic function to Hook callbacks. For specific callback functions see this <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/ms632589(v=vs.85).aspx">API documentation on MSDN</see>.
		/// </summary>
		/// <param name="nCode">An action code for the callback. Can be used to indicate if the hook procedure must process the message or not.</param>
		/// <param name="wParam">First message parameter</param>
		/// <param name="lParam">Second message parameter</param>
		/// <returns>
		/// An LRESULT. Usually if nCode is less than zero, the hook procedure must return the value returned by CallNextHookEx.
		/// If nCode is greater than or equal to zero, it is highly recommended that you call CallNextHookEx and return the value it returns;
		/// otherwise, other applications that have installed hooks will not receive hook notifications and may behave incorrectly as a result.
		/// If the hook procedure does not call CallNextHookEx, the return value should be zero.
		/// </returns>
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public delegate int WindowsHookDelegate(int nCode, IntPtr wParam, IntPtr lParam);

		/// <summary>
		/// An application-defined callback (or hook) function that the system calls in response to events generated by an accessible object.
		/// The hook function processes the event notifications as required. Clients install the hook function and request specific types
		/// of event notifications by calling <see cref="M:PInvoke.User32.SetWinEventHook(PInvoke.User32.WindowsEventHookType,PInvoke.User32.WindowsEventHookType,System.IntPtr,System.IntPtr,System.Int32,System.Int32,PInvoke.User32.WindowsEventHookFlags)" />.
		/// </summary>
		/// <param name="hWinEventHook">Handle to an event hook function. This value is returned by SetWinEventHook when the hook function
		/// is installed and is specific to each instance of the hook function.</param>
		/// <param name="event">Specifies the event that occurred. This value is one of the <see cref="T:PInvoke.User32.WindowsEventHookType" /> constants.</param>
		/// <param name="hwnd">Handle to the window that generates the event, or NULL if no window is associated with the event.
		/// For example, the mouse pointer is not associated with a window.</param>
		/// <param name="idObject">Identifies the object associated with the event. This is one of the object identifiers or a custom object ID.
		/// <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/dd373606(v=vs.85).aspx" /></param>
		/// <param name="idChild">Identifies whether the event was triggered by an object or a child element of the object.
		/// If this value is CHILDID_SELF, the event was triggered by the object; otherwise, this value is the child ID of the element that triggered the event.</param>
		/// <param name="dwEventThread">Identifies the thread that generated the event, or the thread that owns the current window.</param>
		/// <param name="dwmsEventTime">Specifies the time, in milliseconds, that the event was generated.</param>
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public delegate void WinEventProc(User32.SafeEventHookHandle hWinEventHook, User32.WindowsEventHookType @event,
		                                  IntPtr hwnd, int idObject, int idChild, int dwEventThread,
		                                  uint dwmsEventTime);

		/// <summary>
		/// An application-defined callback function used with the <see cref="M:PInvoke.User32.EnumWindowStations(PInvoke.User32.WINSTAENUMPROC,System.IntPtr)" /> function.
		/// </summary>
		/// <param name="lpszWindowStation">The name of the window station.</param>
		/// <param name="lParam">An application-defined value specified in the <see cref="M:PInvoke.User32.EnumWindowStations(PInvoke.User32.WINSTAENUMPROC,System.IntPtr)" /> function.</param>
		/// <returns>To continue enumeration, the callback function must return TRUE (non-zero value). To stop enumeration, it must return FALSE (0).</returns>
		/// <remarks>
		/// An application must register this callback function by passing its address to <see cref="M:PInvoke.User32.EnumWindowStations(PInvoke.User32.WINSTAENUMPROC,System.IntPtr)" />.
		/// The callback function can call SetLastError to set an error code for the caller to retrieve by calling GetLastError.
		/// </remarks>
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public delegate int WINSTAENUMPROC(string lpszWindowStation, IntPtr lParam);

		/// <summary>
		/// An application-defined callback function used with the <see cref="M:PInvoke.User32.EnumDesktops(PInvoke.User32.SafeWindowStationHandle,PInvoke.User32.DESKTOPENUMPROC,System.IntPtr)" /> function.
		/// </summary>
		/// <param name="lpwstrDesktopName">The name of the desktop.</param>
		/// <param name="lParam">An application-defined value specified in the <see cref="M:PInvoke.User32.EnumDesktops(PInvoke.User32.SafeWindowStationHandle,PInvoke.User32.DESKTOPENUMPROC,System.IntPtr)" /> function.</param>
		/// <returns>To continue enumeration, the callback function must return TRUE (non-zero value). To stop enumeration, it must return FALSE (0).</returns>
		/// <remarks>
		/// An application must register this callback function by passing its address to <see cref="M:PInvoke.User32.EnumDesktops(PInvoke.User32.SafeWindowStationHandle,PInvoke.User32.DESKTOPENUMPROC,System.IntPtr)" />.
		/// The callback function can call SetLastError to set an error code for the caller to retrieve by calling GetLastError.
		/// </remarks>
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public delegate int DESKTOPENUMPROC(string lpwstrDesktopName, IntPtr lParam);

		/// <summary> An application-defined callback function used with the <see cref="M:PInvoke.User32.EnumWindows(PInvoke.User32.WNDENUMPROC,System.IntPtr)" /> or <see cref="M:PInvoke.User32.EnumDesktopWindows(PInvoke.User32.SafeDesktopHandle,PInvoke.User32.WNDENUMPROC,System.IntPtr)" /> function.</summary>
		/// <param name="hwnd">A handle to a top-level window.</param>
		/// <param name="lParam">The application-defined value given in <see cref="M:PInvoke.User32.EnumWindows(PInvoke.User32.WNDENUMPROC,System.IntPtr)" /> or <see cref="M:PInvoke.User32.EnumDesktopWindows(PInvoke.User32.SafeDesktopHandle,PInvoke.User32.WNDENUMPROC,System.IntPtr)" />.</param>
		/// <returns>To continue enumeration, the callback function must return TRUE; to stop enumeration, it must return FALSE.</returns>
		/// <remarks>
		/// An application must register this callback function by passing its address to <see cref="M:PInvoke.User32.EnumWindows(PInvoke.User32.WNDENUMPROC,System.IntPtr)" /> or <see cref="M:PInvoke.User32.EnumDesktopWindows(PInvoke.User32.SafeDesktopHandle,PInvoke.User32.WNDENUMPROC,System.IntPtr)" />.
		/// The callback function can call SetLastError to set an error code for the caller to retrieve by calling GetLastError.
		/// </remarks>
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public delegate bool WNDENUMPROC(IntPtr hwnd, IntPtr lParam);

		/// <summary>
		///     Application-defined callback function used with the CreateDialog and DialogBox families of functions. It processes
		///     messages sent to a modal or modeless dialog box.
		/// </summary>
		/// <param name="hwndDlg">A handle to the dialog box.</param>
		/// <param name="uMsg">The message.</param>
		/// <param name="wParam">Additional message-specific information.</param>
		/// <param name="lParam">Additional message-specific information.</param>
		/// <returns>
		///     Typically, the dialog box procedure should return TRUE if it processed the message, and FALSE if it did not. If the
		///     dialog box procedure returns FALSE, the dialog manager performs the default dialog operation in response to the
		///     message.
		///     <para>
		///         If the dialog box procedure processes a message that requires a specific return value, the dialog box
		///         procedure should set the desired return value by calling <see cref="M:PInvoke.User32.SetWindowLong(System.IntPtr,PInvoke.User32.WindowLongIndexFlags,PInvoke.User32.SetWindowLongFlags)" /> with
		///         <see cref="F:PInvoke.User32.WindowLongIndexFlags.DWLP_MSGRESULT" /> immediately before returning TRUE. Note that you must call
		///         SetWindowLong immediately before returning TRUE; doing so earlier may result in the
		///         <see cref="F:PInvoke.User32.WindowLongIndexFlags.DWLP_MSGRESULT" /> value being overwritten by a nested dialog box message.
		///     </para>
		/// </returns>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public delegate IntPtr DialogProc(IntPtr hwndDlg, User32.WindowMessage uMsg, IntPtr wParam, IntPtr lParam);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public delegate void MSGBOXCALLBACK(User32.HELPINFO lpHelpInfo);

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public unsafe delegate bool
			MONITORENUMPROC(IntPtr hMonitor, IntPtr hdcMonitor, RECT* lprcMonitor, void* dwData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public unsafe delegate IntPtr WndProc(IntPtr hWnd, User32.WindowMessage msg, void* wParam, void* lParam);
	}
}