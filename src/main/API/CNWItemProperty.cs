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

public unsafe class CNWItemProperty : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWItemProperty(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWItemProperty obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWItemProperty() {
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
          NWNXLibPINVOKE.delete_CNWItemProperty(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,26,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWItemProperty self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWItemProperty FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWItemProperty((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWItemProperty FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWItemProperty(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWItemProperty other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWItemProperty other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWItemProperty left, CNWItemProperty right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWItemProperty left, CNWItemProperty right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public ushort m_nPropertyName {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nPropertyName_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWItemProperty_m_nPropertyName_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nSubType {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nSubType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWItemProperty_m_nSubType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCostTable {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nCostTable_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWItemProperty_m_nCostTable_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nCostTableValue {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nCostTableValue_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWItemProperty_m_nCostTableValue_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nParam1 {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nParam1_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWItemProperty_m_nParam1_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nParam1Value {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nParam1Value_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWItemProperty_m_nParam1Value_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nChanceOfAppearing {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nChanceOfAppearing_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWItemProperty_m_nChanceOfAppearing_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bUseable {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_bUseable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWItemProperty_m_bUseable_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nUsesPerDay {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nUsesPerDay_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWItemProperty_m_nUsesPerDay_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nDurationType {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nDurationType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWItemProperty_m_nDurationType_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sCustomTag {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_sCustomTag_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWItemProperty_m_sCustomTag_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nID {
    set {
      NWNXLibPINVOKE.CNWItemProperty_m_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWItemProperty_m_nID_get(swigCPtr);
      return ret;
    } 
  }

  public CNWItemProperty() : this(NWNXLibPINVOKE.new_CNWItemProperty(), true) {
  }

}

}
