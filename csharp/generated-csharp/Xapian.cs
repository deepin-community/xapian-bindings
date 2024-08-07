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

public class Xapian {
  public static string SortableSerialise(double value) {
    string ret = XapianPINVOKE.SortableSerialise(value);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double SortableUnserialise(string serialised) {
    double ret = XapianPINVOKE.SortableUnserialise(serialised);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double MilesToMetres(double miles) {
    double ret = XapianPINVOKE.MilesToMetres(miles);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double MetresToMiles(double metres) {
    double ret = XapianPINVOKE.MetresToMiles(metres);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly uint BAD_VALUENO = XapianPINVOKE.BAD_VALUENO_get();
  public static readonly int DB_CREATE = XapianPINVOKE.DB_CREATE_get();
  public static readonly int DB_CREATE_OR_OPEN = XapianPINVOKE.DB_CREATE_OR_OPEN_get();
  public static readonly int DB_CREATE_OR_OVERWRITE = XapianPINVOKE.DB_CREATE_OR_OVERWRITE_get();
  public static readonly int DB_OPEN = XapianPINVOKE.DB_OPEN_get();
  public static readonly int DB_NO_SYNC = XapianPINVOKE.DB_NO_SYNC_get();
  public static readonly int DB_FULL_SYNC = XapianPINVOKE.DB_FULL_SYNC_get();
  public static readonly int DB_DANGEROUS = XapianPINVOKE.DB_DANGEROUS_get();
  public static readonly int DB_NO_TERMLIST = XapianPINVOKE.DB_NO_TERMLIST_get();
  public static readonly int DB_BACKEND_CHERT = XapianPINVOKE.DB_BACKEND_CHERT_get();
  public static readonly int DB_BACKEND_GLASS = XapianPINVOKE.DB_BACKEND_GLASS_get();
  public static readonly int DB_BACKEND_INMEMORY = XapianPINVOKE.DB_BACKEND_INMEMORY_get();
  public static readonly int DB_BACKEND_STUB = XapianPINVOKE.DB_BACKEND_STUB_get();
  public static readonly int DB_RETRY_LOCK = XapianPINVOKE.DB_RETRY_LOCK_get();
  public static readonly int DBCHECK_SHORT_TREE = XapianPINVOKE.DBCHECK_SHORT_TREE_get();
  public static readonly int DBCHECK_FULL_TREE = XapianPINVOKE.DBCHECK_FULL_TREE_get();
  public static readonly int DBCHECK_SHOW_FREELIST = XapianPINVOKE.DBCHECK_SHOW_FREELIST_get();
  public static readonly int DBCHECK_SHOW_STATS = XapianPINVOKE.DBCHECK_SHOW_STATS_get();
  public static readonly int DBCHECK_FIX = XapianPINVOKE.DBCHECK_FIX_get();
  public static readonly int DBCOMPACT_MULTIPASS = XapianPINVOKE.DBCOMPACT_MULTIPASS_get();
  public static readonly int DBCOMPACT_NO_RENUMBER = XapianPINVOKE.DBCOMPACT_NO_RENUMBER_get();
  public static readonly int DBCOMPACT_SINGLE_FILE = XapianPINVOKE.DBCOMPACT_SINGLE_FILE_get();
  public static readonly int DOC_ASSUME_VALID = XapianPINVOKE.DOC_ASSUME_VALID_get();
  public static readonly int RP_SUFFIX = XapianPINVOKE.RP_SUFFIX_get();
  public static readonly int RP_REPEATED = XapianPINVOKE.RP_REPEATED_get();
  public static readonly int RP_DATE_PREFER_MDY = XapianPINVOKE.RP_DATE_PREFER_MDY_get();

}

}
