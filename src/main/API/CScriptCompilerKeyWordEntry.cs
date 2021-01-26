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

public class CScriptCompilerKeyWordEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CScriptCompilerKeyWordEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptCompilerKeyWordEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptCompilerKeyWordEntry() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
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

  public bool Equals(CScriptCompilerKeyWordEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptCompilerKeyWordEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptCompilerKeyWordEntry left, CScriptCompilerKeyWordEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptCompilerKeyWordEntry left, CScriptCompilerKeyWordEntry right) {
    return !Equals(left, right);
  }

  public CExoString m_sAlphanumericName {
    set {
      NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_sAlphanumericName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_sAlphanumericName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nHashValue {
    set {
      NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_nHashValue_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_nHashValue_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nNameLength {
    set {
      NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_nNameLength_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_nNameLength_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTokenToTranslate {
    set {
      NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_nTokenToTranslate_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerKeyWordEntry_m_nTokenToTranslate_get(swigCPtr);
      return ret;
    } 
  }

}

}
