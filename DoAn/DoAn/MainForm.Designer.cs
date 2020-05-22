namespace DoAn
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaSuaNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoCuoiNgayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioLamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhatKyHeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soThuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsmenuXuatLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Goldenrod;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.tinhLuongToolStripMenuItem,
            this.tsmenuXuatLuong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(580, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themNhanVienToolStripMenuItem,
            this.xoaSuaNhanVien,
            this.QuanLiNhanVien});
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(153, 25);
            this.nhanVienToolStripMenuItem.Text = "Quan Li Nhan Vien";
            // 
            // themNhanVienToolStripMenuItem
            // 
            this.themNhanVienToolStripMenuItem.Name = "themNhanVienToolStripMenuItem";
            this.themNhanVienToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.themNhanVienToolStripMenuItem.Text = "Them Nhan Vien";
            this.themNhanVienToolStripMenuItem.Click += new System.EventHandler(this.themNhanVienToolStripMenuItem_Click);
            // 
            // xoaSuaNhanVien
            // 
            this.xoaSuaNhanVien.Name = "xoaSuaNhanVien";
            this.xoaSuaNhanVien.Size = new System.Drawing.Size(215, 26);
            this.xoaSuaNhanVien.Text = "Xoa/Sua Nhan Vien";
            this.xoaSuaNhanVien.Click += new System.EventHandler(this.danhSachNhanVienToolStripMenuItem_Click);
            // 
            // QuanLiNhanVien
            // 
            this.QuanLiNhanVien.Name = "QuanLiNhanVien";
            this.QuanLiNhanVien.Size = new System.Drawing.Size(215, 26);
            this.QuanLiNhanVien.Text = "Quan Li Nhan Vien";
            this.QuanLiNhanVien.Click += new System.EventHandler(this.QuanLiNhanVien_Click);
            // 
            // tinhLuongToolStripMenuItem
            // 
            this.tinhLuongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoCuoiNgayToolStripMenuItem,
            this.gioLamToolStripMenuItem,
            this.nhatKyHeThongToolStripMenuItem,
            this.soThuChiToolStripMenuItem});
            this.tinhLuongToolStripMenuItem.Name = "tinhLuongToolStripMenuItem";
            this.tinhLuongToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.tinhLuongToolStripMenuItem.Text = "Quan Li Ca Lam";
            // 
            // baoCaoCuoiNgayToolStripMenuItem
            // 
            this.baoCaoCuoiNgayToolStripMenuItem.Name = "baoCaoCuoiNgayToolStripMenuItem";
            this.baoCaoCuoiNgayToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.baoCaoCuoiNgayToolStripMenuItem.Text = "Bang Phan Cong";
            this.baoCaoCuoiNgayToolStripMenuItem.Click += new System.EventHandler(this.baoCaoCuoiNgayToolStripMenuItem_Click);
            // 
            // gioLamToolStripMenuItem
            // 
            this.gioLamToolStripMenuItem.Name = "gioLamToolStripMenuItem";
            this.gioLamToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.gioLamToolStripMenuItem.Text = "Chinh Sua Ca Lam";
            this.gioLamToolStripMenuItem.Click += new System.EventHandler(this.gioLamToolStripMenuItem_Click);
            // 
            // nhatKyHeThongToolStripMenuItem
            // 
            this.nhatKyHeThongToolStripMenuItem.Name = "nhatKyHeThongToolStripMenuItem";
            this.nhatKyHeThongToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.nhatKyHeThongToolStripMenuItem.Text = "Bao Cao Cuoi Ngay";
            this.nhatKyHeThongToolStripMenuItem.Click += new System.EventHandler(this.nhatKyHeThongToolStripMenuItem_Click);
            // 
            // soThuChiToolStripMenuItem
            // 
            this.soThuChiToolStripMenuItem.Name = "soThuChiToolStripMenuItem";
            this.soThuChiToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.soThuChiToolStripMenuItem.Text = "So Thu/Chi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DoAn.Properties.Resources.wc1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsmenuXuatLuong
            // 
            this.tsmenuXuatLuong.Name = "tsmenuXuatLuong";
            this.tsmenuXuatLuong.Size = new System.Drawing.Size(98, 25);
            this.tsmenuXuatLuong.Text = "Xuất lương";
            this.tsmenuXuatLuong.Click += new System.EventHandler(this.tsmenuXuatLuong_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaSuaNhanVien;
        private System.Windows.Forms.ToolStripMenuItem QuanLiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tinhLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoCuoiNgayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioLamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhatKyHeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soThuChiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmenuXuatLuong;
    }
}