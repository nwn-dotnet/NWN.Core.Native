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

public class CNWActionNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWActionNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWActionNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWActionNode() {
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

  public bool Equals(CNWActionNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWActionNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWActionNode left, CNWActionNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWActionNode left, CNWActionNode right) {
    return !Equals(left, right);
  }

  public ushort nGroupId {
    set {
      NWNXLibPINVOKE.CNWActionNode_nGroupId_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWActionNode_nGroupId_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nActionId {
    set {
      NWNXLibPINVOKE.CNWActionNode_nActionId_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWActionNode_nActionId_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nSpecialAttackId {
    set {
      NWNXLibPINVOKE.CNWActionNode_nSpecialAttackId_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWActionNode_nSpecialAttackId_get(swigCPtr);
      return ret;
    } 
  }

  public uint nSpellId {
    set {
      NWNXLibPINVOKE.CNWActionNode_nSpellId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWActionNode_nSpellId_get(swigCPtr);
      return ret;
    } 
  }

  public Vector vTargetPos {
    set {
      NWNXLibPINVOKE.CNWActionNode_vTargetPos_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWActionNode_vTargetPos_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public uint oidTarget {
    set {
      NWNXLibPINVOKE.CNWActionNode_oidTarget_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWActionNode_oidTarget_get(swigCPtr);
      return ret;
    } 
  }

}

}
