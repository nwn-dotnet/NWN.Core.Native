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

public class CNWTileSet : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWTileSet(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSet() {
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
          NWNXLibPINVOKE.delete_CNWTileSet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CResRef m_resrefName {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_resrefName_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSet_m_resrefName_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_cEnvMap {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_cEnvMap_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSet_m_cEnvMap_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public float m_fHeightTransition {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_fHeightTransition_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSet_m_fHeightTransition_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nProperty {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_nProperty_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSet_m_nProperty_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNumTileData {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_nNumTileData_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSet_m_nNumTileData_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCurrentTileData {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_nCurrentTileData_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSet_m_nCurrentTileData_get(swigCPtr);
      return ret;
    } 
  }

  public CNWTileData m_pTileData {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_pTileData_set(swigCPtr, CNWTileData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSet_m_pTileData_get(swigCPtr);
      CNWTileData ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileData(cPtr, false);
      return ret;
    } 
  }

  public int m_bHasGrass {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_bHasGrass_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSet_m_bHasGrass_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fGrassDensity {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_fGrassDensity_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSet_m_fGrassDensity_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fGrassHeight {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_fGrassHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSet_m_fGrassHeight_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_vGrassAmbientColor {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_vGrassAmbientColor_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSet_m_vGrassAmbientColor_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector m_vGrassDiffuseColor {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_vGrassDiffuseColor_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSet_m_vGrassDiffuseColor_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sGrassTexture {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_sGrassTexture_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSet_m_sGrassTexture_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSet(CResRef cResRef, int bSetAutoRequest) : this(NWNXLibPINVOKE.new_CNWTileSet(CResRef.getCPtr(cResRef), bSetAutoRequest), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetCornerType(int nTile, byte nCorner, byte nOrientation) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWTileSet_GetCornerType__SWIG_0(swigCPtr, nTile, nCorner, nOrientation), true);
    return ret;
  }

  public CExoString GetCornerType(int nTile, byte nCorner) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWTileSet_GetCornerType__SWIG_1(swigCPtr, nTile, nCorner), true);
    return ret;
  }

  public CExoString GetEdgeType(int nTile, byte nEdge, byte nOrientation) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWTileSet_GetEdgeType__SWIG_0(swigCPtr, nTile, nEdge, nOrientation), true);
    return ret;
  }

  public CExoString GetEdgeType(int nTile, byte nEdge) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWTileSet_GetEdgeType__SWIG_1(swigCPtr, nTile, nEdge), true);
    return ret;
  }

  public float GetHeightTransition() {
    float ret = NWNXLibPINVOKE.CNWTileSet_GetHeightTransition(swigCPtr);
    return ret;
  }

  public CResRef GetEnvMapResRef() {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWTileSet_GetEnvMapResRef(swigCPtr), true);
    return ret;
  }

  public CNWTileData GetTileData(int nID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSet_GetTileData(swigCPtr, nID);
    CNWTileData ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileData(cPtr, false);
    return ret;
  }

  public int LoadTileSet() {
    int ret = NWNXLibPINVOKE.CNWTileSet_LoadTileSet(swigCPtr);
    return ret;
  }

  public int ParseLine(string pLine) {
    int ret = NWNXLibPINVOKE.CNWTileSet_ParseLine(swigCPtr, pLine);
    return ret;
  }

  public int SetTileValue(string pVariable, string pValue) {
    int ret = NWNXLibPINVOKE.CNWTileSet_SetTileValue(swigCPtr, pVariable, pValue);
    return ret;
  }

  public void UnloadTileSet() {
    NWNXLibPINVOKE.CNWTileSet_UnloadTileSet(swigCPtr);
  }

}

}
