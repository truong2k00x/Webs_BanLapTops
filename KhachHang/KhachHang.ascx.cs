using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.KhachHang
{
    public partial class KhachHangcl : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
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
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            Kh.maKH(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString());
            command.Cancel();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "HT")
            {
                Kh.makh = GridView1.Rows[row].Cells[0].Text;
                Kh.tenkh = HttpUtility.HtmlDecode(GridView1.Rows[row].Cells[1].Text);
                Kh.diachi = HttpUtility.HtmlDecode(GridView1.Rows[row].Cells[2].Text);
                Kh.dienthoai = HttpUtility.HtmlDecode(GridView1.Rows[row].Cells[3].Text);
                Kh.email = HttpUtility.HtmlDecode(GridView1.Rows[row].Cells[4].Text);
                Kh.tentk = GridView1.Rows[row].Cells[5].Text;
                Response.Redirect("admin.aspx?uc=cus&suc=upcus");
            }
        }
        private void newsave(string sql)
        {

            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();

        }
        private void select(string sql)
        {
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
        protected void btnsr_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from tbl_KH where MaKH like '%" + TextBox1.Text + "%' or TenKH like '%" + TextBox1.Text + "%' or DiaChi like N'%" + TextBox1.Text + "%' or DienThoai like N'%" + TextBox1.Text + "%' or email like '%" + TextBox1.Text + "%' or TenTK like '%" + TextBox1.Text + "%' order by MaKH asc";
            select(sql);
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    txtmakh.Text = "KH" + Convert.ToString(Kh.makhnew);
        //    string sql = "insert into tbl_KH(MaKH) values('"+txtmakh.Text+"')";
        //    newsave(sql);
        //    load();
        //}

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    string sql = "update tbl_KH set TenKH = N'"+txttenkh.Text+"',DiaChi = N'"+txtdiachi.Text+"',DienThoai = '"+txtsdt.Text+"',email = '"+txtemail.Text+"',TenTK = '"+txttk.Text+"' where MaKH = '"+txtmakh.Text+"'";
        //    newsave(sql);
        //    load();

        //}

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    string sql = "delete tbl_KH where MaKH='" + txtmakh.Text + "'";
        //    newsave(sql);
        //    load();
        //}
    }
}