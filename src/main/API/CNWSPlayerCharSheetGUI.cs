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

public class CNWSPlayerCharSheetGUI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerCharSheetGUI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerCharSheetGUI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerCharSheetGUI() {
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

  public uint m_oidCreatureDisplayed {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_oidCreatureDisplayed_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_oidCreatureDisplayed_get(swigCPtr);
      return ret;
    } 
  }

  public char m_nActivePanel {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_nActivePanel_set(swigCPtr, value);
    } 
    get {
      char ret = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_nActivePanel_get(swigCPtr);
      return ret;
    } 
  }

  public CNWCreatureStatsUpdate m_pLastStatsUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_pLastStatsUpdate_set(swigCPtr, CNWCreatureStatsUpdate.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_pLastStatsUpdate_get(swigCPtr);
      CNWCreatureStatsUpdate ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWCreatureStatsUpdate(cPtr, false);
      return ret;
    } 
  }

  public int m_bForceInitialCharSheetUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_bForceInitialCharSheetUpdate_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_m_bForceInitialCharSheetUpdate_get(swigCPtr);
      return ret;
    } 
  }

  public uint ComputeCharacterSheetUpdateRequired(CNWSPlayer pPlayer) {
    uint ret = NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_ComputeCharacterSheetUpdateRequired(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
    return ret;
  }

  public void SetCreatureDisplayed(uint oidCreature) {
    NWNXLibPINVOKE.CNWSPlayerCharSheetGUI_SetCreatureDisplayed(swigCPtr, oidCreature);
  }

}

}
