/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.13
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class ValueSetMatchDecider extends MatchDecider {
  private transient long swigCPtr;

  protected ValueSetMatchDecider(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.ValueSetMatchDecider_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(ValueSetMatchDecider obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_ValueSetMatchDecider(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public ValueSetMatchDecider(int slot, boolean inclusive_) {
    this(XapianJNI.new_ValueSetMatchDecider(slot, inclusive_), true);
  }

  public void addValue(byte[] value) {
    XapianJNI.ValueSetMatchDecider_addValue(swigCPtr, this, value);
  }

  public void removeValue(byte[] value) {
    XapianJNI.ValueSetMatchDecider_removeValue(swigCPtr, this, value);
  }

  public boolean accept(Document doc) {
    return XapianJNI.ValueSetMatchDecider_accept(swigCPtr, this, Document.getCPtr(doc), doc);
  }

}
