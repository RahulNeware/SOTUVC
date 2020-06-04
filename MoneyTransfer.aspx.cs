using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MoneyTransfer : System.Web.UI.Page
{
    Users user;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            
            Button1.Visible = false;
            Label4.Text = "";
        }
        user = (Users)Session["user"];
      
        
    }
    Transaction t = new Transaction();
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (t.cmTo.ContainId(TextBox1.Text))
        {
        t.cmFrom.ID = Session["Id"].ToString();
        t.cmTo.ID = TextBox1.Text;
        t.cmFrom.LoadCustomer();
        t.cmTo.LoadCustomer();
        
        }
        else
        {
            MsgBox.Show(this, "Account Number does not exist or Invalid Account Number!");
        }
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            t.cmFrom.ID = Session["Id"].ToString();
            t.cmTo.ID = TextBox1.Text;
            t.cmFrom.LoadCustomer();
            t.cmTo.LoadCustomer();

            t.Amt = Convert.ToDouble(TextBox2.Text);
            if ((t.cmFrom.Amt - t.Amt) >= 0)
            {
                t.DoTransaction();
                MsgBox.Show(this, " Transaction Successfully Done");
                Image2.ImageUrl = "";
               
            }
            else
            {
                MsgBox.Show(this, " Balance for this transaction");
            }
            Label4.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            Button1.Visible = false;
        
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
           MsgBox.Show(this, " Choose file first before upload");
        }
        
    }
    Customers cm = new Customers();
    VisualCrypto vc = new VisualCrypto();
    public void CheckImg()
    {
        cm = new Customers();
        cm.ID = Session["Id"].ToString();
        cm.LoadCustomer();
        if (Image2.ImageUrl == "" && Session["ch"] == null)
        {
            MsgBox.Show(this, " Upload your visual cryptography image file first before verify");
        }
        else
        {
            string Path1 = Server.MapPath("~/tmp1/") + Session["ImgName"];
            string Path2 = Server.MapPath("~/UserImg/") + user.Id+"2.jpeg";

            if (vc.CheckPoint(Path1, Path2).Equals(user.SecretCode))
            {
                t.cmFrom.ID = Session["Id"].ToString();
                t.cmTo.ID = TextBox1.Text;
                t.cmFrom.LoadCustomer();
                t.cmTo.LoadCustomer();
                Label4.Text = "Are you sure want to transfer money to this account :<br>" +
                    "Account Holder Name :" + t.cmTo.FirstName + " " + t.cmTo.LastName + "<br>" +
                    "Account No. :" + t.cmTo.ID;
                Button1.Visible = true;
            }
            else
            {
                MsgBox.Show(this, "Invalid Image");
            }

        }
    }
    protected void btnVerify_Click(object sender, EventArgs e)
    {
        CheckImg();
    }
}