using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["username"] != null)
            {
                lblUser.Text = Session["username"].ToString() + "!";
            }
            else
            {
                Response.Redirect("LoginNew.aspx");

            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("LoginNew.aspx");
    }
}
