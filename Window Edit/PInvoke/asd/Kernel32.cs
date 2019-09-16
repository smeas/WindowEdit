using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace PInvoke {
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ACL" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CharacterAttributesFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CHAR_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CHAR_INFO_ENCODING" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleBufferModes" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleDisplayMode" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleScreenBufferFlag" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleSelectionFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CONSOLE_SCREEN_BUFFER_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CONSOLE_SELECTION_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ControlKeyStates" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ControlType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreateProcessFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.EXECUTION_STATE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FOCUS_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GetModuleHandleExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GlobalAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GlobalReAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GRPICONDIR" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GRPICONDIRENTRY" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.HeapAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.HeapFreeFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.HeapReAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ICONDIR" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ICONDIRENTRY" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.InputEventTypeFlag" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.INPUT_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.INPUT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.IO_COUNTERS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECTINFOCLASS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_CPU_RATE_CONTROL_FLAGS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_CPU_RATE_CONTROL_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_EXTENDED_LIMIT_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOB_OBJECT_LIMIT_FLAGS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.KEY_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>Contains the language ID (LANGID) constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.LoadLibraryExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.LocalAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.LocalReAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MENU_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MouseButtonStates" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MouseEvents" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MOUSE_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.NamedPipeInfoFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PipeAccessMode" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PipeMode" /> nested type.
	/// </content>
	/// <content>Contains the <see cref="T:PInvoke.Kernel32.ProcessAccess" /> nested type.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ProcessShutdownFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.QueryFullProcessImageNameFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains all the "RT_" constants that represent resource types.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.StartupInfoFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.StdHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.WINDOW_BUFFER_SIZE_RECORD" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the Kernel32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreateFileFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreationDisposition" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FileAccess" /> nested type.
	/// </content>
	/// <content>
	/// Contains the nested <see cref="T:PInvoke.Kernel32.FileAttribute" /> type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FileShare" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FILETIME" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FINDEX_INFO_LEVELS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FINDEX_SEARCH_OPS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FindFirstFileExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FormatMessageFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SafeFindFilesHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SafeObjectHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SafeObjectHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SECURITY_DESCRIPTOR" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SECURITY_IMPERSONATION_LEVEL" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.WaitForSingleObjectResult" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.WIN32_FIND_DATA" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the Kernel32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ACL" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CharacterAttributesFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CHAR_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CHAR_INFO_ENCODING" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleBufferModes" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleDisplayMode" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleScreenBufferFlag" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ConsoleSelectionFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CONSOLE_SCREEN_BUFFER_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CONSOLE_SELECTION_INFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ControlKeyStates" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ControlType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreateProcessFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.EXECUTION_STATE" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FOCUS_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GetModuleHandleExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GlobalAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GlobalReAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GRPICONDIR" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.GRPICONDIRENTRY" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.HeapAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.HeapFreeFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.HeapReAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ICONDIR" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ICONDIRENTRY" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.InputEventTypeFlag" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.INPUT_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.INPUT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.IO_COUNTERS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECTINFOCLASS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_CPU_RATE_CONTROL_FLAGS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_CPU_RATE_CONTROL_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOBOBJECT_EXTENDED_LIMIT_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.JOB_OBJECT_LIMIT_FLAGS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.KEY_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>Contains the language ID (LANGID) constants.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.LoadLibraryExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.LocalAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.LocalReAllocFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MENU_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MouseButtonStates" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MouseEvents" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.MOUSE_EVENT_RECORD" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.NamedPipeInfoFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PipeAccessMode" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PipeMode" /> nested type.
	/// </content>
	/// <content>Contains the <see cref="T:PInvoke.Kernel32.ProcessAccess" /> nested type.</content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ProcessShutdownFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.QueryFullProcessImageNameFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains all the "RT_" constants that represent resource types.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.StartupInfoFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.StdHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.WINDOW_BUFFER_SIZE_RECORD" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the Kernel32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreateFileFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.CreationDisposition" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FileAccess" /> nested type.
	/// </content>
	/// <content>
	/// Contains the nested <see cref="T:PInvoke.Kernel32.FileAttribute" /> type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FileShare" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FILETIME" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FINDEX_INFO_LEVELS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FINDEX_SEARCH_OPS" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FindFirstFileExFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.FormatMessageFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SafeFindFilesHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SafeObjectHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SafeObjectHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SECURITY_DESCRIPTOR" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SECURITY_IMPERSONATION_LEVEL" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.WaitForSingleObjectResult" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Kernel32.WIN32_FIND_DATA" /> nested type.
	/// </content>
	/// <summary>
	/// Exported functions from the Kernel32.dll Windows library.
	/// </summary>
	/// <content>
	/// Methods and nested types that are not strictly P/Invokes but provide
	/// a slightly higher level of functionality to ease calling into native code.
	/// </content>
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public static class Kernel32 {
		/// <summary>Hardware-dependent cursor resource.</summary>
		public static readonly unsafe char* RT_CURSOR = Kernel32.MAKEINTRESOURCE(1);

		/// <summary>Bitmap resource.</summary>
		public static readonly unsafe char* RT_BITMAP = Kernel32.MAKEINTRESOURCE(2);

		/// <summary>Hardware-dependent icon resource.</summary>
		public static readonly unsafe char* RT_ICON = Kernel32.MAKEINTRESOURCE(3);

		/// <summary>Menu resource.</summary>
		public static readonly unsafe char* RT_MENU = Kernel32.MAKEINTRESOURCE(4);

		/// <summary>Dialog box.</summary>
		public static readonly unsafe char* RT_DIALOG = Kernel32.MAKEINTRESOURCE(5);

		/// <summary>String-table entry.</summary>
		public static readonly unsafe char* RT_STRING = Kernel32.MAKEINTRESOURCE(6);

		/// <summary>Font directory resource.</summary>
		public static readonly unsafe char* RT_FONTDIR = Kernel32.MAKEINTRESOURCE(7);

		/// <summary>Font resource.</summary>
		public static readonly unsafe char* RT_FONT = Kernel32.MAKEINTRESOURCE(8);

		/// <summary>Accelerator table.</summary>
		public static readonly unsafe char* RT_ACCELERATOR = Kernel32.MAKEINTRESOURCE(9);

		/// <summary>Application-defined resource (raw data).</summary>
		public static readonly unsafe char* RT_RCDATA = Kernel32.MAKEINTRESOURCE(10);

		/// <summary>Message-table entry.</summary>
		public static readonly unsafe char* RT_MESSAGETABLE = Kernel32.MAKEINTRESOURCE(11);

		/// <summary>Hardware-independent cursor resource.</summary>
		public static readonly unsafe char* RT_GROUP_CURSOR = Kernel32.MAKEINTRESOURCE(12);

		/// <summary>Hardware-independent icon resource.</summary>
		public static readonly unsafe char* RT_GROUP_ICON = Kernel32.MAKEINTRESOURCE(14);

		/// <summary>Version resource</summary>
		public static readonly unsafe char* RT_VERSION = Kernel32.MAKEINTRESOURCE(16);

		/// <summary>
		///     Allows a resource editing tool to associate a string with an .rc file. Typically, the string is the name of the
		///     header file that provides symbolic names. The resource compiler parses the string but otherwise ignores the value.
		///     For example,
		///     <para>
		///         <code>1 DLGINCLUDE "MyFile.h"</code>
		///     </para>
		/// </summary>
		public static readonly unsafe char* RT_DLGINCLUDE = Kernel32.MAKEINTRESOURCE(17);

		/// <summary>Plug and Play resource.</summary>
		public static readonly unsafe char* RT_PLUGPLAY = Kernel32.MAKEINTRESOURCE(19);

		/// <summary>VXD.</summary>
		public static readonly unsafe char* RT_VXD = Kernel32.MAKEINTRESOURCE(20);

		/// <summary>Animated cursor.</summary>
		public static readonly unsafe char* RT_ANICURSOR = Kernel32.MAKEINTRESOURCE(21);

		/// <summary>Animated icon.</summary>
		public static readonly unsafe char* RT_ANIICON = Kernel32.MAKEINTRESOURCE(22);

		/// <summary>HTML resource.</summary>
		public static readonly unsafe char* RT_HTML = Kernel32.MAKEINTRESOURCE(23);

		/// <summary>Constant for invalid handle value</summary>
		public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

		/// <summary>
		///     Used to specify to <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> that the number of pipe instances that can be created is
		///     limited only by the availability of system resources.
		/// </summary>
		public const int PIPE_UNLIMITED_INSTANCES = 255;

		/// <summary>All processes start at this shutdown level</summary>
		public const int DefaultShutdownLevel = 640;

		/// <summary>The time-out interval is the default value specified by the server process in the
		///     <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> function.
		///     <para>This constant is a special value for named pipes timeouts.</para>
		/// </summary>
		public const int NMPWAIT_USE_DEFAULT_WAIT = 0;

		/// <summary>The function does not return until an instance of the named pipe is available.
		///     <para>This constant is a special value for named pipes timeouts.</para>
		/// </summary>
		public const int NMPWAIT_WAIT_FOREVER = -1;

		/// <summary>Does not wait for the named pipe. If the named pipe is not available, the function returns an error.
		///     <para>This constant is a special value for named pipes timeouts.</para>
		/// </summary>
		public const int NMPWAIT_NOWAIT = 1;

		/// <summary>The maximum length of a name for a process module.</summary>
		public const int MAX_MODULE_NAME32 = 255;

		/// <summary>
		/// The maximum length of file paths for most Win32 functions.
		/// </summary>
		public const int MAX_PATH = 260;

		private const string api_ms_win_core_localization_l1_2_0 = "Kernel32";
		private const string api_ms_win_core_processthreads_l1_1_1 = "Kernel32";
		private const string api_ms_win_core_io_l1_1_1 = "Kernel32";
		private const string api_ms_win_core_file_l1_2_0 = "Kernel32";
		private const string api_ms_win_core_synch_l1_2_0 = "Kernel32";
		private const string api_ms_win_core_handle_l1_1_0 = "Kernel32";
		private const string api_ms_win_core_console_l1_1_0 = "Kernel32";
		private const string api_ms_win_core_console_l2_1_0 = "Kernel32";
		private const string api_ms_win_core_psapi_l1_1_0 = "Kernel32";
		private const string api_ms_win_core_namedpipe_l1_2_0 = "Kernel32";
		private const string api_ms_win_core_libraryloader_l1_1_1 = "Kernel32";
		private const string api_ms_win_core_sysinfo_l1_2_1 = "Kernel32";
		private const string api_ms_win_core_sysinfo_l1_2_0 = "Kernel32";
		private const string api_ms_win_core_errorhandling_l1_1_1 = "Kernel32";

		/// <summary>
		///     Creates a language identifier from a primary language identifier and a sublanguage identifier.
		/// </summary>
		/// <param name="usPrimaryLanguage">
		///     Primary language identifier. This identifier can be a predefined value or a value for a user-defined primary
		///     language. For a user-defined language, the identifier is a value in the range 0x0200 to 0x03FF. All other
		///     values are reserved for operating system use. For more information, see Language Identifier Constants and
		///     Strings.
		/// </param>
		/// <param name="usSubLanguage">
		///     Sublanguage identifier. This parameter can be a predefined sublanguage identifier or a user-defined
		///     sublanguage. For a user-defined sublanguage, the identifier is a value in the range 0x20 to 0x3F. All other
		///     values are reserved for operating system use. For more information, see Language Identifier Constants and
		///     Strings.
		/// </param>
		/// <returns>Returns the language identifier.</returns>
		public static Kernel32.LANGID MAKELANGID(ushort usPrimaryLanguage, ushort usSubLanguage) {
			return new Kernel32.LANGID() {
				Primary = (Kernel32.LANGID.PrimaryLanguage) usPrimaryLanguage,
				Sub = (Kernel32.LANGID.SubLanguage) usSubLanguage
			};
		}

		/// <summary>
		///     Creates a language identifier from a primary language identifier and a sublanguage identifier.
		/// </summary>
		/// <param name="ePrimaryLanguage">
		///     Primary language identifier. This identifier can be a predefined value or a value for a user-defined primary
		///     language. For a user-defined language, the identifier is a value in the range 0x0200 to 0x03FF. All other
		///     values are reserved for operating system use. For more information, see Language Identifier Constants and
		///     Strings.
		/// </param>
		/// <param name="eSubLanguage">
		///     Sublanguage identifier. This parameter can be a predefined sublanguage identifier or a user-defined
		///     sublanguage. For a user-defined sublanguage, the identifier is a value in the range 0x20 to 0x3F. All other
		///     values are reserved for operating system use. For more information, see Language Identifier Constants and
		///     Strings.
		/// </param>
		/// <returns>Returns the language identifier.</returns>
		public static Kernel32.LANGID MAKELANGID(Kernel32.LANGID.PrimaryLanguage ePrimaryLanguage,
		                                         Kernel32.LANGID.SubLanguage eSubLanguage) {
			return new Kernel32.LANGID() {
				Primary = ePrimaryLanguage,
				Sub = eSubLanguage
			};
		}

		/// <summary>
		/// Generates simple tones on the speaker. The function is synchronous; it performs an alertable wait and does not return control to its caller until the sound finishes.
		/// </summary>
		/// <param name="frequency">The frequency of the sound, in hertz. This parameter must be in the range 37 through 32,767 (0x25 through 0x7FFF).</param>
		/// <param name="duration">The duration of the sound, in milliseconds.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Beep(int frequency, int duration);

		/// <summary>
		/// Terminates the specified process and all of its threads.
		/// </summary>
		/// <param name="hProcess">
		/// A handle to the process to be terminated.
		/// The handle must have the PROCESS_TERMINATE access right
		/// </param>
		/// <param name="uExitCode">
		/// The exit code to be used by the process and threads terminated as a result of this call.
		/// Use the <see cref="M:PInvoke.Kernel32.GetExitCodeProcess(System.IntPtr,System.Int32@)" /> function to retrieve a process's exit value.
		/// Use the <see cref="M:PInvoke.Kernel32.GetExitCodeThread(System.IntPtr,System.Int32@)" /> function to retrieve a thread's exit value.
		/// </param>
		/// <returns>If the function succeeds, the return value is true, else the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</returns>
		/// <remarks>
		/// <para>
		/// The TerminateProcess function is used to unconditionally cause a process to exit.
		/// The state of global data maintained by dynamic-link libraries (DLLs) may be compromised if TerminateProcess is used rather than <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" />.
		/// </para>
		/// <para>
		/// This function stops execution of all threads within the process and requests cancellation of all pending I/O.
		/// The terminated process cannot exit until all pending I/O has been completed or canceled.When a process terminates,
		/// its kernel object is not destroyed until all processes that have open handles to the process have released those handles.
		/// TerminateProcess is asynchronous; it initiates termination and returns immediately.
		/// If you need to be sure the process has terminated, call the <see cref="M:PInvoke.Kernel32.WaitForSingleObject(System.Runtime.InteropServices.SafeHandle,System.Int32)" /> function with a handle to the process.
		/// A process cannot prevent itself from being terminated.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TerminateProcess(IntPtr hProcess, int uExitCode);

		/// <summary>Terminates a thread.</summary>
		/// <param name="hThread">A handle to the thread to be terminated. The handle must have the THREAD_TERMINATE access right.</param>
		/// <param name="dwExitCode">The exit code for the thread. Use the <see cref="M:PInvoke.Kernel32.GetExitCodeThread(System.IntPtr,System.Int32@)" /> function to retrieve a thread's exit value.</param>
		/// <returns>If the function succeeds, the return value is true, else the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</returns>
		/// <remarks>
		/// TerminateThread is used to cause a thread to exit.
		/// When this occurs, the target thread has no chance to execute any user-mode code.
		/// DLLs attached to the thread are not notified that the thread is terminating.
		/// The system frees the thread's initial stack.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TerminateThread(IntPtr hThread, int dwExitCode);

		/// <summary>Ends the calling process and all its threads.</summary>
		/// <param name="uExitCode">The exit code for the process and all threads.</param>
		/// <remarks>
		/// <para>
		/// Use the <see cref="M:PInvoke.Kernel32.GetExitCodeProcess(System.IntPtr,System.Int32@)" /> function to retrieve the process's exit value. Use the <see cref="M:PInvoke.Kernel32.GetExitCodeThread(System.IntPtr,System.Int32@)" /> function to retrieve a thread's exit value.
		/// Exiting a process causes the following:
		/// </para>
		/// <list>
		/// <item>All of the threads in the process, except the calling thread, terminate their execution without receiving a DLL_THREAD_DETACH notification.</item>
		/// <item>The states of all of the threads terminated in step 1 become signaled.</item>
		/// <item>The entry-point functions of all loaded dynamic-link libraries (DLLs) are called with DLL_PROCESS_DETACH.</item>
		/// <item>After all attached DLLs have executed any process termination code, the ExitProcess function terminates the current process, including the calling thread.</item>
		/// <item>The state of the calling thread becomes signaled.</item>
		/// <item>All of the object handles opened by the process are closed.</item>
		/// <item>The termination status of the process changes from STILL_ACTIVE to the exit value of the process.</item>
		/// <item>The state of the process object becomes signaled, satisfying any threads that had been waiting for the process to terminate.</item>
		/// </list>
		/// <para>
		/// If one of the terminated threads in the process holds a lock and the DLL detach code in one of the loaded DLLs attempts to acquire the same lock,
		/// then calling ExitProcess results in a deadlock. In contrast, if a process terminates by calling <see cref="M:PInvoke.Kernel32.TerminateProcess(System.IntPtr,System.Int32)" />,
		/// the DLLs that the process is attached to are not notified of the process termination.
		/// Therefore, if you do not know the state of all threads in your process, it is better to call <see cref="M:PInvoke.Kernel32.TerminateProcess(System.IntPtr,System.Int32)" /> than <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" />.
		/// Note that returning from the main function of an application results in a call to <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" />.
		/// </para>
		/// <para>
		/// Calling ExitProcess in a DLL can lead to unexpected application or system errors.
		/// Be sure to call <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" /> from a DLL only if you know which applications or system components
		/// will load the DLL and that it is safe to call <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" /> in this context.
		/// Exiting a process does not cause child processes to be terminated.
		/// Exiting a process does not necessarily remove the process object from the operating system.
		/// A process object is deleted when the last handle to the process is closed.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern void ExitProcess(int uExitCode);

		/// <summary>Ends the calling thread.</summary>
		/// <param name="dwExitCode">The exit code for the thread.</param>
		/// <remarks>
		/// <para>
		/// ExitThread is the preferred method of exiting a thread in C code.
		/// However, in C++ code, the thread is exited before any destructors can be called or any other automatic cleanup can be performed.
		/// Therefore, in C++ code, you should return from your thread function.
		/// When this function is called (either explicitly or by returning from a thread procedure), the current thread's stack is deallocated,
		/// all pending I/O initiated by the thread is canceled, and the thread terminates.
		/// The entry-point function of all attached dynamic-link libraries (DLLs) is invoked with a value indicating that the thread is detaching from the DLL.
		/// If the thread is the last thread in the process when this function is called, the thread's process is also terminated.
		/// The state of the thread object becomes signaled, releasing any other threads that had been waiting for the thread to terminate.
		/// The thread's termination status changes from STILL_ACTIVE to the value of the dwExitCode parameter.
		/// </para>
		/// <para>
		/// Terminating a thread does not necessarily remove the thread object from the operating system.
		/// A thread object is deleted when the last handle to the thread is closed.
		/// The <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" />, ExitThread, CreateThread"/&gt;, CreateRemoteThread functions,
		/// and a process that is starting (as the result of a CreateProcess call) are serialized between each other within a process.
		/// Only one of these events can happen in an address space at a time.
		/// This means the following restrictions hold:
		/// </para>
		/// <list>
		/// <item>During process startup and DLL initialization routines, new threads can be created, but they do not begin execution until DLL initialization is done for the process.</item>
		/// <item>Only one thread in a process can be in a DLL initialization or detach routine at a time.</item>
		/// <item>ExitProcess does not return until no threads are in their DLL initialization or detach routines.</item>
		/// </list>
		/// <para>
		/// A thread in an executable that is linked to the static C run-time library(CRT) should use _beginthread and _endthread for thread management
		/// rather than CreateThread and ExitThread.
		/// Failure to do so results in small memory leaks when the thread calls ExitThread.
		/// Another work around is to link the executable to the CRT in a DLL instead of the static CRT.
		/// Note that this memory leak only occurs from a DLL if the DLL is linked to the static CRT and a thread calls the DisableThreadLibraryCalls function.
		/// Otherwise, it is safe to call CreateThread and ExitThread from a thread in a DLL that links to the static CRT.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern void ExitThread(int dwExitCode);

		/// <summary>
		/// Retrieves the termination status of the specified thread.
		/// </summary>
		/// <param name="hThread">
		/// A handle to the thread. The handle must have the THREAD_QUERY_INFORMATION or THREAD_QUERY_LIMITED_INFORMATION access right.
		/// Windows Server 2003 and Windows XP:  The handle must have the THREAD_QUERY_INFORMATION access right.
		/// </param>
		/// <param name="lpExitCode">A pointer to a variable to receive the thread termination status. For more information, see Remarks.</param>
		/// <returns>If the function is succeeds, the return value is true, else the return value is zero.  To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</returns>
		/// <remarks>
		/// <para>
		/// This function returns immediately. If the specified thread has not terminated and the function succeeds, the status returned is STILL_ACTIVE.
		/// If the thread has terminated and the function succeeds, the status returned is one of the following values:
		/// </para>
		/// <list>
		/// <item>The exit value specified in the <see cref="M:PInvoke.Kernel32.ExitThread(System.Int32)" /> or <see cref="M:PInvoke.Kernel32.TerminateThread(System.IntPtr,System.Int32)" /> function.</item>
		/// <item>The return value from the thread function.</item>
		/// <item>he exit value of the thread's process.</item>
		/// </list>
		/// <para>
		/// Important: The GetExitCodeThread function returns a valid error code defined by the application only after the thread terminates.
		/// Therefore, an application should not use STILL_ACTIVE (259) as an error code.
		/// If a thread returns STILL_ACTIVE (259) as an error code, applications that test for this value could interpret it to mean that the thread is still running
		/// and continue to test for the completion of the thread after the thread has terminated, which could put the application into an infinite loop.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetExitCodeThread(IntPtr hThread, out int lpExitCode);

		/// <summary>
		/// Retrieves the termination status of the specified process.
		/// </summary>
		/// <param name="hProcess">
		/// A handle to the process. The handle must have the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right.
		/// Windows Server 2003 and Windows XP:  The handle must have the PROCESS_QUERY_INFORMATION access right.
		/// </param>
		/// <param name="lpExitCode">A pointer to a variable to receive the process termination status. For more information, see Remarks.</param>
		/// <returns>If the function is succeeds, the return value is true, else the return value is zero.  To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</returns>
		/// <remarks>
		/// <para>
		/// This function returns immediately.
		/// If the process has not terminated and the function succeeds, the status returned is STILL_ACTIVE.
		/// If the process has terminated and the function succeeds, the status returned is one of the following values:
		/// </para>
		/// <list>
		/// <item>The exit value specified in the <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" /> or <see cref="M:PInvoke.Kernel32.TerminateProcess(System.IntPtr,System.Int32)" /> function.</item>
		/// <item>The return value from the main or WinMain function of the process.</item>
		/// <item>The exception value for an unhandled exception that caused the process to terminate.</item>
		/// </list>
		/// <para>
		/// Important: The GetExitCodeProcess function returns a valid error code defined by the application only after the thread terminates.
		/// Therefore, an application should not use STILL_ACTIVE (259) as an error code.
		/// If a thread returns STILL_ACTIVE (259) as an error code, applications that test for this value could interpret it to mean that the thread is still running
		/// and continue to test for the completion of the thread after the thread has terminated, which could put the application into an infinite loop.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetExitCodeProcess(IntPtr hProcess, out int lpExitCode);

		/// <summary>
		/// Sets shutdown parameters for the currently calling process. This function sets a shutdown order for a process relative to the other processes in the system.
		/// </summary>
		/// <param name="dwLevel">
		/// The shutdown priority for a process relative to other processes in the system. The system shuts down processes from high dwLevel values to low.
		/// The highest and lowest shutdown priorities are reserved for system components.
		/// This parameter must be in the following range of values:
		/// <list>
		/// <item>0x000-0x0FF: System reserved last shutdown range.</item>
		/// <item>100-1FF: Application reserved last shutdown range.</item>
		/// <item>200-2FF: Application reserved "in between" shutdown range.</item>
		/// <item>0x280: All processes start at this shutdown level.</item>         /// <item>300-3FF: Application reserved first shutdown range.</item>
		/// <item>400-4FF: System reserved first shutdown range.</item>
		/// </list>
		/// </param>
		/// <param name="dwFlags">Flag to indicate if a retry box should appear for the user when the process terminate.</param>
		/// <returns>If the function is succeeds, the return value is true, else the return value is zero.  To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</returns>
		/// <remarks>
		/// Applications running in the system security context do not get shut down by the operating system.
		/// They get notified of shutdown or logoff through the callback function installable via <see cref="M:PInvoke.Kernel32.SetConsoleCtrlHandler(PInvoke.Kernel32.HandlerRoutine,System.Boolean)" />.
		/// They also get notified in the order specified by the dwLevel parameter.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetProcessShutdownParameters(int dwLevel, Kernel32.ProcessShutdownFlags dwFlags);

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the calling process.
		/// If the calling process is impersonating another user, the new process uses the token for the calling process, not the impersonation token. To run the new process in the security context of the user represented by the impersonation token, use the <see cref="M:PInvoke.Kernel32.CreateProcessAsUser(System.IntPtr,System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" /> or CreateProcessWithLogonW function.
		/// </summary>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool CreateProcess(string lpApplicationName, string lpCommandLine,
		                                               Kernel32.SECURITY_ATTRIBUTES* lpProcessAttributes,
		                                               Kernel32.SECURITY_ATTRIBUTES* lpThreadAttributes,
		                                               [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                               Kernel32.CreateProcessFlags dwCreationFlags, void* lpEnvironment,
		                                               string lpCurrentDirectory,
		                                               ref Kernel32.STARTUPINFO lpStartupInfo,
		                                               out Kernel32.PROCESS_INFORMATION lpProcessInformation);

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the user represented by the specified token.
		/// Typically, the process that calls the CreateProcessAsUser function must have the SE_INCREASE_QUOTA_NAME privilege and may require the SE_ASSIGNPRIMARYTOKEN_NAME privilege if the token is not assignable. If this function fails with ERROR_PRIVILEGE_NOT_HELD (1314), use the CreateProcessWithLogonW function instead. CreateProcessWithLogonW requires no special privileges, but the specified user account must be allowed to log on interactively. Generally, it is best to use CreateProcessWithLogonW to create a process with alternate credentials.
		/// </summary>
		/// <param name="hToken">
		/// A handle to the primary token that represents a user. The handle must have the TOKEN_QUERY, TOKEN_DUPLICATE, and TOKEN_ASSIGN_PRIMARY access rights. For more information, see Access Rights for Access-Token Objects. The user represented by the token must have read and execute access to the application specified by the <paramref name="lpApplicationName" /> or the <paramref name="lpCommandLine" /> parameter.
		/// To get a primary token that represents the specified user, call the LogonUser function. Alternatively, you can call the DuplicateTokenEx function to convert an impersonation token into a primary token. This allows a server application that is impersonating a client to create a process that has the security context of the client.
		/// If hToken is a restricted version of the caller's primary token, the SE_ASSIGNPRIMARYTOKEN_NAME privilege is not required. If the necessary privileges are not already enabled, CreateProcessAsUser enables them for the duration of the call. For more information, see Running with Special Privileges.
		/// Terminal Services:  The process is run in the session specified in the token. By default, this is the same session that called LogonUser. To change the session, use the SetTokenInformation function.
		/// </param>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool CreateProcessAsUser(IntPtr hToken, string lpApplicationName,
		                                                     string lpCommandLine,
		                                                     Kernel32.SECURITY_ATTRIBUTES* lpProcessAttributes,
		                                                     Kernel32.SECURITY_ATTRIBUTES* lpThreadAttributes,
		                                                     [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                                     Kernel32.CreateProcessFlags dwCreationFlags,
		                                                     void* lpEnvironment, string lpCurrentDirectory,
		                                                     ref Kernel32.STARTUPINFO lpStartupInfo,
		                                                     out Kernel32.PROCESS_INFORMATION lpProcessInformation);

		/// <summary>
		/// Retrieves the contents of the <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> structure that was specified when the calling process was created.
		/// </summary>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> structure that receives the startup information.
		/// </param>
		/// <remarks>
		/// This function does not return a value, and does not fail.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern void GetStartupInfo(out Kernel32.STARTUPINFO lpStartupInfo);

		/// <summary>
		/// Initializes the specified list of attributes for process and thread creation.
		/// </summary>
		/// <param name="lpAttributeList">
		/// The attribute list. This parameter can be NULL to determine the buffer size required to support the specified number of attributes.
		/// </param>
		/// <param name="dwAttributeCount">
		/// The count of attributes to be added to the list.
		/// </param>
		/// <param name="dwFlags">
		/// This parameter is reserved and must be zero.
		/// </param>
		/// <param name="lpSize">
		/// If lpAttributeList is not NULL, this parameter specifies the size in bytes of the lpAttributeList buffer on input. On output, this parameter receives the size in bytes of the initialized attribute list.
		/// If lpAttributeList is NULL, this parameter receives the required buffer size in bytes.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// First, call this function with the <paramref name="dwAttributeCount " /> parameter set to the maximum number of attributes you will be using and the lpAttributeList to NULL. The function returns the required buffer size in bytes in the lpSize parameter. Allocate enough space for the data in the lpAttributeList buffer and call the function again to initialize the buffer.
		/// To add attributes to the list, call the <see cref="M:PInvoke.Kernel32.UpdateProcThreadAttribute(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.UInt32,System.UInt32@,System.Void*,System.IntPtr,System.IntPtr@,System.IntPtr@)" /> function. To specify these attributes when creating a process, specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the dwCreationFlag parameter and a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure in the lpStartupInfo parameter. Note that you can specify the same <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure to multiple child processes.
		/// When you have finished using the list, call the <see cref="M:PInvoke.Kernel32.DeleteProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*)" /> function.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool InitializeProcThreadAttributeList(
			Kernel32.PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList, int dwAttributeCount, uint dwFlags,
			ref IntPtr lpSize);

		/// <summary>
		/// Updates the specified attribute in a list of attributes for process and thread creation.
		/// </summary>
		/// <param name="lpAttributeList">
		/// A pointer to an attribute list created by the <see cref="M:PInvoke.Kernel32.InitializeProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.Int32,System.UInt32,System.IntPtr@)" /> function.
		/// </param>
		/// <param name="dwFlags">
		/// This parameter is reserved and must be zero.
		/// </param>
		/// <param name="Attribute">
		/// The attribute key to update in the attribute list.
		/// </param>
		/// <param name="lpValue">
		/// A pointer to the attribute value. This value should persist until the attribute is destroyed using the <see cref="M:PInvoke.Kernel32.DeleteProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*)" /> function.
		/// </param>
		/// <param name="cbSize">
		/// The size of the attribute value specified by the <paramref name="lpValue" /> parameter.
		/// </param>
		/// <param name="lpPreviousValue">
		/// This parameter is reserved and must be NULL.
		/// </param>
		/// <param name="lpReturnSize">This parameter is reserved and must be NULL.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool UpdateProcThreadAttribute(Kernel32.PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList,
		                                                           uint dwFlags, ref uint Attribute, void* lpValue,
		                                                           IntPtr cbSize, ref IntPtr lpPreviousValue,
		                                                           ref IntPtr lpReturnSize);

		/// <summary>
		/// Deletes the specified list of attributes for process and thread creation.
		/// </summary>
		/// <param name="lpAttributeList">
		/// The attribute list. This list is created by the <see cref="M:PInvoke.Kernel32.InitializeProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.Int32,System.UInt32,System.IntPtr@)" /> function.
		/// </param>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern unsafe void DeleteProcThreadAttributeList(
			Kernel32.PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList);

		/// <summary>Allocates a new console for the calling process.</summary>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AllocConsole();

		/// <summary>Detaches the calling process from its console.</summary>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeConsole();

		/// <summary>
		/// Attaches the calling process to the console of the specified process.
		/// </summary>
		/// <param name="dwProcessId">
		/// The identifier of the process whose console is to be used. This parameter can be one of the following values.
		/// pid: Use the console of the specified process.
		/// -1: Use the console of the parent of the current process.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AttachConsole(int dwProcessId);

		/// <summary>
		/// Creates or opens a file or I/O device. The most commonly used I/O devices are as follows: file, file stream, directory, physical disk, volume, console buffer, tape drive, communications resource, mailslot, and pipe. The function returns a handle that can be used to access the file or device for various types of I/O depending on the file or device and the flags and attributes specified.
		/// To perform this operation as a transacted operation, which results in a handle that can be used for transacted I/O, use the CreateFileTransacted function.
		/// </summary>
		/// <param name="filename">
		/// The name of the file or device to be created or opened. You may use either forward slashes (/) or backslashes (\) in this name.
		/// In the ANSI version of this function, the name is limited to <see cref="F:PInvoke.Kernel32.MAX_PATH" /> characters. To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.
		/// For information on special device names, see Defining an MS-DOS Device Name.
		/// To create a file stream, specify the name of the file, a colon, and then the name of the stream.For more information, see File Streams.
		/// </param>
		/// <param name="access">
		/// The requested access to the file or device, which can be summarized as read, write, both or neither zero).
		/// The most commonly used values are <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" />, <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_WRITE" />, or both(<see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> | <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_WRITE" />). For more information, see Generic Access Rights, File Security and Access Rights, File Access Rights Constants, and ACCESS_MASK.
		/// If this parameter is zero, the application can query certain metadata such as file, directory, or device attributes without accessing that file or device, even if <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> access would have been denied.
		/// You cannot request an access mode that conflicts with the sharing mode that is specified by the dwShareMode parameter in an open request that already has an open handle.
		/// For more information, see the Remarks section of this topic and Creating and Opening Files.
		/// Common specific rights are defined in <seealso cref="T:PInvoke.Kernel32.FileAccess" />.
		/// </param>
		/// <param name="share">
		/// The requested sharing mode of the file or device, which can be read, write, both, delete, all of these, or none (refer to the following table). Access requests to attributes or extended attributes are not affected by this flag.
		/// If this parameter is zero and <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> succeeds, the file or device cannot be shared and cannot be opened again until the handle to the file or device is closed. For more information, see the Remarks section.
		/// You cannot request a sharing mode that conflicts with the access mode that is specified in an existing request that has an open handle. <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> would fail and the <see cref="M:PInvoke.Kernel32.GetLastError" /> function would return ERROR_SHARING_VIOLATION.
		/// To enable a process to share a file or device while another process has the file or device open, use a compatible combination of one or more of the following values. For more information about valid combinations of this parameter with the dwDesiredAccess parameter, see Creating and Opening Files.
		/// </param>
		/// <param name="securityAttributes">
		/// A pointer to a SECURITY_ATTRIBUTES structure that contains two separate but related data members: an optional security descriptor, and a Boolean value that determines whether the returned handle can be inherited by child processes.
		/// This parameter can be NULL.
		/// If this parameter is NULL, the handle returned by CreateFile cannot be inherited by any child processes the application may create and the file or device associated with the returned handle gets a default security descriptor.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a <see cref="T:PInvoke.Kernel32.SECURITY_DESCRIPTOR" /> for a file or device. If this member is NULL, the file or device associated with the returned handle is assigned a default security descriptor.
		/// CreateFile ignores the <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member when opening an existing file or device, but continues to use the <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.bInheritHandle" /> member.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.bInheritHandle" /> member of the structure specifies whether the returned handle can be inherited.
		/// </param>
		/// <param name="creationDisposition">
		/// An action to take on a file or device that exists or does not exist.
		/// For devices other than files, this parameter is usually set to <see cref="F:PInvoke.Kernel32.CreationDisposition.OPEN_EXISTING" />.
		/// </param>
		/// <param name="flagsAndAttributes">
		/// The file or device attributes and flags, <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_ATTRIBUTE_NORMAL" /> being the most common default value for files.
		/// This parameter can include any combination of the available file attributes (CreateFileFlags.*Attribute). All other file attributes override <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_ATTRIBUTE_NORMAL" />.
		/// This parameter can also contain combinations of flags (CreateFileFlags.*Flag) for control of file or device caching behavior, access modes, and other special-purpose flags. These combine with any CreateFileFlags.*Attribute values.
		/// This parameter can also contain Security Quality of Service (SQOS) information by specifying the SECURITY_SQOS_PRESENT flag. Additional SQOS-related flags information is presented in the table following the attributes and flags tables.
		/// Note When CreateFile opens an existing file, it generally combines the file flags with the file attributes of the existing file, and ignores any file attributes supplied as part of dwFlagsAndAttributes. Special cases are detailed in Creating and Opening Files.
		/// Some of the following file attributes and flags may only apply to files and not necessarily all other types of devices that CreateFile can open.For additional information, see the Remarks section of this topic and Creating and Opening Files.
		/// For more advanced access to file attributes, see SetFileAttributes. For a complete list of all file attributes with their values and descriptions, see File Attribute Constants.
		/// </param>
		/// <param name="templateFile">
		/// A valid handle to a template file with the <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> access right. The template file supplies file attributes and extended attributes for the file that is being created.
		/// This parameter can be NULL.
		/// When opening an existing file, CreateFile ignores this parameter.
		/// When opening a new encrypted file, the file inherits the discretionary access control list from its parent directory.For additional information, see File Encryption.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is an open handle to the specified file, device, named pipe, or mail slot.
		/// If the function fails, the return value is INVALID_HANDLE_VALUE.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe Kernel32.SafeObjectHandle CreateFile(
			string filename, Kernel32.ACCESS_MASK access, Kernel32.FileShare share,
			Kernel32.SECURITY_ATTRIBUTES* securityAttributes, Kernel32.CreationDisposition creationDisposition,
			Kernel32.CreateFileFlags flagsAndAttributes, Kernel32.SafeObjectHandle templateFile);

		/// <summary>
		/// Searches a directory for a file or subdirectory with a name that matches a specific name (or partial name if wildcards are used).
		/// To specify additional attributes to use in a search, use the FindFirstFileEx function.
		/// To perform this operation as a transacted operation, use the FindFirstFileTransacted function.
		/// </summary>
		/// <param name="lpFileName">
		/// The directory or path, and the file name, which can include wildcard characters, for example, an asterisk (*) or a question mark (?).
		/// This parameter should not be NULL, an invalid string (for example, an empty string or a string that is missing the terminating null character), or end in a trailing backslash(\).
		/// If the string ends with a wildcard, period(.), or directory name, the user must have access permissions to the root and all subdirectories on the path.
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming a File.
		/// </param>
		/// <param name="lpFindFileData">A pointer to the WIN32_FIND_DATA structure that receives information about a found file or directory.</param>
		/// <returns>
		/// If the function succeeds, the return value is a search handle used in a subsequent call to FindNextFile or FindClose, and the lpFindFileData parameter contains information about the first file or directory found.
		/// If the function fails or fails to locate files from the search string in the lpFileName parameter, the return value is INVALID_HANDLE_VALUE and the contents of lpFindFileData are indeterminate.To get extended error information, call the <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		/// If the function fails because no matching files can be found, the <see cref="M:PInvoke.Kernel32.GetLastError" /> function returns ERROR_FILE_NOT_FOUND.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern Kernel32.SafeFindFilesHandle FindFirstFile(
			string lpFileName, out Kernel32.WIN32_FIND_DATA lpFindFileData);

		/// <summary>
		/// Continues a file search from a previous call to the <see cref="M:PInvoke.Kernel32.FindFirstFile(System.String,PInvoke.Kernel32.WIN32_FIND_DATA@)" />, FindFirstFileEx, or FindFirstFileTransacted functions.
		/// </summary>
		/// <param name="hFindFile">The search handle returned by a previous call to the FindFirstFile or FindFirstFileEx function.</param>
		/// <param name="lpFindFileData">A pointer to the WIN32_FIND_DATA structure that receives information about the found file or subdirectory.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero and the lpFindFileData parameter contains information about the next file or directory found.
		/// If the function fails, the return value is zero and the contents of lpFindFileData are indeterminate. To get extended error information, call the <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		/// If the function fails because no more matching files can be found, the <see cref="M:PInvoke.Kernel32.GetLastError" /> function returns ERROR_NO_MORE_FILES.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool FindNextFile(Kernel32.SafeFindFilesHandle hFindFile,
		                                       out Kernel32.WIN32_FIND_DATA lpFindFileData);

		/// <summary>
		/// Takes a snapshot of the specified processes, as well as the heaps, modules, and threads used by these
		/// processes.
		/// </summary>
		/// <param name="dwFlags">The portions of the system to be included in the snapshot.</param>
		/// <param name="th32ProcessID">
		/// The process identifier of the process to be included in the snapshot. This parameter can be zero to indicate the
		/// current process. This parameter is used when the <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPHEAPLIST" />,
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPMODULE" />,
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPMODULE32" />, or
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPALL" /> value is specified. Otherwise, it is ignored and all
		/// processes are included in the snapshot.
		/// <para>
		/// If the specified process is the Idle process or one of the CSRSS processes, this function fails and the last
		/// error code is <see cref="F:PInvoke.Win32ErrorCode.ERROR_ACCESS_DENIED" /> because their access restrictions prevent user-level
		/// code from opening them.
		/// </para>
		/// <para>
		/// If the specified process is a 64-bit process and the caller is a 32-bit process, this function fails and the last
		/// error code is <see cref="F:PInvoke.Win32ErrorCode.ERROR_PARTIAL_COPY" />.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, it returns an open handle to the specified snapshot.
		/// <para>
		/// If the function fails, it returns <see cref="F:PInvoke.Kernel32.INVALID_HANDLE_VALUE" />. To get extended error information, call
		/// <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" />. Possible error codes include
		/// <see cref="F:PInvoke.Win32ErrorCode.ERROR_BAD_LENGTH" />.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The snapshot taken by this function is examined by the other tool help functions to provide their results.Access to the
		/// snapshot is read only.The snapshot handle acts as an object handle and is subject to the same rules regarding which
		/// processes and threads it is valid in.
		/// <para>
		/// To enumerate the heap or module states for all processes, specify
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPALL" /> and set <paramref name="th32ProcessID" /> to zero.Then, for
		/// each additional process in the snapshot, call CreateToolhelp32Snapshot again, specifying its process identifier and the
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPHEAPLIST" /> or
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPMODULE" /> value.
		/// </para>
		/// <para>
		/// When taking snapshots that include heaps and modules for a process other than the current process, the
		/// CreateToolhelp32Snapshot function can fail or return incorrect information for a variety of reasons. For example, if
		/// the loader data table in the target process is corrupted or not initialized, or if the module list changes during the
		/// function call as a result of DLLs being loaded or unloaded, the function might fail with
		/// <see cref="F:PInvoke.Win32ErrorCode.ERROR_BAD_LENGTH" /> or other error code. Ensure that the target process was not started in a
		/// suspended state, and try calling the function again. If the function fails with
		/// <see cref="F:PInvoke.Win32ErrorCode.ERROR_BAD_LENGTH" /> when called with
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPMODULE" /> or
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPMODULE32" />, call the function again until it succeeds.
		/// </para>
		/// <para>
		/// The <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPMODULE" /> and
		/// <see cref="F:PInvoke.Kernel32.CreateToolhelp32SnapshotFlags.TH32CS_SNAPMODULE32" /> flags do not retrieve handles for modules that were
		/// loaded with the LOAD_LIBRARY_AS_DATAFILE or similar flags. For more information, see LoadLibraryEx.
		/// </para>
		/// <para>To destroy the snapshot, call <see cref="M:System.Runtime.InteropServices.SafeHandle.Close" /> on the returned handle.</para>
		/// <para>
		/// Note that you can use the
		/// <see cref="M:PInvoke.Kernel32.QueryFullProcessImageName(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.QueryFullProcessImageNameFlags,System.Char*,System.Int32@)" />
		/// function to retrieve the full name of an executable image for both 32- and 64-bit processes from a 32-bit process.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern Kernel32.SafeObjectHandle CreateToolhelp32Snapshot(
			Kernel32.CreateToolhelp32SnapshotFlags dwFlags, int th32ProcessID);

		/// <summary>Retrieves information about the first process encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		/// A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <param name="lppe">
		/// Contains process information such as the name of the executable file, the process identifier, and
		/// the process identifier of the parent process.
		/// </param>
		/// <returns>
		/// Returns <see langword="true" /> if the first entry of the process list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no processes exist or the snapshot does not contain process
		/// information.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool Process32First(Kernel32.SafeObjectHandle hSnapshot,
		                                                Kernel32.PROCESSENTRY32* lppe);

		/// <summary>Retrieves information about the next process recorded in a system snapshot.</summary>
		/// <param name="hSnapshot">
		/// A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <param name="lppe">A <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> structure.</param>
		/// <returns>
		/// Returns <see langword="true" /> if the next entry of the process list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no processes exist or the snapshot does not contain process
		/// information.
		/// </returns>
		/// <remarks>
		/// To retrieve information about the first process recorded in a snapshot, use the
		/// <see cref="M:PInvoke.Kernel32.Process32First(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.PROCESSENTRY32*)" />
		/// function.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool Process32Next(Kernel32.SafeObjectHandle hSnapshot,
		                                               Kernel32.PROCESSENTRY32* lppe);

		/// <summary>
		/// Retrieves information about the first module associated with a process.
		/// </summary>
		/// <param name="hSnapshot">A handle to the snapshot returned from a previous call to the <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.</param>
		/// <param name="lpme">A <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> structure.</param>
		/// <returns>
		/// Returns <see langword="true" /> if the first entry of the module list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no modules exist or the snapshot does not contain module
		/// information.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool Module32First(Kernel32.SafeObjectHandle hSnapshot,
		                                               Kernel32.MODULEENTRY32* lpme);

		/// <summary>Retrieves information about the next process recorded in a system snapshot.</summary>
		/// <param name="hSnapshot">A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.</param>
		/// <param name="lpme">A <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> structure.</param>
		/// <returns>Returns <see langword="true" /> if the next entry of the module list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no modules exist or the snapshot does not contain module
		/// information.</returns>
		/// <remarks>
		/// To retrieve information about the first module recorded in a snapshot, use the
		/// <see cref="M:PInvoke.Kernel32.Module32First(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.MODULEENTRY32*)" />
		/// function.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool
			Module32Next(Kernel32.SafeObjectHandle hSnapshot, Kernel32.MODULEENTRY32* lpme);

		/// <summary>Retrieves the full name of the executable image for the specified process.</summary>
		/// <param name="hProcess">
		/// A handle to the process. This handle must be created with the
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_INFORMATION" /> or
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_LIMITED_INFORMATION" /> access right.
		/// </param>
		/// <param name="dwFlags">One of the <see cref="T:PInvoke.Kernel32.QueryFullProcessImageNameFlags" /> values.</param>
		/// <param name="lpExeName">The path to the executable image. If the function succeeds, this string is null-terminated.</param>
		/// <param name="lpdwSize">
		/// On input, specifies the size of the lpExeName buffer, in characters. On success, receives the
		/// number of characters written to the buffer, not including the null-terminating character.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</para>
		/// </returns>
		/// <remarks>Minimum OS: Windows Vista / Windows Server 2008.</remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool QueryFullProcessImageName(Kernel32.SafeObjectHandle hProcess,
		                                                           Kernel32.QueryFullProcessImageNameFlags dwFlags,
		                                                           char* lpExeName, ref int lpdwSize);

		/// <summary>Retrieves the full name of the executable image for the specified process.</summary>
		/// <param name="hProcess">
		/// A handle to the process. This handle must be created with the
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_INFORMATION" /> or
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_LIMITED_INFORMATION" /> access right.
		/// </param>
		/// <param name="dwFlags">One of the <see cref="T:PInvoke.Kernel32.QueryFullProcessImageNameFlags" /> values.</param>
		/// <param name="lpExeName">The path to the executable image. If the function succeeds, this string is null-terminated.</param>
		/// <param name="lpdwSize">
		/// On input, specifies the size of the lpExeName buffer, in characters. On success, receives the
		/// number of characters written to the buffer, not including the null-terminating character.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</para>
		/// </returns>
		/// <remarks>Minimum OS: Windows Vista / Windows Server 2008.</remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool QueryFullProcessImageName(Kernel32.SafeObjectHandle hProcess,
		                                                    Kernel32.QueryFullProcessImageNameFlags dwFlags,
		                                                    StringBuilder lpExeName, ref int lpdwSize);

		/// <summary>Opens an existing local process object.</summary>
		/// <param name="dwDesiredAccess">
		/// The access to the process object. This access right is checked against the security descriptor for the process. This
		/// parameter can be one or more of the <see cref="T:PInvoke.Kernel32.ProcessAccess" /> values.
		/// <para>
		/// If the caller has enabled the SeDebugPrivilege privilege, the requested access is granted regardless of the
		/// contents of the security descriptor.
		/// </para>
		/// </param>
		/// <param name="bInheritHandle">
		/// If this value is <see langword="true" />, processes created by this process will inherit
		/// the handle. Otherwise, the processes do not inherit this handle.
		/// </param>
		/// <param name="dwProcessId">
		/// The identifier of the local process to be opened.
		/// <para>
		/// If the specified process is the System Process(0x00000000), the function fails and the last error code is
		/// <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_PARAMETER" />.If the specified process is the Idle process or one of the CSRSS
		/// processes, this function fails and the last error code is <see cref="F:PInvoke.Win32ErrorCode.ERROR_ACCESS_DENIED" /> because
		/// their access restrictions prevent user-level code from opening them.
		/// </para>
		/// <para>
		/// If you are using <see cref="M:PInvoke.Kernel32.GetCurrentProcessId" /> as an argument to this function, consider using
		/// <see cref="M:PInvoke.Kernel32.GetCurrentProcess" /> instead of OpenProcess, for improved performance.
		/// </para>
		/// </param>
		/// <returns>If the function succeeds, the return value is an open handle to the specified process.</returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern Kernel32.SafeObjectHandle OpenProcess(Kernel32.ACCESS_MASK dwDesiredAccess,
		                                                           bool bInheritHandle, int dwProcessId);

		/// <summary>
		/// Retrieves the results of an overlapped operation on the specified file, named pipe, or communications device.
		/// To specify a timeout interval or wait on an alertable thread, use GetOverlappedResultEx.
		/// </summary>
		/// <param name="hFile">
		/// A handle to the file, named pipe, or communications device. This is the same handle that was
		/// specified when the overlapped operation was started by a call to the ReadFile, WriteFile, ConnectNamedPipe,
		/// TransactNamedPipe, DeviceIoControl, or WaitCommEvent function.
		/// </param>
		/// <param name="lpOverlapped">
		/// A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure that was specified when the overlapped
		/// operation was started.
		/// </param>
		/// <param name="lpNumberOfBytesTransferred">
		/// A pointer to a variable that receives the number of bytes that were actually
		/// transferred by a read or write operation. For a TransactNamedPipe operation, this is the number of bytes that were read
		/// from the pipe. For a DeviceIoControl operation, this is the number of bytes of output data returned by the device
		/// driver. For a ConnectNamedPipe or WaitCommEvent operation, this value is undefined.
		/// </param>
		/// <param name="bWait">
		/// If this parameter is TRUE, and the Internal member of the lpOverlapped structure is STATUS_PENDING,
		/// the function does not return until the operation has been completed. If this parameter is FALSE and the operation is
		/// still pending, the function returns FALSE and the <see cref="M:PInvoke.Kernel32.GetLastError" /> function returns
		/// <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_INCOMPLETE" />.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero.To get extended error information, call
		/// <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The results reported by the GetOverlappedResult function are those of the specified handle's last overlapped operation
		/// to which the specified <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure was provided, and for which the operation's results were
		/// pending. A pending operation is indicated when the function that started the operation returns FALSE, and the
		/// GetLastError function returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" />. When an I/O operation is pending, the
		/// function that started the operation resets the hEvent member of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure to the
		/// nonsignaled state. Then when the pending operation has been completed, the system sets the event object to the signaled
		/// state.
		/// <para>
		/// If the bWait parameter is TRUE, GetOverlappedResult determines whether the pending operation has been completed
		/// by waiting for the event object to be in the signaled state.
		/// </para>
		/// <para>
		/// If the hEvent member of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is NULL, the system uses the state of the hFile
		/// handle to signal when the operation has been completed. Use of file, named pipe, or communications-device handles for
		/// this purpose is discouraged. It is safer to use an event object because of the confusion that can occur when multiple
		/// simultaneous overlapped operations are performed on the same file, named pipe, or communications device. In this
		/// situation, there is no way to know which operation caused the object's state to be signaled.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool GetOverlappedResult(Kernel32.SafeObjectHandle hFile,
		                                                     Kernel32.OVERLAPPED* lpOverlapped,
		                                                     out int lpNumberOfBytesTransferred, bool bWait);

		/// <summary>
		/// Cancels all pending input and output (I/O) operations that are issued by the calling thread for the specified file. The
		/// function does not cancel I/O operations that other threads issue for a file handle.
		/// <para>To cancel I/O operations from another thread, use the CancelIoEx function.</para>
		/// </summary>
		/// <param name="hFile">
		/// A handle to the file.
		/// <para>The function cancels all pending I/O operations for this file handle.</para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. The cancel operation for all pending I/O operations issued by
		/// the calling thread for the specified file handle was successfully requested. The thread can use the
		/// <see cref="M:PInvoke.Kernel32.GetOverlappedResult(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.OVERLAPPED*,System.Int32@,System.Boolean)" /> function to determine when the I/O operations themselves have been completed.
		/// <para>
		/// If the function fails, the return value is zero (0). To get extended error information, call the
		/// <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		/// </para>
		/// </returns>
		/// <remarks>
		/// If there are any pending I/O operations in progress for the specified file handle, and they are issued by the calling
		/// thread, the CancelIo function cancels them. CancelIo cancels only outstanding I/O on the handle, it does not change the
		/// state of the handle; this means that you cannot rely on the state of the handle because you cannot know whether the
		/// operation was completed successfully or canceled.
		/// <para>
		/// The I/O operations must be issued as overlapped I/O. If they are not, the I/O operations do not return to allow
		/// the thread to call the CancelIo function. Calling the CancelIo function with a file handle that is not opened with
		/// FILE_FLAG_OVERLAPPED does nothing.
		/// </para>
		/// <para>
		/// All I/O operations that are canceled complete with the error
		/// <see cref="F:PInvoke.Win32ErrorCode.ERROR_OPERATION_ABORTED" />, and all completion notifications for the I/O operations occur
		/// normally.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool CancelIo(Kernel32.SafeObjectHandle hFile);

		/// <summary>
		/// Determines whether the specified process is running under WOW64 (x86 emulator that allows 32-bit Windows-based
		/// applications to run seamlessly on 64-bit Windows)
		/// </summary>
		/// <param name="hProcess">
		/// A handle to the process. The handle must have the <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_INFORMATION" /> or
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_LIMITED_INFORMATION" /> access right.
		/// <para>
		/// Windows Server 2003 and Windows XP:  The handle must have the
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_INFORMATION" /> access right.
		/// </para>
		/// </param>
		/// <param name="Wow64Process">
		/// A pointer to a value that is set to <see langword="true" /> if the process is running under
		/// WOW64. If the process is running under 32-bit Windows, the value is set to <see langword="false" />. If the process is
		/// a 64-bit application running under 64-bit Windows, the value is also set to <see langword="false" />.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a nonzero value.
		/// <para>
		/// If the function fails, the return value is zero. To get extended error information, call
		/// <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool IsWow64Process(Kernel32.SafeObjectHandle hProcess, out bool Wow64Process);

		/// <summary>Creates an anonymous pipe, and returns handles to the read and write ends of the pipe.</summary>
		/// <param name="hReadPipe">A pointer to a variable that receives the read handle for the pipe.</param>
		/// <param name="hWritePipe">A pointer to a variable that receives the write handle for the pipe.</param>
		/// <param name="lpPipeAttributes">
		///     A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that determines whether the returned handle can be
		///     inherited by child processes. If <paramref name="lpPipeAttributes" />  is NULL, the handle cannot be inherited.
		///     <para>
		///         The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a security
		///         descriptor for the new pipe. If <paramref name="lpPipeAttributes" />  is NULL, the pipe gets a default security descriptor. The ACLs
		///         in the default security descriptor for a pipe come from the primary or impersonation token of the creator.
		///     </para>
		/// </param>
		/// <param name="nSize">
		///     The size of the buffer for the pipe, in bytes. The size is only a suggestion; the system uses the
		///     value to calculate an appropriate buffering mechanism. If this parameter is zero, the system uses the default
		///     buffer size.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a nonzero value.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool CreatePipe(out Kernel32.SafeObjectHandle hReadPipe,
		                                            out Kernel32.SafeObjectHandle hWritePipe,
		                                            Kernel32.SECURITY_ATTRIBUTES* lpPipeAttributes, int nSize);

		/// <summary>Removes as many pages as possible from the working set of the specified process.</summary>
		/// <param name="hProcess">
		///     A handle to the process. The handle must have the PROCESS_QUERY_INFORMATION or
		///     PROCESS_QUERY_LIMITED_INFORMATION access right and the PROCESS_SET_QUOTA access right.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		/// <remarks>
		///     This function is exported by kernel32.dll only since Windows 7, on previous version of windows it's
		///     exported by Psapi.dll as "EmptyWorkingSet".
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool K32EmptyWorkingSet(Kernel32.SafeObjectHandle hProcess);

		/// <summary>Retrieves the window handle used by the console associated with the calling process.</summary>
		/// <returns>
		///     The return value is a handle to the window used by the console associated with the calling process or
		///     <see cref="F:System.IntPtr.Zero" /> if there is no such associated console.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetConsoleWindow();

		/// <summary>
		///     Loads the specified module into the address space of the calling process. The specified module may cause other
		///     modules to be loaded.
		///     <para>For additional load options, use the LoadLibraryEx function.</para>
		/// </summary>
		/// <param name="lpFileName">
		///     The name of the module. This can be either a library module (a .dll file) or an executable module (an .exe file).
		///     The name specified is the file name of the module and is not related to the name stored in the library module
		///     itself, as specified by the LIBRARY keyword in the module-definition (.def) file.
		///     <para>If the string specifies a full path, the function searches only that path for the module.</para>
		///     <para>
		///         If the string specifies a relative path or a module name without a path, the function uses a standard search
		///         strategy to find the module.
		///     </para>
		///     <para>
		///         If the function cannot find the module, the function fails. When specifying a path, be sure to use
		///         backslashes (\), not forward slashes (/).
		///     </para>
		///     <para>
		///         If the string specifies a module name without a path and the file name extension is omitted, the function
		///         appends the default library extension .dll to the module name. To prevent the function from appending .dll to
		///         the module name, include a trailing point character (.) in the module name string.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the loaded module.
		///     <para>
		///         If the function fails, the return value is an invalid handle. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern Kernel32.SafeLibraryHandle LoadLibrary(string lpFileName);

		/// <summary>
		///     Loads the specified module into the address space of the calling process. The specified module may cause other
		///     modules to be loaded.
		/// </summary>
		/// <param name="lpFileName">
		///     <para>
		///         A string that specifies the file name of the module to load. This name is not related to the name stored in a
		///         library module itself, as specified by the LIBRARY keyword in the module-definition (.def) file.
		///     </para>
		///     <para>
		///         The module can be a library module (a .dll file) or an executable module (an .exe file). If the specified
		///         module is an executable module, static imports are not loaded; instead, the module is loaded as if
		///         <see cref="F:PInvoke.Kernel32.LoadLibraryExFlags.DONT_RESOLVE_DLL_REFERENCES" /> was specified. See the
		///         <paramref name="dwFlags" /> parameter for more information.
		///     </para>
		///     <para>
		///         If the string specifies a module name without a path and the file name extension is omitted, the function
		///         appends the default library extension .dll to the module name. To prevent the function from appending .dll to
		///         the module name, include a trailing point character (.) in the module name string.
		///     </para>
		///     <para>
		///         If the string specifies a fully qualified path, the function searches only that path for the module. When
		///         specifying a path, be sure to use backslashes (\), not forward slashes (/). For more information about paths,
		///         see Naming Files, Paths, and Namespaces.
		///     </para>
		///     <para>
		///         If the string specifies a module name without a path and more than one loaded module has the same base name
		///         and extension, the function returns a handle to the module that was loaded first.
		///     </para>
		///     <para>
		///         If the string specifies a module name without a path and a module of the same name is not already loaded, or
		///         if the string specifies a module name with a relative path, the function searches for the specified module. The
		///         function also searches for modules if loading the specified module causes the system to load other associated
		///         modules (that is, if the module has dependencies). The directories that are searched and the order in which
		///         they are searched depend on the specified path and the dwFlags parameter.
		///     </para>
		///     <para>If the function cannot find the module or one of its dependencies, the function fails.</para>
		/// </param>
		/// <param name="hFile">This parameter is reserved for future use. It must be <see langword="null" />.</param>
		/// <param name="dwFlags">
		///     The action to be taken when loading the module. If <see cref="F:PInvoke.Kernel32.LoadLibraryExFlags.None" /> is
		///     specified, the behavior of this function is identical to that of the LoadLibrary function.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the loaded module.
		///     <para>
		///         If the function fails, the return value is an invalid handle. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern Kernel32.SafeLibraryHandle LoadLibraryEx(string lpFileName, IntPtr hFile,
		                                                              Kernel32.LoadLibraryExFlags dwFlags);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr AddDllDirectory(string NewDirectory);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetDllDirectory(int nBufferLength, char* lpBuffer);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDllDirectory(string lpPathName);

		/// <summary>
		/// Retrieves a module handle for the specified module. The module must have been loaded by the calling process.
		/// </summary>
		/// <param name="lpModuleName">
		/// The name of the loaded module (either a .dll or .exe file).
		/// If the file name extension is omitted, the default library extension .dll is appended.
		/// The file name string can include a trailing point character (.) to indicate that the module name has no extension.
		/// The string does not have to specify a path. When specifying a path, be sure to use backslashes (\), not forward slashes (/).
		/// The name is compared (case independently) to the names of modules currently mapped into the address space of the calling process.
		/// If this parameter is NULL, it returns a handle to the file used to create the calling process (.exe file).
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the specified module.
		/// If the function fails, the return value is NULL.To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// This function does not retrieve handles for modules that were loaded using the <see cref="F:PInvoke.Kernel32.LoadLibraryExFlags.LOAD_LIBRARY_AS_DATAFILE" /> flag.
		/// This function returns a handle to a mapped module without incrementing its reference count.
		/// However, if this handle is passed to the <see cref="M:PInvoke.Kernel32.FreeLibrary(System.IntPtr)" /> function, the reference count of the mapped module will be decremented.
		/// Therefore, do not pass a handle returned by this function to the <see cref="M:PInvoke.Kernel32.FreeLibrary(System.IntPtr)" /> function. Doing so can cause a DLL module to be unmapped prematurely.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern Kernel32.SafeLibraryHandle GetModuleHandle(string lpModuleName);

		/// <summary>
		/// Retrieves a module handle for the specified module and increments the module's reference count unless <see cref="F:PInvoke.Kernel32.GetModuleHandleExFlags.GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT" /> is specified.
		/// The module must have been loaded by the calling process.
		/// </summary>
		/// <param name="dwFlags">
		/// This parameter can be zero or one or more of the following values.
		/// If the module's reference count is incremented, the caller must use the <see cref="M:PInvoke.Kernel32.FreeLibrary(System.IntPtr)" /> function to decrement the reference count when the module handle is no longer needed.</param>
		/// <param name="lpModuleName">The name of the loaded module (either a .dll or .exe file), or an address in the module (if <paramref name="dwFlags" /> is <see cref="F:PInvoke.Kernel32.GetModuleHandleExFlags.GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS" />).</param>
		/// <param name="phModule">
		/// A handle to the specified module. If the function fails, this parameter is NULL.
		/// </param>
		/// <returns>
		/// If the function succeeds, returns true. If the function fails, the returns false.
		/// To get extended error information, see <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// The handle returned is not global or inheritable. It cannot be duplicated or used by another process.
		/// This function does not retrieve handles for modules that were loaded using the <see cref="F:PInvoke.Kernel32.LoadLibraryExFlags.LOAD_LIBRARY_AS_DATAFILE" /> flag.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetModuleHandleEx(Kernel32.GetModuleHandleExFlags dwFlags, string lpModuleName,
		                                            out Kernel32.SafeLibraryHandle phModule);

		/// <summary>
		///     Creates an instance of a named pipe and returns a handle for subsequent pipe operations. A named pipe server
		///     process uses this function either to create the first instance of a specific named pipe and establish its basic
		///     attributes or to create a new instance of an existing named pipe.
		/// </summary>
		/// <param name="lpName">
		///     The unique pipe name. This string must have the following form:
		///     <para>
		///         <code>\\.\pipe\pipename</code>
		///     </para>
		///     <para>
		///         The pipename part of the name can include any character other than a backslash, including numbers and special
		///         characters. The entire pipe name string can be up to 256 characters long. Pipe names are not case sensitive.
		///     </para>
		/// </param>
		/// <param name="dwOpenMode">
		///     The open mode. The function fails if dwOpenMode specifies anything other than 0 or the flags
		///     from <see cref="T:PInvoke.Kernel32.PipeAccessMode" />.
		///     <para>The same mode must be specified for each instance of the pipe.</para>
		/// </param>
		/// <param name="dwPipeMode">
		///     The pipe mode. The function fails if dwPipeMode specifies anything other than 0 or the flags from
		///     <see cref="T:PInvoke.Kernel32.PipeMode" />.
		///     <para>
		///         One of the following type modes can be specified. The same type mode must be specified for each instance of
		///         the pipe.
		///     </para>
		/// </param>
		/// <param name="nMaxInstances">
		///     The maximum number of instances that can be created for this pipe. The first instance of
		///     the pipe can specify this value; the same number must be specified for other instances of the pipe. Acceptable
		///     values are in the range 1 through <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" /> (255). If this parameter is
		///     <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" />, the number of pipe instances that can be created is limited only by the
		///     availability of system resources. If nMaxInstances is greater than <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" />, the
		///     return value is an invalid handle and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///     <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_PARAMETER" />.
		/// </param>
		/// <param name="nOutBufferSize">The number of bytes to reserve for the output buffer.</param>
		/// <param name="nInBufferSize">The number of bytes to reserve for the input buffer.</param>
		/// <param name="nDefaultTimeOut">
		///     The default time-out value, in milliseconds, if the <see cref="M:PInvoke.Kernel32.WaitNamedPipe(System.String,System.Int32)" /> function specifies
		///     NMPWAIT_USE_DEFAULT_WAIT. Each instance of a named pipe must specify the same value.
		/// </param>
		/// <param name="lpSecurityAttributes">
		///     A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a
		///     security descriptor for the new named pipe and determines whether child processes can inherit the returned handle.
		///     If lpSecurityAttributes is NULL, the named pipe gets a default security descriptor and the handle cannot be
		///     inherited. The ACLs in the default security descriptor for a named pipe grant full control to the LocalSystem
		///     account, administrators, and the creator owner. They also grant read access to members of the Everyone group and
		///     the anonymous account.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the server end of a named pipe instance. If the
		///     function fails, the return value is an invalid handle. To get extended error information, call
		///     <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe Kernel32.SafeObjectHandle CreateNamedPipe(
			string lpName, Kernel32.PipeAccessMode dwOpenMode, Kernel32.PipeMode dwPipeMode, int nMaxInstances,
			int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut,
			Kernel32.SECURITY_ATTRIBUTES* lpSecurityAttributes);

		/// <summary>
		///     Waits until either a time-out interval elapses or an instance of the specified named pipe is available for
		///     connection (that is, the pipe's server process has a pending <see cref="M:PInvoke.Kernel32.ConnectNamedPipe(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.OVERLAPPED*)" /> operation on the
		///     pipe).
		/// </summary>
		/// <param name="lpNamedPipeName">
		///     The name of the named pipe. The string must include the name of the computer on which the server process is
		///     executing. A period may be used for the servername if the pipe is local. The following pipe name format is used:
		///     <para>
		///         <code>\\servername\pipe\pipename</code>
		///     </para>
		/// </param>
		/// <param name="nTimeOut">
		///     The number of milliseconds that the function will wait for an instance of the named pipe to be
		///     available. You can also use either <see cref="F:PInvoke.Kernel32.NMPWAIT_USE_DEFAULT_WAIT" /> or <see cref="F:PInvoke.Kernel32.NMPWAIT_WAIT_FOREVER" />
		///     instead of specifying a number of milliseconds.
		/// </param>
		/// <returns>
		///     If an instance of the pipe is available before the time-out interval elapses, the return value is nonzero.
		///     <para>
		///         If an instance of the pipe is not available before the time-out interval elapses, the return value is zero.
		///         To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		///     <para>
		///         If no instances of the specified named pipe exist, the WaitNamedPipe function returns immediately, regardless
		///         of the time-out value.
		///     </para>
		///     <para>
		///         If the time-out interval expires, the WaitNamedPipe function will fail with the error
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_SEM_TIMEOUT" />.
		///     </para>
		///     <para>
		///         If the function succeeds, the process should use the <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function to open a handle to
		///         the named pipe. A return value of TRUE indicates that there is at least one instance of the pipe available. A
		///         subsequent <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> call to the pipe can fail, because the instance was closed by the server
		///         or opened by another client.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool WaitNamedPipe(string lpNamedPipeName, int nTimeOut);

		/// <summary>
		///     Enables a named pipe server process to wait for a client process to connect to an instance of a named pipe. A
		///     client process connects by calling either the CreateFile or CallNamedPipe function.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the server end of a named pipe instance. This handle is returned by the
		///     CreateNamedPipe function.
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an OVERLAPPED structure.
		///     <para>
		///         If hNamedPipe was opened with FILE_FLAG_OVERLAPPED, the lpOverlapped parameter must not be NULL. It must
		///         point to a valid OVERLAPPED structure. If hNamedPipe was opened with FILE_FLAG_OVERLAPPED and lpOverlapped is
		///         NULL, the function can incorrectly report that the connect operation is complete.
		///     </para>
		///     <para>
		///         If hNamedPipe was created with FILE_FLAG_OVERLAPPED and lpOverlapped is not NULL, the OVERLAPPED structure
		///         should contain a handle to a manual-reset event object (which the server can create by using the CreateEvent
		///         function).
		///     </para>
		///     <para>
		///         If hNamedPipe was not opened with FILE_FLAG_OVERLAPPED, the function does not return until a client is
		///         connected or an error occurs. Successful synchronous operations result in the function returning a nonzero
		///         value if a client connects after the function is called.
		///     </para>
		/// </param>
		/// <returns>
		///     If the operation is synchronous, ConnectNamedPipe does not return until the operation has completed. If the
		///     function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended
		///     error information, call GetLastError.
		///     <para>
		///         If the operation is asynchronous, ConnectNamedPipe returns immediately. If the operation is still pending,
		///         the return value is zero and GetLastError returns ERROR_IO_PENDING. (You can use the HasOverlappedIoCompleted
		///         macro to determine when the operation has finished.) If the function fails, the return value is zero and
		///         GetLastError returns a value other than ERROR_IO_PENDING or ERROR_PIPE_CONNECTED.
		///     </para>
		///     <para>
		///         If a client connects before the function is called, the function returns zero and GetLastError returns
		///         ERROR_PIPE_CONNECTED. This can happen if a client connects in the interval between the call to CreateNamedPipe
		///         and the call to ConnectNamedPipe. In this situation, there is a good connection between client and server, even
		///         though the function returns zero.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool ConnectNamedPipe(Kernel32.SafeObjectHandle hNamedPipe,
		                                                  Kernel32.OVERLAPPED* lpOverlapped);

		/// <summary>
		///     Connects to a message-type pipe (and waits if an instance of the pipe is not available), writes to and reads
		///     from the pipe, and then closes the pipe.
		/// </summary>
		/// <param name="lpNamedPipeName">The pipe name.</param>
		/// <param name="lpInBuffer">The data to be written to the pipe.</param>
		/// <param name="nInBufferSize">The size of the write buffer, in bytes.</param>
		/// <param name="lpOutBuffer">A pointer to the buffer that receives the data read from the pipe.</param>
		/// <param name="nOutBufferSize">The size of the read buffer, in bytes.</param>
		/// <param name="lpBytesRead">A pointer to a variable that receives the number of bytes read from the pipe.</param>
		/// <param name="nTimeOut">
		///     The number of milliseconds to wait for the named pipe to be available. In addition to numeric
		///     values, <see cref="F:PInvoke.Kernel32.NMPWAIT_NOWAIT" />, <see cref="F:PInvoke.Kernel32.NMPWAIT_WAIT_FOREVER" /> and
		///     <see cref="F:PInvoke.Kernel32.NMPWAIT_USE_DEFAULT_WAIT" /> can be specified.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		///     <para>
		///         If the message written to the pipe by the server process is longer than nOutBufferSize, CallNamedPipe returns
		///         FALSE, and GetLastError returns ERROR_MORE_DATA. The remainder of the message is discarded, because
		///         CallNamedPipe closes the handle to the pipe before returning.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool CallNamedPipe(string lpNamedPipeName, void* lpInBuffer, int nInBufferSize,
		                                               void* lpOutBuffer, int nOutBufferSize, out int lpBytesRead,
		                                               int nTimeOut);

		/// <summary>Retrieves the client computer name for the specified named pipe.</summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe
		///     function.
		/// </param>
		/// <param name="ClientComputerName">The computer name.</param>
		/// <param name="ClientComputerNameLength">The size of the ClientComputerName buffer, in bytes.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetNamedPipeClientComputerName(Kernel32.SafeObjectHandle Pipe,
		                                                         StringBuilder ClientComputerName,
		                                                         int ClientComputerNameLength);

		/// <summary>Disconnects the server end of a named pipe instance from a client process.</summary>
		/// <param name="hNamedPipe">
		///     A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe
		///     function.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DisconnectNamedPipe(Kernel32.SafeObjectHandle hNamedPipe);

		/// <summary>Retrieves the client computer name for the specified named pipe.</summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe
		///     function.
		/// </param>
		/// <param name="ClientComputerName">The computer name.</param>
		/// <param name="ClientComputerNameLength">The size of the ClientComputerName buffer, in bytes.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetNamedPipeClientComputerName(Kernel32.SafeObjectHandle Pipe,
		                                                                char* ClientComputerName,
		                                                                int ClientComputerNameLength);

		/// <summary>Retrieves the client process identifier for the specified named pipe.</summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe
		///     function.
		/// </param>
		/// <param name="ClientProcessId">The process identifier.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetNamedPipeClientProcessId(Kernel32.SafeObjectHandle Pipe, out int ClientProcessId);

		/// <summary>
		/// Retrieves the client session identifier for the specified named pipe.
		/// </summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe
		///     function.
		/// </param>
		/// <param name="ClientSessionId">The session identifier.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetNamedPipeClientSessionId(Kernel32.SafeObjectHandle Pipe, out int ClientSessionId);

		/// <summary>
		///     Retrieves information about a specified named pipe. The information returned can vary during the lifetime of
		///     an instance of the named pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe for which information is wanted. The handle must have GENERIC_READ
		///     access for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a
		///     write-only pipe.
		///     <para>This parameter can also be a handle to an anonymous pipe, as returned by the CreatePipe function.</para>
		/// </param>
		/// <param name="lpState">
		///     A pointer to a variable that indicates the current state of the handle. Either or both of
		///     <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_NOWAIT" /> and <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_READMODE_MESSAGE" /> can be specified.
		/// </param>
		/// <param name="lpCurInstances">
		///     A pointer to a variable that receives the number of current pipe instances. This parameter
		///     can be NULL if this information is not required.
		/// </param>
		/// <param name="lpMaxCollectionCount">
		///     A pointer to a variable that receives the maximum number of bytes to be collected on
		///     the client's computer before transmission to the server. This parameter must be NULL if the specified pipe handle
		///     is to the server end of a named pipe or if client and server processes are on the same computer. This parameter can
		///     be NULL if this information is not required.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     A pointer to a variable that receives the maximum time, in milliseconds, that can
		///     pass before a remote named pipe transfers information over the network. This parameter must be NULL if the
		///     specified pipe handle is to the server end of a named pipe or if client and server processes are on the same
		///     computer. This parameter can be NULL if this information is not required.
		/// </param>
		/// <param name="lpUserName">
		///     A pointer to a buffer that receives the user name string associated with the client application. The server can
		///     only retrieve this information if the client opened the pipe with SECURITY_IMPERSONATION access.
		///     <para>
		///         This parameter must be NULL if the specified pipe handle is to the client end of a named pipe. This parameter
		///         can be NULL if this information is not required.
		///     </para>
		/// </param>
		/// <param name="nMaxUserNameSize">
		///     The size of the buffer specified by the lpUserName parameter, in chars. This parameter
		///     is ignored if lpUserName is NULL.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                         out Kernel32.PipeMode lpState, int* lpCurInstances,
		                                                         int* lpMaxCollectionCount, int* lpCollectDataTimeout,
		                                                         StringBuilder lpUserName, int nMaxUserNameSize);

		/// <summary>
		///     Retrieves information about a specified named pipe. The information returned can vary during the lifetime of
		///     an instance of the named pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe for which information is wanted. The handle must have GENERIC_READ
		///     access for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a
		///     write-only pipe.
		///     <para>This parameter can also be a handle to an anonymous pipe, as returned by the CreatePipe function.</para>
		/// </param>
		/// <param name="lpState">
		///     A pointer to a variable that indicates the current state of the handle. Either or both of
		///     <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_NOWAIT" /> and <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_READMODE_MESSAGE" /> can be specified.
		/// </param>
		/// <param name="lpCurInstances">
		///     A pointer to a variable that receives the number of current pipe instances. This parameter
		///     can be NULL if this information is not required.
		/// </param>
		/// <param name="lpMaxCollectionCount">
		///     A pointer to a variable that receives the maximum number of bytes to be collected on
		///     the client's computer before transmission to the server. This parameter must be NULL if the specified pipe handle
		///     is to the server end of a named pipe or if client and server processes are on the same computer. This parameter can
		///     be NULL if this information is not required.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     A pointer to a variable that receives the maximum time, in milliseconds, that can
		///     pass before a remote named pipe transfers information over the network. This parameter must be NULL if the
		///     specified pipe handle is to the server end of a named pipe or if client and server processes are on the same
		///     computer. This parameter can be NULL if this information is not required.
		/// </param>
		/// <param name="lpUserName">
		///     A pointer to a buffer that receives the user name string associated with the client application. The server can
		///     only retrieve this information if the client opened the pipe with SECURITY_IMPERSONATION access.
		///     <para>
		///         This parameter must be NULL if the specified pipe handle is to the client end of a named pipe. This parameter
		///         can be NULL if this information is not required.
		///     </para>
		/// </param>
		/// <param name="nMaxUserNameSize">
		///     The size of the buffer specified by the lpUserName parameter, in chars. This parameter
		///     is ignored if lpUserName is NULL.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                         out Kernel32.PipeMode lpState, int* lpCurInstances,
		                                                         int* lpMaxCollectionCount, int* lpCollectDataTimeout,
		                                                         char* lpUserName, int nMaxUserNameSize);

		/// <summary>Retrieves information about the specified named pipe.</summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe instance. The handle must have GENERIC_READ access to the named
		///     pipe for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a
		///     write-only pipe.
		///     <para>
		///         This parameter can also be a handle to an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" />
		///         function.
		///     </para>
		/// </param>
		/// <param name="lpFlags">Receives the type of the named pipe.</param>
		/// <param name="lpOutBufferSize">
		///     Receives the size of the buffer for outgoing data, in bytes. If the buffer size is zero,
		///     the buffer is allocated as needed.
		/// </param>
		/// <param name="lpInBufferSize">
		///     Receives the size of the buffer for incoming data, in bytes. If the buffer size is zero,
		///     the buffer is allocated as needed.
		/// </param>
		/// <param name="lpMaxInstances">
		///     Receives the maximum number of pipe instances that can be created. If the variable is set
		///     to <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" /> (255), the number of pipe instances that can be created is limited only
		///     by the availability of system resources.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetNamedPipeInfo(Kernel32.SafeObjectHandle hNamedPipe,
		                                           out Kernel32.NamedPipeInfoFlags lpFlags, out int lpOutBufferSize,
		                                           out int lpInBufferSize, out int lpMaxInstances);

		/// <summary>Retrieves the server process identifier for the specified named pipe.</summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the
		///     <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> function.
		/// </param>
		/// <param name="ServerProcessId">The process identifier.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetNamedPipeServerProcessId(Kernel32.SafeObjectHandle Pipe, out int ServerProcessId);

		/// <summary>
		/// Retrieves the server session identifier for the specified named pipe.
		/// </summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the
		///     <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> function.
		/// </param>
		/// <param name="ServerSessionId">The session identifier.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetNamedPipeServerSessionId(Kernel32.SafeObjectHandle Pipe, out int ServerSessionId);

		/// <summary>
		///     Copies data from a named or anonymous pipe into a buffer without removing it from the pipe. It also returns
		///     information about data in the pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the pipe. This parameter can be a handle to a named pipe instance, as returned by
		///     the <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> or <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function, or it can be a handle to the read end of
		///     an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" /> function. The handle must have GENERIC_READ access
		///     to the pipe.
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to a buffer that receives data read from the pipe. This parameter can be NULL if no
		///     data is to be read.
		/// </param>
		/// <param name="nBufferSize">
		///     The size of the buffer specified by the lpBuffer parameter, in bytes. This parameter is
		///     ignored if lpBuffer is NULL.
		/// </param>
		/// <param name="lpBytesRead">A pointer to a variable that receives the number of bytes read from the pipe.</param>
		/// <param name="lpTotalBytesAvail">
		///     A pointer to a variable that receives the total number of bytes available to be read
		///     from the pipe.
		/// </param>
		/// <param name="lpBytesLeftThisMessage">
		///     A pointer to a variable that receives the number of bytes remaining in this
		///     message. This parameter will be zero for byte-type named pipes or for anonymous pipes.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool PeekNamedPipe(Kernel32.SafeObjectHandle hNamedPipe, void* lpBuffer,
		                                               int nBufferSize, out int lpBytesRead, out int lpTotalBytesAvail,
		                                               out int lpBytesLeftThisMessage);

		/// <summary>
		///     Sets the read mode and the blocking mode of the specified named pipe. If the specified handle is to the client
		///     end of a named pipe and if the named pipe server process is on a remote computer, the function can also be used to
		///     control local buffering.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe instance. This parameter can be a handle to the server end of the
		///     pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> function, or to the client end of the pipe, as returned by
		///     the <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function. The handle must have GENERIC_WRITE access to the named pipe for a
		///     write-only or read/write pipe, or it must have GENERIC_READ and FILE_WRITE_ATTRIBUTES access for a read-only pipe.
		///     <para>
		///         This parameter can also be a handle to an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" />
		///         function.
		///     </para>
		/// </param>
		/// <param name="lpMode">The new pipe mode. The mode is a combination of a read-mode flag and a wait-mode flag.</param>
		/// <param name="lpMaxCollectionCount">
		///     The maximum number of bytes collected on the client computer before transmission to
		///     the server. This parameter must be NULL if the specified pipe handle is to the server end of a named pipe or if
		///     client and server processes are on the same machine. This parameter is ignored if the client process specifies the
		///     FILE_FLAG_WRITE_THROUGH flag in the CreateFile function when the handle was created. This parameter can be NULL if
		///     the collection count is not being set.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     The maximum time, in milliseconds, that can pass before a remote named pipe
		///     transfers information over the network. This parameter must be NULL if the specified pipe handle is to the server
		///     end of a named pipe or if client and server processes are on the same computer. This parameter is ignored if the
		///     client process specified the FILE_FLAG_WRITE_THROUGH flag in the CreateFile function when the handle was created.
		///     This parameter can be NULL if the collection count is not being set.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool SetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                         Kernel32.PipeMode* lpMode, int* lpMaxCollectionCount,
		                                                         int* lpCollectDataTimeout);

		/// <summary>
		///     Combines the functions that write a message to and read a message from the specified named pipe into a single
		///     network operation.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe returned by the <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> or
		///     <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function.
		///     <para>
		///         This parameter can also be a handle to an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" />
		///         function.
		///     </para>
		/// </param>
		/// <param name="lpInBuffer">A pointer to the buffer containing the data to be written to the pipe.</param>
		/// <param name="nInBufferSize">The size of the input buffer, in bytes.</param>
		/// <param name="lpOutBuffer">A pointer to the buffer that receives the data read from the pipe.</param>
		/// <param name="nOutBufferSize">The size of the output buffer, in bytes.</param>
		/// <param name="lpBytesRead">A pointer to the variable that receives the number of bytes read from the pipe.</param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. This structure is required if hNamedPipe was opened with
		///     FILE_FLAG_OVERLAPPED.
		///     <para>
		///         If hNamedPipe was opened with FILE_FLAG_OVERLAPPED, the lpOverlapped parameter must not be NULL. It must
		///         point to a valid <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. If hNamedPipe was created with FILE_FLAG_OVERLAPPED and
		///         lpOverlapped is NULL, the function can incorrectly report that the operation is complete.
		///     </para>
		///     <para>
		///         If hNamedPipe was opened with FILE_FLAG_OVERLAPPED and lpOverlapped is not NULL, TransactNamedPipe is
		///         executed as an overlapped operation. The <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure should contain a manual-reset
		///         event object (which can be created by using the CreateEvent function). If the operation cannot be completed
		///         immediately, TransactNamedPipe returns FALSE and GetLastError returns ERROR_IO_PENDING. In this situation, the
		///         event object is set to the nonsignaled state before TransactNamedPipe returns, and it is set to the signaled
		///         state when the transaction has finished. Also, you can be notified when an overlapped operation completes by
		///         using the GetQueuedCompletionStatus or GetQueuedCompletionStatusEx functions. In this case, you do not need to
		///         assign the manual-reset event in the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure, and the completion happens against
		///         <paramref name="hNamedPipe" /> in the same way as an asynchronous read or write operation.
		///     </para>
		///     <para>
		///         If hNamedPipe was not opened with FILE_FLAG_OVERLAPPED, TransactNamedPipe does not return until the operation
		///         is complete.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		///     <para>
		///         If the message to be read is longer than the buffer specified by the <paramref name="nOutBufferSize" />
		///         parameter, TransactNamedPipe returns FALSE and the <see cref="M:PInvoke.Kernel32.GetLastError" /> function returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_MORE_DATA" />. The remainder of the message can be read by a subsequent call to
		///         <see cref="M:PInvoke.Kernel32.ReadFile(PInvoke.Kernel32.SafeObjectHandle,System.Void*,System.Int32,System.Int32*,PInvoke.Kernel32.OVERLAPPED*)" />, ReadFileEx, or PeekNamedPipe.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool TransactNamedPipe(Kernel32.SafeObjectHandle hNamedPipe, void* lpInBuffer,
		                                                   int nInBufferSize, void* lpOutBuffer, int nOutBufferSize,
		                                                   out int lpBytesRead, Kernel32.OVERLAPPED* lpOverlapped);

		/// <summary>
		/// Allocates the specified number of bytes from the heap.
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. The default is the <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_FIXED" /> value.
		/// This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.
		/// </param>
		/// <param name="uBytes">
		/// The number of bytes to allocate. If this parameter is zero and the <paramref name="uFlags" /> parameter specifies <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_MOVEABLE" />,
		/// the function returns a handle to a memory object that is marked as discarded.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* LocalAlloc(Kernel32.LocalAllocFlags uFlags, IntPtr uBytes);

		/// <summary>
		/// Changes the size or the attributes of a specified local memory object. The size can increase or decrease.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the local memory object to be reallocated.
		/// This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.LocalReAllocFlags)" /> function.
		/// </param>
		/// <param name="uBytes">The new size of the memory block, in bytes. If uFlags specifies <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" />, this parameter is ignored.</param>
		/// <param name="uFlags">
		/// The reallocation options. If <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" /> is specified, the function modifies the attributes of the memory object only
		/// (the uBytes parameter is ignored.) Otherwise, the function reallocates the memory object.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// If LocalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// If LocalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block.
		/// To access the memory, a process can simply cast the return value to a pointer.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* LocalReAlloc(void* hMem, IntPtr uBytes, Kernel32.LocalReAllocFlags uFlags);

		/// <summary>
		/// Frees the specified local memory object and invalidates its handle.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the local memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or
		/// <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.LocalReAllocFlags)" /> function. It is not safe to free memory allocated with <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" />.
		/// If the hMem parameter is NULL, LocalFree ignores the parameter and returns NULL.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is NULL.
		/// If the function fails, the return value is equal to a handle to <paramref name="hMem" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* LocalFree(void* hMem);

		/// <summary>
		/// Locks a local memory object and returns a pointer to the first byte of the object's memory block.
		/// </summary>
		/// <param name="hMem">A handle to the local memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.Int32,PInvoke.Kernel32.LocalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the first byte of the memory block.
		/// If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* LocalLock(void* hMem);

		/// <summary>
		/// Decrements the lock count associated with a memory object that was allocated with <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_MOVEABLE" />.
		/// This function has no effect on memory objects allocated with <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_FIXED" />.
		/// </summary>
		/// <param name="hMem">A handle to the local  memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.Int32,PInvoke.Kernel32.LocalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the memory object is still locked after decrementing the lock count, the return value is true.
		/// If the memory object is unlocked after decrementing the lock count, the function returns false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// If the function fails, the return value is false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns a value other than <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool LocalUnlock(void* hMem);

		/// <summary>
		/// Allocates the specified number of bytes from the heap.
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. The default is the <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_FIXED" /> value.
		/// This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.
		/// </param>
		/// <param name="uBytes">
		/// The number of bytes to allocate. If this parameter is zero and the uFlags parameter specifies <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_MOVEABLE" />,
		/// the function returns a handle to a memory object that is marked as discarded.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* GlobalAlloc(Kernel32.GlobalAllocFlags uFlags, IntPtr uBytes);

		/// <summary>
		/// Changes the size or attributes of a specified global memory object. The size can increase or decrease.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object to be reallocated.
		/// This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function.
		/// </param>
		/// <param name="uBytes">The new size of the memory block, in bytes. If uFlags specifies <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_MODIFY" />, this parameter is ignored.</param>
		/// <param name="uFlags">
		/// The reallocation options. If <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" /> is specified, the function modifies the attributes of the memory object only
		/// (the uBytes parameter is ignored.) Otherwise, the function reallocates the memory object.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// If GlobalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// If GlobalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block.
		/// To access the memory, a process can simply cast the return value to a pointer.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* GlobalReAlloc(void* hMem, IntPtr uBytes, Kernel32.GlobalReAllocFlags uFlags);

		/// <summary>
		/// Frees the specified global memory object and invalidates its handle.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or
		/// <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function. It is not safe to free memory allocated with <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" />.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is NULL.
		/// If the function fails, the return value is equal to a handle to <paramref name="hMem" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* GlobalFree(void* hMem);

		/// <summary>
		/// Locks a global memory object and returns a pointer to the first byte of the object's memory block.
		/// </summary>
		/// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the first byte of the memory block.
		///  If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* GlobalLock(void* hMem);

		/// <summary>
		/// Decrements the lock count associated with a memory object that was allocated with <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_MOVEABLE" />.
		/// This function has no effect on memory objects allocated with <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_FIXED" />.
		/// </summary>
		/// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the memory object is still locked after decrementing the lock count, the return value is true.
		/// If the memory object is unlocked after decrementing the lock count, the function returns false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// If the function fails, the return value is false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns a value other than <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GlobalUnlock(void* hMem);

		/// <summary>
		/// Allocates a block of memory from a heap. The allocated memory is not movable.
		/// </summary>
		/// <param name="hHeap">A handle to the heap from which the memory will be allocated. This handle is returned by the HeapCreate or  function.</param>
		/// <param name="uFlags">The heap allocation options. Specifying any of these values will override the corresponding value specified when the heap was created with HeapCreate.</param>
		/// <param name="uBytes">
		/// The number of bytes to be allocated. If the heap specified by the hHeap parameter is a "non-growable" heap,
		/// dwBytes must be less than 0x7FFF8.
		/// You create a non-growable heap by calling the HeapCreate function with a nonzero value.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the allocated memory block.
		/// If the function fails and you have not specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />, the return value is NULL.
		/// If the function fails and you have specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />,
		/// the function may generate either of the exceptions listed in the following table:
		/// <list>
		/// <item>STATUS_NO_MEMORY: The allocation attempt failed because of a lack of available memory or heap corruption.</item>
		/// <item>STATUS_ACCESS_VIOLATION: The allocation attempt failed because of heap corruption or improper function parameters.</item>
		/// </list>
		/// The particular exception depends upon the nature of the heap corruption. For more information, see GetExceptionCode.
		/// </returns>
		/// <remarks>If the function fails, it does not call SetLastError. An application cannot call <see cref="M:PInvoke.Kernel32.GetLastError" /> for extended error information.</remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern unsafe void* HeapAlloc(IntPtr hHeap, Kernel32.HeapAllocFlags uFlags, IntPtr uBytes);

		/// <summary>
		/// Reallocates a block of memory from a heap. This function enables you to resize a memory block and change other memory block properties.
		/// The allocated memory is not movable.
		/// </summary>
		/// <param name="hHeap">A handle to the heap from which the memory is to be reallocated. This handle is a returned by either the HeapCreate or GetProcessHeap function.</param>
		/// <param name="uFlags">
		/// The heap reallocation options. Specifying a value overrides the corresponding value specified in the flOptions parameter
		/// when the heap was created by using the HeapCreate function.
		/// </param>
		/// <param name="hMem">
		/// A pointer to the block of memory that the function reallocates.
		/// This pointer is returned by an earlier call to the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> function.
		/// </param>
		/// <param name="uBytes">
		/// The new size of the memory block, in bytes. A memory block's size can be increased or decreased by using this function.
		/// If the heap specified by the hHeap parameter is a "non-growable" heap, dwBytes must be less than 0x7FFF8.
		/// You create a non-growable heap by calling the HeapCreate function with a nonzero value.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the reallocated memory block.
		/// If the function fails and you have not specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />, the return value is NULL.
		/// If the function fails and you have specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />,
		/// the function may generate either of the exceptions listed in the following table:
		/// <list>
		/// <item>STATUS_NO_MEMORY: The allocation attempt failed because of a lack of available memory or heap corruption.</item>
		/// <item>STATUS_ACCESS_VIOLATION: The allocation attempt failed because of heap corruption or improper function parameters.</item>
		/// </list>
		/// The particular exception depends upon the nature of the heap corruption. For more information, see GetExceptionCode.
		/// </returns>
		/// <remarks>If the function fails, it does not call SetLastError. An application cannot call <see cref="M:PInvoke.Kernel32.GetLastError" /> for extended error information.</remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern unsafe void* HeapReAlloc(IntPtr hHeap, Kernel32.HeapReAllocFlags uFlags, void* hMem,
		                                              IntPtr uBytes);

		/// <summary>
		/// Frees a memory block allocated from a heap by the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> function.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap whose memory block is to be freed. This handle is returned by either the HeapCreate or
		/// GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">The heap free options. Specifying the following value overrides the corresponding value specified in the flOptions parameter
		/// when the heap was created by using the HeapCreate function.</param>
		/// <param name="hMem">
		/// A pointer to the memory block to be freed. This pointer is returned by the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> function.
		/// If this pointer is NULL, the behavior is undefined.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is true. If the function fails, the return value false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool HeapFree(IntPtr hHeap, Kernel32.HeapFreeFlags dwFlags, void* hMem);

		/// <summary>
		/// Attempts to acquire the critical section object, or lock, that is associated with a specified heap.
		/// </summary>
		/// <param name="hMem">A handle to the heap to be locked. This handle is returned by either the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> function.</param>
		/// <returns>
		/// If the function succeeds, the return value is true. If the function fails, the return value is zero.
		/// To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool HeapLock(IntPtr hMem);

		/// <summary>
		/// Releases ownership of the critical section object, or lock, that is associated with a specified heap. It reverses the action of the <see cref="M:PInvoke.Kernel32.HeapLock(System.IntPtr)" /> function.
		/// </summary>
		/// <param name="hHeap">A handle to the heap to be unlocked. This handle is returned by either the HeapCreate or GetProcessHeap function.</param>
		/// <returns>
		/// If the function succeeds, the return value is true. If the function fails, the return value is zero.
		/// To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool HeapUnlock(IntPtr hHeap);

		/// <summary>
		/// Copies a block of memory from one location to another.
		/// </summary>
		/// <param name="Destination">A pointer to the starting address of the copied block's destination.</param>
		/// <param name="Source">A pointer to the starting address of the block of memory to copy.</param>
		/// <param name="Length">The size of the block of memory to copy, in bytes.</param>
		/// <remarks>
		/// This function is defined as the RtlCopyMemory function.
		/// If the source and destination blocks overlap, the results are undefined.
		/// For overlapped blocks, use the <see cref="M:PInvoke.Kernel32.MoveMemory(System.Void*,System.Void*,System.IntPtr)" /> function.
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern unsafe void CopyMemory(void* Destination, void* Source, IntPtr Length);

		/// <summary>Moves a block of memory from one location to another.</summary>
		/// <param name="Destination">A pointer to the starting address of the move destination.</param>
		/// <param name="Source">A pointer to the starting address of the block of memory to be moved.</param>
		/// <param name="Length">The size of the block of memory to move, in bytes.</param>
		/// <remarks>
		/// <para>
		/// This function is defined as the RtlMoveMemory function.
		/// The source and destination blocks may overlap.
		/// </para>
		/// <para>
		/// The first parameter, <paramref name="Destination" />, must be large enough to hold <paramref name="Length" /> bytes of <paramref name="Source" />;
		/// otherwise, a buffer overrun may occur.
		/// This may lead to a denial of service attack against the application if an access violation occurs or, in the worst case,
		/// allow an attacker to inject executable code into your process.
		/// This is especially true if <paramref name="Destination" /> is a stack-based buffer.
		/// Be aware that the last parameter, <paramref name="Length" />, is the number of bytes to copy into <paramref name="Destination" />, not the size of the <paramref name="Destination" />.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern unsafe void MoveMemory(void* Destination, void* Source, IntPtr Length);

		/// <summary>
		///     Enumerates resources of a specified type within a binary module. For Windows Vista and later, this is
		///     typically a language-neutral Portable Executable (LN file), and the enumeration will also include resources from
		///     the corresponding language-specific resource files (.mui files) that contain localizable language resources. It is
		///     also possible for hModule to specify an .mui file, in which case only that file is searched for resources.
		/// </summary>
		/// <param name="hModule">
		///     A handle to a module to be searched. Starting with Windows Vista, if this is an LN file, then appropriate .mui
		///     files (if any exist) are included in the search.
		///     <para>
		///         If this parameter is NULL, that is equivalent to passing in a handle to the module used to create the current
		///         process.
		///     </para>
		/// </param>
		/// <param name="lpszType">
		///     The type of the resource for which the name is being enumerated. Alternately, rather than a
		///     pointer, this parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is an integer value representing a
		///     predefined resource type.
		/// </param>
		/// <param name="lpEnumFunc">A pointer to the callback function to be called for each enumerated resource name or ID.</param>
		/// <param name="lParam">
		///     An application-defined value passed to the callback function. This parameter can be used in error
		///     checking.
		/// </param>
		/// <returns>
		///     The return value is TRUE if the function succeeds or FALSE if the function does not find a resource of the
		///     type specified, or if the function fails for another reason. To get extended error information, call
		///     <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool EnumResourceNames(Kernel32.SafeLibraryHandle hModule, char* lpszType,
		                                                   Kernel32.EnumResNameProc lpEnumFunc, IntPtr lParam);

		/// <summary>
		///     Enumerates language-specific resources, of the specified type and name, associated with a binary module.
		/// </summary>
		/// <param name="hModule">
		///     The handle to a module to be searched. Starting with Windows Vista, if this is a language-neutral Portable
		///     Executable (LN file), then appropriate .mui files (if any exist) are included in the search. If this is a
		///     specific .mui file, only that file is searched for resources.
		///     <para>
		///         If this parameter is NULL, that is equivalent to passing in a handle to the module used to create the current process.
		///     </para>
		/// </param>
		/// <param name="lpType">
		///     The type of resource for which the language is being enumerated. Alternately, rather than a pointer, this
		///     parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is an integer value representing a predefined resource type.
		/// </param>
		/// <param name="lpName">
		///     The name of the resource for which the language is being enumerated. Alternately, rather than a pointer,
		///     this parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is the integer identifier of the resource.
		/// </param>
		/// <param name="lpEnumFunc">
		///     A pointer to the callback function to be called for each enumerated resource language. For more information,
		///     see <see cref="T:PInvoke.Kernel32.EnumResLangProc" />.
		/// </param>
		/// <param name="lParam">
		///     An application-defined value passed to the callback function. This parameter can be used in error checking.
		/// </param>
		/// <returns>Returns TRUE if successful or FALSE otherwise. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool EnumResourceLanguages(Kernel32.SafeLibraryHandle hModule, char* lpType,
		                                                       char* lpName, Kernel32.EnumResLangProc lpEnumFunc,
		                                                       void* lParam);

		/// <summary>Determines whether a value is an integer identifier for a resource.</summary>
		/// <param name="p">The pointer to be tested whether it contains an integer resource identifier.</param>
		/// <returns>If the value is a resource identifier, the return value is TRUE. Otherwise, the return value is FALSE.</returns>
		public static unsafe bool IS_INTRESOURCE(char* p) {
			return (long) p >> 16 == 0L;
		}

		/// <summary>
		///     Converts an integer value to a resource type compatible with the resource-management functions. This macro is
		///     used in place of a string containing the name of the resource.
		/// </summary>
		/// <param name="wInteger">The integer value to be converted.</param>
		/// <returns>The return value is the specified value in the low-order word and zero in the high-order word.</returns>
		public static unsafe char* MAKEINTRESOURCE(int wInteger) {
			return (char*) wInteger;
		}

		/// <summary>
		///     Determines the location of a resource with the specified type and name in the specified module.
		///     <para>To specify a language, use the FindResourceEx function.</para>
		/// </summary>
		/// <param name="hModule">
		///     A handle to the module whose portable executable file or an accompanying MUI file contains the
		///     resource. If this parameter is <see cref="F:PInvoke.Kernel32.SafeLibraryHandle.Null" />, the function searches the module used to
		///     create the current process.
		/// </param>
		/// <param name="lpName">
		///     The name of the resource. Alternately, rather than a pointer, this parameter can be
		///     <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />, where wInteger is the integer identifier of the resource.
		/// </param>
		/// <param name="lpType">
		///     The resource type. Alternately, rather than a pointer, this parameter can be
		///     <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />, where wInteger is the integer identifier of the given resource type.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the specified resource's information block. To obtain a
		///     handle to the resource, pass this handle to the <see cref="M:PInvoke.Kernel32.LoadResource(PInvoke.Kernel32.SafeLibraryHandle,System.IntPtr)" /> function.
		///     <para>
		///         If the function fails, the return value is NULL. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe IntPtr FindResource(Kernel32.SafeLibraryHandle hModule, char* lpName, char* lpType);

		/// <summary>Retrieves the size, in bytes, of the specified resource.</summary>
		/// <param name="hModule">A handle to the module whose executable file contains the resource.</param>
		/// <param name="hResInfo">
		///     handle to the resource. This handle must be created by using the <see cref="M:PInvoke.Kernel32.FindResource(PInvoke.Kernel32.SafeLibraryHandle,System.Char*,System.Char*)" /> or
		///     FindResourceEx function.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is the number of bytes in the resource.
		///     <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int SizeofResource(Kernel32.SafeLibraryHandle hModule, IntPtr hResInfo);

		/// <summary>Suspends the specified WOW64 thread.</summary>
		/// <param name="hThread">
		/// A handle to the thread that is to be suspended.
		/// The handle must have the THREAD_SUSPEND_RESUME access right. For more information, see Thread Security and Access Rights.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the thread's previous suspend count; otherwise, it is (DWORD) -1. To get extended error information, use the <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int Wow64SuspendThread(Kernel32.SafeObjectHandle hThread);

		/// <summary>Assigns a process to an existing job object.</summary>
		/// <param name="hJob">
		/// A handle to the job object to which the process will be associated.
		/// The <see cref="M:PInvoke.Kernel32.CreateJobObject(PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.String)" /> or OpenJobObject function returns this handle.
		/// The handle must have the JOB_OBJECT_ASSIGN_PROCESS access right. For more information, see Job Object Security and Access Rights.
		/// </param>
		/// <param name="hProcess">
		/// A handle to the process to associate with the job object. The handle must have the PROCESS_SET_QUOTA and PROCESS_TERMINATE access rights. For more information, see Process Security and Access Rights.
		/// If the process is already associated with a job, the job specified by hJob must be empty or it must be in the hierarchy of nested jobs to which the process already belongs, and it cannot have UI limits set(SetInformationJobObject with JobObjectBasicUIRestrictions).
		/// For more information, see Remarks.
		/// Windows 7, Windows Server 2008 R2, Windows XP with SP3, Windows Server 2008, Windows Vista, and Windows Server 2003:  The process must not already be assigned to a job; if it is, the function fails with ERROR_ACCESS_DENIED.This behavior changed starting in Windows 8 and Windows Server 2012.
		/// Terminal Services:  All processes within a job must run within the same session as the job.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool AssignProcessToJobObject(Kernel32.SafeObjectHandle hJob,
		                                                   Kernel32.SafeObjectHandle hProcess);

		/// <summary>Creates or opens a job object.</summary>
		/// <param name="lpJobAttributes">A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies the security descriptor for the job object and determines whether child processes can inherit the returned handle.
		/// If lpJobAttributes is NULL, the job object gets a default security descriptor and the handle cannot be inherited.
		/// The ACLs in the default security descriptor for a job object come from the primary or impersonation token of the creator.
		/// </param>
		/// <param name="lpName">The name of the job. The name is limited to MAX_PATH characters. Name comparison is case-sensitive.
		/// If lpName is NULL, the job is created without a name.
		/// If lpName matches the name of an existing event, semaphore, mutex, waitable timer, or file-mapping object, the function fails and the GetLastError function returns ERROR_INVALID_HANDLE.
		/// This occurs because these objects share the same namespace.The object can be created in a private namespace.For more information, see Object Namespaces.
		/// Terminal Services:  The name can have a "Global\" or "Local\" prefix to explicitly create the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\). For more information, see Kernel Object Namespaces.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the job object. The handle has the JOB_OBJECT_ALL_ACCESS access right. If the object existed before the function call, the function returns a handle to the existing job object and GetLastError returns ERROR_ALREADY_EXISTS.
		/// If the function fails, the return value is NULL.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe Kernel32.SafeObjectHandle CreateJobObject(
			Kernel32.SECURITY_ATTRIBUTES* lpJobAttributes, string lpName);

		/// <summary>
		/// Determines whether the process is running in the specified job.
		/// </summary>
		/// <param name="hProcess">
		/// A handle to the process to be tested. The handle must have the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see Process Security and Access Rights.
		/// Windows Server 2003 and Windows XP:  The handle must have the PROCESS_QUERY_INFORMATION access right.
		/// </param>
		/// <param name="hJob">
		/// A handle to the job. If this parameter is NULL, the function tests if the process is running under any job.
		/// If this parameter is not NULL, the handle must have the JOB_OBJECT_QUERY access right. For more information, see Job Object Security and Access Rights.
		/// </param>
		/// <param name="result">
		/// A pointer to a value that receives TRUE if the process is running in the job, and FALSE otherwise.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool IsProcessInJob(Kernel32.SafeObjectHandle hProcess, Kernel32.SafeObjectHandle hJob,
		                                         out bool result);

		/// <summary>Sets limits for a job object.</summary>
		/// <param name="hJob">
		/// A handle to the job whose limits are being set. The <see cref="M:PInvoke.Kernel32.CreateJobObject(PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.String)" /> or OpenJobObject function returns this handle. The handle must have the JOB_OBJECT_SET_ATTRIBUTES access right. For more information, see Job Object Security and Access Rights.
		/// </param>
		/// <param name="jobObjectInfoClass">
		/// The information class for the limits to be set.
		/// </param>
		/// <param name="lpJobObjectInfo">T
		/// he limits or job state to be set for the job. The format of this data depends on the value of JobObjectInfoClass.
		/// </param>
		/// <param name="cbJobObjectInfoLength">
		/// The size of the job information being set, in bytes.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool SetInformationJobObject(Kernel32.SafeObjectHandle hJob,
		                                                         Kernel32.JOBOBJECTINFOCLASS jobObjectInfoClass,
		                                                         void* lpJobObjectInfo, uint cbJobObjectInfoLength);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GenerateConsoleCtrlEvent(Kernel32.ControlType dwCtrlEvent, uint dwProcessGroupId);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddConsoleAlias(string Source, string Target, string ExeName);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe IntPtr CreateConsoleScreenBuffer(Kernel32.ACCESS_MASK dwDesiredAccess,
		                                                             Kernel32.FileShare dwShareMode,
		                                                             Kernel32.SECURITY_ATTRIBUTES* lpSecurityAttributes,
		                                                             Kernel32.ConsoleScreenBufferFlag dwFlags,
		                                                             void* lpScreenBufferData);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlushConsoleInputBuffer(IntPtr hConsoleInput);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetConsoleAliases(char* lpAliasBuffer, int AliasBufferLength, string lpExeName);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetConsoleAliasesLength(string lpExeName);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetConsoleAliasExes(char* lpExeNameBuffer, int ExeNameBufferLength);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int GetConsoleAliasExesLength();

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetConsoleAlias(string lpSource, char* lpTargetBuffer, int TargetBufferLength,
		                                                string lpExeName);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern uint GetConsoleCP();

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetConsoleDisplayMode(out Kernel32.ConsoleDisplayMode lpModeFlags);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern COORD GetConsoleFontSize(IntPtr hConsoleOutput, uint nFont);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetConsoleMode(IntPtr hConsoleHandle, out Kernel32.ConsoleBufferModes lpMode);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleMode(IntPtr hConsoleHandle, Kernel32.ConsoleBufferModes dwMode);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern uint GetConsoleOutputCP();

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleOutputCP(uint wCodePageID);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleCP(uint wCodePageID);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetConsoleProcessList(uint* lpdwProcessList, int dwProcessCount);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput,
		                                                            Kernel32.CONSOLE_SCREEN_BUFFER_INFO*
			                                                            lpConsoleScreenBufferInfo);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool GetConsoleSelectionInfo(
			Kernel32.CONSOLE_SELECTION_INFO* lpConsoleSelectionInfo);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetConsoleTitle(char* lpConsoleTitle, int nSize);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleTitle(string lpConsoleTitle);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, out int lpNumberOfEvents);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PeekConsoleInput(IntPtr hConsoleInput, out Kernel32.INPUT_RECORD lpBuffer,
		                                           int nLength, out int lpNumberOfEventsRead);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ReadConsoleOutput(IntPtr hConsoleOutput, out Kernel32.CHAR_INFO lpBuffer,
		                                            COORD dwBufferSize, COORD dwBufferCoord,
		                                            ref SMALL_RECT lpReadRegion);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool ReadConsole(IntPtr hConsoleInput, void* lpBuffer, int nNumberOfCharsToRead,
		                                             int lpNumberOfCharsRead, IntPtr lpReserved);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ReadConsoleInput(IntPtr hConsoleInput, out Kernel32.INPUT_RECORD lpBuffer,
		                                           int nLength, out int lpNumberOfEventsRead);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool ScrollConsoleScreenBuffer(IntPtr hConsoleOutput, SMALL_RECT* lpScrollRectangle,
		                                                           SMALL_RECT* lpClipRectangle,
		                                                           COORD dwDestinationOrigin,
		                                                           Kernel32.CHAR_INFO* lpFill);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern uint WTSGetActiveConsoleSessionId();

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool WriteConsole(IntPtr hConsoleOutput, void* lpBuffer, int nNumberOfCharsToWrite,
		                                              int* lpNumberOfCharsWritten, IntPtr lpReserved);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool WriteConsoleOutput(IntPtr hConsoleOutput, Kernel32.CHAR_INFO* lpBuffer,
		                                                    COORD dwBufferSize, COORD dwBufferCoord,
		                                                    SMALL_RECT* lpWriteRegion);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool WriteConsoleInput(IntPtr hConsoleInput, Kernel32.INPUT_RECORD* lpBuffer,
		                                                   int nLength, int* lpNumberOfEventsWritten);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput,
		                                                  Kernel32.CharacterAttributesFlags wAttributes);

		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);

		/// <summary>
		/// Adds or removes an application-defined HandlerRoutine function from the list of handler
		/// functions for the calling process. If no handler function is specified, the function sets
		/// an inheritable attribute that determines whether the calling process ignores CTRL+C signals.
		/// </summary>
		/// <param name="handlerRoutine">
		/// A pointer to the application-defined HandlerRoutine function to be added or removed. This
		/// parameter can be NULL.
		/// </param>
		/// <param name="add">
		/// <para>
		/// If this parameter is TRUE, the handler is added; if it is FALSE, the handler is removed.
		/// </para>
		/// <para>
		/// If the HandlerRoutine parameter is NULL, a TRUE value causes the calling process to
		/// ignore CTRL+C input, and a FALSE value restores normal processing of CTRL+C input. This
		/// attribute of ignoring or processing CTRL+C is inherited by child processes.
		/// </para>
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero. If the function fails, the return
		/// value is zero.To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This function provides a similar notification for console application and services that
		/// WM_QUERYENDSESSION provides for graphical applications with a message pump. You could
		/// also use this function from a graphical application, but there is no guarantee it would
		/// arrive before the notification from WM_QUERYENDSESSION.
		/// </para>
		/// <para>
		/// Each console process has its own list of application-defined HandlerRoutine functions
		/// that handle CTRL+C and CTRL+BREAK signals. The handler functions also handle signals
		/// generated by the system when the user closes the console, logs off, or shuts down the
		/// system. Initially, the handler list for each process contains only a default handler
		/// function that calls the ExitProcess function. A console process adds or removes
		/// additional handler functions by calling the SetConsoleCtrlHandler function, which does
		/// not affect the list of handler functions for other processes. When a console process
		/// receives any of the control signals, its handler functions are called on a
		/// last-registered, first-called basis until one of the handlers returns TRUE. If none of
		/// the handlers returns TRUE, the default handler is called.
		/// </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetConsoleCtrlHandler(Kernel32.HandlerRoutine handlerRoutine,
		                                                [MarshalAs(UnmanagedType.Bool)] bool add);

		/// <summary>
		/// Enables an application to inform the system that it is in use, thereby preventing the system from entering sleep or turning off the display while the application is running.
		/// </summary>
		/// <param name="esFlags">The thread's execution requirements.</param>
		/// <returns>
		/// If the function succeeds, the return value is the previous thread execution state.
		/// If the function fails, the return value is <see cref="F:PInvoke.Kernel32.EXECUTION_STATE.None" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern Kernel32.EXECUTION_STATE SetThreadExecutionState(Kernel32.EXECUTION_STATE esFlags);

		/// <summary>
		/// Writes data to an area of memory in a specified process. The entire area to be written to must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process memory to be modified. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_WRITE" /> and <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_OPERATION" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process to which data is written. Before data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for write access, and if it is not accessible, the function fails.</param>
		/// <param name="lpBuffer">A pointer to the buffer that contains data to be written in the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be written to the specified process.</param>
		/// <param name="lpNumberOfBytesWritten">A pointer to a variable that receives the number of bytes transferred into the specified process. This parameter is optional. If <paramref name="lpNumberOfBytesWritten" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError. The function fails if the requested write operation crosses into an area of the process that is inaccessible.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool WriteProcessMemory(IntPtr hProcess, void* lpBaseAddress, void* lpBuffer,
		                                                    IntPtr nSize, IntPtr* lpNumberOfBytesWritten);

		/// <summary>
		/// Reads data from an area of memory in a specified process. The entire area to be read must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process with memory that is being read. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_READ" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process from which to read. Before any data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for read access, and if it is not accessible the function fails.</param>
		/// <param name="lpBuffer">A pointer to a buffer that receives the contents from the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be read from the specified process.</param>
		/// <param name="lpNumberOfBytesRead">A pointer to a variable that receives the number of bytes transferred into the specified buffer. If <paramref name="lpNumberOfBytesRead" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.
		/// The function fails if the requested read operation crosses into an area of the process that is inaccessible.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool ReadProcessMemory(IntPtr hProcess, void* lpBaseAddress, void* lpBuffer,
		                                                   IntPtr nSize, IntPtr* lpNumberOfBytesRead);

		/// <summary>
		/// Retrieves a handle to the specified standard device (standard input, standard output, or standard error).
		/// </summary>
		/// <param name="nStdHandle">The standard device.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the specified device, or a redirected handle set by a previous call to <see cref="M:PInvoke.Kernel32.SetStdHandle(PInvoke.Kernel32.StdHandle,System.IntPtr)" />. The handle has GENERIC_READ and GENERIC_WRITE access rights, unless the application has used <see cref="M:PInvoke.Kernel32.SetStdHandle(PInvoke.Kernel32.StdHandle,System.IntPtr)" /> to set a standard handle with lesser access.
		/// If the function fails, the return value is <see cref="F:PInvoke.Kernel32.INVALID_HANDLE_VALUE" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// If an application does not have associated standard handles, such as a service running on an interactive desktop, and has not redirected them, the return value is NULL.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr GetStdHandle(Kernel32.StdHandle nStdHandle);

		/// <summary>
		/// Sets the handle for the specified standard device (standard input, standard output, or standard error).
		/// </summary>
		/// <param name="nStdHandle">The standard device for which the handle is to be set.</param>
		/// <param name="nHandle">The handle for the standard device.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetStdHandle(Kernel32.StdHandle nStdHandle, IntPtr nHandle);

		/// <summary>Retrieves a pointer to the specified resource in memory.</summary>
		/// <param name="hResData">
		///     A handle to the resource to be accessed. The <see cref="M:PInvoke.Kernel32.LoadResource(PInvoke.Kernel32.SafeLibraryHandle,System.IntPtr)" /> function returns this
		///     handle.
		/// </param>
		/// <returns>
		///     If the loaded resource is available, the return value is a pointer to the first byte of the resource;
		///     otherwise, it is NULL.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe void* LockResource(IntPtr hResData);

		/// <summary>Retrieves a handle that can be used to obtain a pointer to the first byte of the specified resource in memory.</summary>
		/// <param name="hModule">
		///     A handle to the module whose executable file contains the resource. If hModule is
		///     <see cref="F:PInvoke.Kernel32.SafeLibraryHandle.Null" />, the system loads the resource from the module that was used to create the
		///     current process.
		/// </param>
		/// <param name="hResInfo">
		///     A handle to the resource to be loaded. This handle is returned by the
		///     FindResource or FindResourceEx function.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the data associated with the resource.
		///     <para>
		///         If the function fails, the return value is NULL. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadResource(Kernel32.SafeLibraryHandle hModule, IntPtr hResInfo);

		/// <summary>
		///     Sends a control code directly to a specified device driver, causing the corresponding device to perform the
		///     corresponding operation.
		/// </summary>
		/// <param name="hDevice">
		///     A handle to the device on which the operation is to be performed. The device is typically a
		///     volume, directory, file, or stream. To retrieve a device handle, use the CreateFile function.
		/// </param>
		/// <param name="dwIoControlCode">
		///     The control code for the operation. This value identifies the specific operation to be performed and the type of
		///     device on which to perform it.
		///     <para>
		///         For a list of the control codes, see Remarks. The documentation for each control code provides usage details
		///         for the <paramref name="inBuffer" />, <paramref name="nInBufferSize" />, <paramref name="outBuffer" />, and
		///         <paramref name="nOutBufferSize" /> parameters.
		///     </para>
		/// </param>
		/// <param name="inBuffer">
		///     A pointer to the input buffer that contains the data required to perform the operation. The format of this data
		///     depends on the value of the <paramref name="dwIoControlCode" /> parameter.
		///     <para>
		///         This parameter can be NULL if <paramref name="dwIoControlCode" /> specifies an operation that does not
		///         require input data.
		///     </para>
		/// </param>
		/// <param name="nInBufferSize">The size of the input buffer, in bytes.</param>
		/// <param name="outBuffer">
		///     A pointer to the output buffer that is to receive the data returned by the operation. The format of this data
		///     depends on the value of the <paramref name="dwIoControlCode" /> parameter.
		///     <para>
		///         This parameter can be NULL if <paramref name="dwIoControlCode" /> specifies an operation that does not return
		///         data.
		///     </para>
		/// </param>
		/// <param name="nOutBufferSize">The size of the output buffer, in bytes.</param>
		/// <param name="pBytesReturned">
		///     A pointer to a variable that receives the size of the data stored in the output buffer, in bytes.
		///     <para>
		///         If the output buffer is too small to receive any data, the call fails, <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_INSUFFICIENT_BUFFER" />, and lpBytesReturned is zero.
		///     </para>
		///     <para>
		///         If the output buffer is too small to hold all of the data but can hold some entries, some drivers will return
		///         as much data as fits. In this case, the call fails, <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_MORE_DATA" />, and lpBytesReturned indicates the amount of data received. Your
		///         application should call DeviceIoControl again with the same operation, specifying a new starting point.
		///     </para>
		///     <para>
		///         If <paramref name="lpOverlapped" /> is NULL, lpBytesReturned cannot be NULL. Even when an operation returns
		///         no output data and lpOutBuffer is NULL, DeviceIoControl makes use of lpBytesReturned. After such an operation,
		///         the value of lpBytesReturned is meaningless.
		///     </para>
		///     <para>
		///         If <paramref name="lpOverlapped" /> is not NULL, lpBytesReturned can be NULL. If this parameter is not NULL
		///         and the operation returns data, lpBytesReturned is meaningless until the overlapped operation has completed. To
		///         retrieve the number of bytes returned, call GetOverlappedResult. If hDevice is associated with an I/O
		///         completion port, you can retrieve the number of bytes returned by calling GetQueuedCompletionStatus.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an OVERLAPPED structure.
		///     <para>
		///         If hDevice was opened without specifying <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_FLAG_OVERLAPPED" />, lpOverlapped is
		///         ignored.
		///     </para>
		///     <para>
		///         If hDevice was opened with the <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_FLAG_OVERLAPPED" /> flag, the operation is
		///         performed as an overlapped (asynchronous) operation. In this case, lpOverlapped must point to a valid
		///         OVERLAPPED structure that contains a handle to an event object. Otherwise, the function fails in unpredictable
		///         ways.
		///     </para>
		///     <para>
		///         For overlapped operations, DeviceIoControl returns immediately, and the event object is signaled when the
		///         operation has been completed. Otherwise, the function does not return until the operation has been completed or
		///         an error occurs.
		///     </para>
		/// </param>
		/// <returns>
		///     If the operation completes successfully, the return value is nonzero.
		///     <para>
		///         If the operation fails or is pending, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool DeviceIoControl(Kernel32.SafeObjectHandle hDevice, int dwIoControlCode,
		                                                 void* inBuffer, int nInBufferSize, void* outBuffer,
		                                                 int nOutBufferSize, out int pBytesReturned,
		                                                 Kernel32.OVERLAPPED* lpOverlapped);

		/// <summary>
		/// Sets the current system time and date. The system time is expressed in Coordinated Universal Time (UTC).
		/// </summary>
		/// <param name="lpSystemTime">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure that contains the new system date and time.
		/// The wDayOfWeek member of the <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure is ignored.</param>
		/// <returns>
		///     If the function succeeds, the return value is a nonzero value.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool SetSystemTime(Kernel32.SYSTEMTIME* lpSystemTime);

		/// <summary>Retrieves information about the first process encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		///     A handle to the snapshot returned from a previous call to the
		///     <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <returns>
		///     The first <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> if there was any or <see langword="null" /> otherwise (No values in
		///     the snapshot).
		/// </returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if any error occurs.</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hSnapshot" /> is <see langword="null" />.</exception>
		public static Kernel32.PROCESSENTRY32? Process32First(Kernel32.SafeObjectHandle hSnapshot) {
			if (hSnapshot == null)
				throw new ArgumentNullException(nameof(hSnapshot));
			Kernel32.PROCESSENTRY32 lppe = Kernel32.PROCESSENTRY32.Create();
			if (Kernel32.Process32First(hSnapshot, ref lppe))
				return new Kernel32.PROCESSENTRY32?(lppe);
			Win32ErrorCode lastError = Kernel32.GetLastError();
			if (lastError != 18)
				throw new Win32Exception(lastError);
			return new Kernel32.PROCESSENTRY32?();
		}

		/// <summary>Retrieves information about the next process encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		///     A handle to the snapshot returned from a previous call to the
		///     <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <returns>
		///     The next <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> if there was any or <see langword="null" /> otherwise (No more values
		///     in the snapshot).
		/// </returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if any error occurs.</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hSnapshot" /> is <see langword="null" />.</exception>
		public static Kernel32.PROCESSENTRY32? Process32Next(Kernel32.SafeObjectHandle hSnapshot) {
			if (hSnapshot == null)
				throw new ArgumentNullException(nameof(hSnapshot));
			Kernel32.PROCESSENTRY32 lppe = Kernel32.PROCESSENTRY32.Create();
			if (Kernel32.Process32Next(hSnapshot, ref lppe))
				return new Kernel32.PROCESSENTRY32?(lppe);
			Win32ErrorCode lastError = Kernel32.GetLastError();
			if (lastError != 18)
				throw new Win32Exception(lastError);
			return new Kernel32.PROCESSENTRY32?();
		}

		/// <summary>Retrieves information about next process encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		///     A handle to the snapshot returned from a previous call to the
		///     <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <returns>
		///     An enumeration of all the <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> present in the snapshot.
		/// </returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if any error occurs.</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hSnapshot" /> is <see langword="null" />.</exception>
		public static IEnumerable<Kernel32.PROCESSENTRY32> Process32Enumerate(Kernel32.SafeObjectHandle hSnapshot) {
			if (hSnapshot == null)
				throw new ArgumentNullException(nameof(hSnapshot));
			for (Kernel32.PROCESSENTRY32? nullable = Kernel32.Process32First(hSnapshot);
				nullable.HasValue;
				nullable = Kernel32.Process32Next(hSnapshot))
				yield return nullable.Value;
		}

		/// <summary>Retrieves information about the first module encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		///     A handle to the snapshot returned from a previous call to the
		///     <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <returns>
		///     The first <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> if there was any or <see langword="null" /> otherwise (No values in
		///     the snapshot).
		/// </returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if any error occurs.</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hSnapshot" /> is <see langword="null" />.</exception>
		public static Kernel32.MODULEENTRY32? Module32First(Kernel32.SafeObjectHandle hSnapshot) {
			if (hSnapshot == null)
				throw new ArgumentNullException(nameof(hSnapshot));
			Kernel32.MODULEENTRY32 lpme = Kernel32.MODULEENTRY32.Create();
			if (Kernel32.Module32First(hSnapshot, ref lpme))
				return new Kernel32.MODULEENTRY32?(lpme);
			Win32ErrorCode lastError = Kernel32.GetLastError();
			if (lastError != 18)
				throw new Win32Exception(lastError);
			return new Kernel32.MODULEENTRY32?();
		}

		/// <summary>Retrieves information about the next module encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		///     A handle to the snapshot returned from a previous call to the
		///     <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <returns>
		///     The next <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> if there was any or <see langword="null" /> otherwise (No more values
		///     in the snapshot).
		/// </returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if any error occurs.</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hSnapshot" /> is <see langword="null" />.</exception>
		public static Kernel32.MODULEENTRY32? Module32Next(Kernel32.SafeObjectHandle hSnapshot) {
			if (hSnapshot == null)
				throw new ArgumentNullException(nameof(hSnapshot));
			Kernel32.MODULEENTRY32 lpme = Kernel32.MODULEENTRY32.Create();
			if (Kernel32.Module32Next(hSnapshot, ref lpme))
				return new Kernel32.MODULEENTRY32?(lpme);
			Win32ErrorCode lastError = Kernel32.GetLastError();
			if (lastError != 18)
				throw new Win32Exception(lastError);
			return new Kernel32.MODULEENTRY32?();
		}

		/// <summary>Retrieves information about next module encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		///     A handle to the snapshot returned from a previous call to the
		///     <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <returns>
		///     An enumeration of all the <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> present in the snapshot.
		/// </returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if any error occurs.</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hSnapshot" /> is <see langword="null" />.</exception>
		public static IEnumerable<Kernel32.MODULEENTRY32> Module32Enumerate(Kernel32.SafeObjectHandle hSnapshot) {
			if (hSnapshot == null)
				throw new ArgumentNullException(nameof(hSnapshot));
			for (Kernel32.MODULEENTRY32? nullable = Kernel32.Module32First(hSnapshot);
				nullable.HasValue;
				nullable = Kernel32.Module32Next(hSnapshot))
				yield return nullable.Value;
		}

		public static unsafe string QueryFullProcessImageName(Kernel32.SafeObjectHandle hProcess,
		                                                      Kernel32.QueryFullProcessImageNameFlags dwFlags =
			                                                      Kernel32.QueryFullProcessImageNameFlags.None) {
			int maxValue = (int) byte.MaxValue;
			do {
				char[] chArray;
				char* lpExeName = (chArray = new char[maxValue]) == null || chArray.Length == 0
					? (char*) null
					: &chArray[0];
				if (Kernel32.QueryFullProcessImageName(hProcess, dwFlags, lpExeName, ref maxValue))
					return new string(lpExeName, 0, maxValue);
				Win32ErrorCode lastError = Kernel32.GetLastError();
				if (lastError != 122)
					lastError.ThrowOnError();
				chArray = (char[]) null;
				maxValue *= 2;
			} while (maxValue < 2062336);

			throw new InvalidOperationException(string.Format(
				"QueryFullProcessImageName is expecting a buffer of more than {0} bytes", (object) 2062336));
		}

		public static bool IsWow64Process(Kernel32.SafeObjectHandle hProcess) {
			bool Wow64Process;
			if (!Kernel32.IsWow64Process(hProcess, out Wow64Process))
				throw new Win32Exception();
			return Wow64Process;
		}

		/// <summary>
		/// Allocates the specified number of bytes from the heap.
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. The default is the <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_FIXED" /> value. This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.
		/// </param>
		/// <param name="uBytes">The number of bytes to allocate. If this parameter is zero and the <paramref name="uFlags" /> parameter specifies <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_MOVEABLE" />, the function returns a handle to a memory object that is marked as discarded.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe void* LocalAlloc(Kernel32.LocalAllocFlags uFlags, int uBytes) {
			return Kernel32.LocalAlloc(uFlags, new IntPtr(uBytes));
		}

		/// <summary>
		/// Changes the size or the attributes of a specified local memory object. The size can increase or decrease.
		/// </summary>
		/// <param name="hMem">A handle to the local memory object to be reallocated. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.LocalReAllocFlags)" /> function.</param>
		/// <param name="uBytes">The new size of the memory block, in bytes. If uFlags specifies <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" />, this parameter is ignored.</param>
		/// <param name="uFlags">
		/// The reallocation options. If <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" /> is specified, the function modifies the attributes of the memory object only (the uBytes parameter is ignored.) Otherwise, the function reallocates the memory object.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// If LocalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// If LocalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block. To access the memory, a process can simply cast the return value to a pointer.
		/// </remarks>
		public static unsafe void* LocalReAlloc(void* hMem, int uBytes, Kernel32.LocalReAllocFlags uFlags) {
			return Kernel32.LocalReAlloc(hMem, new IntPtr(uBytes), uFlags);
		}

		/// <summary>
		/// Searches a directory for a file or subdirectory with a name and attributes that match those specified.
		/// For the most basic version of this function, see FindFirstFile.
		/// To perform this operation as a transacted operation, use the FindFirstFileTransacted function.
		/// </summary>
		/// <param name="lpFileName">
		/// The directory or path, and the file name, which can include wildcard characters, for example, an asterisk (*) or a question mark (?).
		/// This parameter should not be NULL, an invalid string (for example, an empty string or a string that is missing the terminating null character), or end in a trailing backslash (\).
		/// If the string ends with a wildcard, period, or directory name, the user must have access to the root and all subdirectories on the path.
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to approximately 32,000 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming a File.
		/// </param>
		/// <param name="fInfoLevelId">
		/// The information level of the returned data.
		/// This parameter is one of the <see cref="T:PInvoke.Kernel32.FINDEX_INFO_LEVELS" /> enumeration values.
		/// </param>
		/// <param name="lpFindFileData">
		/// A pointer to the buffer that receives the file data.
		/// The pointer type is determined by the level of information that is specified in the <paramref name="fInfoLevelId" /> parameter.
		/// </param>
		/// <param name="fSearchOp">
		/// The type of filtering to perform that is different from wildcard matching.
		/// This parameter is one of the <see cref="T:PInvoke.Kernel32.FINDEX_SEARCH_OPS" /> enumeration values.
		/// </param>
		/// <param name="lpSearchFilter">
		/// A pointer to the search criteria if the specified <paramref name="fSearchOp" /> needs structured search information.
		/// At this time, none of the supported fSearchOp values require extended search information. Therefore, this pointer must be NULL.
		/// </param>
		/// <param name="dwAdditionalFlags">Specifies additional flags that control the search.</param>
		/// <returns>
		/// If the function succeeds, the return value is a search handle used in a subsequent call to FindNextFile or FindClose, and the lpFindFileData parameter contains information about the first file or directory found.
		/// If the function fails or fails to locate files from the search string in the lpFileName parameter, the return value is INVALID_HANDLE_VALUE and the contents of lpFindFileData are indeterminate.To get extended error information, call the <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		/// </returns>
		[DllImport("Kernel32", EntryPoint = "FindFirstFileExW", CharSet = CharSet.Unicode)]
		public static extern unsafe Kernel32.SafeFindFilesHandle FindFirstFileEx(
			string lpFileName, Kernel32.FINDEX_INFO_LEVELS fInfoLevelId, out Kernel32.WIN32_FIND_DATA lpFindFileData,
			Kernel32.FINDEX_SEARCH_OPS fSearchOp, void* lpSearchFilter,
			Kernel32.FindFirstFileExFlags dwAdditionalFlags);

		/// <summary>
		/// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
		/// </summary>
		/// <param name="dwFlags">
		/// The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
		/// </param>
		/// <param name="lpSource">
		/// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags" /> parameter.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE" />: A handle to the module that contains the message table to search.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />: Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.
		/// If neither of these flags is set in dwFlags, then lpSource is ignored.
		/// </param>
		/// <param name="dwMessageId">
		/// The message identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// </param>
		/// <param name="dwLanguageId">
		/// The language identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only.If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND.If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:
		/// Language neutral
		/// Thread LANGID, based on the thread's locale value
		/// User default LANGID, based on the user's default locale value
		/// System default LANGID, based on the system default locale value
		/// US English
		/// If FormatMessage does not locate a message for any of the preceding LANGIDs, it returns any language message string that is present.If that fails, it returns ERROR_RESOURCE_LANG_NOT_FOUND.
		/// </param>
		/// <param name="lpBuffer">
		/// A pointer to a buffer that receives the null-terminated string that specifies the formatted message. If dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" />, the function allocates a buffer using the LocalAlloc function, and places the pointer to the buffer at the address specified in lpBuffer.
		/// This buffer cannot be larger than 64K bytes.
		/// </param>
		/// <param name="nSize">
		/// If the <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" /> flag is not set, this parameter specifies the size of the output buffer, in TCHARs. If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" /> is set,
		/// this parameter specifies the minimum number of TCHARs to allocate for an output buffer.
		/// The output buffer cannot be larger than 64K bytes.
		/// </param>
		/// <param name="Arguments">
		/// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.
		/// The interpretation of each value depends on the formatting information associated with the insert in the message definition.The default is to treat each value as a pointer to a null-terminated string.
		/// By default, the Arguments parameter is of type va_list*, which is a language- and implementation-specific data type for describing a variable number of arguments.The state of the va_list argument is undefined upon return from the function.To use the va_list again, destroy the variable argument list pointer using va_end and reinitialize it with va_start.
		/// If you do not have a pointer of type va_list*, then specify the FORMAT_MESSAGE_ARGUMENT_ARRAY flag and pass a pointer to an array of DWORD_PTR values; those values are input to the message formatted as the insert values.Each insert must have a corresponding element in the array.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of TCHARs stored in the output buffer, excluding the terminating null character.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", EntryPoint = "FormatMessageW", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int FormatMessage(Kernel32.FormatMessageFlags dwFlags, void* lpSource,
		                                              int dwMessageId, int dwLanguageId, StringBuilder lpBuffer,
		                                              int nSize, IntPtr[] Arguments);

		/// <summary>
		/// Retrieves the thread identifier of the calling thread.
		/// </summary>
		/// <returns>The thread identifier of the calling thread.</returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern int GetCurrentThreadId();

		/// <summary>Retrieves the process identifier of the calling process.</summary>
		/// <returns>The process identifier of the calling process.</returns>
		/// <remarks>Until the process terminates, the process identifier uniquely identifies the process throughout the system.</remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern int GetCurrentProcessId();

		/// <summary>
		/// Retrieves the process identifier of the specified process.
		/// </summary>
		/// <param name="Process">A handle to the process. The handle must have the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see Process Security and Access Rights.</param>
		/// <returns>The process identifier of the specified process.</returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern int GetProcessId(IntPtr Process);

		/// <summary>Retrieves a pseudo handle for the current process.</summary>
		/// <returns>The return value is a pseudo handle to the current process.</returns>
		/// <remarks>
		///     A pseudo handle is a special constant, currently (HANDLE)-1, that is interpreted as the current process handle. For
		///     compatibility with future operating systems, it is best to call GetCurrentProcess instead of hard-coding this
		///     constant value. The calling process can use a pseudo handle to specify its own process whenever a process handle is
		///     required. Pseudo handles are not inherited by child processes.
		///     <para>This handle has the PROCESS_ALL_ACCESS access right to the process object.</para>
		///     <para>
		///         Windows Server 2003 and Windows XP:  This handle has the maximum access allowed by the security descriptor of
		///         the process to the primary token of the process.
		///     </para>
		///     <para>
		///         A process can create a "real" handle to itself that is valid in the context of other processes, or that can
		///         be inherited by other processes, by specifying the pseudo handle as the source handle in a call to the
		///         DuplicateHandle function. A process can also use the OpenProcess function to open a real handle to itself.
		///     </para>
		///     <para>
		///         The pseudo handle need not be closed when it is no longer needed. Calling the <see cref="M:PInvoke.Kernel32.CloseHandle(System.IntPtr)" />
		///         function with a pseudo handle has no effect.If the pseudo handle is duplicated by DuplicateHandle, the
		///         duplicate handle must be closed.
		///     </para>
		/// </remarks>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern Kernel32.SafeObjectHandle GetCurrentProcess();

		/// <summary>
		///     Marks any outstanding I/O operations for the specified file handle. The function only cancels I/O operations
		///     in the current process, regardless of which thread created the I/O operation.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> data structure that contains the data used for asynchronous I/O.
		///     <para>If this parameter is NULL, all I/O requests for the hFile parameter are canceled.</para>
		///     <para>
		///         If this parameter is not NULL, only those specific I/O requests that were issued for the file with the
		///         specified
		///         <paramref name="lpOverlapped" /> overlapped structure are marked as canceled, meaning that you can cancel one
		///         or more requests, while the CancelIo function cancels all outstanding requests on a file handle.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero. The cancel operation for all pending I/O operations issued
		///     by the calling process for the specified file handle was successfully requested. The application must not free or
		///     reuse the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure associated with the canceled I/O operations until they have
		///     completed. The thread can use the GetOverlappedResult function to determine when the I/O operations themselves have
		///     been completed.
		///     <para>
		///         If the function fails, the return value is 0 (zero). To get extended error information, call the
		///         <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		///     </para>
		///     <para>
		///         If this function cannot find a request to cancel, the return value is 0 (zero), and
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />
		///         returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_NOT_FOUND" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool CancelIoEx(Kernel32.SafeObjectHandle hFile, Kernel32.OVERLAPPED* lpOverlapped);

		/// <summary>
		///     Reads data from the specified file or input/output (I/O) device. Reads occur at the position specified by the file
		///     pointer if supported by the device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operations. For a similar function designed
		///         solely for asynchronous operation, see ReadFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer, tape drive,
		///     socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		///     <para>
		///         For asynchronous read operations, hFile can be any handle that is opened with the FILE_FLAG_OVERLAPPED flag
		///         by the CreateFile function, or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer that receives the data read from a file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the read operation. The caller must not use this buffer
		///         until the read operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">
		///     A pointer to the variable that receives the number of bytes read when using a synchronous hFile parameter. ReadFile
		///     sets this value to zero before doing any work or error checking. Use <see langword="null" /> for this parameter if
		///     this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be <see langword="null" /> only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise it can be <see langword="null" />.
		///     <para>
		///         If hFile is opened with FILE_FLAG_OVERLAPPED, the <paramref name="lpOverlapped" /> parameter must point to a
		///         valid and unique <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure, otherwise the function can incorrectly report that the
		///         read operation is complete.
		///     </para>
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start reading from the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the read operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool ReadFile(Kernel32.SafeObjectHandle hFile, void* lpBuffer,
		                                          int nNumberOfBytesToRead, int* lpNumberOfBytesRead,
		                                          Kernel32.OVERLAPPED* lpOverlapped);

		/// <summary>
		///     Writes data to the specified file or input/output (I/O) device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operation. For a similar function designed
		///         solely for asynchronous operation, see WriteFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the file or I/O device (for example, a file, file stream, physical disk, volume, console buffer, tape
		///     drive, socket, communications resource, mailslot, or pipe).
		///     <para>
		///         The hFile parameter must have been created with the write access. For more information, see Generic Access
		///         Rights and File Security and Access Rights.
		///     </para>
		///     <para>
		///         For asynchronous write operations, hFile can be any handle opened with the CreateFile function using the
		///         FILE_FLAG_OVERLAPPED flag or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer containing the data to be written to the file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the write operation. The caller must not use this buffer
		///         until the write operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToWrite">
		///     The number of bytes to be written to the file or device.
		///     <para>
		///         A value of zero specifies a null write operation. The behavior of a null write operation depends on the
		///         underlying file system or communications technology.
		///     </para>
		/// </param>
		/// <param name="lpNumberOfBytesWritten">
		///     A pointer to the variable that receives the number of bytes written when using a synchronous hFile parameter.
		///     WriteFile sets this value to zero before doing any work or error checking. Use <see langword="null" />
		///     for this parameter if this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be NULL only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise this parameter can be NULL.
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start writing to the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		///     <para>
		///         To write to the end of file, specify both the Offset and OffsetHigh members of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" />
		///         structure as 0xFFFFFFFF. This is functionally equivalent to previously calling the CreateFile function to open
		///         hFile using FILE_APPEND_DATA access.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the write operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe bool WriteFile(Kernel32.SafeObjectHandle hFile, void* lpBuffer,
		                                           int nNumberOfBytesToWrite, int* lpNumberOfBytesWritten,
		                                           Kernel32.OVERLAPPED* lpOverlapped);

		/// <summary>
		/// Suspends the specified thread.
		/// A 64-bit application can suspend a WOW64 thread using the Wow64SuspendThread function (desktop only).
		/// </summary>
		/// <param name="hThread">
		/// A handle to the thread that is to be suspended.
		/// The handle must have the THREAD_SUSPEND_RESUME access right. For more information, see Thread Security and Access Rights.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the thread's previous suspend count; otherwise, it is (DWORD) -1. To get extended error information, use the <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int SuspendThread(Kernel32.SafeObjectHandle hThread);

		/// <summary>
		/// Decrements a thread's suspend count. When the suspend count is decremented to zero, the execution of the thread is resumed.
		/// </summary>
		/// <param name="hThread">
		/// A handle to the thread to be restarted.
		/// This handle must have the THREAD_SUSPEND_RESUME access right. For more information, see Thread Security and Access Rights.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the thread's previous suspend count.
		/// If the function fails, the return value is (DWORD) -1. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int ResumeThread(Kernel32.SafeObjectHandle hThread);

		/// <summary>
		/// Waits until the specified object is in the signaled state or the time-out interval elapses.
		/// To enter an alertable wait state, use the WaitForSingleObjectEx function. To wait for multiple objects, use WaitForMultipleObjects.
		/// </summary>
		/// <param name="hHandle">
		/// A handle to the object. For a list of the object types whose handles can be specified, see the following Remarks section.
		/// If this handle is closed while the wait is still pending, the function's behavior is undefined.
		/// The handle must have the SYNCHRONIZE access right. For more information, see Standard Access Rights.
		/// </param>
		/// <param name="dwMilliseconds">
		/// The time-out interval, in milliseconds. If a nonzero value is specified, the function waits until the object is signaled or the interval elapses. If dwMilliseconds is zero, the function does not enter a wait state if the object is not signaled; it always returns immediately. If dwMilliseconds is INFINITE, the function will return only when the object is signaled.
		/// See MSDN docs for more information.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value indicates the event that caused the function to return. It can be one of the following values.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern Kernel32.WaitForSingleObjectResult WaitForSingleObject(
			SafeHandle hHandle, int dwMilliseconds);

		/// <summary>Closes an open object handle.</summary>
		/// <param name="hObject">A valid handle to an open object.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr hObject);

		/// <summary>Flushes the buffers of a specified file and causes all buffered data to be written to a file.</summary>
		/// <param name="hFile">
		///     A handle to the open file.
		///     <para>
		///         The file handle must have the GENERIC_WRITE access right. For more information, see File Security and Access
		///         Rights.
		///     </para>
		///     <para>If hFile is a handle to a communications device, the function only flushes the transmit buffer.</para>
		///     <para>
		///         If hFile is a handle to the server end of a named pipe, the function does not return until the client has
		///         read all buffered data from the pipe.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		///     <para>
		///         The function fails if hFile is a handle to the console output. That is because the console output is not
		///         buffered. The function returns FALSE, and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_HANDLE" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlushFileBuffers(Kernel32.SafeObjectHandle hFile);

		/// <summary>Creates or opens a named or unnamed mutex object.</summary>
		/// <param name="lpMutexAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure. If this parameter is NULL, the handle cannot be inherited by child processes.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a security descriptor for the new mutex. If <paramref name="lpMutexAttributes" /> is NULL, the mutex gets a default security descriptor. The ACLs in the default security descriptor for a mutex come from the primary or impersonation token of the creator. For more information, see Synchronization Object Security and Access Rights.
		/// </param>
		/// <param name="bInitialOwner">
		/// If this value is TRUE and the caller created the mutex, the calling thread obtains initial ownership of the mutex object. Otherwise, the calling thread does not obtain ownership of the mutex. To determine if the caller created the mutex, see the Return Values section.
		/// </param>
		/// <param name="lpName">
		/// The name of the mutex object. The name is limited to MAX_PATH characters. Name comparison is case sensitive.
		/// If lpName matches the name of an existing named mutex object, this function requests the MUTEX_ALL_ACCESS access right. In this case, the bInitialOwner parameter is ignored because it has already been set by the creating process. If the lpMutexAttributes parameter is not NULL, it determines whether the handle can be inherited, but its security-descriptor member is ignored.
		/// If lpName is NULL, the mutex object is created without a name.
		/// If lpName matches the name of an existing event, semaphore, waitable timer, job, or file-mapping object, the function fails and the GetLastError function returns ERROR_INVALID_HANDLE. This occurs because these objects share the same namespace.
		/// The name can have a "Global\" or "Local\" prefix to explicitly create the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\). For more information, see Kernel Object Namespaces. Fast user switching is implemented using Terminal Services sessions. Kernel object names must follow the guidelines outlined for Terminal Services so that applications can support multiple users.
		/// The object can be created in a private namespace. For more information, see Object Namespaces.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly created mutex object.
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// If the mutex is a named mutex and the object existed before this function call, the return value is a handle to the existing object, GetLastError returns ERROR_ALREADY_EXISTS, bInitialOwner is ignored, and the calling thread is not granted ownership. However, if the caller has limited access rights, the function will fail with ERROR_ACCESS_DENIED and the caller should use the OpenMutex function.
		/// </returns>
		[DllImport("Kernel32", EntryPoint = "CreateMutexW", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe Kernel32.SafeObjectHandle CreateMutex(
			Kernel32.SECURITY_ATTRIBUTES* lpMutexAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner,
			string lpName);

		/// <summary>
		/// Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
		/// </summary>
		/// <param name="hModule">A handle to the DLL module that contains the function or variable. The LoadLibrary, LoadLibraryEx, or GetModuleHandle function returns this handle.</param>
		/// <param name="procName">The function or variable name, or the function's ordinal value. If this parameter is an ordinal value, it must be in the low-order word; the high-order word must be zero.</param>
		/// <returns>
		/// If the function succeeds, the return value is the address of the exported function or variable.
		/// If the function fails, the return value is NULL.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>This function does not retrieve handles for modules that were loaded using the LoadLibraryExFlags.LOAD_LIBRARY_AS_DATAFILE flag.</remarks>
		[DllImport("Kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern IntPtr GetProcAddress(Kernel32.SafeLibraryHandle hModule, string procName);

		/// <summary>
		/// Retrieves the number of milliseconds that have elapsed since the system was started, up to 49.7 days.
		/// </summary>
		/// <returns>The return value is the number of milliseconds that have elapsed since the system was started.</returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern uint GetTickCount();

		/// <summary>
		/// Retrieves the number of milliseconds that have elapsed since the system was started.
		/// </summary>
		/// <returns>The number of milliseconds.</returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern ulong GetTickCount64();

		/// <summary>
		/// Retrieves the current system date and time. The system time is expressed in Coordinated Universal Time (UTC).
		/// To retrieve the current system date and time in local time, use the GetLocalTime function.
		/// </summary>
		/// <param name="lpSystemTime">
		/// A pointer to a SYSTEMTIME structure to receive the current system date and time.
		/// The lpSystemTime parameter must not be NULL. Using NULL will result in an access violation.
		/// </param>
		[DllImport("Kernel32", CharSet = CharSet.Unicode)]
		public static extern unsafe void GetSystemTime(Kernel32.SYSTEMTIME* lpSystemTime);

		/// <summary>Sets the last-error code for the calling thread.</summary>
		/// <param name="dwErrCode">The last-error code for the thread.</param>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern void SetLastError(uint dwErrCode);

		/// <summary>
		///     Closes a file search handle opened by the FindFirstFile, FindFirstFileEx, FindFirstFileNameW,
		///     FindFirstFileNameTransactedW, FindFirstFileTransacted, FindFirstStreamTransactedW, or FindFirstStreamW functions.
		/// </summary>
		/// <param name="hFindFile">The file search handle.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern bool FindClose(IntPtr hFindFile);

		/// <summary>
		///     Frees the loaded dynamic-link library (DLL) module and, if necessary, decrements its reference count. When the
		///     reference count reaches zero, the module is unloaded from the address space of the calling process and the handle
		///     is no longer valid.
		/// </summary>
		/// <param name="hModule">
		///     A handle to the loaded library module. The LoadLibrary, LoadLibraryEx, GetModuleHandle, or
		///     GetModuleHandleEx function returns this handle.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a nonzero value.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		[DllImport("Kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool FreeLibrary(IntPtr hModule);

		/// <summary>
		/// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
		/// </summary>
		/// <param name="dwFlags">
		/// The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
		/// The <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ARGUMENT_ARRAY" /> flag is always added
		/// and the <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" /> flag is always suppressed by this helper method
		/// </param>
		/// <param name="lpSource">
		/// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags" /> parameter.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE" />: A handle to the module that contains the message table to search.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />: Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.
		/// If neither of these flags is set in dwFlags, then lpSource is ignored.
		/// </param>
		/// <param name="dwMessageId">
		/// The message identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// </param>
		/// <param name="dwLanguageId">
		/// The language identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only.If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND.If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:
		/// Language neutral
		/// Thread LANGID, based on the thread's locale value
		/// User default LANGID, based on the user's default locale value
		/// System default LANGID, based on the system default locale value
		/// US English
		/// If FormatMessage does not locate a message for any of the preceding LANGIDs, it returns any language message string that is present.If that fails, it returns ERROR_RESOURCE_LANG_NOT_FOUND.
		/// </param>
		/// <param name="Arguments">
		/// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.
		/// The interpretation of each value depends on the formatting information associated with the insert in the message definition.The default is to treat each value as a pointer to a null-terminated string.
		/// By default, the Arguments parameter is of type va_list*, which is a language- and implementation-specific data type for describing a variable number of arguments.The state of the va_list argument is undefined upon return from the function.To use the va_list again, destroy the variable argument list pointer using va_end and reinitialize it with va_start.
		/// If you do not have a pointer of type va_list*, then specify the FORMAT_MESSAGE_ARGUMENT_ARRAY flag and pass a pointer to an array of DWORD_PTR values; those values are input to the message formatted as the insert values.Each insert must have a corresponding element in the array.
		/// </param>
		/// <param name="maxAllowedBufferSize">The maximum size of the returned string. If exceeded, <c>null</c> is returned.</param>
		/// <returns>
		/// If the function succeeds, the return value is the number of TCHARs stored in the output buffer, excluding the terminating null character.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe string FormatMessage(Kernel32.FormatMessageFlags dwFlags, void* lpSource, int dwMessageId,
		                                          int dwLanguageId, IntPtr[] Arguments, int maxAllowedBufferSize) {
			StringBuilder sb = new StringBuilder(256);
			string errorMsg;
			while (!Kernel32.TryGetErrorMessage(dwFlags, lpSource, dwMessageId, dwLanguageId, sb, Arguments,
				out errorMsg)) {
				if (Kernel32.GetLastError() != 122)
					return (string) null;
				sb.Capacity *= 4;
				if (sb.Capacity >= maxAllowedBufferSize)
					return (string) null;
			}

			return errorMsg;
		}

		/// <summary>
		///     Returns the error code returned by the last unmanaged function that was called using platform invoke that has
		///     the <see cref="F:System.Runtime.InteropServices.DllImportAttribute.SetLastError" /> flag set.
		/// </summary>
		/// <returns>
		///     The last error code set by a call to the Win32 SetLastError function.
		///     <para>
		///         The Return Value section of the documentation for each function that sets the last-error code notes the
		///         conditions under which the function sets the last-error code. Most functions that set the thread's last-error
		///         code set it when they fail. However, some functions also set the last-error code when they succeed. If the
		///         function is not documented to set the last-error code, the value returned by this function is simply the most
		///         recent last-error code to have been set; some functions set the last-error code to
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" /> on success and others do not.
		///     </para>
		/// </returns>
		/// <remarks>
		///     This method exists because it is not safe to make a direct platform invoke call to GetLastError to obtain this
		///     information. If you want to access this error code, you must call <see cref="M:PInvoke.Kernel32.GetLastError" /> instead of writing
		///     your own platform invoke definition for GetLastError and calling it. The common language runtime can make internal
		///     calls to APIs that overwrite the GetLastError maintained by the operating system.
		///     <para>
		///         You can use this method to obtain error codes only if you apply the <see cref="T:System.Runtime.InteropServices.DllImportAttribute" /> to the
		///         method signature and set the <see cref="F:System.Runtime.InteropServices.DllImportAttribute.SetLastError" /> field to true. The process for this
		///         varies depending upon the source language used: C# and C++ are false by default, but the Declare statement in
		///         Visual Basic is true.
		///     </para>
		/// </remarks>
		/// <devremarks>
		///     See
		///     https://stackoverflow.com/questions/17918266/winapi-getlasterror-vs-marshal-getlastwin32error/17918729#17918729 for
		///     more details.
		/// </devremarks>
		public static Win32ErrorCode GetLastError() {
			return (Win32ErrorCode) Marshal.GetLastWin32Error();
		}

		/// <summary>Writes data synchronously to the specified file or input/output (I/O) device.</summary>
		/// <param name="hFile">
		///     A handle to the file or I/O device (for example, a file, file stream, physical disk, volume, console buffer, tape
		///     drive, socket, communications resource, mailslot, or pipe).
		///     <para>
		///         The hFile parameter must have been created with the write access. For more information, see Generic Access
		///         Rights and File Security and Access Rights.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">A pointer to the buffer containing the data to be written to the file or device.</param>
		/// <param name="nNumberOfBytesToWrite">
		///     The number of bytes to be written to the file or device.
		///     <para>
		///         A value of zero specifies a null write operation. The behavior of a null write operation depends on the
		///         underlying file system or communications technology.
		///     </para>
		/// </param>
		/// <returns>The number of bytes written.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if the native method return false (Write failed).</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hFile" /> is <see langword="null" />.</exception>
		public static unsafe int WriteFile(Kernel32.SafeObjectHandle hFile, void* lpBuffer, int nNumberOfBytesToWrite) {
			if (hFile == null)
				throw new ArgumentNullException(nameof(hFile));
			int? lpNumberOfBytesWritten = new int?(0);
			if (!Kernel32.WriteFile(hFile, lpBuffer, nNumberOfBytesToWrite, ref lpNumberOfBytesWritten,
				(Kernel32.OVERLAPPED*) null))
				throw new Win32Exception();
			return lpNumberOfBytesWritten.Value;
		}

		/// <summary>Writes data synchronously to the specified file or input/output (I/O) device.</summary>
		/// <param name="hFile">
		///     A handle to the file or I/O device (for example, a file, file stream, physical disk, volume, console buffer, tape
		///     drive, socket, communications resource, mailslot, or pipe).
		///     <para>
		///         The hFile parameter must have been created with the write access. For more information, see Generic Access
		///         Rights and File Security and Access Rights.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">The buffer containing the data to be written to the file or device.</param>
		/// <returns>The number of bytes written.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if the native method return false (Write failed).</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hFile" /> is <see langword="null" />.</exception>
		public static unsafe int WriteFile(Kernel32.SafeObjectHandle hFile, ArraySegment<byte> lpBuffer) {
			if (hFile == null)
				throw new ArgumentNullException(nameof(hFile));
			byte[] array;
			byte* numPtr = ((array = lpBuffer.Array) == null || array.Length == 0 ? (byte*) null : &array[0]) +
				lpBuffer.Offset;
			return Kernel32.WriteFile(hFile, (void*) numPtr, lpBuffer.Count);
		}

		/// <summary>Reads data synchronously from the specified file or input/output (I/O) device.</summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer,
		///     tape drive, socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		/// </param>
		/// <param name="lpBuffer">A pointer to the buffer that receives the data read from a file or device.</param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <returns>The number of bytes read.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if the native method return false (Read failed).</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hFile" /> is <see langword="null" />.</exception>
		public static unsafe int ReadFile(Kernel32.SafeObjectHandle hFile, void* lpBuffer, int nNumberOfBytesToRead) {
			if (hFile == null)
				throw new ArgumentNullException(nameof(hFile));
			int? lpNumberOfBytesRead = new int?(0);
			if (!Kernel32.ReadFile(hFile, lpBuffer, nNumberOfBytesToRead, ref lpNumberOfBytesRead,
				(Kernel32.OVERLAPPED*) null))
				throw new Win32Exception();
			return lpNumberOfBytesRead.Value;
		}

		/// <summary>Reads data synchronously from the specified file or input/output (I/O) device.</summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer,
		///     tape drive, socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		/// </param>
		/// <param name="lpBuffer">A buffer that receives the data read from a file or device.</param>
		/// <returns>The number of bytes read.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if the native method return false (Read failed).</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hFile" /> is <see langword="null" />.</exception>
		public static unsafe int ReadFile(Kernel32.SafeObjectHandle hFile, ArraySegment<byte> lpBuffer) {
			byte[] array;
			byte* numPtr = ((array = lpBuffer.Array) == null || array.Length == 0 ? (byte*) null : &array[0]) +
				lpBuffer.Offset;
			return Kernel32.ReadFile(hFile, (void*) numPtr, lpBuffer.Count);
		}

		/// <summary>Reads data synchronously from the specified file or input/output (I/O) device.</summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer,
		///     tape drive, socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		/// </param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <returns>
		///     The data that has been read. The segment returned might have a size smaller than
		///     <paramref name="nNumberOfBytesToRead" /> if less bytes than requested have been read.
		/// </returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if the native method return false (Read failed).</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hFile" /> is <see langword="null" />.</exception>
		public static ArraySegment<byte> ReadFile(Kernel32.SafeObjectHandle hFile, int nNumberOfBytesToRead) {
			byte[] array = new byte[nNumberOfBytesToRead];
			ArraySegment<byte> lpBuffer = new ArraySegment<byte>(array);
			int count = Kernel32.ReadFile(hFile, lpBuffer);
			return new ArraySegment<byte>(array, 0, count);
		}

		/// <summary>
		/// Tries to get the error message text using the supplied buffer.
		/// </summary>
		/// <param name="flags">
		/// The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
		/// </param>
		/// <param name="source">
		/// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="flags" /> parameter.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE" />: A handle to the module that contains the message table to search.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />: Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.
		/// If neither of these flags is set in dwFlags, then lpSource is ignored.
		/// </param>
		/// <param name="messageId">
		/// The message identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// </param>
		/// <param name="languageId">
		/// The language identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only.If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND.If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:
		/// Language neutral
		/// Thread LANGID, based on the thread's locale value
		/// User default LANGID, based on the user's default locale value
		/// System default LANGID, based on the system default locale value
		/// US English
		/// If FormatMessage does not locate a message for any of the preceding LANGIDs, it returns any language message string that is present.If that fails, it returns ERROR_RESOURCE_LANG_NOT_FOUND.
		/// </param>
		/// <param name="sb">The buffer to use for acquiring the message.</param>
		/// <param name="arguments">
		/// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.
		/// The interpretation of each value depends on the formatting information associated with the insert in the message definition.The default is to treat each value as a pointer to a null-terminated string.
		/// By default, the Arguments parameter is of type va_list*, which is a language- and implementation-specific data type for describing a variable number of arguments.The state of the va_list argument is undefined upon return from the function.To use the va_list again, destroy the variable argument list pointer using va_end and reinitialize it with va_start.
		/// If you do not have a pointer of type va_list*, then specify the FORMAT_MESSAGE_ARGUMENT_ARRAY flag and pass a pointer to an array of DWORD_PTR values; those values are input to the message formatted as the insert values.Each insert must have a corresponding element in the array.
		/// </param>
		/// <param name="errorMsg">Receives the resulting error message.</param>
		/// <returns><c>true</c> if the attempt is successful; <c>false</c> otherwise.</returns>
		private static unsafe bool TryGetErrorMessage(Kernel32.FormatMessageFlags flags, void* source, int messageId,
		                                              int languageId, StringBuilder sb, IntPtr[] arguments,
		                                              out string errorMsg) {
			errorMsg = string.Empty;
			if (Kernel32.FormatMessage(flags | Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ARGUMENT_ARRAY, source,
				messageId, languageId, sb, sb.Capacity + 1, arguments) <= 0)
				return false;
			int length;
			for (length = sb.Length; length > 0; --length) {
				char ch = sb[length - 1];
				if (ch > ' ' && ch != '.')
					break;
			}

			errorMsg = sb.ToString(0, length);
			return true;
		}

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the calling process.
		/// If the calling process is impersonating another user, the new process uses the token for the calling process, not the impersonation token. To run the new process in the security context of the user represented by the impersonation token, use the <see cref="M:PInvoke.Kernel32.CreateProcessAsUser(System.IntPtr,System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" /> or CreateProcessWithLogonW function.
		/// </summary>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool CreateProcess(string lpApplicationName, string lpCommandLine,
		                                        IntPtr lpProcessAttributes, IntPtr lpThreadAttributes,
		                                        [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                        Kernel32.CreateProcessFlags dwCreationFlags, IntPtr lpEnvironment,
		                                        string lpCurrentDirectory, ref Kernel32.STARTUPINFO lpStartupInfo,
		                                        out Kernel32.PROCESS_INFORMATION lpProcessInformation) {
			Kernel32.SECURITY_ATTRIBUTES* pointer1 = (Kernel32.SECURITY_ATTRIBUTES*) lpProcessAttributes.ToPointer();
			Kernel32.SECURITY_ATTRIBUTES* pointer2 = (Kernel32.SECURITY_ATTRIBUTES*) lpThreadAttributes.ToPointer();
			void* pointer3 = lpEnvironment.ToPointer();
			return Kernel32.CreateProcess(lpApplicationName, lpCommandLine, pointer1, pointer2, bInheritHandles,
				dwCreationFlags, pointer3, lpCurrentDirectory, ref lpStartupInfo, out lpProcessInformation);
		}

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the calling process.
		/// If the calling process is impersonating another user, the new process uses the token for the calling process, not the impersonation token. To run the new process in the security context of the user represented by the impersonation token, use the <see cref="M:PInvoke.Kernel32.CreateProcessAsUser(System.IntPtr,System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" /> or CreateProcessWithLogonW function.
		/// </summary>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool CreateProcess(string lpApplicationName, string lpCommandLine,
		                                        Kernel32.SECURITY_ATTRIBUTES? lpProcessAttributes,
		                                        Kernel32.SECURITY_ATTRIBUTES? lpThreadAttributes,
		                                        [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                        Kernel32.CreateProcessFlags dwCreationFlags, IntPtr lpEnvironment,
		                                        string lpCurrentDirectory, ref Kernel32.STARTUPINFO lpStartupInfo,
		                                        out Kernel32.PROCESS_INFORMATION lpProcessInformation) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes1 = lpProcessAttributes.HasValue
				? lpProcessAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			Kernel32.SECURITY_ATTRIBUTES securityAttributes2 = lpThreadAttributes.HasValue
				? lpThreadAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			void* pointer = lpEnvironment.ToPointer();
			return Kernel32.CreateProcess(lpApplicationName, lpCommandLine,
				lpProcessAttributes.HasValue ? &securityAttributes1 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				lpThreadAttributes.HasValue ? &securityAttributes2 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				bInheritHandles, dwCreationFlags, pointer, lpCurrentDirectory, ref lpStartupInfo,
				out lpProcessInformation);
		}

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the calling process.
		/// If the calling process is impersonating another user, the new process uses the token for the calling process, not the impersonation token. To run the new process in the security context of the user represented by the impersonation token, use the <see cref="M:PInvoke.Kernel32.CreateProcessAsUser(System.IntPtr,System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" /> or CreateProcessWithLogonW function.
		/// </summary>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool CreateProcess(string lpApplicationName, string lpCommandLine,
		                                        Kernel32.SECURITY_ATTRIBUTES? lpProcessAttributes,
		                                        Kernel32.SECURITY_ATTRIBUTES? lpThreadAttributes,
		                                        [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                        Kernel32.CreateProcessFlags dwCreationFlags, void* lpEnvironment,
		                                        string lpCurrentDirectory, ref Kernel32.STARTUPINFO lpStartupInfo,
		                                        out Kernel32.PROCESS_INFORMATION lpProcessInformation) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes1 = lpProcessAttributes.HasValue
				? lpProcessAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			Kernel32.SECURITY_ATTRIBUTES securityAttributes2 = lpThreadAttributes.HasValue
				? lpThreadAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			return Kernel32.CreateProcess(lpApplicationName, lpCommandLine,
				lpProcessAttributes.HasValue ? &securityAttributes1 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				lpThreadAttributes.HasValue ? &securityAttributes2 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, ref lpStartupInfo,
				out lpProcessInformation);
		}

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the user represented by the specified token.
		/// Typically, the process that calls the CreateProcessAsUser function must have the SE_INCREASE_QUOTA_NAME privilege and may require the SE_ASSIGNPRIMARYTOKEN_NAME privilege if the token is not assignable. If this function fails with ERROR_PRIVILEGE_NOT_HELD (1314), use the CreateProcessWithLogonW function instead. CreateProcessWithLogonW requires no special privileges, but the specified user account must be allowed to log on interactively. Generally, it is best to use CreateProcessWithLogonW to create a process with alternate credentials.
		/// </summary>
		/// <param name="hToken">
		/// A handle to the primary token that represents a user. The handle must have the TOKEN_QUERY, TOKEN_DUPLICATE, and TOKEN_ASSIGN_PRIMARY access rights. For more information, see Access Rights for Access-Token Objects. The user represented by the token must have read and execute access to the application specified by the <paramref name="lpApplicationName" /> or the <paramref name="lpCommandLine" /> parameter.
		/// To get a primary token that represents the specified user, call the LogonUser function. Alternatively, you can call the DuplicateTokenEx function to convert an impersonation token into a primary token. This allows a server application that is impersonating a client to create a process that has the security context of the client.
		/// If hToken is a restricted version of the caller's primary token, the SE_ASSIGNPRIMARYTOKEN_NAME privilege is not required. If the necessary privileges are not already enabled, CreateProcessAsUser enables them for the duration of the call. For more information, see Running with Special Privileges.
		/// Terminal Services:  The process is run in the session specified in the token. By default, this is the same session that called LogonUser. To change the session, use the SetTokenInformation function.
		/// </param>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine,
		                                              IntPtr lpProcessAttributes, IntPtr lpThreadAttributes,
		                                              [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                              Kernel32.CreateProcessFlags dwCreationFlags, IntPtr lpEnvironment,
		                                              string lpCurrentDirectory, ref Kernel32.STARTUPINFO lpStartupInfo,
		                                              out Kernel32.PROCESS_INFORMATION lpProcessInformation) {
			Kernel32.SECURITY_ATTRIBUTES* pointer1 = (Kernel32.SECURITY_ATTRIBUTES*) lpProcessAttributes.ToPointer();
			Kernel32.SECURITY_ATTRIBUTES* pointer2 = (Kernel32.SECURITY_ATTRIBUTES*) lpThreadAttributes.ToPointer();
			void* pointer3 = lpEnvironment.ToPointer();
			return Kernel32.CreateProcessAsUser(hToken, lpApplicationName, lpCommandLine, pointer1, pointer2,
				bInheritHandles, dwCreationFlags, pointer3, lpCurrentDirectory, ref lpStartupInfo,
				out lpProcessInformation);
		}

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the user represented by the specified token.
		/// Typically, the process that calls the CreateProcessAsUser function must have the SE_INCREASE_QUOTA_NAME privilege and may require the SE_ASSIGNPRIMARYTOKEN_NAME privilege if the token is not assignable. If this function fails with ERROR_PRIVILEGE_NOT_HELD (1314), use the CreateProcessWithLogonW function instead. CreateProcessWithLogonW requires no special privileges, but the specified user account must be allowed to log on interactively. Generally, it is best to use CreateProcessWithLogonW to create a process with alternate credentials.
		/// </summary>
		/// <param name="hToken">
		/// A handle to the primary token that represents a user. The handle must have the TOKEN_QUERY, TOKEN_DUPLICATE, and TOKEN_ASSIGN_PRIMARY access rights. For more information, see Access Rights for Access-Token Objects. The user represented by the token must have read and execute access to the application specified by the <paramref name="lpApplicationName" /> or the <paramref name="lpCommandLine" /> parameter.
		/// To get a primary token that represents the specified user, call the LogonUser function. Alternatively, you can call the DuplicateTokenEx function to convert an impersonation token into a primary token. This allows a server application that is impersonating a client to create a process that has the security context of the client.
		/// If hToken is a restricted version of the caller's primary token, the SE_ASSIGNPRIMARYTOKEN_NAME privilege is not required. If the necessary privileges are not already enabled, CreateProcessAsUser enables them for the duration of the call. For more information, see Running with Special Privileges.
		/// Terminal Services:  The process is run in the session specified in the token. By default, this is the same session that called LogonUser. To change the session, use the SetTokenInformation function.
		/// </param>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine,
		                                              Kernel32.SECURITY_ATTRIBUTES? lpProcessAttributes,
		                                              Kernel32.SECURITY_ATTRIBUTES? lpThreadAttributes,
		                                              [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                              Kernel32.CreateProcessFlags dwCreationFlags, IntPtr lpEnvironment,
		                                              string lpCurrentDirectory, ref Kernel32.STARTUPINFO lpStartupInfo,
		                                              out Kernel32.PROCESS_INFORMATION lpProcessInformation) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes1 = lpProcessAttributes.HasValue
				? lpProcessAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			Kernel32.SECURITY_ATTRIBUTES securityAttributes2 = lpThreadAttributes.HasValue
				? lpThreadAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			void* pointer = lpEnvironment.ToPointer();
			return Kernel32.CreateProcessAsUser(hToken, lpApplicationName, lpCommandLine,
				lpProcessAttributes.HasValue ? &securityAttributes1 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				lpThreadAttributes.HasValue ? &securityAttributes2 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				bInheritHandles, dwCreationFlags, pointer, lpCurrentDirectory, ref lpStartupInfo,
				out lpProcessInformation);
		}

		/// <summary>
		/// Creates a new process and its primary thread. The new process runs in the security context of the user represented by the specified token.
		/// Typically, the process that calls the CreateProcessAsUser function must have the SE_INCREASE_QUOTA_NAME privilege and may require the SE_ASSIGNPRIMARYTOKEN_NAME privilege if the token is not assignable. If this function fails with ERROR_PRIVILEGE_NOT_HELD (1314), use the CreateProcessWithLogonW function instead. CreateProcessWithLogonW requires no special privileges, but the specified user account must be allowed to log on interactively. Generally, it is best to use CreateProcessWithLogonW to create a process with alternate credentials.
		/// </summary>
		/// <param name="hToken">
		/// A handle to the primary token that represents a user. The handle must have the TOKEN_QUERY, TOKEN_DUPLICATE, and TOKEN_ASSIGN_PRIMARY access rights. For more information, see Access Rights for Access-Token Objects. The user represented by the token must have read and execute access to the application specified by the <paramref name="lpApplicationName" /> or the <paramref name="lpCommandLine" /> parameter.
		/// To get a primary token that represents the specified user, call the LogonUser function. Alternatively, you can call the DuplicateTokenEx function to convert an impersonation token into a primary token. This allows a server application that is impersonating a client to create a process that has the security context of the client.
		/// If hToken is a restricted version of the caller's primary token, the SE_ASSIGNPRIMARYTOKEN_NAME privilege is not required. If the necessary privileges are not already enabled, CreateProcessAsUser enables them for the duration of the call. For more information, see Running with Special Privileges.
		/// Terminal Services:  The process is run in the session specified in the token. By default, this is the same session that called LogonUser. To change the session, use the SetTokenInformation function.
		/// </param>
		/// <param name="lpApplicationName">
		/// The name of the module to be executed. This module can be a Windows-based application. It can be some other type of module (for example, MS-DOS or OS/2) if the appropriate subsystem is available on the local computer.
		/// The string can specify the full path and file name of the module to execute or it can specify a partial name. In the case of a partial name, the function uses the current drive and current directory to complete the specification. The function will not use the search path. This parameter must include the file name extension; no default extension is assumed.
		/// The lpApplicationName parameter can be NULL. In that case, the module name must be the first white space–delimited token in the lpCommandLine string. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin; otherwise, the file name is ambiguous. For example, consider the string "c:\program files\sub dir\program name". This string can be interpreted in a number of ways.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCommandLine">
		/// The command line to be executed. The maximum length of this string is 32K characters. If lpApplicationName is NULL, the module name portion of lpCommandLine is limited to MAX_PATH characters.
		/// The Unicode version of this function, CreateProcessAsUserW, can modify the contents of this string. Therefore, this parameter cannot be a pointer to read-only memory (such as a const variable or a literal string). If this parameter is a constant string, the function may cause an access violation.
		/// The lpCommandLine parameter can be NULL. In that case, the function uses the string pointed to by lpApplicationName as the command line.
		/// If both lpApplicationName and lpCommandLine are non-NULL, *lpApplicationName specifies the module to execute, and *lpCommandLine specifies the command line. The new process can use GetCommandLine to retrieve the entire command line. Console processes written in C can use the argc and argv arguments to parse the command line. Because argv[0] is the module name, C programmers generally repeat the module name as the first token in the command line.
		/// If lpApplicationName is NULL, the first white space–delimited token of the command line specifies the module name. If you are using a long file name that contains a space, use quoted strings to indicate where the file name ends and the arguments begin (see the explanation for the lpApplicationName parameter). If the file name does not contain an extension, .exe is appended. Therefore, if the file name extension is .com, this parameter must include the .com extension. If the file name ends in a period (.) with no extension, or if the file name contains a path, .exe is not appended.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpProcessAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new process object and determines whether child processes can inherit the returned handle to the process. If lpProcessAttributes is NULL or lpSecurityDescriptor is NULL, the process gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller, in which case the process may not be opened again after it is run. The process handle is valid and will continue to have full access rights.
		/// </param>
		/// <param name="lpThreadAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a security descriptor for the new thread object and determines whether child processes can inherit the returned handle to the thread. If lpThreadAttributes is NULL or lpSecurityDescriptor is NULL, the thread gets a default security descriptor and the handle cannot be inherited. The default security descriptor is that of the user referenced in the hToken parameter. This security descriptor may not allow access for the caller.
		/// </param>
		/// <param name="bInheritHandles">
		/// If this parameter is TRUE, each inheritable handle in the calling process is inherited by the new process. If the parameter is FALSE, the handles are not inherited. Note that inherited handles have the same value and access rights as the original handles.
		/// Terminal Services:  You cannot inherit handles across sessions. Additionally, if this parameter is TRUE, you must create the process in the same session as the caller.
		/// </param>
		/// <param name="dwCreationFlags">
		/// The flags that control the priority class and the creation of the process. For a list of values, see Process Creation Flags.
		/// This parameter also controls the new process's priority class, which is used to determine the scheduling priorities of the process's threads. For a list of values, see GetPriorityClass. If none of the priority class flags is specified, the priority class defaults to NORMAL_PRIORITY_CLASS unless the priority class of the creating process is IDLE_PRIORITY_CLASS or BELOW_NORMAL_PRIORITY_CLASS. In this case, the child process receives the default priority class of the calling process.
		/// </param>
		/// <param name="lpEnvironment">
		/// A pointer to an environment block for the new process. If this parameter is NULL, the new process uses the environment of the calling process.
		/// An environment block consists of a null-terminated block of null-terminated strings. Each string is in the following form:
		/// name=value\0
		/// Because the equal sign is used as a separator, it must not be used in the name of an environment variable.
		/// An environment block can contain either Unicode or ANSI characters. If the environment block pointed to by lpEnvironment contains Unicode characters, be sure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT. If this parameter is NULL and the environment block of the parent process contains Unicode characters, you must also ensure that dwCreationFlags includes CREATE_UNICODE_ENVIRONMENT.
		/// The ANSI version of this function, CreateProcessAsUserA fails if the total size of the environment block for the process exceeds 32,767 characters.
		/// Note that an ANSI environment block is terminated by two zero bytes: one for the last string, one more to terminate the block. A Unicode environment block is terminated by four zero bytes: two for the last string, two more to terminate the block.
		/// See MSDN docs for more information.
		/// </param>
		/// <param name="lpCurrentDirectory">
		/// The full path to the current directory for the process. The string can also specify a UNC path.
		/// If this parameter is NULL, the new process will have the same current drive and directory as the calling process. (This feature is provided primarily for shells that need to start an application and specify its initial drive and working directory.)
		/// </param>
		/// <param name="lpStartupInfo">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure.
		/// The user must have full access to both the specified window station and desktop. If you want the process to be interactive, specify winsta0\default. If the lpDesktop member is NULL, the new process inherits the desktop and window station of its parent process. If this member is an empty string, "", the new process connects to a window station using the rules described in Process Connection to a Window Station.
		/// To set extended attributes, use a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure and specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the <paramref name="dwCreationFlags" /> parameter.
		/// Handles in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> or <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> must be closed with CloseHandle when they are no longer needed.
		/// Important  The caller is responsible for ensuring that the standard handle fields in <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> contain valid handle values. These fields are copied unchanged to the child process without validation, even when the dwFlags member specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />. Incorrect values can cause the child process to misbehave or crash. Use the Application Verifier runtime verification tool to detect invalid handles.
		/// </param>
		/// <param name="lpProcessInformation">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> structure that receives identification information about the new process.
		/// Handles in <see cref="T:PInvoke.Kernel32.PROCESS_INFORMATION" /> must be closed with CloseHandle when they are no longer needed.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine,
		                                              Kernel32.SECURITY_ATTRIBUTES? lpProcessAttributes,
		                                              Kernel32.SECURITY_ATTRIBUTES? lpThreadAttributes,
		                                              [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles,
		                                              Kernel32.CreateProcessFlags dwCreationFlags, void* lpEnvironment,
		                                              string lpCurrentDirectory, ref Kernel32.STARTUPINFO lpStartupInfo,
		                                              out Kernel32.PROCESS_INFORMATION lpProcessInformation) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes1 = lpProcessAttributes.HasValue
				? lpProcessAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			Kernel32.SECURITY_ATTRIBUTES securityAttributes2 = lpThreadAttributes.HasValue
				? lpThreadAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			return Kernel32.CreateProcessAsUser(hToken, lpApplicationName, lpCommandLine,
				lpProcessAttributes.HasValue ? &securityAttributes1 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				lpThreadAttributes.HasValue ? &securityAttributes2 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, ref lpStartupInfo,
				out lpProcessInformation);
		}

		/// <summary>
		/// Initializes the specified list of attributes for process and thread creation.
		/// </summary>
		/// <param name="lpAttributeList">
		/// The attribute list. This parameter can be NULL to determine the buffer size required to support the specified number of attributes.
		/// </param>
		/// <param name="dwAttributeCount">
		/// The count of attributes to be added to the list.
		/// </param>
		/// <param name="dwFlags">
		/// This parameter is reserved and must be zero.
		/// </param>
		/// <param name="lpSize">
		/// If lpAttributeList is not NULL, this parameter specifies the size in bytes of the lpAttributeList buffer on input. On output, this parameter receives the size in bytes of the initialized attribute list.
		/// If lpAttributeList is NULL, this parameter receives the required buffer size in bytes.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// First, call this function with the <paramref name="dwAttributeCount" /> parameter set to the maximum number of attributes you will be using and the lpAttributeList to NULL. The function returns the required buffer size in bytes in the lpSize parameter. Allocate enough space for the data in the lpAttributeList buffer and call the function again to initialize the buffer.
		/// To add attributes to the list, call the <see cref="M:PInvoke.Kernel32.UpdateProcThreadAttribute(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.UInt32,System.UInt32@,System.Void*,System.IntPtr,System.IntPtr@,System.IntPtr@)" /> function. To specify these attributes when creating a process, specify <see cref="F:PInvoke.Kernel32.CreateProcessFlags.EXTENDED_STARTUPINFO_PRESENT" /> in the dwCreationFlag parameter and a <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure in the lpStartupInfo parameter. Note that you can specify the same <see cref="T:PInvoke.Kernel32.STARTUPINFOEX" /> structure to multiple child processes.
		/// When you have finished using the list, call the <see cref="M:PInvoke.Kernel32.DeleteProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*)" /> function.
		/// </remarks>
		public static unsafe bool InitializeProcThreadAttributeList(IntPtr lpAttributeList, int dwAttributeCount,
		                                                            uint dwFlags, ref IntPtr lpSize) {
			return Kernel32.InitializeProcThreadAttributeList(
				(Kernel32.PROC_THREAD_ATTRIBUTE_LIST*) lpAttributeList.ToPointer(), dwAttributeCount, dwFlags,
				ref lpSize);
		}

		/// <summary>
		/// Updates the specified attribute in a list of attributes for process and thread creation.
		/// </summary>
		/// <param name="lpAttributeList">
		/// A pointer to an attribute list created by the <see cref="M:PInvoke.Kernel32.InitializeProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.Int32,System.UInt32,System.IntPtr@)" /> function.
		/// </param>
		/// <param name="dwFlags">
		/// This parameter is reserved and must be zero.
		/// </param>
		/// <param name="Attribute">
		/// The attribute key to update in the attribute list.
		/// </param>
		/// <param name="lpValue">
		/// A pointer to the attribute value. This value should persist until the attribute is destroyed using the <see cref="M:PInvoke.Kernel32.DeleteProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*)" /> function.
		/// </param>
		/// <param name="cbSize">
		/// The size of the attribute value specified by the <paramref name="lpValue" /> parameter.
		/// </param>
		/// <param name="lpPreviousValue">
		/// This parameter is reserved and must be NULL.
		/// </param>
		/// <param name="lpReturnSize">This parameter is reserved and must be NULL.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool UpdateProcThreadAttribute(IntPtr lpAttributeList, uint dwFlags, ref uint Attribute,
		                                                    IntPtr lpValue, IntPtr cbSize, ref IntPtr lpPreviousValue,
		                                                    ref IntPtr lpReturnSize) {
			Kernel32.PROC_THREAD_ATTRIBUTE_LIST* pointer1 =
				(Kernel32.PROC_THREAD_ATTRIBUTE_LIST*) lpAttributeList.ToPointer();
			void* pointer2 = lpValue.ToPointer();
			return Kernel32.UpdateProcThreadAttribute(pointer1, dwFlags, ref Attribute, pointer2, cbSize,
				ref lpPreviousValue, ref lpReturnSize);
		}

		/// <summary>
		/// Deletes the specified list of attributes for process and thread creation.
		/// </summary>
		/// <param name="lpAttributeList">
		/// The attribute list. This list is created by the <see cref="M:PInvoke.Kernel32.InitializeProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.Int32,System.UInt32,System.IntPtr@)" /> function.
		/// </param>
		public static unsafe void DeleteProcThreadAttributeList(IntPtr lpAttributeList) {
			Kernel32.DeleteProcThreadAttributeList((Kernel32.PROC_THREAD_ATTRIBUTE_LIST*) lpAttributeList.ToPointer());
		}

		/// <summary>
		/// Creates or opens a file or I/O device. The most commonly used I/O devices are as follows: file, file stream, directory, physical disk, volume, console buffer, tape drive, communications resource, mailslot, and pipe. The function returns a handle that can be used to access the file or device for various types of I/O depending on the file or device and the flags and attributes specified.
		/// To perform this operation as a transacted operation, which results in a handle that can be used for transacted I/O, use the CreateFileTransacted function.
		/// </summary>
		/// <param name="filename">
		/// The name of the file or device to be created or opened. You may use either forward slashes (/) or backslashes (\) in this name.
		/// In the ANSI version of this function, the name is limited to <see cref="F:PInvoke.Kernel32.MAX_PATH" /> characters. To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.
		/// For information on special device names, see Defining an MS-DOS Device Name.
		/// To create a file stream, specify the name of the file, a colon, and then the name of the stream.For more information, see File Streams.
		/// </param>
		/// <param name="access">
		/// The requested access to the file or device, which can be summarized as read, write, both or neither zero).
		/// The most commonly used values are <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" />, <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_WRITE" />, or both(<see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> | <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_WRITE" />). For more information, see Generic Access Rights, File Security and Access Rights, File Access Rights Constants, and ACCESS_MASK.
		/// If this parameter is zero, the application can query certain metadata such as file, directory, or device attributes without accessing that file or device, even if <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> access would have been denied.
		/// You cannot request an access mode that conflicts with the sharing mode that is specified by the dwShareMode parameter in an open request that already has an open handle.
		/// For more information, see the Remarks section of this topic and Creating and Opening Files.
		/// Common specific rights are defined in <seealso cref="T:PInvoke.Kernel32.FileAccess" />.
		/// </param>
		/// <param name="share">
		/// The requested sharing mode of the file or device, which can be read, write, both, delete, all of these, or none (refer to the following table). Access requests to attributes or extended attributes are not affected by this flag.
		/// If this parameter is zero and <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> succeeds, the file or device cannot be shared and cannot be opened again until the handle to the file or device is closed. For more information, see the Remarks section.
		/// You cannot request a sharing mode that conflicts with the access mode that is specified in an existing request that has an open handle. <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> would fail and the <see cref="M:PInvoke.Kernel32.GetLastError" /> function would return ERROR_SHARING_VIOLATION.
		/// To enable a process to share a file or device while another process has the file or device open, use a compatible combination of one or more of the following values. For more information about valid combinations of this parameter with the dwDesiredAccess parameter, see Creating and Opening Files.
		/// </param>
		/// <param name="securityAttributes">
		/// A pointer to a SECURITY_ATTRIBUTES structure that contains two separate but related data members: an optional security descriptor, and a Boolean value that determines whether the returned handle can be inherited by child processes.
		/// This parameter can be NULL.
		/// If this parameter is NULL, the handle returned by CreateFile cannot be inherited by any child processes the application may create and the file or device associated with the returned handle gets a default security descriptor.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a <see cref="T:PInvoke.Kernel32.SECURITY_DESCRIPTOR" /> for a file or device. If this member is NULL, the file or device associated with the returned handle is assigned a default security descriptor.
		/// CreateFile ignores the <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member when opening an existing file or device, but continues to use the <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.bInheritHandle" /> member.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.bInheritHandle" /> member of the structure specifies whether the returned handle can be inherited.
		/// </param>
		/// <param name="creationDisposition">
		/// An action to take on a file or device that exists or does not exist.
		/// For devices other than files, this parameter is usually set to <see cref="F:PInvoke.Kernel32.CreationDisposition.OPEN_EXISTING" />.
		/// </param>
		/// <param name="flagsAndAttributes">
		/// The file or device attributes and flags, <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_ATTRIBUTE_NORMAL" /> being the most common default value for files.
		/// This parameter can include any combination of the available file attributes (CreateFileFlags.*Attribute). All other file attributes override <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_ATTRIBUTE_NORMAL" />.
		/// This parameter can also contain combinations of flags (CreateFileFlags.*Flag) for control of file or device caching behavior, access modes, and other special-purpose flags. These combine with any CreateFileFlags.*Attribute values.
		/// This parameter can also contain Security Quality of Service (SQOS) information by specifying the SECURITY_SQOS_PRESENT flag. Additional SQOS-related flags information is presented in the table following the attributes and flags tables.
		/// Note When CreateFile opens an existing file, it generally combines the file flags with the file attributes of the existing file, and ignores any file attributes supplied as part of dwFlagsAndAttributes. Special cases are detailed in Creating and Opening Files.
		/// Some of the following file attributes and flags may only apply to files and not necessarily all other types of devices that CreateFile can open.For additional information, see the Remarks section of this topic and Creating and Opening Files.
		/// For more advanced access to file attributes, see SetFileAttributes. For a complete list of all file attributes with their values and descriptions, see File Attribute Constants.
		/// </param>
		/// <param name="templateFile">
		/// A valid handle to a template file with the <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> access right. The template file supplies file attributes and extended attributes for the file that is being created.
		/// This parameter can be NULL.
		/// When opening an existing file, CreateFile ignores this parameter.
		/// When opening a new encrypted file, the file inherits the discretionary access control list from its parent directory.For additional information, see File Encryption.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is an open handle to the specified file, device, named pipe, or mail slot.
		/// If the function fails, the return value is INVALID_HANDLE_VALUE.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe Kernel32.SafeObjectHandle CreateFile(string filename, Kernel32.ACCESS_MASK access,
		                                                          Kernel32.FileShare share, IntPtr securityAttributes,
		                                                          Kernel32.CreationDisposition creationDisposition,
		                                                          Kernel32.CreateFileFlags flagsAndAttributes,
		                                                          Kernel32.SafeObjectHandle templateFile) {
			Kernel32.SECURITY_ATTRIBUTES* pointer = (Kernel32.SECURITY_ATTRIBUTES*) securityAttributes.ToPointer();
			return Kernel32.CreateFile(filename, access, share, pointer, creationDisposition, flagsAndAttributes,
				templateFile);
		}

		/// <summary>
		/// Creates or opens a file or I/O device. The most commonly used I/O devices are as follows: file, file stream, directory, physical disk, volume, console buffer, tape drive, communications resource, mailslot, and pipe. The function returns a handle that can be used to access the file or device for various types of I/O depending on the file or device and the flags and attributes specified.
		/// To perform this operation as a transacted operation, which results in a handle that can be used for transacted I/O, use the CreateFileTransacted function.
		/// </summary>
		/// <param name="filename">
		/// The name of the file or device to be created or opened. You may use either forward slashes (/) or backslashes (\) in this name.
		/// In the ANSI version of this function, the name is limited to <see cref="F:PInvoke.Kernel32.MAX_PATH" /> characters. To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming Files, Paths, and Namespaces.
		/// For information on special device names, see Defining an MS-DOS Device Name.
		/// To create a file stream, specify the name of the file, a colon, and then the name of the stream.For more information, see File Streams.
		/// </param>
		/// <param name="access">
		/// The requested access to the file or device, which can be summarized as read, write, both or neither zero).
		/// The most commonly used values are <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" />, <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_WRITE" />, or both(<see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> | <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_WRITE" />). For more information, see Generic Access Rights, File Security and Access Rights, File Access Rights Constants, and ACCESS_MASK.
		/// If this parameter is zero, the application can query certain metadata such as file, directory, or device attributes without accessing that file or device, even if <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> access would have been denied.
		/// You cannot request an access mode that conflicts with the sharing mode that is specified by the dwShareMode parameter in an open request that already has an open handle.
		/// For more information, see the Remarks section of this topic and Creating and Opening Files.
		/// Common specific rights are defined in <seealso cref="T:PInvoke.Kernel32.FileAccess" />.
		/// </param>
		/// <param name="share">
		/// The requested sharing mode of the file or device, which can be read, write, both, delete, all of these, or none (refer to the following table). Access requests to attributes or extended attributes are not affected by this flag.
		/// If this parameter is zero and <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> succeeds, the file or device cannot be shared and cannot be opened again until the handle to the file or device is closed. For more information, see the Remarks section.
		/// You cannot request a sharing mode that conflicts with the access mode that is specified in an existing request that has an open handle. <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> would fail and the <see cref="M:PInvoke.Kernel32.GetLastError" /> function would return ERROR_SHARING_VIOLATION.
		/// To enable a process to share a file or device while another process has the file or device open, use a compatible combination of one or more of the following values. For more information about valid combinations of this parameter with the dwDesiredAccess parameter, see Creating and Opening Files.
		/// </param>
		/// <param name="securityAttributes">
		/// A pointer to a SECURITY_ATTRIBUTES structure that contains two separate but related data members: an optional security descriptor, and a Boolean value that determines whether the returned handle can be inherited by child processes.
		/// This parameter can be NULL.
		/// If this parameter is NULL, the handle returned by CreateFile cannot be inherited by any child processes the application may create and the file or device associated with the returned handle gets a default security descriptor.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a <see cref="T:PInvoke.Kernel32.SECURITY_DESCRIPTOR" /> for a file or device. If this member is NULL, the file or device associated with the returned handle is assigned a default security descriptor.
		/// CreateFile ignores the <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member when opening an existing file or device, but continues to use the <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.bInheritHandle" /> member.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.bInheritHandle" /> member of the structure specifies whether the returned handle can be inherited.
		/// </param>
		/// <param name="creationDisposition">
		/// An action to take on a file or device that exists or does not exist.
		/// For devices other than files, this parameter is usually set to <see cref="F:PInvoke.Kernel32.CreationDisposition.OPEN_EXISTING" />.
		/// </param>
		/// <param name="flagsAndAttributes">
		/// The file or device attributes and flags, <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_ATTRIBUTE_NORMAL" /> being the most common default value for files.
		/// This parameter can include any combination of the available file attributes (CreateFileFlags.*Attribute). All other file attributes override <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_ATTRIBUTE_NORMAL" />.
		/// This parameter can also contain combinations of flags (CreateFileFlags.*Flag) for control of file or device caching behavior, access modes, and other special-purpose flags. These combine with any CreateFileFlags.*Attribute values.
		/// This parameter can also contain Security Quality of Service (SQOS) information by specifying the SECURITY_SQOS_PRESENT flag. Additional SQOS-related flags information is presented in the table following the attributes and flags tables.
		/// Note When CreateFile opens an existing file, it generally combines the file flags with the file attributes of the existing file, and ignores any file attributes supplied as part of dwFlagsAndAttributes. Special cases are detailed in Creating and Opening Files.
		/// Some of the following file attributes and flags may only apply to files and not necessarily all other types of devices that CreateFile can open.For additional information, see the Remarks section of this topic and Creating and Opening Files.
		/// For more advanced access to file attributes, see SetFileAttributes. For a complete list of all file attributes with their values and descriptions, see File Attribute Constants.
		/// </param>
		/// <param name="templateFile">
		/// A valid handle to a template file with the <see cref="F:PInvoke.Kernel32.ACCESS_MASK.GenericRight.GENERIC_READ" /> access right. The template file supplies file attributes and extended attributes for the file that is being created.
		/// This parameter can be NULL.
		/// When opening an existing file, CreateFile ignores this parameter.
		/// When opening a new encrypted file, the file inherits the discretionary access control list from its parent directory.For additional information, see File Encryption.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is an open handle to the specified file, device, named pipe, or mail slot.
		/// If the function fails, the return value is INVALID_HANDLE_VALUE.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe Kernel32.SafeObjectHandle CreateFile(string filename, Kernel32.ACCESS_MASK access,
		                                                          Kernel32.FileShare share,
		                                                          Kernel32.SECURITY_ATTRIBUTES? securityAttributes,
		                                                          Kernel32.CreationDisposition creationDisposition,
		                                                          Kernel32.CreateFileFlags flagsAndAttributes,
		                                                          Kernel32.SafeObjectHandle templateFile) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes1 = securityAttributes.HasValue
				? securityAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			return Kernel32.CreateFile(filename, access, share,
				securityAttributes.HasValue ? &securityAttributes1 : (Kernel32.SECURITY_ATTRIBUTES*) null,
				creationDisposition, flagsAndAttributes, templateFile);
		}

		/// <summary>Retrieves information about the first process encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		/// A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <param name="lppe">
		/// Contains process information such as the name of the executable file, the process identifier, and
		/// the process identifier of the parent process.
		/// </param>
		/// <returns>
		/// Returns <see langword="true" /> if the first entry of the process list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no processes exist or the snapshot does not contain process
		/// information.
		/// </returns>
		public static unsafe bool Process32First(Kernel32.SafeObjectHandle hSnapshot, IntPtr lppe) {
			Kernel32.PROCESSENTRY32* pointer = (Kernel32.PROCESSENTRY32*) lppe.ToPointer();
			return Kernel32.Process32First(hSnapshot, pointer);
		}

		/// <summary>Retrieves information about the first process encountered in a system snapshot.</summary>
		/// <param name="hSnapshot">
		/// A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <param name="lppe">
		/// Contains process information such as the name of the executable file, the process identifier, and
		/// the process identifier of the parent process.
		/// </param>
		/// <returns>
		/// Returns <see langword="true" /> if the first entry of the process list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no processes exist or the snapshot does not contain process
		/// information.
		/// </returns>
		public static unsafe bool
			Process32First(Kernel32.SafeObjectHandle hSnapshot, ref Kernel32.PROCESSENTRY32 lppe) {
			fixed (Kernel32.PROCESSENTRY32* lppe1 = &lppe)
				return Kernel32.Process32First(hSnapshot, lppe1);
		}

		/// <summary>Retrieves information about the next process recorded in a system snapshot.</summary>
		/// <param name="hSnapshot">
		/// A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <param name="lppe">A <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> structure.</param>
		/// <returns>
		/// Returns <see langword="true" /> if the next entry of the process list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no processes exist or the snapshot does not contain process
		/// information.
		/// </returns>
		/// <remarks>
		/// To retrieve information about the first process recorded in a snapshot, use the
		/// <see cref="M:PInvoke.Kernel32.Process32First(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.PROCESSENTRY32*)" />
		/// function.
		/// </remarks>
		public static unsafe bool Process32Next(Kernel32.SafeObjectHandle hSnapshot, IntPtr lppe) {
			Kernel32.PROCESSENTRY32* pointer = (Kernel32.PROCESSENTRY32*) lppe.ToPointer();
			return Kernel32.Process32Next(hSnapshot, pointer);
		}

		/// <summary>Retrieves information about the next process recorded in a system snapshot.</summary>
		/// <param name="hSnapshot">
		/// A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.
		/// </param>
		/// <param name="lppe">A <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> structure.</param>
		/// <returns>
		/// Returns <see langword="true" /> if the next entry of the process list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no processes exist or the snapshot does not contain process
		/// information.
		/// </returns>
		/// <remarks>
		/// To retrieve information about the first process recorded in a snapshot, use the
		/// <see cref="M:PInvoke.Kernel32.Process32First(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.PROCESSENTRY32*)" />
		/// function.
		/// </remarks>
		public static unsafe bool Process32Next(Kernel32.SafeObjectHandle hSnapshot, ref Kernel32.PROCESSENTRY32 lppe) {
			fixed (Kernel32.PROCESSENTRY32* lppe1 = &lppe)
				return Kernel32.Process32Next(hSnapshot, lppe1);
		}

		/// <summary>
		/// Retrieves information about the first module associated with a process.
		/// </summary>
		/// <param name="hSnapshot">A handle to the snapshot returned from a previous call to the <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.</param>
		/// <param name="lpme">A <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> structure.</param>
		/// <returns>
		/// Returns <see langword="true" /> if the first entry of the module list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no modules exist or the snapshot does not contain module
		/// information.
		/// </returns>
		public static unsafe bool Module32First(Kernel32.SafeObjectHandle hSnapshot, IntPtr lpme) {
			Kernel32.MODULEENTRY32* pointer = (Kernel32.MODULEENTRY32*) lpme.ToPointer();
			return Kernel32.Module32First(hSnapshot, pointer);
		}

		/// <summary>
		/// Retrieves information about the first module associated with a process.
		/// </summary>
		/// <param name="hSnapshot">A handle to the snapshot returned from a previous call to the <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.</param>
		/// <param name="lpme">A <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> structure.</param>
		/// <returns>
		/// Returns <see langword="true" /> if the first entry of the module list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no modules exist or the snapshot does not contain module
		/// information.
		/// </returns>
		public static unsafe bool Module32First(Kernel32.SafeObjectHandle hSnapshot, ref Kernel32.MODULEENTRY32 lpme) {
			fixed (Kernel32.MODULEENTRY32* lpme1 = &lpme)
				return Kernel32.Module32First(hSnapshot, lpme1);
		}

		/// <summary>Retrieves information about the next process recorded in a system snapshot.</summary>
		/// <param name="hSnapshot">A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.</param>
		/// <param name="lpme">A <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> structure.</param>
		/// <returns>Returns <see langword="true" /> if the next entry of the module list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no modules exist or the snapshot does not contain module
		/// information.</returns>
		/// <remarks>
		/// To retrieve information about the first module recorded in a snapshot, use the
		/// <see cref="M:PInvoke.Kernel32.Module32First(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.MODULEENTRY32*)" />
		/// function.
		/// </remarks>
		public static unsafe bool Module32Next(Kernel32.SafeObjectHandle hSnapshot, IntPtr lpme) {
			Kernel32.MODULEENTRY32* pointer = (Kernel32.MODULEENTRY32*) lpme.ToPointer();
			return Kernel32.Module32Next(hSnapshot, pointer);
		}

		/// <summary>Retrieves information about the next process recorded in a system snapshot.</summary>
		/// <param name="hSnapshot">A handle to the snapshot returned from a previous call to the
		/// <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" /> function.</param>
		/// <param name="lpme">A <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> structure.</param>
		/// <returns>Returns <see langword="true" /> if the next entry of the module list has been copied to the buffer or
		/// <see langword="false" /> otherwise. The <see cref="F:PInvoke.Win32ErrorCode.ERROR_NO_MORE_FILES" /> error value is returned by
		/// the <see cref="M:System.Runtime.InteropServices.Marshal.GetLastWin32Error" /> function if no modules exist or the snapshot does not contain module
		/// information.</returns>
		/// <remarks>
		/// To retrieve information about the first module recorded in a snapshot, use the
		/// <see cref="M:PInvoke.Kernel32.Module32First(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.MODULEENTRY32*)" />
		/// function.
		/// </remarks>
		public static unsafe bool Module32Next(Kernel32.SafeObjectHandle hSnapshot, ref Kernel32.MODULEENTRY32 lpme) {
			fixed (Kernel32.MODULEENTRY32* lpme1 = &lpme)
				return Kernel32.Module32Next(hSnapshot, lpme1);
		}

		/// <summary>Retrieves the full name of the executable image for the specified process.</summary>
		/// <param name="hProcess">
		/// A handle to the process. This handle must be created with the
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_INFORMATION" /> or
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_LIMITED_INFORMATION" /> access right.
		/// </param>
		/// <param name="dwFlags">One of the <see cref="T:PInvoke.Kernel32.QueryFullProcessImageNameFlags" /> values.</param>
		/// <param name="lpExeName">The path to the executable image. If the function succeeds, this string is null-terminated.</param>
		/// <param name="lpdwSize">
		/// On input, specifies the size of the lpExeName buffer, in characters. On success, receives the
		/// number of characters written to the buffer, not including the null-terminating character.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</para>
		/// </returns>
		/// <remarks>Minimum OS: Windows Vista / Windows Server 2008.</remarks>
		public static unsafe bool QueryFullProcessImageName(Kernel32.SafeObjectHandle hProcess,
		                                                    Kernel32.QueryFullProcessImageNameFlags dwFlags,
		                                                    IntPtr lpExeName, ref int lpdwSize) {
			char* pointer = (char*) lpExeName.ToPointer();
			return Kernel32.QueryFullProcessImageName(hProcess, dwFlags, pointer, ref lpdwSize);
		}

		/// <summary>Retrieves the full name of the executable image for the specified process.</summary>
		/// <param name="hProcess">
		/// A handle to the process. This handle must be created with the
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_INFORMATION" /> or
		/// <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_LIMITED_INFORMATION" /> access right.
		/// </param>
		/// <param name="dwFlags">One of the <see cref="T:PInvoke.Kernel32.QueryFullProcessImageNameFlags" /> values.</param>
		/// <param name="lpExeName">The path to the executable image. If the function succeeds, this string is null-terminated.</param>
		/// <param name="lpdwSize">
		/// On input, specifies the size of the lpExeName buffer, in characters. On success, receives the
		/// number of characters written to the buffer, not including the null-terminating character.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</para>
		/// </returns>
		/// <remarks>Minimum OS: Windows Vista / Windows Server 2008.</remarks>
		public static unsafe bool QueryFullProcessImageName(Kernel32.SafeObjectHandle hProcess,
		                                                    Kernel32.QueryFullProcessImageNameFlags dwFlags,
		                                                    char[] lpExeName, ref int lpdwSize) {
			char[] chArray;
			char* lpExeName1 = (chArray = lpExeName) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return Kernel32.QueryFullProcessImageName(hProcess, dwFlags, lpExeName1, ref lpdwSize);
		}

		/// <summary>
		/// Retrieves the results of an overlapped operation on the specified file, named pipe, or communications device.
		/// To specify a timeout interval or wait on an alertable thread, use GetOverlappedResultEx.
		/// </summary>
		/// <param name="hFile">
		/// A handle to the file, named pipe, or communications device. This is the same handle that was
		/// specified when the overlapped operation was started by a call to the ReadFile, WriteFile, ConnectNamedPipe,
		/// TransactNamedPipe, DeviceIoControl, or WaitCommEvent function.
		/// </param>
		/// <param name="lpOverlapped">
		/// A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure that was specified when the overlapped
		/// operation was started.
		/// </param>
		/// <param name="lpNumberOfBytesTransferred">
		/// A pointer to a variable that receives the number of bytes that were actually
		/// transferred by a read or write operation. For a TransactNamedPipe operation, this is the number of bytes that were read
		/// from the pipe. For a DeviceIoControl operation, this is the number of bytes of output data returned by the device
		/// driver. For a ConnectNamedPipe or WaitCommEvent operation, this value is undefined.
		/// </param>
		/// <param name="bWait">
		/// If this parameter is TRUE, and the Internal member of the lpOverlapped structure is STATUS_PENDING,
		/// the function does not return until the operation has been completed. If this parameter is FALSE and the operation is
		/// still pending, the function returns FALSE and the <see cref="M:PInvoke.Kernel32.GetLastError" /> function returns
		/// <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_INCOMPLETE" />.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// <para>
		/// If the function fails, the return value is zero.To get extended error information, call
		/// <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </para>
		/// </returns>
		/// <remarks>
		/// The results reported by the GetOverlappedResult function are those of the specified handle's last overlapped operation
		/// to which the specified <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure was provided, and for which the operation's results were
		/// pending. A pending operation is indicated when the function that started the operation returns FALSE, and the
		/// GetLastError function returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" />. When an I/O operation is pending, the
		/// function that started the operation resets the hEvent member of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure to the
		/// nonsignaled state. Then when the pending operation has been completed, the system sets the event object to the signaled
		/// state.
		/// <para>
		/// If the bWait parameter is TRUE, GetOverlappedResult determines whether the pending operation has been completed
		/// by waiting for the event object to be in the signaled state.
		/// </para>
		/// <para>
		/// If the hEvent member of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is NULL, the system uses the state of the hFile
		/// handle to signal when the operation has been completed. Use of file, named pipe, or communications-device handles for
		/// this purpose is discouraged. It is safer to use an event object because of the confusion that can occur when multiple
		/// simultaneous overlapped operations are performed on the same file, named pipe, or communications device. In this
		/// situation, there is no way to know which operation caused the object's state to be signaled.
		/// </para>
		/// </remarks>
		public static unsafe bool GetOverlappedResult(Kernel32.SafeObjectHandle hFile, IntPtr lpOverlapped,
		                                              out int lpNumberOfBytesTransferred, bool bWait) {
			Kernel32.OVERLAPPED* pointer = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			return Kernel32.GetOverlappedResult(hFile, pointer, out lpNumberOfBytesTransferred, bWait);
		}

		/// <summary>Creates an anonymous pipe, and returns handles to the read and write ends of the pipe.</summary>
		/// <param name="hReadPipe">A pointer to a variable that receives the read handle for the pipe.</param>
		/// <param name="hWritePipe">A pointer to a variable that receives the write handle for the pipe.</param>
		/// <param name="lpPipeAttributes">
		///     A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that determines whether the returned handle can be
		///     inherited by child processes. If <paramref name="lpPipeAttributes" />  is NULL, the handle cannot be inherited.
		///     <para>
		///         The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a security
		///         descriptor for the new pipe. If <paramref name="lpPipeAttributes" />  is NULL, the pipe gets a default security descriptor. The ACLs
		///         in the default security descriptor for a pipe come from the primary or impersonation token of the creator.
		///     </para>
		/// </param>
		/// <param name="nSize">
		///     The size of the buffer for the pipe, in bytes. The size is only a suggestion; the system uses the
		///     value to calculate an appropriate buffering mechanism. If this parameter is zero, the system uses the default
		///     buffer size.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a nonzero value.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool CreatePipe(out Kernel32.SafeObjectHandle hReadPipe,
		                                     out Kernel32.SafeObjectHandle hWritePipe, IntPtr lpPipeAttributes,
		                                     int nSize) {
			Kernel32.SECURITY_ATTRIBUTES* pointer = (Kernel32.SECURITY_ATTRIBUTES*) lpPipeAttributes.ToPointer();
			return Kernel32.CreatePipe(out hReadPipe, out hWritePipe, pointer, nSize);
		}

		/// <summary>Creates an anonymous pipe, and returns handles to the read and write ends of the pipe.</summary>
		/// <param name="hReadPipe">A pointer to a variable that receives the read handle for the pipe.</param>
		/// <param name="hWritePipe">A pointer to a variable that receives the write handle for the pipe.</param>
		/// <param name="lpPipeAttributes">
		///     A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that determines whether the returned handle can be
		///     inherited by child processes. If <paramref name="lpPipeAttributes" />  is NULL, the handle cannot be inherited.
		///     <para>
		///         The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a security
		///         descriptor for the new pipe. If <paramref name="lpPipeAttributes" />  is NULL, the pipe gets a default security descriptor. The ACLs
		///         in the default security descriptor for a pipe come from the primary or impersonation token of the creator.
		///     </para>
		/// </param>
		/// <param name="nSize">
		///     The size of the buffer for the pipe, in bytes. The size is only a suggestion; the system uses the
		///     value to calculate an appropriate buffering mechanism. If this parameter is zero, the system uses the default
		///     buffer size.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a nonzero value.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool CreatePipe(out Kernel32.SafeObjectHandle hReadPipe,
		                                     out Kernel32.SafeObjectHandle hWritePipe,
		                                     Kernel32.SECURITY_ATTRIBUTES? lpPipeAttributes, int nSize) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes =
				lpPipeAttributes.HasValue ? lpPipeAttributes.Value : new Kernel32.SECURITY_ATTRIBUTES();
			return Kernel32.CreatePipe(out hReadPipe, out hWritePipe,
				lpPipeAttributes.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null, nSize);
		}

		public static unsafe bool GetDllDirectory(int nBufferLength, IntPtr lpBuffer) {
			char* pointer = (char*) lpBuffer.ToPointer();
			return Kernel32.GetDllDirectory(nBufferLength, pointer);
		}

		public static unsafe bool GetDllDirectory(int nBufferLength, char[] lpBuffer) {
			char[] chArray;
			char* lpBuffer1 = (chArray = lpBuffer) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return Kernel32.GetDllDirectory(nBufferLength, lpBuffer1);
		}

		/// <summary>
		///     Creates an instance of a named pipe and returns a handle for subsequent pipe operations. A named pipe server
		///     process uses this function either to create the first instance of a specific named pipe and establish its basic
		///     attributes or to create a new instance of an existing named pipe.
		/// </summary>
		/// <param name="lpName">
		///     The unique pipe name. This string must have the following form:
		///     <para>
		///         <code>\\.\pipe\pipename</code>
		///     </para>
		///     <para>
		///         The pipename part of the name can include any character other than a backslash, including numbers and special
		///         characters. The entire pipe name string can be up to 256 characters long. Pipe names are not case sensitive.
		///     </para>
		/// </param>
		/// <param name="dwOpenMode">
		///     The open mode. The function fails if dwOpenMode specifies anything other than 0 or the flags
		///     from <see cref="T:PInvoke.Kernel32.PipeAccessMode" />.
		///     <para>The same mode must be specified for each instance of the pipe.</para>
		/// </param>
		/// <param name="dwPipeMode">
		///     The pipe mode. The function fails if dwPipeMode specifies anything other than 0 or the flags from
		///     <see cref="T:PInvoke.Kernel32.PipeMode" />.
		///     <para>
		///         One of the following type modes can be specified. The same type mode must be specified for each instance of
		///         the pipe.
		///     </para>
		/// </param>
		/// <param name="nMaxInstances">
		///     The maximum number of instances that can be created for this pipe. The first instance of
		///     the pipe can specify this value; the same number must be specified for other instances of the pipe. Acceptable
		///     values are in the range 1 through <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" /> (255). If this parameter is
		///     <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" />, the number of pipe instances that can be created is limited only by the
		///     availability of system resources. If nMaxInstances is greater than <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" />, the
		///     return value is an invalid handle and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///     <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_PARAMETER" />.
		/// </param>
		/// <param name="nOutBufferSize">The number of bytes to reserve for the output buffer.</param>
		/// <param name="nInBufferSize">The number of bytes to reserve for the input buffer.</param>
		/// <param name="nDefaultTimeOut">
		///     The default time-out value, in milliseconds, if the <see cref="M:PInvoke.Kernel32.WaitNamedPipe(System.String,System.Int32)" /> function specifies
		///     NMPWAIT_USE_DEFAULT_WAIT. Each instance of a named pipe must specify the same value.
		/// </param>
		/// <param name="lpSecurityAttributes">
		///     A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a
		///     security descriptor for the new named pipe and determines whether child processes can inherit the returned handle.
		///     If lpSecurityAttributes is NULL, the named pipe gets a default security descriptor and the handle cannot be
		///     inherited. The ACLs in the default security descriptor for a named pipe grant full control to the LocalSystem
		///     account, administrators, and the creator owner. They also grant read access to members of the Everyone group and
		///     the anonymous account.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the server end of a named pipe instance. If the
		///     function fails, the return value is an invalid handle. To get extended error information, call
		///     <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe Kernel32.SafeObjectHandle CreateNamedPipe(string lpName,
		                                                               Kernel32.PipeAccessMode dwOpenMode,
		                                                               Kernel32.PipeMode dwPipeMode, int nMaxInstances,
		                                                               int nOutBufferSize, int nInBufferSize,
		                                                               int nDefaultTimeOut,
		                                                               IntPtr lpSecurityAttributes) {
			Kernel32.SECURITY_ATTRIBUTES* pointer = (Kernel32.SECURITY_ATTRIBUTES*) lpSecurityAttributes.ToPointer();
			return Kernel32.CreateNamedPipe(lpName, dwOpenMode, dwPipeMode, nMaxInstances, nOutBufferSize,
				nInBufferSize, nDefaultTimeOut, pointer);
		}

		/// <summary>
		///     Creates an instance of a named pipe and returns a handle for subsequent pipe operations. A named pipe server
		///     process uses this function either to create the first instance of a specific named pipe and establish its basic
		///     attributes or to create a new instance of an existing named pipe.
		/// </summary>
		/// <param name="lpName">
		///     The unique pipe name. This string must have the following form:
		///     <para>
		///         <code>\\.\pipe\pipename</code>
		///     </para>
		///     <para>
		///         The pipename part of the name can include any character other than a backslash, including numbers and special
		///         characters. The entire pipe name string can be up to 256 characters long. Pipe names are not case sensitive.
		///     </para>
		/// </param>
		/// <param name="dwOpenMode">
		///     The open mode. The function fails if dwOpenMode specifies anything other than 0 or the flags
		///     from <see cref="T:PInvoke.Kernel32.PipeAccessMode" />.
		///     <para>The same mode must be specified for each instance of the pipe.</para>
		/// </param>
		/// <param name="dwPipeMode">
		///     The pipe mode. The function fails if dwPipeMode specifies anything other than 0 or the flags from
		///     <see cref="T:PInvoke.Kernel32.PipeMode" />.
		///     <para>
		///         One of the following type modes can be specified. The same type mode must be specified for each instance of
		///         the pipe.
		///     </para>
		/// </param>
		/// <param name="nMaxInstances">
		///     The maximum number of instances that can be created for this pipe. The first instance of
		///     the pipe can specify this value; the same number must be specified for other instances of the pipe. Acceptable
		///     values are in the range 1 through <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" /> (255). If this parameter is
		///     <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" />, the number of pipe instances that can be created is limited only by the
		///     availability of system resources. If nMaxInstances is greater than <see cref="F:PInvoke.Kernel32.PIPE_UNLIMITED_INSTANCES" />, the
		///     return value is an invalid handle and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///     <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_PARAMETER" />.
		/// </param>
		/// <param name="nOutBufferSize">The number of bytes to reserve for the output buffer.</param>
		/// <param name="nInBufferSize">The number of bytes to reserve for the input buffer.</param>
		/// <param name="nDefaultTimeOut">
		///     The default time-out value, in milliseconds, if the <see cref="M:PInvoke.Kernel32.WaitNamedPipe(System.String,System.Int32)" /> function specifies
		///     NMPWAIT_USE_DEFAULT_WAIT. Each instance of a named pipe must specify the same value.
		/// </param>
		/// <param name="lpSecurityAttributes">
		///     A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies a
		///     security descriptor for the new named pipe and determines whether child processes can inherit the returned handle.
		///     If lpSecurityAttributes is NULL, the named pipe gets a default security descriptor and the handle cannot be
		///     inherited. The ACLs in the default security descriptor for a named pipe grant full control to the LocalSystem
		///     account, administrators, and the creator owner. They also grant read access to members of the Everyone group and
		///     the anonymous account.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the server end of a named pipe instance. If the
		///     function fails, the return value is an invalid handle. To get extended error information, call
		///     <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe Kernel32.SafeObjectHandle CreateNamedPipe(string lpName,
		                                                               Kernel32.PipeAccessMode dwOpenMode,
		                                                               Kernel32.PipeMode dwPipeMode, int nMaxInstances,
		                                                               int nOutBufferSize, int nInBufferSize,
		                                                               int nDefaultTimeOut,
		                                                               Kernel32.SECURITY_ATTRIBUTES?
			                                                               lpSecurityAttributes) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes = lpSecurityAttributes.HasValue
				? lpSecurityAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			return Kernel32.CreateNamedPipe(lpName, dwOpenMode, dwPipeMode, nMaxInstances, nOutBufferSize,
				nInBufferSize, nDefaultTimeOut,
				lpSecurityAttributes.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null);
		}

		/// <summary>
		///     Enables a named pipe server process to wait for a client process to connect to an instance of a named pipe. A
		///     client process connects by calling either the CreateFile or CallNamedPipe function.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the server end of a named pipe instance. This handle is returned by the
		///     CreateNamedPipe function.
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an OVERLAPPED structure.
		///     <para>
		///         If hNamedPipe was opened with FILE_FLAG_OVERLAPPED, the lpOverlapped parameter must not be NULL. It must
		///         point to a valid OVERLAPPED structure. If hNamedPipe was opened with FILE_FLAG_OVERLAPPED and lpOverlapped is
		///         NULL, the function can incorrectly report that the connect operation is complete.
		///     </para>
		///     <para>
		///         If hNamedPipe was created with FILE_FLAG_OVERLAPPED and lpOverlapped is not NULL, the OVERLAPPED structure
		///         should contain a handle to a manual-reset event object (which the server can create by using the CreateEvent
		///         function).
		///     </para>
		///     <para>
		///         If hNamedPipe was not opened with FILE_FLAG_OVERLAPPED, the function does not return until a client is
		///         connected or an error occurs. Successful synchronous operations result in the function returning a nonzero
		///         value if a client connects after the function is called.
		///     </para>
		/// </param>
		/// <returns>
		///     If the operation is synchronous, ConnectNamedPipe does not return until the operation has completed. If the
		///     function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended
		///     error information, call GetLastError.
		///     <para>
		///         If the operation is asynchronous, ConnectNamedPipe returns immediately. If the operation is still pending,
		///         the return value is zero and GetLastError returns ERROR_IO_PENDING. (You can use the HasOverlappedIoCompleted
		///         macro to determine when the operation has finished.) If the function fails, the return value is zero and
		///         GetLastError returns a value other than ERROR_IO_PENDING or ERROR_PIPE_CONNECTED.
		///     </para>
		///     <para>
		///         If a client connects before the function is called, the function returns zero and GetLastError returns
		///         ERROR_PIPE_CONNECTED. This can happen if a client connects in the interval between the call to CreateNamedPipe
		///         and the call to ConnectNamedPipe. In this situation, there is a good connection between client and server, even
		///         though the function returns zero.
		///     </para>
		/// </returns>
		public static unsafe bool ConnectNamedPipe(Kernel32.SafeObjectHandle hNamedPipe, IntPtr lpOverlapped) {
			Kernel32.OVERLAPPED* pointer = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			return Kernel32.ConnectNamedPipe(hNamedPipe, pointer);
		}

		/// <summary>
		///     Connects to a message-type pipe (and waits if an instance of the pipe is not available), writes to and reads
		///     from the pipe, and then closes the pipe.
		/// </summary>
		/// <param name="lpNamedPipeName">The pipe name.</param>
		/// <param name="lpInBuffer">The data to be written to the pipe.</param>
		/// <param name="nInBufferSize">The size of the write buffer, in bytes.</param>
		/// <param name="lpOutBuffer">A pointer to the buffer that receives the data read from the pipe.</param>
		/// <param name="nOutBufferSize">The size of the read buffer, in bytes.</param>
		/// <param name="lpBytesRead">A pointer to a variable that receives the number of bytes read from the pipe.</param>
		/// <param name="nTimeOut">
		///     The number of milliseconds to wait for the named pipe to be available. In addition to numeric
		///     values, <see cref="F:PInvoke.Kernel32.NMPWAIT_NOWAIT" />, <see cref="F:PInvoke.Kernel32.NMPWAIT_WAIT_FOREVER" /> and
		///     <see cref="F:PInvoke.Kernel32.NMPWAIT_USE_DEFAULT_WAIT" /> can be specified.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		///     <para>
		///         If the message written to the pipe by the server process is longer than nOutBufferSize, CallNamedPipe returns
		///         FALSE, and GetLastError returns ERROR_MORE_DATA. The remainder of the message is discarded, because
		///         CallNamedPipe closes the handle to the pipe before returning.
		///     </para>
		/// </returns>
		public static unsafe bool CallNamedPipe(string lpNamedPipeName, IntPtr lpInBuffer, int nInBufferSize,
		                                        IntPtr lpOutBuffer, int nOutBufferSize, out int lpBytesRead,
		                                        int nTimeOut) {
			void* pointer1 = lpInBuffer.ToPointer();
			void* pointer2 = lpOutBuffer.ToPointer();
			return Kernel32.CallNamedPipe(lpNamedPipeName, pointer1, nInBufferSize, pointer2, nOutBufferSize,
				out lpBytesRead, nTimeOut);
		}

		/// <summary>Retrieves the client computer name for the specified named pipe.</summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe
		///     function.
		/// </param>
		/// <param name="ClientComputerName">The computer name.</param>
		/// <param name="ClientComputerNameLength">The size of the ClientComputerName buffer, in bytes.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool GetNamedPipeClientComputerName(Kernel32.SafeObjectHandle Pipe,
		                                                         IntPtr ClientComputerName,
		                                                         int ClientComputerNameLength) {
			char* pointer = (char*) ClientComputerName.ToPointer();
			return Kernel32.GetNamedPipeClientComputerName(Pipe, pointer, ClientComputerNameLength);
		}

		/// <summary>Retrieves the client computer name for the specified named pipe.</summary>
		/// <param name="Pipe">
		///     A handle to an instance of a named pipe. This handle must be created by the CreateNamedPipe
		///     function.
		/// </param>
		/// <param name="ClientComputerName">The computer name.</param>
		/// <param name="ClientComputerNameLength">The size of the ClientComputerName buffer, in bytes.</param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool GetNamedPipeClientComputerName(Kernel32.SafeObjectHandle Pipe,
		                                                         char[] ClientComputerName,
		                                                         int ClientComputerNameLength) {
			char[] chArray;
			char* ClientComputerName1 = (chArray = ClientComputerName) == null || chArray.Length == 0
				? (char*) null
				: &chArray[0];
			return Kernel32.GetNamedPipeClientComputerName(Pipe, ClientComputerName1, ClientComputerNameLength);
		}

		/// <summary>
		///     Retrieves information about a specified named pipe. The information returned can vary during the lifetime of
		///     an instance of the named pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe for which information is wanted. The handle must have GENERIC_READ
		///     access for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a
		///     write-only pipe.
		///     <para>This parameter can also be a handle to an anonymous pipe, as returned by the CreatePipe function.</para>
		/// </param>
		/// <param name="lpState">
		///     A pointer to a variable that indicates the current state of the handle. Either or both of
		///     <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_NOWAIT" /> and <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_READMODE_MESSAGE" /> can be specified.
		/// </param>
		/// <param name="lpCurInstances">
		///     A pointer to a variable that receives the number of current pipe instances. This parameter
		///     can be NULL if this information is not required.
		/// </param>
		/// <param name="lpMaxCollectionCount">
		///     A pointer to a variable that receives the maximum number of bytes to be collected on
		///     the client's computer before transmission to the server. This parameter must be NULL if the specified pipe handle
		///     is to the server end of a named pipe or if client and server processes are on the same computer. This parameter can
		///     be NULL if this information is not required.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     A pointer to a variable that receives the maximum time, in milliseconds, that can
		///     pass before a remote named pipe transfers information over the network. This parameter must be NULL if the
		///     specified pipe handle is to the server end of a named pipe or if client and server processes are on the same
		///     computer. This parameter can be NULL if this information is not required.
		/// </param>
		/// <param name="lpUserName">
		///     A pointer to a buffer that receives the user name string associated with the client application. The server can
		///     only retrieve this information if the client opened the pipe with SECURITY_IMPERSONATION access.
		///     <para>
		///         This parameter must be NULL if the specified pipe handle is to the client end of a named pipe. This parameter
		///         can be NULL if this information is not required.
		///     </para>
		/// </param>
		/// <param name="nMaxUserNameSize">
		///     The size of the buffer specified by the lpUserName parameter, in chars. This parameter
		///     is ignored if lpUserName is NULL.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool GetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                  out Kernel32.PipeMode lpState, IntPtr lpCurInstances,
		                                                  IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout,
		                                                  StringBuilder lpUserName, int nMaxUserNameSize) {
			int* pointer1 = (int*) lpCurInstances.ToPointer();
			int* pointer2 = (int*) lpMaxCollectionCount.ToPointer();
			int* pointer3 = (int*) lpCollectDataTimeout.ToPointer();
			return Kernel32.GetNamedPipeHandleState(hNamedPipe, out lpState, pointer1, pointer2, pointer3, lpUserName,
				nMaxUserNameSize);
		}

		/// <summary>
		///     Retrieves information about a specified named pipe. The information returned can vary during the lifetime of
		///     an instance of the named pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe for which information is wanted. The handle must have GENERIC_READ
		///     access for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a
		///     write-only pipe.
		///     <para>This parameter can also be a handle to an anonymous pipe, as returned by the CreatePipe function.</para>
		/// </param>
		/// <param name="lpState">
		///     A pointer to a variable that indicates the current state of the handle. Either or both of
		///     <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_NOWAIT" /> and <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_READMODE_MESSAGE" /> can be specified.
		/// </param>
		/// <param name="lpCurInstances">
		///     A pointer to a variable that receives the number of current pipe instances. This parameter
		///     can be NULL if this information is not required.
		/// </param>
		/// <param name="lpMaxCollectionCount">
		///     A pointer to a variable that receives the maximum number of bytes to be collected on
		///     the client's computer before transmission to the server. This parameter must be NULL if the specified pipe handle
		///     is to the server end of a named pipe or if client and server processes are on the same computer. This parameter can
		///     be NULL if this information is not required.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     A pointer to a variable that receives the maximum time, in milliseconds, that can
		///     pass before a remote named pipe transfers information over the network. This parameter must be NULL if the
		///     specified pipe handle is to the server end of a named pipe or if client and server processes are on the same
		///     computer. This parameter can be NULL if this information is not required.
		/// </param>
		/// <param name="lpUserName">
		///     A pointer to a buffer that receives the user name string associated with the client application. The server can
		///     only retrieve this information if the client opened the pipe with SECURITY_IMPERSONATION access.
		///     <para>
		///         This parameter must be NULL if the specified pipe handle is to the client end of a named pipe. This parameter
		///         can be NULL if this information is not required.
		///     </para>
		/// </param>
		/// <param name="nMaxUserNameSize">
		///     The size of the buffer specified by the lpUserName parameter, in chars. This parameter
		///     is ignored if lpUserName is NULL.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool GetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                  out Kernel32.PipeMode lpState, ref int? lpCurInstances,
		                                                  ref int? lpMaxCollectionCount, ref int? lpCollectDataTimeout,
		                                                  StringBuilder lpUserName, int nMaxUserNameSize) {
			int num1 = lpCurInstances.HasValue ? lpCurInstances.Value : 0;
			int num2 = lpMaxCollectionCount.HasValue ? lpMaxCollectionCount.Value : 0;
			int num3 = lpCollectDataTimeout.HasValue ? lpCollectDataTimeout.Value : 0;
			int num4 = Kernel32.GetNamedPipeHandleState(hNamedPipe, out lpState,
				lpCurInstances.HasValue ? &num1 : (int*) null, lpMaxCollectionCount.HasValue ? &num2 : (int*) null,
				lpCollectDataTimeout.HasValue ? &num3 : (int*) null, lpUserName, nMaxUserNameSize)
				? 1
				: 0;
			if (lpCurInstances.HasValue)
				lpCurInstances = new int?(num1);
			if (lpMaxCollectionCount.HasValue)
				lpMaxCollectionCount = new int?(num2);
			if (!lpCollectDataTimeout.HasValue)
				return num4 != 0;
			lpCollectDataTimeout = new int?(num3);
			return num4 != 0;
		}

		/// <summary>
		///     Retrieves information about a specified named pipe. The information returned can vary during the lifetime of
		///     an instance of the named pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe for which information is wanted. The handle must have GENERIC_READ
		///     access for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a
		///     write-only pipe.
		///     <para>This parameter can also be a handle to an anonymous pipe, as returned by the CreatePipe function.</para>
		/// </param>
		/// <param name="lpState">
		///     A pointer to a variable that indicates the current state of the handle. Either or both of
		///     <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_NOWAIT" /> and <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_READMODE_MESSAGE" /> can be specified.
		/// </param>
		/// <param name="lpCurInstances">
		///     A pointer to a variable that receives the number of current pipe instances. This parameter
		///     can be NULL if this information is not required.
		/// </param>
		/// <param name="lpMaxCollectionCount">
		///     A pointer to a variable that receives the maximum number of bytes to be collected on
		///     the client's computer before transmission to the server. This parameter must be NULL if the specified pipe handle
		///     is to the server end of a named pipe or if client and server processes are on the same computer. This parameter can
		///     be NULL if this information is not required.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     A pointer to a variable that receives the maximum time, in milliseconds, that can
		///     pass before a remote named pipe transfers information over the network. This parameter must be NULL if the
		///     specified pipe handle is to the server end of a named pipe or if client and server processes are on the same
		///     computer. This parameter can be NULL if this information is not required.
		/// </param>
		/// <param name="lpUserName">
		///     A pointer to a buffer that receives the user name string associated with the client application. The server can
		///     only retrieve this information if the client opened the pipe with SECURITY_IMPERSONATION access.
		///     <para>
		///         This parameter must be NULL if the specified pipe handle is to the client end of a named pipe. This parameter
		///         can be NULL if this information is not required.
		///     </para>
		/// </param>
		/// <param name="nMaxUserNameSize">
		///     The size of the buffer specified by the lpUserName parameter, in chars. This parameter
		///     is ignored if lpUserName is NULL.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool GetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                  out Kernel32.PipeMode lpState, IntPtr lpCurInstances,
		                                                  IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout,
		                                                  IntPtr lpUserName, int nMaxUserNameSize) {
			int* pointer1 = (int*) lpCurInstances.ToPointer();
			int* pointer2 = (int*) lpMaxCollectionCount.ToPointer();
			int* pointer3 = (int*) lpCollectDataTimeout.ToPointer();
			char* pointer4 = (char*) lpUserName.ToPointer();
			return Kernel32.GetNamedPipeHandleState(hNamedPipe, out lpState, pointer1, pointer2, pointer3, pointer4,
				nMaxUserNameSize);
		}

		/// <summary>
		///     Retrieves information about a specified named pipe. The information returned can vary during the lifetime of
		///     an instance of the named pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe for which information is wanted. The handle must have GENERIC_READ
		///     access for a read-only or read/write pipe, or it must have GENERIC_WRITE and FILE_READ_ATTRIBUTES access for a
		///     write-only pipe.
		///     <para>This parameter can also be a handle to an anonymous pipe, as returned by the CreatePipe function.</para>
		/// </param>
		/// <param name="lpState">
		///     A pointer to a variable that indicates the current state of the handle. Either or both of
		///     <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_NOWAIT" /> and <see cref="F:PInvoke.Kernel32.PipeMode.PIPE_READMODE_MESSAGE" /> can be specified.
		/// </param>
		/// <param name="lpCurInstances">
		///     A pointer to a variable that receives the number of current pipe instances. This parameter
		///     can be NULL if this information is not required.
		/// </param>
		/// <param name="lpMaxCollectionCount">
		///     A pointer to a variable that receives the maximum number of bytes to be collected on
		///     the client's computer before transmission to the server. This parameter must be NULL if the specified pipe handle
		///     is to the server end of a named pipe or if client and server processes are on the same computer. This parameter can
		///     be NULL if this information is not required.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     A pointer to a variable that receives the maximum time, in milliseconds, that can
		///     pass before a remote named pipe transfers information over the network. This parameter must be NULL if the
		///     specified pipe handle is to the server end of a named pipe or if client and server processes are on the same
		///     computer. This parameter can be NULL if this information is not required.
		/// </param>
		/// <param name="lpUserName">
		///     A pointer to a buffer that receives the user name string associated with the client application. The server can
		///     only retrieve this information if the client opened the pipe with SECURITY_IMPERSONATION access.
		///     <para>
		///         This parameter must be NULL if the specified pipe handle is to the client end of a named pipe. This parameter
		///         can be NULL if this information is not required.
		///     </para>
		/// </param>
		/// <param name="nMaxUserNameSize">
		///     The size of the buffer specified by the lpUserName parameter, in chars. This parameter
		///     is ignored if lpUserName is NULL.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool GetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                  out Kernel32.PipeMode lpState, ref int? lpCurInstances,
		                                                  ref int? lpMaxCollectionCount, ref int? lpCollectDataTimeout,
		                                                  char[] lpUserName, int nMaxUserNameSize) {
			char[] chArray;
			char* lpUserName1 = (chArray = lpUserName) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			int num1 = lpCurInstances.HasValue ? lpCurInstances.Value : 0;
			int num2 = lpMaxCollectionCount.HasValue ? lpMaxCollectionCount.Value : 0;
			int num3 = lpCollectDataTimeout.HasValue ? lpCollectDataTimeout.Value : 0;
			int num4 = Kernel32.GetNamedPipeHandleState(hNamedPipe, out lpState,
				lpCurInstances.HasValue ? &num1 : (int*) null, lpMaxCollectionCount.HasValue ? &num2 : (int*) null,
				lpCollectDataTimeout.HasValue ? &num3 : (int*) null, lpUserName1, nMaxUserNameSize)
				? 1
				: 0;
			if (lpCurInstances.HasValue)
				lpCurInstances = new int?(num1);
			if (lpMaxCollectionCount.HasValue)
				lpMaxCollectionCount = new int?(num2);
			if (!lpCollectDataTimeout.HasValue)
				return num4 != 0;
			lpCollectDataTimeout = new int?(num3);
			return num4 != 0;
		}

		/// <summary>
		///     Copies data from a named or anonymous pipe into a buffer without removing it from the pipe. It also returns
		///     information about data in the pipe.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the pipe. This parameter can be a handle to a named pipe instance, as returned by
		///     the <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> or <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function, or it can be a handle to the read end of
		///     an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" /> function. The handle must have GENERIC_READ access
		///     to the pipe.
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to a buffer that receives data read from the pipe. This parameter can be NULL if no
		///     data is to be read.
		/// </param>
		/// <param name="nBufferSize">
		///     The size of the buffer specified by the lpBuffer parameter, in bytes. This parameter is
		///     ignored if lpBuffer is NULL.
		/// </param>
		/// <param name="lpBytesRead">A pointer to a variable that receives the number of bytes read from the pipe.</param>
		/// <param name="lpTotalBytesAvail">
		///     A pointer to a variable that receives the total number of bytes available to be read
		///     from the pipe.
		/// </param>
		/// <param name="lpBytesLeftThisMessage">
		///     A pointer to a variable that receives the number of bytes remaining in this
		///     message. This parameter will be zero for byte-type named pipes or for anonymous pipes.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool PeekNamedPipe(Kernel32.SafeObjectHandle hNamedPipe, IntPtr lpBuffer, int nBufferSize,
		                                        out int lpBytesRead, out int lpTotalBytesAvail,
		                                        out int lpBytesLeftThisMessage) {
			void* pointer = lpBuffer.ToPointer();
			return Kernel32.PeekNamedPipe(hNamedPipe, pointer, nBufferSize, out lpBytesRead, out lpTotalBytesAvail,
				out lpBytesLeftThisMessage);
		}

		/// <summary>
		///     Sets the read mode and the blocking mode of the specified named pipe. If the specified handle is to the client
		///     end of a named pipe and if the named pipe server process is on a remote computer, the function can also be used to
		///     control local buffering.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe instance. This parameter can be a handle to the server end of the
		///     pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> function, or to the client end of the pipe, as returned by
		///     the <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function. The handle must have GENERIC_WRITE access to the named pipe for a
		///     write-only or read/write pipe, or it must have GENERIC_READ and FILE_WRITE_ATTRIBUTES access for a read-only pipe.
		///     <para>
		///         This parameter can also be a handle to an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" />
		///         function.
		///     </para>
		/// </param>
		/// <param name="lpMode">The new pipe mode. The mode is a combination of a read-mode flag and a wait-mode flag.</param>
		/// <param name="lpMaxCollectionCount">
		///     The maximum number of bytes collected on the client computer before transmission to
		///     the server. This parameter must be NULL if the specified pipe handle is to the server end of a named pipe or if
		///     client and server processes are on the same machine. This parameter is ignored if the client process specifies the
		///     FILE_FLAG_WRITE_THROUGH flag in the CreateFile function when the handle was created. This parameter can be NULL if
		///     the collection count is not being set.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     The maximum time, in milliseconds, that can pass before a remote named pipe
		///     transfers information over the network. This parameter must be NULL if the specified pipe handle is to the server
		///     end of a named pipe or if client and server processes are on the same computer. This parameter is ignored if the
		///     client process specified the FILE_FLAG_WRITE_THROUGH flag in the CreateFile function when the handle was created.
		///     This parameter can be NULL if the collection count is not being set.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool SetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe, IntPtr lpMode,
		                                                  IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout) {
			Kernel32.PipeMode* pointer1 = (Kernel32.PipeMode*) lpMode.ToPointer();
			int* pointer2 = (int*) lpMaxCollectionCount.ToPointer();
			int* pointer3 = (int*) lpCollectDataTimeout.ToPointer();
			return Kernel32.SetNamedPipeHandleState(hNamedPipe, pointer1, pointer2, pointer3);
		}

		/// <summary>
		///     Sets the read mode and the blocking mode of the specified named pipe. If the specified handle is to the client
		///     end of a named pipe and if the named pipe server process is on a remote computer, the function can also be used to
		///     control local buffering.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe instance. This parameter can be a handle to the server end of the
		///     pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> function, or to the client end of the pipe, as returned by
		///     the <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function. The handle must have GENERIC_WRITE access to the named pipe for a
		///     write-only or read/write pipe, or it must have GENERIC_READ and FILE_WRITE_ATTRIBUTES access for a read-only pipe.
		///     <para>
		///         This parameter can also be a handle to an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" />
		///         function.
		///     </para>
		/// </param>
		/// <param name="lpMode">The new pipe mode. The mode is a combination of a read-mode flag and a wait-mode flag.</param>
		/// <param name="lpMaxCollectionCount">
		///     The maximum number of bytes collected on the client computer before transmission to
		///     the server. This parameter must be NULL if the specified pipe handle is to the server end of a named pipe or if
		///     client and server processes are on the same machine. This parameter is ignored if the client process specifies the
		///     FILE_FLAG_WRITE_THROUGH flag in the CreateFile function when the handle was created. This parameter can be NULL if
		///     the collection count is not being set.
		/// </param>
		/// <param name="lpCollectDataTimeout">
		///     The maximum time, in milliseconds, that can pass before a remote named pipe
		///     transfers information over the network. This parameter must be NULL if the specified pipe handle is to the server
		///     end of a named pipe or if client and server processes are on the same computer. This parameter is ignored if the
		///     client process specified the FILE_FLAG_WRITE_THROUGH flag in the CreateFile function when the handle was created.
		///     This parameter can be NULL if the collection count is not being set.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool SetNamedPipeHandleState(Kernel32.SafeObjectHandle hNamedPipe,
		                                                  Kernel32.PipeMode? lpMode, int? lpMaxCollectionCount,
		                                                  int? lpCollectDataTimeout) {
			Kernel32.PipeMode pipeMode = lpMode.HasValue ? lpMode.Value : Kernel32.PipeMode.PIPE_TYPE_BYTE;
			int num1 = lpMaxCollectionCount.HasValue ? lpMaxCollectionCount.Value : 0;
			int num2 = lpCollectDataTimeout.HasValue ? lpCollectDataTimeout.Value : 0;
			return Kernel32.SetNamedPipeHandleState(hNamedPipe, lpMode.HasValue ? &pipeMode : (Kernel32.PipeMode*) null,
				lpMaxCollectionCount.HasValue ? &num1 : (int*) null,
				lpCollectDataTimeout.HasValue ? &num2 : (int*) null);
		}

		/// <summary>
		///     Combines the functions that write a message to and read a message from the specified named pipe into a single
		///     network operation.
		/// </summary>
		/// <param name="hNamedPipe">
		///     A handle to the named pipe returned by the <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" /> or
		///     <see cref="M:PInvoke.Kernel32.CreateFile(System.String,PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.CreationDisposition,PInvoke.Kernel32.CreateFileFlags,PInvoke.Kernel32.SafeObjectHandle)" /> function.
		///     <para>
		///         This parameter can also be a handle to an anonymous pipe, as returned by the <see cref="M:PInvoke.Kernel32.CreatePipe(PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SafeObjectHandle@,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Int32)" />
		///         function.
		///     </para>
		/// </param>
		/// <param name="lpInBuffer">A pointer to the buffer containing the data to be written to the pipe.</param>
		/// <param name="nInBufferSize">The size of the input buffer, in bytes.</param>
		/// <param name="lpOutBuffer">A pointer to the buffer that receives the data read from the pipe.</param>
		/// <param name="nOutBufferSize">The size of the output buffer, in bytes.</param>
		/// <param name="lpBytesRead">A pointer to the variable that receives the number of bytes read from the pipe.</param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. This structure is required if hNamedPipe was opened with
		///     FILE_FLAG_OVERLAPPED.
		///     <para>
		///         If hNamedPipe was opened with FILE_FLAG_OVERLAPPED, the lpOverlapped parameter must not be NULL. It must
		///         point to a valid <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. If hNamedPipe was created with FILE_FLAG_OVERLAPPED and
		///         lpOverlapped is NULL, the function can incorrectly report that the operation is complete.
		///     </para>
		///     <para>
		///         If hNamedPipe was opened with FILE_FLAG_OVERLAPPED and lpOverlapped is not NULL, TransactNamedPipe is
		///         executed as an overlapped operation. The <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure should contain a manual-reset
		///         event object (which can be created by using the CreateEvent function). If the operation cannot be completed
		///         immediately, TransactNamedPipe returns FALSE and GetLastError returns ERROR_IO_PENDING. In this situation, the
		///         event object is set to the nonsignaled state before TransactNamedPipe returns, and it is set to the signaled
		///         state when the transaction has finished. Also, you can be notified when an overlapped operation completes by
		///         using the GetQueuedCompletionStatus or GetQueuedCompletionStatusEx functions. In this case, you do not need to
		///         assign the manual-reset event in the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure, and the completion happens against
		///         <paramref name="hNamedPipe" /> in the same way as an asynchronous read or write operation.
		///     </para>
		///     <para>
		///         If hNamedPipe was not opened with FILE_FLAG_OVERLAPPED, TransactNamedPipe does not return until the operation
		///         is complete.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		///     <para>
		///         If the message to be read is longer than the buffer specified by the <paramref name="nOutBufferSize" />
		///         parameter, TransactNamedPipe returns FALSE and the <see cref="M:PInvoke.Kernel32.GetLastError" /> function returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_MORE_DATA" />. The remainder of the message can be read by a subsequent call to
		///         <see cref="M:PInvoke.Kernel32.ReadFile(PInvoke.Kernel32.SafeObjectHandle,System.Void*,System.Int32,System.Int32*,PInvoke.Kernel32.OVERLAPPED*)" />, ReadFileEx, or PeekNamedPipe.
		///     </para>
		/// </returns>
		public static unsafe bool TransactNamedPipe(Kernel32.SafeObjectHandle hNamedPipe, IntPtr lpInBuffer,
		                                            int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize,
		                                            out int lpBytesRead, IntPtr lpOverlapped) {
			void* pointer1 = lpInBuffer.ToPointer();
			void* pointer2 = lpOutBuffer.ToPointer();
			Kernel32.OVERLAPPED* pointer3 = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			return Kernel32.TransactNamedPipe(hNamedPipe, pointer1, nInBufferSize, pointer2, nOutBufferSize,
				out lpBytesRead, pointer3);
		}

		/// <summary>
		/// Allocates the specified number of bytes from the heap.
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. The default is the <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_FIXED" /> value.
		/// This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.
		/// </param>
		/// <param name="uBytes">
		/// The number of bytes to allocate. If this parameter is zero and the <paramref name="uFlags" /> parameter specifies <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_MOVEABLE" />,
		/// the function returns a handle to a memory object that is marked as discarded.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe IntPtr LocalAlloc_IntPtr(Kernel32.LocalAllocFlags uFlags, IntPtr uBytes) {
			return new IntPtr(Kernel32.LocalAlloc(uFlags, uBytes));
		}

		/// <summary>
		/// Changes the size or the attributes of a specified local memory object. The size can increase or decrease.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the local memory object to be reallocated.
		/// This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.LocalReAllocFlags)" /> function.
		/// </param>
		/// <param name="uBytes">The new size of the memory block, in bytes. If uFlags specifies <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" />, this parameter is ignored.</param>
		/// <param name="uFlags">
		/// The reallocation options. If <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" /> is specified, the function modifies the attributes of the memory object only
		/// (the uBytes parameter is ignored.) Otherwise, the function reallocates the memory object.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// If LocalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// If LocalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block.
		/// To access the memory, a process can simply cast the return value to a pointer.
		/// </remarks>
		public static unsafe IntPtr LocalReAlloc(IntPtr hMem, IntPtr uBytes, Kernel32.LocalReAllocFlags uFlags) {
			return new IntPtr(Kernel32.LocalReAlloc(hMem.ToPointer(), uBytes, uFlags));
		}

		/// <summary>
		/// Frees the specified local memory object and invalidates its handle.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the local memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or
		/// <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.LocalReAllocFlags)" /> function. It is not safe to free memory allocated with <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" />.
		/// If the hMem parameter is NULL, LocalFree ignores the parameter and returns NULL.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is NULL.
		/// If the function fails, the return value is equal to a handle to <paramref name="hMem" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe IntPtr LocalFree(IntPtr hMem) {
			return new IntPtr(Kernel32.LocalFree(hMem.ToPointer()));
		}

		/// <summary>
		/// Locks a local memory object and returns a pointer to the first byte of the object's memory block.
		/// </summary>
		/// <param name="hMem">A handle to the local memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.Int32,PInvoke.Kernel32.LocalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the first byte of the memory block.
		/// If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe IntPtr LocalLock(IntPtr hMem) {
			return new IntPtr(Kernel32.LocalLock(hMem.ToPointer()));
		}

		/// <summary>
		/// Decrements the lock count associated with a memory object that was allocated with <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_MOVEABLE" />.
		/// This function has no effect on memory objects allocated with <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_FIXED" />.
		/// </summary>
		/// <param name="hMem">A handle to the local  memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.Int32,PInvoke.Kernel32.LocalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the memory object is still locked after decrementing the lock count, the return value is true.
		/// If the memory object is unlocked after decrementing the lock count, the function returns false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// If the function fails, the return value is false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns a value other than <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// </returns>
		public static unsafe bool LocalUnlock(IntPtr hMem) {
			return Kernel32.LocalUnlock(hMem.ToPointer());
		}

		/// <summary>
		/// Allocates the specified number of bytes from the heap.
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. The default is the <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_FIXED" /> value.
		/// This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.
		/// </param>
		/// <param name="uBytes">
		/// The number of bytes to allocate. If this parameter is zero and the uFlags parameter specifies <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_MOVEABLE" />,
		/// the function returns a handle to a memory object that is marked as discarded.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe IntPtr GlobalAlloc_IntPtr(Kernel32.GlobalAllocFlags uFlags, IntPtr uBytes) {
			return new IntPtr(Kernel32.GlobalAlloc(uFlags, uBytes));
		}

		/// <summary>
		/// Changes the size or attributes of a specified global memory object. The size can increase or decrease.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object to be reallocated.
		/// This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function.
		/// </param>
		/// <param name="uBytes">The new size of the memory block, in bytes. If uFlags specifies <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_MODIFY" />, this parameter is ignored.</param>
		/// <param name="uFlags">
		/// The reallocation options. If <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" /> is specified, the function modifies the attributes of the memory object only
		/// (the uBytes parameter is ignored.) Otherwise, the function reallocates the memory object.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// If GlobalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// If GlobalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block.
		/// To access the memory, a process can simply cast the return value to a pointer.
		/// </remarks>
		public static unsafe IntPtr GlobalReAlloc(IntPtr hMem, IntPtr uBytes, Kernel32.GlobalReAllocFlags uFlags) {
			return new IntPtr(Kernel32.GlobalReAlloc(hMem.ToPointer(), uBytes, uFlags));
		}

		/// <summary>
		/// Frees the specified global memory object and invalidates its handle.
		/// </summary>
		/// <param name="hMem">
		/// A handle to the global memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or
		/// <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function. It is not safe to free memory allocated with <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" />.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is NULL.
		/// If the function fails, the return value is equal to a handle to <paramref name="hMem" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe IntPtr GlobalFree(IntPtr hMem) {
			return new IntPtr(Kernel32.GlobalFree(hMem.ToPointer()));
		}

		/// <summary>
		/// Locks a global memory object and returns a pointer to the first byte of the object's memory block.
		/// </summary>
		/// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the first byte of the memory block.
		///  If the function fails, the return value is <see cref="F:System.IntPtr.Zero" />. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe IntPtr GlobalLock(IntPtr hMem) {
			return new IntPtr(Kernel32.GlobalLock(hMem.ToPointer()));
		}

		/// <summary>
		/// Decrements the lock count associated with a memory object that was allocated with <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_MOVEABLE" />.
		/// This function has no effect on memory objects allocated with <see cref="F:PInvoke.Kernel32.GlobalAllocFlags.GMEM_FIXED" />.
		/// </summary>
		/// <param name="hMem">A handle to the global memory object. This handle is returned by either the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> function.</param>
		/// <returns>
		/// If the memory object is still locked after decrementing the lock count, the return value is true.
		/// If the memory object is unlocked after decrementing the lock count, the function returns false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// If the function fails, the return value is false and <see cref="M:PInvoke.Kernel32.GetLastError" /> returns a value other than <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" />.
		/// </returns>
		public static unsafe bool GlobalUnlock(IntPtr hMem) {
			return Kernel32.GlobalUnlock(hMem.ToPointer());
		}

		/// <summary>
		/// Allocates a block of memory from a heap. The allocated memory is not movable.
		/// </summary>
		/// <param name="hHeap">A handle to the heap from which the memory will be allocated. This handle is returned by the HeapCreate or  function.</param>
		/// <param name="uFlags">The heap allocation options. Specifying any of these values will override the corresponding value specified when the heap was created with HeapCreate.</param>
		/// <param name="uBytes">
		/// The number of bytes to be allocated. If the heap specified by the hHeap parameter is a "non-growable" heap,
		/// dwBytes must be less than 0x7FFF8.
		/// You create a non-growable heap by calling the HeapCreate function with a nonzero value.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the allocated memory block.
		/// If the function fails and you have not specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />, the return value is NULL.
		/// If the function fails and you have specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />,
		/// the function may generate either of the exceptions listed in the following table:
		/// <list>
		/// <item>STATUS_NO_MEMORY: The allocation attempt failed because of a lack of available memory or heap corruption.</item>
		/// <item>STATUS_ACCESS_VIOLATION: The allocation attempt failed because of heap corruption or improper function parameters.</item>
		/// </list>
		/// The particular exception depends upon the nature of the heap corruption. For more information, see GetExceptionCode.
		/// </returns>
		/// <remarks>If the function fails, it does not call SetLastError. An application cannot call <see cref="M:PInvoke.Kernel32.GetLastError" /> for extended error information.</remarks>
		public static unsafe IntPtr HeapAlloc_IntPtr(IntPtr hHeap, Kernel32.HeapAllocFlags uFlags, IntPtr uBytes) {
			return new IntPtr(Kernel32.HeapAlloc(hHeap, uFlags, uBytes));
		}

		/// <summary>
		/// Reallocates a block of memory from a heap. This function enables you to resize a memory block and change other memory block properties.
		/// The allocated memory is not movable.
		/// </summary>
		/// <param name="hHeap">A handle to the heap from which the memory is to be reallocated. This handle is a returned by either the HeapCreate or GetProcessHeap function.</param>
		/// <param name="uFlags">
		/// The heap reallocation options. Specifying a value overrides the corresponding value specified in the flOptions parameter
		/// when the heap was created by using the HeapCreate function.
		/// </param>
		/// <param name="hMem">
		/// A pointer to the block of memory that the function reallocates.
		/// This pointer is returned by an earlier call to the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> function.
		/// </param>
		/// <param name="uBytes">
		/// The new size of the memory block, in bytes. A memory block's size can be increased or decreased by using this function.
		/// If the heap specified by the hHeap parameter is a "non-growable" heap, dwBytes must be less than 0x7FFF8.
		/// You create a non-growable heap by calling the HeapCreate function with a nonzero value.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a pointer to the reallocated memory block.
		/// If the function fails and you have not specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />, the return value is NULL.
		/// If the function fails and you have specified <see cref="F:PInvoke.Kernel32.HeapAllocFlags.HEAP_GENERATE_EXCEPTIONS" />,
		/// the function may generate either of the exceptions listed in the following table:
		/// <list>
		/// <item>STATUS_NO_MEMORY: The allocation attempt failed because of a lack of available memory or heap corruption.</item>
		/// <item>STATUS_ACCESS_VIOLATION: The allocation attempt failed because of heap corruption or improper function parameters.</item>
		/// </list>
		/// The particular exception depends upon the nature of the heap corruption. For more information, see GetExceptionCode.
		/// </returns>
		/// <remarks>If the function fails, it does not call SetLastError. An application cannot call <see cref="M:PInvoke.Kernel32.GetLastError" /> for extended error information.</remarks>
		public static unsafe IntPtr HeapReAlloc(IntPtr hHeap, Kernel32.HeapReAllocFlags uFlags, IntPtr hMem,
		                                        IntPtr uBytes) {
			void* pointer = hMem.ToPointer();
			return new IntPtr(Kernel32.HeapReAlloc(hHeap, uFlags, pointer, uBytes));
		}

		/// <summary>
		/// Frees a memory block allocated from a heap by the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> function.
		/// </summary>
		/// <param name="hHeap">
		/// A handle to the heap whose memory block is to be freed. This handle is returned by either the HeapCreate or
		/// GetProcessHeap function.
		/// </param>
		/// <param name="dwFlags">The heap free options. Specifying the following value overrides the corresponding value specified in the flOptions parameter
		/// when the heap was created by using the HeapCreate function.</param>
		/// <param name="hMem">
		/// A pointer to the memory block to be freed. This pointer is returned by the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> function.
		/// If this pointer is NULL, the behavior is undefined.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is true. If the function fails, the return value false. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool HeapFree(IntPtr hHeap, Kernel32.HeapFreeFlags dwFlags, IntPtr hMem) {
			void* pointer = hMem.ToPointer();
			return Kernel32.HeapFree(hHeap, dwFlags, pointer);
		}

		/// <summary>
		/// Copies a block of memory from one location to another.
		/// </summary>
		/// <param name="Destination">A pointer to the starting address of the copied block's destination.</param>
		/// <param name="Source">A pointer to the starting address of the block of memory to copy.</param>
		/// <param name="Length">The size of the block of memory to copy, in bytes.</param>
		/// <remarks>
		/// This function is defined as the RtlCopyMemory function.
		/// If the source and destination blocks overlap, the results are undefined.
		/// For overlapped blocks, use the <see cref="M:PInvoke.Kernel32.MoveMemory(System.Void*,System.Void*,System.IntPtr)" /> function.
		/// </remarks>
		public static unsafe void CopyMemory(IntPtr Destination, IntPtr Source, IntPtr Length) {
			Kernel32.CopyMemory(Destination.ToPointer(), Source.ToPointer(), Length);
		}

		/// <summary>Moves a block of memory from one location to another.</summary>
		/// <param name="Destination">A pointer to the starting address of the move destination.</param>
		/// <param name="Source">A pointer to the starting address of the block of memory to be moved.</param>
		/// <param name="Length">The size of the block of memory to move, in bytes.</param>
		/// <remarks>
		/// <para>
		/// This function is defined as the RtlMoveMemory function.
		/// The source and destination blocks may overlap.
		/// </para>
		/// <para>
		/// The first parameter, <paramref name="Destination" />, must be large enough to hold <paramref name="Length" /> bytes of <paramref name="Source" />;
		/// otherwise, a buffer overrun may occur.
		/// This may lead to a denial of service attack against the application if an access violation occurs or, in the worst case,
		/// allow an attacker to inject executable code into your process.
		/// This is especially true if <paramref name="Destination" /> is a stack-based buffer.
		/// Be aware that the last parameter, <paramref name="Length" />, is the number of bytes to copy into <paramref name="Destination" />, not the size of the <paramref name="Destination" />.
		/// </para>
		/// </remarks>
		public static unsafe void MoveMemory(IntPtr Destination, IntPtr Source, IntPtr Length) {
			Kernel32.MoveMemory(Destination.ToPointer(), Source.ToPointer(), Length);
		}

		/// <summary>
		///     Enumerates resources of a specified type within a binary module. For Windows Vista and later, this is
		///     typically a language-neutral Portable Executable (LN file), and the enumeration will also include resources from
		///     the corresponding language-specific resource files (.mui files) that contain localizable language resources. It is
		///     also possible for hModule to specify an .mui file, in which case only that file is searched for resources.
		/// </summary>
		/// <param name="hModule">
		///     A handle to a module to be searched. Starting with Windows Vista, if this is an LN file, then appropriate .mui
		///     files (if any exist) are included in the search.
		///     <para>
		///         If this parameter is NULL, that is equivalent to passing in a handle to the module used to create the current
		///         process.
		///     </para>
		/// </param>
		/// <param name="lpszType">
		///     The type of the resource for which the name is being enumerated. Alternately, rather than a
		///     pointer, this parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is an integer value representing a
		///     predefined resource type.
		/// </param>
		/// <param name="lpEnumFunc">A pointer to the callback function to be called for each enumerated resource name or ID.</param>
		/// <param name="lParam">
		///     An application-defined value passed to the callback function. This parameter can be used in error
		///     checking.
		/// </param>
		/// <returns>
		///     The return value is TRUE if the function succeeds or FALSE if the function does not find a resource of the
		///     type specified, or if the function fails for another reason. To get extended error information, call
		///     <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool EnumResourceNames(Kernel32.SafeLibraryHandle hModule, IntPtr lpszType,
		                                            Kernel32.EnumResNameProc lpEnumFunc, IntPtr lParam) {
			char* pointer = (char*) lpszType.ToPointer();
			return Kernel32.EnumResourceNames(hModule, pointer, lpEnumFunc, lParam);
		}

		/// <summary>
		///     Enumerates language-specific resources, of the specified type and name, associated with a binary module.
		/// </summary>
		/// <param name="hModule">
		///     The handle to a module to be searched. Starting with Windows Vista, if this is a language-neutral Portable
		///     Executable (LN file), then appropriate .mui files (if any exist) are included in the search. If this is a
		///     specific .mui file, only that file is searched for resources.
		///     <para>
		///         If this parameter is NULL, that is equivalent to passing in a handle to the module used to create the current process.
		///     </para>
		/// </param>
		/// <param name="lpType">
		///     The type of resource for which the language is being enumerated. Alternately, rather than a pointer, this
		///     parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is an integer value representing a predefined resource type.
		/// </param>
		/// <param name="lpName">
		///     The name of the resource for which the language is being enumerated. Alternately, rather than a pointer,
		///     this parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is the integer identifier of the resource.
		/// </param>
		/// <param name="lpEnumFunc">
		///     A pointer to the callback function to be called for each enumerated resource language. For more information,
		///     see <see cref="T:PInvoke.Kernel32.EnumResLangProc" />.
		/// </param>
		/// <param name="lParam">
		///     An application-defined value passed to the callback function. This parameter can be used in error checking.
		/// </param>
		/// <returns>Returns TRUE if successful or FALSE otherwise. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.</returns>
		public static unsafe bool EnumResourceLanguages(Kernel32.SafeLibraryHandle hModule, IntPtr lpType,
		                                                IntPtr lpName, Kernel32.EnumResLangProc lpEnumFunc,
		                                                IntPtr lParam) {
			char* pointer1 = (char*) lpType.ToPointer();
			char* pointer2 = (char*) lpName.ToPointer();
			void* pointer3 = lParam.ToPointer();
			return Kernel32.EnumResourceLanguages(hModule, pointer1, pointer2, lpEnumFunc, pointer3);
		}

		/// <summary>Determines whether a value is an integer identifier for a resource.</summary>
		/// <param name="p">The pointer to be tested whether it contains an integer resource identifier.</param>
		/// <returns>If the value is a resource identifier, the return value is TRUE. Otherwise, the return value is FALSE.</returns>
		public static unsafe bool IS_INTRESOURCE(IntPtr p) {
			return Kernel32.IS_INTRESOURCE((char*) p.ToPointer());
		}

		/// <summary>
		///     Converts an integer value to a resource type compatible with the resource-management functions. This macro is
		///     used in place of a string containing the name of the resource.
		/// </summary>
		/// <param name="wInteger">The integer value to be converted.</param>
		/// <returns>The return value is the specified value in the low-order word and zero in the high-order word.</returns>
		public static unsafe IntPtr MAKEINTRESOURCE_IntPtr(int wInteger) {
			return new IntPtr((void*) Kernel32.MAKEINTRESOURCE(wInteger));
		}

		/// <summary>
		///     Determines the location of a resource with the specified type and name in the specified module.
		///     <para>To specify a language, use the FindResourceEx function.</para>
		/// </summary>
		/// <param name="hModule">
		///     A handle to the module whose portable executable file or an accompanying MUI file contains the
		///     resource. If this parameter is <see cref="F:PInvoke.Kernel32.SafeLibraryHandle.Null" />, the function searches the module used to
		///     create the current process.
		/// </param>
		/// <param name="lpName">
		///     The name of the resource. Alternately, rather than a pointer, this parameter can be
		///     <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />, where wInteger is the integer identifier of the resource.
		/// </param>
		/// <param name="lpType">
		///     The resource type. Alternately, rather than a pointer, this parameter can be
		///     <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />, where wInteger is the integer identifier of the given resource type.
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is a handle to the specified resource's information block. To obtain a
		///     handle to the resource, pass this handle to the <see cref="M:PInvoke.Kernel32.LoadResource(PInvoke.Kernel32.SafeLibraryHandle,System.IntPtr)" /> function.
		///     <para>
		///         If the function fails, the return value is NULL. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe IntPtr FindResource(Kernel32.SafeLibraryHandle hModule, IntPtr lpName, IntPtr lpType) {
			char* pointer1 = (char*) lpName.ToPointer();
			char* pointer2 = (char*) lpType.ToPointer();
			return Kernel32.FindResource(hModule, pointer1, pointer2);
		}

		/// <summary>Creates or opens a job object.</summary>
		/// <param name="lpJobAttributes">A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure that specifies the security descriptor for the job object and determines whether child processes can inherit the returned handle.
		/// If lpJobAttributes is NULL, the job object gets a default security descriptor and the handle cannot be inherited.
		/// The ACLs in the default security descriptor for a job object come from the primary or impersonation token of the creator.
		/// </param>
		/// <param name="lpName">The name of the job. The name is limited to MAX_PATH characters. Name comparison is case-sensitive.
		/// If lpName is NULL, the job is created without a name.
		/// If lpName matches the name of an existing event, semaphore, mutex, waitable timer, or file-mapping object, the function fails and the GetLastError function returns ERROR_INVALID_HANDLE.
		/// This occurs because these objects share the same namespace.The object can be created in a private namespace.For more information, see Object Namespaces.
		/// Terminal Services:  The name can have a "Global\" or "Local\" prefix to explicitly create the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\). For more information, see Kernel Object Namespaces.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the job object. The handle has the JOB_OBJECT_ALL_ACCESS access right. If the object existed before the function call, the function returns a handle to the existing job object and GetLastError returns ERROR_ALREADY_EXISTS.
		/// If the function fails, the return value is NULL.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe Kernel32.SafeObjectHandle CreateJobObject(IntPtr lpJobAttributes, string lpName) {
			return Kernel32.CreateJobObject((Kernel32.SECURITY_ATTRIBUTES*) lpJobAttributes.ToPointer(), lpName);
		}

		/// <summary>Sets limits for a job object.</summary>
		/// <param name="hJob">
		/// A handle to the job whose limits are being set. The <see cref="M:PInvoke.Kernel32.CreateJobObject(PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.String)" /> or OpenJobObject function returns this handle. The handle must have the JOB_OBJECT_SET_ATTRIBUTES access right. For more information, see Job Object Security and Access Rights.
		/// </param>
		/// <param name="jobObjectInfoClass">
		/// The information class for the limits to be set.
		/// </param>
		/// <param name="lpJobObjectInfo">T
		/// he limits or job state to be set for the job. The format of this data depends on the value of JobObjectInfoClass.
		/// </param>
		/// <param name="cbJobObjectInfoLength">
		/// The size of the job information being set, in bytes.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe bool SetInformationJobObject(Kernel32.SafeObjectHandle hJob,
		                                                  Kernel32.JOBOBJECTINFOCLASS jobObjectInfoClass,
		                                                  IntPtr lpJobObjectInfo, uint cbJobObjectInfoLength) {
			void* pointer = lpJobObjectInfo.ToPointer();
			return Kernel32.SetInformationJobObject(hJob, jobObjectInfoClass, pointer, cbJobObjectInfoLength);
		}

		public static unsafe IntPtr CreateConsoleScreenBuffer(Kernel32.ACCESS_MASK dwDesiredAccess,
		                                                      Kernel32.FileShare dwShareMode,
		                                                      IntPtr lpSecurityAttributes,
		                                                      Kernel32.ConsoleScreenBufferFlag dwFlags,
		                                                      IntPtr lpScreenBufferData) {
			Kernel32.SECURITY_ATTRIBUTES* pointer1 = (Kernel32.SECURITY_ATTRIBUTES*) lpSecurityAttributes.ToPointer();
			void* pointer2 = lpScreenBufferData.ToPointer();
			return Kernel32.CreateConsoleScreenBuffer(dwDesiredAccess, dwShareMode, pointer1, dwFlags, pointer2);
		}

		public static unsafe IntPtr CreateConsoleScreenBuffer(Kernel32.ACCESS_MASK dwDesiredAccess,
		                                                      Kernel32.FileShare dwShareMode,
		                                                      Kernel32.SECURITY_ATTRIBUTES? lpSecurityAttributes,
		                                                      Kernel32.ConsoleScreenBufferFlag dwFlags,
		                                                      IntPtr lpScreenBufferData) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes = lpSecurityAttributes.HasValue
				? lpSecurityAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			void* pointer = lpScreenBufferData.ToPointer();
			return Kernel32.CreateConsoleScreenBuffer(dwDesiredAccess, dwShareMode,
				lpSecurityAttributes.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null, dwFlags,
				pointer);
		}

		public static unsafe IntPtr CreateConsoleScreenBuffer(Kernel32.ACCESS_MASK dwDesiredAccess,
		                                                      Kernel32.FileShare dwShareMode,
		                                                      Kernel32.SECURITY_ATTRIBUTES? lpSecurityAttributes,
		                                                      Kernel32.ConsoleScreenBufferFlag dwFlags,
		                                                      void* lpScreenBufferData) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes = lpSecurityAttributes.HasValue
				? lpSecurityAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			return Kernel32.CreateConsoleScreenBuffer(dwDesiredAccess, dwShareMode,
				lpSecurityAttributes.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null, dwFlags,
				lpScreenBufferData);
		}

		public static unsafe int GetConsoleAliases(IntPtr lpAliasBuffer, int AliasBufferLength, string lpExeName) {
			return Kernel32.GetConsoleAliases((char*) lpAliasBuffer.ToPointer(), AliasBufferLength, lpExeName);
		}

		public static unsafe int GetConsoleAliases(char[] lpAliasBuffer, int AliasBufferLength, string lpExeName) {
			char[] chArray;
			return Kernel32.GetConsoleAliases(
				(chArray = lpAliasBuffer) == null || chArray.Length == 0 ? (char*) null : &chArray[0],
				AliasBufferLength, lpExeName);
		}

		public static unsafe int GetConsoleAliasExes(IntPtr lpExeNameBuffer, int ExeNameBufferLength) {
			return Kernel32.GetConsoleAliasExes((char*) lpExeNameBuffer.ToPointer(), ExeNameBufferLength);
		}

		public static unsafe int GetConsoleAliasExes(char[] lpExeNameBuffer, int ExeNameBufferLength) {
			char[] chArray;
			return Kernel32.GetConsoleAliasExes(
				(chArray = lpExeNameBuffer) == null || chArray.Length == 0 ? (char*) null : &chArray[0],
				ExeNameBufferLength);
		}

		public static unsafe int GetConsoleAlias(string lpSource, IntPtr lpTargetBuffer, int TargetBufferLength,
		                                         string lpExeName) {
			char* pointer = (char*) lpTargetBuffer.ToPointer();
			return Kernel32.GetConsoleAlias(lpSource, pointer, TargetBufferLength, lpExeName);
		}

		public static unsafe int GetConsoleAlias(string lpSource, char[] lpTargetBuffer, int TargetBufferLength,
		                                         string lpExeName) {
			char[] chArray;
			char* lpTargetBuffer1 =
				(chArray = lpTargetBuffer) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return Kernel32.GetConsoleAlias(lpSource, lpTargetBuffer1, TargetBufferLength, lpExeName);
		}

		public static unsafe int GetConsoleProcessList(IntPtr lpdwProcessList, int dwProcessCount) {
			return Kernel32.GetConsoleProcessList((uint*) lpdwProcessList.ToPointer(), dwProcessCount);
		}

		public static unsafe int GetConsoleProcessList(uint[] lpdwProcessList, int dwProcessCount) {
			uint[] numArray;
			return Kernel32.GetConsoleProcessList(
				(numArray = lpdwProcessList) == null || numArray.Length == 0 ? (uint*) null : &numArray[0],
				dwProcessCount);
		}

		public static unsafe bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, IntPtr lpConsoleScreenBufferInfo) {
			Kernel32.CONSOLE_SCREEN_BUFFER_INFO* pointer =
				(Kernel32.CONSOLE_SCREEN_BUFFER_INFO*) lpConsoleScreenBufferInfo.ToPointer();
			return Kernel32.GetConsoleScreenBufferInfo(hConsoleOutput, pointer);
		}

		public static unsafe bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput,
		                                                     out Kernel32.CONSOLE_SCREEN_BUFFER_INFO
			                                                     lpConsoleScreenBufferInfo) {
			fixed (Kernel32.CONSOLE_SCREEN_BUFFER_INFO* lpConsoleScreenBufferInfo1 = &lpConsoleScreenBufferInfo)
				return Kernel32.GetConsoleScreenBufferInfo(hConsoleOutput, lpConsoleScreenBufferInfo1);
		}

		public static unsafe bool GetConsoleSelectionInfo(IntPtr lpConsoleSelectionInfo) {
			return Kernel32.GetConsoleSelectionInfo(
				(Kernel32.CONSOLE_SELECTION_INFO*) lpConsoleSelectionInfo.ToPointer());
		}

		public static unsafe bool GetConsoleSelectionInfo(out Kernel32.CONSOLE_SELECTION_INFO lpConsoleSelectionInfo) {
			fixed (Kernel32.CONSOLE_SELECTION_INFO* lpConsoleSelectionInfo1 = &lpConsoleSelectionInfo)
				return Kernel32.GetConsoleSelectionInfo(lpConsoleSelectionInfo1);
		}

		public static unsafe int GetConsoleTitle(IntPtr lpConsoleTitle, int nSize) {
			return Kernel32.GetConsoleTitle((char*) lpConsoleTitle.ToPointer(), nSize);
		}

		public static unsafe int GetConsoleTitle(char[] lpConsoleTitle, int nSize) {
			char[] chArray;
			return Kernel32.GetConsoleTitle(
				(chArray = lpConsoleTitle) == null || chArray.Length == 0 ? (char*) null : &chArray[0], nSize);
		}

		public static unsafe bool ReadConsole(IntPtr hConsoleInput, IntPtr lpBuffer, int nNumberOfCharsToRead,
		                                      int lpNumberOfCharsRead, IntPtr lpReserved) {
			void* pointer = lpBuffer.ToPointer();
			return Kernel32.ReadConsole(hConsoleInput, pointer, nNumberOfCharsToRead, lpNumberOfCharsRead, lpReserved);
		}

		public static unsafe bool ScrollConsoleScreenBuffer(IntPtr hConsoleOutput, IntPtr lpScrollRectangle,
		                                                    IntPtr lpClipRectangle, COORD dwDestinationOrigin,
		                                                    IntPtr lpFill) {
			SMALL_RECT* pointer1 = (SMALL_RECT*) lpScrollRectangle.ToPointer();
			SMALL_RECT* pointer2 = (SMALL_RECT*) lpClipRectangle.ToPointer();
			Kernel32.CHAR_INFO* pointer3 = (Kernel32.CHAR_INFO*) lpFill.ToPointer();
			return Kernel32.ScrollConsoleScreenBuffer(hConsoleOutput, pointer1, pointer2, dwDestinationOrigin,
				pointer3);
		}

		public static unsafe bool ScrollConsoleScreenBuffer(IntPtr hConsoleOutput, SMALL_RECT lpScrollRectangle,
		                                                    SMALL_RECT? lpClipRectangle, COORD dwDestinationOrigin,
		                                                    Kernel32.CHAR_INFO lpFill) {
			SMALL_RECT smallRect = lpClipRectangle.HasValue ? lpClipRectangle.Value : (SMALL_RECT) null;
			return Kernel32.ScrollConsoleScreenBuffer(hConsoleOutput, &lpScrollRectangle,
				lpClipRectangle.HasValue ? &smallRect : (SMALL_RECT*) null, dwDestinationOrigin, &lpFill);
		}

		public static unsafe bool WriteConsole(IntPtr hConsoleOutput, IntPtr lpBuffer, int nNumberOfCharsToWrite,
		                                       IntPtr lpNumberOfCharsWritten, IntPtr lpReserved) {
			void* pointer1 = lpBuffer.ToPointer();
			int* pointer2 = (int*) lpNumberOfCharsWritten.ToPointer();
			return Kernel32.WriteConsole(hConsoleOutput, pointer1, nNumberOfCharsToWrite, pointer2, lpReserved);
		}

		public static unsafe bool WriteConsole(IntPtr hConsoleOutput, IntPtr lpBuffer, int nNumberOfCharsToWrite,
		                                       out int lpNumberOfCharsWritten, IntPtr lpReserved) {
			fixed (int* lpNumberOfCharsWritten1 = &lpNumberOfCharsWritten) {
				void* pointer = lpBuffer.ToPointer();
				return Kernel32.WriteConsole(hConsoleOutput, pointer, nNumberOfCharsToWrite, lpNumberOfCharsWritten1,
					lpReserved);
			}
		}

		public static unsafe bool WriteConsole(IntPtr hConsoleOutput, void* lpBuffer, int nNumberOfCharsToWrite,
		                                       out int lpNumberOfCharsWritten, IntPtr lpReserved) {
			fixed (int* lpNumberOfCharsWritten1 = &lpNumberOfCharsWritten)
				return Kernel32.WriteConsole(hConsoleOutput, lpBuffer, nNumberOfCharsToWrite, lpNumberOfCharsWritten1,
					lpReserved);
		}

		public static unsafe bool WriteConsoleOutput(IntPtr hConsoleOutput, IntPtr lpBuffer, COORD dwBufferSize,
		                                             COORD dwBufferCoord, IntPtr lpWriteRegion) {
			Kernel32.CHAR_INFO* pointer1 = (Kernel32.CHAR_INFO*) lpBuffer.ToPointer();
			SMALL_RECT* pointer2 = (SMALL_RECT*) lpWriteRegion.ToPointer();
			return Kernel32.WriteConsoleOutput(hConsoleOutput, pointer1, dwBufferSize, dwBufferCoord, pointer2);
		}

		public static unsafe bool WriteConsoleOutput(IntPtr hConsoleOutput, Kernel32.CHAR_INFO lpBuffer,
		                                             COORD dwBufferSize, COORD dwBufferCoord,
		                                             ref SMALL_RECT lpWriteRegion) {
			fixed (SMALL_RECT* lpWriteRegion1 = &lpWriteRegion)
				return Kernel32.WriteConsoleOutput(hConsoleOutput, &lpBuffer, dwBufferSize, dwBufferCoord,
					lpWriteRegion1);
		}

		public static unsafe bool WriteConsoleInput(IntPtr hConsoleInput, IntPtr lpBuffer, int nLength,
		                                            IntPtr lpNumberOfEventsWritten) {
			Kernel32.INPUT_RECORD* pointer1 = (Kernel32.INPUT_RECORD*) lpBuffer.ToPointer();
			int* pointer2 = (int*) lpNumberOfEventsWritten.ToPointer();
			return Kernel32.WriteConsoleInput(hConsoleInput, pointer1, nLength, pointer2);
		}

		public static unsafe bool WriteConsoleInput(IntPtr hConsoleInput, Kernel32.INPUT_RECORD lpBuffer, int nLength,
		                                            out int lpNumberOfEventsWritten) {
			fixed (int* lpNumberOfEventsWritten1 = &lpNumberOfEventsWritten)
				return Kernel32.WriteConsoleInput(hConsoleInput, &lpBuffer, nLength, lpNumberOfEventsWritten1);
		}

		/// <summary>
		/// Writes data to an area of memory in a specified process. The entire area to be written to must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process memory to be modified. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_WRITE" /> and <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_OPERATION" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process to which data is written. Before data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for write access, and if it is not accessible, the function fails.</param>
		/// <param name="lpBuffer">A pointer to the buffer that contains data to be written in the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be written to the specified process.</param>
		/// <param name="lpNumberOfBytesWritten">A pointer to a variable that receives the number of bytes transferred into the specified process. This parameter is optional. If <paramref name="lpNumberOfBytesWritten" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError. The function fails if the requested write operation crosses into an area of the process that is inaccessible.
		/// </returns>
		public static unsafe bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer,
		                                             IntPtr nSize, IntPtr lpNumberOfBytesWritten) {
			void* pointer1 = lpBaseAddress.ToPointer();
			void* pointer2 = lpBuffer.ToPointer();
			IntPtr* pointer3 = (IntPtr*) lpNumberOfBytesWritten.ToPointer();
			return Kernel32.WriteProcessMemory(hProcess, pointer1, pointer2, nSize, pointer3);
		}

		/// <summary>
		/// Writes data to an area of memory in a specified process. The entire area to be written to must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process memory to be modified. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_WRITE" /> and <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_OPERATION" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process to which data is written. Before data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for write access, and if it is not accessible, the function fails.</param>
		/// <param name="lpBuffer">A pointer to the buffer that contains data to be written in the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be written to the specified process.</param>
		/// <param name="lpNumberOfBytesWritten">A pointer to a variable that receives the number of bytes transferred into the specified process. This parameter is optional. If <paramref name="lpNumberOfBytesWritten" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError. The function fails if the requested write operation crosses into an area of the process that is inaccessible.
		/// </returns>
		public static unsafe bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer,
		                                             IntPtr nSize, ref IntPtr? lpNumberOfBytesWritten) {
			void* pointer1 = lpBaseAddress.ToPointer();
			void* pointer2 = lpBuffer.ToPointer();
			IntPtr num1 = lpNumberOfBytesWritten.HasValue ? lpNumberOfBytesWritten.Value : IntPtr.Zero;
			int num2 = Kernel32.WriteProcessMemory(hProcess, pointer1, pointer2, nSize,
				lpNumberOfBytesWritten.HasValue ? &num1 : (IntPtr*) null)
				? 1
				: 0;
			if (!lpNumberOfBytesWritten.HasValue)
				return num2 != 0;
			lpNumberOfBytesWritten = new IntPtr?(num1);
			return num2 != 0;
		}

		/// <summary>
		/// Writes data to an area of memory in a specified process. The entire area to be written to must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process memory to be modified. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_WRITE" /> and <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_OPERATION" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process to which data is written. Before data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for write access, and if it is not accessible, the function fails.</param>
		/// <param name="lpBuffer">A pointer to the buffer that contains data to be written in the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be written to the specified process.</param>
		/// <param name="lpNumberOfBytesWritten">A pointer to a variable that receives the number of bytes transferred into the specified process. This parameter is optional. If <paramref name="lpNumberOfBytesWritten" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError. The function fails if the requested write operation crosses into an area of the process that is inaccessible.
		/// </returns>
		public static unsafe bool WriteProcessMemory(IntPtr hProcess, void* lpBaseAddress, void* lpBuffer, IntPtr nSize,
		                                             ref IntPtr? lpNumberOfBytesWritten) {
			IntPtr num1 = lpNumberOfBytesWritten.HasValue ? lpNumberOfBytesWritten.Value : IntPtr.Zero;
			int num2 = Kernel32.WriteProcessMemory(hProcess, lpBaseAddress, lpBuffer, nSize,
				lpNumberOfBytesWritten.HasValue ? &num1 : (IntPtr*) null)
				? 1
				: 0;
			if (!lpNumberOfBytesWritten.HasValue)
				return num2 != 0;
			lpNumberOfBytesWritten = new IntPtr?(num1);
			return num2 != 0;
		}

		/// <summary>
		/// Reads data from an area of memory in a specified process. The entire area to be read must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process with memory that is being read. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_READ" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process from which to read. Before any data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for read access, and if it is not accessible the function fails.</param>
		/// <param name="lpBuffer">A pointer to a buffer that receives the contents from the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be read from the specified process.</param>
		/// <param name="lpNumberOfBytesRead">A pointer to a variable that receives the number of bytes transferred into the specified buffer. If <paramref name="lpNumberOfBytesRead" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.
		/// The function fails if the requested read operation crosses into an area of the process that is inaccessible.
		/// </returns>
		public static unsafe bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer,
		                                            IntPtr nSize, IntPtr lpNumberOfBytesRead) {
			void* pointer1 = lpBaseAddress.ToPointer();
			void* pointer2 = lpBuffer.ToPointer();
			IntPtr* pointer3 = (IntPtr*) lpNumberOfBytesRead.ToPointer();
			return Kernel32.ReadProcessMemory(hProcess, pointer1, pointer2, nSize, pointer3);
		}

		/// <summary>
		/// Reads data from an area of memory in a specified process. The entire area to be read must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process with memory that is being read. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_READ" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process from which to read. Before any data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for read access, and if it is not accessible the function fails.</param>
		/// <param name="lpBuffer">A pointer to a buffer that receives the contents from the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be read from the specified process.</param>
		/// <param name="lpNumberOfBytesRead">A pointer to a variable that receives the number of bytes transferred into the specified buffer. If <paramref name="lpNumberOfBytesRead" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.
		/// The function fails if the requested read operation crosses into an area of the process that is inaccessible.
		/// </returns>
		public static unsafe bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer,
		                                            IntPtr nSize, ref IntPtr? lpNumberOfBytesRead) {
			void* pointer1 = lpBaseAddress.ToPointer();
			void* pointer2 = lpBuffer.ToPointer();
			IntPtr num1 = lpNumberOfBytesRead.HasValue ? lpNumberOfBytesRead.Value : IntPtr.Zero;
			int num2 = Kernel32.ReadProcessMemory(hProcess, pointer1, pointer2, nSize,
				lpNumberOfBytesRead.HasValue ? &num1 : (IntPtr*) null)
				? 1
				: 0;
			if (!lpNumberOfBytesRead.HasValue)
				return num2 != 0;
			lpNumberOfBytesRead = new IntPtr?(num1);
			return num2 != 0;
		}

		/// <summary>
		/// Reads data from an area of memory in a specified process. The entire area to be read must be accessible or the operation fails.
		/// </summary>
		/// <param name="hProcess">A handle to the process with memory that is being read. The handle must have <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_VM_READ" /> access to the process.</param>
		/// <param name="lpBaseAddress">A pointer to the base address in the specified process from which to read. Before any data transfer occurs, the system verifies that all data in the base address and memory of the specified size is accessible for read access, and if it is not accessible the function fails.</param>
		/// <param name="lpBuffer">A pointer to a buffer that receives the contents from the address space of the specified process.</param>
		/// <param name="nSize">The number of bytes to be read from the specified process.</param>
		/// <param name="lpNumberOfBytesRead">A pointer to a variable that receives the number of bytes transferred into the specified buffer. If <paramref name="lpNumberOfBytesRead" /> is NULL, the parameter is ignored.</param>
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is 0 (zero). To get extended error information, call GetLastError.
		/// The function fails if the requested read operation crosses into an area of the process that is inaccessible.
		/// </returns>
		public static unsafe bool ReadProcessMemory(IntPtr hProcess, void* lpBaseAddress, void* lpBuffer, IntPtr nSize,
		                                            ref IntPtr? lpNumberOfBytesRead) {
			IntPtr num1 = lpNumberOfBytesRead.HasValue ? lpNumberOfBytesRead.Value : IntPtr.Zero;
			int num2 = Kernel32.ReadProcessMemory(hProcess, lpBaseAddress, lpBuffer, nSize,
				lpNumberOfBytesRead.HasValue ? &num1 : (IntPtr*) null)
				? 1
				: 0;
			if (!lpNumberOfBytesRead.HasValue)
				return num2 != 0;
			lpNumberOfBytesRead = new IntPtr?(num1);
			return num2 != 0;
		}

		/// <summary>Retrieves a pointer to the specified resource in memory.</summary>
		/// <param name="hResData">
		///     A handle to the resource to be accessed. The <see cref="M:PInvoke.Kernel32.LoadResource(PInvoke.Kernel32.SafeLibraryHandle,System.IntPtr)" /> function returns this
		///     handle.
		/// </param>
		/// <returns>
		///     If the loaded resource is available, the return value is a pointer to the first byte of the resource;
		///     otherwise, it is NULL.
		/// </returns>
		public static unsafe IntPtr LockResource_IntPtr(IntPtr hResData) {
			return new IntPtr(Kernel32.LockResource(hResData));
		}

		/// <summary>
		///     Sends a control code directly to a specified device driver, causing the corresponding device to perform the
		///     corresponding operation.
		/// </summary>
		/// <param name="hDevice">
		///     A handle to the device on which the operation is to be performed. The device is typically a
		///     volume, directory, file, or stream. To retrieve a device handle, use the CreateFile function.
		/// </param>
		/// <param name="dwIoControlCode">
		///     The control code for the operation. This value identifies the specific operation to be performed and the type of
		///     device on which to perform it.
		///     <para>
		///         For a list of the control codes, see Remarks. The documentation for each control code provides usage details
		///         for the <paramref name="inBuffer" />, <paramref name="nInBufferSize" />, <paramref name="outBuffer" />, and
		///         <paramref name="nOutBufferSize" /> parameters.
		///     </para>
		/// </param>
		/// <param name="inBuffer">
		///     A pointer to the input buffer that contains the data required to perform the operation. The format of this data
		///     depends on the value of the <paramref name="dwIoControlCode" /> parameter.
		///     <para>
		///         This parameter can be NULL if <paramref name="dwIoControlCode" /> specifies an operation that does not
		///         require input data.
		///     </para>
		/// </param>
		/// <param name="nInBufferSize">The size of the input buffer, in bytes.</param>
		/// <param name="outBuffer">
		///     A pointer to the output buffer that is to receive the data returned by the operation. The format of this data
		///     depends on the value of the <paramref name="dwIoControlCode" /> parameter.
		///     <para>
		///         This parameter can be NULL if <paramref name="dwIoControlCode" /> specifies an operation that does not return
		///         data.
		///     </para>
		/// </param>
		/// <param name="nOutBufferSize">The size of the output buffer, in bytes.</param>
		/// <param name="pBytesReturned">
		///     A pointer to a variable that receives the size of the data stored in the output buffer, in bytes.
		///     <para>
		///         If the output buffer is too small to receive any data, the call fails, <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_INSUFFICIENT_BUFFER" />, and lpBytesReturned is zero.
		///     </para>
		///     <para>
		///         If the output buffer is too small to hold all of the data but can hold some entries, some drivers will return
		///         as much data as fits. In this case, the call fails, <see cref="M:PInvoke.Kernel32.GetLastError" /> returns
		///         <see cref="F:PInvoke.Win32ErrorCode.ERROR_MORE_DATA" />, and lpBytesReturned indicates the amount of data received. Your
		///         application should call DeviceIoControl again with the same operation, specifying a new starting point.
		///     </para>
		///     <para>
		///         If <paramref name="lpOverlapped" /> is NULL, lpBytesReturned cannot be NULL. Even when an operation returns
		///         no output data and lpOutBuffer is NULL, DeviceIoControl makes use of lpBytesReturned. After such an operation,
		///         the value of lpBytesReturned is meaningless.
		///     </para>
		///     <para>
		///         If <paramref name="lpOverlapped" /> is not NULL, lpBytesReturned can be NULL. If this parameter is not NULL
		///         and the operation returns data, lpBytesReturned is meaningless until the overlapped operation has completed. To
		///         retrieve the number of bytes returned, call GetOverlappedResult. If hDevice is associated with an I/O
		///         completion port, you can retrieve the number of bytes returned by calling GetQueuedCompletionStatus.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an OVERLAPPED structure.
		///     <para>
		///         If hDevice was opened without specifying <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_FLAG_OVERLAPPED" />, lpOverlapped is
		///         ignored.
		///     </para>
		///     <para>
		///         If hDevice was opened with the <see cref="F:PInvoke.Kernel32.CreateFileFlags.FILE_FLAG_OVERLAPPED" /> flag, the operation is
		///         performed as an overlapped (asynchronous) operation. In this case, lpOverlapped must point to a valid
		///         OVERLAPPED structure that contains a handle to an event object. Otherwise, the function fails in unpredictable
		///         ways.
		///     </para>
		///     <para>
		///         For overlapped operations, DeviceIoControl returns immediately, and the event object is signaled when the
		///         operation has been completed. Otherwise, the function does not return until the operation has been completed or
		///         an error occurs.
		///     </para>
		/// </param>
		/// <returns>
		///     If the operation completes successfully, the return value is nonzero.
		///     <para>
		///         If the operation fails or is pending, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool DeviceIoControl(Kernel32.SafeObjectHandle hDevice, int dwIoControlCode,
		                                          IntPtr inBuffer, int nInBufferSize, IntPtr outBuffer,
		                                          int nOutBufferSize, out int pBytesReturned, IntPtr lpOverlapped) {
			void* pointer1 = inBuffer.ToPointer();
			void* pointer2 = outBuffer.ToPointer();
			Kernel32.OVERLAPPED* pointer3 = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			return Kernel32.DeviceIoControl(hDevice, dwIoControlCode, pointer1, nInBufferSize, pointer2, nOutBufferSize,
				out pBytesReturned, pointer3);
		}

		/// <summary>
		/// Sets the current system time and date. The system time is expressed in Coordinated Universal Time (UTC).
		/// </summary>
		/// <param name="lpSystemTime">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure that contains the new system date and time.
		/// The wDayOfWeek member of the <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure is ignored.</param>
		/// <returns>
		///     If the function succeeds, the return value is a nonzero value.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool SetSystemTime(IntPtr lpSystemTime) {
			return Kernel32.SetSystemTime((Kernel32.SYSTEMTIME*) lpSystemTime.ToPointer());
		}

		/// <summary>
		/// Sets the current system time and date. The system time is expressed in Coordinated Universal Time (UTC).
		/// </summary>
		/// <param name="lpSystemTime">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure that contains the new system date and time.
		/// The wDayOfWeek member of the <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure is ignored.</param>
		/// <returns>
		///     If the function succeeds, the return value is a nonzero value.
		///     <para>
		///         If the function fails, the return value is zero. To get extended error information, call
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />.
		///     </para>
		/// </returns>
		public static unsafe bool SetSystemTime(Kernel32.SYSTEMTIME lpSystemTime) {
			return Kernel32.SetSystemTime(&lpSystemTime);
		}

		/// <summary>
		/// Allocates the specified number of bytes from the heap.
		/// </summary>
		/// <param name="uFlags">
		/// The memory allocation attributes. The default is the <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_FIXED" /> value. This parameter can be one or more of the following values, except for the incompatible combinations that are specifically noted.
		/// </param>
		/// <param name="uBytes">The number of bytes to allocate. If this parameter is zero and the <paramref name="uFlags" /> parameter specifies <see cref="F:PInvoke.Kernel32.LocalAllocFlags.LMEM_MOVEABLE" />, the function returns a handle to a memory object that is marked as discarded.</param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly allocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe IntPtr LocalAlloc_IntPtr(Kernel32.LocalAllocFlags uFlags, int uBytes) {
			return new IntPtr(Kernel32.LocalAlloc(uFlags, uBytes));
		}

		/// <summary>
		/// Changes the size or the attributes of a specified local memory object. The size can increase or decrease.
		/// </summary>
		/// <param name="hMem">A handle to the local memory object to be reallocated. This handle is returned by either the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> or <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.LocalReAllocFlags)" /> function.</param>
		/// <param name="uBytes">The new size of the memory block, in bytes. If uFlags specifies <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" />, this parameter is ignored.</param>
		/// <param name="uFlags">
		/// The reallocation options. If <see cref="F:PInvoke.Kernel32.LocalReAllocFlags.LMEM_MODIFY" /> is specified, the function modifies the attributes of the memory object only (the uBytes parameter is ignored.) Otherwise, the function reallocates the memory object.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the reallocated memory object.
		/// If the function fails, the return value is NULL. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		/// <remarks>
		/// If LocalReAlloc fails, the original memory is not freed, and the original handle and pointer are still valid.
		/// If LocalReAlloc reallocates a fixed object, the value of the handle returned is the address of the first byte of the memory block. To access the memory, a process can simply cast the return value to a pointer.
		/// </remarks>
		public static unsafe IntPtr LocalReAlloc(IntPtr hMem, int uBytes, Kernel32.LocalReAllocFlags uFlags) {
			return new IntPtr(Kernel32.LocalReAlloc(hMem.ToPointer(), uBytes, uFlags));
		}

		/// <summary>
		/// Searches a directory for a file or subdirectory with a name and attributes that match those specified.
		/// For the most basic version of this function, see FindFirstFile.
		/// To perform this operation as a transacted operation, use the FindFirstFileTransacted function.
		/// </summary>
		/// <param name="lpFileName">
		/// The directory or path, and the file name, which can include wildcard characters, for example, an asterisk (*) or a question mark (?).
		/// This parameter should not be NULL, an invalid string (for example, an empty string or a string that is missing the terminating null character), or end in a trailing backslash (\).
		/// If the string ends with a wildcard, period, or directory name, the user must have access to the root and all subdirectories on the path.
		/// In the ANSI version of this function, the name is limited to MAX_PATH characters. To extend this limit to approximately 32,000 wide characters, call the Unicode version of the function and prepend "\\?\" to the path. For more information, see Naming a File.
		/// </param>
		/// <param name="fInfoLevelId">
		/// The information level of the returned data.
		/// This parameter is one of the <see cref="T:PInvoke.Kernel32.FINDEX_INFO_LEVELS" /> enumeration values.
		/// </param>
		/// <param name="lpFindFileData">
		/// A pointer to the buffer that receives the file data.
		/// The pointer type is determined by the level of information that is specified in the <paramref name="fInfoLevelId" /> parameter.
		/// </param>
		/// <param name="fSearchOp">
		/// The type of filtering to perform that is different from wildcard matching.
		/// This parameter is one of the <see cref="T:PInvoke.Kernel32.FINDEX_SEARCH_OPS" /> enumeration values.
		/// </param>
		/// <param name="lpSearchFilter">
		/// A pointer to the search criteria if the specified <paramref name="fSearchOp" /> needs structured search information.
		/// At this time, none of the supported fSearchOp values require extended search information. Therefore, this pointer must be NULL.
		/// </param>
		/// <param name="dwAdditionalFlags">Specifies additional flags that control the search.</param>
		/// <returns>
		/// If the function succeeds, the return value is a search handle used in a subsequent call to FindNextFile or FindClose, and the lpFindFileData parameter contains information about the first file or directory found.
		/// If the function fails or fails to locate files from the search string in the lpFileName parameter, the return value is INVALID_HANDLE_VALUE and the contents of lpFindFileData are indeterminate.To get extended error information, call the <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		/// </returns>
		public static unsafe Kernel32.SafeFindFilesHandle FindFirstFileEx(
			string lpFileName, Kernel32.FINDEX_INFO_LEVELS fInfoLevelId, out Kernel32.WIN32_FIND_DATA lpFindFileData,
			Kernel32.FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter,
			Kernel32.FindFirstFileExFlags dwAdditionalFlags) {
			void* pointer = lpSearchFilter.ToPointer();
			return Kernel32.FindFirstFileEx(lpFileName, fInfoLevelId, out lpFindFileData, fSearchOp, pointer,
				dwAdditionalFlags);
		}

		/// <summary>
		/// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
		/// </summary>
		/// <param name="dwFlags">
		/// The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
		/// </param>
		/// <param name="lpSource">
		/// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags" /> parameter.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE" />: A handle to the module that contains the message table to search.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />: Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.
		/// If neither of these flags is set in dwFlags, then lpSource is ignored.
		/// </param>
		/// <param name="dwMessageId">
		/// The message identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// </param>
		/// <param name="dwLanguageId">
		/// The language identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only.If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND.If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:
		/// Language neutral
		/// Thread LANGID, based on the thread's locale value
		/// User default LANGID, based on the user's default locale value
		/// System default LANGID, based on the system default locale value
		/// US English
		/// If FormatMessage does not locate a message for any of the preceding LANGIDs, it returns any language message string that is present.If that fails, it returns ERROR_RESOURCE_LANG_NOT_FOUND.
		/// </param>
		/// <param name="lpBuffer">
		/// A pointer to a buffer that receives the null-terminated string that specifies the formatted message. If dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" />, the function allocates a buffer using the LocalAlloc function, and places the pointer to the buffer at the address specified in lpBuffer.
		/// This buffer cannot be larger than 64K bytes.
		/// </param>
		/// <param name="nSize">
		/// If the <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" /> flag is not set, this parameter specifies the size of the output buffer, in TCHARs. If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" /> is set,
		/// this parameter specifies the minimum number of TCHARs to allocate for an output buffer.
		/// The output buffer cannot be larger than 64K bytes.
		/// </param>
		/// <param name="Arguments">
		/// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.
		/// The interpretation of each value depends on the formatting information associated with the insert in the message definition.The default is to treat each value as a pointer to a null-terminated string.
		/// By default, the Arguments parameter is of type va_list*, which is a language- and implementation-specific data type for describing a variable number of arguments.The state of the va_list argument is undefined upon return from the function.To use the va_list again, destroy the variable argument list pointer using va_end and reinitialize it with va_start.
		/// If you do not have a pointer of type va_list*, then specify the FORMAT_MESSAGE_ARGUMENT_ARRAY flag and pass a pointer to an array of DWORD_PTR values; those values are input to the message formatted as the insert values.Each insert must have a corresponding element in the array.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is the number of TCHARs stored in the output buffer, excluding the terminating null character.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe int FormatMessage(Kernel32.FormatMessageFlags dwFlags, IntPtr lpSource, int dwMessageId,
		                                       int dwLanguageId, StringBuilder lpBuffer, int nSize,
		                                       IntPtr[] Arguments) {
			void* pointer = lpSource.ToPointer();
			return Kernel32.FormatMessage(dwFlags, pointer, dwMessageId, dwLanguageId, lpBuffer, nSize, Arguments);
		}

		/// <summary>
		///     Marks any outstanding I/O operations for the specified file handle. The function only cancels I/O operations
		///     in the current process, regardless of which thread created the I/O operation.
		/// </summary>
		/// <param name="hFile">A handle to the file.</param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> data structure that contains the data used for asynchronous I/O.
		///     <para>If this parameter is NULL, all I/O requests for the hFile parameter are canceled.</para>
		///     <para>
		///         If this parameter is not NULL, only those specific I/O requests that were issued for the file with the
		///         specified
		///         <paramref name="lpOverlapped" /> overlapped structure are marked as canceled, meaning that you can cancel one
		///         or more requests, while the CancelIo function cancels all outstanding requests on a file handle.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is nonzero. The cancel operation for all pending I/O operations issued
		///     by the calling process for the specified file handle was successfully requested. The application must not free or
		///     reuse the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure associated with the canceled I/O operations until they have
		///     completed. The thread can use the GetOverlappedResult function to determine when the I/O operations themselves have
		///     been completed.
		///     <para>
		///         If the function fails, the return value is 0 (zero). To get extended error information, call the
		///         <see cref="M:PInvoke.Kernel32.GetLastError" /> function.
		///     </para>
		///     <para>
		///         If this function cannot find a request to cancel, the return value is 0 (zero), and
		///         <see cref="M:PInvoke.Kernel32.GetLastError" />
		///         returns <see cref="F:PInvoke.Win32ErrorCode.ERROR_NOT_FOUND" />.
		///     </para>
		/// </returns>
		public static unsafe bool CancelIoEx(Kernel32.SafeObjectHandle hFile, IntPtr lpOverlapped) {
			Kernel32.OVERLAPPED* pointer = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			return Kernel32.CancelIoEx(hFile, pointer);
		}

		/// <summary>
		///     Reads data from the specified file or input/output (I/O) device. Reads occur at the position specified by the file
		///     pointer if supported by the device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operations. For a similar function designed
		///         solely for asynchronous operation, see ReadFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer, tape drive,
		///     socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		///     <para>
		///         For asynchronous read operations, hFile can be any handle that is opened with the FILE_FLAG_OVERLAPPED flag
		///         by the CreateFile function, or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer that receives the data read from a file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the read operation. The caller must not use this buffer
		///         until the read operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">
		///     A pointer to the variable that receives the number of bytes read when using a synchronous hFile parameter. ReadFile
		///     sets this value to zero before doing any work or error checking. Use <see langword="null" /> for this parameter if
		///     this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be <see langword="null" /> only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise it can be <see langword="null" />.
		///     <para>
		///         If hFile is opened with FILE_FLAG_OVERLAPPED, the <paramref name="lpOverlapped" /> parameter must point to a
		///         valid and unique <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure, otherwise the function can incorrectly report that the
		///         read operation is complete.
		///     </para>
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start reading from the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the read operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		public static unsafe bool ReadFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer, int nNumberOfBytesToRead,
		                                   IntPtr lpNumberOfBytesRead, IntPtr lpOverlapped) {
			void* pointer1 = lpBuffer.ToPointer();
			int* pointer2 = (int*) lpNumberOfBytesRead.ToPointer();
			Kernel32.OVERLAPPED* pointer3 = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			return Kernel32.ReadFile(hFile, pointer1, nNumberOfBytesToRead, pointer2, pointer3);
		}

		/// <summary>
		///     Reads data from the specified file or input/output (I/O) device. Reads occur at the position specified by the file
		///     pointer if supported by the device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operations. For a similar function designed
		///         solely for asynchronous operation, see ReadFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer, tape drive,
		///     socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		///     <para>
		///         For asynchronous read operations, hFile can be any handle that is opened with the FILE_FLAG_OVERLAPPED flag
		///         by the CreateFile function, or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer that receives the data read from a file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the read operation. The caller must not use this buffer
		///         until the read operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">
		///     A pointer to the variable that receives the number of bytes read when using a synchronous hFile parameter. ReadFile
		///     sets this value to zero before doing any work or error checking. Use <see langword="null" /> for this parameter if
		///     this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be <see langword="null" /> only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise it can be <see langword="null" />.
		///     <para>
		///         If hFile is opened with FILE_FLAG_OVERLAPPED, the <paramref name="lpOverlapped" /> parameter must point to a
		///         valid and unique <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure, otherwise the function can incorrectly report that the
		///         read operation is complete.
		///     </para>
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start reading from the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the read operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		public static unsafe bool ReadFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer, int nNumberOfBytesToRead,
		                                   ref int? lpNumberOfBytesRead, IntPtr lpOverlapped) {
			void* pointer1 = lpBuffer.ToPointer();
			int num1 = lpNumberOfBytesRead.HasValue ? lpNumberOfBytesRead.Value : 0;
			Kernel32.OVERLAPPED* pointer2 = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			int num2 = Kernel32.ReadFile(hFile, pointer1, nNumberOfBytesToRead,
				lpNumberOfBytesRead.HasValue ? &num1 : (int*) null, pointer2)
				? 1
				: 0;
			if (!lpNumberOfBytesRead.HasValue)
				return num2 != 0;
			lpNumberOfBytesRead = new int?(num1);
			return num2 != 0;
		}

		/// <summary>
		///     Reads data from the specified file or input/output (I/O) device. Reads occur at the position specified by the file
		///     pointer if supported by the device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operations. For a similar function designed
		///         solely for asynchronous operation, see ReadFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer, tape drive,
		///     socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		///     <para>
		///         For asynchronous read operations, hFile can be any handle that is opened with the FILE_FLAG_OVERLAPPED flag
		///         by the CreateFile function, or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer that receives the data read from a file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the read operation. The caller must not use this buffer
		///         until the read operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <param name="lpNumberOfBytesRead">
		///     A pointer to the variable that receives the number of bytes read when using a synchronous hFile parameter. ReadFile
		///     sets this value to zero before doing any work or error checking. Use <see langword="null" /> for this parameter if
		///     this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be <see langword="null" /> only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise it can be <see langword="null" />.
		///     <para>
		///         If hFile is opened with FILE_FLAG_OVERLAPPED, the <paramref name="lpOverlapped" /> parameter must point to a
		///         valid and unique <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure, otherwise the function can incorrectly report that the
		///         read operation is complete.
		///     </para>
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start reading from the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the read operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		public static unsafe bool ReadFile(Kernel32.SafeObjectHandle hFile, void* lpBuffer, int nNumberOfBytesToRead,
		                                   ref int? lpNumberOfBytesRead, Kernel32.OVERLAPPED* lpOverlapped) {
			int num1 = lpNumberOfBytesRead.HasValue ? lpNumberOfBytesRead.Value : 0;
			int num2 = Kernel32.ReadFile(hFile, lpBuffer, nNumberOfBytesToRead,
				lpNumberOfBytesRead.HasValue ? &num1 : (int*) null, lpOverlapped)
				? 1
				: 0;
			if (!lpNumberOfBytesRead.HasValue)
				return num2 != 0;
			lpNumberOfBytesRead = new int?(num1);
			return num2 != 0;
		}

		/// <summary>
		///     Writes data to the specified file or input/output (I/O) device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operation. For a similar function designed
		///         solely for asynchronous operation, see WriteFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the file or I/O device (for example, a file, file stream, physical disk, volume, console buffer, tape
		///     drive, socket, communications resource, mailslot, or pipe).
		///     <para>
		///         The hFile parameter must have been created with the write access. For more information, see Generic Access
		///         Rights and File Security and Access Rights.
		///     </para>
		///     <para>
		///         For asynchronous write operations, hFile can be any handle opened with the CreateFile function using the
		///         FILE_FLAG_OVERLAPPED flag or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer containing the data to be written to the file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the write operation. The caller must not use this buffer
		///         until the write operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToWrite">
		///     The number of bytes to be written to the file or device.
		///     <para>
		///         A value of zero specifies a null write operation. The behavior of a null write operation depends on the
		///         underlying file system or communications technology.
		///     </para>
		/// </param>
		/// <param name="lpNumberOfBytesWritten">
		///     A pointer to the variable that receives the number of bytes written when using a synchronous hFile parameter.
		///     WriteFile sets this value to zero before doing any work or error checking. Use <see langword="null" />
		///     for this parameter if this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be NULL only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise this parameter can be NULL.
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start writing to the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		///     <para>
		///         To write to the end of file, specify both the Offset and OffsetHigh members of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" />
		///         structure as 0xFFFFFFFF. This is functionally equivalent to previously calling the CreateFile function to open
		///         hFile using FILE_APPEND_DATA access.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the write operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		public static unsafe bool WriteFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer, int nNumberOfBytesToWrite,
		                                    IntPtr lpNumberOfBytesWritten, IntPtr lpOverlapped) {
			void* pointer1 = lpBuffer.ToPointer();
			int* pointer2 = (int*) lpNumberOfBytesWritten.ToPointer();
			Kernel32.OVERLAPPED* pointer3 = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			return Kernel32.WriteFile(hFile, pointer1, nNumberOfBytesToWrite, pointer2, pointer3);
		}

		/// <summary>
		///     Writes data to the specified file or input/output (I/O) device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operation. For a similar function designed
		///         solely for asynchronous operation, see WriteFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the file or I/O device (for example, a file, file stream, physical disk, volume, console buffer, tape
		///     drive, socket, communications resource, mailslot, or pipe).
		///     <para>
		///         The hFile parameter must have been created with the write access. For more information, see Generic Access
		///         Rights and File Security and Access Rights.
		///     </para>
		///     <para>
		///         For asynchronous write operations, hFile can be any handle opened with the CreateFile function using the
		///         FILE_FLAG_OVERLAPPED flag or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer containing the data to be written to the file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the write operation. The caller must not use this buffer
		///         until the write operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToWrite">
		///     The number of bytes to be written to the file or device.
		///     <para>
		///         A value of zero specifies a null write operation. The behavior of a null write operation depends on the
		///         underlying file system or communications technology.
		///     </para>
		/// </param>
		/// <param name="lpNumberOfBytesWritten">
		///     A pointer to the variable that receives the number of bytes written when using a synchronous hFile parameter.
		///     WriteFile sets this value to zero before doing any work or error checking. Use <see langword="null" />
		///     for this parameter if this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be NULL only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise this parameter can be NULL.
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start writing to the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		///     <para>
		///         To write to the end of file, specify both the Offset and OffsetHigh members of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" />
		///         structure as 0xFFFFFFFF. This is functionally equivalent to previously calling the CreateFile function to open
		///         hFile using FILE_APPEND_DATA access.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the write operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		public static unsafe bool WriteFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer, int nNumberOfBytesToWrite,
		                                    ref int? lpNumberOfBytesWritten, IntPtr lpOverlapped) {
			void* pointer1 = lpBuffer.ToPointer();
			int num1 = lpNumberOfBytesWritten.HasValue ? lpNumberOfBytesWritten.Value : 0;
			Kernel32.OVERLAPPED* pointer2 = (Kernel32.OVERLAPPED*) lpOverlapped.ToPointer();
			int num2 = Kernel32.WriteFile(hFile, pointer1, nNumberOfBytesToWrite,
				lpNumberOfBytesWritten.HasValue ? &num1 : (int*) null, pointer2)
				? 1
				: 0;
			if (!lpNumberOfBytesWritten.HasValue)
				return num2 != 0;
			lpNumberOfBytesWritten = new int?(num1);
			return num2 != 0;
		}

		/// <summary>
		///     Writes data to the specified file or input/output (I/O) device.
		///     <para>
		///         This function is designed for both synchronous and asynchronous operation. For a similar function designed
		///         solely for asynchronous operation, see WriteFileEx.
		///     </para>
		/// </summary>
		/// <param name="hFile">
		///     A handle to the file or I/O device (for example, a file, file stream, physical disk, volume, console buffer, tape
		///     drive, socket, communications resource, mailslot, or pipe).
		///     <para>
		///         The hFile parameter must have been created with the write access. For more information, see Generic Access
		///         Rights and File Security and Access Rights.
		///     </para>
		///     <para>
		///         For asynchronous write operations, hFile can be any handle opened with the CreateFile function using the
		///         FILE_FLAG_OVERLAPPED flag or a socket handle returned by the socket or accept function.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">
		///     A pointer to the buffer containing the data to be written to the file or device.
		///     <para>
		///         This buffer must remain valid for the duration of the write operation. The caller must not use this buffer
		///         until the write operation is completed.
		///     </para>
		/// </param>
		/// <param name="nNumberOfBytesToWrite">
		///     The number of bytes to be written to the file or device.
		///     <para>
		///         A value of zero specifies a null write operation. The behavior of a null write operation depends on the
		///         underlying file system or communications technology.
		///     </para>
		/// </param>
		/// <param name="lpNumberOfBytesWritten">
		///     A pointer to the variable that receives the number of bytes written when using a synchronous hFile parameter.
		///     WriteFile sets this value to zero before doing any work or error checking. Use <see langword="null" />
		///     for this parameter if this is an asynchronous operation to avoid potentially erroneous results.
		///     <para>
		///         This parameter can be NULL only when the <paramref name="lpOverlapped" /> parameter is not
		///         <see langword="null" />.
		///     </para>
		/// </param>
		/// <param name="lpOverlapped">
		///     A pointer to an <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure is required if the hFile parameter was opened with
		///     FILE_FLAG_OVERLAPPED, otherwise this parameter can be NULL.
		///     <para>
		///         For an hFile that supports byte offsets, if you use this parameter you must specify a byte offset at which to
		///         start writing to the file or device. This offset is specified by setting the Offset and OffsetHigh members of
		///         the <see cref="T:PInvoke.Kernel32.OVERLAPPED" /> structure. For an hFile that does not support byte offsets, Offset and OffsetHigh
		///         are ignored.
		///     </para>
		///     <para>
		///         To write to the end of file, specify both the Offset and OffsetHigh members of the <see cref="T:PInvoke.Kernel32.OVERLAPPED" />
		///         structure as 0xFFFFFFFF. This is functionally equivalent to previously calling the CreateFile function to open
		///         hFile using FILE_APPEND_DATA access.
		///     </para>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value is <see langword="true" />.
		///     <para>
		///         If the function fails, or is completing asynchronously, the return value is <see langword="false" />. To get
		///         extended error information, call the GetLastError function.
		///     </para>
		///     <para>
		///         Note: The <see cref="M:PInvoke.Kernel32.GetLastError" /> code <see cref="F:PInvoke.Win32ErrorCode.ERROR_IO_PENDING" /> is not a failure;
		///         it designates the write operation is pending completion asynchronously.
		///     </para>
		/// </returns>
		public static unsafe bool WriteFile(Kernel32.SafeObjectHandle hFile, void* lpBuffer, int nNumberOfBytesToWrite,
		                                    ref int? lpNumberOfBytesWritten, Kernel32.OVERLAPPED* lpOverlapped) {
			int num1 = lpNumberOfBytesWritten.HasValue ? lpNumberOfBytesWritten.Value : 0;
			int num2 = Kernel32.WriteFile(hFile, lpBuffer, nNumberOfBytesToWrite,
				lpNumberOfBytesWritten.HasValue ? &num1 : (int*) null, lpOverlapped)
				? 1
				: 0;
			if (!lpNumberOfBytesWritten.HasValue)
				return num2 != 0;
			lpNumberOfBytesWritten = new int?(num1);
			return num2 != 0;
		}

		/// <summary>Creates or opens a named or unnamed mutex object.</summary>
		/// <param name="lpMutexAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure. If this parameter is NULL, the handle cannot be inherited by child processes.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a security descriptor for the new mutex. If <paramref name="lpMutexAttributes" /> is NULL, the mutex gets a default security descriptor. The ACLs in the default security descriptor for a mutex come from the primary or impersonation token of the creator. For more information, see Synchronization Object Security and Access Rights.
		/// </param>
		/// <param name="bInitialOwner">
		/// If this value is TRUE and the caller created the mutex, the calling thread obtains initial ownership of the mutex object. Otherwise, the calling thread does not obtain ownership of the mutex. To determine if the caller created the mutex, see the Return Values section.
		/// </param>
		/// <param name="lpName">
		/// The name of the mutex object. The name is limited to MAX_PATH characters. Name comparison is case sensitive.
		/// If lpName matches the name of an existing named mutex object, this function requests the MUTEX_ALL_ACCESS access right. In this case, the bInitialOwner parameter is ignored because it has already been set by the creating process. If the lpMutexAttributes parameter is not NULL, it determines whether the handle can be inherited, but its security-descriptor member is ignored.
		/// If lpName is NULL, the mutex object is created without a name.
		/// If lpName matches the name of an existing event, semaphore, waitable timer, job, or file-mapping object, the function fails and the GetLastError function returns ERROR_INVALID_HANDLE. This occurs because these objects share the same namespace.
		/// The name can have a "Global\" or "Local\" prefix to explicitly create the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\). For more information, see Kernel Object Namespaces. Fast user switching is implemented using Terminal Services sessions. Kernel object names must follow the guidelines outlined for Terminal Services so that applications can support multiple users.
		/// The object can be created in a private namespace. For more information, see Object Namespaces.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly created mutex object.
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// If the mutex is a named mutex and the object existed before this function call, the return value is a handle to the existing object, GetLastError returns ERROR_ALREADY_EXISTS, bInitialOwner is ignored, and the calling thread is not granted ownership. However, if the caller has limited access rights, the function will fail with ERROR_ACCESS_DENIED and the caller should use the OpenMutex function.
		/// </returns>
		public static unsafe Kernel32.SafeObjectHandle CreateMutex(IntPtr lpMutexAttributes,
		                                                           [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner,
		                                                           string lpName) {
			return Kernel32.CreateMutex((Kernel32.SECURITY_ATTRIBUTES*) lpMutexAttributes.ToPointer(), bInitialOwner,
				lpName);
		}

		/// <summary>Creates or opens a named or unnamed mutex object.</summary>
		/// <param name="lpMutexAttributes">
		/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure. If this parameter is NULL, the handle cannot be inherited by child processes.
		/// The <see cref="F:PInvoke.Kernel32.SECURITY_ATTRIBUTES.lpSecurityDescriptor" /> member of the structure specifies a security descriptor for the new mutex. If <paramref name="lpMutexAttributes" /> is NULL, the mutex gets a default security descriptor. The ACLs in the default security descriptor for a mutex come from the primary or impersonation token of the creator. For more information, see Synchronization Object Security and Access Rights.
		/// </param>
		/// <param name="bInitialOwner">
		/// If this value is TRUE and the caller created the mutex, the calling thread obtains initial ownership of the mutex object. Otherwise, the calling thread does not obtain ownership of the mutex. To determine if the caller created the mutex, see the Return Values section.
		/// </param>
		/// <param name="lpName">
		/// The name of the mutex object. The name is limited to MAX_PATH characters. Name comparison is case sensitive.
		/// If lpName matches the name of an existing named mutex object, this function requests the MUTEX_ALL_ACCESS access right. In this case, the bInitialOwner parameter is ignored because it has already been set by the creating process. If the lpMutexAttributes parameter is not NULL, it determines whether the handle can be inherited, but its security-descriptor member is ignored.
		/// If lpName is NULL, the mutex object is created without a name.
		/// If lpName matches the name of an existing event, semaphore, waitable timer, job, or file-mapping object, the function fails and the GetLastError function returns ERROR_INVALID_HANDLE. This occurs because these objects share the same namespace.
		/// The name can have a "Global\" or "Local\" prefix to explicitly create the object in the global or session namespace. The remainder of the name can contain any character except the backslash character (\). For more information, see Kernel Object Namespaces. Fast user switching is implemented using Terminal Services sessions. Kernel object names must follow the guidelines outlined for Terminal Services so that applications can support multiple users.
		/// The object can be created in a private namespace. For more information, see Object Namespaces.
		/// </param>
		/// <returns>
		/// If the function succeeds, the return value is a handle to the newly created mutex object.
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// If the mutex is a named mutex and the object existed before this function call, the return value is a handle to the existing object, GetLastError returns ERROR_ALREADY_EXISTS, bInitialOwner is ignored, and the calling thread is not granted ownership. However, if the caller has limited access rights, the function will fail with ERROR_ACCESS_DENIED and the caller should use the OpenMutex function.
		/// </returns>
		public static unsafe Kernel32.SafeObjectHandle CreateMutex(Kernel32.SECURITY_ATTRIBUTES? lpMutexAttributes,
		                                                           [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner,
		                                                           string lpName) {
			Kernel32.SECURITY_ATTRIBUTES securityAttributes = lpMutexAttributes.HasValue
				? lpMutexAttributes.Value
				: new Kernel32.SECURITY_ATTRIBUTES();
			return Kernel32.CreateMutex(
				lpMutexAttributes.HasValue ? &securityAttributes : (Kernel32.SECURITY_ATTRIBUTES*) null, bInitialOwner,
				lpName);
		}

		/// <summary>
		/// Retrieves the current system date and time. The system time is expressed in Coordinated Universal Time (UTC).
		/// To retrieve the current system date and time in local time, use the GetLocalTime function.
		/// </summary>
		/// <param name="lpSystemTime">
		/// A pointer to a SYSTEMTIME structure to receive the current system date and time.
		/// The lpSystemTime parameter must not be NULL. Using NULL will result in an access violation.
		/// </param>
		public static unsafe void GetSystemTime(IntPtr lpSystemTime) {
			Kernel32.GetSystemTime((Kernel32.SYSTEMTIME*) lpSystemTime.ToPointer());
		}

		/// <summary>
		/// Retrieves the current system date and time. The system time is expressed in Coordinated Universal Time (UTC).
		/// To retrieve the current system date and time in local time, use the GetLocalTime function.
		/// </summary>
		/// <param name="lpSystemTime">
		/// A pointer to a SYSTEMTIME structure to receive the current system date and time.
		/// The lpSystemTime parameter must not be NULL. Using NULL will result in an access violation.
		/// </param>
		public static unsafe void GetSystemTime(out Kernel32.SYSTEMTIME lpSystemTime) {
			fixed (Kernel32.SYSTEMTIME* lpSystemTime1 = &lpSystemTime)
				Kernel32.GetSystemTime(lpSystemTime1);
		}

		/// <summary>
		/// Formats a message string. The function requires a message definition as input. The message definition can come from a buffer passed into the function. It can come from a message table resource in an already-loaded module. Or the caller can ask the function to search the system's message table resource(s) for the message definition. The function finds the message definition in a message table resource based on a message identifier and a language identifier. The function copies the formatted message text to an output buffer, processing any embedded insert sequences if requested.
		/// </summary>
		/// <param name="dwFlags">
		/// The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
		/// The <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ARGUMENT_ARRAY" /> flag is always added
		/// and the <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER" /> flag is always suppressed by this helper method
		/// </param>
		/// <param name="lpSource">
		/// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="dwFlags" /> parameter.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE" />: A handle to the module that contains the message table to search.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />: Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.
		/// If neither of these flags is set in dwFlags, then lpSource is ignored.
		/// </param>
		/// <param name="dwMessageId">
		/// The message identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// </param>
		/// <param name="dwLanguageId">
		/// The language identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only.If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND.If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:
		/// Language neutral
		/// Thread LANGID, based on the thread's locale value
		/// User default LANGID, based on the user's default locale value
		/// System default LANGID, based on the system default locale value
		/// US English
		/// If FormatMessage does not locate a message for any of the preceding LANGIDs, it returns any language message string that is present.If that fails, it returns ERROR_RESOURCE_LANG_NOT_FOUND.
		/// </param>
		/// <param name="Arguments">
		/// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.
		/// The interpretation of each value depends on the formatting information associated with the insert in the message definition.The default is to treat each value as a pointer to a null-terminated string.
		/// By default, the Arguments parameter is of type va_list*, which is a language- and implementation-specific data type for describing a variable number of arguments.The state of the va_list argument is undefined upon return from the function.To use the va_list again, destroy the variable argument list pointer using va_end and reinitialize it with va_start.
		/// If you do not have a pointer of type va_list*, then specify the FORMAT_MESSAGE_ARGUMENT_ARRAY flag and pass a pointer to an array of DWORD_PTR values; those values are input to the message formatted as the insert values.Each insert must have a corresponding element in the array.
		/// </param>
		/// <param name="maxAllowedBufferSize">The maximum size of the returned string. If exceeded, <c>null</c> is returned.</param>
		/// <returns>
		/// If the function succeeds, the return value is the number of TCHARs stored in the output buffer, excluding the terminating null character.
		/// If the function fails, the return value is zero. To get extended error information, call <see cref="M:PInvoke.Kernel32.GetLastError" />.
		/// </returns>
		public static unsafe string FormatMessage(Kernel32.FormatMessageFlags dwFlags, IntPtr lpSource, int dwMessageId,
		                                          int dwLanguageId, IntPtr[] Arguments, int maxAllowedBufferSize) {
			void* pointer = lpSource.ToPointer();
			return Kernel32.FormatMessage(dwFlags, pointer, dwMessageId, dwLanguageId, Arguments, maxAllowedBufferSize);
		}

		/// <summary>Writes data synchronously to the specified file or input/output (I/O) device.</summary>
		/// <param name="hFile">
		///     A handle to the file or I/O device (for example, a file, file stream, physical disk, volume, console buffer, tape
		///     drive, socket, communications resource, mailslot, or pipe).
		///     <para>
		///         The hFile parameter must have been created with the write access. For more information, see Generic Access
		///         Rights and File Security and Access Rights.
		///     </para>
		/// </param>
		/// <param name="lpBuffer">A pointer to the buffer containing the data to be written to the file or device.</param>
		/// <param name="nNumberOfBytesToWrite">
		///     The number of bytes to be written to the file or device.
		///     <para>
		///         A value of zero specifies a null write operation. The behavior of a null write operation depends on the
		///         underlying file system or communications technology.
		///     </para>
		/// </param>
		/// <returns>The number of bytes written.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if the native method return false (Write failed).</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hFile" /> is <see langword="null" />.</exception>
		public static unsafe int WriteFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer,
		                                   int nNumberOfBytesToWrite) {
			void* pointer = lpBuffer.ToPointer();
			return Kernel32.WriteFile(hFile, pointer, nNumberOfBytesToWrite);
		}

		/// <summary>Reads data synchronously from the specified file or input/output (I/O) device.</summary>
		/// <param name="hFile">
		///     A handle to the device (for example, a file, file stream, physical disk, volume, console buffer,
		///     tape drive, socket, communications resource, mailslot, or pipe).
		///     <para>The hFile parameter must have been created with read access.</para>
		/// </param>
		/// <param name="lpBuffer">A pointer to the buffer that receives the data read from a file or device.</param>
		/// <param name="nNumberOfBytesToRead">The maximum number of bytes to be read.</param>
		/// <returns>The number of bytes read.</returns>
		/// <exception cref="T:PInvoke.Win32Exception">Thrown if the native method return false (Read failed).</exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="hFile" /> is <see langword="null" />.</exception>
		public static unsafe int ReadFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer, int nNumberOfBytesToRead) {
			void* pointer = lpBuffer.ToPointer();
			return Kernel32.ReadFile(hFile, pointer, nNumberOfBytesToRead);
		}

		/// <summary>
		/// Tries to get the error message text using the supplied buffer.
		/// </summary>
		/// <param name="flags">
		/// The formatting options, and how to interpret the lpSource parameter. The low-order byte of dwFlags specifies how the function handles line breaks in the output buffer. The low-order byte can also specify the maximum width of a formatted output line.
		/// </param>
		/// <param name="source">
		/// The location of the message definition. The type of this parameter depends upon the settings in the <paramref name="flags" /> parameter.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE" />: A handle to the module that contains the message table to search.
		/// If <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />: Pointer to a string that consists of unformatted message text. It will be scanned for inserts and formatted accordingly.
		/// If neither of these flags is set in dwFlags, then lpSource is ignored.
		/// </param>
		/// <param name="messageId">
		/// The message identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// </param>
		/// <param name="languageId">
		/// The language identifier for the requested message. This parameter is ignored if dwFlags includes <see cref="F:PInvoke.Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_STRING" />.
		/// If you pass a specific LANGID in this parameter, FormatMessage will return a message for that LANGID only.If the function cannot find a message for that LANGID, it sets Last-Error to ERROR_RESOURCE_LANG_NOT_FOUND.If you pass in zero, FormatMessage looks for a message for LANGIDs in the following order:
		/// Language neutral
		/// Thread LANGID, based on the thread's locale value
		/// User default LANGID, based on the user's default locale value
		/// System default LANGID, based on the system default locale value
		/// US English
		/// If FormatMessage does not locate a message for any of the preceding LANGIDs, it returns any language message string that is present.If that fails, it returns ERROR_RESOURCE_LANG_NOT_FOUND.
		/// </param>
		/// <param name="sb">The buffer to use for acquiring the message.</param>
		/// <param name="arguments">
		/// An array of values that are used as insert values in the formatted message. A %1 in the format string indicates the first value in the Arguments array; a %2 indicates the second argument; and so on.
		/// The interpretation of each value depends on the formatting information associated with the insert in the message definition.The default is to treat each value as a pointer to a null-terminated string.
		/// By default, the Arguments parameter is of type va_list*, which is a language- and implementation-specific data type for describing a variable number of arguments.The state of the va_list argument is undefined upon return from the function.To use the va_list again, destroy the variable argument list pointer using va_end and reinitialize it with va_start.
		/// If you do not have a pointer of type va_list*, then specify the FORMAT_MESSAGE_ARGUMENT_ARRAY flag and pass a pointer to an array of DWORD_PTR values; those values are input to the message formatted as the insert values.Each insert must have a corresponding element in the array.
		/// </param>
		/// <param name="errorMsg">Receives the resulting error message.</param>
		/// <returns><c>true</c> if the attempt is successful; <c>false</c> otherwise.</returns>
		private static unsafe bool TryGetErrorMessage(Kernel32.FormatMessageFlags flags, IntPtr source, int messageId,
		                                              int languageId, StringBuilder sb, IntPtr[] arguments,
		                                              out string errorMsg) {
			void* pointer = source.ToPointer();
			return Kernel32.TryGetErrorMessage(flags, pointer, messageId, languageId, sb, arguments, out errorMsg);
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct ACL {
			public byte AclRevision;
			public byte Sbz1;
			public ushort AclSize;
			public ushort AceCount;
			public ushort Sbz2;
		}

		/// <summary>The character attributes for console input/output.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum CharacterAttributesFlags : ushort {
			None = 0,
			FOREGROUND_BLUE = 1,
			FOREGROUND_GREEN = 2,
			FOREGROUND_RED = 4,
			FOREGROUND_INTENSITY = 8,
			BACKGROUND_BLUE = 16, // 0x0010
			BACKGROUND_GREEN = 32, // 0x0020
			BACKGROUND_RED = 64, // 0x0040
			BACKGROUND_INTENSITY = 128, // 0x0080
			COMMON_LVB_LEADING_BYTE = 256, // 0x0100
			COMMON_LVB_TRAILING_BYTE = 512, // 0x0200
			COMMON_LVB_GRID_HORIZONTAL = 1024, // 0x0400
			COMMON_LVB_GRID_LVERTICAL = 2048, // 0x0800
			COMMON_LVB_GRID_RVERTICAL = 4096, // 0x1000
			COMMON_LVB_REVERSE_VIDEO = 16384, // 0x4000
			COMMON_LVB_UNDERSCORE = 32768, // 0x8000
		}

		/// <summary>
		/// Specifies a Unicode or ANSI character and its attributes.
		/// This structure is used by console functions to read from and write to a console screen buffer.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct CHAR_INFO {
			/// <summary>A union of the Unicode and Ascii encodings.</summary>
			public Kernel32.CHAR_INFO_ENCODING Char;

			/// <summary>
			/// The character attributes. This member can be zero or any combination of the <see cref="T:PInvoke.Kernel32.CharacterAttributesFlags" /> values
			/// </summary>
			public Kernel32.CharacterAttributesFlags Attributes;
		}

		/// <summary>A union of the Unicode and Ascii encodings.</summary>
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct CHAR_INFO_ENCODING {
			/// <summary>Unicode character of a screen buffer character cell.</summary>
			[FieldOffset(0)] public char UnicodeChar;

			/// <summary>ANSI character of a screen buffer character cell.</summary>
			[FieldOffset(0)] public byte AsciiChar;
		}

		/// <summary>
		/// Designates the console buffer mode on the <see cref="M:PInvoke.Kernel32.GetConsoleMode(System.IntPtr,PInvoke.Kernel32.ConsoleBufferModes@)" /> and <see cref="M:PInvoke.Kernel32.SetConsoleMode(System.IntPtr,PInvoke.Kernel32.ConsoleBufferModes)" /> functions
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ConsoleBufferModes {
			ENABLE_PROCESSED_INPUT = 1,
			ENABLE_PROCESSED_OUTPUT = ENABLE_PROCESSED_INPUT, // 0x00000001
			ENABLE_LINE_INPUT = 2,
			ENABLE_WRAP_AT_EOL_OUTPUT = ENABLE_LINE_INPUT, // 0x00000002
			ENABLE_ECHO_INPUT = 4,
			ENABLE_VIRTUAL_TERMINAL_PROCESSING = ENABLE_ECHO_INPUT, // 0x00000004
			ENABLE_WINDOW_INPUT = 8,
			DISABLE_NEWLINE_AUTO_RETURN = ENABLE_WINDOW_INPUT, // 0x00000008
			ENABLE_MOUSE_INPUT = 16, // 0x00000010
			ENABLE_LVB_GRID_WORLDWIDE = ENABLE_MOUSE_INPUT, // 0x00000010
			ENABLE_INSERT_MODE = 32, // 0x00000020
			ENABLE_QUICK_EDIT_MODE = 64, // 0x00000040
		}

		/// <summary>
		/// Designates the console display mode on the <see cref="M:PInvoke.Kernel32.GetConsoleDisplayMode(PInvoke.Kernel32.ConsoleDisplayMode@)" /> functions
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ConsoleDisplayMode {
			CONSOLE_FULLSCREEN_MODE = 1,
			CONSOLE_WINDOWED_MODE = 2,
		}

		/// <summary>
		/// Designates how to create the screen buffer on the <see cref="M:PInvoke.Kernel32.CreateConsoleScreenBuffer(PInvoke.Kernel32.ACCESS_MASK,PInvoke.Kernel32.FileShare,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.ConsoleScreenBufferFlag,System.Void*)" /> function
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ConsoleScreenBufferFlag {
			None,
			CONSOLE_TEXTMODE_BUFFER,
		}

		/// <summary>
		/// The console selection indicator for <see cref="F:PInvoke.Kernel32.CONSOLE_SELECTION_INFO.dwFlags" />
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ConsoleSelectionFlags {
			CONSOLE_MOUSE_DOWN = 8,
			CONSOLE_MOUSE_SELECTION = 4,
			CONSOLE_NO_SELECTION = 0,
			CONSOLE_SELECTION_IN_PROGRESS = 1,
			CONSOLE_SELECTION_NOT_EMPTY = 2,
		}

		/// <summary>Contains information about a console screen buffer.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct CONSOLE_SCREEN_BUFFER_INFO {
			/// <summary>
			/// A <see cref="T:PInvoke.COORD" /> structure that contains the size of the console screen buffer, in character columns and rows.
			/// </summary>
			public COORD dwSize;

			/// <summary>
			/// A <see cref="T:PInvoke.COORD" /> structure that contains the column and row coordinates of the cursor in the console screen buffer.
			/// </summary>
			public COORD dwCursorPosition;

			/// <summary>
			/// The attributes of the characters written to a screen buffer by the WriteFile and WriteConsole functions,
			/// or echoed to a screen buffer by the ReadFile and ReadConsole functions.
			/// </summary>
			public Kernel32.CharacterAttributesFlags wAttributes;

			/// <summary>
			/// A <see cref="T:PInvoke.SMALL_RECT" /> structure that contains the console screen buffer coordinates of the upper-left and lower-right corners of the display window.
			/// </summary>
			public SMALL_RECT srWindow;

			/// <summary>
			/// A <see cref="T:PInvoke.COORD" /> structure that contains the maximum size of the console window, in character columns and rows,
			/// given the current screen buffer size and font and the screen size.
			/// </summary>
			public COORD dwMaximumWindowSize;
		}

		/// <summary>Contains information for a console selection.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct CONSOLE_SELECTION_INFO {
			/// <summary>The selection indicator.</summary>
			public Kernel32.ConsoleSelectionFlags dwFlags;

			/// <summary>
			/// A <see cref="T:PInvoke.COORD" /> structure that specifies the selection anchor, in characters.
			/// </summary>
			public COORD dwSelectionAnchor;

			/// <summary>
			/// A <see cref="T:PInvoke.SMALL_RECT" /> structure that specifies the selection rectangle.
			/// </summary>
			public SMALL_RECT srSelection;
		}

		/// <summary>Describes the state of the control keys.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ControlKeyStates {
			CAPSLOCK_ON = 128, // 0x00000080
			ENHANCED_KEY = 256, // 0x00000100
			LEFT_ALT_PRESSED = 2,
			LEFT_CTRL_PRESSED = 8,
			NUMLOCK_ON = 32, // 0x00000020
			RIGHT_ALT_PRESSED = 1,
			RIGHT_CTRL_PRESSED = 4,
			SCROLLLOCK_ON = 64, // 0x00000040
			SHIFT_PRESSED = 16, // 0x00000010
		}

		/// <summary>
		/// Values that are passed to the <see cref="T:PInvoke.Kernel32.HandlerRoutine" /> callback.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ControlType {
			CTRL_C_EVENT = 0,
			CTRL_BREAK_EVENT = 1,
			CTRL_CLOSE_EVENT = 2,
			CTRL_LOGOFF_EVENT = 5,
			CTRL_SHUTDOWN_EVENT = 6,
		}

		/// <summary>
		/// Flags that may be passed to the <see cref="M:PInvoke.Kernel32.CreateProcess(System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" /> function.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum CreateProcessFlags {
			None = 0,
			CREATE_BREAKAWAY_FROM_JOB = 16777216, // 0x01000000
			CREATE_DEFAULT_ERROR_MODE = 67108864, // 0x04000000
			CREATE_NEW_CONSOLE = 16, // 0x00000010
			CREATE_NEW_PROCESS_GROUP = 512, // 0x00000200
			CREATE_NO_WINDOW = 134217728, // 0x08000000
			CREATE_PROTECTED_PROCESS = 262144, // 0x00040000
			CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 33554432, // 0x02000000
			CREATE_SEPARATE_WOW_VDM = 2048, // 0x00000800
			CREATE_SHARED_WOW_VDM = 4096, // 0x00001000
			CREATE_SUSPENDED = 4,
			CREATE_UNICODE_ENVIRONMENT = 1024, // 0x00000400
			DEBUG_ONLY_THIS_PROCESS = 2,
			DEBUG_PROCESS = 1,
			DETACHED_PROCESS = 8,
			EXTENDED_STARTUPINFO_PRESENT = 524288, // 0x00080000
			INHERIT_PARENT_AFFINITY = 65536, // 0x00010000
			NORMAL_PRIORITY_CLASS = 32, // 0x00000020
			IDLE_PRIORITY_CLASS = 64, // 0x00000040
			HIGH_PRIORITY_CLASS = 128, // 0x00000080
			REALTIME_PRIORITY_CLASS = 256, // 0x00000100
			CREATE_FORCEDOS = 8192, // 0x00002000
			BELOW_NORMAL_PRIORITY_CLASS = 16384, // 0x00004000
			ABOVE_NORMAL_PRIORITY_CLASS = 32768, // 0x00008000
			PROCESS_MODE_BACKGROUND_BEGIN = 1048576, // 0x00100000
			PROCESS_MODE_BACKGROUND_END = 2097152, // 0x00200000
			PROFILE_USER = 268435456, // 0x10000000
			PROFILE_KERNEL = 536870912, // 0x20000000
			PROFILE_SERVER = 1073741824, // 0x40000000
		}

		/// <summary>
		/// The portions of the system to be included in the snapshot for <see cref="M:PInvoke.Kernel32.CreateToolhelp32Snapshot(PInvoke.Kernel32.CreateToolhelp32SnapshotFlags,System.Int32)" />.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum CreateToolhelp32SnapshotFlags : uint {
			TH32CS_INHERIT = 2147483648, // 0x80000000
			TH32CS_SNAPHEAPLIST = 1,
			TH32CS_SNAPMODULE = 8,
			TH32CS_SNAPMODULE32 = 16, // 0x00000010
			TH32CS_SNAPPROCESS = 2,
			TH32CS_SNAPTHREAD = 4,

			TH32CS_SNAPALL =
				TH32CS_SNAPTHREAD | TH32CS_SNAPPROCESS | TH32CS_SNAPMODULE | TH32CS_SNAPHEAPLIST, // 0x0000000F
		}

		/// <summary>The thread's execution requirements.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum EXECUTION_STATE : uint {
			None = 0,
			ES_AWAYMODE_REQUIRED = 64, // 0x00000040
			ES_CONTINUOUS = 2147483648, // 0x80000000
			ES_DISPLAY_REQUIRED = 2,
			ES_SYSTEM_REQUIRED = 1,

			[Obsolete(
				"This value is not supported. If ES_USER_PRESENT is combined with other esFlags values, the call will fail and none of the specified states will be set.")]
			ES_USER_PRESENT = 4,
		}

		/// <summary>
		/// Describes a focus event in a console <see cref="T:PInvoke.Kernel32.INPUT_RECORD" /> structure.
		/// </summary>
		/// <remarks>
		/// These events are used internally and should be ignored.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct FOCUS_EVENT_RECORD {
			/// <summary>Reserved.</summary>
			[MarshalAs(UnmanagedType.Bool)] public bool bSetFocus;
		}

		/// <summary>
		/// Flags that may be passed to the <see cref="M:PInvoke.Kernel32.GetModuleHandleEx(PInvoke.Kernel32.GetModuleHandleExFlags,System.String,PInvoke.Kernel32.SafeLibraryHandle@)" /> function.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum GetModuleHandleExFlags {
			None = 0,
			GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = 4,
			GET_MODULE_HANDLE_EX_FLAG_PIN = 1,
			GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT = 2,
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.Kernel32.GlobalAlloc(PInvoke.Kernel32.GlobalAllocFlags,System.IntPtr)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum GlobalAllocFlags : uint {
			GMEM_FIXED = 0,
			GMEM_MOVEABLE = 2,
			GMEM_NOCOMPACT = 16, // 0x00000010
			GMEM_NODISCARD = 32, // 0x00000020
			GMEM_ZEROINIT = 64, // 0x00000040
			GPTR = GMEM_ZEROINIT, // 0x00000040
			GHND = GPTR | GMEM_MOVEABLE, // 0x00000042
			GMEM_MODIFY = 128, // 0x00000080
			GMEM_DISCARDABLE = 256, // 0x00000100
			GMEM_NOT_BANKED = 4096, // 0x00001000
			GMEM_LOWER = GMEM_NOT_BANKED, // 0x00001000
			GMEM_DDESHARE = 8192, // 0x00002000
			GMEM_SHARE = GMEM_DDESHARE, // 0x00002000
			GMEM_NOTIFY = 16384, // 0x00004000
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.Kernel32.GlobalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.GlobalReAllocFlags)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum GlobalReAllocFlags {
			GMEM_MODIFY = 128, // 0x00000080
			GMEM_MOVEABLE = 2,
			GMEM_ZEROINIT = 64, // 0x00000040
		}

		/// <summary>Represents a group of icons as stored in a resource</summary>
		/// <remarks>
		/// The structure is followed by <see cref="F:PInvoke.Kernel32.GRPICONDIR.idCount" /> <see cref="T:PInvoke.Kernel32.GRPICONDIRENTRY" /> entries.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
		public struct GRPICONDIR {
			/// <summary>Reserved (must be 0)</summary>
			public ushort idReserved;

			/// <summary>Resource type (1 for icons)</summary>
			public ushort idType;

			/// <summary>How many images?</summary>
			public ushort idCount;
		}

		/// <summary>Represents an icon as stored in a resource</summary>
		[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
		public struct GRPICONDIRENTRY {
			/// <summary>Width, in pixels, of the image</summary>
			public byte bWidth;

			/// <summary>Height, in pixels, of the image</summary>
			public byte bHeight;

			/// <summary>Number of colors in image (0 if &gt;= 8bpp)</summary>
			public byte bColorCount;

			/// <summary>Reserved</summary>
			public byte bReserved;

			/// <summary>Color Planes</summary>
			public ushort wPlanes;

			/// <summary>Bits per pixel</summary>
			public ushort wBitCount;

			/// <summary>How many bytes in this resource?</summary>
			public uint dwBytesInRes;

			/// <summary>The ID</summary>
			public ushort nId;
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.Kernel32.HeapAlloc(System.IntPtr,PInvoke.Kernel32.HeapAllocFlags,System.IntPtr)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum HeapAllocFlags : uint {
			None = 0,
			HEAP_GENERATE_EXCEPTIONS = 4,
			HEAP_NO_SERIALIZE = 1,
			HEAP_ZERO_MEMORY = 8,
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.Kernel32.HeapFree(System.IntPtr,PInvoke.Kernel32.HeapFreeFlags,System.Void*)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum HeapFreeFlags {
			None = 0,
			HEAP_NO_SERIALIZE = 1,
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.Kernel32.HeapReAlloc(System.IntPtr,PInvoke.Kernel32.HeapReAllocFlags,System.Void*,System.IntPtr)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum HeapReAllocFlags {
			None = 0,
			HEAP_GENERATE_EXCEPTIONS = 4,
			HEAP_NO_SERIALIZE = 1,
			HEAP_REALLOC_IN_PLACE_ONLY = 16, // 0x00000010
			HEAP_ZERO_MEMORY = 8,
		}

		/// <summary>
		/// Represents a group of icons as stored in a '.ico' file
		/// </summary>
		/// <remarks>
		/// The structure is followed by <see cref="F:PInvoke.Kernel32.ICONDIR.idCount" /> <see cref="T:PInvoke.Kernel32.ICONDIRENTRY" /> entries.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
		public struct ICONDIR {
			/// <summary>Reserved (must be 0)</summary>
			public ushort idReserved;

			/// <summary>Resource type (1 for icons)</summary>
			public ushort idType;

			/// <summary>How many images?</summary>
			public ushort idCount;
		}

		/// <summary>Represents an icon as stored in a '.ico' file</summary>
		[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
		public struct ICONDIRENTRY {
			/// <summary>Width, in pixels, of the image</summary>
			public byte bWidth;

			/// <summary>Height, in pixels, of the image</summary>
			public byte bHeight;

			/// <summary>Number of colors in image (0 if &gt;= 8bpp)</summary>
			public byte bColorCount;

			/// <summary>Reserved</summary>
			public byte bReserved;

			/// <summary>Color Planes</summary>
			public ushort wPlanes;

			/// <summary>Bits per pixel</summary>
			public ushort wBitCount;

			/// <summary>How many bytes in this resource</summary>
			public uint dwBytesInRes;

			/// <summary>
			/// Location (relative to the start of the ICO file) of the actual image data.
			/// </summary>
			public uint dwImageOffset;
		}

		/// <summary>
		/// A handle to the type of input event and the event record stored in the <see cref="F:PInvoke.Kernel32.INPUT_RECORD.Event" /> member.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum InputEventTypeFlag : short {
			KEY_EVENT = 1,
			MOUSE_EVENT = 2,
			WINDOW_BUFFER_SIZE_EVENT = 4,
			MENU_EVENT = 8,
			FOCUS_EVENT = 16, // 0x0010
		}

		/// <summary>
		/// The input event information. The format of this member depends on the event type specified by the <see cref="F:PInvoke.Kernel32.INPUT_RECORD.EventType" /> member.
		/// </summary>
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct INPUT_EVENT_RECORD {
			/// <summary>Structure with information about a keyboard event.</summary>
			[FieldOffset(0)] public Kernel32.KEY_EVENT_RECORD KeyEvent;

			/// <summary>
			/// Structure with information about a mouse movement or button press event.
			/// </summary>
			[FieldOffset(0)] public Kernel32.MOUSE_EVENT_RECORD MouseEvent;

			/// <summary>
			/// Structure with information about the new size of the console screen buffer.
			/// </summary>
			[FieldOffset(0)] public Kernel32.WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

			/// <summary>
			/// These events are used internally and should be ignored.
			/// </summary>
			[FieldOffset(0)] public Kernel32.MENU_EVENT_RECORD MenuEvent;

			/// <summary>
			/// These events are used internally and should be ignored.
			/// </summary>
			[FieldOffset(0)] public Kernel32.FOCUS_EVENT_RECORD FocusEvent;
		}

		/// <summary>
		/// Describes an input event in the console input buffer.
		/// These records can be read from the input buffer by using the <see cref="M:PInvoke.Kernel32.ReadConsoleInput(System.IntPtr,PInvoke.Kernel32.INPUT_RECORD@,System.Int32,System.Int32@)" /> or <see cref="M:PInvoke.Kernel32.PeekConsoleInput(System.IntPtr,PInvoke.Kernel32.INPUT_RECORD@,System.Int32,System.Int32@)" /> function,
		/// or written to the input buffer by using the <see cref="M:PInvoke.Kernel32.WriteConsoleInput(System.IntPtr,PInvoke.Kernel32.INPUT_RECORD*,System.Int32,System.Int32*)" /> function.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct INPUT_RECORD {
			/// <summary>
			/// A handle to the type of input event and the event record stored in the <see cref="F:PInvoke.Kernel32.INPUT_RECORD.Event" /> member.
			/// </summary>
			public Kernel32.InputEventTypeFlag EventType;

			/// <summary>
			/// The event information. The format of this member depends on the event type specified by the <see cref="F:PInvoke.Kernel32.INPUT_RECORD.EventType" /> member.
			/// </summary>
			public Kernel32.INPUT_EVENT_RECORD Event;
		}

		/// <summary>
		/// Contains I/O accounting information for a process or a job object.
		/// For a job object, the counters include all operations performed by all processes that have ever been associated with the job,
		/// in addition to all processes currently associated with the job.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct IO_COUNTERS {
			/// <summary>The number of read operations performed.</summary>
			public ulong ReadOperationCount;

			/// <summary>The number of write operations performed.</summary>
			public ulong WriteOperationCount;

			/// <summary>
			/// The number of I/O operations performed, other than read and write operations.
			/// </summary>
			public ulong OtherOperationCount;

			/// <summary>The number of bytes read.</summary>
			public ulong ReadTransferCount;

			/// <summary>The number of bytes written.</summary>
			public ulong WriteTransferCount;

			/// <summary>
			/// The number of bytes transferred during operations other than read and write operations.
			/// </summary>
			public ulong OtherTransferCount;
		}

		/// <summary>The information class for the limits to be set.</summary>
		/// <remarks>
		/// Taken from https://msdn.microsoft.com/en-us/library/windows/desktop/ms686216(v=vs.85).aspx
		/// </remarks>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum JOBOBJECTINFOCLASS {
			JobObjectBasicLimitInformation = 2,
			JobObjectBasicUIRestrictions = 4,
			JobObjectSecurityLimitInformation = 5,
			JobObjectEndOfJobTimeInformation = 6,
			JobObjectAssociateCompletionPortInformation = 7,
			JobObjectExtendedLimitInformation = 9,
			JobObjectGroupInformation = 11, // 0x0000000B
			JobObjectNotificationLimitInformation = 12, // 0x0000000C
			JobObjectGroupInformationEx = 14, // 0x0000000E
			JobObjectCpuRateControlInformation = 15, // 0x0000000F
			JobObjectNetRateControlInformation = 32, // 0x00000020
			JobObjectNotificationLimitInformation2 = 34, // 0x00000022
			JobObjectLimitViolationInformation2 = 35, // 0x00000023
		}

		/// <summary>Contains basic limit information for a job object.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct JOBOBJECT_BASIC_LIMIT_INFORMATION {
			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_PROCESS_TIME, this member is the per-process user-mode execution time limit, in 100-nanosecond ticks. Otherwise, this member is ignored.
			/// </summary>
			public long PerProcessUserTimeLimit;

			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_JOB_TIME, this member is the per-job user-mode execution time limit, in 100-nanosecond ticks. Otherwise, this member is ignored.
			/// </summary>
			public long PerJobUserTimeLimit;

			/// <summary>
			/// The limit flags that are in effect. This member is a bitfield that determines whether other structure members are used.
			/// </summary>
			public Kernel32.JOB_OBJECT_LIMIT_FLAGS LimitFlags;

			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_WORKINGSET, this member is the minimum working set size in bytes for each process associated with the job. Otherwise, this member is ignored.
			/// </summary>
			public UIntPtr MinWorkingSetSize;

			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_WORKINGSET, this member is the maximum working set size in bytes for each process associated with the job. Otherwise, this member is ignored.
			/// </summary>
			public UIntPtr MaxWorkingSetSize;

			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_ACTIVE_PROCESS, this member is the active process limit for the job. Otherwise, this member is ignored.
			/// </summary>
			public uint ActiveProcessLimit;

			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_AFFINITY, this member is the processor affinity for all processes associated with the job. Otherwise, this member is ignored.
			/// </summary>
			public UIntPtr Affinity;

			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_PRIORITY_CLASS, this member is the priority class for all processes associated with the job. Otherwise, this member is ignored.
			/// </summary>
			public uint PriorityClass;

			/// <summary>
			/// If LimitFlags specifies JOB_OBJECT_LIMIT_SCHEDULING_CLASS, this member is the scheduling class for all processes associated with the job. Otherwise, this member is ignored.
			/// </summary>
			public uint SchedulingClass;
		}

		/// <summary>The scheduling policy for CPU rate control.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum JOBOBJECT_CPU_RATE_CONTROL_FLAGS : uint {
			JOB_OBJECT_CPU_RATE_CONTROL_ENABLE = 1,
			JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED = 2,
			JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP = 4,
			JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY = 8,
			JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE = 16, // 0x00000010
		}

		/// <summary>
		/// Contains CPU rate control information for a job object. This structure is used by the SetInformationJobObject and QueryInformationJobObject functions with the JobObjectCpuRateControlInformation information class.
		/// </summary>
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct JOBOBJECT_CPU_RATE_CONTROL_INFORMATION {
			/// <summary>The scheduling policy for CPU rate control.</summary>
			[FieldOffset(0)] public Kernel32.JOBOBJECT_CPU_RATE_CONTROL_FLAGS ControlFlags;

			/// <summary>
			/// Specifies the portion of processor cycles that the threads in a job object can use during each scheduling interval, as the number of cycles per 10,000 cycles. If the ControlFlags member specifies JOB_OBJECT_CPU_RATE_WEIGHT_BASED or JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE, this member is not used.
			/// </summary>
			[FieldOffset(4)] public uint CpuRate;

			/// <summary>
			/// If the ControlFlags member specifies JOB_OBJECT_CPU_RATE_WEIGHT_BASED, this member specifies the scheduling weight of the job object, which determines the share of processor time given to the job relative to other workloads on the processor.
			/// </summary>
			[FieldOffset(4)] public uint Weight;

			/// <summary>
			/// Specifies the minimum portion of the processor cycles that the threads in a job object can reserve during each scheduling interval. Specify this rate as a percentage times 100. For example, to set a minimum rate of 50%, specify 50 times 100, or 5,000.
			/// </summary>
			[FieldOffset(4)] public ushort MinRate;

			/// <summary>
			/// Specifies the maximum portion of processor cycles that the threads in a job object can use during each scheduling interval. Specify this rate as a percentage times 100. For example, to set a maximum rate of 50%, specify 50 times 100, or 5,000.
			/// </summary>
			[FieldOffset(6)] public ushort MaxRate;
		}

		/// <summary>
		/// Contains basic and extended limit information for a job object.
		/// </summary>
		/// <remarks>
		/// <para>The system tracks the value of PeakProcessMemoryUsed and PeakJobMemoryUsed constantly. This allows you know the peak memory usage of each job. You can use this information to establish a memory limit using the JOB_OBJECT_LIMIT_PROCESS_MEMORY or JOB_OBJECT_LIMIT_JOB_MEMORY value.</para>
		/// <para>Note that the job memory and process memory limits are very similar in operation, but they are independent. You could set a job-wide limit of 100 MB with a per-process limit of 10 MB. In this scenario, no single process could commit more than 10 MB, and the set of processes associated with a job could never exceed 100 MB.</para>
		/// <para>To register for notifications that a job has exceeded its peak memory limit while allowing processes to continue to commit memory, use the SetInformationJobObject function with the JobObjectNotificationLimitInformation information class.</para>
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION {
			/// <summary>
			/// A <see cref="T:PInvoke.Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION" /> structure that contains basic limit information.
			/// </summary>
			public Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;

			/// <summary>Reserved.</summary>
			public Kernel32.IO_COUNTERS IoInfo;

			/// <summary>
			/// If the <see cref="F:PInvoke.Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION.LimitFlags" /> member of the <see cref="T:PInvoke.Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION" /> structure specifies the
			/// <see cref="F:PInvoke.Kernel32.JOB_OBJECT_LIMIT_FLAGS.JOB_OBJECT_LIMIT_PROCESS_MEMORY" /> value, this member specifies the limit for the virtual memory that can be committed by a process.
			/// Otherwise, this member is ignored.
			/// </summary>
			public UIntPtr ProcessMemoryLimit;

			/// <summary>
			/// If the <see cref="F:PInvoke.Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION.LimitFlags" /> member of the <see cref="T:PInvoke.Kernel32.JOBOBJECT_BASIC_LIMIT_INFORMATION" /> structure specifies the
			/// <see cref="F:PInvoke.Kernel32.JOB_OBJECT_LIMIT_FLAGS.JOB_OBJECT_LIMIT_JOB_MEMORY" /> value,
			/// this member specifies the limit for the virtual memory that can be committed for the job. Otherwise, this member is ignored.
			/// </summary>
			public UIntPtr JobMemoryLimit;

			/// <summary>
			/// The peak memory used by any process ever associated with the job.
			/// </summary>
			public UIntPtr PeakProcessMemoryUsed;

			/// <summary>
			/// The peak memory usage of all processes currently associated with the job.
			/// </summary>
			public UIntPtr PeakJobMemoryUsed;
		}

		/// <summary>The limit flags that are in effect</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum JOB_OBJECT_LIMIT_FLAGS {
			JOB_OBJECT_LIMIT_WORKINGSET = 1,
			JOB_OBJECT_LIMIT_PROCESS_TIME = 2,
			JOB_OBJECT_LIMIT_JOB_TIME = 4,
			JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 8,
			JOB_OBJECT_LIMIT_AFFINITY = 16, // 0x00000010
			JOB_OBJECT_LIMIT_PRIORITY_CLASS = 32, // 0x00000020
			JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 64, // 0x00000040
			JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 128, // 0x00000080
			JOB_OBJECT_LIMIT_PROCESS_MEMORY = 256, // 0x00000100
			JOB_OBJECT_LIMIT_JOB_MEMORY = 512, // 0x00000200
			JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 1024, // 0x00000400
			JOB_OBJECT_LIMIT_BREAKAWAY_OK = 2048, // 0x00000800
			JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 4096, // 0x00001000
			JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 8192, // 0x00002000
			JOB_OBJECT_LIMIT_SUBSET_AFFINITY = 16384, // 0x00004000
		}

		/// <summary>
		/// Describes a keyboard input event in a console <see cref="T:PInvoke.Kernel32.INPUT_RECORD" /> structure.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct KEY_EVENT_RECORD {
			/// <summary>
			/// If the key is pressed, this member is TRUE. Otherwise, this member is FALSE (the key is released).
			/// </summary>
			[MarshalAs(UnmanagedType.Bool)] public bool bKeyDown;

			/// <summary>
			/// The repeat count, which indicates that a key is being held down.
			/// For example, when a key is held down, you might get five events with this member equal to 1,
			/// one event with this member equal to 5, or multiple events with this member greater than or equal to 1.
			/// </summary>
			public ushort wRepeatCount;

			/// <summary>
			/// A virtual-key code that identifies the given key in a device-independent manner.
			/// Possible values are in the User32.VirtualKey enum.
			/// </summary>
			public ushort wVirtualKeyCode;

			/// <summary>
			/// The virtual scan code of the given key that represents the device-dependent value generated by the keyboard hardware.
			/// Possible values are in the User32.ScanCode enum.
			/// </summary>
			public ushort wVirtualScanCode;

			/// <summary>A union of the Unicode and Ascii encodings.</summary>
			public Kernel32.CHAR_INFO_ENCODING uChar;

			/// <summary>The state of the control keys.</summary>
			public Kernel32.ControlKeyStates dwControlKeyState;
		}

		/// <summary>Represents a language identifier.</summary>
		[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
		public struct LANGID {
			internal const ushort PrimaryLanguageMask = 1023;
			internal const ushort SubLanguageMask = 64512;
			internal const int SubLanguageShift = 10;
			internal ushort data;

			public LANGID(ushort usLanguages) {
				this.data = usLanguages;
			}

			public Kernel32.LANGID.PrimaryLanguage Primary {
				get { return (Kernel32.LANGID.PrimaryLanguage) ((uint) this.data & 1023U); }
				set {
					this.data = (ushort) ((Kernel32.LANGID.PrimaryLanguage) ((int) this.data & 64512) |
						value & (Kernel32.LANGID.PrimaryLanguage) 1023);
				}
			}

			public Kernel32.LANGID.SubLanguage Sub {
				get { return (Kernel32.LANGID.SubLanguage) (((int) this.data & 64512) >> 10); }
				set { this.data = (ushort) ((int) this.data & 1023 | (int) value << 10 & 64512); }
			}

			public ushort Data {
				get { return this.data; }
				set { this.data = value; }
			}

			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum PrimaryLanguage : ushort {
				LANG_NEUTRAL = 0,
				LANG_USER_DEFAULT = 0,
				LANG_ARABIC = 1,
				LANG_BULGARIAN = 2,
				LANG_SYSTEM_DEFAULT = 2,
				LANG_CATALAN = 3,
				LANG_VALENCIAN = 3,
				LANG_CHINESE = 4,
				LANG_CHINESE_SIMPLIFIED = 4,
				LANG_CHINESE_TRADITIONAL = 4,
				LANG_CZECH = 5,
				LANG_DANISH = 6,
				LANG_GERMAN = 7,
				LANG_GREEK = 8,
				LANG_ENGLISH = 9,
				LANG_SPANISH = 10, // 0x000A
				LANG_FINNISH = 11, // 0x000B
				LANG_FRENCH = 12, // 0x000C
				LANG_HEBREW = 13, // 0x000D
				LANG_HUNGARIAN = 14, // 0x000E
				LANG_ICELANDIC = 15, // 0x000F
				LANG_ITALIAN = 16, // 0x0010
				LANG_JAPANESE = 17, // 0x0011
				LANG_KOREAN = 18, // 0x0012
				LANG_DUTCH = 19, // 0x0013
				LANG_NORWEGIAN = 20, // 0x0014
				LANG_POLISH = 21, // 0x0015
				LANG_PORTUGUESE = 22, // 0x0016
				LANG_ROMANSH = 23, // 0x0017
				LANG_ROMANIAN = 24, // 0x0018
				LANG_RUSSIAN = 25, // 0x0019
				LANG_BOSNIAN = 26, // 0x001A
				LANG_CROATIAN = 26, // 0x001A
				LANG_SERBIAN = 26, // 0x001A
				LANG_SLOVAK = 27, // 0x001B
				LANG_ALBANIAN = 28, // 0x001C
				LANG_SWEDISH = 29, // 0x001D
				LANG_THAI = 30, // 0x001E
				LANG_TURKISH = 31, // 0x001F
				LANG_URDU = 32, // 0x0020
				LANG_INDONESIAN = 33, // 0x0021
				LANG_UKRAINIAN = 34, // 0x0022
				LANG_BELARUSSIAN = 35, // 0x0023
				LANG_SLOVENIAN = 36, // 0x0024
				LANG_ESTONIAN = 37, // 0x0025
				LANG_LATVIAN = 38, // 0x0026
				LANG_LITHUANIAN = 39, // 0x0027
				LANG_TAJIK = 40, // 0x0028
				LANG_PERSIAN = 41, // 0x0029
				LANG_VIETNAMESE = 42, // 0x002A
				LANG_ARMENIAN = 43, // 0x002B
				LANG_AZERI = 44, // 0x002C
				LANG_BASQUE = 45, // 0x002D
				LANG_LOWER_SORBIAN = 46, // 0x002E
				LANG_UPPER_SORBIAN = 46, // 0x002E
				LANG_MACEDONIAN = 47, // 0x002F
				LANG_TSWANA = 50, // 0x0032
				LANG_XHOSA = 52, // 0x0034
				LANG_ZULU = 53, // 0x0035
				LANG_AFRIKAANS = 54, // 0x0036
				LANG_GEORGIAN = 55, // 0x0037
				LANG_FAEROESE = 56, // 0x0038
				LANG_HINDI = 57, // 0x0039
				LANG_MALTESE = 58, // 0x003A
				LANG_SAMI = 59, // 0x003B
				LANG_IRISH = 60, // 0x003C
				LANG_MALAY = 62, // 0x003E
				LANG_KAZAK = 63, // 0x003F
				LANG_KYRGYZ = 64, // 0x0040
				LANG_SWAHILI = 65, // 0x0041
				LANG_TURKMEN = 66, // 0x0042
				LANG_UZBEK = 67, // 0x0043
				LANG_TATAR = 68, // 0x0044
				LANG_BANGLA = 69, // 0x0045
				LANG_PUNJABI = 70, // 0x0046
				LANG_GUJARATI = 71, // 0x0047
				LANG_ORIYA = 72, // 0x0048
				LANG_TAMIL = 73, // 0x0049
				LANG_TELUGU = 74, // 0x004A
				LANG_KANNADA = 75, // 0x004B
				LANG_MALAYALAM = 76, // 0x004C
				LANG_ASSAMESE = 77, // 0x004D
				LANG_MARATHI = 78, // 0x004E
				LANG_SANSKRIT = 79, // 0x004F
				LANG_MONGOLIAN = 80, // 0x0050
				LANG_TIBETAN = 81, // 0x0051
				LANG_WELSH = 82, // 0x0052
				LANG_KHMER = 83, // 0x0053
				LANG_LAO = 84, // 0x0054
				LANG_GALICIAN = 86, // 0x0056
				LANG_KONKANI = 87, // 0x0057
				LANG_MANIPURI = 88, // 0x0058
				LANG_SINDHI = 89, // 0x0059
				LANG_SYRIAC = 90, // 0x005A
				LANG_SINHALESE = 91, // 0x005B
				LANG_CHEROKEE = 92, // 0x005C
				LANG_INUKTITUT = 93, // 0x005D
				LANG_AMHARIC = 94, // 0x005E
				LANG_TAMAZIGHT = 95, // 0x005F
				LANG_KASHMIRI = 96, // 0x0060
				LANG_NEPALI = 97, // 0x0061
				LANG_FRISIAN = 98, // 0x0062
				LANG_PASHTO = 99, // 0x0063
				LANG_FILIPINO = 100, // 0x0064
				LANG_DIVEHI = 101, // 0x0065
				LANG_PULAR = 103, // 0x0067
				LANG_HAUSA = 104, // 0x0068
				LANG_YORUBA = 106, // 0x006A
				LANG_QUECHUA = 107, // 0x006B
				LANG_SOTHO = 108, // 0x006C
				LANG_BASHKIR = 109, // 0x006D
				LANG_LUXEMBOURGISH = 110, // 0x006E
				LANG_GREENLANDIC = 111, // 0x006F
				LANG_IGBO = 112, // 0x0070
				LANG_TIGRIGNA = 115, // 0x0073
				LANG_TIGRINYA = 115, // 0x0073
				LANG_HAWAIIAN = 117, // 0x0075
				LANG_YI = 120, // 0x0078
				LANG_MAPUDUNGUN = 122, // 0x007A
				LANG_MOHAWK = 124, // 0x007C
				LANG_BRETON = 126, // 0x007E
				LANG_INVARIANT = 127, // 0x007F
				LANG_UIGHUR = 128, // 0x0080
				LANG_MAORI = 129, // 0x0081
				LANG_OCCITAN = 130, // 0x0082
				LANG_CORSICAN = 131, // 0x0083
				LANG_ALSATIAN = 132, // 0x0084
				LANG_SAKHA = 133, // 0x0085
				LANG_KICHE = 134, // 0x0086
				LANG_KINYARWANDA = 135, // 0x0087
				LANG_WOLOF = 136, // 0x0088
				LANG_DARI = 140, // 0x008C
				LANG_CENTRAL_KURDISH = 146, // 0x0092
			}

			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum SubLanguage : ushort {
				SUBLANG_NEUTRAL = 0,
				SUBLANG_AFRIKAANS_SOUTH_AFRICA = 1,
				SUBLANG_ALBANIAN_ALBANIA = 1,
				SUBLANG_ALSATIAN_FRANCE = 1,
				SUBLANG_AMHARIC_ETHIOPIA = 1,
				SUBLANG_ARABIC_SAUDI_ARABIA = 1,
				SUBLANG_ARMENIAN_ARMENIA = 1,
				SUBLANG_ASSAMESE_INDIA = 1,
				SUBLANG_AZERI_LATIN = 1,
				SUBLANG_BANGLA_INDIA = 1,
				SUBLANG_BASHKIR_RUSSIA = 1,
				SUBLANG_BASQUE_BASQUE = 1,
				SUBLANG_BELARUSIAN_BELARUS = 1,
				SUBLANG_BRETON_FRANCE = 1,
				SUBLANG_BULGARIAN_BULGARIA = 1,
				SUBLANG_CATALAN_CATALAN = 1,
				SUBLANG_CENTRAL_KURDISH_IRAQ = 1,
				SUBLANG_CHEROKEE_CHEROKEE = 1,
				SUBLANG_CHINESE_TRADITIONAL = 1,
				SUBLANG_CORSICAN_FRANCE = 1,
				SUBLANG_CROATIAN_CROATIA = 1,
				SUBLANG_CZECH_CZECH_REPUBLIC = 1,
				SUBLANG_DANISH_DENMARK = 1,
				SUBLANG_DARI_AFGHANISTAN = 1,
				SUBLANG_DEFAULT = 1,
				SUBLANG_DIVEHI_MALDIVES = 1,
				SUBLANG_DUTCH = 1,
				SUBLANG_ENGLISH_US = 1,
				SUBLANG_ESTONIAN_ESTONIA = 1,
				SUBLANG_FAEROESE_FAROE_ISLANDS = 1,
				SUBLANG_FILIPINO_PHILIPPINES = 1,
				SUBLANG_FINNISH_FINLAND = 1,
				SUBLANG_FRENCH = 1,
				SUBLANG_FRISIAN_NETHERLANDS = 1,
				SUBLANG_GALICIAN_GALICIAN = 1,
				SUBLANG_GEORGIAN_GEORGIA = 1,
				SUBLANG_GERMAN = 1,
				SUBLANG_GREEK_GREECE = 1,
				SUBLANG_GREENLANDIC_GREENLAND = 1,
				SUBLANG_GUJARATI_INDIA = 1,
				SUBLANG_HAUSA_NIGERIA_LATIN = 1,
				SUBLANG_HAWAIIAN_US = 1,
				SUBLANG_HEBREW_ISRAEL = 1,
				SUBLANG_HINDI_INDIA = 1,
				SUBLANG_HUNGARIAN_HUNGARY = 1,
				SUBLANG_ICELANDIC_ICELAND = 1,
				SUBLANG_IGBO_NIGERIA = 1,
				SUBLANG_INDONESIAN_INDONESIA = 1,
				SUBLANG_INUKTITUT_CANADA = 1,
				SUBLANG_ITALIAN = 1,
				SUBLANG_JAPANESE_JAPAN = 1,
				SUBLANG_KANNADA_INDIA = 1,
				SUBLANG_KAZAK_KAZAKHSTAN = 1,
				SUBLANG_KHMER_CAMBODIA = 1,
				SUBLANG_KICHE_GUATEMALA = 1,
				SUBLANG_KINYARWANDA_RWANDA = 1,
				SUBLANG_KONKANI_INDIA = 1,
				SUBLANG_KOREAN = 1,
				SUBLANG_KYRGYZ_KYRGYZSTAN = 1,
				SUBLANG_LAO_LAO = 1,
				SUBLANG_LATVIAN_LATVIA = 1,
				SUBLANG_LITHUANIAN_LITHUANIA = 1,
				SUBLANG_LUXEMBOURGISH_LUXEMBOURG = 1,
				SUBLANG_MACEDONIAN_MACEDONIA = 1,
				SUBLANG_MALAYALAM_INDIA = 1,
				SUBLANG_MALAY_MALAYSIA = 1,
				SUBLANG_MALTESE_MALTA = 1,
				SUBLANG_MAORI_NEW_ZEALAND = 1,
				SUBLANG_MAPUDUNGUN_CHILE = 1,
				SUBLANG_MARATHI_INDIA = 1,
				SUBLANG_MOHAWK_MOHAWK = 1,
				SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA = 1,
				SUBLANG_NEPALI_NEPAL = 1,
				SUBLANG_NORWEGIAN_BOKMAL = 1,
				SUBLANG_OCCITAN_FRANCE = 1,
				SUBLANG_ORIYA_INDIA = 1,
				SUBLANG_PASHTO_AFGHANISTAN = 1,
				SUBLANG_PERSIAN_IRAN = 1,
				SUBLANG_POLISH_POLAND = 1,
				SUBLANG_PORTUGUESE_BRAZILIAN = 1,
				SUBLANG_PUNJABI_INDIA = 1,
				SUBLANG_QUECHUA_BOLIVIA = 1,
				SUBLANG_ROMANIAN_ROMANIA = 1,
				SUBLANG_ROMANSH_SWITZERLAND = 1,
				SUBLANG_RUSSIAN_RUSSIA = 1,
				SUBLANG_SAKHA_RUSSIA = 1,
				SUBLANG_SAMI_NORTHERN_NORWAY = 1,
				SUBLANG_SANSKRIT_INDIA = 1,
				SUBLANG_SERBIAN_CROATIA = 1,
				SUBLANG_SINDHI_INDIA = 1,
				SUBLANG_SINHALESE_SRI_LANKA = 1,
				SUBLANG_SLOVAK_SLOVAKIA = 1,
				SUBLANG_SLOVENIAN_SLOVENIA = 1,
				SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA = 1,
				SUBLANG_SPANISH = 1,
				SUBLANG_SWAHILI = 1,
				SUBLANG_SWEDISH = 1,
				SUBLANG_SWEDISH_SWEDEN = 1,
				SUBLANG_SYRIAC = 1,
				SUBLANG_TAJIK_TAJIKISTAN = 1,
				SUBLANG_TAMIL_INDIA = 1,
				SUBLANG_TATAR_RUSSIA = 1,
				SUBLANG_TELUGU_INDIA = 1,
				SUBLANG_THAI_THAILAND = 1,
				SUBLANG_TIBETAN_PRC = 1,
				SUBLANG_TIGRINYA_ETHIOPIA = 1,
				SUBLANG_TSWANA_SOUTH_AFRICA = 1,
				SUBLANG_TURKISH_TURKEY = 1,
				SUBLANG_TURKMEN_TURKMENISTAN = 1,
				SUBLANG_UIGHUR_PRC = 1,
				SUBLANG_UKRAINIAN_UKRAINE = 1,
				SUBLANG_UPPER_SORBIAN_GERMANY = 1,
				SUBLANG_URDU_PAKISTAN = 1,
				SUBLANG_UZBEK_LATIN = 1,
				SUBLANG_VIETNAMESE_VIETNAM = 1,
				SUBLANG_WELSH_UNITED_KINGDOM = 1,
				SUBLANG_WOLOF_SENEGAL = 1,
				SUBLANG_XHOSA_SOUTH_AFRICA = 1,
				SUBLANG_YI_PRC = 1,
				SUBLANG_YORUBA_NIGERIA = 1,
				SUBLANG_ZULU_SOUTH_AFRICA = 1,
				SUBLANG_ARABIC_IRAQ = 2,
				SUBLANG_AZERI_CYRILLIC = 2,
				SUBLANG_BANGLA_BANGLADESH = 2,
				SUBLANG_CHINESE_SIMPLIFIED = 2,
				SUBLANG_DUTCH_BELGIAN = 2,
				SUBLANG_ENGLISH_UK = 2,
				SUBLANG_FRENCH_BELGIAN = 2,
				SUBLANG_GERMAN_SWISS = 2,
				SUBLANG_INUKTITUT_CANADA_LATIN = 2,
				SUBLANG_IRISH_IRELAND = 2,
				SUBLANG_ITALIAN_SWISS = 2,
				SUBLANG_KASHMIRI_INDIA = 2,
				SUBLANG_KASHMIRI_SASIA = 2,
				SUBLANG_LOWER_SORBIAN_GERMANY = 2,
				SUBLANG_MALAY_BRUNEI_DARUSSALAM = 2,
				SUBLANG_MONGOLIAN_PRC = 2,
				SUBLANG_NEPALI_INDIA = 2,
				SUBLANG_NORWEGIAN_NYNORSK = 2,
				SUBLANG_PORTUGUESE = 2,
				SUBLANG_PULAR_SENEGAL = 2,
				SUBLANG_PUNJABI_PAKISTAN = 2,
				SUBLANG_QUECHUA_ECUADOR = 2,
				SUBLANG_SAMI_NORTHERN_SWEDEN = 2,
				SUBLANG_SERBIAN_LATIN = 2,
				SUBLANG_SINDHI_AFGHANISTAN = 2,
				SUBLANG_SINDHI_PAKISTAN = 2,
				SUBLANG_SPANISH_MEXICAN = 2,
				SUBLANG_SWEDISH_FINLAND = 2,
				SUBLANG_SYS_DEFAULT = 2,
				SUBLANG_TAMAZIGHT_ALGERIA_LATIN = 2,
				SUBLANG_TAMIL_SRI_LANKA = 2,
				SUBLANG_TIGRIGNA_ERITREA = 2,
				SUBLANG_TIGRINYA_ERITREA = 2,
				SUBLANG_TSWANA_BOTSWANA = 2,
				SUBLANG_URDU_INDIA = 2,
				SUBLANG_UZBEK_CYRILLIC = 2,
				SUBLANG_VALENCIAN_VALENCIA = 2,
				SUBLANG_ARABIC_EGYPT = 3,
				SUBLANG_CHINESE_HONGKONG = 3,
				SUBLANG_CUSTOM_DEFAULT = 3,
				SUBLANG_ENGLISH_AUS = 3,
				SUBLANG_FRENCH_CANADIAN = 3,
				SUBLANG_GERMAN_AUSTRIAN = 3,
				SUBLANG_QUECHUA_PERU = 3,
				SUBLANG_SAMI_NORTHERN_FINLAND = 3,
				SUBLANG_SERBIAN_CYRILLIC = 3,
				SUBLANG_SPANISH_MODERN = 3,
				SUBLANG_ARABIC_LIBYA = 4,
				SUBLANG_CHINESE_SINGAPORE = 4,
				SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN = 4,
				SUBLANG_CUSTOM_UNSPECIFIED = 4,
				SUBLANG_ENGLISH_CAN = 4,
				SUBLANG_FRENCH_SWISS = 4,
				SUBLANG_GERMAN_LUXEMBOURG = 4,
				SUBLANG_SAMI_LULE_NORWAY = 4,
				SUBLANG_SPANISH_GUATEMALA = 4,
				SUBLANG_ARABIC_ALGERIA = 5,
				SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN = 5,
				SUBLANG_CHINESE_MACAU = 5,
				SUBLANG_ENGLISH_NZ = 5,
				SUBLANG_FRENCH_LUXEMBOURG = 5,
				SUBLANG_GERMAN_LIECHTENSTEIN = 5,
				SUBLANG_SAMI_LULE_SWEDEN = 5,
				SUBLANG_SPANISH_COSTA_RICA = 5,
				SUBLANG_UI_CUSTOM_DEFAULT = 5,
				SUBLANG_ARABIC_MOROCCO = 6,
				SUBLANG_ENGLISH_EIRE = 6,
				SUBLANG_ENGLISH_IRELAND = 6,
				SUBLANG_FRENCH_MONACO = 6,
				SUBLANG_SAMI_SOUTHERN_NORWAY = 6,
				SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN = 6,
				SUBLANG_SPANISH_PANAMA = 6,
				SUBLANG_ARABIC_TUNISIA = 7,
				SUBLANG_ENGLISH_SOUTH_AFRICA = 7,
				SUBLANG_SAMI_SOUTHERN_SWEDEN = 7,
				SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 7,
				SUBLANG_SPANISH_DOMINICAN_REPUBLIC = 7,
				SUBLANG_ARABIC_OMAN = 8,
				SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 8,
				SUBLANG_ENGLISH_JAMAICA = 8,
				SUBLANG_SAMI_SKOLT_FINLAND = 8,
				SUBLANG_SPANISH_VENEZUELA = 8,
				SUBLANG_ARABIC_YEMEN = 9,
				SUBLANG_ENGLISH_CARIBBEAN = 9,
				SUBLANG_SAMI_INARI_FINLAND = 9,
				SUBLANG_SPANISH_COLOMBIA = 9,
				SUBLANG_ARABIC_SYRIA = 10, // 0x000A
				SUBLANG_ENGLISH_BELIZE = 10, // 0x000A
				SUBLANG_SPANISH_PERU = 10, // 0x000A
				SUBLANG_ARABIC_JORDAN = 11, // 0x000B
				SUBLANG_ENGLISH_TRINIDAD = 11, // 0x000B
				SUBLANG_SPANISH_ARGENTINA = 11, // 0x000B
				SUBLANG_ARABIC_LEBANON = 12, // 0x000C
				SUBLANG_ENGLISH_ZIMBABWE = 12, // 0x000C
				SUBLANG_SPANISH_ECUADOR = 12, // 0x000C
				SUBLANG_ARABIC_KUWAIT = 13, // 0x000D
				SUBLANG_ENGLISH_PHILIPPINES = 13, // 0x000D
				SUBLANG_SPANISH_CHILE = 13, // 0x000D
				SUBLANG_ARABIC_UAE = 14, // 0x000E
				SUBLANG_SPANISH_URUGUAY = 14, // 0x000E
				SUBLANG_ARABIC_BAHRAIN = 15, // 0x000F
				SUBLANG_SPANISH_PARAGUAY = 15, // 0x000F
				SUBLANG_ARABIC_QATAR = 16, // 0x0010
				SUBLANG_ENGLISH_INDIA = 16, // 0x0010
				SUBLANG_SPANISH_BOLIVIA = 16, // 0x0010
				SUBLANG_ENGLISH_MALAYSIA = 17, // 0x0011
				SUBLANG_SPANISH_EL_SALVADOR = 17, // 0x0011
				SUBLANG_ENGLISH_SINGAPORE = 18, // 0x0012
				SUBLANG_SPANISH_HONDURAS = 18, // 0x0012
				SUBLANG_SPANISH_NICARAGUA = 19, // 0x0013
				SUBLANG_SPANISH_PUERTO_RICO = 20, // 0x0014
				SUBLANG_SPANISH_US = 21, // 0x0015
			}
		}

		/// <summary>
		/// Flags that may be passed to the <see cref="M:PInvoke.Kernel32.LoadLibraryEx(System.String,System.IntPtr,PInvoke.Kernel32.LoadLibraryExFlags)" /> function.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum LoadLibraryExFlags {
			None = 0,
			DONT_RESOLVE_DLL_REFERENCES = 1,
			LOAD_IGNORE_CODE_AUTHZ_LEVEL = 16, // 0x00000010
			LOAD_LIBRARY_AS_DATAFILE = 2,
			LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 64, // 0x00000040
			LOAD_LIBRARY_AS_IMAGE_RESOURCE = 32, // 0x00000020
			LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 512, // 0x00000200
			LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 4096, // 0x00001000
			LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 256, // 0x00000100
			LOAD_LIBRARY_SEARCH_SYSTEM32 = 2048, // 0x00000800
			LOAD_LIBRARY_SEARCH_USER_DIRS = 1024, // 0x00000400
			LOAD_WITH_ALTERED_SEARCH_PATH = 8,
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.Kernel32.LocalAlloc(PInvoke.Kernel32.LocalAllocFlags,System.IntPtr)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum LocalAllocFlags {
			LMEM_FIXED = 0,
			LHND = 66, // 0x00000042
			LMEM_MOVEABLE = 2,
			LMEM_ZEROINIT = 64, // 0x00000040
			LPTR = LMEM_ZEROINIT, // 0x00000040
			NONZEROLHND = LMEM_MOVEABLE, // 0x00000002
			NONZEROLPTR = 0,
		}

		/// <summary>
		/// Flags for the <see cref="M:PInvoke.Kernel32.LocalReAlloc(System.Void*,System.IntPtr,PInvoke.Kernel32.LocalReAllocFlags)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum LocalReAllocFlags {
			LMEM_MODIFY = 128, // 0x00000080
			LMEM_MOVEABLE = 2,
			LMEM_ZEROINIT = 64, // 0x00000040
		}

		/// <summary>
		/// Describes a menu event in a console <see cref="T:PInvoke.Kernel32.INPUT_RECORD" /> structure.
		/// </summary>
		/// <remarks>
		/// These events are used internally and should be ignored.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MENU_EVENT_RECORD {
			/// <summary>Reserved.</summary>
			public uint dwCommandId;
		}

		/// <summary>
		/// Describes an entry from a list of the modules belonging to the specified process.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MODULEENTRY32 {
			/// <summary>
			/// The size of the structure, in bytes. Set automatically by the <see cref="M:PInvoke.Kernel32.MODULEENTRY32.Create" /> method.
			/// </summary>
			public int dwSize;

			/// <summary>
			/// This member is no longer used, and is always set to one.
			/// </summary>
			public int th32ModuleID;

			/// <summary>
			/// The identifier of the process whose modules are to be examined.
			/// </summary>
			public int th32ProcessID;

			/// <summary>
			/// The load count of the module, which is not generally meaningful, and usually equal to <c>0xFFFF</c>.
			/// </summary>
			public int GlblcntUsage;

			/// <summary>
			/// The load count of the module (same as <see cref="F:PInvoke.Kernel32.MODULEENTRY32.GlblcntUsage" />), which is not generally meaningful, and usually equal to <c>0xFFFF</c>.
			/// </summary>
			public int ProccntUsage;

			/// <summary>
			/// The base address of the module in the context of the owning process.
			/// </summary>
			public unsafe byte* modBaseAddr;

			/// <summary>The size of the module, in bytes.</summary>
			public uint modBaseSize;

			/// <summary>
			/// A handle to the module in the context of the owning process.
			/// </summary>
			public unsafe void* hModule;

			/// <summary>The module name.</summary>
			public unsafe fixed char szModule[256];

			/// <summary>The module path.</summary>
			public unsafe fixed char szExePath[260];

			/// <summary>
			/// Gets the name of the module, as specified by the <see cref="F:PInvoke.Kernel32.MODULEENTRY32.szModule" /> character array.
			/// </summary>
			public unsafe string Module {
				get {
					fixed (char* chPtr = &this.szModule.FixedElementField)
						return new string(chPtr);
				}
			}

			/// <summary>
			/// Gets the executable path for the module, as specified by the <see cref="F:PInvoke.Kernel32.MODULEENTRY32.szExePath" /> character array.
			/// </summary>
			public unsafe string ExePath {
				get {
					fixed (char* chPtr = &this.szExePath.FixedElementField)
						return new string(chPtr);
				}
			}

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> struct
			/// with <see cref="F:PInvoke.Kernel32.MODULEENTRY32.dwSize" /> set to the correct value.
			/// </summary>
			/// <returns>An instance of <see cref="T:PInvoke.Kernel32.MODULEENTRY32" />.</returns>
			public static Kernel32.MODULEENTRY32 Create() {
				return new Kernel32.MODULEENTRY32() {
					dwSize = Marshal.SizeOf(typeof(Kernel32.MODULEENTRY32)),
					th32ModuleID = 1
				};
			}

			/// <summary>
			/// The base address of the module in the context of the owning process.
			/// </summary>
			public unsafe IntPtr modBaseAddr_IntPtr {
				get { return new IntPtr((void*) this.modBaseAddr); }
				set { this.modBaseAddr = (byte*) value.ToPointer(); }
			}

			/// <summary>
			/// A handle to the module in the context of the owning process.
			/// </summary>
			public unsafe IntPtr hModule_IntPtr {
				get { return new IntPtr(this.hModule); }
				set { this.hModule = value.ToPointer(); }
			}
		}

		/// <summary>Describes the state of the mouse buttons.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MouseButtonStates {
			FROM_LEFT_1ST_BUTTON_PRESSED = 1,
			FROM_LEFT_2ND_BUTTON_PRESSED = 4,
			FROM_LEFT_3RD_BUTTON_PRESSED = 8,
			FROM_LEFT_4TH_BUTTON_PRESSED = 16, // 0x00000010
			RIGHTMOST_BUTTON_PRESSED = 2,
		}

		/// <summary>Describes the type of the mouse event.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum MouseEvents {
			None = 0,
			DOUBLE_CLICK = 2,
			MOUSE_HWHEELED = 8,
			MOUSE_MOVED = 1,
			MOUSE_WHEELED = 4,
		}

		/// <summary>
		/// Describes a mouse input event in a console <see cref="T:PInvoke.Kernel32.INPUT_RECORD" /> structure.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MOUSE_EVENT_RECORD {
			/// <summary>
			/// A <see cref="T:PInvoke.COORD" /> structure that contains the location of the cursor, in terms of the console screen buffer's character-cell coordinates.
			/// </summary>
			public COORD dwMousePosition;

			/// <summary>The status of the mouse buttons.</summary>
			public Kernel32.MouseButtonStates dwButtonState;

			/// <summary>The state of the control keys.</summary>
			public Kernel32.ControlKeyStates dwControlKeyState;

			/// <summary>
			/// The type of mouse event. If this value is <see cref="F:PInvoke.Kernel32.MouseEvents.None" />, it indicates a mouse button being pressed or released.
			/// </summary>
			public Kernel32.MouseEvents dwEventFlags;
		}

		/// <summary>Flags returned by <see cref="M:PInvoke.Kernel32.GetNamedPipeInfo(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.NamedPipeInfoFlags@,System.Int32@,System.Int32@,System.Int32@)" />.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum NamedPipeInfoFlags : uint {
			PIPE_CLIENT_END = 0,
			PIPE_SERVER_END = 1,
			PIPE_TYPE_BYTE = 0,
			PIPE_TYPE_MESSAGE = 4,
		}

		/// <summary>
		/// Pipe access mode used when creating a pipe using <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum PipeAccessMode : uint {
			None = 0,
			PIPE_ACCESS_DUPLEX = 3,
			PIPE_ACCESS_INBOUND = 1,
			PIPE_ACCESS_OUTBOUND = 2,
			FILE_FLAG_FIRST_PIPE_INSTANCE = 524288, // 0x00080000
			FILE_FLAG_WRITE_THROUGH = 2147483648, // 0x80000000
			FILE_FLAG_OVERLAPPED = 1073741824, // 0x40000000
			WRITE_DAC = 262144, // 0x00040000
			WRITE_OWNER = FILE_FLAG_FIRST_PIPE_INSTANCE, // 0x00080000
			ACCESS_SYSTEM_SECURITY = 16777216, // 0x01000000
		}

		/// <summary>A named pipe usage mode, used in <see cref="M:PInvoke.Kernel32.CreateNamedPipe(System.String,PInvoke.Kernel32.PipeAccessMode,PInvoke.Kernel32.PipeMode,System.Int32,System.Int32,System.Int32,System.Int32,PInvoke.Kernel32.SECURITY_ATTRIBUTES*)" />.</summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum PipeMode : uint {
			PIPE_TYPE_BYTE = 0,
			PIPE_TYPE_MESSAGE = 4,
			PIPE_READMODE_BYTE = 0,
			PIPE_READMODE_MESSAGE = 2,
			PIPE_WAIT = 0,
			PIPE_NOWAIT = 1,
			PIPE_ACCEPT_REMOTE_CLIENTS = 0,
			PIPE_REJECT_REMOTE_CLIENTS = 8,
		}

		/// <summary>
		/// Enumerates the <see cref="P:PInvoke.Kernel32.ACCESS_MASK.SpecificRights" /> that may apply to processes.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public static class ProcessAccess {
			/// <summary>Required to create a process.</summary>
			public const uint PROCESS_CREATE_PROCESS = 128;

			/// <summary>Required to create a thread.</summary>
			public const uint PROCESS_CREATE_THREAD = 2;

			/// <summary>Required to duplicate a handle using DuplicateHandle.</summary>
			public const uint PROCESS_DUP_HANDLE = 64;

			/// <summary>
			/// Required to retrieve certain information about a process, such as its token, exit code, and priority class
			/// (see OpenProcessToken).
			/// </summary>
			public const uint PROCESS_QUERY_INFORMATION = 1024;

			/// <summary>
			/// Required to retrieve certain information about a process (see GetExitCodeProcess, GetPriorityClass,
			/// IsProcessInJob, QueryFullProcessImageName). A handle that has the <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_INFORMATION" /> access right
			/// is automatically granted <see cref="F:PInvoke.Kernel32.ProcessAccess.PROCESS_QUERY_LIMITED_INFORMATION" />.
			/// </summary>
			/// <remarks>Windows Server 2003 and Windows XP:  This access right is not supported.</remarks>
			public const uint PROCESS_QUERY_LIMITED_INFORMATION = 4096;

			/// <summary>Required to set certain information about a process, such as its priority class (see SetPriorityClass).</summary>
			public const uint PROCESS_SET_INFORMATION = 512;

			/// <summary>Required to set memory limits using SetProcessWorkingSetSize.</summary>
			public const uint PROCESS_SET_QUOTA = 256;

			/// <summary>Required to suspend or resume a process.</summary>
			public const uint PROCESS_SUSPEND_RESUME = 2048;

			/// <summary>Required to terminate a process using TerminateProcess.</summary>
			public const uint PROCESS_TERMINATE = 1;

			/// <summary>
			/// Required to perform an operation on the address space of a process (see VirtualProtectEx and
			/// WriteProcessMemory).
			/// </summary>
			public const uint PROCESS_VM_OPERATION = 8;

			/// <summary>Required to read memory in a process using ReadProcessMemory.</summary>
			public const uint PROCESS_VM_READ = 16;

			/// <summary>Required to write to memory in a process using WriteProcessMemory.</summary>
			public const uint PROCESS_VM_WRITE = 32;
		}

		/// <summary>
		/// Describes an entry from a list of the processes residing in the system address space when a snapshot was taken.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct PROCESSENTRY32 {
			/// <summary>
			/// The size of the structure, in bytes. Set automatically by the <see cref="M:PInvoke.Kernel32.PROCESSENTRY32.Create" /> method.
			/// </summary>
			public int dwSize;

			/// <summary>
			/// This member is no longer used and is always set to zero.
			/// </summary>
			public int cntUsage;

			/// <summary>The process identifier.</summary>
			public int th32ProcessID;

			/// <summary>
			/// This member is no longer used and is always set to zero.
			/// </summary>
			public IntPtr th32DefaultHeapID;

			/// <summary>
			/// This member is no longer used and is always set to zero.
			/// </summary>
			public int th32ModuleID;

			/// <summary>
			/// The number of execution threads started by the process.
			/// </summary>
			public int cntThreads;

			/// <summary>
			/// The identifier of the process that created this process (its parent process).
			/// </summary>
			public int th32ParentProcessID;

			/// <summary>
			/// The base priority of any threads created by this process.
			/// </summary>
			public int pcPriClassBase;

			/// <summary>
			/// This member is no longer used, and is always set to zero.
			/// </summary>
			public uint dwFlags;

			/// <summary>
			/// The name of the executable file for the process.
			/// <para>
			/// To retrieve the full path to the executable file, call the Module32First function and check the szExePath member
			/// of the MODULEENTRY32 structure that is returned. However, if the calling process is a 32-bit process, you must call the
			/// <see cref="M:PInvoke.Kernel32.QueryFullProcessImageName(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.QueryFullProcessImageNameFlags,System.Char*,System.Int32@)" />
			/// function to retrieve the full path of the executable file for a 64-bit process.
			/// </para>
			/// </summary>
			public unsafe fixed char szExeFile[260];

			/// <summary>
			/// Gets the name of the executable file for the process, as specified by the <see cref="F:PInvoke.Kernel32.PROCESSENTRY32.szExeFile" /> character array.
			/// <para>
			/// To retrieve the full path to the executable file, call the <see cref="M:PInvoke.Kernel32.Module32First(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.MODULEENTRY32*)" /> function and check the <see cref="F:PInvoke.Kernel32.MODULEENTRY32.szExePath" /> member
			/// of the <see cref="T:PInvoke.Kernel32.MODULEENTRY32" /> structure that is returned. However, if the calling process is a 32-bit process, you must call the
			/// <see cref="M:PInvoke.Kernel32.QueryFullProcessImageName(PInvoke.Kernel32.SafeObjectHandle,PInvoke.Kernel32.QueryFullProcessImageNameFlags,System.Char*,System.Int32@)" />
			/// function to retrieve the full path of the executable file for a 64-bit process.
			/// </para>
			/// </summary>
			public unsafe string ExeFile {
				get {
					fixed (char* chPtr = &this.szExeFile.FixedElementField)
						return new string(chPtr);
				}
			}

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" /> struct
			/// with <see cref="F:PInvoke.Kernel32.PROCESSENTRY32.dwSize" /> set to the correct value.
			/// </summary>
			/// <returns>An instance of <see cref="T:PInvoke.Kernel32.PROCESSENTRY32" />.</returns>
			public static Kernel32.PROCESSENTRY32 Create() {
				return new Kernel32.PROCESSENTRY32() {
					dwSize = Marshal.SizeOf(typeof(Kernel32.PROCESSENTRY32))
				};
			}
		}

		/// <summary>
		/// Values that are passed to the <see cref="M:PInvoke.Kernel32.SetProcessShutdownParameters(System.Int32,PInvoke.Kernel32.ProcessShutdownFlags)" /> flag.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum ProcessShutdownFlags {
			None,
			SHUTDOWN_NORETRY,
		}

		/// <summary>
		/// Contains information about a newly created process and its primary thread. It is used with the <see cref="M:PInvoke.Kernel32.CreateProcess(System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" />,
		/// <see cref="M:PInvoke.Kernel32.CreateProcessAsUser(System.IntPtr,System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" />, CreateProcessWithLogonW, or CreateProcessWithTokenW function.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct PROCESS_INFORMATION {
			/// <summary>
			/// A handle to the newly created process. The handle is used to specify the process in all functions that perform operations on the process object.
			/// </summary>
			public IntPtr hProcess;

			/// <summary>
			/// A handle to the primary thread of the newly created process. The handle is used to specify the thread in all functions that perform operations on the thread object.
			/// </summary>
			public IntPtr hThread;

			/// <summary>
			/// A value that can be used to identify a process. The value is valid from the time the process is created until all handles to the process are closed and the process object is freed; at this point, the identifier may be reused.
			/// </summary>
			public int dwProcessId;

			/// <summary>
			/// A value that can be used to identify a thread. The value is valid from the time the thread is created until all handles to the thread are closed and the thread object is freed; at this point, the identifier may be reused.
			/// </summary>
			public int dwThreadId;
		}

		/// <summary>An empty struct.</summary>
		[StructLayout(LayoutKind.Sequential, Size = 1, CharSet = CharSet.Unicode)]
		public struct PROC_THREAD_ATTRIBUTE_LIST { }

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum QueryFullProcessImageNameFlags {
			None = 0,
			PROCESS_NAME_NATIVE = 1,
		}

		/// <summary>
		/// Specifies the window station, desktop, standard handles, and appearance of the main window for a process at creation time.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct STARTUPINFO {
			/// <summary>The size of this data structure.</summary>
			public int cb;

			/// <summary>Reserved; must be NULL.</summary>
			public string lpReserved;

			/// <summary>
			/// The name of the desktop, or the name of both the desktop and window station for this process. A backslash in the string indicates that the string includes both the desktop and window station names. For more information, see Thread Connection to a Desktop.
			/// </summary>
			public string lpDesktop;

			/// <summary>
			/// For console processes, this is the title displayed in the title bar if a new console window is created. If NULL, the name of the executable file is used as the window title instead. This parameter must be NULL for GUI or console processes that do not create a new console window.
			/// </summary>
			public string lpTitle;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies STARTF_USEPOSITION, this member is the x offset of the upper left corner of a window if a new window is created, in pixels. Otherwise, this member is ignored.
			/// The offset is from the upper left corner of the screen. For GUI processes, the specified position is used the first time the new process calls CreateWindow to create an overlapped window if the x parameter of CreateWindow is CW_USEDEFAULT.
			/// </summary>
			public int dwX;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies STARTF_USEPOSITION, this member is the y offset of the upper left corner of a window if a new window is created, in pixels. Otherwise, this member is ignored.
			/// The offset is from the upper left corner of the screen. For GUI processes, the specified position is used the first time the new process calls CreateWindow to create an overlapped window if the y parameter of CreateWindow is CW_USEDEFAULT.
			/// </summary>
			public int dwY;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies STARTF_USESIZE, this member is the width of the window if a new window is created, in pixels. Otherwise, this member is ignored.
			/// For GUI processes, this is used only the first time the new process calls CreateWindow to create an overlapped window if the nWidth parameter of CreateWindow is CW_USEDEFAULT.
			/// </summary>
			public int dwXSize;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies STARTF_USESIZE, this member is the height of the window if a new window is created, in pixels. Otherwise, this member is ignored.
			/// For GUI processes, this is used only the first time the new process calls CreateWindow to create an overlapped window if the nHeight parameter of CreateWindow is CW_USEDEFAULT.
			/// </summary>
			public int dwYSize;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies STARTF_USECOUNTCHARS, if a new console window is created in a console process, this member specifies the screen buffer width, in character columns. Otherwise, this member is ignored.
			/// </summary>
			public int dwXCountChars;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies STARTF_USECOUNTCHARS, if a new console window is created in a console process, this member specifies the screen buffer height, in character rows. Otherwise, this member is ignored.
			/// </summary>
			public int dwYCountChars;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies STARTF_USEFILLATTRIBUTE, this member is the initial text and background colors if a new console window is created in a console application. Otherwise, this member is ignored.
			/// This value can be any combination of the following values: FOREGROUND_BLUE, FOREGROUND_GREEN, FOREGROUND_RED, FOREGROUND_INTENSITY, BACKGROUND_BLUE, BACKGROUND_GREEN, BACKGROUND_RED, and BACKGROUND_INTENSITY. For example, the following combination of values produces red text on a white background:
			/// FOREGROUND_RED| BACKGROUND_RED| BACKGROUND_GREEN| BACKGROUND_BLUE
			/// </summary>
			public uint dwFillAttribute;

			/// <summary>
			/// A bitfield that determines whether certain STARTUPINFO members are used when the process creates a window.
			/// </summary>
			public Kernel32.StartupInfoFlags dwFlags;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESHOWWINDOW" />, this member can be any of the values that can be specified in the nCmdShow parameter for the ShowWindow function, except for SW_SHOWDEFAULT. Otherwise, this member is ignored.
			/// For GUI processes, the first time ShowWindow is called, its nCmdShow parameter is ignored wShowWindow specifies the default value. In subsequent calls to ShowWindow, the wShowWindow member is used if the nCmdShow parameter of ShowWindow is set to SW_SHOWDEFAULT.
			/// </summary>
			public ushort wShowWindow;

			/// <summary>Reserved for use by the C Run-time; must be zero.</summary>
			public ushort cbReserved2;

			/// <summary>Reserved for use by the C Run-time; must be NULL.</summary>
			public IntPtr lpReserved2;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />, this member is the standard input handle for the process. If <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" /> is not specified, the default for standard input is the keyboard buffer.
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USEHOTKEY" />, this member specifies a hotkey value that is sent as the wParam parameter of a WM_SETHOTKEY message to the first eligible top-level window created by the application that owns the process. If the window is created with the WS_POPUP window style, it is not eligible unless the WS_EX_APPWINDOW extended window style is also set. For more information, see CreateWindowEx.
			/// Otherwise, this member is ignored.
			/// </summary>
			public Kernel32.SafeObjectHandle hStdInput;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />, this member is the standard output handle for the process. Otherwise, this member is ignored and the default for standard output is the console window's buffer.
			/// If a process is launched from the taskbar or jump list, the system sets <see cref="F:PInvoke.Kernel32.STARTUPINFO.hStdOutput" /> to a handle to the monitor that contains the taskbar or jump list used to launch the process. For more information, see Remarks.
			/// Windows 7, Windows Server 2008 R2, Windows Vista, Windows Server 2008, Windows XP, and Windows Server 2003:  This behavior was introduced in Windows 8 and Windows Server 2012.
			/// </summary>
			public Kernel32.SafeObjectHandle hStdOutput;

			/// <summary>
			/// If <see cref="F:PInvoke.Kernel32.STARTUPINFO.dwFlags" /> specifies <see cref="F:PInvoke.Kernel32.StartupInfoFlags.STARTF_USESTDHANDLES" />, this member is the standard error handle for the process. Otherwise, this member is ignored and the default for standard error is the console window's buffer.
			/// </summary>
			public Kernel32.SafeObjectHandle hStdError;

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> struct.
			/// </summary>
			/// <returns>An initialized instance of the struct.</returns>
			public static Kernel32.STARTUPINFO Create() {
				return new Kernel32.STARTUPINFO() {
					cb = Marshal.SizeOf(typeof(Kernel32.STARTUPINFO)),
					hStdInput = Kernel32.SafeObjectHandle.Null,
					hStdOutput = Kernel32.SafeObjectHandle.Null,
					hStdError = Kernel32.SafeObjectHandle.Null
				};
			}
		}

		/// <summary>
		/// Specifies the window station, desktop, standard handles, and attributes for a new process. It is used with the <see cref="M:PInvoke.Kernel32.CreateProcess(System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" /> and <see cref="M:PInvoke.Kernel32.CreateProcessAsUser(System.IntPtr,System.String,System.String,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,PInvoke.Kernel32.SECURITY_ATTRIBUTES*,System.Boolean,PInvoke.Kernel32.CreateProcessFlags,System.Void*,System.String,PInvoke.Kernel32.STARTUPINFO@,PInvoke.Kernel32.PROCESS_INFORMATION@)" /> functions.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct STARTUPINFOEX {
			/// <summary>
			/// A <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> structure.
			/// </summary>
			public Kernel32.STARTUPINFO StartupInfo;

			/// <summary>
			/// An attribute list. This list is created by the <see cref="M:PInvoke.Kernel32.InitializeProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.Int32,System.UInt32,System.IntPtr@)" /> function.
			/// </summary>
			public unsafe Kernel32.PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList;

			/// <summary>
			/// Creates an instance of this structure and initializes its members to
			/// reasonable defaults.
			/// </summary>
			/// <returns>The initialized instance of this struct.</returns>
			public static Kernel32.STARTUPINFOEX Create() {
				return new Kernel32.STARTUPINFOEX() {
					StartupInfo = Kernel32.STARTUPINFO.Create()
				};
			}

			/// <summary>
			/// An attribute list. This list is created by the <see cref="M:PInvoke.Kernel32.InitializeProcThreadAttributeList(PInvoke.Kernel32.PROC_THREAD_ATTRIBUTE_LIST*,System.Int32,System.UInt32,System.IntPtr@)" /> function.
			/// </summary>
			public unsafe IntPtr lpAttributeList_IntPtr {
				get { return new IntPtr((void*) this.lpAttributeList); }
				set { this.lpAttributeList = (Kernel32.PROC_THREAD_ATTRIBUTE_LIST*) value.ToPointer(); }
			}
		}

		/// <summary>
		/// A bitfield that determines whether certain <see cref="T:PInvoke.Kernel32.STARTUPINFO" /> members are used when the process creates a window.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum StartupInfoFlags {
			None = 0,
			STARTF_FORCEONFEEDBACK = 64, // 0x00000040
			STARTF_FORCEOFFFEEDBACK = 128, // 0x00000080
			STARTF_PREVENTPINNING = 8192, // 0x00002000
			STARTF_RUNFULLSCREEN = 32, // 0x00000020
			STARTF_TITLEISAPPID = 4096, // 0x00001000
			STARTF_TITLEISLINKNAME = 2048, // 0x00000800
			STARTF_UNTRUSTEDSOURCE = 32768, // 0x00008000
			STARTF_USECOUNTCHARS = 8,
			STARTF_USEFILLATTRIBUTE = 16, // 0x00000010
			STARTF_USEHOTKEY = 512, // 0x00000200
			STARTF_USEPOSITION = 4,
			STARTF_USESHOWWINDOW = 1,
			STARTF_USESIZE = 2,
			STARTF_USESTDHANDLES = 256, // 0x00000100
		}

		/// <summary>
		/// Standard handles for the <see cref="M:PInvoke.Kernel32.GetStdHandle(PInvoke.Kernel32.StdHandle)" /> and <see cref="M:PInvoke.Kernel32.SetStdHandle(PInvoke.Kernel32.StdHandle,System.IntPtr)" /> methods.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum StdHandle {
			STD_INPUT_HANDLE = -10, // -0x0000000A
			STD_OUTPUT_HANDLE = -11, // -0x0000000B
			STD_ERROR_HANDLE = -12, // -0x0000000C
		}

		/// <summary>
		/// Describes a change in the size of the screen buffer in a console <see cref="T:PInvoke.Kernel32.INPUT_RECORD" /> structure.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct WINDOW_BUFFER_SIZE_RECORD {
			/// <summary>
			/// A <see cref="T:PInvoke.COORD" /> structure that contains the size of the console screen buffer, in character cell columns and rows.
			/// </summary>
			public COORD dwSize;
		}

		/// <summary>
		///     An application-defined callback function used with the EnumResourceNames and EnumResourceNamesEx functions. It
		///     receives the type and name of a resource. The ENUMRESNAMEPROC type defines a pointer to this callback function.
		///     EnumResNameProc is a placeholder for the application-defined function name.
		/// </summary>
		/// <param name="hModule">
		///     A handle to the module whose executable file contains the resources that are being enumerated.
		///     <para>
		///         If this parameter is <see langword="null" />, the function enumerates the resource names in the
		///         module used to create the current process.
		///     </para>
		/// </param>
		/// <param name="lpszType">
		///     The type of resource for which the name is being enumerated. Alternately, rather than a pointer,
		///     this parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is an integer value representing a predefined
		///     resource type.
		/// </param>
		/// <param name="lpszName">
		///     The name of a resource of the type being enumerated. Alternately, rather than a pointer, this
		///     parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is the integer identifier of the resource. For more
		///     information, see the Remarks section below.
		/// </param>
		/// <param name="lParam">
		///     An application-defined parameter passed to the <see cref="M:PInvoke.Kernel32.EnumResourceNames(PInvoke.Kernel32.SafeLibraryHandle,System.Char*,PInvoke.Kernel32.EnumResNameProc,System.IntPtr)" /> or
		///     EnumResourceNamesEx function. This parameter can be used in error checking.
		/// </param>
		/// <returns>Returns TRUE to continue enumeration or FALSE to stop enumeration.</returns>
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public unsafe delegate bool EnumResNameProc(IntPtr hModule, char* lpszType, char* lpszName, IntPtr lParam);

		/// <summary>
		/// Callback function used with the <see cref="M:PInvoke.Kernel32.SetConsoleCtrlHandler(PInvoke.Kernel32.HandlerRoutine,System.Boolean)" /> function.
		/// A console process uses this function to handle control signals received by the process.
		/// When the signal is received, the system creates a new thread in the process to execute the function.
		/// </summary>
		/// <param name="dwCtrlType">The type of control signal received by the handler. This parameter can be one of the following values.</param>
		/// <returns>If the function handles the control signal, it should return TRUE. If it returns FALSE, the next handler function in the list of handlers for this process is used.</returns>
		/// <remarks>
		/// <para>
		/// Because the system creates a new thread in the process to execute the handler function,
		/// it is possible that the handler function will be terminated by another thread in the process.
		/// Be sure to synchronize threads in the process with the thread for the handler function.
		/// Each console process has its own list of <see cref="T:PInvoke.Kernel32.HandlerRoutine" /> callbacks.
		/// Initially, this list contains only a default handler function that calls <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" />.
		/// A console process adds or removes additional handler functions by calling the <see cref="M:PInvoke.Kernel32.SetConsoleCtrlHandler(PInvoke.Kernel32.HandlerRoutine,System.Boolean)" /> function,
		/// which does not affect the list of handler functions for other processes. When a console process receives any of the control signals,
		/// its handler functions are called on a last-registered, first-called basis until one of the handlers returns TRUE.
		/// If none of the handlers returns TRUE, the default handler is called.
		/// </para>
		/// <para>
		/// The <see cref="F:PInvoke.Kernel32.ControlType.CTRL_CLOSE_EVENT" />, <see cref="F:PInvoke.Kernel32.ControlType.CTRL_LOGOFF_EVENT" />, and <see cref="F:PInvoke.Kernel32.ControlType.CTRL_SHUTDOWN_EVENT" /> signals give the process
		/// an opportunity to clean up before termination. A <see cref="T:PInvoke.Kernel32.HandlerRoutine" /> can perform any necessary cleanup, then take one of the following actions:
		/// </para>
		/// <list>
		/// <item>Call the <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" /> function to terminate the process.</item>
		/// <item>Return FALSE. If none of the registered handler functions returns TRUE, the default handler terminates the process.</item>
		/// <item>Return TRUE. In this case, no other handler functions are called and the system terminates the process.</item>
		/// </list>
		/// <para>
		/// A process can use the <see cref="M:PInvoke.Kernel32.SetProcessShutdownParameters(System.Int32,PInvoke.Kernel32.ProcessShutdownFlags)" /> function to prevent the system from displaying a dialog box to the user during logoff or shutdown.
		/// In this case, the system terminates the process when <see cref="T:PInvoke.Kernel32.HandlerRoutine" /> returns TRUE or when the time-out period elapses.
		/// When a console application is run as a service, it receives a modified default console control handler.
		/// This modified handler does not call <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" /> when processing the <see cref="F:PInvoke.Kernel32.ControlType.CTRL_LOGOFF_EVENT" /> and <see cref="F:PInvoke.Kernel32.ControlType.CTRL_SHUTDOWN_EVENT" /> signals.
		/// This allows the service to continue running after the user logs off.
		/// If the service installs its own console control handler, this handler is called before the default handler.
		/// If the installed handler calls <see cref="M:PInvoke.Kernel32.ExitProcess(System.Int32)" /> when processing the <see cref="F:PInvoke.Kernel32.ControlType.CTRL_LOGOFF_EVENT" /> signal, the service exits when the user logs off.
		/// </para>
		/// <para>
		/// Note that a third-party library or DLL can install a console control handler for your application.
		/// If it does, this handler overrides the default handler, and can cause the application to exit when the user logs off.
		/// </para>
		/// </remarks>
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public delegate bool HandlerRoutine(Kernel32.ControlType dwCtrlType);

		/// <summary>
		///     An application-defined callback function used with the EnumResourceLanguages and EnumResourceLanguagesEx
		///     functions. It receives the type, name, and language of a resource item. The ENUMRESLANGPROC type defines
		///     a pointer to this callback function. EnumResLangProc is a placeholder for the application-defined
		///     function name.
		/// </summary>
		/// <param name="hModule">
		///     A handle to the module whose executable file contains the resources for which the languages are being
		///     enumerated.
		///     <para>
		///         If this parameter is NULL, the function enumerates the resource languages in the module used to
		///         create the current process.
		///     </para>
		/// </param>
		/// <param name="lpType">
		///     The type of resource for which the language is being enumerated. Alternately, rather than a pointer,
		///     this parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is an integer value representing a predefined
		///     resource type. For standard resource types, see Resource Types. For more information, see the Remarks
		///     section below.
		/// </param>
		/// <param name="lpName">
		///     The name of the resource for which the language is being enumerated. Alternately, rather than a
		///     pointer, this parameter can be <see cref="M:PInvoke.Kernel32.MAKEINTRESOURCE(System.Int32)" />(ID), where ID is the integer identifier
		///     of the resource. For more information, see the Remarks section below.
		/// </param>
		/// <param name="wLanguage">
		///     The language identifier for the resource for which the language is being enumerated. The
		///     EnumResourceLanguages or EnumResourceLanguagesEx function provides this value. For a list of the primary
		///     language identifiers and sublanguage identifiers that constitute a language identifier, see
		///     <see cref="M:PInvoke.Kernel32.MAKELANGID(System.UInt16,System.UInt16)" />.
		/// </param>
		/// <param name="lParam">
		///     The application-defined parameter passed to the <see cref="M:PInvoke.Kernel32.EnumResourceLanguages(PInvoke.Kernel32.SafeLibraryHandle,System.Char*,System.Char*,PInvoke.Kernel32.EnumResLangProc,System.Void*)" /> EnumResourceLanguages
		///     or EnumResourceLanguagesEx function. This parameter can be used in error checking.
		/// </param>
		/// <returns>Returns TRUE to continue enumeration or FALSE to stop enumeration.</returns>
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public unsafe delegate bool EnumResLangProc(IntPtr hModule, char* lpType, char* lpName,
		                                            Kernel32.LANGID wLanguage, void* lParam);

		/// <summary>
		/// The ACCESS_MASK type is a bitmask that specifies a set of access rights in the access mask of an access control entry.
		/// </summary>
		/// <remarks>
		/// Quite well described here: http://blogs.msdn.com/b/openspecification/archive/2010/04/01/about-the-access-mask-structure.aspx
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct ACCESS_MASK : IComparable, IComparable<Kernel32.ACCESS_MASK>, IEquatable<Kernel32.ACCESS_MASK>,
		                            IFormattable {
			/// <summary>Bits 28-31</summary>
			private const uint GenericRightsMask = 4026531840;

			/// <summary>Bits 24-27</summary>
			private const uint SpecialRightsMask = 251658240;

			/// <summary>Bits 16-23</summary>
			private const uint StandardRightsMask = 16711680;

			/// <summary>Bits 0-15</summary>
			private const uint SpecificRightsMask = 65535;

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /> struct.
			/// </summary>
			/// <param name="value">The value for the <see cref="T:PInvoke.Kernel32.ACCESS_MASK" />.</param>
			public ACCESS_MASK(uint value) {
				this.Value = value;
			}

			/// <summary>Gets the ACCESS_MASK as a 32-bit unsigned integer.</summary>
			public uint Value { get; }

			/// <summary>Gets the ACCESS_MASK as a 32-bit signed integer.</summary>
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public int AsInt32 {
				get { return (int) this.Value; }
			}

			/// <summary>Gets the generic rights of this value.</summary>
			public Kernel32.ACCESS_MASK.GenericRight GenericRights {
				get { return (Kernel32.ACCESS_MASK.GenericRight) ((int) this.Value & -268435456); }
			}

			/// <summary>Gets the special rights of this value.</summary>
			public Kernel32.ACCESS_MASK.SpecialRight SpecialRights {
				get { return (Kernel32.ACCESS_MASK.SpecialRight) ((int) this.Value & 251658240); }
			}

			/// <summary>Gets the standard rights of this value.</summary>
			public Kernel32.ACCESS_MASK.StandardRight StandardRights {
				get { return (Kernel32.ACCESS_MASK.StandardRight) ((int) this.Value & 16711680); }
			}

			/// <summary>Gets the specific rights of this value.</summary>
			public Kernel32.ACCESS_MASK.SpecificRight SpecificRights {
				get { return (Kernel32.ACCESS_MASK.SpecificRight) ((int) this.Value & (int) ushort.MaxValue); }
			}

			/// <summary>Gets the specific rights of this value for desktops.</summary>
			public Kernel32.ACCESS_MASK.DesktopSpecificRight DesktopSpecificRights {
				get { return (Kernel32.ACCESS_MASK.DesktopSpecificRight) this.SpecificRights; }
			}

			/// <summary>
			/// Gets the generic rights of this value for interactive window stations.
			/// </summary>
			public Kernel32.ACCESS_MASK.InteractiveWindowStationGenericRight InteractiveWindowStationGenericRights {
				get { return (Kernel32.ACCESS_MASK.InteractiveWindowStationGenericRight) this.GenericRights; }
			}

			/// <summary>
			/// Gets the generic rights of this value for noninteractive window stations.
			/// </summary>
			public Kernel32.ACCESS_MASK.NonInteractiveWindowStationGenericRight
				NonInteractiveWindowStationGenericRights {
				get { return (Kernel32.ACCESS_MASK.NonInteractiveWindowStationGenericRight) this.GenericRights; }
			}

			/// <summary>
			/// Gets the specific rights of this value for window stations.
			/// </summary>
			public Kernel32.ACCESS_MASK.WindowStationSpecificRight WindowStationSpecificRights {
				get { return (Kernel32.ACCESS_MASK.WindowStationSpecificRight) this.SpecificRights; }
			}

			/// <summary>
			/// Converts an <see cref="T:System.Int32" /> into an <see cref="T:PInvoke.Kernel32.ACCESS_MASK" />.
			/// </summary>
			/// <param name="value">The value of the ACCESS_MASK.</param>
			public static implicit operator Kernel32.ACCESS_MASK(int value) {
				return new Kernel32.ACCESS_MASK((uint) value);
			}

			/// <summary>
			/// Converts an <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /> into an <see cref="T:System.Int32" />.
			/// </summary>
			/// <param name="value">The value of the ACCESS_MASK.</param>
			public static explicit operator int(Kernel32.ACCESS_MASK value) {
				return value.AsInt32;
			}

			/// <summary>
			/// Converts an <see cref="T:System.UInt32" /> into an <see cref="T:PInvoke.Kernel32.ACCESS_MASK" />.
			/// </summary>
			/// <param name="value">The value of the ACCESS_MASK.</param>
			public static implicit operator Kernel32.ACCESS_MASK(uint value) {
				return new Kernel32.ACCESS_MASK(value);
			}

			/// <summary>
			/// Converts an <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /> into an <see cref="T:System.UInt32" />.
			/// </summary>
			/// <param name="value">The value of the ACCESS_MASK.</param>
			public static implicit operator uint(Kernel32.ACCESS_MASK value) {
				return value.Value;
			}

			/// <summary>
			/// Converts a <see cref="T:PInvoke.Kernel32.ACCESS_MASK.StandardRight" /> to an <see cref="T:PInvoke.Kernel32.ACCESS_MASK" />.
			/// </summary>
			/// <param name="value">The value for the <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /></param>
			public static implicit operator Kernel32.ACCESS_MASK(Kernel32.ACCESS_MASK.StandardRight value) {
				return new Kernel32.ACCESS_MASK((uint) value);
			}

			/// <summary>
			/// Converts a <see cref="T:PInvoke.Kernel32.ACCESS_MASK.GenericRight" /> to an <see cref="T:PInvoke.Kernel32.ACCESS_MASK" />.
			/// </summary>
			/// <param name="value">The value for the <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /></param>
			public static implicit operator Kernel32.ACCESS_MASK(Kernel32.ACCESS_MASK.GenericRight value) {
				return new Kernel32.ACCESS_MASK((uint) value);
			}

			/// <summary>
			/// Converts a <see cref="T:PInvoke.Kernel32.ACCESS_MASK.SpecificRight" /> to an <see cref="T:PInvoke.Kernel32.ACCESS_MASK" />.
			/// </summary>
			/// <param name="value">The value for the <see cref="T:PInvoke.Kernel32.ACCESS_MASK" /></param>
			public static implicit operator Kernel32.ACCESS_MASK(Kernel32.ACCESS_MASK.SpecificRight value) {
				return new Kernel32.ACCESS_MASK((uint) value);
			}

			/// <inheritdoc />
			public override int GetHashCode() {
				return this.AsInt32;
			}

			/// <inheritdoc />
			public bool Equals(Kernel32.ACCESS_MASK other) {
				return (int) this.Value == (int) other.Value;
			}

			/// <inheritdoc />
			public override bool Equals(object obj) {
				if (obj is Kernel32.ACCESS_MASK)
					return this.Equals((Kernel32.ACCESS_MASK) obj);
				return false;
			}

			/// <inheritdoc />
			public int CompareTo(object obj) {
				return ((IComparable) this.Value).CompareTo(obj);
			}

			/// <inheritdoc />
			public int CompareTo(Kernel32.ACCESS_MASK other) {
				return this.Value.CompareTo(other.Value);
			}

			/// <inheritdoc />
			public override string ToString() {
				return this.Value.ToString();
			}

			/// <inheritdoc />
			public string ToString(string format, IFormatProvider formatProvider) {
				return this.Value.ToString(format, formatProvider);
			}

			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum GenericRight : uint {
				GENERIC_ALL = 268435456, // 0x10000000
				GENERIC_EXECUTE = 536870912, // 0x20000000
				GENERIC_WRITE = 1073741824, // 0x40000000
				GENERIC_READ = 2147483648, // 0x80000000
			}

			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum SpecialRight : uint {
				ACCESS_SYSTEM_SECURITY = 16777216, // 0x01000000
				MAXIMUM_ALLOWED = 33554432, // 0x02000000
			}

			/// <summary>Contains the object's standard access rights.</summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum StandardRight : uint {
				DELETE = 65536, // 0x00010000
				READ_CONTROL = 131072, // 0x00020000
				WRITE_DAC = 262144, // 0x00040000
				WRITE_OWNER = 524288, // 0x00080000
				SYNCHRONIZE = 1048576, // 0x00100000
				STANDARD_RIGHTS_REQUIRED = WRITE_OWNER | WRITE_DAC | READ_CONTROL | DELETE, // 0x000F0000
				STANDARD_RIGHTS_READ = READ_CONTROL, // 0x00020000
				STANDARD_RIGHTS_WRITE = STANDARD_RIGHTS_READ, // 0x00020000
				STANDARD_RIGHTS_EXECUTE = STANDARD_RIGHTS_WRITE, // 0x00020000

				STANDARD_RIGHTS_ALL =
					STANDARD_RIGHTS_EXECUTE | SYNCHRONIZE | WRITE_OWNER | WRITE_DAC | DELETE, // 0x001F0000
			}

			/// <summary>
			/// Contains the access mask specific to the object type associated with the mask.
			/// </summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum SpecificRight : uint {
				SPECIFIC_RIGHTS_ALL = 65535, // 0x0000FFFF
			}

			/// <summary>
			/// The following are the generic access rights for a desktop object contained in the interactive window station of the user's logon session
			/// </summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum DesktopGenericRight : uint {
				GENERIC_READ = 131137, // 0x00020041
				GENERIC_WRITE = 131262, // 0x000200BE
				GENERIC_EXECUTE = 131328, // 0x00020100
				GENERIC_ALL = 983551, // 0x000F01FF
			}

			/// <summary>
			/// Contains the access mask specific to the Desktop associated with the mask.
			/// </summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum DesktopSpecificRight : uint {
				DESKTOP_ALL_ACCESS = 511, // 0x000001FF
				DESKTOP_CREATEMENU = 4,
				DESKTOP_ENUMERATE = 64, // 0x00000040
				DESKTOP_HOOKCONTROL = 8,
				DESKTOP_JOURNALPLAYBACK = 32, // 0x00000020
				DESKTOP_JOURNALRECORD = 16, // 0x00000010
				DESKTOP_READOBJECTS = 1,
				DESKTOP_CREATEWINDOW = 2,
				DESKTOP_SWITCHDESKTOP = 256, // 0x00000100
				DESKTOP_WRITEOBJECTS = 128, // 0x00000080
			}

			/// <summary>
			/// Generic access rights for the interactive window station object, which is the window station assigned to the logon session of the interactive user.
			/// </summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum InteractiveWindowStationGenericRight : uint {
				GENERIC_READ = 131843, // 0x00020303
				GENERIC_WRITE = 131100, // 0x0002001C
				GENERIC_EXECUTE = 131168, // 0x00020060
				GENERIC_ALL = 983935, // 0x000F037F
			}

			/// <summary>
			/// Generic access rights for a noninteractive window station object.
			/// The system assigns noninteractive window stations to all logon sessions other than that of the interactive user.
			/// </summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum NonInteractiveWindowStationGenericRight : uint {
				GENERIC_READ = 131331, // 0x00020103
				GENERIC_WRITE = 131084, // 0x0002000C
				GENERIC_EXECUTE = 131168, // 0x00020060
				GENERIC_ALL = 983919, // 0x000F036F
			}

			/// <summary>
			/// Contains the access mask specific to the Window Station associated with the mask.
			/// </summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum WindowStationSpecificRight : uint {
				WINSTA_ALL_ACCESS = 895, // 0x0000037F
				WINSTA_ACCESSCLIPBOARD = 4,
				WINSTA_ACCESSGLOBALATOMS = 32, // 0x00000020
				WINSTA_CREATEDESKTOP = 8,
				WINSTA_ENUMDESKTOPS = 1,
				WINSTA_ENUMERATE = 256, // 0x00000100
				WINSTA_EXITWINDOWS = 64, // 0x00000040
				WINSTA_READATTRIBUTES = 2,
				WINSTA_READSCREEN = 512, // 0x00000200
				WINSTA_WRITEATTRIBUTES = 16, // 0x00000010
			}
		}

		/// <summary>
		/// File attributes, flags, and security settings that are passed to the CreateFile method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum CreateFileFlags : uint {
			FILE_ATTRIBUTE_ARCHIVE = 32, // 0x00000020
			FILE_ATTRIBUTE_ENCRYPTED = 16384, // 0x00004000
			FILE_ATTRIBUTE_HIDDEN = 2,
			FILE_ATTRIBUTE_NORMAL = 128, // 0x00000080
			FILE_ATTRIBUTE_OFFLINE = 4096, // 0x00001000
			FILE_ATTRIBUTE_READONLY = 1,
			FILE_ATTRIBUTE_SYSTEM = 4,
			FILE_ATTRIBUTE_TEMPORARY = 256, // 0x00000100
			FILE_FLAG_BACKUP_SEMANTICS = 33554432, // 0x02000000
			FILE_FLAG_DELETE_ON_CLOSE = 67108864, // 0x04000000
			FILE_FLAG_NO_BUFFERING = 536870912, // 0x20000000
			FILE_FLAG_OPEN_NO_RECALL = 1048576, // 0x00100000
			FILE_FLAG_OPEN_REPARSE_POINT = 2097152, // 0x00200000
			FILE_FLAG_OVERLAPPED = 1073741824, // 0x40000000
			FILE_FLAG_POSIX_SEMANTICS = FILE_FLAG_OPEN_NO_RECALL, // 0x00100000
			FILE_FLAG_RANDOM_ACCESS = 268435456, // 0x10000000
			FILE_FLAG_SESSION_AWARE = 8388608, // 0x00800000
			FILE_FLAG_SEQUENTIAL_SCAN = 134217728, // 0x08000000
			FILE_FLAG_WRITE_THROUGH = 2147483648, // 0x80000000
			SECURITY_SQOS_PRESENT = FILE_FLAG_POSIX_SEMANTICS, // 0x00100000
			SECURITY_ANONYMOUS = 0,
			SECURITY_CONTEXT_TRACKING = 262144, // 0x00040000
			SECURITY_DELEGATION = 196608, // 0x00030000
			SECURITY_EFFECTIVE_ONLY = 524288, // 0x00080000
			SECURITY_IDENTIFICATION = 65536, // 0x00010000
			SECURITY_IMPERSONATION = 131072, // 0x00020000
		}

		/// <summary>
		/// Describes an action to take on a file or device that exists or does not exist.
		/// </summary>
		/// <remarks>
		/// These are flags to pass to the CreateFile method's dwCreationDisposition parameter.
		/// </remarks>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum CreationDisposition : uint {
			CREATE_NEW = 1,
			CREATE_ALWAYS = 2,
			OPEN_EXISTING = 3,
			OPEN_ALWAYS = 4,
			TRUNCATE_EXISTING = 5,
		}

		/// <summary>
		/// Enumerates the <see cref="P:PInvoke.Kernel32.ACCESS_MASK.SpecificRights" /> that may apply to files.
		/// </summary>
		/// <remarks>These flags may be passed to CreateFile.</remarks>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public static class FileAccess {
			/// <summary>
			///     For a file object, the right to read the corresponding file data. For a directory object, the right to read
			///     the corresponding directory data.
			/// </summary>
			public const uint FILE_READ_DATA = 1;

			/// <summary>For a directory, the right to list the contents of the directory.</summary>
			public const uint FILE_LIST_DIRECTORY = 1;

			/// <summary>
			///     For a file object, the right to write data to the file. For a directory object, the right to create a file in
			///     the directory (<see cref="F:PInvoke.Kernel32.FileAccess.FILE_ADD_FILE" />).
			/// </summary>
			public const uint FILE_WRITE_DATA = 2;

			/// <summary>For a directory, the right to create a file in the directory.</summary>
			public const uint FILE_ADD_FILE = 2;

			/// <summary>
			///     For a file object, the right to append data to the file. (For local files, write operations will not overwrite
			///     existing data if this flag is specified without <see cref="F:PInvoke.Kernel32.FileAccess.FILE_WRITE_DATA" />.) For a directory object, the right
			///     to create a subdirectory (<see cref="F:PInvoke.Kernel32.FileAccess.FILE_ADD_SUBDIRECTORY" />).
			/// </summary>
			public const uint FILE_APPEND_DATA = 4;

			/// <summary>For a directory, the right to create a subdirectory.</summary>
			public const uint FILE_ADD_SUBDIRECTORY = 4;

			/// <summary>For a named pipe, the right to create a pipe.</summary>
			public const uint FILE_CREATE_PIPE_INSTANCE = 4;

			/// <summary>The right to read extended file attributes.</summary>
			public const uint FILE_READ_EA = 8;

			/// <summary>The right to write extended file attributes.</summary>
			public const uint FILE_WRITE_EA = 16;

			/// <summary>
			///     For a native code file, the right to execute the file. This access right given to scripts may cause the script
			///     to be executable, depending on the script interpreter.
			/// </summary>
			public const uint FILE_EXECUTE = 32;

			/// <summary>
			///     For a directory, the right to traverse the directory. By default, users are assigned the
			///     BYPASS_TRAVERSE_CHECKING privilege, which ignores the FILE_TRAVERSE access right.
			/// </summary>
			public const uint FILE_TRAVERSE = 32;

			/// <summary>For a directory, the right to delete a directory and all the files it contains, including read-only files.</summary>
			public const uint FILE_DELETE_CHILD = 64;

			/// <summary>The right to read file attributes.</summary>
			public const uint FILE_READ_ATTRIBUTES = 128;

			/// <summary>The right to write file attributes.</summary>
			public const uint FILE_WRITE_ATTRIBUTES = 256;

			public const uint SPECIFIC_RIGHTS_ALL = 65535;
			public const uint FILE_ALL_ACCESS = 2032127;
			public const uint FILE_GENERIC_READ = 1179785;
			public const uint FILE_GENERIC_WRITE = 1179926;
			public const uint FILE_GENERIC_EXECUTE = 1179808;
		}

		/// <summary>Defines the Win32 FileAttributes enum.</summary>
		/// <remarks>
		///     This is similar to the System.IO.FileAttributes enum, but that enum is not available in the portable profile,
		///     although it is allowed to call certain file methods via P/Invoke in Windows Store apps, per MSDN docs. A value
		///     typed as this enum may be safely cast to the System.IO.FileAttributes enum, as all the value names have equal
		///     ordinal values.
		/// </remarks>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum FileAttribute {
			FILE_ATTRIBUTE_ARCHIVE = 32, // 0x00000020
			FILE_ATTRIBUTE_COMPRESSED = 2048, // 0x00000800
			FILE_ATTRIBUTE_DEVICE = 64, // 0x00000040
			FILE_ATTRIBUTE_DIRECTORY = 16, // 0x00000010
			FILE_ATTRIBUTE_ENCRYPTED = 16384, // 0x00004000
			FILE_ATTRIBUTE_HIDDEN = 2,
			FILE_ATTRIBUTE_INTEGRITY_STREAM = 32768, // 0x00008000
			FILE_ATTRIBUTE_NORMAL = 128, // 0x00000080
			FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192, // 0x00002000
			FILE_ATTRIBUTE_NO_SCRUB_DATA = 131072, // 0x00020000
			FILE_ATTRIBUTE_OFFLINE = 4096, // 0x00001000
			FILE_ATTRIBUTE_READONLY = 1,
			FILE_ATTRIBUTE_REPARSE_POINT = 1024, // 0x00000400
			FILE_ATTRIBUTE_SPARSE_FILE = 512, // 0x00000200
			FILE_ATTRIBUTE_SYSTEM = 4,
			FILE_ATTRIBUTE_TEMPORARY = 256, // 0x00000100
			FILE_ATTRIBUTE_VIRTUAL = 65536, // 0x00010000
		}

		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum FileShare : uint {
			None = 0,
			FILE_SHARE_READ = 1,
			FILE_SHARE_WRITE = 2,
			FILE_SHARE_DELETE = 4,
		}

		/// <summary>A 64-bit representation of a file timestamp.</summary>
		/// <remarks>
		/// This type is equivalent to <see cref="T:System.Runtime.InteropServices.ComTypes.FILETIME" />.
		/// We couldn't use that type directly even though it's in the portable profile because
		/// Xamarin.Android and Xamarin.iOS omit the type and it causes link failures.
		/// See https://github.com/AArnott/pinvoke/issues/232
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct FILETIME {
			/// <summary>Specifies the high 32 bits of the FILETIME.</summary>
			public int dwHighDateTime;

			/// <summary>Specifies the low 32 bits of the FILETIME.</summary>
			public int dwLowDateTime;
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum FINDEX_INFO_LEVELS {
			FindExInfoStandard,
			FindExInfoMaxInfoLevel,
		}

		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum FINDEX_SEARCH_OPS {
			FindExSearchNameMatch,
			FindExSearchLimitToDirectories,
			FindExSearchLimitToDevices,
			FindExSearchMaxSearchOp,
		}

		/// <summary>
		/// Optional flags to pass to the <see cref="M:PInvoke.Kernel32.FindFirstFileEx(System.String,PInvoke.Kernel32.FINDEX_INFO_LEVELS,PInvoke.Kernel32.WIN32_FIND_DATA@,PInvoke.Kernel32.FINDEX_SEARCH_OPS,System.Void*,PInvoke.Kernel32.FindFirstFileExFlags)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum FindFirstFileExFlags {
			None = 0,
			FIND_FIRST_EX_CASE_SENSITIVE = 1,
			FIND_FIRST_EX_LARGE_FETCH = 2,
		}

		/// <summary>
		/// Flags passed to the <see cref="M:PInvoke.Kernel32.FormatMessage(PInvoke.Kernel32.FormatMessageFlags,System.Void*,System.Int32,System.Int32,System.IntPtr[],System.Int32)" /> method.
		/// </summary>
		[Flags]
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum FormatMessageFlags {
			FORMAT_MESSAGE_ALLOCATE_BUFFER = 256, // 0x00000100
			FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192, // 0x00002000
			FORMAT_MESSAGE_FROM_HMODULE = 2048, // 0x00000800
			FORMAT_MESSAGE_FROM_STRING = 1024, // 0x00000400
			FORMAT_MESSAGE_FROM_SYSTEM = 4096, // 0x00001000
			FORMAT_MESSAGE_IGNORE_INSERTS = 512, // 0x00000200
			FORMAT_MESSAGE_MAX_WIDTH_MASK = 255, // 0x000000FF
		}

		/// <summary>Contains information used in asynchronous (or overlapped) input and output (I/O).</summary>
		/// <remarks>
		/// Any unused members of this structure should always be initialized to zero before the structure is used in a function
		/// call. Otherwise, the function may fail and return <see cref="F:PInvoke.Win32ErrorCode.ERROR_INVALID_PARAMETER" />.
		/// <para>
		/// The Offset and OffsetHigh members together represent a 64-bit file position.It is a byte offset from the start of
		/// the file or file-like device, and it is specified by the user; the system will not modify these values.The calling
		/// process must set this member before passing the OVERLAPPED structure to functions that use an offset, such as the
		/// ReadFile or WriteFile (and related) functions.
		/// </para>
		/// <para>
		/// You can use the HasOverlappedIoCompleted macro to check whether an asynchronous I/O operation has completed if
		/// GetOverlappedResult is too cumbersome for your application.
		/// </para>
		/// <para>You can use the CancelIo function to cancel an asynchronous I/O operation.</para>
		/// <para>
		/// A common mistake is to reuse an OVERLAPPED structure before the previous asynchronous operation has been
		/// completed. You should use a separate structure for each request. You should also create an event object for each thread
		/// that processes data. If you store the event handles in an array, you could easily wait for all events to be signaled
		/// using the WaitForMultipleObjects function.
		/// </para>
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct OVERLAPPED {
			/// <summary>
			/// The status code for the I/O request. When the request is issued, the system sets this member to STATUS_PENDING to indicate that the operation has not yet started. When the request is completed, the system sets this member to the status code for the completed request.
			/// <para>The Internal member was originally reserved for system use and its behavior may change.</para>
			/// </summary>
			public IntPtr Internal;

			/// <summary>
			/// The number of bytes transferred for the I/O request. The system sets this member if the request is completed without errors.
			/// <para>The InternalHigh member was originally reserved for system use and its behavior may change.</para>
			/// </summary>
			public IntPtr InternalHigh;

			/// <summary>
			/// The low-order portion of the file position at which to start the I/O request, as specified by the user.
			/// <para>This member is nonzero only when performing I/O requests on a seeking device that supports the concept of an offset(also referred to as a file pointer mechanism), such as a file.Otherwise, this member must be zero.</para>
			/// <para>For additional information, see Remarks.</para>
			/// </summary>
			public int Offset;

			/// <summary>
			/// The high-order portion of the file position at which to start the I/O request, as specified by the user.
			/// <para>This member is nonzero only when performing I/O requests on a seeking device that supports the concept of an offset(also referred to as a file pointer mechanism), such as a file.Otherwise, this member must be zero.</para>
			/// <para>For additional information, see Remarks.</para>
			/// </summary>
			public int OffsetHigh;

			/// <summary>
			/// A handle to the event that will be set to a signaled state by the system when the operation has completed. The user must initialize this member either to zero or a valid event handle using the CreateEvent function before passing this structure to any overlapped functions. This event can then be used to synchronize simultaneous I/O requests for a device. For additional information, see Remarks.
			/// <para>Functions such as ReadFile and WriteFile set this handle to the nonsignaled state before they begin an I/O operation.When the operation has completed, the handle is set to the signaled state.</para>
			/// <para>Functions such as GetOverlappedResult and the synchronization wait functions reset auto-reset events to the nonsignaled state. Therefore, you should use a manual reset event; if you use an auto-reset event, your application can stop responding if you wait for the operation to complete and then call GetOverlappedResult with the bWait parameter set to TRUE.</para>
			/// </summary>
			public IntPtr hEvent;
		}

		/// <summary>
		/// Represents a Win32 handle that can be closed with <see cref="M:PInvoke.Kernel32.FindClose(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeFindFilesHandle : SafeHandle {
			/// <summary>
			/// An invalid handle that may be used in place of <see cref="F:PInvoke.Kernel32.INVALID_HANDLE_VALUE" />.
			/// </summary>
			public static readonly Kernel32.SafeFindFilesHandle Invalid = new Kernel32.SafeFindFilesHandle();

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.SafeFindFilesHandle" /> class.
			/// </summary>
			public SafeFindFilesHandle()
				: base(Kernel32.INVALID_HANDLE_VALUE, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.SafeFindFilesHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeFindFilesHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			/// <inheritdoc />
			public override bool IsInvalid {
				get { return this.handle == Kernel32.INVALID_HANDLE_VALUE; }
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return Kernel32.FindClose(this.handle);
			}
		}

		/// <summary>
		/// Represents a library handle that can be closed with <see cref="M:PInvoke.Kernel32.FreeLibrary(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeLibraryHandle : SafeHandle {
			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly Kernel32.SafeLibraryHandle Null = new Kernel32.SafeLibraryHandle(IntPtr.Zero, true);

			/// <summary>
			/// An invalid handle that may be used in place of <see cref="F:PInvoke.Kernel32.INVALID_HANDLE_VALUE" />.
			/// </summary>
			public static readonly Kernel32.SafeLibraryHandle Invalid = new Kernel32.SafeLibraryHandle();

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.SafeLibraryHandle" /> class.
			/// </summary>
			public SafeLibraryHandle()
				: base(Kernel32.INVALID_HANDLE_VALUE, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.SafeLibraryHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeLibraryHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(Kernel32.INVALID_HANDLE_VALUE, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			/// <inheritdoc />
			public override bool IsInvalid {
				get {
					if (!(this.handle == Kernel32.INVALID_HANDLE_VALUE))
						return this.handle == IntPtr.Zero;
					return true;
				}
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return Kernel32.FreeLibrary(this.handle);
			}
		}

		/// <summary>
		/// Represents a Win32 handle that can be closed with <see cref="M:PInvoke.Kernel32.CloseHandle(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeObjectHandle : SafeHandle {
			/// <summary>
			/// An invalid handle that may be used in place of <see cref="F:PInvoke.Kernel32.INVALID_HANDLE_VALUE" />.
			/// </summary>
			public static readonly Kernel32.SafeObjectHandle Invalid = new Kernel32.SafeObjectHandle();

			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly Kernel32.SafeObjectHandle Null = new Kernel32.SafeObjectHandle(IntPtr.Zero, false);

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.SafeObjectHandle" /> class.
			/// </summary>
			public SafeObjectHandle()
				: base(Kernel32.INVALID_HANDLE_VALUE, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.SafeObjectHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeObjectHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(Kernel32.INVALID_HANDLE_VALUE, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			/// <inheritdoc />
			public override bool IsInvalid {
				get {
					if (!(this.handle == Kernel32.INVALID_HANDLE_VALUE))
						return this.handle == IntPtr.Zero;
					return true;
				}
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return Kernel32.CloseHandle(this.handle);
			}
		}

		/// <summary>
		/// The SECURITY_ATTRIBUTES structure contains the security descriptor for an object and specifies whether the handle retrieved by specifying this structure is inheritable. This structure provides security settings for objects created by various functions, such as CreateFile, CreatePipe, CreateProcess, RegCreateKeyEx, or RegSaveKeyEx.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SECURITY_ATTRIBUTES {
			/// <summary>
			/// The size, in bytes, of this structure.
			/// This value is set by the constructor to the size of the <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> structure.
			/// </summary>
			public int nLength;

			/// <summary>
			/// A pointer to a <see cref="T:PInvoke.Kernel32.SECURITY_DESCRIPTOR" /> structure that controls access to the object. If the value of this member is NULL, the object is assigned the default security descriptor associated with the access token of the calling process. This is not the same as granting access to everyone by assigning a NULL discretionary access control list (DACL). By default, the default DACL in the access token of a process allows access only to the user represented by the access token.
			/// For information about creating a security descriptor, see Creating a Security Descriptor.
			/// </summary>
			public IntPtr lpSecurityDescriptor;

			/// <summary>
			/// A Boolean value that specifies whether the returned handle is inherited when a new process is created. If this member is TRUE, the new process inherits the handle.
			/// </summary>
			public int bInheritHandle;

			/// <summary>
			/// Gets a value indicating whether the returned handle is inherited when a new process is created. If this member is TRUE, the new process inherits the handle.
			/// </summary>
			public bool InheritHandle {
				get { return (uint) this.bInheritHandle > 0U; }
			}

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" /> struct.
			/// </summary>
			/// <returns>A new instance of <see cref="T:PInvoke.Kernel32.SECURITY_ATTRIBUTES" />.</returns>
			public static Kernel32.SECURITY_ATTRIBUTES Create() {
				return new Kernel32.SECURITY_ATTRIBUTES() {
					nLength = Marshal.SizeOf(typeof(Kernel32.SECURITY_ATTRIBUTES))
				};
			}
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SECURITY_DESCRIPTOR {
			public byte Revision;
			public byte Sbz1;
			public ushort Control;
			public IntPtr Owner;
			public IntPtr Group;
			public IntPtr Sacl;
			public IntPtr Dacl;
		}

		/// <summary>
		/// Contains values that specify security impersonation levels. Security impersonation levels govern the degree to which a server process can act on behalf of a client process.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum SECURITY_IMPERSONATION_LEVEL {
			SecurityAnonymous,
			SecurityIdentification,
			SecurityImpersonation,
			SecurityDelegation,
		}

		/// <summary>
		/// Specifies a date and time, using individual members for the month, day, year, weekday, hour, minute, second, and millisecond.
		/// The time is either in coordinated universal time (UTC) or local time, depending on the function that is being called.
		/// </summary>
		/// <remarks>
		/// It is not recommended that you add and subtract values from the <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure to obtain relative times.
		/// Instead, you should
		/// Convert the <see cref="T:PInvoke.Kernel32.SYSTEMTIME" /> structure to a <see cref="T:PInvoke.Kernel32.FILETIME" /> structure.
		/// <list type="bullet">
		/// <item>
		/// <desccription>Copy the resulting <see cref="T:PInvoke.Kernel32.FILETIME" /> structure to a ULARGE_INTEGER structure.</desccription>
		/// </item>
		/// <item>
		/// <desccription>Use normal 64-bit arithmetic on the ULARGE_INTEGER value.</desccription>
		/// </item>
		/// <item>
		/// <description>The system can periodically refresh the time by synchronizing with a time source.</description>
		/// </item>
		/// </list>
		/// Because the system time can be adjusted either forward or backward, do not compare system time readings to determine elapsed time.
		/// Instead, use one of the methods described in Windows Time.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SYSTEMTIME {
			/// <summary>
			/// The year. The valid values for this member are 1601 through 30827.
			/// </summary>
			public short wYear;

			/// <summary>
			/// The month. This member can be one of the following values.
			/// <list type="table">
			/// <listheader>
			/// <term>Value</term>
			/// <term>Meaning</term>
			/// </listheader>
			/// <item>
			/// <term>1</term>
			/// <term>January</term>
			/// </item>
			/// <item>
			/// <term>2</term>
			/// <term>February</term>
			/// </item>
			/// <item>
			/// <term>3</term>
			/// <term>March</term>
			/// </item>
			/// <item>
			/// <term>4</term>
			/// <term>April</term>
			/// </item>
			/// <item>
			/// <term>5</term>
			/// <term>May</term>
			/// </item>
			/// <item>
			/// <term>6</term>
			/// <term>June</term>
			/// </item>
			/// <item>
			/// <term>7</term>
			/// <term>July</term>
			/// </item>
			/// <item>
			/// <term>8</term>
			/// <term>August</term>
			/// </item>
			/// <item>
			/// <term>9</term>
			/// <term>September</term>
			/// </item>
			/// <item>
			/// <term>10</term>
			/// <term>October</term>
			/// </item>
			/// <item>
			/// <term>11</term>
			/// <term>November</term>
			/// </item>
			/// <item>
			/// <term>12</term>
			/// <term>December</term>
			/// </item>
			/// </list>
			/// </summary>
			public short wMonth;

			/// <summary>
			/// The day of the week. This member can be one of the following values.
			/// <list type="table">
			/// <listheader>
			/// <term>Value</term>
			/// <term>Meaning</term>
			/// </listheader>
			/// <item>
			/// <term>0</term>
			/// <term>Sunday</term>
			/// </item>
			/// <item>
			/// <term>1</term>
			/// <term>Monday</term>
			/// </item>
			/// <item>
			/// <term>2</term>
			/// <term>Tuesday</term>
			/// </item>
			/// <item>
			/// <term>3</term>
			/// <term>Wednesday</term>
			/// </item>
			/// <item>
			/// <term>4</term>
			/// <term>Thursday</term>
			/// </item>
			/// <item>
			/// <term>5</term>
			/// <term>Friday</term>
			/// </item>
			/// <item>
			/// <term>6</term>
			/// <term>Saturday</term>
			/// </item>
			/// </list>
			/// </summary>
			public short wDayOfWeek;

			/// <summary>
			/// The day of the month. The valid values for this member are 1 through 31.
			/// </summary>
			public short wDay;

			/// <summary>
			/// The hour. The valid values for this member are 0 through 23.
			/// </summary>
			public short wHour;

			/// <summary>
			/// The minute. The valid values for this member are 0 through 59.
			/// </summary>
			public short wMinute;

			/// <summary>
			/// The second. The valid values for this member are 0 through 59.
			/// </summary>
			public short wSecond;

			/// <summary>
			/// The millisecond. The valid values for this member are 0 through 999.
			/// </summary>
			public short wMilliseconds;
		}

		/// <summary>
		/// Values that may be returned from the <see cref="M:PInvoke.Kernel32.WaitForSingleObject(System.Runtime.InteropServices.SafeHandle,System.Int32)" /> function.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum WaitForSingleObjectResult : uint {
			WAIT_OBJECT_0 = 0,
			WAIT_ABANDONED = 128, // 0x00000080
			WAIT_TIMEOUT = 258, // 0x00000102
			WAIT_FAILED = 4294967295, // 0xFFFFFFFF
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct WIN32_FIND_DATA {
			/// <summary>The file attributes of a file.</summary>
			/// <remarks>
			/// Although the enum we bind to here exists in the .NET Framework
			/// as System.IO.FileAttributes, it is not reliably present.
			/// Portable profiles don't include it, for example. So we have to define our own.
			/// </remarks>
			public Kernel32.FileAttribute dwFileAttributes;

			/// <summary>
			/// A FILETIME structure that specifies when a file or directory was created.
			/// If the underlying file system does not support creation time, this member is zero.
			/// </summary>
			public Kernel32.FILETIME ftCreationTime;

			/// <summary>
			/// A FILETIME structure.
			/// For a file, the structure specifies when the file was last read from, written to, or for executable files, run.
			/// For a directory, the structure specifies when the directory is created.If the underlying file system does not support last access time, this member is zero.
			/// On the FAT file system, the specified date for both files and directories is correct, but the time of day is always set to midnight.
			/// </summary>
			public Kernel32.FILETIME ftLastAccessTime;

			/// <summary>
			/// A FILETIME structure.
			/// For a file, the structure specifies when the file was last written to, truncated, or overwritten, for example, when WriteFile or SetEndOfFile are used.The date and time are not updated when file attributes or security descriptors are changed.
			/// For a directory, the structure specifies when the directory is created.If the underlying file system does not support last write time, this member is zero.
			/// </summary>
			public Kernel32.FILETIME ftLastWriteTime;

			/// <summary>
			/// The high-order DWORD value of the file size, in bytes.
			/// This value is zero unless the file size is greater than MAXDWORD.
			/// The size of the file is equal to(nFileSizeHigh* (MAXDWORD+1)) + nFileSizeLow.
			/// </summary>
			public uint nFileSizeHigh;

			/// <summary>The low-order DWORD value of the file size, in bytes.</summary>
			public uint nFileSizeLow;

			/// <summary>
			/// If the dwFileAttributes member includes the FILE_ATTRIBUTE_REPARSE_POINT attribute, this member specifies the reparse point tag.
			/// Otherwise, this value is undefined and should not be used.
			/// For more information see Reparse Point Tags.
			/// </summary>
			public uint dwReserved0;

			/// <summary>Reserved for future use.</summary>
			public uint dwReserved1;

			/// <summary>The name of the file.</summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string cFileName;

			/// <summary>
			/// An alternative name for the file.
			/// This name is in the classic 8.3 file name format.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
			public string cAlternateFileName;
		}
	}
}