﻿namespace DoAn
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
            this.tsmenuQuanLiPhongDaDat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuanLiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuTimPhongTrong = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmenuQuanLiPhongDaDat,
            this.tsmenuQuanLiPhong,
            this.tsmenuTimPhongTrong});
            this.tsmenuTinhNang.Name = "tsmenuTinhNang";
            this.tsmenuTinhNang.Size = new System.Drawing.Size(72, 20);
            this.tsmenuTinhNang.Text = "Tính năng";
            // 
            // tsmenuQuanLiLaoCong
            // 
            this.tsmenuQuanLiLaoCong.Name = "tsmenuQuanLiLaoCong";
            this.tsmenuQuanLiLaoCong.Size = new System.Drawing.Size(186, 22);
            this.tsmenuQuanLiLaoCong.Text = "Quản lí lao công";
            this.tsmenuQuanLiLaoCong.Click += new System.EventHandler(this.tsmenuQuanLiLaoCong_Click);
            // 
            // tsmenuQuanLiPhongDaDat
            // 
            this.tsmenuQuanLiPhongDaDat.Name = "tsmenuQuanLiPhongDaDat";
            this.tsmenuQuanLiPhongDaDat.Size = new System.Drawing.Size(186, 22);
            this.tsmenuQuanLiPhongDaDat.Text = "Quản lí phòng đã đặt";
            this.tsmenuQuanLiPhongDaDat.Click += new System.EventHandler(this.tsmenuQuanLiPhongDaDat_Click);
            // 
            // tsmenuQuanLiPhong
            // 
            this.tsmenuQuanLiPhong.Name = "tsmenuQuanLiPhong";
            this.tsmenuQuanLiPhong.Size = new System.Drawing.Size(186, 22);
            this.tsmenuQuanLiPhong.Text = "Quản lí phòng";
            this.tsmenuQuanLiPhong.Click += new System.EventHandler(this.tsmenuQuanLiPhong_Click);
            // 
            // tsmenuTimPhongTrong
            // 
            this.tsmenuTimPhongTrong.Name = "tsmenuTimPhongTrong";
            this.tsmenuTimPhongTrong.Size = new System.Drawing.Size(186, 22);
            this.tsmenuTimPhongTrong.Text = "Tìm phòng trống";
            this.tsmenuTimPhongTrong.Click += new System.EventHandler(this.tsmenuTimPhongTrong_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TiepTanForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmenuTinhNang;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuanLiLaoCong;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuanLiPhongDaDat;
        private System.Windows.Forms.ToolStripMenuItem tsmenuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuanLiPhong;
        private System.Windows.Forms.ToolStripMenuItem tsmenuTimPhongTrong;
    }
}