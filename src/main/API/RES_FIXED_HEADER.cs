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

public class RES_FIXED_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RES_FIXED_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RES_FIXED_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RES_FIXED_HEADER() {
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

  public uint nFileType {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nFileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nFileType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nFileVersion {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nFileVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nFileVersion_get(swigCPtr);
      return ret;
    } 
  }

  public uint nNumber {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nNumber_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nNumber_get(swigCPtr);
      return ret;
    } 
  }

  public uint nSize {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint nTableOffset {
    set {
      NWNXLibPINVOKE.RES_FIXED_HEADER_nTableOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.RES_FIXED_HEADER_nTableOffset_get(swigCPtr);
      return ret;
    } 
  }

}

}
