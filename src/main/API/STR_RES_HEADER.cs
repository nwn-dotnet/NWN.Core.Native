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

public unsafe class STR_RES_HEADER : STR_RES_HEADER_OLD {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal STR_RES_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.STR_RES_HEADER_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(STR_RES_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_STR_RES_HEADER(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(STR_RES_HEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe STR_RES_HEADER FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new STR_RES_HEADER((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static STR_RES_HEADER FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new STR_RES_HEADER(pointer, memoryOwn) : null;
  }

  public bool Equals(STR_RES_HEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is STR_RES_HEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(STR_RES_HEADER left, STR_RES_HEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(STR_RES_HEADER left, STR_RES_HEADER right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public float fSoundLength {
    set {
      NWNXLibPINVOKE.STR_RES_HEADER_fSoundLength_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.STR_RES_HEADER_fSoundLength_get(swigCPtr);
      return retVal;
    }

  }

  public STR_RES_HEADER() : this(NWNXLibPINVOKE.new_STR_RES_HEADER(), true) {
  }

}

}
