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

public unsafe class CExoArrayListCStoreCustomerPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCStoreCustomerPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCStoreCustomerPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCStoreCustomerPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCStoreCustomerPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CExoArrayListCStoreCustomerPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCStoreCustomerPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCStoreCustomerPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCStoreCustomerPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCStoreCustomerPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCStoreCustomerPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCStoreCustomerPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCStoreCustomerPtr left, CExoArrayListCStoreCustomerPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCStoreCustomerPtr left, CExoArrayListCStoreCustomerPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCStoreCustomerPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCStoreCustomerPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCStoreCustomerPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCStoreCustomerPtr__SWIG_1(), true) {
  }

  public CExoArrayListCStoreCustomerPtr(CExoArrayListCStoreCustomerPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCStoreCustomerPtr__SWIG_2(CExoArrayListCStoreCustomerPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCStoreCustomerPtr _OpAssign(CExoArrayListCStoreCustomerPtr list) {
    CExoArrayListCStoreCustomerPtr ret = new CExoArrayListCStoreCustomerPtr(NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr__OpAssign(swigCPtr, CExoArrayListCStoreCustomerPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Pack(swigCPtr);
  }

  public void Add(CStoreCustomer t) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Add(swigCPtr, CStoreCustomer.getCPtr(t));
  }

  public void Insert(CStoreCustomer t, int k) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_Insert(swigCPtr, CStoreCustomer.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCStoreCustomerPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
