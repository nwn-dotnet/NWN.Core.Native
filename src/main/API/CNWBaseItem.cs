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

public class CNWBaseItem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWBaseItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWBaseItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWBaseItem() {
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
          NWNXLibPINVOKE.delete_CNWBaseItem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint m_nName {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nName_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWBaseItem_m_nName_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nEquipableSlots {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nEquipableSlots_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWBaseItem_m_nEquipableSlots_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nWeaponWield {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponWield_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponWield_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nWeaponType {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nMinRange {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nMinRange_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWBaseItem_m_nMinRange_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nMaxRange {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nMaxRange_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWBaseItem_m_nMaxRange_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nInvSlotWidth {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nInvSlotWidth_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nInvSlotWidth_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nInvSlotHeight {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nInvSlotHeight_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nInvSlotHeight_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nModelType {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nModelType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nModelType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nStartingCharges {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nStartingCharges_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nStartingCharges_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nWeaponRanged {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponRanged_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponRanged_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nWeaponSize {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponSize_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponSize_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nNumDice {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nNumDice_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nNumDice_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDieToRoll {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nDieToRoll_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nDieToRoll_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCritThreat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nCritThreat_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nCritThreat_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCritMult {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nCritMult_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nCritMult_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCategory {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nCategory_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nCategory_get(swigCPtr);
      return ret;
    } 
  }

  public float m_nBaseCost {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nBaseCost_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWBaseItem_m_nBaseCost_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nStackSize {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nStackSize_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nStackSize_get(swigCPtr);
      return ret;
    } 
  }

  public float m_nCostMultiplier {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nCostMultiplier_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWBaseItem_m_nCostMultiplier_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDescription {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nDescription_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWBaseItem_m_nDescription_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinProperties {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nMinProperties_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nMinProperties_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMaxProperties {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nMaxProperties_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nMaxProperties_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPropColumn {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nPropColumn_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nPropColumn_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nStorePanel {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nStorePanel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nStorePanel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nStorePanelSort {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nStorePanelSort_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nStorePanelSort_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPercentageSlashL {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nPercentageSlashL_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nPercentageSlashL_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPercentageSlashR {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nPercentageSlashR_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nPercentageSlashR_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPercentageSlashS {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nPercentageSlashS_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nPercentageSlashS_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nILRStackSize {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nILRStackSize_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nILRStackSize_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fPreferredAttackDist {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_fPreferredAttackDist_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWBaseItem_m_fPreferredAttackDist_get(swigCPtr);
      return ret;
    } 
  }

  public string m_ItemClassResRefChunk {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_ItemClassResRefChunk_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CNWBaseItem_m_ItemClassResRefChunk_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_bPartEnvMap {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_bPartEnvMap_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWBaseItem_m_bPartEnvMap_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_DefaultIconResRef {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_DefaultIconResRef_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWBaseItem_m_DefaultIconResRef_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_DefaultModelResRef {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_DefaultModelResRef_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWBaseItem_m_DefaultModelResRef_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public int m_bCanRotateIcon {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_bCanRotateIcon_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWBaseItem_m_bCanRotateIcon_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bContainer {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_bContainer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWBaseItem_m_bContainer_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bGenderSpecific {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_bGenderSpecific_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWBaseItem_m_bGenderSpecific_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_InventorySoundType {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_InventorySoundType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_InventorySoundType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short m_pRequiredFeats {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_pRequiredFeats_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWBaseItem_m_pRequiredFeats_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public byte m_nRequiredFeatCount {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nRequiredFeatCount_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nRequiredFeatCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nStatsString {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nStatsString_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWBaseItem_m_nStatsString_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nRotateOnGround {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nRotateOnGround_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nRotateOnGround_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nWeight {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeight_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeight_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nBaseAC {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nBaseAC_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nBaseAC_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nACEnchantmentType {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nACEnchantmentType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nACEnchantmentType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nWeaponMaterialType {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponMaterialType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponMaterialType_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nArmorCheckPenalty {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nArmorCheckPenalty_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWBaseItem_m_nArmorCheckPenalty_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nAmmunitionType {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nAmmunitionType_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWBaseItem_m_nAmmunitionType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nQBBehaviourType {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nQBBehaviourType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nQBBehaviourType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nArcaneSpellFailure {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nArcaneSpellFailure_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWBaseItem_m_nArcaneSpellFailure_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nWeaponFocusFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponFocusFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponFocusFeat_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nEpicWeaponFocusFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponFocusFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponFocusFeat_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nWeaponSpecializationFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponSpecializationFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponSpecializationFeat_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nEpicWeaponSpecializationFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponSpecializationFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponSpecializationFeat_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nWeaponImprovedCriticalFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponImprovedCriticalFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponImprovedCriticalFeat_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nEpicWeaponOverwhelmingCriticalFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponOverwhelmingCriticalFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponOverwhelmingCriticalFeat_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nEpicWeaponDevastatingCriticalFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponDevastatingCriticalFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nEpicWeaponDevastatingCriticalFeat_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nWeaponOfChoiceFeat {
    set {
      NWNXLibPINVOKE.CNWBaseItem_m_nWeaponOfChoiceFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWBaseItem_m_nWeaponOfChoiceFeat_get(swigCPtr);
      return ret;
    } 
  }

  public CNWBaseItem() : this(NWNXLibPINVOKE.new_CNWBaseItem(), true) {
  }

  public CExoString GetNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWBaseItem_GetNameText(swigCPtr), true);
    return ret;
  }

  public CResRef GetModelResRef(byte nPart, short nModelNumber, char nGender) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWBaseItem_GetModelResRef__SWIG_0(swigCPtr, nPart, nModelNumber, nGender), true);
    return ret;
  }

  public CResRef GetModelResRef(byte nPart, short nModelNumber) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWBaseItem_GetModelResRef__SWIG_1(swigCPtr, nPart, nModelNumber), true);
    return ret;
  }

  public CResRef GetIconResRef(byte nPart, short nModelNumber, char nGender) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWBaseItem_GetIconResRef__SWIG_0(swigCPtr, nPart, nModelNumber, nGender), true);
    return ret;
  }

  public CResRef GetIconResRef(byte nPart, short nModelNumber) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWBaseItem_GetIconResRef__SWIG_1(swigCPtr, nPart, nModelNumber), true);
    return ret;
  }

  public ushort GetRequiredFeat(byte nReqFeatIndex) {
    ushort ret = NWNXLibPINVOKE.CNWBaseItem_GetRequiredFeat(swigCPtr, nReqFeatIndex);
    return ret;
  }

  public void SetRequiredFeat(byte nReqFeatIndex, ushort nFeat) {
    NWNXLibPINVOKE.CNWBaseItem_SetRequiredFeat(swigCPtr, nReqFeatIndex, nFeat);
  }

  public void SetRequiredFeatCount(byte nReqFeatCount) {
    NWNXLibPINVOKE.CNWBaseItem_SetRequiredFeatCount(swigCPtr, nReqFeatCount);
  }

}

}