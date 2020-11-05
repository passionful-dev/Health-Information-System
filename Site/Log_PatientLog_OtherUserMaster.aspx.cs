using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Log_PatientLog_OtherUserMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*Data loading for the DataList1*/
        try
        {
            PatientClass pc = new PatientClass();
            UserClass uc = new UserClass();

            String selectedRow_Username = Session["selectedRow_Username"].ToString();
            DataTable dt1 = uc.GetUserIdFromUsername(selectedRow_Username);
            if (dt1.Rows.Count > 0)
            {
                Session["selectedRow_UserId"] = dt1.Rows[0]["userId"].ToString();
                int selectedRow_UserId = Convert.ToInt32(Session["selectedRow_UserId"].ToString());
                DataTable dt = pc.logOfPatient(selectedRow_UserId);
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
                    ltrMessage.Text = "No any data!";
                }
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
}