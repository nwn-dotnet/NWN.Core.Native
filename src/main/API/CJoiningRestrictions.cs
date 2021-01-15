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

public class CJoiningRestrictions : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CJoiningRestrictions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CJoiningRestrictions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CJoiningRestrictions() {
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

  public int bAllowLocal {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowLocal_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowLocal_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowServer {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowServer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowServer_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowVault {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowVault_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowVault_get(swigCPtr);
      return ret;
    } 
  }

  public int bFixedParties {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bFixedParties_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bFixedParties_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowFighter {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowFighter_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowFighter_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowBarbarian {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowBarbarian_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowBarbarian_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowRanger {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowRanger_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowRanger_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowPaladin {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowPaladin_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowPaladin_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowWizard {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowWizard_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowWizard_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowSorcerer {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowSorcerer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowSorcerer_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowCleric {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowCleric_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowCleric_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowDruid {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowDruid_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowDruid_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowRogue {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowRogue_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowRogue_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowBard {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowBard_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowBard_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowMonk {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowMonk_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowMonk_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowHuman {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowHuman_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowHuman_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowElf {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowElf_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowElf_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowDwarf {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowDwarf_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowDwarf_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowGnome {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowGnome_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowGnome_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowHalfling {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowHalfling_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowHalfling_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowHalfOrc {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowHalfOrc_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowHalfOrc_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowHalfElf {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowHalfElf_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowHalfElf_get(swigCPtr);
      return ret;
    } 
  }

  public int nMaxPlayers {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_nMaxPlayers_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_nMaxPlayers_get(swigCPtr);
      return ret;
    } 
  }

  public int nMaxParties {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_nMaxParties_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_nMaxParties_get(swigCPtr);
      return ret;
    } 
  }

  public int nMaxItemPoints {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_nMaxItemPoints_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_nMaxItemPoints_get(swigCPtr);
      return ret;
    } 
  }

  public int nMaxStatTotal {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_nMaxStatTotal_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_nMaxStatTotal_get(swigCPtr);
      return ret;
    } 
  }

  public int nMinLevel {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_nMinLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_nMinLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int nMaxLevel {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_nMaxLevel_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_nMaxLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int bAllowLocalVaultChars {
    set {
      NWNXLibPINVOKE.CJoiningRestrictions_bAllowLocalVaultChars_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CJoiningRestrictions_bAllowLocalVaultChars_get(swigCPtr);
      return ret;
    } 
  }

}

}
