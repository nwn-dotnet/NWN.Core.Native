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

public class CExoAliasList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoAliasList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoAliasList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoAliasList() {
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
          NWNXLibPINVOKE.delete_CExoAliasList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_CExoAliasListInternal m_pcExoAliasListInternal {
    set {
      NWNXLibPINVOKE.CExoAliasList_m_pcExoAliasListInternal_set(swigCPtr, SWIGTYPE_p_CExoAliasListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoAliasList_m_pcExoAliasListInternal_get(swigCPtr);
      SWIGTYPE_p_CExoAliasListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CExoAliasListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoAliasList() : this(NWNXLibPINVOKE.new_CExoAliasList(), true) {
  }

  public void Add(CExoString alias, CExoString path) {
    NWNXLibPINVOKE.CExoAliasList_Add(swigCPtr, CExoString.getCPtr(alias), CExoString.getCPtr(path));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    NWNXLibPINVOKE.CExoAliasList_Clear(swigCPtr);
  }

  public void Delete(CExoString alias) {
    NWNXLibPINVOKE.CExoAliasList_Delete(swigCPtr, CExoString.getCPtr(alias));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetAliasPath(CExoString alias, int nSize) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoAliasList_GetAliasPath__SWIG_0(swigCPtr, CExoString.getCPtr(alias), nSize), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString GetAliasPath(CExoString alias) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoAliasList_GetAliasPath__SWIG_1(swigCPtr, CExoString.getCPtr(alias)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString ResolveFileName(CExoString sFileName, ushort nType) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoAliasList_ResolveFileName(swigCPtr, CExoString.getCPtr(sFileName), nType), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
