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

public unsafe class CExoArrayListInt32 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListInt32(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListInt32 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListInt32() {
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
          NWNXLibPINVOKE.delete_CExoArrayListInt32(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListInt32 self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListInt32 FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListInt32((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListInt32 FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListInt32(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListInt32 other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListInt32 other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListInt32 left, CExoArrayListInt32 right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListInt32 left, CExoArrayListInt32 right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int* element {
    set {
      NWNXLibPINVOKE.CExoArrayListInt32_element_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CExoArrayListInt32_element_get(swigCPtr);
      return retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListInt32_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListInt32_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListInt32_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListInt32_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListInt32(int s) : this(NWNXLibPINVOKE.new_CExoArrayListInt32__SWIG_0(s), true) {
  }

  public CExoArrayListInt32() : this(NWNXLibPINVOKE.new_CExoArrayListInt32__SWIG_1(), true) {
  }

  public CExoArrayListInt32(CExoArrayListInt32 list) : this(NWNXLibPINVOKE.new_CExoArrayListInt32__SWIG_2(CExoArrayListInt32.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListInt32 _OpAssign(CExoArrayListInt32 list) {
    CExoArrayListInt32 ret = new CExoArrayListInt32(NWNXLibPINVOKE.CExoArrayListInt32__OpAssign(swigCPtr, CExoArrayListInt32.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int* _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListInt32__OpIndex(swigCPtr, i);
    return (int*)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListInt32_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListInt32_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListInt32_Pack(swigCPtr);
  }

  public void Add(int t) {
    NWNXLibPINVOKE.CExoArrayListInt32_Add(swigCPtr, t);
  }

  public void Insert(int t, int k) {
    NWNXLibPINVOKE.CExoArrayListInt32_Insert(swigCPtr, t, k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListInt32_DelIndex(swigCPtr, i);
  }

  public int* begin() {
    int* retVal = NWNXLibPINVOKE.CExoArrayListInt32_begin(swigCPtr);
    return retVal;
  }

  public int* end() {
    int* retVal = NWNXLibPINVOKE.CExoArrayListInt32_end(swigCPtr);
    return retVal;
  }

}

}
