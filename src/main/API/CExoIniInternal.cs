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

public unsafe class CExoIniInternal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoIniInternal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoIniInternal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoIniInternal() {
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
          NWNXLibPINVOKE.delete_CExoIniInternal(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CExoIniInternal self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoIniInternal FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoIniInternal((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoIniInternal FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoIniInternal(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoIniInternal other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoIniInternal other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoIniInternal left, CExoIniInternal right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoIniInternal left, CExoIniInternal right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoString m_pFileNames {
    set {
      NWNXLibPINVOKE.CExoIniInternal_m_pFileNames_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoIniInternal_m_pFileNames_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoIniInternal(CExoString sUserDirectory) : this(NWNXLibPINVOKE.new_CExoIniInternal(CExoString.getCPtr(sUserDirectory)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int ReadIniEntry(CExoString sValue, int idxIniFile, CExoString sSection, CExoString sEntry) {
    int retVal = NWNXLibPINVOKE.CExoIniInternal_ReadIniEntry(swigCPtr, CExoString.getCPtr(sValue), idxIniFile, CExoString.getCPtr(sSection), CExoString.getCPtr(sEntry));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int WriteIniEntry(CExoString sValue, int idxIniFile, CExoString sSection, CExoString sEntry, int stripIfEmpty) {
    int retVal = NWNXLibPINVOKE.CExoIniInternal_WriteIniEntry(swigCPtr, CExoString.getCPtr(sValue), idxIniFile, CExoString.getCPtr(sSection), CExoString.getCPtr(sEntry), stripIfEmpty);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

}

}
