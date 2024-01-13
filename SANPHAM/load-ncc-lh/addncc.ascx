<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="addncc.ascx.cs" Inherits="webs_banlaptop.SANPHAM.load_ncc_lh.addncc" %>
<div class="row">
    <div class="col-sm-3">
    </div>
    <div class="col-sm-6">
        <div class="row">
            <div class="col-sm-3"><a class="textc">Mã Nhà Cung Cấp:</a></div>
            <br />
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" Enabled="false" placeholder="Mã Nhà Cung Cấp" ID="txtmancc" runat="server" Width="546px"></asp:TextBox>
            </div>
            <br />
        </div>
        <div style="margin-top: 10px" class="row">
            <div class="col-sm-3"><a class="textc">Tên Nhà Cung Cấp:</a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="Tên Nhà cung cấp" ID="txttenncc" runat="server" Width="546px"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Dia Chi:</a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="Địa Chỉ" ID="txtdiachi" runat="server" Width="546px"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Số Điện Thoại:</a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="Số Điện Thoại" ID="txtsdt" onkeypress="return ValidateKeypress(/\d/,event);" MaxLength="10" runat="server" Width="546px"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
            </div>
            <div class="col-sm-6">
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="btnsave_Click">Thêm Mới</asp:LinkButton>
            </div>
            <div class="col-sm-3">
            </div>
        </div>
    </div>
    <div class="sol-sm-3">
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
