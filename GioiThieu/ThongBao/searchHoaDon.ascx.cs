using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.GioiThieu.ThongBao
{
    public partial class searchHoaDon : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            trangthaiDH.Text = "";
            string sql = "select dh.*,ma.TenTrangThai from DONHANG dh inner join tbl_TTDON ma on dh.MaTrangThai=ma.MaTrangThai where MaDon='" + TextBox1.Text+"'";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                int a = Convert.ToInt32(dt.Rows[0]["MaTrangThai"].ToString());
                string date = "<div style='font-size:10px'>" + dt.Rows[0]["NgayLap"].ToString()+"</div>";
                for(int i = a; i > 0; i--)
                {
                    trangthaiDH.Text += "<div style='margin-top:20px'> " +
                                            "<div style='font-size:20px'>Đơn Hàng số "+TextBox1.Text+" đang "+conten(i)+"</div>" +
                                            date +
                                        "</div>";
                    date = "";
                    if (i == 5)
                    {
                        i--;
                    }
                }
            }
            else
            {

            }
        }
        public string conten(int a)
        {
            string trangthai="";
            string sql = "select * from tbl_TTDON where MaTrangThai='"+a+"'";
            SqlCommand cmd = new SqlCommand(sql,connection);
            SqlDataReader sqlData = cmd.ExecuteReader();
            DataTable dts = new DataTable();
            dts.Load(sqlData);
            trangthai = dts.Rows[0]["TenTrangThai"].ToString();
            return trangthai;
        }
    }
}