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

public unsafe class CExoArrayListCNWSTagNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWSTagNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSTagNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSTagNode() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSTagNode(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSTagNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoArrayListCNWSTagNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoArrayListCNWSTagNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoArrayListCNWSTagNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoArrayListCNWSTagNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoArrayListCNWSTagNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSTagNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSTagNode left, CExoArrayListCNWSTagNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSTagNode left, CExoArrayListCNWSTagNode right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSTagNode element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSTagNode_element_set(swigCPtr, CNWSTagNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSTagNode_element_get(swigCPtr);
      CNWSTagNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSTagNode(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSTagNode_num_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSTagNode_num_get(swigCPtr);
      return retVal;
    }

  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSTagNode_array_size_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CExoArrayListCNWSTagNode_array_size_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCNWSTagNode(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSTagNode__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSTagNode() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSTagNode__SWIG_1(), true) {
  }

  public CExoArrayListCNWSTagNode(CExoArrayListCNWSTagNode list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSTagNode__SWIG_2(CExoArrayListCNWSTagNode.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSTagNode _OpAssign(CExoArrayListCNWSTagNode list) {
    CExoArrayListCNWSTagNode ret = new CExoArrayListCNWSTagNode(NWNXLibPINVOKE.CExoArrayListCNWSTagNode__OpAssign(swigCPtr, CExoArrayListCNWSTagNode.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNWSTagNode _OpIndex(int i) {
    CNWSTagNode ret = new CNWSTagNode(NWNXLibPINVOKE.CExoArrayListCNWSTagNode__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSTagNode_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSTagNode_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSTagNode_Pack(swigCPtr);
  }

  public void Add(CNWSTagNode t) {
    NWNXLibPINVOKE.CExoArrayListCNWSTagNode_Add(swigCPtr, CNWSTagNode.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(CNWSTagNode t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSTagNode_Insert(swigCPtr, CNWSTagNode.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSTagNode_DelIndex(swigCPtr, i);
  }

  public CNWSTagNode begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSTagNode_begin(swigCPtr);
    CNWSTagNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSTagNode(cPtr, false);
    return ret;
  }

  public CNWSTagNode end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSTagNode_end(swigCPtr);
    CNWSTagNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSTagNode(cPtr, false);
    return ret;
  }

}

}
