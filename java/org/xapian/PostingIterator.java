/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (https://www.swig.org).
 * Version 4.2.0
 *
 * Do not make changes to this file unless you know what you are doing - modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class PostingIterator {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected PostingIterator(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(PostingIterator obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected static long swigRelease(PostingIterator obj) {
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
        XapianJNI.delete_PostingIterator(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public PostingIterator() {
    this(XapianJNI.new_PostingIterator(), true);
  }

  public long getWdf() {
    return XapianJNI.PostingIterator_getWdf(swigCPtr, this);
  }

  public long getDocLength() {
    return XapianJNI.PostingIterator_getDocLength(swigCPtr, this);
  }

  public long getUniqueTerms() {
    return XapianJNI.PostingIterator_getUniqueTerms(swigCPtr, this);
  }

  public PositionIterator positionListBegin() {
    return new PositionIterator(XapianJNI.PostingIterator_positionListBegin(swigCPtr, this), true);
  }

  public PositionIterator positionListEnd() {
    return new PositionIterator(XapianJNI.PostingIterator_positionListEnd(swigCPtr, this), true);
  }

  public void skipTo(long did) {
    XapianJNI.PostingIterator_skipTo(swigCPtr, this, did);
  }

  public String toString() {
    return XapianJNI.PostingIterator_toString(swigCPtr, this);
  }

  public long next() {
    return XapianJNI.PostingIterator_next(swigCPtr, this);
  }

  public boolean hasNext() {
    return XapianJNI.PostingIterator_hasNext(swigCPtr, this);
  }

  public boolean equals(PostingIterator o) {
    return XapianJNI.PostingIterator_equals(swigCPtr, this, PostingIterator.getCPtr(o), o);
  }

  public long getDocId() {
    return XapianJNI.PostingIterator_getDocId(swigCPtr, this);
  }

}
