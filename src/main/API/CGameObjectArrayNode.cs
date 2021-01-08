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

public class CGameObjectArrayNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGameObjectArrayNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CGameObjectArrayNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGameObjectArrayNode() {
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

  public uint m_objectId {
    set {
      NWNXLibPINVOKE.CGameObjectArrayNode_m_objectId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CGameObjectArrayNode_m_objectId_get(swigCPtr);
      return ret;
    } 
  }

  public CGameObject m_objectPtr {
    set {
      NWNXLibPINVOKE.CGameObjectArrayNode_m_objectPtr_set(swigCPtr, CGameObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObjectArrayNode_m_objectPtr_get(swigCPtr);
      CGameObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameObject(cPtr, false);
      return ret;
    } 
  }

  public CGameObjectArrayNode m_nextNode {
    set {
      NWNXLibPINVOKE.CGameObjectArrayNode_m_nextNode_set(swigCPtr, CGameObjectArrayNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CGameObjectArrayNode_m_nextNode_get(swigCPtr);
      CGameObjectArrayNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CGameObjectArrayNode(cPtr, false);
      return ret;
    } 
  }

}

}