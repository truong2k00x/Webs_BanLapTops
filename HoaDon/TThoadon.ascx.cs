using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.HoaDon
{
    public partial class TThoadon : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        string tentk = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            hoadon.Text = "";
            mahd.Text = clsHD.mahd;
            if(clsHD.check == false)
            {
                string sql = "select hd.*,cthd.*,hh.TenHang from tbl_HDban hd inner join CT_HDBan cthd on hd.MaHD=cthd.MaHD inner join tbl_HangHoa hh on cthd.MaHH=hh.MaHH where hd.MaHD='" + clsHD.mahd+"'";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                sqlDataReader.Close();
                loadtt(Convert.ToInt32(dt.Rows[0]["MaTrangThai"].ToString()));
                if(dt.Rows[0]["MaKH"].ToString() != "")
                {
                    tentk = checktentk(dt.Rows[0]["MaKH"].ToString());
                }
                for (int i=0;i<dt.Rows.Count; i++)
                {
                    string mahh = dt.Rows[i]["TenHang"].ToString();
                    hoadon.Text += "<div style='background-color:#C0C0C0' class='row'><div class='col-sm-2'><img width='100%' height='100%' src='../img/SP/anh san pham/" +mahh+"/1.png' /></div><div class='col-sm-5'><div class='row'>"
                    + "<div class='col-sm-6'><b><div style='margin-top: 20px'>Sản Phẩm:</div>"
                    + "<div style='margin-top: 20px'>Số lượng:</div><div style='margin-top: 20px'>Đơn Giá:</div>"
                    + "<div style='margin-top: 20px'>Thành Tiền:</div><div style='margin-top: 20px'>Ngày Đặt Hàng:</div>"
                    + "</b></div><div class='col-sm-6'><div style='margin-top: 20px'>"+dt.Rows[i]["TenHang"].ToString()+ "</div><div style='margin-top: 20px'>" + dt.Rows[i]["sl"].ToString() + "</div>"
                    + "<div style='margin-top: 20px'>" + dt.Rows[i]["GiaBan"].ToString() + "</div><div style='margin-top: 20px'>" + Convert.ToString(Convert.ToInt32(dt.Rows[i]["sl"].ToString())*Convert.ToInt32(dt.Rows[i]["GiaBan"].ToString())) + "</div><div style='margin-top: 20px'>" + dt.Rows[i]["NgayLap"].ToString() + "</div>"
                    + "</div></div></div>"
                    + "<div class='col-sm-5'><div class='row'><div class='col-sm-6'><b><div style='margin-top: 20px'>Họ Tên:</div>"
                    + "<div style='margin-top: 20px'>Địa Chỉ:</div><div style='margin-top: 20px'>Số Điện Thoại:</div>"
                    + "<div style='margin-top: 20px'>Email:</div><div style='margin-top: 20px'>Trạng Thái Đơn Hàng:</div>"
                    + "</b></div><div class='col-sm-6'><div style='margin-top: 20px'>" + dt.Rows[i]["HoTen"].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i]["DiaChi"].ToString() + "</div>"
                    + "<div style='margin-top: 20px'>" + dt.Rows[i]["DienThoai"].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i]["email"].ToString() + "</div><div style='margin-top: 20px'>" + trangthai(dt.Rows[i]["MaTrangThai"].ToString()) + "</div>"
                    + "</div></div></div></div><hr style='height:10px;width:100%;background-color:white' />";
                }
            }
            else
            {
                //string sql = "select dh.*,hh.TenHang from DONHANG dh inner join tbl_HangHoa hh on dh.MaHH=hh.MaHH where dh.MaDon='"+clsHD.mahd+"'";
                //command = new SqlCommand(sql, connection);
                //SqlDataReader sqlDataReader = command.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(sqlDataReader);
                //loadtt(Convert.ToInt32(dt.Rows[0]["MaTrangThai"].ToString()));
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    string tenhh = dt.Rows[i]["TenHang"].ToString();
                //    hoadon.Text = "<div class='row'><div class='col-sm-2'><img width='100%' height='100%' src='../img/SP/anh san pham/" + tenhh + "/1.png' /></div><div class='col-sm-5'><div class='row'>"
                //    + "<div class='col-sm-6'><b><div style='margin-top: 20px'>Sản Phẩm:</div>"
                //    + "<div style='margin-top: 20px'>Số lượng:</div><div style='margin-top: 20px'>Đơn Giá:</div>"
                //    + "<div style='margin-top: 20px'>Thành Tiền:</div><div style='margin-top: 20px'>Ngày Đặt Hàng:</div>"
                //    + "</b></div><div class='col-sm-6'><div style='margin-top: 20px'>" + dt.Rows[i][12].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i][2].ToString() + "</div>"
                //    + "<div style='margin-top: 20px'>" + dt.Rows[i][3].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i][4].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i][9].ToString() + "</div>"
                //    + "</div></div></div>"
                //    + "<div class='col-sm-5'><div class='row'><div class='col-sm-6'><b><div style='margin-top: 20px'>Họ Tên:</div>"
                //    + "<div style='margin-top: 20px'>Địa Chỉ:</div><div style='margin-top: 20px'>Số Điện Thoại:</div>"
                //    + "<div style='margin-top: 20px'>Email:</div><div style='margin-top: 20px'>Trạng Thái Đơn Hàng:</div>"
                //    + "</b></div><div class='col-sm-6'><div style='margin-top: 20px'>" + dt.Rows[i][5].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i][6].ToString() + "</div>"
                //    + "<div style='margin-top: 20px'>" + dt.Rows[i][7].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i][8].ToString() + "</div><div style='margin-top: 20px'>" + dt.Rows[i][11].ToString() + "</div>"
                //    + "</div></div></div></div><hr style='height:10px;width:100%;background-color:white' />";
                //}
            }
        }
        public string trangthai(string a)
        {
            string sql = "select * from tbl_TTDON where MaTrangThai='" + a + "'";
            command = new SqlCommand(sql,connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dts = new DataTable();
            dts.Load(dataReader);
            dataReader.Close();
            command.Cancel();
            return dts.Rows[0]["TenTrangThai"].ToString();
        } 
        public string checktentk(string a)
        {
            string sql = "select * from tbl_KH where MaKH='" + a + "'";
            command = new SqlCommand(sql,connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dts = new DataTable();
            dts.Load(dataReader);
            dataReader.Close();
            command.Cancel();
            return dts.Rows[0]["TenTK"].ToString();
        }
        public void magg()
        {
            hoadon.Text = "<div class='row'><div class='col-sm-6'><div class='row'>"
            + "<div class='col-sm-6'><b><div style='margin-top: 20px'>Sản Phẩm:</div>"
            + "<div style='margin-top: 20px'>Số lượng:</div><div style='margin-top: 20px'>Đơn Giá:</div>"
            + "<div style='margin-top: 20px'>Thành Tiền:</div><div style='margin-top: 20px'>Ngày Đặt Hàng:</div>"
            + "</b></div><div class='col-sm-6'><div style='margin-top: 20px'>90232</div><div style='margin-top: 20px'>90232</div>"
            + "<div style='margin-top: 20px'>90232</div><div style='argin-top: 20px'>90232</div><div style='margin-top: 20px'>90232</div>"
            + "</div></div></div>"
            + "<div class='col-sm-6'><div class='row'><div class='col-sm-6'><b><div style='margin-top: 20px'>Họ Tên:</div>"
            + "<div style='margin-top: 20px'>Địa Chỉ:</div><div style='margin-top: 20px'>Số Điện Thoại:</div>"
            + "<div style='margin-top: 20px'>Email:</div><div style='margin-top: 20px'>Trạng Thái Đơn Hàng:</div>"
            + "</b></div><div class='col-sm-6'><div style='margin-top: 20px'>90232</div><div style='margin-top: 20px'>90232</div>"
            + "<div style='margin-top: 20px'>90232</div><div style='margin-top: 20px'>90232</div><div style='margin-top: 20px'>90232</div>"
            + "</div></div></div></div>";
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin?uc=order");
        }
        public void loadtt(int a)
        {
            DropDownList1.Items.Clear();
            string sql = "select * from tbl_TTDON";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            TRANGTHAI.Text = dt.Rows[a]["TenTrangThai"].ToString();
            for(int i = a; i < dt.Rows.Count; i++)
            {
                ListItem ls = new ListItem();
                ls.Value = dt.Rows[i]["MaTrangThai"].ToString();
                ls.Text = dt.Rows[i]["TenTrangThai"].ToString();
                DropDownList1.Items.Add(ls);
            }
            DropDownList1.SelectedIndex =0;
        }
       
        protected void btn_Click(object sender, EventArgs e)
        {
            DateTime dtime = new DateTime();
            dtime = DateTime.Now;
            string year = Convert.ToString(dtime.Year);
            string month = Convert.ToString(dtime.Month);
            string day = Convert.ToString(dtime.Day);
            string str = Convert.ToString(dtime);
            str = str.Remove(str.Length - 3, 3);
            str = str.Remove(0, 11);
            string dateup = year + "-" + month + "-" + day + " " + str;
            if (clsHD.check == false)
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "update tbl_HDban set MaTrangThai='"+DropDownList1.SelectedItem.Value+"' where MaHD='" + clsHD.mahd + "'";
                command = new SqlCommand(sql, connection);
                command.ExecuteReader();
                command.Cancel();

                Response.Redirect("admin.aspx?uc=order");
            }
            else
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "update DONHANG set TrangThai=N'Đã Xác Nhận',MaTrangThai='" + DropDownList1.SelectedItem.Value + "' where MaDon='" + clsHD.mahd + "'";
                command = new SqlCommand(sql, connection);
                command.ExecuteReader();
                command.Cancel();
                Response.Redirect("admin.aspx?uc=order");
            }
        }
    }
}