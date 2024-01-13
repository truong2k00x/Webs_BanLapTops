using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.login
{
    public partial class dangnhap : System.Web.UI.UserControl
    {
        string strcon = App_Start.datadn.sql;
        SqlConnection myconnection;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtuser.Text;
                string admin = "admin";
                App_Start.datadn.user = txtuser.Text;
                App_Start.datadn.password = txtpassword.Text;
                user = user.ToLower();
                string password = txtpassword.Text;
                myconnection = new SqlConnection(strcon);
                myconnection.Open();
                string sql = "select * from tbl_Admin where TaiKhoan = '" + user + "' and MatKhau = '" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, myconnection);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    Response.Write("<script>alert('login tc')</script>");
                    Response.Redirect("admin.aspx");
                    txtuser.Text = "";
                    txtpassword.Text = "";
                    //Response.Redirect("khoa.aspx");
                    //txtuser.Text = "";
                    //txtpassword.Text = "";


                    //access.count++;
                    //Labelcount.Text = string.Format("số lần postback {0}", access.count);
                }
                else
                {
                    Response.Write("<script>alert('login fail')</script>");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('fail connect')</script>");
            }
        }
    }
}