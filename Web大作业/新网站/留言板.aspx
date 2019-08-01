<%@ Page Language="C#" AutoEventWireup="true" CodeFile="留言板.aspx.cs" Inherits="留言板" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image1" runat="server" Height="98px" ImageUrl="~/主页.png" Width="120px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/登录后.png" />
        <asp:Panel ID="Panel1" runat="server" BackColor="#000099" Height="45px" style="margin-top: 0px">
            <asp:Button ID="Button1" runat="server" Text="返回" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="44px" OnClick="Button1_Click" Width="74px" />
            <asp:Button ID="Button2" runat="server" BackColor="#000099" BorderStyle="None" ForeColor="White" Height="46px" OnClick="Button2_Click" Text="留言" Width="81px" />
            <asp:Button ID="Button7" runat="server" BackColor="#000099" ForeColor="White" Height="47px" OnClick="Button7_Click" Text="刷新页面" Width="108px" />
        </asp:Panel>
        <asp:Image ID="Image3" runat="server" ImageUrl="~/科大.png" />
    
    </div>
        <br />
        <asp:Panel ID="Panel2" runat="server" style="text-align: center">
            <asp:TextBox ID="TextBox1" runat="server" Height="108px" Width="388px" Font-Size="X-Small"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" Visible="False">不超过200个字</asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="留言" Height="41px" Width="115px" />
        </asp:Panel>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width:100%;">
                    <tr>
                        <td style="text-align: left">
                            <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="UserName" DataSourceID="SqlDataSource1" ForeColor="#333333" Height="398px" HorizontalAlign="Center" style="margin-right: 917px; margin-bottom: 0px; text-align: left;" Width="259px">
                                <AlternatingItemStyle BackColor="White" />
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                <ItemTemplate>
                                    UserName:
                                    <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                                    <br />
                                    time:
                                    <asp:Label ID="timeLabel" runat="server" Text='<%# Eval("time") %>' />
                                    <br />
                                    context:
                                    <asp:Label ID="contextLabel" runat="server" Text='<%# Eval("context") %>' />
                                    <br />
                                    <br />
                                </ItemTemplate>
                                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            </asp:DataList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:课设ConnectionString2 %>" SelectCommand="SELECT * FROM [留言板]"></asp:SqlDataSource>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Timer ID="Timer1" runat="server" Interval="10000">
                            </asp:Timer>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
