//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VecMapLocation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VecMapLocation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VecMapLocation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VecMapLocation() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bcPINVOKE.delete_VecMapLocation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VecMapLocation() : this(bcPINVOKE.new_VecMapLocation(), true) {
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
  }

  public string debug() {
    string ret = bcPINVOKE.VecMapLocation_debug(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VecMapLocation clone() {
    global::System.IntPtr cPtr = bcPINVOKE.VecMapLocation_clone(swigCPtr);
    VecMapLocation ret = (cPtr == global::System.IntPtr.Zero) ? null : new VecMapLocation(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint len() {
    uint ret = bcPINVOKE.VecMapLocation_len(swigCPtr);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MapLocation index(uint index) {
    global::System.IntPtr cPtr = bcPINVOKE.VecMapLocation_index(swigCPtr, index);
    MapLocation ret = (cPtr == global::System.IntPtr.Zero) ? null : new MapLocation(cPtr, false);
    if (bcPINVOKE.SWIGPendingException.Pending) throw bcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
