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

public class CResRef : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CResRef(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResRef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResRef() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_unsigned_char m_resRefLowerCase {
    set {
      NWNXLibPINVOKE.CResRef_m_resRefLowerCase_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResRef_m_resRefLowerCase_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_resRef {
    set {
      NWNXLibPINVOKE.CResRef_m_resRef_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResRef_m_resRef_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public CResRef() : this(NWNXLibPINVOKE.new_CResRef__SWIG_0(), true) {
  }

  public CResRef(SWIGTYPE_p_unsigned_char resRef) : this(NWNXLibPINVOKE.new_CResRef__SWIG_1(SWIGTYPE_p_unsigned_char.getCPtr(resRef)), true) {
  }

  public CResRef(CExoString sName) : this(NWNXLibPINVOKE.new_CResRef__SWIG_2(CExoString.getCPtr(sName)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CResRef(string pName) : this(NWNXLibPINVOKE.new_CResRef__SWIG_3(pName), true) {
  }

  public CResRef(SWIGTYPE_p_unsigned_char pName, byte nLength) : this(NWNXLibPINVOKE.new_CResRef__SWIG_4(SWIGTYPE_p_unsigned_char.getCPtr(pName), nLength), true) {
  }

  public void CopyToString(CExoString str) {
    NWNXLibPINVOKE.CResRef_CopyToString__SWIG_0(swigCPtr, CExoString.getCPtr(str));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CopyToString(string pStr) {
    NWNXLibPINVOKE.CResRef_CopyToString__SWIG_1(swigCPtr, pStr);
  }

  public int __NotEquals(CResRef cResRef) {
    int ret = NWNXLibPINVOKE.CResRef___NotEquals__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __NotEquals(CExoString sName) {
    int ret = NWNXLibPINVOKE.CResRef___NotEquals__SWIG_1(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __NotEquals(string pName) {
    int ret = NWNXLibPINVOKE.CResRef___NotEquals__SWIG_2(swigCPtr, pName);
    return ret;
  }

  public int __Equals(CResRef cResRef) {
    int ret = NWNXLibPINVOKE.CResRef___Equals__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __Equals(CExoString sName) {
    int ret = NWNXLibPINVOKE.CResRef___Equals__SWIG_1(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __Equals(string name) {
    int ret = NWNXLibPINVOKE.CResRef___Equals__SWIG_2(swigCPtr, name);
    return ret;
  }

  public int __Not() {
    int ret = NWNXLibPINVOKE.CResRef___Not(swigCPtr);
    return ret;
  }

  public CResRef __Assign(CResRef cResRef) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef___Assign__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef __Assign(SWIGTYPE_p_unsigned_char resRef) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef___Assign__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(resRef)), true);
    return ret;
  }

  public CResRef __Assign(CExoString sName) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef___Assign__SWIG_2(swigCPtr, CExoString.getCPtr(sName)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef __Assign(string pName) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef___Assign__SWIG_3(swigCPtr, pName), true);
    return ret;
  }

  public CResRef __Increment(CExoString sName) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef___Increment(swigCPtr, CExoString.getCPtr(sName)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetResRef(SWIGTYPE_p_unsigned_char resRef) {
    NWNXLibPINVOKE.CResRef_GetResRef__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(resRef));
  }

  public string GetResRef() {
    string ret = NWNXLibPINVOKE.CResRef_GetResRef__SWIG_1(swigCPtr);
    return ret;
  }

  public string GetResRefStr() {
    string ret = NWNXLibPINVOKE.CResRef_GetResRefStr(swigCPtr);
    return ret;
  }

  public int IsValid() {
    int ret = NWNXLibPINVOKE.CResRef_IsValid(swigCPtr);
    return ret;
  }

  public byte GetLength() {
    byte ret = NWNXLibPINVOKE.CResRef_GetLength(swigCPtr);
    return ret;
  }

}

}
