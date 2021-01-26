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

public class CTlkTableToken : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CTlkTableToken(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTlkTableToken obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CTlkTableToken() {
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

  public bool Equals(CTlkTableToken other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CTlkTableToken other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CTlkTableToken left, CTlkTableToken right) {
    return Equals(left, right);
  }

  public static bool operator !=(CTlkTableToken left, CTlkTableToken right) {
    return !Equals(left, right);
  }

  public uint m_nHash {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nHash_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CTlkTableToken_m_nHash_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sToken {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_sToken_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTableToken_m_sToken_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nActionCode {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nActionCode_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CTlkTableToken_m_nActionCode_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int m_nStrRef {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nStrRef_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTableToken_m_nStrRef_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public uint m_nStrRefDefault {
    set {
      NWNXLibPINVOKE.CTlkTableToken_m_nStrRefDefault_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CTlkTableToken_m_nStrRefDefault_get(swigCPtr);
      return ret;
    } 
  }

}

}
