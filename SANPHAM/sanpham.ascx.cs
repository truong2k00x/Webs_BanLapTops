using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace webs_banlaptop.SANPHAM
{
    public partial class sanpham : System.Web.UI.UserControl
    {
        string FilePath = "";
        //datasp da = new datasp();
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            load();
        }
        private void load()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from tbl_HangHoa order by MaHH DESC";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            SanPhamGRV.DataSource = dataTable;
            SanPhamGRV.DataBind();
            App_Start.datadn.maxmasp = Convert.ToInt32(SanPhamGRV.Rows[0].Cells[0].Text);
        }
        
      
        protected void FileUpload1_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_Load(object sender, EventArgs e)
        {
           
        }

        
        protected void loadcontrol()
        {
            
        }
        protected void SanPhamGRV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "SP")
            {
                App_Start.datadn.masp = SanPhamGRV.Rows[row].Cells[0].Text;
                product.mahh = SanPhamGRV.Rows[row].Cells[0].Text;
                product.tenhh = SanPhamGRV.Rows[row].Cells[1].Text;
                product.malh = SanPhamGRV.Rows[row].Cells[2].Text;
                product.sl = SanPhamGRV.Rows[row].Cells[3].Text;
                product.slton = SanPhamGRV.Rows[row].Cells[4].Text;
                product.gianiemyet = SanPhamGRV.Rows[row].Cells[5].Text;
                product.giaban = SanPhamGRV.Rows[row].Cells[6].Text;
                Response.Redirect("admin.aspx?uc=prd&suc=upprd");
            }
        }
        private void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
       

        protected void add_sptt(ref int ma)
        {
            connect();
            string sqlnew = "insert into tbl_ttHH(MaHH) values('" + ma + "')";
            command = new SqlCommand(sqlnew, connection);
            command.ExecuteReader();
            command.Cancel();
        }
        
        
       
        
        
        

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select * from tbl_HangHoa where MaHH like '%" + TextBox1.Text + "%' or TenHang like '%" + TextBox1.Text + "%' or MaLH like '%" + TextBox1.Text + "%' or MaNCC  like '%" + TextBox1.Text + "%'  order by MaHH DESC";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            SanPhamGRV.DataSource = dataTable;
            SanPhamGRV.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
        }

        protected void SanPhamGRV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            //DataTable dt = (DataTable)this.SanPhamGRV.DataSource;
            //DataView dtview = new DataView(dt);

            //dtview.RowFilter = "MaHH =" + txtsearch.Text;
            //SanPhamGRV.DataSource = dtview;

            //SanPhamGRV.DataSource = "select * from tbl_HangHoa where MaHH like '%" + txtsearch.Text + "%' or TenHang like '%" + txtsearch.Text + "%' or MaLH like '%" + txtsearch.Text + "%' or MaNCC  like '%" + txtsearch.Text + "%'  order by MaHH DESC";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}