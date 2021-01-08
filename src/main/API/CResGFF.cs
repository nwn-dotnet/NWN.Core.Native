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

public class CResGFF : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CResGFF(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResGFF_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResGFF obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResGFF(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public uint STRUCT_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_STRUCT_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_STRUCT_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint FIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_FIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_FIELD_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint LABEL_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_LABEL_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_LABEL_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint DATAFIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATAFIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_DATAFIELD_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint DATALAYOUTFIELD_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATALAYOUTFIELD_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_DATALAYOUTFIELD_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public uint DATALAYOUTLIST_GROWSIZE {
    set {
      NWNXLibPINVOKE.CResGFF_DATALAYOUTLIST_GROWSIZE_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_DATALAYOUTLIST_GROWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFFFileHeader m_pFileHeader {
    set {
      NWNXLibPINVOKE.CResGFF_m_pFileHeader_set(swigCPtr, CResGFFFileHeader.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pFileHeader_get(swigCPtr);
      CResGFFFileHeader ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFFileHeader(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_pDDFileHeader {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDDFileHeader_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pDDFileHeader_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public uint m_nHeaderOffset {
    set {
      NWNXLibPINVOKE.CResGFF_m_nHeaderOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nHeaderOffset_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFFStruct m_pStruct {
    set {
      NWNXLibPINVOKE.CResGFF_m_pStruct_set(swigCPtr, CResGFFStruct.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pStruct_get(swigCPtr);
      CResGFFStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFStruct(cPtr, false);
      return ret;
    } 
  }

  public uint m_nStructAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nStructAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nStructAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFFField m_pField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pField_set(swigCPtr, CResGFFField.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pField_get(swigCPtr);
      CResGFFField ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFField(cPtr, false);
      return ret;
    } 
  }

  public uint m_nFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nFieldAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFFLabel m_pLabel {
    set {
      NWNXLibPINVOKE.CResGFF_m_pLabel_set(swigCPtr, CResGFFLabel.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pLabel_get(swigCPtr);
      CResGFFLabel ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFLabel(cPtr, false);
      return ret;
    } 
  }

  public uint m_nLabelAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nLabelAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nLabelAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_pDataField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataField_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pDataField_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public uint m_nDataFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataFieldAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_pDataLayoutField {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataLayoutField_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pDataLayoutField_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public uint m_nDataLayoutFieldAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutFieldWasted {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldWasted_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutFieldWasted_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_pDataLayoutList {
    set {
      NWNXLibPINVOKE.CResGFF_m_pDataLayoutList_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_m_pDataLayoutList_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public uint m_nDataLayoutListAllocated {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutListAllocated_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutListAllocated_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataLayoutListWasted {
    set {
      NWNXLibPINVOKE.CResGFF_m_nDataLayoutListWasted_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFF_m_nDataLayoutListWasted_get(swigCPtr);
      return ret;
    } 
  }

  public string m_pLabelBuffer {
    set {
      NWNXLibPINVOKE.CResGFF_m_pLabelBuffer_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CResGFF_m_pLabelBuffer_get(swigCPtr);
      return ret;
    } 
  }

  public string m_pFileType {
    set {
      NWNXLibPINVOKE.CResGFF_m_pFileType_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CResGFF_m_pFileType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bResourceLoaded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bResourceLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bResourceLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bSelfDemanded {
    set {
      NWNXLibPINVOKE.CResGFF_m_bSelfDemanded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bSelfDemanded_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDataPtrOwned {
    set {
      NWNXLibPINVOKE.CResGFF_m_bDataPtrOwned_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bDataPtrOwned_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bReplaceExistingFields {
    set {
      NWNXLibPINVOKE.CResGFF_m_bReplaceExistingFields_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bReplaceExistingFields_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bValidationFailed {
    set {
      NWNXLibPINVOKE.CResGFF_m_bValidationFailed_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResGFF_m_bValidationFailed_get(swigCPtr);
      return ret;
    } 
  }

  public CResGFF() : this(NWNXLibPINVOKE.new_CResGFF__SWIG_0(), true) {
  }

  public CResGFF(ushort nType, string cIDStr, CResRef cResRef) : this(NWNXLibPINVOKE.new_CResGFF__SWIG_1(nType, cIDStr, CResRef.getCPtr(cResRef)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CResGFF_OnResourceServiced(swigCPtr);
    return ret;
  }

  public override int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CResGFF_OnResourceFreed(swigCPtr);
    return ret;
  }

  public int GetDataFromFile(string pFileName) {
    int ret = NWNXLibPINVOKE.CResGFF_GetDataFromFile(swigCPtr, pFileName);
    return ret;
  }

  public int GetDataFromPointer(SWIGTYPE_p_void pData, int nDataSize) {
    int ret = NWNXLibPINVOKE.CResGFF_GetDataFromPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(pData), nDataSize);
    return ret;
  }

  public void GetGFFFileInfo(CExoString pFileType, CExoString pVersion) {
    NWNXLibPINVOKE.CResGFF_GetGFFFileInfo(swigCPtr, CExoString.getCPtr(pFileType), CExoString.getCPtr(pVersion));
  }

  public uint GetElementType(CResStruct pStructure) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetElementType(swigCPtr, CResStruct.getCPtr(pStructure));
    return ret;
  }

  public uint GetFieldCount(CResStruct pStructure) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldCount__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure));
    return ret;
  }

  public uint GetFieldType(CResStruct pStructure, string szFieldID, uint nFieldIndex) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldType__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nFieldIndex);
    return ret;
  }

  public uint GetFieldType(CResStruct pStructure, string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldType__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public string GetFieldStringID(CResStruct pStructure, uint nFieldIndex) {
    string ret = NWNXLibPINVOKE.CResGFF_GetFieldStringID(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    return ret;
  }

  public uint GetFieldSize(CResStruct pStructure, string szFieldID, uint nFieldIndex) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldSize__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nFieldIndex);
    return ret;
  }

  public uint GetFieldSize(CResStruct pStructure, string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldSize__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public int GetList(CResList pList, CResStruct pStructure, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_GetList(swigCPtr, CResList.getCPtr(pList), CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public uint GetListCount(CResList pList) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetListCount(swigCPtr, CResList.getCPtr(pList));
    return ret;
  }

  public int GetListElement(CResStruct pStruct, CResList pList, uint nIndex) {
    int ret = NWNXLibPINVOKE.CResGFF_GetListElement(swigCPtr, CResStruct.getCPtr(pStruct), CResList.getCPtr(pList), nIndex);
    return ret;
  }

  public int GetStructFromStruct(CResStruct pStruct, CResStruct pParentStruct, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_GetStructFromStruct(swigCPtr, CResStruct.getCPtr(pStruct), CResStruct.getCPtr(pParentStruct), szFieldID);
    return ret;
  }

  public int GetTopLevelStruct(CResStruct pStructure) {
    int ret = NWNXLibPINVOKE.CResGFF_GetTopLevelStruct(swigCPtr, CResStruct.getCPtr(pStructure));
    return ret;
  }

  public byte ReadFieldBYTE(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, byte nDefault) {
    byte ret = NWNXLibPINVOKE.CResGFF_ReadFieldBYTE__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte ReadFieldBYTE(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    byte ret = NWNXLibPINVOKE.CResGFF_ReadFieldBYTE__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public char ReadFieldCHAR(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, char nDefault) {
    char ret = NWNXLibPINVOKE.CResGFF_ReadFieldCHAR__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public char ReadFieldCHAR(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    char ret = NWNXLibPINVOKE.CResGFF_ReadFieldCHAR__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort ReadFieldWORD(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, ushort nDefault) {
    ushort ret = NWNXLibPINVOKE.CResGFF_ReadFieldWORD__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort ReadFieldWORD(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    ushort ret = NWNXLibPINVOKE.CResGFF_ReadFieldWORD__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public short ReadFieldSHORT(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, short nDefault) {
    short ret = NWNXLibPINVOKE.CResGFF_ReadFieldSHORT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public short ReadFieldSHORT(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    short ret = NWNXLibPINVOKE.CResGFF_ReadFieldSHORT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint ReadFieldDWORD(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, uint nDefault) {
    uint ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint ReadFieldDWORD(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    uint ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ReadFieldINT(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, int nDefault) {
    int ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ReadFieldINT(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    int ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong ReadFieldDWORD64(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, ulong nDefault) {
    ulong ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD64__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong ReadFieldDWORD64(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    ulong ret = NWNXLibPINVOKE.CResGFF_ReadFieldDWORD64__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long ReadFieldINT64(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, long nDefault) {
    long ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT64__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), nDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long ReadFieldINT64(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    long ret = NWNXLibPINVOKE.CResGFF_ReadFieldINT64__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ReadFieldFLOAT(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, float fDefault) {
    float ret = NWNXLibPINVOKE.CResGFF_ReadFieldFLOAT__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), fDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ReadFieldFLOAT(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    float ret = NWNXLibPINVOKE.CResGFF_ReadFieldFLOAT__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ReadFieldDOUBLE(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, double fDefault) {
    double ret = NWNXLibPINVOKE.CResGFF_ReadFieldDOUBLE__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), fDefault);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ReadFieldDOUBLE(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    double ret = NWNXLibPINVOKE.CResGFF_ReadFieldDOUBLE__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef ReadFieldCResRef(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, CResRef sDefault) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResGFF_ReadFieldCResRef__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), CResRef.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef ReadFieldCResRef(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResGFF_ReadFieldCResRef__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString ReadFieldCExoString(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, CExoString sDefault) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoString__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), CExoString.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString ReadFieldCExoString(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoString__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoLocString ReadFieldCExoLocString(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess, CExoLocString sDefault) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoLocString__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), CExoLocString.getCPtr(sDefault)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoLocString ReadFieldCExoLocString(CResStruct pStructure, string szFieldID, SWIGTYPE_p_int bSuccess) {
    CExoLocString ret = new CExoLocString(NWNXLibPINVOKE.CResGFF_ReadFieldCExoLocString__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void ReadFieldVOID(CResStruct pStructure, SWIGTYPE_p_void pVariable, uint nSize, string szFieldID, SWIGTYPE_p_int bSuccess, SWIGTYPE_p_void pDefault) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_ReadFieldVOID__SWIG_0(swigCPtr, CResStruct.getCPtr(pStructure), SWIGTYPE_p_void.getCPtr(pVariable), nSize, szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess), SWIGTYPE_p_void.getCPtr(pDefault));
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void ReadFieldVOID(CResStruct pStructure, SWIGTYPE_p_void pVariable, uint nSize, string szFieldID, SWIGTYPE_p_int bSuccess) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_ReadFieldVOID__SWIG_1(swigCPtr, CResStruct.getCPtr(pStructure), SWIGTYPE_p_void.getCPtr(pVariable), nSize, szFieldID, SWIGTYPE_p_int.getCPtr(bSuccess));
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddList(CResList pList, CResStruct pStructure, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_AddList(swigCPtr, CResList.getCPtr(pList), CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public int AddListElement(CResStruct pStruct, CResList pList, uint nType) {
    int ret = NWNXLibPINVOKE.CResGFF_AddListElement(swigCPtr, CResStruct.getCPtr(pStruct), CResList.getCPtr(pList), nType);
    return ret;
  }

  public int AddStructToStruct(CResStruct pNewStruct, CResStruct pParentStruct, string szFieldID, uint nType) {
    int ret = NWNXLibPINVOKE.CResGFF_AddStructToStruct(swigCPtr, CResStruct.getCPtr(pNewStruct), CResStruct.getCPtr(pParentStruct), szFieldID, nType);
    return ret;
  }

  public int CreateGFFFile(CResStruct pStruct, CExoString sFileType, CExoString sVersion) {
    int ret = NWNXLibPINVOKE.CResGFF_CreateGFFFile(swigCPtr, CResStruct.getCPtr(pStruct), CExoString.getCPtr(sFileType), CExoString.getCPtr(sVersion));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldBYTE(CResStruct pStructure, byte nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldBYTE(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldCHAR(CResStruct pStructure, char nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCHAR(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldWORD(CResStruct pStructure, ushort nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldWORD(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldSHORT(CResStruct pStructure, short nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldSHORT(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldDWORD(CResStruct pStructure, uint nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldDWORD(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldINT(CResStruct pStructure, int nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldINT(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldDWORD64(CResStruct pStructure, ulong nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldDWORD64(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldINT64(CResStruct pStructure, long nVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldINT64(swigCPtr, CResStruct.getCPtr(pStructure), nVariable, szFieldID);
    return ret;
  }

  public int WriteFieldFLOAT(CResStruct pStructure, float fVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldFLOAT(swigCPtr, CResStruct.getCPtr(pStructure), fVariable, szFieldID);
    return ret;
  }

  public int WriteFieldDOUBLE(CResStruct pStructure, double fVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldDOUBLE(swigCPtr, CResStruct.getCPtr(pStructure), fVariable, szFieldID);
    return ret;
  }

  public int WriteFieldCResRef(CResStruct pStructure, CResRef sVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCResRef(swigCPtr, CResStruct.getCPtr(pStructure), CResRef.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldCExoString(CResStruct pStructure, CExoString sVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCExoString(swigCPtr, CResStruct.getCPtr(pStructure), CExoString.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldCExoLocString(CResStruct pStructure, CExoLocString sVariable, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldCExoLocString(swigCPtr, CResStruct.getCPtr(pStructure), CExoLocString.getCPtr(sVariable), szFieldID);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteFieldVOID(CResStruct pStructure, SWIGTYPE_p_void pVariable, uint nSize, string szFieldID) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteFieldVOID(swigCPtr, CResStruct.getCPtr(pStructure), SWIGTYPE_p_void.getCPtr(pVariable), nSize, szFieldID);
    return ret;
  }

  public int WriteGFFFile(CExoString sFileName, ushort nType) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFFile__SWIG_0(swigCPtr, CExoString.getCPtr(sFileName), nType);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteGFFFile(string szFileName) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFFile__SWIG_1(swigCPtr, szFileName);
    return ret;
  }

  public int WriteGFFData(CExoFile cFile, SWIGTYPE_p_unsigned_int nBytesWritten) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFData(swigCPtr, CExoFile.getCPtr(cFile), SWIGTYPE_p_unsigned_int.getCPtr(nBytesWritten));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int WriteGFFToPointer(SWIGTYPE_p_p_void pData, SWIGTYPE_p_int nLength) {
    int ret = NWNXLibPINVOKE.CResGFF_WriteGFFToPointer(swigCPtr, SWIGTYPE_p_p_void.getCPtr(pData), SWIGTYPE_p_int.getCPtr(nLength));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Pack(byte nPercentThreshold, uint nByteThreshold) {
    NWNXLibPINVOKE.CResGFF_Pack__SWIG_0(swigCPtr, nPercentThreshold, nByteThreshold);
  }

  public void Pack(byte nPercentThreshold) {
    NWNXLibPINVOKE.CResGFF_Pack__SWIG_1(swigCPtr, nPercentThreshold);
  }

  public void Pack() {
    NWNXLibPINVOKE.CResGFF_Pack__SWIG_2(swigCPtr);
  }

  public uint GetTotalSize() {
    uint ret = NWNXLibPINVOKE.CResGFF_GetTotalSize(swigCPtr);
    return ret;
  }

  public void InitializeForWriting() {
    NWNXLibPINVOKE.CResGFF_InitializeForWriting(swigCPtr);
  }

  public int PrepareHeader() {
    int ret = NWNXLibPINVOKE.CResGFF_PrepareHeader(swigCPtr);
    return ret;
  }

  public int FinalizeSetup() {
    int ret = NWNXLibPINVOKE.CResGFF_FinalizeSetup(swigCPtr);
    return ret;
  }

  public int ValidateAndSetup() {
    int ret = NWNXLibPINVOKE.CResGFF_ValidateAndSetup(swigCPtr);
    return ret;
  }

  public void ReleaseResource() {
    NWNXLibPINVOKE.CResGFF_ReleaseResource(swigCPtr);
  }

  public CResGFFStruct GetStruct(CResStruct pStructure) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetStruct(swigCPtr, CResStruct.getCPtr(pStructure));
    CResGFFStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFStruct(cPtr, false);
    return ret;
  }

  public CResGFFField GetField(CResStruct pStructure, uint nFieldIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetField(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    CResGFFField ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFField(cPtr, false);
    return ret;
  }

  public CResGFFLabel GetLabel(CResStruct pStructure, uint nFieldIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetLabel(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    CResGFFLabel ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFLabel(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_unsigned_char GetDataField(CResGFFField pField, SWIGTYPE_p_unsigned_int nMaxSize) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetDataField(swigCPtr, CResGFFField.getCPtr(pField), SWIGTYPE_p_unsigned_int.getCPtr(nMaxSize));
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned_char GetDataLayoutField(CResGFFField pField, SWIGTYPE_p_unsigned_int nMaxSize) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetDataLayoutField(swigCPtr, CResGFFField.getCPtr(pField), SWIGTYPE_p_unsigned_int.getCPtr(nMaxSize));
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned_char GetDataLayoutList(CResGFFField pField, SWIGTYPE_p_unsigned_int nMaxSize) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_GetDataLayoutList(swigCPtr, CResGFFField.getCPtr(pField), SWIGTYPE_p_unsigned_int.getCPtr(nMaxSize));
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetFieldByLabel(CResStruct pStructure, string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldByLabel(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID);
    return ret;
  }

  public int IsDataInPlace(uint nType) {
    int ret = NWNXLibPINVOKE.CResGFF_IsDataInPlace(swigCPtr, nType);
    return ret;
  }

  public string GetFieldLabel(CResStruct pStructure, uint nFieldIndex) {
    string ret = NWNXLibPINVOKE.CResGFF_GetFieldLabel(swigCPtr, CResStruct.getCPtr(pStructure), nFieldIndex);
    return ret;
  }

  public uint GetFieldCount(CResGFFStruct pStruct) {
    uint ret = NWNXLibPINVOKE.CResGFF_GetFieldCount__SWIG_1(swigCPtr, CResGFFStruct.getCPtr(pStruct));
    return ret;
  }

  public uint AddStruct(uint nType) {
    uint ret = NWNXLibPINVOKE.CResGFF_AddStruct(swigCPtr, nType);
    return ret;
  }

  public CResGFFField AddField(CResStruct pStructure, string szFieldID, uint nType) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_AddField(swigCPtr, CResStruct.getCPtr(pStructure), szFieldID, nType);
    CResGFFField ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResGFFField(cPtr, false);
    return ret;
  }

  public uint AddLabel(string szFieldID) {
    uint ret = NWNXLibPINVOKE.CResGFF_AddLabel(swigCPtr, szFieldID);
    return ret;
  }

  public SWIGTYPE_p_unsigned_char AddDataField(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_AddDataField(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_unsigned_char AddDataLayoutField(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_AddDataLayoutField(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_unsigned_char AddDataLayoutList(uint nCurrentOffset, uint nCurrentSize, uint nNewSize) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CResGFF_AddDataLayoutList(swigCPtr, nCurrentOffset, nCurrentSize, nNewSize);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

}

}