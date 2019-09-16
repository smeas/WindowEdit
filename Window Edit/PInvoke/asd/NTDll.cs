// Decompiled with JetBrains decompiler
// Type: PInvoke.NTDll
// Assembly: PInvoke.NTDll, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: 2B319157-79D9-4051-95AB-F07E86CCC0CF
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.ntdll\0.5.152\lib\net40\PInvoke.NTDll.dll

using System;
using System.Runtime.InteropServices;

namespace PInvoke {
	/// <content>
	/// Contains the <see cref="T:PInvoke.NTDll.OBJECT_ATTRIBUTES" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.NTDll.SafeNTObjectHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.NTDll.UNICODE_STRING" /> nested type.
	/// </content>
	/// <content>
	/// Exported functions from the NTDll.dll Windows library
	/// that are available to Desktop apps only.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.NTDll.OBJECT_ATTRIBUTES" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.NTDll.SafeNTObjectHandle" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.NTDll.UNICODE_STRING" /> nested type.
	/// </content>
	/// <content>
	/// Exported functions from the NTDll.dll Windows library
	/// that are available to Desktop apps only.
	/// </content>
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public static class NTDll {
		/// <summary>
		/// Converts the specified NTSTATUS code to its equivalent system error code.
		/// </summary>
		/// <param name="Status">The NTSTATUS code to be converted.</param>
		/// <returns>The function returns the corresponding system error code.</returns>
		/// <remarks>
		/// There is no function that provides the inverse functionality of RtlNtStatusToDosError, which would convert a system error code to its corresponding NTSTATUS code.
		/// ERROR_MR_MID_NOT_FOUND is returned when the specified NTSTATUS code does not have a corresponding system error code.
		/// </remarks>
		[DllImport("NTDll", CharSet = CharSet.Unicode)]
		public static extern Win32ErrorCode RtlNtStatusToDosError(NTSTATUS Status);

		/// <summary>
		/// The NtOpenSection routine opens a handle for an existing section object.
		/// </summary>
		/// <param name="sectionHandle">Pointer to a HANDLE variable that receives a handle to the section object.</param>
		/// <param name="desiredAccess">Specifies an ACCESS_MASK value that determines the requested access to the object.</param>
		/// <param name="objectAttributes">Pointer to an OBJECT_ATTRIBUTES structure that specifies the object name and other attributes. Use InitializeObjectAttributes to initialize this structure.</param>
		/// <returns>
		/// Returns <see cref="F:PInvoke.NTSTATUS.Code.STATUS_SUCCESS" /> on success, or the appropriate <see cref="T:PInvoke.NTSTATUS" /> error code on failure.
		/// </returns>
		[DllImport("NTDll", CharSet = CharSet.Unicode)]
		public static extern unsafe NTSTATUS NtOpenSection(out NTDll.SafeNTObjectHandle sectionHandle,
		                                                   Kernel32.ACCESS_MASK desiredAccess,
		                                                   NTDll.OBJECT_ATTRIBUTES* objectAttributes);

		/// <summary>The NtClose routine closes an object handle.</summary>
		/// <param name="handle">Handle to an object of any type.</param>
		/// <returns>
		/// Returns <see cref="F:PInvoke.NTSTATUS.Code.STATUS_SUCCESS" /> on success, or the appropriate <see cref="T:PInvoke.NTSTATUS" /> error code on failure.
		/// </returns>
		[DllImport("NTDll", CharSet = CharSet.Unicode)]
		private static extern NTSTATUS NtClose(IntPtr handle);

		/// <summary>
		/// The NtOpenSection routine opens a handle for an existing section object.
		/// </summary>
		/// <param name="sectionHandle">Pointer to a HANDLE variable that receives a handle to the section object.</param>
		/// <param name="desiredAccess">Specifies an ACCESS_MASK value that determines the requested access to the object.</param>
		/// <param name="objectAttributes">Pointer to an OBJECT_ATTRIBUTES structure that specifies the object name and other attributes. Use InitializeObjectAttributes to initialize this structure.</param>
		/// <returns>
		/// Returns <see cref="F:PInvoke.NTSTATUS.Code.STATUS_SUCCESS" /> on success, or the appropriate <see cref="T:PInvoke.NTSTATUS" /> error code on failure.
		/// </returns>
		public static unsafe NTSTATUS NtOpenSection(out NTDll.SafeNTObjectHandle sectionHandle,
		                                            Kernel32.ACCESS_MASK desiredAccess, IntPtr objectAttributes) {
			NTDll.OBJECT_ATTRIBUTES* pointer = (NTDll.OBJECT_ATTRIBUTES*) objectAttributes.ToPointer();
			return NTDll.NtOpenSection(out sectionHandle, desiredAccess, pointer);
		}

		/// <summary>
		/// The NtOpenSection routine opens a handle for an existing section object.
		/// </summary>
		/// <param name="sectionHandle">Pointer to a HANDLE variable that receives a handle to the section object.</param>
		/// <param name="desiredAccess">Specifies an ACCESS_MASK value that determines the requested access to the object.</param>
		/// <param name="objectAttributes">Pointer to an OBJECT_ATTRIBUTES structure that specifies the object name and other attributes. Use InitializeObjectAttributes to initialize this structure.</param>
		/// <returns>
		/// Returns <see cref="F:PInvoke.NTSTATUS.Code.STATUS_SUCCESS" /> on success, or the appropriate <see cref="T:PInvoke.NTSTATUS" /> error code on failure.
		/// </returns>
		public static unsafe NTSTATUS NtOpenSection(out NTDll.SafeNTObjectHandle sectionHandle,
		                                            Kernel32.ACCESS_MASK desiredAccess,
		                                            NTDll.OBJECT_ATTRIBUTES objectAttributes) {
			return NTDll.NtOpenSection(out sectionHandle, desiredAccess, &objectAttributes);
		}

		/// <summary>
		/// The OBJECT_ATTRIBUTES structure specifies attributes that can be applied to objects or object handles by routines that create objects and/or return handles to objects.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct OBJECT_ATTRIBUTES {
			/// <summary>
			/// The number of bytes of data contained in this structure. The <see cref="M:PInvoke.NTDll.OBJECT_ATTRIBUTES.Create" /> method sets this member to <c>sizeof(OBJECT_ATTRIBUTES)</c>.
			/// </summary>
			public int Length;

			/// <summary>
			/// Optional handle to the root object directory for the path name specified by the ObjectName member.
			/// If RootDirectory is NULL, <see cref="F:PInvoke.NTDll.OBJECT_ATTRIBUTES.ObjectName" /> must point to a fully qualified object name that includes the full path to the target object.
			/// If RootDirectory is non-NULL, <see cref="F:PInvoke.NTDll.OBJECT_ATTRIBUTES.ObjectName" /> specifies an object name relative to the RootDirectory directory.
			/// The RootDirectory handle can refer to a file system directory or an object directory in the object manager namespace.
			/// </summary>
			public IntPtr RootDirectory;

			/// <summary>
			/// A <see cref="T:PInvoke.NTDll.UNICODE_STRING" /> that contains the name of the object for which a handle is to be opened.
			/// This must either be a fully qualified object name, or a relative path name to the directory specified by the <see cref="F:PInvoke.NTDll.OBJECT_ATTRIBUTES.RootDirectory" /> member.
			/// </summary>
			public unsafe NTDll.UNICODE_STRING* ObjectName;

			/// <summary>
			/// Bitmask of flags that specify object handle attributes.
			/// </summary>
			public NTDll.OBJECT_ATTRIBUTES.ObjectHandleAttributes Attributes;

			/// <summary>
			/// Specifies a security descriptor (SECURITY_DESCRIPTOR) for the object when the object is created. If this member is NULL, the object will receive default security settings.
			/// </summary>
			public unsafe Kernel32.SECURITY_DESCRIPTOR* SecurityDescriptor;

			/// <summary>
			/// Optional quality of service to be applied to the object when it is created. Used to indicate the security impersonation level and context tracking mode (dynamic or static). Currently, the InitializeObjectAttributes macro sets this member to <see langword="null" />.
			/// </summary>
			public unsafe void* SecurityQualityOfService;

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.NTDll.OBJECT_ATTRIBUTES" /> structure.
			/// </summary>
			/// <returns>An <see cref="T:PInvoke.NTDll.OBJECT_ATTRIBUTES" /> instance with <see cref="F:PInvoke.NTDll.OBJECT_ATTRIBUTES.Length" /> initialized.</returns>
			public static NTDll.OBJECT_ATTRIBUTES Create() {
				return new NTDll.OBJECT_ATTRIBUTES() {
					Length = Marshal.SizeOf(typeof(NTDll.OBJECT_ATTRIBUTES))
				};
			}

			/// <summary>
			/// A <see cref="T:PInvoke.NTDll.UNICODE_STRING" /> that contains the name of the object for which a handle is to be opened.
			/// This must either be a fully qualified object name, or a relative path name to the directory specified by the <see cref="F:PInvoke.NTDll.OBJECT_ATTRIBUTES.RootDirectory" /> member.
			/// </summary>
			public unsafe IntPtr ObjectName_IntPtr {
				get { return new IntPtr((void*) this.ObjectName); }
				set { this.ObjectName = (NTDll.UNICODE_STRING*) value.ToPointer(); }
			}

			/// <summary>
			/// Specifies a security descriptor (SECURITY_DESCRIPTOR) for the object when the object is created. If this member is NULL, the object will receive default security settings.
			/// </summary>
			public unsafe IntPtr SecurityDescriptor_IntPtr {
				get { return new IntPtr((void*) this.SecurityDescriptor); }
				set { this.SecurityDescriptor = (Kernel32.SECURITY_DESCRIPTOR*) value.ToPointer(); }
			}

			/// <summary>
			/// Optional quality of service to be applied to the object when it is created. Used to indicate the security impersonation level and context tracking mode (dynamic or static). Currently, the InitializeObjectAttributes macro sets this member to <see langword="null" />.
			/// </summary>
			public unsafe IntPtr SecurityQualityOfService_IntPtr {
				get { return new IntPtr(this.SecurityQualityOfService); }
				set { this.SecurityQualityOfService = value.ToPointer(); }
			}

			/// <summary>
			/// Possible flags for the <see cref="F:PInvoke.NTDll.OBJECT_ATTRIBUTES.Attributes" /> field.
			/// </summary>
			[Flags]
			[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
			public enum ObjectHandleAttributes {
				OBJ_INHERIT = 2,
				OBJ_PERMANENT = 16, // 0x00000010
				OBJ_EXCLUSIVE = 32, // 0x00000020
				OBJ_CASE_INSENSITIVE = 64, // 0x00000040
				OBJ_OPENIF = 128, // 0x00000080
				OBJ_OPENLINK = 256, // 0x00000100
				OBJ_KERNEL_HANDLE = 512, // 0x00000200
				OBJ_FORCE_ACCESS_CHECK = 1024, // 0x00000400

				OBJ_VALID_ATTRIBUTES =
					OBJ_FORCE_ACCESS_CHECK | OBJ_KERNEL_HANDLE | OBJ_OPENLINK | OBJ_OPENIF | OBJ_CASE_INSENSITIVE |
					OBJ_EXCLUSIVE | OBJ_PERMANENT | OBJ_INHERIT, // 0x000007F2
			}
		}

		/// <summary>
		/// A <see cref="T:System.Runtime.InteropServices.SafeHandle" /> that closes with <see cref="M:PInvoke.NTDll.NtClose(System.IntPtr)" />.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public class SafeNTObjectHandle : SafeHandle {
			/// <summary>
			/// A handle that may be used in place of <see cref="F:System.IntPtr.Zero" />.
			/// </summary>
			public static readonly NTDll.SafeNTObjectHandle Null = new NTDll.SafeNTObjectHandle();

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.NTDll.SafeNTObjectHandle" /> class.
			/// </summary>
			public SafeNTObjectHandle()
				: base(IntPtr.Zero, true) { }

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PInvoke.NTDll.SafeNTObjectHandle" /> class.
			/// </summary>
			/// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
			/// <param name="ownsHandle">
			///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
			///     <see langword="false" /> otherwise.
			/// </param>
			public SafeNTObjectHandle(IntPtr preexistingHandle, bool ownsHandle = true)
				: base(IntPtr.Zero, ownsHandle) {
				this.SetHandle(preexistingHandle);
			}

			/// <inheritdoc />
			public override bool IsInvalid {
				get { return this.handle == IntPtr.Zero; }
			}

			/// <inheritdoc />
			protected override bool ReleaseHandle() {
				return NTDll.NtClose(this.handle).Severity == NTSTATUS.SeverityCode.STATUS_SEVERITY_SUCCESS;
			}
		}

		/// <summary>
		/// The UNICODE_STRING structure is used to define Unicode strings.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct UNICODE_STRING {
			/// <summary>
			/// The length, in bytes, of the string stored in <see cref="F:PInvoke.NTDll.UNICODE_STRING.Buffer" />.
			/// </summary>
			public ushort Length;

			/// <summary>
			/// The length, in bytes, of <see cref="F:PInvoke.NTDll.UNICODE_STRING.Buffer" />.
			/// </summary>
			public ushort MaximumLength;

			/// <summary>
			/// Pointer to a buffer used to contain a string of wide characters.
			/// </summary>
			public unsafe char* Buffer;

			/// <summary>
			/// Pointer to a buffer used to contain a string of wide characters.
			/// </summary>
			public unsafe IntPtr Buffer_IntPtr {
				get { return new IntPtr((void*) this.Buffer); }
				set { this.Buffer = (char*) value.ToPointer(); }
			}
		}
	}
}