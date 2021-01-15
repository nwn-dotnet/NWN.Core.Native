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

public class CKeyTableEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CKeyTableEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CKeyTableEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CKeyTableEntry() {
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

  public CResRef m_cResRef {
    set {
      NWNXLibPINVOKE.CKeyTableEntry_m_cResRef_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CKeyTableEntry_m_cResRef_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CRes m_pRes {
    set {
      NWNXLibPINVOKE.CKeyTableEntry_m_pRes_set(swigCPtr, CRes.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CKeyTableEntry_m_pRes_get(swigCPtr);
      CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
      return ret;
    } 
  }

  public RESID m_nID {
    set {
      NWNXLibPINVOKE.CKeyTableEntry_m_nID_set(swigCPtr, RESID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CKeyTableEntry_m_nID_get(swigCPtr);
      RESID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RESID(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nRefCount {
    set {
      NWNXLibPINVOKE.CKeyTableEntry_m_nRefCount_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CKeyTableEntry_m_nRefCount_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nType {
    set {
      NWNXLibPINVOKE.CKeyTableEntry_m_nType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CKeyTableEntry_m_nType_get(swigCPtr);
      return ret;
    } 
  }

}

}
