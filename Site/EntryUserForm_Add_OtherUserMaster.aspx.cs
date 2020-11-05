using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class EntryUserForm_Add_OtherUserMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtboxFirstName.Focus();

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
                    dropdownlist_Hospital.Items.Insert(0, new ListItem("", ""));
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            /*Check normal conditions*/
            /*Passwords matching checking*/
            if (txtboxPassword.Text != txtboxConfirmPassword.Text)
            {
                ltrMessage.Text = "The Passwords did not match!";
            }

            /*2 emails matching checking*/
            else if (txtboxEmail.Text == txtboxSecEmail.Text)
            {
                ltrMessage.Text = "The 2 Email addresses you provided should not be same!";
            }

            /*2 contacts matching checking*/
            else if (txtboxContact.Text == txtboxSecContact.Text)
            {
                ltrMessage.Text = "The 2 Contact Numbers you provided should not be same!";
            }
            
            else
            {
                ltrMessage.Text = "";
                
                /*Putting Country as Nepal by default*/
                String country;
                if (txtboxCountry.Text == "")
                {
                    country = "Nepal";
                    //Console.WriteLine("Went to this condition!");
                }
                else
                {
                    country = txtboxCountry.Text;
                }
            
                UserEntryUserClass ueuc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();
                LogEntryUserClass leuc = new LogEntryUserClass();

                String entryUserDesignation = txtboxDesignation.Text;
                
                String entryUserHospital = dropdownlist_Hospital.SelectedValue;
                dropdownlist_Hospital.Items.Insert(0, entryUserHospital);
                
                int entryUserRegisteredby = Convert.ToInt32(Session["userId"]); ; 
                String entryUserInactiveOrActive = "Active";

                ueuc.RegisterEntryUser_Users(txtboxUsername.Text, txtboxPassword.Text, txtboxEmail.Text, txtboxSecEmail.Text);
                ueuc.RegisterEntryUser_EntryUser(entryUserDesignation,
                entryUserHospital, entryUserRegisteredby, entryUserInactiveOrActive, txtboxUsername.Text, txtboxFirstName.Text, txtboxMiddleName.Text, txtboxLastName.Text, txtboxDob.Text, dropdownlistGender.Text, txtboxContact.Text, txtboxSecContact.Text, txtboxHouseAdd.Text, txtboxDistrict.Text, txtboxCity.Text, country);

                String username = txtboxUsername.Text;

                luc.insertOn_Log_UsersWholeField_WithInsertOperation(username);
                leuc.insertOn_Log_EntryUserWholeField_WithInsertOperation(username);

                Response.Redirect("EntryUserForm_OtherUserMaster.aspx");
                
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
    //protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    //{
    //    //lblday.Text = Calendar1.TodaysDate.ToShortDateString();
    //    //lblbday.Text = Calendar1.SelectedDate.ToShortDateString();
    //    txtboxDob.Text = Calendar1.SelectedDate.ToShortDateString();
    //}
}