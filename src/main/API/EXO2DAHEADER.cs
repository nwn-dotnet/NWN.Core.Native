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

public unsafe class EXO2DAHEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EXO2DAHEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EXO2DAHEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EXO2DAHEADER() {
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
          NWNXLibPINVOKE.delete_EXO2DAHEADER(swigCPtr);
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

  public static unsafe implicit operator void*(EXO2DAHEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe EXO2DAHEADER FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new EXO2DAHEADER((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static EXO2DAHEADER FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new EXO2DAHEADER(pointer, memoryOwn) : null;
  }

  public bool Equals(EXO2DAHEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is EXO2DAHEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(EXO2DAHEADER left, EXO2DAHEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(EXO2DAHEADER left, EXO2DAHEADER right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint nType {
    set {
      NWNXLibPINVOKE.EXO2DAHEADER_nType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.EXO2DAHEADER_nType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nVersion {
    set {
      NWNXLibPINVOKE.EXO2DAHEADER_nVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.EXO2DAHEADER_nVersion_get(swigCPtr);
      return ret;
    } 
  }

  public EXO2DAHEADER() : this(NWNXLibPINVOKE.new_EXO2DAHEADER(), true) {
  }

}

}
