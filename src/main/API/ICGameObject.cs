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

public interface ICGameObject {
  [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
  global::System.Runtime.InteropServices.HandleRef GetInterfaceCPtr();
  void setM_idSelf(uint value);
  uint getM_idSelf();
  void setM_nObjectType(byte value);
  byte getM_nObjectType();
  void setM_pNwnxData(void* value);
  void* getM_pNwnxData();
  void SetId(uint oidNew);
  void ResetUpdateTimes(uint nCalendarDay, uint nTimeOfDay);
  SWIGTYPE_p_CNWCObject AsNWCObject();
  CNWSObject AsNWSObject();
  SWIGTYPE_p_CNWCDoor AsNWCDoor();
  CNWSDoor AsNWSDoor();
  SWIGTYPE_p_CNWCModule AsNWCModule();
  CNWSModule AsNWSModule();
  SWIGTYPE_p_CNWCArea AsNWCArea();
  CNWSArea AsNWSArea();
  SWIGTYPE_p_CNWCCreature AsNWCCreature();
  CNWSCreature AsNWSCreature();
  SWIGTYPE_p_CNWCItem AsNWCItem();
  CNWSItem AsNWSItem();
  SWIGTYPE_p_CNWCTrigger AsNWCTrigger();
  CNWSTrigger AsNWSTrigger();
  SWIGTYPE_p_CNWCProjectile AsNWCProjectile();
  CNWSPlayerTURD AsNWSPlayerTURD();
  CNWSPlaceable AsNWSPlaceable();
  SWIGTYPE_p_CNWCPlaceable AsNWCPlaceable();
  CNWSAreaOfEffectObject AsNWSAreaOfEffectObject();
  SWIGTYPE_p_CNWCAreaOfEffectObject AsNWCAreaOfEffectObject();
  CNWSWaypoint AsNWSWaypoint();
  CNWSEncounter AsNWSEncounter();
  SWIGTYPE_p_CNWCStore AsNWCStore();
  CNWSStore AsNWSStore();
  CNWSSoundObject AsNWSSoundObject();
  SWIGTYPE_p_CNWCSoundObject AsNWCSoundObject();
}

}
