using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserOtherUserClass
/// </summary>
public class OtherUserClass
{
    GlobalConnection gc = new GlobalConnection();

    /*homeOtherUser*/
    public DataTable homeOtherUser()
    {
        String data = "SELECT * FROM OtherUser_Home "
            + " ORDER BY CONVERT(DATETIME, Dates, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select All Other User from UserId*/
    public DataTable SelectAllOtherUserFromUserId(int userId)
    {
        String data = "SELECT * FROM OtherUser WHERE userId='" + userId + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "OtherUser");
        return ds.Tables[0];

        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = gc.cn;
        //cmd.CommandText = "sp_viewUsers_Login";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.ExecuteNonQuery();
    }
}