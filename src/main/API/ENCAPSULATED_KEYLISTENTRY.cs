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

public class ENCAPSULATED_KEYLISTENTRY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ENCAPSULATED_KEYLISTENTRY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ENCAPSULATED_KEYLISTENTRY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ENCAPSULATED_KEYLISTENTRY() {
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

  public SWIGTYPE_p_unsigned_char resRef {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_resRef_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_resRef_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public uint nID {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nID_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nType {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nType_get(swigCPtr);
      return ret;
    } 
  }

  public ushort unused {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_unused_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_unused_get(swigCPtr);
      return ret;
    } 
  }

}

}