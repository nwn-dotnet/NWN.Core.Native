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

public class CNWSScriptVarTable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSScriptVarTable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSScriptVarTable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSScriptVarTable() {
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

  public SWIGTYPE_p_std__unordered_mapT_CExoString_CNWSScriptVar_t m_vars {
    set {
      NWNXLibPINVOKE.CNWSScriptVarTable_m_vars_set(swigCPtr, SWIGTYPE_p_std__unordered_mapT_CExoString_CNWSScriptVar_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSScriptVarTable_m_vars_get(swigCPtr);
      SWIGTYPE_p_std__unordered_mapT_CExoString_CNWSScriptVar_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__unordered_mapT_CExoString_CNWSScriptVar_t(cPtr, false);
      return ret;
    } 
  }

  public CNWSCreature m_pCreature {
    set {
      NWNXLibPINVOKE.CNWSScriptVarTable_m_pCreature_set(swigCPtr, CNWSCreature.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSScriptVarTable_m_pCreature_get(swigCPtr);
      CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
      return ret;
    } 
  }

  public int GetInt(CExoString sVarName) {
    int ret = NWNXLibPINVOKE.CNWSScriptVarTable_GetInt(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetFloat(CExoString sVarName) {
    float ret = NWNXLibPINVOKE.CNWSScriptVarTable_GetFloat(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString GetString(CExoString sVarName) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWSScriptVarTable_GetString(swigCPtr, CExoString.getCPtr(sVarName)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetObject(CExoString sVarName) {
    uint ret = NWNXLibPINVOKE.CNWSScriptVarTable_GetObject(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CScriptLocation GetLocation(CExoString sVarName) {
    CScriptLocation ret = new CScriptLocation(NWNXLibPINVOKE.CNWSScriptVarTable_GetLocation(swigCPtr, CExoString.getCPtr(sVarName)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetInt(CExoString sVarName, int nValue, int bLoading) {
    NWNXLibPINVOKE.CNWSScriptVarTable_SetInt__SWIG_0(swigCPtr, CExoString.getCPtr(sVarName), nValue, bLoading);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetInt(CExoString sVarName, int nValue) {
    NWNXLibPINVOKE.CNWSScriptVarTable_SetInt__SWIG_1(swigCPtr, CExoString.getCPtr(sVarName), nValue);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFloat(CExoString sVarName, float fValue) {
    NWNXLibPINVOKE.CNWSScriptVarTable_SetFloat(swigCPtr, CExoString.getCPtr(sVarName), fValue);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetString(CExoString sVarName, CExoString sValue) {
    NWNXLibPINVOKE.CNWSScriptVarTable_SetString(swigCPtr, CExoString.getCPtr(sVarName), CExoString.getCPtr(sValue));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetObject(CExoString sVarName, uint oValue) {
    NWNXLibPINVOKE.CNWSScriptVarTable_SetObject(swigCPtr, CExoString.getCPtr(sVarName), oValue);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLocation(CExoString sVarName, CScriptLocation lValue) {
    NWNXLibPINVOKE.CNWSScriptVarTable_SetLocation(swigCPtr, CExoString.getCPtr(sVarName), CScriptLocation.getCPtr(lValue));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DestroyInt(CExoString sVarName) {
    NWNXLibPINVOKE.CNWSScriptVarTable_DestroyInt(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DestroyFloat(CExoString sVarName) {
    NWNXLibPINVOKE.CNWSScriptVarTable_DestroyFloat(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DestroyString(CExoString sVarName) {
    NWNXLibPINVOKE.CNWSScriptVarTable_DestroyString(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DestroyObject(CExoString sVarName) {
    NWNXLibPINVOKE.CNWSScriptVarTable_DestroyObject(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DestroyLocation(CExoString sVarName) {
    NWNXLibPINVOKE.CNWSScriptVarTable_DestroyLocation(swigCPtr, CExoString.getCPtr(sVarName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadVarTable(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSScriptVarTable_LoadVarTable(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public void SaveVarTable(CResGFF pRes, CResStruct pStruct) {
    NWNXLibPINVOKE.CNWSScriptVarTable_SaveVarTable(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
  }

  public CNWSScriptVar MatchIndex(CExoString sVarName, uint nVarType, int bCreate) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSScriptVarTable_MatchIndex(swigCPtr, CExoString.getCPtr(sVarName), nVarType, bCreate);
    CNWSScriptVar ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSScriptVar(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DeleteIndex(CExoString sVarName, uint nVarType) {
    NWNXLibPINVOKE.CNWSScriptVarTable_DeleteIndex(swigCPtr, CExoString.getCPtr(sVarName), nVarType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
