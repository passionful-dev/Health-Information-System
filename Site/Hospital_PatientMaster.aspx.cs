using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Hospital_PatientMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadData();
        }
    }

    /*Making this function to work independently for Loading Data*/
    protected void loadData()
    {
        try
        {
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords();
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                GridView1.DataSource = dt;
                GridView1.DataBind();
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("A");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("B");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("C");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("D");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("E");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("F");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("G");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("H");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("I");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("J");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("K");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("L");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("M");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("N");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("O");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("P");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("Q");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("R");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("S");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("T");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("U");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("V");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("W");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("X");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("Y");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectForViewHospitalRecords_SpecificLetter("Z");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                //dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //int columncount = GridView1.Rows[0].Cells.Count;
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
        String selectedRow_HospitalName = GridView1.SelectedRow.Cells[2].Text;
        Session["selectedRow_HospitalName"] = selectedRow_HospitalName;

        String selectedRow_HospitalType = GridView1.SelectedRow.Cells[3].Text;
        Session["selectedRow_HospitalType"] = selectedRow_HospitalType;

        String selectedRow_HospitalAddress = GridView1.SelectedRow.Cells[4].Text;

        try
        {
            HospitalClass hc = new HospitalClass();

            DataTable dt = hc.SelectAddressFromHospitalFullName(selectedRow_HospitalName);
            if (dt.Rows.Count > 0)
            {
                Session["selectedRow_HospitalHouseAddress"] = dt.Rows[0]["hospitalHouseAdd"].ToString();
                Session["selectedRow_HospitalDistrict"] = dt.Rows[0]["hospitalDistrict"].ToString();
                Session["selectedRow_HospitalCity"] = dt.Rows[0]["hospitalCity"].ToString();

            }
            //else
            //{ 
            //    Session["selectedRow_HospitalHouseAddress"] = "";
            //    Session["selectedRow_HospitalDistrict"] = "";
            //    Session["selectedRow_HospitalCity"] = "";
            //}

        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }

        String selectedRow_HospitalDescription = GridView1.SelectedRow.Cells[5].Text;
        Session["selectedRow_HospitalDescription"] = selectedRow_HospitalDescription;

        //ltrMessage.Text = "Selected: " + selectedRow_HospitalName + " "
        //+ Session["selectedRow_HospitalHouseAddress"];

        Response.Redirect("Hospital_Edit_OtherUserMaster.aspx");
    }

}