using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class StudentPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Sno = Session["IDnew"].ToString();
        //MessageBox.Show(Sno);//测试有没有传过来
        string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
        SqlConnection conn = new SqlConnection(strcon);
        conn.Open();
        SnoBox.Text = Session["IDnew"].ToString();
        string strsql1 = string.Format("select Sname from Tb_Student where Sno='{0}'", Sno);
        SqlCommand SNAME = new SqlCommand(strsql1, conn);
        SnameBox.Text = SNAME.ExecuteScalar().ToString().Trim();
        string strsql2 = string.Format("select Ssex from Tb_Student where Sno='{0}'", Sno);
        SqlCommand SEX = new SqlCommand(strsql2, conn);
        SexBox.Text = SEX.ExecuteScalar().ToString().Trim();
        string strsql3 = string.Format("select Saddress from Tb_Student where Sno='{0}'", Sno);
        SqlCommand SAD = new SqlCommand(strsql3, conn);
        SaddressBox.Text = SAD.ExecuteScalar().ToString().Trim();
        string strsql4 = string.Format("select Stell from Tb_Student where Sno='{0}'", Sno);
        SqlCommand STEL = new SqlCommand(strsql4, conn);
        StellBox.Text = STEL.ExecuteScalar().ToString().Trim();
        string strsql5 = string.Format("select Sqq from Tb_Student where Sno='{0}'", Sno);
        SqlCommand SQQ = new SqlCommand(strsql5, conn);
        SqqBox.Text = SQQ.ExecuteScalar().ToString().Trim();
        conn.Close();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://jw.qust.edu.cn/jwglxt.htm");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://jw.qust.edu.cn/jwglxt.htm");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://jw.qust.edu.cn/");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["IDnew"] = null;
        Session["pass"] = null;
        Session["name"] = null;

        Response.Redirect("Login.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("InfomationCHANGE.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("SScore.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("PWDchange.aspx");
    }
    protected void Button91_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChatRoom.aspx");
    }
}