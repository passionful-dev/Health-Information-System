using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for EntryUserClass
/// </summary>
public class EntryUserClass
{
    GlobalConnection gc = new GlobalConnection();

    /*homeEntryUserFrom_userId*/
    public DataTable homeEntryUserFrom_userId(int selectedRow_UserId)
    {
        String data = "SELECT Log_UsersIndivField.userIndivFieldLog_Date As Dates, Log_UsersIndivField.userIndivFieldLog_Operation, Users.username, Log_UsersIndivField.userIndivFieldLog_Field, Log_UsersIndivField.userIndivFieldLog_DataBefore, Log_UsersIndivField.userIndivFieldLog_DataLater "
            + " FROM Log_UsersIndivField INNER JOIN Users ON Log_UsersIndivField.userId = Users.userId "
            + " Where Log_UsersIndivField.userId = " + selectedRow_UserId
            + " AND Log_UsersIndivField.userIndivFieldLog_Field <> 'userPasswd' "
            + " UNION "
            + " SELECT Log_EntryUserIndivField.entryUserIndivFieldLog_Date As Dates, Log_EntryUserIndivField.entryUserIndivFieldLog_Operation, EntryUser.entryUserFirstName + ' ' + EntryUser.entryUserMiddleName + ' ' + EntryUser.entryUserLastName As Name, Log_EntryUserIndivField.entryUserIndivFieldLog_Field, Log_EntryUserIndivField.entryUserIndivFieldLog_DataBefore, Log_EntryUserIndivField.entryUserIndivFieldLog_DataLater "
            + " FROM Log_EntryUserIndivField INNER JOIN EntryUser ON Log_EntryUserIndivField.entryUserId = EntryUser.userId "
            + " Where Log_EntryUserIndivField.entryUserIndivFieldLog_UpdatedBy = " + selectedRow_UserId
            + " UNION "
            + " SELECT Log_CheckedPatWholeField.checkedPatWholeFieldLog_Date As Dates, Log_CheckedPatWholeField.checkedPatWholeFieldLog_Operation, Patient.patientFirstName + ' ' + Patient.patientMiddleName + ' ' + Patient.patientLastName As Name, NULL, NULL, NULL "
            + " FROM Log_CheckedPatWholeField INNER JOIN CheckedPat ON Log_CheckedPatWholeField.checkedPatId = CheckedPat.checkedPatId "
            + " INNER JOIN Patient ON Patient.patientId = CheckedPat.patientId "
            + " Where CheckedPat.checkedPatBy = " + selectedRow_UserId;
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*selectEntryUserHospitalFrom_EntryUserUsername*/
    public DataTable selectEntryUserHospitalFrom_EntryUserUsername(String entryUser_username)
    {
        String data = "SELECT EntryUser.entryUserHospital "
            + " FROM Users INNER JOIN EntryUser "
            + " ON Users.userId = EntryUser.userId "
            + " WHERE Users.username = '" + entryUser_username + "' ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing EntryUserRecords By Specific Letter*/
    public DataTable SelectForViewEntryUserRecords_SpecificLetter(String usernameFirstLetter)
    {
        //String data = "SELECT Users.userRegisteredDate, Users.username, "
        //   + "EntryUser.entryUserFirstName + '  ' + EntryUser.entryUserMiddleName + '  ' + EntryUser.entryUserLastName As Name, "
        //   + "EntryUser.entryUserDesignation, EntryUser.entryUserHospital, EntryUser.entryUserInactiveOrActive, "
        //   + "EntryUser.entryUserDob, EntryUser.entryUserGender, EntryUser.entryUserContact  + ' ; ' +  "
        //   + "EntryUser.entryUserSecContact As Contacts, Users.userEmail  + ' ; ' +  Users.userSecEmail As Emails, "
        //   + "EntryUser.entryUserHouseAdd  + ' ; ' +   "
        //   + "EntryUser.entryUserCity  + ' ; ' +  EntryUser.entryUserDistrict "
        //     + "+ ' ; ' +  EntryUser.entryUserCountry As Address "
        //   + "FROM Users INNER JOIN EntryUser ON Users.userId = EntryUser.userId "
        //   + "WHERE Users.userType='Entry' "
        //   + "AND Users.username Like '" + usernameFirstLetter + "%'"
        //   + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC ";
        String data = "SELECT Users.userRegisteredDate, Users.username, "
         + "EntryUser.entryUserFirstName, EntryUser.entryUserMiddleName, EntryUser.entryUserLastName, "
         + "EntryUser.entryUserDesignation, EntryUser.entryUserHospital, EntryUser.entryUserInactiveOrActive, "
         + "EntryUser.entryUserDob, EntryUser.entryUserGender, EntryUser.entryUserContact, "
         + "EntryUser.entryUserSecContact, Users.userEmail, Users.userSecEmail, EntryUser.entryUserHouseAdd, "
         + "EntryUser.entryUserCity, EntryUser.entryUserDistrict, EntryUser.entryUserCountry "
         + "FROM Users INNER JOIN EntryUser ON Users.userId = EntryUser.userId "
         + "WHERE Users.userType='Entry' "
         + "AND Users.username Like '" + usernameFirstLetter + "%'"
         + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing EntryUserRecords*/
    public DataTable SelectForViewEntryUserRecords_ForReport()
    {
        String data = "SELECT Users.userRegisteredDate, Users.username, "
           + "EntryUser.entryUserFirstName + '  ' + EntryUser.entryUserMiddleName + '  ' + EntryUser.entryUserLastName As Name, "
           + "EntryUser.entryUserDesignation, EntryUser.entryUserHospital, EntryUser.entryUserInactiveOrActive, "
           + "EntryUser.entryUserDob, EntryUser.entryUserGender, EntryUser.entryUserContact  + ' ; ' +  "
           + "EntryUser.entryUserSecContact As Contacts, Users.userEmail  + ' ; ' +  Users.userSecEmail As Emails, "
           + "EntryUser.entryUserHouseAdd  + ' ; ' +   "
           + "EntryUser.entryUserCity  + ' ; ' +  EntryUser.entryUserDistrict "
             + "+ ' ; ' +  EntryUser.entryUserCountry As Address "
           + "FROM Users INNER JOIN EntryUser ON Users.userId = EntryUser.userId "
           + "WHERE Users.userType='Entry' "
           + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing EntryUserRecords By Specific Letter*/
    public DataTable SelectForViewEntryUserRecords_SpecificLetter_ForReport(String usernameFirstLetter)
    {
        String data = "SELECT Users.userRegisteredDate, Users.username, "
           + "EntryUser.entryUserFirstName + '  ' + EntryUser.entryUserMiddleName + '  ' + EntryUser.entryUserLastName As Name, "
           + "EntryUser.entryUserDesignation, EntryUser.entryUserHospital, EntryUser.entryUserInactiveOrActive, "
           + "EntryUser.entryUserDob, EntryUser.entryUserGender, EntryUser.entryUserContact  + ' ; ' +  "
           + "EntryUser.entryUserSecContact As Contacts, Users.userEmail  + ' ; ' +  Users.userSecEmail As Emails, "
           + "EntryUser.entryUserHouseAdd  + ' ; ' +   "
           + "EntryUser.entryUserCity  + ' ; ' +  EntryUser.entryUserDistrict "
             + "+ ' ; ' +  EntryUser.entryUserCountry As Address "
           + "FROM Users INNER JOIN EntryUser ON Users.userId = EntryUser.userId "
           + "WHERE Users.userType='Entry' "
           + "AND Users.username Like '" + usernameFirstLetter + "%'"
           + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC ";
        //String data = "SELECT Users.userRegisteredDate, Users.username, "
        // + "EntryUser.entryUserFirstName, EntryUser.entryUserMiddleName, EntryUser.entryUserLastName, "
        // + "EntryUser.entryUserDesignation, EntryUser.entryUserHospital, EntryUser.entryUserInactiveOrActive, "
        // + "EntryUser.entryUserDob, EntryUser.entryUserGender, EntryUser.entryUserContact, "
        // + "EntryUser.entryUserSecContact, Users.userEmail, Users.userSecEmail, EntryUser.entryUserHouseAdd, "
        // + "EntryUser.entryUserCity, EntryUser.entryUserDistrict, EntryUser.entryUserCountry "
        // + "FROM Users INNER JOIN EntryUser ON Users.userId = EntryUser.userId "
        // + "WHERE Users.userType='Entry' "
        // + "AND Users.username Like '" + usernameFirstLetter + "%'"
        // + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing EntryUserRecords*/
    public DataTable SelectForViewEntryUserRecords()
    {
        String data = "SELECT Users.userRegisteredDate, Users.username, "
         + "EntryUser.entryUserFirstName, EntryUser.entryUserMiddleName, EntryUser.entryUserLastName, "
         + "EntryUser.entryUserDesignation, EntryUser.entryUserHospital, EntryUser.entryUserInactiveOrActive, "
         + "EntryUser.entryUserDob, EntryUser.entryUserGender, EntryUser.entryUserContact, "
         + "EntryUser.entryUserSecContact, Users.userEmail, Users.userSecEmail, EntryUser.entryUserHouseAdd, "
         + "EntryUser.entryUserCity, EntryUser.entryUserDistrict, EntryUser.entryUserCountry "
         + "FROM Users INNER JOIN EntryUser ON Users.userId = EntryUser.userId "
         + "WHERE Users.userType='Entry' "
         + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select All Entry User from UserId*/
    public DataTable SelectAllEntryUserFromUserId(int userId)
    {
        String data = "SELECT * FROM EntryUser WHERE userId='" + userId + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "EntryUser");
        return ds.Tables[0];
    }
}