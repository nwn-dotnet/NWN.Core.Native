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

public class TLK_FILE_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TLK_FILE_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TLK_FILE_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TLK_FILE_HEADER() {
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

  public uint fileType {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_fileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_fileType_get(swigCPtr);
      return ret;
    } 
  }

  public uint versionNum {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_versionNum_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_versionNum_get(swigCPtr);
      return ret;
    } 
  }

  public uint LanguageType {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_LanguageType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_LanguageType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nStrEntries {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_nStrEntries_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_nStrEntries_get(swigCPtr);
      return ret;
    } 
  }

  public uint strEntriesOffset {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_strEntriesOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_strEntriesOffset_get(swigCPtr);
      return ret;
    } 
  }

}

}