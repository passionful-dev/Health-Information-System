using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserClass
/// </summary>
public class UserClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Delete Users By userId*/
    public void delete_UsersFrom_userId(int userId)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_delete_users";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.ExecuteNonQuery();
    }

    /*Check Login*/
    public DataTable Checklogin(String username, String userPasswd) 
    {
        //String data = "SELECT * FROM Users WHERE username COLLATE Latin1_General_CS_AS ='" 
        //    + username + "' AND userPasswd COLLATE Latin1_General_CS_AS ='" + userPasswd 
        //    + "'";
        //SQL_Latin1_General_CP1_CI_AS
        String data = "SELECT * FROM Users WHERE username ='"
            + username + "' AND userPasswd COLLATE Latin1_General_CS_AS ='" + userPasswd
            + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Users");
        return ds.Tables[0];

        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = gc.cn;
        //cmd.CommandText = "sp_viewUsers_Login";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.AddWithValue("@username", username);
        //cmd.Parameters.AddWithValue("@userPasswd", userPasswd);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //DataSet ds = new DataSet();
        //da.Fill(ds, "Login");
        //return ds.Tables[0];
        
    }

    /*Check Email*/
    public DataTable CheckEmail(String userEmail)
    {
        String data = "SELECT * FROM Users WHERE userEmail='" + userEmail + "' OR userSecEmail='" + userEmail + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Users");
        return ds.Tables[0];

        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = gc.cn;
        //cmd.CommandText = "sp_viewUsers_Login";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.ExecuteNonQuery();
    }

    /*Get UserId From Username*/
    public DataTable GetUserIdFromUsername(String username)
    {
        String data = "SELECT userId FROM Users WHERE username='" + username + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Users");
        return ds.Tables[0];

        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = gc.cn;
        //cmd.CommandText = "sp_viewUsers_Login";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.ExecuteNonQuery();
    }

    /*Select All Users from Username*/
    public DataTable SelectAllUsersFromUsername(String username)
    {
        String data = "SELECT * FROM Users WHERE username='" + username + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Users");
        return ds.Tables[0];

        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = gc.cn;
        //cmd.CommandText = "sp_viewUsers_Login";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.ExecuteNonQuery();
    }

    /*Select All of Users Except of that UserType*/
    public DataTable selectAllUsersFromUserType_RespectiveUsers(String userType)
    {
        //String data = "SELECT * FROM Users";
        if (userType == "Other")
        {
            String data = "SELECT * FROM Users WHERE userType = 'Entry'";
            SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            return ds.Tables[0];
        }
        else if (userType == "Entry")
        {
            String data = "SELECT * FROM Users WHERE userType = 'Patient'";
            SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            return ds.Tables[0];
        }
        else 
        {
            String data = "SELECT * FROM Users WHERE userType = ''";
            SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            return ds.Tables[0];
        }
        
    }
}