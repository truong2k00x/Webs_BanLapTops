using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webs_banlaptop.GioiThieu.tintuc
{
    public class tt_tintuc
    {
        public static string matt = "TT1";
        

        public static void mattnew(string ma)
        {
            try
            {
                var numberKH = ma;
                numberKH = numberKH.Replace("TT", "0");
                int maKH = Convert.ToInt32(numberKH);
                int maKHnew = maKH + 1;
                matt = "TT"+Convert.ToString(maKHnew);
            }
            catch
            {

            }
        }
        public static string img = "";
        public static string header = "";
        public static string nd = "";
    }
}