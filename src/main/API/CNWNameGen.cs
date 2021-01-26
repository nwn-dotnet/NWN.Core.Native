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

public class CNWNameGen : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWNameGen(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWNameGen obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWNameGen() {
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
          NWNXLibPINVOKE.delete_CNWNameGen(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(CNWNameGen other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWNameGen other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWNameGen left, CNWNameGen right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWNameGen left, CNWNameGen right) {
    return !Equals(left, right);
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CNWNameGen_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWNameGen_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nTableRace {
    set {
      NWNXLibPINVOKE.CNWNameGen_m_nTableRace_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWNameGen_m_nTableRace_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nTableNameType {
    set {
      NWNXLibPINVOKE.CNWNameGen_m_nTableNameType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWNameGen_m_nTableNameType_get(swigCPtr);
      return ret;
    } 
  }

  public CNWNameGen() : this(NWNXLibPINVOKE.new_CNWNameGen(), true) {
  }

  public int LoadNameTable(CExoString sTable) {
    int ret = NWNXLibPINVOKE.CNWNameGen_LoadNameTable(swigCPtr, CExoString.getCPtr(sTable));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnloadNameTable() {
    NWNXLibPINVOKE.CNWNameGen_UnloadNameTable(swigCPtr);
  }

  public CExoString GetRandomName() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWNameGen_GetRandomName__SWIG_0(swigCPtr), true);
    return ret;
  }

  public CExoString GetRandomName(ushort nRace, byte nNameType) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWNameGen_GetRandomName__SWIG_1(swigCPtr, nRace, nNameType), true);
    return ret;
  }

}

}
