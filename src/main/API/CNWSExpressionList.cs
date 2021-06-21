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

public unsafe class CNWSExpressionList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSExpressionList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSExpressionList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSExpressionList() {
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
          NWNXLibPINVOKE.delete_CNWSExpressionList(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSExpressionList self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSExpressionList FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSExpressionList((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSExpressionList FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSExpressionList(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSExpressionList other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSExpressionList other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSExpressionList left, CNWSExpressionList right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSExpressionList left, CNWSExpressionList right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSExpressionNode m_pHead {
    set {
      NWNXLibPINVOKE.CNWSExpressionList_m_pHead_set(swigCPtr, CNWSExpressionNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpressionList_m_pHead_get(swigCPtr);
      CNWSExpressionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSExpressionNode(cPtr, false);
      return ret;
    } 
  }

  public CNWSExpressionNode m_pAfter {
    set {
      NWNXLibPINVOKE.CNWSExpressionList_m_pAfter_set(swigCPtr, CNWSExpressionNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpressionList_m_pAfter_get(swigCPtr);
      CNWSExpressionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSExpressionNode(cPtr, false);
      return ret;
    } 
  }

  public CNWSExpressionNode m_pTail {
    set {
      NWNXLibPINVOKE.CNWSExpressionList_m_pTail_set(swigCPtr, CNWSExpressionNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpressionList_m_pTail_get(swigCPtr);
      CNWSExpressionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSExpressionNode(cPtr, false);
      return ret;
    } 
  }

  public CNWSExpressionList() : this(NWNXLibPINVOKE.new_CNWSExpressionList(), true) {
  }

  public void DeleteList() {
    NWNXLibPINVOKE.CNWSExpressionList_DeleteList(swigCPtr);
  }

  public void AddNode(CNWSExpressionNode pNode) {
    NWNXLibPINVOKE.CNWSExpressionList_AddNode(swigCPtr, CNWSExpressionNode.getCPtr(pNode));
  }

  public void AddNodeToHead(CNWSExpressionNode pNode) {
    NWNXLibPINVOKE.CNWSExpressionList_AddNodeToHead(swigCPtr, CNWSExpressionNode.getCPtr(pNode));
  }

  public void DeleteAlternate(CNWSExpressionNode pNode) {
    NWNXLibPINVOKE.CNWSExpressionList_DeleteAlternate(swigCPtr, CNWSExpressionNode.getCPtr(pNode));
  }

}

}
