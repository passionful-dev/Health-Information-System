using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Hospital_Edit_OtherUserMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Load();
        
    }

    protected void Load()
    {
        String selectedRow_HospitalName = Session["selectedRow_HospitalName"].ToString();

        lblName.Visible = true;
        lblName.Text = selectedRow_HospitalName;
        lblNameLabel.Visible = false;

        lblType.Visible = true;
        lblType.Text = Session["selectedRow_HospitalType"].ToString();
        lblTypeLabel.Visible = false;

        lblAddress.Visible = false;
        lblHouseAdd.Visible = true;
        String selectedRow_HospitalHouseAddress = Session["selectedRow_HospitalHouseAddress"].ToString();
        lblHouseAdd.Text = selectedRow_HospitalHouseAddress;
        lblDistrict.Visible = true;
        lblDistrict.Text = Session["selectedRow_HospitalDistrict"].ToString();
        lblCity.Visible = true;
        lblCity.Text = Session["selectedRow_HospitalCity"].ToString();

        lblDescription.Visible = true;
        lblDescription.Text = Session["selectedRow_HospitalDescription"].ToString();
        lblDescriptionLabel.Visible = false;
    }

    protected void btnOk_Name_Click(object sender, EventArgs e)
    {
        if (txtboxName.Text != lblName.Text)
        {
            try
            {
                int hospitalId;
                HospitalClass hc = new HospitalClass();
                LogHospitalClass lhc = new LogHospitalClass();

                String hospitalIndivFieldLog_Operation = "Update";
                String hospitalIndivFieldLog_Field = "hospitalFullName";
                String hospitalIndivFieldLog_DataLater = txtboxName.Text;
                String hospitalIndivFieldLog_DataBefore = lblName.Text;

                /*Update Hospital's FullName on Hospital table
                Insert values on Log_HospitalIndivField table*/
                /*Getting HospitalId from HospitalName table*/
                DataTable dt = hc.SelectAllHospitalFromHospitalFullName(lblName.Text);
                if (dt.Rows.Count > 0)
                {
                    Session["hospitalId"] = dt.Rows[0]["hospitalId"].ToString();
                    hospitalId = Convert.ToInt32(Session["hospitalId"]);

                    hc.update_hospitalFullNameFrom_hospitalId(hospitalId, txtboxName.Text);
                    lhc.insertOn_Log_HospitalIndivField_WithUpdateOperation(hospitalIndivFieldLog_Operation,
                            hospitalId, hospitalIndivFieldLog_Field, hospitalIndivFieldLog_DataBefore,
                            hospitalIndivFieldLog_DataLater);
                }

            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                Session["selectedRow_HospitalName"] = txtboxName.Text;
                lblName.Text = txtboxName.Text;
                txtboxName.Visible = false;
                btnOk_Name.Visible = false;
            }
        }
    }
    protected void btnOk_Type_Click(object sender, EventArgs e)
    {
        if (dropdownlistType.SelectedValue != lblType.Text)
        {
            try
            {
                int hospitalId;
                HospitalClass hc = new HospitalClass();
                LogHospitalClass lhc = new LogHospitalClass();

                String hospitalIndivFieldLog_Operation = "Update";
                String hospitalIndivFieldLog_Field = "hospitalType";
                String hospitalIndivFieldLog_DataLater = dropdownlistType.SelectedValue;
                String hospitalIndivFieldLog_DataBefore = lblType.Text;

                /*Update Hospital's Type on Hospital table
                Insert values on Log_HospitalIndivField table*/
                /*Getting HospitalId from HospitalName table*/
                DataTable dt = hc.SelectAllHospitalFromHospitalFullName(Session["selectedRow_HospitalName"].ToString());
                if (dt.Rows.Count > 0)
                {
                    Session["hospitalId"] = dt.Rows[0]["hospitalId"].ToString();
                    hospitalId = Convert.ToInt32(Session["hospitalId"]);

                    hc.update_hospitalTypeFrom_hospitalId(hospitalId, dropdownlistType.Text);
                    lhc.insertOn_Log_HospitalIndivField_WithUpdateOperation(hospitalIndivFieldLog_Operation,
                            hospitalId, hospitalIndivFieldLog_Field, hospitalIndivFieldLog_DataBefore,
                            hospitalIndivFieldLog_DataLater);
                }

            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                Session["selectedRow_HospitalType"] = dropdownlistType.SelectedValue;
                lblType.Text = dropdownlistType.SelectedValue;
                dropdownlistType.Visible = false;
                btnOk_Type.Visible = false;
            }
        }
    }
    protected void btnOk_Address_Click(object sender, EventArgs e)
    {
        if (txtboxHouseAdd.Text != lblHouseAdd.Text ||
               txtboxDistrict.Text != lblDistrict.Text ||
               txtboxCity.Text != lblCity.Text)
        {try
        {
            int hospitalId;
            HospitalClass hc = new HospitalClass();
            LogHospitalClass lhc = new LogHospitalClass();

            String hospitalIndivFieldLog_Operation = "Update";
            String hospitalIndivFieldLog_Field = "hospitalAddress";
            String hospitalIndivFieldLog_DataLater = txtboxHouseAdd.Text
                + "; " + txtboxDistrict.Text
                + "; " + txtboxCity.Text;
            String hospitalIndivFieldLog_DataBefore = lblHouseAdd.Text
                + "; " + lblDistrict.Text
                + "; " + lblCity.Text; ;

            /*Update Hospital's Address on Hospital table
            Insert values on Log_HospitalIndivField table*/
            /*Getting HospitalId from HospitalName table*/
            DataTable dt = hc.SelectAllHospitalFromHospitalFullName(Session["selectedRow_HospitalName"].ToString());
            if (dt.Rows.Count > 0)
            {
                Session["hospitalId"] = dt.Rows[0]["hospitalId"].ToString();
                hospitalId = Convert.ToInt32(Session["hospitalId"]);

                hc.update_hospitalAddressFrom_hospitalId(hospitalId, txtboxHouseAdd.Text,
                    txtboxDistrict.Text, txtboxCity.Text);
                lhc.insertOn_Log_HospitalIndivField_WithUpdateOperation(hospitalIndivFieldLog_Operation,
                        hospitalId, hospitalIndivFieldLog_Field, hospitalIndivFieldLog_DataBefore,
                        hospitalIndivFieldLog_DataLater);
            }

        }
        catch (Exception ex)
        {
            ltrMessage.Text = ex.Message;
        }
        finally
        {
            Session["selectedRow_HospitalHouseAddress"] = txtboxHouseAdd.Text;
            Session["selectedRow_HospitalDistrict"] = txtboxDistrict.Text;
            Session["selectedRow_HospitalCity"] = txtboxCity.Text;
            lblHouseAdd.Text = txtboxHouseAdd.Text;
            lblDistrict.Text = txtboxDistrict.Text;
            lblCity.Text = txtboxCity.Text;
            txtboxHouseAdd.Visible = false;
            txtboxDistrict.Visible = false;
            txtboxCity.Visible = false;
            btnOk_Address.Visible = false;
        }}
    }
    protected void btnOk_Description_Click(object sender, EventArgs e)
    {
        if (txtboxDescription.Text != lblDescription.Text)
        {
            int hospitalId;
            HospitalClass hc = new HospitalClass();
            LogHospitalClass lhc = new LogHospitalClass();

            String hospitalIndivFieldLog_Operation = "Update";
            String hospitalIndivFieldLog_Field = "hospitalDescription";
            String hospitalIndivFieldLog_DataLater = txtboxDescription.Text;
            String hospitalIndivFieldLog_DataBefore = lblDescription.Text;

            try
            {

                /*Update Hospital's Description on Hospital table
                    Insert values on Log_HospitalIndivField table*/
                /*Getting HospitalId from HospitalName table*/
                DataTable dt = hc.SelectAllHospitalFromHospitalFullName(Session["selectedRow_HospitalName"].ToString());
                if (dt.Rows.Count > 0)
                {
                    Session["hospitalId"] = dt.Rows[0]["hospitalId"].ToString();
                    hospitalId = Convert.ToInt32(Session["hospitalId"]);

                    hc.update_hospitalDescriptionFrom_hospitalId(hospitalId, txtboxDescription.Text);
                    lhc.insertOn_Log_HospitalIndivField_WithUpdateOperation(hospitalIndivFieldLog_Operation,
                            hospitalId, hospitalIndivFieldLog_Field, hospitalIndivFieldLog_DataBefore,
                            hospitalIndivFieldLog_DataLater);
                }

            }
            catch (Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
            finally
            {
                Session["selectedRow_HospitalDescription"] = txtboxDescription.Text;
                lblDescription.Text = txtboxDescription.Text;
                lblDescription.Visible = true;
                txtboxDescription.Visible = false;
                btnOk_Description.Visible = false;
            }
        }
    }
    protected void lnkbtnEdit_Name_Click(object sender, EventArgs e)
    {
        lblName.Visible = false;
        lblType.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblDescription.Visible = true;

        lblNameLabel.Visible = true;
        lblTypeLabel.Visible = false;
        lblAddress.Visible = false;
        lblDescriptionLabel.Visible = false;


        txtboxName.Visible = true;
        btnOk_Name.Visible = true;
        dropdownlistType.Visible = false;
        btnOk_Type.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        btnOk_Address.Visible = false;
        txtboxDescription.Visible = false;
        btnOk_Description.Visible = false;

        txtboxName.Text = lblName.Text;

    }
    protected void lnkbtnEdit_Type_Click(object sender, EventArgs e)
    {
        lblName.Visible = true;
        lblType.Visible = false;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblDescription.Visible = true;

        lblNameLabel.Visible = false;
        lblTypeLabel.Visible = true;
        lblAddress.Visible = false;
        lblDescriptionLabel.Visible = false;


        txtboxName.Visible = false;
        btnOk_Name.Visible = false;
        dropdownlistType.Visible = true;
        btnOk_Type.Visible = true;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        btnOk_Address.Visible = false;
        txtboxDescription.Visible = false;
        btnOk_Description.Visible = false;

        dropdownlistType.SelectedValue = lblType.Text;

    }
    protected void lnkbtnEdit_Address_Click(object sender, EventArgs e)
    {
        lblName.Visible = true;
        lblType.Visible = true;
        lblHouseAdd.Visible = false;
        lblDistrict.Visible = false;
        lblCity.Visible = false;
        lblDescription.Visible = true;

        lblNameLabel.Visible = false;
        lblTypeLabel.Visible = false;
        lblAddress.Visible = true;
        lblDescriptionLabel.Visible = false;


        txtboxName.Visible = false;
        btnOk_Name.Visible = false;
        dropdownlistType.Visible = false;
        btnOk_Type.Visible = false;
        txtboxHouseAdd.Visible = true;
        txtboxDistrict.Visible = true;
        txtboxCity.Visible = true;
        btnOk_Address.Visible = true;
        txtboxDescription.Visible = false;
        btnOk_Description.Visible = false;

        txtboxHouseAdd.Text = lblHouseAdd.Text;
        txtboxDistrict.Text = lblDistrict.Text;
        txtboxCity.Text = lblCity.Text;

    }
    protected void lnkbtnEdit_Description_Click(object sender, EventArgs e)
    {
        lblName.Visible = true;
        lblType.Visible = true;
        lblHouseAdd.Visible = true;
        lblDistrict.Visible = true;
        lblCity.Visible = true;
        lblDescription.Visible = false;

        lblNameLabel.Visible = false;
        lblTypeLabel.Visible = false;
        lblAddress.Visible = false;
        lblDescriptionLabel.Visible = true;


        txtboxName.Visible = false;
        btnOk_Name.Visible = false;
        dropdownlistType.Visible = false;
        btnOk_Type.Visible = false;
        txtboxHouseAdd.Visible = false;
        txtboxDistrict.Visible = false;
        txtboxCity.Visible = false;
        btnOk_Address.Visible = false;
        txtboxDescription.Visible = true;
        btnOk_Description.Visible = true;

        if (lblDescription.Text == "&nbsp;") { txtboxDescription.Text = ""; }
        else { txtboxDescription.Text = lblDescription.Text; }

    }
}