// Decompiled with JetBrains decompiler
// Type: PInvoke.Kernel32Extensions
// Assembly: PInvoke.Kernel32, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: C15E8763-BB9D-4EBC-8549-4F3970187329
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.kernel32\0.5.155\lib\net40\PInvoke.Kernel32.dll

using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace PInvoke
{
  /// <content>Desktop-only extension methods for Kernel32.</content>
  /// <summary>
  /// Extension methods available for and from the Kernel32 library.
  /// </summary>
  [StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
  public static class Kernel32Extensions
  {
    /// <summary>
    /// The maximum memory we are willing to allocate for the exception message.
    /// </summary>
    private const int MaxAllowedBufferSize = 66560;

    /// <summary>
    /// Gets the text associated with an <see cref="T:PInvoke.NTSTATUS" />.
    /// </summary>
    /// <param name="status">The error code.</param>
    /// <returns>The error message. Or <c>null</c> if no message could be found.</returns>
    public static string GetMessage(this NTSTATUS status)
    {
      using (Kernel32.SafeLibraryHandle safeLibraryHandle = Kernel32.LoadLibrary("ntdll.dll"))
      {
        int lcid = CultureInfo.CurrentCulture.LCID;
        string str = Kernel32.FormatMessage(Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE, safeLibraryHandle.DangerousGetHandle(), NTSTATUS.op_Explicit(status), lcid, (IntPtr[]) null, 66560);
        if (str != null)
          return str;
      }
      return (string) null;
    }

    /// <summary>
    /// Gets the text associated with a <see cref="T:PInvoke.Win32ErrorCode" />.
    /// </summary>
    /// <param name="error">The error code.</param>
    /// <returns>The error message. Or <c>null</c> if no message could be found.</returns>
    public static unsafe string GetMessage(this Win32ErrorCode error)
    {
      int lcid = CultureInfo.CurrentCulture.LCID;
      return Kernel32.FormatMessage(Kernel32.FormatMessageFlags.FORMAT_MESSAGE_FROM_SYSTEM, (void*) null, (int) error, lcid, (IntPtr[]) null, 66560);
    }

    /// <summary>Throws an exception when an error occurs.</summary>
    /// <param name="errorCode">The result of the P/Invoke call.</param>
    /// <exception cref="T:PInvoke.Win32Exception">If <paramref name="errorCode" /> is not <see cref="F:PInvoke.Win32ErrorCode.ERROR_SUCCESS" /></exception>
    public static void ThrowOnError(this Win32ErrorCode errorCode)
    {
      if (errorCode != null)
        throw new Win32Exception(errorCode);
    }

    /// <summary>Throws an exception if a P/Invoke failed.</summary>
    /// <param name="status">The result of the P/Invoke call.</param>
    public static void ThrowOnError(this NTSTATUS status)
    {
      if (((NTSTATUS) ref status).get_Severity() == -1073741824)
        throw new NTStatusException(status);
    }
  }
}
