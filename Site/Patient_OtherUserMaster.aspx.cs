using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Patient_OtherUserMaster : System.Web.UI.Page
{
    //protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    GridView1.PageIndex = e.NewPageIndex;
    //    //GetPageData(e.NewPageIndex, 10);
    //}

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Set the "VirtualItemCount" property of the GridView with the total number of records
            //in the database. And bind the datasource with PageSize 10 and PageIndex value 
            //0 as this is first page to show.
            //GridView1.VirtualItemCount = GetTotalCount();
            //GetPageData(0, 10);
            
            loadData();

        }
    }

    /*Making this function to work independently for Loading Data*/
    protected void loadData()
    {
        try
        {
            PatientClass hc = new PatientClass();

            DataTable dt = hc.SelectForViewPatientRecords();
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_A_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("A");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_B_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("B");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_C_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("C");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_D_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("D");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_E_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("E");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_F_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("F");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_G_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("G");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_H_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("H");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_I_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("I");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_J_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("J");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_K_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("K");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_L_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("L");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_M_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("M");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_N_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("N");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_O_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("O");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_P_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("P");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_Q_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("Q");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_R_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("R");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_S_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("S");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_T_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("T");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_U_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("U");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_V_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("V");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_W_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("W");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_X_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("X");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_Y_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("Y");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtn_Z_Click(object sender, EventArgs e)
    {
        try
        {
            PatientClass pc = new PatientClass();

            DataTable dt = pc.SelectForViewPatientRecords_SpecificLetter("Z");
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
                ltrMessage.Text = "No data found!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String selectedRow_Username = GridView1.SelectedRow.Cells[3].Text;
        Session["selectedRow_Username"] = selectedRow_Username;


        //ltrMessage.Text = "Selected: " + selectedRow_Username + " "
        //+ Session["selectedRow_Username"];
        ltrDelMsg.Visible = true;
        ltrDelMsg.Text = "Do you want to delete the record of " + " '"
            + Session["selectedRow_Username"].ToString() + "'" + "?";
        btnOk.Visible = true;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        try
        {
            int selected_userId;
            UserClass uc = new UserClass();
            PatientClass pc = new PatientClass();
            UserPatientClass upc = new UserPatientClass();
            LogUserClass luc = new LogUserClass();
            LogPatientClass lpc = new LogPatientClass();

            /*Delete Users' and Patient's record
            Insert values on Log_UsersWholeFieldWithName and Log_PatientWholeFieldWithName table*/
            /*Getting userId from username from Users table*/
            DataTable dt = uc.SelectAllUsersFromUsername(Session["selectedRow_Username"].ToString());
            if (dt.Rows.Count > 0)
            {
                Session["selected_userId"] = dt.Rows[0]["userId"].ToString();
                selected_userId = Convert.ToInt32(Session["selected_userId"]);

                /*Getting patientRecord from userId from Patient table*/
                DataTable dtPatient = pc.SelectAllPatientFromUserId(selected_userId);
                if (dtPatient.Rows.Count > 0)
                {
                    Session["selected_patientId"] = dtPatient.Rows[0]["patientId"].ToString();
                    int selected_patientId = Convert.ToInt32(Session["selected_patientId"]);

                    String selected_patientFirstName = dtPatient.Rows[0]["patientFirstName"].ToString();
                    String selected_patientMiddleName = dtPatient.Rows[0]["patientMiddleName"].ToString();
                    String selected_patientLastName = dtPatient.Rows[0]["patientLastName"].ToString();
                    Session["selected_patientName"] = selected_patientFirstName + " "
                        + selected_patientMiddleName + " " + selected_patientLastName;

                    luc.insertOn_Log_UsersWholeFieldWithName_WithDeleteOperation(selected_userId, Session["selectedRow_Username"].ToString());
                    lpc.insertOn_Log_PatientWholeFieldWithName_WithDeleteOperation(selected_userId, selected_patientId, Session["selected_patientName"].ToString());
                    uc.delete_UsersFrom_userId(selected_userId);
                    pc.delete_PatientFrom_userId(selected_userId);
                }
                //else { ltrMessage.Text = "Error 2nd if"; }
            }
            //else { ltrMessage.Text += "Error 1st if"; }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
        finally
        {
            ltrDelMsg.Visible = false;
            btnOk.Visible = false;
            loadData();
        }
    }
}