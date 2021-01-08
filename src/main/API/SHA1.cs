//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class SHA1 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SHA1(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SHA1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SHA1() {
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

  public bool m_empty {
    set {
      NWNXLibPINVOKE.SHA1_m_empty_set(swigCPtr, value);
    } 
    get {
      bool ret = NWNXLibPINVOKE.SHA1_m_empty_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_data {
    set {
      NWNXLibPINVOKE.SHA1_m_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.SHA1_m_data_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public string m_hex {
    set {
      NWNXLibPINVOKE.SHA1_m_hex_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.SHA1_m_hex_get(swigCPtr);
      return ret;
    } 
  }

}

}