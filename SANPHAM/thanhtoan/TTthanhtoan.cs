using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webs_banlaptop.SANPHAM.thanhtoan
{
    public class TTthanhtoan
    {
        public static bool ck = true;
        public static string MaKh = "";
        public static string tenkh = "";
        public static string sdt = "";
        public static string diachi = "";
        public static string email = "";


        public static string MaHH = "";
        public static string tenHang = "";
        public static int GiaBan;

        public static string mahd = "";
        public static string MaTT = "PT001";
        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string bin { get; set; }
            public string shortName { get; set; }
            public string logo { get; set; }
            public int transferSupported { get; set; }
            public int lookupSupported { get; set; }
            public string short_name { get; set; }
            public int support { get; set; }
            public int isTransfer { get; set; }
            public string swift_code { get; set; }
        }

        public class bank
        {
            public string code { get; set; }
            public string desc { get; set; }
            public IList<Datum> data { get; set; }
        }
    }
}