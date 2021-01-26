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

public class CNWSPlayerStoreGUI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSPlayerStoreGUI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerStoreGUI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerStoreGUI() {
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

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(CNWSPlayerStoreGUI other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerStoreGUI other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerStoreGUI left, CNWSPlayerStoreGUI right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerStoreGUI left, CNWSPlayerStoreGUI right) {
    return !Equals(left, right);
  }

  public uint m_oidOpen {
    set {
      NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_oidOpen_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_oidOpen_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSelectedPanel {
    set {
      NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_nSelectedPanel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_nSelectedPanel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSelectedPage {
    set {
      NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_nSelectedPage_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_nSelectedPage_get(swigCPtr);
      return ret;
    } 
  }

  public Vector m_vOpenPosition {
    set {
      NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_vOpenPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerStoreGUI_m_vOpenPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerStoreGUI() : this(NWNXLibPINVOKE.new_CNWSPlayerStoreGUI(), true) {
  }

  public void OpenStore(CNWSPlayer pPlayer, uint oidStore, char nMarkUp, char nMarkDown) {
    NWNXLibPINVOKE.CNWSPlayerStoreGUI_OpenStore__SWIG_0(swigCPtr, CNWSPlayer.getCPtr(pPlayer), oidStore, nMarkUp, nMarkDown);
  }

  public void OpenStore(CNWSPlayer pPlayer, uint oidStore, char nMarkUp) {
    NWNXLibPINVOKE.CNWSPlayerStoreGUI_OpenStore__SWIG_1(swigCPtr, CNWSPlayer.getCPtr(pPlayer), oidStore, nMarkUp);
  }

  public void OpenStore(CNWSPlayer pPlayer, uint oidStore) {
    NWNXLibPINVOKE.CNWSPlayerStoreGUI_OpenStore__SWIG_2(swigCPtr, CNWSPlayer.getCPtr(pPlayer), oidStore);
  }

  public void CloseStore(CNWSPlayer pPlayer, int bTellClient) {
    NWNXLibPINVOKE.CNWSPlayerStoreGUI_CloseStore__SWIG_0(swigCPtr, CNWSPlayer.getCPtr(pPlayer), bTellClient);
  }

  public void CloseStore(CNWSPlayer pPlayer) {
    NWNXLibPINVOKE.CNWSPlayerStoreGUI_CloseStore__SWIG_1(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
  }

}

}
