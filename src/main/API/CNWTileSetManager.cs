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

public unsafe class CNWTileSetManager : global::System.IDisposable {
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
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWTileSetManager self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWTileSetManager FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWTileSetManager((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWTileSetManager FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWTileSetManager(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWTileSetManager other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSetManager other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSetManager left, CNWTileSetManager right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSetManager left, CNWTileSetManager right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWTileSetPtrArray m_apTileSets {
    set {
      NWNXLibPINVOKE.CNWTileSetManager_m_apTileSets_set(swigCPtr, CNWTileSetPtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetManager_m_apTileSets_get(swigCPtr);;
        CNWTileSetPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSetPtrArray(cPtr, false);
        return ret;
    }

  }

  public NativeArray<int> m_anTileSetRegistered {
    set {
      NWNXLibPINVOKE.CNWTileSetManager_m_anTileSetRegistered_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWTileSetManager_m_anTileSetRegistered_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 100);

      return retVal; // int[100]
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

  public void ComputePathNodeInformation(byte nPathNode, int nPathNodeOrientation, int* nRegionNodes, int* nTileExits, float** pfRegionNodes, float** pfTileExits, int** pnTileExitRegion) {
    NWNXLibPINVOKE.CNWTileSetManager_ComputePathNodeInformation(swigCPtr, nPathNode, nPathNodeOrientation, (global::System.IntPtr)nRegionNodes, (global::System.IntPtr)nTileExits, (global::System.IntPtr)pfRegionNodes, (global::System.IntPtr)pfTileExits, (global::System.IntPtr)pnTileExitRegion);
  }

  public void ComputePathNodeRotation(int nOrientation, float* fX, float* fY) {
    NWNXLibPINVOKE.CNWTileSetManager_ComputePathNodeRotation(swigCPtr, nOrientation, (global::System.IntPtr)fX, (global::System.IntPtr)fY);
  }

}

}
