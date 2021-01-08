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

public class CVirtualMachineCmdImplementer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVirtualMachineCmdImplementer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineCmdImplementer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineCmdImplementer() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineCmdImplementer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int m_bValidObjectRunScript {
    set {
      NWNXLibPINVOKE.CVirtualMachineCmdImplementer_m_bValidObjectRunScript_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_m_bValidObjectRunScript_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidObjectRunScript {
    set {
      NWNXLibPINVOKE.CVirtualMachineCmdImplementer_m_oidObjectRunScript_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_m_oidObjectRunScript_get(swigCPtr);
      return ret;
    } 
  }

  public virtual void InitializeCommands() {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_InitializeCommands(swigCPtr);
  }

  public virtual int ExecuteCommand(int nCommandId, int nParameters) {
    int ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_ExecuteCommand(swigCPtr, nCommandId, nParameters);
    return ret;
  }

  public virtual void RunScriptCallback(CExoString sFileName) {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_RunScriptCallback(swigCPtr, CExoString.getCPtr(sFileName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReportError(CExoString sFileName, int nError) {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_ReportError(swigCPtr, CExoString.getCPtr(sFileName), nError);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void CreateGameDefinedStructure(int nUserDefinedType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_CreateGameDefinedStructure(swigCPtr, nUserDefinedType);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void DestroyGameDefinedStructure(int nUserDefinedType, SWIGTYPE_p_void pStructureToDelete) {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_DestroyGameDefinedStructure(swigCPtr, nUserDefinedType, SWIGTYPE_p_void.getCPtr(pStructureToDelete));
  }

  public virtual int GetEqualGameDefinedStructure(int nUserDefinedType, SWIGTYPE_p_void pStructure1, SWIGTYPE_p_void pStructure2) {
    int ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_GetEqualGameDefinedStructure(swigCPtr, nUserDefinedType, SWIGTYPE_p_void.getCPtr(pStructure1), SWIGTYPE_p_void.getCPtr(pStructure2));
    return ret;
  }

  public virtual SWIGTYPE_p_void CopyGameDefinedStructure(int nUserDefinedType, SWIGTYPE_p_void pStructureSrc) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_CopyGameDefinedStructure(swigCPtr, nUserDefinedType, SWIGTYPE_p_void.getCPtr(pStructureSrc));
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual int SaveGameDefinedStructure(int nEngineStructure, SWIGTYPE_p_void pStructure, CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_SaveGameDefinedStructure(swigCPtr, nEngineStructure, SWIGTYPE_p_void.getCPtr(pStructure), CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public virtual int LoadGameDefinedStructure(int nEngineStructure, SWIGTYPE_p_p_void pStructure, CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_LoadGameDefinedStructure(swigCPtr, nEngineStructure, SWIGTYPE_p_p_void.getCPtr(pStructure), CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public virtual CExoString GetGameDefinedStructureName(int nEngineStructure) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CVirtualMachineCmdImplementer_GetGameDefinedStructureName(swigCPtr, nEngineStructure), true);
    return ret;
  }

  public virtual CExoString GetDebuggerLabelName(int nDebuggerLabel) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CVirtualMachineCmdImplementer_GetDebuggerLabelName(swigCPtr, nDebuggerLabel), true);
    return ret;
  }

  public virtual void GetEngineStructureWatchView(int nEngineStructure, SWIGTYPE_p_void pEngineStructure, SWIGTYPE_p_int nEntries, SWIGTYPE_p_p_CExoString m_ppNames, SWIGTYPE_p_p_CExoString m_ppValues) {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_GetEngineStructureWatchView(swigCPtr, nEngineStructure, SWIGTYPE_p_void.getCPtr(pEngineStructure), SWIGTYPE_p_int.getCPtr(nEntries), SWIGTYPE_p_p_CExoString.getCPtr(m_ppNames), SWIGTYPE_p_p_CExoString.getCPtr(m_ppValues));
  }

  public virtual void GetObjectWatchView(uint oidObject, SWIGTYPE_p_int nEntries, SWIGTYPE_p_p_CExoString m_ppNames, SWIGTYPE_p_p_CExoString m_ppValues) {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_GetObjectWatchView(swigCPtr, oidObject, SWIGTYPE_p_int.getCPtr(nEntries), SWIGTYPE_p_p_CExoString.getCPtr(m_ppNames), SWIGTYPE_p_p_CExoString.getCPtr(m_ppValues));
  }

  public virtual int DebugGUIStart() {
    int ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_DebugGUIStart(swigCPtr);
    return ret;
  }

  public virtual void DebugGUIStop() {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_DebugGUIStop(swigCPtr);
  }

  public virtual void DebugGUISendMessageTo(string pMsg, int nSize) {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_DebugGUISendMessageTo(swigCPtr, pMsg, nSize);
  }

  public virtual int DebugGUIGetMessageFrom(SWIGTYPE_p_p_char pMsg, SWIGTYPE_p_int nSize) {
    int ret = NWNXLibPINVOKE.CVirtualMachineCmdImplementer_DebugGUIGetMessageFrom(swigCPtr, SWIGTYPE_p_p_char.getCPtr(pMsg), SWIGTYPE_p_int.getCPtr(nSize));
    return ret;
  }

  public virtual void DebugGUIUpdate() {
    NWNXLibPINVOKE.CVirtualMachineCmdImplementer_DebugGUIUpdate(swigCPtr);
  }

}

}
