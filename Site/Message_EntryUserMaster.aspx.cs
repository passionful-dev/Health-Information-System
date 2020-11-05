using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Message_EntryUserMaster : System.Web.UI.Page
{

    /*Make messageModes. 
     * By default:- For Other: mode=2. For Entry, Patient: messageMode=1
     * messageMode=1 for Inbox; //messageMode=2 for Send*/
    protected static int messageMode;

    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.Visible = false;
        if (!Page.IsPostBack)
        {
            /*Make (Inbox or Sent) or (InboxReport or SentReport) lnkbtns visible wrt userType */
            String loggedUserType = Session["userType"].ToString();
            if (loggedUserType == "Other")
            {
                lnkbtn_Inbox.Visible = false;
                lnkbtn_InboxReport.Visible = false;

                /*Make messageModes. 
                * By default:- For Other: mode=2. For Entry, Patient: messageMode=1
                * messageMode=1 for Inbox; //messageMode=2 for Send*/
                messageMode = 2;
            }
            if (loggedUserType == "Entry")
            {
                /*Make messageModes. 
                * By default:- For Other: mode=2. For Entry, Patient: messageMode=1
                * messageMode=1 for Inbox; //messageMode=2 for Send*/
                messageMode = 1;
            }
            if (loggedUserType == "Patient")
            {
                lnkbtn_Sent.Visible = false;
                lnkbtn_SentReport.Visible = false;
                /*Make messageModes. 
                 * By default:- For Other: mode=2. For Entry, Patient: messageMode=1
                * messageMode=1 for Inbox; //messageMode=2 for Send*/
                messageMode = 1;
            }

            loadDataAccordingly();
        }
    }
    /*Making this function to work independently for Loading Data*/
    protected void loadDataAccordingly()
    {
        /*Make page as what to see and what not to see at what messageMode*/
        GridView1.Visible = true;

        /*To send things to show*/
        lbl_ToLabel.Visible = false;
        lbl_ToUsername.Visible = false;
        lbl_Subject.Visible = false;
        txtbox_Subject.Visible = false;
        lbl_Message.Visible = false;
        txtbox_Message.Visible = false;
        btnSend.Visible = false;

        /*A-Z link not to show*/
        lnkbtn_A.Visible = true;
        lnkbtn_B.Visible = true;
        lnkbtn_C.Visible = true;
        lnkbtn_D.Visible = true;
        lnkbtn_E.Visible = true;
        lnkbtn_F.Visible = true;
        lnkbtn_G.Visible = true;
        lnkbtn_H.Visible = true;
        lnkbtn_I.Visible = true;
        lnkbtn_J.Visible = true;
        lnkbtn_K.Visible = true;
        lnkbtn_L.Visible = true;
        lnkbtn_M.Visible = true;
        lnkbtn_N.Visible = true;
        lnkbtn_O.Visible = true;
        lnkbtn_P.Visible = true;
        lnkbtn_Q.Visible = true;
        lnkbtn_R.Visible = true;
        lnkbtn_S.Visible = true;
        lnkbtn_T.Visible = true;
        lnkbtn_U.Visible = true;
        lnkbtn_V.Visible = true;
        lnkbtn_W.Visible = true;
        lnkbtn_X.Visible = true;
        lnkbtn_Y.Visible = true;
        lnkbtn_Z.Visible = true;


        if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
        {
            lnkbtn_InboxReport.Visible = true;
            loadInboxData();

            lnkbtn_SentReport.Visible = false;
            //loadSentData();

        }
        else if (messageMode == 2)
        {
            lnkbtn_InboxReport.Visible = false;
            //loadInboxData();

            lnkbtn_SentReport.Visible = true;
            loadSentData();
        }
    }
    /*Making this function to work independently for Loading Data*/
    protected void loadSentData()
    {
        try
        {
            FeedbackClass fc = new FeedbackClass();
            int feedbackByUserId = Convert.ToInt32(Session["userId"]);

            DataTable dt = fc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId(
                feedbackByUserId);

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
    /*Making this function to work independently for Loading Data*/
    protected void loadInboxData()
    {
        try
        {
            FeedbackClass fc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);
            DataTable dt = fc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId(
                feedbackToUserId);

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

    protected void lnkbtn_NewMessage_Click(object sender, EventArgs e)
    {
        /*Make the dropdownlist n btn visible n Gridview invisible*/
        dropdownlist_SendToUsernameList.Visible = true;
        btn_Ok_SendToUsernameList.Visible = true;
        lnkbtn_SentReport.Visible = false;
        lnkbtn_InboxReport.Visible = false;

        /*Putting respective usernames in dropdownlist*/
        //if (!Page.IsPostBack)
        {
            dropdownlist_SendToUsernameList.Focus();
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
                        ltrMessage.Text = "";
                        dropdownlist_SendToUsernameList.DataSource = dt1;
                        dropdownlist_SendToUsernameList.DataValueField = "username";
                        dropdownlist_SendToUsernameList.DataTextField = "username";
                        dropdownlist_SendToUsernameList.DataBind();
                        dropdownlist_SendToUsernameList.Items.Insert(0, new ListItem("", ""));
                    }
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
    protected void btn_Ok_SendToUsernameList_Click(object sender, EventArgs e)
    {
        if (dropdownlist_SendToUsernameList.SelectedValue != "")
        {
            /*A-Z link not to show*/
            lnkbtn_A.Visible = false;
            lnkbtn_B.Visible = false;
            lnkbtn_C.Visible = false;
            lnkbtn_D.Visible = false;
            lnkbtn_E.Visible = false;
            lnkbtn_F.Visible = false;
            lnkbtn_G.Visible = false;
            lnkbtn_H.Visible = false;
            lnkbtn_I.Visible = false;
            lnkbtn_J.Visible = false;
            lnkbtn_K.Visible = false;
            lnkbtn_L.Visible = false;
            lnkbtn_M.Visible = false;
            lnkbtn_N.Visible = false;
            lnkbtn_O.Visible = false;
            lnkbtn_P.Visible = false;
            lnkbtn_Q.Visible = false;
            lnkbtn_R.Visible = false;
            lnkbtn_S.Visible = false;
            lnkbtn_T.Visible = false;
            lnkbtn_U.Visible = false;
            lnkbtn_V.Visible = false;
            lnkbtn_W.Visible = false;
            lnkbtn_X.Visible = false;
            lnkbtn_Y.Visible = false;
            lnkbtn_Z.Visible = false;

            /*Make the dropdownlist n btn invisible n Gridview visible*/
            dropdownlist_SendToUsernameList.Visible = false;
            btn_Ok_SendToUsernameList.Visible = false;
            lbl_ToLabel.Visible = true;
            lbl_ToUsername.Visible = true;
            lbl_Subject.Visible = true;
            txtbox_Subject.Visible = true;
            lbl_Message.Visible = true;
            txtbox_Message.Visible = true;
            btnSend.Visible = true;
            GridView1.Visible = true;

            lbl_ToUsername.Text = dropdownlist_SendToUsernameList.Text;
            loadSentData_OfOnlythatUser();
        }
    }
    protected void loadSentData_OfOnlythatUser()
    {
        try
        {
            FeedbackClass fc = new FeedbackClass();
            int feedbackByUserId = Convert.ToInt32(Session["userId"]);

            DataTable dt = fc.selectAllSentMessage_OfThatSelectedUser(
                dropdownlist_SendToUsernameList.SelectedValue, feedbackByUserId);

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
                ltrMessage.Text = "";
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "A");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "A");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "B");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "B");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "C");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "C");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "D");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "D");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "E");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "E");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "F");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "F");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "G");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "G");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "H");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "H");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "I");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "I");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "J");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "J");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "K");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "K");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "L");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "L");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "M");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "M");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "N");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "N");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "O");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "O");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "P");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "P");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "Q");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "Q");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "R");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "R");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "S");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "S");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "T");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "T");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "U");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "U");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "V");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "V");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "W");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "W");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "X");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "X");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "Y");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "Y");
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
            FeedbackClass pc = new FeedbackClass();
            int feedbackToUserId = Convert.ToInt32(Session["userId"]);

            /*Load data in DataGrid*/
            if (messageMode == 1) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                DataTable dt = pc.selectAllRespectiveFeedbackForInboxFromfeedbackToUserId_RespectiveLetters(
                    feedbackToUserId, "Z");
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
            else if (messageMode == 2) //messageMode=1 for Inbox; //messageMode=2 for Send
            {
                int feedbackByUserId = Convert.ToInt32(Session["userId"]);
                DataTable dt = pc.selectAllRespectiveFeedbackForSentFromfeedbackByUserId_RespectiveLetters
                    (feedbackByUserId, "Z");
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

        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }

    protected void lnkbtn_Inbox_Click(object sender, EventArgs e)
    {
        /*Make messageModes. 
         * messageMode=1 for Inbox; //messageMode=2 for Send*/
        messageMode = 1;
        loadDataAccordingly();

    }
    protected void lnkbtn_Sent_Click(object sender, EventArgs e)
    {
        /*Make messageModes. 
         * messageMode=1 for Inbox; //messageMode=2 for Send*/
        messageMode = 2;
        loadDataAccordingly();

    }
    protected void lnkbtn_InboxReport_Click(object sender, EventArgs e)
    {
        /*Make messageModes. 
         * messageMode=1 for Inbox; //messageMode=2 for Send*/
        messageMode = 1;

    }
    protected void lnkbtn_SentReport_Click(object sender, EventArgs e)
    {
        /*Make messageModes. 
         * messageMode=1 for Inbox; //messageMode=2 for Send*/
        messageMode = 2;

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtbox_Message.Text != "")
        {
            ltrMessage.Text = "";

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

            feedbackSubject = txtbox_Subject.Text;
            feedbackDescription = txtbox_Message.Text;
            feedbackToUsername = dropdownlist_SendToUsernameList.SelectedValue;
            dropdownlist_SendToUsernameList.Items.Insert(0, feedbackToUsername);

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
                        txtbox_Subject.Text = "";
                        txtbox_Message.Text = "";
                        /*Make messageModes. 
                        * messageMode=1 for Inbox; //messageMode=2 for Send*/
                        messageMode = 2;
                        loadDataAccordingly();
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
}