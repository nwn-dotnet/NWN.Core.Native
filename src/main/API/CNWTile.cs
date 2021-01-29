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

public unsafe class CNWTile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWTile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWTile(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTile() {
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
          NWNXLibPINVOKE.delete_CNWTile(swigCPtr);
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

  public bool Equals(CNWTile other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTile other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTile left, CNWTile right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTile left, CNWTile right) {
    return !Equals(left, right);
  }

  public Vector m_vModelPosition {
    set {
      NWNXLibPINVOKE.CNWTile_m_vModelPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTile_m_vModelPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int m_nID {
    set {
      NWNXLibPINVOKE.CNWTile_m_nID_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTile_m_nID_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nHeight {
    set {
      NWNXLibPINVOKE.CNWTile_m_nHeight_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTile_m_nHeight_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nGridX {
    set {
      NWNXLibPINVOKE.CNWTile_m_nGridX_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTile_m_nGridX_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nGridY {
    set {
      NWNXLibPINVOKE.CNWTile_m_nGridY_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTile_m_nGridY_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nOrientation {
    set {
      NWNXLibPINVOKE.CNWTile_m_nOrientation_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTile_m_nOrientation_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMainLight1Color {
    set {
      NWNXLibPINVOKE.CNWTile_m_nMainLight1Color_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nMainLight1Color_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMainLight2Color {
    set {
      NWNXLibPINVOKE.CNWTile_m_nMainLight2Color_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nMainLight2Color_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSourceLight1Color {
    set {
      NWNXLibPINVOKE.CNWTile_m_nSourceLight1Color_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nSourceLight1Color_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSourceLight2Color {
    set {
      NWNXLibPINVOKE.CNWTile_m_nSourceLight2Color_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nSourceLight2Color_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nReplaceTexture {
    set {
      NWNXLibPINVOKE.CNWTile_m_nReplaceTexture_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nReplaceTexture_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAnimLoop1 {
    set {
      NWNXLibPINVOKE.CNWTile_m_nAnimLoop1_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nAnimLoop1_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAnimLoop2 {
    set {
      NWNXLibPINVOKE.CNWTile_m_nAnimLoop2_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nAnimLoop2_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nAnimLoop3 {
    set {
      NWNXLibPINVOKE.CNWTile_m_nAnimLoop3_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWTile_m_nAnimLoop3_get(swigCPtr);
      return ret;
    } 
  }

  public CNWTile() : this(NWNXLibPINVOKE.new_CNWTile(), true) {
  }

  public void GetLocation(int* pX, int* pY) {
    NWNXLibPINVOKE.CNWTile_GetLocation(swigCPtr, (global::System.IntPtr)pX, (global::System.IntPtr)pY);
  }

  public void SetID(int nID) {
    NWNXLibPINVOKE.CNWTile_SetID(swigCPtr, nID);
  }

  public void SetPosition(int nX, int nY, int nHeight, float fHeightInc) {
    NWNXLibPINVOKE.CNWTile_SetPosition(swigCPtr, nX, nY, nHeight, fHeightInc);
  }

  public void SetOrientation(int nOrientation) {
    NWNXLibPINVOKE.CNWTile_SetOrientation(swigCPtr, nOrientation);
  }

  public void RotateCanonicalToRealTile(float fX, float fY, float* fNewX, float* fNewY) {
    NWNXLibPINVOKE.CNWTile_RotateCanonicalToRealTile(swigCPtr, fX, fY, (global::System.IntPtr)fNewX, (global::System.IntPtr)fNewY);
  }

  public void RotateRealToCanonicalTile(float fX, float fY, float* fNewX, float* fNewY) {
    NWNXLibPINVOKE.CNWTile_RotateRealToCanonicalTile(swigCPtr, fX, fY, (global::System.IntPtr)fNewX, (global::System.IntPtr)fNewY);
  }

  public void RotateCanonicalToReal(float fX, float fY, float* fNewX, float* fNewY) {
    NWNXLibPINVOKE.CNWTile_RotateCanonicalToReal(swigCPtr, fX, fY, (global::System.IntPtr)fNewX, (global::System.IntPtr)fNewY);
  }

  public void RotateRealToCanonical(float fX, float fY, float* fNewX, float* fNewY) {
    NWNXLibPINVOKE.CNWTile_RotateRealToCanonical(swigCPtr, fX, fY, (global::System.IntPtr)fNewX, (global::System.IntPtr)fNewY);
  }

  public void GetMainLightColor(byte* pMainLight1Color, byte* pMainLight2Color) {
    NWNXLibPINVOKE.CNWTile_GetMainLightColor(swigCPtr, (global::System.IntPtr)pMainLight1Color, (global::System.IntPtr)pMainLight2Color);
  }

  public void GetSourceLightColor(byte* pSourceLight1Color, byte* pSourceLight2Color) {
    NWNXLibPINVOKE.CNWTile_GetSourceLightColor(swigCPtr, (global::System.IntPtr)pSourceLight1Color, (global::System.IntPtr)pSourceLight2Color);
  }

  public void GetAnimLoop(byte* pAnimLoop1, byte* pAnimLoop2, byte* pAnimLoop3) {
    NWNXLibPINVOKE.CNWTile_GetAnimLoop(swigCPtr, (global::System.IntPtr)pAnimLoop1, (global::System.IntPtr)pAnimLoop2, (global::System.IntPtr)pAnimLoop3);
  }

  public void SetMainLightColor(byte nMainLight1Color, byte nMainLight2Color) {
    NWNXLibPINVOKE.CNWTile_SetMainLightColor(swigCPtr, nMainLight1Color, nMainLight2Color);
  }

  public void SetSourceLightColor(byte nSourceLight1Color, byte nSourceLight2Color) {
    NWNXLibPINVOKE.CNWTile_SetSourceLightColor(swigCPtr, nSourceLight1Color, nSourceLight2Color);
  }

  public void SetReplaceTexture(byte nValue) {
    NWNXLibPINVOKE.CNWTile_SetReplaceTexture(swigCPtr, nValue);
  }

  public void SetAnimLoop(byte nAnimLoop1, byte nAnimLoop2, byte nAnimLoop3) {
    NWNXLibPINVOKE.CNWTile_SetAnimLoop(swigCPtr, nAnimLoop1, nAnimLoop2, nAnimLoop3);
  }

}

}
