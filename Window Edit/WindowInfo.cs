using System;
using PInvoke;
using Window_Edit.Annotations;
using WindowEdit.Interop;

namespace WindowEdit {
	public class WindowInfo {
		public IntPtr Handle { get; }

		public bool IsValid => Handle != IntPtr.Zero && MUser32.IsWindow(Handle);

		[CanBeNull]
		public string Title => MUser32.GetWindowText(Handle);

		//public int ThreadId => User32.GetWindowThreadProcessId(Handle, out _);
		// public int ProcessId {
		// 	get {
		// 		User32.GetWindowThreadProcessId(Handle, out int processId);
		// 		return processId;
		// 	}
		// }
		
		public int ThreadId { get; }
		public int ProcessId { get; }

		public WindowInfo(IntPtr handle) {
			Handle = handle;
			ThreadId = User32.GetWindowThreadProcessId(Handle, out int processId);
			ProcessId = processId;
		}
	}
}
