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
    public partial class MatHang : UserControl
    {
        public MatHang()
        {
            InitializeComponent();
        }

        String MaMH, MaSuaMH;

        private void MatHang_Load(object sender, EventArgs e)
        {
            LayMatHang();
            LayLoaiHang();
            TaoMaMatHang();
        }

        private void TaoMaMatHang()
        {
            String sql = "SELECT Top 1 * FROM mathang ORDER BY mathang.ID DESC";
            DataTable tb = new DataTable();
            tb = liberyWin.XemQuery(sql);
            if (tb.Rows.Count > 0)
                MaMH = (int.Parse(tb.Rows[0]["Id"].ToString()) + 1).ToString();
            else
                MaMH = "1";
        }

        private void LayMatHang()
        {
            String sql = @"SELECT mathang.ID, mathang.mavach, mathang.tenmathang, mathang.soluongton, mathang.dongia, loaihang.tenloaihang, mathang.IDloaihang
                            FROM loaihang INNER JOIN mathang ON loaihang.ID = mathang.IDloaihang;";
            DataTable dt = new DataTable();
            dt = liberyWin.XemQuery(sql);

            dgvMatHang.DataSource = dt;
        }

        private void LayLoaiHang()
        {
            String sql = "select * from loaihang";
            DataTable tb = new DataTable();
            tb = liberyWin.XemQuery(sql);

            cbThemLoaiHang.DataSource = tb;
            cbThemLoaiHang.DisplayMember = "tenloaihang";
            cbThemLoaiHang.ValueMember = "ID";

            cbSuaLH.DataSource = tb;
            cbSuaLH.DisplayMember = "tenloaihang";
            cbSuaLH.ValueMember = "ID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (liberyWin.confirm())
            {
                String sql = String.Format("insert into mathang (ID,IDloaihang,mavach,tenmathang,dongia,soluongton) values({0},{1},'{2}','{3}',{4},'{5}')", MaMH, cbThemLoaiHang.SelectedValue.ToString(), txtThemMV.Text, txtThemTMH.Text, txtThemGMH.Text, txtThemSL.Text);
                liberyWin.ThemSuaXoaQuery(sql);
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
                TaoMaMatHang();
                LayMatHang();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) // bấm nút sửa trên dgv
            {
                MaSuaMH = dgvMatHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbSuaLH.SelectedValue = dgvMatHang.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtSuaMV.Text = dgvMatHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSuaTMH.Text = dgvMatHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSuaGMH.Text = dgvMatHang.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtSuaSL.Text = dgvMatHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                tabControl1.SelectedTab = tabPage2;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex != -1) // bấm nút xóa trên dgv
            {
                if (liberyWin.confirm())
                {
                    String sql = String.Format("delete from mathang where ID = {0}", dgvMatHang.Rows[e.RowIndex].Cells[2].Value.ToString());
                    liberyWin.ThemSuaXoaQuery(sql);
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo");
                    TaoMaMatHang();
                    LayMatHang();
                    tabControl1.SelectedTab = tabPage1;
                }
            }
        }
    }
}
