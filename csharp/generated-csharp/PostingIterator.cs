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

public class PostingIterator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PostingIterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PostingIterator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(PostingIterator obj) {
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

  ~PostingIterator() {
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
          XapianPINVOKE.delete_PostingIterator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

    public static PostingIterator operator++(PostingIterator it) {
	return it.Next();
    }
    public override bool Equals(object o) {
	return o is PostingIterator && Equals((PostingIterator)o);
    }
    public static bool operator==(PostingIterator a, PostingIterator b) {
	if ((object)a == (object)b) return true;
	if ((object)a == null || (object)b == null) return false;
	return a.Equals(b);
    }
    public static bool operator!=(PostingIterator a, PostingIterator b) {
	if ((object)a == (object)b) return false;
	if ((object)a == null || (object)b == null) return true;
	return !a.Equals(b);
    }
    // Implementing GetHashCode() to always return 0 is rather lame, but
    // using iterators as keys in a hash table would be rather strange.
    public override int GetHashCode() { return 0; }

  public PostingIterator() : this(XapianPINVOKE.new_PostingIterator(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetWdf() {
    uint ret = XapianPINVOKE.PostingIterator_GetWdf(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDocLength() {
    uint ret = XapianPINVOKE.PostingIterator_GetDocLength(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetUniqueTerms() {
    uint ret = XapianPINVOKE.PostingIterator_GetUniqueTerms(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PositionIterator PositionListBegin() {
    PositionIterator ret = new PositionIterator(XapianPINVOKE.PostingIterator_PositionListBegin(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PositionIterator PositionListEnd() {
    PositionIterator ret = new PositionIterator(XapianPINVOKE.PostingIterator_PositionListEnd(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SkipTo(uint did) {
    XapianPINVOKE.PostingIterator_SkipTo(swigCPtr, did);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDescription() {
    string ret = XapianPINVOKE.PostingIterator_GetDescription(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(PostingIterator o) {
    bool ret = XapianPINVOKE.PostingIterator_Equals(swigCPtr, PostingIterator.getCPtr(o));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDocId() {
    uint ret = XapianPINVOKE.PostingIterator_GetDocId(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PostingIterator Next() {
    PostingIterator ret = new PostingIterator(XapianPINVOKE.PostingIterator_Next(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
