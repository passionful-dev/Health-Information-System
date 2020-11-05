using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LogClass
/// </summary>
public class LogClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Insert in Users' Log table*/
    public void Insert_UsersLog(int userId, String userLogField, String userLogDataLater)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String userDate;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        userDate = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_update_users_userSecEmail";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@userLogField", userLogField);
        cmd.Parameters.Add("@userLogDataLater", userLogDataLater);
        cmd.ExecuteNonQuery();
    }
}