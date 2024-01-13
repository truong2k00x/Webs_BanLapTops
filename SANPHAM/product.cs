using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webs_banlaptop.SANPHAM
{
    public class product
    {
        public static string mahh = "";
        public static string tenhh = "";
        public static string malh = "";
        public static string sl = "";
        public static string slton = "";
        public static string gianiemyet = "";
        public static string giaban = "";
        public static int newmancc = 1;
        public static int newmaLH = 1;

        public static void MaNCC(string mancc1)
        {
            var numberncc = mancc1;
            int mancc = Convert.ToInt32(numberncc);
            int manccnew = mancc + 1;
            newmancc = manccnew;
        }
        public static void MaLH(string malh1)
        {
            var numberlh = malh1;
            int malh = Convert.ToInt32(numberlh);
            int malhnew = malh + 1;
            newmaLH = malhnew;
        }
        public int productId { get; set; } //id san pham
        public string productName { get; set; } //ten sản phẩm
        public string Décription { get; set; } //thông tin sản phẩm
        public int Status { get; set; } //trạng thái sản phẩm
        public byte[] image { get; set; } //hình ảnh của sản phẩm
        public string urlimage { get; set; }//đường dẫn của hình ảnh
    }
}