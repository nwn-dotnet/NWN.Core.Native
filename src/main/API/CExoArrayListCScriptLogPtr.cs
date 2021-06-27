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

public unsafe class CExoArrayListCScriptLogPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCScriptLogPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCScriptLogPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCScriptLogPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCScriptLogPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCScriptLogPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCScriptLogPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCScriptLogPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCScriptLogPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCScriptLogPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCScriptLogPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCScriptLogPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCScriptLogPtr left, CExoArrayListCScriptLogPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCScriptLogPtr left, CExoArrayListCScriptLogPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCScriptLogPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCScriptLogPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCScriptLogPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCScriptLogPtr__SWIG_1(), true) {
  }

  public CExoArrayListCScriptLogPtr(CExoArrayListCScriptLogPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCScriptLogPtr__SWIG_2(CExoArrayListCScriptLogPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCScriptLogPtr _OpAssign(CExoArrayListCScriptLogPtr list) {
    CExoArrayListCScriptLogPtr ret = new CExoArrayListCScriptLogPtr(NWNXLibPINVOKE.CExoArrayListCScriptLogPtr__OpAssign(swigCPtr, CExoArrayListCScriptLogPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCScriptLogPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_Pack(swigCPtr);
  }

  public void Add(CScriptLog t) {
    NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_Add(swigCPtr, CScriptLog.getCPtr(t));
  }

  public void Insert(CScriptLog t, int k) {
    NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_Insert(swigCPtr, CScriptLog.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCScriptLogPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
