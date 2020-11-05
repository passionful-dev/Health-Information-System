using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Health_EntryUserMaster : System.Web.UI.Page
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
            //DiseaseClass dc = new DiseaseClass();
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser();
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("A");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("B");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("C");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("D");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("E");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("F");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("G");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("H");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("I");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("J");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("K");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("L");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("M");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("N");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("O");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("P");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("Q");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("R");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("S");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("T");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("U");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("V");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("W");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("X");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("Y");
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
            DiseaseClass dc = new DiseaseClass();

            DataTable dt = dc.healthForEntryUser_RespectiveLetter("Z");
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
    }


}