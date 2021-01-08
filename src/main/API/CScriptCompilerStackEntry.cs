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

public class CScriptCompilerStackEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptCompilerStackEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptCompilerStackEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptCompilerStackEntry() {
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

  public int nState {
    set {
      NWNXLibPINVOKE.CScriptCompilerStackEntry_nState_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerStackEntry_nState_get(swigCPtr);
      return ret;
    } 
  }

  public int nRule {
    set {
      NWNXLibPINVOKE.CScriptCompilerStackEntry_nRule_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerStackEntry_nRule_get(swigCPtr);
      return ret;
    } 
  }

  public int nTerm {
    set {
      NWNXLibPINVOKE.CScriptCompilerStackEntry_nTerm_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerStackEntry_nTerm_get(swigCPtr);
      return ret;
    } 
  }

  public CScriptParseTreeNode pCurrentTree {
    set {
      NWNXLibPINVOKE.CScriptCompilerStackEntry_pCurrentTree_set(swigCPtr, CScriptParseTreeNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptCompilerStackEntry_pCurrentTree_get(swigCPtr);
      CScriptParseTreeNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptParseTreeNode(cPtr, false);
      return ret;
    } 
  }

  public CScriptParseTreeNode pReturnTree {
    set {
      NWNXLibPINVOKE.CScriptCompilerStackEntry_pReturnTree_set(swigCPtr, CScriptParseTreeNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CScriptCompilerStackEntry_pReturnTree_get(swigCPtr);
      CScriptParseTreeNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptParseTreeNode(cPtr, false);
      return ret;
    } 
  }

}

}
