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

public unsafe class CExoLinkedListCNWSDialogPlayer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCNWSDialogPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCNWSDialogPlayer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCNWSDialogPlayer() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCNWSDialogPlayer(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCNWSDialogPlayer self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCNWSDialogPlayer FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCNWSDialogPlayer((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCNWSDialogPlayer FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCNWSDialogPlayer(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCNWSDialogPlayer other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCNWSDialogPlayer other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCNWSDialogPlayer left, CExoLinkedListCNWSDialogPlayer right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCNWSDialogPlayer left, CExoLinkedListCNWSDialogPlayer right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCNWSDialogPlayer() : this(NWNXLibPINVOKE.new_CExoLinkedListCNWSDialogPlayer(), true) {
  }

  public CExoLinkedListNode AddHead(CNWSDialogPlayer Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_AddHead(swigCPtr, CNWSDialogPlayer.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CNWSDialogPlayer Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_AddTail(swigCPtr, CNWSDialogPlayer.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CNWSDialogPlayer Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_AddAfter(swigCPtr, CNWSDialogPlayer.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CNWSDialogPlayer Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_AddBefore(swigCPtr, CNWSDialogPlayer.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_Count(swigCPtr);
    return ret;
  }

  public CNWSDialogPlayer GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

  public CNWSDialogPlayer GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_GetHead(swigCPtr);
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CNWSDialogPlayer GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

  public CNWSDialogPlayer GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

  public CNWSDialogPlayer GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_GetTail(swigCPtr);
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_IsEmpty(swigCPtr);
    return ret;
  }

  public CNWSDialogPlayer RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_RemoveHead(swigCPtr);
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

  public CNWSDialogPlayer RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_RemoveTail(swigCPtr);
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

  public CNWSDialogPlayer Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCNWSDialogPlayer_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CNWSDialogPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogPlayer(cPtr, false);
    return ret;
  }

}

}
