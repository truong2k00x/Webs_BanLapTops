using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace webs_banlaptop.SANPHAM.load_ncc_lh
{
    public partial class addncc : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtmancc.Text = Convert.ToString(product.newmancc);
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('cones')</script>");
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "insert into tbl_NhaCC values ('" + txtmancc.Text + "','" + txttenncc.Text + "','" + txtdiachi.Text + "','" + txtsdt.Text + "')";
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
        }
    }
}