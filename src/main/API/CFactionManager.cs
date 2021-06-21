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

public unsafe class CFactionManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFactionManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFactionManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CFactionManager() {
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
          NWNXLibPINVOKE.delete_CFactionManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CFactionManager self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CFactionManager FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CFactionManager((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CFactionManager FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CFactionManager(pointer, memoryOwn) : null;
  }

  public bool Equals(CFactionManager other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CFactionManager other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CFactionManager left, CFactionManager right) {
    return Equals(left, right);
  }

  public static bool operator !=(CFactionManager left, CFactionManager right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CNWSFaction m_pDefaultFactionDefender {
    set {
      NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionDefender_set(swigCPtr, CNWSFaction.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionDefender_get(swigCPtr);
      CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
      return ret;
    } 
  }

  public CNWSFaction m_pDefaultFactionCommoner {
    set {
      NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionCommoner_set(swigCPtr, CNWSFaction.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionCommoner_get(swigCPtr);
      CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
      return ret;
    } 
  }

  public CNWSFaction m_pDefaultFactionMerchant {
    set {
      NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionMerchant_set(swigCPtr, CNWSFaction.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionMerchant_get(swigCPtr);
      CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
      return ret;
    } 
  }

  public CNWSFaction m_pDefaultFactionHostile {
    set {
      NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionHostile_set(swigCPtr, CNWSFaction.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionHostile_get(swigCPtr);
      CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
      return ret;
    } 
  }

  public CNWSFaction m_pDefaultFactionPC {
    set {
      NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionPC_set(swigCPtr, CNWSFaction.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_m_pDefaultFactionPC_get(swigCPtr);
      CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
      return ret;
    } 
  }

  public int m_nNPCFactionCount {
    set {
      NWNXLibPINVOKE.CFactionManager_m_nNPCFactionCount_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CFactionManager_m_nNPCFactionCount_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListInt32 m_pNPCReputations {
    set {
      NWNXLibPINVOKE.CFactionManager_m_pNPCReputations_set(swigCPtr, CExoArrayListInt32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_m_pNPCReputations_get(swigCPtr);
      CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCNWSFactionPtr m_pFactionList {
    set {
      NWNXLibPINVOKE.CFactionManager_m_pFactionList_set(swigCPtr, CExoArrayListCNWSFactionPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_m_pFactionList_get(swigCPtr);
      CExoArrayListCNWSFactionPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSFactionPtr(cPtr, false);
      return ret;
    } 
  }

  public CFactionManager() : this(NWNXLibPINVOKE.new_CFactionManager(), true) {
  }

  public CNWSFaction GetFaction(int nFactionId) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_GetFaction(swigCPtr, nFactionId);
    CNWSFaction ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSFaction(cPtr, false);
    return ret;
  }

  public int GetIsNPCFaction(int nFactionId) {
    int ret = NWNXLibPINVOKE.CFactionManager_GetIsNPCFaction(swigCPtr, nFactionId);
    return ret;
  }

  public int GetNPCFactionReputation(int nFactionId, int nSubjectFactionId) {
    int ret = NWNXLibPINVOKE.CFactionManager_GetNPCFactionReputation(swigCPtr, nFactionId, nSubjectFactionId);
    return ret;
  }

  public void SetNPCFactionReputation(int nFactionId, int nSubjectFactionId, int nReputation) {
    NWNXLibPINVOKE.CFactionManager_SetNPCFactionReputation(swigCPtr, nFactionId, nSubjectFactionId, nReputation);
  }

  public CExoArrayListInt32 GetDefaultPCReputation() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CFactionManager_GetDefaultPCReputation(swigCPtr);
    CExoArrayListInt32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListInt32(cPtr, false);
    return ret;
  }

  public void DeleteFaction(int nFactionId) {
    NWNXLibPINVOKE.CFactionManager_DeleteFaction(swigCPtr, nFactionId);
  }

  public int GetFactionIdByName(CExoString name) {
    int ret = NWNXLibPINVOKE.CFactionManager_GetFactionIdByName(swigCPtr, CExoString.getCPtr(name));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadFactions(CResGFF pRes, CResList cFactionList) {
    int ret = NWNXLibPINVOKE.CFactionManager_LoadFactions(swigCPtr, CResGFF.getCPtr(pRes), CResList.getCPtr(cFactionList));
    return ret;
  }

  public int LoadReputations(CResGFF pRes, CResList cReputationList) {
    int ret = NWNXLibPINVOKE.CFactionManager_LoadReputations(swigCPtr, CResGFF.getCPtr(pRes), CResList.getCPtr(cReputationList));
    return ret;
  }

  public void CreateDefaultFactions() {
    NWNXLibPINVOKE.CFactionManager_CreateDefaultFactions(swigCPtr);
  }

  public int SaveFactions(CResGFF pRes, CResList pList) {
    int ret = NWNXLibPINVOKE.CFactionManager_SaveFactions(swigCPtr, CResGFF.getCPtr(pRes), CResList.getCPtr(pList));
    return ret;
  }

  public int SaveReputations(CResGFF pRes, CResList pList) {
    int ret = NWNXLibPINVOKE.CFactionManager_SaveReputations(swigCPtr, CResGFF.getCPtr(pRes), CResList.getCPtr(pList));
    return ret;
  }

}

}
