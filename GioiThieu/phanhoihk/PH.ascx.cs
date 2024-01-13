using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace webs_banlaptop.GioiThieu.phanhoihk
{
    public partial class PH : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "Đặt Hàng Thành Công !", true);
            MaHD.Text = "Mã Hóa Đơn Của Bạn Là: "+SANPHAM.thanhtoan.TTthanhtoan.mahd+"";
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        int dg = 0;
        protected void Button1_Click(object sender, EventArgs e)
        {
            check();
            if(App_Start.datadn.user == "")
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "insert into phyc values('admin','"+dg+"',N'"+TextBox1.Text+"')";
                command = new SqlCommand(sql, connection);
                command.ExecuteReader();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "Đã Gửi Ý Kiến Đóng Góp.", true);
                Response.Redirect("index.aspx");
            }
            else
            {
                string sql = "insert into phyc values ('"+App_Start.datadn.user+"','" + dg + "',N'" + TextBox1.Text + "')";
                command = new SqlCommand(sql, connection);
                command.ExecuteReader();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "Đã Gửi Ý Kiến Đóng Góp.", true);
                Response.Redirect("index.aspx");
            }
        }
        public void check()
        {
            if (s5.ForeColor == System.Drawing.Color.Yellow)
                dg = 5;
            else if (s4.ForeColor == System.Drawing.Color.Yellow)
                dg = 4;
            else if (s3.ForeColor == System.Drawing.Color.Yellow)
                dg = 3;
            else if (s2.ForeColor == System.Drawing.Color.Yellow)
                dg = 2;
            else if (s1.ForeColor == System.Drawing.Color.Yellow)
                dg = 1;
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vui Lòng Đánh Giá Thang Điểm Từ 1-5 !')", true);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ý kiến của bạn đã được ghi nhận !')", true);
            Response.Redirect("index.aspx");
        }

        protected void s1_Click(object sender, EventArgs e)
        {
            s1.ForeColor = System.Drawing.Color.Yellow;
            s2.ForeColor = System.Drawing.Color.LightGray;
            s3.ForeColor = System.Drawing.Color.LightGray;
            s4.ForeColor = System.Drawing.Color.LightGray;
            s5.ForeColor = System.Drawing.Color.LightGray;
        }

        protected void s2_Click(object sender, EventArgs e)
        {
            s1.ForeColor = System.Drawing.Color.Yellow;
            s2.ForeColor = System.Drawing.Color.Yellow;
            s3.ForeColor = System.Drawing.Color.LightGray;
            s4.ForeColor = System.Drawing.Color.LightGray;
            s5.ForeColor = System.Drawing.Color.LightGray;
        }

        protected void s3_Click(object sender, EventArgs e)
        {
            s1.ForeColor = System.Drawing.Color.Yellow;
            s2.ForeColor = System.Drawing.Color.Yellow;
            s3.ForeColor = System.Drawing.Color.Yellow;
            s4.ForeColor = System.Drawing.Color.LightGray;
            s5.ForeColor = System.Drawing.Color.LightGray;
        }

        protected void s4_Click(object sender, EventArgs e)
        {
            s1.ForeColor = System.Drawing.Color.Yellow;
            s2.ForeColor = System.Drawing.Color.Yellow;
            s3.ForeColor = System.Drawing.Color.Yellow;
            s4.ForeColor = System.Drawing.Color.Yellow;
            s5.ForeColor = System.Drawing.Color.LightGray;
        }

        protected void s5_Click(object sender, EventArgs e)
        {
            s1.ForeColor = System.Drawing.Color.Yellow;
            s2.ForeColor = System.Drawing.Color.Yellow;
            s3.ForeColor = System.Drawing.Color.Yellow;
            s4.ForeColor = System.Drawing.Color.Yellow;
            s5.ForeColor = System.Drawing.Color.Yellow;
        }
    }
}