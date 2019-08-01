using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public partial class InfomationCHANGE : System.Web.UI.Page
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
        conn.Close();
        SaddressBox.ReadOnly = true;
        StellBox.ReadOnly = true;
        SqqBox.ReadOnly = true;



        btnChange.Visible = true;

        saveBtn.Visible = false;
    }

    protected void btnChange_Click(object sender, EventArgs e)
    {
        ////SnoBox.ReadOnly = false;
        //SnameBox.ReadOnly = false;
        //SexBox.ReadOnly = false;
        SaddressBox.ReadOnly = false;
        StellBox.ReadOnly = false;
        SqqBox.ReadOnly = false;



        btnChange.Visible = false;

        saveBtn.Visible = true;
        // One = true;

    }

    protected void saveBtn_Click(object sender, EventArgs e)
    {
        //SnoBox.ReadOnly = false;
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=课设; Integrated Security=True");
        string sqltext = "Insert_Student";
        SqlCommand cmd = new SqlCommand(sqltext, con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] p = { new SqlParameter("@Sno", SqlDbType.Char), new SqlParameter("@Sname", SqlDbType.VarChar), new SqlParameter("@Ssex", SqlDbType.Char), new SqlParameter("@Saddress", SqlDbType.VarChar), new SqlParameter("@Stell", SqlDbType.Char), new SqlParameter("@Sqq", SqlDbType.Char), new SqlParameter("@rtn", SqlDbType.Int) };
        p[0].Value = Session["IDnew"].ToString();
        p[1].Value = SnameBox.Text.ToString().Trim();
        p[2].Value = SexBox.Text.ToString().Trim();
        p[3].Value = SaddressBox.Text.ToString().Trim();
        p[4].Value = StellBox.Text.ToString().Trim();
        p[5].Value = SqqBox.Text.ToString().Trim();
        p[6].Value = 0;
        p[0].Direction = ParameterDirection.Input;
        p[1].Direction = ParameterDirection.Input;
        p[2].Direction = ParameterDirection.Input;
        p[3].Direction = ParameterDirection.Input;
        p[4].Direction = ParameterDirection.Input;
        p[5].Direction = ParameterDirection.Input;
        p[6].Direction = ParameterDirection.Output;

        foreach (SqlParameter pm in p)
        {
            cmd.Parameters.Add(pm);
        }
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('修改成功')</script>");
       // MessageBox.Show("修改成功！");

        Response.Redirect("InfomationCHANGE.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://jw.qust.edu.cn/");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SScore.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentPage.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("PWDchange.aspx");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Session["IDnew"] = null;
        Session["pass"] = null;
        Session["name"] = null;

        Response.Redirect("Login.aspx");

    }

    protected void Button22_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChatRoom.aspx");

    }
}