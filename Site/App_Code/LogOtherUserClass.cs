using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LogOtherUserClass
/// </summary>
public class LogOtherUserClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Insert on Log_OtherUserIndivField table with the update Operation */
    public void insertOn_Log_OtherUserIndivField_WithUpdateOperation(String otherUserIndivFieldLog_Operation,
        int userId, String otherUserIndivFieldLog_Field, String otherUserIndivFieldLog_DataBefore,
        String otherUserIndivFieldLog_DataLater)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String otherUserIndivFieldLog_Date;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        otherUserIndivFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_otherUserIndivField";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@otherUserIndivFieldLog_Date", otherUserIndivFieldLog_Date);
        cmd.Parameters.Add("@otherUserIndivFieldLog_Operation", otherUserIndivFieldLog_Operation);
        cmd.Parameters.Add("@otherUserId", userId);
        cmd.Parameters.Add("@otherUserIndivFieldLog_Field", otherUserIndivFieldLog_Field);
        cmd.Parameters.Add("@otherUserIndivFieldLog_DataBefore", otherUserIndivFieldLog_DataBefore);
        cmd.Parameters.Add("@otherUserIndivFieldLog_DataLater", otherUserIndivFieldLog_DataLater);
        cmd.ExecuteNonQuery();
    }
}