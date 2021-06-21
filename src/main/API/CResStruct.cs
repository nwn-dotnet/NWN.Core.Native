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

public unsafe class CResStruct : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CResStruct(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResStruct obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResStruct() {
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
          NWNXLibPINVOKE.delete_CResStruct(swigCPtr);
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

  public static unsafe implicit operator void*(CResStruct self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResStruct FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResStruct((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResStruct FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResStruct(pointer, memoryOwn) : null;
  }

  public bool Equals(CResStruct other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResStruct other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResStruct left, CResStruct right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResStruct left, CResStruct right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CResStructHeader m_cHeader {
    set {
      NWNXLibPINVOKE.CResStruct_m_cHeader_set(swigCPtr, CResStructHeader.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResStruct_m_cHeader_get(swigCPtr);
      CResStructHeader ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResStructHeader(cPtr, false);
      return ret;
    } 
  }

  public CResStructLookUp m_pLookUp {
    set {
      NWNXLibPINVOKE.CResStruct_m_pLookUp_set(swigCPtr, CResStructLookUp.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResStruct_m_pLookUp_get(swigCPtr);
      CResStructLookUp ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResStructLookUp(cPtr, false);
      return ret;
    } 
  }

  public void* m_pData {
    set {
      NWNXLibPINVOKE.CResStruct_m_pData_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CResStruct_m_pData_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public SWIGTYPE_p_CResStructInternal m_pWriteStructInternal {
    set {
      NWNXLibPINVOKE.CResStruct_m_pWriteStructInternal_set(swigCPtr, SWIGTYPE_p_CResStructInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResStruct_m_pWriteStructInternal_get(swigCPtr);
      SWIGTYPE_p_CResStructInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CResStructInternal(cPtr, false);
      return ret;
    } 
  }

  public int m_bIncludeStringHashTable {
    set {
      NWNXLibPINVOKE.CResStruct_m_bIncludeStringHashTable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResStruct_m_bIncludeStringHashTable_get(swigCPtr);
      return ret;
    } 
  }

  public CStringFieldIDType m_pStringFieldIDs {
    set {
      NWNXLibPINVOKE.CResStruct_m_pStringFieldIDs_set(swigCPtr, CStringFieldIDType.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CResStruct_m_pStringFieldIDs_get(swigCPtr);
      CStringFieldIDType ret = (cPtr == global::System.IntPtr.Zero) ? null : new CStringFieldIDType(cPtr, false);
      return ret;
    } 
  }

  public CResStruct() : this(NWNXLibPINVOKE.new_CResStruct(), true) {
  }

}

}
