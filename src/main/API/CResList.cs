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

public unsafe class CResList : CResStruct {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CResList(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,26,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CResList self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResList FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResList((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResList FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResList(pointer, memoryOwn) : null;
  }

  public bool Equals(CResList other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResList other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResList left, CResList right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResList left, CResList right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public string m_pLabel {
    set {
      NWNXLibPINVOKE.CResList_m_pLabel_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CResList_m_pLabel_get(swigCPtr);
      return ret;
    } 
  }

  public CResList() : this(NWNXLibPINVOKE.new_CResList(), true) {
  }

}

}
