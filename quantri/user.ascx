<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="user.ascx.cs" Inherits="webs_banlaptop.quantri.user" %>
<div>

    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Quản Lý User"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Tên người quản trị:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtnguoiqt" runat="server" Width="695px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Tên tài khoản: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtuser" runat="server" Width="695px"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Password: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtpass" runat="server" Width="695px"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Tên tài khoản: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtuser0" runat="server" Width="695px"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Password: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtpass0" runat="server" Width="695px"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="thêm" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Text="sửa " OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" Text="xóa" OnClick="Button5_Click" />
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button6" runat="server" Text="search" OnClick="Button6_Click" />
    &nbsp;
    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="refresh" />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="tài khoản khách" />
    <asp:Button ID="Button2" runat="server" Height="29px" OnClick="Button2_Click" Text="tài khoản quản trị" Width="190px" />
    <br />

</div>

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" Width="968px">
    <Columns>
        <asp:BoundField DataField="TenAdmin" HeaderText="tên quản trị" />
        <asp:BoundField DataField="TaiKhoan" HeaderText="tài khoản" />
        <asp:BoundField DataField="matKhau" HeaderText="mật khẩu" />
        <asp:ButtonField CommandName="tttk1" Text="tt user" HeaderText="thông tin" />
        <asp:ButtonField CommandName="updpas" HeaderText="đổi mật khẩu" Text="update" />
    </Columns>
</asp:GridView>

<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView2_RowCommand" OnRowDeleting="GridView2_RowDeleting" OnRowUpdating="GridView2_RowUpdating" Width="966px">
    <Columns>
        <asp:BoundField DataField="TenTK" HeaderText="tên tk" />
        <asp:BoundField DataField="MatKhau" HeaderText="mật khẩu" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:ButtonField CommandName="tttk2" HeaderText="thông tin" Text="tt user" />
        <asp:ButtonField CommandName="updpass1" HeaderText="đổi mật khẩu" Text="updatepassword" />
    </Columns>
</asp:GridView>


