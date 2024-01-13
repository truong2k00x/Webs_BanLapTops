using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace webs_banlaptop
{
    public partial class Dky : System.Web.UI.Page
    {
        string strcon = App_Start.datadn.sql;
        SqlConnection myconnection;
        protected void Page_Load(object sender, EventArgs e)
        {
            myconnection = new SqlConnection(strcon);
            myconnection.Open();
        }

        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        protected void btnlogin2_Click(object sender, EventArgs e)
        {
            //try
            //{
                string user = username.Text;
                user = user.ToLower();
                if(check_user(user) == true)
                {
                    string spassword2 = password2.Text;
                    string spassword1 = password1.Text;


                    if (spassword1 == spassword2)
                    {
                        if (isEmail(Convert.ToString(txtemail.Text)) == true)
                        {
                            string sql = "insert into tbl_TKKhach values('" + user + "','" + App_Start.password.Encrypt(spassword1) + "','" + txtemail.Text + "')";
                            SqlCommand cmd = new SqlCommand(sql, myconnection);
                            cmd.ExecuteNonQuery();
                            Response.Write("<script>alert('Đăng Ký Thành Công')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('email: " + txtemail.Text + " không đúng định dạng')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('vui lòng nhập lại mật khẩu')</script>");
                        password2.Focus();
                    }
                }
                else
                {
                    Response.Write("<script>alert('tên tài khoản đã được sử dụng')</script>");
                }
            //}
            //catch (Exception)
            //{
            //    Response.Write("<script>alert('tên tài khoản đã được sử dụng')</script>");
            //}
        }
        public bool check_user(string user)
        {
            string sql = "select * from tbl_admin where TaiKhoan='" + user + "'";
            SqlCommand command = new SqlCommand(sql, myconnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if(sqlDataReader.HasRows)
            {
                return false;
            }
            else
            {
                sqlDataReader.Close();
                string sql1 = "select * from tbl_TKKhach where TenTk='" + user + "'";
                SqlCommand command1 = new SqlCommand(sql1, myconnection);
                SqlDataReader sqlDataReader1 = command1.ExecuteReader();
                if (sqlDataReader1.HasRows)
                {
                    sqlDataReader1.Close();
                    return false;
                }
                else
                {
                    sqlDataReader1.Close();
                    return true;
                }
            }
        }
    }
}