namespace RetailWin
{
    partial class MatHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatHang));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.MaMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dvgXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThemSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThemGMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThemMV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbThemLoaiHang = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtThemTMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSuaSL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSuaGMH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSuaMV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSuaLH = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtSuaTMH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách mặt hàng";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AllowUserToAddRows = false;
            this.dgvMatHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMatHang,
            this.MaLoaiHang,
            this.MaVach,
            this.TenLoaiHang,
            this.TenMatHang,
            this.DonGia,
            this.SoLuongTon,
            this.dgvSua,
            this.dvgXoa});
            this.dgvMatHang.Location = new System.Drawing.Point(3, 45);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.Size = new System.Drawing.Size(965, 212);
            this.dgvMatHang.TabIndex = 2;
            this.dgvMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatHang_CellClick);
            // 
            // MaMatHang
            // 
            this.MaMatHang.DataPropertyName = "ID";
            this.MaMatHang.HeaderText = "MaMatHang";
            this.MaMatHang.Name = "MaMatHang";
            this.MaMatHang.Visible = false;
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.DataPropertyName = "IDloaihang";
            this.MaLoaiHang.HeaderText = "MaLoaiHang";
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Visible = false;
            // 
            // MaVach
            // 
            this.MaVach.DataPropertyName = "mavach";
            this.MaVach.HeaderText = "Mã vạch";
            this.MaVach.Name = "MaVach";
            this.MaVach.ReadOnly = true;
            this.MaVach.Width = 135;
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.DataPropertyName = "tenloaihang";
            this.TenLoaiHang.HeaderText = "Loại hàng";
            this.TenLoaiHang.Name = "TenLoaiHang";
            this.TenLoaiHang.ReadOnly = true;
            this.TenLoaiHang.Width = 130;
            // 
            // TenMatHang
            // 
            this.TenMatHang.DataPropertyName = "tenmathang";
            this.TenMatHang.HeaderText = "Tên mặt hàng";
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.ReadOnly = true;
            this.TenMatHang.Width = 177;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "dongia";
            this.DonGia.HeaderText = "Giá mặt hàng";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 130;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "soluongton";
            this.SoLuongTon.HeaderText = "Số lượng còn lại";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            this.SoLuongTon.Width = 130;
            // 
            // dgvSua
            // 
            this.dgvSua.HeaderText = "Sửa";
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvSua.Text = "Sửa";
            this.dgvSua.UseColumnTextForButtonValue = true;
            // 
            // dvgXoa
            // 
            this.dvgXoa.HeaderText = "Xóa";
            this.dvgXoa.Name = "dvgXoa";
            this.dvgXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dvgXoa.Text = "Xóa";
            this.dvgXoa.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin mặt hàng";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 310);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 260);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtThemSL);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtThemGMH);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtThemMV);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbThemLoaiHang);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.txtThemTMH);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm mặt hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số lượng còn lại";
            // 
            // txtThemSL
            // 
            this.txtThemSL.Enabled = false;
            this.txtThemSL.Location = new System.Drawing.Point(126, 153);
            this.txtThemSL.Name = "txtThemSL";
            this.txtThemSL.Size = new System.Drawing.Size(828, 22);
            this.txtThemSL.TabIndex = 9;
            this.txtThemSL.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá mặt hàng";
            // 
            // txtThemGMH
            // 
            this.txtThemGMH.Location = new System.Drawing.Point(126, 125);
            this.txtThemGMH.Name = "txtThemGMH";
            this.txtThemGMH.Size = new System.Drawing.Size(828, 22);
            this.txtThemGMH.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã vạch";
            // 
            // txtThemMV
            // 
            this.txtThemMV.Location = new System.Drawing.Point(126, 40);
            this.txtThemMV.Name = "txtThemMV";
            this.txtThemMV.Size = new System.Drawing.Size(828, 22);
            this.txtThemMV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên mặt hàng";
            // 
            // cbThemLoaiHang
            // 
            this.cbThemLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThemLoaiHang.FormattingEnabled = true;
            this.cbThemLoaiHang.Location = new System.Drawing.Point(126, 68);
            this.cbThemLoaiHang.Name = "cbThemLoaiHang";
            this.cbThemLoaiHang.Size = new System.Drawing.Size(828, 23);
            this.cbThemLoaiHang.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(879, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThemTMH
            // 
            this.txtThemTMH.Location = new System.Drawing.Point(126, 97);
            this.txtThemTMH.Name = "txtThemTMH";
            this.txtThemTMH.Size = new System.Drawing.Size(828, 22);
            this.txtThemTMH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "loại hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtSuaSL);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtSuaGMH);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtSuaMV);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cbSuaLH);
            this.tabPage2.Controls.Add(this.btnSua);
            this.tabPage2.Controls.Add(this.txtSuaTMH);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa mặt hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Số lượng còn lại";
            // 
            // txtSuaSL
            // 
            this.txtSuaSL.Location = new System.Drawing.Point(126, 153);
            this.txtSuaSL.Name = "txtSuaSL";
            this.txtSuaSL.Size = new System.Drawing.Size(828, 22);
            this.txtSuaSL.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giá mặt hàng";
            // 
            // txtSuaGMH
            // 
            this.txtSuaGMH.Location = new System.Drawing.Point(126, 125);
            this.txtSuaGMH.Name = "txtSuaGMH";
            this.txtSuaGMH.Size = new System.Drawing.Size(828, 22);
            this.txtSuaGMH.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã vạch";
            // 
            // txtSuaMV
            // 
            this.txtSuaMV.Location = new System.Drawing.Point(126, 40);
            this.txtSuaMV.Name = "txtSuaMV";
            this.txtSuaMV.Size = new System.Drawing.Size(828, 22);
            this.txtSuaMV.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tên mặt hàng";
            // 
            // cbSuaLH
            // 
            this.cbSuaLH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuaLH.FormattingEnabled = true;
            this.cbSuaLH.Location = new System.Drawing.Point(126, 68);
            this.cbSuaLH.Name = "cbSuaLH";
            this.cbSuaLH.Size = new System.Drawing.Size(828, 23);
            this.cbSuaLH.TabIndex = 14;
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(879, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSuaTMH
            // 
            this.txtSuaTMH.Location = new System.Drawing.Point(126, 97);
            this.txtSuaTMH.Name = "txtSuaTMH";
            this.txtSuaTMH.Size = new System.Drawing.Size(828, 22);
            this.txtSuaTMH.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "loại hàng";
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MatHang";
            this.Size = new System.Drawing.Size(971, 573);
            this.Load += new System.EventHandler(this.MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThemSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThemGMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThemMV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbThemLoaiHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtThemTMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSuaSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSuaGMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSuaMV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSuaLH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtSuaTMH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewButtonColumn dgvSua;
        private System.Windows.Forms.DataGridViewButtonColumn dvgXoa;

    }
}
