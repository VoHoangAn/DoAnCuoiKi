namespace DoAn
{
    partial class TiepTanForm
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
            this.tsmenuTinhNang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuanLiLaoCong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuTienThuTienChi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuTinhNang,
            this.tsmenuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmenuTinhNang
            // 
            this.tsmenuTinhNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuQuanLiLaoCong,
            this.tsmenuTienThuTienChi});
            this.tsmenuTinhNang.Name = "tsmenuTinhNang";
            this.tsmenuTinhNang.Size = new System.Drawing.Size(72, 20);
            this.tsmenuTinhNang.Text = "Tính năng";
            // 
            // tsmenuQuanLiLaoCong
            // 
            this.tsmenuQuanLiLaoCong.Name = "tsmenuQuanLiLaoCong";
            this.tsmenuQuanLiLaoCong.Size = new System.Drawing.Size(163, 22);
            this.tsmenuQuanLiLaoCong.Text = "Quản lí lao công";
            this.tsmenuQuanLiLaoCong.Click += new System.EventHandler(this.tsmenuQuanLiLaoCong_Click);
            // 
            // tsmenuTienThuTienChi
            // 
            this.tsmenuTienThuTienChi.Name = "tsmenuTienThuTienChi";
            this.tsmenuTienThuTienChi.Size = new System.Drawing.Size(163, 22);
            this.tsmenuTienThuTienChi.Text = "Tiền thu/Tiền chi";
            // 
            // tsmenuDangXuat
            // 
            this.tsmenuDangXuat.Name = "tsmenuDangXuat";
            this.tsmenuDangXuat.Size = new System.Drawing.Size(74, 20);
            this.tsmenuDangXuat.Text = "Đăng Xuât";
            this.tsmenuDangXuat.Click += new System.EventHandler(this.tsmenuDangXuat_Click);
            // 
            // TiepTanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TiepTanForm";
            this.Text = "TiepTanForm";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TiepTanForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmenuTinhNang;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuanLiLaoCong;
        private System.Windows.Forms.ToolStripMenuItem tsmenuTienThuTienChi;
        private System.Windows.Forms.ToolStripMenuItem tsmenuDangXuat;
    }
}