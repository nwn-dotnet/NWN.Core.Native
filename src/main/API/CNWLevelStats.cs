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

public class CNWLevelStats : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWLevelStats(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWLevelStats obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWLevelStats() {
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
          NWNXLibPINVOKE.delete_CNWLevelStats(swigCPtr);
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

  public bool Equals(CNWLevelStats other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWLevelStats other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWLevelStats left, CNWLevelStats right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWLevelStats left, CNWLevelStats right) {
    return !Equals(left, right);
  }

  public CExoArrayListUInt32 m_pAddedKnownSpellList {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_pAddedKnownSpellList_set(swigCPtr, CExoArrayListUInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWLevelStats_m_pAddedKnownSpellList_get(swigCPtr);
      CExoArrayListUInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt32 m_pRemovedKnownSpellList {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_pRemovedKnownSpellList_set(swigCPtr, CExoArrayListUInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWLevelStats_m_pRemovedKnownSpellList_get(swigCPtr);
      CExoArrayListUInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListUInt16 m_lstFeats {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_lstFeats_set(swigCPtr, CExoArrayListUInt16.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWLevelStats_m_lstFeats_get(swigCPtr);
      CExoArrayListUInt16 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt16(cPtr, false);
      return ret;
    } 
  }

  public string m_lstSkillRanks {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_lstSkillRanks_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CNWLevelStats_m_lstSkillRanks_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nSkillPointsRemaining {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_nSkillPointsRemaining_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWLevelStats_m_nSkillPointsRemaining_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAbilityGain {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_nAbilityGain_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWLevelStats_m_nAbilityGain_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nHitDie {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_nHitDie_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWLevelStats_m_nHitDie_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nClass {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_nClass_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWLevelStats_m_nClass_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bEpic {
    set {
      NWNXLibPINVOKE.CNWLevelStats_m_bEpic_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWLevelStats_m_bEpic_get(swigCPtr);
      return ret;
    } 
  }

  public CNWLevelStats() : this(NWNXLibPINVOKE.new_CNWLevelStats(), true) {
  }

  public void ClearFeats() {
    NWNXLibPINVOKE.CNWLevelStats_ClearFeats(swigCPtr);
  }

  public void AddFeat(ushort nFeat) {
    NWNXLibPINVOKE.CNWLevelStats_AddFeat(swigCPtr, nFeat);
  }

  public char GetSkillRankChange(ushort nSkill) {
    char ret = NWNXLibPINVOKE.CNWLevelStats_GetSkillRankChange(swigCPtr, nSkill);
    return ret;
  }

  public void SetSkillRankChange(ushort nSkill, char nRank) {
    NWNXLibPINVOKE.CNWLevelStats_SetSkillRankChange(swigCPtr, nSkill, nRank);
  }

}

}
