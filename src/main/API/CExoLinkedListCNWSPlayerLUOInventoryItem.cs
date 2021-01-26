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

public class CExoLinkedListCNWSPlayerLUOInventoryItem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoLinkedListCNWSPlayerLUOInventoryItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCNWSPlayerLUOInventoryItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCNWSPlayerLUOInventoryItem() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCNWSPlayerLUOInventoryItem(swigCPtr);
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

  public bool Equals(CExoLinkedListCNWSPlayerLUOInventoryItem other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCNWSPlayerLUOInventoryItem other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCNWSPlayerLUOInventoryItem left, CExoLinkedListCNWSPlayerLUOInventoryItem right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCNWSPlayerLUOInventoryItem left, CExoLinkedListCNWSPlayerLUOInventoryItem right) {
    return !Equals(left, right);
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCNWSPlayerLUOInventoryItem() : this(NWNXLibPINVOKE.new_CExoLinkedListCNWSPlayerLUOInventoryItem(), true) {
  }

  public CExoLinkedListNode AddHead(CNWSPlayerLUOInventoryItem Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_AddHead(swigCPtr, CNWSPlayerLUOInventoryItem.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CNWSPlayerLUOInventoryItem Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_AddTail(swigCPtr, CNWSPlayerLUOInventoryItem.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CNWSPlayerLUOInventoryItem Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_AddAfter(swigCPtr, CNWSPlayerLUOInventoryItem.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CNWSPlayerLUOInventoryItem Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_AddBefore(swigCPtr, CNWSPlayerLUOInventoryItem.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_Count(swigCPtr);
    return ret;
  }

  public CNWSPlayerLUOInventoryItem GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    return ret;
  }

  public CNWSPlayerLUOInventoryItem GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_GetHead(swigCPtr);
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CNWSPlayerLUOInventoryItem GetNext(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_GetNext(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSPlayerLUOInventoryItem GetPrev(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_GetPrev(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSPlayerLUOInventoryItem GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_GetTail(swigCPtr);
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_IsEmpty(swigCPtr);
    return ret;
  }

  public CNWSPlayerLUOInventoryItem RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_RemoveHead(swigCPtr);
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    return ret;
  }

  public CNWSPlayerLUOInventoryItem RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_RemoveTail(swigCPtr);
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    return ret;
  }

  public CNWSPlayerLUOInventoryItem Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSPlayerLUOInventoryItem_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSPlayerLUOInventoryItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLUOInventoryItem(cPtr, false);
    return ret;
  }

}

}
