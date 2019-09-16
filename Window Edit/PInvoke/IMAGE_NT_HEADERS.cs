// Decompiled with JetBrains decompiler
// Type: PInvoke.IMAGE_NT_HEADERS
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

namespace PInvoke
{
  /// <summary>Represents the PE header format.</summary>
  public struct IMAGE_NT_HEADERS
  {
    /// <summary>
    /// A 4-byte signature identifying the file as a PE image. The bytes are "PE\0\0".
    /// </summary>
    public uint Signature;
    /// <summary>
    /// An <see cref="T:PInvoke.IMAGE_FILE_HEADER" /> structure that specifies the file header.
    /// </summary>
    public IMAGE_FILE_HEADER FileHeader;
    /// <summary>
    /// An <see cref="T:PInvoke.IMAGE_OPTIONAL_HEADER" /> structure that specifies the optional file header.
    /// </summary>
    public IMAGE_OPTIONAL_HEADER OptionalHeader;
  }
}
