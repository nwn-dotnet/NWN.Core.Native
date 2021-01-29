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

public unsafe class CNWTilePathNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWTilePathNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWTilePathNode(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTilePathNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTilePathNode() {
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
          NWNXLibPINVOKE.delete_CNWTilePathNode(swigCPtr);
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

  public bool Equals(CNWTilePathNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTilePathNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTilePathNode left, CNWTilePathNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTilePathNode left, CNWTilePathNode right) {
    return !Equals(left, right);
  }

  public int m_nRegionNodes {
    set {
      NWNXLibPINVOKE.CNWTilePathNode_m_nRegionNodes_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTilePathNode_m_nRegionNodes_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTileExits {
    set {
      NWNXLibPINVOKE.CNWTilePathNode_m_nTileExits_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTilePathNode_m_nTileExits_get(swigCPtr);
      return ret;
    } 
  }

  public float* m_pfRegionNodes {
    set {
      NWNXLibPINVOKE.CNWTilePathNode_m_pfRegionNodes_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWTilePathNode_m_pfRegionNodes_get(swigCPtr); 
        return (float*)retVal; 
    }

  }

  public float* m_pfTileExits {
    set {
      NWNXLibPINVOKE.CNWTilePathNode_m_pfTileExits_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWTilePathNode_m_pfTileExits_get(swigCPtr); 
        return (float*)retVal; 
    }

  }

  public int* m_pnTileExitRegion {
    set {
      NWNXLibPINVOKE.CNWTilePathNode_m_pnTileExitRegion_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CNWTilePathNode_m_pnTileExitRegion_get(swigCPtr); 
        return (int*)retVal; 
    }

  }

  public CNWTilePathNode() : this(NWNXLibPINVOKE.new_CNWTilePathNode(), true) {
  }

}

}
