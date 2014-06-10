using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for IDataAccess
/// </summary>
public interface IDataAccess
{
	object GetScalar(string sql);
    DataTable GetDataTable(string sql);
    int InsOrUpdOrDel(string sql);
    int TransferViaSP(string ChkNum, String SavNum, double amt, string sql);
}