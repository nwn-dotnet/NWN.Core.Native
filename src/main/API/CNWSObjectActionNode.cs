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

public class CNWSObjectActionNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSObjectActionNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSObjectActionNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSObjectActionNode() {
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
          NWNXLibPINVOKE.delete_CNWSObjectActionNode(swigCPtr);
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

  public bool Equals(CNWSObjectActionNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSObjectActionNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSObjectActionNode left, CNWSObjectActionNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSObjectActionNode left, CNWSObjectActionNode right) {
    return !Equals(left, right);
  }

  public uint m_nActionId {
    set {
      NWNXLibPINVOKE.CNWSObjectActionNode_m_nActionId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSObjectActionNode_m_nActionId_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int m_nParamType {
    set {
      NWNXLibPINVOKE.CNWSObjectActionNode_m_nParamType_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSObjectActionNode_m_nParamType_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_pParameter {
    set {
      NWNXLibPINVOKE.CNWSObjectActionNode_m_pParameter_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSObjectActionNode_m_pParameter_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nGroupActionId {
    set {
      NWNXLibPINVOKE.CNWSObjectActionNode_m_nGroupActionId_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSObjectActionNode_m_nGroupActionId_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nParameters {
    set {
      NWNXLibPINVOKE.CNWSObjectActionNode_m_nParameters_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSObjectActionNode_m_nParameters_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bInterruptable {
    set {
      NWNXLibPINVOKE.CNWSObjectActionNode_m_bInterruptable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSObjectActionNode_m_bInterruptable_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSObjectActionNode() : this(NWNXLibPINVOKE.new_CNWSObjectActionNode(), true) {
  }

}

}
