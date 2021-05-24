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

public unsafe class CExoInputEventDesc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoInputEventDesc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoInputEventDesc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoInputEventDesc() {
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
          NWNXLibPINVOKE.delete_CExoInputEventDesc(swigCPtr);
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

  public static unsafe implicit operator void*(CExoInputEventDesc self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoInputEventDesc FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoInputEventDesc((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoInputEventDesc FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoInputEventDesc(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoInputEventDesc other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoInputEventDesc other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoInputEventDesc left, CExoInputEventDesc right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoInputEventDesc left, CExoInputEventDesc right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CExoString m_Label {
    set {
      NWNXLibPINVOKE.CExoInputEventDesc_m_Label_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoInputEventDesc_m_Label_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nID {
    set {
      NWNXLibPINVOKE.CExoInputEventDesc_m_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEventDesc_m_nID_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nInputDeviceType {
    set {
      NWNXLibPINVOKE.CExoInputEventDesc_m_nInputDeviceType_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoInputEventDesc_m_nInputDeviceType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nInputDevice {
    set {
      NWNXLibPINVOKE.CExoInputEventDesc_m_nInputDevice_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoInputEventDesc_m_nInputDevice_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nInputDeviceElement {
    set {
      NWNXLibPINVOKE.CExoInputEventDesc_m_nInputDeviceElement_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEventDesc_m_nInputDeviceElement_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nInputMode {
    set {
      NWNXLibPINVOKE.CExoInputEventDesc_m_nInputMode_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoInputEventDesc_m_nInputMode_get(swigCPtr);
      return ret;
    } 
  }

  public CExoInputEventDesc() : this(NWNXLibPINVOKE.new_CExoInputEventDesc(), true) {
  }

}

}
