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

public unsafe class CGameEffectApplierRemover : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGameEffectApplierRemover(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CGameEffectApplierRemover obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGameEffectApplierRemover() {
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
          NWNXLibPINVOKE.delete_CGameEffectApplierRemover(swigCPtr);
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

  public static unsafe implicit operator void*(CGameEffectApplierRemover self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CGameEffectApplierRemover FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CGameEffectApplierRemover((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CGameEffectApplierRemover FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CGameEffectApplierRemover(pointer, memoryOwn) : null;
  }

  public bool Equals(CGameEffectApplierRemover other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CGameEffectApplierRemover other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CGameEffectApplierRemover left, CGameEffectApplierRemover right) {
    return Equals(left, right);
  }

  public static bool operator !=(CGameEffectApplierRemover left, CGameEffectApplierRemover right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public virtual void InitializeEffects() {
    NWNXLibPINVOKE.CGameEffectApplierRemover_InitializeEffects(swigCPtr);
  }

  public virtual int OnEffectApplied(CNWSObject object_, CGameEffect effect, int bLoadingGame) {
    int ret = NWNXLibPINVOKE.CGameEffectApplierRemover_OnEffectApplied__SWIG_0(swigCPtr, CNWSObject.getCPtr(object_), CGameEffect.getCPtr(effect), bLoadingGame);
    return ret;
  }

  public virtual int OnEffectApplied(CNWSObject object_, CGameEffect effect) {
    int ret = NWNXLibPINVOKE.CGameEffectApplierRemover_OnEffectApplied__SWIG_1(swigCPtr, CNWSObject.getCPtr(object_), CGameEffect.getCPtr(effect));
    return ret;
  }

  public virtual int OnEffectRemoved(CNWSObject object_, CGameEffect effect) {
    int ret = NWNXLibPINVOKE.CGameEffectApplierRemover_OnEffectRemoved(swigCPtr, CNWSObject.getCPtr(object_), CGameEffect.getCPtr(effect));
    return ret;
  }

}

}
