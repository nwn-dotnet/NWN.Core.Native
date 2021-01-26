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

public class CNWClass_Skill : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWClass_Skill(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWClass_Skill obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWClass_Skill() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
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

  public bool Equals(CNWClass_Skill other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWClass_Skill other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWClass_Skill left, CNWClass_Skill right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWClass_Skill left, CNWClass_Skill right) {
    return !Equals(left, right);
  }

  public ushort nSkill {
    set {
      NWNXLibPINVOKE.CNWClass_Skill_nSkill_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWClass_Skill_nSkill_get(swigCPtr);
      return ret;
    } 
  }

  public int bClassSkill {
    set {
      NWNXLibPINVOKE.CNWClass_Skill_bClassSkill_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_Skill_bClassSkill_get(swigCPtr);
      return ret;
    } 
  }

}

}
