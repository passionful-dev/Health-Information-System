using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Patient_CheckupWithHistory_EntryUserMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*Data loading for the Labels*/
        try
        {
            PatientClass pc = new PatientClass();

            String selectedRow_Username = Session["selectedRow_Username"].ToString();
            DataTable dt = pc.patientDetails_ForDoctor(selectedRow_Username);
            if (dt.Rows.Count > 0)
            {
                Session["selected_Username"] = dt.Rows[0]["Username"].ToString();
                Session["selected_Name"] = dt.Rows[0]["Name"].ToString();
                Session["selected_Dob"] = dt.Rows[0]["Dob"].ToString();
                Session["selected_AgeGrp"] = dt.Rows[0]["AgeGrp"].ToString();
                Session["selected_Sex"] = dt.Rows[0]["Sex"].ToString();

                ltrMessage1.Text = "";
                lbl_Username.Text = Session["selected_Username"].ToString();
                lbl_Name.Text = Session["selected_Name"].ToString();
                lbl_Dob.Text = Session["selected_Dob"].ToString();
                lbl_AgeGrp.Text = Session["selected_AgeGrp"].ToString();
                lbl_Gender.Text = Session["selected_Sex"].ToString();
            }
            else
            {
                ltrMessage1.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage1.Text = ex.Message;
        }

        /*Data loading for the Gridview1*/
        try
        {
            PatientClass pc = new PatientClass();

            String selectedRow_Username = Session["selectedRow_Username"].ToString();
            DataTable dt = pc.checkUpHistory(selectedRow_Username);
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                ltrMessage.Text = "No any checkup history before!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btn_Ok_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();
            LogPatientClass lpc = new LogPatientClass();
            DiseaseClass dc = new DiseaseClass();
            EntryUserClass euc = new EntryUserClass();

            /*Current date and time calculated*/
            DateTime currentDateNTime = DateTime.Now;
            String checkedPatDate = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

            int checkedPatBy = Convert.ToInt32(Session["userId"]);

            /*selectPatientIdFromPatientUsername*/
            String selected_PatUsername = Session["selectedRow_Username"].ToString();
            DataTable dt = pc.selectPatientIdFromPatientUsername(selected_PatUsername);
            if (dt.Rows.Count > 0)
            {
                int selectedRow_patientId = Convert.ToInt32(dt.Rows[0]["patientId"].ToString());

                /*selectEntryUserHospitalFrom_EntryUserUsername*/
                String entryUser_username = Session["username"].ToString();
                DataTable dt2 = euc.selectEntryUserHospitalFrom_EntryUserUsername(entryUser_username);
                if (dt2.Rows.Count > 0)
                {
                    String entryUserHospital = dt2.Rows[0]["entryUserHospital"].ToString();

                    ltrMessage1.Text = "";
                    /*insertIn_CheckedPat*/
                    pc.insertIn_CheckedPat(selectedRow_patientId, checkedPatDate, txtbox_DiseaseName.Text,
                        txtbox_Remarks.Text, entryUserHospital, checkedPatBy);
                }
                else { ltrMessage1.Text = "No data found!"; }
            }
            else
            {
                ltrMessage1.Text = "No data found!";
            }

            /*get_checkedPatIdFrom_checkedPatDateNcheckedPatBy*/
            DataTable dt1 = pc.get_checkedPatIdFrom_checkedPatDateNcheckedPatBy(checkedPatDate, checkedPatBy);
            if (dt1.Rows.Count > 0)
            {
                int checkedPatId = Convert.ToInt32(dt1.Rows[0]["checkedPatId"].ToString());
                //Session["checkedPatId"] = dt.Rows[0]["checkedPatId"].ToString();
                /*insertIn_Log_CheckedPatWholeField*/
                lpc.insertIn_Log_CheckedPatWholeField(checkedPatDate, checkedPatId);
            }
            else
            {
                ltrMessage1.Text = "No data found!";
            }
            /*insertIn_Disease*/
            dc.insertIn_Disease(txtbox_DiseaseName.Text, txtbox_Remarks.Text, checkedPatBy,
                checkedPatDate);

            Response.Redirect("Patient_CheckupWithHistory_EntryUserMaster.aspx");
            //txtbox_DiseaseName.Text = "";
            //txtbox_Remarks.Text = "";

        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
}