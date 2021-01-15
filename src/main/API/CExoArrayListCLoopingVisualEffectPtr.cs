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

public class CExoArrayListCLoopingVisualEffectPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCLoopingVisualEffectPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCLoopingVisualEffectPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCLoopingVisualEffectPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCLoopingVisualEffectPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_p_CLoopingVisualEffect element {
    set {
      NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_element_set(swigCPtr, SWIGTYPE_p_p_CLoopingVisualEffect.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_element_get(swigCPtr);
      SWIGTYPE_p_p_CLoopingVisualEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CLoopingVisualEffect(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCLoopingVisualEffectPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCLoopingVisualEffectPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCLoopingVisualEffectPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCLoopingVisualEffectPtr__SWIG_1(), true) {
  }

  public CExoArrayListCLoopingVisualEffectPtr(CExoArrayListCLoopingVisualEffectPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCLoopingVisualEffectPtr__SWIG_2(CExoArrayListCLoopingVisualEffectPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCLoopingVisualEffectPtr __Assign(CExoArrayListCLoopingVisualEffectPtr list) {
    CExoArrayListCLoopingVisualEffectPtr ret = new CExoArrayListCLoopingVisualEffectPtr(NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr___Assign(swigCPtr, CExoArrayListCLoopingVisualEffectPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_p_CLoopingVisualEffect __Index(int i) {
    SWIGTYPE_p_p_CLoopingVisualEffect ret = new SWIGTYPE_p_p_CLoopingVisualEffect(NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr___Index(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_Pack(swigCPtr);
  }

  public void Add(CLoopingVisualEffect t) {
    NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_Add(swigCPtr, CLoopingVisualEffect.getCPtr(t));
  }

  public void Insert(CLoopingVisualEffect t, int k) {
    NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_Insert(swigCPtr, CLoopingVisualEffect.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_DelIndex(swigCPtr, i);
  }

  public SWIGTYPE_p_p_CLoopingVisualEffect begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_begin__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CLoopingVisualEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CLoopingVisualEffect(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_p_CLoopingVisualEffect end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCLoopingVisualEffectPtr_end__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CLoopingVisualEffect ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CLoopingVisualEffect(cPtr, false);
    return ret;
  }

}

}
