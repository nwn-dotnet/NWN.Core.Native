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

public unsafe class CFeatUseListEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CFeatUseListEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CFeatUseListEntry(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFeatUseListEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CFeatUseListEntry() {
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
          NWNXLibPINVOKE.delete_CFeatUseListEntry(swigCPtr);
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

  public bool Equals(CFeatUseListEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CFeatUseListEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CFeatUseListEntry left, CFeatUseListEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CFeatUseListEntry left, CFeatUseListEntry right) {
    return !Equals(left, right);
  }

  public ushort m_nFeat {
    set {
      NWNXLibPINVOKE.CFeatUseListEntry_m_nFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFeatUseListEntry_m_nFeat_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nUsedToday {
    set {
      NWNXLibPINVOKE.CFeatUseListEntry_m_nUsedToday_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CFeatUseListEntry_m_nUsedToday_get(swigCPtr);
      return ret;
    } 
  }

  public CFeatUseListEntry() : this(NWNXLibPINVOKE.new_CFeatUseListEntry(), true) {
  }

}

}
