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

public class CSpell_Add : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CSpell_Add(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CSpell_Add obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CSpell_Add() {
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

  public uint m_nSpellID {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nSpellID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CSpell_Add_m_nSpellID_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bReadied {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_bReadied_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CSpell_Add_m_bReadied_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDomainSpell {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_bDomainSpell_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CSpell_Add_m_bDomainSpell_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMetaType {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nMetaType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CSpell_Add_m_nMetaType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSpellSlot {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nSpellSlot_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CSpell_Add_m_nSpellSlot_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSpellLevel {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nSpellLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CSpell_Add_m_nSpellLevel_get(swigCPtr);
      return ret;
    } 
  }

}

}
