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

        String MaNH, MaSuaNH;

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

            cbSuaMH.DataSource = tb;
            cbSuaMH.DisplayMember = "tenloaihang";
            cbSuaMH.ValueMember = "ID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            LayNhapHang();
            LayMatHang();
            TaoMaNhapHang();
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
