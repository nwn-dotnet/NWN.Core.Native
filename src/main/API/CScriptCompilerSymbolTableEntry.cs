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

public unsafe class CScriptCompilerSymbolTableEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptCompilerSymbolTableEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptCompilerSymbolTableEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptCompilerSymbolTableEntry() {
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
          NWNXLibPINVOKE.delete_CScriptCompilerSymbolTableEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CScriptCompilerSymbolTableEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CScriptCompilerSymbolTableEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CScriptCompilerSymbolTableEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CScriptCompilerSymbolTableEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CScriptCompilerSymbolTableEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(CScriptCompilerSymbolTableEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptCompilerSymbolTableEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptCompilerSymbolTableEntry left, CScriptCompilerSymbolTableEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptCompilerSymbolTableEntry left, CScriptCompilerSymbolTableEntry right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nSymbolType {
    set {
      NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nSymbolType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nSymbolType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSymbolSubType1 {
    set {
      NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nSymbolSubType1_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nSymbolSubType1_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSymbolSubType2 {
    set {
      NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nSymbolSubType2_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nSymbolSubType2_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nLocationPointer {
    set {
      NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nLocationPointer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nLocationPointer_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNextEntryPointer {
    set {
      NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nNextEntryPointer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptCompilerSymbolTableEntry_m_nNextEntryPointer_get(swigCPtr);
      return ret;
    } 
  }

  public CScriptCompilerSymbolTableEntry() : this(NWNXLibPINVOKE.new_CScriptCompilerSymbolTableEntry(), true) {
  }

}

}
