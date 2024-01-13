using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.GioHang
{
    public class datagiohang
    {
        public static string mahh = "";
        public static string tenhh = "";
        public static decimal sl;
        public static decimal giaban;

        public static DataTable dt1 = new DataTable();
        public static void addsp(string a, string b, int c,string d)
        {
            DataRow dr = dt1.NewRow();
            dr["MaHH"] = a;
            dr["TenHang"] = b;
            dr["sl"] = c;
            dr["GiaBan"] = d;

            int x = 0;
            try
            {
                if (dt1.Rows.Count == 0)
                {
                    dt1.Rows.Add(dr);
                }
                else
                {
                    int count = 0;
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (a == Convert.ToString(dt1.Rows[i][0].ToString()))
                        {
                            count += 1;
                            x = i;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        dt1.Rows.Add(dr);
                    }
                    else
                    {
                        c += Convert.ToInt32(dt1.Rows[x][2].ToString());
                        remove(a);
                        addsp(a, b, c, d);
                    }
                }
            }
            catch
            {

            }


        }
        public static void addcolumn()
        {
            dt1 = new DataTable("MyTable");
            dt1.Columns.Add(new DataColumn("MaHH", typeof(string)));
            dt1.Columns.Add(new DataColumn("TenHang", typeof(string)));
            dt1.Columns.Add(new DataColumn("sl", typeof(int)));
            dt1.Columns.Add(new DataColumn("GiaBan", typeof(string)));
        }
        public static void remove(string a)
        {
            DataRow[] drx = dt1.Select("MaHH='" + a + "'");
            foreach (var row in drx)
                row.Delete();
        }
    }
}