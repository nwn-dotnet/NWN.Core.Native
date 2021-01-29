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

public unsafe class CNWTileData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWTileData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWTileData(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileData() {
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
          NWNXLibPINVOKE.delete_CNWTileData(swigCPtr);
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

  public bool Equals(CNWTileData other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileData other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileData left, CNWTileData right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileData left, CNWTileData right) {
    return !Equals(left, right);
  }

  public CExoLinkedListCExoString m_pMethodStringList {
    set {
      NWNXLibPINVOKE.CNWTileData_m_pMethodStringList_set(swigCPtr, CExoLinkedListCExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_pMethodStringList_get(swigCPtr);
      CExoLinkedListCExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCExoString(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSurfaceMesh m_pSurfaceMesh {
    set {
      NWNXLibPINVOKE.CNWTileData_m_pSurfaceMesh_set(swigCPtr, CNWTileSurfaceMesh.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_pSurfaceMesh_get(swigCPtr);
      CNWTileSurfaceMesh ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSurfaceMesh(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_refModel {
    set {
      NWNXLibPINVOKE.CNWTileData_m_refModel_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_refModel_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CResRef m_refMapIcon {
    set {
      NWNXLibPINVOKE.CNWTileData_m_refMapIcon_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_refMapIcon_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public byte m_nNumDoors {
    set {
      NWNXLibPINVOKE.CNWTileData_m_nNumDoors_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTileData_m_nNumDoors_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sCornerTopLeft {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sCornerTopLeft_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sCornerTopLeft_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCornerTopRight {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sCornerTopRight_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sCornerTopRight_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCornerBottomLeft {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sCornerBottomLeft_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sCornerBottomLeft_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCornerBottomRight {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sCornerBottomRight_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sCornerBottomRight_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sEdgeTop {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sEdgeTop_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sEdgeTop_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sEdgeBottom {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sEdgeBottom_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sEdgeBottom_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sEdgeLeft {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sEdgeLeft_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sEdgeLeft_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sEdgeRight {
    set {
      NWNXLibPINVOKE.CNWTileData_m_sEdgeRight_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_m_sEdgeRight_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CNWTileData() : this(NWNXLibPINVOKE.new_CNWTileData(), true) {
  }

  public int AddPropertyMethodString(uint nProperty, CExoString sMethodString) {
    int ret = NWNXLibPINVOKE.CNWTileData_AddPropertyMethodString(swigCPtr, nProperty, CExoString.getCPtr(sMethodString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoLinkedListCExoString GetPropertyMethodStringList(uint nProperty) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileData_GetPropertyMethodStringList(swigCPtr, nProperty);
    CExoLinkedListCExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCExoString(cPtr, false);
    return ret;
  }

  public CResRef GetModelResRef() {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWTileData_GetModelResRef(swigCPtr), true);
    return ret;
  }

  public void SetModelResRef(CResRef refModel) {
    NWNXLibPINVOKE.CNWTileData_SetModelResRef(swigCPtr, CResRef.getCPtr(refModel));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CResRef GetMapIcon() {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CNWTileData_GetMapIcon(swigCPtr), true);
    return ret;
  }

  public void SetMapIcon(CResRef refMapIcon) {
    NWNXLibPINVOKE.CNWTileData_SetMapIcon(swigCPtr, CResRef.getCPtr(refMapIcon));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCornerType(byte nCorner, CExoString sType, int bHeight) {
    NWNXLibPINVOKE.CNWTileData_SetCornerType(swigCPtr, nCorner, CExoString.getCPtr(sType), bHeight);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetCornerType(byte nCorner) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWTileData_GetCornerType(swigCPtr, nCorner), true);
    return ret;
  }

  public void SetEdgeType(byte nEdge, CExoString sType) {
    NWNXLibPINVOKE.CNWTileData_SetEdgeType(swigCPtr, nEdge, CExoString.getCPtr(sType));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetEdgeType(byte nEdge) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWTileData_GetEdgeType(swigCPtr, nEdge), true);
    return ret;
  }

}

}
