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
    public partial class NhapHang : UserControl
    {
        public NhapHang()
        {
            InitializeComponent();
        }

        String MaNH, MaSuaNH, SLN;

        private void TaoMaNhapHang()
        {
            String sql = "SELECT Top 1 * FROM nhaphang ORDER BY nhaphang.ID DESC";
            DataTable tb = new DataTable();
            tb = liberyWin.XemQuery(sql);
            if (tb.Rows.Count > 0)
                MaNH = (int.Parse(tb.Rows[0]["Id"].ToString()) + 1).ToString();
            else
                MaNH = "1";
        }

        private void LayNhapHang()
        {
            String sql = @"SELECT nhaphang.ngaynhaphang, nhaphang.soluong, mathang.tenmathang, mathang.mavach, mathang.dongia, nhaphang.ID, mathang.ID
                            FROM mathang INNER JOIN nhaphang ON mathang.ID = nhaphang.IDmathang;";
            DataTable dt = new DataTable();
            dt = liberyWin.XemQuery(sql);

            dgvNhapHang.DataSource = dt;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (liberyWin.confirm())
            {
                String sql = String.Format("insert into nhaphang (ID,IDmathang,soluong,ngaynhaphang) values({0},{1},'{2}','{3}')", MaNH, cbThemMH.SelectedValue.ToString(), txtThemSL.Text, DateTime.Now.ToString());
                liberyWin.ThemSuaXoaQuery(sql);
                DataTable dt = liberyWin.XemQuery("select * from mathang where ID = " + cbThemMH.SelectedValue.ToString());
                liberyWin.ThemSuaXoaQuery(String.Format("update mathang set soluongton = '{0}' where ID = {1}", int.Parse(txtThemSL.Text) + int.Parse(dt.Rows[0]["soluongton"].ToString()), cbThemMH.SelectedValue.ToString()));
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
                TaoMaNhapHang();
                LayNhapHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (liberyWin.confirm())
            {
                String sql = String.Format("update nhaphang set IDmathang = {0}, soluong = '{1}'  where ID = {2}", cbSuaMH.SelectedValue.ToString(), txtSuaSLN.Text, MaSuaNH);
                liberyWin.ThemSuaXoaQuery(sql);
                DataTable dt = liberyWin.XemQuery("select * from mathang where ID = " + cbSuaMH.SelectedValue.ToString());
                int SLNnew = int.Parse(txtSuaSLN.Text);
                if (SLNnew > int.Parse(SLN)) SLNnew = int.Parse(dt.Rows[0]["soluongton"].ToString()) + SLNnew;
                else SLNnew = int.Parse(dt.Rows[0]["soluongton"].ToString()) - (int.Parse(SLN) - SLNnew);
                liberyWin.ThemSuaXoaQuery(String.Format("update mathang set soluongton = '{0}' where ID = {1}", SLNnew, cbSuaMH.SelectedValue.ToString()));
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                LayNhapHang();
            }
        }

        public void NhapHang_Load(object sender, EventArgs e)
        {
            LayNhapHang();
            LayMatHang();
            TaoMaNhapHang();
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) // bấm nút sửa trên dgv
            {
                MaSuaNH = dgvNhapHang.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbSuaMH.SelectedValue = dgvNhapHang.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtSuaMV.Text = dgvNhapHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSuaDG.Text = dgvNhapHang.Rows[e.RowIndex].Cells[6].Value.ToString();
                SLN = txtSuaSLN.Text = dgvNhapHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                tabControl1.SelectedTab = tabPage2;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex != -1) // bấm nút xóa trên dgv
            {
                if (liberyWin.confirm())
                {
                    DataTable dt = liberyWin.XemQuery("select * from mathang where ID = " + dgvNhapHang.Rows[e.RowIndex].Cells[8].Value.ToString());
                    liberyWin.ThemSuaXoaQuery(String.Format("update mathang set soluongton = '{0}' where ID = {1}", int.Parse(dt.Rows[0]["soluongton"].ToString()) - int.Parse(dgvNhapHang.Rows[e.RowIndex].Cells[3].Value.ToString()), dgvNhapHang.Rows[e.RowIndex].Cells[8].Value.ToString()));
                    String sql = String.Format("delete from nhaphang where ID = {0}", dgvNhapHang.Rows[e.RowIndex].Cells[7].Value.ToString());
                    liberyWin.ThemSuaXoaQuery(sql);
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo");
                    TaoMaNhapHang();
                    LayNhapHang();
                    tabControl1.SelectedTab = tabPage1;
                }
            }
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
    }
}
