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

public class QueryParser : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal QueryParser(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(QueryParser obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(QueryParser obj) {
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

  ~QueryParser() {
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
          XapianPINVOKE.delete_QueryParser(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public QueryParser() : this(XapianPINVOKE.new_QueryParser(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStemmer(Stem stemmer) {
    XapianPINVOKE.QueryParser_SetStemmer(swigCPtr, Stem.getCPtr(stemmer));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStemmingStrategy(QueryParser.stem_strategy strategy) {
    XapianPINVOKE.QueryParser_SetStemmingStrategy(swigCPtr, (int)strategy);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStopper(Stopper stop) {
    XapianPINVOKE.QueryParser_SetStopper__SWIG_0(swigCPtr, Stopper.getCPtr(stop));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStopper() {
    XapianPINVOKE.QueryParser_SetStopper__SWIG_1(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDefaultOp(Query.op default_op) {
    XapianPINVOKE.QueryParser_SetDefaultOp(swigCPtr, (int)default_op);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query.op GetDefaultOp() {
    Query.op ret = (Query.op)XapianPINVOKE.QueryParser_GetDefaultOp(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDatabase(Database db) {
    XapianPINVOKE.QueryParser_SetDatabase(swigCPtr, Database.getCPtr(db));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxExpansion(uint max_expansion, int max_type, uint flags) {
    XapianPINVOKE.QueryParser_SetMaxExpansion__SWIG_0(swigCPtr, max_expansion, max_type, flags);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxExpansion(uint max_expansion, int max_type) {
    XapianPINVOKE.QueryParser_SetMaxExpansion__SWIG_1(swigCPtr, max_expansion, max_type);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxExpansion(uint max_expansion) {
    XapianPINVOKE.QueryParser_SetMaxExpansion__SWIG_2(swigCPtr, max_expansion);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxWildcardExpansion(uint arg0) {
    XapianPINVOKE.QueryParser_SetMaxWildcardExpansion(swigCPtr, arg0);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query ParseQuery(string query_string, uint flags, string default_prefix) {
    Query ret = new Query(XapianPINVOKE.QueryParser_ParseQuery__SWIG_0(swigCPtr, query_string, flags, default_prefix), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Query ParseQuery(string query_string, uint flags) {
    Query ret = new Query(XapianPINVOKE.QueryParser_ParseQuery__SWIG_1(swigCPtr, query_string, flags), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Query ParseQuery(string query_string) {
    Query ret = new Query(XapianPINVOKE.QueryParser_ParseQuery__SWIG_2(swigCPtr, query_string), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddPrefix(string field, string prefix) {
    XapianPINVOKE.QueryParser_AddPrefix__SWIG_0(swigCPtr, field, prefix);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddPrefix(string field, FieldProcessor proc) {
    XapianPINVOKE.QueryParser_AddPrefix__SWIG_1(swigCPtr, field, FieldProcessor.getCPtr(proc));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBooleanPrefix(string field, string prefix, string grouping) {
    XapianPINVOKE.QueryParser_AddBooleanPrefix__SWIG_0(swigCPtr, field, prefix, grouping);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBooleanPrefix(string field, string prefix) {
    XapianPINVOKE.QueryParser_AddBooleanPrefix__SWIG_1(swigCPtr, field, prefix);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBooleanPrefix(string field, string prefix, bool exclusive) {
    XapianPINVOKE.QueryParser_AddBooleanPrefix__SWIG_2(swigCPtr, field, prefix, exclusive);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBooleanPrefix(string field, FieldProcessor proc, string grouping) {
    XapianPINVOKE.QueryParser_AddBooleanPrefix__SWIG_3(swigCPtr, field, FieldProcessor.getCPtr(proc), grouping);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBooleanPrefix(string field, FieldProcessor proc) {
    XapianPINVOKE.QueryParser_AddBooleanPrefix__SWIG_4(swigCPtr, field, FieldProcessor.getCPtr(proc));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBooleanPrefix(string field, FieldProcessor proc, bool exclusive) {
    XapianPINVOKE.QueryParser_AddBooleanPrefix__SWIG_5(swigCPtr, field, FieldProcessor.getCPtr(proc), exclusive);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public TermIterator StopListBegin() {
    TermIterator ret = new TermIterator(XapianPINVOKE.QueryParser_StopListBegin(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator StopListEnd() {
    TermIterator ret = new TermIterator(XapianPINVOKE.QueryParser_StopListEnd(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator UnstemBegin(string term) {
    TermIterator ret = new TermIterator(XapianPINVOKE.QueryParser_UnstemBegin(swigCPtr, term), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator UnstemEnd(string arg0) {
    TermIterator ret = new TermIterator(XapianPINVOKE.QueryParser_UnstemEnd(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddRangeprocessor(RangeProcessor range_proc, string grouping) {
    XapianPINVOKE.QueryParser_AddRangeprocessor__SWIG_0(swigCPtr, RangeProcessor.getCPtr(range_proc), grouping);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRangeprocessor(RangeProcessor range_proc) {
    XapianPINVOKE.QueryParser_AddRangeprocessor__SWIG_1(swigCPtr, RangeProcessor.getCPtr(range_proc));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddValuerangeprocessor(ValueRangeProcessor vrproc) {
    XapianPINVOKE.QueryParser_AddValuerangeprocessor(swigCPtr, ValueRangeProcessor.getCPtr(vrproc));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetCorrectedQueryString() {
    string ret = XapianPINVOKE.QueryParser_GetCorrectedQueryString(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetDescription() {
    string ret = XapianPINVOKE.QueryParser_GetDescription(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum feature_flag {
    FLAG_BOOLEAN = 1,
    FLAG_PHRASE = 2,
    FLAG_LOVEHATE = 4,
    FLAG_BOOLEAN_ANY_CASE = 8,
    FLAG_WILDCARD = 16,
    FLAG_PURE_NOT = 32,
    FLAG_PARTIAL = 64,
    FLAG_SPELLING_CORRECTION = 128,
    FLAG_SYNONYM = 256,
    FLAG_AUTO_SYNONYMS = 512,
    FLAG_AUTO_MULTIWORD_SYNONYMS = 1024,
    FLAG_NGRAMS = 2048,
    FLAG_CJK_NGRAM = FLAG_NGRAMS,
    FLAG_ACCUMULATE = 65536,
    FLAG_NO_POSITIONS = 0x20000,
    FLAG_DEFAULT = FLAG_PHRASE|FLAG_BOOLEAN|FLAG_LOVEHATE
  }

  public enum stem_strategy {
    STEM_NONE,
    STEM_SOME,
    STEM_ALL,
    STEM_ALL_Z,
    STEM_SOME_FULL_POS
  }

}

}
