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

public class C2DA : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal C2DA(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(C2DA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~C2DA() {
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
          NWNXLibPINVOKE.delete_C2DA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CExoString m_sDefaultValue {
    set {
      NWNXLibPINVOKE.C2DA_m_sDefaultValue_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.C2DA_m_sDefaultValue_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pRowLabel {
    set {
      NWNXLibPINVOKE.C2DA_m_pRowLabel_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.C2DA_m_pRowLabel_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pColumnLabel {
    set {
      NWNXLibPINVOKE.C2DA_m_pColumnLabel_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.C2DA_m_pColumnLabel_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_CExoString m_pArrayData {
    set {
      NWNXLibPINVOKE.C2DA_m_pArrayData_set(swigCPtr, SWIGTYPE_p_p_CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.C2DA_m_pArrayData_get(swigCPtr);
      SWIGTYPE_p_p_CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nNumRows {
    set {
      NWNXLibPINVOKE.C2DA_m_nNumRows_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.C2DA_m_nNumRows_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNumColumns {
    set {
      NWNXLibPINVOKE.C2DA_m_nNumColumns_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.C2DA_m_nNumColumns_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.C2DA_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.C2DA_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public C2DA(CResRef cResRef, int bSetAutoRequest) : this(NWNXLibPINVOKE.new_C2DA__SWIG_0(CResRef.getCPtr(cResRef), bSetAutoRequest), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public C2DA() : this(NWNXLibPINVOKE.new_C2DA__SWIG_1(), true) {
  }

  public int GetCExoStringEntry(int nRow, int nColumn, CExoString pString) {
    int ret = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_0(swigCPtr, nRow, nColumn, CExoString.getCPtr(pString));
    return ret;
  }

  public int GetCExoStringEntry(CExoString sRowLabel, CExoString sColumnLabel, CExoString pString) {
    int ret = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(pString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetCExoStringEntry(int nRow, CExoString sColumnLabel, CExoString pString) {
    int ret = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(pString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetCExoStringEntry(CExoString sRowLabel, int nColumn, CExoString pString) {
    int ret = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, CExoString.getCPtr(pString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetCExoStringEntry(int nRow, int nColumn, CExoString sString) {
    int ret = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_0(swigCPtr, nRow, nColumn, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetCExoStringEntry(CExoString sRowLabel, CExoString sColumnLabel, CExoString sString) {
    int ret = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetCExoStringEntry(int nRow, CExoString sColumnLabel, CExoString sString) {
    int ret = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetCExoStringEntry(CExoString sRowLabel, int nColumn, CExoString sString) {
    int ret = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetFLOATEntry(int nRow, int nColumn, SWIGTYPE_p_float pFloat) {
    int ret = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_0(swigCPtr, nRow, nColumn, SWIGTYPE_p_float.getCPtr(pFloat));
    return ret;
  }

  public int GetFLOATEntry(CExoString sRowLabel, CExoString sColumnLabel, SWIGTYPE_p_float pFloat) {
    int ret = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), SWIGTYPE_p_float.getCPtr(pFloat));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetFLOATEntry(int nRow, CExoString sColumnLabel, SWIGTYPE_p_float pFloat) {
    int ret = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), SWIGTYPE_p_float.getCPtr(pFloat));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetFLOATEntry(CExoString sRowLabel, int nColumn, SWIGTYPE_p_float pFloat) {
    int ret = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, SWIGTYPE_p_float.getCPtr(pFloat));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetFLOATEntry(int nRow, int nColumn, float fFloat) {
    int ret = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_0(swigCPtr, nRow, nColumn, fFloat);
    return ret;
  }

  public int SetFLOATEntry(CExoString sRowLabel, CExoString sColumnLabel, float fFloat) {
    int ret = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), fFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetFLOATEntry(int nRow, CExoString sColumnLabel, float fFloat) {
    int ret = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), fFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetFLOATEntry(CExoString sRowLabel, int nColumn, float fFloat) {
    int ret = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, fFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetINTEntry(int nRow, int nColumn, SWIGTYPE_p_int pInt) {
    int ret = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_0(swigCPtr, nRow, nColumn, SWIGTYPE_p_int.getCPtr(pInt));
    return ret;
  }

  public int GetINTEntry(CExoString sRowLabel, CExoString sColumnLabel, SWIGTYPE_p_int pInt) {
    int ret = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), SWIGTYPE_p_int.getCPtr(pInt));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetINTEntry(int nRow, CExoString sColumnLabel, SWIGTYPE_p_int pInt) {
    int ret = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), SWIGTYPE_p_int.getCPtr(pInt));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetINTEntry(CExoString sRowLabel, int nColumn, SWIGTYPE_p_int pInt) {
    int ret = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, SWIGTYPE_p_int.getCPtr(pInt));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetINTEntry(int nRow, int nColumn, int nInt) {
    int ret = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_0(swigCPtr, nRow, nColumn, nInt);
    return ret;
  }

  public int SetINTEntry(CExoString sRowLabel, CExoString sColumnLabel, int nInt) {
    int ret = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), nInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetINTEntry(int nRow, CExoString sColumnLabel, int nInt) {
    int ret = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), nInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetINTEntry(CExoString sRowLabel, int nColumn, int nInt) {
    int ret = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, nInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetBlankEntry(int nRow, int nColumn) {
    int ret = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_0(swigCPtr, nRow, nColumn);
    return ret;
  }

  public int SetBlankEntry(CExoString sRowLabel, CExoString sColumnLabel) {
    int ret = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetBlankEntry(int nRow, CExoString sColumnLabel) {
    int ret = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetBlankEntry(CExoString sRowLabel, int nColumn) {
    int ret = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Load2DArray() {
    int ret = NWNXLibPINVOKE.C2DA_Load2DArray(swigCPtr);
    return ret;
  }

  public void Unload2DArray() {
    NWNXLibPINVOKE.C2DA_Unload2DArray(swigCPtr);
  }

  public int GetColumnIndex(CExoString sColumn) {
    int ret = NWNXLibPINVOKE.C2DA_GetColumnIndex(swigCPtr, CExoString.getCPtr(sColumn));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetNextLineLength(string pBuffer, uint nBufferSize) {
    uint ret = NWNXLibPINVOKE.C2DA_GetNextLineLength(swigCPtr, pBuffer, nBufferSize);
    return ret;
  }

  public int GetNextToken(SWIGTYPE_p_p_char pBuffer, SWIGTYPE_p_unsigned_int pBufferSize, string pToken, uint nMaxTokenSize, SWIGTYPE_p_unsigned_int pLeadingWhiteSpaceSize) {
    int ret = NWNXLibPINVOKE.C2DA_GetNextToken(swigCPtr, SWIGTYPE_p_p_char.getCPtr(pBuffer), SWIGTYPE_p_unsigned_int.getCPtr(pBufferSize), pToken, nMaxTokenSize, SWIGTYPE_p_unsigned_int.getCPtr(pLeadingWhiteSpaceSize));
    return ret;
  }

  public int GetRowIndex(CExoString sRow) {
    int ret = NWNXLibPINVOKE.C2DA_GetRowIndex(swigCPtr, CExoString.getCPtr(sRow));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SkipNewLines(SWIGTYPE_p_p_char pBuffer, SWIGTYPE_p_unsigned_int pBufferSize) {
    int ret = NWNXLibPINVOKE.C2DA_SkipNewLines(swigCPtr, SWIGTYPE_p_p_char.getCPtr(pBuffer), SWIGTYPE_p_unsigned_int.getCPtr(pBufferSize));
    return ret;
  }

}

}
