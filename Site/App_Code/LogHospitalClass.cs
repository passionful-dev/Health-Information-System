using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LogHospitalClass
/// </summary>
public class LogHospitalClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Insert on Log_HospitalWholeField table with the insert Operation */
    public void insertOn_Log_HospitalWholeField_WithInsertOperation(String hospitalFullName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String hospitalWholeFieldLog_Date;
        String hospitalWholeFieldLog_Operation = "Insert";

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        hospitalWholeFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_hospitalWholeField";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting Hospital Id from Hospital's username and putting that userId value*/
        try
        {
            HospitalClass hc = new HospitalClass();
            int hospitalId;

            /*Getting Hospital Id from Hospital's userId*/
            DataTable dtHospital = hc.SelectAllHospitalFromHospitalFullName(hospitalFullName);
            if (dtHospital.Rows.Count > 0)
            {
                String hospitalIdString = dtHospital.Rows[0]["hospitalId"].ToString();
                hospitalId = Convert.ToInt32(hospitalIdString);
                cmd.Parameters.Add("@hospitalId", hospitalId);
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        cmd.Parameters.Add("@hospitalWholeFieldLog_Date", hospitalWholeFieldLog_Date);
        cmd.Parameters.Add("@hospitalWholeFieldLog_Operation", hospitalWholeFieldLog_Operation);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_HospitalIndivField table with the update Operation */
    public void insertOn_Log_HospitalIndivField_WithUpdateOperation(String 
        hospitalIndivFieldLog_Operation, int hospitalId, String hospitalIndivFieldLog_Field, 
        String hospitalIndivFieldLog_DataBefore, String hospitalIndivFieldLog_DataLater)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String hospitalIndivFieldLog_Date;
        
        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        hospitalIndivFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_hospitalIndivField";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@hospitalIndivFieldLog_Date", hospitalIndivFieldLog_Date);
        cmd.Parameters.Add("@hospitalIndivFieldLog_Operation", hospitalIndivFieldLog_Operation);
        cmd.Parameters.Add("@hospitalId", hospitalId);
        cmd.Parameters.Add("@hospitalIndivFieldLog_Field", hospitalIndivFieldLog_Field);
        cmd.Parameters.Add("@hospitalIndivFieldLog_DataBefore", hospitalIndivFieldLog_DataBefore);
        cmd.Parameters.Add("@hospitalIndivFieldLog_DataLater", hospitalIndivFieldLog_DataLater);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_HospitalWholeFieldWithName table with the delete Operation */
    public void insertOn_Log_HospitalWholeFieldWithName_WithDeleteOperation(String hospitalFullName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String hospitalWholeFieldLogWithName_Date;
        String hospitalWholeFieldLogWithName_Operation = "Delete";

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        hospitalWholeFieldLogWithName_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_hospitalWholeFieldWithName";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting Hospital Id from Hospital's username and putting that userId value*/
        try
        {
            HospitalClass hc = new HospitalClass();
            int hospitalId;

            /*Getting Hospital Id from Hospital's userId*/
            DataTable dtHospital = hc.SelectAllHospitalFromHospitalFullName(hospitalFullName);
            if (dtHospital.Rows.Count > 0)
            {
                String hospitalIdString = dtHospital.Rows[0]["hospitalId"].ToString();
                hospitalId = Convert.ToInt32(hospitalIdString);
                cmd.Parameters.Add("@hospitalId", hospitalId);
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        cmd.Parameters.Add("@hospitalFullName", hospitalFullName);
        cmd.Parameters.Add("@hospitalWholeFieldLogWithName_Date", hospitalWholeFieldLogWithName_Date);
        cmd.Parameters.Add("@hospitalWholeFieldLogWithName_Operation", hospitalWholeFieldLogWithName_Operation);
        cmd.ExecuteNonQuery();
    }
}