using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChatRoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = DateTime.Now.ToString();
        int P_int_current = Convert.ToInt32(Application["Current"]);
        Application.Lock();
        string P_str_chats = Application["Chats"].ToString();
        string[] P_str_chat = P_str_chats.Split(',');
        for (int i = P_str_chat.Length - 1; i >= 0; i--)
        {
            if (P_int_current == 0)
            {
                this.txtContex.Text = P_str_chat[i].ToString();
            }
            else
            {
                txtContex.Text = txtContex.Text + "\n" + P_str_chat[i].ToString();
            }
        }

        ArrayList ItemList = new ArrayList();
        string P_str_names;       //已在线的用户名
        string[] P_str_user;        //用户在线数组
        int P_int_num = Convert.ToInt32(Application["userNum"]);
        P_str_names = Application["user"].ToString();
        P_str_user = P_str_names.Split(',');
        for (int i = (P_int_num - 1); i >= 0; i--)
        {
            if (P_str_user[i].ToString() != "")
                ItemList.Add(P_str_user[i].ToString());
        }
        lbList.DataSource = ItemList;
        lbList.DataBind();
        Application.UnLock();
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        int P_count = Convert.ToInt32(Application["count"]);
        Application.Lock();
        if (P_count == 0 || P_count > 1000)
        {
            P_count = 0;
            Application["Chats"] = Session["userName"].ToString() + "说：" + txtMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
        }
        else
        {
            Application["Chats"] = Application["Chats"].ToString() + "," + Session["userName"].ToString() + "说：" + txtMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
        }
        P_count += 1;
        Application["current"] = P_count;
        Application.UnLock();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChatRoom.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://jw.qust.edu.cn/");

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("SScore.aspx");

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("PWDchange.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("InfomationCHANGE.aspx");

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentPage.aspx");


    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["IDnew"] = null;
        Session["pass"] = null;
        Session["name"] = null;
        Response.Redirect("Login.aspx");
    }

    protected void Button99_Click(object sender, EventArgs e)
    {
        Response.Redirect("留言板.aspx");
    }
}