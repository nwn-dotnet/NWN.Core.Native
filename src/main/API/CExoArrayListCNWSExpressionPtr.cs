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

public unsafe class CExoArrayListCNWSExpressionPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSExpressionPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSExpressionPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSExpressionPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSExpressionPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSExpressionPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSExpressionPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSExpressionPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSExpressionPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSExpressionPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSExpressionPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSExpressionPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSExpressionPtr left, CExoArrayListCNWSExpressionPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSExpressionPtr left, CExoArrayListCNWSExpressionPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCNWSExpressionPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSExpressionPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSExpressionPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSExpressionPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWSExpressionPtr(CExoArrayListCNWSExpressionPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSExpressionPtr__SWIG_2(CExoArrayListCNWSExpressionPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSExpressionPtr _OpAssign(CExoArrayListCNWSExpressionPtr list) {
    CExoArrayListCNWSExpressionPtr ret = new CExoArrayListCNWSExpressionPtr(NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr__OpAssign(swigCPtr, CExoArrayListCNWSExpressionPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_Pack(swigCPtr);
  }

  public void Add(CNWSExpression t) {
    NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_Add(swigCPtr, CNWSExpression.getCPtr(t));
  }

  public void Insert(CNWSExpression t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_Insert(swigCPtr, CNWSExpression.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSExpressionPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
