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

public unsafe class CNWItem : ICNWItem, global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWItem() {
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
          NWNXLibPINVOKE.delete_CNWItem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
  global::System.Runtime.InteropServices.HandleRef ICNWItem.GetInterfaceCPtr() {
    return new global::System.Runtime.InteropServices.HandleRef(this, NWNXLibPINVOKE.CNWItem_ICNWItem_GetInterfaceCPtr(swigCPtr.Handle));
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,26,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWItem self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWItem FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWItem((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWItem FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWItem(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWItem other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWItem other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWItem left, CNWItem right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWItem left, CNWItem right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public NativeArray<byte> m_nLayeredTextureColors {
    set {
      NWNXLibPINVOKE.CNWItem_m_nLayeredTextureColors_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWItem_m_nLayeredTextureColors_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 6);

      return retVal; // byte[6]
    }

  }

  public NativeArray<global::System.IntPtr> m_pLayeredTextureColorsPerPart {
    set {
      NWNXLibPINVOKE.CNWItem_m_pLayeredTextureColorsPerPart_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWItem_m_pLayeredTextureColorsPerPart_get(swigCPtr);
      NativeArray<global::System.IntPtr> retVal = new NativeArray<global::System.IntPtr>(arrayPtr, 6);

      return retVal; // byte*[6]
    }

  }

  public uint m_nBaseItem {
    set {
      NWNXLibPINVOKE.CNWItem_m_nBaseItem_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWItem_m_nBaseItem_get(swigCPtr);
      return ret;
    } 
  }

  public CNWItem() : this(NWNXLibPINVOKE.new_CNWItem(), true) {
  }

  public byte GetLayeredTextureColorPerPart(byte nTexture, byte nPart) {
    byte ret = NWNXLibPINVOKE.CNWItem_GetLayeredTextureColorPerPart(swigCPtr, nTexture, nPart);
    return ret;
  }

  public void SetLayeredTextureColorPerPart(byte nTexture, byte nPart, byte nColor) {
    NWNXLibPINVOKE.CNWItem_SetLayeredTextureColorPerPart(swigCPtr, nTexture, nPart, nColor);
  }

}

}
