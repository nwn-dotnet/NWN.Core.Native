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

public class CResGFFField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CResGFFField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResGFFField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResGFFField() {
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

  public uint m_nType {
    set {
      NWNXLibPINVOKE.CResGFFField_m_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFField_m_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLabelIndex {
    set {
      NWNXLibPINVOKE.CResGFFField_m_nLabelIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFField_m_nLabelIndex_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nDataOrDataOffset {
    set {
      NWNXLibPINVOKE.CResGFFField_m_nDataOrDataOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGFFField_m_nDataOrDataOffset_get(swigCPtr);
      return ret;
    } 
  }

}

}
