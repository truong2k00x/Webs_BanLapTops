using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace webs_banlaptop.quantri.thong_ke
{
    public partial class chartmin : System.Web.UI.UserControl
    {        
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected string date()
        {
            string month = DateTime.Now.ToString().Trim();
            month = month.Substring(4, 2);
            month = month.Replace("/", "");
            return month;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ChartBD.Titles["ChartBD"].Text = "Biểu Đồ: Tháng " + date()  + " Năm " + chart_cs.Year + "";
            connect();
            drmonth.SelectedValue = date();
            loadsp();
            string mahh = "";
            if (ck1.Checked == true)
            {                
                load(DropDownList1.SelectedValue.Trim());
                ChartBD.Titles["ChartBD"].Text = "Biểus Đồ: Tháng " + drmonth.SelectedItem.Text + " Năm " + chart_cs.Year + " (" + DropDownList1.SelectedItem.Value.Trim() + ")";
            }
            else
            {
                load(mahh);
            }
        }
        protected void load(string maHH)
        {
            string sql = "exec Day_donhang '" + chart_cs.Year + "','" + drmonth.SelectedItem.Text + "','%" + maHH + "%'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);

            ChartBD.Series["ChartBD"].Points.Clear();
            loadBDT(dt);
        }
        protected void loadBDT(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0 || i==dt.Rows.Count-1)
                    {
                        ChartBD.Series["ChartBD"].Points.AddXY("" + dt.Rows[i][0].ToString() + "", Convert.ToInt32(dt.Rows[i][1].ToString()));
                    }
                    else
                    {
                        if (Convert.ToInt32(dt.Rows[i][1].ToString())>0)
                        {
                            ChartBD.Series["ChartBD"].Points.AddXY("" + dt.Rows[i][0].ToString() + "", Convert.ToInt32(dt.Rows[i][1].ToString()));
                        }
                    }
                }
            }
        }
        protected void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        protected void loadBDC_day(DataTable dt)
        {
            //ChartDBC.Titles["ChartBDC"].Text = "Biểu Đồ Thống kê: tháng " + drmonth.SelectedItem.Text + " Năm " + chart_cs.Year;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    ChartDBC.Series["ChartBDC"].Points.AddXY("Ngày " + Convert.ToInt32(dt.Rows[i][0].ToString()) + "", Convert.ToInt32(dt.Rows[i][1].ToString()));
            //}
        }
        protected void loadsp()
        {
            //connect();
            string sqlc = "select MaHH,TenHang from tbl_HangHoa";
            command = new SqlCommand(sqlc, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem lst = new ListItem();
                lst.Value = dt.Rows[i][0].ToString();
                lst.Text = dt.Rows[i][1].ToString();
                DropDownList1.Items.Add(lst);
            }
        }
        //protected void btn_print()
        //{
        //    COMExcel.Application exApp = new COMExcel.Application();
        //    COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
        //    COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
        //    COMExcel.Range exRange;
        //    string sql;
        //    int hang = 0, cot = 0;
        //    DataTable tblThongtinHD, tblThongtinHang;
        //    exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
        //    exSheet = exBook.Worksheets[1];
        //    // Định dạng chung
        //    exRange = exSheet.Cells[1, 1];
        //    exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
        //    exRange.Range["A1:B3"].Font.Size = 10;
        //    exRange.Range["A1:B3"].Font.Bold = true;
        //    exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
        //    exRange.Range["A1:A1"].ColumnWidth = 7;
        //    exRange.Range["B1:B1"].ColumnWidth = 15;
        //    exRange.Range["A1:B1"].MergeCells = true;
        //    exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A1:B1"].Value = "Cửa hàng tiện lợi ABC";
        //    exRange.Range["A2:B2"].MergeCells = true;
        //    exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A2:B2"].Value = "Sài Gòn";
        //    exRange.Range["A3:B3"].MergeCells = true;
        //    exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A3:B3"].Value = "Điện thoại: 0000000000";
        //    exRange.Range["C2:E2"].Font.Size = 16;
        //    exRange.Range["C2:E2"].Font.Bold = true;
        //    exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
        //    exRange.Range["C2:E2"].MergeCells = true;
        //    exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
        //    // Biểu diễn thông tin chung của hóa đơn bán
        //    sql = "SELECT a.MaHDBan, a.NgayBan, a.TongTien, b.TenKhach, b.DiaChi, b.DienThoai, c.TenNhanVien FROM tblHDBan   AS a, tblKhach AS b, tblNhanVien AS c WHERE a.MaHDBan = N'" + txtMaHDBan.Text + "' AND a.MaKhach = b.MaKhach AND a.MaNhanVien = c.MaNhanVien";
        //    tblThongtinHD = Functions.GetDataToTable(sql);
        //    exRange.Range["B6:C9"].Font.Size = 12;
        //    exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
        //    exRange.Range["C6:E6"].MergeCells = true;
        //    exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
        //    exRange.Range["B7:B7"].Value = "Khách hàng:";
        //    exRange.Range["C7:E7"].MergeCells = true;
        //    exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
        //    exRange.Range["B8:B8"].Value = "Địa chỉ:";
        //    exRange.Range["C8:E8"].MergeCells = true;
        //    exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
        //    exRange.Range["B9:B9"].Value = "Điện thoại:";
        //    exRange.Range["C9:E9"].MergeCells = true;
        //    exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
        //    //Lấy thông tin các mặt hàng
        //    sql = "SELECT b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
        //          "FROM tblChiTietHDBan AS a , tblHang AS b WHERE a.MaHDBan = N'" +
        //          txtMaHDBan.Text + "' AND a.MaHang = b.MaHang";
        //    tblThongtinHang = Functions.GetDataToTable(sql);
        //    //Tạo dòng tiêu đề bảng
        //    exRange.Range["A11:F11"].Font.Bold = true;
        //    exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["C11:F11"].ColumnWidth = 12;
        //    exRange.Range["A11:A11"].Value = "STT";
        //    exRange.Range["B11:B11"].Value = "Tên hàng";
        //    exRange.Range["C11:C11"].Value = "Số lượng";
        //    exRange.Range["D11:D11"].Value = "Đơn giá";
        //    exRange.Range["E11:E11"].Value = "Giảm giá";
        //    exRange.Range["F11:F11"].Value = "Thành tiền";
        //    for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
        //    {
        //        //Điền số thứ tự vào cột 1 từ dòng 12
        //        exSheet.Cells[1][hang + 12] = hang + 1;
        //        for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
        //        //Điền thông tin hàng từ cột thứ 2, dòng 12
        //        {
        //            exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
        //            if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
        //        }
        //    }
        //    exRange = exSheet.Cells[cot][hang + 14];
        //    exRange.Font.Bold = true;
        //    exRange.Value2 = "Tổng tiền:";
        //    exRange = exSheet.Cells[cot + 1][hang + 14];
        //    exRange.Font.Bold = true;
        //    exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
        //    exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
        //    exRange.Range["A1:F1"].MergeCells = true;
        //    exRange.Range["A1:F1"].Font.Bold = true;
        //    exRange.Range["A1:F1"].Font.Italic = true;
        //    exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
        //    exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
        //    exRange.Range["A1:C1"].MergeCells = true;
        //    exRange.Range["A1:C1"].Font.Italic = true;
        //    exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
        //    exRange.Range["A1:C1"].Value = "Sài gòn, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
        //    exRange.Range["A2:C2"].MergeCells = true;
        //    exRange.Range["A2:C2"].Font.Italic = true;
        //    exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
        //    exRange.Range["A6:C6"].MergeCells = true;
        //    exRange.Range["A6:C6"].Font.Italic = true;
        //    exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        //    exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
        //    exSheet.Name = "Hóa đơn nhập";
        //    exApp.Visible = true;
        //}
        protected void ListBox1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //connect();
            string sql = "exec select_month '" + DropDownList1.SelectedItem.Value.Trim() + "','" + chart_cs.Year + "','"+drmonth.SelectedItem.Text+"'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            grvsp.DataSource = dt;
            grvsp.DataBind();
            if (ck1.Checked == true)
            {
                load(DropDownList1.SelectedValue.Trim());
                ChartBD.Titles["ChartBD"].Text = "Biểus Đồ: Tháng " + drmonth.SelectedItem.Text + " Năm " + chart_cs.Year + " (" + DropDownList1.SelectedItem.Value.Trim() + ")";
            }
            else
            {
                load("");
            }
        }

        protected void ck1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck1.Checked == true)
            {
                ChartBD.Titles["ChartBD"].Text = "Biểus Đồ: Tháng "+drmonth.SelectedItem.Text+" Năm "+chart_cs.Year+" ("+DropDownList1.SelectedItem.Value.Trim()+")";
                load(DropDownList1.SelectedItem.Value.Trim());
            }
            else
            {
                ChartBD.Titles["ChartBD"].Text = "Biểu Đồ: Tháng " + drmonth.SelectedItem.Text + " Năm " + chart_cs.Year + "";
                load("");
            }
        }
    }
}