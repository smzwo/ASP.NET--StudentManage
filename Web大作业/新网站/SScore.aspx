<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SScore.aspx.cs" Inherits="SScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image3" runat="server" Height="110px" ImageUrl="~/主页.png" Width="116px" />
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/登录后.png" Width="743px" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#000099" Height="43px" style="text-align: center" HorizontalAlign="Center">
            <asp:Button ID="Button3" runat="server" Text="科大主页" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="40px" Width="93px" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="40px" Text="我的主页" Width="93px" OnClick="Button4_Click" />
            <asp:Button ID="Button2" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="40px" Text="信息修改" Width="93px" OnClick="Button2_Click" />
            <asp:Button ID="Button7" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="40px" Text="修改密码" Width="93px" OnClick="Button5_Click" />
            <asp:Button ID="Button8" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="40px" OnClick="Button22_Click" Text="聊天室" Width="93px" />
            <asp:Button ID="Button6" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="40px" Text="退出系统" Width="93px" OnClick="Button6_Click" />
        </asp:Panel>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/科大.png" />
        <asp:Panel ID="Panel2" runat="server" Height="340px" style="text-align: center" HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label1" runat="server" Text="学年："></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="118px">
            </asp:DropDownList>
            &nbsp;<asp:Label ID="Label2" runat="server" Text="学期："></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" Height="24px" Width="122px">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 27px" Text="查询" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1194px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="CNO" HeaderText="课程号" />
                    <asp:BoundField DataField="CNAME" HeaderText="课程名" />
                    <asp:BoundField DataField="CYEAR" HeaderText="学年" />
                    <asp:BoundField DataField="CTERM" HeaderText="学期" />
                    <asp:BoundField DataField="CCREDIT" HeaderText="学分" />
                    <asp:BoundField DataField="CNATURE" HeaderText="种类" />
                    <asp:BoundField DataField="SCORE" HeaderText="分数" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:课设ConnectionString %>" SelectCommand="SELECT * FROM [ScoreSearch]"></asp:SqlDataSource>
            <br />
        </asp:Panel>
    </form>
</body>
</html>
