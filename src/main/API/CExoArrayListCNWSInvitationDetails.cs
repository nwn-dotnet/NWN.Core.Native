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

public unsafe class CExoArrayListCNWSInvitationDetails : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCNWSInvitationDetails(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCNWSInvitationDetails(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSInvitationDetails obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSInvitationDetails() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSInvitationDetails(swigCPtr);
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

  public bool Equals(CExoArrayListCNWSInvitationDetails other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSInvitationDetails other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSInvitationDetails left, CExoArrayListCNWSInvitationDetails right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSInvitationDetails left, CExoArrayListCNWSInvitationDetails right) {
    return !Equals(left, right);
  }

  public CNWSInvitationDetails element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_element_set(swigCPtr, CNWSInvitationDetails.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_element_get(swigCPtr);
      CNWSInvitationDetails ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSInvitationDetails(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWSInvitationDetails(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSInvitationDetails__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSInvitationDetails() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSInvitationDetails__SWIG_1(), true) {
  }

  public CExoArrayListCNWSInvitationDetails(CExoArrayListCNWSInvitationDetails list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSInvitationDetails__SWIG_2(CExoArrayListCNWSInvitationDetails.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSInvitationDetails _OpAssign(CExoArrayListCNWSInvitationDetails list) {
    CExoArrayListCNWSInvitationDetails ret = new CExoArrayListCNWSInvitationDetails(NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails__OpAssign(swigCPtr, CExoArrayListCNWSInvitationDetails.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSInvitationDetails _OpIndex(int i) {
    CNWSInvitationDetails ret = new CNWSInvitationDetails(NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_Pack(swigCPtr);
  }

  public void Add(CNWSInvitationDetails t) {
    NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_Add(swigCPtr, CNWSInvitationDetails.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CNWSInvitationDetails t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_Insert(swigCPtr, CNWSInvitationDetails.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_DelIndex(swigCPtr, i);
  }

  public CNWSInvitationDetails begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_begin(swigCPtr);
    CNWSInvitationDetails ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSInvitationDetails(cPtr, false);
    return ret;
  }

  public CNWSInvitationDetails end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSInvitationDetails_end(swigCPtr);
    CNWSInvitationDetails ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSInvitationDetails(cPtr, false);
    return ret;
  }

}

}
