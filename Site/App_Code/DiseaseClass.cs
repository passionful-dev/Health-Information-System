using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DiseaseClass
/// </summary>
public class DiseaseClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Health For EntryUser*/
    public DataTable healthForEntryUser()
    {
        String data = "SELECT Disease.diseaseRegdDate As Dates, Disease.diseaseName As Disease, "
            + " Disease.diseaseDescription As Remarks, Users.username As Registeredby "
            + " FROM Disease INNER JOIN Users ON Users.userId = Disease.diseaseRegdBy "
            + " ORDER BY CONVERT(DATETIME, Disease.diseaseRegdDate, 103) DESC";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Health For EntryUser_RespectiveLetter*/
    public DataTable healthForEntryUser_RespectiveLetter(String letter)
    {
        String data = "SELECT Disease.diseaseRegdDate As Dates, Disease.diseaseName As Disease, "
            + " Disease.diseaseDescription As Remarks, Users.username As Registeredby "
            + " FROM Disease INNER JOIN Users ON Users.userId = Disease.diseaseRegdBy "
            + " WHERE Disease.diseaseName LIKE '" + letter + "%'"
            + " ORDER BY CONVERT(DATETIME, Disease.diseaseRegdDate, 103) DESC";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*insertIn_Disease */
    public void insertIn_Disease(String diseaseName, String remarks, 
        int checkedPatBy, String checkedPatDate)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_disease";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@diseaseName", diseaseName);
        cmd.Parameters.Add("@diseaseDescription", remarks);
        cmd.Parameters.Add("@diseaseRegdBy", checkedPatBy);
        cmd.Parameters.Add("@diseaseRegdDate", checkedPatDate);
        cmd.ExecuteNonQuery();
    }
}