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

public unsafe class CLastUpdatePartyObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CLastUpdatePartyObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CLastUpdatePartyObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CLastUpdatePartyObject() {
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
          NWNXLibPINVOKE.delete_CLastUpdatePartyObject(swigCPtr);
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

  public static unsafe implicit operator void*(CLastUpdatePartyObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CLastUpdatePartyObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CLastUpdatePartyObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CLastUpdatePartyObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CLastUpdatePartyObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CLastUpdatePartyObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CLastUpdatePartyObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CLastUpdatePartyObject left, CLastUpdatePartyObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CLastUpdatePartyObject left, CLastUpdatePartyObject right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public CResRef m_cPortrait {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_cPortrait_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdatePartyObject_m_cPortrait_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public ushort m_nPortraitId {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nPortraitId_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nPortraitId_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bActive {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bActive_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bActive_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nPlayerId {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nPlayerId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nPlayerId_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAIState {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIState_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIState_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAIStateAction {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIStateAction_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIStateAction_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAIStateActivities {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIStateActivities_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIStateActivities_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidAIStateActee {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_oidAIStateActee_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_oidAIStateActee_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nCurrentHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nCurrentHitPoints_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nCurrentHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nBaseHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nBaseHitPoints_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nBaseHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nTemporaryHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nTemporaryHitPoints_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nTemporaryHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nMaxHitPoints {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nMaxHitPoints_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nMaxHitPoints_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nAIStateReaction {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIStateReaction_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAIStateReaction_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bCombatState {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bCombatState_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bCombatState_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidArea {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_oidArea_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_oidArea_get(swigCPtr);
      return retVal;
    }

  }

  public Vector m_vPosition {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_vPosition_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLastUpdatePartyObject_m_vPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int m_bPC {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bPC_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bPC_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bFreeWill {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bFreeWill_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bFreeWill_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPartyLeader {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bPartyLeader_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bPartyLeader_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSingletonParty {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bSingletonParty_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bSingletonParty_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bInvitedToParty {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bInvitedToParty_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bInvitedToParty_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSummonedFamiliar {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bSummonedFamiliar_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bSummonedFamiliar_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nAssociateType {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAssociateType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_nAssociateType_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidMaster {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_oidMaster_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_oidMaster_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bSummonedAnimalCompanion {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bSummonedAnimalCompanion_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bSummonedAnimalCompanion_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPoisoned {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bPoisoned_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bPoisoned_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bDiseased {
    set {
      NWNXLibPINVOKE.CLastUpdatePartyObject_m_bDiseased_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CLastUpdatePartyObject_m_bDiseased_get(swigCPtr);
      return retVal;
    }

  }

  public CLastUpdatePartyObject() : this(NWNXLibPINVOKE.new_CLastUpdatePartyObject(), true) {
  }

}

}
