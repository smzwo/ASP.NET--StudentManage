using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class 留言板 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Panel2.Visible = false;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentPage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        this.DataList1.Visible = false;
        this.Panel2.Visible = true;

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        String usename = Session["IDnew"].ToString();
        String neirong = TextBox1.Text.ToString();
        String when = DateTime.Now.ToString();
        string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
        SqlConnection conn = new SqlConnection(strcon);
        conn.Open();
        if (neirong.Length > 300)
        {
            RequiredFieldValidator1.Visible = true;
        }
        else if (neirong != "")
        {
            string strsql = string.Format("insert into 留言板(UserName,time,context) values  ('{0}','{1}','{2}')", usename, when, neirong);
            SqlCommand cmd = new SqlCommand(strsql, conn);
            int k = cmd.ExecuteNonQuery();
            if (k!= 0)
            {
                this.DataList1.Visible = true;
                this.Panel2.Visible = false;
            }

        }
        conn.Close();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("留言板.aspx");
    }
}