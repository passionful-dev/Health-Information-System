using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            UserClass uc = new UserClass();
            DataTable dt = uc.Checklogin(txtUid.Text, txtPwd.Text);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                ltrMessage.Text = "Invalid User ID or Password!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }

    }
}