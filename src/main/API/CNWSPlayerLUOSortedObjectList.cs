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

public class CNWSPlayerLUOSortedObjectList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerLUOSortedObjectList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerLUOSortedObjectList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerLUOSortedObjectList() {
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

  public uint oidObject {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_oidObject_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_oidObject_get(swigCPtr);
      return ret;
    } 
  }

  public float fDistanceToPlayer {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_fDistanceToPlayer_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_fDistanceToPlayer_get(swigCPtr);
      return ret;
    } 
  }

  public uint nCategory {
    set {
      NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_nCategory_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerLUOSortedObjectList_nCategory_get(swigCPtr);
      return ret;
    } 
  }

}

}
