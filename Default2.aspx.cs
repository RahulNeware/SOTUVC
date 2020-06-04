using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       Label1.Text = Server.MapPath("~/tmp/");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
        string fileName = "11.jpeg";
        Response.ContentType = "application/octet-stream";
        Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
        Response.TransmitFile(Server.MapPath("~/tmp/" + fileName));
        Response.End();
    }
}