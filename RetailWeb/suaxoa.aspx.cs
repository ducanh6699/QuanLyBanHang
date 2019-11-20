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
            Page.Form.Attributes.Add("enctype", "multipart/form-data");
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

            if (!IsPostBack)
            {
                tenmathang.Text = tb.Rows[0]["tenmathang"].ToString();
                mavach.Text = tb.Rows[0]["mavach"].ToString();
                loaihang.SelectedValue = tb.Rows[0]["IDloaihang"].ToString();
                soluongton.Text = tb.Rows[0]["soluongton"].ToString();
                dongia.Text = tb.Rows[0]["dongia"].ToString();
                tb = libraryweb.laydulieu("Select ID, tenloaihang from loaihang");
                loaihang.DataSource = tb;
                loaihang.DataTextField = "tenloaihang";
                loaihang.DataValueField = "ID";
                loaihang.DataBind();
            }


        }

        protected void sua_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                string filename = fileUpload.FileName;
                fileUpload.SaveAs(Server.MapPath("~/img/") + filename);
                libraryweb.themsuaxoa("Update mathang set IDloaihang = " + loaihang.SelectedValue.ToString() + ", mavach ='" + mavach.Text + "', tenmathang='" + tenmathang.Text + "', soluongton='" + soluongton.Text + "', dongia ='" + dongia.Text + "', anhminhhoa='" + filename + "' Where id="+ Request.QueryString["id"].ToString());

            }
            else
            {
                libraryweb.themsuaxoa("Update mathang set IDloaihang = " + loaihang.SelectedValue.ToString() + ", mavach ='" + mavach.Text + "', tenmathang='" + tenmathang.Text + "', soluongton='" + soluongton.Text + "', dongia ='" + dongia.Text + "' Where id=" + Request.QueryString["id"].ToString());
            }
        }

        protected void xoa_Click(object sender, EventArgs e)
        {
            libraryweb.themsuaxoa("Delete From mathang Where id=" + Request.QueryString["id"].ToString());
            Response.Redirect("index.aspx");
        }
    }
}