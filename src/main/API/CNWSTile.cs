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

public class CNWSTile : CNWTile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CNWSTile(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSTile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSTile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSTile(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CNWTileData m_pTileData {
    set {
      NWNXLibPINVOKE.CNWSTile_m_pTileData_set(swigCPtr, CNWTileData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTile_m_pTileData_get(swigCPtr);
      CNWTileData ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileData(cPtr, false);
      return ret;
    } 
  }

  public int m_nTriggers {
    set {
      NWNXLibPINVOKE.CNWSTile_m_nTriggers_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_nTriggers_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTriggerSize {
    set {
      NWNXLibPINVOKE.CNWSTile_m_nTriggerSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_nTriggerSize_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int m_poidTriggers {
    set {
      NWNXLibPINVOKE.CNWSTile_m_poidTriggers_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTile_m_poidTriggers_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_CExoArrayListT_unsigned_int_t m_aDoors {
    set {
      NWNXLibPINVOKE.CNWSTile_m_aDoors_set(swigCPtr, SWIGTYPE_p_CExoArrayListT_unsigned_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTile_m_aDoors_get(swigCPtr);
      SWIGTYPE_p_CExoArrayListT_unsigned_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoArrayListT_unsigned_int_t(cPtr, false);
      return ret;
    } 
  }

  public int m_bMainLightColorChange {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bMainLightColorChange_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bMainLightColorChange_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSourceLightColorChange {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bSourceLightColorChange_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bSourceLightColorChange_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bFlaggedAsProblem {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bFlaggedAsProblem_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bFlaggedAsProblem_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bHasPlaceableWithWalkMesh {
    set {
      NWNXLibPINVOKE.CNWSTile_m_bHasPlaceableWithWalkMesh_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSTile_m_bHasPlaceableWithWalkMesh_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSTile() : this(NWNXLibPINVOKE.new_CNWSTile(), true) {
  }

  public void AddTrigger(uint oidTrigger) {
    NWNXLibPINVOKE.CNWSTile_AddTrigger(swigCPtr, oidTrigger);
  }

  public int ClearLineOfSight(int nDirectionHeuristic, Vector vSource, Vector vTarget, Vector vImpact) {
    int ret = NWNXLibPINVOKE.CNWSTile_ClearLineOfSight(swigCPtr, nDirectionHeuristic, Vector.getCPtr(vSource), Vector.getCPtr(vTarget), Vector.getCPtr(vImpact));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ClippedLineSegmentWalkable(float fStartX, float fStartY, float fEndX, float fEndY, SWIGTYPE_p_float fClipStartX, SWIGTYPE_p_float fClipStartY, SWIGTYPE_p_float fClipEndX, SWIGTYPE_p_float fClipEndY, SWIGTYPE_p_float fClipMinZ, SWIGTYPE_p_float fClipMaxZ) {
    int ret = NWNXLibPINVOKE.CNWSTile_ClippedLineSegmentWalkable(swigCPtr, fStartX, fStartY, fEndX, fEndY, SWIGTYPE_p_float.getCPtr(fClipStartX), SWIGTYPE_p_float.getCPtr(fClipStartY), SWIGTYPE_p_float.getCPtr(fClipEndX), SWIGTYPE_p_float.getCPtr(fClipEndY), SWIGTYPE_p_float.getCPtr(fClipMinZ), SWIGTYPE_p_float.getCPtr(fClipMaxZ));
    return ret;
  }

  public int ComputeClippedLineSegment(Vector vSource, Vector vTarget, Vector vClipSource, Vector vClipTarget) {
    int ret = NWNXLibPINVOKE.CNWSTile_ComputeClippedLineSegment(swigCPtr, Vector.getCPtr(vSource), Vector.getCPtr(vTarget), Vector.getCPtr(vClipSource), Vector.getCPtr(vClipTarget));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ComputeHeight(Vector vPosition) {
    float ret = NWNXLibPINVOKE.CNWSTile_ComputeHeight(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int FindClosestRegion(float fX, float fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_FindClosestRegion(swigCPtr, fX, fY);
    return ret;
  }

  public int GetExit(int nExit, SWIGTYPE_p_float fX, SWIGTYPE_p_float fY, SWIGTYPE_p_int nRegion) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetExit(swigCPtr, nExit, SWIGTYPE_p_float.getCPtr(fX), SWIGTYPE_p_float.getCPtr(fY), SWIGTYPE_p_int.getCPtr(nRegion));
    return ret;
  }

  public int GetExitNumber(float fX, float fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetExitNumber(swigCPtr, fX, fY);
    return ret;
  }

  public int GetRegionCoords(int nRegion, SWIGTYPE_p_float fX, SWIGTYPE_p_float fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetRegionCoords(swigCPtr, nRegion, SWIGTYPE_p_float.getCPtr(fX), SWIGTYPE_p_float.getCPtr(fY));
    return ret;
  }

  public int GetRegionEntrance(float fX, float fY) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetRegionEntrance(swigCPtr, fX, fY);
    return ret;
  }

  public int GetSurfaceMaterial(Vector vPosition) {
    int ret = NWNXLibPINVOKE.CNWSTile_GetSurfaceMaterial(swigCPtr, Vector.getCPtr(vPosition));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWTileData GetTileData() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSTile_GetTileData(swigCPtr);
    CNWTileData ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileData(cPtr, false);
    return ret;
  }

  public int GetTotalExits() {
    int ret = NWNXLibPINVOKE.CNWSTile_GetTotalExits(swigCPtr);
    return ret;
  }

  public int IntersectLineSegments(float fX1, float fY1, float fX2, float fY2, float fX3, float fY3, float fX4, float fY4, SWIGTYPE_p_float fXIntersect, SWIGTYPE_p_float fYIntersect) {
    int ret = NWNXLibPINVOKE.CNWSTile_IntersectLineSegments(swigCPtr, fX1, fY1, fX2, fY2, fX3, fY3, fX4, fY4, SWIGTYPE_p_float.getCPtr(fXIntersect), SWIGTYPE_p_float.getCPtr(fYIntersect));
    return ret;
  }

  public int InTrigger(Vector vPosition, SWIGTYPE_p_CExoArrayListT_unsigned_int_t aTriggers) {
    int ret = NWNXLibPINVOKE.CNWSTile_InTrigger(swigCPtr, Vector.getCPtr(vPosition), SWIGTYPE_p_CExoArrayListT_unsigned_int_t.getCPtr(aTriggers));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef GetWalkMesh() {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWSTile_GetWalkMesh(swigCPtr), true);
    return ret;
  }

  public int LoadWalkMesh() {
    int ret = NWNXLibPINVOKE.CNWSTile_LoadWalkMesh(swigCPtr);
    return ret;
  }

  public int NoNonWalkPolysOnTile(float fSourceX, float fSourceY, float fTargetX, float fTargetY, float fMinZ, float fMaxZ, float fPersonalSpace, int bTestSinglePoint) {
    int ret = NWNXLibPINVOKE.CNWSTile_NoNonWalkPolysOnTile__SWIG_0(swigCPtr, fSourceX, fSourceY, fTargetX, fTargetY, fMinZ, fMaxZ, fPersonalSpace, bTestSinglePoint);
    return ret;
  }

  public int NoNonWalkPolysOnTile(float fSourceX, float fSourceY, float fTargetX, float fTargetY, float fMinZ, float fMaxZ, float fPersonalSpace) {
    int ret = NWNXLibPINVOKE.CNWSTile_NoNonWalkPolysOnTile__SWIG_1(swigCPtr, fSourceX, fSourceY, fTargetX, fTargetY, fMinZ, fMaxZ, fPersonalSpace);
    return ret;
  }

  public uint PlotIntraTilePath(SWIGTYPE_p_CNWArea pWalkGeometry, CPathfindInformation pPathfindInformation, float fCurrentIntraTileX, float fCurrentIntraTileY, float fInterTileStartX, float fInterTileStartY, uint nMaxTimeAllowed) {
    uint ret = NWNXLibPINVOKE.CNWSTile_PlotIntraTilePath(swigCPtr, SWIGTYPE_p_CNWArea.getCPtr(pWalkGeometry), CPathfindInformation.getCPtr(pPathfindInformation), fCurrentIntraTileX, fCurrentIntraTileY, fInterTileStartX, fInterTileStartY, nMaxTimeAllowed);
    return ret;
  }

  public void SetTileData(CNWTileData pTileData) {
    NWNXLibPINVOKE.CNWSTile_SetTileData(swigCPtr, CNWTileData.getCPtr(pTileData));
  }

  public virtual new void SetMainLightColor(byte nMainLight1Color, byte nMainLight2Color) {
    NWNXLibPINVOKE.CNWSTile_SetMainLightColor(swigCPtr, nMainLight1Color, nMainLight2Color);
  }

  public virtual new void SetSourceLightColor(byte nSourceLight1Color, byte nSourceLight2Color) {
    NWNXLibPINVOKE.CNWSTile_SetSourceLightColor(swigCPtr, nSourceLight1Color, nSourceLight2Color);
  }

}

}
