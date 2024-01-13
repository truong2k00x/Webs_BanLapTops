using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace webs_banlaptop
{
    public partial class quenpassword : System.Web.UI.Page
    {
        string strcon = App_Start.datadn.sql;
        SqlConnection myconnection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmail(Convert.ToString(emailInput.Text)) == true)
                {
                    myconnection = new SqlConnection(strcon);
                    myconnection.Open();
                    string sql = "select * from tbl_TKKhach where email='" + emailInput.Text + "'";
                    command = new SqlCommand(sql, myconnection);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(sqlDataReader);
                    if (dataTable.Rows.Count == 0)
                    {
                        Response.Write("<script>alert('email: " + emailInput.Text + " chưa đăng ký tài khoản')</script>");
                        emailInput.Text = null;
                    }
                    else
                    {
                        lbl.Visible = true;
                        lblpass.Visible = true;
                        lblpass.Text = App_Start.password.Decrypt(Convert.ToString(dataTable.Rows[0][1].ToString()));
                    }
                }
                else
                {
                    Response.Write("<script>alert('email: " + emailInput.Text + " không đúng định dạng')</script>");
                }
            }
            catch
            {

            }
        }
    }
}