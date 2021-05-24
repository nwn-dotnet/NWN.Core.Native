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

public unsafe class CExoArrayListCNWSPVPEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSPVPEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSPVPEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSPVPEntry() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSPVPEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSPVPEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSPVPEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSPVPEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSPVPEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSPVPEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSPVPEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSPVPEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSPVPEntry left, CExoArrayListCNWSPVPEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSPVPEntry left, CExoArrayListCNWSPVPEntry right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSPVPEntry element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_element_set(swigCPtr, CNWSPVPEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_element_get(swigCPtr);
      CNWSPVPEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPVPEntry(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWSPVPEntry(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPVPEntry__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSPVPEntry() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPVPEntry__SWIG_1(), true) {
  }

  public CExoArrayListCNWSPVPEntry(CExoArrayListCNWSPVPEntry list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSPVPEntry__SWIG_2(CExoArrayListCNWSPVPEntry.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSPVPEntry _OpAssign(CExoArrayListCNWSPVPEntry list) {
    CExoArrayListCNWSPVPEntry ret = new CExoArrayListCNWSPVPEntry(NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry__OpAssign(swigCPtr, CExoArrayListCNWSPVPEntry.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSPVPEntry _OpIndex(int i) {
    CNWSPVPEntry ret = new CNWSPVPEntry(NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_Pack(swigCPtr);
  }

  public void Add(CNWSPVPEntry t) {
    NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_Add(swigCPtr, CNWSPVPEntry.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CNWSPVPEntry t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_Insert(swigCPtr, CNWSPVPEntry.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_DelIndex(swigCPtr, i);
  }

  public CNWSPVPEntry begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_begin(swigCPtr);
    CNWSPVPEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPVPEntry(cPtr, false);
    return ret;
  }

  public CNWSPVPEntry end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSPVPEntry_end(swigCPtr);
    CNWSPVPEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPVPEntry(cPtr, false);
    return ret;
  }

}

}
