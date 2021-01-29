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

public unsafe class CNWSDialogPlayer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSDialogPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSDialogPlayer(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSDialogPlayer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSDialogPlayer() {
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
          NWNXLibPINVOKE.delete_CNWSDialogPlayer(swigCPtr);
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

  public bool Equals(CNWSDialogPlayer other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSDialogPlayer other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSDialogPlayer left, CNWSDialogPlayer right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSDialogPlayer left, CNWSDialogPlayer right) {
    return !Equals(left, right);
  }

  public uint m_playerId {
    set {
      NWNXLibPINVOKE.CNWSDialogPlayer_m_playerId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSDialogPlayer_m_playerId_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidObject {
    set {
      NWNXLibPINVOKE.CNWSDialogPlayer_m_oidObject_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSDialogPlayer_m_oidObject_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_gender {
    set {
      NWNXLibPINVOKE.CNWSDialogPlayer_m_gender_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSDialogPlayer_m_gender_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSDialogPlayer() : this(NWNXLibPINVOKE.new_CNWSDialogPlayer(), true) {
  }

}

}
