using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for UserPatientClass
/// </summary>
public class UserPatientClass
{
    GlobalConnection gc = new GlobalConnection();

    //public void RegisterPatient_Users(String userId, String userRegisteredDate, String username, String userPasswd, String userEmail, String userType) {
    public void RegisterPatient_Users(String username, String userPasswd, String userEmail, String userSecEmail)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String userRegisteredDate, userType;
        
        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        userRegisteredDate = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");
        
        userType = "Patient";

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

    public void RegisterPatient_Patient(String patientUsername, String patientFirstName, String patientMiddleName, String patientLastName, String patientDob, String patientGender, String patientContact, String patientSecContact, String patientHouseAdd, String patientDistrict, String patientCity, String patientCountry)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String patientAgeGrp;
        int userId;

        /*Getting Patient Age Group*/
        DateTime currentDateNTime = DateTime.Now;
        int currentYear = currentDateNTime.Year; //Getting current year
        
        DateTime dob;
        dob = Convert.ToDateTime(patientDob);
        int dobYear = dob.Year; //Getting dob year

        int age = currentYear - dobYear;

        if (age >= 1 && age <= 4) {
            patientAgeGrp = "1-4";
        }
        else if (age >= 5 && age <= 14)
        {
            patientAgeGrp = "5-14";
        }
        else if (age >= 15 && age <= 19)
        {
            patientAgeGrp = "15-19";
        }
        else if (age >= 20 && age <= 29)
        {
            patientAgeGrp = "20-29";
        }
        else if (age >= 30 && age <= 39)
        {
            patientAgeGrp = "30-39";
        }
        else if (age >= 40 && age <= 49)
        {
            patientAgeGrp = "40-49";
        }
        else if (age >= 50 && age <= 59)
        {
            patientAgeGrp = "50-59";
        }
        else if (age >= 60 && age <= 64)
        {
            patientAgeGrp = "60-64";
        }
        else if (age >= 65)
        {
            patientAgeGrp = ">=65";
        }
        else {
            patientAgeGrp = "error value";
        }
        
        

        /*Putting values through Stored Procedure*/
        cmd.CommandText = "sp_patient";
        cmd.CommandType = CommandType.StoredProcedure;

        /*Getting User Id from Username*/
        try
        {
            UserClass uc = new UserClass();
            DataTable dt = uc.GetUserIdFromUsername(patientUsername);
            if (dt.Rows.Count > 0)
            {
                String userIdString = dt.Rows[0]["userId"].ToString();
                userId = Convert.ToInt32(userIdString);
                cmd.Parameters.Add("@userId", userId);
        
            }
            //else
            //{
            //    System.Console.WriteLine("Could not get userId!");
            //}
        }
        catch (Exception ex) {
            throw ex;
        }

        cmd.Parameters.Add("@patientFirstName", patientFirstName);
        cmd.Parameters.Add("@patientMiddleName", patientMiddleName);
        cmd.Parameters.Add("@patientLastName", patientLastName);
        cmd.Parameters.Add("@patientDob", patientDob);
        cmd.Parameters.Add("@patientAgeGrp", patientAgeGrp);
        cmd.Parameters.Add("@patientGender", patientGender);
        cmd.Parameters.Add("@patientContact", patientContact);
        cmd.Parameters.Add("@patientSecContact", patientSecContact);
        cmd.Parameters.Add("@patientHouseAdd", patientHouseAdd);
        cmd.Parameters.Add("@patientCity", patientCity);
        cmd.Parameters.Add("@patientDistrict", patientDistrict);
        cmd.Parameters.Add("@patientCountry", patientCountry);
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

    /*Update Profile of Patient table's FullName*/
    public void updateProfile_Patient_patientFullName(int userId,
        String patientFirstName, String patientMiddleName, String patientLastName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_patient_fullName";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@patientFirstName", patientFirstName);
        cmd.Parameters.Add("@patientMiddleName", patientMiddleName);
        cmd.Parameters.Add("@patientLastName", patientLastName);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Patient table's Address*/
    public void updateProfile_Patient_patientAddress(int userId,
        String patientHouseAdd, String patientDistrict, String patientCity,
        String patientCountry)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_patient_patientAddress";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@patientHouseAdd", patientHouseAdd);
        cmd.Parameters.Add("@patientDistrict", patientDistrict);
        cmd.Parameters.Add("@patientCity", patientCity);
        cmd.Parameters.Add("@patientCountry", patientCountry);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Patient table's Dob*/
    public void updateProfile_Patient_patientDob(int userId, String patientDob, String patientAgeGrp)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_patient_patientDob";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@patientDob", patientDob);
        cmd.Parameters.Add("@patientAgeGrp", patientAgeGrp);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Patient table's Gender*/
    public void updateProfile_Patient_patientGender(int userId, String patientGender)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_patient_patientGender";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@patientGender", patientGender);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Patient table's Contact*/
    public void updateProfile_Patient_patientContact(int userId, String patientContact)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_patient_patientContact";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@patientContact", patientContact);
        cmd.ExecuteNonQuery();
    }

    /*Update Profile of Patient table's SecContact*/
    public void updateProfile_Patient_patientSecContact(int userId, String patientSecContact)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_patient_patientSecContact";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.Parameters.Add("@patientSecContact", patientSecContact);
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