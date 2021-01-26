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

public class CExoDebugInternal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoDebugInternal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoDebugInternal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoDebugInternal() {
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
          NWNXLibPINVOKE.delete_CExoDebugInternal(swigCPtr);
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

  public bool Equals(CExoDebugInternal other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoDebugInternal other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoDebugInternal left, CExoDebugInternal right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoDebugInternal left, CExoDebugInternal right) {
    return !Equals(left, right);
  }

  public int m_bFilesOpen {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_bFilesOpen_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoDebugInternal_m_bFilesOpen_get(swigCPtr);
      return ret;
    } 
  }

  public CExoFile m_pLogFile {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_pLogFile_set(swigCPtr, CExoFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoDebugInternal_m_pLogFile_get(swigCPtr);
      CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
      return ret;
    } 
  }

  public CExoFile m_pErrorFile {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_pErrorFile_set(swigCPtr, CExoFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoDebugInternal_m_pErrorFile_get(swigCPtr);
      CExoFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoFile(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sExecutableName {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_sExecutableName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoDebugInternal_m_sExecutableName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nMaxLogSize {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_nMaxLogSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoDebugInternal_m_nMaxLogSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCurrentLogSize {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentLogSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentLogSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCurrentErrorSize {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentErrorSize_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentErrorSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCurrentLogFileNumber {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentLogFileNumber_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentLogFileNumber_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nCurrentErrorFileNumber {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentErrorFileNumber_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoDebugInternal_m_nCurrentErrorFileNumber_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRotateLogFile {
    set {
      NWNXLibPINVOKE.CExoDebugInternal_m_bRotateLogFile_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoDebugInternal_m_bRotateLogFile_get(swigCPtr);
      return ret;
    } 
  }

  public CExoDebugInternal() : this(NWNXLibPINVOKE.new_CExoDebugInternal(), true) {
  }

  public void Assert(int nLineNumber, string sFileName, string sComment) {
    NWNXLibPINVOKE.CExoDebugInternal_Assert__SWIG_0(swigCPtr, nLineNumber, sFileName, sComment);
  }

  public void Assert(int nLineNumber, string sFileName) {
    NWNXLibPINVOKE.CExoDebugInternal_Assert__SWIG_1(swigCPtr, nLineNumber, sFileName);
  }

  public void CloseLogFiles() {
    NWNXLibPINVOKE.CExoDebugInternal_CloseLogFiles(swigCPtr);
  }

  public void FlushErrorFile() {
    NWNXLibPINVOKE.CExoDebugInternal_FlushErrorFile(swigCPtr);
  }

  public void FlushLogFile() {
    NWNXLibPINVOKE.CExoDebugInternal_FlushLogFile(swigCPtr);
  }

  public void OpenLogFiles(CExoString sExecutableName, int nMaxLogSize) {
    NWNXLibPINVOKE.CExoDebugInternal_OpenLogFiles(swigCPtr, CExoString.getCPtr(sExecutableName), nMaxLogSize);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Warning(int nLineNumber, string sFileName, string sComment) {
    NWNXLibPINVOKE.CExoDebugInternal_Warning__SWIG_0(swigCPtr, nLineNumber, sFileName, sComment);
  }

  public void Warning(int nLineNumber, string sFileName) {
    NWNXLibPINVOKE.CExoDebugInternal_Warning__SWIG_1(swigCPtr, nLineNumber, sFileName);
  }

  public void WriteToErrorFile(CExoString sLogString) {
    NWNXLibPINVOKE.CExoDebugInternal_WriteToErrorFile(swigCPtr, CExoString.getCPtr(sLogString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteToLogFile(CExoString sLogString) {
    NWNXLibPINVOKE.CExoDebugInternal_WriteToLogFile(swigCPtr, CExoString.getCPtr(sLogString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetCurrentTimestamp(CExoString sTimestamp) {
    NWNXLibPINVOKE.CExoDebugInternal_GetCurrentTimestamp(swigCPtr, CExoString.getCPtr(sTimestamp));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int CreateDirectory(CExoString sDirectory) {
    int ret = NWNXLibPINVOKE.CExoDebugInternal_CreateDirectory(swigCPtr, CExoString.getCPtr(sDirectory));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
