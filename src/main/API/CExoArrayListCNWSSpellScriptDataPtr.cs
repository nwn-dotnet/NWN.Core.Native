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

public unsafe class CExoArrayListCNWSSpellScriptDataPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSSpellScriptDataPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSSpellScriptDataPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSSpellScriptDataPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSSpellScriptDataPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSSpellScriptDataPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSSpellScriptDataPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSSpellScriptDataPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSSpellScriptDataPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSSpellScriptDataPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSSpellScriptDataPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSSpellScriptDataPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSSpellScriptDataPtr left, CExoArrayListCNWSSpellScriptDataPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSSpellScriptDataPtr left, CExoArrayListCNWSSpellScriptDataPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWSSpellScriptDataPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSSpellScriptDataPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSSpellScriptDataPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSSpellScriptDataPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWSSpellScriptDataPtr(CExoArrayListCNWSSpellScriptDataPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSSpellScriptDataPtr__SWIG_2(CExoArrayListCNWSSpellScriptDataPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSSpellScriptDataPtr _OpAssign(CExoArrayListCNWSSpellScriptDataPtr list) {
    CExoArrayListCNWSSpellScriptDataPtr ret = new CExoArrayListCNWSSpellScriptDataPtr(NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr__OpAssign(swigCPtr, CExoArrayListCNWSSpellScriptDataPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Pack(swigCPtr);
  }

  public void Add(CNWSSpellScriptData t) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Add(swigCPtr, CNWSSpellScriptData.getCPtr(t));
  }

  public void Insert(CNWSSpellScriptData t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_Insert(swigCPtr, CNWSSpellScriptData.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSSpellScriptDataPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
