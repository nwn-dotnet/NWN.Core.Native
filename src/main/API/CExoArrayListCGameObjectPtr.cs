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

public unsafe class CExoArrayListCGameObjectPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCGameObjectPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCGameObjectPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCGameObjectPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCGameObjectPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCGameObjectPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCGameObjectPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCGameObjectPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCGameObjectPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCGameObjectPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCGameObjectPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCGameObjectPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCGameObjectPtr left, CExoArrayListCGameObjectPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCGameObjectPtr left, CExoArrayListCGameObjectPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCGameObjectPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCGameObjectPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCGameObjectPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCGameObjectPtr__SWIG_1(), true) {
  }

  public CExoArrayListCGameObjectPtr(CExoArrayListCGameObjectPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCGameObjectPtr__SWIG_2(CExoArrayListCGameObjectPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCGameObjectPtr _OpAssign(CExoArrayListCGameObjectPtr list) {
    CExoArrayListCGameObjectPtr ret = new CExoArrayListCGameObjectPtr(NWNXLibPINVOKE.CExoArrayListCGameObjectPtr__OpAssign(swigCPtr, CExoArrayListCGameObjectPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCGameObjectPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_Pack(swigCPtr);
  }

  public void Add(ICGameObject t) {
    NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_Add(swigCPtr, t == null ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : t.GetInterfaceCPtr());
  }

  public void Insert(ICGameObject t, int k) {
    NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_Insert(swigCPtr, t == null ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : t.GetInterfaceCPtr(), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCGameObjectPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
