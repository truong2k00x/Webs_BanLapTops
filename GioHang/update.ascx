<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="update.ascx.cs" Inherits="webs_banlaptop.GioHang.update" %>
<div class="row">
    <div class="col-sm-3"><a class="textc">Tên Sản Phẩm:</a></div>
    <br />
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" Enabled="false" placeholder="Tên Sản Phẩm" ID="txtten" runat="server" Width="546px"></asp:TextBox></div>
    <br />
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Tên Sản Phẩm:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Tên Sản Phẩm" ID="txttenhh" Enabled="false" runat="server" Width="546px"></asp:TextBox>
    </div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Số Lượng:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Số Lượng" ID="txtsoluong" onkeypress="return ValidateKeypress(/\d/,event);" runat="server" Width="546px"></asp:TextBox></div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Giá Bán:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Giá Bán" ID="txtgiaban" onkeypress="return ValidateKeypress(/\d/,event);" runat="server" Width="546px"></asp:TextBox></div>
</div>
<div style="align-items:center">
    <asp:Button ID="Button1" runat="server" Text="Lưu" OnClick="Button1_Click" />
</div>