namespace DoAn
{
    partial class QuanLiPhongDaDatForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDSPhongDaDat = new System.Windows.Forms.Button();
            this.btnTimPhongDaDat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenNguoiDat = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbTenNguoiDat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 562);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnDSPhongDaDat
            // 
            this.btnDSPhongDaDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDSPhongDaDat.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDSPhongDaDat.Location = new System.Drawing.Point(542, 27);
            this.btnDSPhongDaDat.Name = "btnDSPhongDaDat";
            this.btnDSPhongDaDat.Size = new System.Drawing.Size(206, 38);
            this.btnDSPhongDaDat.TabIndex = 18;
            this.btnDSPhongDaDat.Text = "Danh sách phòng đã đặt";
            this.btnDSPhongDaDat.UseVisualStyleBackColor = false;
            this.btnDSPhongDaDat.Click += new System.EventHandler(this.btnDSPhongDaDat_Click);
            // 
            // btnTimPhongDaDat
            // 
            this.btnTimPhongDaDat.BackColor = System.Drawing.Color.Lime;
            this.btnTimPhongDaDat.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimPhongDaDat.Location = new System.Drawing.Point(327, 27);
            this.btnTimPhongDaDat.Name = "btnTimPhongDaDat";
            this.btnTimPhongDaDat.Size = new System.Drawing.Size(144, 37);
            this.btnTimPhongDaDat.TabIndex = 17;
            this.btnTimPhongDaDat.Text = "Tìm phòng đã đặt";
            this.btnTimPhongDaDat.UseVisualStyleBackColor = false;
            this.btnTimPhongDaDat.Click += new System.EventHandler(this.btnTimPhongDaDat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số điện thoại:";
            // 
            // lblTenNguoiDat
            // 
            this.lblTenNguoiDat.AutoSize = true;
            this.lblTenNguoiDat.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNguoiDat.Location = new System.Drawing.Point(9, 18);
            this.lblTenNguoiDat.Name = "lblTenNguoiDat";
            this.lblTenNguoiDat.Size = new System.Drawing.Size(103, 18);
            this.lblTenNguoiDat.TabIndex = 15;
            this.lblTenNguoiDat.Text = "Tên người đặt:";
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(118, 55);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(121, 20);
            this.txbSDT.TabIndex = 20;
            // 
            // txbTenNguoiDat
            // 
            this.txbTenNguoiDat.Location = new System.Drawing.Point(118, 18);
            this.txbTenNguoiDat.Name = "txbTenNguoiDat";
            this.txbTenNguoiDat.Size = new System.Drawing.Size(193, 20);
            this.txbTenNguoiDat.TabIndex = 16;
            // 
            // QuanLiPhongDaDatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.txbTenNguoiDat);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.btnDSPhongDaDat);
            this.Controls.Add(this.lblTenNguoiDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimPhongDaDat);
            this.Name = "QuanLiPhongDaDatForm";
            this.Text = "Quản lí phòng đã đặt";
            this.Load += new System.EventHandler(this.QuanLiPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDSPhongDaDat;
        private System.Windows.Forms.Button btnTimPhongDaDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenNguoiDat;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbTenNguoiDat;
    }
}