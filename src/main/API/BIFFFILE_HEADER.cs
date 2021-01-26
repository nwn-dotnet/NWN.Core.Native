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

public class BIFFFILE_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public BIFFFILE_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BIFFFILE_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BIFFFILE_HEADER() {
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

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(BIFFFILE_HEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is BIFFFILE_HEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(BIFFFILE_HEADER left, BIFFFILE_HEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(BIFFFILE_HEADER left, BIFFFILE_HEADER right) {
    return !Equals(left, right);
  }

  public uint nFileType {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nFileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_HEADER_nFileType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nFileVersion {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nFileVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_HEADER_nFileVersion_get(swigCPtr);
      return ret;
    } 
  }

  public uint nNumVariableResources {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nNumVariableResources_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_HEADER_nNumVariableResources_get(swigCPtr);
      return ret;
    } 
  }

  public uint nNumFixedResources {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nNumFixedResources_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_HEADER_nNumFixedResources_get(swigCPtr);
      return ret;
    } 
  }

  public uint nTableOffset {
    set {
      NWNXLibPINVOKE.BIFFFILE_HEADER_nTableOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_HEADER_nTableOffset_get(swigCPtr);
      return ret;
    } 
  }

}

}
