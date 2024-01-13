using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop
{
    public partial class index : System.Web.UI.Page
    {
        
        string piclaptop = App_Start.datadn.pic;
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        DataTable dttable;
        string sqlselect = "";
        #region
        protected void sp01(DataTable dataTable, int a)
        {
            //Literaldemo1.Text = "<li data-target='#demosp1' data-slide-to='0' class='active'></li><li data-target='#demosp1' data-slide-to='1'></li><li data-target='#demosp1' data-slide-to='2'></li>";
            Literalsp1.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp1' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp1' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp1 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 1;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            Literal2.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            Literal3.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            Literal4.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp1.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + @"</b></p>" + s + "";
            TTsp1.Text += "<p style='text-align:center;position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn1.Visible = true;
            App_Start.datadn.masp1 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
        }
        protected void sp02(DataTable dataTable, int a)
        {
            Literalsp2.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp2' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp2' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp2 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 2;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp21.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp22.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp23.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp2.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + @"</b></p>" + s + "";
            TTsp2.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            //TTsp2.Text += "<button id='mn"+position+ "'runat='server' onclick='mn_onclick' style='color: #909010'>Thêm vào Giỏ Hàng</button>";
            btn2.Visible = true;
            App_Start.datadn.masp2 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
        }
        protected void sp03(DataTable dataTable, int a)
        {
            Literalsp3.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp3' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp3' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp3 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            int position = 3;
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp31.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp32.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp33.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp3.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp3.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            //TTsp3.Text += "<button id='mn" + position + "' onclick='mn_onclick' style='color: #909010'>Thêm vào Giỏ Hàng</button>";
            btn3.Visible = true;
        }
        protected void sp04(DataTable dataTable, int a)
        {
            Literalsp4.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp4' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp4' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp4 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 4; int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp41.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp42.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp43.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp4.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + @"</b></p>" + s + "";
            TTsp4.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn4.Visible = true;
        }
        protected void sp05(DataTable dataTable, int a)
        {
            Literalsp5.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp5' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp5' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp5 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 5;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp51.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp52.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp53.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp5.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp5.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn5.Visible = true;
        }
        protected void sp06(DataTable dataTable, int a)
        {
            Literalsp6.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp6' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp5' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp6 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            int position = 6;
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp61.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp62.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";

            TTsp6.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp6.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn6.Visible = true;
        }
        protected void sp07(DataTable dataTable, int a)
        {
            Literalsp7.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp7' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp7' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp7 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 7;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp71.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp72.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp73.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp7.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp7.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn7.Visible = true;
        }
        protected void sp08(DataTable dataTable, int a)
        {
            Literalsp8.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp8' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp8' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp8 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 8;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp81.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp82.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp83.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp8.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp8.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn8.Visible = true;
        }
        protected void sp09(DataTable dataTable, int a)
        {
            Literalsp9.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp9' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp9' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp9 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 9;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp91.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp92.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp93.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp9.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp9.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn9.Visible = true;
        }
        protected void sp10(DataTable dataTable, int a)
        {
            Literalsp10.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp10' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp10' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp10 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 10;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp101.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp102.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp103.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp10.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp10.Text += "<p style='position: absolute; bottom: 24px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn10.Visible = true;
        }
        protected void sp11(DataTable dataTable, int a)
        {
            Literalsp11.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp11' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp11' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp11 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 11;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp111.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp112.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp113.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp11.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp11.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn11.Visible = true;
        }
        protected void sp12(DataTable dataTable, int a)
        {
            Literalsp12.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp12' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp12' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp12 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 12;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp121.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp122.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp123.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp12.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp12.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn12.Visible = true;
        }
        protected void sp13(DataTable dataTable, int a)
        {
            Literalsp13.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp13' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp13' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp13 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 13;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp131.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp132.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp133.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp13.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp13.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn13.Visible = true;
        }
        protected void sp14(DataTable dataTable, int a)
        {
            Literalsp14.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp14' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp14' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp14 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 14;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp141.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp142.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp143.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp14.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp14.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn14.Visible = true;
        }
        protected void sp15(DataTable dataTable, int a)
        {
            Literalsp15.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp15' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp15' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp15 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 15;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp151.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp152.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp153.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp15.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp15.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn15.Visible = true;
        }
        protected void sp16(DataTable dataTable, int a)
        {
            Literalsp16.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp16' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp16' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp16 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 16;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp161.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp162.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp163.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp16.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp16.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn16.Visible = true;
        }
        protected void sp17(DataTable dataTable, int a)
        {
            Literalsp17.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp17' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp17' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp17 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 17;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp171.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp172.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp173.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp17.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp17.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn17.Visible = true;
        }
        protected void sp18(DataTable dataTable, int a)
        {
            Literalsp18.Text = "<a class='carousel-control-prev' style='color: black;' href='#demosp18' data-slide='prev'><span class='carousel-control-prev-icon'></span></a><a class='carousel-control-next' style='color: black;' href='#demosp18' data-slide='next'><span class='carousel-control-next-icon'></span></a>";
            App_Start.datadn.masp18 = Convert.ToInt32(dataTable.Rows[a][0].ToString());
            int position = 18;
            int c = Convert.ToString(dataTable.Rows[a][1].ToString()).Length;
            string s;
            if (c < 30)
            {
                s = "<br>";
            }
            else
            {
                s = "";
            }
            double amount = Convert.ToInt32(dataTable.Rows[a][7].ToString());
            string fomatamount = amount.ToString("#,##0 VND");
            sp181.Text = "<div class='carousel-item active'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/1.png' alt='Los Angeles' width='1100' height='500' ></div> ";
            sp182.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/2.png' alt='Los Angeles' width='1100' height='500' ></div>";
            sp183.Text = "<div class='carousel-item'><img src='" + piclaptop + Convert.ToString(dataTable.Rows[a][1].ToString()) + "/3.png' alt='Los Angeles' width='1100' height='500' ></div>";
            TTsp18.Text += "<p class='textbtm'><b>[Mới 100%]" + Convert.ToString(dataTable.Rows[a][1].ToString()) + "</b></p>" + s + "";
            TTsp18.Text += "<p style='position: absolute; bottom: 15px;color: #ff1a1a;'><b>Giá Bán:  " + fomatamount + "</b></p>";
            btn18.Visible = true;
        }
        #endregion
        protected void dlsql(DataTable dataTable, int a,int n)
        {
            ckt(dataTable);
            visible();
            if (n == 1)
            {
                to_false();
                for (int i = 1; i <= a; i++)
                {
                    switch (i)
                    {
                        case 1:
                            sp01(dataTable, i - 1);
                            break;
                        case 2:
                            sp02(dataTable, i - 1);
                            break;
                        case 3:
                            sp03(dataTable, i - 1);
                            break;
                        case 4:
                            sp04(dataTable, i - 1);
                            break;
                        case 5:
                            sp05(dataTable, i - 1);
                            break;
                        case 6:
                            sp06(dataTable, i - 1);
                            break;
                        case 7:
                            sp07(dataTable, i - 1);
                            break;
                        case 8:
                            sp08(dataTable, i - 1);
                            break;
                        case 9:
                            sp09(dataTable, i - 1);
                            break;
                        case 10:
                            sp10(dataTable, i - 1);
                            break;
                        case 11:
                            sp11(dataTable, i - 1);
                            break;
                        case 12:
                            sp12(dataTable, i - 1);
                            break;
                        case 13:
                            sp13(dataTable, i - 1);
                            break;
                        case 14:
                            sp13(dataTable, i - 1);
                            break;
                        case 15:
                            sp15(dataTable, i - 1);
                            break;
                        case 16:
                            sp16(dataTable, i - 1);
                            break;
                        case 17:
                            sp17(dataTable, i - 1);
                            break;
                        case 18:
                            sp18(dataTable, i - 1);
                            break;
                    }
                }
            }
            
        }
        int tt = 0;
        protected void ckctt()
        {
            plcethanhtoan.Controls.Add(LoadControl("~/SANPHAM/thanhtoan/NganHang/ThanhToanKD.ascx"));
        }
        protected void ckt(DataTable dt)
        {

            tt = dt.Rows.Count / 3;
            if (dt.Rows.Count % 3 != 0)
            {
                tt += 1;
            }
        }
        protected void checkpage(DataTable dt, int countsp, int n) 
        {
            if (n == 1)
            {
                dlsql(dt, countsp, n);
            }
            else
            {
                dlsql(dt, countsp, n);
            }
        }
        protected void selectionsql(string sql)
        {
            try
            {
                command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dttable = new DataTable();
                dttable.Load(dataReader);
                int count = Convert.ToInt32(dttable.Rows.Count.ToString());
                App_Start.datadn.countdtbl = count;
                if (count <= 18)
                {
                    App_Start.datadn.sltrang = 1;
                }
                else if (count % 18 != 0)
                {
                    int x = (count / 18) + 1;
                    App_Start.datadn.sltrang = x;
                }
                else
                {
                    App_Start.datadn.sltrang = count / 18;
                }
                checkpage(dttable, count, App_Start.datadn.sltrang);
            }
            catch
            {

            }
            
        }

       

        int x = 0;
        public void l_tin()
        {
            try
            {
                lttin.Text = "";
                string sql = "select top(18)* from TinTuc order by Matt desc";
                command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    if (tt < dt.Rows.Count)
                    {
                        x = tt;
                    }
                    else
                    {
                        x = dt.Rows.Count;
                    }
                    for (int i = 0; i < x - 1; i++)
                    {
                        var scr = dt.Rows[i][1].ToString();
                        string stc = scr;
                        stc = stc.Replace(" ", "");
                        lttin.Text += "<div><img width='100%' height='auto' src='" + stc + "'/></div><div><div style='font-size:24px'>" + dt.Rows[i][2].ToString() + "</div><div style='font-size:14px'>" + dt.Rows[i][4].ToString() + "</div><div style='font-size:16px'>" + dt.Rows[i][3].ToString() + "</div></div>";
                    }
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);
            }
        }
        protected void ncc()
        {
            try
            {
                txtlistdm.Text = "";
                Literal11ncc.Text = "";
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select * from tbl_NhaCC where TenNCC!=''";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ucncc = dt.Rows[i][1].ToString();
                        checkncc(ucncc);
                        txtlistdm.Text += "<a class='dropdown-item picture1' href='index.aspx?uc=" + ucncc + "'><img src='img/7/" + dt.Rows[i][1].ToString() + ".png'>" + dt.Rows[i][1].ToString() + "</a>";
                        Literal11ncc.Text += "<div class='item'><a href='index.aspx?uc=" + ucncc + "' aria-label='Thương hiệu " + dt.Rows[i][1].ToString() + "'><img src='img/7/" + dt.Rows[i][1].ToString() + ".png' alt='" + dt.Rows[i][1].ToString() + "'></a></div>";
                    }
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);
            }
        }
        string ucncc = "";
        protected void checkncc(string name)
        {
            switch (name)
            {
                case "lenovo":
                    ucncc = "lnv";
                    break; 
                case "razer":
                    ucncc = "raz";
                    break;
                case "microsoft":
                    ucncc = "mrs";
                    break;
            }
        }
        protected void recheckuc(string name)
        {
            switch (name)
            {
                case "lnv":
                    ucncc = "lenovo";
                    break; 
                case "raz":
                    ucncc = "razer";
                    break;
                case "mrs":
                    ucncc = "microsoft";
                    break;
            }
        }
        string checkuc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PTTT();
                ncc();
                clear();
                connection = new SqlConnection(sqlcon);
                connection.Open();

                string sql = "";
                // cập nhật ảnh và thông tin cho web sản phẩm
                string uc = "";
                if (Request.QueryString["uc"] != null)
                {
                    uc = Request.QueryString["uc"];
                    if (App_Start.Classcheck.uc != uc)
                    {
                        App_Start.Classcheck.uc = uc;
                        checkuc = uc;
                        recheckuc(checkuc);
                        sql = "select Top(18)* from tthh_view where TenNCC='" + checkuc + "' order by MaHH DESC";
                        sqlselect = sql;
                    }
                    else
                    {
                        App_Start.Classcheck.uc = "";
                        Response.Redirect("index.aspx");
                    }
                }
                else
                {
                    sql = "select Top(18)* from tbl_HangHoa order by MaHH DESC";
                    sqlselect = sql;
                }
                string suc = "";
                if (Request.QueryString["suc"] != null)
                {
                    suc = Request.QueryString["suc"];
                }
                switch (suc)
                {
                    case "search":
                        sql = "select Top(18)* from tthh_view where TenHang like '%" + App_Start.datadn.name + "%' or TenNCC like '%" + App_Start.datadn.name + "%' or  odell like '%" + App_Start.datadn.name + "%' or CPU like '%" + App_Start.datadn.name + "%' or Memory  like '%" + App_Start.datadn.name + "%' or SSD like '%" + App_Start.datadn.name + "%' or  VGA like '%" + App_Start.datadn.name + "%' or Display like '%" + App_Start.datadn.name + "%' " +
                            "or Audio like '%" + App_Start.datadn.name + "%' or Other like '%" + App_Start.datadn.name + "%' or Wireless like '%" + App_Start.datadn.name + "%' or Battery like '%" + App_Start.datadn.name + "%' or Weight like '%" + App_Start.datadn.name + "%' or SoftWare like '%" + App_Start.datadn.name + "%' or Camera like '%" + App_Start.datadn.name + "%' or BanPhim like '%" + App_Start.datadn.name + "%'" +
                            " or  MauSac like '%" + App_Start.datadn.name + "%' order by MaHH DESC";
                        sqlselect = sql;
                        break;
                }

                selectionsql(sql);

                lbluser.Text = App_Start.datadn.user;

                if (lbluser.Text == "")
                {
                    Literal1.Text = "<a class='dropdown-item picture1' id='acc' href='main.aspx'><img src='img/7/acer.png'>Đăng Nhập</a>";
                    logout.Visible = false;
                }
                else
                {
                    if (App_Start.datadn.ck == true)
                    {
                        Literal1.Text = "<a class='dropdown-item picture1' id='acc' href='admin.aspx'><img src='img/7/acer.png'>ADMIN</a>";
                    }
                    else
                    {

                        Literal1.Text = "<button type='button' class='dropdown-item picture1 btn btn-primary' data-bs-toggle='modal' data-bs-target='#exampleModal'><img src='img/7/asus.png'>Đổi Mật Khẩu</button>";
                        thongbaocart();
                    }
                    logout.Visible = true;
                }

                shopcard();
                l_tin();
                ckctt();
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);
            }
            
            //string lc = "";
            //if (Request.QueryString["lc"] != null)
            //{
            //    lc = Request.QueryString["lc"];
            //}
            //if(lc == "DN")
            //{
            //    Response.Redirect("main.aspx");
            //}
        }
        protected void thongbaocart()
        {
            if (App_Start.datadn.user != "")
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select * from Thongbao where TT='1' and TenTK='" + App_Start.datadn.user + "'";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    thongbaocartlbl.Text = "<a href=soluction.aspx?uc=Nction><div class='shop-cart-number-badge'>" + dt.Rows.Count + "</div></a>";
                }
            }
            else
            {
                if (GioHang.datagiohang.dt1.Rows.Count > 0)
                {
                    thongbaocartlbl.Text = "<a href=soluction.aspx?uc=Nction><div class='shop-cart-number-badge'>" + GioHang.datagiohang.dt1.Rows.Count + "</div></a>";
                }
            }
        }
        protected void shopcard()
        {
            if (App_Start.datadn.user != "")
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select * from GioHang where TenTK='" + App_Start.datadn.user + "'";
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    shopcardlr.Text = "<a href=soluction.aspx?uc=gh><div class='shop-cart-number-badge'>" + dt.Rows.Count + "</div></a>";
                }
            }
            else
            {
                if(GioHang.datagiohang.dt1.Rows.Count > 0)
                {
                    shopcardlr.Text = "<a href=soluction.aspx?uc=gh><div class='shop-cart-number-badge'>" + GioHang.datagiohang.dt1.Rows.Count + "</div></a>";
                }
            }
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            Literal1.Text = "<a class='dropdown-item picture1' id='acc' href='main.aspx'><img src='img/7/acer.png'>Đăng Nhập</a>";
            lbluser.Text = "";
            App_Start.datadn.user = "";
            App_Start.datadn.password = "";
        }
        protected void btn_onclick(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx?uc=search");
        }
        protected void mn_onclick(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Data inserted successfully')</script>");
        }
        protected void to_false()
        {
            //btnback_to_page.Visible = false;
            //btnnumberpage.Visible = false;
            //btnpage_end.Visible = false;
            //btnnextpage.Visible = false;
            //lbl1.Visible = false;
            //lbl2.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            App_Start.datadn.name = txt1x.Text;
        }

        protected void txt1x_Disposed(object sender, EventArgs e)
        {
            clear();
            App_Start.datadn.name = txt1x.Text;
            connection = new SqlConnection(sqlcon);
            connection.Open();
            command.Cancel();
            string sql = "select Top(18)* from tthh_view where TenNCC='" + App_Start.datadn.name + "' order by MaHH DESC";
            sqlselect = sql;
            selectionsql(sql);
            Response.Redirect("index.aspx?suc=search");
        }
        protected void clear()
        {
            Literal4.Text = "";
            Literal3.Text = "";
            Literal2.Text = "";
            TTsp1.Text = "";
            sp21.Text = "";
            sp22.Text = "";
            sp23.Text = "";
            sp24.Text = "";
            TTsp2.Text = "";
            sp31.Text = "";
            sp32.Text = "";
            sp33.Text = "";
            sp34.Text = "";
            TTsp3.Text = "";
            sp41.Text = "";
            sp42.Text = "";
            sp43.Text = "";
            sp44.Text = "";
            TTsp4.Text = "";

            sp51.Text = "";
            sp52.Text = "";
            sp53.Text = "";
            sp54.Text = "";
            //////////
            sp61.Text = "";
            sp62.Text = "";
            sp63.Text = "";
            sp64.Text = "";
            //////////
            sp71.Text = "";
            sp72.Text = "";
            sp73.Text = "";
            sp74.Text = "";
            //////////
            sp81.Text = "";
            sp82.Text = "";
            sp83.Text = "";
            sp84.Text = "";
            //////////
            sp91.Text = "";
            sp92.Text = "";
            sp93.Text = "";
            sp94.Text = "";
            //////////
            sp101.Text = "";
            sp102.Text = "";
            sp103.Text = "";
            sp104.Text = "";
            //////////
            sp111.Text = "";
            sp112.Text = "";
            sp113.Text = "";
            sp114.Text = "";
            //////////
            sp121.Text = "";
            sp122.Text = "";
            sp123.Text = "";
            sp124.Text = "";
            //////////
            sp131.Text = "";
            sp132.Text = "";
            sp133.Text = "";
            sp134.Text = "";
            //////////
            sp141.Text = "";
            sp142.Text = "";
            sp143.Text = "";
            sp144.Text = "";
            //////////
            sp151.Text = "";
            sp152.Text = "";
            sp153.Text = "";
            sp154.Text = "";
            //////////
            sp161.Text = "";
            sp162.Text = "";
            sp163.Text = "";
            sp164.Text = "";
            //////////
            sp171.Text = "";
            sp172.Text = "";
            sp173.Text = "";
            sp174.Text = "";
            //////////
            sp181.Text = "";
            sp182.Text = "";
            sp183.Text = "";
            sp184.Text = "";
            //////////
            TTsp5.Text = "";
            TTsp6.Text = "";
            TTsp7.Text = "";
            TTsp8.Text = "";
            TTsp9.Text = "";
            TTsp10.Text = "";
            TTsp11.Text = "";
            TTsp12.Text = "";
            TTsp13.Text = "";
            TTsp14.Text = "";
            TTsp15.Text = "";
            TTsp16.Text = "";
            TTsp17.Text = "";
            TTsp18.Text = "";

        }
        protected void visible()
        {
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;
            btn10.Visible = false;
            btn11.Visible = false;
            btn12.Visible = false;
            btn13.Visible = false;
            btn14.Visible = false;
            btn15.Visible = false;
            btn16.Visible = false;
            btn17.Visible = false;
            btn18.Visible = false;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Button name = (Button)sender;
            switch (name.ID)
            {
                case "btn1":
                    load_gh(ref App_Start.datadn.masp1);
                    break;
                case "btn2":
                    load_gh(ref App_Start.datadn.masp2);
                    break;
                case "btn3":
                    load_gh(ref App_Start.datadn.masp3);
                    break;
                case "btn4":
                    load_gh(ref App_Start.datadn.masp4);
                    break;
                case "btn5":
                    load_gh(ref App_Start.datadn.masp5);
                    break;
                case "btn6":
                    load_gh(ref App_Start.datadn.masp6);
                    break;
                case "btn7":
                    load_gh(ref App_Start.datadn.masp7);
                    break;
                case "btn8":
                    load_gh(ref App_Start.datadn.masp8);
                    break;
                case "btn9":
                    load_gh(ref App_Start.datadn.masp9);
                    break;
                case "btn10":
                    load_gh(ref App_Start.datadn.masp10);
                    break;
                case "btn11":
                    load_gh(ref App_Start.datadn.masp11);
                    break;
                case "btn12":
                    load_gh(ref App_Start.datadn.masp12);
                    break;
                case "btn13":
                    load_gh(ref App_Start.datadn.masp13);
                    break;
                case "btn14":
                    load_gh(ref App_Start.datadn.masp14);
                    break;
                case "btn15":
                    load_gh(ref App_Start.datadn.masp15);
                    break;
                case "btn16":
                    load_gh(ref App_Start.datadn.masp16);
                    break;
                case "btn17":
                    load_gh(ref App_Start.datadn.masp17);
                    break;
                case "btn18":
                    load_gh(ref App_Start.datadn.masp18);
                    break;
            }
        }
        protected void load_gh(ref int a)
        {
            try
            {
                if (App_Start.datadn.user == "")
                {
                    if (GioHang.datagiohang.dt1.Rows.Count == 0)
                    {
                        GioHang.datagiohang.addcolumn();
                        int sl = 1;
                        string ssqlcheck = "select * from tbl_HangHoa where MaHH='" + a + "'";
                        sqlselect = ssqlcheck;
                        connection = new SqlConnection(sqlcon);
                        connection.Open();
                        command = new SqlCommand(ssqlcheck, connection);
                        SqlDataReader sqldatareader = command.ExecuteReader();
                        DataTable dt113 = new DataTable();
                        dt113.Load(sqldatareader);
                        command.Cancel();
                        GioHang.datagiohang.addsp(Convert.ToString(a), dt113.Rows[0][1].ToString(), sl, dt113.Rows[0][7].ToString());
                    }
                    else
                    {
                        int sl = 1;
                        string ssqlcheck = "select * from tbl_HangHoa where MaHH='" + a + "'";
                        sqlselect = ssqlcheck;
                        connection = new SqlConnection(sqlcon);
                        connection.Open();
                        command = new SqlCommand(ssqlcheck, connection);
                        SqlDataReader sqldatareader = command.ExecuteReader();
                        DataTable dt113 = new DataTable();
                        dt113.Load(sqldatareader);
                        command.Cancel();
                        GioHang.datagiohang.addsp(Convert.ToString(a), dt113.Rows[0][1].ToString(), sl, dt113.Rows[0][7].ToString());
                    }
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Add to Cart Successfully')", true);
                    shopcard();
                }
                else
                {
                    string ssqlcheck = "select * from GioHang where MaHH='" + a + "'";
                    connection = new SqlConnection(sqlcon);
                    connection.Open();
                    command = new SqlCommand(ssqlcheck, connection);
                    SqlDataReader sqldatareader = command.ExecuteReader();
                    DataTable dt113 = new DataTable();
                    dt113.Load(sqldatareader);
                    command.Cancel();
                    if (Convert.ToInt32(dt113.Rows.Count.ToString()) == 0)
                    {
                        string ssqladd = "insert into GioHang values('" + a + "','" + App_Start.datadn.user + "','1','')";
                        command = new SqlCommand(ssqladd, connection);
                        command.ExecuteReader();
                    }
                    else
                    {
                        string ssqladd = "update GioHang set TenTK='" + App_Start.datadn.user + "',sl=sl+1 where MaHH='" + a + "'";
                        command = new SqlCommand(ssqladd, connection);
                        command.ExecuteReader();
                    }
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Add to Cart Successfully')", true);
                    shopcard();
                    thongbaocart();
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!')", true);
            }
        }

        protected void txtbtnsave_Click(object sender, EventArgs e)
        {
            if (App_Start.datadn.password == App_Start.password.Hash(App_Start.password.Encrypt(password1.Text)))
            {
                bool checkup = true;
                App_Start.datadn.password = App_Start.password.Hash(App_Start.password.Encrypt(password1.Text));
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "";
                if(password2.Text == password3.Text)
                {
                    if (App_Start.datadn.ck == true)
                    {
                        sql = "update tbl_Admin set MatKhau='"+App_Start.password.Encrypt(password2.Text)+"' where TaiKhoan='"+App_Start.datadn.user+"'";
                    }
                    else
                    {
                        sql = "update tbl_TKKhach set MatKhau='"+App_Start.password.Encrypt(password2.Text)+ "' where TenTk='" + App_Start.datadn.user + "'";
                    }
                    command = new SqlCommand(sql, connection);
                    command.ExecuteReader();
                    command.Cancel();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Đổi Mật Khẩu Thành Công!')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Mật Khẩu mới Không Khớp!')", true);
                }
            }
        }
        public event EventHandler TextChanged;
        protected void password3_TextChanged(object sender, EventArgs e)
        {
            txtcanhbao.Text = "jdshfjksahg";
        }
        protected void PTTT()
        {
            //Ther.Text = "";
            //connection = new SqlConnection(sqlcon);
            //connection.Open();
            //string sql = "select * from PTThanhToan";
            //command = new SqlCommand(sql, connection);
            //SqlDataReader sqlDataReader = command.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sqlDataReader);
            //for(int i =0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i][1].ToString() != "Thanh Toán Khi Nhận Hàng")
            //    {
            //        Ther.Text += "<div style='margin-bottom: 20px; display:flex;justify-content:center' class='items border'><img style='width: 167px;height:56px' src='img/p_laptop/cart/" + dt.Rows[i][1].ToString() + ".png' /></div>";
            //    }
            //}
        }
        public void ck(bool ck)
        {
            if(App_Start.Classcheck.c1 == true) {
                App_Start.Classcheck.cc1 = "";
            }

            
        }
        string vp = "MaLH='03'";
        string lap_2d = "MaLH='04'";
        string lap_3d = "MaLH='01' or MaLH='02'";
        string ga = "MaLH='01'";
        string qd = "MaLH='05' or MaLH='01' or MaLH='03'";
        string Ltr = "MaLH='06'";
        protected void chk_vp_ht_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select Top(18)* from tthh_view where "+vp+"";
            if (chk_2d.Checked == true)
            {
                sql += " or " + lap_2d;
                if (chk_3d.Checked == true)
                {
                    sql += " or " + lap_3d;
                    if (chk_GM.Checked == true)
                    {
                        sql += " or " + ga;
                        if (chk_if.Checked == true)
                        {
                            sql += " or " + Ltr;
                            if (chk_qd.Checked == true)
                            {
                                sql += " or " + qd;
                            }
                        }
                    }
                }
            }
            selectionsql(sql);
        }

        protected void chk_qd_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select Top(18)* from tthh_view where " + qd + "";
            if (chk_2d.Checked == true)
            {
                sql += " or " + lap_2d;
                if (chk_3d.Checked == true)
                {
                    sql += " or " + lap_3d;
                    if (chk_GM.Checked == true)
                    {
                        sql += " or " + ga;
                        if (chk_if.Checked == true)
                        {
                            sql += " or " + Ltr;
                            if (chk_vp_ht.Checked == true)
                            {
                                sql += " or " + vp;
                            }
                        }
                    }
                }
            }
            selectionsql(sql);
        }

        protected void chk_2d_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select Top(18)* from tthh_view where " + lap_2d + "";
            if (chk_vp_ht.Checked == true)
            {
                sql += " or " + vp;
                if (chk_3d.Checked == true)
                {
                    sql += " or " + lap_3d;
                    if (chk_GM.Checked == true)
                    {
                        sql += " or " + ga;
                        if (chk_if.Checked == true)
                        {
                            sql += " or " + Ltr;
                            if (chk_qd.Checked == true)
                            {
                                sql += " or " + qd;
                            }
                        }
                    }
                }
            }
            selectionsql(sql);
        }

        protected void chk_GM_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select Top(18)* from tthh_view where " + ga + "";
            if (chk_2d.Checked == true)
            {
                sql += " or " + lap_2d;
                if (chk_3d.Checked == true)
                {
                    sql += " or " + lap_3d;
                    if (chk_vp_ht.Checked == true)
                    {
                        sql += " or " + vp;
                        if (chk_if.Checked == true)
                        {
                            sql += " or " + Ltr;
                            if (chk_qd.Checked == true)
                            {
                                sql += " or " + qd;
                            }
                        }
                    }
                }
            }
            selectionsql(sql);
        }

        protected void chk_3d_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select Top(18)* from tthh_view where " + lap_3d + "";
            if (chk_2d.Checked == true)
            {
                sql += " or " + lap_2d;
                if (chk_vp_ht.Checked == true)
                {
                    sql += " or " + vp;
                    if (chk_GM.Checked == true)
                    {
                        sql += " or " + ga;
                        if (chk_if.Checked == true)
                        {
                            sql += " or " + Ltr;
                            if (chk_qd.Checked == true)
                            {
                                sql += " or " + qd;
                            }
                        }
                    }
                }
            }
            selectionsql(sql);
        }

        protected void chk_if_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select Top(18)* from tthh_view where " + Ltr + "";
            if (chk_2d.Checked == true)
            {
                sql += " or " + lap_2d;
                if (chk_3d.Checked == true)
                {
                    sql += " or " + lap_3d;
                    if (chk_GM.Checked == true)
                    {
                        sql += " or " + ga;
                        if (chk_vp_ht.Checked == true)
                        {
                            sql += " or " + vp;
                            if (chk_qd.Checked == true)
                            {
                                sql += " or " + qd;
                            }
                        }
                    }
                }
            }
            selectionsql(sql);
        }
    }
}