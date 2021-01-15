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

public class CExoArrayListCNetLayerPlayerCDKeyInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNetLayerPlayerCDKeyInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNetLayerPlayerCDKeyInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNetLayerPlayerCDKeyInfo() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNetLayerPlayerCDKeyInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CNetLayerPlayerCDKeyInfo element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_element_set(swigCPtr, CNetLayerPlayerCDKeyInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_element_get(swigCPtr);
      CNetLayerPlayerCDKeyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNetLayerPlayerCDKeyInfo(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNetLayerPlayerCDKeyInfo__SWIG_0(s), true) {
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo() : this(NWNXLibPINVOKE.new_CExoArrayListCNetLayerPlayerCDKeyInfo__SWIG_1(), true) {
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo(CExoArrayListCNetLayerPlayerCDKeyInfo list) : this(NWNXLibPINVOKE.new_CExoArrayListCNetLayerPlayerCDKeyInfo__SWIG_2(CExoArrayListCNetLayerPlayerCDKeyInfo.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo __Assign(CExoArrayListCNetLayerPlayerCDKeyInfo list) {
    CExoArrayListCNetLayerPlayerCDKeyInfo ret = new CExoArrayListCNetLayerPlayerCDKeyInfo(NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo___Assign(swigCPtr, CExoArrayListCNetLayerPlayerCDKeyInfo.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNetLayerPlayerCDKeyInfo __Index(int i) {
    CNetLayerPlayerCDKeyInfo ret = new CNetLayerPlayerCDKeyInfo(NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo___Index(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Pack(swigCPtr);
  }

  public void Add(CNetLayerPlayerCDKeyInfo t) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Add(swigCPtr, CNetLayerPlayerCDKeyInfo.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CNetLayerPlayerCDKeyInfo t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_Insert(swigCPtr, CNetLayerPlayerCDKeyInfo.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_DelIndex(swigCPtr, i);
  }

  public CNetLayerPlayerCDKeyInfo begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_begin__SWIG_0(swigCPtr);
    CNetLayerPlayerCDKeyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNetLayerPlayerCDKeyInfo(cPtr, false);
    return ret;
  }

  public CNetLayerPlayerCDKeyInfo end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNetLayerPlayerCDKeyInfo_end__SWIG_0(swigCPtr);
    CNetLayerPlayerCDKeyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNetLayerPlayerCDKeyInfo(cPtr, false);
    return ret;
  }

}

}
