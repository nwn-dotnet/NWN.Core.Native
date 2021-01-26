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

public class CNetLayerPlayerInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNetLayerPlayerInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNetLayerPlayerInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNetLayerPlayerInfo() {
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

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(CNetLayerPlayerInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNetLayerPlayerInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNetLayerPlayerInfo left, CNetLayerPlayerInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNetLayerPlayerInfo left, CNetLayerPlayerInfo right) {
    return !Equals(left, right);
  }

  public int m_bPlayerInUse {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bPlayerInUse_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bPlayerInUse_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sPlayerName {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sPlayerName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sPlayerName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nPlayerLanguage {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nPlayerLanguage_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nPlayerLanguage_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSlidingWindowId {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nSlidingWindowId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nSlidingWindowId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bPlayerPrivileges {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bPlayerPrivileges_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bPlayerPrivileges_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bGameMasterPrivileges {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bGameMasterPrivileges_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bGameMasterPrivileges_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bGameMasterIsPlayerLogin {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bGameMasterIsPlayerLogin_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bGameMasterIsPlayerLogin_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bServerAdminPrivileges {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bServerAdminPrivileges_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bServerAdminPrivileges_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_szMstServerChallenge {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_szMstServerChallenge_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_szMstServerChallenge_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public ulong m_nMstServerTimeout {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nMstServerTimeout_set(swigCPtr, value);
    } 
    get {
      ulong ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nMstServerTimeout_get(swigCPtr);
      return ret;
    } 
  }

  public ulong m_nMstServerTimeStamp {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nMstServerTimeStamp_set(swigCPtr, value);
    } 
    get {
      ulong ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nMstServerTimeStamp_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sGamePasswordChallenge {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sGamePasswordChallenge_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sGamePasswordChallenge_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCDKeyChallenge {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sCDKeyChallenge_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sCDKeyChallenge_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sMstPasswordChallenge {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sMstPasswordChallenge_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sMstPasswordChallenge_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public byte m_nConnectionType {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nConnectionType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nConnectionType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bIsPrimaryPlayer {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bIsPrimaryPlayer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bIsPrimaryPlayer_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNetLayerPlayerCDKeyInfo m_lstKeys {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_lstKeys_set(swigCPtr, CExoArrayListCNetLayerPlayerCDKeyInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_lstKeys_get(swigCPtr);
      CExoArrayListCNetLayerPlayerCDKeyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNetLayerPlayerCDKeyInfo(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sMstPasswordResponse {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sMstPasswordResponse_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sMstPasswordResponse_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bCDKeyAuthorized {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bCDKeyAuthorized_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bCDKeyAuthorized_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bMstPasswordAuthorized {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bMstPasswordAuthorized_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_bMstPasswordAuthorized_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nExpansionPacks {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nExpansionPacks_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nExpansionPacks_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sPSID {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sPSID_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sPSID_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public byte m_nPlatformId {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nPlatformId_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nPlatformId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nBuildVersion {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nBuildVersion_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nBuildVersion_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nPatchRevision {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nPatchRevision_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_nPatchRevision_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sCommitHash {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sCommitHash_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerInfo_m_sCommitHash_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CNetLayerPlayerInfo() : this(NWNXLibPINVOKE.new_CNetLayerPlayerInfo(), true) {
  }

  public void Initialize() {
    NWNXLibPINVOKE.CNetLayerPlayerInfo_Initialize(swigCPtr);
  }

  public void StartMstTimer(ulong nTime) {
    NWNXLibPINVOKE.CNetLayerPlayerInfo_StartMstTimer(swigCPtr, nTime);
  }

  public int UpdateMstTimer(ulong nTime) {
    int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_UpdateMstTimer(swigCPtr, nTime);
    return ret;
  }

  public void AddCDKey(CExoString sPublic, CExoString sResponse) {
    NWNXLibPINVOKE.CNetLayerPlayerInfo_AddCDKey(swigCPtr, CExoString.getCPtr(sPublic), CExoString.getCPtr(sResponse));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AllKeysAuthed(SWIGTYPE_p_unsigned_int nExpansionPacks) {
    int ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_AllKeysAuthed(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(nExpansionPacks));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCDKey(int nIndex, CExoString sPublic, CExoString sResponse) {
    NWNXLibPINVOKE.CNetLayerPlayerInfo_SetCDKey(swigCPtr, nIndex, CExoString.getCPtr(sPublic), CExoString.getCPtr(sResponse));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool SatisfiesBuild(int nBuild, int nRevision) {
    bool ret = NWNXLibPINVOKE.CNetLayerPlayerInfo_SatisfiesBuild(swigCPtr, nBuild, nRevision);
    return ret;
  }

}

}
