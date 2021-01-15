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

public class CExoArrayListCExoStringPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCExoStringPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCExoStringPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCExoStringPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCExoStringPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_p_CExoString element {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoStringPtr_element_set(swigCPtr, SWIGTYPE_p_p_CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_element_get(swigCPtr);
      SWIGTYPE_p_p_CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CExoString(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoStringPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoStringPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCExoStringPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCExoStringPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCExoStringPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCExoStringPtr__SWIG_1(), true) {
  }

  public CExoArrayListCExoStringPtr(CExoArrayListCExoStringPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCExoStringPtr__SWIG_2(CExoArrayListCExoStringPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCExoStringPtr __Assign(CExoArrayListCExoStringPtr list) {
    CExoArrayListCExoStringPtr ret = new CExoArrayListCExoStringPtr(NWNXLibPINVOKE.CExoArrayListCExoStringPtr___Assign(swigCPtr, CExoArrayListCExoStringPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_p_CExoString __Index(int i) {
    SWIGTYPE_p_p_CExoString ret = new SWIGTYPE_p_p_CExoString(NWNXLibPINVOKE.CExoArrayListCExoStringPtr___Index(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCExoStringPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCExoStringPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCExoStringPtr_Pack(swigCPtr);
  }

  public void Add(CExoString t) {
    NWNXLibPINVOKE.CExoArrayListCExoStringPtr_Add(swigCPtr, CExoString.getCPtr(t));
  }

  public void Insert(CExoString t, int k) {
    NWNXLibPINVOKE.CExoArrayListCExoStringPtr_Insert(swigCPtr, CExoString.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCExoStringPtr_DelIndex(swigCPtr, i);
  }

  public SWIGTYPE_p_p_CExoString begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_begin__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CExoString(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_p_CExoString end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_end__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CExoString(cPtr, false);
    return ret;
  }

}

}
