<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongtinKH.ascx.cs" Inherits="webs_banlaptop.KhachHang.ThongtinKH" %>
<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=cus&suc=newcus" title="Thêm"><i class="fas fa-plus"></i>
                Tạo Mới thông tin Khách Hàng</a>
        </div>
        <div class="col-sm-3">
            <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="xóa">
                <asp:LinkButton class="btn btn-add btn-sm" ID="btnxoa" runat="server" OnClick="btnxoa_Click" CausesValidation="False"><i class="fa-solid fa-trash"></i>Delete</asp:LinkButton>
            </p>
        </div>
        <div class="col-sm-3">
            <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="Save">
                <asp:LinkButton class="btn btn-add btn-sm" ID="btnsua" runat="server" OnClick="btnsua_Click"><i class="fa-regular fa-file"></i>Thêm Mới</asp:LinkButton>
            </p>
        </div>
        <div class="col-sm-3">
            <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="Save">
                <asp:LinkButton class="btn btn-add btn-sm" ID="btnupdate" runat="server" CausesValidation="False" OnClick="btnupdate_Click1"><i class="fa-solid fa-floppy-disk"></i>Save</asp:LinkButton>
            </p>
        </div>
    </div>
</div>
<hr />
<div class="row">
    <div class="col-sm-3"><a class="textc">Mã Khách Hàng:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Mã KH" Enabled="false" ID="maKH" runat="server" Width="546px"></asp:TextBox>
    </div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Họ Tên Khách Hàng:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Họ Tên" ID="txttenkh" runat="server" Width="546px"></asp:TextBox></div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Địa Chỉ:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" placeholder="Địa Chỉ" ID="txtdiachi" runat="server" Width="546px"></asp:TextBox></div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Điện Thoại:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" ID="txtsdt" placeholder="Số Điện thoại" runat="server" Width="546px" MaxLength="10" onkeypress="return ValidateKeypress(/\d/,event);"></asp:TextBox></div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Email:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" ID="txtemail" placeholder="Email" runat="server" Width="546px" MaxLength="442"></asp:TextBox></div>
</div>
<div class="row">
    <div class="col-sm-3"><a class="textc">Tên Tài Khoản:</a></div>
    <div class="col-sm-9">
        <asp:TextBox class="TTNV" ID="txttentk" placeholder="User" runat="server" Width="546px" MaxLength="12"></asp:TextBox></div>
</div>

<style>
    .textc{
        color:blue;
        font-size:14px;
    }
    .TTNV{
        display: block;
    font-size: 15px;
    line-height: 1.5;
    color: black;
    background-color: #f1f1f1;
    background-clip: padding-box;
    border: 1px solid #dadada;
    border-radius: .357rem;
    }
</style>
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
<%--<div>

    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p style="text-align: center">
        <asp:Label ID="Label1" runat="server" Text="THÔNG TIN KHÁCH HÀNG"></asp:Label>
    </p>
    <br />
    Tên Khách Hàng:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="" runat="server" Width="747px"></asp:TextBox>
    <br />
    Địa Chỉ:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="" runat="server" Width="747px"></asp:TextBox>
    <br />
    Số Điện Thoại:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="" runat="server" Width="747px"></asp:TextBox>
    <br />
    Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="" runat="server" Width="747px"></asp:TextBox>
    <br />
    TenTK:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="" runat="server" Enabled="False" Width="747px"></asp:TextBox>
    <br />
    <div style="align-items: center">
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="lưu" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;</div>
    </div>
    <br />
    <br />--%>

</div>
