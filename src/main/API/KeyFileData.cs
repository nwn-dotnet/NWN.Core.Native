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

public unsafe class KeyFileData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal KeyFileData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KeyFileData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KeyFileData() {
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
          NWNXLibPINVOKE.delete_KeyFileData(swigCPtr);
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

  public static unsafe implicit operator void*(KeyFileData self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe KeyFileData FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new KeyFileData((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static KeyFileData FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new KeyFileData(pointer, memoryOwn) : null;
  }

  public bool Equals(KeyFileData other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is KeyFileData other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(KeyFileData left, KeyFileData right) {
    return Equals(left, right);
  }

  public static bool operator !=(KeyFileData left, KeyFileData right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int month {
    set {
      NWNXLibPINVOKE.KeyFileData_month_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.KeyFileData_month_get(swigCPtr);
      return ret;
    } 
  }

  public int day {
    set {
      NWNXLibPINVOKE.KeyFileData_day_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.KeyFileData_day_get(swigCPtr);
      return ret;
    } 
  }

  public int year {
    set {
      NWNXLibPINVOKE.KeyFileData_year_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.KeyFileData_year_get(swigCPtr);
      return ret;
    } 
  }

  public int build {
    set {
      NWNXLibPINVOKE.KeyFileData_build_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.KeyFileData_build_get(swigCPtr);
      return ret;
    } 
  }

  public NativeArray<byte> program {
    set {
      NWNXLibPINVOKE.KeyFileData_program_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.KeyFileData_program_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16);

      return retVal; // byte[16]
    }

  }

  public NativeArray<byte> description {
    set {
      NWNXLibPINVOKE.KeyFileData_description_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.KeyFileData_description_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 988);

      return retVal; // byte[988]
    }

  }

  public KeyFileData() : this(NWNXLibPINVOKE.new_KeyFileData(), true) {
  }

}

}
