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

public unsafe class CScriptEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CScriptEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CScriptEvent(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptEvent() {
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
          NWNXLibPINVOKE.delete_CScriptEvent(swigCPtr);
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

  public bool Equals(CScriptEvent other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptEvent other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptEvent left, CScriptEvent right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptEvent left, CScriptEvent right) {
    return !Equals(left, right);
  }

  public ushort m_nType {
    set {
      NWNXLibPINVOKE.CScriptEvent_m_nType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CScriptEvent_m_nType_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_nParamInteger {
    set {
      NWNXLibPINVOKE.CScriptEvent_m_nParamInteger_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptEvent_m_nParamInteger_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListFloat m_fParamFloat {
    set {
      NWNXLibPINVOKE.CScriptEvent_m_fParamFloat_set(swigCPtr, CExoArrayListFloat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptEvent_m_fParamFloat_get(swigCPtr);
      CExoArrayListFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListFloat(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCExoString m_sParamString {
    set {
      NWNXLibPINVOKE.CScriptEvent_m_sParamString_set(swigCPtr, CExoArrayListCExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptEvent_m_sParamString_get(swigCPtr);
      CExoArrayListCExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListObjectId m_oidParamObjectID {
    set {
      NWNXLibPINVOKE.CScriptEvent_m_oidParamObjectID_set(swigCPtr, CExoArrayListObjectId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptEvent_m_oidParamObjectID_get(swigCPtr);
      CExoArrayListObjectId ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListObjectId(cPtr, false);
      return ret;
    } 
  }

  public CScriptEvent() : this(NWNXLibPINVOKE.new_CScriptEvent(), true) {
  }

  public int GetInteger(int nStorageLocation) {
    int ret = NWNXLibPINVOKE.CScriptEvent_GetInteger(swigCPtr, nStorageLocation);
    return ret;
  }

  public void SetInteger(int nStorageLocation, int nValue) {
    NWNXLibPINVOKE.CScriptEvent_SetInteger(swigCPtr, nStorageLocation, nValue);
  }

  public float GetFloat(int nStorageLocation) {
    float ret = NWNXLibPINVOKE.CScriptEvent_GetFloat(swigCPtr, nStorageLocation);
    return ret;
  }

  public void SetFloat(int nStorageLocation, float fValue) {
    NWNXLibPINVOKE.CScriptEvent_SetFloat(swigCPtr, nStorageLocation, fValue);
  }

  public uint GetObjectID(int nStorageLocation) {
    uint ret = NWNXLibPINVOKE.CScriptEvent_GetObjectID(swigCPtr, nStorageLocation);
    return ret;
  }

  public void SetObjectID(int nStorageLocation, uint oidValue) {
    NWNXLibPINVOKE.CScriptEvent_SetObjectID(swigCPtr, nStorageLocation, oidValue);
  }

  public CExoString GetString(int nStorageLocation) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CScriptEvent_GetString(swigCPtr, nStorageLocation), true);
    return ret;
  }

  public void SetString(int nStorageLocation, CExoString sString) {
    NWNXLibPINVOKE.CScriptEvent_SetString(swigCPtr, nStorageLocation, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int _OpEquals(CScriptEvent scriptEvent) {
    int ret = NWNXLibPINVOKE.CScriptEvent__OpEquals(swigCPtr, CScriptEvent.getCPtr(scriptEvent));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int _OpNotEquals(CScriptEvent scriptEvent) {
    int ret = NWNXLibPINVOKE.CScriptEvent__OpNotEquals(swigCPtr, CScriptEvent.getCPtr(scriptEvent));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void CopyScriptEvent(CScriptEvent pScriptEvent) {
    NWNXLibPINVOKE.CScriptEvent_CopyScriptEvent(swigCPtr, CScriptEvent.getCPtr(pScriptEvent));
  }

  public int SaveEvent(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CScriptEvent_SaveEvent(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadEvent(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CScriptEvent_LoadEvent(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

}

}
