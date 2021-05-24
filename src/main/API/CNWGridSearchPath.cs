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

public unsafe class CNWGridSearchPath : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWGridSearchPath(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWGridSearchPath obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWGridSearchPath() {
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
          NWNXLibPINVOKE.delete_CNWGridSearchPath(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,26,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWGridSearchPath self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWGridSearchPath FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWGridSearchPath((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWGridSearchPath FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWGridSearchPath(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWGridSearchPath other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWGridSearchPath other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWGridSearchPath left, CNWGridSearchPath right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWGridSearchPath left, CNWGridSearchPath right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int nDistance {
    set {
      NWNXLibPINVOKE.CNWGridSearchPath_nDistance_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWGridSearchPath_nDistance_get(swigCPtr);
      return ret;
    } 
  }

  public int nSteps {
    set {
      NWNXLibPINVOKE.CNWGridSearchPath_nSteps_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWGridSearchPath_nSteps_get(swigCPtr);
      return ret;
    } 
  }

  public int nLength {
    set {
      NWNXLibPINVOKE.CNWGridSearchPath_nLength_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWGridSearchPath_nLength_get(swigCPtr);
      return ret;
    } 
  }

  public int nX {
    set {
      NWNXLibPINVOKE.CNWGridSearchPath_nX_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWGridSearchPath_nX_get(swigCPtr);
      return ret;
    } 
  }

  public int nY {
    set {
      NWNXLibPINVOKE.CNWGridSearchPath_nY_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWGridSearchPath_nY_get(swigCPtr);
      return ret;
    } 
  }

  public bool bTerminated {
    set {
      NWNXLibPINVOKE.CNWGridSearchPath_bTerminated_set(swigCPtr, value);
    } 
    get {
      bool ret = NWNXLibPINVOKE.CNWGridSearchPath_bTerminated_get(swigCPtr);
      return ret;
    } 
  }

  public CNWGridSearchPath() : this(NWNXLibPINVOKE.new_CNWGridSearchPath(), true) {
  }

}

}
