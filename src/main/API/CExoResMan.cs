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

public unsafe class CExoResMan : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoResMan(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoResMan(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoResMan obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoResMan() {
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
          NWNXLibPINVOKE.delete_CExoResMan(swigCPtr);
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

  public bool Equals(CExoResMan other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoResMan other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoResMan left, CExoResMan right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoResMan left, CExoResMan right) {
    return !Equals(left, right);
  }

  public int m_nTotalPhysicalMemory {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nTotalPhysicalMemory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoResMan_m_nTotalPhysicalMemory_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nTotalAvailableMemory {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nTotalAvailableMemory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoResMan_m_nTotalAvailableMemory_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAvailableMemory {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nAvailableMemory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoResMan_m_nAvailableMemory_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCExoKeyTablePtr m_pKeyTables {
    set {
      NWNXLibPINVOKE.CExoResMan_m_pKeyTables_set(swigCPtr, CExoArrayListCExoKeyTablePtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_m_pKeyTables_get(swigCPtr);
      CExoArrayListCExoKeyTablePtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCExoKeyTablePtr(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCRes m_lstToBeFreed {
    set {
      NWNXLibPINVOKE.CExoResMan_m_lstToBeFreed_set(swigCPtr, CExoLinkedListCRes.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_m_lstToBeFreed_get(swigCPtr);
      CExoLinkedListCRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCRes(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCRes m_lstAsyncResQueue {
    set {
      NWNXLibPINVOKE.CExoResMan_m_lstAsyncResQueue_set(swigCPtr, CExoLinkedListCRes.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_m_lstAsyncResQueue_get(swigCPtr);
      CExoLinkedListCRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListCRes(cPtr, false);
      return ret;
    } 
  }

  public CRes m_pCurrentAsyncRes {
    set {
      NWNXLibPINVOKE.CExoResMan_m_pCurrentAsyncRes_set(swigCPtr, CRes.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_m_pCurrentAsyncRes_get(swigCPtr);
      CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
      return ret;
    } 
  }

  public CExoFile m_pAsyncFile {
    set {
      NWNXLibPINVOKE.CExoResMan_m_pAsyncFile_set(swigCPtr, CExoFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_m_pAsyncFile_get(swigCPtr);
      CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
      return ret;
    } 
  }

  public int m_bAsyncSuspended {
    set {
      NWNXLibPINVOKE.CExoResMan_m_bAsyncSuspended_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoResMan_m_bAsyncSuspended_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTotalDemands {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nTotalDemands_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoResMan_m_nTotalDemands_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTotalCacheHits {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nTotalCacheHits_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoResMan_m_nTotalCacheHits_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTotalOldReleases {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nTotalOldReleases_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoResMan_m_nTotalOldReleases_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTotalNewReleases {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nTotalNewReleases_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoResMan_m_nTotalNewReleases_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTotalLookupFailures {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nTotalLookupFailures_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoResMan_m_nTotalLookupFailures_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_bLogLookupFailures {
    set {
      NWNXLibPINVOKE.CExoResMan_m_bLogLookupFailures_set(swigCPtr, value);
    } 
    get {
      bool ret = NWNXLibPINVOKE.CExoResMan_m_bLogLookupFailures_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_cLastFailedLookup {
    set {
      NWNXLibPINVOKE.CExoResMan_m_cLastFailedLookup_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_m_cLastFailedLookup_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nLastFailedLookupType {
    set {
      NWNXLibPINVOKE.CExoResMan_m_nLastFailedLookupType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CExoResMan_m_nLastFailedLookupType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bOverrideAll {
    set {
      NWNXLibPINVOKE.CExoResMan_m_bOverrideAll_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoResMan_m_bOverrideAll_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSync m_pNWSync {
    set {
      NWNXLibPINVOKE.CExoResMan_m_pNWSync_set(swigCPtr, CNWSync.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_m_pNWSync_get(swigCPtr);
      CNWSync ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSync(cPtr, false);
      return ret;
    } 
  }

  public void* m_pResourceOverrideMap {
    set {
      NWNXLibPINVOKE.CExoResMan_m_pResourceOverrideMap_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CExoResMan_m_pResourceOverrideMap_get(swigCPtr); 
        return (void*)retVal; 
    }

  }

  public CExoResMan() : this(NWNXLibPINVOKE.new_CExoResMan(), true) {
  }

  public void SetupDefaultSearchPath() {
    NWNXLibPINVOKE.CExoResMan_SetupDefaultSearchPath(swigCPtr);
  }

  public int AddEncapsulatedResourceFile(CExoString sName, uint nPriority) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddEncapsulatedResourceFile(swigCPtr, CExoString.getCPtr(sName), nPriority);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddResourceImageFile(CExoString sName, byte* pCipher, uint nPriority) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddResourceImageFile__SWIG_0(swigCPtr, CExoString.getCPtr(sName), (global::System.IntPtr)pCipher, nPriority);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddResourceImageFile(CExoString sName, byte* pCipher) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddResourceImageFile__SWIG_1(swigCPtr, CExoString.getCPtr(sName), (global::System.IntPtr)pCipher);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddResourceImageFile(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddResourceImageFile__SWIG_2(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddFixedKeyTableFile(CExoString sName, uint nPriority) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddFixedKeyTableFile__SWIG_0(swigCPtr, CExoString.getCPtr(sName), nPriority);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddFixedKeyTableFile(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddFixedKeyTableFile__SWIG_1(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddResourceDirectory(CExoString sName, uint nPriority, int bDetectChanges) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddResourceDirectory__SWIG_0(swigCPtr, CExoString.getCPtr(sName), nPriority, bDetectChanges);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddResourceDirectory(CExoString sName, uint nPriority) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddResourceDirectory__SWIG_1(swigCPtr, CExoString.getCPtr(sName), nPriority);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddManifest(SWIGTYPE_p_Hash__SHA1 manifestHash, uint nPriority) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddManifest(swigCPtr, SWIGTYPE_p_Hash__SHA1.getCPtr(manifestHash), nPriority);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DumpAll() {
    NWNXLibPINVOKE.CExoResMan_DumpAll(swigCPtr);
  }

  public void DumpAllOfType(ushort nType) {
    NWNXLibPINVOKE.CExoResMan_DumpAllOfType(swigCPtr, nType);
  }

  public void FreeResourceData(CRes pRes) {
    NWNXLibPINVOKE.CExoResMan_FreeResourceData(swigCPtr, CRes.getCPtr(pRes));
  }

  public int Exists(CResRef cResRef, ushort nType, uint* pTableType) {
    int ret = NWNXLibPINVOKE.CExoResMan_Exists__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), nType, (global::System.IntPtr)pTableType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Exists(CResRef cResRef, ushort nType) {
    int ret = NWNXLibPINVOKE.CExoResMan_Exists__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef), nType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoLocString GetEncapsulatedFileDescription(CExoString sFileName) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CExoResMan_GetEncapsulatedFileDescription(swigCPtr, CExoString.getCPtr(sFileName)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CRes GetResObject(CResRef cResRef, ushort nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_GetResObject(swigCPtr, CResRef.getCPtr(cResRef), nType);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoStringList GetResOfType(ushort nType, int bERFOnly) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_GetResOfType__SWIG_0(swigCPtr, nType, bERFOnly);
    CExoStringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringList(cPtr, false);
    return ret;
  }

  public CExoStringList GetResOfType(ushort nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_GetResOfType__SWIG_1(swigCPtr, nType);
    CExoStringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringList(cPtr, false);
    return ret;
  }

  public CExoStringList GetResOfType(ushort nType, CRes pRes) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_GetResOfType__SWIG_2(swigCPtr, nType, CRes.getCPtr(pRes));
    CExoStringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringList(cPtr, false);
    return ret;
  }

  public RESID GetResID(CResRef cResRef, ushort nType) {
    RESID ret = new RESID(NWNXLibPINVOKE.CExoResMan_GetResID(swigCPtr, CResRef.getCPtr(cResRef), nType), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetTotalPhysicalMemory() {
    int ret = NWNXLibPINVOKE.CExoResMan_GetTotalPhysicalMemory(swigCPtr);
    return ret;
  }

  public int ReleaseResObject(CRes pRes, bool bDontCache) {
    int ret = NWNXLibPINVOKE.CExoResMan_ReleaseResObject__SWIG_0(swigCPtr, CRes.getCPtr(pRes), bDontCache);
    return ret;
  }

  public int ReleaseResObject(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_ReleaseResObject__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int RemoveEncapsulatedResourceFile(CExoString sName, int bEmitWarningOnFailure) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveEncapsulatedResourceFile__SWIG_0(swigCPtr, CExoString.getCPtr(sName), bEmitWarningOnFailure);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveEncapsulatedResourceFile(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveEncapsulatedResourceFile__SWIG_1(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveResourceImageFile(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveResourceImageFile(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveFixedKeyTableFile(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveFixedKeyTableFile(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveResourceDirectory(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveResourceDirectory(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveManifest(SWIGTYPE_p_Hash__SHA1 sManifestHash) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveManifest(swigCPtr, SWIGTYPE_p_Hash__SHA1.getCPtr(sManifestHash));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ResumeServicing() {
    NWNXLibPINVOKE.CExoResMan_ResumeServicing(swigCPtr);
  }

  public void SetResObject(CResRef cResRef, ushort nType, CRes pNewRes) {
    NWNXLibPINVOKE.CExoResMan_SetResObject(swigCPtr, CResRef.getCPtr(cResRef), nType, CRes.getCPtr(pNewRes));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int SetTotalResourceMemory(int totalAvailableMemory) {
    int ret = NWNXLibPINVOKE.CExoResMan_SetTotalResourceMemory(swigCPtr, totalAvailableMemory);
    return ret;
  }

  public void SuspendServicing() {
    NWNXLibPINVOKE.CExoResMan_SuspendServicing(swigCPtr);
  }

  public void Update(uint nTimeSlice) {
    NWNXLibPINVOKE.CExoResMan_Update(swigCPtr, nTimeSlice);
  }

  public int UpdateEncapsulatedResourceFile(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_UpdateEncapsulatedResourceFile(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int UpdateFixedKeyTableFile(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_UpdateFixedKeyTableFile(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int UpdateResourceDirectory(CExoString sName) {
    int ret = NWNXLibPINVOKE.CExoResMan_UpdateResourceDirectory(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int UpdateManifest(CExoString sManifestHash) {
    int ret = NWNXLibPINVOKE.CExoResMan_UpdateManifest(swigCPtr, CExoString.getCPtr(sManifestHash));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort GetResTypeFromFile(CExoString sName) {
    ushort ret = NWNXLibPINVOKE.CExoResMan_GetResTypeFromFile(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetResRefFromFile(CResRef cResRef, CExoString sName) {
    NWNXLibPINVOKE.CExoResMan_GetResRefFromFile(swigCPtr, CResRef.getCPtr(cResRef), CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetKeyEntry(CResRef cResRef, ushort nType, SWIGTYPE_p_p_CExoKeyTable pNewTable, SWIGTYPE_p_p_CKeyTableEntry pNewKey, bool bLogFailure) {
    int ret = NWNXLibPINVOKE.CExoResMan_GetKeyEntry__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), nType, SWIGTYPE_p_p_CExoKeyTable.getCPtr(pNewTable), SWIGTYPE_p_p_CKeyTableEntry.getCPtr(pNewKey), bLogFailure);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetKeyEntry(CResRef cResRef, ushort nType, SWIGTYPE_p_p_CExoKeyTable pNewTable, SWIGTYPE_p_p_CKeyTableEntry pNewKey) {
    int ret = NWNXLibPINVOKE.CExoResMan_GetKeyEntry__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef), nType, SWIGTYPE_p_p_CExoKeyTable.getCPtr(pNewTable), SWIGTYPE_p_p_CKeyTableEntry.getCPtr(pNewKey));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CancelRequest(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_CancelRequest(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public void* Demand(CRes pRes) { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoResMan_Demand(swigCPtr, CRes.getCPtr(pRes));
    return (void*)retVal;
  }

  public void Dump(CRes pRes, int bRemove) {
    NWNXLibPINVOKE.CExoResMan_Dump__SWIG_0(swigCPtr, CRes.getCPtr(pRes), bRemove);
  }

  public void Dump(CRes pRes) {
    NWNXLibPINVOKE.CExoResMan_Dump__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
  }

  public int Release(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_Release(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int Request(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_Request(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int ReadRaw(CRes pRes, int nSize, string pBuffer) {
    int ret = NWNXLibPINVOKE.CExoResMan_ReadRaw(swigCPtr, CRes.getCPtr(pRes), nSize, pBuffer);
    return ret;
  }

  public int GetNewResRef(CResRef cResRef, ushort nType, CResRef cTarget) {
    int ret = NWNXLibPINVOKE.CExoResMan_GetNewResRef(swigCPtr, CResRef.getCPtr(cResRef), nType, CResRef.getCPtr(cTarget));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CreateDirectory(CExoString sDirectory) {
    int ret = NWNXLibPINVOKE.CExoResMan_CreateDirectory(swigCPtr, CExoString.getCPtr(sDirectory));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NukeDirectory(CExoString sDirectory, int bDeleteAllFiles, int bDeleteAllSubDirectories) {
    int ret = NWNXLibPINVOKE.CExoResMan_NukeDirectory__SWIG_0(swigCPtr, CExoString.getCPtr(sDirectory), bDeleteAllFiles, bDeleteAllSubDirectories);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NukeDirectory(CExoString sDirectory, int bDeleteAllFiles) {
    int ret = NWNXLibPINVOKE.CExoResMan_NukeDirectory__SWIG_1(swigCPtr, CExoString.getCPtr(sDirectory), bDeleteAllFiles);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NukeDirectory(CExoString sDirectory) {
    int ret = NWNXLibPINVOKE.CExoResMan_NukeDirectory__SWIG_2(swigCPtr, CExoString.getCPtr(sDirectory));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CleanDirectory(CExoString sDirectory, int bDeleteSubDirectories, int bCleanSubDirectories) {
    int ret = NWNXLibPINVOKE.CExoResMan_CleanDirectory__SWIG_0(swigCPtr, CExoString.getCPtr(sDirectory), bDeleteSubDirectories, bCleanSubDirectories);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CleanDirectory(CExoString sDirectory, int bDeleteSubDirectories) {
    int ret = NWNXLibPINVOKE.CExoResMan_CleanDirectory__SWIG_1(swigCPtr, CExoString.getCPtr(sDirectory), bDeleteSubDirectories);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int CleanDirectory(CExoString sDirectory) {
    int ret = NWNXLibPINVOKE.CExoResMan_CleanDirectory__SWIG_2(swigCPtr, CExoString.getCPtr(sDirectory));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveFile(CExoString sFile, ushort nResType) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveFile(swigCPtr, CExoString.getCPtr(sFile), nResType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetFreeDiskSpace(CExoString sDirectory, ulong* pSpaceAvailable) {
    int ret = NWNXLibPINVOKE.CExoResMan_GetFreeDiskSpace(swigCPtr, CExoString.getCPtr(sDirectory), (global::System.IntPtr)pSpaceAvailable);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ServiceCurrentAsyncRes() {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceCurrentAsyncRes(swigCPtr);
    return ret;
  }

  public int GetTableCount(CRes pRes, int bCountStatic) {
    int ret = NWNXLibPINVOKE.CExoResMan_GetTableCount(swigCPtr, CRes.getCPtr(pRes), bCountStatic);
    return ret;
  }

  public int GetIsStaticType(ushort nType) {
    int ret = NWNXLibPINVOKE.CExoResMan_GetIsStaticType(swigCPtr, nType);
    return ret;
  }

  public void RemoveFromToBeFreedList(CRes pRes) {
    NWNXLibPINVOKE.CExoResMan_RemoveFromToBeFreedList(swigCPtr, CRes.getCPtr(pRes));
  }

  public int AddKeyTable(uint nPriority, CExoString sName, uint nTableType, byte* pCipher, int bDetectChanges) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddKeyTable__SWIG_0(swigCPtr, nPriority, CExoString.getCPtr(sName), nTableType, (global::System.IntPtr)pCipher, bDetectChanges);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddKeyTable(uint nPriority, CExoString sName, uint nTableType, byte* pCipher) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddKeyTable__SWIG_1(swigCPtr, nPriority, CExoString.getCPtr(sName), nTableType, (global::System.IntPtr)pCipher);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddKeyTable(uint nPriority, CExoString sName, uint nTableType) {
    int ret = NWNXLibPINVOKE.CExoResMan_AddKeyTable__SWIG_2(swigCPtr, nPriority, CExoString.getCPtr(sName), nTableType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveKeyTable(CExoString sName, uint nTableType, int bEmitWarningOnFailure) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveKeyTable__SWIG_0(swigCPtr, CExoString.getCPtr(sName), nTableType, bEmitWarningOnFailure);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemoveKeyTable(CExoString sName, uint nTableType) {
    int ret = NWNXLibPINVOKE.CExoResMan_RemoveKeyTable__SWIG_1(swigCPtr, CExoString.getCPtr(sName), nTableType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint CountKeyTablesOf(int type, CExoString sName) {
    uint ret = NWNXLibPINVOKE.CExoResMan_CountKeyTablesOf__SWIG_0(swigCPtr, type, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint CountKeyTablesOf(int type) {
    uint ret = NWNXLibPINVOKE.CExoResMan_CountKeyTablesOf__SWIG_1(swigCPtr, type);
    return ret;
  }

  public void AddOverride(CResRef oldname, CResRef newname, ushort restype) {
    NWNXLibPINVOKE.CExoResMan_AddOverride(swigCPtr, CResRef.getCPtr(oldname), CResRef.getCPtr(newname), restype);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveOverride(CResRef name, ushort restype) {
    NWNXLibPINVOKE.CExoResMan_RemoveOverride(swigCPtr, CResRef.getCPtr(name), restype);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearOverrides() {
    NWNXLibPINVOKE.CExoResMan_ClearOverrides(swigCPtr);
  }

  public int WipeDirectory(CExoString sDirectory, int bDeleteAllFiles, int bRemoveDirectory, int bDeleteAllSubDirectoryFiles, int bDeleteAllSubDirectories) {
    int ret = NWNXLibPINVOKE.CExoResMan_WipeDirectory(swigCPtr, CExoString.getCPtr(sDirectory), bDeleteAllFiles, bRemoveDirectory, bDeleteAllSubDirectoryFiles, bDeleteAllSubDirectories);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Free(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_Free(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int FreeChunk() {
    int ret = NWNXLibPINVOKE.CExoResMan_FreeChunk(swigCPtr);
    return ret;
  }

  public CExoKeyTable GetTable(CRes pRes) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResMan_GetTable(swigCPtr, CRes.getCPtr(pRes));
    CExoKeyTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoKeyTable(cPtr, false);
    return ret;
  }

  public int Malloc(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_Malloc(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int ServiceFromDirectory(CRes pRes, int bAsync) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromDirectory__SWIG_0(swigCPtr, CRes.getCPtr(pRes), bAsync);
    return ret;
  }

  public int ServiceFromDirectory(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromDirectory__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int ServiceFromEncapsulated(CRes pRes, int bAsync) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromEncapsulated__SWIG_0(swigCPtr, CRes.getCPtr(pRes), bAsync);
    return ret;
  }

  public int ServiceFromEncapsulated(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromEncapsulated__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int ServiceFromResFile(CRes pRes, int bAsync) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromResFile__SWIG_0(swigCPtr, CRes.getCPtr(pRes), bAsync);
    return ret;
  }

  public int ServiceFromResFile(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromResFile__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int ServiceFromImage(CRes pRes, int bAsync) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromImage__SWIG_0(swigCPtr, CRes.getCPtr(pRes), bAsync);
    return ret;
  }

  public int ServiceFromImage(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromImage__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int ServiceFromManifest(CRes pRes, int bAsync) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromManifest__SWIG_0(swigCPtr, CRes.getCPtr(pRes), bAsync);
    return ret;
  }

  public int ServiceFromManifest(CRes pRes) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromManifest__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
    return ret;
  }

  public int UpdateKeyTable(CExoString sName, uint nTableType) {
    int ret = NWNXLibPINVOKE.CExoResMan_UpdateKeyTable(swigCPtr, CExoString.getCPtr(sName), nTableType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ServiceFromDirectoryRaw(CRes pRes, int nSize, string pBuffer) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromDirectoryRaw(swigCPtr, CRes.getCPtr(pRes), nSize, pBuffer);
    return ret;
  }

  public int ServiceFromEncapsulatedRaw(CRes pRes, int nSize, string pBuffer) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromEncapsulatedRaw(swigCPtr, CRes.getCPtr(pRes), nSize, pBuffer);
    return ret;
  }

  public int ServiceFromResFileRaw(CRes pRes, int nSize, string pBuffer) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromResFileRaw(swigCPtr, CRes.getCPtr(pRes), nSize, pBuffer);
    return ret;
  }

  public int ServiceFromImageRaw(CRes pRes, int nSize, string pBuffer) {
    int ret = NWNXLibPINVOKE.CExoResMan_ServiceFromImageRaw(swigCPtr, CRes.getCPtr(pRes), nSize, pBuffer);
    return ret;
  }

  public CResRef GetOverride(CResRef name, ushort restype) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CExoResMan_GetOverride(swigCPtr, CResRef.getCPtr(name), restype), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
