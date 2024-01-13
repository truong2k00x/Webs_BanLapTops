<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="cusit.ascx.cs" Inherits="webs_banlaptop.SANPHAM.thanhtoan.cusit" %>

<div class="row">
    <div class="col-sm-3"><a class="textc"></a></div>
    <div class="col-sm-9">
        <asp:TextBox Visible="false" class="TTNV" placeholder="Mã KH" Enabled="false" ID="maKH" runat="server" Width="546px"></asp:TextBox>
    </div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Họ Tên Khách Hàng:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Họ Tên" ID="txttenkh" runat="server" Width="546px"></asp:TextBox>
    </div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Địa Chỉ:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Địa Chỉ" ID="txtdiachi" runat="server" Width="546px"></asp:TextBox>
    </div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Điện Thoại:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" ID="txtsdt" placeholder="Số Điện thoại" runat="server" Width="546px" MaxLength="10" onkeypress="return ValidateKeypress(/\d/,event);"></asp:TextBox>
    </div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Email:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" ID="txtemail" placeholder="Email" runat="server" Width="546px" MaxLength="442"></asp:TextBox>
    </div>
</div>
<div>
    <asp:Button ID="Button1" runat="server" Text="Hoàn Tất" OnClick="Button1_Click" /></div>
<script>
    function ValidateKeypress(numcheck, e) {
        var keynum, keychar, numcheck;
        if (window.event) {//IE
            keynum = e.keyCode;
        }
        else if (e.which) {// Netscape/Firefox/Opera
            keynum = e.which;
        }
        if (keynum == 8 || keynum == 127 || keynum == null || keynum == 9 || keynum == 0 || keynum == 13) return true;
        keychar = String.fromCharCode(keynum);
        var result = numcheck.test(keychar);
        return result;
    }
</script>
