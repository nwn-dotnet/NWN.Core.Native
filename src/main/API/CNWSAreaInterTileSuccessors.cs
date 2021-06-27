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

public unsafe class CNWSAreaInterTileSuccessors : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSAreaInterTileSuccessors(global::System.IntPtr cPtr, bool cMemoryOwn) {
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
          NWNXLibPINVOKE.delete_CNWSAreaInterTileSuccessors(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSAreaInterTileSuccessors self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSAreaInterTileSuccessors FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSAreaInterTileSuccessors((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSAreaInterTileSuccessors FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSAreaInterTileSuccessors(pointer, memoryOwn) : null;
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
/*@SWIG@*/
  public int nTileGridX {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridX_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridX_get(swigCPtr);
      return retVal;
    }

  }

  public int nTileGridY {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridY_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileGridY_get(swigCPtr);
      return retVal;
    }

  }

  public int nTileRegion {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileRegion_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_nTileRegion_get(swigCPtr);
      return retVal;
    }

  }

  public float fTileExitX {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitX_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitX_get(swigCPtr);
      return retVal;
    }

  }

  public float fTileExitY {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitY_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fTileExitY_get(swigCPtr);
      return retVal;
    }

  }

  public float fDotProduct {
    set {
      NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fDotProduct_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWSAreaInterTileSuccessors_fDotProduct_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSAreaInterTileSuccessors() : this(NWNXLibPINVOKE.new_CNWSAreaInterTileSuccessors(), true) {
  }

}

}
