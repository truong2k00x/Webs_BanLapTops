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
    public partial class User_KH : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        private void loadtkk(string sql)
        {
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            GridView2.DataSource = dataTable;
            GridView2.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select top(10)* from tbl_TKKhach order by TenTK asc";
            connection = new SqlConnection(sqlcon);
            connection.Open();
            loadtkk(sql);
        }

        protected void btnsr_Click(object sender, EventArgs e)
        {

        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument.ToString());
            if(e.CommandName== "tttk2")
            usertkk.user = GridView2.Rows[row].Cells[0].Text;
            usertkk.password = GridView2.Rows[row].Cells[1].Text;
            usertkk.email = GridView2.Rows[row].Cells[2].Text;
            Response.Redirect("admin.aspx?uc=userk&suc=upuserk");
        }
    }
}