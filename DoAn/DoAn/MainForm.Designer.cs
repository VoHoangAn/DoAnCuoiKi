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
            this.inNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoCuoiNgayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioLamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhatKyHeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soThuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.tinhLuongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themNhanVienToolStripMenuItem,
            this.xoaSuaNhanVien,
            this.QuanLiNhanVien,
            this.inNhanVien});
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.nhanVienToolStripMenuItem.Text = "Quan Li Nhan Vien";
            // 
            // themNhanVienToolStripMenuItem
            // 
            this.themNhanVienToolStripMenuItem.Name = "themNhanVienToolStripMenuItem";
            this.themNhanVienToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.themNhanVienToolStripMenuItem.Text = "Them Nhan Vien";
            this.themNhanVienToolStripMenuItem.Click += new System.EventHandler(this.themNhanVienToolStripMenuItem_Click);
            // 
            // xoaSuaNhanVien
            // 
            this.xoaSuaNhanVien.Name = "xoaSuaNhanVien";
            this.xoaSuaNhanVien.Size = new System.Drawing.Size(250, 26);
            this.xoaSuaNhanVien.Text = "Xoa/Sua Nhan Vien";
            this.xoaSuaNhanVien.Click += new System.EventHandler(this.danhSachNhanVienToolStripMenuItem_Click);
            // 
            // QuanLiNhanVien
            // 
            this.QuanLiNhanVien.Name = "QuanLiNhanVien";
            this.QuanLiNhanVien.Size = new System.Drawing.Size(250, 26);
            this.QuanLiNhanVien.Text = "Quan Li Nhan Vien";
            this.QuanLiNhanVien.Click += new System.EventHandler(this.QuanLiNhanVien_Click);
            // 
            // inNhanVien
            // 
            this.inNhanVien.Name = "inNhanVien";
            this.inNhanVien.Size = new System.Drawing.Size(250, 26);
            this.inNhanVien.Text = "In Danh Sach Nhan Vien";
            // 
            // tinhLuongToolStripMenuItem
            // 
            this.tinhLuongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoCuoiNgayToolStripMenuItem,
            this.gioLamToolStripMenuItem,
            this.nhatKyHeThongToolStripMenuItem,
            this.soThuChiToolStripMenuItem});
            this.tinhLuongToolStripMenuItem.Name = "tinhLuongToolStripMenuItem";
            this.tinhLuongToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.tinhLuongToolStripMenuItem.Text = "Quan Li Ca Lam";
            // 
            // baoCaoCuoiNgayToolStripMenuItem
            // 
            this.baoCaoCuoiNgayToolStripMenuItem.Name = "baoCaoCuoiNgayToolStripMenuItem";
            this.baoCaoCuoiNgayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.baoCaoCuoiNgayToolStripMenuItem.Text = "Bang Phan Cong";
            this.baoCaoCuoiNgayToolStripMenuItem.Click += new System.EventHandler(this.baoCaoCuoiNgayToolStripMenuItem_Click);
            // 
            // gioLamToolStripMenuItem
            // 
            this.gioLamToolStripMenuItem.Name = "gioLamToolStripMenuItem";
            this.gioLamToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gioLamToolStripMenuItem.Text = "Chinh Sua Ca Lam";
            this.gioLamToolStripMenuItem.Click += new System.EventHandler(this.gioLamToolStripMenuItem_Click);
            // 
            // nhatKyHeThongToolStripMenuItem
            // 
            this.nhatKyHeThongToolStripMenuItem.Name = "nhatKyHeThongToolStripMenuItem";
            this.nhatKyHeThongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhatKyHeThongToolStripMenuItem.Text = "Nhat Ky Ca Lam";
            // 
            // soThuChiToolStripMenuItem
            // 
            this.soThuChiToolStripMenuItem.Name = "soThuChiToolStripMenuItem";
            this.soThuChiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.soThuChiToolStripMenuItem.Text = "So Thu/Chi";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaSuaNhanVien;
        private System.Windows.Forms.ToolStripMenuItem QuanLiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem inNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tinhLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoCuoiNgayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioLamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhatKyHeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soThuChiToolStripMenuItem;
    }
}