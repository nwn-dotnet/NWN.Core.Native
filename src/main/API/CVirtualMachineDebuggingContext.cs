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

public class CVirtualMachineDebuggingContext : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachineDebuggingContext(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineDebuggingContext obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineDebuggingContext() {
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

  public int m_bStepInto {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_bStepInto_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_bStepInto_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bStepOver {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_bStepOver_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_bStepOver_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRunToLineNumber {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_bRunToLineNumber_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_bRunToLineNumber_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nLineNumberToRunTo {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_nLineNumberToRunTo_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_nLineNumberToRunTo_get(swigCPtr);
      return ret;
    } 
  }

  public CVirtualMachineDebuggerInstance m_pDebuggerInstance {
    set {
      NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_pDebuggerInstance_set(swigCPtr, CVirtualMachineDebuggerInstance.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineDebuggingContext_m_pDebuggerInstance_get(swigCPtr);
      CVirtualMachineDebuggerInstance ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVirtualMachineDebuggerInstance(cPtr, false);
      return ret;
    } 
  }

}

}
