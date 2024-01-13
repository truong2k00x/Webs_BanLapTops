using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.SANPHAM.thanhtoan
{
    public partial class thanhtoan : System.Web.UI.UserControl
    {
        string piclaptop = App_Start.datadn.pic;
        DataTable dt = new DataTable();
        string sqlcon = App_Start.datadn.sql;

        string sqlcon1 = App_Start.datadn.sql1;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            connect();
            loadncc();
            btntt.Text = "";
            if (NganHang.ApiBank_Request.mabank == "PT001")
            {
                Literaltt.Text = "<b>Thanh Toán Khi Nhận Hàng</b>";
            }
            else
            {
                Literaltt.Text = "<b>Thanh Toán Chuyển Khoản</b>";
            }
            if (App_Start.datadn.user == "")
            {
                Literaltd.Text = "<a href='soluction.aspx?uc=cusit'>Thay Đổi</a>";
            }
            else
            {
                loaddc();
                Literaltd.Text = "<linkbutton style='background-color: white; color: blue' type='button' data-bs-toggle='modal' data-bs-target='#exampleModal1'>" +
                                     "<b>Thay Đổi</b>" +
                                  "</linkbutton>";
            }

            //PlaceHolder1.Controls.Add(LoadControl("~/SANPHAM/thanhtoan/NganHang/loadnh.ascx"));
            TenKH.Text = TTthanhtoan.tenkh;
            SDT.Text = TTthanhtoan.sdt;
            diachi.Text = TTthanhtoan.diachi;
            email.Text = TTthanhtoan.email;
            string uc = "";
            if (Request.QueryString["uc"] != null)
            {
                uc = Request.QueryString["uc"];
            }
            if (uc == "buyn")
            {
                dt = new DataTable("MyTable");
                dt.Columns.Add(new DataColumn("MaHH", typeof(string)));
                dt.Columns.Add(new DataColumn("TenHang", typeof(string)));
                dt.Columns.Add(new DataColumn("sl", typeof(int)));
                dt.Columns.Add(new DataColumn("GiaBan", typeof(string)));
                DataRow dr = dt.NewRow();
                dr["MaHH"] = TTthanhtoan.MaHH;
                dr["TenHang"] = TTthanhtoan.tenHang;
                dr["sl"] = 1;
                dr["GiaBan"] = TTthanhtoan.GiaBan;
                dt.Rows.Add(dr);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                decimal tongtien = 0;
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {

                    GridView1.Rows[i].Cells[0].Text = "<img src='" + piclaptop + Convert.ToString(GridView1.Rows[i].Cells[1].Text) + "/1.png' witch=50px height=50px class='hinhdaidien'>";
                    decimal thanhtien = Convert.ToDecimal(Convert.ToDecimal(GridView1.Rows[i].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[i].Cells[3].Text));
                    tongtien += thanhtien;
                    string thanhtienfm = thanhtien.ToString("#,##0 VND");
                    GridView1.Rows[i].Cells[4].Text = Convert.ToString(thanhtienfm);
                }
                NganHang.ApiBank_Request.amount = tongtien.ToString();
                string tongtienfm = tongtien.ToString("#,##0 VND");
                Literal1.Text = "<a color:red>" + tongtienfm + "</a>";
                //    decimal thanhtien;
                //thanhtien = Convert.ToDecimal(1 * TTthanhtoan.GiaBan);
                //ttsp1.Text += "<tr><td>" + 1 + "</td>";
                //ttsp1.Text += "<td><img src='" + piclaptop + TTthanhtoan.tenHang + "/1.png' witch=50px height=50px class='hinhdaidien'></td>";
                //ttsp1.Text += "<td>" + TTthanhtoan.tenHang + "</td><td class='text-center'>1</td><td class='text-right'>" + TTthanhtoan.GiaBan + "</td><td class='auto-style2'>" + thanhtien + "</td>";
                //ttsp1.Text += "<td><asp:Button ID='sp1' runat='server' BackColor='#FF5050' BorderStyle='Solid' Font-Size='Large' Text='xóa'/></td></tr>";
            }
            else if (uc == "cart")
            {
                GridView1.DataSource = App_Start.dataindex.dtgh;
                GridView1.DataBind();
                GridView1.DataBind();
                decimal tongtien = 0;
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    GridView1.Rows[i].Cells[0].Text = "<img src='" + piclaptop + Convert.ToString(GridView1.Rows[i].Cells[1].Text) + "/1.png' witch=50px height=50px class='hinhdaidien'>";
                    decimal thanhtien = Convert.ToDecimal(Convert.ToDecimal(GridView1.Rows[i].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[i].Cells[3].Text));
                    tongtien += thanhtien;
                    string thanhtienfm = thanhtien.ToString("#,##0 VND");
                    GridView1.Rows[i].Cells[4].Text = Convert.ToString(thanhtienfm);
                }
                NganHang.ApiBank_Request.amount = tongtien.ToString();
                string tongtienfm = tongtien.ToString("#,##0 VND");
                Literal1.Text = "<a style='text-color:red'>" + tongtienfm + "";
            }
        }
        public void dc()
        {

        }
        protected void Thaydoi_Click(object sender, EventArgs e)
        {
            if (App_Start.datadn.user != "")
            {
                KhachHang.Kh.makh = TTthanhtoan.MaKh;
                Response.Redirect("soluction.aspx?uc=TTKH");
            }
            else
            {
                Response.Redirect("soluction.aspx?uc=upttkh");
            }
        }
        string matb = "";
        public void thongbao()
        {
            matb = "";
            string maTB = "TB";
            for (int i = 1; i <= 100000; i++)
            {
                matb = maTB + i;
                string sql = "select * from Thongbao where MaTB='" + matb + "'";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    thongbao();
                }
                else
                {
                    sqlDataReader.Close();
                    break;
                }
            }
        }
        public void addcthd(string mahd,string mahh,int sl,int giaban,string hoten,string diachi,string sdt,string email)
        {
            string sql = "insert into CT_HDBan values ('"+mahd+"','"+mahh+"','"+sl+"','"+giaban+"',N'"+hoten+"',N'"+diachi+"',N'"+sdt+"','"+email+"')";
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            command.Cancel();
        }
        public void loaddc()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            string sqlck = "select * from tbl_KH where TenTK='" + App_Start.datadn.user + "' and checkmd='2'";
            command = new SqlCommand(sqlck, con);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dtck = new DataTable();
            dtck.Load(sqlDataReader);
            sqlDataReader.Close();
            TTthanhtoan.MaKh = dtck.Rows[0]["MaKH"].ToString();
            TTthanhtoan.tenkh = dtck.Rows[0]["TenKH"].ToString();
            TTthanhtoan.diachi = dtck.Rows[0]["DiaChi"].ToString();
            TTthanhtoan.sdt = dtck.Rows[0]["DienThoai"].ToString();
            TTthanhtoan.email = dtck.Rows[0]["email"].ToString();
        }
        protected void btnad_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                if (App_Start.datadn.ck == false)
                {
                    DateTime dtime = new DateTime();
                    dtime = DateTime.Now;
                    string.Format("{0:dd/MM/yyyy HH:mm:ss}", dtime);
                    string year = Convert.ToString(dtime.Year);
                    string month = Convert.ToString(dtime.Month);
                    string day = Convert.ToString(dtime.Day);
                    string str = Convert.ToString(dtime);
                    str = str.Remove(str.Length - 3, 3);
                    str = str.Remove(0, 11);
                    string dateup = year + "-" + month + "-" + day + " " + str;
                    if (App_Start.datadn.user == "")
                    {
                        string name_bank = "";
                        string infobank = "";
                        if (NganHang.ApiBank_Request.mabank != "PT001")
                        {
                            name_bank = DropDownList1.SelectedItem.Text.Trim();
                            infobank = NganHang.ApiBank_Request.infobank;
                        }
                        randumhdkh();
                        string uc = "";
                        if (Request.QueryString["uc"] != null)
                        {
                            uc = Request.QueryString["uc"];
                        }
                        if (uc == "buyn")
                        {
                            decimal thanhtien = Convert.ToDecimal(GridView1.Rows[0].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[0].Cells[3].Text);
                            string sql1 = "insert into DONHANG values('" + mahd + "','" + TTthanhtoan.MaHH + "','" + GridView1.Rows[0].Cells[2].Text + "','" + GridView1.Rows[0].Cells[3].Text + "','" + thanhtien + "',N'" + TTthanhtoan.tenkh + "',N'" + TTthanhtoan.diachi + "','" + TTthanhtoan.sdt + "',N'" + TTthanhtoan.email + "','" + year + "-" + month + "-" + day + " " + str + "','',N'Chờ Xác Nhận','" + NganHang.ApiBank_Request.mabank + "','" + infobank + "','" + name_bank + "','1')";
                            string sql = "insert into tbl_HDban(MaHD,TongGiaTri,NgayLap,MaTT,info,chart_name,MaTrangThai) values ('" + mahd+"','"+thanhtien+ "','" + year + "-" + month + "-" + day + " " + str + "','"+NganHang.ApiBank_Request.mabank+ "','" + infobank + "','" + name_bank + "','1')";
                            command = new SqlCommand(sql, connection);
                            SqlDataReader dr = command.ExecuteReader();
                            dr.Close();
                            command.Cancel();
                            addcthd(mahd, TTthanhtoan.MaHH,Convert.ToInt32(GridView1.Rows[0].Cells[2].Text),Convert.ToInt32(GridView1.Rows[0].Cells[3].Text), TTthanhtoan.tenkh, TTthanhtoan.diachi, TTthanhtoan.sdt, TTthanhtoan.email);
                            SANPHAM.thanhtoan.TTthanhtoan.mahd = Convert.ToString(mahd);
                            Response.Redirect("soluction.aspx?uc=ph");
                        }
                        else if (uc == "cart")
                        {
                            randum();
                            command.Cancel();
                            decimal thanhtien=0;
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                               thanhtien += Convert.ToDecimal(GridView1.Rows[i].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[i].Cells[3].Text);
                            }
                            string sql = "insert into tbl_HDban(MaHD,TongGiaTri,NgayLap,MaTT,info,chart_name,MaTrangThai) values ('"+mahd+"','"+thanhtien+ "','" + year + "-" + month + "-" + day + " " + str + "','"+NganHang.ApiBank_Request.mabank+"','"+infobank+"','"+name_bank+"','1')";
                            command = new SqlCommand(sql, connection);
                            SqlDataReader s = command.ExecuteReader();
                            command.Cancel();
                            s.Close();
                            SANPHAM.thanhtoan.TTthanhtoan.mahd = Convert.ToString(mahd);    
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {

                                TTthanhtoan.MaHH = GioHang.datagiohang.dt1.Rows[i][0].ToString();
                                GioHang.datagiohang.remove(TTthanhtoan.MaHH);
                                int sl = Convert.ToInt32(GridView1.Rows[i].Cells[2].Text);
                                int dg = Convert.ToInt32(GridView1.Rows[i].Cells[3].Text);
                                addcthd(mahd, TTthanhtoan.MaHH, sl, dg, TTthanhtoan.tenkh, TTthanhtoan.diachi, TTthanhtoan.sdt, TTthanhtoan.email);
                            }
                            Response.Redirect("soluction.aspx?uc=ph");
                        }
                    }
                    else
                    {
                        string sqlck = "select * from tbl_KH where TenTK='" + App_Start.datadn.user + "' and checkmd='2'";
                        command = new SqlCommand(sqlck, connection);
                        SqlDataReader sqlDataReader = command.ExecuteReader();
                        DataTable dtck = new DataTable();
                        dtck.Load(sqlDataReader);
                        TTthanhtoan.MaKh = dtck.Rows[0]["MaKH"].ToString();
                        TTthanhtoan.tenkh = dtck.Rows[0]["TenKH"].ToString();
                        TTthanhtoan.diachi = dtck.Rows[0]["DiaChi"].ToString();
                        TTthanhtoan.sdt = dtck.Rows[0]["DienThoai"].ToString();
                        TTthanhtoan.email = dtck.Rows[0]["email"].ToString();
                        randumhdkh();
                        string name_bank = "";
                        string infobank = "";
                        if (NganHang.ApiBank_Request.mabank != "PT001")
                        {
                            name_bank = DropDownList1.SelectedItem.Text.Trim();
                            infobank = NganHang.ApiBank_Request.infobank;
                        }
                        string uc = "";
                        if (Request.QueryString["uc"] != null)
                        {
                            uc = Request.QueryString["uc"];
                        }
                        if (uc == "buyn")
                        {
                            decimal thanhtien = Convert.ToDecimal(GridView1.Rows[0].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[0].Cells[3].Text);
                            string sql = "insert into tbl_HDban(MaHD,MaKH,TongGiaTri,NgayLap,MaTT,info,chart_name,MaTrangThai) values ('" + mahd + "','" + SANPHAM.thanhtoan.TTthanhtoan.MaKh + "','" + thanhtien + "','" + year + "-" + month + "-" + day + " " + str + "','" + NganHang.ApiBank_Request.mabank + "','" + infobank + "','" + name_bank + "','1')";

                            string sql1 = "insert into tbl_HDban values('" + mahd + "','NV001','" + SANPHAM.thanhtoan.TTthanhtoan.MaKh + "','" + GridView1.Rows[0].Cells[2].Text + "','" + GridView1.Rows[0].Cells[3].Text + "','" + thanhtien + "','" + year + "-" + month + "-" + day + " " + str + "','" + SANPHAM.thanhtoan.TTthanhtoan.MaHH + "',N'Chờ Xác Nhận','" + NganHang.ApiBank_Request.mabank + "','" + infobank + "','" + name_bank + "','1')";
                            command = new SqlCommand(sql, connection);
                            SqlDataReader dreader = command.ExecuteReader();
                            SANPHAM.thanhtoan.TTthanhtoan.mahd = Convert.ToString(mahd);
                            command.Cancel();
                            dreader.Close();
                            addcthd(mahd, SANPHAM.thanhtoan.TTthanhtoan.MaHH,Convert.ToInt32(GridView1.Rows[0].Cells[2].Text),Convert.ToInt32(GridView1.Rows[0].Cells[3].Text), TTthanhtoan.tenkh, TTthanhtoan.diachi, TTthanhtoan.sdt, TTthanhtoan.email);
                            string sql2 = "insert into Thongbao values (N'Đơn Hàng " + mahd + " Đang Chờ Xác Nhận',N'Đơn Hàng " + mahd + " đang được chuẩn bị và vận chuyển vui lòng để ý thông báo và cuộc gọi từ nhà cung cấp!','" + App_Start.datadn.user + "','" + dateup + "','1')";
                            command = new SqlCommand(sql2, connection);
                            command.ExecuteReader();
                            Response.Redirect("soluction.aspx?uc=ph");
                        }
                        else if (uc == "cart")
                        {
                            command.Cancel();
                            connection = new SqlConnection(sqlcon);
                            connection.Open();
                            decimal thanhtien = 0;
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                thanhtien = Convert.ToDecimal(GridView1.Rows[i].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[i].Cells[3].Text);
                            }
                            string sql = "insert into tbl_HDban(MaHD,MaKH,TongGiaTri,NgayLap,MaTT,info,chart_name,MaTrangThai) values ('" + mahd + "','" + SANPHAM.thanhtoan.TTthanhtoan.MaKh + "','" + thanhtien + "','" + year + "-" + month + "-" + day + " " + str + "','" + NganHang.ApiBank_Request.mabank + "','" + infobank + "','" + name_bank + "','1')";
                            command = new SqlCommand(sql, connection);
                            SqlDataReader dreader = command.ExecuteReader();
                            SANPHAM.thanhtoan.TTthanhtoan.mahd = Convert.ToString(mahd);
                            command.Cancel();
                            dreader.Close();
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                addcthd(mahd, App_Start.dataindex.dtgh.Rows[i][3].ToString(), Convert.ToInt32(GridView1.Rows[0].Cells[2].Text), Convert.ToInt32(GridView1.Rows[0].Cells[3].Text), TTthanhtoan.tenkh, TTthanhtoan.diachi, TTthanhtoan.sdt, TTthanhtoan.email);
                            }
                            string sql2 = "insert into Thongbao values (N'Đơn Hàng " + mahd + " Đang Chờ Xác Nhận',N'Đơn Hàng " + mahd + " đang được chuẩn bị và vận chuyển vui lòng để ý thông báo và cuộc gọi từ nhà cung cấp!','" + App_Start.datadn.user + "','" + dateup + "','1')";
                            command = new SqlCommand(sql2, connection);
                            command.ExecuteReader();
                            Response.Redirect("soluction.aspx?uc=ph");
                        }

                    }
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + App_Start.dataindex.dtgh.Rows[0][0].ToString() + "')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Bạn là Admin vui lòng đăng xuất hoặc đăng nhập tài khoản thành viên!')", true);
                }
            }
            catch
            {
                if (App_Start.datadn.ck == true)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Bạn là Admin vui lòng đăng xuất hoặc đăng nhập tài khoản thành viên!')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);
                }
            }
        }
        string mahd = "";
        public void randum()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from DONHANG where MaDon='" + num + "'";
            command = new SqlCommand(sql, connection);
            SqlDataReader data1 = command.ExecuteReader();
            if (data1.HasRows)
            {
                data1.Close();
                randum();
            }
            else
            {
                command.Cancel();
                data1.Close();
                string sql2 = "select * from tbl_HDban where MaHD='" + num + "'";
                command = new SqlCommand(sql2, connection);
                SqlDataReader data2 = command.ExecuteReader();
                if (data2.HasRows)
                {
                    data2.Close();
                    randum();
                }
                else
                {
                    mahd = Convert.ToString(num);
                    data2.Close();
                }
            }
        }
        public void randumhdkh()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from tbl_HDban where MaHD='" + num + "'";
            command = new SqlCommand(sql, connection);
            SqlDataReader data1 = command.ExecuteReader();
            if (data1.HasRows)
            {
                randumhdkh();
            }
            else
            {
                mahd = Convert.ToString(num);
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void txtbtnsave_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
        public void connect()
        {
            connection = new SqlConnection(sqlcon1);
            connection.Open();
        }
        public void loadncc()
        {
            DropDownList1.Items.Clear();
            string sql = "select * from Datum where check_code='1'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sqlDataReader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem ls = new ListItem();
                ls.Value = dt.Rows[i]["bin"].ToString();
                ls.Text = dt.Rows[i]["short_name"].ToString();

                DropDownList1.Items.Add(ls);
            }
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        bool ck = false;
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnad.Visible = false;
            btntt.Text = @"<button style='background-color:white;color:#007bff' type='button' class='btn btn-primary' data-bs-toggle='modal' data-bs-target='#exampleModal'>"
                                            + "<b>Thanh Toán</ b >"
                                        + "</button>";
            Literaltt.Text = "<b>Thanh Toán Chuyển Khoản</b>";
            string bin = DropDownList1.SelectedItem.Value.Trim();
            string name = DropDownList1.SelectedItem.Text.Trim();
            string sql = "select * from Datum where check_code='1' and bin='" + bin + "' and short_name='" + name + "'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dts = new DataTable();
            dts.Load(sqlDataReader);

            string infobank1 = GetPassword();
            Label1.Text = "Quét Mã QR";
            NganHang.ApiBank_Request.infobank = infobank1;


            NganHang.ApiBank_Request.mabank = "PT002";

            TT_cart.Text = @"<div class='row'>"
                                + "<div class='col-sm-4'>"
                                    + "Ngân Hàng:"
                                + "</div>"
                                + "<div class='col-sm-8'>"
                                    + "<div class='border'>" + name + "</div>"
                                + "</div>"
                              + "</div>"
                              + "<div class='row'>"
                                + "<div class='col-sm-4'>"
                                    + "Tên Tài Khoản:"
                                + "</div>"
                                + "<div class='col-sm-8'>"
                                    + "<div class='border'>" + dts.Rows[0]["Name_cart"].ToString() + "</div>"
                                + "</div>"
                              + "</div>"
                              + "<div class='row'>"
                                + "<div class='col-sm-4'>"
                                    + "Số Tài Khoản:"
                                + "</div>"
                                + "<div class='col-sm-8'>"
                                    + "<div class='border'>" + dts.Rows[0]["number_cart"].ToString() + "</div>"
                                + "</div>"
                              + "</div>"
                              + "<div class='row'>"
                                + "<div class='col-sm-4'>"
                                    + "Số Tiền:"
                                + "</div>"
                                + "<div class='col-sm-8'>"
                                    + "<div class='border'>" + NganHang.ApiBank_Request.amount + "</div>"
                                + "</div>"
                              + "</div>"
                              + "<div class='row'>"
                                + "<div class='col-sm-4'>"
                                    + "Lời Nhắn:"
                                + "</div>"
                                + "<div class='col-sm-8'>"
                                    + "<div class='border'>" + NganHang.ApiBank_Request.infobank + "</div>"
                                + "</div>"
                              + "</div>";

            var apiRequest = new NganHang.ApiRequet();
            apiRequest.acqId = Convert.ToInt32(bin); ;
            apiRequest.accountNo = dts.Rows[0]["number_cart"].ToString();
            apiRequest.accountName = dts.Rows[0]["Name_cart"].ToString();
            apiRequest.amount = Convert.ToInt32(NganHang.ApiBank_Request.amount);
            apiRequest.addInfo = NganHang.ApiBank_Request.infobank;
            apiRequest.format = "Text";
            apiRequest.template = "compact";
            var JsonRequest = JsonConvert.SerializeObject(apiRequest);

            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", JsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<NganHang.ApiResponse>(content);
            string url = dataResult.data.qrDataURL.Trim();
            Image1.ImageUrl = dataResult.data.qrDataURL;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            btntt.Text = "";
            btnad.Visible = true;
            NganHang.ApiBank_Request.mabank = "PT001";

            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}