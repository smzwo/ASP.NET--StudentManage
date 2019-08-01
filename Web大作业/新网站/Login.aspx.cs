using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class Login : System.Web.UI.Page
{
    static public string name;
    static public string welcome;
    protected void Page_Load(object sender, EventArgs e)
    {
        //光标换行
        IDBox.TabIndex = 0;
        passwdBox.TabIndex = 1;
        int P_int_judge = 0;
        P_int_judge = Convert.ToInt32(Request["value"]);
        if (!IsPostBack)
        {
            if (P_int_judge == 1)
                Response.Write("<script>alert('该用户已经登录！')</script>");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string strsql_query = "";
        if (IDBox.Text != string.Empty && passwdBox.Text != string.Empty)
        {

            string ID2 = IDBox.Text.Trim().ToString();
            string passwd = passwdBox.Text.Trim().ToString();

            string strcon = "Data Source=(local);Initial Catalog=课设;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);

            conn.Open();
            if (stuButton.Checked)
            {
                strsql_query = string.Format("select * from Tb_SLogin where  Sno='{0}' and Spassword='{1}'", ID2, passwd);
            }
            else if (adminButton.Checked)
            {
                strsql_query = string.Format("select * from Tb_Admin where  id='{0}' and Password='{1}'", ID2, passwd);
            }
            SqlCommand cmd_query = new SqlCommand(strsql_query, conn);
            SqlDataReader dr = cmd_query.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                if (stuButton.Checked)
                {
                   Login.name = dr["Sname"].ToString();

                    welcome = "欢迎  " + name + "  同学登录本系统";
                    Session["name"] = name;
                }
                else if (adminButton.Checked)
                {
                    Login.name = dr["id"].ToString();
                }
                dr.Close();


                if (stuButton.Checked)
                {
                    Session["pass"] = passwd;
                    Session["IDnew"] = ID2;
                   
                    Response.Write(welcome);
                   // MessageBox.Show(welcome);

                    Application.Lock();
                    int P_int_num;     //在线人数
                    string P_str_name; //登录用户
                    string P_str_names;  //已在线的用户名
                    string[] P_str_user; //用户在线数组
                    P_int_num = int.Parse(Application["userNum"].ToString());


                    P_str_name = IDBox.Text.Trim();
                    P_str_names = Application["user"].ToString();
                    P_str_user = P_str_names.Split(',');
                    for (int i = 0; i <= P_int_num - 1; i++)
                    {
                        if (P_str_name == P_str_user[i].Trim())
                        {
                            int P_int_judge = 1;
                            Response.Redirect("Login.aspx?value=" + P_int_judge);
                        }
                    }
                    if (P_int_num == 0)
                        Application["user"] = P_str_name.ToString();
                    else
                        Application["user"] = Application["user"] + "," + P_str_name.ToString();
                    P_int_num += 1;
                    Application["userNum"] = P_int_num;
                    Session["userName"] = IDBox.Text.Trim();
                    Application.UnLock();


                    Response.Redirect("StudentPage.aspx");

                    
                    
                }
                else
                {
                    //adminPage main = new adminPage();
                    // main.Show();
                    Response.Redirect("AdminPage.aspx");
                }
                Visible = false;
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误')</script>");
             //   MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwdBox.Focus();
            }
        }
        else
        {
            Response.Write("<script>alert('用户名或密码不能为空')</script>");
            //MessageBox.Show("用户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        IDBox.Text = "";
        passwdBox.Text = "";
        Application.RemoveAll();
        Session.Abandon();
    }
}