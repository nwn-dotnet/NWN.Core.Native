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

public class EXO2DAHEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EXO2DAHEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EXO2DAHEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EXO2DAHEADER() {
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

  public uint nType {
    set {
      NWNXLibPINVOKE.EXO2DAHEADER_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.EXO2DAHEADER_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nVersion {
    set {
      NWNXLibPINVOKE.EXO2DAHEADER_nVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.EXO2DAHEADER_nVersion_get(swigCPtr);
      return ret;
    } 
  }

}

}
