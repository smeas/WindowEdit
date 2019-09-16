// Decompiled with JetBrains decompiler
// Type: PInvoke.NTStatusException
// Assembly: PInvoke.Kernel32, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: C15E8763-BB9D-4EBC-8549-4F3970187329
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.kernel32\0.5.155\lib\net40\PInvoke.Kernel32.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace PInvoke
{
  /// <summary>
  /// An exception thrown for a failure described by a <see cref="T:PInvoke.NTSTATUS" />.
  /// </summary>
  [Serializable]
  [StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
  public class NTStatusException : Exception
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class.
    /// </summary>
    /// <param name="statusCode">The status code identifying the error.</param>
    public NTStatusException(NTSTATUS statusCode)
      : this(statusCode, NTStatusException.GetMessage(statusCode))
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class.
    /// </summary>
    /// <param name="statusCode">The status code identifying the error.</param>
    /// <param name="message">The exception message (which may be null to use the default).</param>
    public NTStatusException(NTSTATUS statusCode, string message)
      : this(statusCode, message, (Exception) null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class.
    /// </summary>
    /// <param name="statusCode">The status code identifying the error.</param>
    /// <param name="message">The exception message (which may be null to use the default).</param>
    /// <param name="inner">The inner exception.</param>
    public NTStatusException(NTSTATUS statusCode, string message, Exception inner)
      : base(message ?? NTStatusException.GetMessage(statusCode), inner)
    {
      this.NativeErrorCode = statusCode;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.NTStatusException" /> class
    /// for deserialization.
    /// </summary>
    /// <param name="info">Serialization information.</param>
    /// <param name="context">Streaming context.</param>
    protected NTStatusException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.NativeErrorCode = NTSTATUS.op_Implicit(info.GetUInt32(nameof (NativeErrorCode)));
    }

    /// <summary>
    /// Gets the <see cref="T:PInvoke.NTSTATUS" /> code that identifies the error condition.
    /// </summary>
    public NTSTATUS NativeErrorCode { get; }

    /// <inheritdoc />
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      SerializationInfo serializationInfo = info;
      string name = "NativeErrorCode";
      NTSTATUS nativeErrorCode = this.NativeErrorCode;
      int asUint32 = (int) ((NTSTATUS) ref nativeErrorCode).get_AsUInt32();
      serializationInfo.AddValue(name, (uint) asUint32);
      base.GetObjectData(info, context);
    }

    /// <summary>
    /// Gets the message associated with the given <see cref="T:PInvoke.NTSTATUS" />.
    /// </summary>
    /// <param name="status">The <see cref="T:PInvoke.NTSTATUS" /> for the error.</param>
    /// <returns>The description of the error.</returns>
    private static string GetMessage(NTSTATUS status)
    {
      string str1 = string.Format("0x{0:X8}", (object) NTSTATUS.op_Explicit(status));
      string name = Enum.GetName(typeof (NTSTATUS.Code), (object) ((NTSTATUS) ref status).get_AsUInt32());
      string str2 = name == null || !(name != str1) ? str1 : string.Format("{0} ({1})", (object) name, (object) str1);
      string str3 = string.Format("NT_STATUS {0}: {1}", (object) NTStatusException.GetSeverityString(status), (object) str2);
      string message = status.GetMessage();
      if (message == null)
        return str3;
      return string.Format("{0} ({1})", (object) message, (object) str3);
    }

    private static string GetSeverityString(NTSTATUS status)
    {
      NTSTATUS.SeverityCode severity = ((NTSTATUS) ref status).get_Severity();
      if (severity <= 1073741824)
      {
        if (severity == null)
          return "success";
        if (severity == 1073741824)
          return "information";
      }
      else
      {
        if (severity == int.MinValue)
          return "warning";
        if (severity == -1073741824)
          return "error";
      }
      return string.Empty;
    }
  }
}
