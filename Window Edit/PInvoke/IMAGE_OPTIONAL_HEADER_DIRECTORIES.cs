// Decompiled with JetBrains decompiler
// Type: PInvoke.IMAGE_OPTIONAL_HEADER_DIRECTORIES
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

using System;

namespace PInvoke
{
  /// <summary>
  /// Describes a fixed array of 16 <see cref="T:PInvoke.IMAGE_DATA_DIRECTORY" /> structures,
  /// where the array is *not* allocated on the heap.
  /// </summary>
  public struct IMAGE_OPTIONAL_HEADER_DIRECTORIES
  {
    public IMAGE_DATA_DIRECTORY ExportTable;
    public IMAGE_DATA_DIRECTORY ImportTable;
    public IMAGE_DATA_DIRECTORY ResourceTable;
    public IMAGE_DATA_DIRECTORY ExceptionTable;
    public IMAGE_DATA_DIRECTORY CertificateTable;
    public IMAGE_DATA_DIRECTORY BaseRelocationTable;
    public IMAGE_DATA_DIRECTORY Debug;
    public IMAGE_DATA_DIRECTORY Architecture;
    public IMAGE_DATA_DIRECTORY GlobalPtr;
    public IMAGE_DATA_DIRECTORY TLSTable;
    public IMAGE_DATA_DIRECTORY LoadConfigTable;
    public IMAGE_DATA_DIRECTORY BoundImport;
    public IMAGE_DATA_DIRECTORY IAT;
    public IMAGE_DATA_DIRECTORY DelayImportDescriptor;
    public IMAGE_DATA_DIRECTORY CLRRuntimeHeader;
    public IMAGE_DATA_DIRECTORY Reserved;

    public IMAGE_DATA_DIRECTORY this[int index]
    {
      get
      {
        switch (index)
        {
          case 0:
            return this.ExportTable;
          case 1:
            return this.ImportTable;
          case 2:
            return this.ResourceTable;
          case 3:
            return this.ExceptionTable;
          case 4:
            return this.CertificateTable;
          case 5:
            return this.BaseRelocationTable;
          case 6:
            return this.Debug;
          case 7:
            return this.Architecture;
          case 8:
            return this.GlobalPtr;
          case 9:
            return this.TLSTable;
          case 10:
            return this.LoadConfigTable;
          case 11:
            return this.BoundImport;
          case 12:
            return this.IAT;
          case 13:
            return this.DelayImportDescriptor;
          case 14:
            return this.CLRRuntimeHeader;
          case 15:
            return this.Reserved;
          default:
            throw new IndexOutOfRangeException();
        }
      }
      set
      {
        switch (index)
        {
          case 0:
            this.ExportTable = value;
            break;
          case 1:
            this.ImportTable = value;
            break;
          case 2:
            this.ResourceTable = value;
            break;
          case 3:
            this.ExceptionTable = value;
            break;
          case 4:
            this.CertificateTable = value;
            break;
          case 5:
            this.BaseRelocationTable = value;
            break;
          case 6:
            this.Debug = value;
            break;
          case 7:
            this.Architecture = value;
            break;
          case 8:
            this.GlobalPtr = value;
            break;
          case 9:
            this.TLSTable = value;
            break;
          case 10:
            this.LoadConfigTable = value;
            break;
          case 11:
            this.BoundImport = value;
            break;
          case 12:
            this.IAT = value;
            break;
          case 13:
            this.DelayImportDescriptor = value;
            break;
          case 14:
            this.CLRRuntimeHeader = value;
            break;
          case 15:
            this.Reserved = value;
            break;
          default:
            throw new IndexOutOfRangeException();
        }
      }
    }
  }
}
