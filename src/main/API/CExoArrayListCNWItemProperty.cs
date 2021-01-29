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

public unsafe class CExoArrayListCNWItemProperty : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCNWItemProperty(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCNWItemProperty(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWItemProperty obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWItemProperty() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWItemProperty(swigCPtr);
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

  public bool Equals(CExoArrayListCNWItemProperty other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWItemProperty other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWItemProperty left, CExoArrayListCNWItemProperty right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWItemProperty left, CExoArrayListCNWItemProperty right) {
    return !Equals(left, right);
  }

  public CNWItemProperty element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWItemProperty_element_set(swigCPtr, CNWItemProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWItemProperty_element_get(swigCPtr);
      CNWItemProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWItemProperty(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWItemProperty_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWItemProperty_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWItemProperty_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWItemProperty_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWItemProperty(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWItemProperty__SWIG_0(s), true) {
  }

  public CExoArrayListCNWItemProperty() : this(NWNXLibPINVOKE.new_CExoArrayListCNWItemProperty__SWIG_1(), true) {
  }

  public CExoArrayListCNWItemProperty(CExoArrayListCNWItemProperty list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWItemProperty__SWIG_2(CExoArrayListCNWItemProperty.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWItemProperty _OpAssign(CExoArrayListCNWItemProperty list) {
    CExoArrayListCNWItemProperty ret = new CExoArrayListCNWItemProperty(NWNXLibPINVOKE.CExoArrayListCNWItemProperty__OpAssign(swigCPtr, CExoArrayListCNWItemProperty.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWItemProperty _OpIndex(int i) {
    CNWItemProperty ret = new CNWItemProperty(NWNXLibPINVOKE.CExoArrayListCNWItemProperty__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWItemProperty_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWItemProperty_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWItemProperty_Pack(swigCPtr);
  }

  public void Add(CNWItemProperty t) {
    NWNXLibPINVOKE.CExoArrayListCNWItemProperty_Add(swigCPtr, CNWItemProperty.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CNWItemProperty t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWItemProperty_Insert(swigCPtr, CNWItemProperty.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWItemProperty_DelIndex(swigCPtr, i);
  }

  public CNWItemProperty begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWItemProperty_begin(swigCPtr);
    CNWItemProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWItemProperty(cPtr, false);
    return ret;
  }

  public CNWItemProperty end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWItemProperty_end(swigCPtr);
    CNWItemProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWItemProperty(cPtr, false);
    return ret;
  }

}

}
