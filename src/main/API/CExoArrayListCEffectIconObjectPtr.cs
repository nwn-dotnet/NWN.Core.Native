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

public unsafe class CExoArrayListCEffectIconObjectPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCEffectIconObjectPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCEffectIconObjectPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCEffectIconObjectPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCEffectIconObjectPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCEffectIconObjectPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCEffectIconObjectPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCEffectIconObjectPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCEffectIconObjectPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCEffectIconObjectPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCEffectIconObjectPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCEffectIconObjectPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCEffectIconObjectPtr left, CExoArrayListCEffectIconObjectPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCEffectIconObjectPtr left, CExoArrayListCEffectIconObjectPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCEffectIconObjectPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCEffectIconObjectPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCEffectIconObjectPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCEffectIconObjectPtr__SWIG_1(), true) {
  }

  public CExoArrayListCEffectIconObjectPtr(CExoArrayListCEffectIconObjectPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCEffectIconObjectPtr__SWIG_2(CExoArrayListCEffectIconObjectPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCEffectIconObjectPtr _OpAssign(CExoArrayListCEffectIconObjectPtr list) {
    CExoArrayListCEffectIconObjectPtr ret = new CExoArrayListCEffectIconObjectPtr(NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr__OpAssign(swigCPtr, CExoArrayListCEffectIconObjectPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_Pack(swigCPtr);
  }

  public void Add(CEffectIconObject t) {
    NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_Add(swigCPtr, CEffectIconObject.getCPtr(t));
  }

  public void Insert(CEffectIconObject t, int k) {
    NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_Insert(swigCPtr, CEffectIconObject.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCEffectIconObjectPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
