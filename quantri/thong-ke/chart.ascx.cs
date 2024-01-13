using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.quantri.thong_ke
{
    public partial class chart : System.Web.UI.UserControl
    {
        //check thống kê true: thống kê theo năm and false: thống kê theo tháng
        bool check = true;
        int summary;
        DataTable dtc = new DataTable();
        protected void addcolumn()
        {
            dtc = new DataTable("MyTable");
            dtc.Columns.Add(new DataColumn("SLdon", typeof(string)));
            dtc.Columns.Add(new DataColumn("MaHH", typeof(string)));
            dtc.Columns.Add(new DataColumn("TenHang", typeof(string)));
            dtc.Columns.Add(new DataColumn("sl", typeof(int)));
            dtc.Columns.Add(new DataColumn("TongTien", typeof(string)));


            DataRow dr = dtc.NewRow();
            dr["SLdon"] = 12;
            dr["MaHH"] = 9932;
            dr["TenHang"] = "dfssss";
            dr["sl"] = 321;
            dr["TongTien"] = 33;
        }
        protected void addsp(int sldon, string mahh, string TenHH, int sl, string tongtien)
        {
            DataRow dr = dtc.NewRow();
            dr["SLdon"] = sldon;
            dr["MaHH"] = mahh;
            dr["TenHang"] = TenHH;
            dr["sl"] = sl;
            dr["TongTien"] = tongtien;

            int x = -1;
            try
            {
                if (dtc.Rows.Count == 0)
                {
                    dtc.Rows.Add(dr);
                }
                else
                {
                    for (int i = 0; i < dtc.Rows.Count; i++)
                    {
                        if (mahh == Convert.ToString(dtc.Rows[i][1].ToString()))
                        {
                            x = i;
                            break;
                        }
                    }
                    if (x == -1)
                    {
                        dtc.Rows.Add(dr);
                    }
                }
            }
            catch
            {

            }


        }
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected string date()
        {
            string year = DateTime.Now.ToString().Trim();
            year = year.Substring(6, 4);
            return year;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
            lk2.Visible = false;
            litsum.Visible = false;
            ChartDBC.Series["ChartBDC"].Points.Clear();
            ChartDBT.Series["ChartDBT"].Points.Clear();
            chart_cs.Year = date();
            PlaceHolder1.Controls.Add(LoadControl("~/quantri/thong-ke/chartmin.ascx"));
            summary = 0;
            addcolumn();
            int year = Convert.ToInt32(date());
            lityearlbl.Text = year.ToString();
            loaddryear(year);
            connect();
            string s = "exec Month_donhang '"+date()+"','%%'";
            load(s);
            loadgrv();
            GridView1.DataSource = dtc;
            GridView1.DataBind();
            string tongtienfm = summary.ToString("#,##0 VND");
            litsum.Text = "<b>Tổng Thu: </b>"+ tongtienfm;
        }

        protected void ChartDBC_Load(object sender, EventArgs e)
        {

        }
        bool check2 = true;
        string minyear = "";
        protected void loaddryear(int year)
        {
            dryear.Items.Clear();
            if (check2 == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    dryear.Items.Add(year.ToString());
                    year--;
                }
                minyear = (year + 1).ToString();
            }
        }
        protected void load(string sql)
        {
            check = true;
            //connect();
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            //ChartDBT.DataSource = dt;
            //ChartDBT.Series["ChartBDT"].XAxisType = (System.Web.UI.DataVisualization.Charting.AxisType)System.Web.UI.DataVisualization.Charting.ChartValueType.Int32; 

            ChartDBC.Series["ChartBDC"].Points.Clear();
            ChartDBT.Series["ChartDBT"].Points.Clear();
            loadBDC_month(dt);
            loadBDT(dt);
        }
        //select theo tháng
        
        //select theo năm
        protected void loadBDC_month(DataTable dt)
        {
            check = true;
            ChartDBC.Titles["ChartBDC"].Text = "Biểu Đồ Thống kê: Năm "+dryear.SelectedItem.Text;
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 1", Convert.ToInt32(dt.Rows[0][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 2", Convert.ToInt32(dt.Rows[1][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 3", Convert.ToInt32(dt.Rows[2][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 4", Convert.ToInt32(dt.Rows[3][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 5", Convert.ToInt32(dt.Rows[4][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 6", Convert.ToInt32(dt.Rows[5][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 7", Convert.ToInt32(dt.Rows[6][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 8", Convert.ToInt32(dt.Rows[7][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 9", Convert.ToInt32(dt.Rows[8][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 10", Convert.ToInt32(dt.Rows[9][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 11", Convert.ToInt32(dt.Rows[10][1].ToString()));
            ChartDBC.Series["ChartBDC"].Points.AddXY("tháng 12", Convert.ToInt32(dt.Rows[11][1].ToString()));
        }
        //select biểu đồ tròn theo năm
        protected void loadBDT(DataTable dt)
        {
            ChartDBT.Series["ChartDBT"].Points.AddXY("1", Convert.ToInt32(dt.Rows[0][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("2", Convert.ToInt32(dt.Rows[1][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("3", Convert.ToInt32(dt.Rows[2][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("4", Convert.ToInt32(dt.Rows[3][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("5", Convert.ToInt32(dt.Rows[4][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("6", Convert.ToInt32(dt.Rows[5][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("7", Convert.ToInt32(dt.Rows[6][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("8", Convert.ToInt32(dt.Rows[7][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("9", Convert.ToInt32(dt.Rows[8][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("10", Convert.ToInt32(dt.Rows[9][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("11", Convert.ToInt32(dt.Rows[10][1].ToString()));
            ChartDBT.Series["ChartDBT"].Points.AddXY("12", Convert.ToInt32(dt.Rows[11][1].ToString()));
        }
        protected void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        protected void loadgrv()
        {
            command.Cancel();
            dtc.Rows.Clear();
            //connect();
            string sql = "select MaHH from tbl_HangHoa";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                loaddtc(dt.Rows[i][0].ToString());
            }
        }
        protected void loaddtc(string mahh)
        {
            command.Cancel();
            //connect();
            string sql = "exec select_sp '" + mahh + "','"+dryear.SelectedItem.Text+"'";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            addsp(Convert.ToInt32(dt.Rows[0][0].ToString()), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(),Convert.ToInt32(dt.Rows[0][3].ToString()), dt.Rows[0][4].ToString());
            summary += Convert.ToInt32(dt.Rows[0][4].ToString());
        }
        

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dryear_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart_cs.Year = dryear.SelectedItem.Text;
            PlaceHolder1.Controls.Clear();
            PlaceHolder1.Controls.Add(LoadControl("~/quantri/thong-ke/chartmin.ascx"));
            summary = 0;
            loadgrv();
            lityearlbl.Text = dryear.SelectedItem.Text;
            //connect();
            //if(dryear.SelectedItem.Text == minyear)
            //{
            //    int year = Convert.ToInt32(minyear);
            //    loaddryear(year);
            //    check2 = false;
            //}
            string s = "exec Month_donhang '" + dryear.SelectedItem.Text + "','%%'";
            load(s);
            GridView1.DataSource = dtc;
            GridView1.DataBind();

            string tongtienfm = summary.ToString("#,##0 VND");
            litsum.Text = "<b>Tổng Thu: </b>"+tongtienfm;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            lk1.Visible = false;
            GridView1.Visible = true;
            lk2.Visible = true;
            litsum.Visible = true;
        }

        protected void lk2_Click(object sender, EventArgs e)
        {
            lk1.Visible = true;
            GridView1.Visible = false;
            lk2.Visible = false;
            litsum.Visible = false;
        }
    }
}