using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class LoginNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtboxUsername.Focus();
    }
    protected void btnLogIn_Click1(object sender, EventArgs e)
    {
        try
        {
            UserClass uc = new UserClass();
            EntryUserClass euc = new EntryUserClass();

            DataTable dt = uc.Checklogin(txtboxUsername.Text, txtboxPasswd.Text);
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";
                Session["username"] = txtboxUsername.Text;
                Session["userPasswd"] = txtboxPasswd.Text;
                String userType = dt.Rows[0]["userType"].ToString();
                Session["userType"] = dt.Rows[0]["userType"].ToString();

                Session["userId"] = dt.Rows[0]["userId"].ToString();
                String userIdString = dt.Rows[0]["userId"].ToString();
                int userId = Convert.ToInt32(userIdString);

                if (userType == "Patient") 
                {
                    Response.Redirect("Home_Patient.aspx");
                }
                else if (userType == "Entry")
                {
                    /*Check if the Entry User is Active or not*/
                    DataTable dtEntryUser = euc.SelectAllEntryUserFromUserId(userId);
                    if (dtEntryUser.Rows.Count > 0)
                    {
                        String entryUserInactiveOrActive = dtEntryUser.Rows[0]["entryUserInactiveOrActive"].ToString();

                        if (entryUserInactiveOrActive == "Active")
                        {
                            Response.Redirect("Home_EntryUser.aspx");
                        }
                        else 
                        {
                            ltrMessage.Text = "The User is Inactive!";
                        }
                    }
                }
                else if (userType == "Other")
                {
                    Response.Redirect("Home_OtherUser.aspx");
                }
            }
            else
            {
                ltrMessage.Text = "Invalid Username or Password!";
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
}