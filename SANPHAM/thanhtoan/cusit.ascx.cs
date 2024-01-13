using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.SANPHAM.thanhtoan
{
    public partial class cusit : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        string piclaptop = App_Start.datadn.pic;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select Top(1)* from tbl_KH order by MaKH desc";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            KhachHang.Kh.maKH(dt.Rows[0][0].ToString());
            maKH.Text = "KH" + KhachHang.Kh.makhnew;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txttenkh.Text =="" || txtsdt.Text=="" || txtemail.Text =="" || txtdiachi.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('vui lòng điền đầy đủ thông tin !')", true);
            }
            else
            {
                command.Cancel();
                connection = new SqlConnection(sqlcon);
                connection.Open();
                //string sql = "insert into tbl_KH values('" + maKH.Text + "',N'" + txttenkh.Text + "',N'" + txtdiachi.Text + "','" + txtsdt.Text + "','" + txtemail.Text + "','')";
                //command = new SqlCommand(sql, connection);
                //command.ExecuteReader();
                SANPHAM.thanhtoan.TTthanhtoan.MaKh = maKH.Text;
                SANPHAM.thanhtoan.TTthanhtoan.tenkh = txttenkh.Text;
                SANPHAM.thanhtoan.TTthanhtoan.diachi = txtdiachi.Text;
                SANPHAM.thanhtoan.TTthanhtoan.sdt = txtsdt.Text;
                SANPHAM.thanhtoan.TTthanhtoan.email = txtemail.Text;
                if(App_Start.dataindex.checkedbuy == 1)
                {
                    Response.Redirect("soluction.aspx?uc=buyn");
                }
               else if(App_Start.dataindex.checkedbuy == 2)
                {
                    Response.Redirect("soluction.aspx?uc=cart ");
                }
            }
        }
    }
}