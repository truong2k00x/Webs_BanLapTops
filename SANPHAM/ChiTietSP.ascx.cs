using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.SANPHAM
{
    public partial class ChiTietSP : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        string piclaptop = App_Start.datadn.pic;
        int a;
        string maspsl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            
            switch (App_Start.datadn.numberuc)
            {
                case 1:
                    a = App_Start.datadn.masp1;
                    maspsl = Convert.ToString(App_Start.datadn.masp1.ToString());
                    break;
                case 2:
                    a = App_Start.datadn.masp2;
                    maspsl = Convert.ToString(App_Start.datadn.masp2.ToString());
                    break;
                case 3:
                    a = App_Start.datadn.masp3;
                    maspsl = Convert.ToString(App_Start.datadn.masp3.ToString());
                    break;
                case 4:
                    a = App_Start.datadn.masp4;
                    maspsl = Convert.ToString(App_Start.datadn.masp4.ToString());
                    break;
                case 5:
                    a = App_Start.datadn.masp5;
                    maspsl = Convert.ToString(App_Start.datadn.masp5.ToString());
                    break;
                case 6:
                    a = App_Start.datadn.masp6;
                    maspsl = Convert.ToString(App_Start.datadn.masp6.ToString());
                    break;
                case 7:
                    a = App_Start.datadn.masp7;
                    maspsl = Convert.ToString(App_Start.datadn.masp7.ToString());
                    break;
                case 8:
                    a = App_Start.datadn.masp8;
                    maspsl = Convert.ToString(App_Start.datadn.masp8.ToString());
                    break;
                case 9:
                    a = App_Start.datadn.masp9;
                    maspsl = Convert.ToString(App_Start.datadn.masp9.ToString());
                    break;
                case 10:
                    a = App_Start.datadn.masp10;
                    maspsl = Convert.ToString(App_Start.datadn.masp10.ToString());
                    break;
                case 11:
                    a = App_Start.datadn.masp11;
                    maspsl = Convert.ToString(App_Start.datadn.masp11.ToString());
                    break;
                case 12:
                    a = App_Start.datadn.masp12;
                    maspsl = Convert.ToString(App_Start.datadn.masp12.ToString());
                    break;
                case 13:
                    a = App_Start.datadn.masp13;
                    maspsl = Convert.ToString(App_Start.datadn.masp13.ToString());
                    break;
                case 14:
                    a = App_Start.datadn.masp14;
                    maspsl = Convert.ToString(App_Start.datadn.masp14.ToString());
                    break;
                case 15:
                    a = App_Start.datadn.masp15;
                    maspsl = Convert.ToString(App_Start.datadn.masp15.ToString());
                    break;
                case 16:
                    a = App_Start.datadn.masp16;
                    maspsl = Convert.ToString(App_Start.datadn.masp16.ToString());
                    break;
                case 17:
                    a = App_Start.datadn.masp17;
                    maspsl = Convert.ToString(App_Start.datadn.masp17.ToString());
                    break;
                case 18:
                    a = App_Start.datadn.masp18;
                    maspsl = Convert.ToString(App_Start.datadn.masp18.ToString());
                    break;
            }

            string sql = "select * from tbl_HangHoa hh inner join tbl_ttHH tt on tt.MaHH=hh.MaHH where hh.MaHH='"+maspsl+"'";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            int row =0;
            int maHH = Convert.ToInt32(dataTable.Rows[row][0].ToString());
            string TenHH = Convert.ToString(dataTable.Rows[row][1].ToString());

            double amount = Convert.ToInt32(dataTable.Rows[row][7].ToString());
            string fomatamount = amount.ToString("#,##0");

            Literal1.Text = "<div class='carousel-item active'><img src='" + piclaptop + TenHH + "/1.png' alt='Los Angeles' width='1100' height='500' ></div>"+ "<div class='carousel-item'><img src='" + piclaptop + TenHH + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>"+ "<div class='carousel-item'><img src='" + piclaptop + TenHH + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp.Text += "<p style='color: black;'>[Mới 100%]" + TenHH + @"</p>";
            TTsp.Text += "<p style='color: #ff1a1a;'>Giá Sản Phẩm:   <span>" + fomatamount + @"<sup>VND</sup></span></p>";
            
            //TTCTSP.Text = "<p>"+ Convert.ToString(dataTable.Rows[row][8].ToString()) +"<br>"
            //    + Convert.ToString(dataTable.Rows[row][9].ToString())+"<br>"</p>";
            TTCTSP.Text += "<br><br><br><br><br><p>odell: " + Convert.ToString(dataTable.Rows[row][10].ToString()) + @"</p>";
            TTCTSP.Text += "<p>CPU:  " + Convert.ToString(dataTable.Rows[row][11].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Memory:  " + Convert.ToString(dataTable.Rows[row][12].ToString()) + @"</p>";
            TTCTSP.Text += "<p>SSD:  " + Convert.ToString(dataTable.Rows[row][13].ToString()) + @"</p>";
            TTCTSP.Text += "<p>VGA:  " + Convert.ToString(dataTable.Rows[row][14].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Display:  " + Convert.ToString(dataTable.Rows[row][15].ToString()) + @"</p>";
            TTCTSP.Text += "<p>bàn Phím:  " + Convert.ToString(dataTable.Rows[row][16].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Camera:  " + Convert.ToString(dataTable.Rows[row][17].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Audio:  " + Convert.ToString(dataTable.Rows[row][18].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Other:  " + Convert.ToString(dataTable.Rows[row][19].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Wireless:  " + Convert.ToString(dataTable.Rows[row][20].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Battery:  " + Convert.ToString(dataTable.Rows[row][21].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Weight:  " + Convert.ToString(dataTable.Rows[row][22].ToString()) + @"</p>";
            TTCTSP.Text += "<p>SoftWare:  " + Convert.ToString(dataTable.Rows[row][23].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Xuất xứ:  " + Convert.ToString(dataTable.Rows[row][24].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Mầu Sắc:  " + Convert.ToString(dataTable.Rows[row][25].ToString()) + @"</p>";
            TTCTSP.Text += "<p>Bảo hành:  " + Convert.ToString(dataTable.Rows[row][26].ToString()) + @" tháng</p>";
            //string uc = "";
            //if (Request.QueryString["uc"] != null)
            //{
            //    uc = Request.QueryString["uc"];
            //}
            //switch (uc)
            //{
            //    case "sp1":
            //        App_Start.datadn.numberuc = 1;
            //        break;
            //}
            //for(int i = 1; i <= 18; i++)
            //{

            //}
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            if (App_Start.datadn.user == "")
            {
                if(GioHang.datagiohang.dt1.Rows.Count == 0)
                {
                    GioHang.datagiohang.addcolumn();
                    connection = new SqlConnection(sqlcon);
                    connection.Open();
                    string sql = "select * from tbl_HangHoa where MaHH='" + maspsl + "'";
                    command = new SqlCommand(sql, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    int c = 1;
                    GioHang.datagiohang.addsp(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), c, dt.Rows[0][7].ToString());
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Add to Cart Successfully')", true);
                }
                else
                {
                    connection = new SqlConnection(sqlcon);
                    connection.Open();
                    string sql = "select * from tbl_HangHoa where MaHH='" + maspsl + "'";
                    command = new SqlCommand(sql, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    int c = 1;
                    GioHang.datagiohang.addsp(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), c, dt.Rows[0][7].ToString());
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Add to Cart Successfully')", true);
                }
            }
            else
            {
                string ssqlcheck = "select * from GioHang where MaHH='" + a + "'";
                connection = new SqlConnection(sqlcon);
                connection.Open();
                command = new SqlCommand(ssqlcheck, connection);
                SqlDataReader sqldatareader = command.ExecuteReader();
                DataTable dt113 = new DataTable();
                dt113.Load(sqldatareader);
                command.Cancel();
                if (Convert.ToInt32(dt113.Rows.Count.ToString()) == 0)
                {
                    string ssqladd = "insert into GioHang values('" + a + "','" + App_Start.datadn.user + "','1','')";
                    command = new SqlCommand(ssqladd, connection);
                    command.ExecuteReader();
                }
                else
                {
                    string ssqladd = "update GioHang set TenTK='" + App_Start.datadn.user + "',sl=sl+1 where MaHH='" + a + "'";
                    command = new SqlCommand(ssqladd, connection);
                    command.ExecuteReader();
                }
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Add to Cart Successfully')", true);
            }
            string uc = "";
            if (Request.QueryString["uc"] != null)
            {
                uc = Request.QueryString["uc"];
            }
            Response.Redirect("soluction.aspx?uc=" + uc + "");
        }

        protected void btnmua_Click(object sender, EventArgs e)
        {
            if (App_Start.datadn.user == "")
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql1 = "select TenHang,GiaBan from tbl_HangHoa where MaHH='" + a + "'";
                command = new SqlCommand(sql1, connection);
                SqlDataReader data2 = command.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(data2);
                SANPHAM.thanhtoan.TTthanhtoan.MaHH = Convert.ToString(a);
                SANPHAM.thanhtoan.TTthanhtoan.tenHang = dt2.Rows[0][0].ToString();
                SANPHAM.thanhtoan.TTthanhtoan.GiaBan = Convert.ToInt32(dt2.Rows[0][1].ToString());
                if (SANPHAM.thanhtoan.TTthanhtoan.MaKh == "")
                {
                    App_Start.dataindex.checkedbuy = 1;
                    Response.Redirect("soluction.aspx?uc=cusit");
                }
                else
                {
                    Response.Redirect("soluction.aspx?uc=buyn");
                }
            }
            else
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select * from tbl_KH where TenTK='" + App_Start.datadn.user + "'";
                command = new SqlCommand(sql, connection);
                SqlDataReader data = command.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(data);
                if (dt1.Rows.Count > 0)
                {
                    SANPHAM.thanhtoan.TTthanhtoan.MaKh = dt1.Rows[0][0].ToString();
                    SANPHAM.thanhtoan.TTthanhtoan.tenkh = dt1.Rows[0][1].ToString();
                    SANPHAM.thanhtoan.TTthanhtoan.diachi = dt1.Rows[0][2].ToString();
                    SANPHAM.thanhtoan.TTthanhtoan.sdt = dt1.Rows[0][3].ToString();
                    SANPHAM.thanhtoan.TTthanhtoan.email = dt1.Rows[0][4].ToString();
                    command.Cancel();
                    string sql1 = "select TenHang,GiaBan from tbl_HangHoa where MaHH='" + a + "'";
                    command = new SqlCommand(sql1, connection);
                    SqlDataReader data2 = command.ExecuteReader();
                    DataTable dt2 = new DataTable();
                    dt2.Load(data2);
                    SANPHAM.thanhtoan.TTthanhtoan.MaHH = Convert.ToString(a);
                    SANPHAM.thanhtoan.TTthanhtoan.tenHang = dt2.Rows[0][0].ToString();
                    SANPHAM.thanhtoan.TTthanhtoan.GiaBan = Convert.ToInt32(dt2.Rows[0][1].ToString());
                    Response.Redirect("soluction.aspx?uc=buyn");
                }
                else
                {
                    Response.Redirect("soluction.aspx?uc=TTKH");
                }
            }
        }
    }
}