using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace webs_banlaptop
{
    public partial class doipassword : System.Web.UI.Page
    {
        string user = App_Start.datadn.user;
        string strcon = App_Start.datadn.sql;
        SqlConnection myconnection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (user == "")
            {
                Response.Redirect("main.aspx");
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            myconnection = new SqlConnection(strcon);
            myconnection.Open();
            if (password2.Text == password3.Text)
            {
                if (App_Start.datadn.password == App_Start.password.Hash(App_Start.password.Encrypt(password1.Text))) ;
                {
                    string sql = "update tbl_TKKhach set MatKhau='"+ App_Start.password.Encrypt(password2.Text)+"' where TenTk='"+user+"'";
                    SqlCommand cmd = new SqlCommand(sql, myconnection);
                    cmd.ExecuteReader();
                    Response.Write("<script>alert('Đổi Mật Khẩu Thành Công')</script>");
                    Response.Redirect("index.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Mật Khẩu Mới Không Giống Nhau')</script>");
                password3.Text = "";
                password3.Focus();
            }
        }
    }
}