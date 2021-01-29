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

public unsafe class CScriptCompilerVarStackEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CScriptCompilerVarStackEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CScriptCompilerVarStackEntry(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptCompilerVarStackEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptCompilerVarStackEntry() {
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
          NWNXLibPINVOKE.delete_CScriptCompilerVarStackEntry(swigCPtr);
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

  public bool Equals(CScriptCompilerVarStackEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptCompilerVarStackEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptCompilerVarStackEntry left, CScriptCompilerVarStackEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptCompilerVarStackEntry left, CScriptCompilerVarStackEntry right) {
    return !Equals(left, right);
  }

  public CExoString m_psVarName {
    set {
      NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_psVarName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_psVarName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nVarType {
    set {
      NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_nVarType_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_nVarType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nVarLevel {
    set {
      NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_nVarLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_nVarLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nVarRunTimeLocation {
    set {
      NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_nVarRunTimeLocation_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_nVarRunTimeLocation_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sVarStructureName {
    set {
      NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_sVarStructureName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptCompilerVarStackEntry_m_sVarStructureName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CScriptCompilerVarStackEntry() : this(NWNXLibPINVOKE.new_CScriptCompilerVarStackEntry(), true) {
  }

}

}
