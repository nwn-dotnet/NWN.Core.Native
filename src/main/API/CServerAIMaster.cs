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

public class CServerAIMaster : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CServerAIMaster(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerAIMaster obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerAIMaster() {
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
          NWNXLibPINVOKE.delete_CServerAIMaster(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CServerExoAppInternal m_pExoAppInternal {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pExoAppInternal_set(swigCPtr, CServerExoAppInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pExoAppInternal_get(swigCPtr);
      CServerExoAppInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerExoAppInternal(cPtr, false);
      return ret;
    } 
  }

  public CServerAIList m_apGameAIList {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_apGameAIList_set(swigCPtr, CServerAIList.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_apGameAIList_get(swigCPtr);
      CServerAIList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerAIList(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCServerAIEventNode m_lEventQueue {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_lEventQueue_set(swigCPtr, CExoLinkedListCServerAIEventNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_lEventQueue_get(swigCPtr);
      CExoLinkedListCServerAIEventNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCServerAIEventNode(cPtr, false);
      return ret;
    } 
  }

  public CGameEffectApplierRemover m_pGameEffectApplierRemover {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pGameEffectApplierRemover_set(swigCPtr, CGameEffectApplierRemover.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pGameEffectApplierRemover_get(swigCPtr);
      CGameEffectApplierRemover ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameEffectApplierRemover(cPtr, false);
      return ret;
    } 
  }

  public CItemPropertyApplierRemover m_pItemPropertyApplierRemover {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pItemPropertyApplierRemover_set(swigCPtr, CItemPropertyApplierRemover.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pItemPropertyApplierRemover_get(swigCPtr);
      CItemPropertyApplierRemover ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemPropertyApplierRemover(cPtr, false);
      return ret;
    } 
  }

  public int m_nScriptsRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRun_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nScriptsRunSize {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRunSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_nScriptsRunSize_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_psScriptsRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_psScriptsRun_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_psScriptsRun_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bPlotPathRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bPlotPathRun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_bPlotPathRun_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bGridPathRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bGridPathRun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_bGridPathRun_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bUpdateVisibleListRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bUpdateVisibleListRun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_bUpdateVisibleListRun_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bBroadcastAOORun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bBroadcastAOORun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_bBroadcastAOORun_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bTrapCheckRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_bTrapCheckRun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_bTrapCheckRun_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nLastActionRun {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_nLastActionRun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerAIMaster_m_nLastActionRun_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pAttackRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pAttackRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pAttackRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pTheftRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pTheftRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pTheftRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pKillRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pKillRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pKillRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pHelpRepAdj {
    set {
      NWNXLibPINVOKE.CServerAIMaster_m_pHelpRepAdj_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_m_pHelpRepAdj_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CServerAIMaster() : this(NWNXLibPINVOKE.new_CServerAIMaster(), true) {
  }

  public void SetExoAppInternal(CServerExoAppInternal pExoAppInternal) {
    NWNXLibPINVOKE.CServerAIMaster_SetExoAppInternal(swigCPtr, CServerExoAppInternal.getCPtr(pExoAppInternal));
  }

  public void UpdateState() {
    NWNXLibPINVOKE.CServerAIMaster_UpdateState(swigCPtr);
  }

  public void ClearEventQueue() {
    NWNXLibPINVOKE.CServerAIMaster_ClearEventQueue(swigCPtr);
  }

  public int AddObject(CNWSObject pObject, int nAILevel) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_AddObject(swigCPtr, CNWSObject.getCPtr(pObject), nAILevel);
    return ret;
  }

  public int RemoveObject(CNWSObject pObject) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_RemoveObject(swigCPtr, CNWSObject.getCPtr(pObject));
    return ret;
  }

  public int SetAILevel(CNWSObject pObject, int nAILevel) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_SetAILevel(swigCPtr, CNWSObject.getCPtr(pObject), nAILevel);
    return ret;
  }

  public int AddEventDeltaTime(uint nDaysFromNow, uint nTimeFromNow, uint nCallerObjectId, uint nObjectId, uint nEventId, SWIGTYPE_p_void pScript) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_AddEventDeltaTime__SWIG_0(swigCPtr, nDaysFromNow, nTimeFromNow, nCallerObjectId, nObjectId, nEventId, SWIGTYPE_p_void.getCPtr(pScript));
    return ret;
  }

  public int AddEventDeltaTime(uint nDaysFromNow, uint nTimeFromNow, uint nCallerObjectId, uint nObjectId, uint nEventId) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_AddEventDeltaTime__SWIG_1(swigCPtr, nDaysFromNow, nTimeFromNow, nCallerObjectId, nObjectId, nEventId);
    return ret;
  }

  public int AddEventAbsoluteTime(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId, SWIGTYPE_p_void pScript) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTime__SWIG_0(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId, SWIGTYPE_p_void.getCPtr(pScript));
    return ret;
  }

  public int AddEventAbsoluteTime(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTime__SWIG_1(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId);
    return ret;
  }

  public int AddEventAbsoluteTimeViaTail(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId, SWIGTYPE_p_void pScript) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTimeViaTail__SWIG_0(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId, SWIGTYPE_p_void.getCPtr(pScript));
    return ret;
  }

  public int AddEventAbsoluteTimeViaTail(uint nCalendarDay, uint nTimeOfDay, uint nCallerObjectId, uint nObjectId, uint nEventId) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_AddEventAbsoluteTimeViaTail__SWIG_1(swigCPtr, nCalendarDay, nTimeOfDay, nCallerObjectId, nObjectId, nEventId);
    return ret;
  }

  public int EventPending(uint nCalendarDay, uint nTimeOfDay) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_EventPending(swigCPtr, nCalendarDay, nTimeOfDay);
    return ret;
  }

  public int GetPendingEvent(SWIGTYPE_p_unsigned_int nCalendarDay, SWIGTYPE_p_unsigned_int nTimeOfDay, SWIGTYPE_p_unsigned_int nCallerObjectId, SWIGTYPE_p_unsigned_int nObjectId, SWIGTYPE_p_unsigned_int nEventId, SWIGTYPE_p_p_void pScript) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_GetPendingEvent(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(nCalendarDay), SWIGTYPE_p_unsigned_int.getCPtr(nTimeOfDay), SWIGTYPE_p_unsigned_int.getCPtr(nCallerObjectId), SWIGTYPE_p_unsigned_int.getCPtr(nObjectId), SWIGTYPE_p_unsigned_int.getCPtr(nEventId), SWIGTYPE_p_p_void.getCPtr(pScript));
    return ret;
  }

  public int SaveEventQueue(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_SaveEventQueue(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadEventQueue(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_LoadEventQueue(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int OnEffectApplied(CNWSObject pObject, CGameEffect effect, int bLoadingGame) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_OnEffectApplied__SWIG_0(swigCPtr, CNWSObject.getCPtr(pObject), CGameEffect.getCPtr(effect), bLoadingGame);
    return ret;
  }

  public int OnEffectApplied(CNWSObject pObject, CGameEffect effect) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_OnEffectApplied__SWIG_1(swigCPtr, CNWSObject.getCPtr(pObject), CGameEffect.getCPtr(effect));
    return ret;
  }

  public int OnEffectRemoved(CNWSObject pObject, CGameEffect effect) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_OnEffectRemoved(swigCPtr, CNWSObject.getCPtr(pObject), CGameEffect.getCPtr(effect));
    return ret;
  }

  public int OnItemPropertyApplied(CNWSItem pItem, CNWItemProperty pItemProperty, CNWSCreature pTargetCreature, uint nTargetInventorySlot, int bLoadingGame) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_OnItemPropertyApplied(swigCPtr, CNWSItem.getCPtr(pItem), CNWItemProperty.getCPtr(pItemProperty), CNWSCreature.getCPtr(pTargetCreature), nTargetInventorySlot, bLoadingGame);
    return ret;
  }

  public int OnItemPropertyRemoved(CNWSItem pItem, CNWItemProperty pItemProperty, CNWSCreature pTargetCreature, uint nTargetInventorySlot) {
    int ret = NWNXLibPINVOKE.CServerAIMaster_OnItemPropertyRemoved(swigCPtr, CNWSItem.getCPtr(pItem), CNWItemProperty.getCPtr(pItemProperty), CNWSCreature.getCPtr(pTargetCreature), nTargetInventorySlot);
    return ret;
  }

  public void AdjustTargetAndWitnessReputations(uint oidTarget, uint oidSource, int nActionType) {
    NWNXLibPINVOKE.CServerAIMaster_AdjustTargetAndWitnessReputations(swigCPtr, oidTarget, oidSource, nActionType);
  }

  public void LoadReputationAdjustments() {
    NWNXLibPINVOKE.CServerAIMaster_LoadReputationAdjustments(swigCPtr);
  }

  public void ClearScriptsRun() {
    NWNXLibPINVOKE.CServerAIMaster_ClearScriptsRun(swigCPtr);
  }

  public CExoString GetScriptsRun() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerAIMaster_GetScriptsRun(swigCPtr);
    CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
    return ret;
  }

  public void AppendToScriptsRun(CExoString sScriptName) {
    NWNXLibPINVOKE.CServerAIMaster_AppendToScriptsRun(swigCPtr, CExoString.getCPtr(sScriptName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteEventData(uint nEventId, SWIGTYPE_p_void pEventData) {
    NWNXLibPINVOKE.CServerAIMaster_DeleteEventData(swigCPtr, nEventId, SWIGTYPE_p_void.getCPtr(pEventData));
  }

}

}
