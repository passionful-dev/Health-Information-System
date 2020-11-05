using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserOtherUserClass
/// </summary>
public class UserOtherUserClass
{
    GlobalConnection gc = new GlobalConnection();

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

    /*Update Profile of OtherUser table's FullName*/
    public void updateProfile_OtherUser_otherUserFullName(int userId,
        String otherUserFirstName, String otherUserMiddleName, String otherUserLastName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_otherUser_fullName";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@otherUserFirstName", otherUserFirstName);
        cmd.Parameters.Add("@otherUserMiddleName", otherUserMiddleName);
        cmd.Parameters.Add("@otherUserLastName", otherUserLastName);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of OtherUser table's Address*/
    public void updateProfile_OtherUser_otherUserAddress(int userId,
        String otherUserHouseAdd, String otherUserDistrict, String otherUserCity, 
        String otherUserCountry)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_otherUser_otherUserAddress";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@otherUserHouseAdd", otherUserHouseAdd);
        cmd.Parameters.Add("@otherUserDistrict", otherUserDistrict);
        cmd.Parameters.Add("@otherUserCity", otherUserCity);
        cmd.Parameters.Add("@otherUserCountry", otherUserCountry);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of OtherUser table's Dob*/
    public void updateProfile_OtherUser_otherUserDob(int userId, String otherUserDob)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_otherUser_otherUserDob";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@otherUserDob", otherUserDob);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of OtherUser table's Gender*/
    public void updateProfile_OtherUser_otherUserGender(int userId, String otherUserGender)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_otherUser_otherUserGender";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@otherUserGender", otherUserGender);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of OtherUser table's Gender*/
    public void updateProfile_OtherUser_otherUserContact(int userId, String otherUserContact)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_otherUser_otherUserContact";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@otherUserContact", otherUserContact);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of OtherUser table's Gender*/
    public void updateProfile_OtherUser_otherUserSecContact(int userId, String otherUserSecContact)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_otherUser_otherUserSecContact";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@otherUserSecContact", otherUserSecContact);
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