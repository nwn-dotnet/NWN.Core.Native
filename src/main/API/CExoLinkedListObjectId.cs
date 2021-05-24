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

public unsafe class CExoLinkedListObjectId : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListObjectId(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListObjectId obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListObjectId() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListObjectId(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListObjectId self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListObjectId FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListObjectId((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListObjectId FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListObjectId(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListObjectId other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListObjectId other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListObjectId left, CExoLinkedListObjectId right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListObjectId left, CExoLinkedListObjectId right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListObjectId_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListObjectId_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListObjectId() : this(NWNXLibPINVOKE.new_CExoLinkedListObjectId(), true) {
  }

  public CExoLinkedListNode AddHead(uint* Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListObjectId_AddHead(swigCPtr, (global::System.IntPtr)Object);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(uint* Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListObjectId_AddTail(swigCPtr, (global::System.IntPtr)Object);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(uint* Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListObjectId_AddAfter(swigCPtr, (global::System.IntPtr)Object, CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(uint* Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListObjectId_AddBefore(swigCPtr, (global::System.IntPtr)Object, CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint ret = NWNXLibPINVOKE.CExoLinkedListObjectId_Count(swigCPtr);
    return ret;
  }

  public uint* GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    return (uint*)retVal;
  }

  public uint* GetHead() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_GetHead(swigCPtr);
    return (uint*)retVal;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListObjectId_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint* GetNext(void** Position) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_GetNext(swigCPtr, (global::System.IntPtr)Position);
    return (uint*)retVal;
  }

  public uint* GetPrev(void** Position) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    return (uint*)retVal;
  }

  public uint* GetTail() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_GetTail(swigCPtr);
    return (uint*)retVal;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListObjectId_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoLinkedListObjectId_IsEmpty(swigCPtr);
    return ret;
  }

  public uint* RemoveHead() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_RemoveHead(swigCPtr);
    return (uint*)retVal;
  }

  public uint* RemoveTail() {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_RemoveTail(swigCPtr);
    return (uint*)retVal;
  }

  public uint* Remove(CExoLinkedListNode Position) {
    global::System.IntPtr retVal = NWNXLibPINVOKE.CExoLinkedListObjectId_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    return (uint*)retVal;
  }

}

}
