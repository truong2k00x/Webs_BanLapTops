using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.quantri
{
    public partial class user : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            GridView1.Visible = false;
            Label2.Visible = false;
            txtnguoiqt.Visible = false;
            txtuser.Visible = false;
            txtpass.Visible = false;
            Label3.Visible = false;
            Label6.Visible = false;
            loadtkk();
            loadtkadmin();
        }
        private void loadtkk()
        {
            string sql = "select * from tbl_TKKhach order by TenTK asc";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            GridView2.DataSource = dataTable;
            GridView2.DataBind();
        }
        private void loadtkadmin()
        {
            string sql = "select * from tbl_Admin order by TaiKhoan asc";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtnguoiqt.Visible = false;
            txtuser.Visible = false;
            txtpass.Visible = false;
            GridView1.Visible = false;
            GridView2.Visible = true;
            Label2.Visible = false;
            Label3.Visible = false;
            Label6.Visible = false;
            txtnguoiqt.Visible = false;
            Label5.Visible = true;
            Label7.Visible = true;
            txtpass0.Visible = true;
            txtuser0.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtnguoiqt.Visible = true;
            txtuser.Visible = true;
            txtpass.Visible = true;
            GridView1.Visible = true;
            GridView2.Visible = false;
            Label2.Visible = true;
            Label3.Visible = true;
            Label6.Visible = true;
            Label5.Visible = false;
            Label7.Visible = false;
            txtpass0.Visible = false;
            txtuser0.Visible = false;

        }
        private void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "tttk1")
            {
                txtnguoiqt.Text = GridView1.Rows[row].Cells[0].Text;
                txtuser.Text = GridView1.Rows[row].Cells[1].Text;
                txtpass.Text = GridView1.Rows[row].Cells[2].Text;
                Button2_Click(sender,e);
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "tttk2")
            {
                txtuser0.Text = GridView1.Rows[row].Cells[0].Text;
                txtpass0.Text = GridView1.Rows[row].Cells[1].Text;
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            connect();
            if(GridView1.Visible == true)
            {
                try
                {
                    string sqlnew = "insert into tbl_Admin values(N'" + txtnguoiqt.Text + "',N'" + txtuser.Text + "',N'" + txtpass.Text + "')";
                    command = new SqlCommand(sqlnew, connection);
                    command.ExecuteReader();
                    command.Cancel();
                    loadtkadmin();
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    string sqlnew = "insert into tbl_TKKhach values(N'" + txtuser0.Text + "',N'" + txtpass0.Text + "')";
                    command = new SqlCommand(sqlnew, connection);
                    command.ExecuteReader();
                    command.Cancel();
                    loadtkk();
                }
                catch
                {
                    //Response.Write("<script>alert('tên đăng nhập đã tồn tại')</script>");
                }
                
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            connect();
            if(GridView1.Visible == true)
            {
                string sql = "select * from tbl_Admin where TaiKhoan like '%"+TextBox1.Text+"%' or TenAdmin like '%"+TextBox1.Text+"%' order by TaiKhoan asc";
                command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
            else
            {
                string sql = "select * from tbl_TKKhach where TenTK like '%" + TextBox1.Text + "%' order by TenTK asc";
                command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                GridView2.DataSource = dataTable;
                GridView2.DataBind();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            connect();
            loadtkk();
            loadtkadmin();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            connect();
            if (GridView1.Visible == true)
            {
                string sqladd = "update tbl_Admin set TenAdmin = N'"+txtnguoiqt.Text+"',TaiKhoan = '"+txtuser.Text+"',MatKhau = '"+txtpass.Text+"'";
                command = new SqlCommand(sqladd, connection);
                command.ExecuteReader();
                loadtkadmin();
            }
            else
            {
                string sqladd = "update tbl_TKKhach set TenTk='"+txtuser0.Text+"',MatKhau='"+txtpass0.Text+"'";
                command = new SqlCommand(sqladd, connection);
                command.ExecuteReader();
                loadtkk();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            connect();
            if (GridView1.Visible == true)
            {
                string sqlremove = "delete from tbl_Admin where TaiKhoan='" + txtuser.Text + "'";
                command = new SqlCommand(sqlremove, connection);
                command.ExecuteNonQuery();
                loadtkadmin();
            }
            else
            {
                string sqlremove = "delete from tbl_TKKhach where TenTk='" + txtuser0.Text + "'";
                command = new SqlCommand(sqlremove, connection);
                command.ExecuteNonQuery();
                loadtkk();
            }
        }
    }
}