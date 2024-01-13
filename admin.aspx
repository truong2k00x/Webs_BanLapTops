<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="webs_banlaptop.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADMIN</title>
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
    <style>
        body {
  font-family: sans-serif;
  color: #222;
}
        .menu ul {
            font-size:18px;
  background: #7FFFD4;
  list-style-type: none;
 /* text-align: center;*/
}
        .menu li {
  color: #f1f1f1;
  display: inline-block;
  width: 120px;
  height: 40px;
  line-height: 40px;
        .app-sidebar__user{
    display: block;
    display: -ms-flexbox;
    /* display: flex; */
    /* -webkit-box-align: center; */
    -ms-flex-align: center;
    align-items: center;
    padding: 10px;
    color: white;
    text-align: center;
    }
    .app-sidebar__user-avatar {
    background: white;
    border-radius: .357rem;
    width: 70px;
    border: 3px solid white;
    margin-bottom: 10px;
    }
    .app-sidebar__user-name, .app-sidebar__user-designation {
    white-space: nowrap;
    overflow: hidden;
    -o-text-overflow: ellipsis;
    text-overflow: ellipsis;
    margin-bottom: 0;
    }
    p{
     display: block;
     font-size:8px;
    margin-block-start: 1em;
    margin-block-end: 1em;
    margin-inline-start: 0px;
    margin-inline-end: 0px;
    }
    .app-sidebar__user-name {
    font-size: 17px;
    line-height: 1.3;
    }
    .circle {
  background-image: src(img/a/ThinkPro-Logo-PNG.png);
  border: 0.1875em solid #0F1C3F;
  border-radius: 50%;
  box-shadow: 0.375em 0.375em 0 0 rgba(15, 28, 63, 0.125);
  height: 5em;
  width: 5em;
    }
    }
.popup{
    width: 400px;
    background: #fff;
    border-radius: 6px;
    position: absolute;
    top: 0;
    left: 50%;
    transform: translate(-50%,-50%) scale(0.1);
    text-align: center;
    padding: 0 30px 30px;
    color: greenyellow;
    visibility: hidden;
    transition: transform 0.4s, top 0.4s;
}
.open-popup{
    visibility: visible;
    top: 50%;
    transform: translate(-50%,-50%) scale(1);
}
.popup2{
    width: 400px;
    background: #fff;
    border-radius: 6px;
    position: absolute;
    top: 0;
    left: 50%;
    transform: translate(-50%,-50%) scale(0.1);
    text-align: center;
    padding: 0 30px 30px;
    color: greenyellow;
    visibility: hidden;
    transition: transform 0.4s, top 0.4s;
}
.open-popup2{
    top: 50%;
    visibility: visible;
    transform: translate(-50%,-50%) scale(1);
}
.popup3{
    width: 400px;
    background: #fff;
    border-radius: 6px;
    position: absolute;
    top: 0;
    left: 50%;
    transform: translate(-50%,-50%) scale(0.1);
    text-align: center;
    padding: 0 30px 30px;
    color: greenyellow;
    visibility: hidden;
    transition: transform 0.4s, top 0.4s;
}
.open-popup3{
    top: 50%;
    visibility: visible;
    transform: translate(-50%,-50%) scale(1);
}
.popup img{
    width: 100px;
    margin-top: -50px;
    border-radius: 50%;
    box-shadow:  0 2px 5px rgba(red, green, blue, alpha);
}
.popup h2{
    font-size: 38px;
    font-weight: 500;
    margin: 30px 0 10px;
}
.popup button{
    width: 100%;
    margin-top: 50px;
    padding: 10px 0;
    background: #6fd649;
    color: #fff;
    border: 0;
    outline: none;
    font-size: 18px;
    border-radius: 4px;
    cursor: pointer;
    box-shadow:  0 2px 5px rgba(red, green, blue, alpha);
}

    </style>
</head>
<body style="background-image: url(img/_nuxt/background/28.jpg); background-size: cover; margin: 0;" data-bs-spy="scroll" onload="time()" class="app sidebar-mini rtl">
    <form id="form1" runat="server">
        <div class="">
        <div class="row">
            <!-- Button trigger modal -->
            <div class="col-sm-3" style="height: auto; background-color: #000080">
                <div style="display: inline" class="app-sidebar__user align-content-lg-center">
                    <div style="margin-top:0px" class="circle row">
                        <img class="app-sidebar__user-avatar" src="img/a/ThinkPro-Logo-PNG.png" alt="logo" />
                    </div>
                    <div style="text-align:center">
                        <asp:Literal ID="imgnv" runat="server"></asp:Literal>
                    </div>
                    <p style="text-align:center" class="app-sidebar__user-name"><asp:Label Font-Size="30px" ForeColor="White" ID="lbluser" runat="server"></asp:Label></p>
                    <p style="text-align: center;color:white ;font-size: medium" class="app-sidebar__user-designation">Chào mừng trở lại</p>

                </div>
                <div id="navcontrol" class="nav-item">
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="admin.aspx?uc=chart" style="text-align: center; white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class="fa-regular fa-chart-simple"></i>       Thống Kê
                        </a>
                    </div>
                    <asp:Literal ID="checkadmin" runat="server"></asp:Literal>
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="admin.aspx?uc=cus" style="text-align: center; white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class='app-menu__icon bx bx-user-voice'></i>Quản lý khách hàng</a>
                    </div>
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="admin.aspx?uc=prd" style="text-align: center; white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i
                            class='app-menu__icon bx bx-purchase-tag-alt'></i>Quản lý sản phẩm</a>
                    </div>
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="admin.aspx?uc=order" style="text-align: center; white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class='app-menu__icon bx bx-task'></i>Quản Lý Đơn Hàng</a>
                    </div>
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="index.aspx" style="text-align: center; white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class="fa-solid fa-indent"></i> BÁN HÀNG</a>
                    </div>  
                    <div class="dropdown">
                        <div role="button" data-target="accer" data-toggle="dropdown" id="navbarDropdown" class="nav-link dropdown-toggle align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                            <a style="text-align: center; color: #007bff; white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class="fa-sharp fa-regular fa-gear"></i>Setting</a>
                        </div>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                            <a style="color: #007bff" class="dropdown-item picture1" href="admin.aspx?uc=tin">
                                <i class="fa-regular fa-newspaper"></i>Tin Tức</a>
                            <a style="color: #007bff" class="dropdown-item picture1" href="admin.aspx?uc=ExTask">
                                <i class="fa-brands fa-stack-overflow"></i>  Extended Task</a>
                            <button type="button" class="dropdown-item picture1 btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" style="color: #007bff">
                                <i class="fa-regular fa-newspaper"></i>Đổi Mật Khẩu</button>
                            <a style="color: #007bff" class="dropdown-item picture1" href="index.aspx">
                                <i class="fa-sharp fa-solid fa-right-from-bracket"></i>Đăng Xuất</a>
                        </div>
                    </div>
                </div>
            </div>

            <div style="background-image: url(img/_nuxt/background/28.jpg);" class="col-sm-9 app-title">
                    <div class="row" style="width:100%;display: block; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; -webkit-box-pack: justify; -ms-flex-pack: justify; justify-content: space-between; -webkit-box-orient: horizontal; -webkit-box-direction: normal; -ms-flex-direction: row; flex-direction: row; background-color: #FFF; border-radius: .375rem; padding: 10px 30px; -webkit-box-shadow: 0 1px 2px rgb(0 0 0 / 10%); box-shadow: 0 1px 2px rgb(0 0 0 / 10%); border-left: 6px solid #FFD43B; margin-bottom: 20px;">
                        <ul class="col-sm-4 app-breadcrumb breadcrumb side">
                            <li class="breadcrumb-item active"><asp:Literal ID="Literal1" runat="server" Text=""></asp:Literal></li>
                        </ul>
                        <div align="right" class="col-sm-6" id="clock"></div>
                        <div class="col-sm-1" align="right">
                                <asp:LinkButton href="main.aspx" ID="LinkButton1" runat="server"><i class="fa-regular fa-right-from-bracket"></i></asp:LinkButton>
                        </div>
                    </div>
                    <hr />
                    <div class="container">
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server" OnLoad="PlaceHolder1_Load"></asp:PlaceHolder>
                        <asp:PlaceHolder ID="PlaceHolder2" runat="server" OnLoad="PlaceHolder1_Load"></asp:PlaceHolder>
                    </div>
            </div>
        </div>
            <!-- Modal -->
            <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <asp:Literal ID="renewpass" runat="server"></asp:Literal>
                           <h1 class="modal-title fs-5" id="exampleModalLabel">ĐỔI MẬT KHẨU</h1>                         
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
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
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                            <asp:LinkButton class="btn btn-primary" type="button" ID="txtbtnsave" runat="server" OnClick="txtbtnsave_Click">Save changes</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>

            <!-- Essential javascripts for application to work-->
            <script src="js/jquery-3.2.1.min.js"></script>
            <script src="js/popper.min.js"></script>
            <script src="js/bootstrap.min.js"></script>
            <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
            <script src="src/jquery.table2excel.js"></script>
            <script src="js/main.js"></script>
            <!-- The javascript plugin to display page loading on top-->
            <script src="js/plugins/pace.min.js"></script>
            <!-- Page specific javascripts-->
            <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.js"></script>
            <!-- Data table plugin-->
            <script type="text/javascript" src="js/plugins/jquery.dataTables.min.js"></script>
            <script type="text/javascript" src="js/plugins/dataTables.bootstrap.min.js"></script>
            <script type="text/javascript">$('#sampleTable').DataTable();</script>
            <script>
            function deleteRow(r) {
                var i = r.parentNode.parentNode.rowIndex;
                document.getElementById("myTable").deleteRow(i);
            }
            jQuery(function () {
                jQuery(".trash").click(function () {
                    swal({
                        title: "Cảnh báo",

                        text: "Bạn có chắc chắn là muốn xóa nhân viên này?",
                        buttons: ["Hủy bỏ", "Đồng ý"],
                    })
                        .then((willDelete) => {
                            if (willDelete) {
                                swal("Đã xóa thành công.!", {

                                });
                            }
                        });
                });
            });
            oTable = $('#sampleTable').dataTable();
            $('#all').click(function (e) {
                $('#sampleTable tbody :checkbox').prop('checked', $(this).is(':checked'));
                e.stopImmediatePropagation();
            });

            //EXCEL
            // $(document).ready(function () {
            //   $('#').DataTable({

            //     dom: 'Bfrtip',
            //     "buttons": [
            //       'excel'
            //     ]
            //   });
            // });


            //Thời Gian
            function time() {
                var today = new Date();
                var weekday = new Array(7);
                weekday[0] = "Chủ Nhật";
                weekday[1] = "Thứ Hai";
                weekday[2] = "Thứ Ba";
                weekday[3] = "Thứ Tư";
                weekday[4] = "Thứ Năm";
                weekday[5] = "Thứ Sáu";
                weekday[6] = "Thứ Bảy";
                var day = weekday[today.getDay()];
                var dd = today.getDate();
                var mm = today.getMonth() + 1;
                var yyyy = today.getFullYear();
                var h = today.getHours();
                var m = today.getMinutes();
                var s = today.getSeconds();
                m = checkTime(m);
                s = checkTime(s);
                nowTime = h + " giờ " + m + " phút " + s + " giây";
                if (dd < 10) {
                    dd = '0' + dd
                }
                if (mm < 10) {
                    mm = '0' + mm
                }
                today = day + ', ' + dd + '/' + mm + '/' + yyyy;
                tmp = '<span class="date"> ' + today + ' - ' + nowTime +
                    '</span>';
                document.getElementById("clock").innerHTML = tmp;
                clocktime = setTimeout("time()", "1000", "Javascript");

                function checkTime(i) {
                    if (i < 10) {
                        i = "0" + i;
                    }
                    return i;
                }
            }
            //In dữ liệu
            var myApp = new function () {
                this.printTable = function () {
                    var tab = document.getElementById('sampleTable');
                    var win = window.open('', '', 'height=700,width=700');
                    win.document.write(tab.outerHTML);
                    win.document.close();
                    win.print();
                }
            }
            //Modal
            $("#show-emp").on("click", function () {
                $("#ModalUP").modal({ backdrop: false, keyboard: false })
            });
            </script>
        
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
    </form>
</body>
</html>
