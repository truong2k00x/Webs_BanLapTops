﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangky.aspx" Inherits="webs_banlaptop.dangky" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>admin</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Main CSS-->
    <link rel="stylesheet" type="text/css" href="css/main.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css">
    <!-- or -->
    <link rel="stylesheet" href="https://unpkg.com/boxicons@latest/css/boxicons.min.css">

    <link rel="Shortcut Icon" type="img/png" href="img/_nuxt/icons/logoweb.png" />
    <link rel="stylesheet" href="full.css" />
    <link rel="stylesheet" href="css/admin.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="bootstrap-5.3.0-alpha1/dist/css/bootstrap-grid.min.css" />
    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/fontawesome.css" />
    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/brands.css" />

    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/solid.css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.3/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>

    <link rel="stylesheet" href="fontawesome-free-6.3.0-web/css/v5-font-face.css" />
    <!-- Font-icon css-->
    <link rel="stylesheet" type="text/css"
        href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js"></script>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css">
</head>
<body onload="time()" class="app sidebar-mini rtl">
    <form id="form1" runat="server">
        <div class="row">
            <!-- Button trigger modal -->
            <div class="col-sm-3" style="height:auto; background-color:aqua">
                <div style="display:inline" class="fa-font-awesome-logo-full align-content-lg-center">
                    <img src="img/_nuxt/icons/logoweb.png" width="100px" height="auto" alt="logo" />

                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navcontrol" aria-controls="navcontrol" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                </div>
                <div id="navcontrol" class="nav-item">
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="#" style="white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class='app-menu__icon bx bx-id-card'></i>Quản lý nhân viên</a>
                    </div>
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="#" style="white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class='app-menu__icon bx bx-user-voice'></i>Quản lý khách hàng</a>
                    </div>
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="#" style="white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i
                            class='app-menu__icon bx bx-purchase-tag-alt'></i>Quản lý sản phẩm<</a>
                    </div>
                    <div class="align-items-center item" style="position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);">
                        <a href="#" style="white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;"><i class='app-menu__icon bx bx-task'></i>Quản lý đơn hàng</a>
                    </div>
                </div>
            </div>

            <div class="col-sm-9 app-title">
                <header>
                    <div class="row" style="display: block; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; -webkit-box-pack: justify; -ms-flex-pack: justify; justify-content: space-between; -webkit-box-orient: horizontal; -webkit-box-direction: normal; -ms-flex-direction: row; flex-direction: row; background-color: #FFF; border-radius: .375rem; padding: 10px 30px; -webkit-box-shadow: 0 1px 2px rgb(0 0 0 / 10%); box-shadow: 0 1px 2px rgb(0 0 0 / 10%); border-left: 6px solid #FFD43B; margin-bottom: 20px;">
                        <ul class="col-sm-4 app-breadcrumb breadcrumb side">
                            <li class="breadcrumb-item active"><a href="#"><b>Danh sách nhân viên</b></a></li>
                        </ul>
                        <div align="right" class="col-sm-8" id="clock"></div>
                    </div>
                </header>
                <main>
                    <div class="row element-button">
                        <div class="col-sm-2">

                            <a class="btn btn-add btn-sm" href="#" title="Thêm"><i class="fas fa-plus"></i>
                                Tạo mới nhân viên</a>
                        </div>
                        <div class="col-sm-2">
                            <a class="btn btn-delete btn-sm nhap-tu-file" type="button" title="Nhập" onclick="myFunction(this)"><i
                                class="fas fa-file-upload"></i>Tải từ file</a>
                        </div>

                        <div class="col-sm-2">
                            <a class="btn btn-delete btn-sm print-file" type="button" title="In" onclick="myApp.printTable()"><i
                                class="fas fa-print"></i>In dữ liệu</a>
                        </div>
                        <div class="col-sm-2">
                            <a class="btn btn-delete btn-sm print-file js-textareacopybtn" type="button" title="Sao chép"><i
                                class="fas fa-copy"></i>Sao chép</a>
                        </div>

                        <div class="col-sm-2">
                            <a class="btn btn-excel btn-sm" href="#" title="In"><i class="fas fa-file-excel"></i>Xuất Excel</a>
                        </div>
                        <div class="col-sm-2">
                            <a class="btn btn-delete btn-sm pdf-file" type="button" title="In" onclick="myFunction(this)"><i
                                class="fas fa-file-pdf"></i>Xuất PDF</a>
                        </div>
                        <div class="col-sm-2">
                            <a class="btn btn-delete btn-sm" type="button" title="Xóa" onclick="myFunction(this)"><i
                                class="fas fa-trash-alt"></i>Xóa tất cả </a>
                        </div>
                    </div>
                </main>
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
            //     //Sao chép dữ liệu
            //     var copyTextareaBtn = document.querySelector('.js-textareacopybtn');

            // copyTextareaBtn.addEventListener('click', function(event) {
            //   var copyTextarea = document.querySelector('.js-copytextarea');
            //   copyTextarea.focus();
            //   copyTextarea.select();

            //   try {
            //     var successful = document.execCommand('copy');
            //     var msg = successful ? 'successful' : 'unsuccessful';
            //     console.log('Copying text command was ' + msg);
            //   } catch (err) {
            //     console.log('Oops, unable to copy');
            //   }
            // });


            //Modal
            $("#show-emp").on("click", function () {
                $("#ModalUP").modal({ backdrop: false, keyboard: false })
            });
        </script>
    </form>
</body>
</html>