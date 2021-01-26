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

public class CNWSpell : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSpell(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSpell obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSpell() {
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
          NWNXLibPINVOKE.delete_CNWSpell(swigCPtr);
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

  public bool Equals(CNWSpell other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSpell other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSpell left, CNWSpell right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSpell left, CNWSpell right) {
    return !Equals(left, right);
  }

  public CExoString m_sLabel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_sLabel_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_sLabel_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_strrefName {
    set {
      NWNXLibPINVOKE.CNWSpell_m_strrefName_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_strrefName_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_strrefDesc {
    set {
      NWNXLibPINVOKE.CNWSpell_m_strrefDesc_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_strrefDesc_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_resrefIcon {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefIcon_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefIcon_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public byte m_nSchool {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nSchool_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nSchool_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sRange {
    set {
      NWNXLibPINVOKE.CNWSpell_m_sRange_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_sRange_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sComponent {
    set {
      NWNXLibPINVOKE.CNWSpell_m_sComponent_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_sComponent_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nTargetType {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nTargetType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSpell_m_nTargetType_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sImpactScript {
    set {
      NWNXLibPINVOKE.CNWSpell_m_sImpactScript_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_sImpactScript_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public byte m_nBardLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nBardLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nBardLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nClericLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nClericLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nClericLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDruidLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nDruidLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nDruidLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nPaladinLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nPaladinLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nPaladinLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nRangerLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nRangerLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nRangerLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSorcererLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nSorcererLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nSorcererLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nWizardLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nWizardLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nWizardLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nInnateLevel {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nInnateLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nInnateLevel_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nConjureTime {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nConjureTime_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nConjureTime_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nConjureAnimation {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nConjureAnimation_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSpell_m_nConjureAnimation_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_resrefConjureHeadVisual {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefConjureHeadVisual_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefConjureHeadVisual_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefConjureHandVisual {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefConjureHandVisual_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefConjureHandVisual_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefConjureGroundVisual {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefConjureGroundVisual_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefConjureGroundVisual_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefConjureSoundMale {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefConjureSoundMale_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefConjureSoundMale_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefConjureSoundFemale {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefConjureSoundFemale_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefConjureSoundFemale_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefConjureSoundVFX {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefConjureSoundVFX_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefConjureSoundVFX_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nCastAnimation {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nCastAnimation_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSpell_m_nCastAnimation_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nCastTime {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nCastTime_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nCastTime_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_resrefCastHeadVisual {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefCastHeadVisual_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefCastHeadVisual_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefCastHandVisual {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefCastHandVisual_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefCastHandVisual_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefCastGroundVisual {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefCastGroundVisual_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefCastGroundVisual_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_resrefCastSound {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefCastSound_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefCastSound_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public int m_bProjectileSpawn {
    set {
      NWNXLibPINVOKE.CNWSpell_m_bProjectileSpawn_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_bProjectileSpawn_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_resrefProjectile {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefProjectile_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefProjectile_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public uint m_nProjectileType {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nProjectileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nProjectileType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nProjectileSpawnPoint {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nProjectileSpawnPoint_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nProjectileSpawnPoint_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_resrefProjectileSound {
    set {
      NWNXLibPINVOKE.CNWSpell_m_resrefProjectileSound_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_resrefProjectileSound_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public byte m_nProjectileOrientationType {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nProjectileOrientationType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nProjectileOrientationType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nImmunityType {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nImmunityType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nImmunityType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bImmunityItem {
    set {
      NWNXLibPINVOKE.CNWSpell_m_bImmunityItem_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_bImmunityItem_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTalentCategory {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nTalentCategory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_nTalentCategory_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTalentMaxCR {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nTalentMaxCR_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_nTalentMaxCR_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int m_pSubRadialSpell {
    set {
      NWNXLibPINVOKE.CNWSpell_m_pSubRadialSpell_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSpell_m_pSubRadialSpell_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public byte m_nSubRadialSpellCount {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nSubRadialSpellCount_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nSubRadialSpellCount_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bUseConcentration {
    set {
      NWNXLibPINVOKE.CNWSpell_m_bUseConcentration_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_bUseConcentration_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nMasterSpell {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nMasterSpell_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nMasterSpell_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nCounterSpell1 {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nCounterSpell1_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nCounterSpell1_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nCounterSpell2 {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nCounterSpell2_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nCounterSpell2_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nUserType {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nUserType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nUserType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSpontaneouslyCast {
    set {
      NWNXLibPINVOKE.CNWSpell_m_bSpontaneouslyCast_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_bSpontaneouslyCast_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAllowedMetamagic {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nAllowedMetamagic_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSpell_m_nAllowedMetamagic_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nAltMessage {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nAltMessage_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nAltMessage_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHostile {
    set {
      NWNXLibPINVOKE.CNWSpell_m_bHostile_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_bHostile_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nFeatId {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nFeatId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_nFeatId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHasProjectile {
    set {
      NWNXLibPINVOKE.CNWSpell_m_bHasProjectile_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSpell_m_bHasProjectile_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSpellId {
    set {
      NWNXLibPINVOKE.CNWSpell_m_nSpellId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSpell_m_nSpellId_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSpell() : this(NWNXLibPINVOKE.new_CNWSpell(), true) {
  }

  public CExoString GetSpellNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWSpell_GetSpellNameText(swigCPtr), true);
    return ret;
  }

  public int GetSpellHasVerbalComponent() {
    int ret = NWNXLibPINVOKE.CNWSpell_GetSpellHasVerbalComponent(swigCPtr);
    return ret;
  }

  public int GetSpellHasSomaticComponent() {
    int ret = NWNXLibPINVOKE.CNWSpell_GetSpellHasSomaticComponent(swigCPtr);
    return ret;
  }

  public byte GetSpellLevel(byte nClass) {
    byte ret = NWNXLibPINVOKE.CNWSpell_GetSpellLevel(swigCPtr, nClass);
    return ret;
  }

  public uint GetSubRadialSpell(byte nIndex) {
    uint ret = NWNXLibPINVOKE.CNWSpell_GetSubRadialSpell(swigCPtr, nIndex);
    return ret;
  }

  public void SetSubRadialSpell(byte nIndex, uint nSpellID) {
    NWNXLibPINVOKE.CNWSpell_SetSubRadialSpell(swigCPtr, nIndex, nSpellID);
  }

  public void SetSubRadialSpellCount(byte nCount) {
    NWNXLibPINVOKE.CNWSpell_SetSubRadialSpellCount(swigCPtr, nCount);
  }

}

}
