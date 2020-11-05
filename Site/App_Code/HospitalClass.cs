using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for HospitalClass
/// </summary>
public class HospitalClass
{
    GlobalConnection gc = new GlobalConnection();

    /*Select All Hospital's hospitalFullName*/
    public DataTable selectAllHospitalFullName()
    {
        String data = "SELECT hospitalFullName FROM Hospital";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Hospital");
        return ds.Tables[0];
    }

    /*Delete hospitalFrom hospitalId*/
    public void delete_hospitalFrom_hospitalId(int hospitalId)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_delete_Hospital";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@hospitalId", hospitalId);
        cmd.ExecuteNonQuery();
    }

    /*Update hospitalFullName From hospitalId*/
    public void update_hospitalFullNameFrom_hospitalId(int hospitalId, String hospitalFullName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_hospital_hospitalFullName";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@hospitalId", hospitalId);
        cmd.Parameters.Add("@hospitalFullName", hospitalFullName);
        cmd.ExecuteNonQuery();
    }

    /*Update hospitalDescription From hospitalId*/
    public void update_hospitalDescriptionFrom_hospitalId(int hospitalId, String hospitalDescription)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_hospital_hospitalDescription";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@hospitalId", hospitalId);
        cmd.Parameters.Add("@hospitalDescription", hospitalDescription);
        cmd.ExecuteNonQuery();
    }

    /*Update hospitalAddress From hospitalId*/
    public void update_hospitalAddressFrom_hospitalId(int hospitalId, String hospitalHouseAdd,
        String hospitalDistrict, String hospitalCity)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_hospital_hospitalAddress";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@hospitalId", hospitalId);
        cmd.Parameters.Add("@hospitalHouseAdd", hospitalHouseAdd);
        cmd.Parameters.Add("@hospitalDistrict", hospitalDistrict);
        cmd.Parameters.Add("@hospitalCity", hospitalCity);
        cmd.ExecuteNonQuery();
    }

    /*Update hospitalType From hospitalId*/
    public void update_hospitalTypeFrom_hospitalId(int hospitalId, String hospitalType)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        cmd.CommandText = "sp_update_hospital_hospitalType";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@hospitalId", hospitalId);
        cmd.Parameters.Add("@hospitalType", hospitalType);
        cmd.ExecuteNonQuery();
    }

    /*Insert Hospital*/
    public void InsertHospital(String hospitalFullName, String hospitalType, String hospitalHouseAdd,
        String hospitalDistrict, String hospitalCity, String hospitalDescrip, int hospitalRegdBy)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = gc.cn;

        String hospitalRegdDate;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        hospitalRegdDate = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        cmd.CommandText = "sp_hospital";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@hospitalFullName", hospitalFullName);
        cmd.Parameters.Add("@hospitalType", hospitalType);
        cmd.Parameters.Add("@hospitalHouseAdd", hospitalHouseAdd);
        cmd.Parameters.Add("@hospitalDistrict", hospitalDistrict);
        cmd.Parameters.Add("@hospitalCity", hospitalCity);
        cmd.Parameters.Add("@hospitalDescription", hospitalDescrip);
        cmd.Parameters.Add("@hospitalRegdBy", hospitalRegdBy);
        cmd.Parameters.Add("@hospitalRegdDate", hospitalRegdDate);
        cmd.ExecuteNonQuery();
    }

    /*Select All Hospital From HospitalFullName*/
    public DataTable SelectAllHospitalFromHospitalFullName(String hospitalFullName)
    {
        String data = "SELECT * FROM Hospital WHERE hospitalFullName='" + hospitalFullName + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Hospital");
        return ds.Tables[0];
    }

    /*Select For Viewing HospitalRecords By Specific Letter For Report*/
    public DataTable SelectForViewHospitalRecords_SpecificLetter_ForReport(String hospitalNameFirstLetter)
    {
        //String data = "SELECT Hospital.hospitalFullName, Hospital.hospitalType, "
        // + "Hospital.hospitalHouseAdd, Hospital.hospitalCity, Hospital.hospitalDistrict, "
        // + "Hospital.hospitalDescription, Hospital.hospitalRegdDate, Users.username "
        // + "FROM Hospital INNER JOIN Users ON Hospital.hospitalRegdBy = Users.userId "
        // + "WHERE hospitalFullName Like '" + hospitalNameFirstLetter + "%'"
        //    //+ "OR hospitalFullName Like '" + hospitalNameFirstLetter.ToLower() + "%'"
        // + "ORDER BY CONVERT(DATETIME, hospitalRegdDate, 103) DESC";

        String data = "SELECT Hospital.hospitalFullName, Hospital.hospitalType, "
                + "Hospital.hospitalHouseAdd + ' ; ' "
                + "+ Hospital.hospitalCity + ' ; ' "
                + "+ Hospital.hospitalDistrict As Address, "
                + "Hospital.hospitalDescription, Hospital.hospitalRegdDate, Users.username "
                + "FROM Hospital INNER JOIN Users ON Hospital.hospitalRegdBy = Users.userId "
                + "WHERE hospitalFullName Like '" + hospitalNameFirstLetter + "%'"
                + "ORDER BY CONVERT(DATETIME, hospitalRegdDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing HospitalRecords For Report*/
    public DataTable selectForViewHospitalRecords_ForReport()
    {
        String data = "SELECT Hospital.hospitalFullName, Hospital.hospitalType, "
                + "Hospital.hospitalHouseAdd + ' ; ' "
                + "+ Hospital.hospitalCity + ' ; ' "
                + "+ Hospital.hospitalDistrict As Address, "
                + "Hospital.hospitalDescription, Hospital.hospitalRegdDate, Users.username "
                + "FROM Hospital INNER JOIN Users ON Hospital.hospitalRegdBy = Users.userId "
                + "ORDER BY CONVERT(DATETIME, hospitalRegdDate, 103) DESC ";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing HospitalRecords By Specific Letter*/
    public DataTable SelectForViewHospitalRecords_SpecificLetter(String hospitalNameFirstLetter)
    {
        String data = "SELECT Hospital.hospitalFullName, Hospital.hospitalType, "
         + "Hospital.hospitalHouseAdd, Hospital.hospitalCity, Hospital.hospitalDistrict, "
         + "Hospital.hospitalDescription, Hospital.hospitalRegdDate, Users.username "
         + "FROM Hospital INNER JOIN Users ON Hospital.hospitalRegdBy = Users.userId "
         + "WHERE hospitalFullName Like '" + hospitalNameFirstLetter + "%'"
            //+ "OR hospitalFullName Like '" + hospitalNameFirstLetter.ToLower() + "%'"
         + "ORDER BY CONVERT(DATETIME, hospitalRegdDate, 103) DESC";

        //String data = "SELECT Hospital.hospitalFullName, Hospital.hospitalType, "
        // + "Hospital.hospitalHouseAdd, Hospital.hospitalCity, Hospital.hospitalDistrict, "
        // + "Hospital.hospitalDescription, Hospital.hospitalRegdDate "
        // + "FROM Hospital INNER JOIN Users ON Hospital.hospitalRegdBy = Users.userId "
        // + "WHERE hospitalFullName Like '" + hospitalNameFirstLetter + "%'"
        //    //+ "OR hospitalFullName Like '" + hospitalNameFirstLetter.ToLower() + "%'"
        // + "ORDER BY CONVERT(DATETIME, hospitalRegdDate, 103) DESC";

        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select For Viewing HospitalRecords*/
    public DataTable SelectForViewHospitalRecords()
    {
        String data = "SELECT Hospital.hospitalFullName, Hospital.hospitalType, "
         + "Hospital.hospitalHouseAdd, Hospital.hospitalCity, Hospital.hospitalDistrict, "
         + "Hospital.hospitalDescription, Hospital.hospitalRegdDate, Users.username "
         + "FROM Hospital INNER JOIN Users ON Hospital.hospitalRegdBy = Users.userId "
         + "ORDER BY CONVERT(DATETIME, hospitalRegdDate, 103) DESC";

        //String data = "SELECT Hospital.hospitalFullName, Hospital.hospitalType, "
        // + "Hospital.hospitalHouseAdd, Hospital.hospitalCity, Hospital.hospitalDistrict, "
        // + "Hospital.hospitalDescription, Hospital.hospitalRegdDate "
        // + "FROM Hospital INNER JOIN Users ON Hospital.hospitalRegdBy = Users.userId "
        // + "ORDER BY CONVERT(DATETIME, hospitalRegdDate, 103) DESC";

        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    /*Select Mixed Address From Hospital To Get Divided Address Data*/
    public DataTable SelectAddressFromHospitalFullName(String selectedRow_HospitalName)
    {
        String data = "SELECT hospitalHouseAdd, hospitalCity, hospitalDistrict "
         + "FROM Hospital "
         + "WHERE hospitalFullName ='" + selectedRow_HospitalName + "'";
        SqlDataAdapter da = new SqlDataAdapter(data, gc.cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }
}