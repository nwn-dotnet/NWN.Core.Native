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

public class CFeatUseListEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CFeatUseListEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CFeatUseListEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CFeatUseListEntry() {
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

  public ushort m_nFeat {
    set {
      NWNXLibPINVOKE.CFeatUseListEntry_m_nFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CFeatUseListEntry_m_nFeat_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nUsedToday {
    set {
      NWNXLibPINVOKE.CFeatUseListEntry_m_nUsedToday_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CFeatUseListEntry_m_nUsedToday_get(swigCPtr);
      return ret;
    } 
  }

}

}
