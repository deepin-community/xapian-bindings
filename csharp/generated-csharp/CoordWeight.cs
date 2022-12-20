//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.13
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Xapian {

public class CoordWeight : Weight {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CoordWeight(global::System.IntPtr cPtr, bool cMemoryOwn) : base(XapianPINVOKE.CoordWeight_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CoordWeight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CoordWeight() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XapianPINVOKE.delete_CoordWeight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void Init(double factor_) {
    XapianPINVOKE.CoordWeight_Init(swigCPtr, factor_);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public CoordWeight() : this(XapianPINVOKE.new_CoordWeight(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string Name() {
    string ret = XapianPINVOKE.CoordWeight_Name(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetSumPart(uint wdf, uint doclen, uint uniqterm) {
    double ret = XapianPINVOKE.CoordWeight_GetSumPart(swigCPtr, wdf, doclen, uniqterm);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMaxPart() {
    double ret = XapianPINVOKE.CoordWeight_GetMaxPart(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetSumExtra(uint arg0, uint arg1) {
    double ret = XapianPINVOKE.CoordWeight_GetSumExtra(swigCPtr, arg0, arg1);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMaxExtra() {
    double ret = XapianPINVOKE.CoordWeight_GetMaxExtra(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}