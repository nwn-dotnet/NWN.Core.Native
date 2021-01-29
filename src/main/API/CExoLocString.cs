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

public unsafe class CExoLocString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoLocString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoLocString(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLocString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLocString() {
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
          NWNXLibPINVOKE.delete_CExoLocString(swigCPtr);
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

  public bool Equals(CExoLocString other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLocString other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLocString left, CExoLocString right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLocString left, CExoLocString right) {
    return !Equals(left, right);
  }

  public CExoLocStringInternal m_pExoLocStringInternal {
    set {
      NWNXLibPINVOKE.CExoLocString_m_pExoLocStringInternal_set(swigCPtr, CExoLocStringInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLocString_m_pExoLocStringInternal_get(swigCPtr);
      CExoLocStringInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocStringInternal(cPtr, false);
      return ret;
    } 
  }

  public uint m_dwStringRef {
    set {
      NWNXLibPINVOKE.CExoLocString_m_dwStringRef_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoLocString_m_dwStringRef_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLocString() : this(NWNXLibPINVOKE.new_CExoLocString__SWIG_0(), true) {
  }

  public CExoLocString(CExoLocString cLocString) : this(NWNXLibPINVOKE.new_CExoLocString__SWIG_1(CExoLocString.getCPtr(cLocString)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int _OpEquals(CExoLocString LocString) {
    int ret = NWNXLibPINVOKE.CExoLocString__OpEquals(swigCPtr, CExoLocString.getCPtr(LocString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int _OpNotEquals(CExoLocString LocString) {
    int ret = NWNXLibPINVOKE.CExoLocString__OpNotEquals(swigCPtr, CExoLocString.getCPtr(LocString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoLocString _OpAssign(CExoLocString CExoLocString) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CExoLocString__OpAssign(swigCPtr, CExoLocString.getCPtr(CExoLocString)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddString(int nID, CExoString sString, byte bGender) {
    int ret = NWNXLibPINVOKE.CExoLocString_AddString__SWIG_0(swigCPtr, nID, CExoString.getCPtr(sString), bGender);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddString(int nID, CExoString sString) {
    int ret = NWNXLibPINVOKE.CExoLocString_AddString__SWIG_1(swigCPtr, nID, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClearLocString() {
    NWNXLibPINVOKE.CExoLocString_ClearLocString(swigCPtr);
  }

  public int GetString(uint nPos, int* pID, CExoString pString, byte* pGender) {
    int ret = NWNXLibPINVOKE.CExoLocString_GetString__SWIG_0(swigCPtr, nPos, (global::System.IntPtr)pID, CExoString.getCPtr(pString), (global::System.IntPtr)pGender);
    return ret;
  }

  public int GetString(int nID, CExoString pString, byte bGender, bool boSearch) {
    int ret = NWNXLibPINVOKE.CExoLocString_GetString__SWIG_1(swigCPtr, nID, CExoString.getCPtr(pString), bGender, boSearch);
    return ret;
  }

  public int GetString(int nID, CExoString pString, byte bGender) {
    int ret = NWNXLibPINVOKE.CExoLocString_GetString__SWIG_2(swigCPtr, nID, CExoString.getCPtr(pString), bGender);
    return ret;
  }

  public int GetString(int nID, CExoString pString) {
    int ret = NWNXLibPINVOKE.CExoLocString_GetString__SWIG_3(swigCPtr, nID, CExoString.getCPtr(pString));
    return ret;
  }

  public int GetStringLoc(int nID, CExoString pString, byte bGender) {
    int ret = NWNXLibPINVOKE.CExoLocString_GetStringLoc(swigCPtr, nID, CExoString.getCPtr(pString), bGender);
    return ret;
  }

  public uint GetStringCount() {
    uint ret = NWNXLibPINVOKE.CExoLocString_GetStringCount(swigCPtr);
    return ret;
  }

  public int GetStringLength(uint nPos) {
    int ret = NWNXLibPINVOKE.CExoLocString_GetStringLength(swigCPtr, nPos);
    return ret;
  }

  public int GetStringInternal(int nID, CExoString pString) {
    int ret = NWNXLibPINVOKE.CExoLocString_GetStringInternal(swigCPtr, nID, CExoString.getCPtr(pString));
    return ret;
  }

  public void RemoveString(int nID) {
    NWNXLibPINVOKE.CExoLocString_RemoveString__SWIG_0(swigCPtr, nID);
  }

  public void RemoveString(int nID, byte bGender) {
    NWNXLibPINVOKE.CExoLocString_RemoveString__SWIG_1(swigCPtr, nID, bGender);
  }

}

}
