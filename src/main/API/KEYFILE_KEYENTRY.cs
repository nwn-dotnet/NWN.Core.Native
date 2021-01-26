//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class KEYFILE_KEYENTRY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public KEYFILE_KEYENTRY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KEYFILE_KEYENTRY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KEYFILE_KEYENTRY() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(KEYFILE_KEYENTRY other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is KEYFILE_KEYENTRY other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(KEYFILE_KEYENTRY left, KEYFILE_KEYENTRY right) {
    return Equals(left, right);
  }

  public static bool operator !=(KEYFILE_KEYENTRY left, KEYFILE_KEYENTRY right) {
    return !Equals(left, right);
  }

  public SWIGTYPE_p_unsigned_char resRef {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_resRef_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.KEYFILE_KEYENTRY_resRef_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public ushort nType {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_nType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.KEYFILE_KEYENTRY_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nID {
    set {
      NWNXLibPINVOKE.KEYFILE_KEYENTRY_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.KEYFILE_KEYENTRY_nID_get(swigCPtr);
      return ret;
    } 
  }

}

}
