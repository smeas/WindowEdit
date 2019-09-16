// Decompiled with JetBrains decompiler
// Type: PInvoke.HResult
// Assembly: PInvoke.Windows.Core, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: AF09BC8E-ECF7-4220-BFC4-1C1A8B4A0690
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.windows.core\0.5.155\lib\net35\PInvoke.Windows.Core.dll

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PInvoke
{
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
  public struct HResult : IComparable, IComparable<HResult>, IEquatable<HResult>, IFormattable
  {
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
    public HResult(HResult.Code value)
    {
      this.Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.HResult" /> struct.
    /// </summary>
    /// <param name="value">The value of the HRESULT.</param>
    public HResult(int value)
    {
      this = new HResult((HResult.Code) value);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.HResult" /> struct.
    /// </summary>
    /// <param name="value">The value of the HRESULT.</param>
    public HResult(uint value)
    {
      this = new HResult((HResult.Code) value);
    }

    /// <summary>
    /// Gets the full HRESULT value, as a <see cref="T:PInvoke.HResult.Code" /> enum.
    /// </summary>
    public HResult.Code Value { get; }

    /// <summary>Gets the HRESULT as a 32-bit signed integer.</summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int AsInt32
    {
      get
      {
        return (int) this.Value;
      }
    }

    /// <summary>Gets the HRESULT as a 32-bit unsigned integer.</summary>
    public uint AsUInt32
    {
      get
      {
        return (uint) this.Value;
      }
    }

    /// <summary>
    /// Gets a value indicating whether this HRESULT represents a successful operation.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public bool Succeeded
    {
      get
      {
        return this.Severity == HResult.SeverityCode.Success;
      }
    }

    /// <summary>
    /// Gets a value indicating whether this HRESULT represents a failured operation.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public bool Failed
    {
      get
      {
        return this.Severity == HResult.SeverityCode.Fail;
      }
    }

    /// <summary>Gets the facility code of the HRESULT.</summary>
    public HResult.FacilityCode Facility
    {
      get
      {
        return (HResult.FacilityCode) ((int) this.AsUInt32 & 134152192);
      }
    }

    /// <summary>Gets the severity of the HRESULT.</summary>
    public HResult.SeverityCode Severity
    {
      get
      {
        return (HResult.SeverityCode) ((int) this.AsUInt32 & int.MinValue);
      }
    }

    /// <summary>
    /// Gets the facility's status code bits from the HRESULT.
    /// </summary>
    public uint FacilityStatus
    {
      get
      {
        return this.AsUInt32 & (uint) ushort.MaxValue;
      }
    }

    /// <summary>
    /// Converts an <see cref="T:System.Int32" /> into an <see cref="T:PInvoke.HResult" />.
    /// </summary>
    /// <param name="hr">The value of the HRESULT.</param>
    public static implicit operator HResult(int hr)
    {
      return new HResult(hr);
    }

    /// <summary>
    /// Converts an <see cref="T:PInvoke.HResult" /> into an <see cref="T:System.Int32" />.
    /// </summary>
    /// <param name="hr">The value of the HRESULT.</param>
    public static implicit operator int(HResult hr)
    {
      return hr.AsInt32;
    }

    /// <summary>
    /// Converts an <see cref="T:System.UInt32" /> into an <see cref="T:PInvoke.HResult" />.
    /// </summary>
    /// <param name="hr">The value of the HRESULT.</param>
    public static implicit operator HResult(uint hr)
    {
      return new HResult(hr);
    }

    /// <summary>
    /// Converts an <see cref="T:PInvoke.HResult" /> into an <see cref="T:System.UInt32" />.
    /// </summary>
    /// <param name="hr">The value of the HRESULT.</param>
    public static explicit operator uint(HResult hr)
    {
      return hr.AsUInt32;
    }

    /// <summary>
    /// Converts a <see cref="T:PInvoke.HResult.Code" /> enum to its structural <see cref="T:PInvoke.HResult" /> representation.
    /// </summary>
    /// <param name="hr">The value to convert.</param>
    public static implicit operator HResult(HResult.Code hr)
    {
      return new HResult(hr);
    }

    /// <summary>
    /// Converts an <see cref="T:PInvoke.HResult" /> to its <see cref="T:PInvoke.HResult.Code" /> enum representation.
    /// </summary>
    /// <param name="hr">The value to convert.</param>
    public static implicit operator HResult.Code(HResult hr)
    {
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
    public static bool operator ==(HResult hr, uint value)
    {
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
    public static bool operator !=(HResult hr, uint value)
    {
      return (int) hr.AsUInt32 != (int) value;
    }

    /// <summary>
    /// Throws an exception if this HRESULT <see cref="P:PInvoke.HResult.Failed" />, based on the failure value.
    /// </summary>
    public void ThrowOnFailure()
    {
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
    public void ThrowOnFailure(IntPtr errorInfo)
    {
      Marshal.ThrowExceptionForHR(this.AsInt32, errorInfo);
    }

    /// <summary>
    /// Gets an exception that represents this <see cref="T:PInvoke.HResult" />
    /// if it represents a failure.
    /// </summary>
    /// <returns>The exception, if applicable; otherwise null.</returns>
    public Exception GetException()
    {
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
    public Exception GetException(IntPtr errorInfo)
    {
      return Marshal.GetExceptionForHR((int) this, errorInfo);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
      return this.AsInt32;
    }

    /// <inheritdoc />
    public bool Equals(HResult other)
    {
      return this.Value == other.Value;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is HResult)
        return this.Equals((HResult) obj);
      return false;
    }

    /// <inheritdoc />
    public int CompareTo(object obj)
    {
      return ((IComparable) this.Value).CompareTo(obj);
    }

    /// <inheritdoc />
    public int CompareTo(HResult other)
    {
      return this.Value.CompareTo((object) other.Value);
    }

    /// <inheritdoc />
    public override string ToString()
    {
      return this.Value.ToString();
    }

    /// <inheritdoc />
    public string ToString(string format, IFormatProvider formatProvider)
    {
      return this.AsUInt32.ToString(format, formatProvider);
    }

    /// <summary>Common HRESULT constants.</summary>
    public enum Code : uint
    {
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
    public enum FacilityCode : uint
    {
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
    public enum SeverityCode : uint
    {
      Success = 0,
      Fail = 2147483648, // 0x80000000
    }
  }
}
