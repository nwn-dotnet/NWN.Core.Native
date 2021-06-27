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

public unsafe class CNWTileSurfaceMeshAABBNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWTileSurfaceMeshAABBNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSurfaceMeshAABBNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSurfaceMeshAABBNode() {
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
          NWNXLibPINVOKE.delete_CNWTileSurfaceMeshAABBNode(swigCPtr);
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

  public static unsafe implicit operator void*(CNWTileSurfaceMeshAABBNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWTileSurfaceMeshAABBNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWTileSurfaceMeshAABBNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWTileSurfaceMeshAABBNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWTileSurfaceMeshAABBNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWTileSurfaceMeshAABBNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSurfaceMeshAABBNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSurfaceMeshAABBNode left, CNWTileSurfaceMeshAABBNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSurfaceMeshAABBNode left, CNWTileSurfaceMeshAABBNode right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public Vector vBoundBoxMin {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMin_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMin_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector vBoundBoxMax {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMax_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMax_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int nTriangleId {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleId_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleId_get(swigCPtr);
      return retVal;
    }

  }

  public int nTriangleList {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleList_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleList_get(swigCPtr);
      return retVal;
    }

  }

  public int nDirection {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nDirection_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nDirection_get(swigCPtr);
      return retVal;
    }

  }

  public CNWTileSurfaceMeshAABBNode pLeft {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pLeft_set(swigCPtr, CNWTileSurfaceMeshAABBNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pLeft_get(swigCPtr);
      CNWTileSurfaceMeshAABBNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSurfaceMeshAABBNode(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSurfaceMeshAABBNode pRight {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pRight_set(swigCPtr, CNWTileSurfaceMeshAABBNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pRight_get(swigCPtr);
      CNWTileSurfaceMeshAABBNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSurfaceMeshAABBNode(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSurfaceMeshAABBNode() : this(NWNXLibPINVOKE.new_CNWTileSurfaceMeshAABBNode(), true) {
  }

}

}
