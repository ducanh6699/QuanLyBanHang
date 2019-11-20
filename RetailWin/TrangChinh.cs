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
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();
        }

        private void TrangChinh_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            layChucNang();
        }

        private void layChucNang()
        {
            String sql = "select * from chucnang";
            DataTable dt = liberyWin.XemQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Tag = dt.Rows[i]["tenchucnang"].ToString();
                btn.Text = dt.Rows[i]["mota"].ToString();
                btn.Height = 90;
                btn.Width = 172;
                btn.BackColor = Color.AliceBlue;
                btn.Click += btnflp_Click;
                btn.Enabled = (liberyWin.ChucNangCuaNguoiDung.IndexOf(dt.Rows[i]["tenchucnang"].ToString()) > -1);
                flpbtnchucnang.Controls.Add(btn);
            }
        }

        private void btnflp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Mặt hàng":
                    nhapHang1.Hide();
                    matHang1.Show();
                    break;

                case "Nhập hàng":
                    matHang1.Hide();
                    nhapHang1.Show();
                    break;

                //case "Danh sách phòng":
                //    DSPhong DSPhong = new DSPhong();
                //    DSPhong.ShowDialog();
                //    break;

                //case "Danh sách hóa đơn":
                //    DSHoaDon DSHoaDon = new DSHoaDon();
                //    DSHoaDon.ShowDialog();
                //    break;

                default:
                    MessageBox.Show("Chức năng này đang phát triển", "Thông báo");
                    break;
            }
        }
    }
}
