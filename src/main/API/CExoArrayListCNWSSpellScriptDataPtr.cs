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

public class CExoArrayListCNWSSpellScriptDataPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSSpellScriptDataPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSSpellScriptDataPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSSpellScriptDataPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSSpellScriptDataPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_p_CNWSSpellScriptData element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_element_set(swigCPtr, SWIGTYPE_p_p_CNWSSpellScriptData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_element_get(swigCPtr);
      SWIGTYPE_p_p_CNWSSpellScriptData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CNWSSpellScriptData(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWSSpellScriptDataPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSSpellScriptDataPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSSpellScriptDataPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSSpellScriptDataPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWSSpellScriptDataPtr(CExoArrayListCNWSSpellScriptDataPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSSpellScriptDataPtr__SWIG_2(CExoArrayListCNWSSpellScriptDataPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSSpellScriptDataPtr __Assign(CExoArrayListCNWSSpellScriptDataPtr list) {
    CExoArrayListCNWSSpellScriptDataPtr ret = new CExoArrayListCNWSSpellScriptDataPtr(NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr___Assign(swigCPtr, CExoArrayListCNWSSpellScriptDataPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_p_CNWSSpellScriptData __Index(int i) {
    SWIGTYPE_p_p_CNWSSpellScriptData ret = new SWIGTYPE_p_p_CNWSSpellScriptData(NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr___Index(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Pack(swigCPtr);
  }

  public void Add(CNWSSpellScriptData t) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Add(swigCPtr, CNWSSpellScriptData.getCPtr(t));
  }

  public void Insert(CNWSSpellScriptData t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Insert(swigCPtr, CNWSSpellScriptData.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_DelIndex(swigCPtr, i);
  }

  public SWIGTYPE_p_p_CNWSSpellScriptData begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_begin__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CNWSSpellScriptData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CNWSSpellScriptData(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_p_CNWSSpellScriptData end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_end__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CNWSSpellScriptData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CNWSSpellScriptData(cPtr, false);
    return ret;
  }

}

}
