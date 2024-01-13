using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace webs_banlaptop.NhanVien
{
    public partial class Nhanvien : System.Web.UI.UserControl
    {
        string FilePath = "";
        string pictrure = nhanvien.pictrure;
        //string FilePath = "";
        //datasp da = new datasp();
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            nhanvien.manv = "";
            nhanvien.tennv = "";
            nhanvien.diachi = "";
            nhanvien.dienthoai = "";
            nhanvien.cccd = "";
            nhanvien.day = "";
            nhanvien.month = "";
            nhanvien.year = "";
            string sql = "select * from tbl_NhanVien order by MaNV asc";
            load(sql);
        }

        private void load(string sql)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            NhanVienGRV.DataSource = dataTable;
            NhanVienGRV.DataBind();
            nhanvien.manvmax = dataTable.Rows[dataTable.Rows.Count - 1][0].ToString();
            command.Cancel();
        }
        
        
        private void select(string sql)
        {
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            NhanVienGRV.DataSource = dataTable;
            NhanVienGRV.DataBind();
        }
        
        private void newsave(string sql)
        {
            
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();

        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void NhanVienGRV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "TT")
            {
                nhanvien.manv = NhanVienGRV.Rows[row].Cells[0].Text; ;
                nhanvien.tennv = HttpUtility.HtmlDecode(NhanVienGRV.Rows[row].Cells[1].Text);
                nhanvien.diachi = HttpUtility.HtmlDecode(NhanVienGRV.Rows[row].Cells[2].Text);
                nhanvien.dienthoai = NhanVienGRV.Rows[row].Cells[3].Text;
                nhanvien.cccd = NhanVienGRV.Rows[row].Cells[4].Text;
                DateTime dt = DateTime.Parse(NhanVienGRV.Rows[row].Cells[5].Text);
                var day = dt.Day;
                nhanvien.day = day.ToString();
                var month = dt.Month;
                nhanvien.month = month.ToString();
                var year = dt.Year;
                nhanvien.year = year.ToString();
                Response.Redirect("admin.aspx?uc=crs&suc=updcrs");
            }
        }
        private void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            
        }
        bool CheckFileType(string fileName)
        {

            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".png":
                    return true;
                default:
                    return false;
            }
        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            //string sql = "update tbl_NhanVien set TenNV=N'"+txttennv.Text+"',DiaChi=N'"+txtdiachi.Text+"',DienThoai='"+txtdienthoai.Text+"',SCCCD='"+txtCCCD.Text+"',NgaySinh='"+txtyear.Text+"-"+txtmoth.Text+"-"+txtday.Text+" 00:00:00' where MaNV='"+txtmanv.Text+"'";
            //newsave(sql);
            //load();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //string sql = "delete tbl_NhanVien where MaNV='"+txtmanv.Text+"'";
            //newsave(sql);
            //load();
        }

        protected void btnsr_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from tbl_NhanVien where MaNV like '%"+ TextBox1.Text + "%' or TenNV like N'%" + TextBox1.Text + "%' or DiaChi like N'%" + TextBox1.Text + "%' or DienThoai like '%" + TextBox1.Text + "%' or SCCCD like '%" + TextBox1.Text + "%' order by MaNV asc";
            select(sql);
        }
    }
}