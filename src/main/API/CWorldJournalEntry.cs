//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class CWorldJournalEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CWorldJournalEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CWorldJournalEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CWorldJournalEntry() {
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

  public CExoString szText {
    set {
      NWNXLibPINVOKE.CWorldJournalEntry_szText_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CWorldJournalEntry_szText_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString szName {
    set {
      NWNXLibPINVOKE.CWorldJournalEntry_szName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CWorldJournalEntry_szName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint nCalendarDay {
    set {
      NWNXLibPINVOKE.CWorldJournalEntry_nCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldJournalEntry_nCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint nTimeOfDay {
    set {
      NWNXLibPINVOKE.CWorldJournalEntry_nTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldJournalEntry_nTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint nName {
    set {
      NWNXLibPINVOKE.CWorldJournalEntry_nName_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldJournalEntry_nName_get(swigCPtr);
      return ret;
    } 
  }

  public uint nID {
    set {
      NWNXLibPINVOKE.CWorldJournalEntry_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CWorldJournalEntry_nID_get(swigCPtr);
      return ret;
    } 
  }

  public int bIdIsStrref {
    set {
      NWNXLibPINVOKE.CWorldJournalEntry_bIdIsStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CWorldJournalEntry_bIdIsStrref_get(swigCPtr);
      return ret;
    } 
  }

}

}