using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace webs_banlaptop.KhachHang
{
    public partial class ThongtinKH : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            maKH.Text = Kh.makh;
            txttenkh.Text = Kh.tenkh;
            txtdiachi.Text = Kh.diachi;
            txtsdt.Text = Kh.dienthoai;
            txtemail.Text = Kh.email;
            txttentk.Text = Kh.tentk;
            txttentk.Text = App_Start.datadn.user;
            load();
        }

        private void load()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from tbl_KH order by MaKH asc";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            Kh.maKH(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString());
            command.Cancel();
        }
        private void newsave(string sql)
        {

            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        protected void btnupdate_Click1(object sender, EventArgs e)
        {
            try
            {
                if (isEmail(Convert.ToString(txtemail.Text)) == true)
                {
                    string sql = "update tbl_KH set TenKH=N'" + txttenkh.Text + "',DiaChi=N'" + txtdiachi.Text + "',DienThoai='" + txtsdt.Text + "',email=N'" + txtemail.Text + "',TenTK='" + txttentk.Text + "' where MaKH='" + maKH.Text + "'";
                    newsave(sql);
                    Response.Write("<script>alert('Chỉnh Sửa Thông Tin Thành Công')</script>");
                    string uc = "";
                    if (Request.QueryString["uc"] != null)
                    {
                        uc = Request.QueryString["uc"];
                    }
                    if (uc == "TTKH")
                    {
                        Response.Redirect("soluction.aspx?uc=buyn");
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Không Đúng Định Dạng')", true);
                }
            }
            catch
            {
                
            }
        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete tbl_KH where MaKH='" + Kh.makh + "'";
            newsave(sql);
        }

        protected void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmail(Convert.ToString(txtemail.Text)) == true)
                {
                    string makh = "KH" + Convert.ToString(Kh.makhnew);
                    string sql = "insert into tbl_KH values('" + makh + "',N'" + txttentk.Text + "',N'" + txtdiachi.Text + "','" + txtsdt.Text + "','" + txtemail.Text + "','" + txttentk.Text + "','2')";
                    newsave(sql);
                    Response.Write("<script>alert(cập nhật khách Hàng Thành Công)</script>");

                }
                else
                {
                    Response.Write("<script>alert('Email Không Đúng Định Dạng')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('khách hàng đã tồn tại')</script>");
            }
        }
    }
}