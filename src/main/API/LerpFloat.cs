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

public unsafe class LerpFloat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LerpFloat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LerpFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LerpFloat() {
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
          NWNXLibPINVOKE.delete_LerpFloat(swigCPtr);
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

  public static unsafe implicit operator void*(LerpFloat self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe LerpFloat FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new LerpFloat((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static LerpFloat FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new LerpFloat(pointer, memoryOwn) : null;
  }

  public bool Equals(LerpFloat other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is LerpFloat other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(LerpFloat left, LerpFloat right) {
    return Equals(left, right);
  }

  public static bool operator !=(LerpFloat left, LerpFloat right) {
    return !Equals(left, right);
  }
/*@SWIG@*/
  public LerpTimerType m_timer_type {
    set {
      NWNXLibPINVOKE.LerpFloat_m_timer_type_set(swigCPtr, (int)value);
    } 
    get {
      LerpTimerType ret = (LerpTimerType)NWNXLibPINVOKE.LerpFloat_m_timer_type_get(swigCPtr);
      return ret;
    } 
  }

  public float m_value_to {
    set {
      NWNXLibPINVOKE.LerpFloat_m_value_to_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.LerpFloat_m_value_to_get(swigCPtr);
      return retVal;
    }

  }

  public float m_value_from {
    set {
      NWNXLibPINVOKE.LerpFloat_m_value_from_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.LerpFloat_m_value_from_get(swigCPtr);
      return retVal;
    }

  }

  public int m_lerp_type {
    set {
      NWNXLibPINVOKE.LerpFloat_m_lerp_type_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.LerpFloat_m_lerp_type_get(swigCPtr);
      return retVal;
    }

  }

  public float m_lerp_duration {
    set {
      NWNXLibPINVOKE.LerpFloat_m_lerp_duration_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.LerpFloat_m_lerp_duration_get(swigCPtr);
      return retVal;
    }

  }

  public float m_lerp_existing_progress {
    set {
      NWNXLibPINVOKE.LerpFloat_m_lerp_existing_progress_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.LerpFloat_m_lerp_existing_progress_get(swigCPtr);
      return retVal;
    }

  }

  public unsafe class TimeType : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal TimeType(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TimeType obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~TimeType() {
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
            NWNXLibPINVOKE.delete_LerpFloat_TimeType(swigCPtr);
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
  
    public static unsafe implicit operator void*(TimeType self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe TimeType FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new TimeType((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static TimeType FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new TimeType(pointer, memoryOwn) : null;
    }
  
    public bool Equals(TimeType other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is TimeType other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(TimeType left, TimeType right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(TimeType left, TimeType right) {
      return !Equals(left, right);
    }
  /*@SWIG@*/
      public unsafe class World : global::System.IDisposable {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
      
        internal World(global::System.IntPtr cPtr, bool cMemoryOwn) {
          swigCMemOwn = cMemoryOwn;
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }
      
        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(World obj) {
          return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }
      
        ~World() {
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
                NWNXLibPINVOKE.delete_LerpFloat_TimeType_World(swigCPtr);
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
      
        public static unsafe implicit operator void*(World self) {
          return (void*)self.swigCPtr.Handle;
        }
      
        public static unsafe World FromPointer(void* pointer, bool memoryOwn = false) {
          return pointer != null ? new World((global::System.IntPtr)pointer, memoryOwn) : null;
        }
      
        public static World FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
          return pointer != global::System.IntPtr.Zero ? new World(pointer, memoryOwn) : null;
        }
      
        public bool Equals(World other) {
          if (ReferenceEquals(null, other)) {
            return false;
          }
      
          if (ReferenceEquals(this, other)) {
            return true;
          }
      
          return Pointer.Equals(other.Pointer);
        }
      
        public override bool Equals(object obj) {
          return ReferenceEquals(this, obj) || obj is World other && Equals(other);
        }
      
        public override int GetHashCode() {
          return swigCPtr.Handle.GetHashCode();
        }
      
        public static bool operator ==(World left, World right) {
          return Equals(left, right);
        }
      
        public static bool operator !=(World left, World right) {
          return !Equals(left, right);
        }
      /*@SWIG@*/
        public uint m_day {
          set {
            NWNXLibPINVOKE.LerpFloat_TimeType_World_m_day_set(swigCPtr, value);
          } 
          get {
            uint retVal = NWNXLibPINVOKE.LerpFloat_TimeType_World_m_day_get(swigCPtr);
            return retVal;
          }
      
        }
      
        public uint m_time {
          set {
            NWNXLibPINVOKE.LerpFloat_TimeType_World_m_time_set(swigCPtr, value);
          } 
          get {
            uint retVal = NWNXLibPINVOKE.LerpFloat_TimeType_World_m_time_get(swigCPtr);
            return retVal;
          }
      
        }
      
        public World() : this(NWNXLibPINVOKE.new_LerpFloat_TimeType_World(), true) {
        }
      
        public bool _OpLessThan(LerpFloat.TimeType.World rhs) {
          bool ret = NWNXLibPINVOKE.LerpFloat_TimeType_World__OpLessThan(swigCPtr, LerpFloat.TimeType.World.getCPtr(rhs));
          if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
          return ret;
        }
      
        public bool _OpEquals(LerpFloat.TimeType.World rhs) {
          bool ret = NWNXLibPINVOKE.LerpFloat_TimeType_World__OpEquals(swigCPtr, LerpFloat.TimeType.World.getCPtr(rhs));
          if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
          return ret;
        }
      
      }
  
    public ulong m_real {
      set {
        NWNXLibPINVOKE.LerpFloat_TimeType_m_real_set(swigCPtr, value);
      } 
      get {
        ulong retVal = NWNXLibPINVOKE.LerpFloat_TimeType_m_real_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public LerpFloat.TimeType.World m_world {
      set {
        NWNXLibPINVOKE.LerpFloat_TimeType_m_world_set(swigCPtr, LerpFloat.TimeType.World.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.LerpFloat_TimeType_m_world_get(swigCPtr);
        LerpFloat.TimeType.World ret = (cPtr == global::System.IntPtr.Zero) ? null : new LerpFloat.TimeType.World(cPtr, false);
        return ret;
      } 
    }
  
    public TimeType() : this(NWNXLibPINVOKE.new_LerpFloat_TimeType(), true) {
    }
  
  }

  public LerpFloat.TimeType m_lerp_start {
    set {
      NWNXLibPINVOKE.LerpFloat_m_lerp_start_set(swigCPtr, LerpFloat.TimeType.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.LerpFloat_m_lerp_start_get(swigCPtr);
      LerpFloat.TimeType ret = (cPtr == global::System.IntPtr.Zero) ? null : new LerpFloat.TimeType(cPtr, false);
      return ret;
    } 
  }

  public LerpFloat.TimeType m_lerp_end {
    set {
      NWNXLibPINVOKE.LerpFloat_m_lerp_end_set(swigCPtr, LerpFloat.TimeType.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.LerpFloat_m_lerp_end_get(swigCPtr);
      LerpFloat.TimeType ret = (cPtr == global::System.IntPtr.Zero) ? null : new LerpFloat.TimeType(cPtr, false);
      return ret;
    } 
  }

  public LerpFloat(float initial) : this(NWNXLibPINVOKE.new_LerpFloat__SWIG_0(initial), true) {
  }

  public LerpFloat() : this(NWNXLibPINVOKE.new_LerpFloat__SWIG_1(), true) {
  }

  public LerpFloat(LerpTimerType type, float to, float from, int lerpType, float lerpDuration, float existingProgress) : this(NWNXLibPINVOKE.new_LerpFloat__SWIG_2((int)type, to, from, lerpType, lerpDuration, existingProgress), true) {
  }

  public LerpFloat(LerpTimerType type, float to, float from, int lerpType, float lerpDuration) : this(NWNXLibPINVOKE.new_LerpFloat__SWIG_3((int)type, to, from, lerpType, lerpDuration), true) {
  }

  public LerpFloat(LerpFloat other) : this(NWNXLibPINVOKE.new_LerpFloat__SWIG_4(LerpFloat.getCPtr(other)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public LerpFloat _OpAssign(float to) {
    LerpFloat ret = new LerpFloat(NWNXLibPINVOKE.LerpFloat__OpAssign__SWIG_0(swigCPtr, to), false);
    return ret;
  }

  public LerpFloat _OpAssign(LerpFloat other) {
    LerpFloat ret = new LerpFloat(NWNXLibPINVOKE.LerpFloat__OpAssign__SWIG_1(swigCPtr, LerpFloat.getCPtr(other)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool _OpEquals(LerpFloat rhs) {
    bool ret = NWNXLibPINVOKE.LerpFloat__OpEquals(swigCPtr, LerpFloat.getCPtr(rhs));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LerpTimerType TimerType() {
    LerpTimerType ret = (LerpTimerType)NWNXLibPINVOKE.LerpFloat_TimerType(swigCPtr);
    return ret;
  }

  public int LerpType() {
    int retVal = NWNXLibPINVOKE.LerpFloat_LerpType(swigCPtr);
    return retVal;
  }

  public float LerpDuration() {
    float retVal = NWNXLibPINVOKE.LerpFloat_LerpDuration(swigCPtr);
    return retVal;
  }

  public float Value() {
    float retVal = NWNXLibPINVOKE.LerpFloat_Value(swigCPtr);
    return retVal;
  }

  public float ValueFrom() {
    float retVal = NWNXLibPINVOKE.LerpFloat_ValueFrom(swigCPtr);
    return retVal;
  }

  public float Progress() {
    float retVal = NWNXLibPINVOKE.LerpFloat_Progress(swigCPtr);
    return retVal;
  }

  public float Lerped() {
    float retVal = NWNXLibPINVOKE.LerpFloat_Lerped(swigCPtr);
    return retVal;
  }

  public void WriteGFF(CResGFF pRes, CResStruct pStruct, byte* szLabel) {
    NWNXLibPINVOKE.LerpFloat_WriteGFF(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct), szLabel);
  }

  public void AssignStatic(float to) {
    NWNXLibPINVOKE.LerpFloat_AssignStatic(swigCPtr, to);
  }

  public void AdoptLerp(LerpFloat other) {
    NWNXLibPINVOKE.LerpFloat_AdoptLerp(swigCPtr, LerpFloat.getCPtr(other));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Refresh() {
    NWNXLibPINVOKE.LerpFloat_Refresh(swigCPtr);
  }

}

}
