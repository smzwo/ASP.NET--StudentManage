<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PWDchange.aspx.cs" Inherits="PWDchange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image3" runat="server" Height="99px" ImageUrl="~/主页.png" Width="146px" />
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/登录后.png" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#000099" Height="52px" style="text-align: center">
            <asp:Button ID="Button2" runat="server" Text="科大主页" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="49px" OnClick="Button2_Click" Width="93px" />
            <asp:Button ID="Button1" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="49px" OnClick="Button1_Click" Text="成绩查询" Width="93px" />
            <asp:Button ID="Button3" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="49px" OnClick="Button3_Click" Text="信息修改" Width="93px" />
            <asp:Button ID="Button6" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="49px" OnClick="Button4_Click" Text="我的主页" Width="93px" />
            <asp:Button ID="Button7" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="49px" OnClick="Button22_Click" Text="聊天室" Width="93px" />
            <asp:Button ID="Button5" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="49px" OnClick="Button5_Click" Text="退出系统" Width="93px" />
        </asp:Panel>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/科大.png" />
        <asp:Panel ID="Panel2" runat="server" Height="340px" style="text-align: center" HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label1" runat="server" Text="姓名："></asp:Label>
            <asp:TextBox ID="Name5" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="账户："></asp:Label>
            <asp:TextBox ID="ID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="原密码："></asp:Label>
            <asp:TextBox ID="OP" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="新密码："></asp:Label>
            <asp:TextBox ID="NP" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="save" runat="server" Height="38px" OnClick="save_Click" Text="确定" Width="87px" />
        </asp:Panel>
    </form>
</body>
</html>
