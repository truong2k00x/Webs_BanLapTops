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
    public partial class newsp : System.Web.UI.UserControl
    {
        string FilePath = "";
        //datasp da = new datasp();
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            loadncc();
            loadlh();
            txtmahh.Text = product.mahh;
            txttenhh.Text = product.tenhh;
            lisbox2.SelectedValue = product.malh;
            txtsoluong.Text = product.sl;
            txtslton.Text = product.slton;
            txtgiaban.Text = product.giaban;
            txtgianiemyet.Text = product.gianiemyet;
            if (product.tenhh != "")
            {
                Image1.ImageUrl = "/img/SP/anh san pham/" + product.tenhh + "/1.png";
                Image2.ImageUrl = "/img/SP/anh san pham/" + product.tenhh + "/2.png";
                Image3.ImageUrl = "/img/SP/anh san pham/" + product.tenhh + "/3.png";
            }
        }
        private void loadncc()
        {
            ListBox1.Items.Clear();
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select MaNCC,TenNCC from tbl_NhaCC";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            int count = dataTable.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string b = Convert.ToString(dataTable.Rows[i][0].ToString());
                string a = Convert.ToString(dataTable.Rows[i][1].ToString());
                ListItem dataItem = new ListItem();
                dataItem.Text = a;
                dataItem.Value = b;
                ListBox1.Items.Add(dataItem);
                product.MaNCC(Convert.ToString(dataTable.Rows[i][0].ToString()));
            }
            command.Cancel();
        }
        private void loadlh()
        {
            lisbox2.Items.Clear();
            connection = new SqlConnection(sqlcon);
            connection.Open();
            string sql = "select MaLH,TenLH from tbl_LoaiHang";
            command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            int count = dataTable.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string b = Convert.ToString(dataTable.Rows[i][0].ToString());
                string a = Convert.ToString(dataTable.Rows[i][1].ToString());
                ListItem dataItem = new ListItem();
                dataItem.Text = a;
                dataItem.Value = b;
                lisbox2.Items.Add(dataItem);
                product.MaLH(Convert.ToString(dataTable.Rows[i][0].ToString()));
            }
            command.Cancel();
        }
        private void NewMethod()
        {
            //DropDownList1.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //App_Start.datadn.masp = DropDownList1.SelectedValue.ToString();
            //txtloaihang.Text = App_Start.datadn.masp;
        }
        private void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            command.Cancel();
            connect();
            string sqladd = "update tbl_HangHoa set TenHH='" + txttenhh.Text + "',MaLH='" + Convert.ToString(lisbox2.SelectedValue) + "',Soluong='" + txtsoluong.Text + "',SLTon='" + txtslton.Text + "',GiaNiemYet='" + txtgianiemyet.Text + "',GiaBan='" + txtgiaban.Text + "' where MaHH='" + txtmahh.Text + "'";
            command = new SqlCommand(sqladd, connection);
            command.ExecuteReader();
            command.Cancel();
        }
        protected void inserttthh()
        {
            int maspnew = App_Start.datadn.maxmasp;
            connect();
            string sqlnew = "insert into tbl_ttHH values('" + maspnew + "','','','','','','','','','','','','','','','','','')";
            command = new SqlCommand(sqlnew, connection);
            command.ExecuteReader();
            command.Cancel();
        }
        protected void removegh()
        {
            connect();
            string sqlremove = "delete from GioHang where MaHH='" + txtmahh.Text + "'";
            command = new SqlCommand(sqlremove, connection);
            command.ExecuteNonQuery();
        }
        protected void remove()
        {
            connect();
            string sqlremove = "delete from tbl_ttHH where MaHH='" + txtmahh.Text + "'";
            command = new SqlCommand(sqlremove, connection);
            command.ExecuteNonQuery();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            FilePath = MapPath("/img/SP/anh san pham/" + txttenhh.Text + "/");
            remove();
            removegh();
            Response.Write("<script>alert('Data inserted successfully')</script>");
            connect();
            string sqlremove = "delete from tbl_HangHoa where MaHH='" + txtmahh.Text + "'";
            command = new SqlCommand(sqlremove, connection);
            command.ExecuteReader();
            command.Cancel();
            if (!Directory.Exists(FilePath))
            {
                Directory.Delete(FilePath);
            }
            Response.Redirect("admin.aspx?uc=prd");
        }
        protected void btnuploadimg_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && FileUpload1.HasFile && CheckFileType(FileUpload1.FileName))
            {
                string img1 = "1.png";
                string img2 = "2.png";
                string img3 = "3.png";
                FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/img/SP/anh san pham/" + txttenhh.Text + "/" + img1);
                FileUpload2.SaveAs(Request.PhysicalApplicationPath + "/img/SP/anh san pham/" + txttenhh.Text + "/" + img2);
                FileUpload3.SaveAs(Request.PhysicalApplicationPath + "/img/SP/anh san pham/" + txttenhh.Text + "/" + img3);
                Image1.ImageUrl = "/img/SP/anh san pham/" + txttenhh.Text + "/1.png";
                Image2.ImageUrl = "/img/SP/anh san pham/" + txttenhh.Text + "/2.png";
                Image3.ImageUrl = "/img/SP/anh san pham/" + txttenhh.Text + "/3.png";
            }
        }
        bool CheckFileType(string fileName)
        {

            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".png":
                    return true;
                default:
                    return false;
            }
        }
        protected void add_sptt(ref int ma)
        {
            connect();
            string sqlnew = "insert into tbl_ttHH(MaHH) values('" + ma + "')";
            command = new SqlCommand(sqlnew, connection);
            command.ExecuteReader();
            command.Cancel();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                App_Start.datadn.maxmasp = App_Start.datadn.maxmasp + 1;
                int maspnew = App_Start.datadn.maxmasp;
                connect();
                string sqlnew = "insert into tbl_HangHoa values('" + maspnew + "','" + txttenhh.Text + "','" + Convert.ToString(lisbox2.SelectedValue) + "','" + txtsoluong.Text + "','01','" + txtslton.Text + "','" + txtgianiemyet.Text + "','" + txtgiaban.Text + "','" + ListBox1.SelectedValue + "')";
                command = new SqlCommand(sqlnew, connection);
                command.ExecuteReader();
                command.Cancel();
                add_sptt(ref maspnew);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('error " + ex + "')</script>");
            }

            FilePath = MapPath("/img/SP/anh san pham/" + txttenhh.Text + "/");
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int a = i + 1;
                    string filename = "/img/SP/anh san pham/" + txttenhh.Text + "/0" + a + ".png";
                    if (Directory.Exists(filename))
                    {
                        Directory.Delete(filename);
                    }
                }
            }

            if (Page.IsValid && FileUpload1.HasFile && CheckFileType(FileUpload1.FileName))
            {
                string img1 = "1.png";
                string img2 = "2.png";
                string img3 = "3.png";
                FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/img/SP/anh san pham/" + txttenhh.Text + "/" + img1);
                FileUpload2.SaveAs(Request.PhysicalApplicationPath + "/img/SP/anh san pham/" + txttenhh.Text + "/" + img2);
                FileUpload3.SaveAs(Request.PhysicalApplicationPath + "/img/SP/anh san pham/" + txttenhh.Text + "/" + img3);
                Image1.ImageUrl = "/img/SP/anh san pham/" + txttenhh.Text + "/1.png";
                Image2.ImageUrl = "/img/SP/anh san pham/" + txttenhh.Text + "/2.png";
                Image3.ImageUrl = "/img/SP/anh san pham/" + txttenhh.Text + "/3.png";
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string uc = "";
            if (Request.QueryString["uc"] != null)
            {
                uc = Request.QueryString["uc"];
            }
            string suc = "";
            if (Request.QueryString["suc"] != null)
            {
                suc = Request.QueryString["suc"];
            }
            Response.Redirect("admin.aspx?uc="+uc+"&suc="+suc+"&addc=ncc");
        }


        protected void btncancel_Click(object sender, EventArgs e)
        {
            PlaceHolderload.Controls.Clear();
            btncancel.Visible = false;
            string suc = "";
            if (Request.QueryString["suc"] != null)
            {
                suc = Request.QueryString["suc"];
            }
            switch (suc)
            {
                case "newprd":
                    Response.Redirect("admin.aspx?uc=prd&suc=newprd");
                    break;
                case "upprd":
                    Response.Redirect("admin.aspx?uc=prd&suc=upprd");
                    break;
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string uc = "";
            if (Request.QueryString["uc"] != null)
            {
                uc = Request.QueryString["uc"];
            }
            string suc = "";
            if (Request.QueryString["suc"] != null)
            {
                suc = Request.QueryString["suc"];
            }
            Response.Redirect("admin.aspx?uc=" + uc + "&suc=" + suc + "&addc=lh");
        }
    }
}