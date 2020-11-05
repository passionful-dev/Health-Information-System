using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnForgotPassword_Enter_Click(object sender, EventArgs e)
    {
        try
        {
            //txtboxEmail_ForgotPassword.Text = "";
                
            UserClass fpc = new UserClass();
            DataTable dt = fpc.CheckEmail(txtboxEmail_ForgotPassword.Text);
            if (dt.Rows.Count > 0)
            {
                Session["userEmail"] = txtboxEmail_ForgotPassword.Text;
                //Session["userType"] = dt.Rows[0]["userType"].ToString();
                //String userType = dt.Rows[0]["userType"].ToString();
                ltrMessageGreen.Text = "Your password has been send to your email address!";
                ltrMessageRed.Text = "";
            }
            else {
                ltrMessageRed.Text = "Invalid Email!";
            }
        }
        catch (Exception ex)
        {
            ltrMessageGreen.Text = ex.Message;
        }
    }
}