using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class PWDchange : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Name5.Text = Session["name"].ToString();
    }

    protected void save_Click(object sender, EventArgs e)
    {
        string id = ID.Text.Trim().ToString();
        string old = OP.Text.Trim().ToString();
        string np = NP.Text.Trim().ToString();
        //string strsql_query = "";
        string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
        SqlConnection conn = new SqlConnection(strcon);
        conn.Open();
        if (ID.Text != string.Empty && OP.Text != string.Empty && NP.Text != string.Empty)
        {
            //MessageBox.Show(Login.IDnew+Login.pass);调试数值有没有传过来
            if (id == Session["IDnew"].ToString() && old == Session["pass"].ToString())
            {

                //SqlCommand cmd_query = new SqlCommand(strsql_query, conn);
                string strsql = string.Format("update Tb_SLogin set  Spassword='{0}' where Sno='{1}'and Sname='{2}'", np, id, Session["name"].ToString());
                SqlCommand cmd = new SqlCommand(strsql, conn);
                cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() != 0)
                {
                    Response.Write("<script>alert('修改成功')</script>");
                   // MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response.Write("<script>alert('修改失败')</script>");

                   // MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Response.Write("<script>alert('请输入原始账号和密码')</script>");

                //MessageBox.Show("请正确输入原始账号、密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://jw.qust.edu.cn/");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SScore.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("InfomationCHANGE.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentPage.aspx");

    }

    protected void Button5_Click(object sender, EventArgs e)
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