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

public unsafe class CItemPropertyApplierRemover : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CItemPropertyApplierRemover(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CItemPropertyApplierRemover obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CItemPropertyApplierRemover() {
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
          NWNXLibPINVOKE.delete_CItemPropertyApplierRemover(swigCPtr);
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

  public static unsafe implicit operator void*(CItemPropertyApplierRemover self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CItemPropertyApplierRemover FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CItemPropertyApplierRemover((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CItemPropertyApplierRemover FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CItemPropertyApplierRemover(pointer, memoryOwn) : null;
  }

  public bool Equals(CItemPropertyApplierRemover other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CItemPropertyApplierRemover other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CItemPropertyApplierRemover left, CItemPropertyApplierRemover right) {
    return Equals(left, right);
  }

  public static bool operator !=(CItemPropertyApplierRemover left, CItemPropertyApplierRemover right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public virtual void InitializeItemProperties() {
    NWNXLibPINVOKE.CItemPropertyApplierRemover_InitializeItemProperties(swigCPtr);
  }

  public virtual int OnItemPropertyApplied(CNWSItem pItem, CNWItemProperty pItemProperty, CNWSCreature pTargetCreature, uint nTargetInventorySlot, int bLoadingGame) {
    int ret = NWNXLibPINVOKE.CItemPropertyApplierRemover_OnItemPropertyApplied(swigCPtr, CNWSItem.getCPtr(pItem), CNWItemProperty.getCPtr(pItemProperty), CNWSCreature.getCPtr(pTargetCreature), nTargetInventorySlot, bLoadingGame);
    return ret;
  }

  public virtual int OnItemPropertyRemoved(CNWSItem pItem, CNWItemProperty pItemProperty, CNWSCreature pTargetCreature, uint nTargetInventorySlot) {
    int ret = NWNXLibPINVOKE.CItemPropertyApplierRemover_OnItemPropertyRemoved(swigCPtr, CNWSItem.getCPtr(pItem), CNWItemProperty.getCPtr(pItemProperty), CNWSCreature.getCPtr(pTargetCreature), nTargetInventorySlot);
    return ret;
  }

}

}
