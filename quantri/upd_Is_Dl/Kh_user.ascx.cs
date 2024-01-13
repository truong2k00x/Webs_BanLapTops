using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace webs_banlaptop.quantri.upd_Is_Dl
{
    public partial class Kh_user : System.Web.UI.UserControl
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
            string suc = "";
            if (Request.QueryString["suc"] != null)
            {
                suc = Request.QueryString["suc"];
            }
            if(suc != "newuser")
            {
                txtTenTK.Text = usertkk.user;
                if (usertkk.password != "")
                {

                    txtpassword.Text = App_Start.password.Decrypt(usertkk.password);
                }
                txtemail.Text = usertkk.email;
            }
        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "delete tbl_TKKhach where TaiKhoan='" + txtTenTK.Text + "'";
            newsave(sql);

        }

        protected void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "insert into tbl_TKKhach values('" + txtTenTK.Text + "','" + App_Start.password.Encrypt(txtpassword.Text) + "','" + txtemail.Text + "')";
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
            string sql = "update tbl_TKKhach set MatKhau='"+App_Start.password.Encrypt(txtpassword.Text)+"',email='"+txtemail.Text+"' where TaiKhoan='" + txtTenTK.Text + "'";
            newsave(sql);
        }
    }
}