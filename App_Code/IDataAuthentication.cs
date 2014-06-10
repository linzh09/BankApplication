using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IDataAuthentication
/// </summary>
public interface IDataAuthentication
{
    string IsValidUser(string uname, string pwd);
    // returns Checking AccountNumber
}