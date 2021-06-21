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

public unsafe class CNetLayerSessionInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNetLayerSessionInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNetLayerSessionInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNetLayerSessionInfo() {
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
          NWNXLibPINVOKE.delete_CNetLayerSessionInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CNetLayerSessionInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNetLayerSessionInfo FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNetLayerSessionInfo((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNetLayerSessionInfo FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNetLayerSessionInfo(pointer, memoryOwn) : null;
  }

  public bool Equals(CNetLayerSessionInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNetLayerSessionInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNetLayerSessionInfo left, CNetLayerSessionInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNetLayerSessionInfo left, CNetLayerSessionInfo right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nConnectionId {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nConnectionId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nConnectionId_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sSessionName {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_sSessionName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerSessionInfo_m_sSessionName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nProtocol {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nProtocol_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nProtocol_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPort {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPort_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPort_get(swigCPtr);
      return ret;
    } 
  }

  public NativeArray<uint> m_nPingPacketSent {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingPacketSent_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingPacketSent_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 4);

      return retVal; // uint[4]
    }

  }

  public NativeArray<uint> m_nPingPacketReceived {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingPacketReceived_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingPacketReceived_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 4);

      return retVal; // uint[4]
    }

  }

  public uint m_nPingTotalTime {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingTotalTime_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingTotalTime_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPingNumPackets {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingNumPackets_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingNumPackets_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bPingActive {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_bPingActive_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_bPingActive_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPingPacketTimeout {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingPacketTimeout_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nPingPacketTimeout_get(swigCPtr);
      return ret;
    } 
  }

  public CExtendedServerInfo m_pExtendedInfo {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_pExtendedInfo_set(swigCPtr, CExtendedServerInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerSessionInfo_m_pExtendedInfo_get(swigCPtr);
      CExtendedServerInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExtendedServerInfo(cPtr, false);
      return ret;
    } 
  }

  public int m_bHasChanged {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_bHasChanged_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_bHasChanged_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bServerDetailsChanged {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_bServerDetailsChanged_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_bServerDetailsChanged_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bRecievedBNXR {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_bRecievedBNXR_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_bRecievedBNXR_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nLastUpdate {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nLastUpdate_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nLastUpdate_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sVisibleAddress {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_sVisibleAddress_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerSessionInfo_m_sVisibleAddress_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public NWSyncAdvertisement m_nwsyncData {
    set {
      NWNXLibPINVOKE.CNetLayerSessionInfo_m_nwsyncData_set(swigCPtr, NWSyncAdvertisement.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNetLayerSessionInfo_m_nwsyncData_get(swigCPtr);
      NWSyncAdvertisement ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWSyncAdvertisement(cPtr, false);
      return ret;
    } 
  }

  public CNetLayerSessionInfo() : this(NWNXLibPINVOKE.new_CNetLayerSessionInfo(), true) {
  }

  public void Clean() {
    NWNXLibPINVOKE.CNetLayerSessionInfo_Clean(swigCPtr);
  }

}

}
