<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InfomationCHANGE.aspx.cs" Inherits="InfomationCHANGE" %>

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
<body style="height: 785px">
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image3" runat="server" Height="95px" ImageUrl="~/主页.png" Width="130px" />
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/登录后.png" />
        <asp:Panel ID="Panel2" runat="server" BackColor="#000099" Height="46px">
            <asp:Button ID="Button6" runat="server" Text="科大主页" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="42px" Width="119px" OnClick="Button6_Click" />
            <asp:Button ID="Button2" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="42px" Text="成绩查询" Width="119px" OnClick="Button2_Click" />
            <asp:Button ID="Button7" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="42px" Text="我的主页" Width="119px" OnClick="Button7_Click" />
            <asp:Button ID="Button10" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="42px" Text="密码修改" Width="119px" OnClick="Button8_Click" />
            <asp:Button ID="Button11" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="42px" OnClick="Button22_Click" Text="聊天室" Width="119px" />
            <asp:Button ID="Button9" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="42px" Text="退出系统" Width="119px" OnClick="Button9_Click" />
        </asp:Panel>
    
    </div>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/科大.png" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="我的个人信息"></asp:Label>
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="369px" HorizontalAlign="Center">
            <asp:Label ID="Label2" runat="server" Text="学号："></asp:Label>
            <asp:TextBox ID="SnoBox" runat="server" ReadOnly="True"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="姓名："></asp:Label>
            <asp:TextBox ID="SnameBox" runat="server" ReadOnly="True" Width="222px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="性别："></asp:Label>
            <asp:TextBox ID="SexBox" runat="server" ReadOnly="True"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="住址："></asp:Label>
            <asp:TextBox ID="SaddressBox" runat="server" ReadOnly="True" Width="220px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="电话："></asp:Label>
            <asp:TextBox ID="StellBox" runat="server" ReadOnly="True"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Q       Q："></asp:Label>
            <asp:TextBox ID="SqqBox" runat="server" ReadOnly="True" Width="210px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnChange" runat="server" OnClick="btnChange_Click" Text="修改" />
            <asp:Button ID="saveBtn" runat="server" OnClick="saveBtn_Click" Text="保存" Visible="False" />
        </asp:Panel>
    </form>
</body>
</html>
