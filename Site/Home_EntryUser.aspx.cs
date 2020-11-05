using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Home_EntryUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*Data loading for the DataList1*/
        try
        {
            EntryUserClass euc = new EntryUserClass();
            UserClass uc = new UserClass();

            int userId = Convert.ToInt32(Session["userId"].ToString());
            DataTable dt = euc.homeEntryUserFrom_userId(userId);
            if (dt.Rows.Count > 0)
            {
                ltrMessage.Text = "";

                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
            else
            {
                DataList1.DataSource = dt;
                DataList1.DataBind();
                ltrMessage.Text = "No any data before!";
            }
        }

        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
}