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

public unsafe class CNWDomain : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWDomain(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWDomain obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWDomain() {
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
          NWNXLibPINVOKE.delete_CNWDomain(swigCPtr);
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

  public static unsafe implicit operator void*(CNWDomain self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWDomain FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWDomain((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWDomain FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWDomain(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWDomain other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWDomain other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWDomain left, CNWDomain right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWDomain left, CNWDomain right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_nNameStrref {
    set {
      NWNXLibPINVOKE.CNWDomain_m_nNameStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWDomain_m_nNameStrref_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDescriptionStrref {
    set {
      NWNXLibPINVOKE.CNWDomain_m_nDescriptionStrref_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWDomain_m_nDescriptionStrref_get(swigCPtr);
      return ret;
    } 
  }

  public CResRef m_cIcon {
    set {
      NWNXLibPINVOKE.CNWDomain_m_cIcon_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWDomain_m_cIcon_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public NativeArray<uint> m_lstSpells {
    set {
      NWNXLibPINVOKE.CNWDomain_m_lstSpells_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWDomain_m_lstSpells_get(swigCPtr);
      NativeArray<uint> retVal = new NativeArray<uint>(arrayPtr, 10);

      return retVal; // uint[10]
    }

  }

  public ushort m_nGrantedFeat {
    set {
      NWNXLibPINVOKE.CNWDomain_m_nGrantedFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWDomain_m_nGrantedFeat_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bValidDomain {
    set {
      NWNXLibPINVOKE.CNWDomain_m_bValidDomain_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWDomain_m_bValidDomain_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bCastableFeat {
    set {
      NWNXLibPINVOKE.CNWDomain_m_bCastableFeat_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWDomain_m_bCastableFeat_get(swigCPtr);
      return ret;
    } 
  }

  public CNWDomain() : this(NWNXLibPINVOKE.new_CNWDomain(), true) {
  }

  public CExoString GetNameText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWDomain_GetNameText(swigCPtr), true);
    return ret;
  }

  public CExoString GetDescriptionText() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWDomain_GetDescriptionText(swigCPtr), true);
    return ret;
  }

}

}
