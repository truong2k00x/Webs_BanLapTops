using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.HoaDon
{
    public partial class donhang : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            load1();
            load2();
        }
        public void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        public void load1()
        {
            connect();
            string sql = "select * from tbl_HDban where MaTrangThai='" + ListBox1.SelectedValue.ToString() + "' order by MaHD";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            clsHD.dt1 = dt;
        }
        public void load2()
        {
            //connect();
            //string sql = "select * from DONHANG where trangthai=N'" + ListBox1.SelectedValue.ToString() + "' order by MaDon";
            //command = new SqlCommand(sql, connection);
            //SqlDataReader sqlDataReader = command.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sqlDataReader);
            //GridView2.DataSource = dt;
            //GridView2.DataBind();
            //clsHD.dt2 = dt;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            load1();
            load2();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "check")
            {
                clsHD.check = false;
                clsHD.mahd = GridView1.Rows[row].Cells[0].Text;
                clsHD.dtc = clsHD.dt1;
                Response.Redirect("admin.aspx?uc=cf");
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //int row = Convert.ToInt32(e.CommandArgument);
            //if (e.CommandName == "check")
            //{
            //    clsHD.check = true;
            //    clsHD.mahd = GridView2.Rows[row].Cells[0].Text;
            //    clsHD.dtc = clsHD.dt2;
            //    Response.Redirect("admin.aspx?uc=cf");
            //}
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load1();
        }
    }
}