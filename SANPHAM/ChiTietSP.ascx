<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSP.ascx.cs" Inherits="webs_banlaptop.SANPHAM.ChiTietSP" %>

<link rel="styles heet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
<link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap.min.css">
<link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap-grid.min.css">
<link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/fontawesome.css">
<link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/brands.css">

<link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/solid.css">

<div class="container">
    <div class="row"> 
    <figure class="col-md-4">
        <div class="column is-10 is-offset-1">
            <div style="color:#582666" id="demo" class="carousel slide" data-ride="carousel">

                <!-- Indicators -->
                <ul class="carousel-indicators">
                    <li data-target="#demo" data-slide-to="0" class="active"></li>
                    <li data-target="#demo" data-slide-to="1"></li>
                    <li data-target="#demo" data-slide-to="2"></li>
                </ul>
                <!-- The slideshow -->
                <div class="carousel-inner">
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    
                </div>

                <!-- Left and right controls -->
                <a class="carousel-control-prev" style="color: black;" href="#demo" data-slide="prev">
                    <span class="carousel-control-prev-icon"></span>
                    
                </a>
                <a class="carousel-control-next" style="color: black;" href="#demo" data-slide="next">
                    <span class="carousel-control-next-icon"></span>
                </a>
            </div>
        </div>
        <a>
            <asp:Literal ID="TTsp" runat="server"></asp:Literal>
            <div class="row">
                <div class="col-sm-6">
                    <asp:Button ID="btnadd" runat="server" Text="Thêm Vào Giỏ Hàng" OnClick="btnadd_Click" /></div>
                <div class="col-sm-6">
                    <asp:Button ID="btnmua" runat="server" Text="Đặt Hàng" OnClick="btnmua_Click" /></div>
            </div>
        </a>
    </figure>
        <div class="col-md-8">
            <asp:Literal ID="TTCTSP" runat="server"></asp:Literal>
        </div>
    </div>
</div>
