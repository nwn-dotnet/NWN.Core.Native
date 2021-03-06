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

public unsafe class CExoArrayListCWorldJournalEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCWorldJournalEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCWorldJournalEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCWorldJournalEntry() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCWorldJournalEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCWorldJournalEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCWorldJournalEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCWorldJournalEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCWorldJournalEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCWorldJournalEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCWorldJournalEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCWorldJournalEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCWorldJournalEntry left, CExoArrayListCWorldJournalEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCWorldJournalEntry left, CExoArrayListCWorldJournalEntry right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CWorldJournalEntry element {
    set {
      NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_element_set(swigCPtr, CWorldJournalEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_element_get(swigCPtr);
      CWorldJournalEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldJournalEntry(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCWorldJournalEntry(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCWorldJournalEntry__SWIG_0(s), true) {
  }

  public CExoArrayListCWorldJournalEntry() : this(NWNXLibPINVOKE.new_CExoArrayListCWorldJournalEntry__SWIG_1(), true) {
  }

  public CExoArrayListCWorldJournalEntry(CExoArrayListCWorldJournalEntry list) : this(NWNXLibPINVOKE.new_CExoArrayListCWorldJournalEntry__SWIG_2(CExoArrayListCWorldJournalEntry.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCWorldJournalEntry _OpAssign(CExoArrayListCWorldJournalEntry list) {
    CExoArrayListCWorldJournalEntry ret = new CExoArrayListCWorldJournalEntry(NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry__OpAssign(swigCPtr, CExoArrayListCWorldJournalEntry.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CWorldJournalEntry _OpIndex(int i) {
    CWorldJournalEntry ret = new CWorldJournalEntry(NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_Pack(swigCPtr);
  }

  public void Add(CWorldJournalEntry t) {
    NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_Add(swigCPtr, CWorldJournalEntry.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CWorldJournalEntry t, int k) {
    NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_Insert(swigCPtr, CWorldJournalEntry.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_DelIndex(swigCPtr, i);
  }

  public CWorldJournalEntry begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_begin(swigCPtr);
    CWorldJournalEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldJournalEntry(cPtr, false);
    return ret;
  }

  public CWorldJournalEntry end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCWorldJournalEntry_end(swigCPtr);
    CWorldJournalEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CWorldJournalEntry(cPtr, false);
    return ret;
  }

}

}
