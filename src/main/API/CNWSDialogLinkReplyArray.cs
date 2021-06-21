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

public unsafe class CNWSDialogLinkReplyArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSDialogLinkReplyArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSDialogLinkReplyArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSDialogLinkReplyArray() {
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
          NWNXLibPINVOKE.delete_CNWSDialogLinkReplyArray(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSDialogLinkReplyArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSDialogLinkReplyArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSDialogLinkReplyArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSDialogLinkReplyArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSDialogLinkReplyArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSDialogLinkReplyArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSDialogLinkReplyArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSDialogLinkReplyArray left, CNWSDialogLinkReplyArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSDialogLinkReplyArray left, CNWSDialogLinkReplyArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CNWSDialogLinkReply this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CNWSDialogLinkReplyArray(int nElements) : this(NWNXLibPINVOKE.new_CNWSDialogLinkReplyArray(nElements), true) {
  }

  public CNWSDialogLinkReply GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogLinkReplyArray_GetItem(swigCPtr, index);
    CNWSDialogLinkReply ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogLinkReply(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CNWSDialogLinkReply value) {
    NWNXLibPINVOKE.CNWSDialogLinkReplyArray_SetItem(swigCPtr, index, CNWSDialogLinkReply.getCPtr(value));
  }

  public static CNWSDialogLinkReplyArray FromPointer(CNWSDialogLinkReply ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogLinkReplyArray_FromPointer(CNWSDialogLinkReply.getCPtr(ptr));
    CNWSDialogLinkReplyArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogLinkReplyArray(cPtr, false);
    return ret;
  }

}

}
