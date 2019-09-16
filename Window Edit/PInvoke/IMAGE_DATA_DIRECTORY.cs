// Decompiled with JetBrains decompiler
// Type: PInvoke.IMAGE_DATA_DIRECTORY
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

namespace PInvoke
{
  /// <summary>Represents the data directory.</summary>
  /// <remarks>
  /// See remarks on MSDN: https://msdn.microsoft.com/en-us/library/windows/desktop/ms680305(v=vs.85).aspx
  /// </remarks>
  public struct IMAGE_DATA_DIRECTORY
  {
    /// <summary>The relative virtual address of the table.</summary>
    public uint VirtualAddress;
    /// <summary>The size of the table, in bytes.</summary>
    public uint Size;
  }
}
