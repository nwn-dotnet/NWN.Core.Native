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

public unsafe class SSubNetProfile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SSubNetProfile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SSubNetProfile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SSubNetProfile() {
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
          NWNXLibPINVOKE.delete_SSubNetProfile(swigCPtr);
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

  public static unsafe implicit operator void*(SSubNetProfile self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe SSubNetProfile FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new SSubNetProfile((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static SSubNetProfile FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new SSubNetProfile(pointer, memoryOwn) : null;
  }

  public bool Equals(SSubNetProfile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is SSubNetProfile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(SSubNetProfile left, SSubNetProfile right) {
    return Equals(left, right);
  }

  public static bool operator !=(SSubNetProfile left, SSubNetProfile right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint nPlayerID {
    set {
      NWNXLibPINVOKE.SSubNetProfile_nPlayerID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.SSubNetProfile_nPlayerID_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString sPlayerName {
    set {
      NWNXLibPINVOKE.SSubNetProfile_sPlayerName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.SSubNetProfile_sPlayerName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString sCDPublicKey {
    set {
      NWNXLibPINVOKE.SSubNetProfile_sCDPublicKey_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.SSubNetProfile_sCDPublicKey_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public ulong nStartTime {
    set {
      NWNXLibPINVOKE.SSubNetProfile_nStartTime_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.SSubNetProfile_nStartTime_get(swigCPtr);
      return retVal;
    }

  }

  public ulong nTotalBytesSent {
    set {
      NWNXLibPINVOKE.SSubNetProfile_nTotalBytesSent_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.SSubNetProfile_nTotalBytesSent_get(swigCPtr);
      return retVal;
    }

  }

  public ulong nTotalBytesReceived {
    set {
      NWNXLibPINVOKE.SSubNetProfile_nTotalBytesReceived_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.SSubNetProfile_nTotalBytesReceived_get(swigCPtr);
      return retVal;
    }

  }

  public SSubNetProfile() : this(NWNXLibPINVOKE.new_SSubNetProfile(), true) {
  }

}

}
