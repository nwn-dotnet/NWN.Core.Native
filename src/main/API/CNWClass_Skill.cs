//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class CNWClass_Skill : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWClass_Skill(global::System.IntPtr cPtr, bool cMemoryOwn) {
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