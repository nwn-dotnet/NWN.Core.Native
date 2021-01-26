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

public class CVirtualMachineFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CVirtualMachineFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVirtualMachineFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVirtualMachineFile() {
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
          NWNXLibPINVOKE.delete_CVirtualMachineFile(swigCPtr);
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

  public bool Equals(CVirtualMachineFile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CVirtualMachineFile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CVirtualMachineFile left, CVirtualMachineFile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CVirtualMachineFile left, CVirtualMachineFile right) {
    return !Equals(left, right);
  }

  public CVirtualMachineFile() : this(NWNXLibPINVOKE.new_CVirtualMachineFile(), true) {
  }

  public int LoadFile(CExoString sFileName) {
    int ret = NWNXLibPINVOKE.CVirtualMachineFile_LoadFile(swigCPtr, CExoString.getCPtr(sFileName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnloadFile() {
    NWNXLibPINVOKE.CVirtualMachineFile_UnloadFile(swigCPtr);
  }

  public void GetData(SWIGTYPE_p_p_char pData, SWIGTYPE_p_unsigned_int nSize) {
    NWNXLibPINVOKE.CVirtualMachineFile_GetData(swigCPtr, SWIGTYPE_p_p_char.getCPtr(pData), SWIGTYPE_p_unsigned_int.getCPtr(nSize));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
