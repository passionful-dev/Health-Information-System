using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LogUserClass
/// </summary>
public class LogUserClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Insert on Log_UsersWholeFieldWithName table*/
    public void insertOn_Log_UsersWholeFieldWithName_WithDeleteOperation(int userId, String username)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String userWholeFieldLogWithName_Date;
        String userWholeFieldLogWithName_Operation = "Delete";

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        userWholeFieldLogWithName_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_UsersWholeFieldWithName";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userWholeFieldLogWithName_Date", userWholeFieldLogWithName_Date);
        cmd.Parameters.Add("@userWholeFieldLogWithName_Operation", userWholeFieldLogWithName_Operation);
        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@username", username);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_UsersWholeField table With InsertOperation*/
    public void insertOn_Log_UsersWholeField_WithInsertOperation(String username)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String userWholeFieldLog_Date;
        String userWholeFieldLog_Operation = "Insert";

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        userWholeFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_usersWholeField";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting userId from username*/
        try
        {
            UserClass uc = new UserClass();
            int userId;

            DataTable dt = uc.GetUserIdFromUsername(username);
            if (dt.Rows.Count > 0)
            {
                String userIdString = dt.Rows[0]["userId"].ToString();
                userId = Convert.ToInt32(userIdString);
                cmd.Parameters.Add("@userId", userId);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        cmd.Parameters.Add("@userWholeFieldLog_Date", userWholeFieldLog_Date);
        cmd.Parameters.Add("@userWholeFieldLog_Operation", userWholeFieldLog_Operation);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_UsersIndivField table with the update Operation */
    public void insertOn_Log_UsersIndivField_WithUpdateOperation(String userIndivFieldLog_Operation,
        int userId, String userIndivFieldLog_Field, String userIndivFieldLog_DataBefore,
        String userIndivFieldLog_DataLater)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String userIndivFieldLog_Date;
        
        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        userIndivFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_usersIndivField";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userIndivFieldLog_Date", userIndivFieldLog_Date);
        cmd.Parameters.Add("@userIndivFieldLog_Operation", userIndivFieldLog_Operation);
        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@userIndivFieldLog_Field", userIndivFieldLog_Field);
        cmd.Parameters.Add("@userIndivFieldLog_DataBefore", userIndivFieldLog_DataBefore);
        cmd.Parameters.Add("@userIndivFieldLog_DataLater", userIndivFieldLog_DataLater);
        cmd.ExecuteNonQuery();
    }
}