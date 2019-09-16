// Decompiled with JetBrains decompiler
// Type: PInvoke.IMAGE_FILE_HEADER
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

using System;

namespace PInvoke
{
  /// <content>
  /// Contains the <see cref="T:PInvoke.IMAGE_FILE_HEADER.CharacteristicsType" /> nested type.
  /// </content>
  /// <content>
  /// Contains the <see cref="T:PInvoke.IMAGE_FILE_HEADER.MachineType" /> nested type.
  /// </content>
  /// <summary>Represents the COFF header format.</summary>
  public struct IMAGE_FILE_HEADER
  {
    /// <summary>
    /// The architecture type of the computer. An image file can only be run on the specified computer or a system that emulates the specified computer.
    /// </summary>
    public IMAGE_FILE_HEADER.MachineType Machine;
    /// <summary>
    /// The number of sections. This indicates the size of the section table, which immediately follows the headers. Note that the Windows loader limits the number of sections to 96.
    /// </summary>
    public ushort NumberOfSections;
    /// <summary>
    /// The low 32 bits of the time stamp of the image. This represents the date and time the image was created by the linker. The value is represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.
    /// </summary>
    public uint TimeDateStamp;
    /// <summary>
    /// The offset of the symbol table, in bytes, or zero if no COFF symbol table exists.
    /// </summary>
    public uint PointerToSymbolTable;
    /// <summary>The number of symbols in the symbol table.</summary>
    public uint NumberOfSymbols;
    /// <summary>
    /// The size of the optional header, in bytes. This value should be 0 for object files.
    /// </summary>
    public ushort SizeOfOptionalHeader;
    /// <summary>The characteristics of the image.</summary>
    public IMAGE_FILE_HEADER.CharacteristicsType Characteristics;

    /// <summary>
    /// Enumerates the expected values from the <see cref="F:PInvoke.IMAGE_FILE_HEADER.Characteristics" /> field.
    /// </summary>
    [Flags]
    public enum CharacteristicsType : ushort
    {
      IMAGE_FILE_RELOCS_STRIPPED = 1,
      IMAGE_FILE_EXECUTABLE_IMAGE = 2,
      IMAGE_FILE_LINE_NUMS_STRIPPED = 4,
      IMAGE_FILE_LOCAL_SYMS_STRIPPED = 8,
      [Obsolete] IMAGE_FILE_AGGRESIVE_WS_TRIM = 16, // 0x0010
      IMAGE_FILE_LARGE_ADDRESS_AWARE = 32, // 0x0020
      [Obsolete] IMAGE_FILE_BYTES_REVERSED_LO = 128, // 0x0080
      IMAGE_FILE_32BIT_MACHINE = 256, // 0x0100
      IMAGE_FILE_DEBUG_STRIPPED = 512, // 0x0200
      IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 1024, // 0x0400
      IMAGE_FILE_NET_RUN_FROM_SWAP = 2048, // 0x0800
      IMAGE_FILE_SYSTEM = 4096, // 0x1000
      IMAGE_FILE_DLL = 8192, // 0x2000
      IMAGE_FILE_UP_SYSTEM_ONLY = 16384, // 0x4000
      [Obsolete] IMAGE_FILE_BYTES_REVERSED_HI = 32768, // 0x8000
    }

    /// <summary>
    /// Describes the expected values of the <see cref="F:PInvoke.IMAGE_FILE_HEADER.Machine" /> field.
    /// </summary>
    public enum MachineType : ushort
    {
      IMAGE_FILE_MACHINE_I386 = 332, // 0x014C
      IMAGE_FILE_MACHINE_IA64 = 512, // 0x0200
      IMAGE_FILE_MACHINE_AMD64 = 34404, // 0x8664
    }
  }
}
