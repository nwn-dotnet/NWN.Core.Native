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

public unsafe class BIFFFILE_VARRESENTRY_V1 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public BIFFFILE_VARRESENTRY_V1(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public BIFFFILE_VARRESENTRY_V1(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BIFFFILE_VARRESENTRY_V1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BIFFFILE_VARRESENTRY_V1() {
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
          NWNXLibPINVOKE.delete_BIFFFILE_VARRESENTRY_V1(swigCPtr);
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

  public bool Equals(BIFFFILE_VARRESENTRY_V1 other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is BIFFFILE_VARRESENTRY_V1 other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(BIFFFILE_VARRESENTRY_V1 left, BIFFFILE_VARRESENTRY_V1 right) {
    return Equals(left, right);
  }

  public static bool operator !=(BIFFFILE_VARRESENTRY_V1 left, BIFFFILE_VARRESENTRY_V1 right) {
    return !Equals(left, right);
  }

  public uint nID {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nID_get(swigCPtr);
      return ret;
    } 
  }

  public uint nOffset {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint nSize {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint nType {
    set {
      NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.BIFFFILE_VARRESENTRY_V1_nType_get(swigCPtr);
      return ret;
    } 
  }

  public BIFFFILE_VARRESENTRY_V1() : this(NWNXLibPINVOKE.new_BIFFFILE_VARRESENTRY_V1(), true) {
  }

}

}
