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

public class CObjectTableManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CObjectTableManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CObjectTableManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CObjectTableManager() {
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
          NWNXLibPINVOKE.delete_CObjectTableManager(swigCPtr);
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

  public bool Equals(CObjectTableManager other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CObjectTableManager other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CObjectTableManager left, CObjectTableManager right) {
    return Equals(left, right);
  }

  public static bool operator !=(CObjectTableManager left, CObjectTableManager right) {
    return !Equals(left, right);
  }

  public SWIGTYPE_p_p_CObjectLookupTable m_pObjectTableArray {
    set {
      NWNXLibPINVOKE.CObjectTableManager_m_pObjectTableArray_set(swigCPtr, SWIGTYPE_p_p_CObjectLookupTable.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CObjectTableManager_m_pObjectTableArray_get(swigCPtr);
      SWIGTYPE_p_p_CObjectLookupTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CObjectLookupTable(cPtr, false);
      return ret;
    } 
  }

  public uint m_dwMaxPlayerID {
    set {
      NWNXLibPINVOKE.CObjectTableManager_m_dwMaxPlayerID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CObjectTableManager_m_dwMaxPlayerID_get(swigCPtr);
      return ret;
    } 
  }

  public CObjectTableManager() : this(NWNXLibPINVOKE.new_CObjectTableManager(), true) {
  }

  public int AddID(uint oidID, SWIGTYPE_p_unsigned_int dwSlot, uint dwPlayerID) {
    int ret = NWNXLibPINVOKE.CObjectTableManager_AddID__SWIG_0(swigCPtr, oidID, SWIGTYPE_p_unsigned_int.getCPtr(dwSlot), dwPlayerID);
    return ret;
  }

  public int AddID(uint oidID, SWIGTYPE_p_unsigned_int dwSlot) {
    int ret = NWNXLibPINVOKE.CObjectTableManager_AddID__SWIG_1(swigCPtr, oidID, SWIGTYPE_p_unsigned_int.getCPtr(dwSlot));
    return ret;
  }

  public uint GetIDFromIndex(uint dwIndex, uint dwPlayerID) {
    uint ret = NWNXLibPINVOKE.CObjectTableManager_GetIDFromIndex__SWIG_0(swigCPtr, dwIndex, dwPlayerID);
    return ret;
  }

  public uint GetIDFromIndex(uint dwIndex) {
    uint ret = NWNXLibPINVOKE.CObjectTableManager_GetIDFromIndex__SWIG_1(swigCPtr, dwIndex);
    return ret;
  }

  public uint GetIndexFromID(uint oidID, uint dwPlayerID) {
    uint ret = NWNXLibPINVOKE.CObjectTableManager_GetIndexFromID__SWIG_0(swigCPtr, oidID, dwPlayerID);
    return ret;
  }

  public uint GetIndexFromID(uint oidID) {
    uint ret = NWNXLibPINVOKE.CObjectTableManager_GetIndexFromID__SWIG_1(swigCPtr, oidID);
    return ret;
  }

  public int Touch(uint dwIndex, uint dwPlayerID) {
    int ret = NWNXLibPINVOKE.CObjectTableManager_Touch__SWIG_0(swigCPtr, dwIndex, dwPlayerID);
    return ret;
  }

  public int Touch(uint dwIndex) {
    int ret = NWNXLibPINVOKE.CObjectTableManager_Touch__SWIG_1(swigCPtr, dwIndex);
    return ret;
  }

  public int RemovePlayer(uint dwPlayerID) {
    int ret = NWNXLibPINVOKE.CObjectTableManager_RemovePlayer__SWIG_0(swigCPtr, dwPlayerID);
    return ret;
  }

  public int RemovePlayer() {
    int ret = NWNXLibPINVOKE.CObjectTableManager_RemovePlayer__SWIG_1(swigCPtr);
    return ret;
  }

  public void ClearAll() {
    NWNXLibPINVOKE.CObjectTableManager_ClearAll(swigCPtr);
  }

  public int CreateNewPlayer(uint dwPlayerID) {
    int ret = NWNXLibPINVOKE.CObjectTableManager_CreateNewPlayer__SWIG_0(swigCPtr, dwPlayerID);
    return ret;
  }

  public int CreateNewPlayer() {
    int ret = NWNXLibPINVOKE.CObjectTableManager_CreateNewPlayer__SWIG_1(swigCPtr);
    return ret;
  }

}

}
