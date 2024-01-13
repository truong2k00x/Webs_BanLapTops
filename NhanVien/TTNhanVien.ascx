<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TTNhanVien.ascx.cs" Inherits="webs_banlaptop.NhanVien.TTNhanVien" %>
<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=crs&suc=newcrs" title="Thêm"><i class="fas fa-plus"></i>
                Tạo mới Nhân Viên</a>
        </div>
        <div class="col-sm-3">
            <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="xóa">
            <asp:LinkButton class="btn btn-add btn-sm" ID="btnxoa" runat="server" OnClick="btnxoa_Click" CausesValidation="False"><i class="fa-solid fa-trash"></i>Delete</asp:LinkButton></p>
        </div>
        <div class="col-sm-3">
            <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="Save">
                <asp:LinkButton class="btn btn-add btn-sm"  ID="btnsua" runat="server" OnClick="btnsua_Click"><i class="fa-regular fa-file"></i>Thêm Mới</asp:LinkButton>
                </p>
        </div>
        <div class="col-sm-3">
            <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="Save">
                <asp:LinkButton class="btn btn-add btn-sm"  ID="btnupdate" runat="server" CausesValidation="False" OnClick="btnupdate_Click1"><i class="fa-solid fa-floppy-disk"></i>Save</asp:LinkButton>
                </p>
        </div>
    </div>
</div>
<hr />
<div class="row">
    <div class="col-sm-4">
        <asp:Image ID="Image1" runat="server" Height="183px" Width="175px" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="FileUpload1" Display="None" runat="server" ErrorMessage="blank photo"></asp:RequiredFieldValidator>
        <br />
        
    </div>
    <div class="col-sm-8">
        <div class="row">
            <div class="col-sm-3"><a class="textc">Mã Nhân Viên:</a></div>
            <div class="col-sm-9"><asp:TextBox class="TTNV" Enabled="false" placeholder="Mã Nhân Viên" ID="txtmanv" runat="server" Width="546px"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Tên Nhân Viên:</a></div>
            <div class="col-sm-9"><asp:TextBox class="TTNV" placeholder="Tên Nhân Viên" ID="txttennv" runat="server" Width="546px"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Địa Chỉ:</a></div>
            <div class="col-sm-9"><asp:TextBox class="TTNV" placeholder="Địa Chỉ" ID="txtdiachi" runat="server" Width="546px"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Điện Thoại:</a></div>
            <div class="col-sm-9"><asp:TextBox class="TTNV" ID="txtdienthoai" placeholder="Số Điện thoại" runat="server" Width="546px" MaxLength="10" onkeypress="return ValidateKeypress(/\d/,event);"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Số CCCD:</a></div>
            <div class="col-sm-9"><asp:TextBox class="TTNV" ID="txtCCCD" placeholder="Số CCCD" runat="server" Width="546px" onkeypress="return ValidateKeypress(/\d/,event);" MaxLength="12"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Ngày Sinh:</a></div>
            <div class="col-sm-9">
                <div class="row">
                    <div class="col-sm-1" style="margin-bottom: 0px; margin-top: auto; text-align-last: center">Ngày</div>
                    <div style="display:inline" class="col-sm-1">
                        <asp:TextBox class="TTNV" ID="txtday" runat="server" placeholder="DD" onkeypress="return ValidateKeypress(/\d/,event);" Width="49px" MaxLength="2"></asp:TextBox>
                    </div>
                    <div class="col-sm-1" style="margin-bottom: 0px; margin-top: auto; text-align-last: center"> Tháng </div>
                    <div class="col-sm-1">
                        <asp:TextBox class="TTNV" ID="txtmoth" runat="server" placeholder="MM" onkeypress="return ValidateKeypress(/\d/,event);" Width="49px" MaxLength="2"></asp:TextBox></asp:TextBox></div>
                    <div class="col-sm-1" style="margin-bottom:0px;margin-top:auto;text-align-last:center"> Năm </div>
                    <div class="col-sm-7">
                        <asp:TextBox class="TTNV" ID="txtyear" runat="server" placeholder="YYYY" onkeypress="return ValidateKeypress(/\d/,event);" Width="301px" MaxLength="4"></asp:TextBox></asp:TextBox></div>
                </div>
            </div>
        </div>
    </div>
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
