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

public unsafe class CExoArrayListNWPlayerCharacterListPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListNWPlayerCharacterListPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListNWPlayerCharacterListPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListNWPlayerCharacterListPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListNWPlayerCharacterListPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListNWPlayerCharacterListPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListNWPlayerCharacterListPtr FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListNWPlayerCharacterListPtr((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListNWPlayerCharacterListPtr FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListNWPlayerCharacterListPtr(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListNWPlayerCharacterListPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListNWPlayerCharacterListPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListNWPlayerCharacterListPtr left, CExoArrayListNWPlayerCharacterListPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListNWPlayerCharacterListPtr left, CExoArrayListNWPlayerCharacterListPtr right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_element_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListNWPlayerCharacterListPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListNWPlayerCharacterListPtr__SWIG_0(s), true) {
  }

  public CExoArrayListNWPlayerCharacterListPtr() : this(NWNXLibPINVOKE.new_CExoArrayListNWPlayerCharacterListPtr__SWIG_1(), true) {
  }

  public CExoArrayListNWPlayerCharacterListPtr(CExoArrayListNWPlayerCharacterListPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListNWPlayerCharacterListPtr__SWIG_2(CExoArrayListNWPlayerCharacterListPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListNWPlayerCharacterListPtr _OpAssign(CExoArrayListNWPlayerCharacterListPtr list) {
    CExoArrayListNWPlayerCharacterListPtr ret = new CExoArrayListNWPlayerCharacterListPtr(NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr__OpAssign(swigCPtr, CExoArrayListNWPlayerCharacterListPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_Pack(swigCPtr);
  }

  public void Add(NWPlayerCharacterList_st t) {
    NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_Add(swigCPtr, NWPlayerCharacterList_st.getCPtr(t));
  }

  public void Insert(NWPlayerCharacterList_st t, int k) {
    NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_Insert(swigCPtr, NWPlayerCharacterList_st.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListNWPlayerCharacterListPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
