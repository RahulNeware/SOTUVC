using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class TransDetails : System.Web.UI.Page
{
    Transaction t = new Transaction();
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Session["Id"].ToString();
        DataTable dt=t.GetTransDetails(s);
        TableCell[] cell = new TableCell[6];
        TableRow[] row = new TableRow[dt.Rows.Count];
        for (int i = 0; i < row.Length; i++)
        {
            row[i] = new TableRow();
            for (int j = 0; j < cell.Length; j++)
            {
                cell[j] = new TableCell();
            }
            cell[0].Text = (i + 1).ToString();
           string info="";
           if (dt.Rows[i][5].ToString().Equals(Session["Id"].ToString ()))
           {
               info = "transfer to account no.  " + dt.Rows[i][4];
               cell[3].Text = "-";
               cell[4].Text = dt.Rows[i][2].ToString();
               cell[5].Text = dt.Rows[i][7].ToString();
           }
           else
           {
               info = "credit by account no.  " + dt.Rows[i][5];
               cell[3].Text = dt.Rows[i][2].ToString();
               cell[4].Text = "-";
               cell[5].Text = dt.Rows[i][6].ToString();
           }
            cell[1].Text = info;
            cell[2].Text = Convert.ToDateTime (dt.Rows[i][3]).ToString ("dd-MM-yyyy");
            row[i].Cells.AddRange(cell);
        }
        Table1.Rows.AddRange(row);
    }
}