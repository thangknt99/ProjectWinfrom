namespace PhanMemQLTV
{
    partial class frmGiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDienChinh));
            this.mnuHeThong = new System.Windows.Forms.MenuStrip();
            this.mnutaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudangky = new System.Windows.Forms.ToolStripMenuItem();
            this.mnumatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuquanlydanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuquanlysach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuquanlydocgia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuquanlymuontra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaothongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudx = new System.Windows.Forms.ToolStripMenuItem();
            this.picAnhNen = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mnuHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuHeThong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutaikhoan,
            this.mnuquanlydanhmuc,
            this.mnuquanlymuontra,
            this.mnubaocaothongke,
            this.mnudx});
            this.mnuHeThong.Location = new System.Drawing.Point(-8, 54);
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(538, 24);
            this.mnuHeThong.TabIndex = 0;
            this.mnuHeThong.Text = "menuStrip1";
            // 
            // mnutaikhoan
            // 
            this.mnutaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudangky,
            this.mnumatkhau});
            this.mnutaikhoan.Name = "mnutaikhoan";
            this.mnutaikhoan.Size = new System.Drawing.Size(75, 20);
            this.mnutaikhoan.Text = "Tài Khoản";
            // 
            // mnudangky
            // 
            this.mnudangky.Name = "mnudangky";
            this.mnudangky.Size = new System.Drawing.Size(150, 22);
            this.mnudangky.Text = "Đăng Ký";
            this.mnudangky.Click += new System.EventHandler(this.mnudangky_Click);
            // 
            // mnumatkhau
            // 
            this.mnumatkhau.Name = "mnumatkhau";
            this.mnumatkhau.Size = new System.Drawing.Size(150, 22);
            this.mnumatkhau.Text = "Đổi Mật Khẩu";
            this.mnumatkhau.Click += new System.EventHandler(this.mnudoimatkhau_Click);
            // 
            // mnuquanlydanhmuc
            // 
            this.mnuquanlydanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuquanlysach,
            this.mnuquanlydocgia});
            this.mnuquanlydanhmuc.Name = "mnuquanlydanhmuc";
            this.mnuquanlydanhmuc.Size = new System.Drawing.Size(125, 20);
            this.mnuquanlydanhmuc.Text = "Quản Lý Danh Mục";
            // 
            // mnuquanlysach
            // 
            this.mnuquanlysach.Name = "mnuquanlysach";
            this.mnuquanlysach.Size = new System.Drawing.Size(165, 22);
            this.mnuquanlysach.Text = "Quản Lý Sách";
            this.mnuquanlysach.Click += new System.EventHandler(this.mnuquanlysach_Click);
            // 
            // mnuquanlydocgia
            // 
            this.mnuquanlydocgia.Name = "mnuquanlydocgia";
            this.mnuquanlydocgia.Size = new System.Drawing.Size(165, 22);
            this.mnuquanlydocgia.Text = "Quản Lý Độc Giả";
            this.mnuquanlydocgia.Click += new System.EventHandler(this.mnuquanlydocgia_Click);
            // 
            // mnuquanlymuontra
            // 
            this.mnuquanlymuontra.Name = "mnuquanlymuontra";
            this.mnuquanlymuontra.Size = new System.Drawing.Size(125, 20);
            this.mnuquanlymuontra.Text = "Quản lý Mượn - Trả";
            this.mnuquanlymuontra.Click += new System.EventHandler(this.mnuquanlymuontra_Click);
            // 
            // mnubaocaothongke
            // 
            this.mnubaocaothongke.Name = "mnubaocaothongke";
            this.mnubaocaothongke.Size = new System.Drawing.Size(128, 20);
            this.mnubaocaothongke.Text = "Báo Cáo - Thống Kê";
            this.mnubaocaothongke.Click += new System.EventHandler(this.mnuthongkebaocao_Click);
            // 
            // mnudx
            // 
            this.mnudx.Name = "mnudx";
            this.mnudx.Size = new System.Drawing.Size(77, 20);
            this.mnudx.Text = "Đăng Xuất";
            this.mnudx.Click += new System.EventHandler(this.mnudx_Click);
            // 
            // picAnhNen
            // 
            this.picAnhNen.Image = global::PhanMemQLTV.Properties.Resources.thuvien;
            this.picAnhNen.Location = new System.Drawing.Point(6, 77);
            this.picAnhNen.Name = "picAnhNen";
            this.picAnhNen.Size = new System.Drawing.Size(761, 385);
            this.picAnhNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhNen.TabIndex = 2;
            this.picAnhNen.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.Image = global::PhanMemQLTV.Properties.Resources._1;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(774, 52);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Quản Lý Thư Viện";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 472);
            this.Controls.Add(this.picAnhNen);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.mnuHeThong);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuHeThong;
            this.MaximizeBox = false;
            this.Name = "frmGiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDienChinh_FormClosing);
            this.mnuHeThong.ResumeLayout(false);
            this.mnuHeThong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.MenuStrip mnuHeThong;
        private System.Windows.Forms.PictureBox picAnhNen;
        private System.Windows.Forms.ToolStripMenuItem mnuquanlymuontra;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaothongke;
        private System.Windows.Forms.ToolStripMenuItem mnuquanlydanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuquanlysach;
        private System.Windows.Forms.ToolStripMenuItem mnuquanlydocgia;
        private System.Windows.Forms.ToolStripMenuItem mnutaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mnudangky;
        private System.Windows.Forms.ToolStripMenuItem mnumatkhau;
        private System.Windows.Forms.ToolStripMenuItem mnudx;
    }
}