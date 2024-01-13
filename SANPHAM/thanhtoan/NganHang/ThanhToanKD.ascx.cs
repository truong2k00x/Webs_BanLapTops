using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.SANPHAM.thanhtoan.NganHang
{
    public partial class ThanhToanKD : System.Web.UI.UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string sqlcon = App_Start.datadn.sql1;
        protected void Page_Load(object sender, EventArgs e)
        {
            lithanhtoan.Text = "";
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from Datum where check_code='1'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lithanhtoan.Text += "<li style='margin-top:10px' class='border'><img width='70px'' height='auto' src='" + dt.Rows[i]["logo"].ToString() + "' />" + dt.Rows[i]["short_name"].ToString() + "</li>";
            }
        }
    }
}