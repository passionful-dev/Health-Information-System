using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserEntryUserClass
/// </summary>
public class UserEntryUserClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Register EntryUser: Insert in EntryUser's table*/
    public void RegisterEntryUser_EntryUser(String entryUserDesignation,
        String entryUserHospital, int entryUserRegisteredby, String entryUserInactiveOrActive,
        String entryUserUsername, String entryUserFirstName, String entryUserMiddleName, 
        String entryUserLastName, String entryUserDob, String entryUserGender, 
        String entryUserContact, String entryUserSecContact, String entryUserHouseAdd, 
        String entryUserDistrict, String entryUserCity, String entryUserCountry)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        int userId;
        
        /*Putting values through Stored Procedure*/
        cmd.CommandText = "sp_entryUser";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting User Id from Username*/
        try
        {
            UserClass uc = new UserClass();
            DataTable dt = uc.GetUserIdFromUsername(entryUserUsername);
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
        cmd.Parameters.Add("@entryUserFirstName", entryUserFirstName);
        cmd.Parameters.Add("@entryUserMiddleName", entryUserMiddleName);
        cmd.Parameters.Add("@entryUserLastName", entryUserLastName);
        cmd.Parameters.Add("@entryUserDob", entryUserDob);
        cmd.Parameters.Add("@entryUserGender", entryUserGender);
        cmd.Parameters.Add("@entryUserContact", entryUserContact);
        cmd.Parameters.Add("@entryUserSecContact", entryUserSecContact);
        cmd.Parameters.Add("@entryUserHouseAdd", entryUserHouseAdd);
        cmd.Parameters.Add("@entryUserCity", entryUserCity);
        cmd.Parameters.Add("@entryUserDistrict", entryUserDistrict);
        cmd.Parameters.Add("@entryUserCountry", entryUserCountry);
        cmd.Parameters.Add("@entryUserDesignation", entryUserDesignation);
        cmd.Parameters.Add("@entryUserHospital", entryUserHospital);
        cmd.Parameters.Add("@entryUserRegisteredby", entryUserRegisteredby);
        cmd.Parameters.Add("@entryUserInactiveOrActive", entryUserInactiveOrActive);
        cmd.ExecuteNonQuery();
    }

    /*Register EntryUser: Insert in Users' table*/
    public void RegisterEntryUser_Users(String username, String userPasswd, String userEmail, String userSecEmail)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String userRegisteredDate, userType;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        userRegisteredDate = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        userType = "Entry";

        cmd.CommandText = "sp_users";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userRegisteredDate", userRegisteredDate);
        cmd.Parameters.Add("@username", username);
        cmd.Parameters.Add("@userPasswd", userPasswd);
        cmd.Parameters.Add("@userEmail", userEmail);
        cmd.Parameters.Add("@userSecEmail", userSecEmail);
        cmd.Parameters.Add("@userType", userType);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Users table's Username*/
    public void updateProfile_Users_username(String username, int userId)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_users_username";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@username", username);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Users table's SecEmail*/
    public void updateProfile_Users_userSecEmail(String userSecEmail, int userId)
    //String username, String userPasswd, String userEmail)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_users_userSecEmail";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@userSecEmail", userSecEmail);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Users table's Email*/
    public void updateProfile_Users_userEmail(String userEmail, int userId)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_users_userEmail";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@userEmail", userEmail);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's FullName*/
    public void updateProfile_EntryUser_entryUserFullName(int userId,
        String entryUserFirstName, String entryUserMiddleName, String entryUserLastName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_fullName";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserFirstName", entryUserFirstName);
        cmd.Parameters.Add("@entryUserMiddleName", entryUserMiddleName);
        cmd.Parameters.Add("@entryUserLastName", entryUserLastName);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's Address*/
    public void updateProfile_EntryUser_entryUserAddress(int userId,
        String entryUserHouseAdd, String entryUserDistrict, String entryUserCity,
        String entryUserCountry)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserAddress";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserHouseAdd", entryUserHouseAdd);
        cmd.Parameters.Add("@entryUserDistrict", entryUserDistrict);
        cmd.Parameters.Add("@entryUserCity", entryUserCity);
        cmd.Parameters.Add("@entryUserCountry", entryUserCountry);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's Dob*/
    public void updateProfile_EntryUser_entryUserDob(int userId, String entryUserDob)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserDob";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserDob", entryUserDob);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's Designation*/
    public void updateProfile_EntryUser_entryUserDesignation(int userId, String entryUserDesignation)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserDesignation";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserDesignation", entryUserDesignation);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's Status*/
    public void updateProfile_EntryUser_entryUserStatus(int userId, String entryUserStatus)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserInactiveOrActive";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserInactiveOrActive", entryUserStatus);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's Gender*/
    public void updateProfile_EntryUser_entryUserGender(int userId, String entryUserGender)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserGender";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserGender", entryUserGender);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's Current Hospital*/
    public void updateProfile_EntryUser_entryUserHospital(int userId, String entryUserHospital)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserHospital";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserHospital", entryUserHospital);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's Contact*/
    public void updateProfile_EntryUser_entryUserContact(int userId, String entryUserContact)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserContact";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserContact", entryUserContact);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of EntryUser table's SecContact*/
    public void updateProfile_EntryUser_entryUserSecContact(int userId, String entryUserSecContact)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_entryUser_entryUserSecContact";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@entryUserSecContact", entryUserSecContact);
        cmd.ExecuteNonQuery();
    }
    /*Update Profile of Users table's Password*/
    public void updateProfile_Users_userPassword(String userPassword, int userId)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_users_userPasswd";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@userPasswd", userPassword);
        cmd.ExecuteNonQuery();
    }
}