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

public unsafe class CExoResourceImageFile : CExoPackedFile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CExoResourceImageFile(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CExoResourceImageFile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoResourceImageFile(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CExoResourceImageFile_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoResourceImageFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CExoResourceImageFile(swigCPtr);
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

  public static unsafe implicit operator void*(CExoResourceImageFile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CExoResourceImageFile self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoResourceImageFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoResourceImageFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoResourceImageFile left, CExoResourceImageFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoResourceImageFile left, CExoResourceImageFile right) {
    return !Equals(left, right);
  }

  public byte* m_pResourceImage {
    set {
      NWNXLibPINVOKE.CExoResourceImageFile_m_pResourceImage_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CExoResourceImageFile_m_pResourceImage_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public CExoResourceImageFile() : this(NWNXLibPINVOKE.new_CExoResourceImageFile(), true) {
  }

  public override void AddRefCount() {
    NWNXLibPINVOKE.CExoResourceImageFile_AddRefCount(swigCPtr);
  }

  public override void AddAsyncRefCount() {
    NWNXLibPINVOKE.CExoResourceImageFile_AddAsyncRefCount(swigCPtr);
  }

  public override int CloseFile() {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_CloseFile(swigCPtr);
    return ret;
  }

  public override int CloseAsyncFile() {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_CloseAsyncFile(swigCPtr);
    return ret;
  }

  public override void DeleteRefCount() {
    NWNXLibPINVOKE.CExoResourceImageFile_DeleteRefCount(swigCPtr);
  }

  public override void DeleteAsyncRefCount() {
    NWNXLibPINVOKE.CExoResourceImageFile_DeleteAsyncRefCount(swigCPtr);
  }

  public override uint GetResourceSize(RESID nID) {
    uint ret = NWNXLibPINVOKE.CExoResourceImageFile_GetResourceSize(swigCPtr, RESID.getCPtr(nID));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int Initialize() {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_Initialize(swigCPtr);
    return ret;
  }

  public override int OpenFile() {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_OpenFile__SWIG_0(swigCPtr);
    return ret;
  }

  public override int OpenFile(byte* pCipher) {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_OpenFile__SWIG_1(swigCPtr, (global::System.IntPtr)pCipher);
    return ret;
  }

  public override int OpenAsyncFile() {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_OpenAsyncFile(swigCPtr);
    return ret;
  }

  public override uint ReadResource(RESID nID, void* pData, uint nSize, uint nDataOffset) {
    uint ret = NWNXLibPINVOKE.CExoResourceImageFile_ReadResource(swigCPtr, RESID.getCPtr(nID), (global::System.IntPtr)pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ReadResourceAsync(RESID nID, void* pData, uint nSize, uint nDataOffset) {
    NWNXLibPINVOKE.CExoResourceImageFile_ReadResourceAsync(swigCPtr, RESID.getCPtr(nID), (global::System.IntPtr)pData, nSize, nDataOffset);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int LoadHeader(string expectOid, byte nType) {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_LoadHeader__SWIG_0(swigCPtr, expectOid, nType);
    return ret;
  }

  public override int LoadHeader(string expectOid) {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_LoadHeader__SWIG_1(swigCPtr, expectOid);
    return ret;
  }

  public override int UnloadHeader() {
    int ret = NWNXLibPINVOKE.CExoResourceImageFile_UnloadHeader(swigCPtr);
    return ret;
  }

  public virtual void* GetResource(RESID nID) { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoResourceImageFile_GetResource(swigCPtr, RESID.getCPtr(nID));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return (void*)retVal;
  }

  public void** GetKeyList() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoResourceImageFile_GetKeyList(swigCPtr);
    return (void**)retVal;
  }

  public ENCAPSULATED_KEYLISTENTRY GetKeyListEntry(uint nIndex) {
    ENCAPSULATED_KEYLISTENTRY ret = new ENCAPSULATED_KEYLISTENTRY(NWNXLibPINVOKE.CExoResourceImageFile_GetKeyListEntry(swigCPtr, nIndex), true);
    return ret;
  }

  public ENCAPSULATED_RESLISTENTRY GetResourceListEntry(RESID nID) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResourceImageFile_GetResourceListEntry(swigCPtr, RESID.getCPtr(nID));
    ENCAPSULATED_RESLISTENTRY ret = (cPtr == global::System.IntPtr.Zero) ? null : new ENCAPSULATED_RESLISTENTRY(cPtr, false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ENCAPSULATED_HEADER GetHeader() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoResourceImageFile_GetHeader(swigCPtr);
    ENCAPSULATED_HEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new ENCAPSULATED_HEADER(cPtr, false);
    return ret;
  }

}

}
