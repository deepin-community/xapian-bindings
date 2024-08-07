/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (https://www.swig.org).
 * Version 4.2.0
 *
 * Do not make changes to this file unless you know what you are doing - modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class FieldProcessor {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected FieldProcessor(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FieldProcessor obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected static long swigRelease(FieldProcessor obj) {
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
        XapianJNI.delete_FieldProcessor(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    XapianJNI.FieldProcessor_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    XapianJNI.FieldProcessor_change_ownership(this, swigCPtr, true);
  }

  public FieldProcessor() {
    this(XapianJNI.new_FieldProcessor(), true);
    XapianJNI.FieldProcessor_director_connect(this, swigCPtr, true, true);
  }

  public Query apply(String str) {
    return new Query(XapianJNI.FieldProcessor_apply(swigCPtr, this, str), true);
  }

  public FieldProcessor release() {
    long cPtr = XapianJNI.FieldProcessor_release(swigCPtr, this);
    return (cPtr == 0) ? null : new FieldProcessor(cPtr, false);
  }

}
