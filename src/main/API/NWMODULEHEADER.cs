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

public class NWMODULEHEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NWMODULEHEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NWMODULEHEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NWMODULEHEADER() {
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

  public string pModuleID {
    set {
      NWNXLibPINVOKE.NWMODULEHEADER_pModuleID_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.NWMODULEHEADER_pModuleID_get(swigCPtr);
      return ret;
    } 
  }

  public int nModuleCreatorID {
    set {
      NWNXLibPINVOKE.NWMODULEHEADER_nModuleCreatorID_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.NWMODULEHEADER_nModuleCreatorID_get(swigCPtr);
      return ret;
    } 
  }

  public uint nModuleVersion {
    set {
      NWNXLibPINVOKE.NWMODULEHEADER_nModuleVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWMODULEHEADER_nModuleVersion_get(swigCPtr);
      return ret;
    } 
  }

}

}
