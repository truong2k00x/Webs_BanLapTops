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
    public partial class admin_user : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        private void loadtkadmin(string sql)
        {            
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select top(10)* from tbl_Admin order by TaiKhoan asc";
            loadtkadmin(sql);
        }

        protected void btnsr_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select top(10)* from tbl_Admin where TenAdmin like '%"+TextBox1.Text+ "%' or TaiKhoan like '%" + TextBox1.Text + "%' order by TaiKhoan asc";
            loadtkadmin(sql);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "tttk1")
            {
                useradmin.nameuser = GridView1.Rows[row].Cells[0].Text;
                useradmin.user = GridView1.Rows[row].Cells[1].Text;
                useradmin.password = GridView1.Rows[row].Cells[2].Text;
                Response.Redirect("admin.aspx?uc=user&suc=upuser");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}