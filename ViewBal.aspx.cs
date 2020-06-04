using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewBal : System.Web.UI.Page
{
    Customers cm = new Customers();
    protected void Page_Load( object sender, EventArgs e)
    {
        cm.ID = Session["Id"].ToString ();
        cm.LoadCustomer();
        Label5.Text = "Rs. "+cm.Amt;
    }
}