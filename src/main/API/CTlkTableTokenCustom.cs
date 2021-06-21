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

public unsafe class CTlkTableTokenCustom : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CTlkTableTokenCustom(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTlkTableTokenCustom obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CTlkTableTokenCustom() {
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
          NWNXLibPINVOKE.delete_CTlkTableTokenCustom(swigCPtr);
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

  public static unsafe implicit operator void*(CTlkTableTokenCustom self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CTlkTableTokenCustom FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CTlkTableTokenCustom((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CTlkTableTokenCustom FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CTlkTableTokenCustom(pointer, memoryOwn) : null;
  }

  public bool Equals(CTlkTableTokenCustom other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CTlkTableTokenCustom other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CTlkTableTokenCustom left, CTlkTableTokenCustom right) {
    return Equals(left, right);
  }

  public static bool operator !=(CTlkTableTokenCustom left, CTlkTableTokenCustom right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nNumber {
    set {
      NWNXLibPINVOKE.CTlkTableTokenCustom_m_nNumber_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CTlkTableTokenCustom_m_nNumber_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sValue {
    set {
      NWNXLibPINVOKE.CTlkTableTokenCustom_m_sValue_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTableTokenCustom_m_sValue_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CTlkTableTokenCustom() : this(NWNXLibPINVOKE.new_CTlkTableTokenCustom(), true) {
  }

}

}
