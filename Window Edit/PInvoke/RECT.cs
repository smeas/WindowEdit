// Decompiled with JetBrains decompiler
// Type: PInvoke.RECT
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

namespace PInvoke
{
  /// <summary>
  /// The RECT structure defines the coordinates of the upper-left and lower-right corners of a rectangle.
  /// </summary>
  /// <remarks>
  /// By convention, the right and bottom edges of the rectangle are normally considered exclusive.
  /// In other words, the pixel whose coordinates are ( right, bottom ) lies immediately outside of the rectangle.
  /// For example, when RECT is passed to the FillRect function, the rectangle is filled up to, but not including,
  /// the right column and bottom row of pixels. This structure is identical to the RECTL structure.
  /// </remarks>
  public struct RECT
  {
    /// <summary>
    /// The x-coordinate of the upper-left corner of the rectangle.
    /// </summary>
    public int left;
    /// <summary>
    /// The y-coordinate of the upper-left corner of the rectangle.
    /// </summary>
    public int top;
    /// <summary>
    /// The x-coordinate of the lower-right corner of the rectangle.
    /// </summary>
    public int right;
    /// <summary>
    /// The y-coordinate of the lower-right corner of the rectangle.
    /// </summary>
    public int bottom;
  }
}
