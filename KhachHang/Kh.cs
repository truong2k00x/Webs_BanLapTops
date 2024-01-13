using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webs_banlaptop.KhachHang
{
    public class Kh
    {
        public static string makh = "";
        public static string tenkh = "";
        public static string diachi = "";
        public static string dienthoai = "";
        public static string email = "";
        public static string tentk = "";
        public static int makhnew=1;
        public static void maKH(string MaKH)
        {
            try
            {
                var numberKH = MaKH;
                numberKH = numberKH.Replace("KH", "0");
                int maKH = Convert.ToInt32(numberKH);
                int maKHnew = maKH + 1;
                makhnew = maKHnew;
            }
            catch
            {

            }
        }
        
    }
}