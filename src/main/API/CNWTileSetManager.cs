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

public class CNWTileSetManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWTileSetManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSetManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSetManager() {
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
          NWNXLibPINVOKE.delete_CNWTileSetManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_p_CNWTileSet m_apTileSets {
    set {
      NWNXLibPINVOKE.CNWTileSetManager_m_apTileSets_set(swigCPtr, SWIGTYPE_p_p_CNWTileSet.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetManager_m_apTileSets_get(swigCPtr);
      SWIGTYPE_p_p_CNWTileSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CNWTileSet(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_anTileSetRegistered {
    set {
      NWNXLibPINVOKE.CNWTileSetManager_m_anTileSetRegistered_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetManager_m_anTileSetRegistered_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_4__p_CNWTilePathNode m_apTileNodes {
    set {
      NWNXLibPINVOKE.CNWTileSetManager_m_apTileNodes_set(swigCPtr, SWIGTYPE_p_a_4__p_CNWTilePathNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetManager_m_apTileNodes_get(swigCPtr);
      SWIGTYPE_p_a_4__p_CNWTilePathNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_4__p_CNWTilePathNode(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSetManager() : this(NWNXLibPINVOKE.new_CNWTileSetManager(), true) {
  }

  public CNWTileSet RegisterTileSet(CResRef resrefTileSet) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetManager_RegisterTileSet(swigCPtr, CResRef.getCPtr(resrefTileSet));
    CNWTileSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSet(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnregisterTileSet(CNWTileSet pTileSet) {
    NWNXLibPINVOKE.CNWTileSetManager_UnregisterTileSet(swigCPtr, CNWTileSet.getCPtr(pTileSet));
  }

  public void InitializeTilePathNodes() {
    NWNXLibPINVOKE.CNWTileSetManager_InitializeTilePathNodes(swigCPtr);
  }

  public void ClearTilePathNodes() {
    NWNXLibPINVOKE.CNWTileSetManager_ClearTilePathNodes(swigCPtr);
  }

  public CNWTilePathNode GetTilePathNode(byte nNodeType, byte nRotation) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetManager_GetTilePathNode(swigCPtr, nNodeType, nRotation);
    CNWTilePathNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTilePathNode(cPtr, false);
    return ret;
  }

  public void ComputePathNodeInformation(byte nPathNode, int nPathNodeOrientation, SWIGTYPE_p_int nRegionNodes, SWIGTYPE_p_int nTileExits, SWIGTYPE_p_p_float pfRegionNodes, SWIGTYPE_p_p_float pfTileExits, SWIGTYPE_p_p_int pnTileExitRegion) {
    NWNXLibPINVOKE.CNWTileSetManager_ComputePathNodeInformation(swigCPtr, nPathNode, nPathNodeOrientation, SWIGTYPE_p_int.getCPtr(nRegionNodes), SWIGTYPE_p_int.getCPtr(nTileExits), SWIGTYPE_p_p_float.getCPtr(pfRegionNodes), SWIGTYPE_p_p_float.getCPtr(pfTileExits), SWIGTYPE_p_p_int.getCPtr(pnTileExitRegion));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ComputePathNodeRotation(int nOrientation, SWIGTYPE_p_float fX, SWIGTYPE_p_float fY) {
    NWNXLibPINVOKE.CNWTileSetManager_ComputePathNodeRotation(swigCPtr, nOrientation, SWIGTYPE_p_float.getCPtr(fX), SWIGTYPE_p_float.getCPtr(fY));
  }

}

}
