using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LogPatientClass
/// </summary>
public class LogPatientClass
{
    GlobalConnection gc = new GlobalConnection();

    /*insertIn_Log_CheckedPatWholeField*/
    public void insertIn_Log_CheckedPatWholeField(String checkedPatDate, int checkedPatId)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        /*Putting values through Stored Procedure*/
        cmd.CommandText = "sp_Log_checkedPatWholeField";
        cmd.CommandType = CommandType.StoredProcedure;

        String checkedPatWholeFieldLog_Operation = "Insert";
        cmd.Parameters.Add("@checkedPatWholeFieldLog_Date", checkedPatDate);
        cmd.Parameters.Add("@checkedPatWholeFieldLog_Operation", checkedPatWholeFieldLog_Operation);
        cmd.Parameters.Add("@checkedPatId", checkedPatId);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_PatientWholeField table with the insert Operation */
    public void insertOn_Log_PatientWholeField_WithInsertOperation(String username)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String patientWholeFieldLog_Date;
        String patientWholeFieldLog_Operation = "Insert";

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        patientWholeFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_patientWholeField";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting Patient Id from Patient's username and putting that userId value*/
        try
        {
            UserClass uc = new UserClass();
            PatientClass pc = new PatientClass();
            int userId, patientId;
            
            DataTable dt = uc.GetUserIdFromUsername(username);
            if (dt.Rows.Count > 0)
            {
                String userIdString = dt.Rows[0]["userId"].ToString();
                userId = Convert.ToInt32(userIdString);
                cmd.Parameters.Add("@userId", userId);

                /*Getting Patient Id from Patient's userId*/
                DataTable dtPatient = pc.SelectAllPatientFromUserId(userId);
                if (dtPatient.Rows.Count > 0)
                {
                    String patientIdString = dtPatient.Rows[0]["patientId"].ToString();
                    patientId = Convert.ToInt32(patientIdString);
                    cmd.Parameters.Add("@patientId", patientId);
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        cmd.Parameters.Add("@patientWholeFieldLog_Date", patientWholeFieldLog_Date);
        cmd.Parameters.Add("@patientWholeFieldLog_Operation", patientWholeFieldLog_Operation);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_PatientIndivField table with the update Operation */
    public void insertOn_Log_PatientIndivField_WithUpdateOperation(String patientIndivFieldLog_Operation,
        int userId, String patientIndivFieldLog_Field, String patientIndivFieldLog_DataBefore,
        String patientIndivFieldLog_DataLater)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String patientIndivFieldLog_Date;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        patientIndivFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_patientIndivField";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@patientIndivFieldLog_Date", patientIndivFieldLog_Date);
        cmd.Parameters.Add("@patientIndivFieldLog_Operation", patientIndivFieldLog_Operation);
        cmd.Parameters.Add("@patientId", userId);
        cmd.Parameters.Add("@patientIndivFieldLog_Field", patientIndivFieldLog_Field);
        cmd.Parameters.Add("@patientIndivFieldLog_DataBefore", patientIndivFieldLog_DataBefore);
        cmd.Parameters.Add("@patientIndivFieldLog_DataLater", patientIndivFieldLog_DataLater);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_PatientWholeFieldWithName table with the delete Operation */
    public void insertOn_Log_PatientWholeFieldWithName_WithDeleteOperation(int userId, int patientId, 
        String patientFullName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String patientWholeFieldLogWithName_Date;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        patientWholeFieldLogWithName_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_PatientWholeFieldWithName";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@patientWholeFieldLogWithName_Date", patientWholeFieldLogWithName_Date);
        cmd.Parameters.Add("@patientWholeFieldLogWithName_Operation", "Delete");
        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@patientId", patientId);
        cmd.Parameters.Add("@patientFullName", patientFullName);
        cmd.ExecuteNonQuery();
    }
}