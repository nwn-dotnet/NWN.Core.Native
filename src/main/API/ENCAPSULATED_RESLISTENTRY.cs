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

public class ENCAPSULATED_RESLISTENTRY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ENCAPSULATED_RESLISTENTRY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ENCAPSULATED_RESLISTENTRY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ENCAPSULATED_RESLISTENTRY() {
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

  public uint nOffsetToResource {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_RESLISTENTRY_nOffsetToResource_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.ENCAPSULATED_RESLISTENTRY_nOffsetToResource_get(swigCPtr);
      return ret;
    } 
  }

  public uint nResourceSize {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_RESLISTENTRY_nResourceSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.ENCAPSULATED_RESLISTENTRY_nResourceSize_get(swigCPtr);
      return ret;
    } 
  }

}

}
