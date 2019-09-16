// Decompiled with JetBrains decompiler
// Type: PInvoke.PInvokeExtensions
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

namespace PInvoke
{
  /// <summary>Extension methods for commonly defined types.</summary>
  public static class PInvokeExtensions
  {
    /// <summary>
    /// Converts an <see cref="T:PInvoke.NTSTATUS" /> to an <see cref="T:PInvoke.HResult" />.
    /// </summary>
    /// <param name="status">The <see cref="T:PInvoke.NTSTATUS" /> to convert.</param>
    /// <returns>The <see cref="T:PInvoke.HResult" />.</returns>
    public static HResult ToHResult(this NTSTATUS status)
    {
      return (HResult) ((uint) status | 268435456U);
    }

    /// <summary>
    /// Converts a <see cref="T:PInvoke.Win32ErrorCode" /> to an <see cref="T:PInvoke.HResult" />.
    /// </summary>
    /// <param name="error">The <see cref="T:PInvoke.Win32ErrorCode" /> to convert.</param>
    /// <returns>The <see cref="T:PInvoke.HResult" /></returns>
    public static HResult ToHResult(this Win32ErrorCode error)
    {
      if (error > Win32ErrorCode.ERROR_SUCCESS)
        return (HResult) ((int) ((long) (error & (Win32ErrorCode) 65535 | (Win32ErrorCode) 458752) | 2147483648L));
      return (HResult) ((int) error);
    }

    /// <summary>
    /// Allocates an array of characters to represent the specified string, with a null terminating character as the last array element.
    /// </summary>
    /// <param name="value">The string to represent as a character array.</param>
    /// <returns>The character array with null terminator.</returns>
    public static char[] ToCharArrayWithNullTerminator(this string value)
    {
      char[] destination = new char[value.Length + 1];
      value.CopyTo(0, destination, 0, value.Length);
      return destination;
    }
  }
}
