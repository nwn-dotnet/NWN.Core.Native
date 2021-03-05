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

public unsafe class NWSyncAdvertisement : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public NWSyncAdvertisement(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public NWSyncAdvertisement(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NWSyncAdvertisement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NWSyncAdvertisement() {
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
          NWNXLibPINVOKE.delete_NWSyncAdvertisement(swigCPtr);
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

  public static unsafe implicit operator void*(NWSyncAdvertisement self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(NWSyncAdvertisement self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(NWSyncAdvertisement other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is NWSyncAdvertisement other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(NWSyncAdvertisement left, NWSyncAdvertisement right) {
    return Equals(left, right);
  }

  public static bool operator !=(NWSyncAdvertisement left, NWSyncAdvertisement right) {
    return !Equals(left, right);
  }

  public SHA1 m_primary_manifest {
    set {
      NWNXLibPINVOKE.NWSyncAdvertisement_m_primary_manifest_set(swigCPtr, SHA1.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.NWSyncAdvertisement_m_primary_manifest_get(swigCPtr);
      SHA1 ret = (cPtr == global::System.IntPtr.Zero) ? null : new SHA1(cPtr, false);
      return ret;
    } 
  }

  public VectorNWSyncAdvertisementManifest m_additional_manifests {
    set {
      NWNXLibPINVOKE.NWSyncAdvertisement_m_additional_manifests_set(swigCPtr, VectorNWSyncAdvertisementManifest.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.NWSyncAdvertisement_m_additional_manifests_get(swigCPtr);
      VectorNWSyncAdvertisementManifest ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorNWSyncAdvertisementManifest(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_url {
    set {
      NWNXLibPINVOKE.NWSyncAdvertisement_m_url_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.NWSyncAdvertisement_m_url_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public NWSyncAdvertisement() : this(NWNXLibPINVOKE.new_NWSyncAdvertisement(), true) {
  }

}

}
