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

public unsafe class CERFString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CERFString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CERFString(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CERFString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CERFString() {
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
          NWNXLibPINVOKE.delete_CERFString(swigCPtr);
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

  public bool Equals(CERFString other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CERFString other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CERFString left, CERFString right) {
    return Equals(left, right);
  }

  public static bool operator !=(CERFString left, CERFString right) {
    return !Equals(left, right);
  }

  public uint m_nLanguageID {
    set {
      NWNXLibPINVOKE.CERFString_m_nLanguageID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CERFString_m_nLanguageID_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSize {
    set {
      NWNXLibPINVOKE.CERFString_m_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CERFString_m_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public string m_pText {
    set {
      NWNXLibPINVOKE.CERFString_m_pText_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CERFString_m_pText_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString GetText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CERFString_GetText(swigCPtr), true);
    return ret;
  }

  public void SetText(CExoString sString) {
    NWNXLibPINVOKE.CERFString_SetText(swigCPtr, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CERFString() : this(NWNXLibPINVOKE.new_CERFString(), true) {
  }

  public int Read() {
    int ret = NWNXLibPINVOKE.CERFString_Read(swigCPtr);
    return ret;
  }

  public int Reset() {
    int ret = NWNXLibPINVOKE.CERFString_Reset(swigCPtr);
    return ret;
  }

  public int Write(CExoFile cOutFile) {
    int ret = NWNXLibPINVOKE.CERFString_Write(swigCPtr, CExoFile.getCPtr(cOutFile));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
