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

public class SNWItemFlags : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SNWItemFlags(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SNWItemFlags obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SNWItemFlags() {
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

  public byte m_nDropable {
    set {
      NWNXLibPINVOKE.SNWItemFlags_m_nDropable_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.SNWItemFlags_m_nDropable_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPickpocketable {
    set {
      NWNXLibPINVOKE.SNWItemFlags_m_nPickpocketable_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.SNWItemFlags_m_nPickpocketable_get(swigCPtr);
      return ret;
    } 
  }

}

}
