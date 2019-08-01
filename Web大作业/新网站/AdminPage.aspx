<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image1" runat="server" Height="93px" ImageUrl="~/主页.png" Width="115px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/登录后.png" />
        <asp:Panel ID="Panel4" runat="server" BackColor="#000099" Height="53px">
            <asp:Button ID="管理员主页0" runat="server" Text="管理员主页" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="48px" OnClick="管理员主页0_Click" Width="111px" />
            <asp:Button ID="管理员主页1" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="48px" OnClick="管理员主页1_Click" Text="学生信息管理" Width="111px" />
            <asp:Button ID="Button2" runat="server" Text="退出系统" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="44px" OnClick="Button2_Click" Width="98px" />
        </asp:Panel>
    
    </div>
        <p>
            <asp:Image ID="Image3" runat="server" Height="307px" ImageUrl="~/科大.png" style="margin-top: 0px" Width="1163px" />
        </p>
        <asp:Panel ID="Panel1" runat="server" Height="201px" HorizontalAlign="Center">
            <asp:Label ID="Label1" runat="server" Text="班级学生信息"></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text="学号："></asp:Label>
            <asp:TextBox ID="sIDBox" runat="server" style="text-align: center" ToolTip="160"></asp:TextBox>
            <asp:Button ID="delBtn" runat="server" OnClick="delBtn_Click" Text="删除" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EnableTheming="True" Height="159px" Width="1165px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" OnRowEditing="GridView1_RowEditing" OnRowUpdated="GridView1_RowUpdated1" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="Sno" HeaderText="学号" />
                    <asp:BoundField DataField="Sname" HeaderText="姓名" />
                    <asp:BoundField DataField="Ssex" HeaderText="性别" />
                    <asp:BoundField DataField="Saddress" HeaderText="住址" />
                    <asp:BoundField DataField="Stell" HeaderText="电话" />
                    <asp:BoundField DataField="Sqq" HeaderText="QQ" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="290px" style="margin-top: 29px" HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label2" runat="server" Text="普通课程查询"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="学年：   "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="学期：  "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="1169px" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="Cno" HeaderText="课程号" />
                    <asp:BoundField DataField="Cname" HeaderText="课程名" />
                    <asp:BoundField DataField="Cyear" HeaderText="学年" />
                    <asp:BoundField DataField="Cterm" HeaderText="学期" />
                    <asp:BoundField DataField="Ccredit" HeaderText="学分" />
                    <asp:BoundField DataField="Cnature" HeaderText="种类" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="303px" HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label5" runat="server" Text="选修课程查询"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="学年："></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="学期："></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="学号："></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="127px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="查询" />
            <br />
            <br />
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" Width="1164px" AllowPaging="True" OnPageIndexChanging="GridView3_PageIndexChanging" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="Cno" HeaderText="课程号" />
                    <asp:BoundField DataField="Cname" HeaderText="课程名" />
                    <asp:BoundField DataField="Sno_C" HeaderText="学号" />
                    <asp:BoundField DataField="Ccredit" HeaderText="学分" />
                    <asp:BoundField DataField="Cscore" HeaderText="成绩" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
