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

public unsafe class CExoLocStringInternal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoLocStringInternal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoLocStringInternal(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLocStringInternal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLocStringInternal() {
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
          NWNXLibPINVOKE.delete_CExoLocStringInternal(swigCPtr);
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

  public bool Equals(CExoLocStringInternal other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLocStringInternal other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLocStringInternal left, CExoLocStringInternal right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLocStringInternal left, CExoLocStringInternal right) {
    return !Equals(left, right);
  }

  public CExoLinkedListEXOLOCSTRING m_lstString {
    set {
      NWNXLibPINVOKE.CExoLocStringInternal_m_lstString_set(swigCPtr, CExoLinkedListEXOLOCSTRING.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLocStringInternal_m_lstString_get(swigCPtr);
      CExoLinkedListEXOLOCSTRING ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListEXOLOCSTRING(cPtr, false);
      return ret;
    } 
  }

  public uint m_nStringCount {
    set {
      NWNXLibPINVOKE.CExoLocStringInternal_m_nStringCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoLocStringInternal_m_nStringCount_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLocStringInternal() : this(NWNXLibPINVOKE.new_CExoLocStringInternal(), true) {
  }

  public int AddString(int nID, CExoString sString) {
    int ret = NWNXLibPINVOKE.CExoLocStringInternal_AddString(swigCPtr, nID, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Assign(CExoLocStringInternal pLocStringInternal) {
    int ret = NWNXLibPINVOKE.CExoLocStringInternal_Assign(swigCPtr, CExoLocStringInternal.getCPtr(pLocStringInternal));
    return ret;
  }

  public void ClearLocString() {
    NWNXLibPINVOKE.CExoLocStringInternal_ClearLocString(swigCPtr);
  }

  public int Compare(CExoLocString LocString) {
    int ret = NWNXLibPINVOKE.CExoLocStringInternal_Compare(swigCPtr, CExoLocString.getCPtr(LocString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetString(uint nPos, int* pID, CExoString pString) {
    int ret = NWNXLibPINVOKE.CExoLocStringInternal_GetString__SWIG_0(swigCPtr, nPos, (global::System.IntPtr)pID, CExoString.getCPtr(pString));
    return ret;
  }

  public int GetString(int nID, CExoString pString) {
    int ret = NWNXLibPINVOKE.CExoLocStringInternal_GetString__SWIG_1(swigCPtr, nID, CExoString.getCPtr(pString));
    return ret;
  }

  public uint GetStringCount() {
    uint ret = NWNXLibPINVOKE.CExoLocStringInternal_GetStringCount(swigCPtr);
    return ret;
  }

  public int GetStringLength(uint nPos) {
    int ret = NWNXLibPINVOKE.CExoLocStringInternal_GetStringLength(swigCPtr, nPos);
    return ret;
  }

  public void RemoveString(int nID) {
    NWNXLibPINVOKE.CExoLocStringInternal_RemoveString(swigCPtr, nID);
  }

}

}
