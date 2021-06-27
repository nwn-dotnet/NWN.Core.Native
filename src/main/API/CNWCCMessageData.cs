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

public unsafe class CNWCCMessageData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWCCMessageData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWCCMessageData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWCCMessageData() {
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
          NWNXLibPINVOKE.delete_CNWCCMessageData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWCCMessageData self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWCCMessageData FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWCCMessageData((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWCCMessageData FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWCCMessageData(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWCCMessageData other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWCCMessageData other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWCCMessageData left, CNWCCMessageData right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWCCMessageData left, CNWCCMessageData right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public byte m_nType {
    set {
      NWNXLibPINVOKE.CNWCCMessageData_m_nType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWCCMessageData_m_nType_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListInt32 m_nParamInteger {
    set {
      NWNXLibPINVOKE.CNWCCMessageData_m_nParamInteger_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWCCMessageData_m_nParamInteger_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListFloat m_nParamFloat {
    set {
      NWNXLibPINVOKE.CNWCCMessageData_m_nParamFloat_set(swigCPtr, CExoArrayListFloat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWCCMessageData_m_nParamFloat_get(swigCPtr);
      CExoArrayListFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListFloat(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCExoString m_sParamString {
    set {
      NWNXLibPINVOKE.CNWCCMessageData_m_sParamString_set(swigCPtr, CExoArrayListCExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWCCMessageData_m_sParamString_get(swigCPtr);
      CExoArrayListCExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListObjectId m_oidParamObjectID {
    set {
      NWNXLibPINVOKE.CNWCCMessageData_m_oidParamObjectID_set(swigCPtr, CExoArrayListObjectId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWCCMessageData_m_oidParamObjectID_get(swigCPtr);
      CExoArrayListObjectId ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListObjectId(cPtr, false);
      return ret;
    } 
  }

  public CNWCCMessageData() : this(NWNXLibPINVOKE.new_CNWCCMessageData(), true) {
  }

  public int GetInteger(int nStorageLocation) {
    int retVal = NWNXLibPINVOKE.CNWCCMessageData_GetInteger(swigCPtr, nStorageLocation);
    return retVal;
  }

  public void SetInteger(int nStorageLocation, int nValue) {
    NWNXLibPINVOKE.CNWCCMessageData_SetInteger(swigCPtr, nStorageLocation, nValue);
  }

  public float GetFloat(int nStorageLocation) {
    float retVal = NWNXLibPINVOKE.CNWCCMessageData_GetFloat(swigCPtr, nStorageLocation);
    return retVal;
  }

  public void SetFloat(int nStorageLocation, float fValue) {
    NWNXLibPINVOKE.CNWCCMessageData_SetFloat(swigCPtr, nStorageLocation, fValue);
  }

  public uint GetObjectID(int nStorageLocation) {
    uint retVal = NWNXLibPINVOKE.CNWCCMessageData_GetObjectID(swigCPtr, nStorageLocation);
    return retVal;
  }

  public void SetObjectID(int nStorageLocation, uint oidValue) {
    NWNXLibPINVOKE.CNWCCMessageData_SetObjectID(swigCPtr, nStorageLocation, oidValue);
  }

  public CExoString GetString(int nStorageLocation) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWCCMessageData_GetString(swigCPtr, nStorageLocation), true);
    return ret;
  }

  public void SetString(int nStorageLocation, CExoString sString) {
    NWNXLibPINVOKE.CNWCCMessageData_SetString(swigCPtr, nStorageLocation, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int SaveData(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWCCMessageData_SaveData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadData(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CNWCCMessageData_LoadData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public void CopyTo(CNWCCMessageData pDestinationData) {
    NWNXLibPINVOKE.CNWCCMessageData_CopyTo(swigCPtr, CNWCCMessageData.getCPtr(pDestinationData));
  }

  public void ClearData() {
    NWNXLibPINVOKE.CNWCCMessageData_ClearData(swigCPtr);
  }

}

}
