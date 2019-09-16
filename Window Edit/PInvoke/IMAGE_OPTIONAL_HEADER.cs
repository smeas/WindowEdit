// Decompiled with JetBrains decompiler
// Type: PInvoke.IMAGE_OPTIONAL_HEADER
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

using System;

namespace PInvoke
{
  /// <content>
  /// Contains the <see cref="T:PInvoke.IMAGE_OPTIONAL_HEADER.DllCharacteristicsType" /> nested type.
  /// </content>
  /// <content>
  /// Contains the <see cref="T:PInvoke.IMAGE_OPTIONAL_HEADER.MagicType" /> nested type.
  /// </content>
  /// <content>
  /// Contains the <see cref="T:PInvoke.IMAGE_OPTIONAL_HEADER.SubsystemType" /> nested type.
  /// </content>
  /// <summary>Represents the optional header format.</summary>
  /// <remarks>
  /// <para>The <see cref="T:System.UIntPtr" /> fields are typed such so that their size in memory
  /// changes according to the bitness of the process, as it must be.
  /// This allows this one struct to play the role of both IMAGE_OPTIONAL_HEADER32
  /// and IMAGE_OPTIONAL_HEADER64 from native code.
  /// </para>
  /// <para>The number of directories is not fixed. Check the NumberOfRvaAndSizes member before looking for a specific directory.</para>
  /// </remarks>
  public struct IMAGE_OPTIONAL_HEADER
  {
    /// <summary>The state of the image file.</summary>
    public IMAGE_OPTIONAL_HEADER.MagicType Magic;
    /// <summary>The major version number of the linker.</summary>
    public byte MajorLinkerVersion;
    /// <summary>The minor version number of the linker.</summary>
    public byte MinorLinkerVersion;
    /// <summary>
    /// The size of the code section, in bytes, or the sum of all such sections if there are multiple code sections.
    /// </summary>
    public uint SizeOfCode;
    /// <summary>
    /// The size of the initialized data section, in bytes, or the sum of all such sections if there are multiple initialized data sections.
    /// </summary>
    public uint SizeOfInitializedData;
    /// <summary>
    /// The size of the uninitialized data section, in bytes, or the sum of all such sections if there are multiple uninitialized data sections.
    /// </summary>
    public uint SizeOfUninitializedData;
    /// <summary>
    /// A pointer to the entry point function, relative to the image base address. For executable files, this is the starting address. For device drivers, this is the address of the initialization function. The entry point function is optional for DLLs. When no entry point is present, this member is zero.
    /// </summary>
    public uint AddressOfEntryPoint;
    /// <summary>
    /// A pointer to the beginning of the code section, relative to the image base.
    /// </summary>
    public uint BaseOfCode;
    /// <summary>
    /// A pointer to the beginning of the data section, relative to the image base.
    /// </summary>
    public uint BaseOfData;
    /// <summary>
    /// The preferred address of the first byte of the image when it is loaded in memory. This value is a multiple of 64K bytes. The default value for DLLs is 0x10000000. The default value for applications is 0x00400000, except on Windows CE where it is 0x00010000.
    /// </summary>
    public UIntPtr ImageBase;
    /// <summary>
    /// The alignment of sections loaded in memory, in bytes. This value must be greater than or equal to the FileAlignment member. The default value is the page size for the system.
    /// </summary>
    public uint SectionAlignment;
    /// <summary>
    /// The alignment of the raw data of sections in the image file, in bytes. The value should be a power of 2 between 512 and 64K (inclusive). The default is 512. If the SectionAlignment member is less than the system page size, this member must be the same as SectionAlignment.
    /// </summary>
    public uint FileAlignment;
    /// <summary>
    /// The major version number of the required operating system.
    /// </summary>
    public ushort MajorOperatingSystemVersion;
    /// <summary>
    /// The minor version number of the required operating system.
    /// </summary>
    public ushort MinorOperatingSystemVersion;
    /// <summary>The major version number of the image.</summary>
    public ushort MajorImageVersion;
    /// <summary>The minor version number of the image.</summary>
    public ushort MinorImageVersion;
    /// <summary>The major version number of the subsystem.</summary>
    public ushort MajorSubsystemVersion;
    /// <summary>The minor version number of the subsystem.</summary>
    public ushort MinorSubsystemVersion;
    /// <summary>This member is reserved and must be 0.</summary>
    public uint Win32VersionValue;
    /// <summary>
    /// The size of the image, in bytes, including all headers. Must be a multiple of SectionAlignment.
    /// </summary>
    public uint SizeOfImage;
    /// <summary>
    /// The combined size of the following items, rounded to a multiple of the value specified in the FileAlignment member.
    /// <list type="bullet">
    /// <item>e_lfanew member of IMAGE_DOS_HEADER</item>
    /// <item>4 byte signature</item>
    /// <item>size of IMAGE_FILE_HEADER</item>
    /// <item>size of optional header</item>
    /// <item>size of all section headers</item>
    /// </list>
    /// </summary>
    public uint SizeOfHeaders;
    /// <summary>
    /// The image file checksum. The following files are validated at load time: all drivers, any DLL loaded at boot time, and any DLL loaded into a critical system process.
    /// </summary>
    public uint CheckSum;
    /// <summary>The subsystem required to run this image.</summary>
    public IMAGE_OPTIONAL_HEADER.SubsystemType Subsystem;
    /// <summary>The DLL characteristics of the image.</summary>
    public IMAGE_OPTIONAL_HEADER.DllCharacteristicsType DllCharacteristics;
    /// <summary>
    /// The number of bytes to reserve for the stack. Only the memory specified by the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.SizeOfStackCommit" /> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
    /// </summary>
    public UIntPtr SizeOfStackReserve;
    /// <summary>The number of bytes to commit for the stack.</summary>
    public UIntPtr SizeOfStackCommit;
    /// <summary>
    /// The number of bytes to reserve for the local heap. Only the memory specified by the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.SizeOfHeapCommit" /> member is committed at load time; the rest is made available one page at a time until this reserve size is reached.
    /// </summary>
    public UIntPtr SizeOfHeapReserve;
    /// <summary>The number of bytes to commit for the local heap.</summary>
    public UIntPtr SizeOfHeapCommit;
    /// <summary>This member is obsolete.</summary>
    [Obsolete]
    public uint LoaderFlags;
    /// <summary>
    /// The number of directory entries in the remainder of the optional header. Each entry describes a location and size.
    /// </summary>
    public uint NumberOfRvaAndSizes;
    /// <summary>
    /// A pointer to the first <see cref="T:PInvoke.IMAGE_DATA_DIRECTORY" /> structure in the data directory.
    /// </summary>
    public IMAGE_OPTIONAL_HEADER_DIRECTORIES DataDirectory;

    /// <summary>
    /// Enumerates flags that may be found in the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.DllCharacteristics" /> field.
    /// </summary>
    [Flags]
    public enum DllCharacteristicsType : ushort
    {
      Reserved1 = 1,
      Reserved2 = 2,
      Reserved3 = 4,
      Reserved4 = 8,
      IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE = 64, // 0x0040
      IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY = 128, // 0x0080
      IMAGE_DLLCHARACTERISTICS_NX_COMPAT = 256, // 0x0100
      IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 512, // 0x0200
      IMAGE_DLLCHARACTERISTICS_NO_SEH = 1024, // 0x0400
      IMAGE_DLLCHARACTERISTICS_NO_BIND = 2048, // 0x0800
      Reserved5 = 4096, // 0x1000
      IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 8192, // 0x2000
      Reserved6 = 16384, // 0x4000
      IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 32768, // 0x8000
    }

    /// <summary>
    /// Expected values for the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.Magic" /> field.
    /// </summary>
    public enum MagicType : ushort
    {
      IMAGE_ROM_OPTIONAL_HDR_MAGIC = 263, // 0x0107
      IMAGE_NT_OPTIONAL_HDR32_MAGIC = 267, // 0x010B
      IMAGE_NT_OPTIONAL_HDR64_MAGIC = 523, // 0x020B
    }

    /// <summary>
    /// Describes expected values for the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.Subsystem" /> field.
    /// </summary>
    public enum SubsystemType : ushort
    {
      IMAGE_SUBSYSTEM_UNKNOWN = 0,
      IMAGE_SUBSYSTEM_NATIVE = 1,
      IMAGE_SUBSYSTEM_WINDOWS_GUI = 2,
      IMAGE_SUBSYSTEM_WINDOWS_CUI = 3,
      IMAGE_SUBSYSTEM_OS2_CUI = 5,
      IMAGE_SUBSYSTEM_POSIX_CUI = 7,
      IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9,
      IMAGE_SUBSYSTEM_EFI_APPLICATION = 10, // 0x000A
      IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11, // 0x000B
      IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12, // 0x000C
      IMAGE_SUBSYSTEM_EFI_ROM = 13, // 0x000D
      IMAGE_SUBSYSTEM_XBOX = 14, // 0x000E
      IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = 16, // 0x0010
    }
  }
}
