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

public class CScriptSourceFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CScriptSourceFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptSourceFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptSourceFile() {
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

  public CScriptSourceFile() : this(NWNXLibPINVOKE.new_CScriptSourceFile(), true) {
  }

  public int LoadScript(CExoString sFileName, SWIGTYPE_p_p_char pScript, SWIGTYPE_p_unsigned_int nScriptLength) {
    int ret = NWNXLibPINVOKE.CScriptSourceFile_LoadScript(swigCPtr, CExoString.getCPtr(sFileName), SWIGTYPE_p_p_char.getCPtr(pScript), SWIGTYPE_p_unsigned_int.getCPtr(nScriptLength));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnloadScript() {
    NWNXLibPINVOKE.CScriptSourceFile_UnloadScript(swigCPtr);
  }

}

}
