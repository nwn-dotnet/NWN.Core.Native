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

public unsafe class CNWSAreaGridTransTableEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSAreaGridTransTableEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSAreaGridTransTableEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSAreaGridTransTableEntry() {
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
          NWNXLibPINVOKE.delete_CNWSAreaGridTransTableEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSAreaGridTransTableEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSAreaGridTransTableEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSAreaGridTransTableEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSAreaGridTransTableEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSAreaGridTransTableEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSAreaGridTransTableEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSAreaGridTransTableEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSAreaGridTransTableEntry left, CNWSAreaGridTransTableEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSAreaGridTransTableEntry left, CNWSAreaGridTransTableEntry right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int nX {
    set {
      NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nX_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nX_get(swigCPtr);
      return ret;
    } 
  }

  public int nY {
    set {
      NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nY_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nY_get(swigCPtr);
      return ret;
    } 
  }

  public int nShortestPath {
    set {
      NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nShortestPath_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nShortestPath_get(swigCPtr);
      return ret;
    } 
  }

  public int nStepsExplored {
    set {
      NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nStepsExplored_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaGridTransTableEntry_nStepsExplored_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSAreaGridTransTableEntry() : this(NWNXLibPINVOKE.new_CNWSAreaGridTransTableEntry(), true) {
  }

}

}
