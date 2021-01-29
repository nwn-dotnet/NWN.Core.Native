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

public unsafe class CExoLinkedListC2DA : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoLinkedListC2DA(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoLinkedListC2DA(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListC2DA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListC2DA() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListC2DA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(CExoLinkedListC2DA other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListC2DA other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListC2DA left, CExoLinkedListC2DA right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListC2DA left, CExoLinkedListC2DA right) {
    return !Equals(left, right);
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListC2DA_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListC2DA() : this(NWNXLibPINVOKE.new_CExoLinkedListC2DA(), true) {
  }

  public CExoLinkedListNode AddHead(C2DA Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_AddHead(swigCPtr, C2DA.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(C2DA Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_AddTail(swigCPtr, C2DA.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(C2DA Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_AddAfter(swigCPtr, C2DA.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(C2DA Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_AddBefore(swigCPtr, C2DA.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListC2DA_Count(swigCPtr);
    return ret;
  }

  public C2DA GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_GetHead(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public C2DA GetNext(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_GetNext(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public C2DA GetPrev(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_GetPrev(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public C2DA GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_GetTail(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListC2DA_IsEmpty(swigCPtr);
    return ret;
  }

  public C2DA RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_RemoveHead(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_RemoveTail(swigCPtr);
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

  public C2DA Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListC2DA_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    C2DA ret = (cPtr == global::System.IntPtr.Zero) ? null : new C2DA(cPtr, false);
    return ret;
  }

}

}
