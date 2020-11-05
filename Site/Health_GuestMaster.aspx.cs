using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Health_GuestMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Of2_Ok_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of2.SelectedValue == "Date and Disease")
        {
            ChartClass cc = new ChartClass();
            DataTable dt = cc.chart_SelectDateDisease();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countDisease";
                    //Chart1.Series.Add("Series1");
                    //Chart1.Series["Series1"].YValueMembers = "CountUnhealthyAgeGrp";
                    //Chart1.Series["Series1"].YValueMembers = "CountFemale";

                    Chart1.Series["Series"].Name = "Disease";
                    //Chart1.Series["Series1"].Name = "AgeGrp";
                    //Chart1.Series["Series1"].Name = "Female";
                    // Data bind to the selected data source
                    Chart1.DataBind();
                }
                else
                {
                    ltrMessage.Text = "Data not retrieved!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of2.SelectedValue == "Date and Unhealthy People")
        {
            ChartClass cc = new ChartClass();
            DataTable dt = cc.chart_DateUnhealthyPeople();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countPatient";
                    Chart1.Series["Series"].Name = "Patient";
                    Chart1.DataBind();
                }
                else
                {
                    ltrMessage.Text = "Data not retrieved!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of2.SelectedValue == "Date and Unhealthy Female")
        {
            ChartClass cc = new ChartClass();
            DataTable dt = cc.Chart_DateUnhealthyFemale();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countFemale";
                    Chart1.Series["Series"].Name = "Female";
                    Chart1.DataBind();
                }
                else
                {
                    ltrMessage.Text = "Data not retrieved!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of2.SelectedValue == "Date and Unhealthy Male")
        {
            ChartClass cc = new ChartClass();
            DataTable dt = cc.Chart_DateUnhealthyMale();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countMale";
                    Chart1.Series["Series"].Name = "Male";
                    Chart1.DataBind();
                }
                else
                {
                    ltrMessage.Text = "Data not retrieved!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of2.SelectedValue == "Date and Unhealthy AgeGrp")
        {
            dropdownlist_AgeGrp.Visible = true;
            btnOk_AgeGrp.Visible = true;
        }
        else if (dropdownlist_Of2.SelectedValue == "Date and Unhealthy District")
        {
            dropdownlist_District.Visible = true;
            btnOk_District.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District.DataSource = dt;
                    dropdownlist_District.DataValueField = "patientDistrict";
                    dropdownlist_District.DataTextField = "patientDistrict";
                    dropdownlist_District.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

        }
        else if (dropdownlist_Of2.SelectedValue == "Date and Unhealthy City")
        {
            dropdownlist_City.Visible = true;
            btnOk_City.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City.DataSource = dt;
                    dropdownlist_City.DataValueField = "patientCity";
                    dropdownlist_City.DataTextField = "patientCity";
                    dropdownlist_City.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else { ltrMessage.Text = "No data given!"; }
    }
    protected void btnOk_AgeGrp_Click(object sender, EventArgs e)
    {
        ChartClass cc = new ChartClass();

        /*Check the AgeGrp first*/
        if (dropdownlist_AgeGrp.SelectedValue == "1-4")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == "5-14")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + "5-14";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == "15-19")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + "15-19";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == "20-29")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + "20-29";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == "30-39")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + "30-39";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == "40-49")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + "40-49";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == "50-59")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + "50-59";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == "60-64")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + "60-64";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_AgeGrp.SelectedValue == ">=65")
        {
            try
            {
                DataTable dt = cc.chart_DateUnhealthyAgeGrp(dropdownlist_AgeGrp.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart1.DataSource = dt;
                    Chart1.Series.Add("Series");
                    Chart1.Series["Series"].XValueMember = "dates";
                    Chart1.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                    Chart1.Series["Series"].Name = "AgeGrp: " + ">=65";
                    Chart1.DataBind();
                    dropdownlist_AgeGrp.Visible = false;
                    btnOk_AgeGrp.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else
        {
            //ltrMessage.Text = "Error!"; 
        }
    }
    protected void btnOk_District_Click(object sender, EventArgs e)
    {
        ChartClass cc = new ChartClass();
        try
        {
            DataTable dt = cc.chart_DateUnhealthyDistrict(dropdownlist_District.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                Chart1.DataSource = dt;
                Chart1.Series.Add("Series");
                Chart1.Series["Series"].XValueMember = "dates";
                Chart1.Series["Series"].YValueMembers = "countUnhealthyDistrict";
                Chart1.Series["Series"].Name = "District: " + dropdownlist_District.SelectedValue;
                Chart1.DataBind();
                dropdownlist_District.Visible = false;
                btnOk_District.Visible = false;
            }
            else
            {
                ltrMessage.Text = " No Data!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void btnOk_City_Click(object sender, EventArgs e)
    {
        ChartClass cc = new ChartClass();
        try
        {
            DataTable dt = cc.chart_DateUnhealthyCity(dropdownlist_City.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                Chart1.DataSource = dt;
                Chart1.Series.Add("Series");
                Chart1.Series["Series"].XValueMember = "dates";
                Chart1.Series["Series"].YValueMembers = "countUnhealthyCity";
                Chart1.Series["Series"].Name = "City: " + dropdownlist_City.SelectedValue;
                Chart1.DataBind();
                dropdownlist_City.Visible = false;
                btnOk_City.Visible = false;
            }
            else
            {
                ltrMessage.Text = " No Data!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void btn_Of3_Ok_Click(object sender, EventArgs e)
    {
        dropdownlist_AgeGrp_Of3.Visible = false;
        btnOk_AgeGrp_Of3.Visible = false;

        if (dropdownlist_Of3.SelectedValue == "Date and Disease and People")
        {
            ChartClass cc = new ChartClass();
            DataTable dt = cc.chart_DateDiseasePeople();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countDisease";
                    Chart2.Series.Add("Series1");
                    Chart2.Series["Series1"].YValueMembers = "countPatient";
                    Chart2.Series["Series"].Name = "Disease";
                    Chart2.Series["Series1"].Name = "People";
                    Chart2.DataBind();
                }
                else
                {
                    ltrMessage.Text = "Data not retrieved!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Disease and Female")
        {
            ChartClass cc = new ChartClass();
            DataTable dt = cc.chart_DateDiseaseFemale();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countDisease";
                    Chart2.Series.Add("Series1");
                    Chart2.Series["Series1"].YValueMembers = "countFemale";
                    Chart2.Series["Series"].Name = "Disease";
                    Chart2.Series["Series1"].Name = "Female";
                    Chart2.DataBind();
                }
                else
                {
                    ltrMessage.Text = "Data not retrieved!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Disease and Male")
        {
            ChartClass cc = new ChartClass();
            DataTable dt = cc.chart_DateDiseaseMale();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countDisease";
                    Chart2.Series.Add("Series1");
                    Chart2.Series["Series1"].YValueMembers = "countMale";
                    Chart2.Series["Series"].Name = "Disease";
                    Chart2.Series["Series1"].Name = "Male";
                    Chart2.DataBind();
                }
                else
                {
                    ltrMessage.Text = "Data not retrieved!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
        {
            dropdownlist_AgeGrp_Of3.Visible = true;
            btnOk_AgeGrp_Of3.Visible = true;
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Disease and District")
        {
            dropdownlist_District_Of3.Visible = true;
            btnOk_District_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of3.DataSource = dt;
                    dropdownlist_District_Of3.DataValueField = "patientDistrict";
                    dropdownlist_District_Of3.DataTextField = "patientDistrict";
                    dropdownlist_District_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Disease and City")
        {
            dropdownlist_City_Of3.Visible = true;
            btnOk_City_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of3.DataSource = dt;
                    dropdownlist_City_Of3.DataValueField = "patientCity";
                    dropdownlist_City_Of3.DataTextField = "patientCity";
                    dropdownlist_City_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
        {
            dropdownlist_AgeGrp_Of3.Visible = true;
            btnOk_AgeGrp_Of3.Visible = true;
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
        {
            dropdownlist_AgeGrp_Of3.Visible = true;
            btnOk_AgeGrp_Of3.Visible = true;
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
        {
            dropdownlist_AgeGrp_Of3.Visible = true;
            btnOk_AgeGrp_Of3.Visible = true;
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and AgeGrp and District")
        {
            dropdownlist_AgeGrp_Of3.Visible = true;
            btnOk_AgeGrp_Of3.Visible = true;

        }
        else if (dropdownlist_Of3.SelectedValue == "Date and AgeGrp and City")
        {
            dropdownlist_AgeGrp_Of3.Visible = true;
            btnOk_AgeGrp_Of3.Visible = true;

        }
        else if (dropdownlist_Of3.SelectedValue == "Date and People and District")
        {
            dropdownlist_District_Of3.Visible = true;
            btnOk_District_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of3.DataSource = dt;
                    dropdownlist_District_Of3.DataValueField = "patientDistrict";
                    dropdownlist_District_Of3.DataTextField = "patientDistrict";
                    dropdownlist_District_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Female and District")
        {
            dropdownlist_District_Of3.Visible = true;
            btnOk_District_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of3.DataSource = dt;
                    dropdownlist_District_Of3.DataValueField = "patientDistrict";
                    dropdownlist_District_Of3.DataTextField = "patientDistrict";
                    dropdownlist_District_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Male and District")
        {
            dropdownlist_District_Of3.Visible = true;
            btnOk_District_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of3.DataSource = dt;
                    dropdownlist_District_Of3.DataValueField = "patientDistrict";
                    dropdownlist_District_Of3.DataTextField = "patientDistrict";
                    dropdownlist_District_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and People and City")
        {
            dropdownlist_City_Of3.Visible = true;
            btnOk_City_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of3.DataSource = dt;
                    dropdownlist_City_Of3.DataValueField = "patientCity";
                    dropdownlist_City_Of3.DataTextField = "patientCity";
                    dropdownlist_City_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Female and City")
        {
            dropdownlist_City_Of3.Visible = true;
            btnOk_City_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of3.DataSource = dt;
                    dropdownlist_City_Of3.DataValueField = "patientCity";
                    dropdownlist_City_Of3.DataTextField = "patientCity";
                    dropdownlist_City_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else if (dropdownlist_Of3.SelectedValue == "Date and Male and City")
        {
            dropdownlist_City_Of3.Visible = true;
            btnOk_City_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of3.DataSource = dt;
                    dropdownlist_City_Of3.DataValueField = "patientCity";
                    dropdownlist_City_Of3.DataTextField = "patientCity";
                    dropdownlist_City_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        else { }
    }
    protected void btnOk_AgeGrp_Of3_Click(object sender, EventArgs e)
    {
        ChartClass cc = new ChartClass();

        if (dropdownlist_Of3.SelectedValue == "Date and AgeGrp and City")
        {
            dropdownlist_City_Of3.Visible = true;
            btnOk_City_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of3.DataSource = dt;
                    dropdownlist_City_Of3.DataValueField = "patientCity";
                    dropdownlist_City_Of3.DataTextField = "patientCity";
                    dropdownlist_City_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }

        if (dropdownlist_Of3.SelectedValue == "Date and AgeGrp and District")
        {
            dropdownlist_District_Of3.Visible = true;
            btnOk_District_Of3.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of3.DataSource = dt;
                    dropdownlist_District_Of3.DataValueField = "patientDistrict";
                    dropdownlist_District_Of3.DataTextField = "patientDistrict";
                    dropdownlist_District_Of3.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }

        /*Check the AgeGrp first*/
        if (dropdownlist_AgeGrp_Of3.SelectedValue == "1-4")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == "5-14")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + "5-14";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }

        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == "15-19")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {

                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + "15-19";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }

        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == "20-29")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + "20-29";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == "30-39")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + "30-39";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == "40-49")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + "40-49";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == "50-59")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + "50-59";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }


        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == "60-64")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + "60-64";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }


        }
        else if (dropdownlist_AgeGrp_Of3.SelectedValue == ">=65")
        {
            if (dropdownlist_Of3.SelectedValue == "Date and Disease and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateDiseaseAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countUnhealthyAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + ">=65";
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countDisease";
                        Chart2.Series["Series1"].Name = "Disease";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
            }
            else if (dropdownlist_Of3.SelectedValue == "Date and People and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DatePeopleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countPeople";
                        Chart2.Series["Series1"].Name = "People";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Female and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateFemaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countFemale";
                        Chart2.Series["Series1"].Name = "Female";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }
            else if (dropdownlist_Of3.SelectedValue == "Date and Male and AgeGrp")
            {
                try
                {
                    DataTable dt = cc.chart_DateMaleAgeGrp(dropdownlist_AgeGrp_Of3.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        ltrMessage.Text = "";
                        Chart2.DataSource = dt;
                        Chart2.Series.Add("Series");
                        Chart2.Series["Series"].XValueMember = "dates";
                        Chart2.Series["Series"].YValueMembers = "countAgeGrp";
                        Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue;
                        Chart2.Series.Add("Series1");
                        Chart2.Series["Series1"].YValueMembers = "countMale";
                        Chart2.Series["Series1"].Name = "Male";

                        Chart2.DataBind();
                        dropdownlist_AgeGrp_Of3.Visible = false;
                        btnOk_AgeGrp_Of3.Visible = false;
                    }
                    else
                    {
                        ltrMessage.Text = " No Data!";
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

            }

        }
        else
        {
            //ltrMessage.Text = "Error selected!"; 
        }
    }
    protected void btnOk_AgeGrp_Of4_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and City and AgeGrp")
        {
            dropdownlist_City_Of4.Visible = true;
            btnOk_City_Of4.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of4.DataSource = dt;
                    dropdownlist_City_Of4.DataValueField = "patientCity";
                    dropdownlist_City_Of4.DataTextField = "patientCity";
                    dropdownlist_City_Of4.DataBind();
                }
            }
            catch (Exception ex)
            {
                //ltrMessage_Of4.Text = "Error";
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and District and AgeGrp")
        {
            dropdownlist_District_Of4.Visible = true;
            btnOk_District_Of4.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of4.DataSource = dt;
                    dropdownlist_District_Of4.DataValueField = "patientDistrict";
                    dropdownlist_District_Of4.DataTextField = "patientDistrict";
                    dropdownlist_District_Of4.DataBind();
                }
            }
            catch (Exception ex)
            {
                //ltrMessage_Of4.Text = "Error";
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Male and AgeGrp")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseMaleAgeGrp(
                    dropdownlist_AgeGrp_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countAgeGrp";
                    Chart3.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    Chart3.Series.Add("Series2");
                    Chart3.Series["Series2"].YValueMembers = "countMale";
                    Chart3.Series["Series2"].Name = "Male";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Female and AgeGrp")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseFemaleAgeGrp(
                    dropdownlist_AgeGrp_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countAgeGrp";
                    Chart3.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    Chart3.Series.Add("Series2");
                    Chart3.Series["Series2"].YValueMembers = "countFemale";
                    Chart3.Series["Series2"].Name = "Female";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and People and AgeGrp")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseasePeopleAgeGrp(
                    dropdownlist_AgeGrp_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countAgeGrp";
                    Chart3.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    Chart3.Series.Add("Series2");
                    Chart3.Series["Series2"].YValueMembers = "countPeople";
                    Chart3.Series["Series2"].Name = "People";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }

    }
    protected void btnOk_AgeGrp_Of5_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Male and AgeGrp and City")
        {
            dropdownlist_City_Of5.Visible = true;
            btnOk_City_Of5.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of5.DataSource = dt;
                    dropdownlist_City_Of5.DataValueField = "patientCity";
                    dropdownlist_City_Of5.DataTextField = "patientCity";
                    dropdownlist_City_Of5.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage_Of5.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Female and AgeGrp and City")
        {
            dropdownlist_City_Of5.Visible = true;
            btnOk_City_Of5.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of5.DataSource = dt;
                    dropdownlist_City_Of5.DataValueField = "patientCity";
                    dropdownlist_City_Of5.DataTextField = "patientCity";
                    dropdownlist_City_Of5.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage_Of5.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and People and AgeGrp and City")
        {
            dropdownlist_City_Of5.Visible = true;
            btnOk_City_Of5.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientCity();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_City_Of5.DataSource = dt;
                    dropdownlist_City_Of5.DataValueField = "patientCity";
                    dropdownlist_City_Of5.DataTextField = "patientCity";
                    dropdownlist_City_Of5.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage_Of5.Text = ex.Message;
            }
        }

        /////////////////////////////////////////////////////
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Male and AgeGrp and District")
        {
            dropdownlist_District_Of5.Visible = true;
            btnOk_District_Of5.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of5.DataSource = dt;
                    dropdownlist_District_Of5.DataValueField = "patientDistrict";
                    dropdownlist_District_Of5.DataTextField = "patientDistrict";
                    dropdownlist_District_Of5.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage_Of5.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Female and AgeGrp and District")
        {
            dropdownlist_District_Of5.Visible = true;
            btnOk_District_Of5.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of5.DataSource = dt;
                    dropdownlist_District_Of5.DataValueField = "patientDistrict";
                    dropdownlist_District_Of5.DataTextField = "patientDistrict";
                    dropdownlist_District_Of5.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage_Of5.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and People and AgeGrp and District")
        {
            dropdownlist_District_Of5.Visible = true;
            btnOk_District_Of5.Visible = true;

            PatientClass pc = new PatientClass();
            try
            {
                DataTable dt = pc.SelectAllPatientDistrict();
                if (dt.Rows.Count > 0)
                {
                    dropdownlist_District_Of5.DataSource = dt;
                    dropdownlist_District_Of5.DataValueField = "patientDistrict";
                    dropdownlist_District_Of5.DataTextField = "patientDistrict";
                    dropdownlist_District_Of5.DataBind();
                }
            }
            catch (Exception ex)
            {
                ltrMessage_Of5.Text = ex.Message;
            }
        }

        else
        {
            //ltrMessage.Text = "Error!"; 
        }
    }
    protected void btnOk_District_Of3_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of3.SelectedValue == "Date and Male and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateMaleDistrict(dropdownlist_District_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countPeople";
                    Chart2.Series["Series"].Name = "District: " + dropdownlist_District_Of3.SelectedValue;

                    Chart2.DataBind();
                    dropdownlist_District_Of3.Visible = false;
                    btnOk_District_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of3.SelectedValue == "Date and Female and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateFemaleDistrict(dropdownlist_District_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countPeople";
                    Chart2.Series["Series"].Name = "District: " + dropdownlist_District_Of3.SelectedValue;

                    Chart2.DataBind();
                    dropdownlist_District_Of3.Visible = false;
                    btnOk_District_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of3.SelectedValue == "Date and People and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DatePeopleDistrict(dropdownlist_District_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countPeople";
                    Chart2.Series["Series"].Name = "District: " + dropdownlist_District_Of3.SelectedValue;

                    Chart2.DataBind();
                    dropdownlist_District_Of3.Visible = false;
                    btnOk_District_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of3.SelectedValue == "Date and AgeGrp and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateAgeGrpDistrict(dropdownlist_AgeGrp_Of3.SelectedValue,
                    dropdownlist_District_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countPeople";
                    Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue
                        + "\n District: " + dropdownlist_District_Of3.SelectedValue;

                    //Chart2.Series.Add("Series1");
                    //Chart2.Series["Series1"].YValueMembers = "countDisease";
                    //Chart2.Series["Series1"].Name = "Disease";

                    Chart2.DataBind();
                    dropdownlist_AgeGrp_Of3.Visible = false;
                    btnOk_AgeGrp_Of3.Visible = false;
                    dropdownlist_District_Of3.Visible = false;
                    btnOk_District_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of3.SelectedValue == "Date and Disease and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseDistrict(dropdownlist_District_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countUnhealthyDistrict";
                    Chart2.Series["Series"].Name = "District: " + dropdownlist_District_Of3.SelectedValue;
                    Chart2.Series.Add("Series1");
                    Chart2.Series["Series1"].YValueMembers = "countDisease";
                    Chart2.Series["Series1"].Name = "Disease";

                    Chart2.DataBind();
                    dropdownlist_District_Of3.Visible = false;
                    btnOk_District_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
    protected void btnOk_City_Of3_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of3.SelectedValue == "Date and Female and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateFemaleCity(dropdownlist_City_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countFemale";
                    Chart2.Series["Series"].Name = "City: " + dropdownlist_City_Of3.SelectedValue;
                    //Chart2.Series.Add("Series1");
                    //Chart2.Series["Series1"].YValueMembers = "countDisease";
                    //Chart2.Series["Series1"].Name = "Disease";

                    Chart2.DataBind();
                    dropdownlist_City_Of3.Visible = false;
                    btnOk_City_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of3.SelectedValue == "Date and Male and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateMaleCity(dropdownlist_City_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countMale";
                    Chart2.Series["Series"].Name = "City: " + dropdownlist_City_Of3.SelectedValue;
                    //Chart2.Series.Add("Series1");
                    //Chart2.Series["Series1"].YValueMembers = "countDisease";
                    //Chart2.Series["Series1"].Name = "Disease";

                    Chart2.DataBind();
                    dropdownlist_City_Of3.Visible = false;
                    btnOk_City_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of3.SelectedValue == "Date and People and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DatePeopleCity(dropdownlist_City_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countPeople";
                    Chart2.Series["Series"].Name = "City: " + dropdownlist_City_Of3.SelectedValue;
                    //Chart2.Series.Add("Series1");
                    //Chart2.Series["Series1"].YValueMembers = "countDisease";
                    //Chart2.Series["Series1"].Name = "Disease";

                    Chart2.DataBind();
                    dropdownlist_City_Of3.Visible = false;
                    btnOk_City_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of3.SelectedValue == "Date and AgeGrp and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateAgeGrpCity(dropdownlist_AgeGrp_Of3.SelectedValue,
                    dropdownlist_City_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countPeople";
                    Chart2.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of3.SelectedValue
                        + "\n City: " + dropdownlist_City_Of3.SelectedValue;
                    //Chart2.Series.Add("Series1");
                    //Chart2.Series["Series1"].YValueMembers = "countDisease";
                    //Chart2.Series["Series1"].Name = "Disease";

                    Chart2.DataBind();
                    dropdownlist_AgeGrp_Of3.Visible = false;
                    btnOk_AgeGrp_Of3.Visible = false;
                    dropdownlist_City_Of3.Visible = false;
                    btnOk_City_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }

        if (dropdownlist_Of3.SelectedValue == "Date and Disease and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseCity(dropdownlist_City_Of3.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";
                    Chart2.DataSource = dt;
                    Chart2.Series.Add("Series");
                    Chart2.Series["Series"].XValueMember = "dates";
                    Chart2.Series["Series"].YValueMembers = "countUnhealthyCity";
                    Chart2.Series["Series"].Name = "City: " + dropdownlist_City_Of3.SelectedValue;
                    Chart2.Series.Add("Series1");
                    Chart2.Series["Series1"].YValueMembers = "countDisease";
                    Chart2.Series["Series1"].Name = "Disease";

                    Chart2.DataBind();
                    dropdownlist_City_Of3.Visible = false;
                    btnOk_City_Of3.Visible = false;
                }
                else
                {
                    ltrMessage.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
    protected void btn_Of4_Ok_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and People and AgeGrp")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_AgeGrp_Of4.Visible = true;
            btnOk_AgeGrp_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Female and AgeGrp")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_AgeGrp_Of4.Visible = true;
            btnOk_AgeGrp_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Male and AgeGrp")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_AgeGrp_Of4.Visible = true;
            btnOk_AgeGrp_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and District and AgeGrp")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_AgeGrp_Of4.Visible = true;
            btnOk_AgeGrp_Of4.Visible = true;
            //dropdownlist_District_Of4.Visible = true;
            //btnOk_District_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and City and AgeGrp")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_AgeGrp_Of4.Visible = true;
            btnOk_AgeGrp_Of4.Visible = true;
            //dropdownlist_City_Of4.Visible = true;
            //btnOk_City_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and People and District")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_District_Of4.Visible = true;
            btnOk_District_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Female and District")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_District_Of4.Visible = true;
            btnOk_District_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Male and District")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_District_Of4.Visible = true;
            btnOk_District_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and People and City")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_City_Of4.Visible = true;
            btnOk_City_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Female and City")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_City_Of4.Visible = true;
            btnOk_City_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Male and City")
        {
            ltrMessage_Of4.Text = "";
            dropdownlist_City_Of4.Visible = true;
            btnOk_City_Of4.Visible = true;
        }
        if (dropdownlist_Of4.SelectedValue == "")
        {
            ltrMessage_Of4.Text = "Select data!";
        }
    }
    protected void btnOk_District_Of4_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Male and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseMaleDistrict(
                    dropdownlist_District_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countMale";
                    Chart3.Series["Series"].Name = "District: " + dropdownlist_District_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    //Chart3.Series.Add("Series2");
                    //Chart3.Series["Series2"].YValueMembers = "countMale";
                    //Chart3.Series["Series2"].Name = "Male";

                    Chart3.DataBind();
                    dropdownlist_District_Of4.Visible = false;
                    btnOk_District_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Female and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseFemaleDistrict(
                    dropdownlist_District_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countFemale";
                    Chart3.Series["Series"].Name = "District: " + dropdownlist_District_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    //Chart3.Series.Add("Series2");
                    //Chart3.Series["Series2"].YValueMembers = "countMale";
                    //Chart3.Series["Series2"].Name = "Male";

                    Chart3.DataBind();
                    dropdownlist_District_Of4.Visible = false;
                    btnOk_District_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and People and District")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseasePeopleDistrict(
                    dropdownlist_District_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countPeople";
                    Chart3.Series["Series"].Name = "District: " + dropdownlist_District_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    //Chart3.Series.Add("Series2");
                    //Chart3.Series["Series2"].YValueMembers = "countMale";
                    //Chart3.Series["Series2"].Name = "Male";

                    Chart3.DataBind();
                    dropdownlist_District_Of4.Visible = false;
                    btnOk_District_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and District and AgeGrp")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseDistrictAgeGrp(
                    dropdownlist_AgeGrp_Of4.SelectedValue,
                    dropdownlist_District_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countPeople";
                    Chart3.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of4.SelectedValue
                        + "\n District: " + dropdownlist_District_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    //Chart3.Series.Add("Series2");
                    //Chart3.Series["Series2"].YValueMembers = "countMale";
                    //Chart3.Series["Series2"].Name = "Male";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                    dropdownlist_District_Of4.Visible = false;
                    btnOk_District_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

        }
    }
    protected void btnOk_City_Of4_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Male and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseMaleCity(
                    dropdownlist_City_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countMale";
                    Chart3.Series["Series"].Name = "City: " + dropdownlist_City_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                    dropdownlist_City_Of4.Visible = false;
                    btnOk_City_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and Female and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseFemaleCity(
                    dropdownlist_City_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countFemale";
                    Chart3.Series["Series"].Name = "City: " + dropdownlist_City_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                    dropdownlist_City_Of4.Visible = false;
                    btnOk_City_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and People and City")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseasePeopleCity(
                    dropdownlist_City_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countPeople";
                    Chart3.Series["Series"].Name = "City: " + dropdownlist_City_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    //Chart3.Series.Add("Series2");
                    //Chart3.Series["Series2"].YValueMembers = "countMale";
                    //Chart3.Series["Series2"].Name = "Male";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                    dropdownlist_City_Of4.Visible = false;
                    btnOk_City_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of4.SelectedValue == "Date and Disease and City and AgeGrp")
        {
            ChartClass cc = new ChartClass();
            try
            {
                DataTable dt = cc.chart_DateDiseaseCityAgeGrp(
                    dropdownlist_AgeGrp_Of4.SelectedValue,
                    dropdownlist_City_Of4.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of4.Text = "";
                    Chart3.DataSource = dt;
                    Chart3.Series.Add("Series");
                    Chart3.Series["Series"].XValueMember = "dates";
                    Chart3.Series["Series"].YValueMembers = "countPeople";
                    Chart3.Series["Series"].Name = "AgeGrp: " + dropdownlist_AgeGrp_Of4.SelectedValue
                        + "\n City: " + dropdownlist_City_Of4.SelectedValue;
                    Chart3.Series.Add("Series1");
                    Chart3.Series["Series1"].YValueMembers = "countDisease";
                    Chart3.Series["Series1"].Name = "Disease";
                    //Chart3.Series.Add("Series2");
                    //Chart3.Series["Series2"].YValueMembers = "countMale";
                    //Chart3.Series["Series2"].Name = "Male";

                    Chart3.DataBind();
                    dropdownlist_AgeGrp_Of4.Visible = false;
                    btnOk_AgeGrp_Of4.Visible = false;
                    dropdownlist_City_Of4.Visible = false;
                    btnOk_City_Of4.Visible = false;
                }
                else
                {
                    ltrMessage.Text = "";
                    ltrMessage_Of4.Text = "No data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

        }
    }
    protected void btn_Of5_Ok_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and People and AgeGrp and District")
        {
            ltrMessage.Text = "";
            ltrMessage_Of4.Text = "";
            ltrMessage_Of5.Text = "";

            dropdownlist_AgeGrp_Of5.Visible = true;
            btnOk_AgeGrp_Of5.Visible = true;
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Female and AgeGrp and District")
        {
            ltrMessage.Text = "";
            ltrMessage_Of4.Text = "";
            ltrMessage_Of5.Text = "";

            dropdownlist_AgeGrp_Of5.Visible = true;
            btnOk_AgeGrp_Of5.Visible = true;
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Male and AgeGrp and District")
        {
            ltrMessage.Text = "";
            ltrMessage_Of4.Text = "";
            ltrMessage_Of5.Text = "";

            dropdownlist_AgeGrp_Of5.Visible = true;
            btnOk_AgeGrp_Of5.Visible = true;
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and People and AgeGrp and City")
        {
            ltrMessage.Text = "";
            ltrMessage_Of4.Text = "";
            ltrMessage_Of5.Text = "";

            dropdownlist_AgeGrp_Of5.Visible = true;
            btnOk_AgeGrp_Of5.Visible = true;
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Female and AgeGrp and City")
        {
            ltrMessage.Text = "";
            ltrMessage_Of4.Text = "";
            ltrMessage_Of5.Text = "";

            dropdownlist_AgeGrp_Of5.Visible = true;
            btnOk_AgeGrp_Of5.Visible = true;
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Male and AgeGrp and City")
        {
            ltrMessage.Text = "";
            ltrMessage_Of4.Text = "";
            ltrMessage_Of5.Text = "";

            dropdownlist_AgeGrp_Of5.Visible = true;
            btnOk_AgeGrp_Of5.Visible = true;
        }
    }
    protected void btnOk_District_Of5_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Male and AgeGrp and District")
        {
            try
            {
                ChartClass cc = new ChartClass();
                DataTable dt = cc.chart_DateDiseaseMaleAgeGrpDistrict(
                    dropdownlist_AgeGrp_Of5.SelectedValue,
                    dropdownlist_District_Of5.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of5.Text = "";
                    Chart4.DataSource = dt;
                    Chart4.Series.Add("Series");
                    Chart4.Series["Series"].XValueMember = "dates";
                    Chart4.Series["Series"].YValueMembers = "countDisease";
                    Chart4.Series["Series"].Name = "Disease";
                    Chart4.Series.Add("Series1");
                    Chart4.Series["Series1"].YValueMembers = "countMale";
                    Chart4.Series["Series1"].Name = "Male";
                    Chart4.Series.Add("Series2");
                    Chart4.Series["Series2"].YValueMembers = "countPeople";
                    Chart4.Series["Series2"].Name = "AgeGrp: "
                        + dropdownlist_AgeGrp_Of5.SelectedValue;

                    Chart4.DataBind();
                    dropdownlist_AgeGrp_Of5.Visible = false;
                    btnOk_AgeGrp_Of5.Visible = false;
                    dropdownlist_District_Of5.Visible = false;
                    btnOk_District_Of5.Visible = false;
                }
                else
                {
                    ltrMessage_Of5.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Female and AgeGrp and District")
        {
            try
            {
                ChartClass cc = new ChartClass();
                DataTable dt = cc.chart_DateDiseaseFemaleAgeGrpDistrict(
                    dropdownlist_AgeGrp_Of5.SelectedValue,
                    dropdownlist_District_Of5.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of5.Text = "";
                    Chart4.DataSource = dt;
                    Chart4.Series.Add("Series");
                    Chart4.Series["Series"].XValueMember = "dates";
                    Chart4.Series["Series"].YValueMembers = "countDisease";
                    Chart4.Series["Series"].Name = "Disease";
                    Chart4.Series.Add("Series1");
                    Chart4.Series["Series1"].YValueMembers = "countFemale";
                    Chart4.Series["Series1"].Name = "Female";
                    Chart4.Series.Add("Series2");
                    Chart4.Series["Series2"].YValueMembers = "countPeople";
                    Chart4.Series["Series2"].Name = "AgeGrp: "
                        + dropdownlist_AgeGrp_Of5.SelectedValue;

                    Chart4.DataBind();
                    dropdownlist_AgeGrp_Of5.Visible = false;
                    btnOk_AgeGrp_Of5.Visible = false;
                    dropdownlist_District_Of5.Visible = false;
                    btnOk_District_Of5.Visible = false;
                }
                else
                {
                    ltrMessage_Of5.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and People and AgeGrp and District")
        {
            try
            {
                ChartClass cc = new ChartClass();
                DataTable dt = cc.chart_DateDiseasePeopleAgeGrpDistrict(
                    dropdownlist_AgeGrp_Of5.SelectedValue,
                    dropdownlist_District_Of5.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of5.Text = "";
                    Chart4.DataSource = dt;
                    Chart4.Series.Add("Series");
                    Chart4.Series["Series"].XValueMember = "dates";
                    Chart4.Series["Series"].YValueMembers = "countDisease";
                    Chart4.Series["Series"].Name = "Disease";
                    Chart4.Series.Add("Series1");
                    Chart4.Series["Series1"].YValueMembers = "countPatient";
                    Chart4.Series["Series1"].Name = "Patient";
                    Chart4.Series.Add("Series2");
                    Chart4.Series["Series2"].YValueMembers = "countPeople";
                    Chart4.Series["Series2"].Name = "AgeGrp: "
                        + dropdownlist_AgeGrp_Of5.SelectedValue;

                    Chart4.DataBind();
                    dropdownlist_AgeGrp_Of5.Visible = false;
                    btnOk_AgeGrp_Of5.Visible = false;
                    dropdownlist_District_Of5.Visible = false;
                    btnOk_District_Of5.Visible = false;
                }
                else
                {
                    ltrMessage_Of5.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
    protected void btnOk_City_Of5_Click(object sender, EventArgs e)
    {
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Male and AgeGrp and City")
        {
            try
            {
                ChartClass cc = new ChartClass();
                DataTable dt = cc.chart_DateDiseaseMaleAgeGrpCity(
                    dropdownlist_AgeGrp_Of5.SelectedValue,
                    dropdownlist_City_Of5.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of5.Text = "";
                    Chart4.DataSource = dt;
                    Chart4.Series.Add("Series");
                    Chart4.Series["Series"].XValueMember = "dates";
                    Chart4.Series["Series"].YValueMembers = "countDisease";
                    Chart4.Series["Series"].Name = "Disease";
                    Chart4.Series.Add("Series1");
                    Chart4.Series["Series1"].YValueMembers = "countMale";
                    Chart4.Series["Series1"].Name = "Male";
                    Chart4.Series.Add("Series2");
                    Chart4.Series["Series2"].YValueMembers = "countPeople";
                    Chart4.Series["Series2"].Name = "AgeGrp: "
                        + dropdownlist_AgeGrp_Of5.SelectedValue;

                    Chart4.DataBind();
                    dropdownlist_AgeGrp_Of5.Visible = false;
                    btnOk_AgeGrp_Of5.Visible = false;
                    dropdownlist_City_Of5.Visible = false;
                    btnOk_City_Of5.Visible = false;
                }
                else
                {
                    ltrMessage_Of5.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and Female and AgeGrp and City")
        {
            try
            {
                ChartClass cc = new ChartClass();
                DataTable dt = cc.chart_DateDiseaseFemaleAgeGrpCity(
                    dropdownlist_AgeGrp_Of5.SelectedValue,
                    dropdownlist_City_Of5.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of5.Text = "";
                    Chart4.DataSource = dt;
                    Chart4.Series.Add("Series");
                    Chart4.Series["Series"].XValueMember = "dates";
                    Chart4.Series["Series"].YValueMembers = "countDisease";
                    Chart4.Series["Series"].Name = "Disease";
                    Chart4.Series.Add("Series1");
                    Chart4.Series["Series1"].YValueMembers = "countFemale";
                    Chart4.Series["Series1"].Name = "Female";
                    Chart4.Series.Add("Series2");
                    Chart4.Series["Series2"].YValueMembers = "countPeople";
                    Chart4.Series["Series2"].Name = "AgeGrp: "
                        + dropdownlist_AgeGrp_Of5.SelectedValue;

                    Chart4.DataBind();
                    dropdownlist_AgeGrp_Of5.Visible = false;
                    btnOk_AgeGrp_Of5.Visible = false;
                    dropdownlist_City_Of5.Visible = false;
                    btnOk_City_Of5.Visible = false;
                }
                else
                {
                    ltrMessage_Of5.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
        if (dropdownlist_Of5.SelectedValue == "Date and Disease and People and AgeGrp and City")
        {
            try
            {
                ChartClass cc = new ChartClass();
                DataTable dt = cc.chart_DateDiseasePeopleAgeGrpCity(
                    dropdownlist_AgeGrp_Of5.SelectedValue,
                    dropdownlist_City_Of5.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage_Of5.Text = "";
                    Chart4.DataSource = dt;
                    Chart4.Series.Add("Series");
                    Chart4.Series["Series"].XValueMember = "dates";
                    Chart4.Series["Series"].YValueMembers = "countDisease";
                    Chart4.Series["Series"].Name = "Disease";
                    Chart4.Series.Add("Series1");
                    Chart4.Series["Series1"].YValueMembers = "countPatient";
                    Chart4.Series["Series1"].Name = "Patient";
                    Chart4.Series.Add("Series2");
                    Chart4.Series["Series2"].YValueMembers = "countPeople";
                    Chart4.Series["Series2"].Name = "AgeGrp: "
                        + dropdownlist_AgeGrp_Of5.SelectedValue;

                    Chart4.DataBind();
                    dropdownlist_AgeGrp_Of5.Visible = false;
                    btnOk_AgeGrp_Of5.Visible = false;
                    dropdownlist_City_Of5.Visible = false;
                    btnOk_City_Of5.Visible = false;
                }
                else
                {
                    ltrMessage_Of5.Text = " No Data!";
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
}
