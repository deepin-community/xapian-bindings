/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (https://www.swig.org).
 * Version 4.2.0
 *
 * Do not make changes to this file unless you know what you are doing - modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class DPHWeight extends Weight {
  private transient long swigCPtr;

  protected DPHWeight(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.DPHWeight_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DPHWeight obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected static long swigRelease(DPHWeight obj) {
    long ptr = 0;
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new RuntimeException("Cannot release ownership as memory is not owned");
      ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.delete();
    }
    return ptr;
  }

  @SuppressWarnings({"deprecation", "removal"})
  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_DPHWeight(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public DPHWeight() {
    this(XapianJNI.new_DPHWeight(), true);
  }

  public String name() {
    return XapianJNI.DPHWeight_name(swigCPtr, this);
  }

  public double getSumPart(long wdf, long doclen, long uniqterms) {
    return XapianJNI.DPHWeight_getSumPart(swigCPtr, this, wdf, doclen, uniqterms);
  }

  public double getMaxPart() {
    return XapianJNI.DPHWeight_getMaxPart(swigCPtr, this);
  }

  public double getSumExtra(long doclen, long uniqterms) {
    return XapianJNI.DPHWeight_getSumExtra(swigCPtr, this, doclen, uniqterms);
  }

  public double getMaxExtra() {
    return XapianJNI.DPHWeight_getMaxExtra(swigCPtr, this);
  }

}
