using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class Inform_EntryUserMaster : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            dropdownlistUsername.Focus();
            ltrMessage.Text = "";
            ltrMessageGreen.Text = "";


            UserClass uc = new UserClass();

            try
            {
                DataTable dt = uc.SelectAllUsersFromUsername(Session["username"].ToString());
                if (dt.Rows.Count > 0)
                {
                    String feedbackCheckUserType = dt.Rows[0]["userType"].ToString();

                    DataTable dt1 = uc.selectAllUsersFromUserType_RespectiveUsers(feedbackCheckUserType);
                    if (dt1.Rows.Count > 0)
                    {
                        dropdownlistUsername.DataSource = dt1;
                        dropdownlistUsername.DataValueField = "username";
                        dropdownlistUsername.DataTextField = "username";
                        dropdownlistUsername.DataBind();
                        dropdownlistUsername.Items.Insert(0, new ListItem("", ""));
                    }
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {

        ltrMessage.Text = "";
        ltrMessageGreen.Text = "";

        FeedbackClass fc = new FeedbackClass();
        LogFeedbackClass lfc = new LogFeedbackClass();
        UserClass uc = new UserClass();

        int feedbackByUserId, feedbackToUserId;
        String feedbackSubject, feedbackDescription;
        String feedbackCheckUserType = "";
        String feedbackToUsername;

        String feedbackDate;

        /*Current date and time calculated*/
        DateTime currentDateNTime = DateTime.Now;
        feedbackDate = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

        feedbackSubject = txtboxSubject.Text;
        feedbackDescription = txtboxMessage.Text;
        feedbackToUsername = dropdownlistUsername.SelectedValue;
        dropdownlistUsername.Items.Insert(0, feedbackToUsername);

        /*Getting feedbackBy userId from Session*/
        String userIdString = Session["userId"].ToString();
        int userId = Convert.ToInt32(userIdString);
        feedbackByUserId = userId;

        try
        {
            /*Getting feedbackToUserId from feedbackToUsername*/
            DataTable dt = uc.SelectAllUsersFromUsername(feedbackToUsername);
            if (dt.Rows.Count > 0)
            {
                feedbackCheckUserType = dt.Rows[0]["userType"].ToString();

                if (feedbackCheckUserType == "Patient")
                {
                    Session["feedbackToUserId"] = dt.Rows[0]["userId"].ToString();
                    String feedbackToUserIdString = dt.Rows[0]["userId"].ToString();
                    feedbackToUserId = Convert.ToInt32(feedbackToUserIdString);

                    /*Inserting and putting the values in Log*/
                    fc.InsertFeedback(feedbackByUserId, feedbackToUserId, feedbackSubject, feedbackDescription);
                    lfc.insertOn_Log_FeedbackWholeField_WithInsertOperation(feedbackDate);

                    /*Refreshing*/
                    Response.Redirect("Inform_EntryUserMaster.aspx");
                    dropdownlistUsername.Focus();
                }
                else
                {
                    ltrMessage.Text = "Invalid Username!";
                }
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
}