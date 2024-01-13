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
    public partial class TTNhanVien : System.Web.UI.UserControl
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
            txtmanv.Text = nhanvien.manv;
            txttennv.Text = nhanvien.tennv;
            txtdiachi.Text = nhanvien.diachi;
            txtdienthoai.Text = nhanvien.dienthoai;
            if (nhanvien.cccd != "")
            {
                txtCCCD.Text = App_Start.password.Decrypt(nhanvien.cccd);
            }
            txtday.Text = nhanvien.day;
            txtmoth.Text = nhanvien.month;
            txtyear.Text = nhanvien.year;
            Image1.ImageUrl = "~/img/NhanVien/" + nhanvien.manv + "/1.png";
        }

        private void newsave(string sql)
        {
            command.Cancel();
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();
        }
        private void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
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
        protected void btnsave_Click(object sender, EventArgs e)
        {

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            connect();
            string sql = "delete tbl_NhanVien where MaNV='" + txtmanv.Text + "'";
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            Response.Redirect("admin.aspx?uc=crs");
            
        }

        protected void btnsua_Click(object sender, EventArgs e)
        {
            var numbernv = nhanvien.manv;
            numbernv = numbernv.Replace("NV", "0");
            int manv = Convert.ToInt32(numbernv);
            int manvnew = manv;
            connect();
            string sql = "insert into tbl_NhanVien values('NV" + manvnew + "',N'" + txttennv.Text + "',N'" + txtdiachi.Text + "','" + txtdienthoai.Text + "','" + App_Start.password.Encrypt(txtCCCD.Text) + "','" + txtyear.Text + "-" + txtmoth.Text + "-" + txtday.Text + " 00:00:00')";
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            FilePath = MapPath(pictrure + "NV" + manvnew + "/");
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            else
            {
                string filename = "/img/NhanVien/NV" + manvnew + "/1.png";
                if (Directory.Exists(filename))
                {
                    Directory.Delete(filename);
                }
            }
            if (Page.IsValid && FileUpload1.HasFile && CheckFileType(FileUpload1.FileName))
            {
                FileUpload1.SaveAs(FilePath + "1.png");
                Image1.ImageUrl = "~/img/NhanVien/NV" + manvnew + "/1.png";
            }
        }

        protected void btnupdate_Click1(object sender, EventArgs e)
        {
            connect();
            string sql = "update tbl_NhanVien set TenNV=N'" + txttennv.Text + "',DiaChi=N'" + txtdiachi.Text + "',DienThoai='" + txtdienthoai.Text + "',SCCCD='" + App_Start.password.Encrypt(txtCCCD.Text) + "',NgaySinh='" + txtyear.Text + "-" + txtmoth.Text + "-" + txtday.Text + " 00:00:00' where MaNV='" + txtmanv.Text + "'";
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();
            //load();
        }
    }
}