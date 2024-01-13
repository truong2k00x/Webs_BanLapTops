using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace webs_banlaptop.GioiThieu.ThongBao
{
    public partial class Nction : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string duc = "";
            if (Request.QueryString["duc"] != null)
            {
                duc = Request.QueryString["duc"];
                popup(duc);
            }
            if (App_Start.datadn.user == "")
            {
                thongbao.Text = "<div class='border ' style='text-align:center;font-size:20px'><b>Nhập Mã Đơn Để Kiểm Tra Trạng Thái</b></div>";
                PlaceHolder1.Controls.Add(LoadControl("~/GioiThieu/ThongBao/searchHoaDon.ascx"));
            }
            else
            {
                thongbao.Text = "";
                
                string sql = "select * from Thongbao where TenTk='" + App_Start.datadn.user + "' order by [date] desc";
                command = new SqlCommand(sql,connection);
                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                command.Cancel();
                dataReader.Close();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    string duxc = "";
                    string test =dt.Rows[i]["header"].ToString();

                    Regex regexObj = new Regex(@"(d+)([^0-9]+)", RegexOptions.IgnorePatternWhitespace);
                    Match match = regexObj.Match(test);

                    string numPart = match.Groups[1].Value;
                    while (match.Success)
                    {
                        match = match.NextMatch();
                        duxc = numPart;
                    }
                    string background = "LightGray";
                    string tb = "<i class='fa-solid fa-circle-exclamation'></i>";
                    if (dt.Rows[i]["TT"].ToString() == "2")
                    {
                        background = "while";
                        tb = "";
                    }
                    thongbao.Text += @"<a href='soluction.aspx?uc=Nction&duc=" + test + "'><div style='margin-top:10px;Background-color:"+background+"'><div style='font-size:20px;' class='row'><div class='col-sm-10'><b>" + dt.Rows[i]["header"].ToString() + "</b></div><div class='col-sm-2' style='text-align:right;color:red'>"+tb+"</div></div>"
                        + "<div style='margin-top:5px;Background-color:"+background+"'>"+ dt.Rows[i]["footer"].ToString() + "</div>"
                        +"<div style='font-size:10px'>"+ dt.Rows[i]["date"].ToString() + "</div></div></a>";
                }
            }
        }
        public void popup(string d)
        {
            string sql = "select * from Thongbao where header like N'%"+d+"%'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader sqlData = cmd.ExecuteReader();
            DataTable dts = new DataTable();
            dts.Load(sqlData);
            cmd.Cancel();
            sqlData.Close();
            txtcanhbao.Text = "<div style='margin-top:10px;Background-color:LightGray'><div style='font-size:20px;'><b>" + dts.Rows[0]["header"].ToString() + "</b></div>"
                        + "<div style='margin-top:5px;Background-color:LightGray'>" + dts.Rows[0]["footer"].ToString() + "</div>"
                        + "<div style='font-size:10px'>" + dts.Rows[0]["date"].ToString() + "</div></div>";
            sqlData.Close();
            string sqlt = "update Thongbao set TT='2' where header like N'%" + d + "%'";
            command = new SqlCommand(sqlt, connection);
            SqlDataReader s = command.ExecuteReader();
            command.Cancel();
            s.Close();
            command.Cancel();
        }
    }
}