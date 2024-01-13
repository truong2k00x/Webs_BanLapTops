<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="doipassword.aspx.cs" Inherits="webs_banlaptop.doipassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đổi Mật Khẩu</title>
    <link rel="Shortcut Icon" type="img/png" href="img/_nuxt/icons/logoweb.png">
    <link rel="stylesheet" href="full.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap-grid.min.css">
    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/fontawesome.css">
    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/brands.css">
    <link rel="stylesheet" type="text/css" href="css/util.css">
    <link rel="stylesheet" type="text/css" href="css/main.css">
    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/solid.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.3/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>

    <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.min.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js"></script>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css">
    <link rel="stylesheet" href="https://unpkg.com/boxicons@latest/css/boxicons.min.css">
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
                                <b>Đổi Mật Khẩu</b>
                            </span>
                            <!--=====FORM INPUT PASSWORD VÀ PASSWORD NEW======-->
                            <form action="">
                                <div class="wrap-input100 validate-input">
                                    <asp:TextBox ID="password1" Class="input100" TextMode="Password" placeholder="Mật khẩu Cũ" name="current-password" runat="server"></asp:TextBox>
                                    <%--<input autocomplete="off" class="input100" type="password" placeholder="Mật khẩu" name="current-password" id="password-field">--%>

                                    <span toggle="#password1" class="bx fa-fw bx-hide field-icon click-eye"></span>
                                    <span class="focus-input100"></span>
                                    <span class="symbol-input100">
                                        <i class='bx bx-key'></i>
                                    </span>
                                </div>
                                <div class="wrap-input100 validate-input">
                                    <asp:TextBox ID="password2" Class="input100" TextMode="Password" placeholder="Mật khẩu Mới" name="current-password" runat="server"></asp:TextBox>
                                    <%--<input autocomplete="off" class="input100" type="password" placeholder="Mật khẩu" name="current-password" id="password-field">--%>

                                    <span toggle="#password2" class="bx fa-fw bx-hide field-icon click-eye"></span>
                                    <span class="focus-input100"></span>
                                    <span class="symbol-input100">
                                        <i class='bx bx-key'></i>
                                    </span>
                                </div>
                                <div class="wrap-input100 validate-input">
                                    <asp:TextBox ID="password3" Class="input100" TextMode="Password" placeholder="Nhập Lại Mật khẩu" name="current-password" runat="server"></asp:TextBox>
                                    <%--<input autocomplete="off" class="input100" type="password" placeholder="Mật khẩu" name="current-password" id="password-field">--%>

                                    <span toggle="#password3" class="bx fa-fw bx-hide field-icon click-eye"></span>
                                    <span class="focus-input100"></span>
                                    <span class="symbol-input100">
                                        <i class='bx bx-key'></i>
                                    </span>
                                </div>

                                <!--=====ĐĂNG Ký======-->
                                <div class="container-login100-form-btn">
                                    <asp:Button ID="submit" runat="server" Text="Đổi Mật Khẩu" OnClick="Button12_Click" />
                                    <%--<input type="button" value="Đăng nhập" id="submit" onclick="validate()" />--%>
                                </div>
                                <!--=====LINK Đăng Nhập======-->
                                <div class="text-right p-t-12">
                                    <a class="txt2" href="main.aspx">Đăng Nhập Ngay
                                    </a>
                                </div>
                            </form>
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
    </form>
</body>
</html>
