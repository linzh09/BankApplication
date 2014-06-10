using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess : IDataAccess  
{
    public static
        string CONNSTR = ConfigurationManager.ConnectionStrings["BANKDBCONN"].ConnectionString;

    public DataAccess()
	{
	}

    #region IDataAccess Members

    public object GetScalar(string sql)
    {
        object obj = null;
        SqlConnection conn = new SqlConnection(CONNSTR);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            obj = cmd.ExecuteScalar(); 
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return obj;
    }

    public System.Data.DataTable GetDataTable(string sql)
    {
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(CONNSTR);
        try
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return dt;
    }

    public int InsOrUpdOrDel(string sql)
    {
        int rows = 0;
        SqlConnection conn = new SqlConnection(CONNSTR);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            rows = cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
        return rows;
    }

    #endregion


    public int TransferViaSP(string ChkNum, string SavNum, double amt, string sql)
    {
        int rows = 0;
        SqlConnection conn = new SqlConnection(CONNSTR);
        
        try
        {
            conn.Open();
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter p1 = new SqlParameter("@ChkAcctNum",
                                System.Data.SqlDbType.VarChar, 50);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            p1.Value = ChkNum;
            cmd.Parameters.Add(p1);
            SqlParameter p2 = new SqlParameter("@SavAcctNum",
                                System.Data.SqlDbType.VarChar, 50);
            p2.Value = SavNum;
            cmd.Parameters.Add(p2);
            SqlParameter p3 = new SqlParameter("@amt",
                                System.Data.SqlDbType.Money);
            p3.Value = amt;
            cmd.Parameters.Add(p3);
             rows = cmd.ExecuteNonQuery();
           
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conn.Close();
        }

        return rows;
        
        
    }
}