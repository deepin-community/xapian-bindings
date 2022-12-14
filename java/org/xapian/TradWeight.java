/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.13
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class TradWeight extends Weight {
  private transient long swigCPtr;

  protected TradWeight(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.TradWeight_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(TradWeight obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_TradWeight(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public TradWeight(double k) {
    this(XapianJNI.new_TradWeight__SWIG_0(k), true);
  }

  public TradWeight() {
    this(XapianJNI.new_TradWeight__SWIG_1(), true);
  }

  public String name() {
    return XapianJNI.TradWeight_name(swigCPtr, this);
  }

  public double getSumPart(long wdf, long doclen, long uniqueterms) {
    return XapianJNI.TradWeight_getSumPart(swigCPtr, this, wdf, doclen, uniqueterms);
  }

  public double getMaxPart() {
    return XapianJNI.TradWeight_getMaxPart(swigCPtr, this);
  }

  public double getSumExtra(long doclen, long uniqterms) {
    return XapianJNI.TradWeight_getSumExtra(swigCPtr, this, doclen, uniqterms);
  }

  public double getMaxExtra() {
    return XapianJNI.TradWeight_getMaxExtra(swigCPtr, this);
  }

}
