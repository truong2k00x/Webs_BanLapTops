using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.SANPHAM.thanhtoan.NganHang
{
    public partial class loadnh : System.Web.UI.UserControl
    {
        DataTable dt = new DataTable();
        string sqlcon = App_Start.datadn.sql1;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {

            ApiBank_Request.mabank = "PT001";
            connect();
            loadncc();
        }
        public void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        public void loadncc()
        {
            DropDownList1.Items.Clear();
            string sql = "select * from Datum where check_code='1'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sqlDataReader);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem ls = new ListItem();
                ls.Value = dt.Rows[i]["bin"].ToString();
                ls.Text = dt.Rows[i]["short_name"].ToString();

                DropDownList1.Items.Add(ls);
            }
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        bool ck = false;
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bin = DropDownList1.SelectedItem.Value.Trim();
            string name = DropDownList1.SelectedItem.Text.Trim();
            string sql = "select * from Datum where check_code='1' and bin='" + bin + "' and short_name='" + name + "'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dts = new DataTable();
            dts.Load(sqlDataReader);

            string infobank1 = GetPassword();
            Label1.Text = infobank1;
            ApiBank_Request.infobank = infobank1;


            ApiBank_Request.mabank = "PT002";



            var apiRequest = new ApiRequet();
            apiRequest.acqId = Convert.ToInt32(bin); ;
            apiRequest.accountNo = dts.Rows[0]["number_cart"].ToString();
            apiRequest.accountName = dts.Rows[0]["Name_cart"].ToString();
            apiRequest.amount = Convert.ToInt32(ApiBank_Request.amount);
            apiRequest.addInfo = ApiBank_Request.infobank;
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
            Image1.ImageUrl = dataResult.data.qrDataURL;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ApiBank_Request.mabank = "PT001";

            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}