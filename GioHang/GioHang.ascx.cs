using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Text;
using CheckBox = System.Web.UI.WebControls.CheckBox;

namespace webs_banlaptop.GioHang
{
    public partial class GioHang1 : System.Web.UI.UserControl
    {
        string piclaptop = App_Start.datadn.pic;
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        DataTable dttable;
        protected void Page_Load(object sender, EventArgs e)
        {
            string slsql = "select HH.TenHang,gh.sl,HH.GiaBan,HH.MaHH from GioHang gh join tbl_HangHoa HH on gh.MaHH = HH.MaHH where gh.TenTK='" + App_Start.datadn.user + "'";
            if (App_Start.datadn.user == "")
            {
                load(slsql);
            }
            else
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                command = new SqlCommand(slsql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                dttable = new DataTable();
                dttable.Load(sqlDataReader);
                //loaddta(dttable);
                command.Cancel();
                load(slsql);
                //int count = Convert.ToInt32(dttable.Rows.Count.ToString());
                //decimal thanhtien;
                //for (int i = 0; i < count; i++)
                //{
                //    thanhtien = Convert.ToDecimal(dttable.Rows[i][2].ToString()) * Convert.ToDecimal(dttable.Rows[i][1].ToString());
                //    DataTable dt = new DataTable();
                //    DataRow NewRow = dt.NewRow();
                //    NewRow[2] = dttable.Rows[i][0].ToString();
                //    NewRow[3] = dttable.Rows[i][1].ToString();
                //    NewRow[4] = dttable.Rows[i][2].ToString();
                //    NewRow[5] = "";
                //    dt.Rows.Add(NewRow);
                //    GridView1.DataSource = dt;
                //    GridView1.DataBind();
                //}
            }
        }
        //protected void loaddta(DataTable dt)
        //{
        //    int count = Convert.ToInt32(dt.Rows.Count.ToString());
        //    decimal thanhtien;
        //    for(int i = 0; i < count; i++)
        //    {
        //        thanhtien = Convert.ToDecimal(dt.Rows[i][2].ToString()) * Convert.ToDecimal(dt.Rows[i][1].ToString());
        //        int a = i + 1;
        //        ttsp1.Text += "<tr><td>"+a+"</td>";
        //        ttsp1.Text += "<td><img src='"+ piclaptop + dt.Rows[i][0].ToString() +"/1.png' witch=50px height=50px class='hinhdaidien'></td>";
        //        ttsp1.Text += "<td>"+ dt.Rows[i][0].ToString() + "</td><td class='text-center'>"+ dt.Rows[i][1].ToString() + "</td><td class='text-right'>"+ dt.Rows[i][2].ToString() + "</td><td class='auto-style2'>"+thanhtien+"</td>";
        //        ttsp1.Text += "<td><asp:Button ID='sp1' runat='server' BackColor='#FF5050' BorderStyle='Solid' Font-Size='Large' Text='xóa'/></td>" +
        //            "<td><button class='btn btn-primary btn-sm trash' type='button' title='Xóa' onclick='myFunction(this)'><i class='fas fa-trash-alt'></i></button><button class='btn btn-primary btn-sm edit' type='button' title='Sửa'' id='show-emp' data-toggle='modal' data-target='#ModalUP'><i class='fas fa-edit'></i></button></td>" +
        //            "</tr>";
        //    }
        //}
        private void load(string sql)
        {
            if(App_Start.datadn.user == "")
            {
                decimal tongtien = 0;
                if (datagiohang.dt1.Rows.Count == 0)
                {
                    SANPHAM.thanhtoan.TTthanhtoan.ck = false;
                    lbltongtien.Visible = false;
                    btndat.Visible = false;
                    lbltbao.Text = "<a href='index.aspx' style='font-size:78px;color:red;text-decoration: none'>GIỎ HÀNG TRỐNG</a>";
                }
                else
                {
                    SANPHAM.thanhtoan.TTthanhtoan.ck = true;
                    GridView1.DataSource = datagiohang.dt1;
                    GridView1.DataBind();
                    App_Start.dataindex.dtgh = datagiohang.dt1;
                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {

                        GridView1.Rows[i].Cells[0].Text = "<img src='" + piclaptop +Convert.ToString(GridView1.Rows[i].Cells[1].Text) + "/1.png' witch=50px height=50px class='hinhdaidien'>";
                        decimal thanhtien = Convert.ToDecimal(Convert.ToDecimal(GridView1.Rows[i].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[i].Cells[3].Text));
                        tongtien += thanhtien;
                        string thanhtienfm = thanhtien.ToString("#,##0 VND");
                        GridView1.Rows[i].Cells[4].Text = Convert.ToString(thanhtienfm);
                    }
                    string tongtienfm = tongtien.ToString("#,##0 VND");
                    lbltongtien.Text += tongtienfm;
                    lbltbao.Text = "<a href='index.aspx' style='font-size:78px;color:black;text-decoration: none'>GIỎ HÀNG</a>";
                }
            }
            else
            {
                connection = new SqlConnection(sqlcon);
                connection.Open();
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                App_Start.dataindex.dtgh.Load(sqlDataReader);
                decimal tongtien = 0;
                if (dt.Rows.Count == 0)
                {
                    SANPHAM.thanhtoan.TTthanhtoan.ck = false;
                    lbltongtien.Visible = false;
                    btndat.Visible = false;
                    lbltbao.Text = "<a href='index.aspx' style='font-size:78px;color:red;text-decoration: none'>GIỎ HÀNG TRỐNG</a>";
                }
                else
                {
                    SANPHAM.thanhtoan.TTthanhtoan.ck = true;
                    GridView1.DataSource = dt;
                    App_Start.dataindex.dtgh = dt;
                    GridView1.DataBind();
                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {

                        GridView1.Rows[i].Cells[0].Text = "<img src='" + piclaptop + dt.Rows[i][0].ToString() + "/1.png' witch=50px height=50px class='hinhdaidien'>";
                        decimal thanhtien = Convert.ToDecimal(Convert.ToDecimal(GridView1.Rows[i].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[i].Cells[3].Text));
                        tongtien += thanhtien;
                        string thanhtienfm = thanhtien.ToString("#,##0 VND");
                        GridView1.Rows[i].Cells[4].Text = Convert.ToString(thanhtienfm);
                    }
                    string tongtienfm = tongtien.ToString("#,##0 VND");
                    lbltongtien.Text += tongtienfm;
                    lbltbao.Text = "<a style='font-size:78px;color:black;text-decoration: none'>GIỎ HÀNG</a>";
                }
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int row = Convert.ToInt32(e.CommandArgument);
                if (App_Start.datadn.user == "")
                {
                    if (e.CommandName == "update")
                    {
                        datagiohang.mahh = datagiohang.dt1.Rows[row][0].ToString();
                        datagiohang.tenhh = datagiohang.dt1.Rows[row][1].ToString();
                        datagiohang.sl = Convert.ToDecimal(GridView1.Rows[row].Cells[2].Text);
                        datagiohang.giaban = Convert.ToDecimal(GridView1.Rows[row].Cells[3].Text);

                        Response.Redirect("soluction.aspx?uc=upgh");
                    }
                    else if (e.CommandName == "delete")
                    {
                        string a = datagiohang.dt1.Rows[row][0].ToString();
                        datagiohang.remove(a);
                        Response.Redirect("soluction.aspx?uc=gh");
                    }
                }
                else
                {
                    if (e.CommandName == "update")
                    {
                        datagiohang.mahh = dttable.Rows[row][3].ToString();
                        datagiohang.sl = Convert.ToDecimal(GridView1.Rows[row].Cells[2].Text);
                        datagiohang.giaban = Convert.ToDecimal(GridView1.Rows[row].Cells[3].Text);
                        datagiohang.tenhh = dttable.Rows[row][0].ToString();
                        Response.Redirect("soluction.aspx?uc=upgh");
                    }
                    else if (e.CommandName == "delete")
                    {
                        connection = new SqlConnection(sqlcon);
                        connection.Open();
                        string sql = "delete from GioHang where MaHH='" + dttable.Rows[row][3].ToString() + "' and TenTK='" + App_Start.datadn.user + "'";
                        command = new SqlCommand(sql, connection);
                        command.ExecuteReader();
                        Response.Redirect("soluction.aspx?uc=gh");
                    }
                }
            }
            catch
            {

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(SANPHAM.thanhtoan.TTthanhtoan.ck == true)
            {
                if (App_Start.datadn.user == "")
                {
                    App_Start.dataindex.checkedbuy = 2;
                    Response.Redirect("soluction.aspx?uc=cusit");
                }
                else
                {
                    Response.Redirect("soluction.aspx?uc=cart");
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(),"alertMessage", "alert('Vui Lòng Thêm Hàng Vào Giỏ !')", true);
            }
        }

        protected void chktem_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            StringBuilder bl = new StringBuilder();
            decimal tongtien = 0;
            foreach(GridViewRow row in GridView1.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chktem");
                if(chk != null && chk.Checked)
                {
                    int row1 = Convert.ToInt32(GridView1.Rows);
                    tongtien += Convert.ToDecimal(GridView1.Rows[row1].Cells[2].Text) * Convert.ToDecimal(GridView1.Rows[row1].Cells[3].Text);
                }
            }
            string tongtientt = tongtien.ToString("#,##0 VND");
            lbltongtien.Text = "Tổng tiền: " + tongtientt;
        }
    }
}