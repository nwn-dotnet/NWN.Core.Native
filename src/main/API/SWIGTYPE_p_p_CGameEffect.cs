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

public class SWIGTYPE_p_p_CGameEffect {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SWIGTYPE_p_p_CGameEffect(global::System.IntPtr cPtr, bool futureUse) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  protected SWIGTYPE_p_p_CGameEffect() {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SWIGTYPE_p_p_CGameEffect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public bool Equals(SWIGTYPE_p_p_CGameEffect other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is SWIGTYPE_p_p_CGameEffect other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(SWIGTYPE_p_p_CGameEffect left, SWIGTYPE_p_p_CGameEffect right) {
    return Equals(left, right);
  }

  public static bool operator !=(SWIGTYPE_p_p_CGameEffect left, SWIGTYPE_p_p_CGameEffect right) {
    return !Equals(left, right);
  }
}

}
