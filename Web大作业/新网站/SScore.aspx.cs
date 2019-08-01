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

public partial class SScore : System.Web.UI.Page
{
    public void selCourse(string sqlStr)
    {
        string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";


        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand(sqlStr, conn);
        conn.Open();
        SqlDataReader sdr = cmd.ExecuteReader();
        GridView1.DataSource = sdr;
        GridView1.DataBind();
        conn.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string Sno = Session["IDnew"].ToString();
        string strcon = "Data Source=(local);Initial Catalog=课设; Integrated Security=True";
        DropDownList1.Items.Add("");
        DropDownList2.Items.Add("");
        SqlConnection conn = new SqlConnection(strcon);
        SqlConnection conn2 = new SqlConnection(strcon);
        conn.Open();
        conn2.Open();

        SqlCommand comm = new SqlCommand("select distinct(CYEAR) from ScoreSearch", conn);
        SqlDataReader reader = comm.ExecuteReader();
        while (reader.Read())
        {
            
            DropDownList1.Items.Add(reader.GetString(0));
        }


        SqlCommand comm2 = new SqlCommand("select distinct(CTERM) from ScoreSearch", conn2);
        SqlDataReader reader2 = comm2.ExecuteReader();
        while (reader2.Read())
        {
            
            DropDownList2.Items.Add(reader2.GetString(0));
        }

        conn.Close();
        conn2.Close();
        selCourse(string.Format("select CNO,CNAME,CYEAR,CTERM,CCREDIT,CNATURE,SCORE from ScoreSearch where SNO='{0}'", Sno));

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        //union all
        string Sno = Session["IDnew"].ToString();
        //检测是否传入正确值MessageBox.Show(Sno);
        string search = "CNO,CNAME,CYEAR,CTERM,CCREDIT,CNATURE,SCORE";
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

            selCourse(string.Format("select " + search + "  from ScoreSearch where SNO='{0}'", Sno));
        }
        else if (courseYear != "" && courseTerm == "")
        {
            selCourse(string.Format("select " + search + " from ScoreSearch where CYEAR='{0}' and SNO='{1}'", courseYear, Sno));
        }
        else if (courseYear == "" && courseTerm != "")
        {
            selCourse(string.Format("select " + search + "  from ScoreSearch where CTERM='{0}' and SNO='{1}'", courseTerm, Sno));
        }
        else
        {
            selCourse(string.Format("select " + search + "  from ScoreSearch where CYEAR='{0}'and CTERM='{1}' and SNO='{2}'", courseYear, courseTerm, Sno));
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://jw.qust.edu.cn/");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentPage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("InfomationCHANGE.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("PWDchange.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
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