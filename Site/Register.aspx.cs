using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.Sql;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtboxFirstName.Focus();
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            UserPatientClass upc = new UserPatientClass();
            LogUserClass luc = new LogUserClass();
            LogPatientClass lpc = new LogPatientClass();

            /*Check normal conditions*/
            //1. Checking Patient Age Group if not <1
            DateTime currentDateNTime = DateTime.Now;
            int currentYear = currentDateNTime.Year; //Getting current year

            DateTime dob;
            dob = Convert.ToDateTime(txtboxDob.Text);
            int dobYear = dob.Year; //Getting dob year

            int age = currentYear - dobYear;

            if (age < 1)
            {
                ltrMessage.Text = "Invalid Date of Birth!";
            }

            /*Passwords matching checking*/
            else if (txtboxPassword.Text != txtboxConfirmPassword.Text)
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
                upc.RegisterPatient_Users(txtboxUsername.Text, txtboxPassword.Text, txtboxEmail.Text, txtboxSecEmail.Text);
                
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
                upc.RegisterPatient_Patient(txtboxUsername.Text, txtboxFirstName.Text, txtboxMiddleName.Text, txtboxLastName.Text, txtboxDob.Text, dropdownlistGender.Text, txtboxContact.Text, txtboxSecContact.Text, txtboxHouseAdd.Text, txtboxDistrict.Text, txtboxCity.Text, country);

                String username = txtboxUsername.Text;

                luc.insertOn_Log_UsersWholeField_WithInsertOperation(username);
                lpc.insertOn_Log_PatientWholeField_WithInsertOperation(username);
                
                Session["username"] = txtboxUsername.Text;
                Response.Redirect("Home_Patient.aspx");
                //ltrMessageGreen.Text = "New Account registered!";

                //txtboxUsername.Text = "";
                //txtboxPassword.Text = "";
                //txtboxEmail.Text = "";
                //txtboxSecEmail.Text = "";

                //txtboxFirstName.Text = "";
                //txtboxMiddleName.Text = "";
                //txtboxLastName.Text = "";
                //txtboxDob.Text = "";
                //dropdownlistGender.Text = "";
                //txtboxContact.Text = "";
                //txtboxSecContact.Text = "";
                //txtboxHouseAdd.Text = "";
                //txtboxDistrict.Text = "";
                //txtboxCity.Text = "";
                //txtboxCountry.Text = "";

                //txtboxFirstName.Focus();
            }
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    }
}