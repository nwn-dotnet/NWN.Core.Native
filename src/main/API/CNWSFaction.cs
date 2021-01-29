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

public unsafe class CNWSFaction : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSFaction(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSFaction(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSFaction obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSFaction() {
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
          NWNXLibPINVOKE.delete_CNWSFaction(swigCPtr);
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

  public bool Equals(CNWSFaction other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSFaction other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSFaction left, CNWSFaction right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSFaction left, CNWSFaction right) {
    return !Equals(left, right);
  }

  public CExoArrayListObjectId m_listFactionMembers {
    set {
      NWNXLibPINVOKE.CNWSFaction_m_listFactionMembers_set(swigCPtr, CExoArrayListObjectId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSFaction_m_listFactionMembers_get(swigCPtr);
      CExoArrayListObjectId ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListObjectId(cPtr, false);
      return ret;
    } 
  }

  public int m_nFactionId {
    set {
      NWNXLibPINVOKE.CNWSFaction_m_nFactionId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSFaction_m_nFactionId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nParentFactionId {
    set {
      NWNXLibPINVOKE.CNWSFaction_m_nParentFactionId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSFaction_m_nParentFactionId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nMemberListArrayIndex {
    set {
      NWNXLibPINVOKE.CNWSFaction_m_nMemberListArrayIndex_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSFaction_m_nMemberListArrayIndex_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sFactionName {
    set {
      NWNXLibPINVOKE.CNWSFaction_m_sFactionName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSFaction_m_sFactionName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bGlobalReaction {
    set {
      NWNXLibPINVOKE.CNWSFaction_m_bGlobalReaction_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSFaction_m_bGlobalReaction_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSFaction() : this(NWNXLibPINVOKE.new_CNWSFaction__SWIG_0(), true) {
  }

  public CNWSFaction(uint oidLeaderID) : this(NWNXLibPINVOKE.new_CNWSFaction__SWIG_1(oidLeaderID), true) {
  }

  public void Initialise() {
    NWNXLibPINVOKE.CNWSFaction_Initialise(swigCPtr);
  }

  public void AddMember(uint oidNewMemberID, int bInPostProcess) {
    NWNXLibPINVOKE.CNWSFaction_AddMember__SWIG_0(swigCPtr, oidNewMemberID, bInPostProcess);
  }

  public void AddMember(uint oidNewMemberID) {
    NWNXLibPINVOKE.CNWSFaction_AddMember__SWIG_1(swigCPtr, oidNewMemberID);
  }

  public void AttemptJoin(uint oidNewMemberID) {
    NWNXLibPINVOKE.CNWSFaction_AttemptJoin(swigCPtr, oidNewMemberID);
  }

  public int AttemptRemove(uint oidRemoveeID, uint oidRemoverID) {
    int ret = NWNXLibPINVOKE.CNWSFaction_AttemptRemove(swigCPtr, oidRemoveeID, oidRemoverID);
    return ret;
  }

  public uint GetMemberList(uint** pMemberIDs) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetMemberList(swigCPtr, (global::System.IntPtr)pMemberIDs);
    return ret;
  }

  public int InviteMember(uint oidNewMemberID, uint oidInviterPlayerID) {
    int ret = NWNXLibPINVOKE.CNWSFaction_InviteMember(swigCPtr, oidNewMemberID, oidInviterPlayerID);
    return ret;
  }

  public int GetIsInvited(uint oidCreatureID) {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetIsInvited(swigCPtr, oidCreatureID);
    return ret;
  }

  public void RemoveMember(uint oidMemberID) {
    NWNXLibPINVOKE.CNWSFaction_RemoveMember(swigCPtr, oidMemberID);
  }

  public void ChangeMemberId(uint oidOld, uint oidNew) {
    NWNXLibPINVOKE.CNWSFaction_ChangeMemberId(swigCPtr, oidOld, oidNew);
  }

  public void SendChatMessage(uint oidSpeaker, CExoString sSpeakerMessage) {
    NWNXLibPINVOKE.CNWSFaction_SendChatMessage(swigCPtr, oidSpeaker, CExoString.getCPtr(sSpeakerMessage));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SendFactionUpdateList() {
    NWNXLibPINVOKE.CNWSFaction_SendFactionUpdateList(swigCPtr);
  }

  public void SendFactionUpdateAdd(uint oidAddedMemberID) {
    NWNXLibPINVOKE.CNWSFaction_SendFactionUpdateAdd(swigCPtr, oidAddedMemberID);
  }

  public void SendFactionUpdateRemove(uint oidRemovedMemberID) {
    NWNXLibPINVOKE.CNWSFaction_SendFactionUpdateRemove(swigCPtr, oidRemovedMemberID);
  }

  public uint GetWeakestMember(uint oidReferenceFactionMember, int bMustBeVisible) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetWeakestMember__SWIG_0(swigCPtr, oidReferenceFactionMember, bMustBeVisible);
    return ret;
  }

  public uint GetWeakestMember(uint oidReferenceFactionMember) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetWeakestMember__SWIG_1(swigCPtr, oidReferenceFactionMember);
    return ret;
  }

  public uint GetStrongestMember(uint oidReferenceFactionMember, int bMustBeVisible) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetStrongestMember__SWIG_0(swigCPtr, oidReferenceFactionMember, bMustBeVisible);
    return ret;
  }

  public uint GetStrongestMember(uint oidReferenceFactionMember) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetStrongestMember__SWIG_1(swigCPtr, oidReferenceFactionMember);
    return ret;
  }

  public uint GetMostDamagedMember(uint oidReferenceFactionMember, int bMustBeVisible) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetMostDamagedMember__SWIG_0(swigCPtr, oidReferenceFactionMember, bMustBeVisible);
    return ret;
  }

  public uint GetMostDamagedMember(uint oidReferenceFactionMember) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetMostDamagedMember__SWIG_1(swigCPtr, oidReferenceFactionMember);
    return ret;
  }

  public uint GetLeastDamagedMember(uint oidReferenceFactionMember, int bMustBeVisible) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetLeastDamagedMember__SWIG_0(swigCPtr, oidReferenceFactionMember, bMustBeVisible);
    return ret;
  }

  public uint GetLeastDamagedMember(uint oidReferenceFactionMember) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetLeastDamagedMember__SWIG_1(swigCPtr, oidReferenceFactionMember);
    return ret;
  }

  public int GetGold() {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetGold(swigCPtr);
    return ret;
  }

  public int GetAverageReputation(uint oidSubject) {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetAverageReputation(swigCPtr, oidSubject);
    return ret;
  }

  public int GetAverageGoodEvilAlignment() {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetAverageGoodEvilAlignment(swigCPtr);
    return ret;
  }

  public int GetAverageLawChaosAlignment() {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetAverageLawChaosAlignment(swigCPtr);
    return ret;
  }

  public int GetAverageLevel() {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetAverageLevel(swigCPtr);
    return ret;
  }

  public int GetAverageXP() {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetAverageXP(swigCPtr);
    return ret;
  }

  public int GetMostFrequentClass() {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetMostFrequentClass(swigCPtr);
    return ret;
  }

  public uint GetWorstAC(uint oidReferenceFactionMember, int bMustBeVisible) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetWorstAC__SWIG_0(swigCPtr, oidReferenceFactionMember, bMustBeVisible);
    return ret;
  }

  public uint GetWorstAC(uint oidReferenceFactionMember) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetWorstAC__SWIG_1(swigCPtr, oidReferenceFactionMember);
    return ret;
  }

  public uint GetBestAC(uint oidReferenceFactionMember, int bMustBeVisible) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetBestAC__SWIG_0(swigCPtr, oidReferenceFactionMember, bMustBeVisible);
    return ret;
  }

  public uint GetBestAC(uint oidReferenceFactionMember) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetBestAC__SWIG_1(swigCPtr, oidReferenceFactionMember);
    return ret;
  }

  public int GetCreatureInParty(uint oidCreature) {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetCreatureInParty(swigCPtr, oidCreature);
    return ret;
  }

  public int GetSingletonParty() {
    int ret = NWNXLibPINVOKE.CNWSFaction_GetSingletonParty(swigCPtr);
    return ret;
  }

  public int TransferLeadership(uint oidNewLeader, uint oidOldLeader) {
    int ret = NWNXLibPINVOKE.CNWSFaction_TransferLeadership(swigCPtr, oidNewLeader, oidOldLeader);
    return ret;
  }

  public uint GetFactionMember(int nStartPos, int bPCOnly) {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetFactionMember(swigCPtr, nStartPos, bPCOnly);
    return ret;
  }

  public void ClearAllReputationsTowards(uint oidCreature) {
    NWNXLibPINVOKE.CNWSFaction_ClearAllReputationsTowards(swigCPtr, oidCreature);
  }

  public uint GetLeader() {
    uint ret = NWNXLibPINVOKE.CNWSFaction_GetLeader(swigCPtr);
    return ret;
  }

  public CFactionManager GetFactionManager() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSFaction_GetFactionManager(swigCPtr);
    CFactionManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new CFactionManager(cPtr, false);
    return ret;
  }

}

}
