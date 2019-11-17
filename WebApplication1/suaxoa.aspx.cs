using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class suaxoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable tb = null;
            if (Session["tendangnhap"] == null || Request.QueryString["id"] == null || Request.QueryString["id"] == "")
            {
                Response.Redirect("index.aspx");
            }
            try
            {
                tb = libraryweb.laydulieu("Select * from mathang where id =" + Request.QueryString["id"].ToString() + "");
            }
            catch
            {
                Response.Redirect("index.aspx");
            }
            if (tb.Rows.Count == 0)
            {
                Response.Redirect("index.aspx");
            }


            login.Visible = false;
            logout.Visible = true;
            thongke.Visible = true;

            tenmathang.Text = tb.Rows[0]["tenmathang"].ToString();
            mavach.Text = tb.Rows[0]["mavach"].ToString();
            loaihang.SelectedValue = tb.Rows[0]["IDloaihang"].ToString(); 
            soluongton.Text = tb.Rows[0]["soluongton"].ToString();
            dongia.Text = tb.Rows[0]["dongia"].ToString();
            anhminhhoa1.Text = tb.Rows[0]["anhminhhoa"].ToString();

            if (IsPostBack && fileUpload.PostedFile != null)
            {
                if (fileUpload.PostedFile.FileName.Length > 0)
                {
                    anhminhhoa1.Text = "img/"+fileUpload.PostedFile.FileName;
                }
            }

            tb = libraryweb.laydulieu("Select ID, tenloaihang from loaihang");
            loaihang.DataSource = tb;
            loaihang.DataTextField = "tenloaihang";
            loaihang.DataValueField = "ID";
            loaihang.DataBind();
        }

    }
}