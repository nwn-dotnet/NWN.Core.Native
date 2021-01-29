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

public unsafe class CNWSEncounter : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CNWSEncounter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSEncounter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSEncounter(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSEncounter_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSEncounter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSEncounter(swigCPtr);
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

  public bool Equals(CNWSEncounter other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSEncounter other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSEncounter left, CNWSEncounter right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSEncounter left, CNWSEncounter right) {
    return !Equals(left, right);
  }

  public ushort m_nActivateObjectArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nActivateObjectArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSEncounter_m_nActivateObjectArrayIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nFactionId {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nFactionId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nFactionId_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLocString m_sLocalizedName {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_sLocalizedName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSEncounter_m_sLocalizedName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public int m_bActive {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_bActive_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_bActive_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bReset {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_bReset_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_bReset_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nResetTime {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nResetTime_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nResetTime_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSpawnMode {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nSpawnMode_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nSpawnMode_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDifficulty {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nDifficulty_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nDifficulty_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDifficultyIndex {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nDifficultyIndex_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nDifficultyIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nMinNumSpawnedCreatures {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nMinNumSpawnedCreatures_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nMinNumSpawnedCreatures_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nMaxSpawnedCreatures {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nMaxSpawnedCreatures_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nMaxSpawnedCreatures_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNumSpawnedCreatures {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nNumSpawnedCreatures_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nNumSpawnedCreatures_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nLastHeartbeatScriptCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSEncounter_m_nLastHeartbeatScriptCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nLastHeartbeatScriptTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSEncounter_m_nLastHeartbeatScriptTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastCreatureKilledCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nLastCreatureKilledCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSEncounter_m_nLastCreatureKilledCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastCreatureKilledTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nLastCreatureKilledTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSEncounter_m_nLastCreatureKilledTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bEncounterStarted {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_bEncounterStarted_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_bEncounterStarted_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bEncounterExhausted {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_bEncounterExhausted_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_bEncounterExhausted_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAreaListArraySize {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nAreaListArraySize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nAreaListArraySize_get(swigCPtr);
      return ret;
    } 
  }

  public uint* m_pEnemiesInActivateArea {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_pEnemiesInActivateArea_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWSEncounter_m_pEnemiesInActivateArea_get(swigCPtr); 
        return (uint*)retVal; 
    }

  }

  public int m_nNumEnemiesInActivateArea {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nNumEnemiesInActivateArea_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nNumEnemiesInActivateArea_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bNewEntry {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_bNewEntry_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_bNewEntry_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_pvActivateVertices {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_pvActivateVertices_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSEncounter_m_pvActivateVertices_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int m_nNumActivateVertices {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nNumActivateVertices_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nNumActivateVertices_get(swigCPtr);
      return ret;
    } 
  }

  public int* m_pnOutlineVertices {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_pnOutlineVertices_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWSEncounter_m_pnOutlineVertices_get(swigCPtr); 
        return (int*)retVal; 
    }

  }

  public int m_nNumOutlineVertices {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nNumOutlineVertices_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nNumOutlineVertices_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fMinActivateX {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fMinActivateX_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fMinActivateX_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fMaxActivateX {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fMaxActivateX_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fMaxActivateX_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fMinActivateY {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fMinActivateY_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fMinActivateY_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fMaxActivateY {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fMaxActivateY_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fMaxActivateY_get(swigCPtr);
      return ret;
    } 
  }

  public CEncounterListEntry m_pEncounterList {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_pEncounterList_set(swigCPtr, CEncounterListEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSEncounter_m_pEncounterList_get(swigCPtr);
      CEncounterListEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CEncounterListEntry(cPtr, false);
      return ret;
    } 
  }

  public int m_nNumEncounterListEntries {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nNumEncounterListEntries_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nNumEncounterListEntries_get(swigCPtr);
      return ret;
    } 
  }

  public CEncounterSpawnPoint m_pSpawnPointList {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_pSpawnPointList_set(swigCPtr, CEncounterSpawnPoint.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSEncounter_m_pSpawnPointList_get(swigCPtr);
      CEncounterSpawnPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new CEncounterSpawnPoint(cPtr, false);
      return ret;
    } 
  }

  public int m_nNumSpawnPoints {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nNumSpawnPoints_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nNumSpawnPoints_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nEncounterLevel {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nEncounterLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nEncounterLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nRespawnsMax {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nRespawnsMax_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nRespawnsMax_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nRespawnsCurrent {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nRespawnsCurrent_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nRespawnsCurrent_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fCreaturePoints {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fCreaturePoints_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fCreaturePoints_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fSmallestCreature {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fSmallestCreature_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fSmallestCreature_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fEnemyRadiusPoints {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fEnemyRadiusPoints_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fEnemyRadiusPoints_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fSpawnPool {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fSpawnPool_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fSpawnPool_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fSpawnPoolActive {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_fSpawnPoolActive_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSEncounter_m_fSpawnPoolActive_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastEntered {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_oidLastEntered_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSEncounter_m_oidLastEntered_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastLeft {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_oidLastLeft_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSEncounter_m_oidLastLeft_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sScripts {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_sScripts_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSEncounter_m_sScripts_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListFloat m_pFractionalCRThresholds {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_pFractionalCRThresholds_set(swigCPtr, CExoArrayListFloat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSEncounter_m_pFractionalCRThresholds_get(swigCPtr);
      CExoArrayListFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListFloat(cPtr, false);
      return ret;
    } 
  }

  public int m_nCustomScriptEventId {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_nCustomScriptEventId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_nCustomScriptEventId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bPlayerTriggeredOnly {
    set {
      NWNXLibPINVOKE.CNWSEncounter_m_bPlayerTriggeredOnly_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSEncounter_m_bPlayerTriggeredOnly_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSEncounter(uint oidId) : this(NWNXLibPINVOKE.new_CNWSEncounter__SWIG_0(oidId), true) {
  }

  public CNWSEncounter() : this(NWNXLibPINVOKE.new_CNWSEncounter__SWIG_1(), true) {
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSEncounter_AIUpdate(swigCPtr);
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSEncounter_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSEncounter_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSEncounter_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSEncounter_RemoveFromArea(swigCPtr);
  }

  public int GetInActivateArea(Vector vPosition) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_GetInActivateArea(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetInActivateAreaList(uint oidObject) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_GetInActivateAreaList(swigCPtr, oidObject);
    return ret;
  }

  public void SetActive(int bActive) {
    NWNXLibPINVOKE.CNWSEncounter_SetActive(swigCPtr, bActive);
  }

  public void SetDifficulty(int nDifficulty) {
    NWNXLibPINVOKE.CNWSEncounter_SetDifficulty(swigCPtr, nDifficulty);
  }

  public void RemoveFromActiveCreatureCount(float fCreatureCRU, int nRemovalReason) {
    NWNXLibPINVOKE.CNWSEncounter_RemoveFromActiveCreatureCount(swigCPtr, fCreatureCRU, nRemovalReason);
  }

  public int LoadEncounter(CResGFF pRes, CResStruct cResStruct) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_LoadEncounter(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cResStruct));
    return ret;
  }

  public int ReadEncounterFromGff(CResGFF pRes, CResStruct pGffStructWithEncounterData, int bOverrideGeometry, Vector pOverridePosition) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_ReadEncounterFromGff__SWIG_0(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pGffStructWithEncounterData), bOverrideGeometry, Vector.getCPtr(pOverridePosition));
    return ret;
  }

  public int ReadEncounterFromGff(CResGFF pRes, CResStruct pGffStructWithEncounterData, int bOverrideGeometry) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_ReadEncounterFromGff__SWIG_1(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pGffStructWithEncounterData), bOverrideGeometry);
    return ret;
  }

  public int ReadEncounterFromGff(CResGFF pRes, CResStruct pGffStructWithEncounterData) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_ReadEncounterFromGff__SWIG_2(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pGffStructWithEncounterData));
    return ret;
  }

  public void ReadEncounterScriptsFromGff(CResGFF pRes, CResStruct pGffStructWithEncounterData) {
    NWNXLibPINVOKE.CNWSEncounter_ReadEncounterScriptsFromGff(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pGffStructWithEncounterData));
  }

  public void LoadFromTemplate(CResRef cResRef, int bOverrideGeometry, Vector pOverridePosition) {
    NWNXLibPINVOKE.CNWSEncounter_LoadFromTemplate__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), bOverrideGeometry, Vector.getCPtr(pOverridePosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadFromTemplate(CResRef cResRef, int bOverrideGeometry) {
    NWNXLibPINVOKE.CNWSEncounter_LoadFromTemplate__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef), bOverrideGeometry);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadFromTemplate(CResRef cResRef) {
    NWNXLibPINVOKE.CNWSEncounter_LoadFromTemplate__SWIG_2(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int SaveEncounter(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_SaveEncounter(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public void SpawnIfAppropriate(uint oidEntered, float fFakeEnemyRadiusLevels) {
    NWNXLibPINVOKE.CNWSEncounter_SpawnIfAppropriate__SWIG_0(swigCPtr, oidEntered, fFakeEnemyRadiusLevels);
  }

  public void SpawnIfAppropriate(uint oidEntered) {
    NWNXLibPINVOKE.CNWSEncounter_SpawnIfAppropriate__SWIG_1(swigCPtr, oidEntered);
  }

  public void SpawnIfAppropriate() {
    NWNXLibPINVOKE.CNWSEncounter_SpawnIfAppropriate__SWIG_2(swigCPtr);
  }

  public int LineSegmentIntersectActivateArea(Vector vStartLine, Vector vEndLine) {
    int ret = NWNXLibPINVOKE.CNWSEncounter_LineSegmentIntersectActivateArea(swigCPtr, Vector.getCPtr(vStartLine), Vector.getCPtr(vEndLine));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddToActivateAreaList(uint oidObject) {
    NWNXLibPINVOKE.CNWSEncounter_AddToActivateAreaList(swigCPtr, oidObject);
  }

  public void RemoveFromActivateAreaList(uint oidObject) {
    NWNXLibPINVOKE.CNWSEncounter_RemoveFromActivateAreaList(swigCPtr, oidObject);
  }

  public void UpdateActivateAreaList(uint oidEntered) {
    NWNXLibPINVOKE.CNWSEncounter_UpdateActivateAreaList(swigCPtr, oidEntered);
  }

  public void CalculateSpawnPool(float fFakeEnemyRadiusLevels) {
    NWNXLibPINVOKE.CNWSEncounter_CalculateSpawnPool__SWIG_0(swigCPtr, fFakeEnemyRadiusLevels);
  }

  public void CalculateSpawnPool() {
    NWNXLibPINVOKE.CNWSEncounter_CalculateSpawnPool__SWIG_1(swigCPtr);
  }

  public void SpawnEncounterCreatures() {
    NWNXLibPINVOKE.CNWSEncounter_SpawnEncounterCreatures(swigCPtr);
  }

  public void MakeSpawnList(CEncounterListEntry pSpawnList, int* nNumCreatures) {
    NWNXLibPINVOKE.CNWSEncounter_MakeSpawnList(swigCPtr, CEncounterListEntry.getCPtr(pSpawnList), (global::System.IntPtr)nNumCreatures);
  }

  public void AddCreaturesToSpawnList(CEncounterListEntry pCreatureList, int* nNumCreatures, int nCRUSplitIndex, CEncounterListEntry cCreature) {
    NWNXLibPINVOKE.CNWSEncounter_AddCreaturesToSpawnList(swigCPtr, CEncounterListEntry.getCPtr(pCreatureList), (global::System.IntPtr)nNumCreatures, nCRUSplitIndex, CEncounterListEntry.getCPtr(cCreature));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public float CalculatePointsFromCR(float fCR) {
    float ret = NWNXLibPINVOKE.CNWSEncounter_CalculatePointsFromCR(swigCPtr, fCR);
    return ret;
  }

  public void PadOutCreatureCount(CEncounterListEntry pCreatureList, int* nNumCreatures) {
    NWNXLibPINVOKE.CNWSEncounter_PadOutCreatureCount(swigCPtr, CEncounterListEntry.getCPtr(pCreatureList), (global::System.IntPtr)nNumCreatures);
  }

  public void TallyEnemyRadiusPoints() {
    NWNXLibPINVOKE.CNWSEncounter_TallyEnemyRadiusPoints(swigCPtr);
  }

  public void LoadFractionalCRData() {
    NWNXLibPINVOKE.CNWSEncounter_LoadFractionalCRData(swigCPtr);
  }

}

}
