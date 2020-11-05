using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LogEntryUserClass
/// </summary>
public class LogEntryUserClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Insert on Log_EntryUserWholeField table with the insert Operation */
    public void insertOn_Log_EntryUserWholeField_WithInsertOperation(String username)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String entryUserWholeFieldLog_Date;
        String entryUserWholeFieldLog_Operation = "Insert";

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        entryUserWholeFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_entryUserWholeField";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting Patient Id from Patient's username and putting that userId value*/
        try
        {
            UserClass uc = new UserClass();
            EntryUserClass euc = new EntryUserClass();
            int userId, entryUserId;

            DataTable dt = uc.GetUserIdFromUsername(username);
            if (dt.Rows.Count > 0)
            {
                String userIdString = dt.Rows[0]["userId"].ToString();
                userId = Convert.ToInt32(userIdString);
                cmd.Parameters.Add("@userId", userId);

                /*Getting entryUserId from EntryUser's userId*/
                DataTable dtEntryUser = euc.SelectAllEntryUserFromUserId(userId);
                if (dtEntryUser.Rows.Count > 0)
                {
                    String entryUserIdString = dtEntryUser.Rows[0]["entryUserId"].ToString();
                    entryUserId = Convert.ToInt32(entryUserIdString);
                    cmd.Parameters.Add("@entryUserId", entryUserId);
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        cmd.Parameters.Add("@entryUserWholeFieldLog_Date", entryUserWholeFieldLog_Date);
        cmd.Parameters.Add("@entryUserWholeFieldLog_Operation", entryUserWholeFieldLog_Operation);
        cmd.ExecuteNonQuery();
    }

    /*Insert on Log_EntryUserIndivField table with the update Operation */
    public void insertOn_Log_EntryUserIndivField_WithUpdateOperation(String entryUserIndivFieldLog_Operation,
        int userId, String entryUserIndivFieldLog_Field, String entryUserIndivFieldLog_DataBefore,
        String entryUserIndivFieldLog_DataLater, int entryUserIndivFieldLog_UpdatedBy)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String entryUserIndivFieldLog_Date;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        entryUserIndivFieldLog_Date = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_Log_entryUserIndivField";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@entryUserIndivFieldLog_Date", entryUserIndivFieldLog_Date);
        cmd.Parameters.Add("@entryUserIndivFieldLog_Operation", entryUserIndivFieldLog_Operation);
        cmd.Parameters.Add("@entryUserId", userId);
        cmd.Parameters.Add("@entryUserIndivFieldLog_Field", entryUserIndivFieldLog_Field);
        cmd.Parameters.Add("@entryUserIndivFieldLog_DataBefore", entryUserIndivFieldLog_DataBefore);
        cmd.Parameters.Add("@entryUserIndivFieldLog_DataLater", entryUserIndivFieldLog_DataLater);
        cmd.Parameters.Add("@entryUserIndivFieldLog_UpdatedBy", entryUserIndivFieldLog_UpdatedBy);
        cmd.ExecuteNonQuery();
    }
}