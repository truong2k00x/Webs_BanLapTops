using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.SANPHAM.thanhtoan.NganHang
{
    public partial class etd_task : System.Web.UI.UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string sqlcon = App_Start.datadn.sql1;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblautt.Text = "";
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from Datum";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem ls = new ListItem();
                ls.Value = dt.Rows[i]["bin"].ToString();
                //ls.Text = "("+dt.Rows[i]["bin"].ToString()+")" + dt.Rows[i]["short_name"].ToString();
                ls.Text = dt.Rows[i]["short_name"].ToString();

                drops.Items.Add(ls);
            }
            name();
        }
        public void check()
        {
            string sql = "select * from Datum where bin='" + drops.SelectedItem.Value.Trim() +"'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            if (Convert.ToInt32(dt.Rows[0]["check_code"].ToString()) == 0)
            {
                string sqlup = "update Datum set check_code=1,number_cart='"+TextBox1.Text+"',Name_cart=N'"+TextBox2.Text+"' where bin='"+drops.SelectedItem.Value.Trim()+"'";
                command = new SqlCommand(sqlup, connection);
                command.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Thêm Tài Khoản Thành công!')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Tài Khoản Đã Được Xác Minh!')", true);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {


        }

        protected void txtbtnsave_Click(object sender, EventArgs e)
        {
            check();
        }
        public void name()
        {
            lblautt.Text = "";
            lblautt.Text += "Ngân Hàng:"+ drops.SelectedItem.Text + "</br>Số Tài Khoản:" + TextBox1.Text  + "</br>Tên Tài Khoản:" + TextBox2.Text;
        }
        protected void drops_SelectedIndexChanged(object sender, EventArgs e)
        {
            name();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            name();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            name();
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            var apiRequest = new ApiRequet();
            apiRequest.acqId = Convert.ToInt32(drops.SelectedItem.Value.Trim());
            apiRequest.accountNo = TextBox1.Text;
            apiRequest.accountName = TextBox2.Text;
            apiRequest.amount = Convert.ToInt32("0");
            apiRequest.format = "Text";
            apiRequest.template = "compact";
            var JsonRequest = JsonConvert.SerializeObject(apiRequest);

            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", JsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);
            string url = dataResult.data.qrDataURL.Trim();
            img.ImageUrl = dataResult.data.qrDataURL;
        }
    }
}