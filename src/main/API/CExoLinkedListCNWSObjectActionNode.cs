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

public class CExoLinkedListCNWSObjectActionNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCNWSObjectActionNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCNWSObjectActionNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCNWSObjectActionNode() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCNWSObjectActionNode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCNWSObjectActionNode() : this(NWNXLibPINVOKE.new_CExoLinkedListCNWSObjectActionNode(), true) {
  }

  public CExoLinkedListNode AddHead(CNWSObjectActionNode Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddHead(swigCPtr, CNWSObjectActionNode.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CNWSObjectActionNode Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddTail(swigCPtr, CNWSObjectActionNode.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CNWSObjectActionNode Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddAfter(swigCPtr, CNWSObjectActionNode.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CNWSObjectActionNode Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_AddBefore(swigCPtr, CNWSObjectActionNode.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_Count(swigCPtr);
    return ret;
  }

  public CNWSObjectActionNode GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetHead(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode GetNext(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetNext(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSObjectActionNode GetPrev(SWIGTYPE_p_p_CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetPrev(swigCPtr, SWIGTYPE_p_p_CExoLinkedListNode.getCPtr(Position));
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSObjectActionNode GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetTail(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_IsEmpty(swigCPtr);
    return ret;
  }

  public CNWSObjectActionNode RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_RemoveHead(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_RemoveTail(swigCPtr);
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

  public CNWSObjectActionNode Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSObjectActionNode_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSObjectActionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObjectActionNode(cPtr, false);
    return ret;
  }

}

}
