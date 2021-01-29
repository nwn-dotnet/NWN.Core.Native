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

public unsafe class CNWSkill : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSkill(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSkill(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSkill obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSkill() {
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
          NWNXLibPINVOKE.delete_CNWSkill(swigCPtr);
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

  public bool Equals(CNWSkill other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSkill other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSkill left, CNWSkill right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSkill left, CNWSkill right) {
    return !Equals(left, right);
  }

  public int m_nNameStrref {
    set {
      NWNXLibPINVOKE.CNWSkill_m_nNameStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_nNameStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDescriptionStrref {
    set {
      NWNXLibPINVOKE.CNWSkill_m_nDescriptionStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_nDescriptionStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTalentCategory {
    set {
      NWNXLibPINVOKE.CNWSkill_m_nTalentCategory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_nTalentCategory_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTalentMaxCR {
    set {
      NWNXLibPINVOKE.CNWSkill_m_nTalentMaxCR_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_nTalentMaxCR_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sIconName {
    set {
      NWNXLibPINVOKE.CNWSkill_m_sIconName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSkill_m_sIconName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nKeyAbility {
    set {
      NWNXLibPINVOKE.CNWSkill_m_nKeyAbility_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_nKeyAbility_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHostileSkill {
    set {
      NWNXLibPINVOKE.CNWSkill_m_bHostileSkill_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_bHostileSkill_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bUntrained {
    set {
      NWNXLibPINVOKE.CNWSkill_m_bUntrained_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_bUntrained_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bArmorCheckPenalty {
    set {
      NWNXLibPINVOKE.CNWSkill_m_bArmorCheckPenalty_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_bArmorCheckPenalty_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAllClassesCanUse {
    set {
      NWNXLibPINVOKE.CNWSkill_m_bAllClassesCanUse_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSkill_m_bAllClassesCanUse_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSkill() : this(NWNXLibPINVOKE.new_CNWSkill(), true) {
  }

  public CExoString GetNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWSkill_GetNameText(swigCPtr), true);
    return ret;
  }

  public CExoString GetDescriptionText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWSkill_GetDescriptionText(swigCPtr), true);
    return ret;
  }

}

}
