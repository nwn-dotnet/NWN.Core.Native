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

public class CNWSScriptVar : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSScriptVar(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSScriptVar obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSScriptVar() {
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

  public int m_int {
    set {
      NWNXLibPINVOKE.CNWSScriptVar_m_int_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSScriptVar_m_int_get(swigCPtr);
      return ret;
    } 
  }

  public float m_float {
    set {
      NWNXLibPINVOKE.CNWSScriptVar_m_float_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWSScriptVar_m_float_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_objectId {
    set {
      NWNXLibPINVOKE.CNWSScriptVar_m_objectId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSScriptVar_m_objectId_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_string {
    set {
      NWNXLibPINVOKE.CNWSScriptVar_m_string_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSScriptVar_m_string_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CScriptLocation m_location {
    set {
      NWNXLibPINVOKE.CNWSScriptVar_m_location_set(swigCPtr, CScriptLocation.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSScriptVar_m_location_get(swigCPtr);
      CScriptLocation ret = (cPtr == global::System.IntPtr.Zero) ? null : new CScriptLocation(cPtr, false);
      return ret;
    } 
  }

  public CNWSScriptVar() : this(NWNXLibPINVOKE.new_CNWSScriptVar__SWIG_0(), true) {
  }

  public CNWSScriptVar(CNWSScriptVar arg0) : this(NWNXLibPINVOKE.new_CNWSScriptVar__SWIG_1(CNWSScriptVar.getCPtr(arg0)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CNWSScriptVar __Assign(CNWSScriptVar arg0) {
    CNWSScriptVar ret = new CNWSScriptVar(NWNXLibPINVOKE.CNWSScriptVar___Assign(swigCPtr, CNWSScriptVar.getCPtr(arg0)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset(uint nVarType) {
    NWNXLibPINVOKE.CNWSScriptVar_Reset(swigCPtr, nVarType);
  }

  public bool HasInt() {
    bool ret = NWNXLibPINVOKE.CNWSScriptVar_HasInt(swigCPtr);
    return ret;
  }

  public bool HasFloat() {
    bool ret = NWNXLibPINVOKE.CNWSScriptVar_HasFloat(swigCPtr);
    return ret;
  }

  public bool HasObject() {
    bool ret = NWNXLibPINVOKE.CNWSScriptVar_HasObject(swigCPtr);
    return ret;
  }

  public bool HasString() {
    bool ret = NWNXLibPINVOKE.CNWSScriptVar_HasString(swigCPtr);
    return ret;
  }

  public bool HasLocation() {
    bool ret = NWNXLibPINVOKE.CNWSScriptVar_HasLocation(swigCPtr);
    return ret;
  }

}

}
