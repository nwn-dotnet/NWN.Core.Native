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

public class KEYFILE_RESFILENAME : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal KEYFILE_RESFILENAME(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KEYFILE_RESFILENAME obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KEYFILE_RESFILENAME() {
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

  public uint nFileSize {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint nFileNameOffset {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameOffset_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nFileNameSize {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameSize_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.KEYFILE_RESFILENAME_nFileNameSize_get(swigCPtr);
      return ret;
    } 
  }

  public ushort bDrives {
    set {
      NWNXLibPINVOKE.KEYFILE_RESFILENAME_bDrives_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.KEYFILE_RESFILENAME_bDrives_get(swigCPtr);
      return ret;
    } 
  }

}

}