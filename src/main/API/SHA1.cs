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

public unsafe class SHA1 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SHA1(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SHA1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SHA1() {
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
          NWNXLibPINVOKE.delete_SHA1(swigCPtr);
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

  public static unsafe implicit operator void*(SHA1 self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe SHA1 FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new SHA1((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static SHA1 FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new SHA1(pointer, memoryOwn) : null;
  }

  public bool Equals(SHA1 other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is SHA1 other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(SHA1 left, SHA1 right) {
    return Equals(left, right);
  }

  public static bool operator !=(SHA1 left, SHA1 right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public bool m_empty {
    set {
      NWNXLibPINVOKE.SHA1_m_empty_set(swigCPtr, value);
    } 
    get {
      bool ret = NWNXLibPINVOKE.SHA1_m_empty_get(swigCPtr);
      return ret;
    } 
  }

  public NativeArray<byte> m_data {
    set {
      NWNXLibPINVOKE.SHA1_m_data_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.SHA1_m_data_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 20);

      return retVal; // byte[20]
    }

  }

  public string m_hex {
    set {
      NWNXLibPINVOKE.SHA1_m_hex_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.SHA1_m_hex_get(swigCPtr);
      return ret;
    } 
  }

  public SHA1() : this(NWNXLibPINVOKE.new_SHA1(), true) {
  }

}

}
