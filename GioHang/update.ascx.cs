using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.GioHang
{
    public partial class update : System.Web.UI.UserControl
    {
        string piclaptop = App_Start.datadn.pic;
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        DataTable dttable;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtten.Text = datagiohang.mahh;
            txtsoluong.Text = Convert.ToString(datagiohang.sl);
            txtgiaban.Text = Convert.ToString(datagiohang.giaban);
            txttenhh.Text = datagiohang.tenhh;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (App_Start.datadn.user == "")
            {
                datagiohang.remove(txtten.Text);
                datagiohang.addsp(txtten.Text, txttenhh.Text, Convert.ToInt32(txtsoluong.Text), txtgiaban.Text);
                Response.Redirect("soluction.aspx?uc=gh");
            }
            else
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "update GioHang set sl=" + txtsoluong.Text + " where TenTK='" + App_Start.datadn.user + "' and MaHH='" + txtten.Text + "'";
                command = new SqlCommand(sql, connection);
                command.ExecuteReader();
                Response.Redirect("soluction.aspx?uc=gh");
            }
        }
    }
}