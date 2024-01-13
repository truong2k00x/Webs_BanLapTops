using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace webs_banlaptop
{
    public partial class main : System.Web.UI.Page
    {
        string strcon = App_Start.datadn.sql;
        SqlConnection myconnection;
        MD5 md = MD5.Create();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Labelcount.Text = string.Format("Số lần postback 0");
            App_Start.datadn.ck = false;
            App_Start.datadn.cknv = false;
            App_Start.datadn.user = "";
            App_Start.datadn.password = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = username.Text;
                App_Start.datadn.user = username.Text;
                App_Start.datadn.password = App_Start.password.Hash(App_Start.password.Encrypt(txtpassword.Text));
                user = user.ToLower();
                string password = App_Start.password.Encrypt(txtpassword.Text);
                myconnection = new SqlConnection(strcon);
                myconnection.Open();
                string sql = "select * from tbl_Admin where TaiKhoan = '" + user + "' and MatKhau = '" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, myconnection);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    Response.Write("<script>alert('login tc')</script>");
                    App_Start.datadn.ck = true;
                    Response.Redirect("admin.aspx");
                    username.Text = "";
                    txtpassword.Text = "";
                }
                else
                {
                    cmd.Cancel();
                    data.Close();
                    string sqlnv = "select * from tbl_NhanVien where DienThoai = '" + user + "' and SCCCD = '" + password + "'";
                    SqlCommand cmdnv = new SqlCommand(sqlnv, myconnection);
                    SqlDataReader datanv = cmdnv.ExecuteReader();
                    if (datanv.HasRows)
                    {
                        Response.Write("<script>alert('login tc')</script>");
                        App_Start.datadn.ck = true;
                        App_Start.datadn.cknv = true;
                        Response.Redirect("admin.aspx");
                        username.Text = "";
                        txtpassword.Text = "";

                    }
                    else
                    {
                        cmdnv.Cancel();
                        datanv.Close();
                        string sql2 = "select * from tbl_TKKhach where TenTk = '" + user + "' and MatKhau = '" + password + "'";
                        SqlCommand cmd1 = new SqlCommand(sql2, myconnection);
                        SqlDataReader data1 = cmd1.ExecuteReader();
                        if (data1.HasRows)
                        {
                            Response.Write("<script>alert('login tc')</script>");
                            App_Start.datadn.ck = false;
                            Response.Redirect("index.aspx");
                            username.Text = "";
                            txtpassword.Text = "";
                        }
                        else
                        {
                            Response.Write("<script>alert('login fail')</script>");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('fail connect')</script>");
            }
        }
    }
}