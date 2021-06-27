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

public unsafe class ENCAPSULATED_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ENCAPSULATED_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ENCAPSULATED_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ENCAPSULATED_HEADER() {
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
          NWNXLibPINVOKE.delete_ENCAPSULATED_HEADER(swigCPtr);
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

  public static unsafe implicit operator void*(ENCAPSULATED_HEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe ENCAPSULATED_HEADER FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new ENCAPSULATED_HEADER((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static ENCAPSULATED_HEADER FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new ENCAPSULATED_HEADER(pointer, memoryOwn) : null;
  }

  public bool Equals(ENCAPSULATED_HEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is ENCAPSULATED_HEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(ENCAPSULATED_HEADER left, ENCAPSULATED_HEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(ENCAPSULATED_HEADER left, ENCAPSULATED_HEADER right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint nFileType {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nFileType_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nFileType_get(swigCPtr);
      return retVal;
    }

  }

  public uint nFileVersion {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nFileVersion_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nFileVersion_get(swigCPtr);
      return retVal;
    }

  }

  public uint nNumLanguages {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nNumLanguages_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nNumLanguages_get(swigCPtr);
      return retVal;
    }

  }

  public uint nLocalizedStringSize {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nLocalizedStringSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nLocalizedStringSize_get(swigCPtr);
      return retVal;
    }

  }

  public uint nEntries {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nEntries_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nEntries_get(swigCPtr);
      return retVal;
    }

  }

  public uint nOffsetToLocalizedString {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nOffsetToLocalizedString_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nOffsetToLocalizedString_get(swigCPtr);
      return retVal;
    }

  }

  public uint nOffsetToKeyList {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nOffsetToKeyList_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nOffsetToKeyList_get(swigCPtr);
      return retVal;
    }

  }

  public uint nOffsetToResourceList {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nOffsetToResourceList_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nOffsetToResourceList_get(swigCPtr);
      return retVal;
    }

  }

  public uint nBuildYear {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nBuildYear_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nBuildYear_get(swigCPtr);
      return retVal;
    }

  }

  public uint nBuildDay {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nBuildDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nBuildDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint nDescriptionStringRef {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_nDescriptionStringRef_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_HEADER_nDescriptionStringRef_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> pMD5 {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_pMD5_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.ENCAPSULATED_HEADER_pMD5_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16);

      return retVal; // byte[16]
    }

  }

  public NativeArray<byte> pUnused {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_HEADER_pUnused_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.ENCAPSULATED_HEADER_pUnused_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 100);

      return retVal; // byte[100]
    }

  }

  public ENCAPSULATED_HEADER() : this(NWNXLibPINVOKE.new_ENCAPSULATED_HEADER(), true) {
  }

}

}
