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

public partial class AdminPage : System.Web.UI.Page
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
        GridView1.DataKeyNames = new string[] { "Sno"};
    }
    public void selCourse2(string sqlStr)
    {
        string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";


        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand(sqlStr, conn);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        conn.Open();
        da.Fill(ds);
        conn.Close();
        GridView2.DataSource = ds.Tables[0].DefaultView;
        GridView2.DataBind();
    }
    public void selCourse3(string sqlStr)
    {
        string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";


        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand(sqlStr, conn);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        conn.Open();
        da.Fill(ds);
        conn.Close();
        GridView3.DataSource = ds.Tables[0].DefaultView;
        GridView3.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //第一部分
        selCourse("select * from Tb_Student");
        //第二部分

        string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";
        DropDownList1.Items.Add("");
        DropDownList2.Items.Add("");
        SqlConnection conn = new SqlConnection(strcon);
        SqlConnection conn2 = new SqlConnection(strcon);
        conn.Open();
        conn2.Open();

        SqlCommand comm = new SqlCommand("select distinct(Cyear) from Tb_Course", conn);
        SqlDataReader reader = comm.ExecuteReader();
        while (reader.Read())
        {

            DropDownList1.Items.Add(reader.GetString(0));
        }


        SqlCommand comm2 = new SqlCommand("select distinct(Cyear) from Tb_Course", conn2);
        SqlDataReader reader2 = comm2.ExecuteReader();
        while (reader2.Read())
        {

            DropDownList2.Items.Add(reader2.GetString(0));
        }

        conn.Close();
        conn2.Close();
        selCourse2("select * from Tb_Course");
        ////第三部分


        SqlConnection conn3 = new SqlConnection(strcon);
        SqlConnection conn4 = new SqlConnection(strcon);
        DropDownList3.Items.Add("");
        DropDownList4.Items.Add("");
        conn3.Open();
        conn4.Open();

        SqlCommand comm3 = new SqlCommand("select distinct(Cyear) from Tb_Course2", conn3);
        SqlDataReader reader3 = comm3.ExecuteReader();
        SqlCommand comm4 = new SqlCommand("select distinct(Cterm) from Tb_Course2", conn4);
        SqlDataReader reader4 = comm4.ExecuteReader();
        while (reader3.Read())
        {
            DropDownList3.Items.Add(reader3.GetString(0));
        }
        while (reader4.Read())
        {
            DropDownList4.Items.Add(reader4.GetString(0));
        }

        conn3.Close();
        conn4.Close();
        selCourse3("select * from Tb_Course2");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string courseYear = DropDownList1.SelectedItem.Text.ToString();
        string courseTerm = DropDownList2.SelectedItem.Text.ToString();
        if (courseYear == "" && courseTerm == "")
        {
            Button1.Text = "查询全部";
        }
        else
        {
            Button1.Text = "查询";
        }
        if (courseYear == "" && courseTerm == "")
        {
            selCourse2("select * from Tb_Course ");
        }
        else if (courseYear != "" && courseTerm == "")
        {
            selCourse2(string.Format("select * from Tb_Course where Cyear='{0}'", courseYear));
        }
        else if (courseYear == "" && courseTerm != "")
        {
            selCourse2(string.Format("select * from Tb_Course where Cterm='{0}'", courseTerm));
        }
        else
        {
            selCourse2(string.Format("select * from Tb_Course where Cyear='{0}'and Cterm='{1}'", courseYear, courseTerm));
        }
    }

    protected void btnSelect_Click(object sender, EventArgs e)
    {
        string courseYear = DropDownList3.SelectedItem.Text.ToString();
        string courseTerm = DropDownList4.SelectedItem.Text.ToString();
        string sno = TextBox1.Text.Trim().ToString();
        if (courseYear == "" && courseTerm == "" && sno == "")
        {
            selCourse3("select Cno,Cname,Sno_C,Ccredit,Cscore from Tb_Course2 ");
        }
        else if (courseYear != "" && courseTerm == "" && sno == "")
        {
            selCourse3(string.Format("select Cno,Cname,Sno_C,Ccredit,Cscore from Tb_Course2 where Cyear='{0}'", courseYear));
        }
        else if (courseYear != "" && courseTerm == "" && sno != "")
        {
            selCourse3(string.Format("select Cno,Cname,Sno_C,Ccredit,Cscore from Tb_Course2 where Cyear='{0}' and  Sno_C='{1}'", courseYear, sno));
        }
        else if (courseYear == "" && courseTerm == "" && sno != "")
        {
            selCourse3(string.Format("select Cno,Cname,Sno_C,Ccredit,Cscore from Tb_Course2 where Sno_C='{0}'", sno));
        }
        else if (courseYear != "" && courseTerm != "" && sno == "")
        {
            selCourse3(string.Format("select Cno,Cname,Sno_C,Ccredit,Cscore  from Tb_Course2 where Cyear='{0}'and Cterm='{1}'", courseYear, courseTerm));
        }
        else if (courseYear != "" && courseTerm != "" && sno != "")
        {
            selCourse3(string.Format("select Cno,Cname,Sno_C,Ccredit,Cscore  from Tb_Course2 where Cyear='{0}'and Cterm='{1}' and Sno_C='{2}'", courseYear, courseTerm, sno));
        }
        else
        {
            Response.Write("<script>alert('条件错误')</script>");
          //  MessageBox.Show("条件错误");
        }
    }

    protected void 管理员主页1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminForStu.aspx");
    }

    protected void 管理员主页0_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminPage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }

    protected void GridView3_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        GridView3.DataBind();
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView2_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataBind();
    }

    protected void delBtn_Click(object sender, EventArgs e)
    {
        if (sIDBox.Text == "")
        {
            Response.Write("<script>alert('请输入内容！')</script>");
           // MessageBox.Show("请输入内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            string sID = sIDBox.Text.Trim();
            string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";//建立连接
            SqlConnection conn = new SqlConnection(strcon);
            //打开连接
            conn.Open();
            string strsql_insert = string.Format("delete from Tb_Student where Sno='{0}'", sID);
            SqlCommand cmd2 = new SqlCommand(strsql_insert, conn);
            cmd2.ExecuteNonQuery();
            selCourse("select * from Tb_Student");
            conn.Close();
            Response.Write("<script>alert('删除成功！')</script>");

           // MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
    {

    }

    protected void GridView1_RowUpdated(object sender, System.Web.UI.WebControls.GridViewUpdatedEventArgs e)
    {
        
    }

    protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
    {
        //GridView1.Columns[1].ExtractValuesFromCell(e.Keys,row)
        //String me = GridView1.DataKeys[e.RowIndex].Value.ToString();
        ////// Response.Write(me);
        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=课设; Integrated Security=True");
        //string sqltext = "Insert_Student";
        //SqlCommand cmd = new SqlCommand(sqltext, con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //SqlParameter[] p = { new SqlParameter("@Sno", SqlDbType.Char), new SqlParameter("@Sname", SqlDbType.VarChar), new SqlParameter("@Ssex", SqlDbType.Char), new SqlParameter("@Saddress", SqlDbType.VarChar), new SqlParameter("@Stell", SqlDbType.Char), new SqlParameter("@Sqq", SqlDbType.Char), new SqlParameter("@rtn", SqlDbType.Int) };
        //p[0].Value = me;
        ////GridView1.da
        //p[1].Value = GridView1.DataKeys[e.RowIndex].Values[1].ToString();
        //p[2].Value = GridView1.DataKeys[e.RowIndex].Values[2].ToString();
        //p[3].Value = GridView1.DataKeys[e.RowIndex].Values[3].ToString();
        //p[4].Value = GridView1.DataKeys[e.RowIndex].Values[4].ToString();
        //p[5].Value = GridView1.DataKeys[e.RowIndex].Values[5].ToString();
        //p[6].Value = 0;
        //p[0].Direction = ParameterDirection.Input;
        //p[1].Direction = ParameterDirection.Input;
        //p[2].Direction = ParameterDirection.Input;
        //p[3].Direction = ParameterDirection.Input;
        //p[4].Direction = ParameterDirection.Input;
        //p[5].Direction = ParameterDirection.Input;
        //p[6].Direction = ParameterDirection.Output;

        //foreach (SqlParameter pm in p)
        //{
        //    cmd.Parameters.Add(pm);
        //}
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        //this.GridView1.EditIndex = -1;
        //selCourse("select * from Tb_Student");

        // Response.Redirect("InfomationCHANGE.aspx");
    }

    protected void GridView1_RowUpdated1(object sender, System.Web.UI.WebControls.GridViewUpdatedEventArgs e)
    {
     //   Response.Redirect("AdminPage.aspx");
    }
}