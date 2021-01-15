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

public class CNWSAreaOfEffectObject : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSAreaOfEffectObject(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSAreaOfEffectObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSAreaOfEffectObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSAreaOfEffectObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ushort m_nObjectArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nObjectArrayIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nObjectArrayIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAreaEffectId {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nAreaEffectId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nAreaEffectId_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nShape {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nShape_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nShape_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSpellId {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellId_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fRadius {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fRadius_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fRadius_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fWidth {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fWidth_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fWidth_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fLength {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fLength_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_fLength_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_pVertices {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_pVertices_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_pVertices_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidCreator {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidCreator_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidCreator_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLinkedToObj {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLinkedToObj_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLinkedToObj_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastEntered {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastEntered_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastEntered_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidLastLeft {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastLeft_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_oidLastLeft_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSpellSaveDC {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellSaveDC_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellSaveDC_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nSpellLevel {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nSpellLevel_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sScripts {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_sScripts_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_sScripts_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptCalendarDay {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptCalendarDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastHeartbeatScriptTimeOfDay {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nLastHeartbeatScriptTimeOfDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDuration {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDuration_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDuration_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDurationType {
    set {
      NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDurationType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_m_nDurationType_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSAreaOfEffectObject(uint oidId) : this(NWNXLibPINVOKE.new_CNWSAreaOfEffectObject__SWIG_0(oidId), true) {
  }

  public CNWSAreaOfEffectObject() : this(NWNXLibPINVOKE.new_CNWSAreaOfEffectObject__SWIG_1(), true) {
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_AIUpdate(swigCPtr);
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, SWIGTYPE_p_void pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_EventHandler(swigCPtr, nEventId, nCallerObjectId, SWIGTYPE_p_void.getCPtr(pScript), nCalendarDay, nTimeOfDay);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_RemoveFromArea(swigCPtr);
  }

  public int LineSegmentIntersectAreaOfEffect(Vector vStartLine, Vector vEndLine) {
    int ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_LineSegmentIntersectAreaOfEffect(swigCPtr, Vector.getCPtr(vStartLine), Vector.getCPtr(vEndLine));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int InAreaOfEffect(Vector vPosition) {
    int ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_InAreaOfEffect(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadEffect(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_LoadEffect(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int SaveEffect(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_SaveEffect(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public void SetTargetObjID(uint oidValue) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetTargetObjID(swigCPtr, oidValue);
  }

  public void LoadAreaEffect(int nId) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_LoadAreaEffect(swigCPtr, nId);
  }

  public void SetDuration(byte nDurationType, float fDuration) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetDuration__SWIG_0(swigCPtr, nDurationType, fDuration);
  }

  public void SetDuration(byte nDurationType) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetDuration__SWIG_1(swigCPtr, nDurationType);
  }

  public Vector GetPosition() {
    Vector ret = new Vector(NWNXLibPINVOKE.CNWSAreaOfEffectObject_GetPosition(swigCPtr), true);
    return ret;
  }

  public void SetCreator(uint oidObject) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetCreator(swigCPtr, oidObject);
  }

  public override uint GetEffectSpellId() {
    uint ret = NWNXLibPINVOKE.CNWSAreaOfEffectObject_GetEffectSpellId(swigCPtr);
    return ret;
  }

  public override void SetEffectSpellId(uint nSpellId) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetEffectSpellId(swigCPtr, nSpellId);
  }

  public void JumpToPoint(CNWSArea pNewArea, Vector vNewPos) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_JumpToPoint(swigCPtr, CNWSArea.getCPtr(pNewArea), Vector.getCPtr(vNewPos));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MoveToPoint(Vector vNewPos) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_MoveToPoint(swigCPtr, Vector.getCPtr(vNewPos));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetShape(byte nShape, float f1, float f2) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetShape__SWIG_0(swigCPtr, nShape, f1, f2);
  }

  public void SetShape(byte nShape, float f1) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetShape__SWIG_1(swigCPtr, nShape, f1);
  }

  public void SetShape(byte nShape) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_SetShape__SWIG_2(swigCPtr, nShape);
  }

  public void UpdateSubAreas(Vector NewPos) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_UpdateSubAreas__SWIG_0(swigCPtr, Vector.getCPtr(NewPos));
  }

  public void UpdateSubAreas() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_UpdateSubAreas__SWIG_1(swigCPtr);
  }

  public void RemoveFromSubAreas(int bInstantEvents) {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_RemoveFromSubAreas__SWIG_0(swigCPtr, bInstantEvents);
  }

  public void RemoveFromSubAreas() {
    NWNXLibPINVOKE.CNWSAreaOfEffectObject_RemoveFromSubAreas__SWIG_1(swigCPtr);
  }

}

}
