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

public class CWalkHitInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CWalkHitInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CWalkHitInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CWalkHitInfo() {
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

  public int m_nFailureReason {
    set {
      NWNXLibPINVOKE.CWalkHitInfo_m_nFailureReason_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CWalkHitInfo_m_nFailureReason_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_vIntersectedAt {
    set {
      NWNXLibPINVOKE.CWalkHitInfo_m_vIntersectedAt_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CWalkHitInfo_m_vIntersectedAt_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector m_vNormalOfIntersectedLine {
    set {
      NWNXLibPINVOKE.CWalkHitInfo_m_vNormalOfIntersectedLine_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CWalkHitInfo_m_vNormalOfIntersectedLine_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector m_vVertex1 {
    set {
      NWNXLibPINVOKE.CWalkHitInfo_m_vVertex1_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CWalkHitInfo_m_vVertex1_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector m_vVertex2 {
    set {
      NWNXLibPINVOKE.CWalkHitInfo_m_vVertex2_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CWalkHitInfo_m_vVertex2_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int m_nIntersectionType {
    set {
      NWNXLibPINVOKE.CWalkHitInfo_m_nIntersectionType_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CWalkHitInfo_m_nIntersectionType_get(swigCPtr);
      return ret;
    } 
  }

}

}
