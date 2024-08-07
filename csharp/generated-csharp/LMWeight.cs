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

public class LMWeight : Weight {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal LMWeight(global::System.IntPtr cPtr, bool cMemoryOwn) : base(XapianPINVOKE.LMWeight_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LMWeight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(LMWeight obj) {
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

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XapianPINVOKE.delete_LMWeight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public LMWeight(double param_log_, Weight.type_smoothing select_smoothing_, double param_smoothing1_, double param_smoothing2_) : this(XapianPINVOKE.new_LMWeight__SWIG_0(param_log_, (int)select_smoothing_, param_smoothing1_, param_smoothing2_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public LMWeight(double param_log_, Weight.type_smoothing select_smoothing_, double param_smoothing1_) : this(XapianPINVOKE.new_LMWeight__SWIG_1(param_log_, (int)select_smoothing_, param_smoothing1_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public LMWeight(double param_log_, Weight.type_smoothing select_smoothing_) : this(XapianPINVOKE.new_LMWeight__SWIG_2(param_log_, (int)select_smoothing_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public LMWeight(double param_log_) : this(XapianPINVOKE.new_LMWeight__SWIG_3(param_log_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public LMWeight() : this(XapianPINVOKE.new_LMWeight__SWIG_4(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string Name() {
    string ret = XapianPINVOKE.LMWeight_Name(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetSumPart(uint wdf, uint doclen, uint uniqterm) {
    double ret = XapianPINVOKE.LMWeight_GetSumPart(swigCPtr, wdf, doclen, uniqterm);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMaxPart() {
    double ret = XapianPINVOKE.LMWeight_GetMaxPart(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetSumExtra(uint doclen, uint arg1) {
    double ret = XapianPINVOKE.LMWeight_GetSumExtra(swigCPtr, doclen, arg1);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMaxExtra() {
    double ret = XapianPINVOKE.LMWeight_GetMaxExtra(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
