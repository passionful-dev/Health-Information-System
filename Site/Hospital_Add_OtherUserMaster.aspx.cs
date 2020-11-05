using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hospital_Add_OtherUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtboxName.Focus();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            ltrMessage.Text = "";
            //ltrMessageGreen.Text = "";
            
            HospitalClass hc = new HospitalClass();
            LogHospitalClass lhc = new LogHospitalClass();

            /*Current date and time calculated*/
            String currentDateNTimeString;
            DateTime currentDateNTime = DateTime.Now;
            currentDateNTimeString = currentDateNTime.ToString("dd/MM/yyyy hh:mm:ss tt");

            String hospitalFullName, hospitalType, hospitalHouseAdd, hospitalDistrict, hospitalCity, hospitalDescrip;
            int hospitalRegdBy;

            hospitalFullName = txtboxName.Text;
            hospitalType = dropdownlistType.SelectedValue;
            hospitalHouseAdd = txtboxHouseAdd.Text;
            hospitalDistrict = txtboxDistrict.Text;
            hospitalCity = txtboxCity.Text;
            hospitalDescrip = txtboxDescrip.Text;

            /*Getting userId from Session*/
            String userIdString = Session["userId"].ToString();
            int userId = Convert.ToInt32(userIdString);
                
            hospitalRegdBy = userId;

            /*Inserting and putting the values in Log*/
            hc.InsertHospital(hospitalFullName, hospitalType, hospitalHouseAdd, hospitalDistrict, 
                hospitalCity, hospitalDescrip, hospitalRegdBy);
            lhc.insertOn_Log_HospitalWholeField_WithInsertOperation(hospitalFullName);
            
            Response.Redirect("Hospital_OtherUserMaster.aspx");
            txtboxName.Text = "";
            dropdownlistType.SelectedValue = "";
            txtboxHouseAdd.Text = "";
            txtboxDistrict.Text = "";
            txtboxCity.Text = "";
            txtboxDescrip.Text = "";

            //ltrMessageGreen.Text = "Record added!";
        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
    
    }
}