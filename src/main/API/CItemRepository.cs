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

public class CItemRepository : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CItemRepository(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CItemRepository obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CItemRepository() {
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
          NWNXLibPINVOKE.delete_CItemRepository(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public byte m_nWidth {
    set {
      NWNXLibPINVOKE.CItemRepository_m_nWidth_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CItemRepository_m_nWidth_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nHeight {
    set {
      NWNXLibPINVOKE.CItemRepository_m_nHeight_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CItemRepository_m_nHeight_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nBoundary {
    set {
      NWNXLibPINVOKE.CItemRepository_m_nBoundary_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CItemRepository_m_nBoundary_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidParent {
    set {
      NWNXLibPINVOKE.CItemRepository_m_oidParent_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CItemRepository_m_oidParent_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bScalable {
    set {
      NWNXLibPINVOKE.CItemRepository_m_bScalable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CItemRepository_m_bScalable_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLinkedListObjectId m_oidItems {
    set {
      NWNXLibPINVOKE.CItemRepository_m_oidItems_set(swigCPtr, CExoLinkedListObjectId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CItemRepository_m_oidItems_get(swigCPtr);
      CExoLinkedListObjectId ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListObjectId(cPtr, false);
      return ret;
    } 
  }

  public CItemRepository(uint oidParent, byte nWidth, byte nHeight, uint nBoundary, int bScalable) : this(NWNXLibPINVOKE.new_CItemRepository__SWIG_0(oidParent, nWidth, nHeight, nBoundary, bScalable), true) {
  }

  public CItemRepository(uint oidParent, byte nWidth, byte nHeight, uint nBoundary) : this(NWNXLibPINVOKE.new_CItemRepository__SWIG_1(oidParent, nWidth, nHeight, nBoundary), true) {
  }

  public int AddItem(SWIGTYPE_p_p_CNWSItem pItem, byte x, byte y, int bAllowEncumbrance, int bMergeItem) {
    int ret = NWNXLibPINVOKE.CItemRepository_AddItem__SWIG_0(swigCPtr, SWIGTYPE_p_p_CNWSItem.getCPtr(pItem), x, y, bAllowEncumbrance, bMergeItem);
    return ret;
  }

  public int AddItem(SWIGTYPE_p_p_CNWSItem pItem, byte x, byte y, int bAllowEncumbrance) {
    int ret = NWNXLibPINVOKE.CItemRepository_AddItem__SWIG_1(swigCPtr, SWIGTYPE_p_p_CNWSItem.getCPtr(pItem), x, y, bAllowEncumbrance);
    return ret;
  }

  public int AddItem(SWIGTYPE_p_p_CNWSItem pItem, byte x, byte y) {
    int ret = NWNXLibPINVOKE.CItemRepository_AddItem__SWIG_2(swigCPtr, SWIGTYPE_p_p_CNWSItem.getCPtr(pItem), x, y);
    return ret;
  }

  public int AddItem(SWIGTYPE_p_p_CNWSItem pItem, byte x) {
    int ret = NWNXLibPINVOKE.CItemRepository_AddItem__SWIG_3(swigCPtr, SWIGTYPE_p_p_CNWSItem.getCPtr(pItem), x);
    return ret;
  }

  public int AddItem(SWIGTYPE_p_p_CNWSItem pItem) {
    int ret = NWNXLibPINVOKE.CItemRepository_AddItem__SWIG_4(swigCPtr, SWIGTYPE_p_p_CNWSItem.getCPtr(pItem));
    return ret;
  }

  public byte CalculatePage(byte x, byte y) {
    byte ret = NWNXLibPINVOKE.CItemRepository_CalculatePage(swigCPtr, x, y);
    return ret;
  }

  public int CheckFit(CNWSItem pItem, byte x, byte y) {
    int ret = NWNXLibPINVOKE.CItemRepository_CheckFit(swigCPtr, CNWSItem.getCPtr(pItem), x, y);
    return ret;
  }

  public int CheckItemOverlaps(CNWSItem pSourceItem, CNWSItem pDroppingItem, byte x, byte y) {
    int ret = NWNXLibPINVOKE.CItemRepository_CheckItemOverlaps(swigCPtr, CNWSItem.getCPtr(pSourceItem), CNWSItem.getCPtr(pDroppingItem), x, y);
    return ret;
  }

  public uint FindItemWithBaseItemId(uint nBaseItemId, int nTh) {
    uint ret = NWNXLibPINVOKE.CItemRepository_FindItemWithBaseItemId__SWIG_0(swigCPtr, nBaseItemId, nTh);
    return ret;
  }

  public uint FindItemWithBaseItemId(uint nBaseItemId) {
    uint ret = NWNXLibPINVOKE.CItemRepository_FindItemWithBaseItemId__SWIG_1(swigCPtr, nBaseItemId);
    return ret;
  }

  public uint FindItemWithTag(CExoString pTag) {
    uint ret = NWNXLibPINVOKE.CItemRepository_FindItemWithTag(swigCPtr, CExoString.getCPtr(pTag));
    return ret;
  }

  public int FindPosition(CNWSItem pItem, SWIGTYPE_p_unsigned_char x, SWIGTYPE_p_unsigned_char y, int bOriginatingFromScript) {
    int ret = NWNXLibPINVOKE.CItemRepository_FindPosition__SWIG_0(swigCPtr, CNWSItem.getCPtr(pItem), SWIGTYPE_p_unsigned_char.getCPtr(x), SWIGTYPE_p_unsigned_char.getCPtr(y), bOriginatingFromScript);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int FindPosition(CNWSItem pItem, SWIGTYPE_p_unsigned_char x, SWIGTYPE_p_unsigned_char y) {
    int ret = NWNXLibPINVOKE.CItemRepository_FindPosition__SWIG_1(swigCPtr, CNWSItem.getCPtr(pItem), SWIGTYPE_p_unsigned_char.getCPtr(x), SWIGTYPE_p_unsigned_char.getCPtr(y));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddPanel() {
    int ret = NWNXLibPINVOKE.CItemRepository_AddPanel(swigCPtr);
    return ret;
  }

  public int RemoveItem(CNWSItem pItem) {
    int ret = NWNXLibPINVOKE.CItemRepository_RemoveItem(swigCPtr, CNWSItem.getCPtr(pItem));
    return ret;
  }

  public int MoveItem(CNWSItem pItem, byte x, byte y) {
    int ret = NWNXLibPINVOKE.CItemRepository_MoveItem(swigCPtr, CNWSItem.getCPtr(pItem), x, y);
    return ret;
  }

  public int GetItemInRepository(CNWSItem pItem, int bCheckContainers) {
    int ret = NWNXLibPINVOKE.CItemRepository_GetItemInRepository__SWIG_0(swigCPtr, CNWSItem.getCPtr(pItem), bCheckContainers);
    return ret;
  }

  public int GetItemInRepository(CNWSItem pItem) {
    int ret = NWNXLibPINVOKE.CItemRepository_GetItemInRepository__SWIG_1(swigCPtr, CNWSItem.getCPtr(pItem));
    return ret;
  }

  public uint GetItemInRepository(byte x, byte y) {
    uint ret = NWNXLibPINVOKE.CItemRepository_GetItemInRepository__SWIG_2(swigCPtr, x, y);
    return ret;
  }

  public CNWSItem ItemListGetItem(CExoLinkedListNode pListPosition) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CItemRepository_ItemListGetItem(swigCPtr, CExoLinkedListNode.getCPtr(pListPosition));
    CNWSItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSItem(cPtr, false);
    return ret;
  }

  public uint ItemListGetItemObjectID(CExoLinkedListNode pListPosition) {
    uint ret = NWNXLibPINVOKE.CItemRepository_ItemListGetItemObjectID(swigCPtr, CExoLinkedListNode.getCPtr(pListPosition));
    return ret;
  }

  public int CalculateContentsWeight() {
    int ret = NWNXLibPINVOKE.CItemRepository_CalculateContentsWeight(swigCPtr);
    return ret;
  }

}

}
