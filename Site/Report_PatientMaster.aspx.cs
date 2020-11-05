using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Microsoft.Reporting.WebForms;

public partial class Report_PatientMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                GlobalConnection gc = new GlobalConnection();
                PatientClass pc = new PatientClass();

                String username = Session["username"].ToString();
                DataTable dt = pc.checkUpHistory(username);
                if (dt.Rows.Count > 0)
                {
                    ltrMessage.Text = "";

                    ReportViewer1.Reset();

                    // OR Set Report Path  
                    ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath("Report_PatientMaster.rdlc");

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
                    ltrMessage.Text = "No data found!";
                    ReportViewer1.Reset();
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.DataBind();
                    ReportViewer1.LocalReport.Refresh();
                }

            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
}