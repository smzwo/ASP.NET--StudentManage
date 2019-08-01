<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminForStu.aspx.cs" Inherits="AdminForStu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image1" runat="server" Height="96px" ImageUrl="~/主页.png" Width="138px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/登录后.png" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#000099" Height="48px" style="text-align: center">
            <asp:Button ID="管理员主页" runat="server" Text="管理员主页" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="48px" OnClick="管理员主页_Click" Width="111px" />
            <asp:Button ID="Button1" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="48px" OnClick="Button1_Click" Text="学生信息管理" Width="111px" />
            <asp:Button ID="Button3" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="48px" OnClick="Button3_Click" Text="退出系统" Width="111px" />
        </asp:Panel>
        <asp:Image ID="Image3" runat="server" ImageUrl="~/科大.png" />
        <asp:Panel ID="Panel2" runat="server" Height="264px" style="text-align: center" HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label1" runat="server" Text="添加学生信息"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="学号："></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label4" runat="server" Text="姓名："></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="性别："></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label5" runat="server" Text="宿舍："></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="电话："></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label7" runat="server" Text="QQ/微信："></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="AddBtn" runat="server" Height="36px" OnClick="AddBtn_Click" Text="添加" Width="67px" />
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="322px" style="text-align: center" HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label8" runat="server" Text="学生用户"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="账号："></asp:Label>
            <asp:TextBox ID="sIDBox" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Label ID="Label9" runat="server" Text="姓名："></asp:Label>
            <asp:TextBox ID="sNameBox" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Label ID="Label11" runat="server" Text="密码："></asp:Label>
            <asp:TextBox ID="sPasswdBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okBtn" runat="server" OnClick="okBtn_Click" Text="添加" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="cancelBtn" runat="server" OnClick="cancelBtn_Click" Text="重置" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="DelBtn" runat="server" OnClick="DelBtn_Click" Text="删除" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="1163px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="Sno" HeaderText="账号" />
                    <asp:BoundField DataField="Sname" HeaderText="姓名" />
                    <asp:BoundField DataField="Spassword" HeaderText="密码" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
