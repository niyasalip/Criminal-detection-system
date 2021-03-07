using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class dbconnect
{
    SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\NIYAS\Documents\Visual Studio 2010\WebSites\criminal_detection1\App_Data\Criminal_detection.mdf");


    public void Execute(SqlCommand cmd)//inser...dete...up..
    {
        cmd.Connection = Con;
        Con.Open();
        cmd.ExecuteNonQuery();
        Con.Close();
    }
    public DataTable get_Data(SqlCommand cmd)//sel
    {

        cmd.Connection = Con;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];

    }
}