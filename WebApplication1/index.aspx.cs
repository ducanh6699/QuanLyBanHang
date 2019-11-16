using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = "Select * from MatHang";  
            Repeater1.DataSource = libraryweb.laydulieu(sql);
            Repeater1.DataBind();
            if (Session["tendangnhap"] != null)
            {
                login.Visible = false;
                logout.Visible = true;
                thongke.Visible = true;
            }
        }

        protected void dangnhap_Click(object sender, EventArgs e)
        {
            String sql = "Select * from taikhoan where taikhoan = '" + tendangnhap.Text+"' and matkhau = '"+matkhau.Text+"'";
            if(libraryweb.laydulieu(sql).Rows.Count == 1)
            {
                Session["tendangnhap"] = tendangnhap.Text;
                login.Visible = false;
                logout.Visible = true;
                thongke.Visible = true;
            }
        }
    }
}