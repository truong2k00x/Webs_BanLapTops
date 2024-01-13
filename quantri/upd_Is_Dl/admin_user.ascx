﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_user.ascx.cs" Inherits="webs_banlaptop.quantri.upd_Is_Dl.admin_user" %>
<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=user&suc=newuser" title="Thêm"><i class="fas fa-plus"></i>
                Tạo mới ADMIN User</a>
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
    <div class="col-sm-12">
        <div class="row">
            <div class="col-sm-3"><a class="textc">Tên Người Quản trị:</a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="Tên Người Quản Trị" ID="txtnameQT" runat="server" Width="546px"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">Tên Tài Khoản:</a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="user name" ID="txttentk" runat="server" Width="546px"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3"><a class="textc">password:</a></div>
            <div class="col-sm-9">
                <asp:TextBox class="TTNV" placeholder="Password" ID="txtpassword" runat="server" Width="546px"></asp:TextBox>
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
