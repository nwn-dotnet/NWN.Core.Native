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

public class CExoEncapsulatedFile : CExoPackedFile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CExoEncapsulatedFile(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CExoEncapsulatedFile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoEncapsulatedFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CExoEncapsulatedFile(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(CExoEncapsulatedFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoEncapsulatedFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoEncapsulatedFile left, CExoEncapsulatedFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoEncapsulatedFile left, CExoEncapsulatedFile right) {
    return !Equals(left, right);
  }

  public CExoLocString m_lsDescription {
    set {
      NWNXLibPINVOKE.CExoEncapsulatedFile_m_lsDescription_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoEncapsulatedFile_m_lsDescription_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public ENCAPSULATED_HEADER m_pEncapsulatedHeader {
    set {
      NWNXLibPINVOKE.CExoEncapsulatedFile_m_pEncapsulatedHeader_set(swigCPtr, ENCAPSULATED_HEADER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoEncapsulatedFile_m_pEncapsulatedHeader_get(swigCPtr);
      ENCAPSULATED_HEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new ENCAPSULATED_HEADER(cPtr, false);
      return ret;
    } 
  }

  public ENCAPSULATED_RESLISTENTRY_E1 m_pResListEntry {
    set {
      NWNXLibPINVOKE.CExoEncapsulatedFile_m_pResListEntry_set(swigCPtr, ENCAPSULATED_RESLISTENTRY_E1.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoEncapsulatedFile_m_pResListEntry_get(swigCPtr);
      ENCAPSULATED_RESLISTENTRY_E1 ret = (cPtr == global::System.IntPtr.Zero) ? null : new ENCAPSULATED_RESLISTENTRY_E1(cPtr, false);
      return ret;
    } 
  }

  public byte m_nFileType {
    set {
      NWNXLibPINVOKE.CExoEncapsulatedFile_m_nFileType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CExoEncapsulatedFile_m_nFileType_get(swigCPtr);
      return ret;
    } 
  }

  public CExoEncapsulatedFile() : this(NWNXLibPINVOKE.new_CExoEncapsulatedFile(), true) {
  }

  public override void AddRefCount() {
    NWNXLibPINVOKE.CExoEncapsulatedFile_AddRefCount(swigCPtr);
  }

  public override void AddAsyncRefCount() {
    NWNXLibPINVOKE.CExoEncapsulatedFile_AddAsyncRefCount(swigCPtr);
  }

  public override int CloseFile() {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_CloseFile(swigCPtr);
    return ret;
  }

  public override int CloseAsyncFile() {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_CloseAsyncFile(swigCPtr);
    return ret;
  }

  public override void DeleteRefCount() {
    NWNXLibPINVOKE.CExoEncapsulatedFile_DeleteRefCount(swigCPtr);
  }

  public override void DeleteAsyncRefCount() {
    NWNXLibPINVOKE.CExoEncapsulatedFile_DeleteAsyncRefCount(swigCPtr);
  }

  public override uint GetResourceSize(RESID nID) {
    uint ret = NWNXLibPINVOKE.CExoEncapsulatedFile_GetResourceSize(swigCPtr, RESID.getCPtr(nID));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int Initialize() {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_Initialize(swigCPtr);
    return ret;
  }

  public override int OpenFile() {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_OpenFile__SWIG_0(swigCPtr);
    return ret;
  }

  public override int OpenFile(SWIGTYPE_p_unsigned_char pCipher) {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_OpenFile__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(pCipher));
    return ret;
  }

  public override int OpenAsyncFile() {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_OpenAsyncFile(swigCPtr);
    return ret;
  }

  public override uint ReadResource(RESID nID, System.IntPtr pData, uint nSize, uint nDataOffset) {
    uint ret = NWNXLibPINVOKE.CExoEncapsulatedFile_ReadResource(swigCPtr, RESID.getCPtr(nID), pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ReadResourceAsync(RESID nID, System.IntPtr pData, uint nSize, uint nDataOffset) {
    NWNXLibPINVOKE.CExoEncapsulatedFile_ReadResourceAsync(swigCPtr, RESID.getCPtr(nID), pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int LoadHeader(byte nType) {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_LoadHeader__SWIG_0(swigCPtr, nType);
    return ret;
  }

  public override int LoadHeader() {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_LoadHeader__SWIG_1(swigCPtr);
    return ret;
  }

  public override int UnloadHeader() {
    int ret = NWNXLibPINVOKE.CExoEncapsulatedFile_UnloadHeader(swigCPtr);
    return ret;
  }

}

}
