<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dangnhap.ascx.cs" Inherits="webs_banlaptop.login.dangnhap" %>
<div class="align-content-center">
    <asp:Label ID="Label1" runat="server" ForeColor="YellowGreen" Text="Tên Đăng Nhập:"></asp:Label>
    &nbsp;<span class="border border-dark"><asp:TextBox ID="txtuser" runat="server" BorderColor="Blue" BorderStyle="Ridge" Width="333px"></asp:TextBox></span>
    <br />
    <asp:Label ID="Label2" ForeColor="YellowGreen" runat="server" Text="Mật Khẩu:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                <span class="border border-dark-subtle">
                                    <asp:TextBox ID="txtpassword" TextMode="Password" runat="server" BorderColor="Blue" BorderStyle="Inset" Width="335px"></asp:TextBox></span>
    <br />
    <asp:Button ID="btnlogin" BorderStyle="Ridge" BorderColor="Yellow" ForeColor="Red" runat="server" OnClick="Button1_Click" Text="đăng nhập" />


</div>
