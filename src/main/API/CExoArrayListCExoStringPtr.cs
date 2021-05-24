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

public unsafe class CExoArrayListCExoStringPtr : global::System.IDisposable {
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
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,26,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CExoArrayListCExoStringPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCExoStringPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCExoStringPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCExoStringPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCExoStringPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCExoStringPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCExoStringPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCExoStringPtr left, CExoArrayListCExoStringPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCExoStringPtr left, CExoArrayListCExoStringPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCExoStringPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_element_get(swigCPtr);
        return (void**)retVal;
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

  public CExoArrayListCExoStringPtr _OpAssign(CExoArrayListCExoStringPtr list) {
    CExoArrayListCExoStringPtr ret = new CExoArrayListCExoStringPtr(NWNXLibPINVOKE.CExoArrayListCExoStringPtr__OpAssign(swigCPtr, CExoArrayListCExoStringPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoStringPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
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

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCExoStringPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
