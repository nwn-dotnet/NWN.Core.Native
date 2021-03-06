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

public unsafe class CExoArrayListCNWCCMessageDataPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWCCMessageDataPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWCCMessageDataPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWCCMessageDataPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWCCMessageDataPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWCCMessageDataPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWCCMessageDataPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWCCMessageDataPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWCCMessageDataPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWCCMessageDataPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWCCMessageDataPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWCCMessageDataPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWCCMessageDataPtr left, CExoArrayListCNWCCMessageDataPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWCCMessageDataPtr left, CExoArrayListCNWCCMessageDataPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCNWCCMessageDataPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWCCMessageDataPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWCCMessageDataPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWCCMessageDataPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWCCMessageDataPtr(CExoArrayListCNWCCMessageDataPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWCCMessageDataPtr__SWIG_2(CExoArrayListCNWCCMessageDataPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWCCMessageDataPtr _OpAssign(CExoArrayListCNWCCMessageDataPtr list) {
    CExoArrayListCNWCCMessageDataPtr ret = new CExoArrayListCNWCCMessageDataPtr(NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr__OpAssign(swigCPtr, CExoArrayListCNWCCMessageDataPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_Pack(swigCPtr);
  }

  public void Add(CNWCCMessageData t) {
    NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_Add(swigCPtr, CNWCCMessageData.getCPtr(t));
  }

  public void Insert(CNWCCMessageData t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_Insert(swigCPtr, CNWCCMessageData.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWCCMessageDataPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
