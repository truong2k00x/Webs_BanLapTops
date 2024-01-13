using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webs_banlaptop.SANPHAM
{
    public partial class tt_sp : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                string sql = "select MaHH from tbl_HangHoa";
                command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                int count = dataTable.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    string a = Convert.ToString(dataTable.Rows[i][0].ToString());
                    ListBoxmasp.Items.Add(a);
                }
            }
            catch
            {

            }
            
        }
        
        protected void GridView1_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBoxmasp.Items.Clear();
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select MaHH from tbl_HangHoa";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            int count = dataTable.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string a = Convert.ToString(dataTable.Rows[i][0].ToString());
                ListBoxmasp.Items.Add(a);
            }
        }

        protected void Buttonluu_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string masp = ListBoxmasp.SelectedValue;
            string sql = "update tbl_ttHH set odell=N'" + txtodell.Text + "', CPU=N'"+txtcpu.Text+ "',Memory=N'"+txtmemory.Text+ "',SSD=N'"+txtssd.Text+ "',VGA=N'"+txtvga.Text+ "',Display=N'"+txtdisplay.Text+  "',BanPhim=N'"+txtkey.Text+ "',Camera=N'"+txtcamera.Text+ "',Audio=N'"+txtaudio.Text+ "',Other=N'"+txtother.Text+ "',Wireless=N'"+txtwireless.Text+ "',Battery=N'"+txtbettery.Text+ "',Weight=N'"+txtweight.Text+ "',SoftWare=N'"+txtSW.Text+ "',XuatXu=N'"+txtxuatxu.Text+ "',MauSac=N'"+txtcolor.Text+ "',BaoHanh='"+txtBH.Text+"' where MaHH='"+masp+"'";
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        protected void btntt_Click(object sender, EventArgs e)
        {
            string masp = ListBoxmasp.SelectedValue;
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql1 = "select hh.TenHang,tt.* from tbl_HangHoa hh inner join tbl_ttHH tt on tt.MaHH=hh.MaHH where hh.MaHH='" + masp + "'";
            command = new SqlCommand(sql1, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);

            txttensp.Text = dataTable.Rows[0][0].ToString();
            txtodell.Text = dataTable.Rows[0][2].ToString();
            txtcpu.Text = dataTable.Rows[0][3].ToString();
            txtmemory.Text = dataTable.Rows[0][4].ToString();
            txtssd.Text = dataTable.Rows[0][5].ToString();
            txtvga.Text = dataTable.Rows[0][6].ToString();
            txtdisplay.Text = dataTable.Rows[0][7].ToString();
            txtkey.Text = dataTable.Rows[0][8].ToString();
            txtcamera.Text = dataTable.Rows[0][9].ToString();
            txtaudio.Text = dataTable.Rows[0][10].ToString();
            txtother.Text = dataTable.Rows[0][11].ToString();
            txtwireless.Text = dataTable.Rows[0][12].ToString();
            txtbettery.Text = dataTable.Rows[0][13].ToString();
            txtweight.Text = dataTable.Rows[0][14].ToString();
            txtSW.Text = dataTable.Rows[0][15].ToString();
            txtxuatxu.Text = dataTable.Rows[0][16].ToString();
            txtcolor.Text = dataTable.Rows[0][17].ToString();
            txtBH.Text = dataTable.Rows[0][18].ToString();
        }
    }
}