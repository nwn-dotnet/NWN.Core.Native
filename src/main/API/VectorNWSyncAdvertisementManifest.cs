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

public unsafe class VectorNWSyncAdvertisementManifest : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<NWSyncAdvertisementManifest>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public VectorNWSyncAdvertisementManifest(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public VectorNWSyncAdvertisementManifest(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorNWSyncAdvertisementManifest obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorNWSyncAdvertisementManifest() {
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
          NWNXLibPINVOKE.delete_VectorNWSyncAdvertisementManifest(swigCPtr);
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

  public static unsafe implicit operator void*(VectorNWSyncAdvertisementManifest self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(VectorNWSyncAdvertisementManifest self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(VectorNWSyncAdvertisementManifest other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is VectorNWSyncAdvertisementManifest other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(VectorNWSyncAdvertisementManifest left, VectorNWSyncAdvertisementManifest right) {
    return Equals(left, right);
  }

  public static bool operator !=(VectorNWSyncAdvertisementManifest left, VectorNWSyncAdvertisementManifest right) {
    return !Equals(left, right);
  }

  public VectorNWSyncAdvertisementManifest(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (NWSyncAdvertisementManifest element in c) {
      this.Add(element);
    }
  }

  public VectorNWSyncAdvertisementManifest(global::System.Collections.Generic.IEnumerable<NWSyncAdvertisementManifest> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (NWSyncAdvertisementManifest element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public NWSyncAdvertisementManifest this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(NWSyncAdvertisementManifest[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(NWSyncAdvertisementManifest[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, NWSyncAdvertisementManifest[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public NWSyncAdvertisementManifest[] ToArray() {
    NWSyncAdvertisementManifest[] array = new NWSyncAdvertisementManifest[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<NWSyncAdvertisementManifest> global::System.Collections.Generic.IEnumerable<NWSyncAdvertisementManifest>.GetEnumerator() {
    return new VectorNWSyncAdvertisementManifestEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorNWSyncAdvertisementManifestEnumerator(this);
  }

  public VectorNWSyncAdvertisementManifestEnumerator GetEnumerator() {
    return new VectorNWSyncAdvertisementManifestEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorNWSyncAdvertisementManifestEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<NWSyncAdvertisementManifest>
  {
    private VectorNWSyncAdvertisementManifest collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorNWSyncAdvertisementManifestEnumerator(VectorNWSyncAdvertisementManifest collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public NWSyncAdvertisementManifest Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (NWSyncAdvertisementManifest)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_Clear(swigCPtr);
  }

  public void Add(NWSyncAdvertisementManifest x) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_Add(swigCPtr, NWSyncAdvertisementManifest.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_reserve(swigCPtr, n);
  }

  public VectorNWSyncAdvertisementManifest() : this(NWNXLibPINVOKE.new_VectorNWSyncAdvertisementManifest__SWIG_0(), true) {
  }

  public VectorNWSyncAdvertisementManifest(VectorNWSyncAdvertisementManifest other) : this(NWNXLibPINVOKE.new_VectorNWSyncAdvertisementManifest__SWIG_1(VectorNWSyncAdvertisementManifest.getCPtr(other)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorNWSyncAdvertisementManifest(int capacity) : this(NWNXLibPINVOKE.new_VectorNWSyncAdvertisementManifest__SWIG_2(capacity), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private NWSyncAdvertisementManifest getitemcopy(int index) {
    NWSyncAdvertisementManifest ret = new NWSyncAdvertisementManifest(NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_getitemcopy(swigCPtr, index), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NWSyncAdvertisementManifest getitem(int index) {
    NWSyncAdvertisementManifest ret = new NWSyncAdvertisementManifest(NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_getitem(swigCPtr, index), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, NWSyncAdvertisementManifest val) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_setitem(swigCPtr, index, NWSyncAdvertisementManifest.getCPtr(val));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorNWSyncAdvertisementManifest values) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_AddRange(swigCPtr, VectorNWSyncAdvertisementManifest.getCPtr(values));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorNWSyncAdvertisementManifest GetRange(int index, int count) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_GetRange(swigCPtr, index, count);
    VectorNWSyncAdvertisementManifest ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorNWSyncAdvertisementManifest(cPtr, true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, NWSyncAdvertisementManifest x) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_Insert(swigCPtr, index, NWSyncAdvertisementManifest.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorNWSyncAdvertisementManifest values) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_InsertRange(swigCPtr, index, VectorNWSyncAdvertisementManifest.getCPtr(values));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_RemoveAt(swigCPtr, index);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_RemoveRange(swigCPtr, index, count);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorNWSyncAdvertisementManifest Repeat(NWSyncAdvertisementManifest value, int count) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_Repeat(NWSyncAdvertisementManifest.getCPtr(value), count);
    VectorNWSyncAdvertisementManifest ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorNWSyncAdvertisementManifest(cPtr, true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_Reverse__SWIG_1(swigCPtr, index, count);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorNWSyncAdvertisementManifest values) {
    NWNXLibPINVOKE.VectorNWSyncAdvertisementManifest_SetRange(swigCPtr, index, VectorNWSyncAdvertisementManifest.getCPtr(values));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
