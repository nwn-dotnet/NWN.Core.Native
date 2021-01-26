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

public class CNWSAreaInterTileSuccessors : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSAreaInterTileSuccessors(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSAreaInterTileSuccessors obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSAreaInterTileSuccessors() {
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

  public bool Equals(CNWSAreaInterTileSuccessors other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSAreaInterTileSuccessors other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSAreaInterTileSuccessors left, CNWSAreaInterTileSuccessors right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSAreaInterTileSuccessors left, CNWSAreaInterTileSuccessors right) {
    return !Equals(left, right);
  }

  public int nTileGridX {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridX_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridX_get(swigCPtr);
      return ret;
    } 
  }

  public int nTileGridY {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridY_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridY_get(swigCPtr);
      return ret;
    } 
  }

  public int nTileRegion {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileRegion_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileRegion_get(swigCPtr);
      return ret;
    } 
  }

  public float fTileExitX {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitX_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitX_get(swigCPtr);
      return ret;
    } 
  }

  public float fTileExitY {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitY_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitY_get(swigCPtr);
      return ret;
    } 
  }

  public float fDotProduct {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fDotProduct_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fDotProduct_get(swigCPtr);
      return ret;
    } 
  }

}

}
