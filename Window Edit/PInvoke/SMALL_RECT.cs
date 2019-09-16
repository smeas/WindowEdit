// Decompiled with JetBrains decompiler
// Type: PInvoke.SMALL_RECT
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

namespace PInvoke
{
  /// <summary>
  /// The RECT structure defines the coordinates of the upper-left and lower-right corners of a rectangle.
  /// </summary>
  /// <remarks>
  /// This structure is used by console functions to specify rectangular areas of console screen buffers,
  /// where the coordinates specify the rows and columns of screen-buffer character cells.
  /// </remarks>
  public struct SMALL_RECT
  {
    /// <summary>
    /// The x-coordinate of the upper-left corner of the rectangle.
    /// </summary>
    public short Left;
    /// <summary>
    /// The y-coordinate of the upper-left corner of the rectangle.
    /// </summary>
    public short Top;
    /// <summary>
    /// The x-coordinate of the lower-right corner of the rectangle.
    /// </summary>
    public short Right;
    /// <summary>
    /// The y-coordinate of the lower-right corner of the rectangle.
    /// </summary>
    public short Bottom;
  }
}
