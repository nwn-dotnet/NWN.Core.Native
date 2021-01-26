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

public class CNWSPlayerTURD : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CNWSPlayerTURD(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSPlayerTURD_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerTURD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSPlayerTURD(swigCPtr);
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

  public bool Equals(CNWSPlayerTURD other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerTURD other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerTURD left, CNWSPlayerTURD right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerTURD left, CNWSPlayerTURD right) {
    return !Equals(left, right);
  }

  public CExoString m_sCommunityName {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_sCommunityName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_m_sCommunityName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_lsFirstName {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_lsFirstName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_m_lsFirstName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_lsLastName {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_lsLastName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_m_lsLastName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidPlayer {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_oidPlayer_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerTURD_m_oidPlayer_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_nCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerTURD_m_nCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nCalendarTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_nCalendarTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerTURD_m_nCalendarTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pReputation {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_pReputation_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_m_pReputation_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCNWSPersonalReputation m_pPersonalReputationList {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_pPersonalReputationList_set(swigCPtr, CExoArrayListCNWSPersonalReputation.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_m_pPersonalReputationList_get(swigCPtr);
      CExoArrayListCNWSPersonalReputation ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSPersonalReputation(cPtr, false);
      return ret;
    } 
  }

  public int m_nNumAutomapAreas {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_nNumAutomapAreas_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayerTURD_m_nNumAutomapAreas_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int m_poidAutomapAreasList {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_poidAutomapAreasList_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_m_poidAutomapAreasList_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_unsigned_char m_pAutoMapTileData {
    set {
      NWNXLibPINVOKE.CNWSPlayerTURD_m_pAutoMapTileData_set(swigCPtr, SWIGTYPE_p_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_m_pAutoMapTileData_get(swigCPtr);
      SWIGTYPE_p_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerTURD(uint oidId) : this(NWNXLibPINVOKE.new_CNWSPlayerTURD__SWIG_0(oidId), true) {
  }

  public CNWSPlayerTURD() : this(NWNXLibPINVOKE.new_CNWSPlayerTURD__SWIG_1(), true) {
  }

  public override CNWSPlayerTURD AsNWSPlayerTURD() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerTURD_AsNWSPlayerTURD(swigCPtr);
    CNWSPlayerTURD ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerTURD(cPtr, false);
    return ret;
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSPlayerTURD_AIUpdate(swigCPtr);
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, System.IntPtr pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSPlayerTURD_EventHandler(swigCPtr, nEventId, nCallerObjectId, pScript, nCalendarDay, nTimeOfDay);
  }

  public void AddToArea(CNWSArea pArea, int bRunScripts) {
    NWNXLibPINVOKE.CNWSPlayerTURD_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), bRunScripts);
  }

  public void AddToArea(CNWSArea pArea) {
    NWNXLibPINVOKE.CNWSPlayerTURD_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea));
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSPlayerTURD_RemoveFromArea(swigCPtr);
  }

  public void SaveTURD(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSPlayerTURD_SaveTURD(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public int LoadTURD(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSPlayerTURD_LoadTURD(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public void SetReputation(CExoArrayListInt32 pRep) {
    NWNXLibPINVOKE.CNWSPlayerTURD_SetReputation(swigCPtr, CExoArrayListInt32.getCPtr(pRep));
  }

  public void SetPersonalReputation(CExoArrayListCNWSPersonalReputation pRep) {
    NWNXLibPINVOKE.CNWSPlayerTURD_SetPersonalReputation(swigCPtr, CExoArrayListCNWSPersonalReputation.getCPtr(pRep));
  }

  public void CopyEffectList(CExoArrayListCGameEffectPtr pEffectList) {
    NWNXLibPINVOKE.CNWSPlayerTURD_CopyEffectList(swigCPtr, CExoArrayListCGameEffectPtr.getCPtr(pEffectList));
  }

  public void CopyAutomapData(int nNumAreas, CExoArrayListObjectId pAreaList, SWIGTYPE_p_p_unsigned_char pAreaData) {
    NWNXLibPINVOKE.CNWSPlayerTURD_CopyAutomapData(swigCPtr, nNumAreas, CExoArrayListObjectId.getCPtr(pAreaList), SWIGTYPE_p_p_unsigned_char.getCPtr(pAreaData));
  }

  public void ClearAutomapData() {
    NWNXLibPINVOKE.CNWSPlayerTURD_ClearAutomapData(swigCPtr);
  }

  public void LoadAutoMapData(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSPlayerTURD_LoadAutoMapData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public void SaveAutoMapData(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSPlayerTURD_SaveAutoMapData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

}

}
