using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace webs_banlaptop
{
    public partial class admin : System.Web.UI.Page
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connect;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(App_Start.datadn.ck == true)
            {
                lbluser.Text = App_Start.datadn.user;
                if(App_Start.datadn.cknv == true)
                {
                    if (tennvck(App_Start.datadn.user) == true)
                    {
                        lbluser.Text = ten;
                       imgnv.Text = "<img style='background: #dddddd; border-radius: 50%; border: 2px solid #a1a1a1; height: 200px; margin: 20px; padding: 10px; text-align: center; width: 200px;margin-top:-50px' src='img/NhanVien/"+manv+"/1.png' />";
                    }
                }
                else
                {
                    checkadmin.Text = @"<div class='align-items-center item' style='position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);'>"
                       +"<a href='admin.aspx?uc=user' style='text-align:center ;white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;'><i class='fa-regular fa-users'></i>Quản lý Tài Khoản"
                       +"</a>"
                    +"</div>"
                    +"<div class='align-items-center item' style='position: relative; display: -webkit-box; display: -ms-flexbox; display: flex; -webkit-box-align: center; -ms-flex-align: center; align-items: center; border-radius: .375rem; margin-bottom: 10px; padding: 15px 15px; font-size: 1.08em; border-left: 0px; box-shadow: none; -webkit-transition: border-left-color 0.3s ease, background-color 0.3s ease; -o-transition: border-left-color 0.3s ease, background-color 0.3s ease; transition: border-left-color 0.3s ease, background-color 0.3s ease; color: white; border: 1px solid transparent; background: #c6defd; text-decoration: none; color: rgb(22 22 72); box-shadow: none; border: 1px solid rgb(22 22 72);'>"
                        +"<a href='admin.aspx?uc=crs' style='text-align: center; white-space: nowrap; -webkit-box-flex: 1; -ms-flex: 1 1 auto; flex: 1 1 auto; font-size: 15px; font-weight: 500;'><i class='app-menu__icon bx bx-id-card'></i>Quản lý nhân viên</a>"
                    +"</div>";
                    imgnv.Text= @"<img style='background: #dddddd; border-radius: 50%; border: 2px solid #a1a1a1; height: 200px; margin: 20px; padding: 10px; text-align: center; width: 200px;margin-top:-50px' src='img/_nuxt/icons/user.png' />";
                }
            }
            //else
            //{
            //    Response.Redirect("main.aspx");
            //}
            string uc = "";
            if(Request.QueryString["uc"] != null)
            {
                uc = Request.QueryString["uc"];
            }
            else
            {
                PlaceHolder1.Controls.Add(LoadControl("~/quantri/thong-ke/chart.ascx"));
                Literal1.Text = "<a href='admin.aspx?uc=chart'><b>Thống kê</b></a>";
            }
            
            switch (uc)
            {
                case "ExTask":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/SANPHAM/thanhtoan/NganHang/etd_task.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=ExTask'><b>Extended task</b></a>";
                    break;
                case "chart":
                    PlaceHolder1.Controls.Add(LoadControl("~/quantri/thong-ke/chart.ascx"));
                    Literal1.Text += "<a href='admin.aspx?uc=chart'><b>Thống kê</b></a>";
                    break;
                case "cf":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/HoaDon/TThoadon.ascx"));
                    Literal1.Text += "<a href='admin.aspx?uc=order'><b>Đơn Hàng</b></a><a href='admin.aspx?uc=cf'><b>  _  Xác Nhận Đơn Hàng</b></a>";
                    break;
                case "order":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/HoaDon/donhang.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=order'><b>Đơn Hàng</b></a>";
                    break;
                case "prd":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("SANPHAM/sanpham.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=prd'><b>Danh sách Sản Phẩm</b></a>";
                break;
                case "stc":
                    PlaceHolder1.Controls.Add(LoadControl("GioiThieu/GioiThieu.ascx"));
                break;
                case "cus":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/KhachHang/KhachHang.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=cus'><b>Danh Sách Thông Tin Khách Hàng</b></a>";
                break;
                case "crs":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/NhanVien/Nhanvien.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=crs'><b>Danh sách nhân viên</b></a>";
                break;
                case "user":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/quantri/admin_user.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=user'><b>Danh sách Tài Khoản</b></a>";
                break;
                case "userk":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/quantri/User_KH.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=usekr'><b>Danh sách Tài Khoản</b></a>";
                break;
                case "HD":
                    PlaceHolder1.Controls.Add(LoadControl("CHINHSACH/Huongdan.ascx"));
                break;
                case "tin":
                PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("GioiThieu/tintuc/admintt.ascx"));
                    Literal1.Text = "<a href='admin.aspx?uc=usekr'><b>Danh sách Tin  </b></a>";
                break;
            }
            string suc = "";
            if (Request.QueryString["suc"] != null)
            {
                suc = Request.QueryString["suc"];
            }

            switch (suc)
            {
                case "newcrs":
                    NhanVien.nhanvien.manv = "";
                    NhanVien.nhanvien.tennv = "";
                    NhanVien.nhanvien.cccd = "";
                    NhanVien.nhanvien.dienthoai = "";
                    NhanVien.nhanvien.diachi = "";
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/NhanVien/TTNhanVien.ascx"));
                    addnew_NV();
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=crs&suc=newcrs'><b>Thêm Mới Nhân Viên</b></a>";
                    break;
                case "updcrs":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/NhanVien/TTNhanVien.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=crs&suc=updcrs'><b>Chỉnh Sửa</b></a>";
                    break;
                case "newuser":
                    quantri.useradmin.nameuser = "";
                    quantri.useradmin.password = "";
                    quantri.useradmin.user = "";
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/quantri/upd_Is_Dl/admin_user.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=user&suc=newuser'><b>Thêm Mới Tài Khoản</b></a>";
                    break;
                case "upuser":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/quantri/upd_Is_Dl/admin_user.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=user&suc=upuser'><b>Chỉnh Sửa</b></a>";
                    break;
                case "newuserk":
                    quantri.usertkk.user = "";
                    quantri.usertkk.password = "";
                    quantri.usertkk.email = "";
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/quantri/upd_Is_Dl/Kh_user.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=user&suc=newuser'><b>Thêm Mới Tài Khoản</b></a>";
                    break;
                case "upuserk":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/quantri/upd_Is_Dl/Kh_user.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=user&suc=upuser'><b>Chỉnh Sửa</b></a>";
                    break;
                case "newcus":
                    KhachHang.Kh.makh = "KH"+ KhachHang.Kh.makhnew;
                    KhachHang.Kh.tentk = "";
                    KhachHang.Kh.tenkh = "";
                    KhachHang.Kh.diachi = "";
                    KhachHang.Kh.dienthoai = "";
                    KhachHang.Kh.email = "";
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/KhachHang/ThongtinKH.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=cus&suc=mewcus'><b>Thêm Mới Khách Hàng</b></a>";
                    break;
                case "upcus":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/KhachHang/ThongtinKH.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=cus&suc=upcus'><b>Chỉnh Sửa</b></a>";
                    break;
                case "newprd":
                    SANPHAM.product.mahh = Convert.ToString(App_Start.datadn.maxmasp+1);
                    SANPHAM.product.tenhh = "";
                    SANPHAM.product.malh = "";
                    SANPHAM.product.sl = "";
                    SANPHAM.product.slton = "";
                    SANPHAM.product.giaban = "";
                    SANPHAM.product.gianiemyet = "";
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/SANPHAM/newsp.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=prd&suc=mewprd'><b>Thêm Mới sản phẩm</b></a>";
                    break;
                case "upprd":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/SANPHAM/newsp.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=prd&suc=upprd'><b>Update sản phẩm</b></a>";
                    break;
                case "newtin":
                    GioiThieu.tintuc.tt_tintuc.img = "";
                    GioiThieu.tintuc.tt_tintuc.header = "";
                    GioiThieu.tintuc.tt_tintuc.nd = "";
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/GioiThieu/tintuc/addtintuc.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=tin&suc=mewtin'><b>Thêm Mới Tin Tức</b></a>";
                    break;
                case "uptin":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/GioiThieu/tintuc/addtintuc.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=tin&suc=uptin'><b>Update sản phẩm</b></a>";
                    break;
                case "HD":
                    PlaceHolder1.Controls.Add(LoadControl("CHINHSACH/Huongdan.ascx"));
                    break;
            }
            string addc = "";
            if (Request.QueryString["addc"] != null)
            {
                addc = Request.QueryString["addc"];
            }
            switch (addc)
            {
                case "ncc":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/SANPHAM/load-ncc-lh/addncc.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc="+uc+"&suc="+suc+"'><b>Thêm Mới Nhà Cung Cấp</b></a>";
                    break;
                case "lh":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/SANPHAM/load-ncc-lh/LoaiHang.ascx"));
                    Literal1.Text += "<a>_</a><a href='admin.aspx?uc=" + uc + "&suc=" + suc + "'><b>Thêm Mới Nhà Cung Cấp</b></a>";
                    break;
            }
            string wart = "";
            if(Request.QueryString["wart"] != null)
            {
                wart = Request.QueryString["wart"];
            }
            switch (wart)
            {
                case "ttcht":
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/SANPHAM/tt_sp.ascx"));
                    break;
            }
        }
        protected void addnew_NV()
        {
            var numbernv = NhanVien.nhanvien.manvmax;
            numbernv = numbernv.Replace("NV", "0");
            int manv = Convert.ToInt32(numbernv);
            int manvnew = manv + 1;
            NhanVien.nhanvien.manv = "NV" + manvnew;
        }
        protected void PlaceHolder1_Load(object sender, EventArgs e)
        {

        }

        protected void txtbtnsave_Click(object sender, EventArgs e)
        {
            
        }
        string ten = "";
        string manv = "";
        public bool tennvck(string a)
        {
            connect = new SqlConnection(sqlcon);
            connect.Open();
            string sql = "select * from tbl_NhanVien where DienThoai='" + a + "'";
            command = new SqlCommand(sql, connect);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                ten = dt.Rows[0]["TenNV"].ToString();
                manv = dt.Rows[0]["MaNV"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}