using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VcCheckPoint : System.Web.UI.Page
{
    Users user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (Users)Session["user"];
        Label1.Text = user.FirstName + " " + user.LastName;
    }
}