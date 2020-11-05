using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for PatientClass
/// </summary>
public class PatientClass
{
    GlobalConnection gc = new GlobalConnection();

    /*get_checkedPatIdFrom_checkedPatDateNcheckedPatBy*/
    public DataTable get_checkedPatIdFrom_checkedPatDateNcheckedPatBy(
        String checkedPatDate, int checkedPatBy)
    {
        String data = "SELECT CheckedPat.checkedPatId "
            + " FROM CheckedPat "
            + " WHERE CheckedPat.checkedPatDate = ' " + checkedPatDate + "' "
            + " AND CheckedPat.checkedPatBy = " + checkedPatBy ;
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*insertIn_CheckedPat*/
    public void insertIn_CheckedPat(int selectedRow_patientId, String checkedPatDate, 
        String txtbox_DiseaseName, String txtbox_Remarks, String entryUserHospital, 
        int checkedPatBy)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        /*Putting values through Stored Procedure*/
        cmd.CommandText = "sp_checkedPat";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@patientId", selectedRow_patientId);
        cmd.Parameters.Add("@checkedPatDate", checkedPatDate);
        cmd.Parameters.Add("@checkedPatDiseaseName", txtbox_DiseaseName);
        cmd.Parameters.Add("@checkedPatRemarks", txtbox_Remarks);
        cmd.Parameters.Add("@checkedPatHospital", entryUserHospital);
        cmd.Parameters.Add("@checkedPatBy", checkedPatBy);
        cmd.ExecuteNonQuery();
    }

    /*selectPatientIdFromPatientUsername*/
    public DataTable selectPatientIdFromPatientUsername(String selected_PatUsername)
    {
        String data = "SELECT Patient.patientId "
            + " FROM Users INNER JOIN Patient "
            + " ON Users.userId = Patient.userId "
            + " WHERE Users.username = '" + selected_PatUsername + "' " ;
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*checkUpHistory*/
    public DataTable checkUpHistory(String selectedRow_Username)
    {
        String data = "SELECT CheckedPat.checkedPatDate As Date, CheckedPat.checkedPatDiseaseName As Disease, "
            + " CheckedPat.checkedPatRemarks As Remarks, CheckedPat.checkedPatHospital As Hospital, "
            + " Users.username As Checkedby "
            + " From CheckedPat INNER JOIN Users "
            + " ON CheckedPat.checkedPatBy = Users.userId  "
            + " WHERE CheckedPat.patientId = "
            + " (SELECT Patient.patientId "
            + " FROM Patient INNER JOIN Users "
            + " ON Patient.userId = Users.userId "
            + " WHERE Users.username = '" + selectedRow_Username + "') "
            + " ORDER BY CONVERT(DATETIME, CheckedPat.checkedPatDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*patientDetails_ForDoctor*/
    public DataTable patientDetails_ForDoctor(String selectedRow_Username)
    {
        String data = "SELECT Users.username As Username, Patient.patientFirstName + ' ' + "
            + " + Patient.patientMiddleName  + ' ' + Patient.patientLastName As Name, "
            + " Patient.patientDob As Dob, Patient.patientAgeGrp As AgeGrp, "
            + " Patient.patientGender As Sex "
            + " FROM Users INNER JOIN Patient "
            + " ON Users.userId = Patient.userId "
            + " WHERE Users.username = '" + selectedRow_Username + "' ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*logOfPatient*/
    public DataTable logOfPatient(int selectedRow_UserId)
    {
        String data = "SELECT Log_UsersIndivField.userIndivFieldLog_Date As Dates, Log_UsersIndivField.userIndivFieldLog_Operation, Users.username, Log_UsersIndivField.userIndivFieldLog_Field, Log_UsersIndivField.userIndivFieldLog_DataBefore, Log_UsersIndivField.userIndivFieldLog_DataLater "
            + " FROM Log_UsersIndivField INNER JOIN Users ON Log_UsersIndivField.userId = Users.userId  "
            + " Where Log_UsersIndivField.userId =  " + selectedRow_UserId
            + " AND Log_UsersIndivField.userIndivFieldLog_Field <> 'userPasswd' "
            + " UNION "
            + " SELECT Log_PatientIndivField.patientIndivFieldLog_Date As Dates, Log_PatientIndivField.patientIndivFieldLog_Operation, Patient.patientFirstName + ' ' + Patient.patientMiddleName + ' ' + Patient.patientLastName As Name, Log_PatientIndivField.patientIndivFieldLog_Field, Log_PatientIndivField.patientIndivFieldLog_DataBefore, Log_PatientIndivField.patientIndivFieldLog_DataLater "
            + " FROM Log_PatientIndivField INNER JOIN Patient ON Log_PatientIndivField.patientId = Patient.userId "
            + " Where Log_PatientIndivField.patientId =  " + selectedRow_UserId
            + " UNION "
            //+ " SELECT Log_PatientWholeField.patientWholeFieldLog_Date As Dates, Log_PatientWholeField.patientWholeFieldLog_Operation, Patient.patientFirstName + ' ' + Patient.patientMiddleName + ' ' + Patient.patientLastName As Name, NULL, NULL, NULL "
            //+ " FROM Log_PatientWholeField INNER JOIN Patient ON Log_PatientWholeField.patientId = Patient.patientId "
            //+ " Where Log_PatientWholeField.userId =  " + selectedRow_UserId
            //+ " UNION "
            + " SELECT Log_UsersWholeField.userWholeFieldLog_Date As Dates, Log_UsersWholeField.userWholeFieldLog_Operation, Users.username, NULL, NULL, NULL "
            + " FROM Log_UsersWholeField INNER JOIN Users ON Log_UsersWholeField.userId = Users.userId "
            + " Where Log_UsersWholeField.userId =  " + selectedRow_UserId ;
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Patient");
        return ds.Tables[0];
    }

    /*Select All Patient's District*/
    public DataTable SelectAllPatientDistrict()
    {
        String data = "SELECT patientDistrict FROM Patient";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Patient");
        return ds.Tables[0];
    }

    /*Select All Patient's City*/
    public DataTable SelectAllPatientCity()
    {
        String data = "SELECT patientCity FROM Patient";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Patient");
        return ds.Tables[0];
    }
    
    /*Delete Patient By userId*/
    public void delete_PatientFrom_userId(int userId)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_delete_patient";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@userId", userId);
        cmd.ExecuteNonQuery();
    }

    /*Select All Patient from UserId*/
    public DataTable SelectAllPatientFromUserId(int userId)
    {
        String data = "SELECT * FROM Patient WHERE userId='" + userId + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Patient");
        return ds.Tables[0];

        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = gc.cn;
        //cmd.CommandText = "sp_viewUsers_Login";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.ExecuteNonQuery();
    }

    /*Select For Viewing PatientRecords By Specific Letter*/
    public DataTable SelectForViewPatientRecords_SpecificLetter(String usernameFirstLetter)
    {
        String data = "SELECT Users.userRegisteredDate, Users.username, "
         + "Patient.patientFirstName, Patient.patientMiddleName, Patient.patientLastName, "
         + "Patient.patientDob, Patient.patientGender, Patient.patientContact, "
         + "Patient.patientSecContact, Users.userEmail, Users.userSecEmail, Patient.patientHouseAdd, "
         + "Patient.patientCity, Patient.patientDistrict, Patient.patientCountry "
         + "FROM Users INNER JOIN Patient ON Users.userId = Patient.userId "
         + "WHERE Users.userType='Patient'"
         + "AND Users.username Like '" + usernameFirstLetter + "%'"
         + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing PatientRecords*/
    public DataTable SelectForViewPatientRecords()
    {
        String data = "SELECT Users.userRegisteredDate, Users.username, "
         + "Patient.patientFirstName, Patient.patientMiddleName, Patient.patientLastName, "
         + "Patient.patientDob, Patient.patientGender, Patient.patientContact, "
         + "Patient.patientSecContact, Users.userEmail, Users.userSecEmail, Patient.patientHouseAdd, "
         + "Patient.patientCity, Patient.patientDistrict, Patient.patientCountry "
         + "FROM Users INNER JOIN Patient ON Users.userId = Patient.userId "
         + "WHERE Users.userType='Patient'"
         + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing PatientRecords For Report*/
    public DataTable SelectForViewPatientRecords_ForReport()
    {
        String data = "SELECT Users.userRegisteredDate, Users.username, "
         + "Patient.patientFirstName + ' '+ Patient.patientMiddleName + ' '+  Patient.patientLastName As Name, "
         + "Patient.patientDob, Patient.patientGender, Patient.patientContact + ' ; '+  "
         + "Patient.patientSecContact As Contacts, "
         + "Users.userEmail + ' ; '+  Users.userSecEmail As Emails, Patient.patientHouseAdd + ' ; '+  "
         + "Patient.patientCity + ' ; '+  Patient.patientDistrict + ' ; '+ Patient.patientCountry "
         + "As Address "
         + "FROM Users INNER JOIN Patient ON Users.userId = Patient.userId "
         + "WHERE Users.userType='Patient' "
         + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing PatientRecords By Specific Letter For Report*/
    public DataTable SelectForViewPatientRecords_SpecificLetter_ForReport(String usernameFirstLetter)
    {
        String data = "SELECT Users.userRegisteredDate, Users.username, "
         + "Patient.patientFirstName + ' '+ Patient.patientMiddleName + ' '+  Patient.patientLastName As Name, "
         + "Patient.patientDob, Patient.patientGender, Patient.patientContact + ' ; '+  "
         + "Patient.patientSecContact As Contacts, "
         + "Users.userEmail + ' ; '+  Users.userSecEmail As Emails, Patient.patientHouseAdd + ' ; '+  "
         + "Patient.patientCity + ' ; '+  Patient.patientDistrict + ' ; '+ Patient.patientCountry "
         + "As Address "
         + "FROM Users INNER JOIN Patient ON Users.userId = Patient.userId "
         + "WHERE Users.userType='Patient' "
         + "AND Users.username Like '" + usernameFirstLetter + "%'"
         + "ORDER BY CONVERT(DATETIME, userRegisteredDate, 103) DESC";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }
}