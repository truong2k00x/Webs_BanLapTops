using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace webs_banlaptop.SANPHAM
{
    public class datasp
    {
        //    public string 
        public SqlConnection Conn = null;
        public static string masp = "";
        public datasp()
        {
            //    string cs = System.Configuration.ConfigurationManager.ConnectionStrings["QLYBANHANG.Properties.Settings.quanlyxuatnhapkhoConnectionString"].ToString();
            string cs = "Data Source=laptop-m2humip2\\maya0;Initial Catalog=thinkproo;Integrated Security=True";

            Conn = new SqlConnection(cs);
        }
        public DataTable GetSqlTable(string sQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                Conn.Open();
                //Console.WriteLine("Kết nối DB thành công");

                SqlDataAdapter sda = new SqlDataAdapter(sQuery, Conn);
                sda.Fill(dt);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                dt = null;
            }
            finally
            {
                Conn.Close();
            }

            return dt;
        }
    }
}