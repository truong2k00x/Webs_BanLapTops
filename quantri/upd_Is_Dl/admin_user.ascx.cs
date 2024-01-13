using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace webs_banlaptop.quantri.upd_Is_Dl
{
    public partial class admin_user : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        private void newsave(string sql)
        {

            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            txtnameQT.Text = useradmin.nameuser;
            txttentk.Text = useradmin.user;
            if(useradmin.password!="")
            {
                txtpassword.Text = App_Start.password.Decrypt(useradmin.password);
            }
        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "delete tbl_Admin where TaiKhoan='" + txttentk.Text + "'";
            newsave(sql);
        }

        protected void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "insert into tbl_Admin values('" + txtnameQT.Text + "','" + txttentk.Text + "','" + App_Start.password.Encrypt(txtpassword.Text) + "')";
                newsave(sql);
            }
            catch
            {
                Response.Write("<script>alert('tên đăng nhập đã được đăng ký')</script>");
            }
        }

        protected void btnupdate_Click1(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "update tbl_Admin set TenAdmin='" + txtnameQT.Text + "',MatKhau='"+ App_Start.password.Encrypt(txtpassword.Text) +"' where TaiKhoan='" + txttentk.Text + "'";
            newsave(sql);
        }
    }
}