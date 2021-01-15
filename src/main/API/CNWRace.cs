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

public class CNWRace : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWRace(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWRace obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWRace() {
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
          NWNXLibPINVOKE.delete_CNWRace(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int m_nNameStrref {
    set {
      NWNXLibPINVOKE.CNWRace_m_nNameStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nNameStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nConverNameStrref {
    set {
      NWNXLibPINVOKE.CNWRace_m_nConverNameStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nConverNameStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nConverNameLowerStrref {
    set {
      NWNXLibPINVOKE.CNWRace_m_nConverNameLowerStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nConverNameLowerStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNamePluralStrref {
    set {
      NWNXLibPINVOKE.CNWRace_m_nNamePluralStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nNamePluralStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDescriptionStrref {
    set {
      NWNXLibPINVOKE.CNWRace_m_nDescriptionStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nDescriptionStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDefaultBiographyStrref {
    set {
      NWNXLibPINVOKE.CNWRace_m_nDefaultBiographyStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nDefaultBiographyStrref_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nSTRAdjust {
    set {
      NWNXLibPINVOKE.CNWRace_m_nSTRAdjust_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWRace_m_nSTRAdjust_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nDEXAdjust {
    set {
      NWNXLibPINVOKE.CNWRace_m_nDEXAdjust_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWRace_m_nDEXAdjust_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nINTAdjust {
    set {
      NWNXLibPINVOKE.CNWRace_m_nINTAdjust_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWRace_m_nINTAdjust_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nCHAAdjust {
    set {
      NWNXLibPINVOKE.CNWRace_m_nCHAAdjust_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWRace_m_nCHAAdjust_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nWISAdjust {
    set {
      NWNXLibPINVOKE.CNWRace_m_nWISAdjust_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWRace_m_nWISAdjust_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nCONAdjust {
    set {
      NWNXLibPINVOKE.CNWRace_m_nCONAdjust_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWRace_m_nCONAdjust_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nEndurance {
    set {
      NWNXLibPINVOKE.CNWRace_m_nEndurance_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWRace_m_nEndurance_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nFavoredClass {
    set {
      NWNXLibPINVOKE.CNWRace_m_nFavoredClass_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWRace_m_nFavoredClass_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bIsPlayerRace {
    set {
      NWNXLibPINVOKE.CNWRace_m_bIsPlayerRace_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_bIsPlayerRace_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nNumFeats {
    set {
      NWNXLibPINVOKE.CNWRace_m_nNumFeats_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWRace_m_nNumFeats_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short m_lstFeatTable {
    set {
      NWNXLibPINVOKE.CNWRace_m_lstFeatTable_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRace_m_lstFeatTable_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public int m_nAge {
    set {
      NWNXLibPINVOKE.CNWRace_m_nAge_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nAge_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nDefaultAppearance {
    set {
      NWNXLibPINVOKE.CNWRace_m_nDefaultAppearance_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWRace_m_nDefaultAppearance_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sIcon {
    set {
      NWNXLibPINVOKE.CNWRace_m_sIcon_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWRace_m_sIcon_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nExtraFeatsAtFirstLevel {
    set {
      NWNXLibPINVOKE.CNWRace_m_nExtraFeatsAtFirstLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nExtraFeatsAtFirstLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nExtraSkillPointsPerLevel {
    set {
      NWNXLibPINVOKE.CNWRace_m_nExtraSkillPointsPerLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nExtraSkillPointsPerLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nFirstLevelSkillPointsMultiplier {
    set {
      NWNXLibPINVOKE.CNWRace_m_nFirstLevelSkillPointsMultiplier_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nFirstLevelSkillPointsMultiplier_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAbilitiesPointBuyNumber {
    set {
      NWNXLibPINVOKE.CNWRace_m_nAbilitiesPointBuyNumber_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nAbilitiesPointBuyNumber_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNormalFeatEveryNthLevel {
    set {
      NWNXLibPINVOKE.CNWRace_m_nNormalFeatEveryNthLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nNormalFeatEveryNthLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNumberNormalFeatsEveryNthLevel {
    set {
      NWNXLibPINVOKE.CNWRace_m_nNumberNormalFeatsEveryNthLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nNumberNormalFeatsEveryNthLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSkillPointModifierAbility {
    set {
      NWNXLibPINVOKE.CNWRace_m_nSkillPointModifierAbility_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWRace_m_nSkillPointModifierAbility_get(swigCPtr);
      return ret;
    } 
  }

  public CNWRace() : this(NWNXLibPINVOKE.new_CNWRace(), true) {
  }

  public CExoString GetNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRace_GetNameText(swigCPtr), true);
    return ret;
  }

  public CExoString GetConverNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRace_GetConverNameText(swigCPtr), true);
    return ret;
  }

  public CExoString GetConverNameLowerText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRace_GetConverNameLowerText(swigCPtr), true);
    return ret;
  }

  public CExoString GetNamePluralText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRace_GetNamePluralText(swigCPtr), true);
    return ret;
  }

  public CExoString GetDescriptionText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRace_GetDescriptionText(swigCPtr), true);
    return ret;
  }

  public CExoString GetDefaultBiographyText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWRace_GetDefaultBiographyText(swigCPtr), true);
    return ret;
  }

  public char GetAbilityAdjust(byte nAbilityId) {
    char ret = NWNXLibPINVOKE.CNWRace_GetAbilityAdjust(swigCPtr, nAbilityId);
    return ret;
  }

  public int IsFirstLevelGrantedFeat(ushort nFeat) {
    int ret = NWNXLibPINVOKE.CNWRace_IsFirstLevelGrantedFeat(swigCPtr, nFeat);
    return ret;
  }

  public void LoadFeatsTable(CExoString sTable) {
    NWNXLibPINVOKE.CNWRace_LoadFeatsTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
