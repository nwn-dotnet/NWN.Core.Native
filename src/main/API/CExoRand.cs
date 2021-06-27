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

public unsafe class CExoRand : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoRand(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoRand obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoRand() {
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
          NWNXLibPINVOKE.delete_CExoRand(swigCPtr);
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

  public static unsafe implicit operator void*(CExoRand self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoRand FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoRand((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoRand FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoRand(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoRand other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoRand other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoRand left, CExoRand right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoRand left, CExoRand right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoRandInternal m_pcExoRandInternal {
    set {
      NWNXLibPINVOKE.CExoRand_m_pcExoRandInternal_set(swigCPtr, CExoRandInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoRand_m_pcExoRandInternal_get(swigCPtr);
      CExoRandInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoRandInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoRand() : this(NWNXLibPINVOKE.new_CExoRand(), true) {
  }

  public uint Rand() {
    uint retVal = NWNXLibPINVOKE.CExoRand_Rand(swigCPtr);
    return retVal;
  }

  public CExoString GetString(ushort nLength) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoRand_GetString(swigCPtr, nLength), true);
    return ret;
  }

  public void SignalEvent() {
    NWNXLibPINVOKE.CExoRand_SignalEvent__SWIG_0(swigCPtr);
  }

  public void SignalEvent(uint nTimeStamp) {
    NWNXLibPINVOKE.CExoRand_SignalEvent__SWIG_1(swigCPtr, nTimeStamp);
  }

}

}
