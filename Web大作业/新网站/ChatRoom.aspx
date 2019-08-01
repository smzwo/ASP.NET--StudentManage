<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChatRoom.aspx.cs" Inherits="ChatRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            margin-bottom: 20px;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="98px" ImageUrl="~/主页.png" Width="106px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/登录后.png" />
        <asp:Panel ID="Panel1" runat="server" BackColor="#000099" Height="52px" HorizontalAlign="Center">
            <asp:Button ID="Button2" runat="server" Text="科大主页" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="50px" OnClick="Button2_Click" Width="98px" />
            <asp:Button ID="Button3" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="50px" OnClick="Button3_Click" Text="成绩查询" Width="98px" />
            <asp:Button ID="Button1" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="50px" OnClick="Button1_Click" Text="信息修改" Width="98px" />
            <asp:Button ID="Button4" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="50px" OnClick="Button4_Click" Text="密码修改" Width="98px" />
            <asp:Button ID="Button8" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="50px" OnClick="Button5_Click" Text="我的主页" Width="98px" />
            <asp:Button ID="Button5" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="50px" OnClick="Button99_Click" Text="留言板" Width="98px" />
            <asp:Button ID="Button6" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="50px" OnClick="Button6_Click" Text="退出系统" Width="98px" />
        </asp:Panel>
        <asp:Image ID="Image3" runat="server" Height="309px" ImageUrl="~/科大.png" Width="1151px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 聊天窗口&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 在线用户<br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <asp:Timer ID="Timer1" runat="server" Interval="1000">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:TextBox ID="txtContex" runat="server" Height="342px" TextMode="MultiLine" Width="979px" style="text-align: center"></asp:TextBox>
        <asp:ListBox ID="lbList" runat="server" Height="344px" Width="170px"></asp:ListBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="请输入内容："></asp:Label>
        <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
        <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="发送" />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="刷新" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
