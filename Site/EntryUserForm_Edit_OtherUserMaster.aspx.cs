using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class EntryUserForm_Edit_OtherUserMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Load();
    }
    protected void Load()
    {
        /*Getting values from Users and EntryUser tables*/
        try
        {
            int selectedRow_UserId;
            UserClass uc = new UserClass();
            EntryUserClass euc = new EntryUserClass();

            String selectedRow_Username = Session["selectedRow_Username"].ToString();
            hprlnk_header.Text = "Edit Entry User: " + selectedRow_Username + "'s Record";
            
            /*Getting userId of Users table*/
            DataTable dtUsers = uc.SelectAllUsersFromUsername(selectedRow_Username);
            if (dtUsers.Rows.Count > 0)
            {
                Session["selectedRow_UserId"] = dtUsers.Rows[0]["userId"].ToString();
            }

            /*Getting values of EntryUser table*/
            selectedRow_UserId = Convert.ToInt32(Session["selectedRow_UserId"]);
            DataTable dtEntryUser = euc.SelectAllEntryUserFromUserId(selectedRow_UserId);
            if (dtEntryUser.Rows.Count > 0)
            {
                //Session["selectedRow_EntryUserId"] = dtEntryUser.Rows[0]["entryUserId"].ToString();
                Session["selectedRow_EntryUserHospital"] = dtEntryUser.Rows[0]["entryUserHospital"].ToString();
                Session["selectedRow_EntryUserInactiveOrActive"] = dtEntryUser.Rows[0]["entryUserInactiveOrActive"].ToString();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        lblHospital.Visible = true;
        lblHospital.Text = Session["selectedRow_EntryUserHospital"].ToString();
        lblHospitalLabel.Visible = false;

        lblStatus.Visible = true;
        lblStatus.Text = Session["selectedRow_EntryUserInactiveOrActive"].ToString();
        lblStatusLabel.Visible = false;
    }

    protected void btnOk_CurrentHospital_Click(object sender, EventArgs e)
    {
        int selectedRow_UserId;
        UserClass uc = new UserClass();
        UserEntryUserClass uouc = new UserEntryUserClass();
        EntryUserClass euc = new EntryUserClass();
        LogEntryUserClass leuc = new LogEntryUserClass();

        String entryUserIndivFieldLog_Operation = "Update";
        String entryUserIndivFieldLog_Field = "entryUserContact";
        String entryUserIndivFieldLog_DataLater = dropdownlist_Hospital.SelectedValue;
        String entryUserIndivFieldLog_DataBefore = Session["selectedRow_EntryUserHospital"].ToString(); ;

        /*Update Record of EntryUser's Current Hospital
        Insert values on Log_UsersIndivField table*/
        try
        {
            selectedRow_UserId = Convert.ToInt32(Session["selectedRow_UserId"]);
            DataTable dtEntryUser = euc.SelectAllEntryUserFromUserId(selectedRow_UserId);
            if (dtEntryUser.Rows.Count > 0)
            {
                uouc.updateProfile_EntryUser_entryUserHospital(selectedRow_UserId, dropdownlist_Hospital.SelectedValue);

                int userId = Convert.ToInt32(Session["userId"]);
                leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                    selectedRow_UserId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                    entryUserIndivFieldLog_DataLater, userId);
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
        finally
        {
            Session["selectedRow_EntryUserHospital"] = dropdownlist_Hospital.SelectedValue;
            lblHospital.Text = dropdownlist_Hospital.SelectedValue;
            dropdownlist_Hospital.Visible = false;
            btnOk_Hospital.Visible = false;
        }
    }
    protected void btnOk_Status_Click(object sender, EventArgs e)
    {
        int selectedRow_UserId;
        UserClass uc = new UserClass();
        UserEntryUserClass uouc = new UserEntryUserClass();
        EntryUserClass euc = new EntryUserClass();
        LogEntryUserClass leuc = new LogEntryUserClass();

        String entryUserIndivFieldLog_Operation = "Update";
        String entryUserIndivFieldLog_Field = "entryUserInactiveOrActive";
        String entryUserIndivFieldLog_DataLater = dropdownlistStatus.SelectedValue;
        String entryUserIndivFieldLog_DataBefore = Session["selectedRow_EntryUserInactiveOrActive"].ToString();

        /*Update Record of EntryUser's Status
        Insert values on Log_EntryUsersIndivField table*/
        try
        {
            selectedRow_UserId = Convert.ToInt32(Session["selectedRow_UserId"]);
            DataTable dtEntryUser = euc.SelectAllEntryUserFromUserId(selectedRow_UserId);
            if (dtEntryUser.Rows.Count > 0)
            {
                uouc.updateProfile_EntryUser_entryUserStatus(selectedRow_UserId, dropdownlistStatus.SelectedValue);

                int userId = Convert.ToInt32(Session["userId"]);
                leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                    selectedRow_UserId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                    entryUserIndivFieldLog_DataLater, userId);
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
        finally
        {
            Session["selectedRow_EntryUserInactiveOrActive"] = dropdownlistStatus.SelectedValue;
            lblStatus.Text = dropdownlistStatus.SelectedValue;
            dropdownlistStatus.Visible = false;
            btnOk_Status.Visible = false;
        }
    }

    protected void lnkbtnEdit_CurrentHospital_Click(object sender, EventArgs e)
    {
        lblHospital.Visible = false;
        lblStatus.Visible = true;
    
        lblHospitalLabel.Visible = true;
        lblStatusLabel.Visible = false;

        dropdownlist_Hospital.Visible = true;
        btnOk_Hospital.Visible = true;
        dropdownlistStatus.Visible = false;
        btnOk_Status.Visible = false;

        dropdownlist_Hospital.Text = lblHospital.Text;

        HospitalClass hc = new HospitalClass();
        try
        {
            DataTable dt = hc.selectAllHospitalFullName();
            if (dt.Rows.Count > 0)
            {
                dropdownlist_Hospital.DataSource = dt;
                dropdownlist_Hospital.DataValueField = "hospitalFullName";
                dropdownlist_Hospital.DataTextField = "hospitalFullName";
                dropdownlist_Hospital.DataBind();
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    protected void lnkbtnEdit_Status_Click(object sender, EventArgs e)
    {
        lblHospital.Visible = true;
        lblStatus.Visible = false;
        
        lblHospitalLabel.Visible = false;
        lblStatusLabel.Visible = true;

        dropdownlist_Hospital.Visible = false;
        btnOk_Hospital.Visible = false;
        dropdownlistStatus.Visible = true;
        btnOk_Status.Visible = true;
        
        dropdownlistStatus.SelectedValue = lblStatus.Text;
    }
    
}