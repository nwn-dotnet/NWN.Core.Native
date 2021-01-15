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

public class CNWTileSurfaceMeshNodeFace : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWTileSurfaceMeshNodeFace(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSurfaceMeshNodeFace obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSurfaceMeshNodeFace() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_int pnUselessPointer1 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer1_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer1_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int pnUselessPointer2 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer2_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer2_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int pnUselessPointer3 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer3_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer3_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int vertexindices {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_vertexindices_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_vertexindices_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public int s {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_s_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_s_get(swigCPtr);
      return ret;
    } 
  }

  public int matid {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_matid_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_matid_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int neighbors {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_neighbors_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_neighbors_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public Vector normal {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_normal_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_normal_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public float dist {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_dist_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_dist_get(swigCPtr);
      return ret;
    } 
  }

}

}
