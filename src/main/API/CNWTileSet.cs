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

public unsafe class CNWTileSet : global::System.IDisposable {
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
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWTileSet self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWTileSet FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWTileSet((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWTileSet FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWTileSet(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWTileSet other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSet other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSet left, CNWTileSet right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSet left, CNWTileSet right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
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
      float retVal = NWNXLibPINVOKE.CNWTileSet_m_fHeightTransition_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nProperty {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_nProperty_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSet_m_nProperty_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nNumTileData {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_nNumTileData_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSet_m_nNumTileData_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nCurrentTileData {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_nCurrentTileData_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSet_m_nCurrentTileData_get(swigCPtr);
      return retVal;
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
      int retVal = NWNXLibPINVOKE.CNWTileSet_m_bHasGrass_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fGrassDensity {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_fGrassDensity_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWTileSet_m_fGrassDensity_get(swigCPtr);
      return retVal;
    }

  }

  public float m_fGrassHeight {
    set {
      NWNXLibPINVOKE.CNWTileSet_m_fGrassHeight_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWTileSet_m_fGrassHeight_get(swigCPtr);
      return retVal;
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
    float retVal = NWNXLibPINVOKE.CNWTileSet_GetHeightTransition(swigCPtr);
    return retVal;
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
    int retVal = NWNXLibPINVOKE.CNWTileSet_LoadTileSet(swigCPtr);
    return retVal;
  }

  public int ParseLine(byte* pLine) {
    int retVal = NWNXLibPINVOKE.CNWTileSet_ParseLine(swigCPtr, pLine);
    return retVal;
  }

  public int SetTileValue(byte* pVariable, byte* pValue) {
    int retVal = NWNXLibPINVOKE.CNWTileSet_SetTileValue(swigCPtr, pVariable, pValue);
    return retVal;
  }

  public void UnloadTileSet() {
    NWNXLibPINVOKE.CNWTileSet_UnloadTileSet(swigCPtr);
  }

}

}
