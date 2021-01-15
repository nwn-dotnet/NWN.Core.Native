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

public class CExoArrayListSSubNetProfilePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListSSubNetProfilePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListSSubNetProfilePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListSSubNetProfilePtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListSSubNetProfilePtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_p_SSubNetProfile element {
    set {
      NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_element_set(swigCPtr, SWIGTYPE_p_p_SSubNetProfile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_element_get(swigCPtr);
      SWIGTYPE_p_p_SSubNetProfile ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_SSubNetProfile(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListSSubNetProfilePtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListSSubNetProfilePtr__SWIG_0(s), true) {
  }

  public CExoArrayListSSubNetProfilePtr() : this(NWNXLibPINVOKE.new_CExoArrayListSSubNetProfilePtr__SWIG_1(), true) {
  }

  public CExoArrayListSSubNetProfilePtr(CExoArrayListSSubNetProfilePtr list) : this(NWNXLibPINVOKE.new_CExoArrayListSSubNetProfilePtr__SWIG_2(CExoArrayListSSubNetProfilePtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListSSubNetProfilePtr __Assign(CExoArrayListSSubNetProfilePtr list) {
    CExoArrayListSSubNetProfilePtr ret = new CExoArrayListSSubNetProfilePtr(NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr___Assign(swigCPtr, CExoArrayListSSubNetProfilePtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_p_SSubNetProfile __Index(int i) {
    SWIGTYPE_p_p_SSubNetProfile ret = new SWIGTYPE_p_p_SSubNetProfile(NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr___Index(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Pack(swigCPtr);
  }

  public void Add(SSubNetProfile t) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Add(swigCPtr, SSubNetProfile.getCPtr(t));
  }

  public void Insert(SSubNetProfile t, int k) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_Insert(swigCPtr, SSubNetProfile.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_DelIndex(swigCPtr, i);
  }

  public SWIGTYPE_p_p_SSubNetProfile begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_begin__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_SSubNetProfile ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_SSubNetProfile(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_p_SSubNetProfile end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListSSubNetProfilePtr_end__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_SSubNetProfile ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_SSubNetProfile(cPtr, false);
    return ret;
  }

}

}
