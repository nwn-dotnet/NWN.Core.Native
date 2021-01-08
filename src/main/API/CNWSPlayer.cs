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

public class CNWSPlayer : CNWSClient {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSPlayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSPlayer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public SWIGTYPE_p_CExoLinkedListT_CLastUpdateObject_t m_pActiveObjectsLastUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pActiveObjectsLastUpdate_set(swigCPtr, SWIGTYPE_p_CExoLinkedListT_CLastUpdateObject_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pActiveObjectsLastUpdate_get(swigCPtr);
      SWIGTYPE_p_CExoLinkedListT_CLastUpdateObject_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoLinkedListT_CLastUpdateObject_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_CExoLinkedListT_CLastUpdatePartyObject_t m_pActivePartyObjectsLastUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pActivePartyObjectsLastUpdate_set(swigCPtr, SWIGTYPE_p_CExoLinkedListT_CLastUpdatePartyObject_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pActivePartyObjectsLastUpdate_get(swigCPtr);
      SWIGTYPE_p_CExoLinkedListT_CLastUpdatePartyObject_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoLinkedListT_CLastUpdatePartyObject_t(cPtr, false);
      return ret;
    } 
  }

  public int m_nAreaTransitionBMP {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nAreaTransitionBMP_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_nAreaTransitionBMP_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sAreaTransitionName {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_sAreaTransitionName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_sAreaTransitionName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bFloatyEffects {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bFloatyEffects_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bFloatyEffects_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAreas {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nAreas_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_nAreas_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int m_pAreas {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pAreas_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pAreas_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public byte m_nLoginState {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLoginState_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlayer_m_nLoginState_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidNWSObject {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidNWSObject_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayer_m_oidNWSObject_get(swigCPtr);
      return ret;
    } 
  }

  public ulong m_nLastUpdatedTime {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLastUpdatedTime_set(swigCPtr, value);
    } 
    get {
      ulong ret = NWNXLibPINVOKE.CNWSPlayer_m_nLastUpdatedTime_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastObjectControlled {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidLastObjectControlled_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayer_m_oidLastObjectControlled_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidPCObject {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidPCObject_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayer_m_oidPCObject_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bIsPrimaryPlayer {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bIsPrimaryPlayer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bIsPrimaryPlayer_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bFromSaveGame {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bFromSaveGame_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bFromSaveGame_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bFromTURD {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bFromTURD_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bFromTURD_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPlayerListIndex {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nPlayerListIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayer_m_nPlayerListIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bPlayModuleListingCharacters {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bPlayModuleListingCharacters_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bPlayModuleListingCharacters_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSPlayerJournalQuest m_pJournalQuest {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pJournalQuest_set(swigCPtr, CNWSPlayerJournalQuest.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pJournalQuest_get(swigCPtr);
      CNWSPlayerJournalQuest ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerJournalQuest(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerStoreGUI m_pStoreGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pStoreGUI_set(swigCPtr, CNWSPlayerStoreGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pStoreGUI_get(swigCPtr);
      CNWSPlayerStoreGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerStoreGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerCharSheetGUI m_pCharSheetGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pCharSheetGUI_set(swigCPtr, CNWSPlayerCharSheetGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pCharSheetGUI_get(swigCPtr);
      CNWSPlayerCharSheetGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerCharSheetGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerInventoryGUI m_pInventoryGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pInventoryGUI_set(swigCPtr, CNWSPlayerInventoryGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pInventoryGUI_get(swigCPtr);
      CNWSPlayerInventoryGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerInventoryGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerInventoryGUI m_pOtherInventoryGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pOtherInventoryGUI_set(swigCPtr, CNWSPlayerInventoryGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pOtherInventoryGUI_get(swigCPtr);
      CNWSPlayerInventoryGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerInventoryGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerLastUpdateObject m_pPlayerLUO {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pPlayerLUO_set(swigCPtr, CNWSPlayerLastUpdateObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pPlayerLUO_get(swigCPtr);
      CNWSPlayerLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLastUpdateObject(cPtr, false);
      return ret;
    } 
  }

  public int m_bAlwaysRun {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bAlwaysRun_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bAlwaysRun_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCharacterType {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nCharacterType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlayer_m_nCharacterType_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_resFileName {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_resFileName_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_resFileName_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public int m_bCommunityNameAuthorized {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bCommunityNameAuthorized_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bCommunityNameAuthorized_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bModuleInfoSucceeded {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bModuleInfoSucceeded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bModuleInfoSucceeded_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nIFOCharacterIndex {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nIFOCharacterIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayer_m_nIFOCharacterIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bCutsceneState {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bCutsceneState_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bCutsceneState_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bTargetMode {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bTargetMode_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bTargetMode_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidDungeonMasterAvatar {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidDungeonMasterAvatar_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayer_m_oidDungeonMasterAvatar_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPossessState {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nPossessState_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlayer_m_nPossessState_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bWasSentITP {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bWasSentITP_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayer_m_bWasSentITP_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSPlayer(uint nPlayerID) : this(NWNXLibPINVOKE.new_CNWSPlayer(nPlayerID), true) {
  }

  public void ClearPlayerOnDestroyGame() {
    NWNXLibPINVOKE.CNWSPlayer_ClearPlayerOnDestroyGame(swigCPtr);
  }

  public override CNWSPlayer AsNWSPlayer() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_AsNWSPlayer(swigCPtr);
    CNWSPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayer(cPtr, false);
    return ret;
  }

  public override CNWSPlayer AsNWSDungeonMaster() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_AsNWSDungeonMaster(swigCPtr);
    CNWSPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayer(cPtr, false);
    return ret;
  }

  public uint LoadLocalCharacter() {
    uint ret = NWNXLibPINVOKE.CNWSPlayer_LoadLocalCharacter(swigCPtr);
    return ret;
  }

  public uint LoadDMCharacter() {
    uint ret = NWNXLibPINVOKE.CNWSPlayer_LoadDMCharacter(swigCPtr);
    return ret;
  }

  public uint LoadServerCharacter(CResRef cResRef, int bSubDirChar) {
    uint ret = NWNXLibPINVOKE.CNWSPlayer_LoadServerCharacter__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), bSubDirChar);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint LoadServerCharacter(CResRef cResRef) {
    uint ret = NWNXLibPINVOKE.CNWSPlayer_LoadServerCharacter__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded, int bRunPostProcess, int bAddObjectToArray, int bDoingCharacterCopy) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_0(swigCPtr, nIndex, bAreaLoaded, bRunPostProcess, bAddObjectToArray, bDoingCharacterCopy);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded, int bRunPostProcess, int bAddObjectToArray) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_1(swigCPtr, nIndex, bAreaLoaded, bRunPostProcess, bAddObjectToArray);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded, int bRunPostProcess) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_2(swigCPtr, nIndex, bAreaLoaded, bRunPostProcess);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_3(swigCPtr, nIndex, bAreaLoaded);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_4(swigCPtr, nIndex);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public void LoadTURDInfoFromIFO(uint nIndex) {
    NWNXLibPINVOKE.CNWSPlayer_LoadTURDInfoFromIFO(swigCPtr, nIndex);
  }

  public int GetCharacterInfoFromIFO(SWIGTYPE_p_unsigned_char nNumClasses, SWIGTYPE_p_int pClasses, SWIGTYPE_p_unsigned_char pLevels, SWIGTYPE_p_unsigned_int nXP) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_GetCharacterInfoFromIFO(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(nNumClasses), SWIGTYPE_p_int.getCPtr(pClasses), SWIGTYPE_p_unsigned_char.getCPtr(pLevels), SWIGTYPE_p_unsigned_int.getCPtr(nXP));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint LoadCreatureData(CResRef cResRef, CNWSCreature pCreature) {
    uint ret = NWNXLibPINVOKE.CNWSPlayer_LoadCreatureData(swigCPtr, CResRef.getCPtr(cResRef), CNWSCreature.getCPtr(pCreature));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SaveServerCharacter(int bBackupPlayer) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_SaveServerCharacter__SWIG_0(swigCPtr, bBackupPlayer);
    return ret;
  }

  public int SaveServerCharacter() {
    int ret = NWNXLibPINVOKE.CNWSPlayer_SaveServerCharacter__SWIG_1(swigCPtr);
    return ret;
  }

  public int BackupServerCharacter(CExoString sFilename) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_BackupServerCharacter(swigCPtr, CExoString.getCPtr(sFilename));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint ValidateCharacter(SWIGTYPE_p_int bFailedServerRestriction) {
    uint ret = NWNXLibPINVOKE.CNWSPlayer_ValidateCharacter(swigCPtr, SWIGTYPE_p_int.getCPtr(bFailedServerRestriction));
    return ret;
  }

  public void ValidateCharacter_SetNormalBonusFlags(ushort nFeatID, SWIGTYPE_p_int bNormalListFeat, SWIGTYPE_p_int bBonusListFeat, byte nClass) {
    NWNXLibPINVOKE.CNWSPlayer_ValidateCharacter_SetNormalBonusFlags(swigCPtr, nFeatID, SWIGTYPE_p_int.getCPtr(bNormalListFeat), SWIGTYPE_p_int.getCPtr(bBonusListFeat), nClass);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void StripAllInvalidItemPropertiesInInventory(CNWSCreature pCreature) {
    NWNXLibPINVOKE.CNWSPlayer_StripAllInvalidItemPropertiesInInventory(swigCPtr, CNWSCreature.getCPtr(pCreature));
  }

  public void StripAllInvalidItemPropertiesOnItem(CNWSItem pItem) {
    NWNXLibPINVOKE.CNWSPlayer_StripAllInvalidItemPropertiesOnItem(swigCPtr, CNWSItem.getCPtr(pItem));
  }

  public void AddDMAbilities(CNWSCreature pCreature) {
    NWNXLibPINVOKE.CNWSPlayer_AddDMAbilities(swigCPtr, CNWSCreature.getCPtr(pCreature));
  }

  public int PackCreatureIntoMessage() {
    int ret = NWNXLibPINVOKE.CNWSPlayer_PackCreatureIntoMessage(swigCPtr);
    return ret;
  }

  public CNWSObject GetGameObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_GetGameObject(swigCPtr);
    CNWSObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObject(cPtr, false);
    return ret;
  }

  public void SetGameObject(CNWSObject pObject) {
    NWNXLibPINVOKE.CNWSPlayer_SetGameObject(swigCPtr, CNWSObject.getCPtr(pObject));
  }

  public CLastUpdateObject GetLastUpdateObject(uint oidLastUpdateObject) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_GetLastUpdateObject(swigCPtr, oidLastUpdateObject);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public void SetAreaTransitionBMP(int nIndex, CExoString sString) {
    NWNXLibPINVOKE.CNWSPlayer_SetAreaTransitionBMP(swigCPtr, nIndex, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetPlayerName() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWSPlayer_GetPlayerName(swigCPtr), true);
    return ret;
  }

  public void AllocateAreas(int nAreas) {
    NWNXLibPINVOKE.CNWSPlayer_AllocateAreas(swigCPtr, nAreas);
  }

  public int AddArea(uint oidArea) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_AddArea(swigCPtr, oidArea);
    return ret;
  }

  public int GetIsAllowedToSave() {
    int ret = NWNXLibPINVOKE.CNWSPlayer_GetIsAllowedToSave(swigCPtr);
    return ret;
  }

  public void DropTURD() {
    NWNXLibPINVOKE.CNWSPlayer_DropTURD(swigCPtr);
  }

  public void EatTURD(CNWSPlayerTURD pTURD) {
    NWNXLibPINVOKE.CNWSPlayer_EatTURD(swigCPtr, CNWSPlayerTURD.getCPtr(pTURD));
  }

  public void CleanMyTURDs() {
    NWNXLibPINVOKE.CNWSPlayer_CleanMyTURDs(swigCPtr);
  }

  public CNWSPlayerLastUpdateObject CreateNewPlayerLastUpdateObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_CreateNewPlayerLastUpdateObject(swigCPtr);
    CNWSPlayerLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLastUpdateObject(cPtr, false);
    return ret;
  }

  public void ClearPlayerLastUpdateObject() {
    NWNXLibPINVOKE.CNWSPlayer_ClearPlayerLastUpdateObject(swigCPtr);
  }

  public int PermittedToDisplayCharacterSheet(uint oidCreature) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_PermittedToDisplayCharacterSheet(swigCPtr, oidCreature);
    return ret;
  }

  public int HasExpansionPack(byte nPack, int bOrBetter) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_HasExpansionPack__SWIG_0(swigCPtr, nPack, bOrBetter);
    return ret;
  }

  public int HasExpansionPack(byte nPack) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_HasExpansionPack__SWIG_1(swigCPtr, nPack);
    return ret;
  }

  public void StoreCameraSettings() {
    NWNXLibPINVOKE.CNWSPlayer_StoreCameraSettings(swigCPtr);
  }

  public void RestoreCameraSettings() {
    NWNXLibPINVOKE.CNWSPlayer_RestoreCameraSettings(swigCPtr);
  }

  public int SatisfiesBuild(int nBuild, int nRevision) {
    int ret = NWNXLibPINVOKE.CNWSPlayer_SatisfiesBuild(swigCPtr, nBuild, nRevision);
    return ret;
  }

  public int GetIsDM() {
    int ret = NWNXLibPINVOKE.CNWSPlayer_GetIsDM(swigCPtr);
    return ret;
  }

  public int GetIsPlayerDM() {
    int ret = NWNXLibPINVOKE.CNWSPlayer_GetIsPlayerDM(swigCPtr);
    return ret;
  }

  public void PossessCreature(uint oidTarget, byte possessType) {
    NWNXLibPINVOKE.CNWSPlayer_PossessCreature(swigCPtr, oidTarget, possessType);
  }

}

}
