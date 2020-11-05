using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ChartClass
/// </summary>
public class ChartClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Chart Select Date and Disease*/
    public DataTable chart_SelectDateDisease()
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease FROM Chart_DateDisease";

        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];

    }

    /*Chart Select Date and UnhealthyPeople*/
    public DataTable chart_DateUnhealthyPeople()
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountPatient FROM Chart_DateUnhealthyPeople";
        
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];

    }

    /*Chart Select Date and UnhealthyFemale*/
    public DataTable Chart_DateUnhealthyFemale()
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountFemale FROM Chart_DateUnhealthyFemale";

        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];

    }

    /*Chart Select Date and UnhealthyMale*/
    public DataTable Chart_DateUnhealthyMale()
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountMale FROM Chart_DateUnhealthyMale";

        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];

    }

    /*Chart Select Date and UnhealthyAgeGrp*/
    public DataTable chart_DateUnhealthyAgeGrp(String ageGrp)
    {
        String data = "SELECT DATEADD(day, DATEDIFF(day, 0, CAST(CONVERT(DATETIME, Users.userRegisteredDate, 103) AS DATE)), 0) AS Dates, " 
            + "COUNT(patientId) As CountUnhealthyAgeGrp "
            + "FROM Patient INNER JOIN Users "
            + "ON Patient.userId = Users.userId "
            + "WHERE Patient.patientAgeGrp = '" + ageGrp + "'"
            + "GROUP BY DATEADD(day, DATEDIFF(day, 0, CAST(CONVERT(DATETIME, Users.userRegisteredDate, 103) As DATE)), 0)";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and UnhealthyDistrict*/
    public DataTable chart_DateUnhealthyDistrict(String district)
    {
        String data = "SELECT DATEADD(day, DATEDIFF(day, 0, CAST(CONVERT(DATETIME, Users.userRegisteredDate, 103) AS DATE)), 0) AS Dates, "
            + "COUNT(patientId) As CountUnhealthyDistrict "
            + "FROM Patient INNER JOIN Users "
            + "ON Patient.userId = Users.userId "
            + "WHERE Patient.patientDistrict = '" + district + "'"
            + "GROUP BY DATEADD(day, DATEDIFF(day, 0, CAST(CONVERT(DATETIME, Users.userRegisteredDate, 103) As DATE)), 0)";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and UnhealthyCity*/
    public DataTable chart_DateUnhealthyCity(String city)
    {
        String data = "SELECT DATEADD(day, DATEDIFF(day, 0, CAST(CONVERT(DATETIME, Users.userRegisteredDate, 103) AS DATE)), 0) AS Dates, "
            + "COUNT(patientId) As CountUnhealthyCity "
            + "FROM Patient INNER JOIN Users "
            + "ON Patient.userId = Users.userId "
            + "WHERE Patient.patientCity = '" + city + "'"
            + "GROUP BY DATEADD(day, DATEDIFF(day, 0, CAST(CONVERT(DATETIME, Users.userRegisteredDate, 103) As DATE)), 0)";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and People*/
    public DataTable chart_DateDiseasePeople()
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, CountDisease, "
            + "CountPatient FROM Chart_DateDiseasePeople";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Female*/
    public DataTable chart_DateDiseaseFemale()
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, CountDisease, "
            + "CountFemale FROM Chart_DateDiseaseFemale";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Male*/
    public DataTable chart_DateDiseaseMale()
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, CountDisease, "
            + "CountMale FROM Chart_DateDiseaseMale";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and AgeGrp*/
    public DataTable chart_DateDiseaseAgeGrp(String ageGrp)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "COUNT(patientId) As CountUnhealthyAgeGrp, CountDisease "
            + "FROM Chart_DateDiseaseAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease";
            //+ "ORDER BY Dates ASC";
            //+ "ORDER BY CAST(Dates As Date)";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and District*/
    public DataTable chart_DateDiseaseDistrict(String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "COUNT(patientId) As CountUnhealthyDistrict, CountDisease "
            + "FROM Chart_DateDiseaseDistrict "
            + "WHERE patientDistrict = '" + district + "' " 
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and City*/
    public DataTable chart_DateDiseaseCity(String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "COUNT(patientId) As CountUnhealthyCity, CountDisease "
            + "FROM Chart_DateDiseaseCity "
            + "WHERE patientCity = '" + city + "' "
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and People and AgeGrp*/
    public DataTable chart_DatePeopleAgeGrp(String ageGrp)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountPeople, COUNT(patientId) As CountAgeGrp "
            + "FROM Chart_DatePeopleAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' " 
            + "OR CountPeople IS NOT NULL "
            + "GROUP BY Dates, CountPeople ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Female and AgeGrp*/
    public DataTable chart_DateFemaleAgeGrp(String ageGrp)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountFemale, COUNT(patientId) As CountAgeGrp "
            + "FROM Chart_DateFemaleAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "OR CountFemale IS NOT NULL "
            + "GROUP BY Dates, CountFemale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Male and AgeGrp*/
    public DataTable chart_DateMaleAgeGrp(String ageGrp)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountMale, COUNT(patientId) As CountAgeGrp "
            + "FROM Chart_DateMaleAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "OR CountMale IS NOT NULL "
            + "GROUP BY Dates, CountMale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and AgeGrp and District*/
    public DataTable chart_DateAgeGrpDistrict(String ageGrp, String district)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountPeople "
            + "FROM Chart_DateAgeGrpDistrict "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientDistrict = '" + district + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and AgeGrp and City*/
    public DataTable chart_DateAgeGrpCity(String ageGrp, String city)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountPeople "
            + "FROM Chart_DateAgeGrpCity "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientCity = '" + city + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and People and District*/ //(Check this, if same as 1.f)
    public DataTable chart_DatePeopleDistrict(String district)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountPeople "
            + "FROM Chart_DatePeopleDistrict "
            + "WHERE patientDistrict = '" + district + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Female and District*/
    public DataTable chart_DateFemaleDistrict(String district)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountPeople "
            + "FROM Chart_DateFemaleDistrict "
            + "WHERE patientDistrict = '" + district + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Male and District*/
    public DataTable chart_DateMaleDistrict(String district)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountPeople "
            + "FROM Chart_DateMaleDistrict "
            + "WHERE patientDistrict = '" + district + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and People and City*/
    //(Same as 1.g (Check this))
    public DataTable chart_DatePeopleCity(String city)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountPeople "
            + "FROM Chart_DatePeopleCity "
            + "WHERE patientCity = '" + city + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Female and City*/
    public DataTable chart_DateFemaleCity(String city)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountFemale "
            + "FROM Chart_DateFemaleCity "
            + "WHERE patientCity = '" + city + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Male and City*/
    public DataTable chart_DateMaleCity(String city)
    {
        String data = "SELECT Dates, "
            + "COUNT(patientId) As CountMale "
            + "FROM Chart_DateMaleCity "
            + "WHERE patientCity = '" + city + "' "
            + "GROUP BY Dates ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and People and AgeGrp*/
    public DataTable chart_DateDiseasePeopleAgeGrp(String ageGrp)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountPeople, COUNT(patientId) As CountAgeGrp "
            + "FROM Chart_DateDiseasePeopleAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' " 
            + "OR CountDisease IS NOT NULL "
            + "OR CountPeople IS NOT NULL "
            + "GROUP BY Dates, CountPeople, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Female and AgeGrp*/
    public DataTable chart_DateDiseaseFemaleAgeGrp(String ageGrp)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountFemale, COUNT(patientId) As CountAgeGrp "
            + "FROM Chart_DateDiseaseFemaleAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' " 
            + "OR CountDisease IS NOT NULL "
            + "OR CountFemale IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountFemale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Male and AgeGrp*/
    public DataTable chart_DateDiseaseMaleAgeGrp(String ageGrp)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountMale, COUNT(patientId) As CountAgeGrp "
            + "FROM Chart_DateDiseaseMaleAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' " 
            + "OR CountDisease IS NOT NULL "
            + "OR CountMale IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountMale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and District and AgeGrp*/
    public DataTable chart_DateDiseaseDistrictAgeGrp(String ageGrp, String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseaseDistrictAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' " 
            + "AND patientDistrict = '" + district + "' "
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and City and AgeGrp*/
    public DataTable chart_DateDiseaseCityAgeGrp(String ageGrp, String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseaseCityAgeGrp "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientCity = '" + city + "' "
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and People and District*/
    public DataTable chart_DateDiseasePeopleDistrict(String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseasePeopleDistrict "
            + "WHERE patientDistrict = '" + district + "'"
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Female and District*/
    public DataTable chart_DateDiseaseFemaleDistrict(String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountFemale "
            + "FROM Chart_DateDiseaseFemaleDistrict "
            + "WHERE patientDistrict = '" + district + "'"
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Male and District*/
    public DataTable chart_DateDiseaseMaleDistrict(String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountMale "
            + "FROM Chart_DateDiseaseMaleDistrict "
            + "WHERE patientDistrict = '" + district + "'"
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    ///////////////////////////////////////
    /*Chart Select Date and Disease and People and City*/
    public DataTable chart_DateDiseasePeopleCity(String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseasePeopleCity "
            + "WHERE patientCity = '" + city + "'"
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Female and City*/
    public DataTable chart_DateDiseaseFemaleCity(String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountFemale "
            + "FROM Chart_DateDiseaseFemaleCity "
            + "WHERE patientCity = '" + city + "'"
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Male and City*/
    public DataTable chart_DateDiseaseMaleCity(String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, COUNT(patientId) As CountMale "
            + "FROM Chart_DateDiseaseMaleCity "
            + "WHERE patientCity = '" + city + "'"
            + "OR CountDisease IS NOT NULL "
            + "GROUP BY Dates, CountDisease ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and People and AgeGrp and District*/
    public DataTable chart_DateDiseasePeopleAgeGrpDistrict(String ageGrp, String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountPatient, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseasePeopleAgeGrpDistrict "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientDistrict = '" + district + "'"
            + "OR CountDisease IS NOT NULL "
            + "OR CountPatient IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountPatient ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Female and AgeGrp and District*/
    public DataTable chart_DateDiseaseFemaleAgeGrpDistrict(String ageGrp, String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountFemale, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseaseFemaleAgeGrpDistrict "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientDistrict = '" + district + "'"
            + "OR CountDisease IS NOT NULL "
            + "OR CountFemale IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountFemale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Male and AgeGrp and District*/
    public DataTable chart_DateDiseaseMaleAgeGrpDistrict(String ageGrp, String district)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountMale, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseaseMaleAgeGrpDistrict "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientDistrict = '" + district + "'"
            + "OR CountDisease IS NOT NULL "
            + "OR CountMale IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountMale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    ///////////////////////////////////////
    ///////////////////////////////////////
    ///////////////////////////////////////
    /*Chart Select Date and Disease and People and AgeGrp and City*/
    public DataTable chart_DateDiseasePeopleAgeGrpCity(String ageGrp, String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountPatient, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseasePeopleAgeGrpCity "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientCity = '" + city + "'"
            + "OR CountDisease IS NOT NULL "
            + "OR CountPatient IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountPatient ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Female and AgeGrp and City*/
    public DataTable chart_DateDiseaseFemaleAgeGrpCity(String ageGrp, String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountFemale, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseaseFemaleAgeGrpCity "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientCity = '" + city + "'"
            + "OR CountDisease IS NOT NULL "
            + "OR CountFemale IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountFemale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Chart Select Date and Disease and Male and AgeGrp and City*/
    public DataTable chart_DateDiseaseMaleAgeGrpCity(String ageGrp, String city)
    {
        String data = "SELECT CAST(CAST(Dates As DATE) As Varchar) As Dates, "
            + "CountDisease, CountMale, COUNT(patientId) As CountPeople "
            + "FROM Chart_DateDiseaseMaleAgeGrpCity "
            + "WHERE patientAgeGrp = '" + ageGrp + "' "
            + "AND patientCity = '" + city + "'"
            + "OR CountDisease IS NOT NULL "
            + "OR CountMale IS NOT NULL "
            + "GROUP BY Dates, CountDisease, CountMale ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }
}