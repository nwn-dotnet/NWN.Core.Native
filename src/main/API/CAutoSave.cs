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

public class CAutoSave : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CAutoSave(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CAutoSave obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CAutoSave() {
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

  public int bAtIntervals {
    set {
      NWNXLibPINVOKE.CAutoSave_bAtIntervals_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAutoSave_bAtIntervals_get(swigCPtr);
      return ret;
    } 
  }

  public int bAtSavePoints {
    set {
      NWNXLibPINVOKE.CAutoSave_bAtSavePoints_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAutoSave_bAtSavePoints_get(swigCPtr);
      return ret;
    } 
  }

  public int bOnPlayerChange {
    set {
      NWNXLibPINVOKE.CAutoSave_bOnPlayerChange_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAutoSave_bOnPlayerChange_get(swigCPtr);
      return ret;
    } 
  }

  public int nInterval {
    set {
      NWNXLibPINVOKE.CAutoSave_nInterval_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CAutoSave_nInterval_get(swigCPtr);
      return ret;
    } 
  }

}

}
