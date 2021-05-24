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

public unsafe class CScriptCompilerKeyWordEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptCompilerKeyWordEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
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
          NWNXLibPINVOKE.delete_CScriptCompilerKeyWordEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CScriptCompilerKeyWordEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CScriptCompilerKeyWordEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CScriptCompilerKeyWordEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CScriptCompilerKeyWordEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CScriptCompilerKeyWordEntry(pointer, memoryOwn) : null;
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
/*@SWIG@*/
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

  public CScriptCompilerKeyWordEntry() : this(NWNXLibPINVOKE.new_CScriptCompilerKeyWordEntry(), true) {
  }

}

}
