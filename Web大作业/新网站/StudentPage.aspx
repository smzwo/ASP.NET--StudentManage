<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentPage.aspx.cs" Inherits="StudentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

td {
	font-family: Tahoma,Verdana;
	font-size: 12px;
	color: #000000;
	text-decoration: none;
}
    A{
	COLOR: #003366 ; TEXT-DECORATION: none
}
        #form1 {
            text-align: center;
            height: 811px;
        }
    </style>
</head>
<body style="height: 951px; text-align: center;">
    <form id="form1" runat="server">
        <asp:Image ID="Image3" runat="server" Height="93px" ImageUrl="~/主页.png" Width="134px" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/登录后.png" Width="859px" Height="94px" style="text-align: center" />
			<asp:Panel ID="Panel2" runat="server" BackColor="#000099" Height="45px" HorizontalAlign="Center">
                <asp:Button ID="Button2" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="43px" Text="科大主页" Width="95px" OnClick="Button2_Click" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="43px" Text="成绩查询" Width="95px" OnClick="Button3_Click" />
                &nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="43px" Text="信息修改" Width="95px" OnClick="Button1_Click" />
                &nbsp;
                <asp:Button ID="Button6" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="43px" Text="密码修改" Width="95px" OnClick="Button4_Click" />
                <asp:Button ID="Button91" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="43px" OnClick="Button91_Click" Text="聊天室" Width="95px" />
                &nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="43px" Text="退出系统" Width="95px" OnClick="Button5_Click" />
        </asp:Panel>
        <asp:Image ID="Image2" runat="server" Height="295px" ImageUrl="~/科大.png" style="text-align: center" />
        <asp:Panel ID="Panel3" runat="server" Height="448px" Width="1188px" HorizontalAlign="Center">
            <br />
            &nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Larger" style="text-align: center" Text="我的个人基本信息"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="学号"></asp:Label>
            ：<asp:TextBox ID="SnoBox" runat="server" ReadOnly="True"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
            ：<asp:TextBox ID="SnameBox" runat="server" ReadOnly="True" Width="249px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="性别"></asp:Label>
            ：<asp:TextBox ID="SexBox" runat="server" ReadOnly="True"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="住址"></asp:Label>
            ：<asp:TextBox ID="SaddressBox" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="电话"></asp:Label>
            ：<asp:TextBox ID="StellBox" runat="server" ReadOnly="True"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Q    Q"></asp:Label>
            ：<asp:TextBox ID="SqqBox" runat="server" ReadOnly="True" style="text-align: center" Width="260px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/教务系统.png" OnClick="ImageButton1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/校历.png" OnClick="ImageButton2_Click" />
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
    <p style="text-align: center">
        &nbsp;</p>
</body>
</html>
