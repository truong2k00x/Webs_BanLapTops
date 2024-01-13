<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TThoadon.ascx.cs" Inherits="webs_banlaptop.HoaDon.TThoadon" %>
<div class="border" style="background-color:white;text-align:center"><a style="font-size:45px;color:blue">Thông Tin Hóa Đơn</a></div>
<div class="border" style="background-color: white"><a style="font-size:30px"><b>MaHD:<asp:Literal ID="mahd" runat="server"></asp:Literal></b></a></div>
<div style="text-align:right">
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></div>
<asp:Literal ID="hoadon" runat="server"></asp:Literal>
<div style="text-align:center;background-color:white;color:red;font-size:50px">
    <asp:Literal ID="TRANGTHAI" runat="server"></asp:Literal></div>
<div class="row">
    <div class="col-sm-6">
        <asp:Button ID="btn" runat="server" Text="Xác Nhận Chuyển Trạng Thái Đơn Hàng" OnClick="btn_Click" />
    </div>
    <div class="col-sm-6">
        <asp:Button ID="cancel" runat="server" Text="Hủy" OnClick="cancel_Click" />
    </div>
</div>
