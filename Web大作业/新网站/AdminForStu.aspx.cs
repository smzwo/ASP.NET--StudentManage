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

public partial class AdminForStu : System.Web.UI.Page
{
    public void selCourse(string sqlStr)
    {
        string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";


        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand(sqlStr, conn);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        conn.Open();
        da.Fill(ds);
        conn.Close();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        selCourse("select * from Tb_SLogin");
        if(this.IsPostBack==false)
        {
            TextBox7.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        if(TextBox7.Text.ToString() == ""&&TextBox2.Text == ""&& TextBox3.Text == ""&&TextBox4.Text == ""&&TextBox5.Text.ToString() == ""&&TextBox6.Text== "")
        {
            Response.Write("<script>alert('请输入信息')</script>");
        }
        else
        {
            //Response.Write(TextBox7.Text.ToString());
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=课设; Integrated Security=True");
            string sqltext = "Insert_Student";
            SqlCommand cmd = new SqlCommand(sqltext, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] p = { new SqlParameter("@Sno", SqlDbType.Char), new SqlParameter("@Sname", SqlDbType.VarChar), new SqlParameter("@Ssex", SqlDbType.Char), new SqlParameter("@Saddress", SqlDbType.VarChar), new SqlParameter("@Stell", SqlDbType.Char), new SqlParameter("@Sqq", SqlDbType.Char), new SqlParameter("@rtn", SqlDbType.Int) };
            p[0].Value = this.TextBox7.Text.ToString().Trim();
            p[1].Value = TextBox2.Text.ToString().Trim();
            p[2].Value = TextBox3.Text.ToString().Trim();
            p[3].Value = TextBox4.Text.ToString().Trim();
            p[4].Value = TextBox5.Text.ToString().Trim();
            p[5].Value = TextBox6.Text.ToString().Trim();
            // p[6].Value = 0;
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
            Response.Write("成功！");
        }


        // MessageBox.Show("添加成功");

    }

    protected void okBtn_Click(object sender, EventArgs e)
    {
        if (sIDBox.Text == "" || sPasswdBox.Text == "" || sNameBox.Text == "")
        {
            Response.Write("<script>alert('请输入内容')</script>");

        //    MessageBox.Show("请输入内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            string sID = sIDBox.Text.Trim();
            string sName = sNameBox.Text.Trim();
            string sPasswd = sPasswdBox.Text.Trim();

            string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";//建立连接
            SqlConnection conn = new SqlConnection(strcon);
            //打开连接
            conn.Open();
            string strsql_query = string.Format("select * from Tb_SLogin where Sno='{0}'", sID);
            SqlCommand cmd_query = new SqlCommand(strsql_query, conn);

            SqlDataReader dr = cmd_query.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script>alert('该学生已存在')</script>");

              //  MessageBox.Show("该课学生已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
            }
            else
            {
                dr.Close();
                string strsql_insert = string.Format("insert into Tb_SLogin(Sno,Sname,Spassword) values('{0}','{1}','{2}')", sID, sName, sPasswd);
                SqlCommand cmd2 = new SqlCommand(strsql_insert, conn);
                cmd2.ExecuteNonQuery();
                selCourse("select * from Tb_SLogin");
                Response.Write("<script>alert('插入成功！')</script>");

               // MessageBox.Show("插入成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        sIDBox.Text = "";
        sPasswdBox.Text = "";
        sNameBox.Text = "";
    }

    protected void cancelBtn_Click(object sender, EventArgs e)
    {
        sIDBox.Text = "";
        sPasswdBox.Text = "";
        sNameBox.Text = "";
    }

    protected void 管理员主页_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminPage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminForStu.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");

    }

    protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }



    protected void DelBtn_Click(object sender, EventArgs e)
    {
        if (sIDBox.Text == "")
        {
            Response.Write("<script>alert('请输入内容')</script>");

            //MessageBox.Show("请输入内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            string sID = sIDBox.Text.Trim();
            string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";//建立连接
            SqlConnection conn = new SqlConnection(strcon);
            //打开连接
            conn.Open();
                string strsql_insert = string.Format("delete from Tb_SLogin where Sno='{0}'", sID);
                SqlCommand cmd2 = new SqlCommand(strsql_insert, conn);
                cmd2.ExecuteNonQuery();
                selCourse("select * from Tb_SLogin");
            conn.Close();
            Response.Write("<script>alert('删除成功')</script>");

            //MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}