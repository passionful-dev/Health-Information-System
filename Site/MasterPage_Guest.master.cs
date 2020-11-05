using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class HomeMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    setImageURL();
        //}
    }
    //protected void Timer1_Tick(object sender, EventArgs e)
    //{
    //    setImageURL();
    //}
    //private void setImageURL()
    //{
    //    Random rad = new Random();
    //    int i = rad.Next(1, 3);
    //    Image5.ImageUrl = "~/slider/" + i.ToString() + ".jpg";
    //}
}
