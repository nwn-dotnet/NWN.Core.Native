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

public unsafe class CNWSCreatureStats_ClassInfoArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSCreatureStats_ClassInfoArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCreatureStats_ClassInfoArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCreatureStats_ClassInfoArray() {
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
          NWNXLibPINVOKE.delete_CNWSCreatureStats_ClassInfoArray(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSCreatureStats_ClassInfoArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSCreatureStats_ClassInfoArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSCreatureStats_ClassInfoArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSCreatureStats_ClassInfoArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSCreatureStats_ClassInfoArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSCreatureStats_ClassInfoArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCreatureStats_ClassInfoArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCreatureStats_ClassInfoArray left, CNWSCreatureStats_ClassInfoArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCreatureStats_ClassInfoArray left, CNWSCreatureStats_ClassInfoArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CNWSCreatureStats_ClassInfo this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CNWSCreatureStats_ClassInfoArray(int nElements) : this(NWNXLibPINVOKE.new_CNWSCreatureStats_ClassInfoArray(nElements), true) {
  }

  public CNWSCreatureStats_ClassInfo GetItem(int index) {
    CNWSCreatureStats_ClassInfo ret = new CNWSCreatureStats_ClassInfo(NWNXLibPINVOKE.CNWSCreatureStats_ClassInfoArray_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CNWSCreatureStats_ClassInfo value) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfoArray_SetItem(swigCPtr, index, CNWSCreatureStats_ClassInfo.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CNWSCreatureStats_ClassInfoArray FromPointer(CNWSCreatureStats_ClassInfo ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfoArray_FromPointer(CNWSCreatureStats_ClassInfo.getCPtr(ptr));
    CNWSCreatureStats_ClassInfoArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreatureStats_ClassInfoArray(cPtr, false);
    return ret;
  }

}

}
