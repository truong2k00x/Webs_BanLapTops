<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="addtintuc.ascx.cs" Inherits="webs_banlaptop.GioiThieu.tintuc.addtintuc" %>
<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=tin&suc=newtin" title="Thêm"><i class="fas fa-plus"></i>
                New Tin Tức</a>
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
    <div class="col-sm-4">
        <asp:Image ID="Image1" runat="server" Height="183px" Width="175px" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="FileUpload1" Display="None" runat="server" ErrorMessage="blank photo"></asp:RequiredFieldValidator>
        <br />

    </div>
    <div class="col-sm-8">
        <div class="row">
            <div class="col-sm-3"><a class="textc"><b>Mã Tin Tức:</b></a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" Enabled="false" placeholder="Mã tin tức" ID="txtmatt" runat="server" Width="546px"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc"><b>ND Header:</b></a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="ND Header" MaxLength="300" ID="txtndheader" runat="server" Width="546px" Height="72px" TextMode="MultiLine"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc"><b>Nội Dung:</b></a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="Nội Dung" ID="txtND" runat="server" Width="546px" Height="162px" TextMode="MultiLine"></asp:TextBox></div>
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
