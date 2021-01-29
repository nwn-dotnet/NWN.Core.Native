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

public unsafe class CNWPlaceableSurfaceMesh : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWPlaceableSurfaceMesh(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWPlaceableSurfaceMesh(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWPlaceableSurfaceMesh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWPlaceableSurfaceMesh() {
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
          NWNXLibPINVOKE.delete_CNWPlaceableSurfaceMesh(swigCPtr);
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

  public bool Equals(CNWPlaceableSurfaceMesh other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWPlaceableSurfaceMesh other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWPlaceableSurfaceMesh left, CNWPlaceableSurfaceMesh right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWPlaceableSurfaceMesh left, CNWPlaceableSurfaceMesh right) {
    return !Equals(left, right);
  }

  public Vector m_pvVertices {
    set {
      NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pvVertices_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pvVertices_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int* m_pnTriangles {
    set {
      NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pnTriangles_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pnTriangles_get(swigCPtr); 
        return (int*)retVal; 
    }

  }

  public int m_nTriangles {
    set {
      NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_nTriangles_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_nTriangles_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nVertices {
    set {
      NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_nVertices_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_nVertices_get(swigCPtr);
      return ret;
    } 
  }

  public int* m_pnTriangleMaterial {
    set {
      NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pnTriangleMaterial_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pnTriangleMaterial_get(swigCPtr); 
        return (int*)retVal; 
    }

  }

  public Vector m_pvActionPoints {
    set {
      NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pvActionPoints_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_m_pvActionPoints_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public CNWPlaceableSurfaceMesh() : this(NWNXLibPINVOKE.new_CNWPlaceableSurfaceMesh(), true) {
  }

  public int LoadWalkMesh(CResRef cWalkMesh) {
    int ret = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_LoadWalkMesh(swigCPtr, CResRef.getCPtr(cWalkMesh));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadWalkMeshString(byte** pInput, uint* nInputSize, byte* pchBuffer, uint nBufferSize) {
    int ret = NWNXLibPINVOKE.CNWPlaceableSurfaceMesh_LoadWalkMeshString(swigCPtr, (global::System.IntPtr)pInput, (global::System.IntPtr)nInputSize, (global::System.IntPtr)pchBuffer, nBufferSize);
    return ret;
  }

}

}
