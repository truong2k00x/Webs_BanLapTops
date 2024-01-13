<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="searchHoaDon.ascx.cs" Inherits="webs_banlaptop.GioiThieu.ThongBao.searchHoaDon" %>
<div class="row" style="margin-top:30px">
    <div class="col-sm-8">
        <asp:TextBox ID="TextBox1" class="form-control mr-sm-2" type="search" placeholder="Search" runat="server"></asp:TextBox>
    </div>
    <div class="col-sm-4">
        <asp:Button ID="Button1" runat="server" Text="Kiểm Tra" OnClick="Button1_Click" />
    </div>
</div>
<asp:Literal ID="trangthaiDH" runat="server"></asp:Literal>