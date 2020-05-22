namespace DoAn
{
    partial class SuaGiaPhongForm
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
            this.btnXoaGiaPhong = new System.Windows.Forms.Button();
            this.btnSuaGiaPhong = new System.Windows.Forms.Button();
            this.btnThemGiaPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbGiaPhong = new System.Windows.Forms.TextBox();
            this.btnGiaPhong = new System.Windows.Forms.Button();
            this.txbLoaiPhong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnXoaGiaPhong
            // 
            this.btnXoaGiaPhong.BackColor = System.Drawing.Color.Red;
            this.btnXoaGiaPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaGiaPhong.Location = new System.Drawing.Point(16, 88);
            this.btnXoaGiaPhong.Name = "btnXoaGiaPhong";
            this.btnXoaGiaPhong.Size = new System.Drawing.Size(79, 51);
            this.btnXoaGiaPhong.TabIndex = 0;
            this.btnXoaGiaPhong.Text = "Xóa giá phòng";
            this.btnXoaGiaPhong.UseVisualStyleBackColor = false;
            this.btnXoaGiaPhong.Click += new System.EventHandler(this.btnXoaGiaPhong_Click);
            // 
            // btnSuaGiaPhong
            // 
            this.btnSuaGiaPhong.BackColor = System.Drawing.Color.Magenta;
            this.btnSuaGiaPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaGiaPhong.Location = new System.Drawing.Point(135, 88);
            this.btnSuaGiaPhong.Name = "btnSuaGiaPhong";
            this.btnSuaGiaPhong.Size = new System.Drawing.Size(79, 51);
            this.btnSuaGiaPhong.TabIndex = 1;
            this.btnSuaGiaPhong.Text = "Sửa giá phòng";
            this.btnSuaGiaPhong.UseVisualStyleBackColor = false;
            this.btnSuaGiaPhong.Click += new System.EventHandler(this.btnSuaGiaPhong_Click);
            // 
            // btnThemGiaPhong
            // 
            this.btnThemGiaPhong.BackColor = System.Drawing.Color.Lime;
            this.btnThemGiaPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemGiaPhong.Location = new System.Drawing.Point(257, 88);
            this.btnThemGiaPhong.Name = "btnThemGiaPhong";
            this.btnThemGiaPhong.Size = new System.Drawing.Size(79, 51);
            this.btnThemGiaPhong.TabIndex = 2;
            this.btnThemGiaPhong.Text = "Thêm giá phòng";
            this.btnThemGiaPhong.UseVisualStyleBackColor = false;
            this.btnThemGiaPhong.Click += new System.EventHandler(this.btnThemGiaPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá phòng:";
            // 
            // txbGiaPhong
            // 
            this.txbGiaPhong.Location = new System.Drawing.Point(101, 48);
            this.txbGiaPhong.Name = "txbGiaPhong";
            this.txbGiaPhong.Size = new System.Drawing.Size(121, 20);
            this.txbGiaPhong.TabIndex = 6;
            // 
            // btnGiaPhong
            // 
            this.btnGiaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGiaPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaPhong.Location = new System.Drawing.Point(242, 12);
            this.btnGiaPhong.Name = "btnGiaPhong";
            this.btnGiaPhong.Size = new System.Drawing.Size(94, 47);
            this.btnGiaPhong.TabIndex = 7;
            this.btnGiaPhong.Text = "Giá phòng";
            this.btnGiaPhong.UseVisualStyleBackColor = false;
            this.btnGiaPhong.Click += new System.EventHandler(this.btnGiaPhong_Click);
            // 
            // txbLoaiPhong
            // 
            this.txbLoaiPhong.Location = new System.Drawing.Point(101, 9);
            this.txbLoaiPhong.Name = "txbLoaiPhong";
            this.txbLoaiPhong.Size = new System.Drawing.Size(121, 20);
            this.txbLoaiPhong.TabIndex = 8;
            // 
            // SuaGiaPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(354, 165);
            this.Controls.Add(this.txbLoaiPhong);
            this.Controls.Add(this.btnGiaPhong);
            this.Controls.Add(this.txbGiaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemGiaPhong);
            this.Controls.Add(this.btnSuaGiaPhong);
            this.Controls.Add(this.btnXoaGiaPhong);
            this.Name = "SuaGiaPhongForm";
            this.Text = "Sửa giá phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaGiaPhong;
        private System.Windows.Forms.Button btnSuaGiaPhong;
        private System.Windows.Forms.Button btnThemGiaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbGiaPhong;
        private System.Windows.Forms.Button btnGiaPhong;
        private System.Windows.Forms.TextBox txbLoaiPhong;
    }
}