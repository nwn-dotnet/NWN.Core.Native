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

public unsafe class CNWSPlayerJournalQuest : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerJournalQuest(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerJournalQuest obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerJournalQuest() {
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
          NWNXLibPINVOKE.delete_CNWSPlayerJournalQuest(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPlayerJournalQuest self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayerJournalQuest FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayerJournalQuest((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayerJournalQuest FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayerJournalQuest(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayerJournalQuest other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerJournalQuest other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerJournalQuest left, CNWSPlayerJournalQuest right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerJournalQuest left, CNWSPlayerJournalQuest right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public int m_bOpen {
    set {
      NWNXLibPINVOKE.CNWSPlayerJournalQuest_m_bOpen_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerJournalQuest_m_bOpen_get(swigCPtr);
      return retVal;
    }

  }

  public CExoArrayListCNWSPlayerJournalQuestUpdates m_lstModifications {
    set {
      NWNXLibPINVOKE.CNWSPlayerJournalQuest_m_lstModifications_set(swigCPtr, CExoArrayListCNWSPlayerJournalQuestUpdates.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerJournalQuest_m_lstModifications_get(swigCPtr);
      CExoArrayListCNWSPlayerJournalQuestUpdates ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSPlayerJournalQuestUpdates(cPtr, false);
      return ret;
    } 
  }

  public int m_bFullUpdateNeeded {
    set {
      NWNXLibPINVOKE.CNWSPlayerJournalQuest_m_bFullUpdateNeeded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayerJournalQuest_m_bFullUpdateNeeded_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPlayerJournalQuest() : this(NWNXLibPINVOKE.new_CNWSPlayerJournalQuest(), true) {
  }

}

}
