using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VCCheckTool : System.Web.UI.UserControl
{
    Customers cm = new Customers();
    Users user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (Users)Session["user"];
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/tmp1") + "/" + FileUpload1.FileName);
            Session["ImgName"] = FileUpload1.FileName;
            Image2.ImageUrl = "~/tmp1/" + Session["ImgName"];
        }
        else
        {
            MsgBox.Show (this, "Choose file first before upload.");
        }
    }
    
    VisualCrypto vc = new VisualCrypto();
    public void CheckImg()
    {
        cm = new Customers();
        cm.ID = Session["Id"].ToString();
        cm.LoadCustomer();
        if (Image2.ImageUrl == "" && Session["ch"] == null)
        {
            MsgBox.Show (this,"Upload your visual cryptography image file first before verify.");
        }
        else
        {
            string Path1 = Server.MapPath("~/tmp1/") + Session["ImgName"];
            string Path2 = Server.MapPath("~/UserImg/") + user.Id + "2.jpeg";
            
                if (vc.CheckPoint(Path1, Path2).Equals (user.SecretCode ))
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Session.Clear();
                    Response.Redirect("Login.aspx");
                }
           
        }
    }
    protected void btnVerify_Click(object sender, EventArgs e)
    {
        CheckImg();
    }
}