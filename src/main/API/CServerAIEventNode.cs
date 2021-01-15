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

public class CServerAIEventNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CServerAIEventNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerAIEventNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerAIEventNode() {
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

  public uint m_nCalendarDay {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CServerAIEventNode_m_nCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTimeOfDay {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CServerAIEventNode_m_nTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nCallerObjectId {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nCallerObjectId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CServerAIEventNode_m_nCallerObjectId_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nObjectId {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nObjectId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CServerAIEventNode_m_nObjectId_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nEventId {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nEventId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CServerAIEventNode_m_nEventId_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void m_pEventData {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_pEventData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIEventNode_m_pEventData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public int SaveNode(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CServerAIEventNode_SaveNode(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadNode(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CServerAIEventNode_LoadNode(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

}

}
