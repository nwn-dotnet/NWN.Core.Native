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

public class CScriptCompilerStructureFieldEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptCompilerStructureFieldEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptCompilerStructureFieldEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptCompilerStructureFieldEntry() {
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

  public byte m_pchType {
    set {
      NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_pchType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_pchType_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_psStructureName {
    set {
      NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_psStructureName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_psStructureName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_psVarName {
    set {
      NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_psVarName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_psVarName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nLocation {
    set {
      NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_nLocation_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerStructureFieldEntry_m_nLocation_get(swigCPtr);
      return ret;
    } 
  }

}

}
