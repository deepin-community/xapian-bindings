/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (https://www.swig.org).
 * Version 4.2.0
 *
 * Do not make changes to this file unless you know what you are doing - modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class LatLongCoord {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected LatLongCoord(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(LatLongCoord obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected static long swigRelease(LatLongCoord obj) {
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
        XapianJNI.delete_LatLongCoord(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public void setLatitude(double value) {
    XapianJNI.LatLongCoord_latitude_set(swigCPtr, this, value);
  }

  public double getLatitude() {
    return XapianJNI.LatLongCoord_latitude_get(swigCPtr, this);
  }

  public void setLongitude(double value) {
    XapianJNI.LatLongCoord_longitude_set(swigCPtr, this, value);
  }

  public double getLongitude() {
    return XapianJNI.LatLongCoord_longitude_get(swigCPtr, this);
  }

  public LatLongCoord() {
    this(XapianJNI.new_LatLongCoord__SWIG_0(), true);
  }

  public LatLongCoord(double latitude_, double longitude_) {
    this(XapianJNI.new_LatLongCoord__SWIG_1(latitude_, longitude_), true);
  }

  public void unserialise(byte[] serialised) {
    XapianJNI.LatLongCoord_unserialise(swigCPtr, this, serialised);
  }

  public byte[] serialise() {
    return XapianJNI.LatLongCoord_serialise(swigCPtr, this);
  }

  public String toString() {
    return XapianJNI.LatLongCoord_toString(swigCPtr, this);
  }

}
