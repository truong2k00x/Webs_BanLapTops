using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.GioiThieu.tintuc
{
    public partial class tin : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select top(18)* from TinTuc order by Matt desc";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var scr = dt.Rows[i][1].ToString();
                    string stc = scr;
                    stc = stc.Replace(" ", "");
                    Literal1.Text += "<div class='col-sm-4'><img width='220px' height='160px' src='"+ stc + "'/></div><div class='col-sm-8'><div style='font-size:24px'>" + dt.Rows[i][2].ToString() + "</div><div style='font-size:14px'>" + dt.Rows[i][4].ToString() + "</div><div style='font-size:16px'>" + dt.Rows[i][3].ToString() + "</div></div>";
                }
            }
        }
    }
}