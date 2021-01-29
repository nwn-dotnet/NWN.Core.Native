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

public unsafe class CNWClass : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWClass(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWClass(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWClass obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWClass() {
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
          NWNXLibPINVOKE.delete_CNWClass(swigCPtr);
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

  public bool Equals(CNWClass other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWClass other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWClass left, CNWClass right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWClass left, CNWClass right) {
    return !Equals(left, right);
  }

  public uint m_nName {
    set {
      NWNXLibPINVOKE.CNWClass_m_nName_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWClass_m_nName_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nNameLower {
    set {
      NWNXLibPINVOKE.CNWClass_m_nNameLower_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWClass_m_nNameLower_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nNamePlural {
    set {
      NWNXLibPINVOKE.CNWClass_m_nNamePlural_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWClass_m_nNamePlural_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDescription {
    set {
      NWNXLibPINVOKE.CNWClass_m_nDescription_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWClass_m_nDescription_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sIcon {
    set {
      NWNXLibPINVOKE.CNWClass_m_sIcon_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_m_sIcon_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sPreReqTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_sPreReqTable_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_m_sPreReqTable_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public byte[] m_lstBaseAttackBonus {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstBaseAttackBonus_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_lstBaseAttackBonus_get(swigCPtr);
        return retVal;
    }

  }

  public byte m_nHitDie {
    set {
      NWNXLibPINVOKE.CNWClass_m_nHitDie_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nHitDie_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSkillPointBase {
    set {
      NWNXLibPINVOKE.CNWClass_m_nSkillPointBase_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nSkillPointBase_get(swigCPtr);
      return ret;
    } 
  }

  public byte[] m_lstFortificationSaveThrowBonus {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstFortificationSaveThrowBonus_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_lstFortificationSaveThrowBonus_get(swigCPtr);
        return retVal;
    }

  }

  public byte[] m_lstWillSaveThrowBonus {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstWillSaveThrowBonus_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_lstWillSaveThrowBonus_get(swigCPtr);
        return retVal;
    }

  }

  public byte[] m_lstReflexSaveThrowBonus {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstReflexSaveThrowBonus_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_lstReflexSaveThrowBonus_get(swigCPtr);
        return retVal;
    }

  }

  public byte** m_lstSpellKnownTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstSpellKnownTable_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWClass_m_lstSpellKnownTable_get(swigCPtr); 
        return (byte**)retVal; 
    }

  }

  public byte[] m_lstSpellLevelsPerLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstSpellLevelsPerLevel_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_lstSpellLevelsPerLevel_get(swigCPtr);
        return retVal;
    }

  }

  public byte*[] m_lstSpellGainTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstSpellGainTable_set(swigCPtr, value);
    }  
    get {
        byte*[] retVal = NWNXLibPINVOKE.CNWClass_m_lstSpellGainTable_get(swigCPtr);
        return retVal;
    }

  }

  public CNWClass_Skill m_lstSkillTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstSkillTable_set(swigCPtr, CNWClass_Skill.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_m_lstSkillTable_get(swigCPtr);
      CNWClass_Skill ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWClass_Skill(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nNumSkills {
    set {
      NWNXLibPINVOKE.CNWClass_m_nNumSkills_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWClass_m_nNumSkills_get(swigCPtr);
      return ret;
    } 
  }

  public CNWClass_Feat m_lstFeatTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstFeatTable_set(swigCPtr, CNWClass_Feat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_m_lstFeatTable_get(swigCPtr);
      CNWClass_Feat ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWClass_Feat(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nNumFeats {
    set {
      NWNXLibPINVOKE.CNWClass_m_nNumFeats_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWClass_m_nNumFeats_get(swigCPtr);
      return ret;
    } 
  }

  public byte[] m_lstBonusFeatsTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstBonusFeatsTable_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_lstBonusFeatsTable_get(swigCPtr);
        return retVal;
    }

  }

  public SWIGTYPE_p_a_6__signed_char m_lstAbilityGainTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstAbilityGainTable_set(swigCPtr, SWIGTYPE_p_a_6__signed_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_m_lstAbilityGainTable_get(swigCPtr);
      SWIGTYPE_p_a_6__signed_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_6__signed_char(cPtr, false);
      return ret;
    } 
  }

  public sbyte[] m_lstNaturalACGainTable {
    set {
      NWNXLibPINVOKE.CNWClass_m_lstNaturalACGainTable_set(swigCPtr, value);
    }  
    get {
        sbyte[] retVal = NWNXLibPINVOKE.CNWClass_m_lstNaturalACGainTable_get(swigCPtr);
        return retVal;
    }

  }

  public byte m_nPrimaryAbility {
    set {
      NWNXLibPINVOKE.CNWClass_m_nPrimaryAbility_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nPrimaryAbility_get(swigCPtr);
      return ret;
    } 
  }

  public byte[] m_pnRecommendedAbilities {
    set {
      NWNXLibPINVOKE.CNWClass_m_pnRecommendedAbilities_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_pnRecommendedAbilities_get(swigCPtr);
        return retVal;
    }

  }

  public byte m_nClassRestrictions {
    set {
      NWNXLibPINVOKE.CNWClass_m_nClassRestrictions_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nClassRestrictions_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nClassRestrictionType {
    set {
      NWNXLibPINVOKE.CNWClass_m_nClassRestrictionType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nClassRestrictionType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nClassRestrictionsInversed {
    set {
      NWNXLibPINVOKE.CNWClass_m_nClassRestrictionsInversed_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_nClassRestrictionsInversed_get(swigCPtr);
      return ret;
    } 
  }

  public byte[] m_pnEffectiveCRForLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_pnEffectiveCRForLevel_set(swigCPtr, value);
    }  
    get {
        byte[] retVal = NWNXLibPINVOKE.CNWClass_m_pnEffectiveCRForLevel_get(swigCPtr);
        return retVal;
    }

  }

  public int m_bIsPlayerClass {
    set {
      NWNXLibPINVOKE.CNWClass_m_bIsPlayerClass_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bIsPlayerClass_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bIsSpellCasterClass {
    set {
      NWNXLibPINVOKE.CNWClass_m_bIsSpellCasterClass_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bIsSpellCasterClass_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMaxLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_nMaxLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nMaxLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bXPPenalty {
    set {
      NWNXLibPINVOKE.CNWClass_m_bXPPenalty_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bXPPenalty_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDefaultPackage {
    set {
      NWNXLibPINVOKE.CNWClass_m_nDefaultPackage_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWClass_m_nDefaultPackage_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSpellcastingAbility {
    set {
      NWNXLibPINVOKE.CNWClass_m_nSpellcastingAbility_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nSpellcastingAbility_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bNeedsToMemorizeSpells {
    set {
      NWNXLibPINVOKE.CNWClass_m_bNeedsToMemorizeSpells_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bNeedsToMemorizeSpells_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSpellbookRestricted {
    set {
      NWNXLibPINVOKE.CNWClass_m_bSpellbookRestricted_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bSpellbookRestricted_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHasDomains {
    set {
      NWNXLibPINVOKE.CNWClass_m_bHasDomains_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bHasDomains_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHasSpecialization {
    set {
      NWNXLibPINVOKE.CNWClass_m_bHasSpecialization_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bHasSpecialization_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bCanLearnFromScrolls {
    set {
      NWNXLibPINVOKE.CNWClass_m_bCanLearnFromScrolls_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bCanLearnFromScrolls_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bIsArcane {
    set {
      NWNXLibPINVOKE.CNWClass_m_bIsArcane_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bIsArcane_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSuffersArcaneSpellFailure {
    set {
      NWNXLibPINVOKE.CNWClass_m_bSuffersArcaneSpellFailure_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bSuffersArcaneSpellFailure_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sSpellsTableColumn {
    set {
      NWNXLibPINVOKE.CNWClass_m_sSpellsTableColumn_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_m_sSpellsTableColumn_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public float m_fCasterLevelMultiplier {
    set {
      NWNXLibPINVOKE.CNWClass_m_fCasterLevelMultiplier_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWClass_m_fCasterLevelMultiplier_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nMinCastingLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_nMinCastingLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_nMinCastingLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bCanCastSpontaneously {
    set {
      NWNXLibPINVOKE.CNWClass_m_bCanCastSpontaneously_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_m_bCanCastSpontaneously_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMinAssociateLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_nMinAssociateLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nMinAssociateLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nArcSpellUsePerDayLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_nArcSpellUsePerDayLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nArcSpellUsePerDayLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDivSpellUsePerDayLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_nDivSpellUsePerDayLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nDivSpellUsePerDayLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nEpicLevel {
    set {
      NWNXLibPINVOKE.CNWClass_m_nEpicLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_m_nEpicLevel_get(swigCPtr);
      return ret;
    } 
  }

  public CNWClass() : this(NWNXLibPINVOKE.new_CNWClass(), true) {
  }

  public CExoString GetNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWClass_GetNameText(swigCPtr), true);
    return ret;
  }

  public CExoString GetNameLowerText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWClass_GetNameLowerText(swigCPtr), true);
    return ret;
  }

  public CExoString GetNamePluralText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWClass_GetNamePluralText(swigCPtr), true);
    return ret;
  }

  public CExoString GetDescriptionText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWClass_GetDescriptionText(swigCPtr), true);
    return ret;
  }

  public byte GetAttackBonus(byte nLevel) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetAttackBonus(swigCPtr, nLevel);
    return ret;
  }

  public byte GetBonusFeats(byte nLevel) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetBonusFeats(swigCPtr, nLevel);
    return ret;
  }

  public byte GetFortSaveBonus(byte nLevel) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetFortSaveBonus(swigCPtr, nLevel);
    return ret;
  }

  public byte GetRefSaveBonus(byte nLevel) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetRefSaveBonus(swigCPtr, nLevel);
    return ret;
  }

  public byte GetWillSaveBonus(byte nLevel) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetWillSaveBonus(swigCPtr, nLevel);
    return ret;
  }

  public byte GetSpellGain(byte nLevel, byte nSpellLevel) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetSpellGain(swigCPtr, nLevel, nSpellLevel);
    return ret;
  }

  public byte GetSpellsKnownPerLevel(byte nLevel, byte nSpellLevel, byte nClass, ushort nRace, byte nCastingAbilityBase) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetSpellsKnownPerLevel(swigCPtr, nLevel, nSpellLevel, nClass, nRace, nCastingAbilityBase);
    return ret;
  }

  public void LoadAttackBonusTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWClass_LoadAttackBonusTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadFeatsTable(CExoString sTable, CNWRules pRules) {
    NWNXLibPINVOKE.CNWClass_LoadFeatsTable(swigCPtr, CExoString.getCPtr(sTable), CNWRules.getCPtr(pRules));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadSavingThrowTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWClass_LoadSavingThrowTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadSkillsTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWClass_LoadSkillsTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadBonusFeatsTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWClass_LoadBonusFeatsTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadSpellGainTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWClass_LoadSpellGainTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadSpellKnownTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWClass_LoadSpellKnownTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadStatGainTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWClass_LoadStatGainTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IsSkillUseable(ushort nSkill) {
    int ret = NWNXLibPINVOKE.CNWClass_IsSkillUseable(swigCPtr, nSkill);
    return ret;
  }

  public int IsSkillClassSkill(ushort nSkill) {
    int ret = NWNXLibPINVOKE.CNWClass_IsSkillClassSkill(swigCPtr, nSkill);
    return ret;
  }

  public int GetIsAlignmentAllowed(byte nGoodEvilConst, byte nLawChaosConst) {
    int ret = NWNXLibPINVOKE.CNWClass_GetIsAlignmentAllowed(swigCPtr, nGoodEvilConst, nLawChaosConst);
    return ret;
  }

  public byte GetLevelFeatGranted(ushort nFeat) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetLevelFeatGranted(swigCPtr, nFeat);
    return ret;
  }

  public CNWClass_Feat GetClassFeat(ushort nFeat) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWClass_GetClassFeat(swigCPtr, nFeat);
    CNWClass_Feat ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWClass_Feat(cPtr, false);
    return ret;
  }

  public int IsBonusFeat(ushort nFeat) {
    int ret = NWNXLibPINVOKE.CNWClass_IsBonusFeat(swigCPtr, nFeat);
    return ret;
  }

  public int IsNormalFeat(ushort nFeat) {
    int ret = NWNXLibPINVOKE.CNWClass_IsNormalFeat(swigCPtr, nFeat);
    return ret;
  }

  public int IsGrantedFeat(ushort nFeat, byte* nLevelGranted) {
    int ret = NWNXLibPINVOKE.CNWClass_IsGrantedFeat(swigCPtr, nFeat, (global::System.IntPtr)nLevelGranted);
    return ret;
  }

  public int IsFeatUseable(ushort nFeat) {
    int ret = NWNXLibPINVOKE.CNWClass_IsFeatUseable(swigCPtr, nFeat);
    return ret;
  }

  public byte GetLevelGranted(ushort nFeat) {
    byte ret = NWNXLibPINVOKE.CNWClass_GetLevelGranted(swigCPtr, nFeat);
    return ret;
  }

  public sbyte GetAbilityGainForSingleLevel(int ability, int level) {
    sbyte ret = NWNXLibPINVOKE.CNWClass_GetAbilityGainForSingleLevel(swigCPtr, ability, level);
    return ret;
  }

  public sbyte GetAbilityGainForLevel(int ability, int level) {
    sbyte ret = NWNXLibPINVOKE.CNWClass_GetAbilityGainForLevel(swigCPtr, ability, level);
    return ret;
  }

  public sbyte GetNaturalACGainForLevel(int level) {
    sbyte ret = NWNXLibPINVOKE.CNWClass_GetNaturalACGainForLevel(swigCPtr, level);
    return ret;
  }

}

}
