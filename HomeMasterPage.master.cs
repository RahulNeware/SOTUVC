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
        Label1.Text = DateTime.Now.ToLongDateString();
        Literal1.Text = "© " + DateTime.Now.ToString("yyyy") + "	Privacy Policy";
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
