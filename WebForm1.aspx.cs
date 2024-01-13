using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webs_banlaptop.SANPHAM.thanhtoan.NganHang;

namespace webs_banlaptop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string piclaptop = App_Start.datadn.pic;
        string sqlcon = @"C:\USERS\TRUONG\SOURCE\REPOS\WEBS_BANLAPTOP\WEBS_BANLAPTOP\APP_DATA\DATABASE.MDF";
        SqlConnection connection;
        SqlCommand command;
        DataTable dttable;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<bank>(bankRawJson);

                DataTable dt = new DataTable();
                dt.Load((IDataReader)listBankData.data);

                Response.Write("<script>alert('"+dt.Rows.Count+"')</script>");
            }
        }
    }
}