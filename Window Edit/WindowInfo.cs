using System;
using Window_Edit.Annotations;
using WindowEdit.Interop;

namespace WindowEdit {
	public class WindowInfo {
		public IntPtr Handle { get; }

		public bool IsValid => Handle != IntPtr.Zero && User32.IsWindow(Handle);

		[CanBeNull]
		public string Title => User32.GetWindowText(Handle);

		public WindowInfo(IntPtr handle) {
			Handle = handle;
		}
	}
}
