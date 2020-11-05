using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Log_EntryUser_OtherUserMaster : System.Web.UI.Page
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords();
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("A");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("B");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("C");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("D");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("E");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("F");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("G");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("H");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("I");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("J");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("K");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("L");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("M");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("N");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("O");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("P");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("Q");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("R");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("S");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("T");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("U");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("V");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("W");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("X");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("Y");
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
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter("Z");
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

        Response.Redirect("Log_EntryUserLog_OtherUserMaster.aspx");

    }


}