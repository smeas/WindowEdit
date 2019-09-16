// Decompiled with JetBrains decompiler
// Type: PInvoke.Win32Exception
// Assembly: PInvoke.Kernel32, Version=0.5.0.0, Culture=neutral, PublicKeyToken=9e300f9f87f04a7a
// MVID: C15E8763-BB9D-4EBC-8549-4F3970187329
// Assembly location: C:\Users\Jonatan\.nuget\packages\pinvoke.kernel32\0.5.155\lib\net40\PInvoke.Kernel32.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace PInvoke
{
  /// <summary>
  /// An exception thrown for a failure described by a <see cref="T:PInvoke.Win32ErrorCode" />.
  /// </summary>
  [Serializable]
  [StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
  public class Win32Exception : System.ComponentModel.Win32Exception
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
    /// </summary>
    public Win32Exception()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
    /// </summary>
    /// <param name="error">The Win32 error code associated with this exception.</param>
    public Win32Exception(Win32ErrorCode error)
      : base((int) error)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
    /// </summary>
    /// <param name="error">The Win32 error code associated with this exception.</param>
    public Win32Exception(int error)
      : this((Win32ErrorCode) error)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class.
    /// </summary>
    /// <param name="error">The Win32 error code associated with this exception.</param>
    /// <param name="message">The message for this exception.</param>
    public Win32Exception(Win32ErrorCode error, string message)
      : base((int) error, message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:PInvoke.Win32Exception" /> class
    /// for deserialization.
    /// </summary>
    /// <param name="info">Serialization information.</param>
    /// <param name="context">Streaming context.</param>
    protected Win32Exception(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    /// <summary>
    /// Gets the Win32 error code associated with this exception.
    /// </summary>
    /// <devremarks>
    /// We must define this so that our own assembly on desktop is not a subset
    /// of what portable offers (lest runtime errors in our users occur).
    /// </devremarks>
    public Win32ErrorCode NativeErrorCode
    {
      get
      {
        return (Win32ErrorCode) base.NativeErrorCode;
      }
    }
  }
}
