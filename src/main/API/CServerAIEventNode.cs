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

public unsafe class CServerAIEventNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CServerAIEventNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerAIEventNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerAIEventNode() {
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
          NWNXLibPINVOKE.delete_CServerAIEventNode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,25,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CServerAIEventNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CServerAIEventNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CServerAIEventNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CServerAIEventNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CServerAIEventNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CServerAIEventNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CServerAIEventNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CServerAIEventNode left, CServerAIEventNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CServerAIEventNode left, CServerAIEventNode right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public uint m_nCalendarDay {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nCalendarDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CServerAIEventNode_m_nCalendarDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nTimeOfDay {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nTimeOfDay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CServerAIEventNode_m_nTimeOfDay_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nCallerObjectId {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nCallerObjectId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CServerAIEventNode_m_nCallerObjectId_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nObjectId {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nObjectId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CServerAIEventNode_m_nObjectId_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nEventId {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_nEventId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CServerAIEventNode_m_nEventId_get(swigCPtr);
      return retVal;
    }

  }

  public void* m_pEventData {
    set {
      NWNXLibPINVOKE.CServerAIEventNode_m_pEventData_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CServerAIEventNode_m_pEventData_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public int SaveNode(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CServerAIEventNode_SaveNode(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public int LoadNode(CResGFF pRes, CResStruct pStruct) {
    int retVal = NWNXLibPINVOKE.CServerAIEventNode_LoadNode(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return retVal;
  }

  public CServerAIEventNode() : this(NWNXLibPINVOKE.new_CServerAIEventNode(), true) {
  }

}

}
