// Decompiled with JetBrains decompiler
// Type: PInvoke.Psapi
// Assembly: PInvoke.Psapi, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: C98A40BD-AF37-4D3A-887F-EB31B5F0B568
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.psapi\0.5.152\lib\net40\PInvoke.Psapi.dll

using System;
using System.Runtime.InteropServices;

namespace PInvoke {
	/// <content>
	/// Contains the <see cref="T:PInvoke.Psapi.EnumProcessModulesFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Psapi.MODULEINFO" /> nested type.
	/// </content>
	/// <content>Exported functions from the Psapi.dll Windows library that are available to Desktop apps only.</content>
	/// <devremark>
	///     In Windows 7 and higher all the Psapi functions are also exported by Kernel32 under the name K32Xxx Where "Xxx" is
	///     the original name. For each function added here, please add the equivalent one in <see cref="T:PInvoke.Kernel32" />.
	///     <para>
	///         You should also add to the <see cref="T:PInvoke.Kernel32" /> version a note in the remarks about this. See
	///         <see cref="M:PInvoke.Kernel32.K32EmptyWorkingSet(PInvoke.Kernel32.SafeObjectHandle)" /> for an example.
	///     </para>
	/// </devremark>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Psapi.EnumProcessModulesFlags" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.Psapi.MODULEINFO" /> nested type.
	/// </content>
	/// <content>Exported functions from the Psapi.dll Windows library that are available to Desktop apps only.</content>
	/// <devremark>
	///     In Windows 7 and higher all the Psapi functions are also exported by Kernel32 under the name K32Xxx Where "Xxx" is
	///     the original name. For each function added here, please add the equivalent one in <see cref="T:PInvoke.Kernel32" />.
	///     <para>
	///         You should also add to the <see cref="T:PInvoke.Kernel32" /> version a note in the remarks about this. See
	///         <see cref="M:PInvoke.Kernel32.K32EmptyWorkingSet(PInvoke.Kernel32.SafeObjectHandle)" /> for an example.
	///     </para>
	/// </devremark>
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public static class Psapi {
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
		[DllImport("Psapi", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EmptyWorkingSet(Kernel32.SafeObjectHandle hProcess);

		/// <summary>
		/// Retrieves a handle for each module in the specified process that meets the specified filter criteria.
		/// </summary>
		/// <param name="hProcess">A handle to the process.</param>
		/// <param name="lphModule">An array that receives the list of module handles.</param>
		/// <param name="cb">The size of the <paramref name="lphModule" /> array, in bytes.</param>
		/// <param name="lpcbNeeded">The number of bytes required to store all module handles in the <paramref name="lphModule" /> array.</param>
		/// <param name="dwFilterFlag">The filter criteria. This parameter can be one of the following values.</param>
		/// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
		[DllImport("Psapi", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern unsafe bool EnumProcessModulesEx(IntPtr hProcess, IntPtr* lphModule, int cb,
		                                                      out int lpcbNeeded,
		                                                      Psapi.EnumProcessModulesFlags dwFilterFlag);

		/// <summary>
		/// Retrieves information about the specified module in the <see cref="T:PInvoke.Psapi.MODULEINFO" /> structure.
		/// </summary>
		/// <param name="hProcess">A handle to the process that contains the module.</param>
		/// <param name="hModule">A handle to the module.</param>
		/// <param name="lpmodinfo">A pointer to the MODULEINFO structure that receives information about the module.</param>
		/// <param name="cb">The size of the <see cref="T:PInvoke.Psapi.MODULEINFO" /> structure, in bytes.</param>
		/// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
		[DllImport("Psapi", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetModuleInformation(IntPtr hProcess, IntPtr hModule, out Psapi.MODULEINFO lpmodinfo,
		                                               int cb);

		/// <summary>
		/// Retrieves the fully qualified path for the file containing the specified module.
		/// </summary>
		/// <param name="hProcess">A handle to the process that contains the module.</param>
		/// <param name="hModule">A handle to the module. If this parameter is NULL, GetModuleFileNameEx returns the path of the executable file of the process specified in hProcess.</param>
		/// <param name="lpFilename">A pointer to a buffer that receives the fully qualified path to the module. If the size of the file name is larger than the value of the nSize parameter, the function succeeds but the file name is truncated and null-terminated.</param>
		/// <param name="nSize">The size of the lpFilename buffer, in characters.</param>
		/// <returns>If the function succeeds, the return value specifies the length of the string copied to the buffer. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
		[DllImport("Psapi", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern unsafe int GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, char* lpFilename,
		                                                    int nSize);

		/// <summary>
		/// Retrieves a handle for each module in the specified process that meets the specified filter criteria.
		/// </summary>
		/// <param name="hProcess">A handle to the process.</param>
		/// <param name="lphModule">An array that receives the list of module handles.</param>
		/// <param name="cb">The size of the <paramref name="lphModule" /> array, in bytes.</param>
		/// <param name="lpcbNeeded">The number of bytes required to store all module handles in the <paramref name="lphModule" /> array.</param>
		/// <param name="dwFilterFlag">The filter criteria. This parameter can be one of the following values.</param>
		/// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
		public static unsafe bool EnumProcessModulesEx(IntPtr hProcess, IntPtr lphModule, int cb, out int lpcbNeeded,
		                                               Psapi.EnumProcessModulesFlags dwFilterFlag) {
			IntPtr* pointer = (IntPtr*) lphModule.ToPointer();
			return Psapi.EnumProcessModulesEx(hProcess, pointer, cb, out lpcbNeeded, dwFilterFlag);
		}

		/// <summary>
		/// Retrieves a handle for each module in the specified process that meets the specified filter criteria.
		/// </summary>
		/// <param name="hProcess">A handle to the process.</param>
		/// <param name="lphModule">An array that receives the list of module handles.</param>
		/// <param name="cb">The size of the <paramref name="lphModule" /> array, in bytes.</param>
		/// <param name="lpcbNeeded">The number of bytes required to store all module handles in the <paramref name="lphModule" /> array.</param>
		/// <param name="dwFilterFlag">The filter criteria. This parameter can be one of the following values.</param>
		/// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
		public static unsafe bool EnumProcessModulesEx(IntPtr hProcess, IntPtr[] lphModule, int cb, out int lpcbNeeded,
		                                               Psapi.EnumProcessModulesFlags dwFilterFlag) {
			IntPtr[] numArray;
			IntPtr* lphModule1 = (numArray = lphModule) == null || numArray.Length == 0 ? (IntPtr*) null : &numArray[0];
			return Psapi.EnumProcessModulesEx(hProcess, lphModule1, cb, out lpcbNeeded, dwFilterFlag);
		}

		/// <summary>
		/// Retrieves the fully qualified path for the file containing the specified module.
		/// </summary>
		/// <param name="hProcess">A handle to the process that contains the module.</param>
		/// <param name="hModule">A handle to the module. If this parameter is NULL, GetModuleFileNameEx returns the path of the executable file of the process specified in hProcess.</param>
		/// <param name="lpFilename">A pointer to a buffer that receives the fully qualified path to the module. If the size of the file name is larger than the value of the nSize parameter, the function succeeds but the file name is truncated and null-terminated.</param>
		/// <param name="nSize">The size of the lpFilename buffer, in characters.</param>
		/// <returns>If the function succeeds, the return value specifies the length of the string copied to the buffer. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
		public static unsafe int GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, IntPtr lpFilename, int nSize) {
			char* pointer = (char*) lpFilename.ToPointer();
			return Psapi.GetModuleFileNameEx(hProcess, hModule, pointer, nSize);
		}

		/// <summary>
		/// Retrieves the fully qualified path for the file containing the specified module.
		/// </summary>
		/// <param name="hProcess">A handle to the process that contains the module.</param>
		/// <param name="hModule">A handle to the module. If this parameter is NULL, GetModuleFileNameEx returns the path of the executable file of the process specified in hProcess.</param>
		/// <param name="lpFilename">A pointer to a buffer that receives the fully qualified path to the module. If the size of the file name is larger than the value of the nSize parameter, the function succeeds but the file name is truncated and null-terminated.</param>
		/// <param name="nSize">The size of the lpFilename buffer, in characters.</param>
		/// <returns>If the function succeeds, the return value specifies the length of the string copied to the buffer. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
		public static unsafe int GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, char[] lpFilename, int nSize) {
			char[] chArray;
			char* lpFilename1 = (chArray = lpFilename) == null || chArray.Length == 0 ? (char*) null : &chArray[0];
			return Psapi.GetModuleFileNameEx(hProcess, hModule, lpFilename1, nSize);
		}

		/// <summary>
		/// An enumeration determining whether to enumerate 32-bit, 64-bit or both even both architectured modules on EnumProcessModulesEx function.
		/// </summary>
		[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
		public enum EnumProcessModulesFlags : uint {
			LIST_MODULES_DEFAULT,
			LIST_MODULES_32BIT,
			LIST_MODULES_64BIT,
			LIST_MODULES_ALL,
		}

		/// <summary>
		/// The MODULEINFO structure specifies processmodules properties.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct MODULEINFO {
			/// <summary>The base address of the module</summary>
			public unsafe void* lpBaseOfDll;

			/// <summary>The size of the module</summary>
			public int SizeOfImage;

			/// <summary>The entry point of the module</summary>
			public unsafe void* EntryPoint;

			/// <summary>The base address of the module</summary>
			public unsafe IntPtr lpBaseOfDll_IntPtr {
				get { return new IntPtr(this.lpBaseOfDll); }
				set { this.lpBaseOfDll = value.ToPointer(); }
			}

			/// <summary>The entry point of the module</summary>
			public unsafe IntPtr EntryPoint_IntPtr {
				get { return new IntPtr(this.EntryPoint); }
				set { this.EntryPoint = value.ToPointer(); }
			}
		}
	}
}