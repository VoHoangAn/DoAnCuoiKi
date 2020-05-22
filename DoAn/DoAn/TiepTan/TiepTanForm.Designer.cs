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
            this.tsmenuQuanLiPhongDaDat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuanLiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuTimPhongTrong = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuThongKeThuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuThongKeTheoNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuThongKeTheoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuTinhNang,
            this.tsmenuThongKeThuChi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmenuTinhNang
            // 
            this.tsmenuTinhNang.BackColor = System.Drawing.Color.Fuchsia;
            this.tsmenuTinhNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuQuanLiLaoCong,
            this.tsmenuQuanLiPhongDaDat,
            this.tsmenuQuanLiPhong,
            this.tsmenuTimPhongTrong,
            this.xuấtLươngToolStripMenuItem});
            this.tsmenuTinhNang.Name = "tsmenuTinhNang";
            this.tsmenuTinhNang.Size = new System.Drawing.Size(72, 20);
            this.tsmenuTinhNang.Text = "Tính năng";
            // 
            // tsmenuQuanLiLaoCong
            // 
            this.tsmenuQuanLiLaoCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsmenuQuanLiLaoCong.Name = "tsmenuQuanLiLaoCong";
            this.tsmenuQuanLiLaoCong.Size = new System.Drawing.Size(186, 22);
            this.tsmenuQuanLiLaoCong.Text = "Quản lí lao công";
            this.tsmenuQuanLiLaoCong.Click += new System.EventHandler(this.tsmenuQuanLiLaoCong_Click);
            // 
            // tsmenuQuanLiPhongDaDat
            // 
            this.tsmenuQuanLiPhongDaDat.BackColor = System.Drawing.Color.Lime;
            this.tsmenuQuanLiPhongDaDat.Name = "tsmenuQuanLiPhongDaDat";
            this.tsmenuQuanLiPhongDaDat.Size = new System.Drawing.Size(186, 22);
            this.tsmenuQuanLiPhongDaDat.Text = "Quản lí phòng đã đặt";
            this.tsmenuQuanLiPhongDaDat.Click += new System.EventHandler(this.tsmenuQuanLiPhongDaDat_Click);
            // 
            // tsmenuQuanLiPhong
            // 
            this.tsmenuQuanLiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsmenuQuanLiPhong.Name = "tsmenuQuanLiPhong";
            this.tsmenuQuanLiPhong.Size = new System.Drawing.Size(186, 22);
            this.tsmenuQuanLiPhong.Text = "Quản lí phòng";
            this.tsmenuQuanLiPhong.Click += new System.EventHandler(this.tsmenuQuanLiPhong_Click);
            // 
            // tsmenuTimPhongTrong
            // 
            this.tsmenuTimPhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tsmenuTimPhongTrong.Name = "tsmenuTimPhongTrong";
            this.tsmenuTimPhongTrong.Size = new System.Drawing.Size(186, 22);
            this.tsmenuTimPhongTrong.Text = "Tìm phòng trống";
            this.tsmenuTimPhongTrong.Click += new System.EventHandler(this.tsmenuTimPhongTrong_Click);
            // 
            // xuấtLươngToolStripMenuItem
            // 
            this.xuấtLươngToolStripMenuItem.Name = "xuấtLươngToolStripMenuItem";
            this.xuấtLươngToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.xuấtLươngToolStripMenuItem.Text = "Xuất lương";
//            this.xuấtLươngToolStripMenuItem.Click += new System.EventHandler(this.xuấtLươngToolStripMenuItem_Click);
            // 
            // tsmenuThongKeThuChi
            // 
            this.tsmenuThongKeThuChi.BackColor = System.Drawing.Color.Yellow;
            this.tsmenuThongKeThuChi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuThongKeTheoNgay,
            this.tsmenuThongKeTheoThang});
            this.tsmenuThongKeThuChi.Name = "tsmenuThongKeThuChi";
            this.tsmenuThongKeThuChi.Size = new System.Drawing.Size(108, 20);
            this.tsmenuThongKeThuChi.Text = "Thống kê thu chi";
//            this.tsmenuThongKeThuChi.Click += new System.EventHandler(this.tsmenuDangXuat_Click);
            // 
            // tsmenuThongKeTheoNgay
            // 
            this.tsmenuThongKeTheoNgay.BackColor = System.Drawing.Color.Red;
            this.tsmenuThongKeTheoNgay.Name = "tsmenuThongKeTheoNgay";
            this.tsmenuThongKeTheoNgay.Size = new System.Drawing.Size(184, 22);
            this.tsmenuThongKeTheoNgay.Text = "Thống kê theo ngày";
            this.tsmenuThongKeTheoNgay.Click += new System.EventHandler(this.tsmenuThongKeTheoNgay_Click);
            // 
            // tsmenuThongKeTheoThang
            // 
            this.tsmenuThongKeTheoThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsmenuThongKeTheoThang.Name = "tsmenuThongKeTheoThang";
            this.tsmenuThongKeTheoThang.Size = new System.Drawing.Size(184, 22);
            this.tsmenuThongKeTheoThang.Text = "Thống kê theo tháng";
            // 
            // TiepTanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
        private System.Windows.Forms.ToolStripMenuItem tsmenuThongKeThuChi;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuanLiPhong;
        private System.Windows.Forms.ToolStripMenuItem tsmenuTimPhongTrong;
        private System.Windows.Forms.ToolStripMenuItem xuấtLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmenuThongKeTheoNgay;
        private System.Windows.Forms.ToolStripMenuItem tsmenuThongKeTheoThang;
    }
}