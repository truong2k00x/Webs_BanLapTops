<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="webs_banlaptop.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <link rel="Shortcut Icon" type="img/png" href="img/_nuxt/icons/logoweb.png" />


    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Latest compiled JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <link href="Content/owl-carousel/assets/owl.carousel.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="Content/owl-carousel/assets/assets/owl.theme.default.min.css" />
    <script src="Content/jquery.min.js"></script>
    <script src="Content/owl.carousel.min.js"></script>
    <link href="css/index1.css" rel="stylesheet" />
    <link rel="stylesheet" href="full.css" />

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css" />
    <link rel="stylesheet" type="text/css" href="css/util.css" />
    <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap-grid.min.css" />
    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/fontawesome.css" />
    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/brands.css" />


    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/solid.css" />

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="limiter">
            <div class="container-login100">
                <div class="row wrap-login100">
                    <div class="col-sm-3 login100-pic js-tilt" data-tilt>
                        <img src="img/_nuxt/icons/logoweb.png" alt="IMG">
                    </div>
                    <!--=====TIÊU ĐỀ======-->
                    <div class="col-sm-7">
                        <form class="login100-form validate-form">
                            <span class="login100-form-title">
                                <b>ĐĂNG NHẬP HỆ THỐNG THINKPRO</b>
                            </span>
                            <!--=====FORM INPUT TÀI KHOẢN VÀ PASSWORD======-->
                            <%--<form action="">--%>
                            <div class="wrap-input100 validate-input">
                                <asp:TextBox ID="username" runat="server" placeholder="Tài khoản quản trị" Class="input100"></asp:TextBox></span>
                                    <%--<asp:TextBox ID="username"   runat="server"></asp:TextBox>--%>
                                <span class="focus-input100"></span>
                                <span class="symbol-input100">
                                    <i class='bx bx-user'></i>
                                </span>
                            </div>
                            <div class="wrap-input100 validate-input">
                                <asp:TextBox ID="txtpassword" Class="input100" placeholder="Mật khẩu" TextMode="Password" runat="server" name="current-password"></asp:TextBox>
                                <%--<asp:TextBox ID="password"  TextMode="Password"  name="current-password" runat="server"></asp:TextBox>--%>
                                <%--<input autocomplete="off" class="input100" type="password" placeholder="Mật khẩu" name="current-password" id="password-field">--%>

                                <span toggle="#txtpassword" class="bx fa-fw bx-hide field-icon click-eye"></span>
                                <span class="focus-input100"></span>
                                <span class="symbol-input100">
                                    <i class='bx bx-key'></i>
                                </span>
                            </div>

                            <!--=====ĐĂNG NHẬP======-->
                            <div class="container-login100-form-btn">
                                <asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="Đăng nhập" />
                                <%--<input id="Button1" type="button" value="button" />
                                    <input type="button" value="Đăng nhập" id="submit" onclick="Button1_Click" />--%>
                            </div>
                            <div class="row">
                                <!--=====LINK TẠO TÀI KHOẢN======-->
                                <div class="col-sm-6 text-left p-t-12">
                                    <a class="txt2" href="Dky.aspx">Bạn Chưa Có Tài Khoản?
                                    </a>
                                </div>
                                <!--=====LINK TÌM MẬT KHẨU======-->
                                <div class="col-sm-6 text-right p-t-12">
                                    <a class="txt2" href="quenpassword.aspx">Bạn quên mật khẩu?
                                    </a>
                                </div>
                            </div>
                            <%--</form>--%>
                    </div>
                    <!--=====FOOTER======-->
                    <div class="text-center p-t-70 txt2">
                        Phần mềm quản lý bán hàng <i class="far fa-copyright" aria-hidden="true"></i>
                        <script type="text/javascript">document.write(new Date().getFullYear());</script>
                        <a
                            class="txt2" href="https://www.facebook.com/buitruong2k/">Code bởi Trường </a>
                    </div>
    </form>
    </div>
            </div>
        </div>
    <script src="/js/main.js"></script>
    <script src="https://unpkg.com/boxicons@latest/dist/boxicons.js"></script>
    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
    <script src="vendor/bootstrap/js/popper.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="vendor/select2/select2.min.js"></script>
    <script type="text/javascript">
        //show - hide mật khẩu
        function myFunction() {
            var x = document.getElementById("myInput");
            if (x.type === "password") {
                x.type = "text"
            } else {
                x.type = "password";
            }
        }
        $(".click-eye").click(function () {
            $(this).toggleClass("bx-show bx-hide");
            var input = $($(this).attr("toggle"));
            if (input.attr("type") == "password") {
                input.attr("type", "text");
            } else {
                input.attr("type", "password");
            }
        });
    </script>
    <%--<div>

        </div>
        <div style="margin-left: 400px">
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Labelcount" runat="server" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <div class="container">
                <div class="row">
                    <div class="col-md-6">
                        <img src="img/_nuxt/icons/logoweb.png"/><br />
                        THINKPRO hỗ trợ khách hàng 24/7 bảo hành tận tâm.
                    </div>
                    <div class="col-md-6">
                        <br />
                        <br />
                        <div class="align-content-center">
                            <asp:Label ID="Label1" runat="server" ForeColor="YellowGreen" Text="Tên Đăng Nhập:"></asp:Label>
                            &nbsp;<span class="border border-dark">
                            <br />
                            <asp:Label ID="Label2" ForeColor="YellowGreen" runat="server" Text="Mật Khẩu:"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                <span class="border border-dark-subtle">
                    
                            <br />
                            <asp:Button ID="btnlogin" BorderStyle="Ridge" BorderColor="Yellow" ForeColor="Red" runat="server" OnClick="Button1_Click" Text="đăng nhập" />
                            
                            <a href="Dky.aspx">đăng ký tài khoản</a>
                        </div>
                    </div>
                </div>
            </div>
            
            
            <br />
        </div>--%>
    </form>
</body>
</html>
