// Decompiled with JetBrains decompiler
// Type: PInvoke.LIST_ENTRY
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

using System;

namespace PInvoke
{
  /// <summary>Describes a link in a doubly-linked list.</summary>
  public struct LIST_ENTRY
  {
    public unsafe LIST_ENTRY* Flink;
    public unsafe LIST_ENTRY* Blink;

    public unsafe IntPtr Flink_IntPtr
    {
      get
      {
        return new IntPtr((void*) this.Flink);
      }
      set
      {
        this.Flink = (LIST_ENTRY*) value.ToPointer();
      }
    }

    public unsafe IntPtr Blink_IntPtr
    {
      get
      {
        return new IntPtr((void*) this.Blink);
      }
      set
      {
        this.Blink = (LIST_ENTRY*) value.ToPointer();
      }
    }
  }
}
