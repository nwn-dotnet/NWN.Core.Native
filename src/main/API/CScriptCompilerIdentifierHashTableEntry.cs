//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class CScriptCompilerIdentifierHashTableEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptCompilerIdentifierHashTableEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptCompilerIdentifierHashTableEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptCompilerIdentifierHashTableEntry() {
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

  public uint m_nHashValue {
    set {
      NWNXLibPINVOKE.CScriptCompilerIdentifierHashTableEntry_m_nHashValue_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerIdentifierHashTableEntry_m_nHashValue_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nIdentifierType {
    set {
      NWNXLibPINVOKE.CScriptCompilerIdentifierHashTableEntry_m_nIdentifierType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerIdentifierHashTableEntry_m_nIdentifierType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nIdentifierIndex {
    set {
      NWNXLibPINVOKE.CScriptCompilerIdentifierHashTableEntry_m_nIdentifierIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerIdentifierHashTableEntry_m_nIdentifierIndex_get(swigCPtr);
      return ret;
    } 
  }

}

}
