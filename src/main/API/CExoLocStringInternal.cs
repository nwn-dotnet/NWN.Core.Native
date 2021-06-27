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

  internal CExoLocStringInternal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
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
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CExoLocStringInternal self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLocStringInternal FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLocStringInternal((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLocStringInternal FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLocStringInternal(pointer, memoryOwn) : null;
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
/*@SWIG@*/
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
      uint retVal = NWNXLibPINVOKE.CExoLocStringInternal_m_nStringCount_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLocStringInternal() : this(NWNXLibPINVOKE.new_CExoLocStringInternal(), true) {
  }

  public int AddString(int nID, CExoString sString) {
    int retVal = NWNXLibPINVOKE.CExoLocStringInternal_AddString(swigCPtr, nID, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int Assign(CExoLocStringInternal pLocStringInternal) {
    int retVal = NWNXLibPINVOKE.CExoLocStringInternal_Assign(swigCPtr, CExoLocStringInternal.getCPtr(pLocStringInternal));
    return retVal;
  }

  public void ClearLocString() {
    NWNXLibPINVOKE.CExoLocStringInternal_ClearLocString(swigCPtr);
  }

  public int Compare(CExoLocString LocString) {
    int retVal = NWNXLibPINVOKE.CExoLocStringInternal_Compare(swigCPtr, CExoLocString.getCPtr(LocString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetString(uint nPos, int* pID, CExoString pString) {
    int retVal = NWNXLibPINVOKE.CExoLocStringInternal_GetString__SWIG_0(swigCPtr, nPos, pID, CExoString.getCPtr(pString));
    return retVal;
  }

  public int GetString(int nID, CExoString pString) {
    int retVal = NWNXLibPINVOKE.CExoLocStringInternal_GetString__SWIG_1(swigCPtr, nID, CExoString.getCPtr(pString));
    return retVal;
  }

  public uint GetStringCount() {
    uint retVal = NWNXLibPINVOKE.CExoLocStringInternal_GetStringCount(swigCPtr);
    return retVal;
  }

  public int GetStringLength(uint nPos) {
    int retVal = NWNXLibPINVOKE.CExoLocStringInternal_GetStringLength(swigCPtr, nPos);
    return retVal;
  }

  public void RemoveString(int nID) {
    NWNXLibPINVOKE.CExoLocStringInternal_RemoveString(swigCPtr, nID);
  }

}

}
