using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace webs_banlaptop.GioiThieu.tintuc
{
    public partial class admintt : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from TinTuc order by Matt desc";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataTable = new DataTable();
                dataTable.Load(dataReader);
                GRVTT.DataSource = dataTable;
                GRVTT.DataBind();
                tt_tintuc.mattnew(dataTable.Rows[0][0].ToString());
            }           
            command.Cancel();
        }
        public void remove(string a)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "delete from TinTuc where Matt='"+a+"'";
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();
            load();
        }
        protected void NhanVienGRV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void NhanVienGRV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void NhanVienGRV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "TT")
            {
                tt_tintuc.matt = HttpUtility.HtmlDecode(GRVTT.Rows[row].Cells[0].Text);
                tt_tintuc.img = HttpUtility.HtmlDecode(GRVTT.Rows[row].Cells[1].Text);
                tt_tintuc.header = HttpUtility.HtmlDecode(GRVTT.Rows[row].Cells[2].Text);
                tt_tintuc.nd = HttpUtility.HtmlDecode(GRVTT.Rows[row].Cells[3].Text);
                Response.Redirect("admin.aspx?uc=tin&suc=uptin");
            }
            else if (e.CommandName == "delete")
            {
                string a = GRVTT.Rows[row].Cells[0].Text;
                remove(a);
            }
        }

        protected void btnsr_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from TinTuc where matt like '%"+TextBox1.Text+"%' or header like '%"+TextBox1.Text+"%' order by Matt desc";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable = new DataTable();
            dataTable.Load(dataReader);
            GRVTT.DataSource = dataTable;
            GRVTT.DataBind();
            tt_tintuc.mattnew(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString());
            command.Cancel();
        }
    }
}