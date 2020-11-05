using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Microsoft.Reporting.WebForms;

public partial class EntryUserFrom_Report_OtherUserMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                GlobalConnection gc = new GlobalConnection();
                EntryUserClass euc = new EntryUserClass();

                DataTable dt = euc.SelectForViewEntryUserRecords_ForReport();
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";

                    ReportViewer1.Reset();

                    // OR Set Report Path  
                    ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                    // Clear the Data Source   
                    ReportViewer1.LocalReport.DataSources.Clear();

                    // Set a DataSource to the report  
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    ReportViewer1.DataBind();

                    // Refresh and Display Report  
                    ReportViewer1.LocalReport.Refresh();
                }
                else
                {
                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.DataBind();
                    ReportViewer1.LocalReport.Refresh();
                    ltrMessage.Text = "No data found!";
                }

            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
    protected void lnkbtn_A_Click(object sender, EventArgs e)
    {
        try
        {
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("A");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("B");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("C");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("D");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("E");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("F");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("G");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("H");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("I");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("J");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("K");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("L");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("M");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("N");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("O");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("P");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("Q");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("R");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("S");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("T");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("U");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("V");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("W");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("X");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("Y");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
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
            GlobalConnection gc = new GlobalConnection();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = euc.SelectForViewEntryUserRecords_SpecificLetter_ForReport("Z");
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                ReportViewer1.Reset();

                // OR Set Report Path  
                ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_EntryUser_OtherUserMaster.rdlc");

                // Clear the Data Source   
                ReportViewer1.LocalReport.DataSources.Clear();

                // Set a DataSource to the report  
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                ReportViewer1.DataBind();

                // Refresh and Display Report  
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            
                ltrMessage.Text = "No data found!";
            }

        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
}