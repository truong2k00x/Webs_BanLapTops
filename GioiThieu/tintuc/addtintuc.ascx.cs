using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webs_banlaptop.GioiThieu.tintuc
{
    public partial class addtintuc : System.Web.UI.UserControl
    {
        string FilePath = "~/img/tintuc/";
        //string FilePath = "";
        //datasp da = new datasp();
        string sqlcon = App_Start.datadn.sql;
        SqlConnection connection;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            string rfl = tt_tintuc.img;
            Image1.ImageUrl = "~/"+rfl;
            txtmatt.Text = tt_tintuc.matt;
            txtndheader.Text = tt_tintuc.header;
            txtND.Text = tt_tintuc.nd;
        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            connect();
            string sql = "delete TinTuc where Matt='" + txtmatt.Text + "'";
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
        }
        private void connect()
        {
            connection = new SqlConnection(sqlcon);
            connection.Open();
        }
        private void newsave(string sql)
        {
            connect();
            command = new SqlCommand(sql, connection);
            command.ExecuteReader();
            command.Cancel();
            Response.Write("<script>alert('Thành Công')</script>");
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
        protected void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = FilePath + txtmatt.Text + ".png";
                //if (!Directory.Exists(FilePath))
                //{
                //    Directory.CreateDirectory(FilePath);
                //}
                //if (Directory.Exists(filename))
                //{
                //    Directory.Delete(filename);
                //}
                if (Page.IsValid && FileUpload1.HasFile && CheckFileType(FileUpload1.FileName))
                {
                    string name = txtmatt.Text;
                    FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/img/tintuc/" + name + ".png");
                    Image1.ImageUrl = FilePath + name + ".png";
                }
                connect();
                DateTime dtime = new DateTime();
                dtime = DateTime.Now;
                string year = Convert.ToString(dtime.Year);
                string month = Convert.ToString(dtime.Month);
                string day = Convert.ToString(dtime.Day);
                string str = Convert.ToString(dtime);
                str = str.Remove(str.Length - 3, 3);
                str = str.Remove(0, 11);
                string heard = txtndheader.Text;
                string nd = txtND.Text;
                heard = heard.Replace("'", "");
                nd = nd.Replace("'", "");
                string sql = "insert into TinTuc values('" + txtmatt.Text + "','img/tintuc/" + txtmatt.Text + ".png',N'" + heard + "',N'" + txtND.Text + "','" + year + "-" + month + "-" + day + " " + str + "')";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                Response.Redirect("admin.aspx?uc=tin");
            }
            catch { }
        }
        string date = "";
        public void sdtime(DateTime dt)
        {
            var stringdt = dt;
            string sstringdt = Convert.ToString(stringdt);
            sstringdt.Replace(" CH", "");
            sstringdt.Replace(" AM", "");
            date = sstringdt;
        }
        protected void btnupdate_Click1(object sender, EventArgs e)
        {
            try
            {
                connect();
                DateTime dtime = new DateTime();
                dtime = DateTime.Now;
                string year = Convert.ToString(dtime.Year);
                string month = Convert.ToString(dtime.Month);
                string day = Convert.ToString(dtime.Day);
                string str = Convert.ToString(dtime);
                str = str.Remove(str.Length - 3, 3);
                str = str.Remove(0, 11);
                string sql = "update TinTuc set img='img/tintuc/" + txtmatt.Text + ".png',header=N'" + txtndheader.Text + "',nd=N'" + txtND.Text + "',ngayadd='" + year + "-" + month + "-" + day + " " + str + "' where Matt='" + txtmatt.Text + "'";
                command = new SqlCommand(sql, connection);
                command.ExecuteReader();
                Response.Redirect("admin.aspx?uc=tin");
            }
            catch
            {

            }
        }
    }
}