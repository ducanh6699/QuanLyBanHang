using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class Thongke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tendangnhap"] == null)
            {
                Response.Redirect("index.aspx");
            }
            float ngay;
            float thang;
            String now = DateTime.Today.ToString("MM/dd/yyyy");
            String sql = String.Format(@"SELECT Sum(hoadon.tongtien) AS SumOftongtien, hoadon.ngaytao
                            FROM hoadon
                            WHERE hoadon.ngaytao = #{0}#
                            GROUP BY hoadon.ngaytao;",now);
            DataTable tb = libraryweb.laydulieu(sql);
            if (tb.Rows.Count == 0)
            {
                labelngay.Text = "0";
                ngay = 0;
            }
            else
            {
                labelngay.Text = tb.Rows[0]["SumOftongtien"].ToString();
                ngay = float.Parse(labelngay.Text);
            }
            String nhaydup = "\",\"";
            sql = @"SELECT Sum(hoadon.tongtien) AS SumOftongtien, Format([ngaytao],'mm" + nhaydup + @"yyyy') AS Expr1
                            FROM hoadon
                            WHERE Format([ngaytao], 'mm" + nhaydup + @"yyyy') = Format(NOW(), 'mm" + nhaydup + @"yyyy')
                            GROUP BY Format([ngaytao],'mm" + nhaydup + "yyyy');";
            tb = libraryweb.laydulieu(sql);
            if (tb.Rows.Count == 0)
            {
                labelngay.Text = "0";
                thang = 0;
            }
            else
            {
                label1thang.Text = tb.Rows[0]["SumOftongtien"].ToString();
                thang = float.Parse(label1thang.Text);
            }

            labelchitieungay.Text = (ngay / 1000000 * 100).ToString()+"%";
            labelchitieuthang.Text = (thang / 30000000 * 100).ToString() + "%";

            sql = @"SELECT TOP 10 Sum(hoadon.tongtien) AS SumOftongtien, hoadon.ngaytao
                    FROM hoadon
                    GROUP BY hoadon.ngaytao
                    ORDER BY hoadon.ngaytao DESC;";
            tb = libraryweb.laydulieu(sql);
            Chartthunhap.DataSource = tb;
            Chartthunhap.DataBind();

            sql = "Select top 10 tenmathang, soluongton from mathang ORDER BY ABS(soluongton) ASC";
            tb = libraryweb.laydulieu(sql);
            hangsaphet.DataSource = tb;
            hangsaphet.DataBind();
        }
    }
}