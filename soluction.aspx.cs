using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop
{
    public partial class soluction : System.Web.UI.Page
    {
        string piclaptop = App_Start.datadn.pic;
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        DataTable dttable;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ckctt();
                ncc();
                string uc = "";
                if (Request.QueryString["uc"] != null)
                {
                    uc = Request.QueryString["uc"];
                }

                //switch (uc)
                //{
                //    case "clg":
                //        PlaceHolder1.Controls.Add(LoadControl("CHINHSACH/Huongdan.ascx"));
                //        break;
                //    case "stc":
                //        PlaceHolder1.Controls.Add(LoadControl("GioiThieu/GioiThieu.ascx"));
                //        break;
                //    case "cus":
                //        PlaceHolder1.Controls.Add(LoadControl("CHINHSACH/Huongdan.ascx"));
                //        break;

                //}

                lbluser.Text = App_Start.datadn.user;

                if (lbluser.Text == "")
                {
                    shopcard();
                    Literal1.Text = "<a class='dropdown-item picture1' id='acc' href='main.aspx'><img src='img/7/acer.png'>Đăng Nhập</a>";
                    logout.Visible = false;
                }
                else
                {
                    shopcard();
                    thongbaocart();
                    Literal1.Text = "";
                    logout.Visible = true;
                }

                switch (uc)
                {
                    case "Nction":
                        thongbaocart();
                        PlaceHolder2.Controls.Clear();
                        PlaceHolder2.Controls.Add(LoadControl("~/GioiThieu/ThongBao/Nction.ascx"));
                        break;
                    case "cusit":
                        PlaceHolder2.Controls.Clear();
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/thanhtoan/cusit.ascx"));
                        break;
                    case "upgh":
                        PlaceHolder2.Controls.Clear();
                        PlaceHolder2.Controls.Add(LoadControl("GioHang/update.ascx"));
                        break;
                    case "ph":
                        PlaceHolder2.Controls.Clear();
                        PlaceHolder2.Controls.Add(LoadControl("GioiThieu/phanhoihk/PH.ascx"));
                        break;
                    case "gh":
                        PlaceHolder2.Controls.Add(LoadControl("GioHang/GioHang.ascx"));
                        break;
                    case "quality":
                        PlaceHolder2.Controls.Add(LoadControl("CHINHSACH/cs_chatluong.ascx"));
                        break;
                    case "sp1":
                        App_Start.datadn.numberuc = 1;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp2":
                        App_Start.datadn.numberuc = 2;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp3":
                        App_Start.datadn.numberuc = 3;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp4":
                        App_Start.datadn.numberuc = 4;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp5":
                        App_Start.datadn.numberuc = 5;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp6":
                        App_Start.datadn.numberuc = 6;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp7":
                        App_Start.datadn.numberuc = 7;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp8":
                        App_Start.datadn.numberuc = 8;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp9":
                        App_Start.datadn.numberuc = 9;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp10":
                        App_Start.datadn.numberuc = 10;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp11":
                        App_Start.datadn.numberuc = 11;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp12":
                        App_Start.datadn.numberuc = 12;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp13":
                        App_Start.datadn.numberuc = 13;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp14":
                        App_Start.datadn.numberuc = 14;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp15":
                        App_Start.datadn.numberuc = 15;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp16":
                        App_Start.datadn.numberuc = 16;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp17":
                        App_Start.datadn.numberuc = 17;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "sp18":
                        App_Start.datadn.numberuc = 18;
                        PlaceHolder2.Controls.Add(LoadControl("SANPHAM/ChiTietSP.ascx"));
                        break;
                    case "stc":
                        PlaceHolder2.Controls.Add(LoadControl("GioiThieu/GioiThieu.ascx"));
                        break;
                    case "cus":
                        PlaceHolder2.Controls.Add(LoadControl("CHINHSACH/Huongdan.ascx"));
                        break;
                    case "TTKH":
                        PlaceHolder2.Controls.Add(LoadControl("~/KhachHang/ThongtinKH.ascx"));
                        break;
                    case "buyn":
                        PlaceHolder2.Controls.Add(LoadControl("~/SANPHAM/thanhtoan/thanhtoan.ascx"));
                        break;
                    case "cart":
                        PlaceHolder2.Controls.Add(LoadControl("~/SANPHAM/thanhtoan/thanhtoan.ascx"));
                        break;
                    case "tt":
                        PlaceHolder1.Controls.Clear();
                        PlaceHolder2.Controls.Clear();
                        PlaceHolder2.Controls.Add(LoadControl("~/GioiThieu/tintuc/tin.ascx"));
                        break;
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);
            }
        }
        protected void ckctt()
        {
            plcethanhtoan.Controls.Add(LoadControl("~/SANPHAM/thanhtoan/NganHang/ThanhToanKD.ascx"));
        }
        protected void ncc()
        {
            try
            {
                txtlistdm.Text = "";
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select * from tbl_NhaCC where TenNCC!=''";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ucncc = dt.Rows[i][1].ToString();
                        checkncc(ucncc);
                        txtlistdm.Text += "<a class='dropdown-item picture1' href='index.aspx?uc=" + ucncc + "'><img src='img/7/" + dt.Rows[i][1].ToString() + ".png'>" + dt.Rows[i][1].ToString() + "</a>";

                    }
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);
            }
            
        }
        string ucncc = "";
        protected void checkncc(string name)
        {
            switch (name)
            {
                case "lenovo":
                    ucncc = "lnv";
                    break;
                case "razer":
                    ucncc = "raz";
                    break;
                case "microsoft":
                    ucncc = "mrs";
                    break;
            }
        }
        protected void recheckuc(string name)
        {
            switch (name)
            {
                case "lnv":
                    ucncc = "lenovo";
                    break;
                case "raz":
                    ucncc = "razer";
                    break;
                case "mrs":
                    ucncc = "microsoft";
                    break;
            }
        }
        protected void shopcard()
        {
            if (App_Start.datadn.user != "")
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select * from GioHang where TenTK='" + App_Start.datadn.user + "'";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    shopcardlt.Text = "<a href=soluction.aspx?uc=gh><div class='shop-cart-number-badge'>" + dt.Rows.Count + "</div></a>";
                }
            }
            else
            {
                if (GioHang.datagiohang.dt1.Rows.Count > 0)
                {
                    shopcardlt.Text = "<a href=soluction.aspx?uc=gh><div class='shop-cart-number-badge'>" + GioHang.datagiohang.dt1.Rows.Count + "</div></a>";
                }
            }
        }
        protected void thongbaocart()
        {
            if (App_Start.datadn.user != "")
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select * from Thongbao where TT='1' and TenTK='" + App_Start.datadn.user + "'";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    thongbaocartlbl.Text = "<a href=soluction.aspx?uc=Nction><div class='shop-cart-number-badge'>" + dt.Rows.Count + "</div></a>";
                }
            }
            else
            {
                if (GioHang.datagiohang.dt1.Rows.Count > 0)
                {
                    thongbaocartlbl.Text = "<a href=soluction.aspx?uc=Nction><div class='shop-cart-number-badge'>" + GioHang.datagiohang.dt1.Rows.Count + "</div></a>";
                }
            }
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            Literal1.Text = "<a class='dropdown-item picture1' id='acc' href='main.aspx'><img src='img/7/acer.png'>Đăng Nhập</a>";
            lbluser.Text = "";
            App_Start.datadn.user = "";
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            App_Start.datadn.name = txt1x.Text;
        }

        protected void txt1x_Disposed(object sender, EventArgs e)
        {
            App_Start.datadn.name = txt1x.Text;
            Response.Redirect("index.aspx?uc=search");
        }

        protected void txtbtnsave_Click(object sender, EventArgs e)
        {
            if (App_Start.datadn.password == App_Start.password.Hash(App_Start.password.Encrypt(password1.Text)))
            {
                bool checkup = true;
                App_Start.datadn.password = App_Start.password.Hash(App_Start.password.Encrypt(password1.Text));
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "";
                if (password2.Text == password3.Text)
                {
                    if (App_Start.datadn.ck == true)
                    {
                        sql = "update tbl_Admin set MatKhau='" + App_Start.password.Encrypt(password2.Text) + "' where TaiKhoan='" + App_Start.datadn.user + "'";
                    }
                    else
                    {
                        sql = "update tbl_TKKhach set MatKhau='" + App_Start.password.Encrypt(password2.Text) + "' where TenTk='" + App_Start.datadn.user + "'";
                    }
                    command = new SqlCommand(sql, connection);
                    command.ExecuteReader();
                    command.Cancel();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Đổi Mật Khẩu Thành Công!')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mật Khẩu mới Không Khớp!')", true);
                }
            }
        }
    }
}