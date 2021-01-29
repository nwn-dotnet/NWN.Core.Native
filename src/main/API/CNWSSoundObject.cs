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

public unsafe class CNWSSoundObject : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CNWSSoundObject(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSSoundObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSSoundObject(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSSoundObject_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSSoundObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSSoundObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(CNWSSoundObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSSoundObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSSoundObject left, CNWSSoundObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSSoundObject left, CNWSSoundObject right) {
    return !Equals(left, right);
  }

  public int m_bIsActive {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_bIsActive_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_bIsActive_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bPositional {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_bPositional_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_bPositional_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLooping {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_bLooping_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_bLooping_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nVolume {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nVolume_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_nVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nVolumeVariation {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nVolumeVariation_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_nVolumeVariation_get(swigCPtr);
      return ret;
    } 
  }

  public int m_Time {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_Time_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_Time_get(swigCPtr);
      return ret;
    } 
  }

  public float m_nPitchVariation {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nPitchVariation_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSSoundObject_m_nPitchVariation_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nHours {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nHours_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSSoundObject_m_nHours_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPriority {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nPriority_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSSoundObject_m_nPriority_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRandomPosition {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_bRandomPosition_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_bRandomPosition_get(swigCPtr);
      return ret;
    } 
  }

  public float m_nRandomXRange {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nRandomXRange_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSSoundObject_m_nRandomXRange_get(swigCPtr);
      return ret;
    } 
  }

  public float m_nRandomYRange {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nRandomYRange_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSSoundObject_m_nRandomYRange_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCResRef m_SoundList {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_SoundList_set(swigCPtr, CExoArrayListCResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSSoundObject_m_SoundList_get(swigCPtr);
      CExoArrayListCResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCResRef(cPtr, false);
      return ret;
    } 
  }

  public uint m_nInterval {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nInterval_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSSoundObject_m_nInterval_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nIntervalVariance {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nIntervalVariance_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSSoundObject_m_nIntervalVariance_get(swigCPtr);
      return ret;
    } 
  }

  public float m_nMinDistance {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nMinDistance_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSSoundObject_m_nMinDistance_get(swigCPtr);
      return ret;
    } 
  }

  public float m_nMaxDistance {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_nMaxDistance_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSSoundObject_m_nMaxDistance_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bContinuous {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_bContinuous_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_bContinuous_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRandom {
    set {
      NWNXLibPINVOKE.CNWSSoundObject_m_bRandom_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSSoundObject_m_bRandom_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSSoundObject(uint oidId) : this(NWNXLibPINVOKE.new_CNWSSoundObject__SWIG_0(oidId), true) {
  }

  public CNWSSoundObject() : this(NWNXLibPINVOKE.new_CNWSSoundObject__SWIG_1(), true) {
  }

  public override CNWSSoundObject AsNWSSoundObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSSoundObject_AsNWSSoundObject(swigCPtr);
    CNWSSoundObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSSoundObject(cPtr, false);
    return ret;
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSSoundObject_AIUpdate(swigCPtr);
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSSoundObject_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public int Load(CResGFF pRes, CResStruct cSoundStruct) {
    int ret = NWNXLibPINVOKE.CNWSSoundObject_Load(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cSoundStruct));
    return ret;
  }

  public void Save(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSSoundObject_Save(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public void AddToArea(CNWSArea pArea, int bRunScripts) {
    NWNXLibPINVOKE.CNWSSoundObject_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), bRunScripts);
  }

  public void AddToArea(CNWSArea pArea) {
    NWNXLibPINVOKE.CNWSSoundObject_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea));
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSSoundObject_RemoveFromArea(swigCPtr);
  }

  public void PackIntoMessage(CNWSMessage pMessage) {
    NWNXLibPINVOKE.CNWSSoundObject_PackIntoMessage(swigCPtr, CNWSMessage.getCPtr(pMessage));
  }

  public void Play() {
    NWNXLibPINVOKE.CNWSSoundObject_Play(swigCPtr);
  }

  public void Stop() {
    NWNXLibPINVOKE.CNWSSoundObject_Stop(swigCPtr);
  }

  public void ChangeVolume(int nVolume) {
    NWNXLibPINVOKE.CNWSSoundObject_ChangeVolume(swigCPtr, nVolume);
  }

  public void ChangePosition(Vector vPos) {
    NWNXLibPINVOKE.CNWSSoundObject_ChangePosition(swigCPtr, Vector.getCPtr(vPos));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListObjectId GetPeopleInSoundRange() {
    CExoArrayListObjectId ret = new CExoArrayListObjectId(NWNXLibPINVOKE.CNWSSoundObject_GetPeopleInSoundRange(swigCPtr), true);
    return ret;
  }

}

}
