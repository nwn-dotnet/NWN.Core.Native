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

public class CNetLayerPlayerCDKeyInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNetLayerPlayerCDKeyInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNetLayerPlayerCDKeyInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNetLayerPlayerCDKeyInfo() {
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

  public CExoString sPublic {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_sPublic_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_sPublic_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString sResponse {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_sResponse_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_sResponse_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int bValidated {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_bValidated_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_bValidated_get(swigCPtr);
      return ret;
    } 
  }

  public uint nExpansionPack {
    set {
      NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_nExpansionPack_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerPlayerCDKeyInfo_nExpansionPack_get(swigCPtr);
      return ret;
    } 
  }

}

}