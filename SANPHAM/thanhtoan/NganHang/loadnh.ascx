<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="loadnh.ascx.cs" Inherits="webs_banlaptop.SANPHAM.thanhtoan.NganHang.loadnh" %>
<div style="text-align:center">
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</div>
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    <asp:ListItem></asp:ListItem>
</asp:DropDownList>
<div style="width:30%;height:auto">
    <asp:Button ID="Button1" Style="font-size: 10px" runat="server" Text="Thanh Toán Khi Nhận Hàng" OnClick="Button1_Click" />
</div>
<div style="text-align:center">
    <asp:Image style="width:200px;height:auto" ID="Image1" runat="server" />
</div>