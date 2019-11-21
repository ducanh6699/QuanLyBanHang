using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailWin
{
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        String MaHD, MaSuaMH_HD, MaMH_HD, MaChonHD;

        private void TaoMaHoaDon()
        {
            String sql = "SELECT Top 1 * FROM hoadon ORDER BY hoadon.ID DESC";
            DataTable tb = new DataTable();
            tb = liberyWin.XemQuery(sql);
            if (tb.Rows.Count > 0)
                MaHD = (int.Parse(tb.Rows[0]["Id"].ToString()) + 1).ToString();
            else
                MaHD = "1";
        }

        private void TaoMaHD_MH()
        {
            String sql = "SELECT Top 1 * FROM mathang_hoadon ORDER BY mathang_hoadon.ID DESC";
            DataTable tb = new DataTable();
            tb = liberyWin.XemQuery(sql);
            if (tb.Rows.Count > 0)
                MaMH_HD = (int.Parse(tb.Rows[0]["Id"].ToString()) + 1).ToString();
            else
                MaMH_HD = "1";
        }

        private void LayHoaDon()
        {
            String sql = @"SELECT * from hoadon";
            DataTable dt = new DataTable();
            dt = liberyWin.XemQuery(sql);

            dgvHoaDon.DataSource = dt;
        }

        private void LayMatHang()
        {
            String sql = "select * from mathang";
            DataTable tb = new DataTable();
            tb = liberyWin.XemQuery(sql);

            cbThemMH.DataSource = tb;
            cbThemMH.DisplayMember = "tenmathang";
            cbThemMH.ValueMember = "ID";
            cbThemMH.SelectedIndexChanged += cbThemMH_SelectedIndexChanged;

            sql = "select * from mathang";
            DataTable dt = new DataTable();
            dt = liberyWin.XemQuery(sql);
            cbSuaMH.DataSource = dt;
            cbSuaMH.DisplayMember = "tenmathang";
            cbSuaMH.ValueMember = "ID";
            cbSuaMH.SelectedIndexChanged += cbSuaMH_SelectedIndexChanged;
        }

        private void cbSuaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = liberyWin.XemQuery(String.Format("select * from mathang where ID = {0}", cbSuaMH.SelectedValue.ToString()));
            txtSuaMV.Text = dt.Rows[0]["mavach"].ToString();
            txtSuaDG.Text = dt.Rows[0]["dongia"].ToString();
        }

        private void cbThemMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = liberyWin.XemQuery(String.Format("select * from mathang where ID = {0}", cbThemMH.SelectedValue.ToString()));
            txtThemMV.Text = dt.Rows[0]["mavach"].ToString();
            txtThemDG.Text = dt.Rows[0]["dongia"].ToString();
        }

        public void HoaDon_Load(object sender, EventArgs e)
        {
            LayHoaDon();
            LayMatHang();
            TaoMaHoaDon();
            TaoMaHD_MH();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            String sql = String.Format("insert into hoadon (ID,tongtien,ngaytao) values({0},'0','{1}')", MaHD, DateTime.Today.ToString());
            liberyWin.ThemSuaXoaQuery(sql);
            MessageBox.Show("Đã thêm thành công!", "Thông báo");
            LayHoaDon();
            TaoMaHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) // bấm nút xóa trên dgv
            {
                if (liberyWin.confirm())
                {
                    liberyWin.ThemSuaXoaQuery("delete from hoadon where ID = " + dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                    MessageBox.Show("Đã xóa thành công!", "Thông báo");
                    LayHoaDon();
                    TaoMaHoaDon();
                }
            }
            else if (e.ColumnIndex == 1 && e.RowIndex != -1) // bấm nút hiển thị trên dgv
            {
                MaChonHD = dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                dgvMatHang_HoaDon.DataSource = liberyWin.XemQuery(String.Format(@"SELECT mathang_hoadon.ID, mathang_hoadon.idmathang, mathang_hoadon.idhoadon, mathang_hoadon.soluongmathang, mathang.mavach, mathang.tenmathang, mathang.dongia
                                            FROM mathang INNER JOIN mathang_hoadon ON mathang.ID = mathang_hoadon.idmathang
                                            WHERE (((mathang_hoadon.idhoadon)={0}));", MaChonHD));
            }
        }

        private void dgvMatHang_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) // bấm nút xóa trên dgv
            {
                if (liberyWin.confirm())
                {
                    DataTable dt = liberyWin.XemQuery("select * from hoadon where ID = " + MaChonHD);
                    liberyWin.ThemSuaXoaQuery(String.Format("update hoadon set tongtien = '{0}' where ID = {1}", int.Parse(dt.Rows[0]["tongtien"].ToString()) - (int.Parse(dgvMatHang_HoaDon.Rows[e.RowIndex].Cells[5].Value.ToString()) * int.Parse(dgvMatHang_HoaDon.Rows[e.RowIndex].Cells[8].Value.ToString())), MaChonHD));
                    liberyWin.ThemSuaXoaQuery("delete from mathang_hoadon where ID = " + dgvMatHang_HoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                    MessageBox.Show("Đã xóa thành công!", "Thông báo");
                    dgvMatHang_HoaDon.DataSource = liberyWin.XemQuery(String.Format(@"SELECT mathang_hoadon.ID, mathang_hoadon.idmathang, mathang_hoadon.idhoadon, mathang_hoadon.soluongmathang, mathang.mavach, mathang.tenmathang, mathang.dongia
                                            FROM mathang INNER JOIN mathang_hoadon ON mathang.ID = mathang_hoadon.idmathang
                                            WHERE (((mathang_hoadon.idhoadon)={0}));", MaChonHD));
                    LayHoaDon();
                    TaoMaHD_MH();
                    tabControl1.SelectedTab = tabPage1;
                }
            }
            else if (e.ColumnIndex == 1 && e.RowIndex != -1) // bấm nút sửa trên dgv
            {
                MaSuaMH_HD = dgvMatHang_HoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbSuaMH.SelectedValue = dgvMatHang_HoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbSuaMH_SelectedIndexChanged(sender, e);
                txtSuaSL.Text = dgvMatHang_HoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();
                dgvMatHang_HoaDon.DataSource = liberyWin.XemQuery(String.Format(@"SELECT mathang_hoadon.ID, mathang_hoadon.idmathang, mathang_hoadon.idhoadon, mathang_hoadon.soluongmathang, mathang.mavach, mathang.tenmathang, mathang.dongia
                                            FROM mathang INNER JOIN mathang_hoadon ON mathang.ID = mathang_hoadon.idmathang
                                            WHERE (((mathang_hoadon.idhoadon)={0}));", MaChonHD));
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = liberyWin.XemQuery("select * from hoadon where ID = " + MaChonHD);
            int tongtien = int.Parse(dt1.Rows[0]["tongtien"].ToString()) + int.Parse(txtThemSL.Text) * int.Parse(txtThemDG.Text);
            liberyWin.ThemSuaXoaQuery(String.Format("insert into mathang_hoadon(ID,idmathang,idhoadon,soluongmathang) values({0},{1},{2},'{3}')", MaMH_HD, cbThemMH.SelectedValue.ToString(), MaChonHD,txtThemSL.Text));
            MessageBox.Show("Đã thêm thành công!", "Thông báo");
            dgvMatHang_HoaDon.DataSource = liberyWin.XemQuery(String.Format(@"SELECT mathang_hoadon.ID, mathang_hoadon.idmathang, mathang_hoadon.idhoadon, mathang_hoadon.soluongmathang, mathang.mavach, mathang.tenmathang, mathang.dongia
                                        FROM mathang INNER JOIN mathang_hoadon ON mathang.ID = mathang_hoadon.idmathang
                                        WHERE (((mathang_hoadon.idhoadon)={0}));", MaChonHD));
            liberyWin.ThemSuaXoaQuery(String.Format("update hoadon set tongtien = '{0}' where ID = {1}", tongtien, MaChonHD));
            LayHoaDon();
            TaoMaHD_MH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (liberyWin.confirm())
            {
                DataTable dt1 = liberyWin.XemQuery("select * from hoadon where ID = " + MaChonHD);
                DataTable dt2 = liberyWin.XemQuery("select * from mathang_hoadon where ID = " + MaSuaMH_HD);
                int SLold = int.Parse(dt2.Rows[0]["soluongmathang"].ToString());
                int SLnew = int.Parse(txtSuaSL.Text);
                int tongtien = int.Parse(dt1.Rows[0]["tongtien"].ToString());
                if (SLnew > SLold) tongtien = tongtien + ((SLnew - SLold) * int.Parse(txtSuaDG.Text));
                else tongtien = tongtien - ((SLold - SLnew) * int.Parse(txtSuaDG.Text));
                liberyWin.ThemSuaXoaQuery(String.Format("update hoadon set tongtien = '{0}' where ID = {1}", tongtien.ToString(), MaChonHD));
                liberyWin.ThemSuaXoaQuery(String.Format("update mathang_hoadon set soluongmathang = '{0}' where ID = {1}", SLnew, MaSuaMH_HD));
                dgvMatHang_HoaDon.DataSource = liberyWin.XemQuery(String.Format(@"SELECT mathang_hoadon.ID, mathang_hoadon.idmathang, mathang_hoadon.idhoadon, mathang_hoadon.soluongmathang, mathang.mavach, mathang.tenmathang, mathang.dongia
                                            FROM mathang INNER JOIN mathang_hoadon ON mathang.ID = mathang_hoadon.idmathang
                                            WHERE (((mathang_hoadon.idhoadon)={0}));", MaChonHD));
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LayHoaDon();
            }
        }
    }
}
