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

public unsafe class CExoKeyTable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoKeyTable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoKeyTable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoKeyTable() {
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
          NWNXLibPINVOKE.delete_CExoKeyTable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,26,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CExoKeyTable self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoKeyTable FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoKeyTable((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoKeyTable FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoKeyTable(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoKeyTable other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoKeyTable other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoKeyTable left, CExoKeyTable right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoKeyTable left, CExoKeyTable right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoKeyTable_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bExcludeFromSearches {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_bExcludeFromSearches_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoKeyTable_m_bExcludeFromSearches_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTableEntries {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_nTableEntries_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoKeyTable_m_nTableEntries_get(swigCPtr);
      return ret;
    } 
  }

  public CKeyTableEntry m_pEntries {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_pEntries_set(swigCPtr, CKeyTableEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_m_pEntries_get(swigCPtr);
      CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
      return ret;
    } 
  }

  public uint m_nSearchs {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_nSearchs_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoKeyTable_m_nSearchs_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nWorstSearch {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_nWorstSearch_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoKeyTable_m_nWorstSearch_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nTableType {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_nTableType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoKeyTable_m_nTableType_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sName {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_sName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_m_sName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sDirectory {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_sDirectory_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_m_sDirectory_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nTableID {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_nTableID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoKeyTable_m_nTableID_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nNumPackedFiles {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_nNumPackedFiles_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoKeyTable_m_nNumPackedFiles_get(swigCPtr);
      return ret;
    } 
  }

  public void** m_pExoPackedFile {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_pExoPackedFile_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CExoKeyTable_m_pExoPackedFile_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int m_bIsOverride {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_bIsOverride_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoKeyTable_m_bIsOverride_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAllowDynamicReload {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_bAllowDynamicReload_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoKeyTable_m_bAllowDynamicReload_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sResolvedAliasCache {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_sResolvedAliasCache_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_m_sResolvedAliasCache_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nLastModified {
    set {
      NWNXLibPINVOKE.CExoKeyTable_m_nLastModified_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoKeyTable_m_nLastModified_get(swigCPtr);
      return ret;
    } 
  }

  public CExoKeyTable() : this(NWNXLibPINVOKE.new_CExoKeyTable(), true) {
  }

  public int AddDirectoryContents(int bPopulateTable) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddDirectoryContents__SWIG_0(swigCPtr, bPopulateTable);
    return ret;
  }

  public int AddDirectoryContents() {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddDirectoryContents__SWIG_1(swigCPtr);
    return ret;
  }

  public int AddEncapsulatedContents(int bPopulateTable) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddEncapsulatedContents__SWIG_0(swigCPtr, bPopulateTable);
    return ret;
  }

  public int AddEncapsulatedContents() {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddEncapsulatedContents__SWIG_1(swigCPtr);
    return ret;
  }

  public int AddResourceImageContents(int bPopulateTable, byte* pCipher) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddResourceImageContents__SWIG_0(swigCPtr, bPopulateTable, (global::System.IntPtr)pCipher);
    return ret;
  }

  public int AddResourceImageContents(int bPopulateTable) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddResourceImageContents__SWIG_1(swigCPtr, bPopulateTable);
    return ret;
  }

  public int AddResourceImageContents() {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddResourceImageContents__SWIG_2(swigCPtr);
    return ret;
  }

  public int AddManifestContents(int bPopulateTable) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddManifestContents__SWIG_0(swigCPtr, bPopulateTable);
    return ret;
  }

  public int AddManifestContents() {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddManifestContents__SWIG_1(swigCPtr);
    return ret;
  }

  public CKeyTableEntry AddKey(CResRef cNewResRef, ushort nType, RESID nNewResID, int bPopulateEntry) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_AddKey(swigCPtr, CResRef.getCPtr(cNewResRef), nType, RESID.getCPtr(nNewResID), bPopulateEntry);
    CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddKeyTableContents(int bPopulateTable) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddKeyTableContents__SWIG_0(swigCPtr, bPopulateTable);
    return ret;
  }

  public int AddKeyTableContents() {
    int ret = NWNXLibPINVOKE.CExoKeyTable_AddKeyTableContents__SWIG_1(swigCPtr);
    return ret;
  }

  public CKeyTableEntry AllocateTable(uint nTableEntries, int bKeepInMemory) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_AllocateTable__SWIG_0(swigCPtr, nTableEntries, bKeepInMemory);
    CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
    return ret;
  }

  public CKeyTableEntry AllocateTable(uint nTableEntries) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_AllocateTable__SWIG_1(swigCPtr, nTableEntries);
    CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
    return ret;
  }

  public int BuildNewTable(uint nTableType, CExoString sName, uint nTableID, int bPopulateTable, byte* pCipher) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_BuildNewTable__SWIG_0(swigCPtr, nTableType, CExoString.getCPtr(sName), nTableID, bPopulateTable, (global::System.IntPtr)pCipher);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int BuildNewTable(uint nTableType, CExoString sName, uint nTableID, int bPopulateTable) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_BuildNewTable__SWIG_1(swigCPtr, nTableType, CExoString.getCPtr(sName), nTableID, bPopulateTable);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int BuildNewTable(uint nTableType, CExoString sName, uint nTableID) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_BuildNewTable__SWIG_2(swigCPtr, nTableType, CExoString.getCPtr(sName), nTableID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DeleteTableList(CExoLinkedListCKeyTableInfo lKeyTables) {
    NWNXLibPINVOKE.CExoKeyTable_DeleteTableList(swigCPtr, CExoLinkedListCKeyTableInfo.getCPtr(lKeyTables));
  }

  public void DestroyTable() {
    NWNXLibPINVOKE.CExoKeyTable_DestroyTable(swigCPtr);
  }

  public CKeyTableEntry FindKey(CResRef cResRef, ushort nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_FindKey__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), nType);
    CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CKeyTableEntry FindKey(CRes pRes) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_FindKey__SWIG_1(swigCPtr, CRes.getCPtr(pRes));
    CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
    return ret;
  }

  public CExoStringList GetKeysOfType(ushort nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_GetKeysOfType(swigCPtr, nType);
    CExoStringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoStringList(cPtr, false);
    return ret;
  }

  public CRes GetRes(CResRef cResRef, ushort nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoKeyTable_GetRes(swigCPtr, CResRef.getCPtr(cResRef), nType);
    CRes ret = (cPtr == global::System.IntPtr.Zero) ? null : new CRes(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RESID GetResID(CResRef cResRef, ushort nType) {
    RESID ret = new RESID(NWNXLibPINVOKE.CExoKeyTable_GetResID(swigCPtr, CResRef.getCPtr(cResRef), nType), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetTableEntry(uint nIndex, CResRef cResRef, ushort* nType) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_GetTableEntry(swigCPtr, nIndex, CResRef.getCPtr(cResRef), (global::System.IntPtr)nType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetTableIndex(uint* nIndex, CResRef cResRef, ushort nType) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_GetTableIndex(swigCPtr, (global::System.IntPtr)nIndex, CResRef.getCPtr(cResRef), nType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Hash(CResRef cResRef, ushort nType) {
    uint ret = NWNXLibPINVOKE.CExoKeyTable_Hash(swigCPtr, CResRef.getCPtr(cResRef), nType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LocateBifFile(CExoString sFileName) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_LocateBifFile(swigCPtr, CExoString.getCPtr(sFileName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RebuildTable(byte* pCipher) {
    NWNXLibPINVOKE.CExoKeyTable_RebuildTable__SWIG_0(swigCPtr, (global::System.IntPtr)pCipher);
  }

  public void RebuildTable() {
    NWNXLibPINVOKE.CExoKeyTable_RebuildTable__SWIG_1(swigCPtr);
  }

  public int GetEntryCount(int bCountStatic) {
    int ret = NWNXLibPINVOKE.CExoKeyTable_GetEntryCount(swigCPtr, bCountStatic);
    return ret;
  }

  public void SetAllowDynamicReload(int v) {
    NWNXLibPINVOKE.CExoKeyTable_SetAllowDynamicReload(swigCPtr, v);
  }

  public void DropContentsFromCache() {
    NWNXLibPINVOKE.CExoKeyTable_DropContentsFromCache(swigCPtr);
  }

  public int CheckForModificationsInStorage() {
    int ret = NWNXLibPINVOKE.CExoKeyTable_CheckForModificationsInStorage(swigCPtr);
    return ret;
  }

}

}
