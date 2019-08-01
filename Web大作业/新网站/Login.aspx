<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
    td {
	font-family: Tahoma,Verdana;
	font-size: 12px;
	color: #000000;
	text-decoration: none;
}
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
&nbsp;&nbsp;&nbsp;
            </p>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Larger" Font-Strikeout="False" Font-Underline="False" style="text-align: center" Text="班级管理系统"></asp:Label>
        <FONT face="宋体">
				<br>
				<TABLE align="center" cellSpacing="0" cellPadding="0" width="526" border="0">
					<TR>
						<TD colSpan="3">
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/login_1.jpg" />
                        </TD>
					</TR>
					<TR>
						<TD><asp:Image ID="Image1" runat="server" Height="201px" ImageUrl="~/主页.png" Width="276px" />
                        &nbsp;&nbsp;&nbsp;
                        </TD>
						<TD width="187" height="219">
							<TABLE id="Table3" height="219" cellSpacing="0" cellPadding="0" width="187" border="0">
								<TR>
									<TD>
    <div style="text-align: center">
    
        <br />
    
    </div>
        <div class="auto-style1">
        <asp:RadioButton ID="stuButton" runat="server" Checked="True" Text="学生" GroupName="choose" />
&nbsp;
        <asp:RadioButton ID="adminButton" runat="server" Text="管理员" GroupName="choose" />
        </div>
                                        &nbsp;
										<p class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="账号："></asp:Label>
            <asp:TextBox ID="IDBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label3" runat="server" Font-Bold="False" Text="密码："></asp:Label>
            <asp:TextBox ID="passwdBox" runat="server"></asp:TextBox>
        </p>
										<TABLE id="Table1" cellSpacing="1" cellPadding="1" border="0">
											<TR>
												<TD><FONT face="宋体">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登录" Width="66px" style="height: 27px" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="重置" OnClick="Button2_Click" Width="66px" />
			</FONT>
		                                        </TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</TD>
						<TD>
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/login_4.jpg" />
                        </TD>
					</TR>
					<TR>
						<TD colSpan="3">
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/login_5.jpg" />
                        </TD>
					</TR>
				</TABLE>
			</FONT>
    </form>
</body>
</html>
