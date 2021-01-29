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

public unsafe class CEncounterListEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CEncounterListEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CEncounterListEntry(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CEncounterListEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CEncounterListEntry() {
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
          NWNXLibPINVOKE.delete_CEncounterListEntry(swigCPtr);
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

  public bool Equals(CEncounterListEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CEncounterListEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CEncounterListEntry left, CEncounterListEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CEncounterListEntry left, CEncounterListEntry right) {
    return !Equals(left, right);
  }

  public CResRef m_cCreatureResRef {
    set {
      NWNXLibPINVOKE.CEncounterListEntry_m_cCreatureResRef_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CEncounterListEntry_m_cCreatureResRef_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public float m_fCR {
    set {
      NWNXLibPINVOKE.CEncounterListEntry_m_fCR_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CEncounterListEntry_m_fCR_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fCreaturePoints {
    set {
      NWNXLibPINVOKE.CEncounterListEntry_m_fCreaturePoints_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CEncounterListEntry_m_fCreaturePoints_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAlreadyUsed {
    set {
      NWNXLibPINVOKE.CEncounterListEntry_m_bAlreadyUsed_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CEncounterListEntry_m_bAlreadyUsed_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAlreadyChecked {
    set {
      NWNXLibPINVOKE.CEncounterListEntry_m_bAlreadyChecked_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CEncounterListEntry_m_bAlreadyChecked_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bUnique {
    set {
      NWNXLibPINVOKE.CEncounterListEntry_m_bUnique_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CEncounterListEntry_m_bUnique_get(swigCPtr);
      return ret;
    } 
  }

  public CEncounterListEntry() : this(NWNXLibPINVOKE.new_CEncounterListEntry(), true) {
  }

}

}
