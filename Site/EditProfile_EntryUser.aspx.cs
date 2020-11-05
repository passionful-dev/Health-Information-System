using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class EditProfile_EntryUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*Getting Username and assigning it to the respective label*/
        lblUsername.Text = Session["username"].ToString();

        /*Getting values from Users and EntryUser tables*/
        try
        {
            int userId;
            UserClass uc = new UserClass();
            EntryUserClass euc = new EntryUserClass();

            /*Getting values of Users table*/
            DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
            if (dtUsers.Rows.Count > 0)
            {
                Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                Session["userPasswd"] = dtUsers.Rows[0]["userPasswd"].ToString();
                Session["userEmail"] = dtUsers.Rows[0]["userEmail"].ToString();
                Session["userSecEmail"] = dtUsers.Rows[0]["userSecEmail"].ToString();

                lblEmail.Text = Session["userEmail"].ToString();
                lblSecEmail.Text = Session["userSecEmail"].ToString();
            }

            /*Getting values of EntryUser table*/
            userId = Convert.ToInt32(Session["userId"]);
            DataTable dtEntryUser = euc.SelectAllEntryUserFromUserId(userId);
            if (dtEntryUser.Rows.Count > 0)
            {
                Session["entryUserFirstName"] = dtEntryUser.Rows[0]["entryUserFirstName"].ToString();
                Session["entryUserMiddleName"] = dtEntryUser.Rows[0]["entryUserMiddleName"].ToString();
                Session["entryUserLastName"] = dtEntryUser.Rows[0]["entryUserLastName"].ToString();
                Session["entryUserDob"] = dtEntryUser.Rows[0]["entryUserDob"].ToString();
                Session["entryUserGender"] = dtEntryUser.Rows[0]["entryUserGender"].ToString();
                Session["entryUserContact"] = dtEntryUser.Rows[0]["entryUserContact"].ToString();
                Session["entryUserSecContact"] = dtEntryUser.Rows[0]["entryUserSecContact"].ToString();
                Session["entryUserHouseAdd"] = dtEntryUser.Rows[0]["entryUserHouseAdd"].ToString();
                Session["entryUserDistrict"] = dtEntryUser.Rows[0]["entryUserDistrict"].ToString();
                Session["entryUserCity"] = dtEntryUser.Rows[0]["entryUserCity"].ToString();
                Session["entryUserCountry"] = dtEntryUser.Rows[0]["entryUserCountry"].ToString();
                Session["entryUserDesignation"] = dtEntryUser.Rows[0]["entryUserDesignation"].ToString();

                lblFirstName.Text = Session["entryUserFirstName"].ToString();
                lblMiddleName.Text = Session["entryUserMiddleName"].ToString();
                lblLastName.Text = Session["entryUserLastName"].ToString();
                lblDob.Text = Session["entryUserDob"].ToString();
                lblGender.Text = Session["entryUserGender"].ToString();
                lblContact.Text = Session["entryUserContact"].ToString();
                lblSecContact.Text = Session["entryUserSecContact"].ToString();
                lblHouseAdd.Text = Session["entryUserHouseAdd"].ToString();
                lblDistrict.Text = Session["entryUserDistrict"].ToString();
                lblCity.Text = Session["entryUserCity"].ToString();
                lblCountry.Text = Session["entryUserCountry"].ToString();
                lblDesignation.Text = Session["entryUserDesignation"].ToString();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    protected void lnkbtnEdit_Name_Click(object sender, EventArgs e)
    {
        lblFirstName.Visible = false;
        lblMiddleName.Visible = false;
        lblLastName.Visible = false;
        //lnkbtnEdit_Name.Visible = false;
        lblName.Visible = true;
        lblName.Text = "Name";

        txtboxFirstName.Visible = true;
        txtboxMiddleName.Visible = true;
        txtboxLastName.Visible = true;
        btnOk_Name.Visible = true;

        txtboxFirstName.Text = Session["entryUserFirstName"].ToString();
        txtboxMiddleName.Text = Session["entryUserMiddleName"].ToString();
        txtboxLastName.Text = Session["entryUserLastName"].ToString();

        /*Put other things as default*/
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;

        //ReqFieldVald_FirstName.Visible = false;
        //ReqFieldVald_LastName.Visible = false;
    }
    protected void lnkbtnEdit_Username_Click(object sender, EventArgs e)
    {
        //lnkbtnEdit_Username.Visible = false;
        lblUsername.Visible = false;
        lblUsernameLabel.Visible = true;
        lblUsernameLabel.Text = "Username";

        txtboxUsername.Visible = true;
        btnOk_Username.Visible = true;

        txtboxUsername.Text = Session["username"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        //lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        //lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        //txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        //btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_Password_Click(object sender, EventArgs e)
    {
        lblPassword.Visible = false;
        lblPasswordLabel.Visible = true;
        //lnkbtnEdit_Password.Visible = false;
        lblPasswordLabel.Text = "Password";

        txtboxOldPassword.Visible = true;
        txtboxNewPassword.Visible = true;
        txtboxNewConfirmPassword.Visible = true;
        btnOk_Password.Visible = true;

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        //lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        //lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        //txtboxOldPassword.Visible = false;
        //txtboxNewPassword.Visible = false;
        //txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        //btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_Email_Click(object sender, EventArgs e)
    {
        lblEmail.Visible = false;
        lblEmailLabel.Visible = true;
        //lnkbtnEdit_Email.Visible = false;
        lblEmailLabel.Text = "Email";

        txtboxEmail.Visible = true;
        btnOk_Email.Visible = true;

        txtboxEmail.Text = Session["userEmail"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        //lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        //lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        //txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        //btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_Dob_Click(object sender, EventArgs e)
    {
        lblDob.Visible = false;
        lblDobLabel.Visible = true;
        lblDobLabel.Text = "Date of Birth (dd/mm/yyyy)";

        txtboxDob.Visible = true;
        btnOk_Dob.Visible = true;

        txtboxDob.Text = Session["entryUserDob"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        //lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        //lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        //txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        //btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_Gender_Click(object sender, EventArgs e)
    {
        lblGender.Visible = false;
        lblGenderLabel.Visible = true;
        lblGenderLabel.Text = "Gender";

        dropdownlistGender.Visible = true;
        btnOk_Gender.Visible = true;

        dropdownlistGender.SelectedValue = Session["entryUserGender"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        //lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        //lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        //dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        //btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_Contact_Click(object sender, EventArgs e)
    {
        lblContact.Visible = false;
        lblContactLabel.Visible = true;
        lblContactLabel.Text = "Contact";

        txtboxContact.Visible = true;
        btnOk_Contact.Visible = true;

        txtboxContact.Text = Session["entryUserContact"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        //lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        //lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        //txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        //btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_Address_Click(object sender, EventArgs e)
    {
        lblAddress.Visible = true;
        lblAddress.Text = "Address";
        lblHouseAdd.Visible = false;
        lblDistrict.Visible = false;
        lblCity.Visible = false;
        lblCountry.Visible = false;


        txtboxHouseAdd.Visible = true;
        txtboxDistrict.Visible = true;
        txtboxCity.Visible = true;
        txtboxCountry.Visible = true;
        btnOk_Address.Visible = true;

        txtboxHouseAdd.Text = Session["entryUserHouseAdd"].ToString();
        txtboxDistrict.Text = Session["entryUserDistrict"].ToString();
        txtboxCity.Text = Session["entryUserCity"].ToString();
        txtboxCountry.Text = Session["entryUserCountry"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        //lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        //lblHouseAdd.Visible = true;
        //lblDistrict.Visible = true;
        //lblCity.Visible = true;
        //lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        //txtboxHouseAdd.Visible = false;
        //txtboxDistrict.Visible = false;
        //txtboxCity.Visible = false;
        //txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        //btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_SecEmail_Click(object sender, EventArgs e)
    {
        lblSecEmail.Visible = false;
        lblSecEmailLabel.Visible = true;
        lblSecEmailLabel.Text = "Secondary Email";

        btnOk_SecEmail.Visible = true;

        txtboxSecEmail.Visible = true;
        txtboxSecEmail.Text = Session["userSecEmail"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        //lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        //lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        //txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        //btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
    protected void lnkbtnEdit_SecContact_Click(object sender, EventArgs e)
    {
        lblSecContact.Visible = false;
        lblSecContactLabel.Visible = true;
        lblSecContactLabel.Text = "Secondary Contact";

        btnOk_SecContact.Visible = true;
        txtboxSecContact.Visible = true;

        txtboxSecContact.Text = Session["entryUserSecContact"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        //lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        //lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        //txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        //btnOk_SecContact.Visible = false;
    }
    protected void btnOk_Name_Click(object sender, EventArgs e)
    {
        if (txtboxFirstName.Text != lblFirstName.Text ||
            txtboxMiddleName.Text != lblMiddleName.Text ||
            txtboxLastName.Text != lblLastName.Text)
        {
            try
            {
                int userId;
                UserClass uc = new UserClass();
                UserEntryUserClass uouc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();
                EntryUserClass ouc = new EntryUserClass();
                LogEntryUserClass leuc = new LogEntryUserClass();

                String entryUserIndivFieldLog_Operation = "Update";
                String entryUserIndivFieldLog_Field = "entryUserFullName";
                String entryUserIndivFieldLog_DataLater = txtboxFirstName.Text + " " + txtboxMiddleName.Text
                     + " " + txtboxLastName.Text;
                String entryUserIndivFieldLog_DataBefore;

                /*Update Profile of EntryUser's FullName
                Insert values on Log_UsersIndivField table*/
                /*Getting values of Users table*/
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                    userId = Convert.ToInt32(Session["userId"]);

                    DataTable dtEntryUser = ouc.SelectAllEntryUserFromUserId(userId);
                    if (dtEntryUser.Rows.Count > 0)
                    {
                        entryUserIndivFieldLog_DataBefore = dtEntryUser.Rows[0]
                            ["entryUserFirstName"].ToString() + " "
                            + dtEntryUser.Rows[0]["entryUserMiddleName"].ToString() + " "
                            + dtEntryUser.Rows[0]["entryUserLastName"].ToString();
                        leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                            userId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                            entryUserIndivFieldLog_DataLater, userId);
                    }

                    uouc.updateProfile_EntryUser_entryUserFullName(userId, txtboxFirstName.Text,
                        txtboxMiddleName.Text, txtboxLastName.Text);

                }

            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

            finally
            {
                txtboxFirstName.Visible = false;
                txtboxMiddleName.Visible = false;
                txtboxLastName.Visible = false;
                btnOk_Name.Visible = false;

                lblName.Visible = false;

                lblFirstName.Text = txtboxFirstName.Text;
                lblMiddleName.Text = txtboxMiddleName.Text;
                lblLastName.Text = txtboxLastName.Text;

                lblFirstName.Visible = true;
                lblMiddleName.Visible = true;
                lblLastName.Visible = true;
            }
        }
    }
    protected void btnOk_SecEmail_Click(object sender, EventArgs e)
    {
        if (txtboxSecEmail.Text != lblSecEmail.Text)
        {
            try
            {
                int userId;
                UserClass uc = new UserClass();
                UserEntryUserClass uouc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();

                String userIndivFieldLog_Operation = "Update";
                String userIndivFieldLog_Field = "userSecEmail";
                String userIndivFieldLog_DataLater = txtboxSecEmail.Text;
                String userIndivFieldLog_DataBefore;

                /*Update Profile of Users' SecEmail
                Insert values on Log_UsersIndivField table*/
                /*Getting values of Users table*/
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                    userId = Convert.ToInt32(Session["userId"]);

                    userIndivFieldLog_DataBefore = dtUsers.Rows[0]["userSecEmail"].ToString();

                    uouc.updateProfile_Users_userSecEmail(txtboxSecEmail.Text, userId);
                    luc.insertOn_Log_UsersIndivField_WithUpdateOperation(userIndivFieldLog_Operation,
                        userId, userIndivFieldLog_Field, userIndivFieldLog_DataBefore,
                        userIndivFieldLog_DataLater);

                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxSecEmail.Visible = false;
                btnOk_SecEmail.Visible = false;

                lblSecEmailLabel.Visible = false;

                lblSecEmail.Text = txtboxSecEmail.Text;

                lblSecEmail.Visible = true;
            }
        }
    }
    protected void btnOk_Username_Click(object sender, EventArgs e)
    {

        if (txtboxUsername.Text != lblUsername.Text)
        {
            try
            {
                int userId;
                UserClass uc = new UserClass();
                UserEntryUserClass uouc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();

                String userIndivFieldLog_Operation = "Update";
                String userIndivFieldLog_Field = "username";
                String userIndivFieldLog_DataLater = txtboxUsername.Text;
                String userIndivFieldLog_DataBefore;

                /*Update Profile of Users' username
                Insert values on Log_UsersIndivField table*/
                /*Getting values of Users table*/
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                    userId = Convert.ToInt32(Session["userId"]);
                    userIndivFieldLog_DataBefore = dtUsers.Rows[0]["username"].ToString();

                    uouc.updateProfile_Users_username(txtboxUsername.Text, userId);

                    Session["username"] = txtboxUsername.Text;

                    luc.insertOn_Log_UsersIndivField_WithUpdateOperation(userIndivFieldLog_Operation,
                        userId, userIndivFieldLog_Field, userIndivFieldLog_DataBefore,
                        userIndivFieldLog_DataLater);

                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxUsername.Visible = false;
                btnOk_Username.Visible = false;

                lblUsernameLabel.Visible = false;

                lblUsername.Text = txtboxUsername.Text;

                lblUsername.Visible = true;
                Response.Redirect("EditProfileNew_EntryUser.aspx");
            }
        }
    }
    protected void btnOk_Password_Click(object sender, EventArgs e)
    {

        if (txtboxNewPassword.Text != lblPassword.Text)
        {
            try
            {
                int userId;
                UserClass uc = new UserClass();
                UserEntryUserClass uouc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();

                String userIndivFieldLog_Operation = "Update";
                String userIndivFieldLog_Field = "userPasswd";
                String userIndivFieldLog_DataLater = txtboxNewPassword.Text;
                String userIndivFieldLog_DataBefore;

                /*Update Profile of Users' password
                Insert values on Log_UsersIndivField table*/
                /*Getting values of Users table*/
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                    userId = Convert.ToInt32(Session["userId"]);

                    userIndivFieldLog_DataBefore = dtUsers.Rows[0]["userPasswd"].ToString();
                    if (txtboxOldPassword.Text.ToString() == userIndivFieldLog_DataBefore)
                    {
                        if (txtboxNewPassword.Text == txtboxNewConfirmPassword.Text)
                        {
                            ltrMessage.Text = "";
                            uouc.updateProfile_Users_userPassword(txtboxNewPassword.Text, userId);

                            luc.insertOn_Log_UsersIndivField_WithUpdateOperation(userIndivFieldLog_Operation,
                                userId, userIndivFieldLog_Field, userIndivFieldLog_DataBefore,
                                userIndivFieldLog_DataLater);
                        }
                        else
                        {
                            ltrMessage.Text = "New Password does not match with Confirming New Password!";
                        }
                    }
                    else
                    {
                        ltrMessage.Text = "Old Password incorrect!";
                    }
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxOldPassword.Visible = false;
                txtboxNewPassword.Visible = false;
                txtboxNewConfirmPassword.Visible = false;
                btnOk_Password.Visible = false;

                lblPasswordLabel.Visible = false;

                //lblPassword.Text = txtboxNewPassword.Text;

                lblPassword.Visible = true;
            }
        }
    }
    protected void btnOk_Email_Click(object sender, EventArgs e)
    {
        if (txtboxEmail.Text != lblEmail.Text)
        {
            try
            {
                int userId;
                UserClass uc = new UserClass();
                UserEntryUserClass uouc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();

                String userIndivFieldLog_Operation = "Update";
                String userIndivFieldLog_Field = "userEmail";
                String userIndivFieldLog_DataLater = txtboxEmail.Text;
                String userIndivFieldLog_DataBefore;

                /*Update Profile of Users' userEmail
                Insert values on Log_UsersIndivField table*/
                /*Getting values of Users table*/
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                    userId = Convert.ToInt32(Session["userId"]);
                    userIndivFieldLog_DataBefore = dtUsers.Rows[0]["userEmail"].ToString();

                    uouc.updateProfile_Users_userEmail(txtboxEmail.Text, userId);

                    luc.insertOn_Log_UsersIndivField_WithUpdateOperation(userIndivFieldLog_Operation,
                        userId, userIndivFieldLog_Field, userIndivFieldLog_DataBefore,
                        userIndivFieldLog_DataLater);
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxEmail.Visible = false;
                btnOk_Email.Visible = false;

                lblEmailLabel.Visible = false;

                lblEmail.Text = txtboxEmail.Text;

                lblEmail.Visible = true;
            }
        }
    }
    protected void btnOk_Dob_Click(object sender, EventArgs e)
    {
        //if (txtboxDob.Text != lblDob.Text)
        {
            String patientDob = txtboxDob.Text;

            /*Getting Patient Age Group*/
            DateTime currentDateNTime = DateTime.Now;
            int currentYear = currentDateNTime.Year; //Getting current year

            DateTime dob;
            dob = Convert.ToDateTime(patientDob);
            int dobYear = dob.Year; //Getting dob year

            int age = currentYear - dobYear;

            if (age < 1)
            {
                ltrMessage.Text = "Invalid Date of Birth!";
            }
            else
            {
                ltrMessage.Text = "";
                int userId;
                UserClass uc = new UserClass();
                UserEntryUserClass uouc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();
                EntryUserClass ouc = new EntryUserClass();
                LogEntryUserClass leuc = new LogEntryUserClass();

                String entryUserIndivFieldLog_Operation = "Update";
                String entryUserIndivFieldLog_Field = "entryUserDob";
                String entryUserIndivFieldLog_DataLater = txtboxDob.Text;
                String entryUserIndivFieldLog_DataBefore;

                try
                {
                    /*Update Profile of EntryUser's Dob
                    Insert values on Log_UsersIndivField table*/
                    /*Getting values of Users table*/
                    DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                    if (dtUsers.Rows.Count > 0)
                    {
                        Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }

                try
                {
                    userId = Convert.ToInt32(Session["userId"]);
                    DataTable dtEntryUser = ouc.SelectAllEntryUserFromUserId(userId);
                    if (dtEntryUser.Rows.Count > 0)
                    {
                        entryUserIndivFieldLog_DataBefore = dtEntryUser.Rows[0]["entryUserDob"].ToString();

                        uouc.updateProfile_EntryUser_entryUserDob(userId, txtboxDob.Text);

                        leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                            userId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                            entryUserIndivFieldLog_DataLater, userId);
                    }
                }
                catch (Exception ex)
                {
                    ltrMessage.Text = ex.Message;
                }
                finally
                {
                    txtboxDob.Visible = false;
                    btnOk_Dob.Visible = false;

                    lblDobLabel.Visible = false;

                    lblDob.Text = txtboxDob.Text;

                    lblDob.Visible = true;
                }
            }
        }
    }
    protected void btnOk_Gender_Click(object sender, EventArgs e)
    {
        if (dropdownlistGender.SelectedValue != lblGender.Text)
        {
            int userId;
            UserClass uc = new UserClass();
            UserEntryUserClass uouc = new UserEntryUserClass();
            LogUserClass luc = new LogUserClass();
            EntryUserClass ouc = new EntryUserClass();
            LogEntryUserClass leuc = new LogEntryUserClass();

            String entryUserIndivFieldLog_Operation = "Update";
            String entryUserIndivFieldLog_Field = "entryUserGender";
            String entryUserIndivFieldLog_DataLater = dropdownlistGender.SelectedValue;
            String entryUserIndivFieldLog_DataBefore;

            /*Getting userId from Users table*/
            try
            {
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

            /*Update Profile of EntryUser's Gender
            Insert values on Log_UsersIndivField table*/
            try
            {
                userId = Convert.ToInt32(Session["userId"]);
                DataTable dtEntryUser = ouc.SelectAllEntryUserFromUserId(userId);
                if (dtEntryUser.Rows.Count > 0)
                {
                    entryUserIndivFieldLog_DataBefore = dtEntryUser.Rows[0]["entryUserGender"].ToString();

                    uouc.updateProfile_EntryUser_entryUserGender(userId, dropdownlistGender.SelectedValue);

                    leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                        userId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                        entryUserIndivFieldLog_DataLater, userId);
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                dropdownlistGender.Visible = false;
                btnOk_Gender.Visible = false;

                lblGenderLabel.Visible = false;

                lblGender.Text = dropdownlistGender.SelectedValue;

                lblGender.Visible = true;
            }
        }
    }
    protected void btnOk_Contact_Click(object sender, EventArgs e)
    {
        if (txtboxContact.Text != lblContact.Text)
        {
            int userId;
            UserClass uc = new UserClass();
            UserEntryUserClass uouc = new UserEntryUserClass();
            LogUserClass luc = new LogUserClass();
            EntryUserClass ouc = new EntryUserClass();
            LogEntryUserClass leuc = new LogEntryUserClass();

            String entryUserIndivFieldLog_Operation = "Update";
            String entryUserIndivFieldLog_Field = "entryUserContact";
            String entryUserIndivFieldLog_DataLater = txtboxContact.Text;
            String entryUserIndivFieldLog_DataBefore;

            /*Getting userId from Users table*/
            try
            {
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

            /*Update Profile of EntryUser's Contact
            Insert values on Log_UsersIndivField table*/
            try
            {
                userId = Convert.ToInt32(Session["userId"]);
                DataTable dtEntryUser = ouc.SelectAllEntryUserFromUserId(userId);
                if (dtEntryUser.Rows.Count > 0)
                {
                    entryUserIndivFieldLog_DataBefore = dtEntryUser.Rows[0]["entryUserContact"].ToString();

                    uouc.updateProfile_EntryUser_entryUserContact(userId, txtboxContact.Text);

                    leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                        userId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                        entryUserIndivFieldLog_DataLater, userId);
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxContact.Visible = false;
                btnOk_Contact.Visible = false;

                lblContactLabel.Visible = false;

                lblContact.Text = txtboxContact.Text;

                lblContact.Visible = true;
            }
        }
    }
    protected void btnOk_Address_Click(object sender, EventArgs e)
    {
        if (txtboxHouseAdd.Text != lblHouseAdd.Text ||
            txtboxDistrict.Text != lblDistrict.Text ||
            txtboxCity.Text != lblCity.Text ||
            txtboxCountry.Text != lblCountry.Text)
        {
            try
            {
                int userId;
                UserClass uc = new UserClass();
                UserEntryUserClass uouc = new UserEntryUserClass();
                LogUserClass luc = new LogUserClass();
                EntryUserClass ouc = new EntryUserClass();
                LogEntryUserClass leuc = new LogEntryUserClass();

                String entryUserIndivFieldLog_Operation = "Update";
                String entryUserIndivFieldLog_Field = "entryUserAddress";
                String entryUserIndivFieldLog_DataLater = txtboxHouseAdd.Text
                    + "; " + txtboxDistrict.Text
                    + "; " + txtboxCity.Text
                    + "; " + txtboxCountry.Text;
                String entryUserIndivFieldLog_DataBefore;

                /*Update Profile of EntryUser's Address
                Insert values on Log_UsersIndivField table*/
                /*Getting values of Users table*/
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                    userId = Convert.ToInt32(Session["userId"]);

                    DataTable dtEntryUser = ouc.SelectAllEntryUserFromUserId(userId);
                    if (dtEntryUser.Rows.Count > 0)
                    {
                        entryUserIndivFieldLog_DataBefore = dtEntryUser.Rows[0]
                            ["entryUserHouseAdd"].ToString() + "; "
                            + dtEntryUser.Rows[0]["entryUserDistrict"].ToString() + "; "
                            + dtEntryUser.Rows[0]["entryUserCity"].ToString() + "; "
                            + dtEntryUser.Rows[0]["entryUserCountry"].ToString();

                        leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                            userId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                            entryUserIndivFieldLog_DataLater, userId);
                    }

                    uouc.updateProfile_EntryUser_entryUserAddress(userId, txtboxHouseAdd.Text,
                        txtboxDistrict.Text, txtboxCity.Text, txtboxCountry.Text);

                }

            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxHouseAdd.Visible = false;
                txtboxDistrict.Visible = false;
                txtboxCity.Visible = false;
                txtboxCountry.Visible = false;
                btnOk_Address.Visible = false;

                lblAddress.Visible = false;

                lblHouseAdd.Text = txtboxHouseAdd.Text;
                lblDistrict.Text = txtboxDistrict.Text;
                lblCity.Text = txtboxCity.Text;
                lblCountry.Text = txtboxCountry.Text;

                lblHouseAdd.Visible = true;
                lblDistrict.Visible = true;
                lblCity.Visible = true;
                lblCountry.Visible = true;
            }
        }
    }
    protected void btnOk_SecContact_Click(object sender, EventArgs e)
    {
        if (txtboxSecContact.Text != lblSecContact.Text)
        {
            int userId;
            UserClass uc = new UserClass();
            UserEntryUserClass uouc = new UserEntryUserClass();
            LogUserClass luc = new LogUserClass();
            EntryUserClass ouc = new EntryUserClass();
            LogEntryUserClass leuc = new LogEntryUserClass();

            String entryUserIndivFieldLog_Operation = "Update";
            String entryUserIndivFieldLog_Field = "entryUserSecContact";
            String entryUserIndivFieldLog_DataLater = txtboxSecContact.Text;
            String entryUserIndivFieldLog_DataBefore;

            /*Getting userId from Users table*/
            try
            {
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

            /*Update Profile of EntryUser's SecContact
            Insert values on Log_UsersIndivField table*/
            try
            {
                userId = Convert.ToInt32(Session["userId"]);
                DataTable dtEntryUser = ouc.SelectAllEntryUserFromUserId(userId);
                if (dtEntryUser.Rows.Count > 0)
                {
                    entryUserIndivFieldLog_DataBefore = dtEntryUser.Rows[0]["entryUserSecContact"].ToString();

                    uouc.updateProfile_EntryUser_entryUserSecContact(userId, txtboxSecContact.Text);

                    leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                        userId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                        entryUserIndivFieldLog_DataLater, userId);
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxSecContact.Visible = false;
                btnOk_SecContact.Visible = false;

                lblSecContactLabel.Visible = false;

                lblSecContact.Text = txtboxSecContact.Text;

                lblSecContact.Visible = true;
            }
        }
    }
    protected void btnOk_Designation_Click(object sender, EventArgs e)
    {
        if (txtboxDesignation.Text != lblDesignation.Text)
        {
            int userId;
            UserClass uc = new UserClass();
            UserEntryUserClass ueuc = new UserEntryUserClass();
            LogUserClass luc = new LogUserClass();
            EntryUserClass ouc = new EntryUserClass();
            LogEntryUserClass leuc = new LogEntryUserClass();

            String entryUserIndivFieldLog_Operation = "Update";
            String entryUserIndivFieldLog_Field = "entryUserDesignation";
            String entryUserIndivFieldLog_DataLater = txtboxDesignation.Text;
            String entryUserIndivFieldLog_DataBefore;

            /*Getting userId from Users table*/
            try
            {
                DataTable dtUsers = uc.SelectAllUsersFromUsername(lblUsername.Text);
                if (dtUsers.Rows.Count > 0)
                {
                    Session["userId"] = dtUsers.Rows[0]["userId"].ToString();
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }

            /*Update Profile of EntryUser's Designation
            Insert values on Log_EntryUserIndivField table*/
            try
            {
                userId = Convert.ToInt32(Session["userId"]);
                DataTable dtEntryUser = ouc.SelectAllEntryUserFromUserId(userId);
                if (dtEntryUser.Rows.Count > 0)
                {
                    entryUserIndivFieldLog_DataBefore = dtEntryUser.Rows[0]["entryUserDesignation"].ToString();

                    ueuc.updateProfile_EntryUser_entryUserDesignation(userId, txtboxDesignation.Text);

                    leuc.insertOn_Log_EntryUserIndivField_WithUpdateOperation(entryUserIndivFieldLog_Operation,
                        userId, entryUserIndivFieldLog_Field, entryUserIndivFieldLog_DataBefore,
                        entryUserIndivFieldLog_DataLater, userId);
                }
            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                txtboxDesignation.Visible = false;
                btnOk_Designation.Visible = false;

                lblDesignationLabel.Visible = false;

                lblDesignation.Text = txtboxDesignation.Text;

                lblDesignation.Visible = true;
            }
        }
    }
    protected void lnkbtnEdit_Designation_Click(object sender, EventArgs e)
    {
        lblDesignationLabel.Visible = false;
        lblDesignation.Visible = true;
        lnkbtnEdit_Designation.Visible = true;
        lblDesignation.Text = "Designation";

        txtboxDesignation.Visible = true;
        btnOk_Designation.Visible = true;

        txtboxDesignation.Text = Session["entryUserDesignation"].ToString();

        /*Put other things as default*/
        lblName.Visible = false;
        lblUsernameLabel.Visible = false;
        lblPasswordLabel.Visible = false;
        lblEmailLabel.Visible = false;
        lblDobLabel.Visible = false;
        lblGenderLabel.Visible = false;
        lblContactLabel.Visible = false;
        lblAddress.Visible = false;
        lblSecEmailLabel.Visible = false;
        lblSecContactLabel.Visible = false;

        lblFirstName.Visible = true;
        lblMiddleName.Visible = true;
        lblLastName.Visible = true;
        lblUsername.Visible = true;
        lblPassword.Visible = true;
        lblEmail.Visible = true;
        lblDob.Visible = true;
        lblGender.Visible = true;
        lblContact.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblCountry.Visible = true;
        lblSecEmail.Visible = true;
        lblSecContact.Visible = true;

        txtboxFirstName.Visible = false;
        txtboxMiddleName.Visible = false;
        txtboxLastName.Visible = false;
        txtboxUsername.Visible = false;
        txtboxOldPassword.Visible = false;
        txtboxNewPassword.Visible = false;
        txtboxNewConfirmPassword.Visible = false;
        txtboxEmail.Visible = false;
        txtboxDob.Visible = false;
        dropdownlistGender.Visible = false;
        txtboxContact.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        txtboxCountry.Visible = false;
        txtboxSecEmail.Visible = false;
        txtboxSecContact.Visible = false;

        btnOk_Name.Visible = false;
        btnOk_Username.Visible = false;
        btnOk_Password.Visible = false;
        btnOk_Email.Visible = false;
        btnOk_Dob.Visible = false;
        btnOk_Gender.Visible = false;
        btnOk_Contact.Visible = false;
        btnOk_Address.Visible = false;
        btnOk_SecEmail.Visible = false;
        btnOk_SecContact.Visible = false;
    }
}