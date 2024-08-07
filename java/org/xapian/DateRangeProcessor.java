/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (https://www.swig.org).
 * Version 4.2.0
 *
 * Do not make changes to this file unless you know what you are doing - modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class DateRangeProcessor extends RangeProcessor {
  private transient long swigCPtr;

  protected DateRangeProcessor(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.DateRangeProcessor_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DateRangeProcessor obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected static long swigRelease(DateRangeProcessor obj) {
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
        XapianJNI.delete_DateRangeProcessor(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public DateRangeProcessor(int slot_, long flags_, int epoch_year_) {
    this(XapianJNI.new_DateRangeProcessor__SWIG_0(slot_, flags_, epoch_year_), true);
  }

  public DateRangeProcessor(int slot_, long flags_) {
    this(XapianJNI.new_DateRangeProcessor__SWIG_1(slot_, flags_), true);
  }

  public DateRangeProcessor(int slot_) {
    this(XapianJNI.new_DateRangeProcessor__SWIG_2(slot_), true);
  }

  public DateRangeProcessor(int slot_, String str_, long flags_, int epoch_year_) {
    this(XapianJNI.new_DateRangeProcessor__SWIG_3(slot_, str_, flags_, epoch_year_), true);
  }

  public DateRangeProcessor(int slot_, String str_, long flags_) {
    this(XapianJNI.new_DateRangeProcessor__SWIG_4(slot_, str_, flags_), true);
  }

  public DateRangeProcessor(int slot_, String str_) {
    this(XapianJNI.new_DateRangeProcessor__SWIG_5(slot_, str_), true);
  }

  public Query apply(String begin, String end) {
    return new Query(XapianJNI.DateRangeProcessor_apply(swigCPtr, this, begin, end), true);
  }

}
