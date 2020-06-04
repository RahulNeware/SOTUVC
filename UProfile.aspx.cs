using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UProfile : System.Web.UI.Page
{
    Customers cm = new Customers();

    protected void Page_Load(object sender, EventArgs e)
    {
        cm.ID = Session["Id"].ToString();
        cm.LoadCustomer();
        txtFirstName.Text = cm.FirstName;
        txtLastName.Text = cm.LastName;
        txtMobileNo.Text = cm.MobileNo;
        txtPincode.Text = cm.Pincode;
        txtAddress.Text = cm.Address ;
        txtCity.Text = cm.City;
        Label4.Text = "Saving";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        cm.FirstName = txtFirstName.Text;
        cm.LastName = txtLastName.Text;
        cm.Address = txtAddress.Text;
        cm.City = txtCity.Text;
        cm.Pincode = txtPincode.Text;
        cm.MobileNo = txtMobileNo.Text;
      
        cm.Update ();
    }
}