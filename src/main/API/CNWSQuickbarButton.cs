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

public unsafe class CNWSQuickbarButton : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSQuickbarButton(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSQuickbarButton obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSQuickbarButton() {
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
          NWNXLibPINVOKE.delete_CNWSQuickbarButton(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSQuickbarButton self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSQuickbarButton FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSQuickbarButton((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSQuickbarButton FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSQuickbarButton(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSQuickbarButton other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSQuickbarButton other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSQuickbarButton left, CNWSQuickbarButton right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSQuickbarButton left, CNWSQuickbarButton right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_oidItem {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_oidItem_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_oidItem_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidSecondaryItem {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_oidSecondaryItem_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_oidSecondaryItem_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nObjectType {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_nObjectType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_nObjectType_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nMultiClass {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_nMultiClass_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_nMultiClass_get(swigCPtr);
      return retVal;
    }

  }

  public CResRef m_cResRef {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_cResRef_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSQuickbarButton_m_cResRef_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCommandLabel {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_sCommandLabel_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSQuickbarButton_m_sCommandLabel_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCommandLine {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_sCommandLine_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSQuickbarButton_m_sCommandLine_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sToolTip {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_sToolTip_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSQuickbarButton_m_sToolTip_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_nINTParam1 {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_nINTParam1_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_nINTParam1_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nMetaType {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_nMetaType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_nMetaType_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nDomainLevel {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_nDomainLevel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_nDomainLevel_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAssociateType {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_nAssociateType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_nAssociateType_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidAssociate {
    set {
      NWNXLibPINVOKE.CNWSQuickbarButton_m_oidAssociate_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSQuickbarButton_m_oidAssociate_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSQuickbarButton() : this(NWNXLibPINVOKE.new_CNWSQuickbarButton(), true) {
  }

}

}
