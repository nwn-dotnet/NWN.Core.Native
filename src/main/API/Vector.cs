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

public unsafe class Vector : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vector() {
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
          NWNXLibPINVOKE.delete_Vector(swigCPtr);
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

  public static unsafe implicit operator void*(Vector self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe Vector FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new Vector((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static Vector FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new Vector(pointer, memoryOwn) : null;
  }

  public bool Equals(Vector other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is Vector other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(Vector left, Vector right) {
    return Equals(left, right);
  }

  public static bool operator !=(Vector left, Vector right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public float x {
    set {
      NWNXLibPINVOKE.Vector_x_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.Vector_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      NWNXLibPINVOKE.Vector_y_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.Vector_y_get(swigCPtr);
      return ret;
    } 
  }

  public float z {
    set {
      NWNXLibPINVOKE.Vector_z_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.Vector_z_get(swigCPtr);
      return ret;
    } 
  }

  public Vector() : this(NWNXLibPINVOKE.new_Vector__SWIG_0(), true) {
  }

  public Vector(float xx, float yy, float zz) : this(NWNXLibPINVOKE.new_Vector__SWIG_1(xx, yy, zz), true) {
  }

}

}
