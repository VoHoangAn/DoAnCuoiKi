namespace DoAn
{
    partial class QuanLiPhongForm
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
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnAddPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnDSPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSoPhong = new System.Windows.Forms.TextBox();
            this.pibHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnTaiAnhLen = new System.Windows.Forms.Button();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.Red;
            this.btnXoaPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPhong.Location = new System.Drawing.Point(25, 277);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(86, 52);
            this.btnXoaPhong.TabIndex = 0;
            this.btnXoaPhong.Text = "Xóa phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnAddPhong
            // 
            this.btnAddPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPhong.Location = new System.Drawing.Point(153, 277);
            this.btnAddPhong.Name = "btnAddPhong";
            this.btnAddPhong.Size = new System.Drawing.Size(86, 52);
            this.btnAddPhong.TabIndex = 1;
            this.btnAddPhong.Text = "Thêm phòng";
            this.btnAddPhong.UseVisualStyleBackColor = false;
            this.btnAddPhong.Click += new System.EventHandler(this.btnAddPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.Color.Lime;
            this.btnSuaPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaPhong.Location = new System.Drawing.Point(278, 277);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(86, 52);
            this.btnSuaPhong.TabIndex = 2;
            this.btnSuaPhong.Text = "Sửa phòng";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnDSPhong
            // 
            this.btnDSPhong.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDSPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDSPhong.Location = new System.Drawing.Point(253, 20);
            this.btnDSPhong.Name = "btnDSPhong";
            this.btnDSPhong.Size = new System.Drawing.Size(111, 71);
            this.btnDSPhong.TabIndex = 3;
            this.btnDSPhong.Text = "Danh sách phòng";
            this.btnDSPhong.UseVisualStyleBackColor = false;
            this.btnDSPhong.Click += new System.EventHandler(this.btnDSPhong_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hình ảnh:";
            // 
            // txbSoPhong
            // 
            this.txbSoPhong.Location = new System.Drawing.Point(119, 23);
            this.txbSoPhong.Name = "txbSoPhong";
            this.txbSoPhong.Size = new System.Drawing.Size(65, 20);
            this.txbSoPhong.TabIndex = 8;
            // 
            // pibHinhAnh
            // 
            this.pibHinhAnh.BackColor = System.Drawing.Color.Yellow;
            this.pibHinhAnh.Location = new System.Drawing.Point(119, 120);
            this.pibHinhAnh.Name = "pibHinhAnh";
            this.pibHinhAnh.Size = new System.Drawing.Size(245, 102);
            this.pibHinhAnh.TabIndex = 10;
            this.pibHinhAnh.TabStop = false;
            // 
            // btnTaiAnhLen
            // 
            this.btnTaiAnhLen.Location = new System.Drawing.Point(153, 228);
            this.btnTaiAnhLen.Name = "btnTaiAnhLen";
            this.btnTaiAnhLen.Size = new System.Drawing.Size(165, 23);
            this.btnTaiAnhLen.TabIndex = 11;
            this.btnTaiAnhLen.Text = "Tải ảnh lên";
            this.btnTaiAnhLen.UseVisualStyleBackColor = true;
            this.btnTaiAnhLen.Click += new System.EventHandler(this.btnTaiAnhLen_Click);
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(118, 75);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiPhong.TabIndex = 12;
            this.cbbLoaiPhong.SelectedValueChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedValueChanged);
            // 
            // QuanLiPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(391, 352);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.btnTaiAnhLen);
            this.Controls.Add(this.pibHinhAnh);
            this.Controls.Add(this.txbSoPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDSPhong);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnAddPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Name = "QuanLiPhongForm";
            this.Text = "Quản lí phòng";
            this.Load += new System.EventHandler(this.QuanLiPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnAddPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnDSPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSoPhong;
        private System.Windows.Forms.PictureBox pibHinhAnh;
        private System.Windows.Forms.Button btnTaiAnhLen;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
    }
}