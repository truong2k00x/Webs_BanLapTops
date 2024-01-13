using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webs_banlaptop.KhachHang
{
    public class newttkhcl
    {
        public static string makh = "";
        public static int makhnew = 1;
        public static void maKH(string MaKH)
        {
            var numberKH = MaKH;
            numberKH = numberKH.Replace("KH", "0");
            int maKH = Convert.ToInt32(numberKH);
            int maKHnew = maKH + 1;
            makhnew = maKHnew;
        }
    }
}