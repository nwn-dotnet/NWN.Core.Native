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

public unsafe class CachedRulesetEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CachedRulesetEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CachedRulesetEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CachedRulesetEntry() {
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
          NWNXLibPINVOKE.delete_CachedRulesetEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CachedRulesetEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CachedRulesetEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CachedRulesetEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CachedRulesetEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CachedRulesetEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(CachedRulesetEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CachedRulesetEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CachedRulesetEntry left, CachedRulesetEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CachedRulesetEntry left, CachedRulesetEntry right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoString s {
    set {
      NWNXLibPINVOKE.CachedRulesetEntry_s_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CachedRulesetEntry_s_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int i {
    set {
      NWNXLibPINVOKE.CachedRulesetEntry_i_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CachedRulesetEntry_i_get(swigCPtr);
      return ret;
    } 
  }

  public float f {
    set {
      NWNXLibPINVOKE.CachedRulesetEntry_f_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CachedRulesetEntry_f_get(swigCPtr);
      return ret;
    } 
  }

  public CachedRulesetEntry() : this(NWNXLibPINVOKE.new_CachedRulesetEntry(), true) {
  }

}

}
