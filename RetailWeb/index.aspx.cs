using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dodulieu();

                checkboxloaihang.DataTextField = "tenloaihang";
                checkboxloaihang.DataValueField = "id";
                checkboxloaihang.DataSource = libraryweb.laydulieu("Select * from loaihang");
                checkboxloaihang.DataBind();
            }

            if (Session["tendangnhap"] != null)
            {
                login.Visible = false;
                logout.Visible = true;
                thongke.Visible = true;
            }

        }

        protected void dangnhap_Click(object sender, EventArgs e)
        {
            String sql = "Select * from taikhoan where taikhoan = '" + tendangnhap.Text + "' and matkhau = '" + matkhau.Text + "'";
            if (libraryweb.laydulieu(sql).Rows.Count == 1)
            {
                Session["tendangnhap"] = tendangnhap.Text;
                login.Visible = false;
                logout.Visible = true;
                thongke.Visible = true;
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("<script>alert('Sai tài khoản hoặc mật khẩu')</script>");
            }
        }




        protected void checkboxloaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sql = "Select * from mathang where";
            int first = 0;
            int dem = 0;
            foreach (ListItem i in checkboxloaihang.Items)
            {
                if (i.Selected == true)
                {
                    dem++;
                    if (first == 0)
                    {
                        sql += " IDloaihang =" + i.Value.ToString();
                        first++;
                    }
                    else
                    {
                        sql += " OR IDloaihang =" + i.Value.ToString();
                    }
                }
            }
            if (dem != 0)
            {
                Listview1.DataSource = libraryweb.laydulieu(sql);
                this.DataPager1.SetPageProperties((0) * this.DataPager1.PageSize, this.DataPager1.MaximumRows, false);
                Listview1.DataBind();
            }
            else
            {
                this.DataPager1.SetPageProperties((0) * this.DataPager1.PageSize, this.DataPager1.MaximumRows, false);
                dodulieu();
            }
        }

        public void dodulieu()
        {
            String sql = "Select * from MatHang";
            Listview1.DataSource = libraryweb.laydulieu(sql);
            Listview1.DataBind();
        }

        protected void tim_Click(object sender, EventArgs e)
        {
            if (giatu.Text == "")
            {
                giatu.Text = "0";
            }
            if (giaden.Text == "")
            {
                giaden.Text = "100000";
            }
            Listview1.DataSource = libraryweb.laydulieu("Select * from mathang Where tenmathang like '%" + ten.Text + "%' and dongia >=" + giatu.Text + " and dongia <=" + giaden.Text);
            this.DataPager1.SetPageProperties((0) * this.DataPager1.PageSize, this.DataPager1.MaximumRows, false);
            Listview1.DataBind();
        }

        protected void Listview1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            HtmlGenericControl theDiv = e.Item.FindControl("theDiv") as HtmlGenericControl;
            if (Session["tendangnhap"] == null)
            {
                theDiv.Visible = false;
            }
        }

        protected void Listview1_PagePropertiesChanged(object sender, EventArgs e)
        {
            dodulieu();
        }
    }
}