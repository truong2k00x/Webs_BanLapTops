using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.SANPHAM.load_ncc_lh
{
    public partial class LoaiHang : System.Web.UI.UserControl
    {
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            malh();
            load_ncc();
            dcnh();
        }
        public void load_ncc()
        {
            DropDownList1.Items.Clear();
            string sql = "select * from tbl_NhaCC";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem ls = new ListItem();
                ls.Value = dt.Rows[i]["MaNCC"].ToString();
                ls.Text = dt.Rows[i]["TenNCC"].ToString();
                DropDownList1.Items.Add(ls);
            }
        }
        public void dcnh()
        {
            DropDownList2.Items.Clear();
            string sql = "select * from tbl_TTBH";
            command = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem ls = new ListItem();
                ls.Value = dt.Rows[i]["MaTTBH"].ToString();
                ls.Text = dt.Rows[i]["DiaChi"].ToString();
                DropDownList2.Items.Add(ls);
            }
        }
        public void malh()
        {
            string sql = "select * from tbl_LoaiHang order by  desc ";
            command = new SqlCommand(sql,connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable at = new DataTable();
            at.Load(dataReader);
            
            txtmalh.Text = Convert.ToString(Convert.ToInt32(at.Rows[0]["MaLH"].ToString())+1);
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            
        }
    }
}