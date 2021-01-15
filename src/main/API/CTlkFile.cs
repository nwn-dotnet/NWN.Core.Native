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

public class CTlkFile : CExoFile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CTlkFile(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CTlkFile_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTlkFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CTlkFile(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public TLK_FILE_HEADER m_header {
    set {
      NWNXLibPINVOKE.CTlkFile_m_header_set(swigCPtr, TLK_FILE_HEADER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkFile_m_header_get(swigCPtr);
      TLK_FILE_HEADER ret = (cPtr == global::System.IntPtr.Zero) ? null : new TLK_FILE_HEADER(cPtr, false);
      return ret;
    } 
  }

  public CTlkFile(CExoString sFileName) : this(NWNXLibPINVOKE.new_CTlkFile__SWIG_0(CExoString.getCPtr(sFileName)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CTlkFile(SWIGTYPE_p_void pMemoryBuffer, int nSize) : this(NWNXLibPINVOKE.new_CTlkFile__SWIG_1(SWIGTYPE_p_void.getCPtr(pMemoryBuffer), nSize), true) {
  }

  public int ReadHeader() {
    int ret = NWNXLibPINVOKE.CTlkFile_ReadHeader(swigCPtr);
    return ret;
  }

}

}
