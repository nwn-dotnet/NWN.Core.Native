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

public class CServerAIList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CServerAIList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerAIList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerAIList() {
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
          NWNXLibPINVOKE.delete_CServerAIList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_CExoArrayListT_unsigned_int_t m_aoGameObjects {
    set {
      NWNXLibPINVOKE.CServerAIList_m_aoGameObjects_set(swigCPtr, SWIGTYPE_p_CExoArrayListT_unsigned_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIList_m_aoGameObjects_get(swigCPtr);
      SWIGTYPE_p_CExoArrayListT_unsigned_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoArrayListT_unsigned_int_t(cPtr, false);
      return ret;
    } 
  }

  public int m_nPosition {
    set {
      NWNXLibPINVOKE.CServerAIList_m_nPosition_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIList_m_nPosition_get(swigCPtr);
      return ret;
    } 
  }

  public CServerAIList() : this(NWNXLibPINVOKE.new_CServerAIList(), true) {
  }

  public int AddObject(uint oidObjectToAdd) {
    int ret = NWNXLibPINVOKE.CServerAIList_AddObject(swigCPtr, oidObjectToAdd);
    return ret;
  }

  public int RemoveObject(uint oidObjectToRemove) {
    int ret = NWNXLibPINVOKE.CServerAIList_RemoveObject(swigCPtr, oidObjectToRemove);
    return ret;
  }

  public CNWSObject GetNextObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIList_GetNextObject(swigCPtr);
    CNWSObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObject(cPtr, false);
    return ret;
  }

}

}