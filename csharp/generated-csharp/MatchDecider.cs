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

public class MatchDecider : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MatchDecider(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MatchDecider obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(MatchDecider obj) {
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

  ~MatchDecider() {
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
          XapianPINVOKE.delete_MatchDecider(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public MatchDecider() : this(XapianPINVOKE.new_MatchDecider(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public virtual bool Apply(Document doc) {
    bool ret = XapianPINVOKE.MatchDecider_Apply(swigCPtr, Document.getCPtr(doc));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("Apply", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMatchDecider_0(SwigDirectorMethodApply);
    XapianPINVOKE.MatchDecider_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo[] methodInfos = this.GetType().GetMethods(
        global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance);
    foreach (global::System.Reflection.MethodInfo methodInfo in methodInfos) {
      if (methodInfo.DeclaringType == null)
        continue;

      if (methodInfo.Name != methodName)
        continue;

      var parameters = methodInfo.GetParameters();
      if (parameters.Length != methodTypes.Length)
        continue;

      bool parametersMatch = true;
      for (var i = 0; i < parameters.Length; i++) {
        if (parameters[i].ParameterType != methodTypes[i]) {
          parametersMatch = false;
          break;
        }
      }

      if (!parametersMatch)
        continue;

      if (methodInfo.IsVirtual && (methodInfo.DeclaringType.IsSubclassOf(typeof(MatchDecider))) &&
        methodInfo.DeclaringType != methodInfo.GetBaseDefinition().DeclaringType) {
        return true;
      }
    }

    return false;
  }

  private bool SwigDirectorMethodApply(global::System.IntPtr doc) {
    return Apply(new Document(doc, false));
  }

  public delegate bool SwigDelegateMatchDecider_0(global::System.IntPtr doc);

  private SwigDelegateMatchDecider_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(Document) };
}

}
