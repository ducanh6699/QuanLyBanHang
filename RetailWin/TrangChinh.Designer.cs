namespace RetailWin
{
    partial class TrangChinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChinh));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpbtnchucnang = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.matHang1 = new RetailWin.MatHang();
            this.nhapHang1 = new RetailWin.NhapHang();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flpbtnchucnang);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.nhapHang1);
            this.splitContainer1.Panel2.Controls.Add(this.matHang1);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 579);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 0;
            // 
            // flpbtnchucnang
            // 
            this.flpbtnchucnang.AutoScroll = true;
            this.flpbtnchucnang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpbtnchucnang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpbtnchucnang.BackgroundImage")));
            this.flpbtnchucnang.Location = new System.Drawing.Point(3, 117);
            this.flpbtnchucnang.Name = "flpbtnchucnang";
            this.flpbtnchucnang.Size = new System.Drawing.Size(200, 459);
            this.flpbtnchucnang.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // matHang1
            // 
            this.matHang1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matHang1.Location = new System.Drawing.Point(3, 3);
            this.matHang1.Name = "matHang1";
            this.matHang1.Size = new System.Drawing.Size(971, 573);
            this.matHang1.TabIndex = 0;
            this.matHang1.Visible = false;
            // 
            // nhapHang1
            // 
            this.nhapHang1.Location = new System.Drawing.Point(6, 3);
            this.nhapHang1.Name = "nhapHang1";
            this.nhapHang1.Size = new System.Drawing.Size(971, 573);
            this.nhapHang1.TabIndex = 1;
            this.nhapHang1.Visible = false;
            // 
            // TrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 579);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.TrangChinh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpbtnchucnang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MatHang matHang1;
        private NhapHang nhapHang1;
    }
}