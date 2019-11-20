using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailWin
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String sql = String.Format("select * from taikhoan where taikhoan = '{0}' and matkhau = '{1}'", txtTaiKhoan.Text, txtMatKhau.Text);
            DataTable tb = new DataTable();
            tb = liberyWin.XemQuery(sql);

            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu sai", "Thông Báo");
                return;
            }
            liberyWin.MaNguoiDung = int.Parse(tb.Rows[0]["ID"].ToString());
            liberyWin.Quyen = int.Parse(tb.Rows[0]["idquyen"].ToString());
            sql = String.Format(@"SELECT chucnang.tenchucnang, chucnang.mota
                                        FROM chucnang INNER JOIN quyen_chucnang ON chucnang.ID = quyen_chucnang.idchucnang
                                        WHERE (((quyen_chucnang.idquyen)={0}));", tb.Rows[0]["idQuyen"].ToString());
            tb = liberyWin.XemQuery(sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                liberyWin.ChucNangCuaNguoiDung += tb.Rows[i]["TenChucNang"].ToString();
            }
            this.Hide();
            TrangChinh TrangChinh = new TrangChinh();
            TrangChinh.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            liberyWin.Thoat();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
