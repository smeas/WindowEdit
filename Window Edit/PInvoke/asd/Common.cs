using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace PInvoke {
	/// <summary>
	/// The COORD structure defines the X- and Y- coordinates of a point.
	/// </summary>
	public struct COORD {
		/// <summary>The x-coordinate of the point.</summary>
		public short X;

		/// <summary>The x-coordinate of the point.</summary>
		public short Y;
	}

	/// <content>
	/// The <see cref="T:PInvoke.HResult.Code" /> nested type.
	/// </content>
	/// <content>
	/// The <see cref="T:PInvoke.HResult.FacilityCode" /> nested type.
	/// </content>
	/// <content>
	/// The <see cref="T:PInvoke.HResult.SeverityCode" /> nested type.
	/// </content>
	/// <summary>Describes an HRESULT error or success condition.</summary>
	/// <remarks>
	///  HRESULTs are 32 bit values layed out as follows:
	/// 
	///   3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
	///   1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
	///  +-+-+-+-+-+---------------------+-------------------------------+
	///  |S|R|C|N|r|    Facility         |               Code            |
	///  +-+-+-+-+-+---------------------+-------------------------------+
	/// 
	///  where
	/// 
	///      S - Severity - indicates success/fail
	/// 
	///          0 - Success
	///          1 - Fail (COERROR)
	/// 
	///      R - reserved portion of the facility code, corresponds to NT's
	///              second severity bit.
	/// 
	///      C - reserved portion of the facility code, corresponds to NT's
	///              C field.
	/// 
	///      N - reserved portion of the facility code. Used to indicate a
	///              mapped NT status value.
	/// 
	///      r - reserved portion of the facility code. Reserved for internal
	///              use. Used to indicate HRESULT values that are not status
	///              values, but are instead message ids for display strings.
	/// 
	///      Facility - is the facility code
	/// 
	///      Code - is the facility's status code
	/// 
	/// </remarks>
	[DebuggerDisplay("{Value}")]
	public struct HResult : IComparable, IComparable<HResult>, IEquatable<HResult>, IFormattable {
		/// <summary>
		/// The mask of the bits that describe the <see cref="P:PInvoke.HResult.Severity" />.
		/// </summary>
		private const uint SeverityMask = 2147483648;

		/// <summary>
		/// The number of bits that <see cref="P:PInvoke.HResult.Severity" /> values are shifted
		/// in order to fit within <see cref="F:PInvoke.HResult.SeverityMask" />.
		/// </summary>
		private const int SeverityShift = 31;

		/// <summary>
		/// The mask of the bits that describe the <see cref="P:PInvoke.HResult.Facility" />.
		/// </summary>
		private const int FacilityMask = 134152192;

		/// <summary>
		/// The number of bits that <see cref="P:PInvoke.HResult.Facility" /> values are shifted
		/// in order to fit within <see cref="F:PInvoke.HResult.FacilityMask" />.
		/// </summary>
		private const int FacilityShift = 16;

		/// <summary>
		/// The mask of the bits that describe the <see cref="P:PInvoke.HResult.FacilityStatus" />.
		/// </summary>
		private const int FacilityStatusMask = 65535;

		/// <summary>
		/// The number of bits that <see cref="P:PInvoke.HResult.FacilityStatus" /> values are shifted
		/// in order to fit within <see cref="F:PInvoke.HResult.FacilityStatusMask" />.
		/// </summary>
		private const int FacilityStatusShift = 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.HResult" /> struct.
		/// </summary>
		/// <param name="value">The value of the HRESULT.</param>
		public HResult(HResult.Code value) {
			this.Value = value;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.HResult" /> struct.
		/// </summary>
		/// <param name="value">The value of the HRESULT.</param>
		public HResult(int value) {
			this = new HResult((HResult.Code) value);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.HResult" /> struct.
		/// </summary>
		/// <param name="value">The value of the HRESULT.</param>
		public HResult(uint value) {
			this = new HResult((HResult.Code) value);
		}

		/// <summary>
		/// Gets the full HRESULT value, as a <see cref="T:PInvoke.HResult.Code" /> enum.
		/// </summary>
		public HResult.Code Value { get; }

		/// <summary>Gets the HRESULT as a 32-bit signed integer.</summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int AsInt32 {
			get { return (int) this.Value; }
		}

		/// <summary>Gets the HRESULT as a 32-bit unsigned integer.</summary>
		public uint AsUInt32 {
			get { return (uint) this.Value; }
		}

		/// <summary>
		/// Gets a value indicating whether this HRESULT represents a successful operation.
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool Succeeded {
			get { return this.Severity == HResult.SeverityCode.Success; }
		}

		/// <summary>
		/// Gets a value indicating whether this HRESULT represents a failured operation.
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool Failed {
			get { return this.Severity == HResult.SeverityCode.Fail; }
		}

		/// <summary>Gets the facility code of the HRESULT.</summary>
		public HResult.FacilityCode Facility {
			get { return (HResult.FacilityCode) ((int) this.AsUInt32 & 134152192); }
		}

		/// <summary>Gets the severity of the HRESULT.</summary>
		public HResult.SeverityCode Severity {
			get { return (HResult.SeverityCode) ((int) this.AsUInt32 & int.MinValue); }
		}

		/// <summary>
		/// Gets the facility's status code bits from the HRESULT.
		/// </summary>
		public uint FacilityStatus {
			get { return this.AsUInt32 & (uint) ushort.MaxValue; }
		}

		/// <summary>
		/// Converts an <see cref="T:System.Int32" /> into an <see cref="T:PInvoke.HResult" />.
		/// </summary>
		/// <param name="hr">The value of the HRESULT.</param>
		public static implicit operator HResult(int hr) {
			return new HResult(hr);
		}

		/// <summary>
		/// Converts an <see cref="T:PInvoke.HResult" /> into an <see cref="T:System.Int32" />.
		/// </summary>
		/// <param name="hr">The value of the HRESULT.</param>
		public static implicit operator int(HResult hr) {
			return hr.AsInt32;
		}

		/// <summary>
		/// Converts an <see cref="T:System.UInt32" /> into an <see cref="T:PInvoke.HResult" />.
		/// </summary>
		/// <param name="hr">The value of the HRESULT.</param>
		public static implicit operator HResult(uint hr) {
			return new HResult(hr);
		}

		/// <summary>
		/// Converts an <see cref="T:PInvoke.HResult" /> into an <see cref="T:System.UInt32" />.
		/// </summary>
		/// <param name="hr">The value of the HRESULT.</param>
		public static explicit operator uint(HResult hr) {
			return hr.AsUInt32;
		}

		/// <summary>
		/// Converts a <see cref="T:PInvoke.HResult.Code" /> enum to its structural <see cref="T:PInvoke.HResult" /> representation.
		/// </summary>
		/// <param name="hr">The value to convert.</param>
		public static implicit operator HResult(HResult.Code hr) {
			return new HResult(hr);
		}

		/// <summary>
		/// Converts an <see cref="T:PInvoke.HResult" /> to its <see cref="T:PInvoke.HResult.Code" /> enum representation.
		/// </summary>
		/// <param name="hr">The value to convert.</param>
		public static implicit operator HResult.Code(HResult hr) {
			return hr.Value;
		}

		/// <summary>
		/// Checks equality between this HResult and a <see cref="T:System.UInt32" /> value.
		/// </summary>
		/// <param name="hr">An <see cref="T:PInvoke.HResult" /></param>
		/// <param name="value">Some <see cref="T:System.UInt32" /> value</param>
		/// <returns><c>true</c> if they equal; <c>false</c> otherwise.</returns>
		/// <remarks>
		/// This operator overload is useful because HResult-uint conversion must be explicit,
		/// and without this overload, it makes comparing HResults to 0x8xxxxxxx values require casts.
		/// </remarks>
		public static bool operator ==(HResult hr, uint value) {
			return (int) hr.AsUInt32 == (int) value;
		}

		/// <summary>
		/// Checks inequality between this HResult and a <see cref="T:System.UInt32" /> value.
		/// </summary>
		/// <param name="hr">An <see cref="T:PInvoke.HResult" /></param>
		/// <param name="value">Some <see cref="T:System.UInt32" /> value</param>
		/// <returns><c>true</c> if they unequal; <c>false</c> otherwise.</returns>
		/// <remarks>
		/// This operator overload is useful because HResult-uint conversion must be explicit,
		/// and without this overload, it makes comparing HResults to 0x8xxxxxxx values require casts.
		/// </remarks>
		public static bool operator !=(HResult hr, uint value) {
			return (int) hr.AsUInt32 != (int) value;
		}

		/// <summary>
		/// Throws an exception if this HRESULT <see cref="P:PInvoke.HResult.Failed" />, based on the failure value.
		/// </summary>
		public void ThrowOnFailure() {
			Marshal.ThrowExceptionForHR(this.AsInt32);
		}

		/// <summary>
		/// Throws an exception if this HRESULT <see cref="P:PInvoke.HResult.Failed" />, based on the failure value and the specified IErrorInfo interface.
		/// </summary>
		/// <param name="errorInfo">
		/// A pointer to the IErrorInfo interface that provides more information about the
		/// error. You can specify IntPtr(0) to use the current IErrorInfo interface, or
		/// IntPtr(-1) to ignore the current IErrorInfo interface and construct the exception
		/// just from the error code.
		/// </param>
		public void ThrowOnFailure(IntPtr errorInfo) {
			Marshal.ThrowExceptionForHR(this.AsInt32, errorInfo);
		}

		/// <summary>
		/// Gets an exception that represents this <see cref="T:PInvoke.HResult" />
		/// if it represents a failure.
		/// </summary>
		/// <returns>The exception, if applicable; otherwise null.</returns>
		public Exception GetException() {
			return Marshal.GetExceptionForHR((int) this);
		}

		/// <summary>
		/// Gets an exception that represents this <see cref="T:PInvoke.HResult" />
		/// if it represents a failure.
		/// </summary>
		/// <param name="errorInfo">
		/// A pointer to additional error information that may be used to populate the Exception.
		/// </param>
		/// <returns>The exception, if applicable; otherwise null.</returns>
		public Exception GetException(IntPtr errorInfo) {
			return Marshal.GetExceptionForHR((int) this, errorInfo);
		}

		/// <inheritdoc />
		public override int GetHashCode() {
			return this.AsInt32;
		}

		/// <inheritdoc />
		public bool Equals(HResult other) {
			return this.Value == other.Value;
		}

		/// <inheritdoc />
		public override bool Equals(object obj) {
			if (obj is HResult)
				return this.Equals((HResult) obj);
			return false;
		}

		/// <inheritdoc />
		public int CompareTo(object obj) {
			return ((IComparable) this.Value).CompareTo(obj);
		}

		/// <inheritdoc />
		public int CompareTo(HResult other) {
			return this.Value.CompareTo((object) other.Value);
		}

		/// <inheritdoc />
		public override string ToString() {
			return this.Value.ToString();
		}

		/// <inheritdoc />
		public string ToString(string format, IFormatProvider formatProvider) {
			return this.AsUInt32.ToString(format, formatProvider);
		}

		/// <summary>Common HRESULT constants.</summary>
		public enum Code : uint {
			S_OK = 0,
			S_FALSE = 1,
			E_NOTIMPL = 2147500033, // 0x80004001
			E_NOINTERFACE = 2147500034, // 0x80004002
			E_POINTER = 2147500035, // 0x80004003
			E_ABORT = 2147500036, // 0x80004004
			E_FAIL = 2147500037, // 0x80004005
			E_UNEXPECTED = 2147549183, // 0x8000FFFF
			RPC_E_CALL_CANCELED = 2147549186, // 0x80010002
			RPC_E_CALL_COMPLETE = 2147549463, // 0x80010117
			CO_E_CANCEL_DISABLED = 2147549504, // 0x80010140
			E_ACCESSDENIED = 2147942405, // 0x80070005
			E_HANDLE = 2147942406, // 0x80070006
			E_OUTOFMEMORY = 2147942414, // 0x8007000E
			E_INVALIDARG = 2147942487, // 0x80070057
		}

		/// <summary>HRESULT facility codes defined by winerror.h</summary>
		public enum FacilityCode : uint {
			FACILITY_NULL = 0,
			FACILITY_RPC = 65536, // 0x00010000
			FACILITY_DISPATCH = 131072, // 0x00020000
			FACILITY_STORAGE = 196608, // 0x00030000
			FACILITY_ITF = 262144, // 0x00040000
			FACILITY_WIN32 = 458752, // 0x00070000
			FACILITY_WINDOWS = 524288, // 0x00080000
			FACILITY_SECURITY = 589824, // 0x00090000
			FACILITY_SSPI = 589824, // 0x00090000
			FACILITY_CONTROL = 655360, // 0x000A0000
			FACILITY_CERT = 720896, // 0x000B0000
			FACILITY_INTERNET = 786432, // 0x000C0000
			FACILITY_MEDIASERVER = 851968, // 0x000D0000
			FACILITY_MSMQ = 917504, // 0x000E0000
			FACILITY_SETUPAPI = 983040, // 0x000F0000
			FACILITY_SCARD = 1048576, // 0x00100000
			FACILITY_COMPLUS = 1114112, // 0x00110000
			FACILITY_AAF = 1179648, // 0x00120000
			FACILITY_URT = 1245184, // 0x00130000
			FACILITY_ACS = 1310720, // 0x00140000
			FACILITY_DPLAY = 1376256, // 0x00150000
			FACILITY_UMI = 1441792, // 0x00160000
			FACILITY_SXS = 1507328, // 0x00170000
			FACILITY_WINDOWS_CE = 1572864, // 0x00180000
			FACILITY_HTTP = 1638400, // 0x00190000
			FACILITY_USERMODE_COMMONLOG = 1703936, // 0x001A0000
			FACILITY_WER = 1769472, // 0x001B0000
			FACILITY_USERMODE_FILTER_MANAGER = 2031616, // 0x001F0000
			FACILITY_BACKGROUNDCOPY = 2097152, // 0x00200000
			FACILITY_CONFIGURATION = 2162688, // 0x00210000
			FACILITY_WIA = 2162688, // 0x00210000
			FACILITY_STATE_MANAGEMENT = 2228224, // 0x00220000
			FACILITY_METADIRECTORY = 2293760, // 0x00230000
			FACILITY_WINDOWSUPDATE = 2359296, // 0x00240000
			FACILITY_DIRECTORYSERVICE = 2424832, // 0x00250000
			FACILITY_GRAPHICS = 2490368, // 0x00260000
			FACILITY_NAP = 2555904, // 0x00270000
			FACILITY_SHELL = 2555904, // 0x00270000
			FACILITY_TPM_SERVICES = 2621440, // 0x00280000
			FACILITY_TPM_SOFTWARE = 2686976, // 0x00290000
			FACILITY_UI = 2752512, // 0x002A0000
			FACILITY_XAML = 2818048, // 0x002B0000
			FACILITY_ACTION_QUEUE = 2883584, // 0x002C0000
			FACILITY_PLA = 3145728, // 0x00300000
			FACILITY_WINDOWS_SETUP = 3145728, // 0x00300000
			FACILITY_FVE = 3211264, // 0x00310000
			FACILITY_FWP = 3276800, // 0x00320000
			FACILITY_WINRM = 3342336, // 0x00330000
			FACILITY_NDIS = 3407872, // 0x00340000
			FACILITY_USERMODE_HYPERVISOR = 3473408, // 0x00350000
			FACILITY_CMI = 3538944, // 0x00360000
			FACILITY_USERMODE_VIRTUALIZATION = 3604480, // 0x00370000
			FACILITY_USERMODE_VOLMGR = 3670016, // 0x00380000
			FACILITY_BCD = 3735552, // 0x00390000
			FACILITY_USERMODE_VHD = 3801088, // 0x003A0000
			FACILITY_SDIAG = 3932160, // 0x003C0000
			FACILITY_WEBSERVICES = 3997696, // 0x003D0000
			FACILITY_WINPE = 3997696, // 0x003D0000
			FACILITY_WPN = 4063232, // 0x003E0000
			FACILITY_WINDOWS_STORE = 4128768, // 0x003F0000
			FACILITY_INPUT = 4194304, // 0x00400000
			FACILITY_EAP = 4325376, // 0x00420000
			FACILITY_WINDOWS_DEFENDER = 5242880, // 0x00500000
			FACILITY_OPC = 5308416, // 0x00510000
			FACILITY_XPS = 5373952, // 0x00520000
			FACILITY_RAS = 5439488, // 0x00530000
			FACILITY_MBN = 5505024, // 0x00540000
			FACILITY_POWERSHELL = 5505024, // 0x00540000
			FACILITY_EAS = 5570560, // 0x00550000
			FACILITY_P2P_INT = 6422528, // 0x00620000
			FACILITY_P2P = 6488064, // 0x00630000
			FACILITY_DAF = 6553600, // 0x00640000
			FACILITY_BLUETOOTH_ATT = 6619136, // 0x00650000
			FACILITY_AUDIO = 6684672, // 0x00660000
			FACILITY_VISUALCPP = 7143424, // 0x006D0000
			FACILITY_SCRIPT = 7340032, // 0x00700000
			FACILITY_PARSE = 7405568, // 0x00710000
			FACILITY_BLB = 7864320, // 0x00780000
			FACILITY_BLB_CLI = 7929856, // 0x00790000
			FACILITY_WSBAPP = 7995392, // 0x007A0000
			FACILITY_BLBUI = 8388608, // 0x00800000
			FACILITY_USN = 8454144, // 0x00810000
			FACILITY_USERMODE_VOLSNAP = 8519680, // 0x00820000
			FACILITY_TIERING = 8585216, // 0x00830000
			FACILITY_WSB_ONLINE = 8716288, // 0x00850000
			FACILITY_ONLINE_ID = 8781824, // 0x00860000
			FACILITY_DLS = 10027008, // 0x00990000
			FACILITY_SOS = 10485760, // 0x00A00000
			FACILITY_DEBUGGERS = 11534336, // 0x00B00000
			FACILITY_USERMODE_SPACES = 15138816, // 0x00E70000
			FACILITY_DMSERVER = 16777216, // 0x01000000
			FACILITY_RESTORE = 16777216, // 0x01000000
			FACILITY_SPP = 16777216, // 0x01000000
			FACILITY_DEPLOYMENT_SERVICES_SERVER = 16842752, // 0x01010000
			FACILITY_DEPLOYMENT_SERVICES_IMAGING = 16908288, // 0x01020000
			FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT = 16973824, // 0x01030000
			FACILITY_DEPLOYMENT_SERVICES_UTIL = 17039360, // 0x01040000
			FACILITY_DEPLOYMENT_SERVICES_BINLSVC = 17104896, // 0x01050000
			FACILITY_DEPLOYMENT_SERVICES_PXE = 17235968, // 0x01070000
			FACILITY_DEPLOYMENT_SERVICES_TFTP = 17301504, // 0x01080000
			FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT = 17825792, // 0x01100000
			FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING = 18219008, // 0x01160000
			FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER = 18939904, // 0x01210000
			FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT = 19005440, // 0x01220000
			FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER = 19202048, // 0x01250000
			FACILITY_LINGUISTIC_SERVICES = 19988480, // 0x01310000
			FACILITY_WEB = 57999360, // 0x03750000
			FACILITY_WEB_SOCKET = 58064896, // 0x03760000
			FACILITY_AUDIOSTREAMING = 71696384, // 0x04460000
			FACILITY_ACCELERATOR = 100663296, // 0x06000000
			FACILITY_MOBILE = 117506048, // 0x07010000
			FACILITY_WMAAECMA = 130809856, // 0x07CC0000
			FACILITY_WEP = 134283264, // 0x08010000
			FACILITY_SYNCENGINE = 134348800, // 0x08020000
			FACILITY_DIRECTMUSIC = 142082048, // 0x08780000
			FACILITY_DIRECT3D10 = 142147584, // 0x08790000
			FACILITY_DXGI = 142213120, // 0x087A0000
			FACILITY_DXGI_DDI = 142278656, // 0x087B0000
			FACILITY_DIRECT3D11 = 142344192, // 0x087C0000
			FACILITY_LEAP = 143130624, // 0x08880000
			FACILITY_AUDCLNT = 143196160, // 0x08890000
			FACILITY_WINCODEC_DWRITE_DWM = 144179200, // 0x08980000
			FACILITY_DIRECT2D = 144244736, // 0x08990000
			FACILITY_DEFRAG = 150994944, // 0x09000000
			FACILITY_USERMODE_SDBUS = 151060480, // 0x09010000
			FACILITY_JSCRIPT = 151126016, // 0x09020000
			FACILITY_PIDGENX = 167837696, // 0x0A010000
			FACILITY_NT_BIT = 268435456, // 0x10000000
		}

		/// <summary>HRESULT severity codes defined by winerror.h</summary>
		public enum SeverityCode : uint {
			Success = 0,
			Fail = 2147483648, // 0x80000000
		}
	}

	/// <summary>Represents the data directory.</summary>
	/// <remarks>
	/// See remarks on MSDN: https://msdn.microsoft.com/en-us/library/windows/desktop/ms680305(v=vs.85).aspx
	/// </remarks>
	public struct IMAGE_DATA_DIRECTORY {
		/// <summary>The relative virtual address of the table.</summary>
		public uint VirtualAddress;

		/// <summary>The size of the table, in bytes.</summary>
		public uint Size;
	}

	/// <content>
	/// Contains the <see cref="T:PInvoke.IMAGE_FILE_HEADER.CharacteristicsType" /> nested type.
	/// </content>
	/// <content>
	/// Contains the <see cref="T:PInvoke.IMAGE_FILE_HEADER.MachineType" /> nested type.
	/// </content>
	/// <summary>Represents the COFF header format.</summary>
	public struct IMAGE_FILE_HEADER {
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
		public enum CharacteristicsType : ushort {
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
		public enum MachineType : ushort {
			IMAGE_FILE_MACHINE_I386 = 332, // 0x014C
			IMAGE_FILE_MACHINE_IA64 = 512, // 0x0200
			IMAGE_FILE_MACHINE_AMD64 = 34404, // 0x8664
		}
	}

	/// <summary>Represents the PE header format.</summary>
	public struct IMAGE_NT_HEADERS {
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
	public struct IMAGE_OPTIONAL_HEADER {
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
		[Obsolete] public uint LoaderFlags;

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
		public enum DllCharacteristicsType : ushort {
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
		public enum MagicType : ushort {
			IMAGE_ROM_OPTIONAL_HDR_MAGIC = 263, // 0x0107
			IMAGE_NT_OPTIONAL_HDR32_MAGIC = 267, // 0x010B
			IMAGE_NT_OPTIONAL_HDR64_MAGIC = 523, // 0x020B
		}

		/// <summary>
		/// Describes expected values for the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.Subsystem" /> field.
		/// </summary>
		public enum SubsystemType : ushort {
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

	/// <summary>
	/// Describes a fixed array of 16 <see cref="T:PInvoke.IMAGE_DATA_DIRECTORY" /> structures,
	/// where the array is *not* allocated on the heap.
	/// </summary>
	public struct IMAGE_OPTIONAL_HEADER_DIRECTORIES {
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

		public IMAGE_DATA_DIRECTORY this[int index] {
			get {
				switch (index) {
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
			set {
				switch (index) {
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

	/// <content>
	/// Contains the <see cref="T:PInvoke.IMAGE_SECTION_HEADER.CharacteristicsType" /> nested type.
	/// </content>
	/// <summary>Represents the image section header format.</summary>
	public struct IMAGE_SECTION_HEADER {
		/// <summary>
		/// An 8-byte, null-padded UTF-8 string. There is no terminating null character if the string is exactly eight characters long. For longer names, this member contains a forward slash (/) followed by an ASCII representation of a decimal number that is an offset into the string table. Executable images do not use a string table and do not support section names longer than eight characters.
		/// </summary>
		public unsafe fixed byte Name[8];

		/// <summary>
		/// EITHER:
		/// <list type="bullet">
		/// <item>The file address.</item>
		/// <item>The total size of the section when loaded into memory, in bytes. If this value is greater than the <see cref="F:PInvoke.IMAGE_SECTION_HEADER.SizeOfRawData" /> member, the section is filled with zeroes. This field is valid only for executable images and should be set to 0 for object files.</item>
		/// </list>
		/// </summary>
		public uint PhysicalAddressOrVirtualSize;

		/// <summary>
		/// The address of the first byte of the section when loaded into memory, relative to the image base. For object files, this is the address of the first byte before relocation is applied.
		/// </summary>
		public uint VirtualAddress;

		/// <summary>
		/// The size of the initialized data on disk, in bytes. This value must be a multiple of the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.FileAlignment" /> member of the <see cref="T:PInvoke.IMAGE_OPTIONAL_HEADER" /> structure. If this value is less than the VirtualSize member, the remainder of the section is filled with zeroes. If the section contains only uninitialized data, the member is zero.
		/// </summary>
		public uint SizeOfRawData;

		/// <summary>
		/// A file pointer to the first page within the COFF file. This value must be a multiple of the <see cref="F:PInvoke.IMAGE_OPTIONAL_HEADER.FileAlignment" /> member of the <see cref="T:PInvoke.IMAGE_OPTIONAL_HEADER" /> structure. If a section contains only uninitialized data, set this member is zero.
		/// </summary>
		public uint PointerToRawData;

		/// <summary>
		/// A file pointer to the beginning of the relocation entries for the section.If there are no relocations, this value is zero.
		/// </summary>
		public uint PointerToRelocations;

		/// <summary>
		/// A file pointer to the beginning of the line-number entries for the section. If there are no COFF line numbers, this value is zero.
		/// </summary>
		public uint PointerToLinenumbers;

		/// <summary>
		/// The number of relocation entries for the section. This value is zero for executable images.
		/// </summary>
		public ushort NumberOfRelocations;

		/// <summary>The number of line-number entries for the section.</summary>
		public ushort NumberOfLinenumbers;

		/// <summary>The characteristics of the image.</summary>
		public IMAGE_SECTION_HEADER.CharacteristicsType Characteristics;

		/// <summary>
		/// Enumerates the values that may be expected in the <see cref="F:PInvoke.IMAGE_SECTION_HEADER.Characteristics" /> field.
		/// </summary>
		[Flags]
		public enum CharacteristicsType { }
	}

	/// <summary>Describes a link in a doubly-linked list.</summary>
	public struct LIST_ENTRY {
		public unsafe LIST_ENTRY* Flink;
		public unsafe LIST_ENTRY* Blink;

		public unsafe IntPtr Flink_IntPtr {
			get { return new IntPtr((void*) this.Flink); }
			set { this.Flink = (LIST_ENTRY*) value.ToPointer(); }
		}

		public unsafe IntPtr Blink_IntPtr {
			get { return new IntPtr((void*) this.Blink); }
			set { this.Blink = (LIST_ENTRY*) value.ToPointer(); }
		}
	}

	/// <content>
	/// Contains the <see cref="T:PInvoke.NTSTATUS.Code" /> nested type.
	/// </content>
	/// <content>
	/// The <see cref="T:PInvoke.NTSTATUS.FacilityCode" /> nested type.
	/// </content>
	/// <content>
	/// The <see cref="T:PInvoke.NTSTATUS.SeverityCode" /> nested type.
	/// </content>
	/// <summary>Win32 return error codes.</summary>
	/// <remarks>
	/// This values come from https://msdn.microsoft.com/en-us/library/cc704588.aspx
	///  Values are 32 bit values laid out as follows:
	///   3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
	///   1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
	///  +---+-+-+-----------------------+-------------------------------+
	///  |Sev|C|R|     Facility          |               Code            |
	///  +---+-+-+-----------------------+-------------------------------+
	///  where
	///      Sev - is the severity code
	///          00 - Success
	///          01 - Informational
	///          10 - Warning
	///          11 - Error
	///      C - is the Customer code flag
	///      R - is a reserved bit
	///      Facility - is the facility code
	///      Code - is the facility's status code
	/// 
	/// FacilityCodes 0x5 - 0xF have been allocated by various drivers.
	/// The success status codes 0 - 63 are reserved for wait completion status.
	/// </remarks>
	[DebuggerDisplay("{Value}")]
	public struct NTSTATUS : IComparable, IComparable<NTSTATUS>, IEquatable<NTSTATUS>, IFormattable {
		/// <summary>
		/// The mask of the bits that describe the <see cref="P:PInvoke.NTSTATUS.Severity" />.
		/// </summary>
		private const uint SeverityMask = 3221225472;

		/// <summary>
		/// The number of bits that <see cref="P:PInvoke.NTSTATUS.Severity" /> values are shifted
		/// in order to fit within <see cref="F:PInvoke.NTSTATUS.SeverityMask" />.
		/// </summary>
		private const int SeverityShift = 30;

		/// <summary>
		/// The mask of the bits that describe the <see cref="P:PInvoke.NTSTATUS.CustomerCode" />.
		/// </summary>
		private const uint CustomerCodeMask = 536870912;

		/// <summary>
		/// The number of bits that <see cref="P:PInvoke.NTSTATUS.CustomerCode" /> values are shifted
		/// in order to fit within <see cref="F:PInvoke.NTSTATUS.CustomerCodeMask" />.
		/// </summary>
		private const int CustomerCodeShift = 29;

		/// <summary>
		/// The mask of the bits that describe the <see cref="P:PInvoke.NTSTATUS.Facility" />.
		/// </summary>
		private const uint FacilityMask = 268369920;

		/// <summary>
		/// The number of bits that <see cref="P:PInvoke.NTSTATUS.Facility" /> values are shifted
		/// in order to fit within <see cref="F:PInvoke.NTSTATUS.FacilityMask" />.
		/// </summary>
		private const int FacilityShift = 16;

		/// <summary>
		/// The mask of the bits that describe the facility's status <see cref="P:PInvoke.NTSTATUS.FacilityStatus" />.
		/// </summary>
		private const uint FacilityStatusMask = 65535;

		/// <summary>
		/// The number of bits that <see cref="P:PInvoke.NTSTATUS.FacilityStatus" /> values are shifted
		/// in order to fit within <see cref="F:PInvoke.NTSTATUS.FacilityStatusMask" />.
		/// </summary>
		private const int FacilityStatusShift = 0;

		/// <summary>
		/// The full NT_STATUS value, as a <see cref="T:PInvoke.NTSTATUS.Code" /> enum.
		/// </summary>
		private readonly NTSTATUS.Code value;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.NTSTATUS" /> struct.
		/// </summary>
		/// <param name="status">The value of the NTStatus.</param>
		public NTSTATUS(uint status) {
			this = new NTSTATUS((NTSTATUS.Code) status);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.NTSTATUS" /> struct.
		/// </summary>
		/// <param name="status">The value of the NTStatus.</param>
		public NTSTATUS(int status) {
			this = new NTSTATUS((NTSTATUS.Code) status);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.NTSTATUS" /> struct.
		/// </summary>
		/// <param name="status">The value of the NTStatus.</param>
		public NTSTATUS(NTSTATUS.Code status) {
			this.value = status;
		}

		/// <summary>
		/// Gets the full NT_STATUS value, as a <see cref="T:PInvoke.NTSTATUS.Code" /> enum.
		/// </summary>
		public NTSTATUS.Code Value {
			get { return this.value; }
		}

		/// <summary>Gets the NT_STATUS as a 32-bit signed integer.</summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int AsInt32 {
			get { return (int) this.Value; }
		}

		/// <summary>Gets the NT_STATUS as a 32-bit unsigned integer.</summary>
		public uint AsUInt32 {
			get { return (uint) this.Value; }
		}

		/// <summary>Gets the severity code of this value.</summary>
		public NTSTATUS.SeverityCode Severity {
			get { return (NTSTATUS.SeverityCode) ((int) this.AsUInt32 & -1073741824); }
		}

		/// <summary>Gets the customer code portion of this value.</summary>
		public uint CustomerCode {
			get { return this.AsUInt32 & 536870912U; }
		}

		/// <summary>Gets the facility code of this value.</summary>
		public NTSTATUS.FacilityCode Facility {
			get { return (NTSTATUS.FacilityCode) ((int) this.AsUInt32 & 268369920); }
		}

		/// <summary>
		/// Gets the facility's status code bits from the NT_STATUS.
		/// </summary>
		public uint FacilityStatus {
			get { return this.AsUInt32 & (uint) ushort.MaxValue; }
		}

		/// <summary>
		/// Converts an <see cref="T:System.Int32" /> into an <see cref="T:PInvoke.NTSTATUS" />.
		/// </summary>
		/// <param name="status">The value of the NT_STATUS.</param>
		public static implicit operator NTSTATUS(int status) {
			return new NTSTATUS(status);
		}

		/// <summary>
		/// Converts an <see cref="T:PInvoke.NTSTATUS" /> into an <see cref="T:System.Int32" />.
		/// </summary>
		/// <param name="status">The value of the NT_STATUS.</param>
		public static explicit operator int(NTSTATUS status) {
			return status.AsInt32;
		}

		/// <summary>
		/// Converts an <see cref="T:System.UInt32" /> into an <see cref="T:PInvoke.NTSTATUS" />.
		/// </summary>
		/// <param name="status">The value of the NT_STATUS.</param>
		public static implicit operator NTSTATUS(uint status) {
			return new NTSTATUS(status);
		}

		/// <summary>
		/// Converts an <see cref="T:PInvoke.NTSTATUS" /> into an <see cref="T:System.UInt32" />.
		/// </summary>
		/// <param name="status">The value of the NT_STATUS.</param>
		public static implicit operator uint(NTSTATUS status) {
			return status.AsUInt32;
		}

		/// <summary>
		/// Converts a <see cref="T:PInvoke.NTSTATUS.Code" /> enum to its structural <see cref="T:PInvoke.NTSTATUS" /> representation.
		/// </summary>
		/// <param name="status">The value to convert.</param>
		public static implicit operator NTSTATUS(NTSTATUS.Code status) {
			return new NTSTATUS(status);
		}

		/// <summary>
		/// Converts an <see cref="T:PInvoke.NTSTATUS" /> to its <see cref="T:PInvoke.NTSTATUS.Code" /> enum representation.
		/// </summary>
		/// <param name="status">The value to convert.</param>
		public static implicit operator NTSTATUS.Code(NTSTATUS status) {
			return status.Value;
		}

		/// <inheritdoc />
		public override int GetHashCode() {
			return (int) this.Value;
		}

		/// <inheritdoc />
		public bool Equals(NTSTATUS other) {
			return this.Value == other.Value;
		}

		/// <inheritdoc />
		public override bool Equals(object obj) {
			if (obj is NTSTATUS)
				return this.Equals((NTSTATUS) obj);
			return false;
		}

		/// <inheritdoc />
		public int CompareTo(object obj) {
			return ((IComparable) this.Value).CompareTo(obj);
		}

		/// <inheritdoc />
		public int CompareTo(NTSTATUS other) {
			return this.Value.CompareTo((object) other.Value);
		}

		/// <inheritdoc />
		public override string ToString() {
			return this.Value.ToString();
		}

		/// <inheritdoc />
		public string ToString(string format, IFormatProvider formatProvider) {
			return this.AsUInt32.ToString(format, formatProvider);
		}

		/// <summary>
		/// Common <see cref="T:PInvoke.NTSTATUS" /> constants.
		/// </summary>
		public enum Code : uint {
			STATUS_SUCCESS = 0,
			STATUS_WAIT_0 = 0,
			STATUS_WAIT_1 = 1,
			STATUS_WAIT_2 = 2,
			STATUS_WAIT_3 = 3,
			STATUS_WAIT_63 = 63, // 0x0000003F
			STATUS_ABANDONED = 128, // 0x00000080
			STATUS_ABANDONED_WAIT_0 = 128, // 0x00000080
			STATUS_ABANDONED_WAIT_63 = 191, // 0x000000BF
			STATUS_USER_APC = 192, // 0x000000C0
			STATUS_KERNEL_APC = 256, // 0x00000100
			STATUS_ALERTED = 257, // 0x00000101
			STATUS_TIMEOUT = 258, // 0x00000102
			STATUS_PENDING = 259, // 0x00000103
			STATUS_REPARSE = 260, // 0x00000104
			STATUS_MORE_ENTRIES = 261, // 0x00000105
			STATUS_NOT_ALL_ASSIGNED = 262, // 0x00000106
			STATUS_SOME_NOT_MAPPED = 263, // 0x00000107
			STATUS_OPLOCK_BREAK_IN_PROGRESS = 264, // 0x00000108
			STATUS_VOLUME_MOUNTED = 265, // 0x00000109
			STATUS_RXACT_COMMITTED = 266, // 0x0000010A
			STATUS_NOTIFY_CLEANUP = 267, // 0x0000010B
			STATUS_NOTIFY_ENUM_DIR = 268, // 0x0000010C
			STATUS_NO_QUOTAS_FOR_ACCOUNT = 269, // 0x0000010D
			STATUS_PRIMARY_TRANSPORT_CONNECT_FAILED = 270, // 0x0000010E
			STATUS_PAGE_FAULT_TRANSITION = 272, // 0x00000110
			STATUS_PAGE_FAULT_DEMAND_ZERO = 273, // 0x00000111
			STATUS_PAGE_FAULT_COPY_ON_WRITE = 274, // 0x00000112
			STATUS_PAGE_FAULT_GUARD_PAGE = 275, // 0x00000113
			STATUS_PAGE_FAULT_PAGING_FILE = 276, // 0x00000114
			STATUS_CACHE_PAGE_LOCKED = 277, // 0x00000115
			STATUS_CRASH_DUMP = 278, // 0x00000116
			STATUS_BUFFER_ALL_ZEROS = 279, // 0x00000117
			STATUS_REPARSE_OBJECT = 280, // 0x00000118
			STATUS_RESOURCE_REQUIREMENTS_CHANGED = 281, // 0x00000119
			STATUS_TRANSLATION_COMPLETE = 288, // 0x00000120
			STATUS_DS_MEMBERSHIP_EVALUATED_LOCALLY = 289, // 0x00000121
			STATUS_NOTHING_TO_TERMINATE = 290, // 0x00000122
			STATUS_PROCESS_NOT_IN_JOB = 291, // 0x00000123
			STATUS_PROCESS_IN_JOB = 292, // 0x00000124
			STATUS_VOLSNAP_HIBERNATE_READY = 293, // 0x00000125
			STATUS_FSFILTER_OP_COMPLETED_SUCCESSFULLY = 294, // 0x00000126
			STATUS_INTERRUPT_VECTOR_ALREADY_CONNECTED = 295, // 0x00000127
			STATUS_INTERRUPT_STILL_CONNECTED = 296, // 0x00000128
			STATUS_PROCESS_CLONED = 297, // 0x00000129
			STATUS_FILE_LOCKED_WITH_ONLY_READERS = 298, // 0x0000012A
			STATUS_FILE_LOCKED_WITH_WRITERS = 299, // 0x0000012B
			STATUS_VALID_IMAGE_HASH = 300, // 0x0000012C
			STATUS_VALID_CATALOG_HASH = 301, // 0x0000012D
			STATUS_RESOURCEMANAGER_READ_ONLY = 514, // 0x00000202
			STATUS_RING_PREVIOUSLY_EMPTY = 528, // 0x00000210
			STATUS_RING_PREVIOUSLY_FULL = 529, // 0x00000211
			STATUS_RING_PREVIOUSLY_ABOVE_QUOTA = 530, // 0x00000212
			STATUS_RING_NEWLY_EMPTY = 531, // 0x00000213
			STATUS_RING_SIGNAL_OPPOSITE_ENDPOINT = 532, // 0x00000214
			STATUS_OPLOCK_SWITCHED_TO_NEW_HANDLE = 533, // 0x00000215
			STATUS_OPLOCK_HANDLE_CLOSED = 534, // 0x00000216
			STATUS_WAIT_FOR_OPLOCK = 871, // 0x00000367
			DBG_EXCEPTION_HANDLED = 65537, // 0x00010001
			DBG_CONTINUE = 65538, // 0x00010002
			HIDP_STATUS_SUCCESS = 1114112, // 0x00110000
			STATUS_FLT_IO_COMPLETE = 1835009, // 0x001C0001
			STATUS_OBJECT_NAME_EXISTS = 1073741824, // 0x40000000
			STATUS_THREAD_WAS_SUSPENDED = 1073741825, // 0x40000001
			STATUS_WORKING_SET_LIMIT_RANGE = 1073741826, // 0x40000002
			STATUS_IMAGE_NOT_AT_BASE = 1073741827, // 0x40000003
			STATUS_RXACT_STATE_CREATED = 1073741828, // 0x40000004
			STATUS_SEGMENT_NOTIFICATION = 1073741829, // 0x40000005
			STATUS_LOCAL_USER_SESSION_KEY = 1073741830, // 0x40000006
			STATUS_BAD_CURRENT_DIRECTORY = 1073741831, // 0x40000007
			STATUS_SERIAL_MORE_WRITES = 1073741832, // 0x40000008
			STATUS_REGISTRY_RECOVERED = 1073741833, // 0x40000009
			STATUS_FT_READ_RECOVERY_FROM_BACKUP = 1073741834, // 0x4000000A
			STATUS_FT_WRITE_RECOVERY = 1073741835, // 0x4000000B
			STATUS_SERIAL_COUNTER_TIMEOUT = 1073741836, // 0x4000000C
			STATUS_NULL_LM_PASSWORD = 1073741837, // 0x4000000D
			STATUS_IMAGE_MACHINE_TYPE_MISMATCH = 1073741838, // 0x4000000E
			STATUS_RECEIVE_PARTIAL = 1073741839, // 0x4000000F
			STATUS_RECEIVE_EXPEDITED = 1073741840, // 0x40000010
			STATUS_RECEIVE_PARTIAL_EXPEDITED = 1073741841, // 0x40000011
			STATUS_EVENT_DONE = 1073741842, // 0x40000012
			STATUS_EVENT_PENDING = 1073741843, // 0x40000013
			STATUS_CHECKING_FILE_SYSTEM = 1073741844, // 0x40000014
			STATUS_FATAL_APP_EXIT = 1073741845, // 0x40000015
			STATUS_PREDEFINED_HANDLE = 1073741846, // 0x40000016
			STATUS_WAS_UNLOCKED = 1073741847, // 0x40000017
			STATUS_SERVICE_NOTIFICATION = 1073741848, // 0x40000018
			STATUS_WAS_LOCKED = 1073741849, // 0x40000019
			STATUS_LOG_HARD_ERROR = 1073741850, // 0x4000001A
			STATUS_ALREADY_WIN32 = 1073741851, // 0x4000001B
			STATUS_WX86_UNSIMULATE = 1073741852, // 0x4000001C
			STATUS_WX86_CONTINUE = 1073741853, // 0x4000001D
			STATUS_WX86_SINGLE_STEP = 1073741854, // 0x4000001E
			STATUS_WX86_BREAKPOINT = 1073741855, // 0x4000001F
			STATUS_WX86_EXCEPTION_CONTINUE = 1073741856, // 0x40000020
			STATUS_WX86_EXCEPTION_LASTCHANCE = 1073741857, // 0x40000021
			STATUS_WX86_EXCEPTION_CHAIN = 1073741858, // 0x40000022
			STATUS_IMAGE_MACHINE_TYPE_MISMATCH_EXE = 1073741859, // 0x40000023
			STATUS_NO_YIELD_PERFORMED = 1073741860, // 0x40000024
			STATUS_TIMER_RESUME_IGNORED = 1073741861, // 0x40000025
			STATUS_ARBITRATION_UNHANDLED = 1073741862, // 0x40000026
			STATUS_CARDBUS_NOT_SUPPORTED = 1073741863, // 0x40000027
			STATUS_WX86_CREATEWX86TIB = 1073741864, // 0x40000028
			STATUS_MP_PROCESSOR_MISMATCH = 1073741865, // 0x40000029
			STATUS_HIBERNATED = 1073741866, // 0x4000002A
			STATUS_RESUME_HIBERNATION = 1073741867, // 0x4000002B
			STATUS_FIRMWARE_UPDATED = 1073741868, // 0x4000002C
			STATUS_DRIVERS_LEAKING_LOCKED_PAGES = 1073741869, // 0x4000002D
			STATUS_MESSAGE_RETRIEVED = 1073741870, // 0x4000002E
			STATUS_SYSTEM_POWERSTATE_TRANSITION = 1073741871, // 0x4000002F
			STATUS_ALPC_CHECK_COMPLETION_LIST = 1073741872, // 0x40000030
			STATUS_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = 1073741873, // 0x40000031
			STATUS_ACCESS_AUDIT_BY_POLICY = 1073741874, // 0x40000032
			STATUS_ABANDON_HIBERFILE = 1073741875, // 0x40000033
			STATUS_BIZRULES_NOT_ENABLED = 1073741876, // 0x40000034
			STATUS_FT_READ_FROM_COPY = 1073741877, // 0x40000035
			STATUS_IMAGE_AT_DIFFERENT_BASE = 1073741878, // 0x40000036
			STATUS_WAKE_SYSTEM = 1073742484, // 0x40000294
			STATUS_DS_SHUTTING_DOWN = 1073742704, // 0x40000370
			STATUS_DISK_REPAIR_REDIRECTED = 1073743879, // 0x40000807
			STATUS_SERVICES_FAILED_AUTOSTART = 1073783108, // 0x4000A144
			DBG_REPLY_LATER = 1073807361, // 0x40010001
			DBG_UNABLE_TO_PROVIDE_HANDLE = 1073807362, // 0x40010002
			DBG_TERMINATE_THREAD = 1073807363, // 0x40010003
			DBG_TERMINATE_PROCESS = 1073807364, // 0x40010004
			DBG_CONTROL_C = 1073807365, // 0x40010005
			DBG_PRINTEXCEPTION_C = 1073807366, // 0x40010006
			DBG_RIPEXCEPTION = 1073807367, // 0x40010007
			DBG_CONTROL_BREAK = 1073807368, // 0x40010008
			DBG_COMMAND_EXCEPTION = 1073807369, // 0x40010009
			RPC_NT_UUID_LOCAL_ONLY = 1073872982, // 0x40020056
			RPC_NT_SEND_INCOMPLETE = 1073873071, // 0x400200AF
			STATUS_CTX_CDM_CONNECT = 1074397188, // 0x400A0004
			STATUS_CTX_CDM_DISCONNECT = 1074397189, // 0x400A0005
			STATUS_SXS_RELEASE_ACTIVATION_CONTEXT = 1075118093, // 0x4015000D
			STATUS_HEURISTIC_DAMAGE_POSSIBLE = 1075380225, // 0x40190001
			STATUS_RECOVERY_NOT_NEEDED = 1075380276, // 0x40190034
			STATUS_RM_ALREADY_STARTED = 1075380277, // 0x40190035
			STATUS_LOG_NO_RESTART = 1075445772, // 0x401A000C
			STATUS_VIDEO_DRIVER_DEBUG_REPORT_REQUEST = 1075511532, // 0x401B00EC
			STATUS_GRAPHICS_PARTIAL_DATA_POPULATED = 1075707914, // 0x401E000A
			STATUS_GRAPHICS_SKIP_ALLOCATION_PREPARATION = 1075708417, // 0x401E0201
			STATUS_GRAPHICS_MODE_NOT_PINNED = 1075708679, // 0x401E0307
			STATUS_GRAPHICS_NO_PREFERRED_MODE = 1075708702, // 0x401E031E
			STATUS_GRAPHICS_DATASET_IS_EMPTY = 1075708747, // 0x401E034B
			STATUS_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET = 1075708748, // 0x401E034C
			STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED = 1075708753, // 0x401E0351
			STATUS_GRAPHICS_UNKNOWN_CHILD_STATUS = 1075708975, // 0x401E042F
			STATUS_GRAPHICS_LEADLINK_START_DEFERRED = 1075708983, // 0x401E0437
			STATUS_GRAPHICS_POLLING_TOO_FREQUENTLY = 1075708985, // 0x401E0439
			STATUS_GRAPHICS_START_DEFERRED = 1075708986, // 0x401E043A
			STATUS_NDIS_INDICATION_REQUIRED = 1076035585, // 0x40230001
			STATUS_GUARD_PAGE_VIOLATION = 2147483649, // 0x80000001
			STATUS_DATATYPE_MISALIGNMENT = 2147483650, // 0x80000002
			STATUS_BREAKPOINT = 2147483651, // 0x80000003
			STATUS_SINGLE_STEP = 2147483652, // 0x80000004
			STATUS_BUFFER_OVERFLOW = 2147483653, // 0x80000005
			STATUS_NO_MORE_FILES = 2147483654, // 0x80000006
			STATUS_WAKE_SYSTEM_DEBUGGER = 2147483655, // 0x80000007
			STATUS_HANDLES_CLOSED = 2147483658, // 0x8000000A
			STATUS_NO_INHERITANCE = 2147483659, // 0x8000000B
			STATUS_GUID_SUBSTITUTION_MADE = 2147483660, // 0x8000000C
			STATUS_PARTIAL_COPY = 2147483661, // 0x8000000D
			STATUS_DEVICE_PAPER_EMPTY = 2147483662, // 0x8000000E
			STATUS_DEVICE_POWERED_OFF = 2147483663, // 0x8000000F
			STATUS_DEVICE_OFF_LINE = 2147483664, // 0x80000010
			STATUS_DEVICE_BUSY = 2147483665, // 0x80000011
			STATUS_NO_MORE_EAS = 2147483666, // 0x80000012
			STATUS_INVALID_EA_NAME = 2147483667, // 0x80000013
			STATUS_EA_LIST_INCONSISTENT = 2147483668, // 0x80000014
			STATUS_INVALID_EA_FLAG = 2147483669, // 0x80000015
			STATUS_VERIFY_REQUIRED = 2147483670, // 0x80000016
			STATUS_EXTRANEOUS_INFORMATION = 2147483671, // 0x80000017
			STATUS_RXACT_COMMIT_NECESSARY = 2147483672, // 0x80000018
			STATUS_NO_MORE_ENTRIES = 2147483674, // 0x8000001A
			STATUS_FILEMARK_DETECTED = 2147483675, // 0x8000001B
			STATUS_MEDIA_CHANGED = 2147483676, // 0x8000001C
			STATUS_BUS_RESET = 2147483677, // 0x8000001D
			STATUS_END_OF_MEDIA = 2147483678, // 0x8000001E
			STATUS_BEGINNING_OF_MEDIA = 2147483679, // 0x8000001F
			STATUS_MEDIA_CHECK = 2147483680, // 0x80000020
			STATUS_SETMARK_DETECTED = 2147483681, // 0x80000021
			STATUS_NO_DATA_DETECTED = 2147483682, // 0x80000022
			STATUS_REDIRECTOR_HAS_OPEN_HANDLES = 2147483683, // 0x80000023
			STATUS_SERVER_HAS_OPEN_HANDLES = 2147483684, // 0x80000024
			STATUS_ALREADY_DISCONNECTED = 2147483685, // 0x80000025
			STATUS_LONGJUMP = 2147483686, // 0x80000026
			STATUS_CLEANER_CARTRIDGE_INSTALLED = 2147483687, // 0x80000027
			STATUS_PLUGPLAY_QUERY_VETOED = 2147483688, // 0x80000028
			STATUS_UNWIND_CONSOLIDATE = 2147483689, // 0x80000029
			STATUS_REGISTRY_HIVE_RECOVERED = 2147483690, // 0x8000002A
			STATUS_DLL_MIGHT_BE_INSECURE = 2147483691, // 0x8000002B
			STATUS_DLL_MIGHT_BE_INCOMPATIBLE = 2147483692, // 0x8000002C
			STATUS_STOPPED_ON_SYMLINK = 2147483693, // 0x8000002D
			STATUS_CANNOT_GRANT_REQUESTED_OPLOCK = 2147483694, // 0x8000002E
			STATUS_NO_ACE_CONDITION = 2147483695, // 0x8000002F
			STATUS_DEVICE_SUPPORT_IN_PROGRESS = 2147483696, // 0x80000030
			STATUS_DEVICE_REQUIRES_CLEANING = 2147484296, // 0x80000288
			STATUS_DEVICE_DOOR_OPEN = 2147484297, // 0x80000289
			STATUS_DATA_LOST_REPAIR = 2147485699, // 0x80000803
			STATUS_GPIO_INTERRUPT_ALREADY_UNMASKED = 2147524903, // 0x8000A127
			DBG_EXCEPTION_NOT_HANDLED = 2147549185, // 0x80010001
			HIDP_STATUS_NULL = 2148597761, // 0x80110001
			STATUS_CLUSTER_NODE_ALREADY_UP = 2148728833, // 0x80130001
			STATUS_CLUSTER_NODE_ALREADY_DOWN = 2148728834, // 0x80130002
			STATUS_CLUSTER_NETWORK_ALREADY_ONLINE = 2148728835, // 0x80130003
			STATUS_CLUSTER_NETWORK_ALREADY_OFFLINE = 2148728836, // 0x80130004
			STATUS_CLUSTER_NODE_ALREADY_MEMBER = 2148728837, // 0x80130005
			STATUS_COULD_NOT_RESIZE_LOG = 2149122057, // 0x80190009
			STATUS_NO_TXF_METADATA = 2149122089, // 0x80190029
			STATUS_CANT_RECOVER_WITH_HANDLE_OPEN = 2149122097, // 0x80190031
			STATUS_TXF_METADATA_ALREADY_PRESENT = 2149122113, // 0x80190041
			STATUS_TRANSACTION_SCOPE_CALLBACKS_NOT_SET = 2149122114, // 0x80190042
			STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD_RECOVERED = 2149253355, // 0x801B00EB
			STATUS_FLT_BUFFER_TOO_SMALL = 2149318657, // 0x801C0001
			STATUS_FVE_PARTIAL_METADATA = 2149646337, // 0x80210001
			STATUS_FVE_TRANSIENT_STATE = 2149646338, // 0x80210002
			STATUS_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED = 2151088129, // 0x80370001
			STATUS_VOLMGR_INCOMPLETE_REGENERATION = 2151153665, // 0x80380001
			STATUS_VOLMGR_INCOMPLETE_DISK_MIGRATION = 2151153666, // 0x80380002
			STATUS_BCD_NOT_ALL_ENTRIES_IMPORTED = 2151219201, // 0x80390001
			STATUS_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED = 2151219203, // 0x80390003
			STATUS_QUERY_STORAGE_ERROR = 2151284737, // 0x803A0001
			STATUS_SECUREBOOT_NOT_ENABLED = 2151874566, // 0x80430006
			STATUS_UNSUCCESSFUL = 3221225473, // 0xC0000001
			STATUS_NOT_IMPLEMENTED = 3221225474, // 0xC0000002
			STATUS_INVALID_INFO_CLASS = 3221225475, // 0xC0000003
			STATUS_INFO_LENGTH_MISMATCH = 3221225476, // 0xC0000004
			STATUS_ACCESS_VIOLATION = 3221225477, // 0xC0000005
			STATUS_IN_PAGE_ERROR = 3221225478, // 0xC0000006
			STATUS_PAGEFILE_QUOTA = 3221225479, // 0xC0000007
			STATUS_INVALID_HANDLE = 3221225480, // 0xC0000008
			STATUS_BAD_INITIAL_STACK = 3221225481, // 0xC0000009
			STATUS_BAD_INITIAL_PC = 3221225482, // 0xC000000A
			STATUS_INVALID_CID = 3221225483, // 0xC000000B
			STATUS_TIMER_NOT_CANCELED = 3221225484, // 0xC000000C
			STATUS_INVALID_PARAMETER = 3221225485, // 0xC000000D
			STATUS_NO_SUCH_DEVICE = 3221225486, // 0xC000000E
			STATUS_NO_SUCH_FILE = 3221225487, // 0xC000000F
			STATUS_INVALID_DEVICE_REQUEST = 3221225488, // 0xC0000010
			STATUS_END_OF_FILE = 3221225489, // 0xC0000011
			STATUS_WRONG_VOLUME = 3221225490, // 0xC0000012
			STATUS_NO_MEDIA_IN_DEVICE = 3221225491, // 0xC0000013
			STATUS_UNRECOGNIZED_MEDIA = 3221225492, // 0xC0000014
			STATUS_NONEXISTENT_SECTOR = 3221225493, // 0xC0000015
			STATUS_MORE_PROCESSING_REQUIRED = 3221225494, // 0xC0000016
			STATUS_NO_MEMORY = 3221225495, // 0xC0000017
			STATUS_CONFLICTING_ADDRESSES = 3221225496, // 0xC0000018
			STATUS_NOT_MAPPED_VIEW = 3221225497, // 0xC0000019
			STATUS_UNABLE_TO_FREE_VM = 3221225498, // 0xC000001A
			STATUS_UNABLE_TO_DELETE_SECTION = 3221225499, // 0xC000001B
			STATUS_INVALID_SYSTEM_SERVICE = 3221225500, // 0xC000001C
			STATUS_ILLEGAL_INSTRUCTION = 3221225501, // 0xC000001D
			STATUS_INVALID_LOCK_SEQUENCE = 3221225502, // 0xC000001E
			STATUS_INVALID_VIEW_SIZE = 3221225503, // 0xC000001F
			STATUS_INVALID_FILE_FOR_SECTION = 3221225504, // 0xC0000020
			STATUS_ALREADY_COMMITTED = 3221225505, // 0xC0000021
			STATUS_ACCESS_DENIED = 3221225506, // 0xC0000022
			STATUS_BUFFER_TOO_SMALL = 3221225507, // 0xC0000023
			STATUS_OBJECT_TYPE_MISMATCH = 3221225508, // 0xC0000024
			STATUS_NONCONTINUABLE_EXCEPTION = 3221225509, // 0xC0000025
			STATUS_INVALID_DISPOSITION = 3221225510, // 0xC0000026
			STATUS_UNWIND = 3221225511, // 0xC0000027
			STATUS_BAD_STACK = 3221225512, // 0xC0000028
			STATUS_INVALID_UNWIND_TARGET = 3221225513, // 0xC0000029
			STATUS_NOT_LOCKED = 3221225514, // 0xC000002A
			STATUS_PARITY_ERROR = 3221225515, // 0xC000002B
			STATUS_UNABLE_TO_DECOMMIT_VM = 3221225516, // 0xC000002C
			STATUS_NOT_COMMITTED = 3221225517, // 0xC000002D
			STATUS_INVALID_PORT_ATTRIBUTES = 3221225518, // 0xC000002E
			STATUS_PORT_MESSAGE_TOO_LONG = 3221225519, // 0xC000002F
			STATUS_INVALID_PARAMETER_MIX = 3221225520, // 0xC0000030
			STATUS_INVALID_QUOTA_LOWER = 3221225521, // 0xC0000031
			STATUS_DISK_CORRUPT_ERROR = 3221225522, // 0xC0000032
			STATUS_OBJECT_NAME_INVALID = 3221225523, // 0xC0000033
			STATUS_OBJECT_NAME_NOT_FOUND = 3221225524, // 0xC0000034
			STATUS_OBJECT_NAME_COLLISION = 3221225525, // 0xC0000035
			STATUS_PORT_DISCONNECTED = 3221225527, // 0xC0000037
			STATUS_DEVICE_ALREADY_ATTACHED = 3221225528, // 0xC0000038
			STATUS_OBJECT_PATH_INVALID = 3221225529, // 0xC0000039
			STATUS_OBJECT_PATH_NOT_FOUND = 3221225530, // 0xC000003A
			STATUS_OBJECT_PATH_SYNTAX_BAD = 3221225531, // 0xC000003B
			STATUS_DATA_OVERRUN = 3221225532, // 0xC000003C
			STATUS_DATA_LATE_ERROR = 3221225533, // 0xC000003D
			STATUS_DATA_ERROR = 3221225534, // 0xC000003E
			STATUS_CRC_ERROR = 3221225535, // 0xC000003F
			STATUS_SECTION_TOO_BIG = 3221225536, // 0xC0000040
			STATUS_PORT_CONNECTION_REFUSED = 3221225537, // 0xC0000041
			STATUS_INVALID_PORT_HANDLE = 3221225538, // 0xC0000042
			STATUS_SHARING_VIOLATION = 3221225539, // 0xC0000043
			STATUS_QUOTA_EXCEEDED = 3221225540, // 0xC0000044
			STATUS_INVALID_PAGE_PROTECTION = 3221225541, // 0xC0000045
			STATUS_MUTANT_NOT_OWNED = 3221225542, // 0xC0000046
			STATUS_SEMAPHORE_LIMIT_EXCEEDED = 3221225543, // 0xC0000047
			STATUS_PORT_ALREADY_SET = 3221225544, // 0xC0000048
			STATUS_SECTION_NOT_IMAGE = 3221225545, // 0xC0000049
			STATUS_SUSPEND_COUNT_EXCEEDED = 3221225546, // 0xC000004A
			STATUS_THREAD_IS_TERMINATING = 3221225547, // 0xC000004B
			STATUS_BAD_WORKING_SET_LIMIT = 3221225548, // 0xC000004C
			STATUS_INCOMPATIBLE_FILE_MAP = 3221225549, // 0xC000004D
			STATUS_SECTION_PROTECTION = 3221225550, // 0xC000004E
			STATUS_EAS_NOT_SUPPORTED = 3221225551, // 0xC000004F
			STATUS_EA_TOO_LARGE = 3221225552, // 0xC0000050
			STATUS_NONEXISTENT_EA_ENTRY = 3221225553, // 0xC0000051
			STATUS_NO_EAS_ON_FILE = 3221225554, // 0xC0000052
			STATUS_EA_CORRUPT_ERROR = 3221225555, // 0xC0000053
			STATUS_FILE_LOCK_CONFLICT = 3221225556, // 0xC0000054
			STATUS_LOCK_NOT_GRANTED = 3221225557, // 0xC0000055
			STATUS_DELETE_PENDING = 3221225558, // 0xC0000056
			STATUS_CTL_FILE_NOT_SUPPORTED = 3221225559, // 0xC0000057
			STATUS_UNKNOWN_REVISION = 3221225560, // 0xC0000058
			STATUS_REVISION_MISMATCH = 3221225561, // 0xC0000059
			STATUS_INVALID_OWNER = 3221225562, // 0xC000005A
			STATUS_INVALID_PRIMARY_GROUP = 3221225563, // 0xC000005B
			STATUS_NO_IMPERSONATION_TOKEN = 3221225564, // 0xC000005C
			STATUS_CANT_DISABLE_MANDATORY = 3221225565, // 0xC000005D
			STATUS_NO_LOGON_SERVERS = 3221225566, // 0xC000005E
			STATUS_NO_SUCH_LOGON_SESSION = 3221225567, // 0xC000005F
			STATUS_NO_SUCH_PRIVILEGE = 3221225568, // 0xC0000060
			STATUS_PRIVILEGE_NOT_HELD = 3221225569, // 0xC0000061
			STATUS_INVALID_ACCOUNT_NAME = 3221225570, // 0xC0000062
			STATUS_USER_EXISTS = 3221225571, // 0xC0000063
			STATUS_NO_SUCH_USER = 3221225572, // 0xC0000064
			STATUS_GROUP_EXISTS = 3221225573, // 0xC0000065
			STATUS_NO_SUCH_GROUP = 3221225574, // 0xC0000066
			STATUS_MEMBER_IN_GROUP = 3221225575, // 0xC0000067
			STATUS_MEMBER_NOT_IN_GROUP = 3221225576, // 0xC0000068
			STATUS_LAST_ADMIN = 3221225577, // 0xC0000069
			STATUS_WRONG_PASSWORD = 3221225578, // 0xC000006A
			STATUS_ILL_FORMED_PASSWORD = 3221225579, // 0xC000006B
			STATUS_PASSWORD_RESTRICTION = 3221225580, // 0xC000006C
			STATUS_LOGON_FAILURE = 3221225581, // 0xC000006D
			STATUS_ACCOUNT_RESTRICTION = 3221225582, // 0xC000006E
			STATUS_INVALID_LOGON_HOURS = 3221225583, // 0xC000006F
			STATUS_INVALID_WORKSTATION = 3221225584, // 0xC0000070
			STATUS_PASSWORD_EXPIRED = 3221225585, // 0xC0000071
			STATUS_ACCOUNT_DISABLED = 3221225586, // 0xC0000072
			STATUS_NONE_MAPPED = 3221225587, // 0xC0000073
			STATUS_TOO_MANY_LUIDS_REQUESTED = 3221225588, // 0xC0000074
			STATUS_LUIDS_EXHAUSTED = 3221225589, // 0xC0000075
			STATUS_INVALID_SUB_AUTHORITY = 3221225590, // 0xC0000076
			STATUS_INVALID_ACL = 3221225591, // 0xC0000077
			STATUS_INVALID_SID = 3221225592, // 0xC0000078
			STATUS_INVALID_SECURITY_DESCR = 3221225593, // 0xC0000079
			STATUS_PROCEDURE_NOT_FOUND = 3221225594, // 0xC000007A
			STATUS_INVALID_IMAGE_FORMAT = 3221225595, // 0xC000007B
			STATUS_NO_TOKEN = 3221225596, // 0xC000007C
			STATUS_BAD_INHERITANCE_ACL = 3221225597, // 0xC000007D
			STATUS_RANGE_NOT_LOCKED = 3221225598, // 0xC000007E
			STATUS_DISK_FULL = 3221225599, // 0xC000007F
			STATUS_SERVER_DISABLED = 3221225600, // 0xC0000080
			STATUS_SERVER_NOT_DISABLED = 3221225601, // 0xC0000081
			STATUS_TOO_MANY_GUIDS_REQUESTED = 3221225602, // 0xC0000082
			STATUS_GUIDS_EXHAUSTED = 3221225603, // 0xC0000083
			STATUS_INVALID_ID_AUTHORITY = 3221225604, // 0xC0000084
			STATUS_AGENTS_EXHAUSTED = 3221225605, // 0xC0000085
			STATUS_INVALID_VOLUME_LABEL = 3221225606, // 0xC0000086
			STATUS_SECTION_NOT_EXTENDED = 3221225607, // 0xC0000087
			STATUS_NOT_MAPPED_DATA = 3221225608, // 0xC0000088
			STATUS_RESOURCE_DATA_NOT_FOUND = 3221225609, // 0xC0000089
			STATUS_RESOURCE_TYPE_NOT_FOUND = 3221225610, // 0xC000008A
			STATUS_RESOURCE_NAME_NOT_FOUND = 3221225611, // 0xC000008B
			STATUS_ARRAY_BOUNDS_EXCEEDED = 3221225612, // 0xC000008C
			STATUS_FLOAT_DENORMAL_OPERAND = 3221225613, // 0xC000008D
			STATUS_FLOAT_DIVIDE_BY_ZERO = 3221225614, // 0xC000008E
			STATUS_FLOAT_INEXACT_RESULT = 3221225615, // 0xC000008F
			STATUS_FLOAT_INVALID_OPERATION = 3221225616, // 0xC0000090
			STATUS_FLOAT_OVERFLOW = 3221225617, // 0xC0000091
			STATUS_FLOAT_STACK_CHECK = 3221225618, // 0xC0000092
			STATUS_FLOAT_UNDERFLOW = 3221225619, // 0xC0000093
			STATUS_INTEGER_DIVIDE_BY_ZERO = 3221225620, // 0xC0000094
			STATUS_INTEGER_OVERFLOW = 3221225621, // 0xC0000095
			STATUS_PRIVILEGED_INSTRUCTION = 3221225622, // 0xC0000096
			STATUS_TOO_MANY_PAGING_FILES = 3221225623, // 0xC0000097
			STATUS_FILE_INVALID = 3221225624, // 0xC0000098
			STATUS_ALLOTTED_SPACE_EXCEEDED = 3221225625, // 0xC0000099
			STATUS_INSUFFICIENT_RESOURCES = 3221225626, // 0xC000009A
			STATUS_DFS_EXIT_PATH_FOUND = 3221225627, // 0xC000009B
			STATUS_DEVICE_DATA_ERROR = 3221225628, // 0xC000009C
			STATUS_DEVICE_NOT_CONNECTED = 3221225629, // 0xC000009D
			STATUS_DEVICE_POWER_FAILURE = 3221225630, // 0xC000009E
			STATUS_FREE_VM_NOT_AT_BASE = 3221225631, // 0xC000009F
			STATUS_MEMORY_NOT_ALLOCATED = 3221225632, // 0xC00000A0
			STATUS_WORKING_SET_QUOTA = 3221225633, // 0xC00000A1
			STATUS_MEDIA_WRITE_PROTECTED = 3221225634, // 0xC00000A2
			STATUS_DEVICE_NOT_READY = 3221225635, // 0xC00000A3
			STATUS_INVALID_GROUP_ATTRIBUTES = 3221225636, // 0xC00000A4
			STATUS_BAD_IMPERSONATION_LEVEL = 3221225637, // 0xC00000A5
			STATUS_CANT_OPEN_ANONYMOUS = 3221225638, // 0xC00000A6
			STATUS_BAD_VALIDATION_CLASS = 3221225639, // 0xC00000A7
			STATUS_BAD_TOKEN_TYPE = 3221225640, // 0xC00000A8
			STATUS_BAD_MASTER_BOOT_RECORD = 3221225641, // 0xC00000A9
			STATUS_INSTRUCTION_MISALIGNMENT = 3221225642, // 0xC00000AA
			STATUS_INSTANCE_NOT_AVAILABLE = 3221225643, // 0xC00000AB
			STATUS_PIPE_NOT_AVAILABLE = 3221225644, // 0xC00000AC
			STATUS_INVALID_PIPE_STATE = 3221225645, // 0xC00000AD
			STATUS_PIPE_BUSY = 3221225646, // 0xC00000AE
			STATUS_ILLEGAL_FUNCTION = 3221225647, // 0xC00000AF
			STATUS_PIPE_DISCONNECTED = 3221225648, // 0xC00000B0
			STATUS_PIPE_CLOSING = 3221225649, // 0xC00000B1
			STATUS_PIPE_CONNECTED = 3221225650, // 0xC00000B2
			STATUS_PIPE_LISTENING = 3221225651, // 0xC00000B3
			STATUS_INVALID_READ_MODE = 3221225652, // 0xC00000B4
			STATUS_IO_TIMEOUT = 3221225653, // 0xC00000B5
			STATUS_FILE_FORCED_CLOSED = 3221225654, // 0xC00000B6
			STATUS_PROFILING_NOT_STARTED = 3221225655, // 0xC00000B7
			STATUS_PROFILING_NOT_STOPPED = 3221225656, // 0xC00000B8
			STATUS_COULD_NOT_INTERPRET = 3221225657, // 0xC00000B9
			STATUS_FILE_IS_A_DIRECTORY = 3221225658, // 0xC00000BA
			STATUS_NOT_SUPPORTED = 3221225659, // 0xC00000BB
			STATUS_REMOTE_NOT_LISTENING = 3221225660, // 0xC00000BC
			STATUS_DUPLICATE_NAME = 3221225661, // 0xC00000BD
			STATUS_BAD_NETWORK_PATH = 3221225662, // 0xC00000BE
			STATUS_NETWORK_BUSY = 3221225663, // 0xC00000BF
			STATUS_DEVICE_DOES_NOT_EXIST = 3221225664, // 0xC00000C0
			STATUS_TOO_MANY_COMMANDS = 3221225665, // 0xC00000C1
			STATUS_ADAPTER_HARDWARE_ERROR = 3221225666, // 0xC00000C2
			STATUS_INVALID_NETWORK_RESPONSE = 3221225667, // 0xC00000C3
			STATUS_UNEXPECTED_NETWORK_ERROR = 3221225668, // 0xC00000C4
			STATUS_BAD_REMOTE_ADAPTER = 3221225669, // 0xC00000C5
			STATUS_PRINT_QUEUE_FULL = 3221225670, // 0xC00000C6
			STATUS_NO_SPOOL_SPACE = 3221225671, // 0xC00000C7
			STATUS_PRINT_CANCELLED = 3221225672, // 0xC00000C8
			STATUS_NETWORK_NAME_DELETED = 3221225673, // 0xC00000C9
			STATUS_NETWORK_ACCESS_DENIED = 3221225674, // 0xC00000CA
			STATUS_BAD_DEVICE_TYPE = 3221225675, // 0xC00000CB
			STATUS_BAD_NETWORK_NAME = 3221225676, // 0xC00000CC
			STATUS_TOO_MANY_NAMES = 3221225677, // 0xC00000CD
			STATUS_TOO_MANY_SESSIONS = 3221225678, // 0xC00000CE
			STATUS_SHARING_PAUSED = 3221225679, // 0xC00000CF
			STATUS_REQUEST_NOT_ACCEPTED = 3221225680, // 0xC00000D0
			STATUS_REDIRECTOR_PAUSED = 3221225681, // 0xC00000D1
			STATUS_NET_WRITE_FAULT = 3221225682, // 0xC00000D2
			STATUS_PROFILING_AT_LIMIT = 3221225683, // 0xC00000D3
			STATUS_NOT_SAME_DEVICE = 3221225684, // 0xC00000D4
			STATUS_FILE_RENAMED = 3221225685, // 0xC00000D5
			STATUS_VIRTUAL_CIRCUIT_CLOSED = 3221225686, // 0xC00000D6
			STATUS_NO_SECURITY_ON_OBJECT = 3221225687, // 0xC00000D7
			STATUS_CANT_WAIT = 3221225688, // 0xC00000D8
			STATUS_PIPE_EMPTY = 3221225689, // 0xC00000D9
			STATUS_CANT_ACCESS_DOMAIN_INFO = 3221225690, // 0xC00000DA
			STATUS_CANT_TERMINATE_SELF = 3221225691, // 0xC00000DB
			STATUS_INVALID_SERVER_STATE = 3221225692, // 0xC00000DC
			STATUS_INVALID_DOMAIN_STATE = 3221225693, // 0xC00000DD
			STATUS_INVALID_DOMAIN_ROLE = 3221225694, // 0xC00000DE
			STATUS_NO_SUCH_DOMAIN = 3221225695, // 0xC00000DF
			STATUS_DOMAIN_EXISTS = 3221225696, // 0xC00000E0
			STATUS_DOMAIN_LIMIT_EXCEEDED = 3221225697, // 0xC00000E1
			STATUS_OPLOCK_NOT_GRANTED = 3221225698, // 0xC00000E2
			STATUS_INVALID_OPLOCK_PROTOCOL = 3221225699, // 0xC00000E3
			STATUS_INTERNAL_DB_CORRUPTION = 3221225700, // 0xC00000E4
			STATUS_INTERNAL_ERROR = 3221225701, // 0xC00000E5
			STATUS_GENERIC_NOT_MAPPED = 3221225702, // 0xC00000E6
			STATUS_BAD_DESCRIPTOR_FORMAT = 3221225703, // 0xC00000E7
			STATUS_INVALID_USER_BUFFER = 3221225704, // 0xC00000E8
			STATUS_UNEXPECTED_IO_ERROR = 3221225705, // 0xC00000E9
			STATUS_UNEXPECTED_MM_CREATE_ERR = 3221225706, // 0xC00000EA
			STATUS_UNEXPECTED_MM_MAP_ERROR = 3221225707, // 0xC00000EB
			STATUS_UNEXPECTED_MM_EXTEND_ERR = 3221225708, // 0xC00000EC
			STATUS_NOT_LOGON_PROCESS = 3221225709, // 0xC00000ED
			STATUS_LOGON_SESSION_EXISTS = 3221225710, // 0xC00000EE
			STATUS_INVALID_PARAMETER_1 = 3221225711, // 0xC00000EF
			STATUS_INVALID_PARAMETER_2 = 3221225712, // 0xC00000F0
			STATUS_INVALID_PARAMETER_3 = 3221225713, // 0xC00000F1
			STATUS_INVALID_PARAMETER_4 = 3221225714, // 0xC00000F2
			STATUS_INVALID_PARAMETER_5 = 3221225715, // 0xC00000F3
			STATUS_INVALID_PARAMETER_6 = 3221225716, // 0xC00000F4
			STATUS_INVALID_PARAMETER_7 = 3221225717, // 0xC00000F5
			STATUS_INVALID_PARAMETER_8 = 3221225718, // 0xC00000F6
			STATUS_INVALID_PARAMETER_9 = 3221225719, // 0xC00000F7
			STATUS_INVALID_PARAMETER_10 = 3221225720, // 0xC00000F8
			STATUS_INVALID_PARAMETER_11 = 3221225721, // 0xC00000F9
			STATUS_INVALID_PARAMETER_12 = 3221225722, // 0xC00000FA
			STATUS_REDIRECTOR_NOT_STARTED = 3221225723, // 0xC00000FB
			STATUS_REDIRECTOR_STARTED = 3221225724, // 0xC00000FC
			STATUS_STACK_OVERFLOW = 3221225725, // 0xC00000FD
			STATUS_NO_SUCH_PACKAGE = 3221225726, // 0xC00000FE
			STATUS_BAD_FUNCTION_TABLE = 3221225727, // 0xC00000FF
			STATUS_VARIABLE_NOT_FOUND = 3221225728, // 0xC0000100
			STATUS_DIRECTORY_NOT_EMPTY = 3221225729, // 0xC0000101
			STATUS_FILE_CORRUPT_ERROR = 3221225730, // 0xC0000102
			STATUS_NOT_A_DIRECTORY = 3221225731, // 0xC0000103
			STATUS_BAD_LOGON_SESSION_STATE = 3221225732, // 0xC0000104
			STATUS_LOGON_SESSION_COLLISION = 3221225733, // 0xC0000105
			STATUS_NAME_TOO_LONG = 3221225734, // 0xC0000106
			STATUS_FILES_OPEN = 3221225735, // 0xC0000107
			STATUS_CONNECTION_IN_USE = 3221225736, // 0xC0000108
			STATUS_MESSAGE_NOT_FOUND = 3221225737, // 0xC0000109
			STATUS_PROCESS_IS_TERMINATING = 3221225738, // 0xC000010A
			STATUS_INVALID_LOGON_TYPE = 3221225739, // 0xC000010B
			STATUS_NO_GUID_TRANSLATION = 3221225740, // 0xC000010C
			STATUS_CANNOT_IMPERSONATE = 3221225741, // 0xC000010D
			STATUS_IMAGE_ALREADY_LOADED = 3221225742, // 0xC000010E
			STATUS_ABIOS_NOT_PRESENT = 3221225743, // 0xC000010F
			STATUS_ABIOS_LID_NOT_EXIST = 3221225744, // 0xC0000110
			STATUS_ABIOS_LID_ALREADY_OWNED = 3221225745, // 0xC0000111
			STATUS_ABIOS_NOT_LID_OWNER = 3221225746, // 0xC0000112
			STATUS_ABIOS_INVALID_COMMAND = 3221225747, // 0xC0000113
			STATUS_ABIOS_INVALID_LID = 3221225748, // 0xC0000114
			STATUS_ABIOS_SELECTOR_NOT_AVAILABLE = 3221225749, // 0xC0000115
			STATUS_ABIOS_INVALID_SELECTOR = 3221225750, // 0xC0000116
			STATUS_NO_LDT = 3221225751, // 0xC0000117
			STATUS_INVALID_LDT_SIZE = 3221225752, // 0xC0000118
			STATUS_INVALID_LDT_OFFSET = 3221225753, // 0xC0000119
			STATUS_INVALID_LDT_DESCRIPTOR = 3221225754, // 0xC000011A
			STATUS_INVALID_IMAGE_NE_FORMAT = 3221225755, // 0xC000011B
			STATUS_RXACT_INVALID_STATE = 3221225756, // 0xC000011C
			STATUS_RXACT_COMMIT_FAILURE = 3221225757, // 0xC000011D
			STATUS_MAPPED_FILE_SIZE_ZERO = 3221225758, // 0xC000011E
			STATUS_TOO_MANY_OPENED_FILES = 3221225759, // 0xC000011F
			STATUS_CANCELLED = 3221225760, // 0xC0000120
			STATUS_CANNOT_DELETE = 3221225761, // 0xC0000121
			STATUS_INVALID_COMPUTER_NAME = 3221225762, // 0xC0000122
			STATUS_FILE_DELETED = 3221225763, // 0xC0000123
			STATUS_SPECIAL_ACCOUNT = 3221225764, // 0xC0000124
			STATUS_SPECIAL_GROUP = 3221225765, // 0xC0000125
			STATUS_SPECIAL_USER = 3221225766, // 0xC0000126
			STATUS_MEMBERS_PRIMARY_GROUP = 3221225767, // 0xC0000127
			STATUS_FILE_CLOSED = 3221225768, // 0xC0000128
			STATUS_TOO_MANY_THREADS = 3221225769, // 0xC0000129
			STATUS_THREAD_NOT_IN_PROCESS = 3221225770, // 0xC000012A
			STATUS_TOKEN_ALREADY_IN_USE = 3221225771, // 0xC000012B
			STATUS_PAGEFILE_QUOTA_EXCEEDED = 3221225772, // 0xC000012C
			STATUS_COMMITMENT_LIMIT = 3221225773, // 0xC000012D
			STATUS_INVALID_IMAGE_LE_FORMAT = 3221225774, // 0xC000012E
			STATUS_INVALID_IMAGE_NOT_MZ = 3221225775, // 0xC000012F
			STATUS_INVALID_IMAGE_PROTECT = 3221225776, // 0xC0000130
			STATUS_INVALID_IMAGE_WIN_16 = 3221225777, // 0xC0000131
			STATUS_LOGON_SERVER_CONFLICT = 3221225778, // 0xC0000132
			STATUS_TIME_DIFFERENCE_AT_DC = 3221225779, // 0xC0000133
			STATUS_SYNCHRONIZATION_REQUIRED = 3221225780, // 0xC0000134
			STATUS_DLL_NOT_FOUND = 3221225781, // 0xC0000135
			STATUS_OPEN_FAILED = 3221225782, // 0xC0000136
			STATUS_IO_PRIVILEGE_FAILED = 3221225783, // 0xC0000137
			STATUS_ORDINAL_NOT_FOUND = 3221225784, // 0xC0000138
			STATUS_ENTRYPOINT_NOT_FOUND = 3221225785, // 0xC0000139
			STATUS_CONTROL_C_EXIT = 3221225786, // 0xC000013A
			STATUS_LOCAL_DISCONNECT = 3221225787, // 0xC000013B
			STATUS_REMOTE_DISCONNECT = 3221225788, // 0xC000013C
			STATUS_REMOTE_RESOURCES = 3221225789, // 0xC000013D
			STATUS_LINK_FAILED = 3221225790, // 0xC000013E
			STATUS_LINK_TIMEOUT = 3221225791, // 0xC000013F
			STATUS_INVALID_CONNECTION = 3221225792, // 0xC0000140
			STATUS_INVALID_ADDRESS = 3221225793, // 0xC0000141
			STATUS_DLL_INIT_FAILED = 3221225794, // 0xC0000142
			STATUS_MISSING_SYSTEMFILE = 3221225795, // 0xC0000143
			STATUS_UNHANDLED_EXCEPTION = 3221225796, // 0xC0000144
			STATUS_APP_INIT_FAILURE = 3221225797, // 0xC0000145
			STATUS_PAGEFILE_CREATE_FAILED = 3221225798, // 0xC0000146
			STATUS_NO_PAGEFILE = 3221225799, // 0xC0000147
			STATUS_INVALID_LEVEL = 3221225800, // 0xC0000148
			STATUS_WRONG_PASSWORD_CORE = 3221225801, // 0xC0000149
			STATUS_ILLEGAL_FLOAT_CONTEXT = 3221225802, // 0xC000014A
			STATUS_PIPE_BROKEN = 3221225803, // 0xC000014B
			STATUS_REGISTRY_CORRUPT = 3221225804, // 0xC000014C
			STATUS_REGISTRY_IO_FAILED = 3221225805, // 0xC000014D
			STATUS_NO_EVENT_PAIR = 3221225806, // 0xC000014E
			STATUS_UNRECOGNIZED_VOLUME = 3221225807, // 0xC000014F
			STATUS_SERIAL_NO_DEVICE_INITED = 3221225808, // 0xC0000150
			STATUS_NO_SUCH_ALIAS = 3221225809, // 0xC0000151
			STATUS_MEMBER_NOT_IN_ALIAS = 3221225810, // 0xC0000152
			STATUS_MEMBER_IN_ALIAS = 3221225811, // 0xC0000153
			STATUS_ALIAS_EXISTS = 3221225812, // 0xC0000154
			STATUS_LOGON_NOT_GRANTED = 3221225813, // 0xC0000155
			STATUS_TOO_MANY_SECRETS = 3221225814, // 0xC0000156
			STATUS_SECRET_TOO_LONG = 3221225815, // 0xC0000157
			STATUS_INTERNAL_DB_ERROR = 3221225816, // 0xC0000158
			STATUS_FULLSCREEN_MODE = 3221225817, // 0xC0000159
			STATUS_TOO_MANY_CONTEXT_IDS = 3221225818, // 0xC000015A
			STATUS_LOGON_TYPE_NOT_GRANTED = 3221225819, // 0xC000015B
			STATUS_NOT_REGISTRY_FILE = 3221225820, // 0xC000015C
			STATUS_NT_CROSS_ENCRYPTION_REQUIRED = 3221225821, // 0xC000015D
			STATUS_DOMAIN_CTRLR_CONFIG_ERROR = 3221225822, // 0xC000015E
			STATUS_FT_MISSING_MEMBER = 3221225823, // 0xC000015F
			STATUS_ILL_FORMED_SERVICE_ENTRY = 3221225824, // 0xC0000160
			STATUS_ILLEGAL_CHARACTER = 3221225825, // 0xC0000161
			STATUS_UNMAPPABLE_CHARACTER = 3221225826, // 0xC0000162
			STATUS_UNDEFINED_CHARACTER = 3221225827, // 0xC0000163
			STATUS_FLOPPY_VOLUME = 3221225828, // 0xC0000164
			STATUS_FLOPPY_ID_MARK_NOT_FOUND = 3221225829, // 0xC0000165
			STATUS_FLOPPY_WRONG_CYLINDER = 3221225830, // 0xC0000166
			STATUS_FLOPPY_UNKNOWN_ERROR = 3221225831, // 0xC0000167
			STATUS_FLOPPY_BAD_REGISTERS = 3221225832, // 0xC0000168
			STATUS_DISK_RECALIBRATE_FAILED = 3221225833, // 0xC0000169
			STATUS_DISK_OPERATION_FAILED = 3221225834, // 0xC000016A
			STATUS_DISK_RESET_FAILED = 3221225835, // 0xC000016B
			STATUS_SHARED_IRQ_BUSY = 3221225836, // 0xC000016C
			STATUS_FT_ORPHANING = 3221225837, // 0xC000016D
			STATUS_BIOS_FAILED_TO_CONNECT_INTERRUPT = 3221225838, // 0xC000016E
			STATUS_PARTITION_FAILURE = 3221225842, // 0xC0000172
			STATUS_INVALID_BLOCK_LENGTH = 3221225843, // 0xC0000173
			STATUS_DEVICE_NOT_PARTITIONED = 3221225844, // 0xC0000174
			STATUS_UNABLE_TO_LOCK_MEDIA = 3221225845, // 0xC0000175
			STATUS_UNABLE_TO_UNLOAD_MEDIA = 3221225846, // 0xC0000176
			STATUS_EOM_OVERFLOW = 3221225847, // 0xC0000177
			STATUS_NO_MEDIA = 3221225848, // 0xC0000178
			STATUS_NO_SUCH_MEMBER = 3221225850, // 0xC000017A
			STATUS_INVALID_MEMBER = 3221225851, // 0xC000017B
			STATUS_KEY_DELETED = 3221225852, // 0xC000017C
			STATUS_NO_LOG_SPACE = 3221225853, // 0xC000017D
			STATUS_TOO_MANY_SIDS = 3221225854, // 0xC000017E
			STATUS_LM_CROSS_ENCRYPTION_REQUIRED = 3221225855, // 0xC000017F
			STATUS_KEY_HAS_CHILDREN = 3221225856, // 0xC0000180
			STATUS_CHILD_MUST_BE_VOLATILE = 3221225857, // 0xC0000181
			STATUS_DEVICE_CONFIGURATION_ERROR = 3221225858, // 0xC0000182
			STATUS_DRIVER_INTERNAL_ERROR = 3221225859, // 0xC0000183
			STATUS_INVALID_DEVICE_STATE = 3221225860, // 0xC0000184
			STATUS_IO_DEVICE_ERROR = 3221225861, // 0xC0000185
			STATUS_DEVICE_PROTOCOL_ERROR = 3221225862, // 0xC0000186
			STATUS_BACKUP_CONTROLLER = 3221225863, // 0xC0000187
			STATUS_LOG_FILE_FULL = 3221225864, // 0xC0000188
			STATUS_TOO_LATE = 3221225865, // 0xC0000189
			STATUS_NO_TRUST_LSA_SECRET = 3221225866, // 0xC000018A
			STATUS_NO_TRUST_SAM_ACCOUNT = 3221225867, // 0xC000018B
			STATUS_TRUSTED_DOMAIN_FAILURE = 3221225868, // 0xC000018C
			STATUS_TRUSTED_RELATIONSHIP_FAILURE = 3221225869, // 0xC000018D
			STATUS_EVENTLOG_FILE_CORRUPT = 3221225870, // 0xC000018E
			STATUS_EVENTLOG_CANT_START = 3221225871, // 0xC000018F
			STATUS_TRUST_FAILURE = 3221225872, // 0xC0000190
			STATUS_MUTANT_LIMIT_EXCEEDED = 3221225873, // 0xC0000191
			STATUS_NETLOGON_NOT_STARTED = 3221225874, // 0xC0000192
			STATUS_ACCOUNT_EXPIRED = 3221225875, // 0xC0000193
			STATUS_POSSIBLE_DEADLOCK = 3221225876, // 0xC0000194
			STATUS_NETWORK_CREDENTIAL_CONFLICT = 3221225877, // 0xC0000195
			STATUS_REMOTE_SESSION_LIMIT = 3221225878, // 0xC0000196
			STATUS_EVENTLOG_FILE_CHANGED = 3221225879, // 0xC0000197
			STATUS_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 3221225880, // 0xC0000198
			STATUS_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 3221225881, // 0xC0000199
			STATUS_NOLOGON_SERVER_TRUST_ACCOUNT = 3221225882, // 0xC000019A
			STATUS_DOMAIN_TRUST_INCONSISTENT = 3221225883, // 0xC000019B
			STATUS_FS_DRIVER_REQUIRED = 3221225884, // 0xC000019C
			STATUS_IMAGE_ALREADY_LOADED_AS_DLL = 3221225885, // 0xC000019D
			STATUS_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 3221225886, // 0xC000019E
			STATUS_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 3221225887, // 0xC000019F
			STATUS_SECURITY_STREAM_IS_INCONSISTENT = 3221225888, // 0xC00001A0
			STATUS_INVALID_LOCK_RANGE = 3221225889, // 0xC00001A1
			STATUS_INVALID_ACE_CONDITION = 3221225890, // 0xC00001A2
			STATUS_IMAGE_SUBSYSTEM_NOT_PRESENT = 3221225891, // 0xC00001A3
			STATUS_NOTIFICATION_GUID_ALREADY_DEFINED = 3221225892, // 0xC00001A4
			STATUS_INVALID_EXCEPTION_HANDLER = 3221225893, // 0xC00001A5
			STATUS_DUPLICATE_PRIVILEGES = 3221225894, // 0xC00001A6
			STATUS_NOT_ALLOWED_ON_SYSTEM_FILE = 3221225895, // 0xC00001A7
			STATUS_REPAIR_NEEDED = 3221225896, // 0xC00001A8
			STATUS_QUOTA_NOT_ENABLED = 3221225897, // 0xC00001A9
			STATUS_NO_APPLICATION_PACKAGE = 3221225898, // 0xC00001AA
			STATUS_NETWORK_OPEN_RESTRICTION = 3221225985, // 0xC0000201
			STATUS_NO_USER_SESSION_KEY = 3221225986, // 0xC0000202
			STATUS_USER_SESSION_DELETED = 3221225987, // 0xC0000203
			STATUS_RESOURCE_LANG_NOT_FOUND = 3221225988, // 0xC0000204
			STATUS_INSUFF_SERVER_RESOURCES = 3221225989, // 0xC0000205
			STATUS_INVALID_BUFFER_SIZE = 3221225990, // 0xC0000206
			STATUS_INVALID_ADDRESS_COMPONENT = 3221225991, // 0xC0000207
			STATUS_INVALID_ADDRESS_WILDCARD = 3221225992, // 0xC0000208
			STATUS_TOO_MANY_ADDRESSES = 3221225993, // 0xC0000209
			STATUS_ADDRESS_ALREADY_EXISTS = 3221225994, // 0xC000020A
			STATUS_ADDRESS_CLOSED = 3221225995, // 0xC000020B
			STATUS_CONNECTION_DISCONNECTED = 3221225996, // 0xC000020C
			STATUS_CONNECTION_RESET = 3221225997, // 0xC000020D
			STATUS_TOO_MANY_NODES = 3221225998, // 0xC000020E
			STATUS_TRANSACTION_ABORTED = 3221225999, // 0xC000020F
			STATUS_TRANSACTION_TIMED_OUT = 3221226000, // 0xC0000210
			STATUS_TRANSACTION_NO_RELEASE = 3221226001, // 0xC0000211
			STATUS_TRANSACTION_NO_MATCH = 3221226002, // 0xC0000212
			STATUS_TRANSACTION_RESPONDED = 3221226003, // 0xC0000213
			STATUS_TRANSACTION_INVALID_ID = 3221226004, // 0xC0000214
			STATUS_TRANSACTION_INVALID_TYPE = 3221226005, // 0xC0000215
			STATUS_NOT_SERVER_SESSION = 3221226006, // 0xC0000216
			STATUS_NOT_CLIENT_SESSION = 3221226007, // 0xC0000217
			STATUS_CANNOT_LOAD_REGISTRY_FILE = 3221226008, // 0xC0000218
			STATUS_DEBUG_ATTACH_FAILED = 3221226009, // 0xC0000219
			STATUS_SYSTEM_PROCESS_TERMINATED = 3221226010, // 0xC000021A
			STATUS_DATA_NOT_ACCEPTED = 3221226011, // 0xC000021B
			STATUS_NO_BROWSER_SERVERS_FOUND = 3221226012, // 0xC000021C
			STATUS_VDM_HARD_ERROR = 3221226013, // 0xC000021D
			STATUS_DRIVER_CANCEL_TIMEOUT = 3221226014, // 0xC000021E
			STATUS_REPLY_MESSAGE_MISMATCH = 3221226015, // 0xC000021F
			STATUS_MAPPED_ALIGNMENT = 3221226016, // 0xC0000220
			STATUS_IMAGE_CHECKSUM_MISMATCH = 3221226017, // 0xC0000221
			STATUS_LOST_WRITEBEHIND_DATA = 3221226018, // 0xC0000222
			STATUS_CLIENT_SERVER_PARAMETERS_INVALID = 3221226019, // 0xC0000223
			STATUS_PASSWORD_MUST_CHANGE = 3221226020, // 0xC0000224
			STATUS_NOT_FOUND = 3221226021, // 0xC0000225
			STATUS_NOT_TINY_STREAM = 3221226022, // 0xC0000226
			STATUS_RECOVERY_FAILURE = 3221226023, // 0xC0000227
			STATUS_STACK_OVERFLOW_READ = 3221226024, // 0xC0000228
			STATUS_FAIL_CHECK = 3221226025, // 0xC0000229
			STATUS_DUPLICATE_OBJECTID = 3221226026, // 0xC000022A
			STATUS_OBJECTID_EXISTS = 3221226027, // 0xC000022B
			STATUS_CONVERT_TO_LARGE = 3221226028, // 0xC000022C
			STATUS_RETRY = 3221226029, // 0xC000022D
			STATUS_FOUND_OUT_OF_SCOPE = 3221226030, // 0xC000022E
			STATUS_ALLOCATE_BUCKET = 3221226031, // 0xC000022F
			STATUS_PROPSET_NOT_FOUND = 3221226032, // 0xC0000230
			STATUS_MARSHALL_OVERFLOW = 3221226033, // 0xC0000231
			STATUS_INVALID_VARIANT = 3221226034, // 0xC0000232
			STATUS_DOMAIN_CONTROLLER_NOT_FOUND = 3221226035, // 0xC0000233
			STATUS_ACCOUNT_LOCKED_OUT = 3221226036, // 0xC0000234
			STATUS_HANDLE_NOT_CLOSABLE = 3221226037, // 0xC0000235
			STATUS_CONNECTION_REFUSED = 3221226038, // 0xC0000236
			STATUS_GRACEFUL_DISCONNECT = 3221226039, // 0xC0000237
			STATUS_ADDRESS_ALREADY_ASSOCIATED = 3221226040, // 0xC0000238
			STATUS_ADDRESS_NOT_ASSOCIATED = 3221226041, // 0xC0000239
			STATUS_CONNECTION_INVALID = 3221226042, // 0xC000023A
			STATUS_CONNECTION_ACTIVE = 3221226043, // 0xC000023B
			STATUS_NETWORK_UNREACHABLE = 3221226044, // 0xC000023C
			STATUS_HOST_UNREACHABLE = 3221226045, // 0xC000023D
			STATUS_PROTOCOL_UNREACHABLE = 3221226046, // 0xC000023E
			STATUS_PORT_UNREACHABLE = 3221226047, // 0xC000023F
			STATUS_REQUEST_ABORTED = 3221226048, // 0xC0000240
			STATUS_CONNECTION_ABORTED = 3221226049, // 0xC0000241
			STATUS_BAD_COMPRESSION_BUFFER = 3221226050, // 0xC0000242
			STATUS_USER_MAPPED_FILE = 3221226051, // 0xC0000243
			STATUS_AUDIT_FAILED = 3221226052, // 0xC0000244
			STATUS_TIMER_RESOLUTION_NOT_SET = 3221226053, // 0xC0000245
			STATUS_CONNECTION_COUNT_LIMIT = 3221226054, // 0xC0000246
			STATUS_LOGIN_TIME_RESTRICTION = 3221226055, // 0xC0000247
			STATUS_LOGIN_WKSTA_RESTRICTION = 3221226056, // 0xC0000248
			STATUS_IMAGE_MP_UP_MISMATCH = 3221226057, // 0xC0000249
			STATUS_INSUFFICIENT_LOGON_INFO = 3221226064, // 0xC0000250
			STATUS_BAD_DLL_ENTRYPOINT = 3221226065, // 0xC0000251
			STATUS_BAD_SERVICE_ENTRYPOINT = 3221226066, // 0xC0000252
			STATUS_LPC_REPLY_LOST = 3221226067, // 0xC0000253
			STATUS_IP_ADDRESS_CONFLICT1 = 3221226068, // 0xC0000254
			STATUS_IP_ADDRESS_CONFLICT2 = 3221226069, // 0xC0000255
			STATUS_REGISTRY_QUOTA_LIMIT = 3221226070, // 0xC0000256
			STATUS_PATH_NOT_COVERED = 3221226071, // 0xC0000257
			STATUS_NO_CALLBACK_ACTIVE = 3221226072, // 0xC0000258
			STATUS_LICENSE_QUOTA_EXCEEDED = 3221226073, // 0xC0000259
			STATUS_PWD_TOO_SHORT = 3221226074, // 0xC000025A
			STATUS_PWD_TOO_RECENT = 3221226075, // 0xC000025B
			STATUS_PWD_HISTORY_CONFLICT = 3221226076, // 0xC000025C
			STATUS_PLUGPLAY_NO_DEVICE = 3221226078, // 0xC000025E
			STATUS_UNSUPPORTED_COMPRESSION = 3221226079, // 0xC000025F
			STATUS_INVALID_HW_PROFILE = 3221226080, // 0xC0000260
			STATUS_INVALID_PLUGPLAY_DEVICE_PATH = 3221226081, // 0xC0000261
			STATUS_DRIVER_ORDINAL_NOT_FOUND = 3221226082, // 0xC0000262
			STATUS_DRIVER_ENTRYPOINT_NOT_FOUND = 3221226083, // 0xC0000263
			STATUS_RESOURCE_NOT_OWNED = 3221226084, // 0xC0000264
			STATUS_TOO_MANY_LINKS = 3221226085, // 0xC0000265
			STATUS_QUOTA_LIST_INCONSISTENT = 3221226086, // 0xC0000266
			STATUS_FILE_IS_OFFLINE = 3221226087, // 0xC0000267
			STATUS_EVALUATION_EXPIRATION = 3221226088, // 0xC0000268
			STATUS_ILLEGAL_DLL_RELOCATION = 3221226089, // 0xC0000269
			STATUS_LICENSE_VIOLATION = 3221226090, // 0xC000026A
			STATUS_DLL_INIT_FAILED_LOGOFF = 3221226091, // 0xC000026B
			STATUS_DRIVER_UNABLE_TO_LOAD = 3221226092, // 0xC000026C
			STATUS_DFS_UNAVAILABLE = 3221226093, // 0xC000026D
			STATUS_VOLUME_DISMOUNTED = 3221226094, // 0xC000026E
			STATUS_WX86_INTERNAL_ERROR = 3221226095, // 0xC000026F
			STATUS_WX86_FLOAT_STACK_CHECK = 3221226096, // 0xC0000270
			STATUS_VALIDATE_CONTINUE = 3221226097, // 0xC0000271
			STATUS_NO_MATCH = 3221226098, // 0xC0000272
			STATUS_NO_MORE_MATCHES = 3221226099, // 0xC0000273
			STATUS_NOT_A_REPARSE_POINT = 3221226101, // 0xC0000275
			STATUS_IO_REPARSE_TAG_INVALID = 3221226102, // 0xC0000276
			STATUS_IO_REPARSE_TAG_MISMATCH = 3221226103, // 0xC0000277
			STATUS_IO_REPARSE_DATA_INVALID = 3221226104, // 0xC0000278
			STATUS_IO_REPARSE_TAG_NOT_HANDLED = 3221226105, // 0xC0000279
			STATUS_PWD_TOO_LONG = 3221226106, // 0xC000027A
			STATUS_STOWED_EXCEPTION = 3221226107, // 0xC000027B
			STATUS_REPARSE_POINT_NOT_RESOLVED = 3221226112, // 0xC0000280
			STATUS_DIRECTORY_IS_A_REPARSE_POINT = 3221226113, // 0xC0000281
			STATUS_RANGE_LIST_CONFLICT = 3221226114, // 0xC0000282
			STATUS_SOURCE_ELEMENT_EMPTY = 3221226115, // 0xC0000283
			STATUS_DESTINATION_ELEMENT_FULL = 3221226116, // 0xC0000284
			STATUS_ILLEGAL_ELEMENT_ADDRESS = 3221226117, // 0xC0000285
			STATUS_MAGAZINE_NOT_PRESENT = 3221226118, // 0xC0000286
			STATUS_REINITIALIZATION_NEEDED = 3221226119, // 0xC0000287
			STATUS_ENCRYPTION_FAILED = 3221226122, // 0xC000028A
			STATUS_DECRYPTION_FAILED = 3221226123, // 0xC000028B
			STATUS_RANGE_NOT_FOUND = 3221226124, // 0xC000028C
			STATUS_NO_RECOVERY_POLICY = 3221226125, // 0xC000028D
			STATUS_NO_EFS = 3221226126, // 0xC000028E
			STATUS_WRONG_EFS = 3221226127, // 0xC000028F
			STATUS_NO_USER_KEYS = 3221226128, // 0xC0000290
			STATUS_FILE_NOT_ENCRYPTED = 3221226129, // 0xC0000291
			STATUS_NOT_EXPORT_FORMAT = 3221226130, // 0xC0000292
			STATUS_FILE_ENCRYPTED = 3221226131, // 0xC0000293
			STATUS_WMI_GUID_NOT_FOUND = 3221226133, // 0xC0000295
			STATUS_WMI_INSTANCE_NOT_FOUND = 3221226134, // 0xC0000296
			STATUS_WMI_ITEMID_NOT_FOUND = 3221226135, // 0xC0000297
			STATUS_WMI_TRY_AGAIN = 3221226136, // 0xC0000298
			STATUS_SHARED_POLICY = 3221226137, // 0xC0000299
			STATUS_POLICY_OBJECT_NOT_FOUND = 3221226138, // 0xC000029A
			STATUS_POLICY_ONLY_IN_DS = 3221226139, // 0xC000029B
			STATUS_VOLUME_NOT_UPGRADED = 3221226140, // 0xC000029C
			STATUS_REMOTE_STORAGE_NOT_ACTIVE = 3221226141, // 0xC000029D
			STATUS_REMOTE_STORAGE_MEDIA_ERROR = 3221226142, // 0xC000029E
			STATUS_NO_TRACKING_SERVICE = 3221226143, // 0xC000029F
			STATUS_SERVER_SID_MISMATCH = 3221226144, // 0xC00002A0
			STATUS_DS_NO_ATTRIBUTE_OR_VALUE = 3221226145, // 0xC00002A1
			STATUS_DS_INVALID_ATTRIBUTE_SYNTAX = 3221226146, // 0xC00002A2
			STATUS_DS_ATTRIBUTE_TYPE_UNDEFINED = 3221226147, // 0xC00002A3
			STATUS_DS_ATTRIBUTE_OR_VALUE_EXISTS = 3221226148, // 0xC00002A4
			STATUS_DS_BUSY = 3221226149, // 0xC00002A5
			STATUS_DS_UNAVAILABLE = 3221226150, // 0xC00002A6
			STATUS_DS_NO_RIDS_ALLOCATED = 3221226151, // 0xC00002A7
			STATUS_DS_NO_MORE_RIDS = 3221226152, // 0xC00002A8
			STATUS_DS_INCORRECT_ROLE_OWNER = 3221226153, // 0xC00002A9
			STATUS_DS_RIDMGR_INIT_ERROR = 3221226154, // 0xC00002AA
			STATUS_DS_OBJ_CLASS_VIOLATION = 3221226155, // 0xC00002AB
			STATUS_DS_CANT_ON_NON_LEAF = 3221226156, // 0xC00002AC
			STATUS_DS_CANT_ON_RDN = 3221226157, // 0xC00002AD
			STATUS_DS_CANT_MOD_OBJ_CLASS = 3221226158, // 0xC00002AE
			STATUS_DS_CROSS_DOM_MOVE_FAILED = 3221226159, // 0xC00002AF
			STATUS_DS_GC_NOT_AVAILABLE = 3221226160, // 0xC00002B0
			STATUS_DIRECTORY_SERVICE_REQUIRED = 3221226161, // 0xC00002B1
			STATUS_REPARSE_ATTRIBUTE_CONFLICT = 3221226162, // 0xC00002B2
			STATUS_CANT_ENABLE_DENY_ONLY = 3221226163, // 0xC00002B3
			STATUS_FLOAT_MULTIPLE_FAULTS = 3221226164, // 0xC00002B4
			STATUS_FLOAT_MULTIPLE_TRAPS = 3221226165, // 0xC00002B5
			STATUS_DEVICE_REMOVED = 3221226166, // 0xC00002B6
			STATUS_JOURNAL_DELETE_IN_PROGRESS = 3221226167, // 0xC00002B7
			STATUS_JOURNAL_NOT_ACTIVE = 3221226168, // 0xC00002B8
			STATUS_NOINTERFACE = 3221226169, // 0xC00002B9
			STATUS_DS_RIDMGR_DISABLED = 3221226170, // 0xC00002BA
			STATUS_DS_ADMIN_LIMIT_EXCEEDED = 3221226177, // 0xC00002C1
			STATUS_DRIVER_FAILED_SLEEP = 3221226178, // 0xC00002C2
			STATUS_MUTUAL_AUTHENTICATION_FAILED = 3221226179, // 0xC00002C3
			STATUS_CORRUPT_SYSTEM_FILE = 3221226180, // 0xC00002C4
			STATUS_DATATYPE_MISALIGNMENT_ERROR = 3221226181, // 0xC00002C5
			STATUS_WMI_READ_ONLY = 3221226182, // 0xC00002C6
			STATUS_WMI_SET_FAILURE = 3221226183, // 0xC00002C7
			STATUS_COMMITMENT_MINIMUM = 3221226184, // 0xC00002C8
			STATUS_REG_NAT_CONSUMPTION = 3221226185, // 0xC00002C9
			STATUS_TRANSPORT_FULL = 3221226186, // 0xC00002CA
			STATUS_DS_SAM_INIT_FAILURE = 3221226187, // 0xC00002CB
			STATUS_ONLY_IF_CONNECTED = 3221226188, // 0xC00002CC
			STATUS_DS_SENSITIVE_GROUP_VIOLATION = 3221226189, // 0xC00002CD
			STATUS_PNP_RESTART_ENUMERATION = 3221226190, // 0xC00002CE
			STATUS_JOURNAL_ENTRY_DELETED = 3221226191, // 0xC00002CF
			STATUS_DS_CANT_MOD_PRIMARYGROUPID = 3221226192, // 0xC00002D0
			STATUS_SYSTEM_IMAGE_BAD_SIGNATURE = 3221226193, // 0xC00002D1
			STATUS_PNP_REBOOT_REQUIRED = 3221226194, // 0xC00002D2
			STATUS_POWER_STATE_INVALID = 3221226195, // 0xC00002D3
			STATUS_DS_INVALID_GROUP_TYPE = 3221226196, // 0xC00002D4
			STATUS_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 3221226197, // 0xC00002D5
			STATUS_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 3221226198, // 0xC00002D6
			STATUS_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 3221226199, // 0xC00002D7
			STATUS_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 3221226200, // 0xC00002D8
			STATUS_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 3221226201, // 0xC00002D9
			STATUS_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 3221226202, // 0xC00002DA
			STATUS_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 3221226203, // 0xC00002DB
			STATUS_DS_HAVE_PRIMARY_MEMBERS = 3221226204, // 0xC00002DC
			STATUS_WMI_NOT_SUPPORTED = 3221226205, // 0xC00002DD
			STATUS_INSUFFICIENT_POWER = 3221226206, // 0xC00002DE
			STATUS_SAM_NEED_BOOTKEY_PASSWORD = 3221226207, // 0xC00002DF
			STATUS_SAM_NEED_BOOTKEY_FLOPPY = 3221226208, // 0xC00002E0
			STATUS_DS_CANT_START = 3221226209, // 0xC00002E1
			STATUS_DS_INIT_FAILURE = 3221226210, // 0xC00002E2
			STATUS_SAM_INIT_FAILURE = 3221226211, // 0xC00002E3
			STATUS_DS_GC_REQUIRED = 3221226212, // 0xC00002E4
			STATUS_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 3221226213, // 0xC00002E5
			STATUS_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 3221226214, // 0xC00002E6
			STATUS_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 3221226215, // 0xC00002E7
			STATUS_MULTIPLE_FAULT_VIOLATION = 3221226216, // 0xC00002E8
			STATUS_CURRENT_DOMAIN_NOT_ALLOWED = 3221226217, // 0xC00002E9
			STATUS_CANNOT_MAKE = 3221226218, // 0xC00002EA
			STATUS_SYSTEM_SHUTDOWN = 3221226219, // 0xC00002EB
			STATUS_DS_INIT_FAILURE_CONSOLE = 3221226220, // 0xC00002EC
			STATUS_DS_SAM_INIT_FAILURE_CONSOLE = 3221226221, // 0xC00002ED
			STATUS_UNFINISHED_CONTEXT_DELETED = 3221226222, // 0xC00002EE
			STATUS_NO_TGT_REPLY = 3221226223, // 0xC00002EF
			STATUS_OBJECTID_NOT_FOUND = 3221226224, // 0xC00002F0
			STATUS_NO_IP_ADDRESSES = 3221226225, // 0xC00002F1
			STATUS_WRONG_CREDENTIAL_HANDLE = 3221226226, // 0xC00002F2
			STATUS_CRYPTO_SYSTEM_INVALID = 3221226227, // 0xC00002F3
			STATUS_MAX_REFERRALS_EXCEEDED = 3221226228, // 0xC00002F4
			STATUS_MUST_BE_KDC = 3221226229, // 0xC00002F5
			STATUS_STRONG_CRYPTO_NOT_SUPPORTED = 3221226230, // 0xC00002F6
			STATUS_TOO_MANY_PRINCIPALS = 3221226231, // 0xC00002F7
			STATUS_NO_PA_DATA = 3221226232, // 0xC00002F8
			STATUS_PKINIT_NAME_MISMATCH = 3221226233, // 0xC00002F9
			STATUS_SMARTCARD_LOGON_REQUIRED = 3221226234, // 0xC00002FA
			STATUS_KDC_INVALID_REQUEST = 3221226235, // 0xC00002FB
			STATUS_KDC_UNABLE_TO_REFER = 3221226236, // 0xC00002FC
			STATUS_KDC_UNKNOWN_ETYPE = 3221226237, // 0xC00002FD
			STATUS_SHUTDOWN_IN_PROGRESS = 3221226238, // 0xC00002FE
			STATUS_SERVER_SHUTDOWN_IN_PROGRESS = 3221226239, // 0xC00002FF
			STATUS_NOT_SUPPORTED_ON_SBS = 3221226240, // 0xC0000300
			STATUS_WMI_GUID_DISCONNECTED = 3221226241, // 0xC0000301
			STATUS_WMI_ALREADY_DISABLED = 3221226242, // 0xC0000302
			STATUS_WMI_ALREADY_ENABLED = 3221226243, // 0xC0000303
			STATUS_MFT_TOO_FRAGMENTED = 3221226244, // 0xC0000304
			STATUS_COPY_PROTECTION_FAILURE = 3221226245, // 0xC0000305
			STATUS_CSS_AUTHENTICATION_FAILURE = 3221226246, // 0xC0000306
			STATUS_CSS_KEY_NOT_PRESENT = 3221226247, // 0xC0000307
			STATUS_CSS_KEY_NOT_ESTABLISHED = 3221226248, // 0xC0000308
			STATUS_CSS_SCRAMBLED_SECTOR = 3221226249, // 0xC0000309
			STATUS_CSS_REGION_MISMATCH = 3221226250, // 0xC000030A
			STATUS_CSS_RESETS_EXHAUSTED = 3221226251, // 0xC000030B
			STATUS_PASSWORD_CHANGE_REQUIRED = 3221226252, // 0xC000030C
			STATUS_PKINIT_FAILURE = 3221226272, // 0xC0000320
			STATUS_SMARTCARD_SUBSYSTEM_FAILURE = 3221226273, // 0xC0000321
			STATUS_NO_KERB_KEY = 3221226274, // 0xC0000322
			STATUS_HOST_DOWN = 3221226320, // 0xC0000350
			STATUS_UNSUPPORTED_PREAUTH = 3221226321, // 0xC0000351
			STATUS_EFS_ALG_BLOB_TOO_BIG = 3221226322, // 0xC0000352
			STATUS_PORT_NOT_SET = 3221226323, // 0xC0000353
			STATUS_DEBUGGER_INACTIVE = 3221226324, // 0xC0000354
			STATUS_DS_VERSION_CHECK_FAILURE = 3221226325, // 0xC0000355
			STATUS_AUDITING_DISABLED = 3221226326, // 0xC0000356
			STATUS_PRENT4_MACHINE_ACCOUNT = 3221226327, // 0xC0000357
			STATUS_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 3221226328, // 0xC0000358
			STATUS_INVALID_IMAGE_WIN_32 = 3221226329, // 0xC0000359
			STATUS_INVALID_IMAGE_WIN_64 = 3221226330, // 0xC000035A
			STATUS_BAD_BINDINGS = 3221226331, // 0xC000035B
			STATUS_NETWORK_SESSION_EXPIRED = 3221226332, // 0xC000035C
			STATUS_APPHELP_BLOCK = 3221226333, // 0xC000035D
			STATUS_ALL_SIDS_FILTERED = 3221226334, // 0xC000035E
			STATUS_NOT_SAFE_MODE_DRIVER = 3221226335, // 0xC000035F
			STATUS_ACCESS_DISABLED_BY_POLICY_DEFAULT = 3221226337, // 0xC0000361
			STATUS_ACCESS_DISABLED_BY_POLICY_PATH = 3221226338, // 0xC0000362
			STATUS_ACCESS_DISABLED_BY_POLICY_PUBLISHER = 3221226339, // 0xC0000363
			STATUS_ACCESS_DISABLED_BY_POLICY_OTHER = 3221226340, // 0xC0000364
			STATUS_FAILED_DRIVER_ENTRY = 3221226341, // 0xC0000365
			STATUS_DEVICE_ENUMERATION_ERROR = 3221226342, // 0xC0000366
			STATUS_MOUNT_POINT_NOT_RESOLVED = 3221226344, // 0xC0000368
			STATUS_INVALID_DEVICE_OBJECT_PARAMETER = 3221226345, // 0xC0000369
			STATUS_MCA_OCCURED = 3221226346, // 0xC000036A
			STATUS_DRIVER_BLOCKED_CRITICAL = 3221226347, // 0xC000036B
			STATUS_DRIVER_BLOCKED = 3221226348, // 0xC000036C
			STATUS_DRIVER_DATABASE_ERROR = 3221226349, // 0xC000036D
			STATUS_SYSTEM_HIVE_TOO_LARGE = 3221226350, // 0xC000036E
			STATUS_INVALID_IMPORT_OF_NON_DLL = 3221226351, // 0xC000036F
			STATUS_NO_SECRETS = 3221226353, // 0xC0000371
			STATUS_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = 3221226354, // 0xC0000372
			STATUS_FAILED_STACK_SWITCH = 3221226355, // 0xC0000373
			STATUS_HEAP_CORRUPTION = 3221226356, // 0xC0000374
			STATUS_SMARTCARD_WRONG_PIN = 3221226368, // 0xC0000380
			STATUS_SMARTCARD_CARD_BLOCKED = 3221226369, // 0xC0000381
			STATUS_SMARTCARD_CARD_NOT_AUTHENTICATED = 3221226370, // 0xC0000382
			STATUS_SMARTCARD_NO_CARD = 3221226371, // 0xC0000383
			STATUS_SMARTCARD_NO_KEY_CONTAINER = 3221226372, // 0xC0000384
			STATUS_SMARTCARD_NO_CERTIFICATE = 3221226373, // 0xC0000385
			STATUS_SMARTCARD_NO_KEYSET = 3221226374, // 0xC0000386
			STATUS_SMARTCARD_IO_ERROR = 3221226375, // 0xC0000387
			STATUS_DOWNGRADE_DETECTED = 3221226376, // 0xC0000388
			STATUS_SMARTCARD_CERT_REVOKED = 3221226377, // 0xC0000389
			STATUS_ISSUING_CA_UNTRUSTED = 3221226378, // 0xC000038A
			STATUS_REVOCATION_OFFLINE_C = 3221226379, // 0xC000038B
			STATUS_PKINIT_CLIENT_FAILURE = 3221226380, // 0xC000038C
			STATUS_SMARTCARD_CERT_EXPIRED = 3221226381, // 0xC000038D
			STATUS_DRIVER_FAILED_PRIOR_UNLOAD = 3221226382, // 0xC000038E
			STATUS_SMARTCARD_SILENT_CONTEXT = 3221226383, // 0xC000038F
			STATUS_PER_USER_TRUST_QUOTA_EXCEEDED = 3221226497, // 0xC0000401
			STATUS_ALL_USER_TRUST_QUOTA_EXCEEDED = 3221226498, // 0xC0000402
			STATUS_USER_DELETE_TRUST_QUOTA_EXCEEDED = 3221226499, // 0xC0000403
			STATUS_DS_NAME_NOT_UNIQUE = 3221226500, // 0xC0000404
			STATUS_DS_DUPLICATE_ID_FOUND = 3221226501, // 0xC0000405
			STATUS_DS_GROUP_CONVERSION_ERROR = 3221226502, // 0xC0000406
			STATUS_VOLSNAP_PREPARE_HIBERNATE = 3221226503, // 0xC0000407
			STATUS_USER2USER_REQUIRED = 3221226504, // 0xC0000408
			STATUS_STACK_BUFFER_OVERRUN = 3221226505, // 0xC0000409
			STATUS_NO_S4U_PROT_SUPPORT = 3221226506, // 0xC000040A
			STATUS_CROSSREALM_DELEGATION_FAILURE = 3221226507, // 0xC000040B
			STATUS_REVOCATION_OFFLINE_KDC = 3221226508, // 0xC000040C
			STATUS_ISSUING_CA_UNTRUSTED_KDC = 3221226509, // 0xC000040D
			STATUS_KDC_CERT_EXPIRED = 3221226510, // 0xC000040E
			STATUS_KDC_CERT_REVOKED = 3221226511, // 0xC000040F
			STATUS_PARAMETER_QUOTA_EXCEEDED = 3221226512, // 0xC0000410
			STATUS_HIBERNATION_FAILURE = 3221226513, // 0xC0000411
			STATUS_DELAY_LOAD_FAILED = 3221226514, // 0xC0000412
			STATUS_AUTHENTICATION_FIREWALL_FAILED = 3221226515, // 0xC0000413
			STATUS_VDM_DISALLOWED = 3221226516, // 0xC0000414
			STATUS_HUNG_DISPLAY_DRIVER_THREAD = 3221226517, // 0xC0000415
			STATUS_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = 3221226518, // 0xC0000416
			STATUS_INVALID_CRUNTIME_PARAMETER = 3221226519, // 0xC0000417
			STATUS_NTLM_BLOCKED = 3221226520, // 0xC0000418
			STATUS_DS_SRC_SID_EXISTS_IN_FOREST = 3221226521, // 0xC0000419
			STATUS_DS_DOMAIN_NAME_EXISTS_IN_FOREST = 3221226522, // 0xC000041A
			STATUS_DS_FLAT_NAME_EXISTS_IN_FOREST = 3221226523, // 0xC000041B
			STATUS_INVALID_USER_PRINCIPAL_NAME = 3221226524, // 0xC000041C
			STATUS_FATAL_USER_CALLBACK_EXCEPTION = 3221226525, // 0xC000041D
			STATUS_ASSERTION_FAILURE = 3221226528, // 0xC0000420
			STATUS_VERIFIER_STOP = 3221226529, // 0xC0000421
			STATUS_CALLBACK_POP_STACK = 3221226531, // 0xC0000423
			STATUS_INCOMPATIBLE_DRIVER_BLOCKED = 3221226532, // 0xC0000424
			STATUS_HIVE_UNLOADED = 3221226533, // 0xC0000425
			STATUS_COMPRESSION_DISABLED = 3221226534, // 0xC0000426
			STATUS_FILE_SYSTEM_LIMITATION = 3221226535, // 0xC0000427
			STATUS_INVALID_IMAGE_HASH = 3221226536, // 0xC0000428
			STATUS_NOT_CAPABLE = 3221226537, // 0xC0000429
			STATUS_REQUEST_OUT_OF_SEQUENCE = 3221226538, // 0xC000042A
			STATUS_IMPLEMENTATION_LIMIT = 3221226539, // 0xC000042B
			STATUS_ELEVATION_REQUIRED = 3221226540, // 0xC000042C
			STATUS_NO_SECURITY_CONTEXT = 3221226541, // 0xC000042D
			STATUS_PKU2U_CERT_FAILURE = 3221226543, // 0xC000042F
			STATUS_BEYOND_VDL = 3221226546, // 0xC0000432
			STATUS_ENCOUNTERED_WRITE_IN_PROGRESS = 3221226547, // 0xC0000433
			STATUS_PTE_CHANGED = 3221226548, // 0xC0000434
			STATUS_PURGE_FAILED = 3221226549, // 0xC0000435
			STATUS_CRED_REQUIRES_CONFIRMATION = 3221226560, // 0xC0000440
			STATUS_CS_ENCRYPTION_INVALID_SERVER_RESPONSE = 3221226561, // 0xC0000441
			STATUS_CS_ENCRYPTION_UNSUPPORTED_SERVER = 3221226562, // 0xC0000442
			STATUS_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE = 3221226563, // 0xC0000443
			STATUS_CS_ENCRYPTION_NEW_ENCRYPTED_FILE = 3221226564, // 0xC0000444
			STATUS_CS_ENCRYPTION_FILE_NOT_CSE = 3221226565, // 0xC0000445
			STATUS_INVALID_LABEL = 3221226566, // 0xC0000446
			STATUS_DRIVER_PROCESS_TERMINATED = 3221226576, // 0xC0000450
			STATUS_AMBIGUOUS_SYSTEM_DEVICE = 3221226577, // 0xC0000451
			STATUS_SYSTEM_DEVICE_NOT_FOUND = 3221226578, // 0xC0000452
			STATUS_RESTART_BOOT_APPLICATION = 3221226579, // 0xC0000453
			STATUS_INSUFFICIENT_NVRAM_RESOURCES = 3221226580, // 0xC0000454
			STATUS_INVALID_SESSION = 3221226581, // 0xC0000455
			STATUS_THREAD_ALREADY_IN_SESSION = 3221226582, // 0xC0000456
			STATUS_THREAD_NOT_IN_SESSION = 3221226583, // 0xC0000457
			STATUS_INVALID_WEIGHT = 3221226584, // 0xC0000458
			STATUS_REQUEST_PAUSED = 3221226585, // 0xC0000459
			STATUS_NO_RANGES_PROCESSED = 3221226592, // 0xC0000460
			STATUS_DISK_RESOURCES_EXHAUSTED = 3221226593, // 0xC0000461
			STATUS_NEEDS_REMEDIATION = 3221226594, // 0xC0000462
			STATUS_DEVICE_FEATURE_NOT_SUPPORTED = 3221226595, // 0xC0000463
			STATUS_DEVICE_UNREACHABLE = 3221226596, // 0xC0000464
			STATUS_INVALID_TOKEN = 3221226597, // 0xC0000465
			STATUS_SERVER_UNAVAILABLE = 3221226598, // 0xC0000466
			STATUS_FILE_NOT_AVAILABLE = 3221226599, // 0xC0000467
			STATUS_DEVICE_INSUFFICIENT_RESOURCES = 3221226600, // 0xC0000468
			STATUS_PACKAGE_UPDATING = 3221226601, // 0xC0000469
			STATUS_NOT_READ_FROM_COPY = 3221226602, // 0xC000046A
			STATUS_FT_WRITE_FAILURE = 3221226603, // 0xC000046B
			STATUS_FT_DI_SCAN_REQUIRED = 3221226604, // 0xC000046C
			STATUS_OBJECT_NOT_EXTERNALLY_BACKED = 3221226605, // 0xC000046D
			STATUS_EXTERNAL_BACKING_PROVIDER_UNKNOWN = 3221226606, // 0xC000046E
			STATUS_DATA_CHECKSUM_ERROR = 3221226608, // 0xC0000470
			STATUS_INTERMIXED_KERNEL_EA_OPERATION = 3221226609, // 0xC0000471
			STATUS_TRIM_READ_ZERO_NOT_SUPPORTED = 3221226610, // 0xC0000472
			STATUS_TOO_MANY_SEGMENT_DESCRIPTORS = 3221226611, // 0xC0000473
			STATUS_INVALID_OFFSET_ALIGNMENT = 3221226612, // 0xC0000474
			STATUS_INVALID_FIELD_IN_PARAMETER_LIST = 3221226613, // 0xC0000475
			STATUS_OPERATION_IN_PROGRESS = 3221226614, // 0xC0000476
			STATUS_INVALID_INITIATOR_TARGET_PATH = 3221226615, // 0xC0000477
			STATUS_SCRUB_DATA_DISABLED = 3221226616, // 0xC0000478
			STATUS_NOT_REDUNDANT_STORAGE = 3221226617, // 0xC0000479
			STATUS_RESIDENT_FILE_NOT_SUPPORTED = 3221226618, // 0xC000047A
			STATUS_COMPRESSED_FILE_NOT_SUPPORTED = 3221226619, // 0xC000047B
			STATUS_DIRECTORY_NOT_SUPPORTED = 3221226620, // 0xC000047C
			STATUS_IO_OPERATION_TIMEOUT = 3221226621, // 0xC000047D
			STATUS_SYSTEM_NEEDS_REMEDIATION = 3221226622, // 0xC000047E
			STATUS_APPX_INTEGRITY_FAILURE_CLR_NGEN = 3221226623, // 0xC000047F
			STATUS_SHARE_UNAVAILABLE = 3221226624, // 0xC0000480
			STATUS_APISET_NOT_HOSTED = 3221226625, // 0xC0000481
			STATUS_APISET_NOT_PRESENT = 3221226626, // 0xC0000482
			STATUS_DEVICE_HARDWARE_ERROR = 3221226627, // 0xC0000483
			STATUS_INVALID_TASK_NAME = 3221226752, // 0xC0000500
			STATUS_INVALID_TASK_INDEX = 3221226753, // 0xC0000501
			STATUS_THREAD_ALREADY_IN_TASK = 3221226754, // 0xC0000502
			STATUS_CALLBACK_BYPASS = 3221226755, // 0xC0000503
			STATUS_UNDEFINED_SCOPE = 3221226756, // 0xC0000504
			STATUS_INVALID_CAP = 3221226757, // 0xC0000505
			STATUS_NOT_GUI_PROCESS = 3221226758, // 0xC0000506
			STATUS_FAIL_FAST_EXCEPTION = 3221227010, // 0xC0000602
			STATUS_IMAGE_CERT_REVOKED = 3221227011, // 0xC0000603
			STATUS_DYNAMIC_CODE_BLOCKED = 3221227012, // 0xC0000604
			STATUS_PORT_CLOSED = 3221227264, // 0xC0000700
			STATUS_MESSAGE_LOST = 3221227265, // 0xC0000701
			STATUS_INVALID_MESSAGE = 3221227266, // 0xC0000702
			STATUS_REQUEST_CANCELED = 3221227267, // 0xC0000703
			STATUS_RECURSIVE_DISPATCH = 3221227268, // 0xC0000704
			STATUS_LPC_RECEIVE_BUFFER_EXPECTED = 3221227269, // 0xC0000705
			STATUS_LPC_INVALID_CONNECTION_USAGE = 3221227270, // 0xC0000706
			STATUS_LPC_REQUESTS_NOT_ALLOWED = 3221227271, // 0xC0000707
			STATUS_RESOURCE_IN_USE = 3221227272, // 0xC0000708
			STATUS_HARDWARE_MEMORY_ERROR = 3221227273, // 0xC0000709
			STATUS_THREADPOOL_HANDLE_EXCEPTION = 3221227274, // 0xC000070A
			STATUS_THREADPOOL_SET_EVENT_ON_COMPLETION_FAILED = 3221227275, // 0xC000070B
			STATUS_THREADPOOL_RELEASE_SEMAPHORE_ON_COMPLETION_FAILED = 3221227276, // 0xC000070C
			STATUS_THREADPOOL_RELEASE_MUTEX_ON_COMPLETION_FAILED = 3221227277, // 0xC000070D
			STATUS_THREADPOOL_FREE_LIBRARY_ON_COMPLETION_FAILED = 3221227278, // 0xC000070E
			STATUS_THREADPOOL_RELEASED_DURING_OPERATION = 3221227279, // 0xC000070F
			STATUS_CALLBACK_RETURNED_WHILE_IMPERSONATING = 3221227280, // 0xC0000710
			STATUS_APC_RETURNED_WHILE_IMPERSONATING = 3221227281, // 0xC0000711
			STATUS_PROCESS_IS_PROTECTED = 3221227282, // 0xC0000712
			STATUS_MCA_EXCEPTION = 3221227283, // 0xC0000713
			STATUS_CERTIFICATE_MAPPING_NOT_UNIQUE = 3221227284, // 0xC0000714
			STATUS_SYMLINK_CLASS_DISABLED = 3221227285, // 0xC0000715
			STATUS_INVALID_IDN_NORMALIZATION = 3221227286, // 0xC0000716
			STATUS_NO_UNICODE_TRANSLATION = 3221227287, // 0xC0000717
			STATUS_ALREADY_REGISTERED = 3221227288, // 0xC0000718
			STATUS_CONTEXT_MISMATCH = 3221227289, // 0xC0000719
			STATUS_PORT_ALREADY_HAS_COMPLETION_LIST = 3221227290, // 0xC000071A
			STATUS_CALLBACK_RETURNED_THREAD_PRIORITY = 3221227291, // 0xC000071B
			STATUS_INVALID_THREAD = 3221227292, // 0xC000071C
			STATUS_CALLBACK_RETURNED_TRANSACTION = 3221227293, // 0xC000071D
			STATUS_CALLBACK_RETURNED_LDR_LOCK = 3221227294, // 0xC000071E
			STATUS_CALLBACK_RETURNED_LANG = 3221227295, // 0xC000071F
			STATUS_CALLBACK_RETURNED_PRI_BACK = 3221227296, // 0xC0000720
			STATUS_CALLBACK_RETURNED_THREAD_AFFINITY = 3221227297, // 0xC0000721
			STATUS_DISK_REPAIR_DISABLED = 3221227520, // 0xC0000800
			STATUS_DS_DOMAIN_RENAME_IN_PROGRESS = 3221227521, // 0xC0000801
			STATUS_DISK_QUOTA_EXCEEDED = 3221227522, // 0xC0000802
			STATUS_CONTENT_BLOCKED = 3221227524, // 0xC0000804
			STATUS_BAD_CLUSTERS = 3221227525, // 0xC0000805
			STATUS_VOLUME_DIRTY = 3221227526, // 0xC0000806
			STATUS_DISK_REPAIR_UNSUCCESSFUL = 3221227528, // 0xC0000808
			STATUS_CORRUPT_LOG_OVERFULL = 3221227529, // 0xC0000809
			STATUS_CORRUPT_LOG_CORRUPTED = 3221227530, // 0xC000080A
			STATUS_CORRUPT_LOG_UNAVAILABLE = 3221227531, // 0xC000080B
			STATUS_CORRUPT_LOG_DELETED_FULL = 3221227532, // 0xC000080C
			STATUS_CORRUPT_LOG_CLEARED = 3221227533, // 0xC000080D
			STATUS_ORPHAN_NAME_EXHAUSTED = 3221227534, // 0xC000080E
			STATUS_PROACTIVE_SCAN_IN_PROGRESS = 3221227535, // 0xC000080F
			STATUS_ENCRYPTED_IO_NOT_POSSIBLE = 3221227536, // 0xC0000810
			STATUS_CORRUPT_LOG_UPLEVEL_RECORDS = 3221227537, // 0xC0000811
			STATUS_FILE_CHECKED_OUT = 3221227777, // 0xC0000901
			STATUS_CHECKOUT_REQUIRED = 3221227778, // 0xC0000902
			STATUS_BAD_FILE_TYPE = 3221227779, // 0xC0000903
			STATUS_FILE_TOO_LARGE = 3221227780, // 0xC0000904
			STATUS_FORMS_AUTH_REQUIRED = 3221227781, // 0xC0000905
			STATUS_VIRUS_INFECTED = 3221227782, // 0xC0000906
			STATUS_VIRUS_DELETED = 3221227783, // 0xC0000907
			STATUS_BAD_MCFG_TABLE = 3221227784, // 0xC0000908
			STATUS_CANNOT_BREAK_OPLOCK = 3221227785, // 0xC0000909
			STATUS_BAD_KEY = 3221227786, // 0xC000090A
			STATUS_BAD_DATA = 3221227787, // 0xC000090B
			STATUS_NO_KEY = 3221227788, // 0xC000090C
			STATUS_FILE_HANDLE_REVOKED = 3221227792, // 0xC0000910
			STATUS_WOW_ASSERTION = 3221264536, // 0xC0009898
			STATUS_INVALID_SIGNATURE = 3221266432, // 0xC000A000
			STATUS_HMAC_NOT_SUPPORTED = 3221266433, // 0xC000A001
			STATUS_AUTH_TAG_MISMATCH = 3221266434, // 0xC000A002
			STATUS_INVALID_STATE_TRANSITION = 3221266435, // 0xC000A003
			STATUS_INVALID_KERNEL_INFO_VERSION = 3221266436, // 0xC000A004
			STATUS_INVALID_PEP_INFO_VERSION = 3221266437, // 0xC000A005
			STATUS_IPSEC_QUEUE_OVERFLOW = 3221266448, // 0xC000A010
			STATUS_ND_QUEUE_OVERFLOW = 3221266449, // 0xC000A011
			STATUS_HOPLIMIT_EXCEEDED = 3221266450, // 0xC000A012
			STATUS_PROTOCOL_NOT_SUPPORTED = 3221266451, // 0xC000A013
			STATUS_FASTPATH_REJECTED = 3221266452, // 0xC000A014
			STATUS_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = 3221266560, // 0xC000A080
			STATUS_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = 3221266561, // 0xC000A081
			STATUS_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = 3221266562, // 0xC000A082
			STATUS_XML_PARSE_ERROR = 3221266563, // 0xC000A083
			STATUS_XMLDSIG_ERROR = 3221266564, // 0xC000A084
			STATUS_WRONG_COMPARTMENT = 3221266565, // 0xC000A085
			STATUS_AUTHIP_FAILURE = 3221266566, // 0xC000A086
			STATUS_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS = 3221266567, // 0xC000A087
			STATUS_DS_OID_NOT_FOUND = 3221266568, // 0xC000A088
			STATUS_INCORRECT_ACCOUNT_TYPE = 3221266569, // 0xC000A089
			STATUS_HASH_NOT_SUPPORTED = 3221266688, // 0xC000A100
			STATUS_HASH_NOT_PRESENT = 3221266689, // 0xC000A101
			STATUS_SECONDARY_IC_PROVIDER_NOT_REGISTERED = 3221266721, // 0xC000A121
			STATUS_GPIO_CLIENT_INFORMATION_INVALID = 3221266722, // 0xC000A122
			STATUS_GPIO_VERSION_NOT_SUPPORTED = 3221266723, // 0xC000A123
			STATUS_GPIO_INVALID_REGISTRATION_PACKET = 3221266724, // 0xC000A124
			STATUS_GPIO_OPERATION_DENIED = 3221266725, // 0xC000A125
			STATUS_GPIO_INCOMPATIBLE_CONNECT_MODE = 3221266726, // 0xC000A126
			STATUS_CANNOT_SWITCH_RUNLEVEL = 3221266753, // 0xC000A141
			STATUS_INVALID_RUNLEVEL_SETTING = 3221266754, // 0xC000A142
			STATUS_RUNLEVEL_SWITCH_TIMEOUT = 3221266755, // 0xC000A143
			STATUS_RUNLEVEL_SWITCH_AGENT_TIMEOUT = 3221266757, // 0xC000A145
			STATUS_RUNLEVEL_SWITCH_IN_PROGRESS = 3221266758, // 0xC000A146
			STATUS_NOT_APPCONTAINER = 3221266944, // 0xC000A200
			STATUS_NOT_SUPPORTED_IN_APPCONTAINER = 3221266945, // 0xC000A201
			STATUS_INVALID_PACKAGE_SID_LENGTH = 3221266946, // 0xC000A202
			STATUS_APP_DATA_NOT_FOUND = 3221267073, // 0xC000A281
			STATUS_APP_DATA_EXPIRED = 3221267074, // 0xC000A282
			STATUS_APP_DATA_CORRUPT = 3221267075, // 0xC000A283
			STATUS_APP_DATA_LIMIT_EXCEEDED = 3221267076, // 0xC000A284
			STATUS_APP_DATA_REBOOT_REQUIRED = 3221267077, // 0xC000A285
			STATUS_OFFLOAD_READ_FLT_NOT_SUPPORTED = 3221267105, // 0xC000A2A1
			STATUS_OFFLOAD_WRITE_FLT_NOT_SUPPORTED = 3221267106, // 0xC000A2A2
			STATUS_OFFLOAD_READ_FILE_NOT_SUPPORTED = 3221267107, // 0xC000A2A3
			STATUS_OFFLOAD_WRITE_FILE_NOT_SUPPORTED = 3221267108, // 0xC000A2A4
			DBG_NO_STATE_CHANGE = 3221291009, // 0xC0010001
			DBG_APP_NOT_IDLE = 3221291010, // 0xC0010002
			RPC_NT_INVALID_STRING_BINDING = 3221356545, // 0xC0020001
			RPC_NT_WRONG_KIND_OF_BINDING = 3221356546, // 0xC0020002
			RPC_NT_INVALID_BINDING = 3221356547, // 0xC0020003
			RPC_NT_PROTSEQ_NOT_SUPPORTED = 3221356548, // 0xC0020004
			RPC_NT_INVALID_RPC_PROTSEQ = 3221356549, // 0xC0020005
			RPC_NT_INVALID_STRING_UUID = 3221356550, // 0xC0020006
			RPC_NT_INVALID_ENDPOINT_FORMAT = 3221356551, // 0xC0020007
			RPC_NT_INVALID_NET_ADDR = 3221356552, // 0xC0020008
			RPC_NT_NO_ENDPOINT_FOUND = 3221356553, // 0xC0020009
			RPC_NT_INVALID_TIMEOUT = 3221356554, // 0xC002000A
			RPC_NT_OBJECT_NOT_FOUND = 3221356555, // 0xC002000B
			RPC_NT_ALREADY_REGISTERED = 3221356556, // 0xC002000C
			RPC_NT_TYPE_ALREADY_REGISTERED = 3221356557, // 0xC002000D
			RPC_NT_ALREADY_LISTENING = 3221356558, // 0xC002000E
			RPC_NT_NO_PROTSEQS_REGISTERED = 3221356559, // 0xC002000F
			RPC_NT_NOT_LISTENING = 3221356560, // 0xC0020010
			RPC_NT_UNKNOWN_MGR_TYPE = 3221356561, // 0xC0020011
			RPC_NT_UNKNOWN_IF = 3221356562, // 0xC0020012
			RPC_NT_NO_BINDINGS = 3221356563, // 0xC0020013
			RPC_NT_NO_PROTSEQS = 3221356564, // 0xC0020014
			RPC_NT_CANT_CREATE_ENDPOINT = 3221356565, // 0xC0020015
			RPC_NT_OUT_OF_RESOURCES = 3221356566, // 0xC0020016
			RPC_NT_SERVER_UNAVAILABLE = 3221356567, // 0xC0020017
			RPC_NT_SERVER_TOO_BUSY = 3221356568, // 0xC0020018
			RPC_NT_INVALID_NETWORK_OPTIONS = 3221356569, // 0xC0020019
			RPC_NT_NO_CALL_ACTIVE = 3221356570, // 0xC002001A
			RPC_NT_CALL_FAILED = 3221356571, // 0xC002001B
			RPC_NT_CALL_FAILED_DNE = 3221356572, // 0xC002001C
			RPC_NT_PROTOCOL_ERROR = 3221356573, // 0xC002001D
			RPC_NT_UNSUPPORTED_TRANS_SYN = 3221356575, // 0xC002001F
			RPC_NT_UNSUPPORTED_TYPE = 3221356577, // 0xC0020021
			RPC_NT_INVALID_TAG = 3221356578, // 0xC0020022
			RPC_NT_INVALID_BOUND = 3221356579, // 0xC0020023
			RPC_NT_NO_ENTRY_NAME = 3221356580, // 0xC0020024
			RPC_NT_INVALID_NAME_SYNTAX = 3221356581, // 0xC0020025
			RPC_NT_UNSUPPORTED_NAME_SYNTAX = 3221356582, // 0xC0020026
			RPC_NT_UUID_NO_ADDRESS = 3221356584, // 0xC0020028
			RPC_NT_DUPLICATE_ENDPOINT = 3221356585, // 0xC0020029
			RPC_NT_UNKNOWN_AUTHN_TYPE = 3221356586, // 0xC002002A
			RPC_NT_MAX_CALLS_TOO_SMALL = 3221356587, // 0xC002002B
			RPC_NT_STRING_TOO_LONG = 3221356588, // 0xC002002C
			RPC_NT_PROTSEQ_NOT_FOUND = 3221356589, // 0xC002002D
			RPC_NT_PROCNUM_OUT_OF_RANGE = 3221356590, // 0xC002002E
			RPC_NT_BINDING_HAS_NO_AUTH = 3221356591, // 0xC002002F
			RPC_NT_UNKNOWN_AUTHN_SERVICE = 3221356592, // 0xC0020030
			RPC_NT_UNKNOWN_AUTHN_LEVEL = 3221356593, // 0xC0020031
			RPC_NT_INVALID_AUTH_IDENTITY = 3221356594, // 0xC0020032
			RPC_NT_UNKNOWN_AUTHZ_SERVICE = 3221356595, // 0xC0020033
			EPT_NT_INVALID_ENTRY = 3221356596, // 0xC0020034
			EPT_NT_CANT_PERFORM_OP = 3221356597, // 0xC0020035
			EPT_NT_NOT_REGISTERED = 3221356598, // 0xC0020036
			RPC_NT_NOTHING_TO_EXPORT = 3221356599, // 0xC0020037
			RPC_NT_INCOMPLETE_NAME = 3221356600, // 0xC0020038
			RPC_NT_INVALID_VERS_OPTION = 3221356601, // 0xC0020039
			RPC_NT_NO_MORE_MEMBERS = 3221356602, // 0xC002003A
			RPC_NT_NOT_ALL_OBJS_UNEXPORTED = 3221356603, // 0xC002003B
			RPC_NT_INTERFACE_NOT_FOUND = 3221356604, // 0xC002003C
			RPC_NT_ENTRY_ALREADY_EXISTS = 3221356605, // 0xC002003D
			RPC_NT_ENTRY_NOT_FOUND = 3221356606, // 0xC002003E
			RPC_NT_NAME_SERVICE_UNAVAILABLE = 3221356607, // 0xC002003F
			RPC_NT_INVALID_NAF_ID = 3221356608, // 0xC0020040
			RPC_NT_CANNOT_SUPPORT = 3221356609, // 0xC0020041
			RPC_NT_NO_CONTEXT_AVAILABLE = 3221356610, // 0xC0020042
			RPC_NT_INTERNAL_ERROR = 3221356611, // 0xC0020043
			RPC_NT_ZERO_DIVIDE = 3221356612, // 0xC0020044
			RPC_NT_ADDRESS_ERROR = 3221356613, // 0xC0020045
			RPC_NT_FP_DIV_ZERO = 3221356614, // 0xC0020046
			RPC_NT_FP_UNDERFLOW = 3221356615, // 0xC0020047
			RPC_NT_FP_OVERFLOW = 3221356616, // 0xC0020048
			RPC_NT_CALL_IN_PROGRESS = 3221356617, // 0xC0020049
			RPC_NT_NO_MORE_BINDINGS = 3221356618, // 0xC002004A
			RPC_NT_GROUP_MEMBER_NOT_FOUND = 3221356619, // 0xC002004B
			EPT_NT_CANT_CREATE = 3221356620, // 0xC002004C
			RPC_NT_INVALID_OBJECT = 3221356621, // 0xC002004D
			RPC_NT_NO_INTERFACES = 3221356623, // 0xC002004F
			RPC_NT_CALL_CANCELLED = 3221356624, // 0xC0020050
			RPC_NT_BINDING_INCOMPLETE = 3221356625, // 0xC0020051
			RPC_NT_COMM_FAILURE = 3221356626, // 0xC0020052
			RPC_NT_UNSUPPORTED_AUTHN_LEVEL = 3221356627, // 0xC0020053
			RPC_NT_NO_PRINC_NAME = 3221356628, // 0xC0020054
			RPC_NT_NOT_RPC_ERROR = 3221356629, // 0xC0020055
			RPC_NT_SEC_PKG_ERROR = 3221356631, // 0xC0020057
			RPC_NT_NOT_CANCELLED = 3221356632, // 0xC0020058
			RPC_NT_INVALID_ASYNC_HANDLE = 3221356642, // 0xC0020062
			RPC_NT_INVALID_ASYNC_CALL = 3221356643, // 0xC0020063
			RPC_NT_PROXY_ACCESS_DENIED = 3221356644, // 0xC0020064
			RPC_NT_COOKIE_AUTH_FAILED = 3221356645, // 0xC0020065
			RPC_NT_NO_MORE_ENTRIES = 3221422081, // 0xC0030001
			RPC_NT_SS_CHAR_TRANS_OPEN_FAIL = 3221422082, // 0xC0030002
			RPC_NT_SS_CHAR_TRANS_SHORT_FILE = 3221422083, // 0xC0030003
			RPC_NT_SS_IN_NULL_CONTEXT = 3221422084, // 0xC0030004
			RPC_NT_SS_CONTEXT_MISMATCH = 3221422085, // 0xC0030005
			RPC_NT_SS_CONTEXT_DAMAGED = 3221422086, // 0xC0030006
			RPC_NT_SS_HANDLES_MISMATCH = 3221422087, // 0xC0030007
			RPC_NT_SS_CANNOT_GET_CALL_HANDLE = 3221422088, // 0xC0030008
			RPC_NT_NULL_REF_POINTER = 3221422089, // 0xC0030009
			RPC_NT_ENUM_VALUE_OUT_OF_RANGE = 3221422090, // 0xC003000A
			RPC_NT_BYTE_COUNT_TOO_SMALL = 3221422091, // 0xC003000B
			RPC_NT_BAD_STUB_DATA = 3221422092, // 0xC003000C
			RPC_NT_INVALID_ES_ACTION = 3221422169, // 0xC0030059
			RPC_NT_WRONG_ES_VERSION = 3221422170, // 0xC003005A
			RPC_NT_WRONG_STUB_VERSION = 3221422171, // 0xC003005B
			RPC_NT_INVALID_PIPE_OBJECT = 3221422172, // 0xC003005C
			RPC_NT_INVALID_PIPE_OPERATION = 3221422173, // 0xC003005D
			RPC_NT_WRONG_PIPE_VERSION = 3221422174, // 0xC003005E
			RPC_NT_PIPE_CLOSED = 3221422175, // 0xC003005F
			RPC_NT_PIPE_DISCIPLINE_ERROR = 3221422176, // 0xC0030060
			RPC_NT_PIPE_EMPTY = 3221422177, // 0xC0030061
			STATUS_PNP_BAD_MPS_TABLE = 3221487669, // 0xC0040035
			STATUS_PNP_TRANSLATION_FAILED = 3221487670, // 0xC0040036
			STATUS_PNP_IRQ_TRANSLATION_FAILED = 3221487671, // 0xC0040037
			STATUS_PNP_INVALID_ID = 3221487672, // 0xC0040038
			STATUS_IO_REISSUE_AS_CACHED = 3221487673, // 0xC0040039
			STATUS_CTX_WINSTATION_NAME_INVALID = 3221880833, // 0xC00A0001
			STATUS_CTX_INVALID_PD = 3221880834, // 0xC00A0002
			STATUS_CTX_PD_NOT_FOUND = 3221880835, // 0xC00A0003
			STATUS_CTX_CLOSE_PENDING = 3221880838, // 0xC00A0006
			STATUS_CTX_NO_OUTBUF = 3221880839, // 0xC00A0007
			STATUS_CTX_MODEM_INF_NOT_FOUND = 3221880840, // 0xC00A0008
			STATUS_CTX_INVALID_MODEMNAME = 3221880841, // 0xC00A0009
			STATUS_CTX_RESPONSE_ERROR = 3221880842, // 0xC00A000A
			STATUS_CTX_MODEM_RESPONSE_TIMEOUT = 3221880843, // 0xC00A000B
			STATUS_CTX_MODEM_RESPONSE_NO_CARRIER = 3221880844, // 0xC00A000C
			STATUS_CTX_MODEM_RESPONSE_NO_DIALTONE = 3221880845, // 0xC00A000D
			STATUS_CTX_MODEM_RESPONSE_BUSY = 3221880846, // 0xC00A000E
			STATUS_CTX_MODEM_RESPONSE_VOICE = 3221880847, // 0xC00A000F
			STATUS_CTX_TD_ERROR = 3221880848, // 0xC00A0010
			STATUS_CTX_LICENSE_CLIENT_INVALID = 3221880850, // 0xC00A0012
			STATUS_CTX_LICENSE_NOT_AVAILABLE = 3221880851, // 0xC00A0013
			STATUS_CTX_LICENSE_EXPIRED = 3221880852, // 0xC00A0014
			STATUS_CTX_WINSTATION_NOT_FOUND = 3221880853, // 0xC00A0015
			STATUS_CTX_WINSTATION_NAME_COLLISION = 3221880854, // 0xC00A0016
			STATUS_CTX_WINSTATION_BUSY = 3221880855, // 0xC00A0017
			STATUS_CTX_BAD_VIDEO_MODE = 3221880856, // 0xC00A0018
			STATUS_CTX_GRAPHICS_INVALID = 3221880866, // 0xC00A0022
			STATUS_CTX_NOT_CONSOLE = 3221880868, // 0xC00A0024
			STATUS_CTX_CLIENT_QUERY_TIMEOUT = 3221880870, // 0xC00A0026
			STATUS_CTX_CONSOLE_DISCONNECT = 3221880871, // 0xC00A0027
			STATUS_CTX_CONSOLE_CONNECT = 3221880872, // 0xC00A0028
			STATUS_CTX_SHADOW_DENIED = 3221880874, // 0xC00A002A
			STATUS_CTX_WINSTATION_ACCESS_DENIED = 3221880875, // 0xC00A002B
			STATUS_CTX_INVALID_WD = 3221880878, // 0xC00A002E
			STATUS_CTX_WD_NOT_FOUND = 3221880879, // 0xC00A002F
			STATUS_CTX_SHADOW_INVALID = 3221880880, // 0xC00A0030
			STATUS_CTX_SHADOW_DISABLED = 3221880881, // 0xC00A0031
			STATUS_RDP_PROTOCOL_ERROR = 3221880882, // 0xC00A0032
			STATUS_CTX_CLIENT_LICENSE_NOT_SET = 3221880883, // 0xC00A0033
			STATUS_CTX_CLIENT_LICENSE_IN_USE = 3221880884, // 0xC00A0034
			STATUS_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 3221880885, // 0xC00A0035
			STATUS_CTX_SHADOW_NOT_RUNNING = 3221880886, // 0xC00A0036
			STATUS_CTX_LOGON_DISABLED = 3221880887, // 0xC00A0037
			STATUS_CTX_SECURITY_LAYER_ERROR = 3221880888, // 0xC00A0038
			STATUS_TS_INCOMPATIBLE_SESSIONS = 3221880889, // 0xC00A0039
			STATUS_TS_VIDEO_SUBSYSTEM_ERROR = 3221880890, // 0xC00A003A
			STATUS_MUI_FILE_NOT_FOUND = 3221946369, // 0xC00B0001
			STATUS_MUI_INVALID_FILE = 3221946370, // 0xC00B0002
			STATUS_MUI_INVALID_RC_CONFIG = 3221946371, // 0xC00B0003
			STATUS_MUI_INVALID_LOCALE_NAME = 3221946372, // 0xC00B0004
			STATUS_MUI_INVALID_ULTIMATEFALLBACK_NAME = 3221946373, // 0xC00B0005
			STATUS_MUI_FILE_NOT_LOADED = 3221946374, // 0xC00B0006
			STATUS_RESOURCE_ENUM_USER_STOP = 3221946375, // 0xC00B0007
			HIDP_STATUS_INVALID_PREPARSED_DATA = 3222339585, // 0xC0110001
			HIDP_STATUS_INVALID_REPORT_TYPE = 3222339586, // 0xC0110002
			HIDP_STATUS_INVALID_REPORT_LENGTH = 3222339587, // 0xC0110003
			HIDP_STATUS_USAGE_NOT_FOUND = 3222339588, // 0xC0110004
			HIDP_STATUS_VALUE_OUT_OF_RANGE = 3222339589, // 0xC0110005
			HIDP_STATUS_BAD_LOG_PHY_VALUES = 3222339590, // 0xC0110006
			HIDP_STATUS_BUFFER_TOO_SMALL = 3222339591, // 0xC0110007
			HIDP_STATUS_INTERNAL_ERROR = 3222339592, // 0xC0110008
			HIDP_STATUS_I8042_TRANS_UNKNOWN = 3222339593, // 0xC0110009
			HIDP_STATUS_INCOMPATIBLE_REPORT_ID = 3222339594, // 0xC011000A
			HIDP_STATUS_NOT_VALUE_ARRAY = 3222339595, // 0xC011000B
			HIDP_STATUS_IS_VALUE_ARRAY = 3222339596, // 0xC011000C
			HIDP_STATUS_DATA_INDEX_NOT_FOUND = 3222339597, // 0xC011000D
			HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE = 3222339598, // 0xC011000E
			HIDP_STATUS_BUTTON_NOT_PRESSED = 3222339599, // 0xC011000F
			HIDP_STATUS_REPORT_DOES_NOT_EXIST = 3222339600, // 0xC0110010
			HIDP_STATUS_NOT_IMPLEMENTED = 3222339616, // 0xC0110020
			STATUS_CLUSTER_INVALID_NODE = 3222470657, // 0xC0130001
			STATUS_CLUSTER_NODE_EXISTS = 3222470658, // 0xC0130002
			STATUS_CLUSTER_JOIN_IN_PROGRESS = 3222470659, // 0xC0130003
			STATUS_CLUSTER_NODE_NOT_FOUND = 3222470660, // 0xC0130004
			STATUS_CLUSTER_LOCAL_NODE_NOT_FOUND = 3222470661, // 0xC0130005
			STATUS_CLUSTER_NETWORK_EXISTS = 3222470662, // 0xC0130006
			STATUS_CLUSTER_NETWORK_NOT_FOUND = 3222470663, // 0xC0130007
			STATUS_CLUSTER_NETINTERFACE_EXISTS = 3222470664, // 0xC0130008
			STATUS_CLUSTER_NETINTERFACE_NOT_FOUND = 3222470665, // 0xC0130009
			STATUS_CLUSTER_INVALID_REQUEST = 3222470666, // 0xC013000A
			STATUS_CLUSTER_INVALID_NETWORK_PROVIDER = 3222470667, // 0xC013000B
			STATUS_CLUSTER_NODE_DOWN = 3222470668, // 0xC013000C
			STATUS_CLUSTER_NODE_UNREACHABLE = 3222470669, // 0xC013000D
			STATUS_CLUSTER_NODE_NOT_MEMBER = 3222470670, // 0xC013000E
			STATUS_CLUSTER_JOIN_NOT_IN_PROGRESS = 3222470671, // 0xC013000F
			STATUS_CLUSTER_INVALID_NETWORK = 3222470672, // 0xC0130010
			STATUS_CLUSTER_NO_NET_ADAPTERS = 3222470673, // 0xC0130011
			STATUS_CLUSTER_NODE_UP = 3222470674, // 0xC0130012
			STATUS_CLUSTER_NODE_PAUSED = 3222470675, // 0xC0130013
			STATUS_CLUSTER_NODE_NOT_PAUSED = 3222470676, // 0xC0130014
			STATUS_CLUSTER_NO_SECURITY_CONTEXT = 3222470677, // 0xC0130015
			STATUS_CLUSTER_NETWORK_NOT_INTERNAL = 3222470678, // 0xC0130016
			STATUS_CLUSTER_POISONED = 3222470679, // 0xC0130017
			STATUS_CLUSTER_NON_CSV_PATH = 3222470680, // 0xC0130018
			STATUS_CLUSTER_CSV_VOLUME_NOT_LOCAL = 3222470681, // 0xC0130019
			STATUS_CLUSTER_CSV_READ_OPLOCK_BREAK_IN_PROGRESS = 3222470688, // 0xC0130020
			STATUS_CLUSTER_CSV_AUTO_PAUSE_ERROR = 3222470689, // 0xC0130021
			STATUS_CLUSTER_CSV_REDIRECTED = 3222470690, // 0xC0130022
			STATUS_CLUSTER_CSV_NOT_REDIRECTED = 3222470691, // 0xC0130023
			STATUS_CLUSTER_CSV_VOLUME_DRAINING = 3222470692, // 0xC0130024
			STATUS_CLUSTER_CSV_SNAPSHOT_CREATION_IN_PROGRESS = 3222470693, // 0xC0130025
			STATUS_CLUSTER_CSV_VOLUME_DRAINING_SUCCEEDED_DOWNLEVEL = 3222470694, // 0xC0130026
			STATUS_ACPI_INVALID_OPCODE = 3222536193, // 0xC0140001
			STATUS_ACPI_STACK_OVERFLOW = 3222536194, // 0xC0140002
			STATUS_ACPI_ASSERT_FAILED = 3222536195, // 0xC0140003
			STATUS_ACPI_INVALID_INDEX = 3222536196, // 0xC0140004
			STATUS_ACPI_INVALID_ARGUMENT = 3222536197, // 0xC0140005
			STATUS_ACPI_FATAL = 3222536198, // 0xC0140006
			STATUS_ACPI_INVALID_SUPERNAME = 3222536199, // 0xC0140007
			STATUS_ACPI_INVALID_ARGTYPE = 3222536200, // 0xC0140008
			STATUS_ACPI_INVALID_OBJTYPE = 3222536201, // 0xC0140009
			STATUS_ACPI_INVALID_TARGETTYPE = 3222536202, // 0xC014000A
			STATUS_ACPI_INCORRECT_ARGUMENT_COUNT = 3222536203, // 0xC014000B
			STATUS_ACPI_ADDRESS_NOT_MAPPED = 3222536204, // 0xC014000C
			STATUS_ACPI_INVALID_EVENTTYPE = 3222536205, // 0xC014000D
			STATUS_ACPI_HANDLER_COLLISION = 3222536206, // 0xC014000E
			STATUS_ACPI_INVALID_DATA = 3222536207, // 0xC014000F
			STATUS_ACPI_INVALID_REGION = 3222536208, // 0xC0140010
			STATUS_ACPI_INVALID_ACCESS_SIZE = 3222536209, // 0xC0140011
			STATUS_ACPI_ACQUIRE_GLOBAL_LOCK = 3222536210, // 0xC0140012
			STATUS_ACPI_ALREADY_INITIALIZED = 3222536211, // 0xC0140013
			STATUS_ACPI_NOT_INITIALIZED = 3222536212, // 0xC0140014
			STATUS_ACPI_INVALID_MUTEX_LEVEL = 3222536213, // 0xC0140015
			STATUS_ACPI_MUTEX_NOT_OWNED = 3222536214, // 0xC0140016
			STATUS_ACPI_MUTEX_NOT_OWNER = 3222536215, // 0xC0140017
			STATUS_ACPI_RS_ACCESS = 3222536216, // 0xC0140018
			STATUS_ACPI_INVALID_TABLE = 3222536217, // 0xC0140019
			STATUS_ACPI_REG_HANDLER_FAILED = 3222536224, // 0xC0140020
			STATUS_ACPI_POWER_REQUEST_FAILED = 3222536225, // 0xC0140021
			STATUS_SXS_SECTION_NOT_FOUND = 3222601729, // 0xC0150001
			STATUS_SXS_CANT_GEN_ACTCTX = 3222601730, // 0xC0150002
			STATUS_SXS_INVALID_ACTCTXDATA_FORMAT = 3222601731, // 0xC0150003
			STATUS_SXS_ASSEMBLY_NOT_FOUND = 3222601732, // 0xC0150004
			STATUS_SXS_MANIFEST_FORMAT_ERROR = 3222601733, // 0xC0150005
			STATUS_SXS_MANIFEST_PARSE_ERROR = 3222601734, // 0xC0150006
			STATUS_SXS_ACTIVATION_CONTEXT_DISABLED = 3222601735, // 0xC0150007
			STATUS_SXS_KEY_NOT_FOUND = 3222601736, // 0xC0150008
			STATUS_SXS_VERSION_CONFLICT = 3222601737, // 0xC0150009
			STATUS_SXS_WRONG_SECTION_TYPE = 3222601738, // 0xC015000A
			STATUS_SXS_THREAD_QUERIES_DISABLED = 3222601739, // 0xC015000B
			STATUS_SXS_ASSEMBLY_MISSING = 3222601740, // 0xC015000C
			STATUS_SXS_PROCESS_DEFAULT_ALREADY_SET = 3222601742, // 0xC015000E
			STATUS_SXS_EARLY_DEACTIVATION = 3222601743, // 0xC015000F
			STATUS_SXS_INVALID_DEACTIVATION = 3222601744, // 0xC0150010
			STATUS_SXS_MULTIPLE_DEACTIVATION = 3222601745, // 0xC0150011
			STATUS_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY = 3222601746, // 0xC0150012
			STATUS_SXS_PROCESS_TERMINATION_REQUESTED = 3222601747, // 0xC0150013
			STATUS_SXS_CORRUPT_ACTIVATION_STACK = 3222601748, // 0xC0150014
			STATUS_SXS_CORRUPTION = 3222601749, // 0xC0150015
			STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE = 3222601750, // 0xC0150016
			STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME = 3222601751, // 0xC0150017
			STATUS_SXS_IDENTITY_DUPLICATE_ATTRIBUTE = 3222601752, // 0xC0150018
			STATUS_SXS_IDENTITY_PARSE_ERROR = 3222601753, // 0xC0150019
			STATUS_SXS_COMPONENT_STORE_CORRUPT = 3222601754, // 0xC015001A
			STATUS_SXS_FILE_HASH_MISMATCH = 3222601755, // 0xC015001B
			STATUS_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT = 3222601756, // 0xC015001C
			STATUS_SXS_IDENTITIES_DIFFERENT = 3222601757, // 0xC015001D
			STATUS_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT = 3222601758, // 0xC015001E
			STATUS_SXS_FILE_NOT_PART_OF_ASSEMBLY = 3222601759, // 0xC015001F
			STATUS_ADVANCED_INSTALLER_FAILED = 3222601760, // 0xC0150020
			STATUS_XML_ENCODING_MISMATCH = 3222601761, // 0xC0150021
			STATUS_SXS_MANIFEST_TOO_BIG = 3222601762, // 0xC0150022
			STATUS_SXS_SETTING_NOT_REGISTERED = 3222601763, // 0xC0150023
			STATUS_SXS_TRANSACTION_CLOSURE_INCOMPLETE = 3222601764, // 0xC0150024
			STATUS_SMI_PRIMITIVE_INSTALLER_FAILED = 3222601765, // 0xC0150025
			STATUS_GENERIC_COMMAND_FAILED = 3222601766, // 0xC0150026
			STATUS_SXS_FILE_HASH_MISSING = 3222601767, // 0xC0150027
			STATUS_TRANSACTIONAL_CONFLICT = 3222863873, // 0xC0190001
			STATUS_INVALID_TRANSACTION = 3222863874, // 0xC0190002
			STATUS_TRANSACTION_NOT_ACTIVE = 3222863875, // 0xC0190003
			STATUS_TM_INITIALIZATION_FAILED = 3222863876, // 0xC0190004
			STATUS_RM_NOT_ACTIVE = 3222863877, // 0xC0190005
			STATUS_RM_METADATA_CORRUPT = 3222863878, // 0xC0190006
			STATUS_TRANSACTION_NOT_JOINED = 3222863879, // 0xC0190007
			STATUS_DIRECTORY_NOT_RM = 3222863880, // 0xC0190008
			STATUS_TRANSACTIONS_UNSUPPORTED_REMOTE = 3222863882, // 0xC019000A
			STATUS_LOG_RESIZE_INVALID_SIZE = 3222863883, // 0xC019000B
			STATUS_REMOTE_FILE_VERSION_MISMATCH = 3222863884, // 0xC019000C
			STATUS_CRM_PROTOCOL_ALREADY_EXISTS = 3222863887, // 0xC019000F
			STATUS_TRANSACTION_PROPAGATION_FAILED = 3222863888, // 0xC0190010
			STATUS_CRM_PROTOCOL_NOT_FOUND = 3222863889, // 0xC0190011
			STATUS_TRANSACTION_SUPERIOR_EXISTS = 3222863890, // 0xC0190012
			STATUS_TRANSACTION_REQUEST_NOT_VALID = 3222863891, // 0xC0190013
			STATUS_TRANSACTION_NOT_REQUESTED = 3222863892, // 0xC0190014
			STATUS_TRANSACTION_ALREADY_ABORTED = 3222863893, // 0xC0190015
			STATUS_TRANSACTION_ALREADY_COMMITTED = 3222863894, // 0xC0190016
			STATUS_TRANSACTION_INVALID_MARSHALL_BUFFER = 3222863895, // 0xC0190017
			STATUS_CURRENT_TRANSACTION_NOT_VALID = 3222863896, // 0xC0190018
			STATUS_LOG_GROWTH_FAILED = 3222863897, // 0xC0190019
			STATUS_OBJECT_NO_LONGER_EXISTS = 3222863905, // 0xC0190021
			STATUS_STREAM_MINIVERSION_NOT_FOUND = 3222863906, // 0xC0190022
			STATUS_STREAM_MINIVERSION_NOT_VALID = 3222863907, // 0xC0190023
			STATUS_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION = 3222863908, // 0xC0190024
			STATUS_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT = 3222863909, // 0xC0190025
			STATUS_CANT_CREATE_MORE_STREAM_MINIVERSIONS = 3222863910, // 0xC0190026
			STATUS_HANDLE_NO_LONGER_VALID = 3222863912, // 0xC0190028
			STATUS_LOG_CORRUPTION_DETECTED = 3222863920, // 0xC0190030
			STATUS_RM_DISCONNECTED = 3222863922, // 0xC0190032
			STATUS_ENLISTMENT_NOT_SUPERIOR = 3222863923, // 0xC0190033
			STATUS_FILE_IDENTITY_NOT_PERSISTENT = 3222863926, // 0xC0190036
			STATUS_CANT_BREAK_TRANSACTIONAL_DEPENDENCY = 3222863927, // 0xC0190037
			STATUS_CANT_CROSS_RM_BOUNDARY = 3222863928, // 0xC0190038
			STATUS_TXF_DIR_NOT_EMPTY = 3222863929, // 0xC0190039
			STATUS_INDOUBT_TRANSACTIONS_EXIST = 3222863930, // 0xC019003A
			STATUS_TM_VOLATILE = 3222863931, // 0xC019003B
			STATUS_ROLLBACK_TIMER_EXPIRED = 3222863932, // 0xC019003C
			STATUS_TXF_ATTRIBUTE_CORRUPT = 3222863933, // 0xC019003D
			STATUS_EFS_NOT_ALLOWED_IN_TRANSACTION = 3222863934, // 0xC019003E
			STATUS_TRANSACTIONAL_OPEN_NOT_ALLOWED = 3222863935, // 0xC019003F
			STATUS_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE = 3222863936, // 0xC0190040
			STATUS_TRANSACTION_REQUIRED_PROMOTION = 3222863939, // 0xC0190043
			STATUS_CANNOT_EXECUTE_FILE_IN_TRANSACTION = 3222863940, // 0xC0190044
			STATUS_TRANSACTIONS_NOT_FROZEN = 3222863941, // 0xC0190045
			STATUS_TRANSACTION_FREEZE_IN_PROGRESS = 3222863942, // 0xC0190046
			STATUS_NOT_SNAPSHOT_VOLUME = 3222863943, // 0xC0190047
			STATUS_NO_SAVEPOINT_WITH_OPEN_FILES = 3222863944, // 0xC0190048
			STATUS_SPARSE_NOT_ALLOWED_IN_TRANSACTION = 3222863945, // 0xC0190049
			STATUS_TM_IDENTITY_MISMATCH = 3222863946, // 0xC019004A
			STATUS_FLOATED_SECTION = 3222863947, // 0xC019004B
			STATUS_CANNOT_ACCEPT_TRANSACTED_WORK = 3222863948, // 0xC019004C
			STATUS_CANNOT_ABORT_TRANSACTIONS = 3222863949, // 0xC019004D
			STATUS_TRANSACTION_NOT_FOUND = 3222863950, // 0xC019004E
			STATUS_RESOURCEMANAGER_NOT_FOUND = 3222863951, // 0xC019004F
			STATUS_ENLISTMENT_NOT_FOUND = 3222863952, // 0xC0190050
			STATUS_TRANSACTIONMANAGER_NOT_FOUND = 3222863953, // 0xC0190051
			STATUS_TRANSACTIONMANAGER_NOT_ONLINE = 3222863954, // 0xC0190052
			STATUS_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION = 3222863955, // 0xC0190053
			STATUS_TRANSACTION_NOT_ROOT = 3222863956, // 0xC0190054
			STATUS_TRANSACTION_OBJECT_EXPIRED = 3222863957, // 0xC0190055
			STATUS_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION = 3222863958, // 0xC0190056
			STATUS_TRANSACTION_RESPONSE_NOT_ENLISTED = 3222863959, // 0xC0190057
			STATUS_TRANSACTION_RECORD_TOO_LONG = 3222863960, // 0xC0190058
			STATUS_NO_LINK_TRACKING_IN_TRANSACTION = 3222863961, // 0xC0190059
			STATUS_OPERATION_NOT_SUPPORTED_IN_TRANSACTION = 3222863962, // 0xC019005A
			STATUS_TRANSACTION_INTEGRITY_VIOLATED = 3222863963, // 0xC019005B
			STATUS_TRANSACTIONMANAGER_IDENTITY_MISMATCH = 3222863964, // 0xC019005C
			STATUS_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT = 3222863965, // 0xC019005D
			STATUS_TRANSACTION_MUST_WRITETHROUGH = 3222863966, // 0xC019005E
			STATUS_TRANSACTION_NO_SUPERIOR = 3222863967, // 0xC019005F
			STATUS_EXPIRED_HANDLE = 3222863968, // 0xC0190060
			STATUS_TRANSACTION_NOT_ENLISTED = 3222863969, // 0xC0190061
			STATUS_LOG_SECTOR_INVALID = 3222929409, // 0xC01A0001
			STATUS_LOG_SECTOR_PARITY_INVALID = 3222929410, // 0xC01A0002
			STATUS_LOG_SECTOR_REMAPPED = 3222929411, // 0xC01A0003
			STATUS_LOG_BLOCK_INCOMPLETE = 3222929412, // 0xC01A0004
			STATUS_LOG_INVALID_RANGE = 3222929413, // 0xC01A0005
			STATUS_LOG_BLOCKS_EXHAUSTED = 3222929414, // 0xC01A0006
			STATUS_LOG_READ_CONTEXT_INVALID = 3222929415, // 0xC01A0007
			STATUS_LOG_RESTART_INVALID = 3222929416, // 0xC01A0008
			STATUS_LOG_BLOCK_VERSION = 3222929417, // 0xC01A0009
			STATUS_LOG_BLOCK_INVALID = 3222929418, // 0xC01A000A
			STATUS_LOG_READ_MODE_INVALID = 3222929419, // 0xC01A000B
			STATUS_LOG_METADATA_CORRUPT = 3222929421, // 0xC01A000D
			STATUS_LOG_METADATA_INVALID = 3222929422, // 0xC01A000E
			STATUS_LOG_METADATA_INCONSISTENT = 3222929423, // 0xC01A000F
			STATUS_LOG_RESERVATION_INVALID = 3222929424, // 0xC01A0010
			STATUS_LOG_CANT_DELETE = 3222929425, // 0xC01A0011
			STATUS_LOG_CONTAINER_LIMIT_EXCEEDED = 3222929426, // 0xC01A0012
			STATUS_LOG_START_OF_LOG = 3222929427, // 0xC01A0013
			STATUS_LOG_POLICY_ALREADY_INSTALLED = 3222929428, // 0xC01A0014
			STATUS_LOG_POLICY_NOT_INSTALLED = 3222929429, // 0xC01A0015
			STATUS_LOG_POLICY_INVALID = 3222929430, // 0xC01A0016
			STATUS_LOG_POLICY_CONFLICT = 3222929431, // 0xC01A0017
			STATUS_LOG_PINNED_ARCHIVE_TAIL = 3222929432, // 0xC01A0018
			STATUS_LOG_RECORD_NONEXISTENT = 3222929433, // 0xC01A0019
			STATUS_LOG_RECORDS_RESERVED_INVALID = 3222929434, // 0xC01A001A
			STATUS_LOG_SPACE_RESERVED_INVALID = 3222929435, // 0xC01A001B
			STATUS_LOG_TAIL_INVALID = 3222929436, // 0xC01A001C
			STATUS_LOG_FULL = 3222929437, // 0xC01A001D
			STATUS_LOG_MULTIPLEXED = 3222929438, // 0xC01A001E
			STATUS_LOG_DEDICATED = 3222929439, // 0xC01A001F
			STATUS_LOG_ARCHIVE_NOT_IN_PROGRESS = 3222929440, // 0xC01A0020
			STATUS_LOG_ARCHIVE_IN_PROGRESS = 3222929441, // 0xC01A0021
			STATUS_LOG_EPHEMERAL = 3222929442, // 0xC01A0022
			STATUS_LOG_NOT_ENOUGH_CONTAINERS = 3222929443, // 0xC01A0023
			STATUS_LOG_CLIENT_ALREADY_REGISTERED = 3222929444, // 0xC01A0024
			STATUS_LOG_CLIENT_NOT_REGISTERED = 3222929445, // 0xC01A0025
			STATUS_LOG_FULL_HANDLER_IN_PROGRESS = 3222929446, // 0xC01A0026
			STATUS_LOG_CONTAINER_READ_FAILED = 3222929447, // 0xC01A0027
			STATUS_LOG_CONTAINER_WRITE_FAILED = 3222929448, // 0xC01A0028
			STATUS_LOG_CONTAINER_OPEN_FAILED = 3222929449, // 0xC01A0029
			STATUS_LOG_CONTAINER_STATE_INVALID = 3222929450, // 0xC01A002A
			STATUS_LOG_STATE_INVALID = 3222929451, // 0xC01A002B
			STATUS_LOG_PINNED = 3222929452, // 0xC01A002C
			STATUS_LOG_METADATA_FLUSH_FAILED = 3222929453, // 0xC01A002D
			STATUS_LOG_INCONSISTENT_SECURITY = 3222929454, // 0xC01A002E
			STATUS_LOG_APPENDED_FLUSH_FAILED = 3222929455, // 0xC01A002F
			STATUS_LOG_PINNED_RESERVATION = 3222929456, // 0xC01A0030
			STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD = 3222995178, // 0xC01B00EA
			STATUS_FLT_NO_HANDLER_DEFINED = 3223060481, // 0xC01C0001
			STATUS_FLT_CONTEXT_ALREADY_DEFINED = 3223060482, // 0xC01C0002
			STATUS_FLT_INVALID_ASYNCHRONOUS_REQUEST = 3223060483, // 0xC01C0003
			STATUS_FLT_DISALLOW_FAST_IO = 3223060484, // 0xC01C0004
			STATUS_FLT_INVALID_NAME_REQUEST = 3223060485, // 0xC01C0005
			STATUS_FLT_NOT_SAFE_TO_POST_OPERATION = 3223060486, // 0xC01C0006
			STATUS_FLT_NOT_INITIALIZED = 3223060487, // 0xC01C0007
			STATUS_FLT_FILTER_NOT_READY = 3223060488, // 0xC01C0008
			STATUS_FLT_POST_OPERATION_CLEANUP = 3223060489, // 0xC01C0009
			STATUS_FLT_INTERNAL_ERROR = 3223060490, // 0xC01C000A
			STATUS_FLT_DELETING_OBJECT = 3223060491, // 0xC01C000B
			STATUS_FLT_MUST_BE_NONPAGED_POOL = 3223060492, // 0xC01C000C
			STATUS_FLT_DUPLICATE_ENTRY = 3223060493, // 0xC01C000D
			STATUS_FLT_CBDQ_DISABLED = 3223060494, // 0xC01C000E
			STATUS_FLT_DO_NOT_ATTACH = 3223060495, // 0xC01C000F
			STATUS_FLT_DO_NOT_DETACH = 3223060496, // 0xC01C0010
			STATUS_FLT_INSTANCE_ALTITUDE_COLLISION = 3223060497, // 0xC01C0011
			STATUS_FLT_INSTANCE_NAME_COLLISION = 3223060498, // 0xC01C0012
			STATUS_FLT_FILTER_NOT_FOUND = 3223060499, // 0xC01C0013
			STATUS_FLT_VOLUME_NOT_FOUND = 3223060500, // 0xC01C0014
			STATUS_FLT_INSTANCE_NOT_FOUND = 3223060501, // 0xC01C0015
			STATUS_FLT_CONTEXT_ALLOCATION_NOT_FOUND = 3223060502, // 0xC01C0016
			STATUS_FLT_INVALID_CONTEXT_REGISTRATION = 3223060503, // 0xC01C0017
			STATUS_FLT_NAME_CACHE_MISS = 3223060504, // 0xC01C0018
			STATUS_FLT_NO_DEVICE_OBJECT = 3223060505, // 0xC01C0019
			STATUS_FLT_VOLUME_ALREADY_MOUNTED = 3223060506, // 0xC01C001A
			STATUS_FLT_ALREADY_ENLISTED = 3223060507, // 0xC01C001B
			STATUS_FLT_CONTEXT_ALREADY_LINKED = 3223060508, // 0xC01C001C
			STATUS_FLT_NO_WAITER_FOR_REPLY = 3223060512, // 0xC01C0020
			STATUS_FLT_REGISTRATION_BUSY = 3223060515, // 0xC01C0023
			STATUS_MONITOR_NO_DESCRIPTOR = 3223126017, // 0xC01D0001
			STATUS_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT = 3223126018, // 0xC01D0002
			STATUS_MONITOR_INVALID_DESCRIPTOR_CHECKSUM = 3223126019, // 0xC01D0003
			STATUS_MONITOR_INVALID_STANDARD_TIMING_BLOCK = 3223126020, // 0xC01D0004
			STATUS_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED = 3223126021, // 0xC01D0005
			STATUS_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK = 3223126022, // 0xC01D0006
			STATUS_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK = 3223126023, // 0xC01D0007
			STATUS_MONITOR_NO_MORE_DESCRIPTOR_DATA = 3223126024, // 0xC01D0008
			STATUS_MONITOR_INVALID_DETAILED_TIMING_BLOCK = 3223126025, // 0xC01D0009
			STATUS_MONITOR_INVALID_MANUFACTURE_DATE = 3223126026, // 0xC01D000A
			STATUS_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER = 3223191552, // 0xC01E0000
			STATUS_GRAPHICS_INSUFFICIENT_DMA_BUFFER = 3223191553, // 0xC01E0001
			STATUS_GRAPHICS_INVALID_DISPLAY_ADAPTER = 3223191554, // 0xC01E0002
			STATUS_GRAPHICS_ADAPTER_WAS_RESET = 3223191555, // 0xC01E0003
			STATUS_GRAPHICS_INVALID_DRIVER_MODEL = 3223191556, // 0xC01E0004
			STATUS_GRAPHICS_PRESENT_MODE_CHANGED = 3223191557, // 0xC01E0005
			STATUS_GRAPHICS_PRESENT_OCCLUDED = 3223191558, // 0xC01E0006
			STATUS_GRAPHICS_PRESENT_DENIED = 3223191559, // 0xC01E0007
			STATUS_GRAPHICS_CANNOTCOLORCONVERT = 3223191560, // 0xC01E0008
			STATUS_GRAPHICS_DRIVER_MISMATCH = 3223191561, // 0xC01E0009
			STATUS_GRAPHICS_PRESENT_REDIRECTION_DISABLED = 3223191563, // 0xC01E000B
			STATUS_GRAPHICS_PRESENT_UNOCCLUDED = 3223191564, // 0xC01E000C
			STATUS_GRAPHICS_WINDOWDC_NOT_AVAILABLE = 3223191565, // 0xC01E000D
			STATUS_GRAPHICS_WINDOWLESS_PRESENT_DISABLED = 3223191566, // 0xC01E000E
			STATUS_GRAPHICS_NO_VIDEO_MEMORY = 3223191808, // 0xC01E0100
			STATUS_GRAPHICS_CANT_LOCK_MEMORY = 3223191809, // 0xC01E0101
			STATUS_GRAPHICS_ALLOCATION_BUSY = 3223191810, // 0xC01E0102
			STATUS_GRAPHICS_TOO_MANY_REFERENCES = 3223191811, // 0xC01E0103
			STATUS_GRAPHICS_TRY_AGAIN_LATER = 3223191812, // 0xC01E0104
			STATUS_GRAPHICS_TRY_AGAIN_NOW = 3223191813, // 0xC01E0105
			STATUS_GRAPHICS_ALLOCATION_INVALID = 3223191814, // 0xC01E0106
			STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE = 3223191815, // 0xC01E0107
			STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED = 3223191816, // 0xC01E0108
			STATUS_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION = 3223191817, // 0xC01E0109
			STATUS_GRAPHICS_INVALID_ALLOCATION_USAGE = 3223191824, // 0xC01E0110
			STATUS_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION = 3223191825, // 0xC01E0111
			STATUS_GRAPHICS_ALLOCATION_CLOSED = 3223191826, // 0xC01E0112
			STATUS_GRAPHICS_INVALID_ALLOCATION_INSTANCE = 3223191827, // 0xC01E0113
			STATUS_GRAPHICS_INVALID_ALLOCATION_HANDLE = 3223191828, // 0xC01E0114
			STATUS_GRAPHICS_WRONG_ALLOCATION_DEVICE = 3223191829, // 0xC01E0115
			STATUS_GRAPHICS_ALLOCATION_CONTENT_LOST = 3223191830, // 0xC01E0116
			STATUS_GRAPHICS_GPU_EXCEPTION_ON_DEVICE = 3223192064, // 0xC01E0200
			STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY = 3223192320, // 0xC01E0300
			STATUS_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED = 3223192321, // 0xC01E0301
			STATUS_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED = 3223192322, // 0xC01E0302
			STATUS_GRAPHICS_INVALID_VIDPN = 3223192323, // 0xC01E0303
			STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE = 3223192324, // 0xC01E0304
			STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET = 3223192325, // 0xC01E0305
			STATUS_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED = 3223192326, // 0xC01E0306
			STATUS_GRAPHICS_INVALID_VIDPN_SOURCEMODESET = 3223192328, // 0xC01E0308
			STATUS_GRAPHICS_INVALID_VIDPN_TARGETMODESET = 3223192329, // 0xC01E0309
			STATUS_GRAPHICS_INVALID_FREQUENCY = 3223192330, // 0xC01E030A
			STATUS_GRAPHICS_INVALID_ACTIVE_REGION = 3223192331, // 0xC01E030B
			STATUS_GRAPHICS_INVALID_TOTAL_REGION = 3223192332, // 0xC01E030C
			STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE = 3223192336, // 0xC01E0310
			STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE = 3223192337, // 0xC01E0311
			STATUS_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET = 3223192338, // 0xC01E0312
			STATUS_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY = 3223192339, // 0xC01E0313
			STATUS_GRAPHICS_MODE_ALREADY_IN_MODESET = 3223192340, // 0xC01E0314
			STATUS_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET = 3223192341, // 0xC01E0315
			STATUS_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET = 3223192342, // 0xC01E0316
			STATUS_GRAPHICS_SOURCE_ALREADY_IN_SET = 3223192343, // 0xC01E0317
			STATUS_GRAPHICS_TARGET_ALREADY_IN_SET = 3223192344, // 0xC01E0318
			STATUS_GRAPHICS_INVALID_VIDPN_PRESENT_PATH = 3223192345, // 0xC01E0319
			STATUS_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY = 3223192346, // 0xC01E031A
			STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET = 3223192347, // 0xC01E031B
			STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE = 3223192348, // 0xC01E031C
			STATUS_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET = 3223192349, // 0xC01E031D
			STATUS_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET = 3223192351, // 0xC01E031F
			STATUS_GRAPHICS_STALE_MODESET = 3223192352, // 0xC01E0320
			STATUS_GRAPHICS_INVALID_MONITOR_SOURCEMODESET = 3223192353, // 0xC01E0321
			STATUS_GRAPHICS_INVALID_MONITOR_SOURCE_MODE = 3223192354, // 0xC01E0322
			STATUS_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN = 3223192355, // 0xC01E0323
			STATUS_GRAPHICS_MODE_ID_MUST_BE_UNIQUE = 3223192356, // 0xC01E0324
			STATUS_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION = 3223192357, // 0xC01E0325
			STATUS_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES = 3223192358, // 0xC01E0326
			STATUS_GRAPHICS_PATH_NOT_IN_TOPOLOGY = 3223192359, // 0xC01E0327
			STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE = 3223192360, // 0xC01E0328
			STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET = 3223192361, // 0xC01E0329
			STATUS_GRAPHICS_INVALID_MONITORDESCRIPTORSET = 3223192362, // 0xC01E032A
			STATUS_GRAPHICS_INVALID_MONITORDESCRIPTOR = 3223192363, // 0xC01E032B
			STATUS_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET = 3223192364, // 0xC01E032C
			STATUS_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET = 3223192365, // 0xC01E032D
			STATUS_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE = 3223192366, // 0xC01E032E
			STATUS_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE = 3223192367, // 0xC01E032F
			STATUS_GRAPHICS_RESOURCES_NOT_RELATED = 3223192368, // 0xC01E0330
			STATUS_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE = 3223192369, // 0xC01E0331
			STATUS_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE = 3223192370, // 0xC01E0332
			STATUS_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET = 3223192371, // 0xC01E0333
			STATUS_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER = 3223192372, // 0xC01E0334
			STATUS_GRAPHICS_NO_VIDPNMGR = 3223192373, // 0xC01E0335
			STATUS_GRAPHICS_NO_ACTIVE_VIDPN = 3223192374, // 0xC01E0336
			STATUS_GRAPHICS_STALE_VIDPN_TOPOLOGY = 3223192375, // 0xC01E0337
			STATUS_GRAPHICS_MONITOR_NOT_CONNECTED = 3223192376, // 0xC01E0338
			STATUS_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY = 3223192377, // 0xC01E0339
			STATUS_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE = 3223192378, // 0xC01E033A
			STATUS_GRAPHICS_INVALID_VISIBLEREGION_SIZE = 3223192379, // 0xC01E033B
			STATUS_GRAPHICS_INVALID_STRIDE = 3223192380, // 0xC01E033C
			STATUS_GRAPHICS_INVALID_PIXELFORMAT = 3223192381, // 0xC01E033D
			STATUS_GRAPHICS_INVALID_COLORBASIS = 3223192382, // 0xC01E033E
			STATUS_GRAPHICS_INVALID_PIXELVALUEACCESSMODE = 3223192383, // 0xC01E033F
			STATUS_GRAPHICS_TARGET_NOT_IN_TOPOLOGY = 3223192384, // 0xC01E0340
			STATUS_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT = 3223192385, // 0xC01E0341
			STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = 3223192386, // 0xC01E0342
			STATUS_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN = 3223192387, // 0xC01E0343
			STATUS_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL = 3223192388, // 0xC01E0344
			STATUS_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION = 3223192389, // 0xC01E0345
			STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED = 3223192390, // 0xC01E0346
			STATUS_GRAPHICS_INVALID_GAMMA_RAMP = 3223192391, // 0xC01E0347
			STATUS_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED = 3223192392, // 0xC01E0348
			STATUS_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED = 3223192393, // 0xC01E0349
			STATUS_GRAPHICS_MODE_NOT_IN_MODESET = 3223192394, // 0xC01E034A
			STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON = 3223192397, // 0xC01E034D
			STATUS_GRAPHICS_INVALID_PATH_CONTENT_TYPE = 3223192398, // 0xC01E034E
			STATUS_GRAPHICS_INVALID_COPYPROTECTION_TYPE = 3223192399, // 0xC01E034F
			STATUS_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS = 3223192400, // 0xC01E0350
			STATUS_GRAPHICS_INVALID_SCANLINE_ORDERING = 3223192402, // 0xC01E0352
			STATUS_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED = 3223192403, // 0xC01E0353
			STATUS_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS = 3223192404, // 0xC01E0354
			STATUS_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT = 3223192405, // 0xC01E0355
			STATUS_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM = 3223192406, // 0xC01E0356
			STATUS_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN = 3223192407, // 0xC01E0357
			STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT = 3223192408, // 0xC01E0358
			STATUS_GRAPHICS_MAX_NUM_PATHS_REACHED = 3223192409, // 0xC01E0359
			STATUS_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION = 3223192410, // 0xC01E035A
			STATUS_GRAPHICS_INVALID_CLIENT_TYPE = 3223192411, // 0xC01E035B
			STATUS_GRAPHICS_CLIENTVIDPN_NOT_SET = 3223192412, // 0xC01E035C
			STATUS_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED = 3223192576, // 0xC01E0400
			STATUS_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED = 3223192577, // 0xC01E0401
			STATUS_GRAPHICS_NOT_A_LINKED_ADAPTER = 3223192624, // 0xC01E0430
			STATUS_GRAPHICS_LEADLINK_NOT_ENUMERATED = 3223192625, // 0xC01E0431
			STATUS_GRAPHICS_CHAINLINKS_NOT_ENUMERATED = 3223192626, // 0xC01E0432
			STATUS_GRAPHICS_ADAPTER_CHAIN_NOT_READY = 3223192627, // 0xC01E0433
			STATUS_GRAPHICS_CHAINLINKS_NOT_STARTED = 3223192628, // 0xC01E0434
			STATUS_GRAPHICS_CHAINLINKS_NOT_POWERED_ON = 3223192629, // 0xC01E0435
			STATUS_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE = 3223192630, // 0xC01E0436
			STATUS_GRAPHICS_NOT_POST_DEVICE_DRIVER = 3223192632, // 0xC01E0438
			STATUS_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED = 3223192635, // 0xC01E043B
			STATUS_GRAPHICS_OPM_NOT_SUPPORTED = 3223192832, // 0xC01E0500
			STATUS_GRAPHICS_COPP_NOT_SUPPORTED = 3223192833, // 0xC01E0501
			STATUS_GRAPHICS_UAB_NOT_SUPPORTED = 3223192834, // 0xC01E0502
			STATUS_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS = 3223192835, // 0xC01E0503
			STATUS_GRAPHICS_OPM_NO_PROTECTED_OUTPUTS_EXIST = 3223192837, // 0xC01E0505
			STATUS_GRAPHICS_OPM_INTERNAL_ERROR = 3223192843, // 0xC01E050B
			STATUS_GRAPHICS_OPM_INVALID_HANDLE = 3223192844, // 0xC01E050C
			STATUS_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH = 3223192846, // 0xC01E050E
			STATUS_GRAPHICS_OPM_SPANNING_MODE_ENABLED = 3223192847, // 0xC01E050F
			STATUS_GRAPHICS_OPM_THEATER_MODE_ENABLED = 3223192848, // 0xC01E0510
			STATUS_GRAPHICS_PVP_HFS_FAILED = 3223192849, // 0xC01E0511
			STATUS_GRAPHICS_OPM_INVALID_SRM = 3223192850, // 0xC01E0512
			STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP = 3223192851, // 0xC01E0513
			STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP = 3223192852, // 0xC01E0514
			STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA = 3223192853, // 0xC01E0515
			STATUS_GRAPHICS_OPM_HDCP_SRM_NEVER_SET = 3223192854, // 0xC01E0516
			STATUS_GRAPHICS_OPM_RESOLUTION_TOO_HIGH = 3223192855, // 0xC01E0517
			STATUS_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE = 3223192856, // 0xC01E0518
			STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_NO_LONGER_EXISTS = 3223192858, // 0xC01E051A
			STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS = 3223192860, // 0xC01E051C
			STATUS_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST = 3223192861, // 0xC01E051D
			STATUS_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR = 3223192862, // 0xC01E051E
			STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS = 3223192863, // 0xC01E051F
			STATUS_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED = 3223192864, // 0xC01E0520
			STATUS_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST = 3223192865, // 0xC01E0521
			STATUS_GRAPHICS_I2C_NOT_SUPPORTED = 3223192960, // 0xC01E0580
			STATUS_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST = 3223192961, // 0xC01E0581
			STATUS_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA = 3223192962, // 0xC01E0582
			STATUS_GRAPHICS_I2C_ERROR_RECEIVING_DATA = 3223192963, // 0xC01E0583
			STATUS_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED = 3223192964, // 0xC01E0584
			STATUS_GRAPHICS_DDCCI_INVALID_DATA = 3223192965, // 0xC01E0585
			STATUS_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE = 3223192966, // 0xC01E0586
			STATUS_GRAPHICS_DDCCI_INVALID_CAPABILITIES_STRING = 3223192967, // 0xC01E0587
			STATUS_GRAPHICS_MCA_INTERNAL_ERROR = 3223192968, // 0xC01E0588
			STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND = 3223192969, // 0xC01E0589
			STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH = 3223192970, // 0xC01E058A
			STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM = 3223192971, // 0xC01E058B
			STATUS_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE = 3223192972, // 0xC01E058C
			STATUS_GRAPHICS_MONITOR_NO_LONGER_EXISTS = 3223192973, // 0xC01E058D
			STATUS_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED = 3223193056, // 0xC01E05E0
			STATUS_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME = 3223193057, // 0xC01E05E1
			STATUS_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP = 3223193058, // 0xC01E05E2
			STATUS_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED = 3223193059, // 0xC01E05E3
			STATUS_GRAPHICS_INVALID_POINTER = 3223193060, // 0xC01E05E4
			STATUS_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE = 3223193061, // 0xC01E05E5
			STATUS_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL = 3223193062, // 0xC01E05E6
			STATUS_GRAPHICS_INTERNAL_ERROR = 3223193063, // 0xC01E05E7
			STATUS_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS = 3223193064, // 0xC01E05E8
			STATUS_FVE_LOCKED_VOLUME = 3223388160, // 0xC0210000
			STATUS_FVE_NOT_ENCRYPTED = 3223388161, // 0xC0210001
			STATUS_FVE_BAD_INFORMATION = 3223388162, // 0xC0210002
			STATUS_FVE_TOO_SMALL = 3223388163, // 0xC0210003
			STATUS_FVE_FAILED_WRONG_FS = 3223388164, // 0xC0210004
			STATUS_FVE_BAD_PARTITION_SIZE = 3223388165, // 0xC0210005
			STATUS_FVE_FS_NOT_EXTENDED = 3223388166, // 0xC0210006
			STATUS_FVE_FS_MOUNTED = 3223388167, // 0xC0210007
			STATUS_FVE_NO_LICENSE = 3223388168, // 0xC0210008
			STATUS_FVE_ACTION_NOT_ALLOWED = 3223388169, // 0xC0210009
			STATUS_FVE_BAD_DATA = 3223388170, // 0xC021000A
			STATUS_FVE_VOLUME_NOT_BOUND = 3223388171, // 0xC021000B
			STATUS_FVE_NOT_DATA_VOLUME = 3223388172, // 0xC021000C
			STATUS_FVE_CONV_READ_ERROR = 3223388173, // 0xC021000D
			STATUS_FVE_CONV_WRITE_ERROR = 3223388174, // 0xC021000E
			STATUS_FVE_OVERLAPPED_UPDATE = 3223388175, // 0xC021000F
			STATUS_FVE_FAILED_SECTOR_SIZE = 3223388176, // 0xC0210010
			STATUS_FVE_FAILED_AUTHENTICATION = 3223388177, // 0xC0210011
			STATUS_FVE_NOT_OS_VOLUME = 3223388178, // 0xC0210012
			STATUS_FVE_KEYFILE_NOT_FOUND = 3223388179, // 0xC0210013
			STATUS_FVE_KEYFILE_INVALID = 3223388180, // 0xC0210014
			STATUS_FVE_KEYFILE_NO_VMK = 3223388181, // 0xC0210015
			STATUS_FVE_TPM_DISABLED = 3223388182, // 0xC0210016
			STATUS_FVE_TPM_SRK_AUTH_NOT_ZERO = 3223388183, // 0xC0210017
			STATUS_FVE_TPM_INVALID_PCR = 3223388184, // 0xC0210018
			STATUS_FVE_TPM_NO_VMK = 3223388185, // 0xC0210019
			STATUS_FVE_PIN_INVALID = 3223388186, // 0xC021001A
			STATUS_FVE_AUTH_INVALID_APPLICATION = 3223388187, // 0xC021001B
			STATUS_FVE_AUTH_INVALID_CONFIG = 3223388188, // 0xC021001C
			STATUS_FVE_DEBUGGER_ENABLED = 3223388189, // 0xC021001D
			STATUS_FVE_DRY_RUN_FAILED = 3223388190, // 0xC021001E
			STATUS_FVE_BAD_METADATA_POINTER = 3223388191, // 0xC021001F
			STATUS_FVE_OLD_METADATA_COPY = 3223388192, // 0xC0210020
			STATUS_FVE_REBOOT_REQUIRED = 3223388193, // 0xC0210021
			STATUS_FVE_RAW_ACCESS = 3223388194, // 0xC0210022
			STATUS_FVE_RAW_BLOCKED = 3223388195, // 0xC0210023
			STATUS_FVE_NO_AUTOUNLOCK_MASTER_KEY = 3223388196, // 0xC0210024
			STATUS_FVE_MOR_FAILED = 3223388197, // 0xC0210025
			STATUS_FVE_NO_FEATURE_LICENSE = 3223388198, // 0xC0210026
			STATUS_FVE_POLICY_USER_DISABLE_RDV_NOT_ALLOWED = 3223388199, // 0xC0210027
			STATUS_FVE_CONV_RECOVERY_FAILED = 3223388200, // 0xC0210028
			STATUS_FVE_VIRTUALIZED_SPACE_TOO_BIG = 3223388201, // 0xC0210029
			STATUS_FVE_INVALID_DATUM_TYPE = 3223388202, // 0xC021002A
			STATUS_FVE_VOLUME_TOO_SMALL = 3223388208, // 0xC0210030
			STATUS_FVE_ENH_PIN_INVALID = 3223388209, // 0xC0210031
			STATUS_FVE_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE = 3223388210, // 0xC0210032
			STATUS_FVE_WIPE_NOT_ALLOWED_ON_TP_STORAGE = 3223388211, // 0xC0210033
			STATUS_FVE_NOT_ALLOWED_ON_CSV_STACK = 3223388212, // 0xC0210034
			STATUS_FVE_NOT_ALLOWED_ON_CLUSTER = 3223388213, // 0xC0210035
			STATUS_FVE_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING = 3223388214, // 0xC0210036
			STATUS_FVE_WIPE_CANCEL_NOT_APPLICABLE = 3223388215, // 0xC0210037
			STATUS_FVE_EDRIVE_DRY_RUN_FAILED = 3223388216, // 0xC0210038
			STATUS_FVE_SECUREBOOT_DISABLED = 3223388217, // 0xC0210039
			STATUS_FVE_SECUREBOOT_CONFIG_CHANGE = 3223388218, // 0xC021003A
			STATUS_FVE_DEVICE_LOCKEDOUT = 3223388219, // 0xC021003B
			STATUS_FVE_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT = 3223388220, // 0xC021003C
			STATUS_FVE_NOT_DE_VOLUME = 3223388221, // 0xC021003D
			STATUS_FVE_PROTECTION_DISABLED = 3223388222, // 0xC021003E
			STATUS_FVE_PROTECTION_CANNOT_BE_DISABLED = 3223388223, // 0xC021003F
			STATUS_FWP_CALLOUT_NOT_FOUND = 3223453697, // 0xC0220001
			STATUS_FWP_CONDITION_NOT_FOUND = 3223453698, // 0xC0220002
			STATUS_FWP_FILTER_NOT_FOUND = 3223453699, // 0xC0220003
			STATUS_FWP_LAYER_NOT_FOUND = 3223453700, // 0xC0220004
			STATUS_FWP_PROVIDER_NOT_FOUND = 3223453701, // 0xC0220005
			STATUS_FWP_PROVIDER_CONTEXT_NOT_FOUND = 3223453702, // 0xC0220006
			STATUS_FWP_SUBLAYER_NOT_FOUND = 3223453703, // 0xC0220007
			STATUS_FWP_NOT_FOUND = 3223453704, // 0xC0220008
			STATUS_FWP_ALREADY_EXISTS = 3223453705, // 0xC0220009
			STATUS_FWP_IN_USE = 3223453706, // 0xC022000A
			STATUS_FWP_DYNAMIC_SESSION_IN_PROGRESS = 3223453707, // 0xC022000B
			STATUS_FWP_WRONG_SESSION = 3223453708, // 0xC022000C
			STATUS_FWP_NO_TXN_IN_PROGRESS = 3223453709, // 0xC022000D
			STATUS_FWP_TXN_IN_PROGRESS = 3223453710, // 0xC022000E
			STATUS_FWP_TXN_ABORTED = 3223453711, // 0xC022000F
			STATUS_FWP_SESSION_ABORTED = 3223453712, // 0xC0220010
			STATUS_FWP_INCOMPATIBLE_TXN = 3223453713, // 0xC0220011
			STATUS_FWP_TIMEOUT = 3223453714, // 0xC0220012
			STATUS_FWP_NET_EVENTS_DISABLED = 3223453715, // 0xC0220013
			STATUS_FWP_INCOMPATIBLE_LAYER = 3223453716, // 0xC0220014
			STATUS_FWP_KM_CLIENTS_ONLY = 3223453717, // 0xC0220015
			STATUS_FWP_LIFETIME_MISMATCH = 3223453718, // 0xC0220016
			STATUS_FWP_BUILTIN_OBJECT = 3223453719, // 0xC0220017
			STATUS_FWP_TOO_MANY_CALLOUTS = 3223453720, // 0xC0220018
			STATUS_FWP_NOTIFICATION_DROPPED = 3223453721, // 0xC0220019
			STATUS_FWP_TRAFFIC_MISMATCH = 3223453722, // 0xC022001A
			STATUS_FWP_INCOMPATIBLE_SA_STATE = 3223453723, // 0xC022001B
			STATUS_FWP_NULL_POINTER = 3223453724, // 0xC022001C
			STATUS_FWP_INVALID_ENUMERATOR = 3223453725, // 0xC022001D
			STATUS_FWP_INVALID_FLAGS = 3223453726, // 0xC022001E
			STATUS_FWP_INVALID_NET_MASK = 3223453727, // 0xC022001F
			STATUS_FWP_INVALID_RANGE = 3223453728, // 0xC0220020
			STATUS_FWP_INVALID_INTERVAL = 3223453729, // 0xC0220021
			STATUS_FWP_ZERO_LENGTH_ARRAY = 3223453730, // 0xC0220022
			STATUS_FWP_NULL_DISPLAY_NAME = 3223453731, // 0xC0220023
			STATUS_FWP_INVALID_ACTION_TYPE = 3223453732, // 0xC0220024
			STATUS_FWP_INVALID_WEIGHT = 3223453733, // 0xC0220025
			STATUS_FWP_MATCH_TYPE_MISMATCH = 3223453734, // 0xC0220026
			STATUS_FWP_TYPE_MISMATCH = 3223453735, // 0xC0220027
			STATUS_FWP_OUT_OF_BOUNDS = 3223453736, // 0xC0220028
			STATUS_FWP_RESERVED = 3223453737, // 0xC0220029
			STATUS_FWP_DUPLICATE_CONDITION = 3223453738, // 0xC022002A
			STATUS_FWP_DUPLICATE_KEYMOD = 3223453739, // 0xC022002B
			STATUS_FWP_ACTION_INCOMPATIBLE_WITH_LAYER = 3223453740, // 0xC022002C
			STATUS_FWP_ACTION_INCOMPATIBLE_WITH_SUBLAYER = 3223453741, // 0xC022002D
			STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_LAYER = 3223453742, // 0xC022002E
			STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_CALLOUT = 3223453743, // 0xC022002F
			STATUS_FWP_INCOMPATIBLE_AUTH_METHOD = 3223453744, // 0xC0220030
			STATUS_FWP_INCOMPATIBLE_DH_GROUP = 3223453745, // 0xC0220031
			STATUS_FWP_EM_NOT_SUPPORTED = 3223453746, // 0xC0220032
			STATUS_FWP_NEVER_MATCH = 3223453747, // 0xC0220033
			STATUS_FWP_PROVIDER_CONTEXT_MISMATCH = 3223453748, // 0xC0220034
			STATUS_FWP_INVALID_PARAMETER = 3223453749, // 0xC0220035
			STATUS_FWP_TOO_MANY_SUBLAYERS = 3223453750, // 0xC0220036
			STATUS_FWP_CALLOUT_NOTIFICATION_FAILED = 3223453751, // 0xC0220037
			STATUS_FWP_INVALID_AUTH_TRANSFORM = 3223453752, // 0xC0220038
			STATUS_FWP_INVALID_CIPHER_TRANSFORM = 3223453753, // 0xC0220039
			STATUS_FWP_INCOMPATIBLE_CIPHER_TRANSFORM = 3223453754, // 0xC022003A
			STATUS_FWP_INVALID_TRANSFORM_COMBINATION = 3223453755, // 0xC022003B
			STATUS_FWP_DUPLICATE_AUTH_METHOD = 3223453756, // 0xC022003C
			STATUS_FWP_INVALID_TUNNEL_ENDPOINT = 3223453757, // 0xC022003D
			STATUS_FWP_L2_DRIVER_NOT_READY = 3223453758, // 0xC022003E
			STATUS_FWP_KEY_DICTATOR_ALREADY_REGISTERED = 3223453759, // 0xC022003F
			STATUS_FWP_KEY_DICTATION_INVALID_KEYING_MATERIAL = 3223453760, // 0xC0220040
			STATUS_FWP_CONNECTIONS_DISABLED = 3223453761, // 0xC0220041
			STATUS_FWP_INVALID_DNS_NAME = 3223453762, // 0xC0220042
			STATUS_FWP_STILL_ON = 3223453763, // 0xC0220043
			STATUS_FWP_IKEEXT_NOT_RUNNING = 3223453764, // 0xC0220044
			STATUS_FWP_TCPIP_NOT_READY = 3223453952, // 0xC0220100
			STATUS_FWP_INJECT_HANDLE_CLOSING = 3223453953, // 0xC0220101
			STATUS_FWP_INJECT_HANDLE_STALE = 3223453954, // 0xC0220102
			STATUS_FWP_CANNOT_PEND = 3223453955, // 0xC0220103
			STATUS_FWP_DROP_NOICMP = 3223453956, // 0xC0220104
			STATUS_NDIS_CLOSING = 3223519234, // 0xC0230002
			STATUS_NDIS_BAD_VERSION = 3223519236, // 0xC0230004
			STATUS_NDIS_BAD_CHARACTERISTICS = 3223519237, // 0xC0230005
			STATUS_NDIS_ADAPTER_NOT_FOUND = 3223519238, // 0xC0230006
			STATUS_NDIS_OPEN_FAILED = 3223519239, // 0xC0230007
			STATUS_NDIS_DEVICE_FAILED = 3223519240, // 0xC0230008
			STATUS_NDIS_MULTICAST_FULL = 3223519241, // 0xC0230009
			STATUS_NDIS_MULTICAST_EXISTS = 3223519242, // 0xC023000A
			STATUS_NDIS_MULTICAST_NOT_FOUND = 3223519243, // 0xC023000B
			STATUS_NDIS_REQUEST_ABORTED = 3223519244, // 0xC023000C
			STATUS_NDIS_RESET_IN_PROGRESS = 3223519245, // 0xC023000D
			STATUS_NDIS_INVALID_PACKET = 3223519247, // 0xC023000F
			STATUS_NDIS_INVALID_DEVICE_REQUEST = 3223519248, // 0xC0230010
			STATUS_NDIS_ADAPTER_NOT_READY = 3223519249, // 0xC0230011
			STATUS_NDIS_INVALID_LENGTH = 3223519252, // 0xC0230014
			STATUS_NDIS_INVALID_DATA = 3223519253, // 0xC0230015
			STATUS_NDIS_BUFFER_TOO_SHORT = 3223519254, // 0xC0230016
			STATUS_NDIS_INVALID_OID = 3223519255, // 0xC0230017
			STATUS_NDIS_ADAPTER_REMOVED = 3223519256, // 0xC0230018
			STATUS_NDIS_UNSUPPORTED_MEDIA = 3223519257, // 0xC0230019
			STATUS_NDIS_GROUP_ADDRESS_IN_USE = 3223519258, // 0xC023001A
			STATUS_NDIS_FILE_NOT_FOUND = 3223519259, // 0xC023001B
			STATUS_NDIS_ERROR_READING_FILE = 3223519260, // 0xC023001C
			STATUS_NDIS_ALREADY_MAPPED = 3223519261, // 0xC023001D
			STATUS_NDIS_RESOURCE_CONFLICT = 3223519262, // 0xC023001E
			STATUS_NDIS_MEDIA_DISCONNECTED = 3223519263, // 0xC023001F
			STATUS_NDIS_INVALID_ADDRESS = 3223519266, // 0xC0230022
			STATUS_NDIS_PAUSED = 3223519274, // 0xC023002A
			STATUS_NDIS_INTERFACE_NOT_FOUND = 3223519275, // 0xC023002B
			STATUS_NDIS_UNSUPPORTED_REVISION = 3223519276, // 0xC023002C
			STATUS_NDIS_INVALID_PORT = 3223519277, // 0xC023002D
			STATUS_NDIS_INVALID_PORT_STATE = 3223519278, // 0xC023002E
			STATUS_NDIS_LOW_POWER_STATE = 3223519279, // 0xC023002F
			STATUS_NDIS_REINIT_REQUIRED = 3223519280, // 0xC0230030
			STATUS_NDIS_NOT_SUPPORTED = 3223519419, // 0xC02300BB
			STATUS_NDIS_OFFLOAD_POLICY = 3223523343, // 0xC023100F
			STATUS_NDIS_OFFLOAD_CONNECTION_REJECTED = 3223523346, // 0xC0231012
			STATUS_NDIS_OFFLOAD_PATH_REJECTED = 3223523347, // 0xC0231013
			STATUS_NDIS_DOT11_AUTO_CONFIG_ENABLED = 3223527424, // 0xC0232000
			STATUS_NDIS_DOT11_MEDIA_IN_USE = 3223527425, // 0xC0232001
			STATUS_NDIS_DOT11_POWER_STATE_INVALID = 3223527426, // 0xC0232002
			STATUS_NDIS_PM_WOL_PATTERN_LIST_FULL = 3223527427, // 0xC0232003
			STATUS_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL = 3223527428, // 0xC0232004
			STATUS_TPM_ERROR_MASK = 3223912448, // 0xC0290000
			STATUS_TPM_AUTHFAIL = 3223912449, // 0xC0290001
			STATUS_TPM_BADINDEX = 3223912450, // 0xC0290002
			STATUS_TPM_BAD_PARAMETER = 3223912451, // 0xC0290003
			STATUS_TPM_AUDITFAILURE = 3223912452, // 0xC0290004
			STATUS_TPM_CLEAR_DISABLED = 3223912453, // 0xC0290005
			STATUS_TPM_DEACTIVATED = 3223912454, // 0xC0290006
			STATUS_TPM_DISABLED = 3223912455, // 0xC0290007
			STATUS_TPM_DISABLED_CMD = 3223912456, // 0xC0290008
			STATUS_TPM_FAIL = 3223912457, // 0xC0290009
			STATUS_TPM_BAD_ORDINAL = 3223912458, // 0xC029000A
			STATUS_TPM_INSTALL_DISABLED = 3223912459, // 0xC029000B
			STATUS_TPM_INVALID_KEYHANDLE = 3223912460, // 0xC029000C
			STATUS_TPM_KEYNOTFOUND = 3223912461, // 0xC029000D
			STATUS_TPM_INAPPROPRIATE_ENC = 3223912462, // 0xC029000E
			STATUS_TPM_MIGRATEFAIL = 3223912463, // 0xC029000F
			STATUS_TPM_INVALID_PCR_INFO = 3223912464, // 0xC0290010
			STATUS_TPM_NOSPACE = 3223912465, // 0xC0290011
			STATUS_TPM_NOSRK = 3223912466, // 0xC0290012
			STATUS_TPM_NOTSEALED_BLOB = 3223912467, // 0xC0290013
			STATUS_TPM_OWNER_SET = 3223912468, // 0xC0290014
			STATUS_TPM_RESOURCES = 3223912469, // 0xC0290015
			STATUS_TPM_SHORTRANDOM = 3223912470, // 0xC0290016
			STATUS_TPM_SIZE = 3223912471, // 0xC0290017
			STATUS_TPM_WRONGPCRVAL = 3223912472, // 0xC0290018
			STATUS_TPM_BAD_PARAM_SIZE = 3223912473, // 0xC0290019
			STATUS_TPM_SHA_THREAD = 3223912474, // 0xC029001A
			STATUS_TPM_SHA_ERROR = 3223912475, // 0xC029001B
			STATUS_TPM_FAILEDSELFTEST = 3223912476, // 0xC029001C
			STATUS_TPM_AUTH2FAIL = 3223912477, // 0xC029001D
			STATUS_TPM_BADTAG = 3223912478, // 0xC029001E
			STATUS_TPM_IOERROR = 3223912479, // 0xC029001F
			STATUS_TPM_ENCRYPT_ERROR = 3223912480, // 0xC0290020
			STATUS_TPM_DECRYPT_ERROR = 3223912481, // 0xC0290021
			STATUS_TPM_INVALID_AUTHHANDLE = 3223912482, // 0xC0290022
			STATUS_TPM_NO_ENDORSEMENT = 3223912483, // 0xC0290023
			STATUS_TPM_INVALID_KEYUSAGE = 3223912484, // 0xC0290024
			STATUS_TPM_WRONG_ENTITYTYPE = 3223912485, // 0xC0290025
			STATUS_TPM_INVALID_POSTINIT = 3223912486, // 0xC0290026
			STATUS_TPM_INAPPROPRIATE_SIG = 3223912487, // 0xC0290027
			STATUS_TPM_BAD_KEY_PROPERTY = 3223912488, // 0xC0290028
			STATUS_TPM_BAD_MIGRATION = 3223912489, // 0xC0290029
			STATUS_TPM_BAD_SCHEME = 3223912490, // 0xC029002A
			STATUS_TPM_BAD_DATASIZE = 3223912491, // 0xC029002B
			STATUS_TPM_BAD_MODE = 3223912492, // 0xC029002C
			STATUS_TPM_BAD_PRESENCE = 3223912493, // 0xC029002D
			STATUS_TPM_BAD_VERSION = 3223912494, // 0xC029002E
			STATUS_TPM_NO_WRAP_TRANSPORT = 3223912495, // 0xC029002F
			STATUS_TPM_AUDITFAIL_UNSUCCESSFUL = 3223912496, // 0xC0290030
			STATUS_TPM_AUDITFAIL_SUCCESSFUL = 3223912497, // 0xC0290031
			STATUS_TPM_NOTRESETABLE = 3223912498, // 0xC0290032
			STATUS_TPM_NOTLOCAL = 3223912499, // 0xC0290033
			STATUS_TPM_BAD_TYPE = 3223912500, // 0xC0290034
			STATUS_TPM_INVALID_RESOURCE = 3223912501, // 0xC0290035
			STATUS_TPM_NOTFIPS = 3223912502, // 0xC0290036
			STATUS_TPM_INVALID_FAMILY = 3223912503, // 0xC0290037
			STATUS_TPM_NO_NV_PERMISSION = 3223912504, // 0xC0290038
			STATUS_TPM_REQUIRES_SIGN = 3223912505, // 0xC0290039
			STATUS_TPM_KEY_NOTSUPPORTED = 3223912506, // 0xC029003A
			STATUS_TPM_AUTH_CONFLICT = 3223912507, // 0xC029003B
			STATUS_TPM_AREA_LOCKED = 3223912508, // 0xC029003C
			STATUS_TPM_BAD_LOCALITY = 3223912509, // 0xC029003D
			STATUS_TPM_READ_ONLY = 3223912510, // 0xC029003E
			STATUS_TPM_PER_NOWRITE = 3223912511, // 0xC029003F
			STATUS_TPM_FAMILYCOUNT = 3223912512, // 0xC0290040
			STATUS_TPM_WRITE_LOCKED = 3223912513, // 0xC0290041
			STATUS_TPM_BAD_ATTRIBUTES = 3223912514, // 0xC0290042
			STATUS_TPM_INVALID_STRUCTURE = 3223912515, // 0xC0290043
			STATUS_TPM_KEY_OWNER_CONTROL = 3223912516, // 0xC0290044
			STATUS_TPM_BAD_COUNTER = 3223912517, // 0xC0290045
			STATUS_TPM_NOT_FULLWRITE = 3223912518, // 0xC0290046
			STATUS_TPM_CONTEXT_GAP = 3223912519, // 0xC0290047
			STATUS_TPM_MAXNVWRITES = 3223912520, // 0xC0290048
			STATUS_TPM_NOOPERATOR = 3223912521, // 0xC0290049
			STATUS_TPM_RESOURCEMISSING = 3223912522, // 0xC029004A
			STATUS_TPM_DELEGATE_LOCK = 3223912523, // 0xC029004B
			STATUS_TPM_DELEGATE_FAMILY = 3223912524, // 0xC029004C
			STATUS_TPM_DELEGATE_ADMIN = 3223912525, // 0xC029004D
			STATUS_TPM_TRANSPORT_NOTEXCLUSIVE = 3223912526, // 0xC029004E
			STATUS_TPM_OWNER_CONTROL = 3223912527, // 0xC029004F
			STATUS_TPM_DAA_RESOURCES = 3223912528, // 0xC0290050
			STATUS_TPM_DAA_INPUT_DATA0 = 3223912529, // 0xC0290051
			STATUS_TPM_DAA_INPUT_DATA1 = 3223912530, // 0xC0290052
			STATUS_TPM_DAA_ISSUER_SETTINGS = 3223912531, // 0xC0290053
			STATUS_TPM_DAA_TPM_SETTINGS = 3223912532, // 0xC0290054
			STATUS_TPM_DAA_STAGE = 3223912533, // 0xC0290055
			STATUS_TPM_DAA_ISSUER_VALIDITY = 3223912534, // 0xC0290056
			STATUS_TPM_DAA_WRONG_W = 3223912535, // 0xC0290057
			STATUS_TPM_BAD_HANDLE = 3223912536, // 0xC0290058
			STATUS_TPM_BAD_DELEGATE = 3223912537, // 0xC0290059
			STATUS_TPM_BADCONTEXT = 3223912538, // 0xC029005A
			STATUS_TPM_TOOMANYCONTEXTS = 3223912539, // 0xC029005B
			STATUS_TPM_MA_TICKET_SIGNATURE = 3223912540, // 0xC029005C
			STATUS_TPM_MA_DESTINATION = 3223912541, // 0xC029005D
			STATUS_TPM_MA_SOURCE = 3223912542, // 0xC029005E
			STATUS_TPM_MA_AUTHORITY = 3223912543, // 0xC029005F
			STATUS_TPM_PERMANENTEK = 3223912545, // 0xC0290061
			STATUS_TPM_BAD_SIGNATURE = 3223912546, // 0xC0290062
			STATUS_TPM_NOCONTEXTSPACE = 3223912547, // 0xC0290063
			STATUS_TPM_COMMAND_BLOCKED = 3223913472, // 0xC0290400
			STATUS_TPM_INVALID_HANDLE = 3223913473, // 0xC0290401
			STATUS_TPM_DUPLICATE_VHANDLE = 3223913474, // 0xC0290402
			STATUS_TPM_EMBEDDED_COMMAND_BLOCKED = 3223913475, // 0xC0290403
			STATUS_TPM_EMBEDDED_COMMAND_UNSUPPORTED = 3223913476, // 0xC0290404
			STATUS_TPM_RETRY = 3223914496, // 0xC0290800
			STATUS_TPM_NEEDS_SELFTEST = 3223914497, // 0xC0290801
			STATUS_TPM_DOING_SELFTEST = 3223914498, // 0xC0290802
			STATUS_TPM_DEFEND_LOCK_RUNNING = 3223914499, // 0xC0290803
			STATUS_TPM_COMMAND_CANCELED = 3223916545, // 0xC0291001
			STATUS_TPM_TOO_MANY_CONTEXTS = 3223916546, // 0xC0291002
			STATUS_TPM_NOT_FOUND = 3223916547, // 0xC0291003
			STATUS_TPM_ACCESS_DENIED = 3223916548, // 0xC0291004
			STATUS_TPM_INSUFFICIENT_BUFFER = 3223916549, // 0xC0291005
			STATUS_TPM_PPI_FUNCTION_UNSUPPORTED = 3223916550, // 0xC0291006
			STATUS_PCP_ERROR_MASK = 3223920640, // 0xC0292000
			STATUS_PCP_DEVICE_NOT_READY = 3223920641, // 0xC0292001
			STATUS_PCP_INVALID_HANDLE = 3223920642, // 0xC0292002
			STATUS_PCP_INVALID_PARAMETER = 3223920643, // 0xC0292003
			STATUS_PCP_FLAG_NOT_SUPPORTED = 3223920644, // 0xC0292004
			STATUS_PCP_NOT_SUPPORTED = 3223920645, // 0xC0292005
			STATUS_PCP_BUFFER_TOO_SMALL = 3223920646, // 0xC0292006
			STATUS_PCP_INTERNAL_ERROR = 3223920647, // 0xC0292007
			STATUS_PCP_AUTHENTICATION_FAILED = 3223920648, // 0xC0292008
			STATUS_PCP_AUTHENTICATION_IGNORED = 3223920649, // 0xC0292009
			STATUS_PCP_POLICY_NOT_FOUND = 3223920650, // 0xC029200A
			STATUS_PCP_PROFILE_NOT_FOUND = 3223920651, // 0xC029200B
			STATUS_PCP_VALIDATION_FAILED = 3223920652, // 0xC029200C
			STATUS_PCP_DEVICE_NOT_FOUND = 3223920653, // 0xC029200D
			STATUS_HV_INVALID_HYPERCALL_CODE = 3224698882, // 0xC0350002
			STATUS_HV_INVALID_HYPERCALL_INPUT = 3224698883, // 0xC0350003
			STATUS_HV_INVALID_ALIGNMENT = 3224698884, // 0xC0350004
			STATUS_HV_INVALID_PARAMETER = 3224698885, // 0xC0350005
			STATUS_HV_ACCESS_DENIED = 3224698886, // 0xC0350006
			STATUS_HV_INVALID_PARTITION_STATE = 3224698887, // 0xC0350007
			STATUS_HV_OPERATION_DENIED = 3224698888, // 0xC0350008
			STATUS_HV_UNKNOWN_PROPERTY = 3224698889, // 0xC0350009
			STATUS_HV_PROPERTY_VALUE_OUT_OF_RANGE = 3224698890, // 0xC035000A
			STATUS_HV_INSUFFICIENT_MEMORY = 3224698891, // 0xC035000B
			STATUS_HV_PARTITION_TOO_DEEP = 3224698892, // 0xC035000C
			STATUS_HV_INVALID_PARTITION_ID = 3224698893, // 0xC035000D
			STATUS_HV_INVALID_VP_INDEX = 3224698894, // 0xC035000E
			STATUS_HV_INVALID_PORT_ID = 3224698897, // 0xC0350011
			STATUS_HV_INVALID_CONNECTION_ID = 3224698898, // 0xC0350012
			STATUS_HV_INSUFFICIENT_BUFFERS = 3224698899, // 0xC0350013
			STATUS_HV_NOT_ACKNOWLEDGED = 3224698900, // 0xC0350014
			STATUS_HV_ACKNOWLEDGED = 3224698902, // 0xC0350016
			STATUS_HV_INVALID_SAVE_RESTORE_STATE = 3224698903, // 0xC0350017
			STATUS_HV_INVALID_SYNIC_STATE = 3224698904, // 0xC0350018
			STATUS_HV_OBJECT_IN_USE = 3224698905, // 0xC0350019
			STATUS_HV_INVALID_PROXIMITY_DOMAIN_INFO = 3224698906, // 0xC035001A
			STATUS_HV_NO_DATA = 3224698907, // 0xC035001B
			STATUS_HV_INACTIVE = 3224698908, // 0xC035001C
			STATUS_HV_NO_RESOURCES = 3224698909, // 0xC035001D
			STATUS_HV_FEATURE_UNAVAILABLE = 3224698910, // 0xC035001E
			STATUS_HV_INSUFFICIENT_BUFFER = 3224698931, // 0xC0350033
			STATUS_HV_INSUFFICIENT_DEVICE_DOMAINS = 3224698936, // 0xC0350038
			STATUS_HV_INVALID_LP_INDEX = 3224698945, // 0xC0350041
			STATUS_HV_NOT_PRESENT = 3224702976, // 0xC0351000
			STATUS_IPSEC_BAD_SPI = 3224764417, // 0xC0360001
			STATUS_IPSEC_SA_LIFETIME_EXPIRED = 3224764418, // 0xC0360002
			STATUS_IPSEC_WRONG_SA = 3224764419, // 0xC0360003
			STATUS_IPSEC_REPLAY_CHECK_FAILED = 3224764420, // 0xC0360004
			STATUS_IPSEC_INVALID_PACKET = 3224764421, // 0xC0360005
			STATUS_IPSEC_INTEGRITY_CHECK_FAILED = 3224764422, // 0xC0360006
			STATUS_IPSEC_CLEAR_TEXT_DROP = 3224764423, // 0xC0360007
			STATUS_IPSEC_AUTH_FIREWALL_DROP = 3224764424, // 0xC0360008
			STATUS_IPSEC_THROTTLE_DROP = 3224764425, // 0xC0360009
			STATUS_IPSEC_DOSP_BLOCK = 3224797184, // 0xC0368000
			STATUS_IPSEC_DOSP_RECEIVED_MULTICAST = 3224797185, // 0xC0368001
			STATUS_IPSEC_DOSP_INVALID_PACKET = 3224797186, // 0xC0368002
			STATUS_IPSEC_DOSP_STATE_LOOKUP_FAILED = 3224797187, // 0xC0368003
			STATUS_IPSEC_DOSP_MAX_ENTRIES = 3224797188, // 0xC0368004
			STATUS_IPSEC_DOSP_KEYMOD_NOT_ALLOWED = 3224797189, // 0xC0368005
			STATUS_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES = 3224797190, // 0xC0368006
			STATUS_VID_DUPLICATE_HANDLER = 3224829953, // 0xC0370001
			STATUS_VID_TOO_MANY_HANDLERS = 3224829954, // 0xC0370002
			STATUS_VID_QUEUE_FULL = 3224829955, // 0xC0370003
			STATUS_VID_HANDLER_NOT_PRESENT = 3224829956, // 0xC0370004
			STATUS_VID_INVALID_OBJECT_NAME = 3224829957, // 0xC0370005
			STATUS_VID_PARTITION_NAME_TOO_LONG = 3224829958, // 0xC0370006
			STATUS_VID_MESSAGE_QUEUE_NAME_TOO_LONG = 3224829959, // 0xC0370007
			STATUS_VID_PARTITION_ALREADY_EXISTS = 3224829960, // 0xC0370008
			STATUS_VID_PARTITION_DOES_NOT_EXIST = 3224829961, // 0xC0370009
			STATUS_VID_PARTITION_NAME_NOT_FOUND = 3224829962, // 0xC037000A
			STATUS_VID_MESSAGE_QUEUE_ALREADY_EXISTS = 3224829963, // 0xC037000B
			STATUS_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT = 3224829964, // 0xC037000C
			STATUS_VID_MB_STILL_REFERENCED = 3224829965, // 0xC037000D
			STATUS_VID_CHILD_GPA_PAGE_SET_CORRUPTED = 3224829966, // 0xC037000E
			STATUS_VID_INVALID_NUMA_SETTINGS = 3224829967, // 0xC037000F
			STATUS_VID_INVALID_NUMA_NODE_INDEX = 3224829968, // 0xC0370010
			STATUS_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED = 3224829969, // 0xC0370011
			STATUS_VID_INVALID_MEMORY_BLOCK_HANDLE = 3224829970, // 0xC0370012
			STATUS_VID_PAGE_RANGE_OVERFLOW = 3224829971, // 0xC0370013
			STATUS_VID_INVALID_MESSAGE_QUEUE_HANDLE = 3224829972, // 0xC0370014
			STATUS_VID_INVALID_GPA_RANGE_HANDLE = 3224829973, // 0xC0370015
			STATUS_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE = 3224829974, // 0xC0370016
			STATUS_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED = 3224829975, // 0xC0370017
			STATUS_VID_INVALID_PPM_HANDLE = 3224829976, // 0xC0370018
			STATUS_VID_MBPS_ARE_LOCKED = 3224829977, // 0xC0370019
			STATUS_VID_MESSAGE_QUEUE_CLOSED = 3224829978, // 0xC037001A
			STATUS_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED = 3224829979, // 0xC037001B
			STATUS_VID_STOP_PENDING = 3224829980, // 0xC037001C
			STATUS_VID_INVALID_PROCESSOR_STATE = 3224829981, // 0xC037001D
			STATUS_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT = 3224829982, // 0xC037001E
			STATUS_VID_KM_INTERFACE_ALREADY_INITIALIZED = 3224829983, // 0xC037001F
			STATUS_VID_MB_PROPERTY_ALREADY_SET_RESET = 3224829984, // 0xC0370020
			STATUS_VID_MMIO_RANGE_DESTROYED = 3224829985, // 0xC0370021
			STATUS_VID_INVALID_CHILD_GPA_PAGE_SET = 3224829986, // 0xC0370022
			STATUS_VID_RESERVE_PAGE_SET_IS_BEING_USED = 3224829987, // 0xC0370023
			STATUS_VID_RESERVE_PAGE_SET_TOO_SMALL = 3224829988, // 0xC0370024
			STATUS_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE = 3224829989, // 0xC0370025
			STATUS_VID_MBP_COUNT_EXCEEDED_LIMIT = 3224829990, // 0xC0370026
			STATUS_VID_SAVED_STATE_CORRUPT = 3224829991, // 0xC0370027
			STATUS_VID_SAVED_STATE_UNRECOGNIZED_ITEM = 3224829992, // 0xC0370028
			STATUS_VID_SAVED_STATE_INCOMPATIBLE = 3224829993, // 0xC0370029
			STATUS_VOLMGR_DATABASE_FULL = 3224895489, // 0xC0380001
			STATUS_VOLMGR_DISK_CONFIGURATION_CORRUPTED = 3224895490, // 0xC0380002
			STATUS_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC = 3224895491, // 0xC0380003
			STATUS_VOLMGR_PACK_CONFIG_UPDATE_FAILED = 3224895492, // 0xC0380004
			STATUS_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME = 3224895493, // 0xC0380005
			STATUS_VOLMGR_DISK_DUPLICATE = 3224895494, // 0xC0380006
			STATUS_VOLMGR_DISK_DYNAMIC = 3224895495, // 0xC0380007
			STATUS_VOLMGR_DISK_ID_INVALID = 3224895496, // 0xC0380008
			STATUS_VOLMGR_DISK_INVALID = 3224895497, // 0xC0380009
			STATUS_VOLMGR_DISK_LAST_VOTER = 3224895498, // 0xC038000A
			STATUS_VOLMGR_DISK_LAYOUT_INVALID = 3224895499, // 0xC038000B
			STATUS_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS = 3224895500, // 0xC038000C
			STATUS_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED = 3224895501, // 0xC038000D
			STATUS_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL = 3224895502, // 0xC038000E
			STATUS_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS = 3224895503, // 0xC038000F
			STATUS_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS = 3224895504, // 0xC0380010
			STATUS_VOLMGR_DISK_MISSING = 3224895505, // 0xC0380011
			STATUS_VOLMGR_DISK_NOT_EMPTY = 3224895506, // 0xC0380012
			STATUS_VOLMGR_DISK_NOT_ENOUGH_SPACE = 3224895507, // 0xC0380013
			STATUS_VOLMGR_DISK_REVECTORING_FAILED = 3224895508, // 0xC0380014
			STATUS_VOLMGR_DISK_SECTOR_SIZE_INVALID = 3224895509, // 0xC0380015
			STATUS_VOLMGR_DISK_SET_NOT_CONTAINED = 3224895510, // 0xC0380016
			STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS = 3224895511, // 0xC0380017
			STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES = 3224895512, // 0xC0380018
			STATUS_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED = 3224895513, // 0xC0380019
			STATUS_VOLMGR_EXTENT_ALREADY_USED = 3224895514, // 0xC038001A
			STATUS_VOLMGR_EXTENT_NOT_CONTIGUOUS = 3224895515, // 0xC038001B
			STATUS_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION = 3224895516, // 0xC038001C
			STATUS_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED = 3224895517, // 0xC038001D
			STATUS_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION = 3224895518, // 0xC038001E
			STATUS_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH = 3224895519, // 0xC038001F
			STATUS_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED = 3224895520, // 0xC0380020
			STATUS_VOLMGR_INTERLEAVE_LENGTH_INVALID = 3224895521, // 0xC0380021
			STATUS_VOLMGR_MAXIMUM_REGISTERED_USERS = 3224895522, // 0xC0380022
			STATUS_VOLMGR_MEMBER_IN_SYNC = 3224895523, // 0xC0380023
			STATUS_VOLMGR_MEMBER_INDEX_DUPLICATE = 3224895524, // 0xC0380024
			STATUS_VOLMGR_MEMBER_INDEX_INVALID = 3224895525, // 0xC0380025
			STATUS_VOLMGR_MEMBER_MISSING = 3224895526, // 0xC0380026
			STATUS_VOLMGR_MEMBER_NOT_DETACHED = 3224895527, // 0xC0380027
			STATUS_VOLMGR_MEMBER_REGENERATING = 3224895528, // 0xC0380028
			STATUS_VOLMGR_ALL_DISKS_FAILED = 3224895529, // 0xC0380029
			STATUS_VOLMGR_NO_REGISTERED_USERS = 3224895530, // 0xC038002A
			STATUS_VOLMGR_NO_SUCH_USER = 3224895531, // 0xC038002B
			STATUS_VOLMGR_NOTIFICATION_RESET = 3224895532, // 0xC038002C
			STATUS_VOLMGR_NUMBER_OF_MEMBERS_INVALID = 3224895533, // 0xC038002D
			STATUS_VOLMGR_NUMBER_OF_PLEXES_INVALID = 3224895534, // 0xC038002E
			STATUS_VOLMGR_PACK_DUPLICATE = 3224895535, // 0xC038002F
			STATUS_VOLMGR_PACK_ID_INVALID = 3224895536, // 0xC0380030
			STATUS_VOLMGR_PACK_INVALID = 3224895537, // 0xC0380031
			STATUS_VOLMGR_PACK_NAME_INVALID = 3224895538, // 0xC0380032
			STATUS_VOLMGR_PACK_OFFLINE = 3224895539, // 0xC0380033
			STATUS_VOLMGR_PACK_HAS_QUORUM = 3224895540, // 0xC0380034
			STATUS_VOLMGR_PACK_WITHOUT_QUORUM = 3224895541, // 0xC0380035
			STATUS_VOLMGR_PARTITION_STYLE_INVALID = 3224895542, // 0xC0380036
			STATUS_VOLMGR_PARTITION_UPDATE_FAILED = 3224895543, // 0xC0380037
			STATUS_VOLMGR_PLEX_IN_SYNC = 3224895544, // 0xC0380038
			STATUS_VOLMGR_PLEX_INDEX_DUPLICATE = 3224895545, // 0xC0380039
			STATUS_VOLMGR_PLEX_INDEX_INVALID = 3224895546, // 0xC038003A
			STATUS_VOLMGR_PLEX_LAST_ACTIVE = 3224895547, // 0xC038003B
			STATUS_VOLMGR_PLEX_MISSING = 3224895548, // 0xC038003C
			STATUS_VOLMGR_PLEX_REGENERATING = 3224895549, // 0xC038003D
			STATUS_VOLMGR_PLEX_TYPE_INVALID = 3224895550, // 0xC038003E
			STATUS_VOLMGR_PLEX_NOT_RAID5 = 3224895551, // 0xC038003F
			STATUS_VOLMGR_PLEX_NOT_SIMPLE = 3224895552, // 0xC0380040
			STATUS_VOLMGR_STRUCTURE_SIZE_INVALID = 3224895553, // 0xC0380041
			STATUS_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS = 3224895554, // 0xC0380042
			STATUS_VOLMGR_TRANSACTION_IN_PROGRESS = 3224895555, // 0xC0380043
			STATUS_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE = 3224895556, // 0xC0380044
			STATUS_VOLMGR_VOLUME_CONTAINS_MISSING_DISK = 3224895557, // 0xC0380045
			STATUS_VOLMGR_VOLUME_ID_INVALID = 3224895558, // 0xC0380046
			STATUS_VOLMGR_VOLUME_LENGTH_INVALID = 3224895559, // 0xC0380047
			STATUS_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE = 3224895560, // 0xC0380048
			STATUS_VOLMGR_VOLUME_NOT_MIRRORED = 3224895561, // 0xC0380049
			STATUS_VOLMGR_VOLUME_NOT_RETAINED = 3224895562, // 0xC038004A
			STATUS_VOLMGR_VOLUME_OFFLINE = 3224895563, // 0xC038004B
			STATUS_VOLMGR_VOLUME_RETAINED = 3224895564, // 0xC038004C
			STATUS_VOLMGR_NUMBER_OF_EXTENTS_INVALID = 3224895565, // 0xC038004D
			STATUS_VOLMGR_DIFFERENT_SECTOR_SIZE = 3224895566, // 0xC038004E
			STATUS_VOLMGR_BAD_BOOT_DISK = 3224895567, // 0xC038004F
			STATUS_VOLMGR_PACK_CONFIG_OFFLINE = 3224895568, // 0xC0380050
			STATUS_VOLMGR_PACK_CONFIG_ONLINE = 3224895569, // 0xC0380051
			STATUS_VOLMGR_NOT_PRIMARY_PACK = 3224895570, // 0xC0380052
			STATUS_VOLMGR_PACK_LOG_UPDATE_FAILED = 3224895571, // 0xC0380053
			STATUS_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID = 3224895572, // 0xC0380054
			STATUS_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID = 3224895573, // 0xC0380055
			STATUS_VOLMGR_VOLUME_MIRRORED = 3224895574, // 0xC0380056
			STATUS_VOLMGR_PLEX_NOT_SIMPLE_SPANNED = 3224895575, // 0xC0380057
			STATUS_VOLMGR_NO_VALID_LOG_COPIES = 3224895576, // 0xC0380058
			STATUS_VOLMGR_PRIMARY_PACK_PRESENT = 3224895577, // 0xC0380059
			STATUS_VOLMGR_NUMBER_OF_DISKS_INVALID = 3224895578, // 0xC038005A
			STATUS_VOLMGR_MIRROR_NOT_SUPPORTED = 3224895579, // 0xC038005B
			STATUS_VOLMGR_RAID5_NOT_SUPPORTED = 3224895580, // 0xC038005C
			STATUS_BCD_TOO_MANY_ELEMENTS = 3224961026, // 0xC0390002
			STATUS_VHD_DRIVE_FOOTER_MISSING = 3225026561, // 0xC03A0001
			STATUS_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH = 3225026562, // 0xC03A0002
			STATUS_VHD_DRIVE_FOOTER_CORRUPT = 3225026563, // 0xC03A0003
			STATUS_VHD_FORMAT_UNKNOWN = 3225026564, // 0xC03A0004
			STATUS_VHD_FORMAT_UNSUPPORTED_VERSION = 3225026565, // 0xC03A0005
			STATUS_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH = 3225026566, // 0xC03A0006
			STATUS_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION = 3225026567, // 0xC03A0007
			STATUS_VHD_SPARSE_HEADER_CORRUPT = 3225026568, // 0xC03A0008
			STATUS_VHD_BLOCK_ALLOCATION_FAILURE = 3225026569, // 0xC03A0009
			STATUS_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT = 3225026570, // 0xC03A000A
			STATUS_VHD_INVALID_BLOCK_SIZE = 3225026571, // 0xC03A000B
			STATUS_VHD_BITMAP_MISMATCH = 3225026572, // 0xC03A000C
			STATUS_VHD_PARENT_VHD_NOT_FOUND = 3225026573, // 0xC03A000D
			STATUS_VHD_CHILD_PARENT_ID_MISMATCH = 3225026574, // 0xC03A000E
			STATUS_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH = 3225026575, // 0xC03A000F
			STATUS_VHD_METADATA_READ_FAILURE = 3225026576, // 0xC03A0010
			STATUS_VHD_METADATA_WRITE_FAILURE = 3225026577, // 0xC03A0011
			STATUS_VHD_INVALID_SIZE = 3225026578, // 0xC03A0012
			STATUS_VHD_INVALID_FILE_SIZE = 3225026579, // 0xC03A0013
			STATUS_VIRTDISK_PROVIDER_NOT_FOUND = 3225026580, // 0xC03A0014
			STATUS_VIRTDISK_NOT_VIRTUAL_DISK = 3225026581, // 0xC03A0015
			STATUS_VHD_PARENT_VHD_ACCESS_DENIED = 3225026582, // 0xC03A0016
			STATUS_VHD_CHILD_PARENT_SIZE_MISMATCH = 3225026583, // 0xC03A0017
			STATUS_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED = 3225026584, // 0xC03A0018
			STATUS_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT = 3225026585, // 0xC03A0019
			STATUS_VIRTUAL_DISK_LIMITATION = 3225026586, // 0xC03A001A
			STATUS_VHD_INVALID_TYPE = 3225026587, // 0xC03A001B
			STATUS_VHD_INVALID_STATE = 3225026588, // 0xC03A001C
			STATUS_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE = 3225026589, // 0xC03A001D
			STATUS_VIRTDISK_DISK_ALREADY_OWNED = 3225026590, // 0xC03A001E
			STATUS_VIRTDISK_DISK_ONLINE_AND_WRITABLE = 3225026591, // 0xC03A001F
			STATUS_CTLOG_TRACKING_NOT_INITIALIZED = 3225026592, // 0xC03A0020
			STATUS_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE = 3225026593, // 0xC03A0021
			STATUS_CTLOG_VHD_CHANGED_OFFLINE = 3225026594, // 0xC03A0022
			STATUS_CTLOG_INVALID_TRACKING_STATE = 3225026595, // 0xC03A0023
			STATUS_CTLOG_INCONSISTENT_TRACKING_FILE = 3225026596, // 0xC03A0024
			STATUS_VHD_METADATA_FULL = 3225026600, // 0xC03A0028
			STATUS_RKF_KEY_NOT_FOUND = 3225419777, // 0xC0400001
			STATUS_RKF_DUPLICATE_KEY = 3225419778, // 0xC0400002
			STATUS_RKF_BLOB_FULL = 3225419779, // 0xC0400003
			STATUS_RKF_STORE_FULL = 3225419780, // 0xC0400004
			STATUS_RKF_FILE_BLOCKED = 3225419781, // 0xC0400005
			STATUS_RKF_ACTIVE_KEY = 3225419782, // 0xC0400006
			STATUS_RDBSS_RESTART_OPERATION = 3225485313, // 0xC0410001
			STATUS_RDBSS_CONTINUE_OPERATION = 3225485314, // 0xC0410002
			STATUS_RDBSS_POST_OPERATION = 3225485315, // 0xC0410003
			STATUS_BTH_ATT_INVALID_HANDLE = 3225550849, // 0xC0420001
			STATUS_BTH_ATT_READ_NOT_PERMITTED = 3225550850, // 0xC0420002
			STATUS_BTH_ATT_WRITE_NOT_PERMITTED = 3225550851, // 0xC0420003
			STATUS_BTH_ATT_INVALID_PDU = 3225550852, // 0xC0420004
			STATUS_BTH_ATT_INSUFFICIENT_AUTHENTICATION = 3225550853, // 0xC0420005
			STATUS_BTH_ATT_REQUEST_NOT_SUPPORTED = 3225550854, // 0xC0420006
			STATUS_BTH_ATT_INVALID_OFFSET = 3225550855, // 0xC0420007
			STATUS_BTH_ATT_INSUFFICIENT_AUTHORIZATION = 3225550856, // 0xC0420008
			STATUS_BTH_ATT_PREPARE_QUEUE_FULL = 3225550857, // 0xC0420009
			STATUS_BTH_ATT_ATTRIBUTE_NOT_FOUND = 3225550858, // 0xC042000A
			STATUS_BTH_ATT_ATTRIBUTE_NOT_LONG = 3225550859, // 0xC042000B
			STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE = 3225550860, // 0xC042000C
			STATUS_BTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH = 3225550861, // 0xC042000D
			STATUS_BTH_ATT_UNLIKELY = 3225550862, // 0xC042000E
			STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION = 3225550863, // 0xC042000F
			STATUS_BTH_ATT_UNSUPPORTED_GROUP_TYPE = 3225550864, // 0xC0420010
			STATUS_BTH_ATT_INSUFFICIENT_RESOURCES = 3225550865, // 0xC0420011
			STATUS_BTH_ATT_UNKNOWN_ERROR = 3225554944, // 0xC0421000
			STATUS_SECUREBOOT_ROLLBACK_DETECTED = 3225616385, // 0xC0430001
			STATUS_SECUREBOOT_POLICY_VIOLATION = 3225616386, // 0xC0430002
			STATUS_SECUREBOOT_INVALID_POLICY = 3225616387, // 0xC0430003
			STATUS_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND = 3225616388, // 0xC0430004
			STATUS_SECUREBOOT_POLICY_NOT_SIGNED = 3225616389, // 0xC0430005
			STATUS_SECUREBOOT_FILE_REPLACED = 3225616391, // 0xC0430007
			STATUS_AUDIO_ENGINE_NODE_NOT_FOUND = 3225681921, // 0xC0440001
			STATUS_HDAUDIO_EMPTY_CONNECTION_LIST = 3225681922, // 0xC0440002
			STATUS_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED = 3225681923, // 0xC0440003
			STATUS_HDAUDIO_NO_LOGICAL_DEVICES_CREATED = 3225681924, // 0xC0440004
			STATUS_HDAUDIO_NULL_LINKED_LIST_ENTRY = 3225681925, // 0xC0440005
			STATUS_VOLSNAP_BOOTFILE_NOT_VALID = 3226468355, // 0xC0500003
			STATUS_IO_PREEMPTED = 3226533889, // 0xC0510001
			STATUS_SVHDX_ERROR_STORED = 3227254784, // 0xC05C0000
			STATUS_SVHDX_ERROR_NOT_AVAILABLE = 3227320064, // 0xC05CFF00
			STATUS_SVHDX_UNIT_ATTENTION_AVAILABLE = 3227320065, // 0xC05CFF01
			STATUS_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED = 3227320066, // 0xC05CFF02
			STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED = 3227320067, // 0xC05CFF03
			STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED = 3227320068, // 0xC05CFF04
			STATUS_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED = 3227320069, // 0xC05CFF05
			STATUS_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED = 3227320070, // 0xC05CFF06
			STATUS_SVHDX_RESERVATION_CONFLICT = 3227320071, // 0xC05CFF07
			STATUS_SVHDX_WRONG_FILE_TYPE = 3227320072, // 0xC05CFF08
			STATUS_SVHDX_VERSION_MISMATCH = 3227320073, // 0xC05CFF09
			STATUS_VHD_SHARED = 3227320074, // 0xC05CFF0A
			STATUS_SPACES_RESILIENCY_TYPE_INVALID = 3236364291, // 0xC0E70003
			STATUS_SPACES_DRIVE_SECTOR_SIZE_INVALID = 3236364292, // 0xC0E70004
			STATUS_SPACES_INTERLEAVE_LENGTH_INVALID = 3236364297, // 0xC0E70009
			STATUS_SPACES_NUMBER_OF_COLUMNS_INVALID = 3236364298, // 0xC0E7000A
			STATUS_SPACES_NOT_ENOUGH_DRIVES = 3236364299, // 0xC0E7000B
		}

		/// <summary>
		/// The <see cref="T:PInvoke.NTSTATUS" /> facility codes.
		/// </summary>
		public enum FacilityCode {
			FACILITY_DEBUGGER = 65536, // 0x00010000
			FACILITY_RPC_RUNTIME = 131072, // 0x00020000
			FACILITY_RPC_STUBS = 196608, // 0x00030000
			FACILITY_IO_ERROR_CODE = 262144, // 0x00040000
			FACILITY_CODCLASS_ERROR_CODE = 393216, // 0x00060000
			FACILITY_NTWIN32 = 458752, // 0x00070000
			FACILITY_NTCERT = 524288, // 0x00080000
			FACILITY_NTSSPI = 589824, // 0x00090000
			FACILITY_TERMINAL_SERVER = 655360, // 0x000A0000
			FACILTIY_MUI_ERROR_CODE = 720896, // 0x000B0000
			FACILITY_USB_ERROR_CODE = 1048576, // 0x00100000
			FACILITY_HID_ERROR_CODE = 1114112, // 0x00110000
			FACILITY_FIREWIRE_ERROR_CODE = 1179648, // 0x00120000
			FACILITY_CLUSTER_ERROR_CODE = 1245184, // 0x00130000
			FACILITY_ACPI_ERROR_CODE = 1310720, // 0x00140000
			FACILITY_SXS_ERROR_CODE = 1376256, // 0x00150000
			FACILITY_TRANSACTION = 1638400, // 0x00190000
			FACILITY_COMMONLOG = 1703936, // 0x001A0000
			FACILITY_VIDEO = 1769472, // 0x001B0000
			FACILITY_FILTER_MANAGER = 1835008, // 0x001C0000
			FACILITY_MONITOR = 1900544, // 0x001D0000
			FACILITY_GRAPHICS_KERNEL = 1966080, // 0x001E0000
			FACILITY_DRIVER_FRAMEWORK = 2097152, // 0x00200000
			FACILITY_FVE_ERROR_CODE = 2162688, // 0x00210000
			FACILITY_FWP_ERROR_CODE = 2228224, // 0x00220000
			FACILITY_NDIS_ERROR_CODE = 2293760, // 0x00230000
			FACILITY_TPM = 2686976, // 0x00290000
			FACILITY_HYPERVISOR = 3473408, // 0x00350000
			FACILITY_IPSEC = 3538944, // 0x00360000
			FACILITY_VIRTUALIZATION = 3604480, // 0x00370000
			FACILITY_VOLMGR = 3670016, // 0x00380000
			FACILITY_BCD_ERROR_CODE = 3735552, // 0x00390000
			FACILITY_WIN32K_NTUSER = 4063232, // 0x003E0000
			FACILITY_WIN32K_NTGDI = 4128768, // 0x003F0000
			FACILITY_RESUME_KEY_FILTER = 4194304, // 0x00400000
			FACILITY_RDBSS = 4259840, // 0x00410000
			FACILITY_BTH_ATT = 4325376, // 0x00420000
			FACILITY_SECUREBOOT = 4390912, // 0x00430000
			FACILITY_AUDIO_KERNEL = 4456448, // 0x00440000
			FACILITY_VOLSNAP = 5242880, // 0x00500000
			FACILITY_SDBUS = 5308416, // 0x00510000
			FACILITY_SHARED_VHDX = 6029312, // 0x005C0000
			FACILITY_INTERIX = 10027008, // 0x00990000
			FACILITY_SPACES = 15138816, // 0x00E70000
			FACILITY_MAXIMUM_VALUE = 15204352, // 0x00E80000
		}

		/// <summary>
		/// The <see cref="T:PInvoke.NTSTATUS" /> severity codes.
		/// </summary>
		public enum SeverityCode : uint {
			STATUS_SEVERITY_SUCCESS = 0,
			STATUS_SEVERITY_INFORMATIONAL = 1073741824, // 0x40000000
			STATUS_SEVERITY_WARNING = 2147483648, // 0x80000000
			STATUS_SEVERITY_ERROR = 3221225472, // 0xC0000000
		}
	}

	/// <summary>
	/// An exception thrown for a failure described by a <see cref="T:PInvoke.NTSTATUS" />.
	/// </summary>
	[Serializable]
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public class NTStatusException : Exception {
		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class.
		/// </summary>
		/// <param name="statusCode">The status code identifying the error.</param>
		public NTStatusException(NTSTATUS statusCode)
			: this(statusCode, NTStatusException.GetMessage(statusCode)) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class.
		/// </summary>
		/// <param name="statusCode">The status code identifying the error.</param>
		/// <param name="message">The exception message (which may be null to use the default).</param>
		public NTStatusException(NTSTATUS statusCode, string message)
			: this(statusCode, message, (Exception) null) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class.
		/// </summary>
		/// <param name="statusCode">The status code identifying the error.</param>
		/// <param name="message">The exception message (which may be null to use the default).</param>
		/// <param name="inner">The inner exception.</param>
		public NTStatusException(NTSTATUS statusCode, string message, Exception inner)
			: base(message ?? NTStatusException.GetMessage(statusCode), inner) {
			this.NativeErrorCode = statusCode;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class
		/// for deserialization.
		/// </summary>
		/// <param name="info">Serialization information.</param>
		/// <param name="context">Streaming context.</param>
		protected NTStatusException(SerializationInfo info, StreamingContext context)
			: base(info, context) {
			this.NativeErrorCode = NTSTATUS.op_Implicit(info.GetUInt32(nameof(NativeErrorCode)));
		}

		/// <summary>
		/// Gets the <see cref="T:PInvoke.NTSTATUS" /> code that identifies the error condition.
		/// </summary>
		public NTSTATUS NativeErrorCode { get; }

		/// <inheritdoc />
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {
			SerializationInfo serializationInfo = info;
			string name = "NativeErrorCode";
			NTSTATUS nativeErrorCode = this.NativeErrorCode;
			int asUint32 = (int) ((NTSTATUS) ref nativeErrorCode ).get_AsUInt32();
			serializationInfo.AddValue(name, (uint) asUint32);
			base.GetObjectData(info, context);
		}

		/// <summary>
		/// Gets the message associated with the given <see cref="T:PInvoke.NTSTATUS" />.
		/// </summary>
		/// <param name="status">The <see cref="T:PInvoke.NTSTATUS" /> for the error.</param>
		/// <returns>The description of the error.</returns>
		private static string GetMessage(NTSTATUS status) {
			string str1 = string.Format("0x{0:X8}", (object) NTSTATUS.op_Explicit(status));
			string name = Enum.GetName(typeof(NTSTATUS.Code), (object) ((NTSTATUS) ref status ).get_AsUInt32());
			string str2 = name == null || !(name != str1)
				? str1
				: string.Format("{0} ({1})", (object) name, (object) str1);
			string str3 = string.Format("NT_STATUS {0}: {1}", (object) NTStatusException.GetSeverityString(status),
				(object) str2);
			string message = status.GetMessage();
			if (message == null)
				return str3;
			return string.Format("{0} ({1})", (object) message, (object) str3);
		}

		private static string GetSeverityString(NTSTATUS status) {
			NTSTATUS.SeverityCode severity = ((NTSTATUS) ref status ).get_Severity();
			if (severity <= 1073741824) {
				if (severity == null)
					return "success";
				if (severity == 1073741824)
					return "information";
			}
			else {
				if (severity == int.MinValue)
					return "warning";
				if (severity == -1073741824)
					return "error";
			}

			return string.Empty;
		}
	}

	/// <summary>
	/// The POINT structure defines the x- and y- coordinates of a point.
	/// </summary>
	public struct POINT {
		/// <summary>The x-coordinate of the point.</summary>
		public int x;

		/// <summary>The x-coordinate of the point.</summary>
		public int y;
	}

	/// <summary>
	/// The RECT structure defines the coordinates of the upper-left and lower-right corners of a rectangle.
	/// </summary>
	/// <remarks>
	/// By convention, the right and bottom edges of the rectangle are normally considered exclusive.
	/// In other words, the pixel whose coordinates are ( right, bottom ) lies immediately outside of the rectangle.
	/// For example, when RECT is passed to the FillRect function, the rectangle is filled up to, but not including,
	/// the right column and bottom row of pixels. This structure is identical to the RECTL structure.
	/// </remarks>
	public struct RECT {
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

	/// <summary>
	/// The RECT structure defines the coordinates of the upper-left and lower-right corners of a rectangle.
	/// </summary>
	/// <remarks>
	/// This structure is used by console functions to specify rectangular areas of console screen buffers,
	/// where the coordinates specify the rows and columns of screen-buffer character cells.
	/// </remarks>
	public struct SMALL_RECT {
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

	/// <summary>Win32 system error codes.</summary>
	public enum Win32ErrorCode {
		ERROR_SUCCESS = 0,
		NERR_Success = 0,
		ERROR_INVALID_FUNCTION = 1,
		ERROR_FILE_NOT_FOUND = 2,
		ERROR_PATH_NOT_FOUND = 3,
		ERROR_TOO_MANY_OPEN_FILES = 4,
		ERROR_ACCESS_DENIED = 5,
		ERROR_INVALID_HANDLE = 6,
		ERROR_ARENA_TRASHED = 7,
		ERROR_NOT_ENOUGH_MEMORY = 8,
		ERROR_INVALID_BLOCK = 9,
		ERROR_BAD_ENVIRONMENT = 10, // 0x0000000A
		ERROR_BAD_FORMAT = 11, // 0x0000000B
		ERROR_INVALID_ACCESS = 12, // 0x0000000C
		ERROR_INVALID_DATA = 13, // 0x0000000D
		ERROR_OUTOFMEMORY = 14, // 0x0000000E
		ERROR_INVALID_DRIVE = 15, // 0x0000000F
		ERROR_CURRENT_DIRECTORY = 16, // 0x00000010
		ERROR_NOT_SAME_DEVICE = 17, // 0x00000011
		ERROR_NO_MORE_FILES = 18, // 0x00000012
		ERROR_WRITE_PROTECT = 19, // 0x00000013
		ERROR_BAD_UNIT = 20, // 0x00000014
		ERROR_NOT_READY = 21, // 0x00000015
		ERROR_BAD_COMMAND = 22, // 0x00000016
		ERROR_CRC = 23, // 0x00000017
		ERROR_BAD_LENGTH = 24, // 0x00000018
		ERROR_SEEK = 25, // 0x00000019
		ERROR_NOT_DOS_DISK = 26, // 0x0000001A
		ERROR_SECTOR_NOT_FOUND = 27, // 0x0000001B
		ERROR_OUT_OF_PAPER = 28, // 0x0000001C
		ERROR_WRITE_FAULT = 29, // 0x0000001D
		ERROR_READ_FAULT = 30, // 0x0000001E
		ERROR_GEN_FAILURE = 31, // 0x0000001F
		ERROR_SHARING_VIOLATION = 32, // 0x00000020
		ERROR_LOCK_VIOLATION = 33, // 0x00000021
		ERROR_WRONG_DISK = 34, // 0x00000022
		ERROR_SHARING_BUFFER_EXCEEDED = 36, // 0x00000024
		ERROR_HANDLE_EOF = 38, // 0x00000026
		ERROR_HANDLE_DISK_FULL = 39, // 0x00000027
		ERROR_NOT_SUPPORTED = 50, // 0x00000032
		ERROR_REM_NOT_LIST = 51, // 0x00000033
		ERROR_DUP_NAME = 52, // 0x00000034
		ERROR_BAD_NETPATH = 53, // 0x00000035
		ERROR_NETWORK_BUSY = 54, // 0x00000036
		ERROR_DEV_NOT_EXIST = 55, // 0x00000037
		ERROR_TOO_MANY_CMDS = 56, // 0x00000038
		ERROR_ADAP_HDW_ERR = 57, // 0x00000039
		ERROR_BAD_NET_RESP = 58, // 0x0000003A
		ERROR_UNEXP_NET_ERR = 59, // 0x0000003B
		ERROR_BAD_REM_ADAP = 60, // 0x0000003C
		ERROR_PRINTQ_FULL = 61, // 0x0000003D
		ERROR_NO_SPOOL_SPACE = 62, // 0x0000003E
		ERROR_PRINT_CANCELLED = 63, // 0x0000003F
		ERROR_NETNAME_DELETED = 64, // 0x00000040
		ERROR_NETWORK_ACCESS_DENIED = 65, // 0x00000041
		ERROR_BAD_DEV_TYPE = 66, // 0x00000042
		ERROR_BAD_NET_NAME = 67, // 0x00000043
		ERROR_TOO_MANY_NAMES = 68, // 0x00000044
		ERROR_TOO_MANY_SESS = 69, // 0x00000045
		ERROR_SHARING_PAUSED = 70, // 0x00000046
		ERROR_REQ_NOT_ACCEP = 71, // 0x00000047
		ERROR_REDIR_PAUSED = 72, // 0x00000048
		ERROR_FILE_EXISTS = 80, // 0x00000050
		ERROR_CANNOT_MAKE = 82, // 0x00000052
		ERROR_FAIL_I24 = 83, // 0x00000053
		ERROR_OUT_OF_STRUCTURES = 84, // 0x00000054
		ERROR_ALREADY_ASSIGNED = 85, // 0x00000055
		ERROR_INVALID_PASSWORD = 86, // 0x00000056
		ERROR_INVALID_PARAMETER = 87, // 0x00000057
		ERROR_NET_WRITE_FAULT = 88, // 0x00000058
		ERROR_NO_PROC_SLOTS = 89, // 0x00000059
		ERROR_TOO_MANY_SEMAPHORES = 100, // 0x00000064
		ERROR_EXCL_SEM_ALREADY_OWNED = 101, // 0x00000065
		ERROR_SEM_IS_SET = 102, // 0x00000066
		ERROR_TOO_MANY_SEM_REQUESTS = 103, // 0x00000067
		ERROR_INVALID_AT_INTERRUPT_TIME = 104, // 0x00000068
		ERROR_SEM_OWNER_DIED = 105, // 0x00000069
		ERROR_SEM_USER_LIMIT = 106, // 0x0000006A
		ERROR_DISK_CHANGE = 107, // 0x0000006B
		ERROR_DRIVE_LOCKED = 108, // 0x0000006C
		ERROR_BROKEN_PIPE = 109, // 0x0000006D
		ERROR_OPEN_FAILED = 110, // 0x0000006E
		ERROR_BUFFER_OVERFLOW = 111, // 0x0000006F
		ERROR_DISK_FULL = 112, // 0x00000070
		ERROR_NO_MORE_SEARCH_HANDLES = 113, // 0x00000071
		ERROR_INVALID_TARGET_HANDLE = 114, // 0x00000072
		ERROR_INVALID_CATEGORY = 117, // 0x00000075
		ERROR_INVALID_VERIFY_SWITCH = 118, // 0x00000076
		ERROR_BAD_DRIVER_LEVEL = 119, // 0x00000077
		ERROR_CALL_NOT_IMPLEMENTED = 120, // 0x00000078
		ERROR_SEM_TIMEOUT = 121, // 0x00000079
		ERROR_INSUFFICIENT_BUFFER = 122, // 0x0000007A
		ERROR_INVALID_NAME = 123, // 0x0000007B
		ERROR_INVALID_LEVEL = 124, // 0x0000007C
		ERROR_NO_VOLUME_LABEL = 125, // 0x0000007D
		ERROR_MOD_NOT_FOUND = 126, // 0x0000007E
		ERROR_PROC_NOT_FOUND = 127, // 0x0000007F
		ERROR_WAIT_NO_CHILDREN = 128, // 0x00000080
		ERROR_CHILD_NOT_COMPLETE = 129, // 0x00000081
		ERROR_DIRECT_ACCESS_HANDLE = 130, // 0x00000082
		ERROR_NEGATIVE_SEEK = 131, // 0x00000083
		ERROR_SEEK_ON_DEVICE = 132, // 0x00000084
		ERROR_IS_JOIN_TARGET = 133, // 0x00000085
		ERROR_IS_JOINED = 134, // 0x00000086
		ERROR_IS_SUBSTED = 135, // 0x00000087
		ERROR_NOT_JOINED = 136, // 0x00000088
		ERROR_NOT_SUBSTED = 137, // 0x00000089
		ERROR_JOIN_TO_JOIN = 138, // 0x0000008A
		ERROR_SUBST_TO_SUBST = 139, // 0x0000008B
		ERROR_JOIN_TO_SUBST = 140, // 0x0000008C
		ERROR_SUBST_TO_JOIN = 141, // 0x0000008D
		ERROR_BUSY_DRIVE = 142, // 0x0000008E
		ERROR_SAME_DRIVE = 143, // 0x0000008F
		ERROR_DIR_NOT_ROOT = 144, // 0x00000090
		ERROR_DIR_NOT_EMPTY = 145, // 0x00000091
		ERROR_IS_SUBST_PATH = 146, // 0x00000092
		ERROR_IS_JOIN_PATH = 147, // 0x00000093
		ERROR_PATH_BUSY = 148, // 0x00000094
		ERROR_IS_SUBST_TARGET = 149, // 0x00000095
		ERROR_SYSTEM_TRACE = 150, // 0x00000096
		ERROR_INVALID_EVENT_COUNT = 151, // 0x00000097
		ERROR_TOO_MANY_MUXWAITERS = 152, // 0x00000098
		ERROR_INVALID_LIST_FORMAT = 153, // 0x00000099
		ERROR_LABEL_TOO_LONG = 154, // 0x0000009A
		ERROR_TOO_MANY_TCBS = 155, // 0x0000009B
		ERROR_SIGNAL_REFUSED = 156, // 0x0000009C
		ERROR_DISCARDED = 157, // 0x0000009D
		ERROR_NOT_LOCKED = 158, // 0x0000009E
		ERROR_BAD_THREADID_ADDR = 159, // 0x0000009F
		ERROR_BAD_ARGUMENTS = 160, // 0x000000A0
		ERROR_BAD_PATHNAME = 161, // 0x000000A1
		ERROR_SIGNAL_PENDING = 162, // 0x000000A2
		ERROR_MAX_THRDS_REACHED = 164, // 0x000000A4
		ERROR_LOCK_FAILED = 167, // 0x000000A7
		ERROR_BUSY = 170, // 0x000000AA
		ERROR_CANCEL_VIOLATION = 173, // 0x000000AD
		ERROR_INVALID_SEGMENT_NUMBER = 180, // 0x000000B4
		ERROR_INVALID_ORDINAL = 182, // 0x000000B6
		ERROR_ALREADY_EXISTS = 183, // 0x000000B7
		ERROR_INVALID_FLAG_NUMBER = 186, // 0x000000BA
		ERROR_SEM_NOT_FOUND = 187, // 0x000000BB
		ERROR_INVALID_STARTING_CODESEG = 188, // 0x000000BC
		ERROR_INVALID_STACKSEG = 189, // 0x000000BD
		ERROR_INVALID_MODULETYPE = 190, // 0x000000BE
		ERROR_INVALID_EXE_SIGNATURE = 191, // 0x000000BF
		ERROR_EXE_MARKED_INVALID = 192, // 0x000000C0
		ERROR_BAD_EXE_FORMAT = 193, // 0x000000C1
		ERROR_ITERATED_DATA_EXCEEDS_64k = 194, // 0x000000C2
		ERROR_INVALID_MINALLOCSIZE = 195, // 0x000000C3
		ERROR_DYNLINK_FROM_INVALID_RING = 196, // 0x000000C4
		ERROR_IOPL_NOT_ENABLED = 197, // 0x000000C5
		ERROR_INVALID_SEGDPL = 198, // 0x000000C6
		ERROR_AUTODATASEG_EXCEEDS_64k = 199, // 0x000000C7
		ERROR_RING2SEG_MUST_BE_MOVABLE = 200, // 0x000000C8
		ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201, // 0x000000C9
		ERROR_INFLOOP_IN_RELOC_CHAIN = 202, // 0x000000CA
		ERROR_ENVVAR_NOT_FOUND = 203, // 0x000000CB
		ERROR_NO_SIGNAL_SENT = 205, // 0x000000CD
		ERROR_FILENAME_EXCED_RANGE = 206, // 0x000000CE
		ERROR_RING2_STACK_IN_USE = 207, // 0x000000CF
		ERROR_META_EXPANSION_TOO_LONG = 208, // 0x000000D0
		ERROR_INVALID_SIGNAL_NUMBER = 209, // 0x000000D1
		ERROR_THREAD_1_INACTIVE = 210, // 0x000000D2
		ERROR_LOCKED = 212, // 0x000000D4
		ERROR_TOO_MANY_MODULES = 214, // 0x000000D6
		ERROR_NESTING_NOT_ALLOWED = 215, // 0x000000D7
		ERROR_EXE_MACHINE_TYPE_MISMATCH = 216, // 0x000000D8
		ERROR_FILE_CHECKED_OUT = 220, // 0x000000DC
		ERROR_CHECKOUT_REQUIRED = 221, // 0x000000DD
		ERROR_BAD_FILE_TYPE = 222, // 0x000000DE
		ERROR_FILE_TOO_LARGE = 223, // 0x000000DF
		ERROR_FORMS_AUTH_REQUIRED = 224, // 0x000000E0
		ERROR_VIRUS_INFECTED = 225, // 0x000000E1
		ERROR_VIRUS_DELETED = 226, // 0x000000E2
		ERROR_PIPE_LOCAL = 229, // 0x000000E5
		ERROR_BAD_PIPE = 230, // 0x000000E6
		ERROR_PIPE_BUSY = 231, // 0x000000E7
		ERROR_NO_DATA = 232, // 0x000000E8
		ERROR_PIPE_NOT_CONNECTED = 233, // 0x000000E9
		ERROR_MORE_DATA = 234, // 0x000000EA
		ERROR_VC_DISCONNECTED = 240, // 0x000000F0
		ERROR_INVALID_EA_NAME = 254, // 0x000000FE
		ERROR_EA_LIST_INCONSISTENT = 255, // 0x000000FF
		WAIT_TIMEOUT = 258, // 0x00000102
		ERROR_NO_MORE_ITEMS = 259, // 0x00000103
		ERROR_CANNOT_COPY = 266, // 0x0000010A
		ERROR_DIRECTORY = 267, // 0x0000010B
		ERROR_EAS_DIDNT_FIT = 275, // 0x00000113
		ERROR_EA_FILE_CORRUPT = 276, // 0x00000114
		ERROR_EA_TABLE_FULL = 277, // 0x00000115
		ERROR_INVALID_EA_HANDLE = 278, // 0x00000116
		ERROR_EAS_NOT_SUPPORTED = 282, // 0x0000011A
		ERROR_NOT_OWNER = 288, // 0x00000120
		ERROR_TOO_MANY_POSTS = 298, // 0x0000012A
		ERROR_PARTIAL_COPY = 299, // 0x0000012B
		ERROR_OPLOCK_NOT_GRANTED = 300, // 0x0000012C
		ERROR_INVALID_OPLOCK_PROTOCOL = 301, // 0x0000012D
		ERROR_DISK_TOO_FRAGMENTED = 302, // 0x0000012E
		ERROR_DELETE_PENDING = 303, // 0x0000012F
		ERROR_INVALID_LOCK_RANGE = 307, // 0x00000133
		ERROR_INVALID_EXCEPTION_HANDLER = 310, // 0x00000136
		ERROR_DUPLICATE_PRIVILEGES = 311, // 0x00000137
		ERROR_NO_RANGES_PROCESSED = 312, // 0x00000138
		ERROR_DISK_RESOURCES_EXHAUSTED = 314, // 0x0000013A
		ERROR_INVALID_TOKEN = 315, // 0x0000013B
		ERROR_MR_MID_NOT_FOUND = 317, // 0x0000013D
		ERROR_SCOPE_NOT_FOUND = 318, // 0x0000013E
		ERROR_UNDEFINED_SCOPE = 319, // 0x0000013F
		ERROR_INVALID_CAP = 320, // 0x00000140
		ERROR_DEVICE_UNREACHABLE = 321, // 0x00000141
		ERROR_DEVICE_NO_RESOURCES = 322, // 0x00000142
		ERROR_DATA_CHECKSUM_ERROR = 323, // 0x00000143
		ERROR_OPERATION_IN_PROGRESS = 329, // 0x00000149
		ERROR_BAD_DEVICE_PATH = 330, // 0x0000014A
		ERROR_TOO_MANY_DESCRIPTORS = 331, // 0x0000014B
		ERROR_SCRUB_DATA_DISABLED = 332, // 0x0000014C
		ERROR_NOT_REDUNDANT_STORAGE = 333, // 0x0000014D
		ERROR_DIRECTORY_NOT_SUPPORTED = 336, // 0x00000150
		ERROR_NOT_READ_FROM_COPY = 337, // 0x00000151
		ERROR_FT_WRITE_FAILURE = 338, // 0x00000152
		ERROR_FT_DI_SCAN_REQUIRED = 339, // 0x00000153
		ERROR_INVALID_PEP_INFO_VERSION = 341, // 0x00000155
		ERROR_BLOCK_TOO_MANY_REFERENCES = 347, // 0x0000015B
		ERROR_FAIL_NOACTION_REBOOT = 350, // 0x0000015E
		ERROR_FAIL_SHUTDOWN = 351, // 0x0000015F
		ERROR_FAIL_RESTART = 352, // 0x00000160
		ERROR_MAX_SESSIONS_REACHED = 353, // 0x00000161
		ERROR_DEVICE_HARDWARE_ERROR = 483, // 0x000001E3
		ERROR_INVALID_ADDRESS = 487, // 0x000001E7
		ERROR_USER_PROFILE_LOAD = 500, // 0x000001F4
		ERROR_ARITHMETIC_OVERFLOW = 534, // 0x00000216
		ERROR_PIPE_CONNECTED = 535, // 0x00000217
		ERROR_PIPE_LISTENING = 536, // 0x00000218
		ERROR_VERIFIER_STOP = 537, // 0x00000219
		ERROR_ABIOS_ERROR = 538, // 0x0000021A
		ERROR_WX86_WARNING = 539, // 0x0000021B
		ERROR_WX86_ERROR = 540, // 0x0000021C
		ERROR_TIMER_NOT_CANCELED = 541, // 0x0000021D
		ERROR_UNWIND = 542, // 0x0000021E
		ERROR_BAD_STACK = 543, // 0x0000021F
		ERROR_INVALID_UNWIND_TARGET = 544, // 0x00000220
		ERROR_INVALID_PORT_ATTRIBUTES = 545, // 0x00000221
		ERROR_PORT_MESSAGE_TOO_LONG = 546, // 0x00000222
		ERROR_INVALID_QUOTA_LOWER = 547, // 0x00000223
		ERROR_DEVICE_ALREADY_ATTACHED = 548, // 0x00000224
		ERROR_INSTRUCTION_MISALIGNMENT = 549, // 0x00000225
		ERROR_PROFILING_NOT_STARTED = 550, // 0x00000226
		ERROR_PROFILING_NOT_STOPPED = 551, // 0x00000227
		ERROR_COULD_NOT_INTERPRET = 552, // 0x00000228
		ERROR_PROFILING_AT_LIMIT = 553, // 0x00000229
		ERROR_CANT_WAIT = 554, // 0x0000022A
		ERROR_CANT_TERMINATE_SELF = 555, // 0x0000022B
		ERROR_UNEXPECTED_MM_CREATE_ERR = 556, // 0x0000022C
		ERROR_UNEXPECTED_MM_MAP_ERROR = 557, // 0x0000022D
		ERROR_UNEXPECTED_MM_EXTEND_ERR = 558, // 0x0000022E
		ERROR_BAD_FUNCTION_TABLE = 559, // 0x0000022F
		ERROR_NO_GUID_TRANSLATION = 560, // 0x00000230
		ERROR_INVALID_LDT_SIZE = 561, // 0x00000231
		ERROR_INVALID_LDT_OFFSET = 563, // 0x00000233
		ERROR_INVALID_LDT_DESCRIPTOR = 564, // 0x00000234
		ERROR_TOO_MANY_THREADS = 565, // 0x00000235
		ERROR_THREAD_NOT_IN_PROCESS = 566, // 0x00000236
		ERROR_PAGEFILE_QUOTA_EXCEEDED = 567, // 0x00000237
		ERROR_LOGON_SERVER_CONFLICT = 568, // 0x00000238
		ERROR_SYNCHRONIZATION_REQUIRED = 569, // 0x00000239
		ERROR_NET_OPEN_FAILED = 570, // 0x0000023A
		ERROR_IO_PRIVILEGE_FAILED = 571, // 0x0000023B
		ERROR_CONTROL_C_EXIT = 572, // 0x0000023C
		ERROR_MISSING_SYSTEMFILE = 573, // 0x0000023D
		ERROR_UNHANDLED_EXCEPTION = 574, // 0x0000023E
		ERROR_APP_INIT_FAILURE = 575, // 0x0000023F
		ERROR_PAGEFILE_CREATE_FAILED = 576, // 0x00000240
		ERROR_INVALID_IMAGE_HASH = 577, // 0x00000241
		ERROR_NO_PAGEFILE = 578, // 0x00000242
		ERROR_ILLEGAL_FLOAT_CONTEXT = 579, // 0x00000243
		ERROR_NO_EVENT_PAIR = 580, // 0x00000244
		ERROR_DOMAIN_CTRLR_CONFIG_ERROR = 581, // 0x00000245
		ERROR_ILLEGAL_CHARACTER = 582, // 0x00000246
		ERROR_UNDEFINED_CHARACTER = 583, // 0x00000247
		ERROR_FLOPPY_VOLUME = 584, // 0x00000248
		ERROR_BACKUP_CONTROLLER = 586, // 0x0000024A
		ERROR_MUTANT_LIMIT_EXCEEDED = 587, // 0x0000024B
		ERROR_FS_DRIVER_REQUIRED = 588, // 0x0000024C
		ERROR_CANNOT_LOAD_REGISTRY_FILE = 589, // 0x0000024D
		ERROR_DEBUG_ATTACH_FAILED = 590, // 0x0000024E
		ERROR_SYSTEM_PROCESS_TERMINATED = 591, // 0x0000024F
		ERROR_DATA_NOT_ACCEPTED = 592, // 0x00000250
		ERROR_VDM_HARD_ERROR = 593, // 0x00000251
		ERROR_DRIVER_CANCEL_TIMEOUT = 594, // 0x00000252
		ERROR_REPLY_MESSAGE_MISMATCH = 595, // 0x00000253
		ERROR_LOST_WRITEBEHIND_DATA = 596, // 0x00000254
		ERROR_NOT_TINY_STREAM = 598, // 0x00000256
		ERROR_STACK_OVERFLOW_READ = 599, // 0x00000257
		ERROR_CONVERT_TO_LARGE = 600, // 0x00000258
		ERROR_FOUND_OUT_OF_SCOPE = 601, // 0x00000259
		ERROR_ALLOCATE_BUCKET = 602, // 0x0000025A
		ERROR_MARSHALL_OVERFLOW = 603, // 0x0000025B
		ERROR_INVALID_VARIANT = 604, // 0x0000025C
		ERROR_BAD_COMPRESSION_BUFFER = 605, // 0x0000025D
		ERROR_AUDIT_FAILED = 606, // 0x0000025E
		ERROR_TIMER_RESOLUTION_NOT_SET = 607, // 0x0000025F
		ERROR_INSUFFICIENT_LOGON_INFO = 608, // 0x00000260
		ERROR_BAD_DLL_ENTRYPOINT = 609, // 0x00000261
		ERROR_BAD_SERVICE_ENTRYPOINT = 610, // 0x00000262
		ERROR_IP_ADDRESS_CONFLICT1 = 611, // 0x00000263
		ERROR_IP_ADDRESS_CONFLICT2 = 612, // 0x00000264
		ERROR_REGISTRY_QUOTA_LIMIT = 613, // 0x00000265
		ERROR_NO_CALLBACK_ACTIVE = 614, // 0x00000266
		ERROR_PWD_TOO_SHORT = 615, // 0x00000267
		ERROR_PWD_TOO_RECENT = 616, // 0x00000268
		ERROR_PWD_HISTORY_CONFLICT = 617, // 0x00000269
		ERROR_UNSUPPORTED_COMPRESSION = 618, // 0x0000026A
		ERROR_INVALID_HW_PROFILE = 619, // 0x0000026B
		ERROR_QUOTA_LIST_INCONSISTENT = 621, // 0x0000026D
		ERROR_EVALUATION_EXPIRATION = 622, // 0x0000026E
		ERROR_ILLEGAL_DLL_RELOCATION = 623, // 0x0000026F
		ERROR_DLL_INIT_FAILED_LOGOFF = 624, // 0x00000270
		ERROR_VALIDATE_CONTINUE = 625, // 0x00000271
		ERROR_NO_MORE_MATCHES = 626, // 0x00000272
		ERROR_RANGE_LIST_CONFLICT = 627, // 0x00000273
		ERROR_SERVER_SID_MISMATCH = 628, // 0x00000274
		ERROR_CANT_ENABLE_DENY_ONLY = 629, // 0x00000275
		ERROR_FLOAT_MULTIPLE_FAULTS = 630, // 0x00000276
		ERROR_FLOAT_MULTIPLE_TRAPS = 631, // 0x00000277
		ERROR_NOINTERFACE = 632, // 0x00000278
		ERROR_DRIVER_FAILED_SLEEP = 633, // 0x00000279
		ERROR_CORRUPT_SYSTEM_FILE = 634, // 0x0000027A
		ERROR_COMMITMENT_MINIMUM = 635, // 0x0000027B
		ERROR_PNP_RESTART_ENUMERATION = 636, // 0x0000027C
		ERROR_PNP_REBOOT_REQUIRED = 638, // 0x0000027E
		ERROR_INSUFFICIENT_POWER = 639, // 0x0000027F
		ERROR_MULTIPLE_FAULT_VIOLATION = 640, // 0x00000280
		ERROR_SYSTEM_SHUTDOWN = 641, // 0x00000281
		ERROR_PORT_NOT_SET = 642, // 0x00000282
		ERROR_DS_VERSION_CHECK_FAILURE = 643, // 0x00000283
		ERROR_RANGE_NOT_FOUND = 644, // 0x00000284
		ERROR_NOT_SAFE_MODE_DRIVER = 646, // 0x00000286
		ERROR_FAILED_DRIVER_ENTRY = 647, // 0x00000287
		ERROR_DEVICE_ENUMERATION_ERROR = 648, // 0x00000288
		ERROR_MOUNT_POINT_NOT_RESOLVED = 649, // 0x00000289
		ERROR_MCA_OCCURED = 651, // 0x0000028B
		ERROR_DRIVER_DATABASE_ERROR = 652, // 0x0000028C
		ERROR_SYSTEM_HIVE_TOO_LARGE = 653, // 0x0000028D
		ERROR_VOLSNAP_PREPARE_HIBERNATE = 655, // 0x0000028F
		ERROR_HIBERNATION_FAILURE = 656, // 0x00000290
		ERROR_PWD_TOO_LONG = 657, // 0x00000291
		ERROR_FILE_SYSTEM_LIMITATION = 665, // 0x00000299
		ERROR_ASSERTION_FAILURE = 668, // 0x0000029C
		ERROR_ACPI_ERROR = 669, // 0x0000029D
		ERROR_WOW_ASSERTION = 670, // 0x0000029E
		ERROR_PNP_BAD_MPS_TABLE = 671, // 0x0000029F
		ERROR_PNP_TRANSLATION_FAILED = 672, // 0x000002A0
		ERROR_PNP_INVALID_ID = 674, // 0x000002A2
		ERROR_WAKE_SYSTEM_DEBUGGER = 675, // 0x000002A3
		ERROR_HANDLES_CLOSED = 676, // 0x000002A4
		ERROR_EXTRANEOUS_INFORMATION = 677, // 0x000002A5
		ERROR_RXACT_COMMIT_NECESSARY = 678, // 0x000002A6
		ERROR_MEDIA_CHECK = 679, // 0x000002A7
		ERROR_GUID_SUBSTITUTION_MADE = 680, // 0x000002A8
		ERROR_STOPPED_ON_SYMLINK = 681, // 0x000002A9
		ERROR_LONGJUMP = 682, // 0x000002AA
		ERROR_PLUGPLAY_QUERY_VETOED = 683, // 0x000002AB
		ERROR_UNWIND_CONSOLIDATE = 684, // 0x000002AC
		ERROR_REGISTRY_HIVE_RECOVERED = 685, // 0x000002AD
		ERROR_DLL_MIGHT_BE_INSECURE = 686, // 0x000002AE
		ERROR_DLL_MIGHT_BE_INCOMPATIBLE = 687, // 0x000002AF
		ERROR_DBG_EXCEPTION_NOT_HANDLED = 688, // 0x000002B0
		ERROR_DBG_REPLY_LATER = 689, // 0x000002B1
		ERROR_DBG_TERMINATE_THREAD = 691, // 0x000002B3
		ERROR_DBG_TERMINATE_PROCESS = 692, // 0x000002B4
		ERROR_DBG_CONTROL_C = 693, // 0x000002B5
		ERROR_DBG_PRINTEXCEPTION_C = 694, // 0x000002B6
		ERROR_DBG_RIPEXCEPTION = 695, // 0x000002B7
		ERROR_DBG_CONTROL_BREAK = 696, // 0x000002B8
		ERROR_DBG_COMMAND_EXCEPTION = 697, // 0x000002B9
		ERROR_OBJECT_NAME_EXISTS = 698, // 0x000002BA
		ERROR_THREAD_WAS_SUSPENDED = 699, // 0x000002BB
		ERROR_IMAGE_NOT_AT_BASE = 700, // 0x000002BC
		ERROR_RXACT_STATE_CREATED = 701, // 0x000002BD
		ERROR_SEGMENT_NOTIFICATION = 702, // 0x000002BE
		ERROR_BAD_CURRENT_DIRECTORY = 703, // 0x000002BF
		ERROR_FT_WRITE_RECOVERY = 705, // 0x000002C1
		ERROR_RECEIVE_PARTIAL = 707, // 0x000002C3
		ERROR_RECEIVE_EXPEDITED = 708, // 0x000002C4
		ERROR_RECEIVE_PARTIAL_EXPEDITED = 709, // 0x000002C5
		ERROR_EVENT_DONE = 710, // 0x000002C6
		ERROR_EVENT_PENDING = 711, // 0x000002C7
		ERROR_CHECKING_FILE_SYSTEM = 712, // 0x000002C8
		ERROR_FATAL_APP_EXIT = 713, // 0x000002C9
		ERROR_PREDEFINED_HANDLE = 714, // 0x000002CA
		ERROR_WAS_UNLOCKED = 715, // 0x000002CB
		ERROR_SERVICE_NOTIFICATION = 716, // 0x000002CC
		ERROR_WAS_LOCKED = 717, // 0x000002CD
		ERROR_LOG_HARD_ERROR = 718, // 0x000002CE
		ERROR_ALREADY_WIN32 = 719, // 0x000002CF
		ERROR_NO_YIELD_PERFORMED = 721, // 0x000002D1
		ERROR_TIMER_RESUME_IGNORED = 722, // 0x000002D2
		ERROR_ARBITRATION_UNHANDLED = 723, // 0x000002D3
		ERROR_CARDBUS_NOT_SUPPORTED = 724, // 0x000002D4
		ERROR_MP_PROCESSOR_MISMATCH = 725, // 0x000002D5
		ERROR_HIBERNATED = 726, // 0x000002D6
		ERROR_RESUME_HIBERNATION = 727, // 0x000002D7
		ERROR_FIRMWARE_UPDATED = 728, // 0x000002D8
		ERROR_WAKE_SYSTEM = 730, // 0x000002DA
		ERROR_WAIT_1 = 731, // 0x000002DB
		ERROR_WAIT_2 = 732, // 0x000002DC
		ERROR_WAIT_3 = 733, // 0x000002DD
		ERROR_WAIT_63 = 734, // 0x000002DE
		ERROR_ABANDONED_WAIT_0 = 735, // 0x000002DF
		ERROR_ABANDONED_WAIT_63 = 736, // 0x000002E0
		ERROR_USER_APC = 737, // 0x000002E1
		ERROR_KERNEL_APC = 738, // 0x000002E2
		ERROR_ALERTED = 739, // 0x000002E3
		ERROR_ELEVATION_REQUIRED = 740, // 0x000002E4
		ERROR_REPARSE = 741, // 0x000002E5
		ERROR_OPLOCK_BREAK_IN_PROGRESS = 742, // 0x000002E6
		ERROR_VOLUME_MOUNTED = 743, // 0x000002E7
		ERROR_RXACT_COMMITTED = 744, // 0x000002E8
		ERROR_NOTIFY_CLEANUP = 745, // 0x000002E9
		ERROR_PAGE_FAULT_TRANSITION = 747, // 0x000002EB
		ERROR_PAGE_FAULT_DEMAND_ZERO = 748, // 0x000002EC
		ERROR_PAGE_FAULT_COPY_ON_WRITE = 749, // 0x000002ED
		ERROR_PAGE_FAULT_GUARD_PAGE = 750, // 0x000002EE
		ERROR_PAGE_FAULT_PAGING_FILE = 751, // 0x000002EF
		ERROR_CACHE_PAGE_LOCKED = 752, // 0x000002F0
		ERROR_CRASH_DUMP = 753, // 0x000002F1
		ERROR_BUFFER_ALL_ZEROS = 754, // 0x000002F2
		ERROR_REPARSE_OBJECT = 755, // 0x000002F3
		ERROR_TRANSLATION_COMPLETE = 757, // 0x000002F5
		ERROR_NOTHING_TO_TERMINATE = 758, // 0x000002F6
		ERROR_PROCESS_NOT_IN_JOB = 759, // 0x000002F7
		ERROR_PROCESS_IN_JOB = 760, // 0x000002F8
		ERROR_VOLSNAP_HIBERNATE_READY = 761, // 0x000002F9
		ERROR_INTERRUPT_STILL_CONNECTED = 764, // 0x000002FC
		ERROR_WAIT_FOR_OPLOCK = 765, // 0x000002FD
		ERROR_DBG_EXCEPTION_HANDLED = 766, // 0x000002FE
		ERROR_DBG_CONTINUE = 767, // 0x000002FF
		ERROR_CALLBACK_POP_STACK = 768, // 0x00000300
		ERROR_COMPRESSION_DISABLED = 769, // 0x00000301
		ERROR_CANTFETCHBACKWARDS = 770, // 0x00000302
		ERROR_CANTSCROLLBACKWARDS = 771, // 0x00000303
		ERROR_ROWSNOTRELEASED = 772, // 0x00000304
		ERROR_BAD_ACCESSOR_FLAGS = 773, // 0x00000305
		ERROR_ERRORS_ENCOUNTERED = 774, // 0x00000306
		ERROR_NOT_CAPABLE = 775, // 0x00000307
		ERROR_REQUEST_OUT_OF_SEQUENCE = 776, // 0x00000308
		ERROR_VERSION_PARSE_ERROR = 777, // 0x00000309
		ERROR_BADSTARTPOSITION = 778, // 0x0000030A
		ERROR_MEMORY_HARDWARE = 779, // 0x0000030B
		ERROR_DISK_REPAIR_DISABLED = 780, // 0x0000030C
		ERROR_MCA_EXCEPTION = 784, // 0x00000310
		ERROR_ACCESS_AUDIT_BY_POLICY = 785, // 0x00000311
		ERROR_ABANDON_HIBERFILE = 787, // 0x00000313
		ERROR_BAD_MCFG_TABLE = 791, // 0x00000317
		ERROR_DISK_REPAIR_REDIRECTED = 792, // 0x00000318
		ERROR_DISK_REPAIR_UNSUCCESSFUL = 793, // 0x00000319
		ERROR_CORRUPT_LOG_OVERFULL = 794, // 0x0000031A
		ERROR_CORRUPT_LOG_CORRUPTED = 795, // 0x0000031B
		ERROR_CORRUPT_LOG_UNAVAILABLE = 796, // 0x0000031C
		ERROR_CORRUPT_LOG_DELETED_FULL = 797, // 0x0000031D
		ERROR_CORRUPT_LOG_CLEARED = 798, // 0x0000031E
		ERROR_ORPHAN_NAME_EXHAUSTED = 799, // 0x0000031F
		ERROR_CANNOT_BREAK_OPLOCK = 802, // 0x00000322
		ERROR_OPLOCK_HANDLE_CLOSED = 803, // 0x00000323
		ERROR_NO_ACE_CONDITION = 804, // 0x00000324
		ERROR_INVALID_ACE_CONDITION = 805, // 0x00000325
		ERROR_FILE_HANDLE_REVOKED = 806, // 0x00000326
		ERROR_IMAGE_AT_DIFFERENT_BASE = 807, // 0x00000327
		ERROR_ENCRYPTED_IO_NOT_POSSIBLE = 808, // 0x00000328
		ERROR_QUOTA_ACTIVITY = 810, // 0x0000032A
		ERROR_HANDLE_REVOKED = 811, // 0x0000032B
		ERROR_CALLBACK_INVOKE_INLINE = 812, // 0x0000032C
		ERROR_CPU_SET_INVALID = 813, // 0x0000032D
		ERROR_EA_ACCESS_DENIED = 994, // 0x000003E2
		ERROR_OPERATION_ABORTED = 995, // 0x000003E3
		ERROR_IO_INCOMPLETE = 996, // 0x000003E4
		ERROR_IO_PENDING = 997, // 0x000003E5
		ERROR_NOACCESS = 998, // 0x000003E6
		ERROR_SWAPERROR = 999, // 0x000003E7
		ERROR_STACK_OVERFLOW = 1001, // 0x000003E9
		ERROR_INVALID_MESSAGE = 1002, // 0x000003EA
		ERROR_CAN_NOT_COMPLETE = 1003, // 0x000003EB
		ERROR_INVALID_FLAGS = 1004, // 0x000003EC
		ERROR_UNRECOGNIZED_VOLUME = 1005, // 0x000003ED
		ERROR_FILE_INVALID = 1006, // 0x000003EE
		ERROR_FULLSCREEN_MODE = 1007, // 0x000003EF
		ERROR_NO_TOKEN = 1008, // 0x000003F0
		ERROR_BADDB = 1009, // 0x000003F1
		ERROR_BADKEY = 1010, // 0x000003F2
		ERROR_CANTOPEN = 1011, // 0x000003F3
		ERROR_CANTREAD = 1012, // 0x000003F4
		ERROR_CANTWRITE = 1013, // 0x000003F5
		ERROR_REGISTRY_RECOVERED = 1014, // 0x000003F6
		ERROR_REGISTRY_CORRUPT = 1015, // 0x000003F7
		ERROR_REGISTRY_IO_FAILED = 1016, // 0x000003F8
		ERROR_NOT_REGISTRY_FILE = 1017, // 0x000003F9
		ERROR_KEY_DELETED = 1018, // 0x000003FA
		ERROR_NO_LOG_SPACE = 1019, // 0x000003FB
		ERROR_KEY_HAS_CHILDREN = 1020, // 0x000003FC
		ERROR_CHILD_MUST_BE_VOLATILE = 1021, // 0x000003FD
		ERROR_NOTIFY_ENUM_DIR = 1022, // 0x000003FE
		ERROR_INVALID_SERVICE_CONTROL = 1052, // 0x0000041C
		ERROR_SERVICE_REQUEST_TIMEOUT = 1053, // 0x0000041D
		ERROR_SERVICE_NO_THREAD = 1054, // 0x0000041E
		ERROR_SERVICE_DATABASE_LOCKED = 1055, // 0x0000041F
		ERROR_SERVICE_ALREADY_RUNNING = 1056, // 0x00000420
		ERROR_INVALID_SERVICE_ACCOUNT = 1057, // 0x00000421
		ERROR_SERVICE_DISABLED = 1058, // 0x00000422
		ERROR_CIRCULAR_DEPENDENCY = 1059, // 0x00000423
		ERROR_SERVICE_DOES_NOT_EXIST = 1060, // 0x00000424
		ERROR_SERVICE_NOT_ACTIVE = 1062, // 0x00000426
		ERROR_EXCEPTION_IN_SERVICE = 1064, // 0x00000428
		ERROR_DATABASE_DOES_NOT_EXIST = 1065, // 0x00000429
		ERROR_SERVICE_SPECIFIC_ERROR = 1066, // 0x0000042A
		ERROR_PROCESS_ABORTED = 1067, // 0x0000042B
		ERROR_SERVICE_DEPENDENCY_FAIL = 1068, // 0x0000042C
		ERROR_SERVICE_LOGON_FAILED = 1069, // 0x0000042D
		ERROR_SERVICE_START_HANG = 1070, // 0x0000042E
		ERROR_INVALID_SERVICE_LOCK = 1071, // 0x0000042F
		ERROR_SERVICE_MARKED_FOR_DELETE = 1072, // 0x00000430
		ERROR_SERVICE_EXISTS = 1073, // 0x00000431
		ERROR_ALREADY_RUNNING_LKG = 1074, // 0x00000432
		ERROR_BOOT_ALREADY_ACCEPTED = 1076, // 0x00000434
		ERROR_SERVICE_NEVER_STARTED = 1077, // 0x00000435
		ERROR_DUPLICATE_SERVICE_NAME = 1078, // 0x00000436
		ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079, // 0x00000437
		ERROR_NO_RECOVERY_PROGRAM = 1082, // 0x0000043A
		ERROR_SERVICE_NOT_IN_EXE = 1083, // 0x0000043B
		ERROR_NOT_SAFEBOOT_SERVICE = 1084, // 0x0000043C
		ERROR_END_OF_MEDIA = 1100, // 0x0000044C
		ERROR_FILEMARK_DETECTED = 1101, // 0x0000044D
		ERROR_BEGINNING_OF_MEDIA = 1102, // 0x0000044E
		ERROR_SETMARK_DETECTED = 1103, // 0x0000044F
		ERROR_NO_DATA_DETECTED = 1104, // 0x00000450
		ERROR_PARTITION_FAILURE = 1105, // 0x00000451
		ERROR_INVALID_BLOCK_LENGTH = 1106, // 0x00000452
		ERROR_DEVICE_NOT_PARTITIONED = 1107, // 0x00000453
		ERROR_UNABLE_TO_LOCK_MEDIA = 1108, // 0x00000454
		ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109, // 0x00000455
		ERROR_MEDIA_CHANGED = 1110, // 0x00000456
		ERROR_BUS_RESET = 1111, // 0x00000457
		ERROR_NO_MEDIA_IN_DRIVE = 1112, // 0x00000458
		ERROR_NO_UNICODE_TRANSLATION = 1113, // 0x00000459
		ERROR_DLL_INIT_FAILED = 1114, // 0x0000045A
		ERROR_SHUTDOWN_IN_PROGRESS = 1115, // 0x0000045B
		ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116, // 0x0000045C
		ERROR_IO_DEVICE = 1117, // 0x0000045D
		ERROR_SERIAL_NO_DEVICE = 1118, // 0x0000045E
		ERROR_IRQ_BUSY = 1119, // 0x0000045F
		ERROR_MORE_WRITES = 1120, // 0x00000460
		ERROR_COUNTER_TIMEOUT = 1121, // 0x00000461
		ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122, // 0x00000462
		ERROR_FLOPPY_WRONG_CYLINDER = 1123, // 0x00000463
		ERROR_FLOPPY_UNKNOWN_ERROR = 1124, // 0x00000464
		ERROR_FLOPPY_BAD_REGISTERS = 1125, // 0x00000465
		ERROR_DISK_RECALIBRATE_FAILED = 1126, // 0x00000466
		ERROR_DISK_OPERATION_FAILED = 1127, // 0x00000467
		ERROR_DISK_RESET_FAILED = 1128, // 0x00000468
		ERROR_EOM_OVERFLOW = 1129, // 0x00000469
		ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130, // 0x0000046A
		ERROR_POSSIBLE_DEADLOCK = 1131, // 0x0000046B
		ERROR_MAPPED_ALIGNMENT = 1132, // 0x0000046C
		ERROR_SET_POWER_STATE_VETOED = 1140, // 0x00000474
		ERROR_SET_POWER_STATE_FAILED = 1141, // 0x00000475
		ERROR_TOO_MANY_LINKS = 1142, // 0x00000476
		ERROR_OLD_WIN_VERSION = 1150, // 0x0000047E
		ERROR_APP_WRONG_OS = 1151, // 0x0000047F
		ERROR_SINGLE_INSTANCE_APP = 1152, // 0x00000480
		ERROR_RMODE_APP = 1153, // 0x00000481
		ERROR_INVALID_DLL = 1154, // 0x00000482
		ERROR_NO_ASSOCIATION = 1155, // 0x00000483
		ERROR_DDE_FAIL = 1156, // 0x00000484
		ERROR_DLL_NOT_FOUND = 1157, // 0x00000485
		ERROR_NO_MORE_USER_HANDLES = 1158, // 0x00000486
		ERROR_MESSAGE_SYNC_ONLY = 1159, // 0x00000487
		ERROR_SOURCE_ELEMENT_EMPTY = 1160, // 0x00000488
		ERROR_DESTINATION_ELEMENT_FULL = 1161, // 0x00000489
		ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162, // 0x0000048A
		ERROR_MAGAZINE_NOT_PRESENT = 1163, // 0x0000048B
		ERROR_DEVICE_REQUIRES_CLEANING = 1165, // 0x0000048D
		ERROR_DEVICE_DOOR_OPEN = 1166, // 0x0000048E
		ERROR_DEVICE_NOT_CONNECTED = 1167, // 0x0000048F
		ERROR_NOT_FOUND = 1168, // 0x00000490
		ERROR_NO_MATCH = 1169, // 0x00000491
		ERROR_SET_NOT_FOUND = 1170, // 0x00000492
		ERROR_POINT_NOT_FOUND = 1171, // 0x00000493
		ERROR_NO_TRACKING_SERVICE = 1172, // 0x00000494
		ERROR_NO_VOLUME_ID = 1173, // 0x00000495
		ERROR_UNABLE_TO_REMOVE_REPLACED = 1175, // 0x00000497
		ERROR_JOURNAL_NOT_ACTIVE = 1179, // 0x0000049B
		ERROR_POTENTIAL_FILE_FOUND = 1180, // 0x0000049C
		ERROR_JOURNAL_ENTRY_DELETED = 1181, // 0x0000049D
		ERROR_SHUTDOWN_IS_SCHEDULED = 1190, // 0x000004A6
		ERROR_SHUTDOWN_USERS_LOGGED_ON = 1191, // 0x000004A7
		ERROR_BAD_DEVICE = 1200, // 0x000004B0
		ERROR_CONNECTION_UNAVAIL = 1201, // 0x000004B1
		ERROR_DEVICE_ALREADY_REMEMBERED = 1202, // 0x000004B2
		ERROR_NO_NET_OR_BAD_PATH = 1203, // 0x000004B3
		ERROR_BAD_PROVIDER = 1204, // 0x000004B4
		ERROR_CANNOT_OPEN_PROFILE = 1205, // 0x000004B5
		ERROR_BAD_PROFILE = 1206, // 0x000004B6
		ERROR_NOT_CONTAINER = 1207, // 0x000004B7
		ERROR_EXTENDED_ERROR = 1208, // 0x000004B8
		ERROR_INVALID_GROUPNAME = 1209, // 0x000004B9
		ERROR_INVALID_COMPUTERNAME = 1210, // 0x000004BA
		ERROR_INVALID_EVENTNAME = 1211, // 0x000004BB
		ERROR_INVALID_DOMAINNAME = 1212, // 0x000004BC
		ERROR_INVALID_SERVICENAME = 1213, // 0x000004BD
		ERROR_INVALID_NETNAME = 1214, // 0x000004BE
		ERROR_INVALID_SHARENAME = 1215, // 0x000004BF
		ERROR_INVALID_PASSWORDNAME = 1216, // 0x000004C0
		ERROR_INVALID_MESSAGENAME = 1217, // 0x000004C1
		ERROR_INVALID_MESSAGEDEST = 1218, // 0x000004C2
		ERROR_DUP_DOMAINNAME = 1221, // 0x000004C5
		ERROR_NO_NETWORK = 1222, // 0x000004C6
		ERROR_CANCELLED = 1223, // 0x000004C7
		ERROR_USER_MAPPED_FILE = 1224, // 0x000004C8
		ERROR_CONNECTION_REFUSED = 1225, // 0x000004C9
		ERROR_GRACEFUL_DISCONNECT = 1226, // 0x000004CA
		ERROR_ADDRESS_NOT_ASSOCIATED = 1228, // 0x000004CC
		ERROR_CONNECTION_INVALID = 1229, // 0x000004CD
		ERROR_CONNECTION_ACTIVE = 1230, // 0x000004CE
		ERROR_NETWORK_UNREACHABLE = 1231, // 0x000004CF
		ERROR_HOST_UNREACHABLE = 1232, // 0x000004D0
		ERROR_PROTOCOL_UNREACHABLE = 1233, // 0x000004D1
		ERROR_PORT_UNREACHABLE = 1234, // 0x000004D2
		ERROR_REQUEST_ABORTED = 1235, // 0x000004D3
		ERROR_CONNECTION_ABORTED = 1236, // 0x000004D4
		ERROR_RETRY = 1237, // 0x000004D5
		ERROR_CONNECTION_COUNT_LIMIT = 1238, // 0x000004D6
		ERROR_LOGIN_TIME_RESTRICTION = 1239, // 0x000004D7
		ERROR_LOGIN_WKSTA_RESTRICTION = 1240, // 0x000004D8
		ERROR_INCORRECT_ADDRESS = 1241, // 0x000004D9
		ERROR_ALREADY_REGISTERED = 1242, // 0x000004DA
		ERROR_SERVICE_NOT_FOUND = 1243, // 0x000004DB
		ERROR_NOT_AUTHENTICATED = 1244, // 0x000004DC
		ERROR_NOT_LOGGED_ON = 1245, // 0x000004DD
		ERROR_CONTINUE = 1246, // 0x000004DE
		ERROR_ALREADY_INITIALIZED = 1247, // 0x000004DF
		ERROR_NO_MORE_DEVICES = 1248, // 0x000004E0
		ERROR_NO_SUCH_SITE = 1249, // 0x000004E1
		ERROR_DOMAIN_CONTROLLER_EXISTS = 1250, // 0x000004E2
		ERROR_ONLY_IF_CONNECTED = 1251, // 0x000004E3
		ERROR_OVERRIDE_NOCHANGES = 1252, // 0x000004E4
		ERROR_BAD_USER_PROFILE = 1253, // 0x000004E5
		ERROR_NOT_SUPPORTED_ON_SBS = 1254, // 0x000004E6
		ERROR_HOST_DOWN = 1256, // 0x000004E8
		ERROR_NON_ACCOUNT_SID = 1257, // 0x000004E9
		ERROR_NON_DOMAIN_SID = 1258, // 0x000004EA
		ERROR_APPHELP_BLOCK = 1259, // 0x000004EB
		ERROR_ACCESS_DISABLED_BY_POLICY = 1260, // 0x000004EC
		ERROR_REG_NAT_CONSUMPTION = 1261, // 0x000004ED
		ERROR_CSCSHARE_OFFLINE = 1262, // 0x000004EE
		ERROR_PKINIT_FAILURE = 1263, // 0x000004EF
		ERROR_DOWNGRADE_DETECTED = 1265, // 0x000004F1
		ERROR_MACHINE_LOCKED = 1271, // 0x000004F7
		ERROR_DRIVER_BLOCKED = 1275, // 0x000004FB
		ERROR_INVALID_IMPORT_OF_NON_DLL = 1276, // 0x000004FC
		ERROR_ACCESS_DISABLED_WEBBLADE = 1277, // 0x000004FD
		ERROR_RECOVERY_FAILURE = 1279, // 0x000004FF
		ERROR_ALREADY_FIBER = 1280, // 0x00000500
		ERROR_ALREADY_THREAD = 1281, // 0x00000501
		ERROR_STACK_BUFFER_OVERRUN = 1282, // 0x00000502
		ERROR_PARAMETER_QUOTA_EXCEEDED = 1283, // 0x00000503
		ERROR_DEBUGGER_INACTIVE = 1284, // 0x00000504
		ERROR_DELAY_LOAD_FAILED = 1285, // 0x00000505
		ERROR_VDM_DISALLOWED = 1286, // 0x00000506
		ERROR_UNIDENTIFIED_ERROR = 1287, // 0x00000507
		ERROR_BEYOND_VDL = 1289, // 0x00000509
		ERROR_DRIVER_PROCESS_TERMINATED = 1291, // 0x0000050B
		ERROR_IMPLEMENTATION_LIMIT = 1292, // 0x0000050C
		ERROR_PROCESS_IS_PROTECTED = 1293, // 0x0000050D
		ERROR_DISK_QUOTA_EXCEEDED = 1295, // 0x0000050F
		ERROR_CONTENT_BLOCKED = 1296, // 0x00000510
		ERROR_APP_HANG = 1298, // 0x00000512
		ERROR_INVALID_LABEL = 1299, // 0x00000513
		ERROR_NOT_ALL_ASSIGNED = 1300, // 0x00000514
		ERROR_SOME_NOT_MAPPED = 1301, // 0x00000515
		ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302, // 0x00000516
		ERROR_LOCAL_USER_SESSION_KEY = 1303, // 0x00000517
		ERROR_NULL_LM_PASSWORD = 1304, // 0x00000518
		ERROR_UNKNOWN_REVISION = 1305, // 0x00000519
		ERROR_REVISION_MISMATCH = 1306, // 0x0000051A
		ERROR_INVALID_OWNER = 1307, // 0x0000051B
		ERROR_INVALID_PRIMARY_GROUP = 1308, // 0x0000051C
		ERROR_NO_IMPERSONATION_TOKEN = 1309, // 0x0000051D
		ERROR_CANT_DISABLE_MANDATORY = 1310, // 0x0000051E
		ERROR_NO_LOGON_SERVERS = 1311, // 0x0000051F
		ERROR_NO_SUCH_LOGON_SESSION = 1312, // 0x00000520
		ERROR_NO_SUCH_PRIVILEGE = 1313, // 0x00000521
		ERROR_PRIVILEGE_NOT_HELD = 1314, // 0x00000522
		ERROR_INVALID_ACCOUNT_NAME = 1315, // 0x00000523
		ERROR_USER_EXISTS = 1316, // 0x00000524
		ERROR_NO_SUCH_USER = 1317, // 0x00000525
		ERROR_GROUP_EXISTS = 1318, // 0x00000526
		ERROR_NO_SUCH_GROUP = 1319, // 0x00000527
		ERROR_MEMBER_IN_GROUP = 1320, // 0x00000528
		ERROR_MEMBER_NOT_IN_GROUP = 1321, // 0x00000529
		ERROR_LAST_ADMIN = 1322, // 0x0000052A
		ERROR_WRONG_PASSWORD = 1323, // 0x0000052B
		ERROR_ILL_FORMED_PASSWORD = 1324, // 0x0000052C
		ERROR_PASSWORD_RESTRICTION = 1325, // 0x0000052D
		ERROR_LOGON_FAILURE = 1326, // 0x0000052E
		ERROR_ACCOUNT_RESTRICTION = 1327, // 0x0000052F
		ERROR_INVALID_LOGON_HOURS = 1328, // 0x00000530
		ERROR_INVALID_WORKSTATION = 1329, // 0x00000531
		ERROR_PASSWORD_EXPIRED = 1330, // 0x00000532
		ERROR_ACCOUNT_DISABLED = 1331, // 0x00000533
		ERROR_NONE_MAPPED = 1332, // 0x00000534
		ERROR_TOO_MANY_LUIDS_REQUESTED = 1333, // 0x00000535
		ERROR_LUIDS_EXHAUSTED = 1334, // 0x00000536
		ERROR_INVALID_SUB_AUTHORITY = 1335, // 0x00000537
		ERROR_INVALID_ACL = 1336, // 0x00000538
		ERROR_INVALID_SID = 1337, // 0x00000539
		ERROR_INVALID_SECURITY_DESCR = 1338, // 0x0000053A
		ERROR_BAD_INHERITANCE_ACL = 1340, // 0x0000053C
		ERROR_SERVER_DISABLED = 1341, // 0x0000053D
		ERROR_SERVER_NOT_DISABLED = 1342, // 0x0000053E
		ERROR_INVALID_ID_AUTHORITY = 1343, // 0x0000053F
		ERROR_ALLOTTED_SPACE_EXCEEDED = 1344, // 0x00000540
		ERROR_INVALID_GROUP_ATTRIBUTES = 1345, // 0x00000541
		ERROR_BAD_IMPERSONATION_LEVEL = 1346, // 0x00000542
		ERROR_CANT_OPEN_ANONYMOUS = 1347, // 0x00000543
		ERROR_BAD_VALIDATION_CLASS = 1348, // 0x00000544
		ERROR_BAD_TOKEN_TYPE = 1349, // 0x00000545
		ERROR_NO_SECURITY_ON_OBJECT = 1350, // 0x00000546
		ERROR_CANT_ACCESS_DOMAIN_INFO = 1351, // 0x00000547
		ERROR_INVALID_SERVER_STATE = 1352, // 0x00000548
		ERROR_INVALID_DOMAIN_STATE = 1353, // 0x00000549
		ERROR_INVALID_DOMAIN_ROLE = 1354, // 0x0000054A
		ERROR_NO_SUCH_DOMAIN = 1355, // 0x0000054B
		ERROR_DOMAIN_EXISTS = 1356, // 0x0000054C
		ERROR_DOMAIN_LIMIT_EXCEEDED = 1357, // 0x0000054D
		ERROR_INTERNAL_DB_CORRUPTION = 1358, // 0x0000054E
		ERROR_INTERNAL_ERROR = 1359, // 0x0000054F
		ERROR_GENERIC_NOT_MAPPED = 1360, // 0x00000550
		ERROR_BAD_DESCRIPTOR_FORMAT = 1361, // 0x00000551
		ERROR_NOT_LOGON_PROCESS = 1362, // 0x00000552
		ERROR_LOGON_SESSION_EXISTS = 1363, // 0x00000553
		ERROR_NO_SUCH_PACKAGE = 1364, // 0x00000554
		ERROR_BAD_LOGON_SESSION_STATE = 1365, // 0x00000555
		ERROR_LOGON_SESSION_COLLISION = 1366, // 0x00000556
		ERROR_INVALID_LOGON_TYPE = 1367, // 0x00000557
		ERROR_CANNOT_IMPERSONATE = 1368, // 0x00000558
		ERROR_RXACT_INVALID_STATE = 1369, // 0x00000559
		ERROR_RXACT_COMMIT_FAILURE = 1370, // 0x0000055A
		ERROR_SPECIAL_ACCOUNT = 1371, // 0x0000055B
		ERROR_SPECIAL_GROUP = 1372, // 0x0000055C
		ERROR_SPECIAL_USER = 1373, // 0x0000055D
		ERROR_MEMBERS_PRIMARY_GROUP = 1374, // 0x0000055E
		ERROR_TOKEN_ALREADY_IN_USE = 1375, // 0x0000055F
		ERROR_NO_SUCH_ALIAS = 1376, // 0x00000560
		ERROR_MEMBER_NOT_IN_ALIAS = 1377, // 0x00000561
		ERROR_MEMBER_IN_ALIAS = 1378, // 0x00000562
		ERROR_ALIAS_EXISTS = 1379, // 0x00000563
		ERROR_LOGON_NOT_GRANTED = 1380, // 0x00000564
		ERROR_TOO_MANY_SECRETS = 1381, // 0x00000565
		ERROR_SECRET_TOO_LONG = 1382, // 0x00000566
		ERROR_INTERNAL_DB_ERROR = 1383, // 0x00000567
		ERROR_TOO_MANY_CONTEXT_IDS = 1384, // 0x00000568
		ERROR_LOGON_TYPE_NOT_GRANTED = 1385, // 0x00000569
		ERROR_NO_SUCH_MEMBER = 1387, // 0x0000056B
		ERROR_INVALID_MEMBER = 1388, // 0x0000056C
		ERROR_TOO_MANY_SIDS = 1389, // 0x0000056D
		ERROR_NO_INHERITANCE = 1391, // 0x0000056F
		ERROR_FILE_CORRUPT = 1392, // 0x00000570
		ERROR_DISK_CORRUPT = 1393, // 0x00000571
		ERROR_NO_USER_SESSION_KEY = 1394, // 0x00000572
		ERROR_LICENSE_QUOTA_EXCEEDED = 1395, // 0x00000573
		ERROR_WRONG_TARGET_NAME = 1396, // 0x00000574
		ERROR_MUTUAL_AUTH_FAILED = 1397, // 0x00000575
		ERROR_TIME_SKEW = 1398, // 0x00000576
		ERROR_INVALID_WINDOW_HANDLE = 1400, // 0x00000578
		ERROR_INVALID_MENU_HANDLE = 1401, // 0x00000579
		ERROR_INVALID_CURSOR_HANDLE = 1402, // 0x0000057A
		ERROR_INVALID_ACCEL_HANDLE = 1403, // 0x0000057B
		ERROR_INVALID_HOOK_HANDLE = 1404, // 0x0000057C
		ERROR_INVALID_DWP_HANDLE = 1405, // 0x0000057D
		ERROR_TLW_WITH_WSCHILD = 1406, // 0x0000057E
		ERROR_CANNOT_FIND_WND_CLASS = 1407, // 0x0000057F
		ERROR_WINDOW_OF_OTHER_THREAD = 1408, // 0x00000580
		ERROR_HOTKEY_ALREADY_REGISTERED = 1409, // 0x00000581
		ERROR_CLASS_ALREADY_EXISTS = 1410, // 0x00000582
		ERROR_CLASS_DOES_NOT_EXIST = 1411, // 0x00000583
		ERROR_CLASS_HAS_WINDOWS = 1412, // 0x00000584
		ERROR_INVALID_INDEX = 1413, // 0x00000585
		ERROR_INVALID_ICON_HANDLE = 1414, // 0x00000586
		ERROR_PRIVATE_DIALOG_INDEX = 1415, // 0x00000587
		ERROR_LISTBOX_ID_NOT_FOUND = 1416, // 0x00000588
		ERROR_NO_WILDCARD_CHARACTERS = 1417, // 0x00000589
		ERROR_CLIPBOARD_NOT_OPEN = 1418, // 0x0000058A
		ERROR_HOTKEY_NOT_REGISTERED = 1419, // 0x0000058B
		ERROR_WINDOW_NOT_DIALOG = 1420, // 0x0000058C
		ERROR_CONTROL_ID_NOT_FOUND = 1421, // 0x0000058D
		ERROR_INVALID_COMBOBOX_MESSAGE = 1422, // 0x0000058E
		ERROR_WINDOW_NOT_COMBOBOX = 1423, // 0x0000058F
		ERROR_INVALID_EDIT_HEIGHT = 1424, // 0x00000590
		ERROR_DC_NOT_FOUND = 1425, // 0x00000591
		ERROR_INVALID_HOOK_FILTER = 1426, // 0x00000592
		ERROR_INVALID_FILTER_PROC = 1427, // 0x00000593
		ERROR_HOOK_NEEDS_HMOD = 1428, // 0x00000594
		ERROR_GLOBAL_ONLY_HOOK = 1429, // 0x00000595
		ERROR_JOURNAL_HOOK_SET = 1430, // 0x00000596
		ERROR_HOOK_NOT_INSTALLED = 1431, // 0x00000597
		ERROR_INVALID_LB_MESSAGE = 1432, // 0x00000598
		ERROR_SETCOUNT_ON_BAD_LB = 1433, // 0x00000599
		ERROR_LB_WITHOUT_TABSTOPS = 1434, // 0x0000059A
		ERROR_CHILD_WINDOW_MENU = 1436, // 0x0000059C
		ERROR_NO_SYSTEM_MENU = 1437, // 0x0000059D
		ERROR_INVALID_MSGBOX_STYLE = 1438, // 0x0000059E
		ERROR_INVALID_SPI_VALUE = 1439, // 0x0000059F
		ERROR_SCREEN_ALREADY_LOCKED = 1440, // 0x000005A0
		ERROR_HWNDS_HAVE_DIFF_PARENT = 1441, // 0x000005A1
		ERROR_NOT_CHILD_WINDOW = 1442, // 0x000005A2
		ERROR_INVALID_GW_COMMAND = 1443, // 0x000005A3
		ERROR_INVALID_THREAD_ID = 1444, // 0x000005A4
		ERROR_NON_MDICHILD_WINDOW = 1445, // 0x000005A5
		ERROR_POPUP_ALREADY_ACTIVE = 1446, // 0x000005A6
		ERROR_NO_SCROLLBARS = 1447, // 0x000005A7
		ERROR_INVALID_SCROLLBAR_RANGE = 1448, // 0x000005A8
		ERROR_INVALID_SHOWWIN_COMMAND = 1449, // 0x000005A9
		ERROR_NO_SYSTEM_RESOURCES = 1450, // 0x000005AA
		ERROR_NONPAGED_SYSTEM_RESOURCES = 1451, // 0x000005AB
		ERROR_PAGED_SYSTEM_RESOURCES = 1452, // 0x000005AC
		ERROR_WORKING_SET_QUOTA = 1453, // 0x000005AD
		ERROR_PAGEFILE_QUOTA = 1454, // 0x000005AE
		ERROR_COMMITMENT_LIMIT = 1455, // 0x000005AF
		ERROR_MENU_ITEM_NOT_FOUND = 1456, // 0x000005B0
		ERROR_INVALID_KEYBOARD_HANDLE = 1457, // 0x000005B1
		ERROR_HOOK_TYPE_NOT_ALLOWED = 1458, // 0x000005B2
		ERROR_TIMEOUT = 1460, // 0x000005B4
		ERROR_INVALID_MONITOR_HANDLE = 1461, // 0x000005B5
		ERROR_INCORRECT_SIZE = 1462, // 0x000005B6
		ERROR_SYMLINK_CLASS_DISABLED = 1463, // 0x000005B7
		ERROR_SYMLINK_NOT_SUPPORTED = 1464, // 0x000005B8
		ERROR_XML_PARSE_ERROR = 1465, // 0x000005B9
		ERROR_XMLDSIG_ERROR = 1466, // 0x000005BA
		ERROR_RESTART_APPLICATION = 1467, // 0x000005BB
		ERROR_WRONG_COMPARTMENT = 1468, // 0x000005BC
		ERROR_AUTHIP_FAILURE = 1469, // 0x000005BD
		ERROR_NO_NVRAM_RESOURCES = 1470, // 0x000005BE
		ERROR_NOT_GUI_PROCESS = 1471, // 0x000005BF
		ERROR_EVENTLOG_FILE_CORRUPT = 1500, // 0x000005DC
		ERROR_EVENTLOG_CANT_START = 1501, // 0x000005DD
		ERROR_LOG_FILE_FULL = 1502, // 0x000005DE
		ERROR_EVENTLOG_FILE_CHANGED = 1503, // 0x000005DF
		ERROR_CONTAINER_ASSIGNED = 1504, // 0x000005E0
		ERROR_JOB_NO_CONTAINER = 1505, // 0x000005E1
		ERROR_INVALID_TASK_NAME = 1550, // 0x0000060E
		ERROR_INVALID_TASK_INDEX = 1551, // 0x0000060F
		ERROR_THREAD_ALREADY_IN_TASK = 1552, // 0x00000610
		ERROR_INSTALL_SERVICE_FAILURE = 1601, // 0x00000641
		ERROR_INSTALL_USEREXIT = 1602, // 0x00000642
		ERROR_INSTALL_FAILURE = 1603, // 0x00000643
		ERROR_INSTALL_SUSPEND = 1604, // 0x00000644
		ERROR_UNKNOWN_PRODUCT = 1605, // 0x00000645
		ERROR_UNKNOWN_FEATURE = 1606, // 0x00000646
		ERROR_UNKNOWN_COMPONENT = 1607, // 0x00000647
		ERROR_UNKNOWN_PROPERTY = 1608, // 0x00000648
		ERROR_INVALID_HANDLE_STATE = 1609, // 0x00000649
		ERROR_BAD_CONFIGURATION = 1610, // 0x0000064A
		ERROR_INDEX_ABSENT = 1611, // 0x0000064B
		ERROR_INSTALL_SOURCE_ABSENT = 1612, // 0x0000064C
		ERROR_INSTALL_PACKAGE_VERSION = 1613, // 0x0000064D
		ERROR_PRODUCT_UNINSTALLED = 1614, // 0x0000064E
		ERROR_BAD_QUERY_SYNTAX = 1615, // 0x0000064F
		ERROR_INVALID_FIELD = 1616, // 0x00000650
		ERROR_DEVICE_REMOVED = 1617, // 0x00000651
		ERROR_INSTALL_ALREADY_RUNNING = 1618, // 0x00000652
		ERROR_INSTALL_PACKAGE_INVALID = 1620, // 0x00000654
		ERROR_INSTALL_UI_FAILURE = 1621, // 0x00000655
		ERROR_INSTALL_LOG_FAILURE = 1622, // 0x00000656
		ERROR_INSTALL_TRANSFORM_FAILURE = 1624, // 0x00000658
		ERROR_INSTALL_PACKAGE_REJECTED = 1625, // 0x00000659
		ERROR_FUNCTION_NOT_CALLED = 1626, // 0x0000065A
		ERROR_FUNCTION_FAILED = 1627, // 0x0000065B
		ERROR_INVALID_TABLE = 1628, // 0x0000065C
		ERROR_DATATYPE_MISMATCH = 1629, // 0x0000065D
		ERROR_UNSUPPORTED_TYPE = 1630, // 0x0000065E
		ERROR_CREATE_FAILED = 1631, // 0x0000065F
		ERROR_INSTALL_TEMP_UNWRITABLE = 1632, // 0x00000660
		ERROR_INSTALL_NOTUSED = 1634, // 0x00000662
		ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635, // 0x00000663
		ERROR_PATCH_PACKAGE_INVALID = 1636, // 0x00000664
		ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637, // 0x00000665
		ERROR_PRODUCT_VERSION = 1638, // 0x00000666
		ERROR_INVALID_COMMAND_LINE = 1639, // 0x00000667
		ERROR_INSTALL_REMOTE_DISALLOWED = 1640, // 0x00000668
		ERROR_SUCCESS_REBOOT_INITIATED = 1641, // 0x00000669
		ERROR_PATCH_TARGET_NOT_FOUND = 1642, // 0x0000066A
		ERROR_PATCH_PACKAGE_REJECTED = 1643, // 0x0000066B
		ERROR_INSTALL_REMOTE_PROHIBITED = 1645, // 0x0000066D
		ERROR_PATCH_REMOVAL_UNSUPPORTED = 1646, // 0x0000066E
		ERROR_UNKNOWN_PATCH = 1647, // 0x0000066F
		ERROR_PATCH_NO_SEQUENCE = 1648, // 0x00000670
		ERROR_PATCH_REMOVAL_DISALLOWED = 1649, // 0x00000671
		ERROR_INVALID_PATCH_XML = 1650, // 0x00000672
		ERROR_INSTALL_SERVICE_SAFEBOOT = 1652, // 0x00000674
		ERROR_FAIL_FAST_EXCEPTION = 1653, // 0x00000675
		ERROR_INSTALL_REJECTED = 1654, // 0x00000676
		ERROR_DYNAMIC_CODE_BLOCKED = 1655, // 0x00000677
		ERROR_NOT_SAME_OBJECT = 1656, // 0x00000678
		RPC_S_INVALID_STRING_BINDING = 1700, // 0x000006A4
		RPC_S_WRONG_KIND_OF_BINDING = 1701, // 0x000006A5
		RPC_S_INVALID_BINDING = 1702, // 0x000006A6
		RPC_S_PROTSEQ_NOT_SUPPORTED = 1703, // 0x000006A7
		RPC_S_INVALID_RPC_PROTSEQ = 1704, // 0x000006A8
		RPC_S_INVALID_STRING_UUID = 1705, // 0x000006A9
		RPC_S_INVALID_ENDPOINT_FORMAT = 1706, // 0x000006AA
		RPC_S_INVALID_NET_ADDR = 1707, // 0x000006AB
		RPC_S_NO_ENDPOINT_FOUND = 1708, // 0x000006AC
		RPC_S_INVALID_TIMEOUT = 1709, // 0x000006AD
		RPC_S_OBJECT_NOT_FOUND = 1710, // 0x000006AE
		RPC_S_ALREADY_REGISTERED = 1711, // 0x000006AF
		RPC_S_TYPE_ALREADY_REGISTERED = 1712, // 0x000006B0
		RPC_S_ALREADY_LISTENING = 1713, // 0x000006B1
		RPC_S_NO_PROTSEQS_REGISTERED = 1714, // 0x000006B2
		RPC_S_NOT_LISTENING = 1715, // 0x000006B3
		RPC_S_UNKNOWN_MGR_TYPE = 1716, // 0x000006B4
		RPC_S_UNKNOWN_IF = 1717, // 0x000006B5
		RPC_S_NO_BINDINGS = 1718, // 0x000006B6
		RPC_S_NO_PROTSEQS = 1719, // 0x000006B7
		RPC_S_CANT_CREATE_ENDPOINT = 1720, // 0x000006B8
		RPC_S_OUT_OF_RESOURCES = 1721, // 0x000006B9
		RPC_S_SERVER_UNAVAILABLE = 1722, // 0x000006BA
		RPC_S_SERVER_TOO_BUSY = 1723, // 0x000006BB
		RPC_S_INVALID_NETWORK_OPTIONS = 1724, // 0x000006BC
		RPC_S_NO_CALL_ACTIVE = 1725, // 0x000006BD
		RPC_S_CALL_FAILED = 1726, // 0x000006BE
		RPC_S_CALL_FAILED_DNE = 1727, // 0x000006BF
		RPC_S_PROTOCOL_ERROR = 1728, // 0x000006C0
		RPC_S_PROXY_ACCESS_DENIED = 1729, // 0x000006C1
		RPC_S_UNSUPPORTED_TRANS_SYN = 1730, // 0x000006C2
		RPC_S_UNSUPPORTED_TYPE = 1732, // 0x000006C4
		RPC_S_INVALID_TAG = 1733, // 0x000006C5
		RPC_S_INVALID_BOUND = 1734, // 0x000006C6
		RPC_S_NO_ENTRY_NAME = 1735, // 0x000006C7
		RPC_S_INVALID_NAME_SYNTAX = 1736, // 0x000006C8
		RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737, // 0x000006C9
		RPC_S_UUID_NO_ADDRESS = 1739, // 0x000006CB
		RPC_S_DUPLICATE_ENDPOINT = 1740, // 0x000006CC
		RPC_S_UNKNOWN_AUTHN_TYPE = 1741, // 0x000006CD
		RPC_S_MAX_CALLS_TOO_SMALL = 1742, // 0x000006CE
		RPC_S_STRING_TOO_LONG = 1743, // 0x000006CF
		RPC_S_PROTSEQ_NOT_FOUND = 1744, // 0x000006D0
		RPC_S_PROCNUM_OUT_OF_RANGE = 1745, // 0x000006D1
		RPC_S_BINDING_HAS_NO_AUTH = 1746, // 0x000006D2
		RPC_S_UNKNOWN_AUTHN_SERVICE = 1747, // 0x000006D3
		RPC_S_UNKNOWN_AUTHN_LEVEL = 1748, // 0x000006D4
		RPC_S_INVALID_AUTH_IDENTITY = 1749, // 0x000006D5
		RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750, // 0x000006D6
		EPT_S_INVALID_ENTRY = 1751, // 0x000006D7
		EPT_S_CANT_PERFORM_OP = 1752, // 0x000006D8
		EPT_S_NOT_REGISTERED = 1753, // 0x000006D9
		RPC_S_NOTHING_TO_EXPORT = 1754, // 0x000006DA
		RPC_S_INCOMPLETE_NAME = 1755, // 0x000006DB
		RPC_S_INVALID_VERS_OPTION = 1756, // 0x000006DC
		RPC_S_NO_MORE_MEMBERS = 1757, // 0x000006DD
		RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758, // 0x000006DE
		RPC_S_INTERFACE_NOT_FOUND = 1759, // 0x000006DF
		RPC_S_ENTRY_ALREADY_EXISTS = 1760, // 0x000006E0
		RPC_S_ENTRY_NOT_FOUND = 1761, // 0x000006E1
		RPC_S_NAME_SERVICE_UNAVAILABLE = 1762, // 0x000006E2
		RPC_S_INVALID_NAF_ID = 1763, // 0x000006E3
		RPC_S_CANNOT_SUPPORT = 1764, // 0x000006E4
		RPC_S_NO_CONTEXT_AVAILABLE = 1765, // 0x000006E5
		RPC_S_INTERNAL_ERROR = 1766, // 0x000006E6
		RPC_S_ZERO_DIVIDE = 1767, // 0x000006E7
		RPC_S_ADDRESS_ERROR = 1768, // 0x000006E8
		RPC_S_FP_DIV_ZERO = 1769, // 0x000006E9
		RPC_S_FP_UNDERFLOW = 1770, // 0x000006EA
		RPC_S_FP_OVERFLOW = 1771, // 0x000006EB
		RPC_X_NO_MORE_ENTRIES = 1772, // 0x000006EC
		RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773, // 0x000006ED
		RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774, // 0x000006EE
		RPC_X_SS_IN_NULL_CONTEXT = 1775, // 0x000006EF
		RPC_X_SS_CONTEXT_DAMAGED = 1777, // 0x000006F1
		RPC_X_SS_HANDLES_MISMATCH = 1778, // 0x000006F2
		RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779, // 0x000006F3
		RPC_X_NULL_REF_POINTER = 1780, // 0x000006F4
		RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781, // 0x000006F5
		RPC_X_BYTE_COUNT_TOO_SMALL = 1782, // 0x000006F6
		RPC_X_BAD_STUB_DATA = 1783, // 0x000006F7
		ERROR_INVALID_USER_BUFFER = 1784, // 0x000006F8
		ERROR_UNRECOGNIZED_MEDIA = 1785, // 0x000006F9
		ERROR_NO_TRUST_LSA_SECRET = 1786, // 0x000006FA
		ERROR_NO_TRUST_SAM_ACCOUNT = 1787, // 0x000006FB
		ERROR_TRUSTED_DOMAIN_FAILURE = 1788, // 0x000006FC
		ERROR_TRUST_FAILURE = 1790, // 0x000006FE
		RPC_S_CALL_IN_PROGRESS = 1791, // 0x000006FF
		ERROR_NETLOGON_NOT_STARTED = 1792, // 0x00000700
		ERROR_ACCOUNT_EXPIRED = 1793, // 0x00000701
		ERROR_UNKNOWN_PORT = 1796, // 0x00000704
		ERROR_UNKNOWN_PRINTER_DRIVER = 1797, // 0x00000705
		ERROR_UNKNOWN_PRINTPROCESSOR = 1798, // 0x00000706
		ERROR_INVALID_SEPARATOR_FILE = 1799, // 0x00000707
		ERROR_INVALID_PRIORITY = 1800, // 0x00000708
		ERROR_INVALID_PRINTER_NAME = 1801, // 0x00000709
		ERROR_PRINTER_ALREADY_EXISTS = 1802, // 0x0000070A
		ERROR_INVALID_PRINTER_COMMAND = 1803, // 0x0000070B
		ERROR_INVALID_DATATYPE = 1804, // 0x0000070C
		ERROR_INVALID_ENVIRONMENT = 1805, // 0x0000070D
		RPC_S_NO_MORE_BINDINGS = 1806, // 0x0000070E
		ERROR_DOMAIN_TRUST_INCONSISTENT = 1810, // 0x00000712
		ERROR_SERVER_HAS_OPEN_HANDLES = 1811, // 0x00000713
		ERROR_RESOURCE_DATA_NOT_FOUND = 1812, // 0x00000714
		ERROR_RESOURCE_TYPE_NOT_FOUND = 1813, // 0x00000715
		ERROR_RESOURCE_NAME_NOT_FOUND = 1814, // 0x00000716
		ERROR_RESOURCE_LANG_NOT_FOUND = 1815, // 0x00000717
		ERROR_NOT_ENOUGH_QUOTA = 1816, // 0x00000718
		RPC_S_NO_INTERFACES = 1817, // 0x00000719
		RPC_S_CALL_CANCELLED = 1818, // 0x0000071A
		RPC_S_BINDING_INCOMPLETE = 1819, // 0x0000071B
		RPC_S_COMM_FAILURE = 1820, // 0x0000071C
		RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821, // 0x0000071D
		RPC_S_NO_PRINC_NAME = 1822, // 0x0000071E
		RPC_S_NOT_RPC_ERROR = 1823, // 0x0000071F
		RPC_S_UUID_LOCAL_ONLY = 1824, // 0x00000720
		RPC_S_SEC_PKG_ERROR = 1825, // 0x00000721
		RPC_S_NOT_CANCELLED = 1826, // 0x00000722
		RPC_X_INVALID_ES_ACTION = 1827, // 0x00000723
		RPC_X_WRONG_ES_VERSION = 1828, // 0x00000724
		RPC_X_WRONG_STUB_VERSION = 1829, // 0x00000725
		RPC_X_INVALID_PIPE_OBJECT = 1830, // 0x00000726
		RPC_X_WRONG_PIPE_ORDER = 1831, // 0x00000727
		RPC_X_WRONG_PIPE_VERSION = 1832, // 0x00000728
		RPC_S_COOKIE_AUTH_FAILED = 1833, // 0x00000729
		RPC_S_DO_NOT_DISTURB = 1834, // 0x0000072A
		RPC_S_GROUP_MEMBER_NOT_FOUND = 1898, // 0x0000076A
		EPT_S_CANT_CREATE = 1899, // 0x0000076B
		RPC_S_INVALID_OBJECT = 1900, // 0x0000076C
		ERROR_INVALID_TIME = 1901, // 0x0000076D
		ERROR_INVALID_FORM_NAME = 1902, // 0x0000076E
		ERROR_INVALID_FORM_SIZE = 1903, // 0x0000076F
		ERROR_ALREADY_WAITING = 1904, // 0x00000770
		ERROR_PRINTER_DELETED = 1905, // 0x00000771
		ERROR_INVALID_PRINTER_STATE = 1906, // 0x00000772
		ERROR_PASSWORD_MUST_CHANGE = 1907, // 0x00000773
		ERROR_ACCOUNT_LOCKED_OUT = 1909, // 0x00000775
		OR_INVALID_OXID = 1910, // 0x00000776
		OR_INVALID_OID = 1911, // 0x00000777
		OR_INVALID_SET = 1912, // 0x00000778
		RPC_S_SEND_INCOMPLETE = 1913, // 0x00000779
		RPC_S_INVALID_ASYNC_HANDLE = 1914, // 0x0000077A
		RPC_S_INVALID_ASYNC_CALL = 1915, // 0x0000077B
		RPC_X_PIPE_CLOSED = 1916, // 0x0000077C
		RPC_X_PIPE_DISCIPLINE_ERROR = 1917, // 0x0000077D
		RPC_X_PIPE_EMPTY = 1918, // 0x0000077E
		ERROR_NO_SITENAME = 1919, // 0x0000077F
		ERROR_CANT_ACCESS_FILE = 1920, // 0x00000780
		ERROR_CANT_RESOLVE_FILENAME = 1921, // 0x00000781
		RPC_S_ENTRY_TYPE_MISMATCH = 1922, // 0x00000782
		RPC_S_NOT_ALL_OBJS_EXPORTED = 1923, // 0x00000783
		RPC_S_INTERFACE_NOT_EXPORTED = 1924, // 0x00000784
		RPC_S_PROFILE_NOT_ADDED = 1925, // 0x00000785
		RPC_S_PRF_ELT_NOT_ADDED = 1926, // 0x00000786
		RPC_S_PRF_ELT_NOT_REMOVED = 1927, // 0x00000787
		RPC_S_GRP_ELT_NOT_ADDED = 1928, // 0x00000788
		RPC_S_GRP_ELT_NOT_REMOVED = 1929, // 0x00000789
		ERROR_KM_DRIVER_BLOCKED = 1930, // 0x0000078A
		ERROR_CONTEXT_EXPIRED = 1931, // 0x0000078B
		ERROR_NTLM_BLOCKED = 1937, // 0x00000791
		ERROR_PASSWORD_CHANGE_REQUIRED = 1938, // 0x00000792
		ERROR_INVALID_PIXEL_FORMAT = 2000, // 0x000007D0
		ERROR_BAD_DRIVER = 2001, // 0x000007D1
		ERROR_INVALID_WINDOW_STYLE = 2002, // 0x000007D2
		ERROR_METAFILE_NOT_SUPPORTED = 2003, // 0x000007D3
		ERROR_TRANSFORM_NOT_SUPPORTED = 2004, // 0x000007D4
		ERROR_CLIPPING_NOT_SUPPORTED = 2005, // 0x000007D5
		ERROR_INVALID_CMM = 2010, // 0x000007DA
		ERROR_INVALID_PROFILE = 2011, // 0x000007DB
		ERROR_TAG_NOT_FOUND = 2012, // 0x000007DC
		ERROR_TAG_NOT_PRESENT = 2013, // 0x000007DD
		ERROR_DUPLICATE_TAG = 2014, // 0x000007DE
		ERROR_PROFILE_NOT_FOUND = 2016, // 0x000007E0
		ERROR_INVALID_COLORSPACE = 2017, // 0x000007E1
		ERROR_ICM_NOT_ENABLED = 2018, // 0x000007E2
		ERROR_DELETING_ICM_XFORM = 2019, // 0x000007E3
		ERROR_INVALID_TRANSFORM = 2020, // 0x000007E4
		ERROR_COLORSPACE_MISMATCH = 2021, // 0x000007E5
		ERROR_INVALID_COLORINDEX = 2022, // 0x000007E6
		NERR_NetNotStarted = 2102, // 0x00000836
		NERR_UnknownServer = 2103, // 0x00000837
		NERR_ShareMem = 2104, // 0x00000838
		NERR_NoNetworkResource = 2105, // 0x00000839
		NERR_RemoteOnly = 2106, // 0x0000083A
		NERR_DevNotRedirected = 2107, // 0x0000083B
		ERROR_CONNECTED_OTHER_PASSWORD = 2108, // 0x0000083C
		NERR_ServerNotStarted = 2114, // 0x00000842
		NERR_ItemNotFound = 2115, // 0x00000843
		NERR_UnknownDevDir = 2116, // 0x00000844
		NERR_RedirectedPath = 2117, // 0x00000845
		NERR_DuplicateShare = 2118, // 0x00000846
		NERR_NoRoom = 2119, // 0x00000847
		NERR_TooManyItems = 2121, // 0x00000849
		NERR_InvalidMaxUsers = 2122, // 0x0000084A
		NERR_BufTooSmall = 2123, // 0x0000084B
		NERR_RemoteErr = 2127, // 0x0000084F
		NERR_LanmanIniError = 2131, // 0x00000853
		NERR_NetworkError = 2136, // 0x00000858
		NERR_WkstaInconsistentState = 2137, // 0x00000859
		NERR_WkstaNotStarted = 2138, // 0x0000085A
		NERR_BrowserNotStarted = 2139, // 0x0000085B
		NERR_InternalError = 2140, // 0x0000085C
		NERR_BadTransactConfig = 2141, // 0x0000085D
		NERR_InvalidAPI = 2142, // 0x0000085E
		NERR_BadEventName = 2143, // 0x0000085F
		NERR_DupNameReboot = 2144, // 0x00000860
		NERR_CfgCompNotFound = 2146, // 0x00000862
		NERR_CfgParamNotFound = 2147, // 0x00000863
		NERR_LineTooLong = 2149, // 0x00000865
		NERR_QNotFound = 2150, // 0x00000866
		NERR_JobNotFound = 2151, // 0x00000867
		NERR_DestNotFound = 2152, // 0x00000868
		NERR_DestExists = 2153, // 0x00000869
		NERR_QExists = 2154, // 0x0000086A
		NERR_QNoRoom = 2155, // 0x0000086B
		NERR_JobNoRoom = 2156, // 0x0000086C
		NERR_DestNoRoom = 2157, // 0x0000086D
		NERR_DestIdle = 2158, // 0x0000086E
		NERR_DestInvalidOp = 2159, // 0x0000086F
		NERR_ProcNoRespond = 2160, // 0x00000870
		NERR_SpoolerNotLoaded = 2161, // 0x00000871
		NERR_DestInvalidState = 2162, // 0x00000872
		NERR_QInvalidState = 2163, // 0x00000873
		NERR_JobInvalidState = 2164, // 0x00000874
		NERR_SpoolNoMemory = 2165, // 0x00000875
		NERR_DriverNotFound = 2166, // 0x00000876
		NERR_DataTypeInvalid = 2167, // 0x00000877
		NERR_ProcNotFound = 2168, // 0x00000878
		NERR_ServiceTableLocked = 2180, // 0x00000884
		NERR_ServiceTableFull = 2181, // 0x00000885
		NERR_ServiceInstalled = 2182, // 0x00000886
		NERR_ServiceEntryLocked = 2183, // 0x00000887
		NERR_ServiceNotInstalled = 2184, // 0x00000888
		NERR_BadServiceName = 2185, // 0x00000889
		NERR_ServiceCtlTimeout = 2186, // 0x0000088A
		NERR_ServiceCtlBusy = 2187, // 0x0000088B
		NERR_BadServiceProgName = 2188, // 0x0000088C
		NERR_ServiceNotCtrl = 2189, // 0x0000088D
		NERR_ServiceKillProc = 2190, // 0x0000088E
		NERR_ServiceCtlNotValid = 2191, // 0x0000088F
		NERR_NotInDispatchTbl = 2192, // 0x00000890
		NERR_BadControlRecv = 2193, // 0x00000891
		NERR_ServiceNotStarting = 2194, // 0x00000892
		NERR_AlreadyLoggedOn = 2200, // 0x00000898
		NERR_NotLoggedOn = 2201, // 0x00000899
		ERROR_BAD_USERNAME = 2202, // 0x0000089A
		NERR_BadUsername = 2202, // 0x0000089A
		NERR_BadPassword = 2203, // 0x0000089B
		NERR_UnableToAddName_W = 2204, // 0x0000089C
		NERR_UnableToAddName_F = 2205, // 0x0000089D
		NERR_UnableToDelName_W = 2206, // 0x0000089E
		NERR_UnableToDelName_F = 2207, // 0x0000089F
		NERR_LogonsPaused = 2209, // 0x000008A1
		NERR_LogonServerConflict = 2210, // 0x000008A2
		NERR_LogonNoUserPath = 2211, // 0x000008A3
		NERR_LogonScriptError = 2212, // 0x000008A4
		NERR_StandaloneLogon = 2214, // 0x000008A6
		NERR_LogonServerNotFound = 2215, // 0x000008A7
		NERR_LogonDomainExists = 2216, // 0x000008A8
		NERR_NonValidatedLogon = 2217, // 0x000008A9
		NERR_ACFNotFound = 2219, // 0x000008AB
		NERR_GroupNotFound = 2220, // 0x000008AC
		NERR_UserNotFound = 2221, // 0x000008AD
		NERR_ResourceNotFound = 2222, // 0x000008AE
		NERR_GroupExists = 2223, // 0x000008AF
		NERR_UserExists = 2224, // 0x000008B0
		NERR_ResourceExists = 2225, // 0x000008B1
		NERR_NotPrimary = 2226, // 0x000008B2
		NERR_ACFNotLoaded = 2227, // 0x000008B3
		NERR_ACFNoRoom = 2228, // 0x000008B4
		NERR_ACFFileIOFail = 2229, // 0x000008B5
		NERR_ACFTooManyLists = 2230, // 0x000008B6
		NERR_UserLogon = 2231, // 0x000008B7
		NERR_ACFNoParent = 2232, // 0x000008B8
		NERR_CanNotGrowSegment = 2233, // 0x000008B9
		NERR_SpeGroupOp = 2234, // 0x000008BA
		NERR_NotInCache = 2235, // 0x000008BB
		NERR_UserInGroup = 2236, // 0x000008BC
		NERR_UserNotInGroup = 2237, // 0x000008BD
		NERR_AccountUndefined = 2238, // 0x000008BE
		NERR_AccountExpired = 2239, // 0x000008BF
		NERR_InvalidWorkstation = 2240, // 0x000008C0
		NERR_InvalidLogonHours = 2241, // 0x000008C1
		NERR_PasswordExpired = 2242, // 0x000008C2
		NERR_PasswordCantChange = 2243, // 0x000008C3
		NERR_PasswordHistConflict = 2244, // 0x000008C4
		NERR_PasswordTooShort = 2245, // 0x000008C5
		NERR_PasswordTooRecent = 2246, // 0x000008C6
		NERR_InvalidDatabase = 2247, // 0x000008C7
		NERR_DatabaseUpToDate = 2248, // 0x000008C8
		NERR_SyncRequired = 2249, // 0x000008C9
		ERROR_NOT_CONNECTED = 2250, // 0x000008CA
		NERR_UseNotFound = 2250, // 0x000008CA
		NERR_BadAsgType = 2251, // 0x000008CB
		NERR_DeviceIsShared = 2252, // 0x000008CC
		NERR_SameAsComputerName = 2253, // 0x000008CD
		NERR_NoComputerName = 2270, // 0x000008DE
		NERR_MsgAlreadyStarted = 2271, // 0x000008DF
		NERR_MsgInitFailed = 2272, // 0x000008E0
		NERR_NameNotFound = 2273, // 0x000008E1
		NERR_AlreadyForwarded = 2274, // 0x000008E2
		NERR_AddForwarded = 2275, // 0x000008E3
		NERR_AlreadyExists = 2276, // 0x000008E4
		NERR_TooManyNames = 2277, // 0x000008E5
		NERR_DelComputerName = 2278, // 0x000008E6
		NERR_LocalForward = 2279, // 0x000008E7
		NERR_GrpMsgProcessor = 2280, // 0x000008E8
		NERR_PausedRemote = 2281, // 0x000008E9
		NERR_BadReceive = 2282, // 0x000008EA
		NERR_NameInUse = 2283, // 0x000008EB
		NERR_MsgNotStarted = 2284, // 0x000008EC
		NERR_NotLocalName = 2285, // 0x000008ED
		NERR_NoForwardName = 2286, // 0x000008EE
		NERR_RemoteFull = 2287, // 0x000008EF
		NERR_NameNotForwarded = 2288, // 0x000008F0
		NERR_TruncatedBroadcast = 2289, // 0x000008F1
		NERR_InvalidDevice = 2294, // 0x000008F6
		NERR_WriteFault = 2295, // 0x000008F7
		NERR_DuplicateName = 2297, // 0x000008F9
		NERR_DeleteLater = 2298, // 0x000008FA
		NERR_IncompleteDel = 2299, // 0x000008FB
		NERR_MultipleNets = 2300, // 0x000008FC
		NERR_NetNameNotFound = 2310, // 0x00000906
		NERR_DeviceNotShared = 2311, // 0x00000907
		NERR_ClientNameNotFound = 2312, // 0x00000908
		NERR_FileIdNotFound = 2314, // 0x0000090A
		NERR_ExecFailure = 2315, // 0x0000090B
		NERR_TmpFile = 2316, // 0x0000090C
		NERR_TooMuchData = 2317, // 0x0000090D
		NERR_DeviceShareConflict = 2318, // 0x0000090E
		NERR_BrowserTableIncomplete = 2319, // 0x0000090F
		NERR_NotLocalDomain = 2320, // 0x00000910
		NERR_IsDfsShare = 2321, // 0x00000911
		NERR_DevInvalidOpCode = 2331, // 0x0000091B
		NERR_DevNotFound = 2332, // 0x0000091C
		NERR_DevNotOpen = 2333, // 0x0000091D
		NERR_BadQueueDevString = 2334, // 0x0000091E
		NERR_BadQueuePriority = 2335, // 0x0000091F
		NERR_NoCommDevs = 2337, // 0x00000921
		NERR_QueueNotFound = 2338, // 0x00000922
		NERR_BadDevString = 2340, // 0x00000924
		NERR_BadDev = 2341, // 0x00000925
		NERR_InUseBySpooler = 2342, // 0x00000926
		NERR_CommDevInUse = 2343, // 0x00000927
		NERR_InvalidComputer = 2351, // 0x0000092F
		NERR_MaxLenExceeded = 2354, // 0x00000932
		NERR_BadComponent = 2356, // 0x00000934
		NERR_CantType = 2357, // 0x00000935
		NERR_TooManyEntries = 2362, // 0x0000093A
		NERR_ProfileFileTooBig = 2370, // 0x00000942
		NERR_ProfileOffset = 2371, // 0x00000943
		NERR_ProfileCleanup = 2372, // 0x00000944
		NERR_ProfileUnknownCmd = 2373, // 0x00000945
		NERR_ProfileLoadErr = 2374, // 0x00000946
		NERR_ProfileSaveErr = 2375, // 0x00000947
		NERR_LogOverflow = 2377, // 0x00000949
		NERR_LogFileChanged = 2378, // 0x0000094A
		NERR_LogFileCorrupt = 2379, // 0x0000094B
		NERR_SourceIsDir = 2380, // 0x0000094C
		NERR_BadSource = 2381, // 0x0000094D
		NERR_BadDest = 2382, // 0x0000094E
		NERR_DifferentServers = 2383, // 0x0000094F
		NERR_RunSrvPaused = 2385, // 0x00000951
		NERR_ErrCommRunSrv = 2389, // 0x00000955
		NERR_ErrorExecingGhost = 2391, // 0x00000957
		NERR_ShareNotFound = 2392, // 0x00000958
		NERR_InvalidLana = 2400, // 0x00000960
		ERROR_OPEN_FILES = 2401, // 0x00000961
		NERR_OpenFiles = 2401, // 0x00000961
		ERROR_ACTIVE_CONNECTIONS = 2402, // 0x00000962
		NERR_ActiveConns = 2402, // 0x00000962
		NERR_BadPasswordCore = 2403, // 0x00000963
		ERROR_DEVICE_IN_USE = 2404, // 0x00000964
		NERR_DevInUse = 2404, // 0x00000964
		NERR_LocalDrive = 2405, // 0x00000965
		NERR_AlertExists = 2430, // 0x0000097E
		NERR_TooManyAlerts = 2431, // 0x0000097F
		NERR_NoSuchAlert = 2432, // 0x00000980
		NERR_BadRecipient = 2433, // 0x00000981
		NERR_AcctLimitExceeded = 2434, // 0x00000982
		NERR_InvalidLogSeek = 2440, // 0x00000988
		NERR_BadUasConfig = 2450, // 0x00000992
		NERR_InvalidUASOp = 2451, // 0x00000993
		NERR_LastAdmin = 2452, // 0x00000994
		NERR_DCNotFound = 2453, // 0x00000995
		NERR_LogonTrackingError = 2454, // 0x00000996
		NERR_NetlogonNotStarted = 2455, // 0x00000997
		NERR_CanNotGrowUASFile = 2456, // 0x00000998
		NERR_TimeDiffAtDC = 2457, // 0x00000999
		NERR_PasswordMismatch = 2458, // 0x0000099A
		NERR_NoSuchServer = 2460, // 0x0000099C
		NERR_NoSuchSession = 2461, // 0x0000099D
		NERR_NoSuchConnection = 2462, // 0x0000099E
		NERR_TooManyServers = 2463, // 0x0000099F
		NERR_TooManySessions = 2464, // 0x000009A0
		NERR_TooManyConnections = 2465, // 0x000009A1
		NERR_TooManyFiles = 2466, // 0x000009A2
		NERR_NoAlternateServers = 2467, // 0x000009A3
		NERR_TryDownLevel = 2470, // 0x000009A6
		NERR_UPSDriverNotStarted = 2480, // 0x000009B0
		NERR_UPSInvalidConfig = 2481, // 0x000009B1
		NERR_UPSInvalidCommPort = 2482, // 0x000009B2
		NERR_UPSSignalAsserted = 2483, // 0x000009B3
		NERR_UPSShutdownFailed = 2484, // 0x000009B4
		NERR_BadDosRetCode = 2500, // 0x000009C4
		NERR_ProgNeedsExtraMem = 2501, // 0x000009C5
		NERR_BadDosFunction = 2502, // 0x000009C6
		NERR_RemoteBootFailed = 2503, // 0x000009C7
		NERR_BadFileCheckSum = 2504, // 0x000009C8
		NERR_NoRplBootSystem = 2505, // 0x000009C9
		NERR_RplLoadrNetBiosErr = 2506, // 0x000009CA
		NERR_RplLoadrDiskErr = 2507, // 0x000009CB
		NERR_ImageParamErr = 2508, // 0x000009CC
		NERR_TooManyImageParams = 2509, // 0x000009CD
		NERR_NonDosFloppyUsed = 2510, // 0x000009CE
		NERR_RplBootRestart = 2511, // 0x000009CF
		NERR_RplSrvrCallFailed = 2512, // 0x000009D0
		NERR_CantConnectRplSrvr = 2513, // 0x000009D1
		NERR_CantOpenImageFile = 2514, // 0x000009D2
		NERR_CallingRplSrvr = 2515, // 0x000009D3
		NERR_StartingRplBoot = 2516, // 0x000009D4
		NERR_RplBootServiceTerm = 2517, // 0x000009D5
		NERR_RplBootStartFailed = 2518, // 0x000009D6
		NERR_RPL_CONNECTED = 2519, // 0x000009D7
		NERR_BrowserConfiguredToNotRun = 2550, // 0x000009F6
		NERR_RplNoAdaptersStarted = 2610, // 0x00000A32
		NERR_RplBadRegistry = 2611, // 0x00000A33
		NERR_RplBadDatabase = 2612, // 0x00000A34
		NERR_RplRplfilesShare = 2613, // 0x00000A35
		NERR_RplNotRplServer = 2614, // 0x00000A36
		NERR_RplCannotEnum = 2615, // 0x00000A37
		NERR_RplWkstaInfoCorrupted = 2616, // 0x00000A38
		NERR_RplWkstaNotFound = 2617, // 0x00000A39
		NERR_RplWkstaNameUnavailable = 2618, // 0x00000A3A
		NERR_RplProfileInfoCorrupted = 2619, // 0x00000A3B
		NERR_RplProfileNotFound = 2620, // 0x00000A3C
		NERR_RplProfileNameUnavailable = 2621, // 0x00000A3D
		NERR_RplProfileNotEmpty = 2622, // 0x00000A3E
		NERR_RplConfigInfoCorrupted = 2623, // 0x00000A3F
		NERR_RplConfigNotFound = 2624, // 0x00000A40
		NERR_RplAdapterInfoCorrupted = 2625, // 0x00000A41
		NERR_RplInternal = 2626, // 0x00000A42
		NERR_RplVendorInfoCorrupted = 2627, // 0x00000A43
		NERR_RplBootInfoCorrupted = 2628, // 0x00000A44
		NERR_RplWkstaNeedsUserAcct = 2629, // 0x00000A45
		NERR_RplNeedsRPLUSERAcct = 2630, // 0x00000A46
		NERR_RplBootNotFound = 2631, // 0x00000A47
		NERR_RplIncompatibleProfile = 2632, // 0x00000A48
		NERR_RplAdapterNameUnavailable = 2633, // 0x00000A49
		NERR_RplConfigNotEmpty = 2634, // 0x00000A4A
		NERR_RplBootInUse = 2635, // 0x00000A4B
		NERR_RplBackupDatabase = 2636, // 0x00000A4C
		NERR_RplAdapterNotFound = 2637, // 0x00000A4D
		NERR_RplVendorNotFound = 2638, // 0x00000A4E
		NERR_RplVendorNameUnavailable = 2639, // 0x00000A4F
		NERR_RplBootNameUnavailable = 2640, // 0x00000A50
		NERR_RplConfigNameUnavailable = 2641, // 0x00000A51
		NERR_DfsInternalCorruption = 2660, // 0x00000A64
		NERR_DfsVolumeDataCorrupt = 2661, // 0x00000A65
		NERR_DfsNoSuchVolume = 2662, // 0x00000A66
		NERR_DfsVolumeAlreadyExists = 2663, // 0x00000A67
		NERR_DfsAlreadyShared = 2664, // 0x00000A68
		NERR_DfsNoSuchShare = 2665, // 0x00000A69
		NERR_DfsNotALeafVolume = 2666, // 0x00000A6A
		NERR_DfsLeafVolume = 2667, // 0x00000A6B
		NERR_DfsVolumeHasMultipleServers = 2668, // 0x00000A6C
		NERR_DfsCantCreateJunctionPoint = 2669, // 0x00000A6D
		NERR_DfsServerNotDfsAware = 2670, // 0x00000A6E
		NERR_DfsBadRenamePath = 2671, // 0x00000A6F
		NERR_DfsVolumeIsOffline = 2672, // 0x00000A70
		NERR_DfsNoSuchServer = 2673, // 0x00000A71
		NERR_DfsCyclicalName = 2674, // 0x00000A72
		NERR_DfsNotSupportedInServerDfs = 2675, // 0x00000A73
		NERR_DfsDuplicateService = 2676, // 0x00000A74
		NERR_DfsCantRemoveLastServerShare = 2677, // 0x00000A75
		NERR_DfsVolumeIsInterDfs = 2678, // 0x00000A76
		NERR_DfsInconsistent = 2679, // 0x00000A77
		NERR_DfsServerUpgraded = 2680, // 0x00000A78
		NERR_DfsDataIsIdentical = 2681, // 0x00000A79
		NERR_DfsCantRemoveDfsRoot = 2682, // 0x00000A7A
		NERR_DfsChildOrParentInDfs = 2683, // 0x00000A7B
		NERR_DfsInternalError = 2690, // 0x00000A82
		NERR_SetupAlreadyJoined = 2691, // 0x00000A83
		NERR_SetupNotJoined = 2692, // 0x00000A84
		NERR_SetupDomainController = 2693, // 0x00000A85
		NERR_DefaultJoinRequired = 2694, // 0x00000A86
		NERR_InvalidWorkgroupName = 2695, // 0x00000A87
		NERR_NameUsesIncompatibleCodePage = 2696, // 0x00000A88
		NERR_ComputerAccountNotFound = 2697, // 0x00000A89
		NERR_PersonalSku = 2698, // 0x00000A8A
		NERR_SetupCheckDNSConfig = 2699, // 0x00000A8B
		NERR_PasswordMustChange = 2701, // 0x00000A8D
		NERR_AccountLockedOut = 2702, // 0x00000A8E
		NERR_PasswordTooLong = 2703, // 0x00000A8F
		NERR_PasswordNotComplexEnough = 2704, // 0x00000A90
		NERR_PasswordFilterError = 2705, // 0x00000A91
		NERR_NoOfflineJoinInfo = 2709, // 0x00000A95
		NERR_BadOfflineJoinInfo = 2710, // 0x00000A96
		NERR_CantCreateJoinInfo = 2711, // 0x00000A97
		NERR_BadDomainJoinInfo = 2712, // 0x00000A98
		NERR_JoinPerformedMustRestart = 2713, // 0x00000A99
		NERR_NoJoinPending = 2714, // 0x00000A9A
		NERR_ValuesNotSet = 2715, // 0x00000A9B
		NERR_CantVerifyHostname = 2716, // 0x00000A9C
		NERR_CantLoadOfflineHive = 2717, // 0x00000A9D
		NERR_ConnectionInsecure = 2718, // 0x00000A9E
		NERR_ProvisioningBlobUnsupported = 2719, // 0x00000A9F
		NERR_DS8DCRequired = 2720, // 0x00000AA0
		NERR_LDAPCapableDCRequired = 2721, // 0x00000AA1
		NERR_DS8DCNotFound = 2722, // 0x00000AA2
		NERR_TargetVersionUnsupported = 2723, // 0x00000AA3
		NERR_InvalidMachineNameForJoin = 2724, // 0x00000AA4
		NERR_DS9DCNotFound = 2725, // 0x00000AA5
		ERROR_UNKNOWN_PRINT_MONITOR = 3000, // 0x00000BB8
		ERROR_PRINTER_DRIVER_IN_USE = 3001, // 0x00000BB9
		ERROR_SPOOL_FILE_NOT_FOUND = 3002, // 0x00000BBA
		ERROR_SPL_NO_STARTDOC = 3003, // 0x00000BBB
		ERROR_SPL_NO_ADDJOB = 3004, // 0x00000BBC
		ERROR_INVALID_PRINT_MONITOR = 3007, // 0x00000BBF
		ERROR_PRINT_MONITOR_IN_USE = 3008, // 0x00000BC0
		ERROR_PRINTER_HAS_JOBS_QUEUED = 3009, // 0x00000BC1
		ERROR_SUCCESS_REBOOT_REQUIRED = 3010, // 0x00000BC2
		ERROR_SUCCESS_RESTART_REQUIRED = 3011, // 0x00000BC3
		ERROR_PRINTER_NOT_FOUND = 3012, // 0x00000BC4
		ERROR_PRINTER_DRIVER_WARNED = 3013, // 0x00000BC5
		ERROR_PRINTER_DRIVER_BLOCKED = 3014, // 0x00000BC6
		ERROR_FAIL_REBOOT_REQUIRED = 3017, // 0x00000BC9
		ERROR_FAIL_REBOOT_INITIATED = 3018, // 0x00000BCA
		ERROR_PRINTER_NOT_SHAREABLE = 3022, // 0x00000BCE
		ERROR_REQUEST_PAUSED = 3050, // 0x00000BEA
		ERROR_IO_REISSUE_AS_CACHED = 3950, // 0x00000F6E
		ERROR_WINS_INTERNAL = 4000, // 0x00000FA0
		ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001, // 0x00000FA1
		ERROR_STATIC_INIT = 4002, // 0x00000FA2
		ERROR_INC_BACKUP = 4003, // 0x00000FA3
		ERROR_FULL_BACKUP = 4004, // 0x00000FA4
		ERROR_REC_NON_EXISTENT = 4005, // 0x00000FA5
		ERROR_RPL_NOT_ALLOWED = 4006, // 0x00000FA6
		PEERDIST_ERROR_MISSING_DATA = 4052, // 0x00000FD4
		PEERDIST_ERROR_NO_MORE = 4053, // 0x00000FD5
		PEERDIST_ERROR_NOT_INITIALIZED = 4054, // 0x00000FD6
		PEERDIST_ERROR_INVALIDATED = 4057, // 0x00000FD9
		PEERDIST_ERROR_ALREADY_EXISTS = 4058, // 0x00000FDA
		PEERDIST_ERROR_OUT_OF_BOUNDS = 4061, // 0x00000FDD
		PEERDIST_ERROR_NOT_LICENSED = 4064, // 0x00000FE0
		PEERDIST_ERROR_TRUST_FAILURE = 4066, // 0x00000FE2
		ERROR_DHCP_ADDRESS_CONFLICT = 4100, // 0x00001004
		ERROR_WMI_GUID_NOT_FOUND = 4200, // 0x00001068
		ERROR_WMI_INSTANCE_NOT_FOUND = 4201, // 0x00001069
		ERROR_WMI_ITEMID_NOT_FOUND = 4202, // 0x0000106A
		ERROR_WMI_TRY_AGAIN = 4203, // 0x0000106B
		ERROR_WMI_DP_NOT_FOUND = 4204, // 0x0000106C
		ERROR_WMI_ALREADY_ENABLED = 4206, // 0x0000106E
		ERROR_WMI_GUID_DISCONNECTED = 4207, // 0x0000106F
		ERROR_WMI_SERVER_UNAVAILABLE = 4208, // 0x00001070
		ERROR_WMI_DP_FAILED = 4209, // 0x00001071
		ERROR_WMI_INVALID_MOF = 4210, // 0x00001072
		ERROR_WMI_INVALID_REGINFO = 4211, // 0x00001073
		ERROR_WMI_ALREADY_DISABLED = 4212, // 0x00001074
		ERROR_WMI_READ_ONLY = 4213, // 0x00001075
		ERROR_WMI_SET_FAILURE = 4214, // 0x00001076
		ERROR_NOT_APPCONTAINER = 4250, // 0x0000109A
		ERROR_APPCONTAINER_REQUIRED = 4251, // 0x0000109B
		ERROR_INVALID_MEDIA = 4300, // 0x000010CC
		ERROR_INVALID_LIBRARY = 4301, // 0x000010CD
		ERROR_INVALID_MEDIA_POOL = 4302, // 0x000010CE
		ERROR_DRIVE_MEDIA_MISMATCH = 4303, // 0x000010CF
		ERROR_MEDIA_OFFLINE = 4304, // 0x000010D0
		ERROR_LIBRARY_OFFLINE = 4305, // 0x000010D1
		ERROR_EMPTY = 4306, // 0x000010D2
		ERROR_NOT_EMPTY = 4307, // 0x000010D3
		ERROR_MEDIA_UNAVAILABLE = 4308, // 0x000010D4
		ERROR_RESOURCE_DISABLED = 4309, // 0x000010D5
		ERROR_INVALID_CLEANER = 4310, // 0x000010D6
		ERROR_UNABLE_TO_CLEAN = 4311, // 0x000010D7
		ERROR_OBJECT_NOT_FOUND = 4312, // 0x000010D8
		ERROR_DATABASE_FAILURE = 4313, // 0x000010D9
		ERROR_DATABASE_FULL = 4314, // 0x000010DA
		ERROR_MEDIA_INCOMPATIBLE = 4315, // 0x000010DB
		ERROR_RESOURCE_NOT_PRESENT = 4316, // 0x000010DC
		ERROR_INVALID_OPERATION = 4317, // 0x000010DD
		ERROR_MEDIA_NOT_AVAILABLE = 4318, // 0x000010DE
		ERROR_DEVICE_NOT_AVAILABLE = 4319, // 0x000010DF
		ERROR_REQUEST_REFUSED = 4320, // 0x000010E0
		ERROR_INVALID_DRIVE_OBJECT = 4321, // 0x000010E1
		ERROR_LIBRARY_FULL = 4322, // 0x000010E2
		ERROR_MEDIUM_NOT_ACCESSIBLE = 4323, // 0x000010E3
		ERROR_UNABLE_TO_LOAD_MEDIUM = 4324, // 0x000010E4
		ERROR_UNABLE_TO_INVENTORY_DRIVE = 4325, // 0x000010E5
		ERROR_UNABLE_TO_INVENTORY_SLOT = 4326, // 0x000010E6
		ERROR_TRANSPORT_FULL = 4328, // 0x000010E8
		ERROR_CONTROLLING_IEPORT = 4329, // 0x000010E9
		ERROR_CLEANER_SLOT_SET = 4331, // 0x000010EB
		ERROR_CLEANER_SLOT_NOT_SET = 4332, // 0x000010EC
		ERROR_CLEANER_CARTRIDGE_SPENT = 4333, // 0x000010ED
		ERROR_UNEXPECTED_OMID = 4334, // 0x000010EE
		ERROR_CANT_DELETE_LAST_ITEM = 4335, // 0x000010EF
		ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336, // 0x000010F0
		ERROR_VOLUME_CONTAINS_SYS_FILES = 4337, // 0x000010F1
		ERROR_INDIGENOUS_TYPE = 4338, // 0x000010F2
		ERROR_NO_SUPPORTING_DRIVES = 4339, // 0x000010F3
		ERROR_IEPORT_FULL = 4341, // 0x000010F5
		ERROR_FILE_OFFLINE = 4350, // 0x000010FE
		ERROR_REMOTE_STORAGE_NOT_ACTIVE = 4351, // 0x000010FF
		ERROR_NOT_A_REPARSE_POINT = 4390, // 0x00001126
		ERROR_INVALID_REPARSE_DATA = 4392, // 0x00001128
		ERROR_REPARSE_TAG_INVALID = 4393, // 0x00001129
		ERROR_REPARSE_TAG_MISMATCH = 4394, // 0x0000112A
		ERROR_APP_DATA_NOT_FOUND = 4400, // 0x00001130
		ERROR_APP_DATA_EXPIRED = 4401, // 0x00001131
		ERROR_APP_DATA_CORRUPT = 4402, // 0x00001132
		ERROR_APP_DATA_LIMIT_EXCEEDED = 4403, // 0x00001133
		ERROR_APP_DATA_REBOOT_REQUIRED = 4404, // 0x00001134
		ERROR_SECUREBOOT_INVALID_POLICY = 4422, // 0x00001146
		ERROR_SECUREBOOT_NOT_ENABLED = 4425, // 0x00001149
		ERROR_SECUREBOOT_FILE_REPLACED = 4426, // 0x0000114A
		ERROR_VOLUME_NOT_SIS_ENABLED = 4500, // 0x00001194
		ERROR_VSM_NOT_INITIALIZED = 4560, // 0x000011D0
		ERROR_DEPENDENT_RESOURCE_EXISTS = 5001, // 0x00001389
		ERROR_DEPENDENCY_NOT_FOUND = 5002, // 0x0000138A
		ERROR_DEPENDENCY_ALREADY_EXISTS = 5003, // 0x0000138B
		ERROR_RESOURCE_NOT_ONLINE = 5004, // 0x0000138C
		ERROR_HOST_NODE_NOT_AVAILABLE = 5005, // 0x0000138D
		ERROR_RESOURCE_NOT_AVAILABLE = 5006, // 0x0000138E
		ERROR_RESOURCE_NOT_FOUND = 5007, // 0x0000138F
		ERROR_SHUTDOWN_CLUSTER = 5008, // 0x00001390
		ERROR_CANT_EVICT_ACTIVE_NODE = 5009, // 0x00001391
		ERROR_OBJECT_ALREADY_EXISTS = 5010, // 0x00001392
		ERROR_OBJECT_IN_LIST = 5011, // 0x00001393
		ERROR_GROUP_NOT_AVAILABLE = 5012, // 0x00001394
		ERROR_GROUP_NOT_FOUND = 5013, // 0x00001395
		ERROR_GROUP_NOT_ONLINE = 5014, // 0x00001396
		ERROR_HOST_NODE_NOT_GROUP_OWNER = 5016, // 0x00001398
		ERROR_RESMON_CREATE_FAILED = 5017, // 0x00001399
		ERROR_RESMON_ONLINE_FAILED = 5018, // 0x0000139A
		ERROR_RESOURCE_ONLINE = 5019, // 0x0000139B
		ERROR_QUORUM_RESOURCE = 5020, // 0x0000139C
		ERROR_NOT_QUORUM_CAPABLE = 5021, // 0x0000139D
		ERROR_CLUSTER_SHUTTING_DOWN = 5022, // 0x0000139E
		ERROR_INVALID_STATE = 5023, // 0x0000139F
		ERROR_NOT_QUORUM_CLASS = 5025, // 0x000013A1
		ERROR_CORE_RESOURCE = 5026, // 0x000013A2
		ERROR_QUORUMLOG_OPEN_FAILED = 5028, // 0x000013A4
		ERROR_CLUSTERLOG_CORRUPT = 5029, // 0x000013A5
		ERROR_QUORUM_OWNER_ALIVE = 5034, // 0x000013AA
		ERROR_NETWORK_NOT_AVAILABLE = 5035, // 0x000013AB
		ERROR_NODE_NOT_AVAILABLE = 5036, // 0x000013AC
		ERROR_ALL_NODES_NOT_AVAILABLE = 5037, // 0x000013AD
		ERROR_RESOURCE_FAILED = 5038, // 0x000013AE
		ERROR_CLUSTER_INVALID_NODE = 5039, // 0x000013AF
		ERROR_CLUSTER_NODE_EXISTS = 5040, // 0x000013B0
		ERROR_CLUSTER_JOIN_IN_PROGRESS = 5041, // 0x000013B1
		ERROR_CLUSTER_NODE_NOT_FOUND = 5042, // 0x000013B2
		ERROR_CLUSTER_NETWORK_EXISTS = 5044, // 0x000013B4
		ERROR_CLUSTER_NETWORK_NOT_FOUND = 5045, // 0x000013B5
		ERROR_CLUSTER_INVALID_REQUEST = 5048, // 0x000013B8
		ERROR_CLUSTER_NODE_DOWN = 5050, // 0x000013BA
		ERROR_CLUSTER_NODE_UNREACHABLE = 5051, // 0x000013BB
		ERROR_CLUSTER_NODE_NOT_MEMBER = 5052, // 0x000013BC
		ERROR_CLUSTER_INVALID_NETWORK = 5054, // 0x000013BE
		ERROR_CLUSTER_NODE_UP = 5056, // 0x000013C0
		ERROR_CLUSTER_IPADDR_IN_USE = 5057, // 0x000013C1
		ERROR_CLUSTER_NODE_NOT_PAUSED = 5058, // 0x000013C2
		ERROR_CLUSTER_NODE_ALREADY_UP = 5061, // 0x000013C5
		ERROR_CLUSTER_NODE_ALREADY_DOWN = 5062, // 0x000013C6
		ERROR_DEPENDENCY_NOT_ALLOWED = 5069, // 0x000013CD
		ERROR_CLUSTER_NODE_PAUSED = 5070, // 0x000013CE
		ERROR_NODE_CANT_HOST_RESOURCE = 5071, // 0x000013CF
		ERROR_CLUSTER_NODE_NOT_READY = 5072, // 0x000013D0
		ERROR_CLUSTER_JOIN_ABORTED = 5074, // 0x000013D2
		ERROR_CLUSTER_RESNAME_NOT_FOUND = 5080, // 0x000013D8
		ERROR_RESMON_INVALID_STATE = 5084, // 0x000013DC
		ERROR_CLUSTER_GUM_NOT_LOCKER = 5085, // 0x000013DD
		ERROR_QUORUM_DISK_NOT_FOUND = 5086, // 0x000013DE
		ERROR_DATABASE_BACKUP_CORRUPT = 5087, // 0x000013DF
		ERROR_NO_ADMIN_ACCESS_POINT = 5090, // 0x000013E2
		ERROR_CLUSTER_MEMBERSHIP_HALT = 5892, // 0x00001704
		ERROR_NODE_CANNOT_BE_CLUSTERED = 5898, // 0x0000170A
		ERROR_CLUSTER_WRONG_OS_VERSION = 5899, // 0x0000170B
		ERROR_CLUSCFG_ALREADY_COMMITTED = 5901, // 0x0000170D
		ERROR_CLUSCFG_ROLLBACK_FAILED = 5902, // 0x0000170E
		ERROR_CLUSTER_OLD_VERSION = 5904, // 0x00001710
		ERROR_CLUSTER_NO_NET_ADAPTERS = 5906, // 0x00001712
		ERROR_CLUSTER_POISONED = 5907, // 0x00001713
		ERROR_CLUSTER_GROUP_MOVING = 5908, // 0x00001714
		ERROR_RESOURCE_CALL_TIMED_OUT = 5910, // 0x00001716
		ERROR_CLUSTER_PARTIAL_SEND = 5914, // 0x0000171A
		ERROR_CLUSTER_NULL_DATA = 5920, // 0x00001720
		ERROR_CLUSTER_PARTIAL_READ = 5921, // 0x00001721
		ERROR_CLUSTER_PARTIAL_WRITE = 5922, // 0x00001722
		ERROR_CLUSTER_NO_QUORUM = 5925, // 0x00001725
		ERROR_CLUSTER_NOT_INSTALLED = 5932, // 0x0000172C
		ERROR_CLUSTER_TOO_MANY_NODES = 5935, // 0x0000172F
		ERROR_NONCORE_GROUPS_FOUND = 5937, // 0x00001731
		ERROR_CLUSTER_GROUP_BUSY = 5944, // 0x00001738
		ERROR_CLUSTER_NOT_SHARED_VOLUME = 5945, // 0x00001739
		ERROR_NON_CSV_PATH = 5950, // 0x0000173E
		ERROR_CSV_VOLUME_NOT_LOCAL = 5951, // 0x0000173F
		ERROR_CLUSTER_GROUP_QUEUED = 5959, // 0x00001747
		ERROR_DISK_NOT_CSV_CAPABLE = 5964, // 0x0000174C
		ERROR_CLUSTER_AFFINITY_CONFLICT = 5971, // 0x00001753
		ERROR_CLUSTER_NODE_ISOLATED = 5984, // 0x00001760
		ERROR_CLUSTER_NODE_QUARANTINED = 5985, // 0x00001761
		ERROR_CLUSTER_SPACE_DEGRADED = 5987, // 0x00001763
		ERROR_ENCRYPTION_FAILED = 6000, // 0x00001770
		ERROR_DECRYPTION_FAILED = 6001, // 0x00001771
		ERROR_FILE_ENCRYPTED = 6002, // 0x00001772
		ERROR_NO_RECOVERY_POLICY = 6003, // 0x00001773
		ERROR_NO_EFS = 6004, // 0x00001774
		ERROR_WRONG_EFS = 6005, // 0x00001775
		ERROR_NO_USER_KEYS = 6006, // 0x00001776
		ERROR_FILE_NOT_ENCRYPTED = 6007, // 0x00001777
		ERROR_NOT_EXPORT_FORMAT = 6008, // 0x00001778
		ERROR_FILE_READ_ONLY = 6009, // 0x00001779
		ERROR_DIR_EFS_DISALLOWED = 6010, // 0x0000177A
		ERROR_EFS_SERVER_NOT_TRUSTED = 6011, // 0x0000177B
		ERROR_BAD_RECOVERY_POLICY = 6012, // 0x0000177C
		ERROR_EFS_ALG_BLOB_TOO_BIG = 6013, // 0x0000177D
		ERROR_VOLUME_NOT_SUPPORT_EFS = 6014, // 0x0000177E
		ERROR_EFS_DISABLED = 6015, // 0x0000177F
		ERROR_EFS_VERSION_NOT_SUPPORT = 6016, // 0x00001780
		ERROR_NO_BROWSER_SERVERS_FOUND = 6118, // 0x000017E6
		SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200, // 0x00001838
		ERROR_LOG_SECTOR_INVALID = 6600, // 0x000019C8
		ERROR_LOG_SECTOR_PARITY_INVALID = 6601, // 0x000019C9
		ERROR_LOG_SECTOR_REMAPPED = 6602, // 0x000019CA
		ERROR_LOG_BLOCK_INCOMPLETE = 6603, // 0x000019CB
		ERROR_LOG_INVALID_RANGE = 6604, // 0x000019CC
		ERROR_LOG_BLOCKS_EXHAUSTED = 6605, // 0x000019CD
		ERROR_LOG_READ_CONTEXT_INVALID = 6606, // 0x000019CE
		ERROR_LOG_RESTART_INVALID = 6607, // 0x000019CF
		ERROR_LOG_BLOCK_VERSION = 6608, // 0x000019D0
		ERROR_LOG_BLOCK_INVALID = 6609, // 0x000019D1
		ERROR_LOG_READ_MODE_INVALID = 6610, // 0x000019D2
		ERROR_LOG_NO_RESTART = 6611, // 0x000019D3
		ERROR_LOG_METADATA_CORRUPT = 6612, // 0x000019D4
		ERROR_LOG_METADATA_INVALID = 6613, // 0x000019D5
		ERROR_LOG_METADATA_INCONSISTENT = 6614, // 0x000019D6
		ERROR_LOG_RESERVATION_INVALID = 6615, // 0x000019D7
		ERROR_LOG_CANT_DELETE = 6616, // 0x000019D8
		ERROR_LOG_START_OF_LOG = 6618, // 0x000019DA
		ERROR_LOG_POLICY_NOT_INSTALLED = 6620, // 0x000019DC
		ERROR_LOG_POLICY_INVALID = 6621, // 0x000019DD
		ERROR_LOG_POLICY_CONFLICT = 6622, // 0x000019DE
		ERROR_LOG_PINNED_ARCHIVE_TAIL = 6623, // 0x000019DF
		ERROR_LOG_RECORD_NONEXISTENT = 6624, // 0x000019E0
		ERROR_LOG_TAIL_INVALID = 6627, // 0x000019E3
		ERROR_LOG_FULL = 6628, // 0x000019E4
		ERROR_COULD_NOT_RESIZE_LOG = 6629, // 0x000019E5
		ERROR_LOG_MULTIPLEXED = 6630, // 0x000019E6
		ERROR_LOG_DEDICATED = 6631, // 0x000019E7
		ERROR_LOG_ARCHIVE_IN_PROGRESS = 6633, // 0x000019E9
		ERROR_LOG_EPHEMERAL = 6634, // 0x000019EA
		ERROR_LOG_NOT_ENOUGH_CONTAINERS = 6635, // 0x000019EB
		ERROR_LOG_CLIENT_NOT_REGISTERED = 6637, // 0x000019ED
		ERROR_LOG_CONTAINER_READ_FAILED = 6639, // 0x000019EF
		ERROR_LOG_CONTAINER_OPEN_FAILED = 6641, // 0x000019F1
		ERROR_LOG_STATE_INVALID = 6643, // 0x000019F3
		ERROR_LOG_PINNED = 6644, // 0x000019F4
		ERROR_LOG_METADATA_FLUSH_FAILED = 6645, // 0x000019F5
		ERROR_LOG_INCONSISTENT_SECURITY = 6646, // 0x000019F6
		ERROR_LOG_APPENDED_FLUSH_FAILED = 6647, // 0x000019F7
		ERROR_LOG_PINNED_RESERVATION = 6648, // 0x000019F8
		ERROR_INVALID_TRANSACTION = 6700, // 0x00001A2C
		ERROR_TRANSACTION_NOT_ACTIVE = 6701, // 0x00001A2D
		ERROR_TRANSACTION_NOT_REQUESTED = 6703, // 0x00001A2F
		ERROR_TM_INITIALIZATION_FAILED = 6706, // 0x00001A32
		ERROR_RESOURCEMANAGER_READ_ONLY = 6707, // 0x00001A33
		ERROR_TRANSACTION_NOT_JOINED = 6708, // 0x00001A34
		ERROR_CRM_PROTOCOL_NOT_FOUND = 6712, // 0x00001A38
		ERROR_TRANSACTION_NOT_FOUND = 6715, // 0x00001A3B
		ERROR_RESOURCEMANAGER_NOT_FOUND = 6716, // 0x00001A3C
		ERROR_ENLISTMENT_NOT_FOUND = 6717, // 0x00001A3D
		ERROR_TRANSACTION_NOT_ROOT = 6721, // 0x00001A41
		ERROR_TRANSACTION_NO_SUPERIOR = 6730, // 0x00001A4A
		ERROR_HEURISTIC_DAMAGE_POSSIBLE = 6731, // 0x00001A4B
		ERROR_TRANSACTIONAL_CONFLICT = 6800, // 0x00001A90
		ERROR_RM_NOT_ACTIVE = 6801, // 0x00001A91
		ERROR_RM_METADATA_CORRUPT = 6802, // 0x00001A92
		ERROR_DIRECTORY_NOT_RM = 6803, // 0x00001A93
		ERROR_LOG_RESIZE_INVALID_SIZE = 6806, // 0x00001A96
		ERROR_OBJECT_NO_LONGER_EXISTS = 6807, // 0x00001A97
		ERROR_HANDLE_NO_LONGER_VALID = 6815, // 0x00001A9F
		ERROR_NO_TXF_METADATA = 6816, // 0x00001AA0
		ERROR_LOG_CORRUPTION_DETECTED = 6817, // 0x00001AA1
		ERROR_RM_DISCONNECTED = 6819, // 0x00001AA3
		ERROR_ENLISTMENT_NOT_SUPERIOR = 6820, // 0x00001AA4
		ERROR_RECOVERY_NOT_NEEDED = 6821, // 0x00001AA5
		ERROR_RM_ALREADY_STARTED = 6822, // 0x00001AA6
		ERROR_CANT_CROSS_RM_BOUNDARY = 6825, // 0x00001AA9
		ERROR_TXF_DIR_NOT_EMPTY = 6826, // 0x00001AAA
		ERROR_TM_VOLATILE = 6828, // 0x00001AAC
		ERROR_ROLLBACK_TIMER_EXPIRED = 6829, // 0x00001AAD
		ERROR_TXF_ATTRIBUTE_CORRUPT = 6830, // 0x00001AAE
		ERROR_LOG_GROWTH_FAILED = 6833, // 0x00001AB1
		ERROR_TRANSACTIONS_NOT_FROZEN = 6839, // 0x00001AB7
		ERROR_NOT_SNAPSHOT_VOLUME = 6841, // 0x00001AB9
		ERROR_DATA_LOST_REPAIR = 6843, // 0x00001ABB
		ERROR_TM_IDENTITY_MISMATCH = 6845, // 0x00001ABD
		ERROR_FLOATED_SECTION = 6846, // 0x00001ABE
		ERROR_CANNOT_ABORT_TRANSACTIONS = 6848, // 0x00001AC0
		ERROR_BAD_CLUSTERS = 6849, // 0x00001AC1
		ERROR_VOLUME_DIRTY = 6851, // 0x00001AC3
		ERROR_EXPIRED_HANDLE = 6854, // 0x00001AC6
		ERROR_TRANSACTION_NOT_ENLISTED = 6855, // 0x00001AC7
		ERROR_CTX_INVALID_PD = 7002, // 0x00001B5A
		ERROR_CTX_PD_NOT_FOUND = 7003, // 0x00001B5B
		ERROR_CTX_WD_NOT_FOUND = 7004, // 0x00001B5C
		ERROR_CTX_CLOSE_PENDING = 7007, // 0x00001B5F
		ERROR_CTX_NO_OUTBUF = 7008, // 0x00001B60
		ERROR_CTX_MODEM_INF_NOT_FOUND = 7009, // 0x00001B61
		ERROR_CTX_INVALID_MODEMNAME = 7010, // 0x00001B62
		ERROR_CTX_MODEM_RESPONSE_ERROR = 7011, // 0x00001B63
		ERROR_CTX_MODEM_RESPONSE_BUSY = 7015, // 0x00001B67
		ERROR_CTX_MODEM_RESPONSE_VOICE = 7016, // 0x00001B68
		ERROR_CTX_TD_ERROR = 7017, // 0x00001B69
		ERROR_CTX_WINSTATION_NOT_FOUND = 7022, // 0x00001B6E
		ERROR_CTX_WINSTATION_BUSY = 7024, // 0x00001B70
		ERROR_CTX_BAD_VIDEO_MODE = 7025, // 0x00001B71
		ERROR_CTX_GRAPHICS_INVALID = 7035, // 0x00001B7B
		ERROR_CTX_LOGON_DISABLED = 7037, // 0x00001B7D
		ERROR_CTX_NOT_CONSOLE = 7038, // 0x00001B7E
		ERROR_CTX_CLIENT_QUERY_TIMEOUT = 7040, // 0x00001B80
		ERROR_CTX_CONSOLE_DISCONNECT = 7041, // 0x00001B81
		ERROR_CTX_CONSOLE_CONNECT = 7042, // 0x00001B82
		ERROR_CTX_SHADOW_DENIED = 7044, // 0x00001B84
		ERROR_CTX_INVALID_WD = 7049, // 0x00001B89
		ERROR_CTX_SHADOW_INVALID = 7050, // 0x00001B8A
		ERROR_CTX_SHADOW_DISABLED = 7051, // 0x00001B8B
		ERROR_CTX_CLIENT_LICENSE_IN_USE = 7052, // 0x00001B8C
		ERROR_CTX_LICENSE_NOT_AVAILABLE = 7054, // 0x00001B8E
		ERROR_CTX_LICENSE_EXPIRED = 7056, // 0x00001B90
		ERROR_CTX_SHADOW_NOT_RUNNING = 7057, // 0x00001B91
		ERROR_ACTIVATION_COUNT_EXCEEDED = 7059, // 0x00001B93
		ERROR_CTX_WINSTATIONS_DISABLED = 7060, // 0x00001B94
		ERROR_CTX_SESSION_IN_USE = 7062, // 0x00001B96
		ERROR_CTX_NO_FORCE_LOGOFF = 7063, // 0x00001B97
		ERROR_CTX_ACCOUNT_RESTRICTION = 7064, // 0x00001B98
		ERROR_RDP_PROTOCOL_ERROR = 7065, // 0x00001B99
		ERROR_CTX_CDM_CONNECT = 7066, // 0x00001B9A
		ERROR_CTX_CDM_DISCONNECT = 7067, // 0x00001B9B
		ERROR_CTX_SECURITY_LAYER_ERROR = 7068, // 0x00001B9C
		ERROR_TS_INCOMPATIBLE_SESSIONS = 7069, // 0x00001B9D
		ERROR_TS_VIDEO_SUBSYSTEM_ERROR = 7070, // 0x00001B9E
		FRS_ERR_INVALID_API_SEQUENCE = 8001, // 0x00001F41
		FRS_ERR_STARTING_SERVICE = 8002, // 0x00001F42
		FRS_ERR_STOPPING_SERVICE = 8003, // 0x00001F43
		FRS_ERR_INTERNAL_API = 8004, // 0x00001F44
		FRS_ERR_INTERNAL = 8005, // 0x00001F45
		FRS_ERR_SERVICE_COMM = 8006, // 0x00001F46
		FRS_ERR_INSUFFICIENT_PRIV = 8007, // 0x00001F47
		FRS_ERR_AUTHENTICATION = 8008, // 0x00001F48
		FRS_ERR_PARENT_AUTHENTICATION = 8010, // 0x00001F4A
		FRS_ERR_CHILD_TO_PARENT_COMM = 8011, // 0x00001F4B
		FRS_ERR_PARENT_TO_CHILD_COMM = 8012, // 0x00001F4C
		FRS_ERR_SYSVOL_POPULATE = 8013, // 0x00001F4D
		FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014, // 0x00001F4E
		FRS_ERR_SYSVOL_IS_BUSY = 8015, // 0x00001F4F
		FRS_ERR_SYSVOL_DEMOTE = 8016, // 0x00001F50
		ERROR_DS_NOT_INSTALLED = 8200, // 0x00002008
		ERROR_DS_NO_ATTRIBUTE_OR_VALUE = 8202, // 0x0000200A
		ERROR_DS_BUSY = 8206, // 0x0000200E
		ERROR_DS_UNAVAILABLE = 8207, // 0x0000200F
		ERROR_DS_NO_RIDS_ALLOCATED = 8208, // 0x00002010
		ERROR_DS_NO_MORE_RIDS = 8209, // 0x00002011
		ERROR_DS_INCORRECT_ROLE_OWNER = 8210, // 0x00002012
		ERROR_DS_RIDMGR_INIT_ERROR = 8211, // 0x00002013
		ERROR_DS_OBJ_CLASS_VIOLATION = 8212, // 0x00002014
		ERROR_DS_CANT_ON_NON_LEAF = 8213, // 0x00002015
		ERROR_DS_CANT_ON_RDN = 8214, // 0x00002016
		ERROR_DS_CANT_MOD_OBJ_CLASS = 8215, // 0x00002017
		ERROR_DS_CROSS_DOM_MOVE_ERROR = 8216, // 0x00002018
		ERROR_DS_GC_NOT_AVAILABLE = 8217, // 0x00002019
		ERROR_SHARED_POLICY = 8218, // 0x0000201A
		ERROR_POLICY_OBJECT_NOT_FOUND = 8219, // 0x0000201B
		ERROR_POLICY_ONLY_IN_DS = 8220, // 0x0000201C
		ERROR_PROMOTION_ACTIVE = 8221, // 0x0000201D
		ERROR_NO_PROMOTION_ACTIVE = 8222, // 0x0000201E
		ERROR_DS_OPERATIONS_ERROR = 8224, // 0x00002020
		ERROR_DS_PROTOCOL_ERROR = 8225, // 0x00002021
		ERROR_DS_TIMELIMIT_EXCEEDED = 8226, // 0x00002022
		ERROR_DS_SIZELIMIT_EXCEEDED = 8227, // 0x00002023
		ERROR_DS_ADMIN_LIMIT_EXCEEDED = 8228, // 0x00002024
		ERROR_DS_COMPARE_FALSE = 8229, // 0x00002025
		ERROR_DS_COMPARE_TRUE = 8230, // 0x00002026
		ERROR_DS_STRONG_AUTH_REQUIRED = 8232, // 0x00002028
		ERROR_DS_INAPPROPRIATE_AUTH = 8233, // 0x00002029
		ERROR_DS_AUTH_UNKNOWN = 8234, // 0x0000202A
		ERROR_DS_REFERRAL = 8235, // 0x0000202B
		ERROR_DS_INAPPROPRIATE_MATCHING = 8238, // 0x0000202E
		ERROR_DS_CONSTRAINT_VIOLATION = 8239, // 0x0000202F
		ERROR_DS_NO_SUCH_OBJECT = 8240, // 0x00002030
		ERROR_DS_ALIAS_PROBLEM = 8241, // 0x00002031
		ERROR_DS_INVALID_DN_SYNTAX = 8242, // 0x00002032
		ERROR_DS_IS_LEAF = 8243, // 0x00002033
		ERROR_DS_ALIAS_DEREF_PROBLEM = 8244, // 0x00002034
		ERROR_DS_UNWILLING_TO_PERFORM = 8245, // 0x00002035
		ERROR_DS_LOOP_DETECT = 8246, // 0x00002036
		ERROR_DS_NAMING_VIOLATION = 8247, // 0x00002037
		ERROR_DS_AFFECTS_MULTIPLE_DSAS = 8249, // 0x00002039
		ERROR_DS_SERVER_DOWN = 8250, // 0x0000203A
		ERROR_DS_LOCAL_ERROR = 8251, // 0x0000203B
		ERROR_DS_ENCODING_ERROR = 8252, // 0x0000203C
		ERROR_DS_DECODING_ERROR = 8253, // 0x0000203D
		ERROR_DS_FILTER_UNKNOWN = 8254, // 0x0000203E
		ERROR_DS_PARAM_ERROR = 8255, // 0x0000203F
		ERROR_DS_NOT_SUPPORTED = 8256, // 0x00002040
		ERROR_DS_NO_RESULTS_RETURNED = 8257, // 0x00002041
		ERROR_DS_CONTROL_NOT_FOUND = 8258, // 0x00002042
		ERROR_DS_CLIENT_LOOP = 8259, // 0x00002043
		ERROR_DS_SORT_CONTROL_MISSING = 8261, // 0x00002045
		ERROR_DS_OFFSET_RANGE_ERROR = 8262, // 0x00002046
		ERROR_DS_RIDMGR_DISABLED = 8263, // 0x00002047
		ERROR_DS_ROOT_MUST_BE_NC = 8301, // 0x0000206D
		ERROR_DS_ADD_REPLICA_INHIBITED = 8302, // 0x0000206E
		ERROR_DS_ATT_NOT_DEF_IN_SCHEMA = 8303, // 0x0000206F
		ERROR_DS_MAX_OBJ_SIZE_EXCEEDED = 8304, // 0x00002070
		ERROR_DS_OBJ_STRING_NAME_EXISTS = 8305, // 0x00002071
		ERROR_DS_USER_BUFFER_TO_SMALL = 8309, // 0x00002075
		ERROR_DS_ATT_IS_NOT_ON_OBJ = 8310, // 0x00002076
		ERROR_DS_ILLEGAL_MOD_OPERATION = 8311, // 0x00002077
		ERROR_DS_OBJ_TOO_LARGE = 8312, // 0x00002078
		ERROR_DS_BAD_INSTANCE_TYPE = 8313, // 0x00002079
		ERROR_DS_MASTERDSA_REQUIRED = 8314, // 0x0000207A
		ERROR_DS_OBJECT_CLASS_REQUIRED = 8315, // 0x0000207B
		ERROR_DS_MISSING_REQUIRED_ATT = 8316, // 0x0000207C
		ERROR_DS_ATT_NOT_DEF_FOR_CLASS = 8317, // 0x0000207D
		ERROR_DS_ATT_ALREADY_EXISTS = 8318, // 0x0000207E
		ERROR_DS_CANT_ADD_ATT_VALUES = 8320, // 0x00002080
		ERROR_DS_RANGE_CONSTRAINT = 8322, // 0x00002082
		ERROR_DS_ATT_VAL_ALREADY_EXISTS = 8323, // 0x00002083
		ERROR_DS_CANT_REM_MISSING_ATT = 8324, // 0x00002084
		ERROR_DS_ROOT_CANT_BE_SUBREF = 8326, // 0x00002086
		ERROR_DS_NO_CHAINING = 8327, // 0x00002087
		ERROR_DS_NO_CHAINED_EVAL = 8328, // 0x00002088
		ERROR_DS_NO_PARENT_OBJECT = 8329, // 0x00002089
		ERROR_DS_PARENT_IS_AN_ALIAS = 8330, // 0x0000208A
		ERROR_DS_CHILDREN_EXIST = 8332, // 0x0000208C
		ERROR_DS_OBJ_NOT_FOUND = 8333, // 0x0000208D
		ERROR_DS_ALIASED_OBJ_MISSING = 8334, // 0x0000208E
		ERROR_DS_BAD_NAME_SYNTAX = 8335, // 0x0000208F
		ERROR_DS_ALIAS_POINTS_TO_ALIAS = 8336, // 0x00002090
		ERROR_DS_CANT_DEREF_ALIAS = 8337, // 0x00002091
		ERROR_DS_OUT_OF_SCOPE = 8338, // 0x00002092
		ERROR_DS_OBJECT_BEING_REMOVED = 8339, // 0x00002093
		ERROR_DS_CANT_DELETE_DSA_OBJ = 8340, // 0x00002094
		ERROR_DS_GENERIC_ERROR = 8341, // 0x00002095
		ERROR_DS_DSA_MUST_BE_INT_MASTER = 8342, // 0x00002096
		ERROR_DS_CLASS_NOT_DSA = 8343, // 0x00002097
		ERROR_DS_INSUFF_ACCESS_RIGHTS = 8344, // 0x00002098
		ERROR_DS_ILLEGAL_SUPERIOR = 8345, // 0x00002099
		ERROR_DS_ATTRIBUTE_OWNED_BY_SAM = 8346, // 0x0000209A
		ERROR_DS_NAME_TOO_MANY_PARTS = 8347, // 0x0000209B
		ERROR_DS_NAME_TOO_LONG = 8348, // 0x0000209C
		ERROR_DS_NAME_VALUE_TOO_LONG = 8349, // 0x0000209D
		ERROR_DS_NAME_UNPARSEABLE = 8350, // 0x0000209E
		ERROR_DS_NAME_TYPE_UNKNOWN = 8351, // 0x0000209F
		ERROR_DS_NOT_AN_OBJECT = 8352, // 0x000020A0
		ERROR_DS_SEC_DESC_TOO_SHORT = 8353, // 0x000020A1
		ERROR_DS_SEC_DESC_INVALID = 8354, // 0x000020A2
		ERROR_DS_NO_DELETED_NAME = 8355, // 0x000020A3
		ERROR_DS_NCNAME_MUST_BE_NC = 8357, // 0x000020A5
		ERROR_DS_CANT_ADD_SYSTEM_ONLY = 8358, // 0x000020A6
		ERROR_DS_CLASS_MUST_BE_CONCRETE = 8359, // 0x000020A7
		ERROR_DS_INVALID_DMD = 8360, // 0x000020A8
		ERROR_DS_OBJ_GUID_EXISTS = 8361, // 0x000020A9
		ERROR_DS_NOT_ON_BACKLINK = 8362, // 0x000020AA
		ERROR_DS_NO_CROSSREF_FOR_NC = 8363, // 0x000020AB
		ERROR_DS_SHUTTING_DOWN = 8364, // 0x000020AC
		ERROR_DS_UNKNOWN_OPERATION = 8365, // 0x000020AD
		ERROR_DS_INVALID_ROLE_OWNER = 8366, // 0x000020AE
		ERROR_DS_COULDNT_CONTACT_FSMO = 8367, // 0x000020AF
		ERROR_DS_CROSS_NC_DN_RENAME = 8368, // 0x000020B0
		ERROR_DS_CANT_MOD_SYSTEM_ONLY = 8369, // 0x000020B1
		ERROR_DS_REPLICATOR_ONLY = 8370, // 0x000020B2
		ERROR_DS_OBJ_CLASS_NOT_DEFINED = 8371, // 0x000020B3
		ERROR_DS_OBJ_CLASS_NOT_SUBCLASS = 8372, // 0x000020B4
		ERROR_DS_NAME_REFERENCE_INVALID = 8373, // 0x000020B5
		ERROR_DS_CROSS_REF_EXISTS = 8374, // 0x000020B6
		ERROR_DS_DUP_RDN = 8378, // 0x000020BA
		ERROR_DS_DUP_OID = 8379, // 0x000020BB
		ERROR_DS_DUP_MAPI_ID = 8380, // 0x000020BC
		ERROR_DS_DUP_SCHEMA_ID_GUID = 8381, // 0x000020BD
		ERROR_DS_DUP_LDAP_DISPLAY_NAME = 8382, // 0x000020BE
		ERROR_DS_SEMANTIC_ATT_TEST = 8383, // 0x000020BF
		ERROR_DS_SYNTAX_MISMATCH = 8384, // 0x000020C0
		ERROR_DS_EXISTS_IN_MUST_HAVE = 8385, // 0x000020C1
		ERROR_DS_EXISTS_IN_MAY_HAVE = 8386, // 0x000020C2
		ERROR_DS_NONEXISTENT_MAY_HAVE = 8387, // 0x000020C3
		ERROR_DS_NONEXISTENT_MUST_HAVE = 8388, // 0x000020C4
		ERROR_DS_AUX_CLS_TEST_FAIL = 8389, // 0x000020C5
		ERROR_DS_NONEXISTENT_POSS_SUP = 8390, // 0x000020C6
		ERROR_DS_SUB_CLS_TEST_FAIL = 8391, // 0x000020C7
		ERROR_DS_BAD_RDN_ATT_ID_SYNTAX = 8392, // 0x000020C8
		ERROR_DS_EXISTS_IN_AUX_CLS = 8393, // 0x000020C9
		ERROR_DS_EXISTS_IN_SUB_CLS = 8394, // 0x000020CA
		ERROR_DS_EXISTS_IN_POSS_SUP = 8395, // 0x000020CB
		ERROR_DS_RECALCSCHEMA_FAILED = 8396, // 0x000020CC
		ERROR_DS_CANT_DELETE = 8398, // 0x000020CE
		ERROR_DS_ATT_SCHEMA_REQ_ID = 8399, // 0x000020CF
		ERROR_DS_BAD_ATT_SCHEMA_SYNTAX = 8400, // 0x000020D0
		ERROR_DS_CANT_CACHE_ATT = 8401, // 0x000020D1
		ERROR_DS_CANT_CACHE_CLASS = 8402, // 0x000020D2
		ERROR_DS_CANT_REMOVE_ATT_CACHE = 8403, // 0x000020D3
		ERROR_DS_CANT_RETRIEVE_DN = 8405, // 0x000020D5
		ERROR_DS_MISSING_SUPREF = 8406, // 0x000020D6
		ERROR_DS_CANT_RETRIEVE_INSTANCE = 8407, // 0x000020D7
		ERROR_DS_CODE_INCONSISTENCY = 8408, // 0x000020D8
		ERROR_DS_DATABASE_ERROR = 8409, // 0x000020D9
		ERROR_DS_GOVERNSID_MISSING = 8410, // 0x000020DA
		ERROR_DS_MISSING_EXPECTED_ATT = 8411, // 0x000020DB
		ERROR_DS_NCNAME_MISSING_CR_REF = 8412, // 0x000020DC
		ERROR_DS_SCHEMA_NOT_LOADED = 8414, // 0x000020DE
		ERROR_DS_SCHEMA_ALLOC_FAILED = 8415, // 0x000020DF
		ERROR_DS_ATT_SCHEMA_REQ_SYNTAX = 8416, // 0x000020E0
		ERROR_DS_GCVERIFY_ERROR = 8417, // 0x000020E1
		ERROR_DS_DRA_SCHEMA_MISMATCH = 8418, // 0x000020E2
		ERROR_DS_CANT_FIND_DSA_OBJ = 8419, // 0x000020E3
		ERROR_DS_CANT_FIND_EXPECTED_NC = 8420, // 0x000020E4
		ERROR_DS_CANT_FIND_NC_IN_CACHE = 8421, // 0x000020E5
		ERROR_DS_CANT_RETRIEVE_CHILD = 8422, // 0x000020E6
		ERROR_DS_BAD_HIERARCHY_FILE = 8425, // 0x000020E9
		ERROR_DS_CONFIG_PARAM_MISSING = 8427, // 0x000020EB
		ERROR_DS_INTERNAL_FAILURE = 8430, // 0x000020EE
		ERROR_DS_UNKNOWN_ERROR = 8431, // 0x000020EF
		ERROR_DS_REFUSING_FSMO_ROLES = 8433, // 0x000020F1
		ERROR_DS_MISSING_FSMO_SETTINGS = 8434, // 0x000020F2
		ERROR_DS_DRA_GENERIC = 8436, // 0x000020F4
		ERROR_DS_DRA_INVALID_PARAMETER = 8437, // 0x000020F5
		ERROR_DS_DRA_BUSY = 8438, // 0x000020F6
		ERROR_DS_DRA_BAD_DN = 8439, // 0x000020F7
		ERROR_DS_DRA_BAD_NC = 8440, // 0x000020F8
		ERROR_DS_DRA_DN_EXISTS = 8441, // 0x000020F9
		ERROR_DS_DRA_INTERNAL_ERROR = 8442, // 0x000020FA
		ERROR_DS_DRA_INCONSISTENT_DIT = 8443, // 0x000020FB
		ERROR_DS_DRA_CONNECTION_FAILED = 8444, // 0x000020FC
		ERROR_DS_DRA_BAD_INSTANCE_TYPE = 8445, // 0x000020FD
		ERROR_DS_DRA_OUT_OF_MEM = 8446, // 0x000020FE
		ERROR_DS_DRA_MAIL_PROBLEM = 8447, // 0x000020FF
		ERROR_DS_DRA_REF_ALREADY_EXISTS = 8448, // 0x00002100
		ERROR_DS_DRA_REF_NOT_FOUND = 8449, // 0x00002101
		ERROR_DS_DRA_OBJ_IS_REP_SOURCE = 8450, // 0x00002102
		ERROR_DS_DRA_DB_ERROR = 8451, // 0x00002103
		ERROR_DS_DRA_NO_REPLICA = 8452, // 0x00002104
		ERROR_DS_DRA_ACCESS_DENIED = 8453, // 0x00002105
		ERROR_DS_DRA_NOT_SUPPORTED = 8454, // 0x00002106
		ERROR_DS_DRA_RPC_CANCELLED = 8455, // 0x00002107
		ERROR_DS_DRA_SOURCE_DISABLED = 8456, // 0x00002108
		ERROR_DS_DRA_SINK_DISABLED = 8457, // 0x00002109
		ERROR_DS_DRA_NAME_COLLISION = 8458, // 0x0000210A
		ERROR_DS_DRA_SOURCE_REINSTALLED = 8459, // 0x0000210B
		ERROR_DS_DRA_MISSING_PARENT = 8460, // 0x0000210C
		ERROR_DS_DRA_PREEMPTED = 8461, // 0x0000210D
		ERROR_DS_DRA_ABANDON_SYNC = 8462, // 0x0000210E
		ERROR_DS_DRA_SHUTDOWN = 8463, // 0x0000210F
		ERROR_DS_DUP_LINK_ID = 8468, // 0x00002114
		ERROR_DS_NAME_ERROR_RESOLVING = 8469, // 0x00002115
		ERROR_DS_NAME_ERROR_NOT_FOUND = 8470, // 0x00002116
		ERROR_DS_NAME_ERROR_NOT_UNIQUE = 8471, // 0x00002117
		ERROR_DS_NAME_ERROR_NO_MAPPING = 8472, // 0x00002118
		ERROR_DS_NAME_ERROR_DOMAIN_ONLY = 8473, // 0x00002119
		ERROR_DS_CONSTRUCTED_ATT_MOD = 8475, // 0x0000211B
		ERROR_DS_WRONG_OM_OBJ_CLASS = 8476, // 0x0000211C
		ERROR_DS_DRA_REPL_PENDING = 8477, // 0x0000211D
		ERROR_DS_DS_REQUIRED = 8478, // 0x0000211E
		ERROR_DS_NON_BASE_SEARCH = 8480, // 0x00002120
		ERROR_DS_CANT_RETRIEVE_ATTS = 8481, // 0x00002121
		ERROR_DS_BACKLINK_WITHOUT_LINK = 8482, // 0x00002122
		ERROR_DS_EPOCH_MISMATCH = 8483, // 0x00002123
		ERROR_DS_SRC_NAME_MISMATCH = 8484, // 0x00002124
		ERROR_DS_DST_NC_MISMATCH = 8486, // 0x00002126
		ERROR_DS_SRC_GUID_MISMATCH = 8488, // 0x00002128
		ERROR_DS_NC_MUST_HAVE_NC_PARENT = 8494, // 0x0000212E
		ERROR_DS_DST_DOMAIN_NOT_NATIVE = 8496, // 0x00002130
		ERROR_DS_INVALID_SEARCH_FLAG = 8500, // 0x00002134
		ERROR_DS_SAM_INIT_FAILURE = 8504, // 0x00002138
		ERROR_DS_NONSAFE_SCHEMA_CHANGE = 8508, // 0x0000213C
		ERROR_DS_INVALID_GROUP_TYPE = 8513, // 0x00002141
		ERROR_DS_HAVE_PRIMARY_MEMBERS = 8521, // 0x00002149
		ERROR_DS_NAMING_MASTER_GC = 8523, // 0x0000214B
		ERROR_DS_DNS_LOOKUP_FAILURE = 8524, // 0x0000214C
		ERROR_DS_COULDNT_UPDATE_SPNS = 8525, // 0x0000214D
		ERROR_DS_CANT_RETRIEVE_SD = 8526, // 0x0000214E
		ERROR_DS_KEY_NOT_UNIQUE = 8527, // 0x0000214F
		ERROR_DS_CANT_START = 8531, // 0x00002153
		ERROR_DS_INIT_FAILURE = 8532, // 0x00002154
		ERROR_SAM_INIT_FAILURE = 8541, // 0x0000215D
		ERROR_DS_DRA_SCHEMA_INFO_SHIP = 8542, // 0x0000215E
		ERROR_DS_DRA_SCHEMA_CONFLICT = 8543, // 0x0000215F
		ERROR_DS_DRA_OBJ_NC_MISMATCH = 8545, // 0x00002161
		ERROR_DS_NC_STILL_HAS_DSAS = 8546, // 0x00002162
		ERROR_DS_GC_REQUIRED = 8547, // 0x00002163
		ERROR_DS_CANT_ADD_TO_GC = 8550, // 0x00002166
		ERROR_DS_NO_CHECKPOINT_WITH_PDC = 8551, // 0x00002167
		ERROR_DS_INVALID_NAME_FOR_SPN = 8554, // 0x0000216A
		ERROR_DS_MUST_BE_RUN_ON_DST_DC = 8558, // 0x0000216E
		ERROR_DS_INIT_FAILURE_CONSOLE = 8561, // 0x00002171
		ERROR_DS_FOREST_VERSION_TOO_LOW = 8565, // 0x00002175
		ERROR_DS_DOMAIN_VERSION_TOO_LOW = 8566, // 0x00002176
		ERROR_DS_INCOMPATIBLE_VERSION = 8567, // 0x00002177
		ERROR_DS_LOW_DSA_VERSION = 8568, // 0x00002178
		ERROR_DS_NAME_NOT_UNIQUE = 8571, // 0x0000217B
		ERROR_DS_OUT_OF_VERSION_STORE = 8573, // 0x0000217D
		ERROR_DS_NO_REF_DOMAIN = 8575, // 0x0000217F
		ERROR_DS_RESERVED_LINK_ID = 8576, // 0x00002180
		ERROR_DS_LINK_ID_NOT_AVAILABLE = 8577, // 0x00002181
		ERROR_DS_THREAD_LIMIT_EXCEEDED = 8587, // 0x0000218B
		ERROR_DS_NOT_CLOSEST = 8588, // 0x0000218C
		ERROR_DS_NTDSCRIPT_SYNTAX_ERROR = 8591, // 0x0000218F
		ERROR_DS_DIFFERENT_REPL_EPOCHS = 8593, // 0x00002191
		ERROR_DS_DRS_EXTENSIONS_CHANGED = 8594, // 0x00002192
		ERROR_DS_NO_MSDS_INTID = 8596, // 0x00002194
		ERROR_DS_DUP_MSDS_INTID = 8597, // 0x00002195
		ERROR_DS_EXISTS_IN_RDNATTID = 8598, // 0x00002196
		ERROR_DS_AUTHORIZATION_FAILED = 8599, // 0x00002197
		ERROR_DS_INVALID_SCRIPT = 8600, // 0x00002198
		ERROR_DS_CROSS_REF_BUSY = 8602, // 0x0000219A
		ERROR_DS_DUPLICATE_ID_FOUND = 8605, // 0x0000219D
		ERROR_DS_GROUP_CONVERSION_ERROR = 8607, // 0x0000219F
		ERROR_DS_ROLE_NOT_VERIFIED = 8610, // 0x000021A2
		ERROR_DS_EXISTING_AD_CHILD_NC = 8613, // 0x000021A5
		ERROR_DS_REPL_LIFETIME_EXCEEDED = 8614, // 0x000021A6
		ERROR_DS_LDAP_SEND_QUEUE_FULL = 8616, // 0x000021A8
		ERROR_DS_POLICY_NOT_KNOWN = 8618, // 0x000021AA
		ERROR_NO_SITE_SETTINGS_OBJECT = 8619, // 0x000021AB
		ERROR_NO_SECRETS = 8620, // 0x000021AC
		ERROR_NO_WRITABLE_DC_FOUND = 8621, // 0x000021AD
		ERROR_DS_NO_SERVER_OBJECT = 8622, // 0x000021AE
		ERROR_DS_NO_NTDSA_OBJECT = 8623, // 0x000021AF
		ERROR_DS_NON_ASQ_SEARCH = 8624, // 0x000021B0
		ERROR_DS_AUDIT_FAILURE = 8625, // 0x000021B1
		ERROR_DS_DRA_CORRUPT_UTD_VECTOR = 8629, // 0x000021B5
		ERROR_DS_DRA_SECRETS_DENIED = 8630, // 0x000021B6
		ERROR_DS_RESERVED_MAPI_ID = 8631, // 0x000021B7
		ERROR_DS_MAPI_ID_NOT_AVAILABLE = 8632, // 0x000021B8
		ERROR_DS_OID_NOT_FOUND = 8638, // 0x000021BE
		ERROR_DS_DRA_RECYCLED_TARGET = 8639, // 0x000021BF
		ERROR_DS_DISALLOWED_NC_REDIRECT = 8640, // 0x000021C0
		ERROR_DS_HIGH_ADLDS_FFL = 8641, // 0x000021C1
		ERROR_DS_HIGH_DSA_VERSION = 8642, // 0x000021C2
		ERROR_DS_LOW_ADLDS_FFL = 8643, // 0x000021C3
		ERROR_INCORRECT_ACCOUNT_TYPE = 8646, // 0x000021C6
		ERROR_DS_MISSING_FOREST_TRUST = 8649, // 0x000021C9
		ERROR_DS_VALUE_KEY_NOT_UNIQUE = 8650, // 0x000021CA
		DNS_ERROR_RCODE_FORMAT_ERROR = 9001, // 0x00002329
		DNS_ERROR_RCODE_SERVER_FAILURE = 9002, // 0x0000232A
		DNS_ERROR_RCODE_NAME_ERROR = 9003, // 0x0000232B
		DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004, // 0x0000232C
		DNS_ERROR_RCODE_REFUSED = 9005, // 0x0000232D
		DNS_ERROR_RCODE_YXDOMAIN = 9006, // 0x0000232E
		DNS_ERROR_RCODE_YXRRSET = 9007, // 0x0000232F
		DNS_ERROR_RCODE_NXRRSET = 9008, // 0x00002330
		DNS_ERROR_RCODE_NOTAUTH = 9009, // 0x00002331
		DNS_ERROR_RCODE_NOTZONE = 9010, // 0x00002332
		DNS_ERROR_RCODE_BADSIG = 9016, // 0x00002338
		DNS_ERROR_RCODE_BADKEY = 9017, // 0x00002339
		DNS_ERROR_RCODE_BADTIME = 9018, // 0x0000233A
		DNS_ERROR_KEYMASTER_REQUIRED = 9101, // 0x0000238D
		DNS_ERROR_UNSUPPORTED_ALGORITHM = 9105, // 0x00002391
		DNS_ERROR_INVALID_KEY_SIZE = 9106, // 0x00002392
		DNS_ERROR_UNEXPECTED_CNG_ERROR = 9110, // 0x00002396
		DNS_ERROR_KSP_NOT_ACCESSIBLE = 9112, // 0x00002398
		DNS_ERROR_TOO_MANY_SKDS = 9113, // 0x00002399
		DNS_ERROR_ROLLOVER_IN_PROGRESS = 9116, // 0x0000239C
		DNS_ERROR_NOT_ALLOWED_ON_ZSK = 9118, // 0x0000239E
		DNS_ERROR_BAD_KEYMASTER = 9122, // 0x000023A2
		DNS_ERROR_DNSSEC_IS_DISABLED = 9125, // 0x000023A5
		DNS_ERROR_INVALID_XML = 9126, // 0x000023A6
		DNS_ERROR_ROLLOVER_NOT_POKEABLE = 9128, // 0x000023A8
		DNS_ERROR_NSEC3_NAME_COLLISION = 9129, // 0x000023A9
		DNS_INFO_NO_RECORDS = 9501, // 0x0000251D
		DNS_ERROR_BAD_PACKET = 9502, // 0x0000251E
		DNS_ERROR_NO_PACKET = 9503, // 0x0000251F
		DNS_ERROR_RCODE = 9504, // 0x00002520
		DNS_ERROR_UNSECURE_PACKET = 9505, // 0x00002521
		DNS_REQUEST_PENDING = 9506, // 0x00002522
		DNS_ERROR_INVALID_TYPE = 9551, // 0x0000254F
		DNS_ERROR_INVALID_IP_ADDRESS = 9552, // 0x00002550
		DNS_ERROR_INVALID_PROPERTY = 9553, // 0x00002551
		DNS_ERROR_TRY_AGAIN_LATER = 9554, // 0x00002552
		DNS_ERROR_NOT_UNIQUE = 9555, // 0x00002553
		DNS_ERROR_NON_RFC_NAME = 9556, // 0x00002554
		DNS_STATUS_FQDN = 9557, // 0x00002555
		DNS_STATUS_DOTTED_NAME = 9558, // 0x00002556
		DNS_STATUS_SINGLE_PART_NAME = 9559, // 0x00002557
		DNS_ERROR_INVALID_NAME_CHAR = 9560, // 0x00002558
		DNS_ERROR_NUMERIC_NAME = 9561, // 0x00002559
		DNS_ERROR_DWORD_VALUE_TOO_SMALL = 9566, // 0x0000255E
		DNS_ERROR_DWORD_VALUE_TOO_LARGE = 9567, // 0x0000255F
		DNS_ERROR_BACKGROUND_LOADING = 9568, // 0x00002560
		DNS_ERROR_NOT_ALLOWED_ON_RODC = 9569, // 0x00002561
		DNS_ERROR_DELEGATION_REQUIRED = 9571, // 0x00002563
		DNS_ERROR_INVALID_POLICY_TABLE = 9572, // 0x00002564
		DNS_ERROR_ADDRESS_REQUIRED = 9573, // 0x00002565
		DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601, // 0x00002581
		DNS_ERROR_NO_ZONE_INFO = 9602, // 0x00002582
		DNS_ERROR_ZONE_LOCKED = 9607, // 0x00002587
		DNS_ERROR_ZONE_CREATION_FAILED = 9608, // 0x00002588
		DNS_ERROR_ZONE_ALREADY_EXISTS = 9609, // 0x00002589
		DNS_ERROR_INVALID_ZONE_TYPE = 9611, // 0x0000258B
		DNS_ERROR_ZONE_NOT_SECONDARY = 9613, // 0x0000258D
		DNS_ERROR_WINS_INIT_FAILED = 9615, // 0x0000258F
		DNS_ERROR_NEED_WINS_SERVERS = 9616, // 0x00002590
		DNS_ERROR_NBSTAT_INIT_FAILED = 9617, // 0x00002591
		DNS_ERROR_SOA_DELETE_INVALID = 9618, // 0x00002592
		DNS_ERROR_ZONE_IS_SHUTDOWN = 9621, // 0x00002595
		DNS_ERROR_INVALID_DATAFILE_NAME = 9652, // 0x000025B4
		DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653, // 0x000025B5
		DNS_ERROR_FILE_WRITEBACK_FAILED = 9654, // 0x000025B6
		DNS_ERROR_DATAFILE_PARSING = 9655, // 0x000025B7
		DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701, // 0x000025E5
		DNS_ERROR_RECORD_FORMAT = 9702, // 0x000025E6
		DNS_ERROR_NODE_CREATION_FAILED = 9703, // 0x000025E7
		DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704, // 0x000025E8
		DNS_ERROR_RECORD_TIMED_OUT = 9705, // 0x000025E9
		DNS_ERROR_NAME_NOT_IN_ZONE = 9706, // 0x000025EA
		DNS_ERROR_CNAME_LOOP = 9707, // 0x000025EB
		DNS_ERROR_NODE_IS_CNAME = 9708, // 0x000025EC
		DNS_ERROR_CNAME_COLLISION = 9709, // 0x000025ED
		DNS_ERROR_RECORD_ALREADY_EXISTS = 9711, // 0x000025EF
		DNS_ERROR_SECONDARY_DATA = 9712, // 0x000025F0
		DNS_ERROR_NO_CREATE_CACHE_DATA = 9713, // 0x000025F1
		DNS_ERROR_NAME_DOES_NOT_EXIST = 9714, // 0x000025F2
		DNS_WARNING_PTR_CREATE_FAILED = 9715, // 0x000025F3
		DNS_WARNING_DOMAIN_UNDELETED = 9716, // 0x000025F4
		DNS_ERROR_DS_UNAVAILABLE = 9717, // 0x000025F5
		DNS_ERROR_NODE_IS_DNAME = 9720, // 0x000025F8
		DNS_ERROR_DNAME_COLLISION = 9721, // 0x000025F9
		DNS_ERROR_ALIAS_LOOP = 9722, // 0x000025FA
		DNS_INFO_AXFR_COMPLETE = 9751, // 0x00002617
		DNS_ERROR_AXFR = 9752, // 0x00002618
		DNS_INFO_ADDED_LOCAL_WINS = 9753, // 0x00002619
		DNS_STATUS_CONTINUE_NEEDED = 9801, // 0x00002649
		DNS_ERROR_NO_TCPIP = 9851, // 0x0000267B
		DNS_ERROR_NO_DNS_SERVERS = 9852, // 0x0000267C
		DNS_ERROR_DP_DOES_NOT_EXIST = 9901, // 0x000026AD
		DNS_ERROR_DP_ALREADY_EXISTS = 9902, // 0x000026AE
		DNS_ERROR_DP_NOT_ENLISTED = 9903, // 0x000026AF
		DNS_ERROR_DP_ALREADY_ENLISTED = 9904, // 0x000026B0
		DNS_ERROR_DP_NOT_AVAILABLE = 9905, // 0x000026B1
		DNS_ERROR_DP_FSMO_ERROR = 9906, // 0x000026B2
		DNS_ERROR_DEFAULT_ZONESCOPE = 9953, // 0x000026E1
		DNS_ERROR_LOAD_ZONESCOPE_FAILED = 9956, // 0x000026E4
		DNS_ERROR_INVALID_SCOPE_NAME = 9958, // 0x000026E6
		DNS_ERROR_SCOPE_DOES_NOT_EXIST = 9959, // 0x000026E7
		DNS_ERROR_DEFAULT_SCOPE = 9960, // 0x000026E8
		DNS_ERROR_SCOPE_LOCKED = 9962, // 0x000026EA
		DNS_ERROR_SCOPE_ALREADY_EXISTS = 9963, // 0x000026EB
		DNS_ERROR_POLICY_ALREADY_EXISTS = 9971, // 0x000026F3
		DNS_ERROR_POLICY_DOES_NOT_EXIST = 9972, // 0x000026F4
		DNS_ERROR_SUBNET_DOES_NOT_EXIST = 9978, // 0x000026FA
		DNS_ERROR_SUBNET_ALREADY_EXISTS = 9979, // 0x000026FB
		DNS_ERROR_POLICY_LOCKED = 9980, // 0x000026FC
		DNS_ERROR_POLICY_INVALID_WEIGHT = 9981, // 0x000026FD
		DNS_ERROR_POLICY_INVALID_NAME = 9982, // 0x000026FE
		DNS_ERROR_POLICY_SCOPE_MISSING = 9986, // 0x00002702
		WSAEINTR = 10004, // 0x00002714
		WSAEBADF = 10009, // 0x00002719
		WSAEACCES = 10013, // 0x0000271D
		WSAEFAULT = 10014, // 0x0000271E
		WSAEINVAL = 10022, // 0x00002726
		WSAEMFILE = 10024, // 0x00002728
		WSAEWOULDBLOCK = 10035, // 0x00002733
		WSAEINPROGRESS = 10036, // 0x00002734
		WSAEALREADY = 10037, // 0x00002735
		WSAENOTSOCK = 10038, // 0x00002736
		WSAEDESTADDRREQ = 10039, // 0x00002737
		WSAEMSGSIZE = 10040, // 0x00002738
		WSAEPROTOTYPE = 10041, // 0x00002739
		WSAENOPROTOOPT = 10042, // 0x0000273A
		WSAEPROTONOSUPPORT = 10043, // 0x0000273B
		WSAESOCKTNOSUPPORT = 10044, // 0x0000273C
		WSAEOPNOTSUPP = 10045, // 0x0000273D
		WSAEPFNOSUPPORT = 10046, // 0x0000273E
		WSAEAFNOSUPPORT = 10047, // 0x0000273F
		WSAEADDRINUSE = 10048, // 0x00002740
		WSAEADDRNOTAVAIL = 10049, // 0x00002741
		WSAENETDOWN = 10050, // 0x00002742
		WSAENETUNREACH = 10051, // 0x00002743
		WSAENETRESET = 10052, // 0x00002744
		WSAECONNABORTED = 10053, // 0x00002745
		WSAECONNRESET = 10054, // 0x00002746
		WSAENOBUFS = 10055, // 0x00002747
		WSAEISCONN = 10056, // 0x00002748
		WSAENOTCONN = 10057, // 0x00002749
		WSAESHUTDOWN = 10058, // 0x0000274A
		WSAETOOMANYREFS = 10059, // 0x0000274B
		WSAETIMEDOUT = 10060, // 0x0000274C
		WSAECONNREFUSED = 10061, // 0x0000274D
		WSAELOOP = 10062, // 0x0000274E
		WSAENAMETOOLONG = 10063, // 0x0000274F
		WSAEHOSTDOWN = 10064, // 0x00002750
		WSAEHOSTUNREACH = 10065, // 0x00002751
		WSAENOTEMPTY = 10066, // 0x00002752
		WSAEPROCLIM = 10067, // 0x00002753
		WSAEUSERS = 10068, // 0x00002754
		WSAEDQUOT = 10069, // 0x00002755
		WSAESTALE = 10070, // 0x00002756
		WSAEREMOTE = 10071, // 0x00002757
		WSASYSNOTREADY = 10091, // 0x0000276B
		WSAVERNOTSUPPORTED = 10092, // 0x0000276C
		WSANOTINITIALISED = 10093, // 0x0000276D
		WSAEDISCON = 10101, // 0x00002775
		WSAENOMORE = 10102, // 0x00002776
		WSAECANCELLED = 10103, // 0x00002777
		WSAEINVALIDPROCTABLE = 10104, // 0x00002778
		WSAEINVALIDPROVIDER = 10105, // 0x00002779
		WSAEPROVIDERFAILEDINIT = 10106, // 0x0000277A
		WSASYSCALLFAILURE = 10107, // 0x0000277B
		WSASERVICE_NOT_FOUND = 10108, // 0x0000277C
		WSATYPE_NOT_FOUND = 10109, // 0x0000277D
		WSA_E_NO_MORE = 10110, // 0x0000277E
		WSA_E_CANCELLED = 10111, // 0x0000277F
		WSAEREFUSED = 10112, // 0x00002780
		WSAHOST_NOT_FOUND = 11001, // 0x00002AF9
		WSATRY_AGAIN = 11002, // 0x00002AFA
		WSANO_RECOVERY = 11003, // 0x00002AFB
		WSANO_DATA = 11004, // 0x00002AFC
		WSA_QOS_RECEIVERS = 11005, // 0x00002AFD
		WSA_QOS_SENDERS = 11006, // 0x00002AFE
		WSA_QOS_NO_SENDERS = 11007, // 0x00002AFF
		WSA_QOS_NO_RECEIVERS = 11008, // 0x00002B00
		WSA_QOS_REQUEST_CONFIRMED = 11009, // 0x00002B01
		WSA_QOS_ADMISSION_FAILURE = 11010, // 0x00002B02
		WSA_QOS_POLICY_FAILURE = 11011, // 0x00002B03
		WSA_QOS_BAD_STYLE = 11012, // 0x00002B04
		WSA_QOS_BAD_OBJECT = 11013, // 0x00002B05
		WSA_QOS_TRAFFIC_CTRL_ERROR = 11014, // 0x00002B06
		WSA_QOS_GENERIC_ERROR = 11015, // 0x00002B07
		WSA_QOS_ESERVICETYPE = 11016, // 0x00002B08
		WSA_QOS_EFLOWSPEC = 11017, // 0x00002B09
		WSA_QOS_EPROVSPECBUF = 11018, // 0x00002B0A
		WSA_QOS_EFILTERSTYLE = 11019, // 0x00002B0B
		WSA_QOS_EFILTERTYPE = 11020, // 0x00002B0C
		WSA_QOS_EFILTERCOUNT = 11021, // 0x00002B0D
		WSA_QOS_EOBJLENGTH = 11022, // 0x00002B0E
		WSA_QOS_EFLOWCOUNT = 11023, // 0x00002B0F
		WSA_QOS_EUNKOWNPSOBJ = 11024, // 0x00002B10
		WSA_QOS_EPOLICYOBJ = 11025, // 0x00002B11
		WSA_QOS_EFLOWDESC = 11026, // 0x00002B12
		WSA_QOS_EPSFLOWSPEC = 11027, // 0x00002B13
		WSA_QOS_EPSFILTERSPEC = 11028, // 0x00002B14
		WSA_QOS_ESDMODEOBJ = 11029, // 0x00002B15
		WSA_QOS_ESHAPERATEOBJ = 11030, // 0x00002B16
		WSA_QOS_RESERVED_PETYPE = 11031, // 0x00002B17
		WSA_SECURE_HOST_NOT_FOUND = 11032, // 0x00002B18
		WSA_IPSEC_NAME_POLICY_ERROR = 11033, // 0x00002B19
		ERROR_IPSEC_QM_POLICY_EXISTS = 13000, // 0x000032C8
		ERROR_IPSEC_QM_POLICY_NOT_FOUND = 13001, // 0x000032C9
		ERROR_IPSEC_QM_POLICY_IN_USE = 13002, // 0x000032CA
		ERROR_IPSEC_MM_POLICY_EXISTS = 13003, // 0x000032CB
		ERROR_IPSEC_MM_POLICY_NOT_FOUND = 13004, // 0x000032CC
		ERROR_IPSEC_MM_POLICY_IN_USE = 13005, // 0x000032CD
		ERROR_IPSEC_MM_FILTER_EXISTS = 13006, // 0x000032CE
		ERROR_IPSEC_MM_FILTER_NOT_FOUND = 13007, // 0x000032CF
		ERROR_IPSEC_MM_AUTH_EXISTS = 13010, // 0x000032D2
		ERROR_IPSEC_MM_AUTH_NOT_FOUND = 13011, // 0x000032D3
		ERROR_IPSEC_MM_AUTH_IN_USE = 13012, // 0x000032D4
		WARNING_IPSEC_MM_POLICY_PRUNED = 13024, // 0x000032E0
		WARNING_IPSEC_QM_POLICY_PRUNED = 13025, // 0x000032E1
		ERROR_IPSEC_IKE_AUTH_FAIL = 13801, // 0x000035E9
		ERROR_IPSEC_IKE_ATTRIB_FAIL = 13802, // 0x000035EA
		ERROR_IPSEC_IKE_TIMED_OUT = 13805, // 0x000035ED
		ERROR_IPSEC_IKE_NO_CERT = 13806, // 0x000035EE
		ERROR_IPSEC_IKE_SA_DELETED = 13807, // 0x000035EF
		ERROR_IPSEC_IKE_SA_REAPED = 13808, // 0x000035F0
		ERROR_IPSEC_IKE_MM_ACQUIRE_DROP = 13809, // 0x000035F1
		ERROR_IPSEC_IKE_QM_ACQUIRE_DROP = 13810, // 0x000035F2
		ERROR_IPSEC_IKE_QUEUE_DROP_MM = 13811, // 0x000035F3
		ERROR_IPSEC_IKE_MM_DELAY_DROP = 13814, // 0x000035F6
		ERROR_IPSEC_IKE_QM_DELAY_DROP = 13815, // 0x000035F7
		ERROR_IPSEC_IKE_ERROR = 13816, // 0x000035F8
		ERROR_IPSEC_IKE_CRL_FAILED = 13817, // 0x000035F9
		ERROR_IPSEC_IKE_NO_PRIVATE_KEY = 13820, // 0x000035FC
		ERROR_IPSEC_IKE_DH_FAIL = 13822, // 0x000035FE
		ERROR_IPSEC_IKE_INVALID_HEADER = 13824, // 0x00003600
		ERROR_IPSEC_IKE_NO_POLICY = 13825, // 0x00003601
		ERROR_IPSEC_IKE_KERBEROS_ERROR = 13827, // 0x00003603
		ERROR_IPSEC_IKE_NO_PUBLIC_KEY = 13828, // 0x00003604
		ERROR_IPSEC_IKE_PROCESS_ERR = 13829, // 0x00003605
		ERROR_IPSEC_IKE_PROCESS_ERR_SA = 13830, // 0x00003606
		ERROR_IPSEC_IKE_PROCESS_ERR_KE = 13833, // 0x00003609
		ERROR_IPSEC_IKE_PROCESS_ERR_ID = 13834, // 0x0000360A
		ERROR_IPSEC_IKE_PROCESS_ERR_SIG = 13838, // 0x0000360E
		ERROR_IPSEC_IKE_INVALID_PAYLOAD = 13843, // 0x00003613
		ERROR_IPSEC_IKE_LOAD_SOFT_SA = 13844, // 0x00003614
		ERROR_IPSEC_IKE_INVALID_COOKIE = 13846, // 0x00003616
		ERROR_IPSEC_IKE_NO_PEER_CERT = 13847, // 0x00003617
		ERROR_IPSEC_IKE_PEER_CRL_FAILED = 13848, // 0x00003618
		ERROR_IPSEC_IKE_POLICY_CHANGE = 13849, // 0x00003619
		ERROR_IPSEC_IKE_NO_MM_POLICY = 13850, // 0x0000361A
		ERROR_IPSEC_IKE_NOTCBPRIV = 13851, // 0x0000361B
		ERROR_IPSEC_IKE_SECLOADFAIL = 13852, // 0x0000361C
		ERROR_IPSEC_IKE_FAILSSPINIT = 13853, // 0x0000361D
		ERROR_IPSEC_IKE_FAILQUERYSSP = 13854, // 0x0000361E
		ERROR_IPSEC_IKE_SRVACQFAIL = 13855, // 0x0000361F
		ERROR_IPSEC_IKE_SRVQUERYCRED = 13856, // 0x00003620
		ERROR_IPSEC_IKE_GETSPIFAIL = 13857, // 0x00003621
		ERROR_IPSEC_IKE_INVALID_FILTER = 13858, // 0x00003622
		ERROR_IPSEC_IKE_OUT_OF_MEMORY = 13859, // 0x00003623
		ERROR_IPSEC_IKE_INVALID_POLICY = 13861, // 0x00003625
		ERROR_IPSEC_IKE_UNKNOWN_DOI = 13862, // 0x00003626
		ERROR_IPSEC_IKE_DH_FAILURE = 13864, // 0x00003628
		ERROR_IPSEC_IKE_INVALID_GROUP = 13865, // 0x00003629
		ERROR_IPSEC_IKE_ENCRYPT = 13866, // 0x0000362A
		ERROR_IPSEC_IKE_DECRYPT = 13867, // 0x0000362B
		ERROR_IPSEC_IKE_POLICY_MATCH = 13868, // 0x0000362C
		ERROR_IPSEC_IKE_UNSUPPORTED_ID = 13869, // 0x0000362D
		ERROR_IPSEC_IKE_INVALID_HASH = 13870, // 0x0000362E
		ERROR_IPSEC_IKE_INVALID_SIG = 13875, // 0x00003633
		ERROR_IPSEC_IKE_LOAD_FAILED = 13876, // 0x00003634
		ERROR_IPSEC_IKE_RPC_DELETE = 13877, // 0x00003635
		ERROR_IPSEC_IKE_BENIGN_REINIT = 13878, // 0x00003636
		ERROR_IPSEC_IKE_MM_LIMIT = 13882, // 0x0000363A
		ERROR_IPSEC_IKE_QM_LIMIT = 13884, // 0x0000363C
		ERROR_IPSEC_IKE_MM_EXPIRED = 13885, // 0x0000363D
		ERROR_IPSEC_IKE_DOS_COOKIE_SENT = 13890, // 0x00003642
		ERROR_IPSEC_IKE_SHUTTING_DOWN = 13891, // 0x00003643
		ERROR_IPSEC_IKE_CGA_AUTH_FAILED = 13892, // 0x00003644
		ERROR_IPSEC_IKE_QM_EXPIRED = 13895, // 0x00003647
		ERROR_IPSEC_IKE_NEG_STATUS_END = 13897, // 0x00003649
		ERROR_IPSEC_IKE_RATELIMIT_DROP = 13903, // 0x0000364F
		ERROR_IPSEC_BAD_SPI = 13910, // 0x00003656
		ERROR_IPSEC_SA_LIFETIME_EXPIRED = 13911, // 0x00003657
		ERROR_IPSEC_WRONG_SA = 13912, // 0x00003658
		ERROR_IPSEC_REPLAY_CHECK_FAILED = 13913, // 0x00003659
		ERROR_IPSEC_INVALID_PACKET = 13914, // 0x0000365A
		ERROR_IPSEC_CLEAR_TEXT_DROP = 13916, // 0x0000365C
		ERROR_IPSEC_AUTH_FIREWALL_DROP = 13917, // 0x0000365D
		ERROR_IPSEC_THROTTLE_DROP = 13918, // 0x0000365E
		ERROR_IPSEC_DOSP_BLOCK = 13925, // 0x00003665
		ERROR_IPSEC_DOSP_INVALID_PACKET = 13927, // 0x00003667
		ERROR_IPSEC_DOSP_MAX_ENTRIES = 13929, // 0x00003669
		ERROR_IPSEC_DOSP_NOT_INSTALLED = 13931, // 0x0000366B
		ERROR_SXS_SECTION_NOT_FOUND = 14000, // 0x000036B0
		ERROR_SXS_CANT_GEN_ACTCTX = 14001, // 0x000036B1
		ERROR_SXS_ASSEMBLY_NOT_FOUND = 14003, // 0x000036B3
		ERROR_SXS_MANIFEST_FORMAT_ERROR = 14004, // 0x000036B4
		ERROR_SXS_MANIFEST_PARSE_ERROR = 14005, // 0x000036B5
		ERROR_SXS_KEY_NOT_FOUND = 14007, // 0x000036B7
		ERROR_SXS_VERSION_CONFLICT = 14008, // 0x000036B8
		ERROR_SXS_WRONG_SECTION_TYPE = 14009, // 0x000036B9
		ERROR_SXS_UNKNOWN_ENCODING = 14013, // 0x000036BD
		ERROR_SXS_DUPLICATE_DLL_NAME = 14021, // 0x000036C5
		ERROR_SXS_DUPLICATE_CLSID = 14023, // 0x000036C7
		ERROR_SXS_DUPLICATE_IID = 14024, // 0x000036C8
		ERROR_SXS_DUPLICATE_TLBID = 14025, // 0x000036C9
		ERROR_SXS_DUPLICATE_PROGID = 14026, // 0x000036CA
		ERROR_SXS_FILE_HASH_MISMATCH = 14028, // 0x000036CC
		ERROR_SXS_POLICY_PARSE_ERROR = 14029, // 0x000036CD
		ERROR_SXS_XML_E_MISSINGQUOTE = 14030, // 0x000036CE
		ERROR_SXS_XML_E_COMMENTSYNTAX = 14031, // 0x000036CF
		ERROR_SXS_XML_E_BADNAMECHAR = 14033, // 0x000036D1
		ERROR_SXS_XML_E_BADCHARINSTRING = 14034, // 0x000036D2
		ERROR_SXS_XML_E_XMLDECLSYNTAX = 14035, // 0x000036D3
		ERROR_SXS_XML_E_BADCHARDATA = 14036, // 0x000036D4
		ERROR_SXS_XML_E_EXPECTINGTAGEND = 14038, // 0x000036D6
		ERROR_SXS_XML_E_UNBALANCEDPAREN = 14040, // 0x000036D8
		ERROR_SXS_XML_E_INTERNALERROR = 14041, // 0x000036D9
		ERROR_SXS_XML_E_MISSING_PAREN = 14044, // 0x000036DC
		ERROR_SXS_XML_E_MULTIPLE_COLONS = 14046, // 0x000036DE
		ERROR_SXS_XML_E_INVALID_DECIMAL = 14047, // 0x000036DF
		ERROR_SXS_XML_E_INVALID_UNICODE = 14049, // 0x000036E1
		ERROR_SXS_XML_E_UNCLOSEDTAG = 14052, // 0x000036E4
		ERROR_SXS_XML_E_MULTIPLEROOTS = 14054, // 0x000036E6
		ERROR_SXS_XML_E_BADXMLDECL = 14056, // 0x000036E8
		ERROR_SXS_XML_E_MISSINGROOT = 14057, // 0x000036E9
		ERROR_SXS_XML_E_UNEXPECTEDEOF = 14058, // 0x000036EA
		ERROR_SXS_XML_E_UNCLOSEDENDTAG = 14061, // 0x000036ED
		ERROR_SXS_XML_E_UNCLOSEDSTRING = 14062, // 0x000036EE
		ERROR_SXS_XML_E_UNCLOSEDCOMMENT = 14063, // 0x000036EF
		ERROR_SXS_XML_E_UNCLOSEDDECL = 14064, // 0x000036F0
		ERROR_SXS_XML_E_UNCLOSEDCDATA = 14065, // 0x000036F1
		ERROR_SXS_XML_E_INVALIDENCODING = 14067, // 0x000036F3
		ERROR_SXS_XML_E_INVALIDSWITCH = 14068, // 0x000036F4
		ERROR_SXS_XML_E_BADXMLCASE = 14069, // 0x000036F5
		ERROR_SXS_XML_E_INVALID_VERSION = 14072, // 0x000036F8
		ERROR_SXS_XML_E_MISSINGEQUALS = 14073, // 0x000036F9
		ERROR_SXS_ASSEMBLY_MISSING = 14081, // 0x00003701
		ERROR_SXS_CORRUPTION = 14083, // 0x00003703
		ERROR_SXS_EARLY_DEACTIVATION = 14084, // 0x00003704
		ERROR_SXS_INVALID_DEACTIVATION = 14085, // 0x00003705
		ERROR_SXS_MULTIPLE_DEACTIVATION = 14086, // 0x00003706
		ERROR_SXS_IDENTITY_PARSE_ERROR = 14093, // 0x0000370D
		ERROR_SXS_ASSEMBLY_NOT_LOCKED = 14097, // 0x00003711
		ERROR_ADVANCED_INSTALLER_FAILED = 14099, // 0x00003713
		ERROR_XML_ENCODING_MISMATCH = 14100, // 0x00003714
		ERROR_SXS_IDENTITIES_DIFFERENT = 14102, // 0x00003716
		ERROR_SXS_MANIFEST_TOO_BIG = 14105, // 0x00003719
		ERROR_GENERIC_COMMAND_FAILED = 14109, // 0x0000371D
		ERROR_SXS_FILE_HASH_MISSING = 14110, // 0x0000371E
		ERROR_EVT_INVALID_CHANNEL_PATH = 15000, // 0x00003A98
		ERROR_EVT_INVALID_QUERY = 15001, // 0x00003A99
		ERROR_EVT_INVALID_EVENT_DATA = 15005, // 0x00003A9D
		ERROR_EVT_CHANNEL_NOT_FOUND = 15007, // 0x00003A9F
		ERROR_EVT_MALFORMED_XML_TEXT = 15008, // 0x00003AA0
		ERROR_EVT_CONFIGURATION_ERROR = 15010, // 0x00003AA2
		ERROR_EVT_QUERY_RESULT_STALE = 15011, // 0x00003AA3
		ERROR_EVT_NON_VALIDATING_MSXML = 15013, // 0x00003AA5
		ERROR_EVT_FILTER_ALREADYSCOPED = 15014, // 0x00003AA6
		ERROR_EVT_FILTER_NOTELTSET = 15015, // 0x00003AA7
		ERROR_EVT_FILTER_INVARG = 15016, // 0x00003AA8
		ERROR_EVT_FILTER_INVTEST = 15017, // 0x00003AA9
		ERROR_EVT_FILTER_INVTYPE = 15018, // 0x00003AAA
		ERROR_EVT_FILTER_PARSEERR = 15019, // 0x00003AAB
		ERROR_EVT_FILTER_UNSUPPORTEDOP = 15020, // 0x00003AAC
		ERROR_EVT_FILTER_TOO_COMPLEX = 15026, // 0x00003AB2
		ERROR_EVT_MESSAGE_NOT_FOUND = 15027, // 0x00003AB3
		ERROR_EVT_MESSAGE_ID_NOT_FOUND = 15028, // 0x00003AB4
		ERROR_EVT_MAX_INSERTS_REACHED = 15031, // 0x00003AB7
		ERROR_EVT_VERSION_TOO_OLD = 15034, // 0x00003ABA
		ERROR_EVT_VERSION_TOO_NEW = 15035, // 0x00003ABB
		ERROR_EVT_PUBLISHER_DISABLED = 15037, // 0x00003ABD
		ERROR_EVT_FILTER_OUT_OF_RANGE = 15038, // 0x00003ABE
		ERROR_EC_LOG_DISABLED = 15081, // 0x00003AE9
		ERROR_EC_CIRCULAR_FORWARDING = 15082, // 0x00003AEA
		ERROR_EC_CREDSTORE_FULL = 15083, // 0x00003AEB
		ERROR_EC_CRED_NOT_FOUND = 15084, // 0x00003AEC
		ERROR_EC_NO_ACTIVE_CHANNEL = 15085, // 0x00003AED
		ERROR_MUI_FILE_NOT_FOUND = 15100, // 0x00003AFC
		ERROR_MUI_INVALID_FILE = 15101, // 0x00003AFD
		ERROR_MUI_INVALID_RC_CONFIG = 15102, // 0x00003AFE
		ERROR_MUI_INVALID_LOCALE_NAME = 15103, // 0x00003AFF
		ERROR_MUI_FILE_NOT_LOADED = 15105, // 0x00003B01
		ERROR_RESOURCE_ENUM_USER_STOP = 15106, // 0x00003B02
		ERROR_MRM_INVALID_PRICONFIG = 15111, // 0x00003B07
		ERROR_MRM_INVALID_FILE_TYPE = 15112, // 0x00003B08
		ERROR_MRM_UNKNOWN_QUALIFIER = 15113, // 0x00003B09
		ERROR_MRM_NO_CANDIDATE = 15115, // 0x00003B0B
		ERROR_MRM_DUPLICATE_MAP_NAME = 15118, // 0x00003B0E
		ERROR_MRM_DUPLICATE_ENTRY = 15119, // 0x00003B0F
		ERROR_MRM_FILEPATH_TOO_LONG = 15121, // 0x00003B11
		ERROR_MRM_INVALID_PRI_FILE = 15126, // 0x00003B16
		ERROR_MRM_MAP_NOT_FOUND = 15135, // 0x00003B1F
		ERROR_MRM_AUTOMERGE_ENABLED = 15139, // 0x00003B23
		ERROR_MRM_TOO_MANY_RESOURCES = 15140, // 0x00003B24
		ERROR_MCA_INVALID_VCP_VERSION = 15201, // 0x00003B61
		ERROR_MCA_MCCS_VERSION_MISMATCH = 15203, // 0x00003B63
		ERROR_MCA_INTERNAL_ERROR = 15205, // 0x00003B65
		ERROR_AMBIGUOUS_SYSTEM_DEVICE = 15250, // 0x00003B92
		ERROR_SYSTEM_DEVICE_NOT_FOUND = 15299, // 0x00003BC3
		ERROR_HASH_NOT_SUPPORTED = 15300, // 0x00003BC4
		ERROR_HASH_NOT_PRESENT = 15301, // 0x00003BC5
		ERROR_GPIO_OPERATION_DENIED = 15325, // 0x00003BDD
		ERROR_CANNOT_SWITCH_RUNLEVEL = 15400, // 0x00003C28
		ERROR_INVALID_RUNLEVEL_SETTING = 15401, // 0x00003C29
		ERROR_RUNLEVEL_SWITCH_TIMEOUT = 15402, // 0x00003C2A
		ERROR_SERVICES_FAILED_AUTOSTART = 15405, // 0x00003C2D
		ERROR_COM_TASK_STOP_PENDING = 15501, // 0x00003C8D
		ERROR_INSTALL_PACKAGE_NOT_FOUND = 15601, // 0x00003CF1
		ERROR_INSTALL_INVALID_PACKAGE = 15602, // 0x00003CF2
		ERROR_INSTALL_OUT_OF_DISK_SPACE = 15604, // 0x00003CF4
		ERROR_INSTALL_NETWORK_FAILURE = 15605, // 0x00003CF5
		ERROR_INSTALL_CANCEL = 15608, // 0x00003CF8
		ERROR_INSTALL_FAILED = 15609, // 0x00003CF9
		ERROR_REMOVE_FAILED = 15610, // 0x00003CFA
		ERROR_PACKAGE_ALREADY_EXISTS = 15611, // 0x00003CFB
		ERROR_NEEDS_REMEDIATION = 15612, // 0x00003CFC
		ERROR_INSTALL_POLICY_FAILURE = 15615, // 0x00003CFF
		ERROR_PACKAGE_UPDATING = 15616, // 0x00003D00
		ERROR_PACKAGES_IN_USE = 15618, // 0x00003D02
		ERROR_RECOVERY_FILE_CORRUPT = 15619, // 0x00003D03
		ERROR_INVALID_STAGED_SIGNATURE = 15620, // 0x00003D04
		ERROR_INSTALL_PACKAGE_DOWNGRADE = 15622, // 0x00003D06
		ERROR_SYSTEM_NEEDS_REMEDIATION = 15623, // 0x00003D07
		ERROR_RESILIENCY_FILE_CORRUPT = 15625, // 0x00003D09
		ERROR_PACKAGE_MOVE_FAILED = 15627, // 0x00003D0B
		ERROR_INSTALL_VOLUME_NOT_EMPTY = 15628, // 0x00003D0C
		ERROR_INSTALL_VOLUME_OFFLINE = 15629, // 0x00003D0D
		ERROR_INSTALL_VOLUME_CORRUPT = 15630, // 0x00003D0E
		ERROR_NEEDS_REGISTRATION = 15631, // 0x00003D0F
		APPMODEL_ERROR_NO_PACKAGE = 15700, // 0x00003D54
		APPMODEL_ERROR_NO_APPLICATION = 15703, // 0x00003D57
		ERROR_STATE_LOAD_STORE_FAILED = 15800, // 0x00003DB8
		ERROR_STATE_GET_VERSION_FAILED = 15801, // 0x00003DB9
		ERROR_STATE_SET_VERSION_FAILED = 15802, // 0x00003DBA
		ERROR_STATE_READ_SETTING_FAILED = 15807, // 0x00003DBF
		ERROR_API_UNAVAILABLE = 15841, // 0x00003DE1
		STORE_ERROR_UNLICENSED = 15861, // 0x00003DF5
		STORE_ERROR_UNLICENSED_USER = 15862, // 0x00003DF6
		STORE_ERROR_LICENSE_REVOKED = 15864, // 0x00003DF8
	}

	/// <summary>
	/// An exception thrown for a failure described by a <see cref="T:PInvoke.Win32ErrorCode" />.
	/// </summary>
	[Serializable]
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public class Win32Exception : System.ComponentModel.Win32Exception {
		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
		/// </summary>
		public Win32Exception() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
		/// </summary>
		/// <param name="error">The Win32 error code associated with this exception.</param>
		public Win32Exception(Win32ErrorCode error)
			: base((int) error) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
		/// </summary>
		/// <param name="error">The Win32 error code associated with this exception.</param>
		public Win32Exception(int error)
			: this((Win32ErrorCode) error) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
		/// </summary>
		/// <param name="error">The Win32 error code associated with this exception.</param>
		/// <param name="message">The message for this exception.</param>
		public Win32Exception(Win32ErrorCode error, string message)
			: base((int) error, message) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class
		/// for deserialization.
		/// </summary>
		/// <param name="info">Serialization information.</param>
		/// <param name="context">Streaming context.</param>
		protected Win32Exception(SerializationInfo info, StreamingContext context)
			: base(info, context) { }

		/// <summary>
		/// Gets the Win32 error code associated with this exception.
		/// </summary>
		/// <devremarks>
		/// We must define this so that our own assembly on desktop is not a subset
		/// of what portable offers (lest runtime errors in our users occur).
		/// </devremarks>
		public Win32ErrorCode NativeErrorCode {
			get { return (Win32ErrorCode) base.NativeErrorCode; }
		}
	}
}