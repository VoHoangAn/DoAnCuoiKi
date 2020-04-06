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
            this.danhSachNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachNhanVienToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoCuoiNgayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioLamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themNhanVienToolStripMenuItem,
            this.danhSachNhanVienToolStripMenuItem,
            this.xoaNhanVienToolStripMenuItem,
            this.danhSachNhanVienToolStripMenuItem1});
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.nhanVienToolStripMenuItem.Text = "Nhan Vien";
            // 
            // themNhanVienToolStripMenuItem
            // 
            this.themNhanVienToolStripMenuItem.Name = "themNhanVienToolStripMenuItem";
            this.themNhanVienToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.themNhanVienToolStripMenuItem.Text = "Them Nhan Vien";
            this.themNhanVienToolStripMenuItem.Click += new System.EventHandler(this.themNhanVienToolStripMenuItem_Click);
            // 
            // danhSachNhanVienToolStripMenuItem
            // 
            this.danhSachNhanVienToolStripMenuItem.Name = "danhSachNhanVienToolStripMenuItem";
            this.danhSachNhanVienToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.danhSachNhanVienToolStripMenuItem.Text = "Sua Nhan Vien";
            // 
            // xoaNhanVienToolStripMenuItem
            // 
            this.xoaNhanVienToolStripMenuItem.Name = "xoaNhanVienToolStripMenuItem";
            this.xoaNhanVienToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.xoaNhanVienToolStripMenuItem.Text = "Xoa Nhan Vien";
            // 
            // danhSachNhanVienToolStripMenuItem1
            // 
            this.danhSachNhanVienToolStripMenuItem1.Name = "danhSachNhanVienToolStripMenuItem1";
            this.danhSachNhanVienToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.danhSachNhanVienToolStripMenuItem1.Text = "Danh Sach Nhan Vien";
            // 
            // tinhLuongToolStripMenuItem
            // 
            this.tinhLuongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoCuoiNgayToolStripMenuItem,
            this.gioLamToolStripMenuItem});
            this.tinhLuongToolStripMenuItem.Name = "tinhLuongToolStripMenuItem";
            this.tinhLuongToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.tinhLuongToolStripMenuItem.Text = "Tinh Luong";
            // 
            // baoCaoCuoiNgayToolStripMenuItem
            // 
            this.baoCaoCuoiNgayToolStripMenuItem.Name = "baoCaoCuoiNgayToolStripMenuItem";
            this.baoCaoCuoiNgayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.baoCaoCuoiNgayToolStripMenuItem.Text = "Bao Cao Cuoi Ngay";
            // 
            // gioLamToolStripMenuItem
            // 
            this.gioLamToolStripMenuItem.Name = "gioLamToolStripMenuItem";
            this.gioLamToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gioLamToolStripMenuItem.Text = "Gio Lam";
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
        private System.Windows.Forms.ToolStripMenuItem danhSachNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachNhanVienToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tinhLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoCuoiNgayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioLamToolStripMenuItem;
    }
}