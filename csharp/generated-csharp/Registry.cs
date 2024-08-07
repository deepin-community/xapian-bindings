//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Xapian {

public class Registry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Registry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Registry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Registry obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~Registry() {
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
          XapianPINVOKE.delete_Registry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Registry() : this(XapianPINVOKE.new_Registry(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterWeightingScheme(Weight wt) {
    XapianPINVOKE.Registry_RegisterWeightingScheme(swigCPtr, Weight.getCPtr(wt));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Weight GetWeightingScheme(string name) {
    global::System.IntPtr cPtr = XapianPINVOKE.Registry_GetWeightingScheme(swigCPtr, name);
    Weight ret = (cPtr == global::System.IntPtr.Zero) ? null : new Weight(cPtr, false);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RegisterPostingSource(PostingSource source) {
    XapianPINVOKE.Registry_RegisterPostingSource(swigCPtr, PostingSource.getCPtr(source));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public PostingSource GetPostingSource(string name) {
    global::System.IntPtr cPtr = XapianPINVOKE.Registry_GetPostingSource(swigCPtr, name);
    PostingSource ret = (cPtr == global::System.IntPtr.Zero) ? null : new PostingSource(cPtr, false);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RegisterMatchSpy(MatchSpy spy) {
    XapianPINVOKE.Registry_RegisterMatchSpy(swigCPtr, MatchSpy.getCPtr(spy));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public MatchSpy GetMatchSpy(string name) {
    global::System.IntPtr cPtr = XapianPINVOKE.Registry_GetMatchSpy(swigCPtr, name);
    MatchSpy ret = (cPtr == global::System.IntPtr.Zero) ? null : new MatchSpy(cPtr, false);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RegisterLatLongMetric(LatLongMetric metric) {
    XapianPINVOKE.Registry_RegisterLatLongMetric(swigCPtr, LatLongMetric.getCPtr(metric));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public LatLongMetric GetLatLongMetric(string name) {
    global::System.IntPtr cPtr = XapianPINVOKE.Registry_GetLatLongMetric(swigCPtr, name);
    LatLongMetric ret = (cPtr == global::System.IntPtr.Zero) ? null : new LatLongMetric(cPtr, false);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
