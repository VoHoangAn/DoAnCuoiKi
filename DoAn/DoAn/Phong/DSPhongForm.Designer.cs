namespace DoAn
{
    partial class DSPhongForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dSPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSetDSPhong = new DoAn.DoAnCuoiKiDataSetDSPhong();
            this.dSPhongTableAdapter = new DoAn.DoAnCuoiKiDataSetDSPhongTableAdapters.DSPhongTableAdapter();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSoPhong = new System.Windows.Forms.TextBox();
            this.rdbSoPhong = new System.Windows.Forms.RadioButton();
            this.rdbLoaiPhong = new System.Windows.Forms.RadioButton();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnXemGiaPhong = new System.Windows.Forms.Button();
            this.btnTaiLaiToanBoPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetDSPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 497);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dSPhongBindingSource
            // 
            this.dSPhongBindingSource.DataMember = "DSPhong";
            this.dSPhongBindingSource.DataSource = this.doAnCuoiKiDataSetDSPhong;
            // 
            // doAnCuoiKiDataSetDSPhong
            // 
            this.doAnCuoiKiDataSetDSPhong.DataSetName = "DoAnCuoiKiDataSetDSPhong";
            this.doAnCuoiKiDataSetDSPhong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSPhongTableAdapter
            // 
            this.dSPhongTableAdapter.ClearBeforeFill = true;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Lime;
            this.btnTim.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(417, 48);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(82, 40);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(128, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm theo:";
            // 
            // txbSoPhong
            // 
            this.txbSoPhong.Location = new System.Drawing.Point(351, 60);
            this.txbSoPhong.Name = "txbSoPhong";
            this.txbSoPhong.Size = new System.Drawing.Size(60, 20);
            this.txbSoPhong.TabIndex = 4;
            // 
            // rdbSoPhong
            // 
            this.rdbSoPhong.AutoSize = true;
            this.rdbSoPhong.Checked = true;
            this.rdbSoPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbSoPhong.Location = new System.Drawing.Point(232, 60);
            this.rdbSoPhong.Name = "rdbSoPhong";
            this.rdbSoPhong.Size = new System.Drawing.Size(78, 19);
            this.rdbSoPhong.TabIndex = 5;
            this.rdbSoPhong.TabStop = true;
            this.rdbSoPhong.Text = "Số phòng";
            this.rdbSoPhong.UseVisualStyleBackColor = true;
            this.rdbSoPhong.CheckedChanged += new System.EventHandler(this.rdbSoPhong_CheckedChanged);
            // 
            // rdbLoaiPhong
            // 
            this.rdbLoaiPhong.AutoSize = true;
            this.rdbLoaiPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbLoaiPhong.Location = new System.Drawing.Point(232, 98);
            this.rdbLoaiPhong.Name = "rdbLoaiPhong";
            this.rdbLoaiPhong.Size = new System.Drawing.Size(87, 19);
            this.rdbLoaiPhong.TabIndex = 6;
            this.rdbLoaiPhong.Text = "Loại phòng";
            this.rdbLoaiPhong.UseVisualStyleBackColor = true;
            this.rdbLoaiPhong.CheckedChanged += new System.EventHandler(this.rdbLoaiPhong_CheckedChanged);
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.Enabled = false;
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(351, 98);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(148, 21);
            this.cbbLoaiPhong.TabIndex = 7;
            // 
            // btnXemGiaPhong
            // 
            this.btnXemGiaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXemGiaPhong.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemGiaPhong.Location = new System.Drawing.Point(542, 50);
            this.btnXemGiaPhong.Name = "btnXemGiaPhong";
            this.btnXemGiaPhong.Size = new System.Drawing.Size(138, 69);
            this.btnXemGiaPhong.TabIndex = 8;
            this.btnXemGiaPhong.Text = "Xem giá phòng";
            this.btnXemGiaPhong.UseVisualStyleBackColor = false;
            this.btnXemGiaPhong.Click += new System.EventHandler(this.btnXemGiaPhong_Click);
            // 
            // btnTaiLaiToanBoPhong
            // 
            this.btnTaiLaiToanBoPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTaiLaiToanBoPhong.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiLaiToanBoPhong.Location = new System.Drawing.Point(319, 125);
            this.btnTaiLaiToanBoPhong.Name = "btnTaiLaiToanBoPhong";
            this.btnTaiLaiToanBoPhong.Size = new System.Drawing.Size(137, 37);
            this.btnTaiLaiToanBoPhong.TabIndex = 9;
            this.btnTaiLaiToanBoPhong.Text = "Tải lại toàn bộ phòng";
            this.btnTaiLaiToanBoPhong.UseVisualStyleBackColor = false;
            this.btnTaiLaiToanBoPhong.Click += new System.EventHandler(this.btnTaiLaiToanBoPhong_Click);
            // 
            // DSPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(764, 678);
            this.Controls.Add(this.btnTaiLaiToanBoPhong);
            this.Controls.Add(this.btnXemGiaPhong);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.rdbLoaiPhong);
            this.Controls.Add(this.rdbSoPhong);
            this.Controls.Add(this.txbSoPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DSPhongForm";
            this.Text = "Danh sách phòng";
            this.Load += new System.EventHandler(this.DSPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetDSPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DoAnCuoiKiDataSetDSPhong doAnCuoiKiDataSetDSPhong;
        private System.Windows.Forms.BindingSource dSPhongBindingSource;
        private DoAnCuoiKiDataSetDSPhongTableAdapters.DSPhongTableAdapter dSPhongTableAdapter;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSoPhong;
        private System.Windows.Forms.RadioButton rdbSoPhong;
        private System.Windows.Forms.RadioButton rdbLoaiPhong;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.Button btnXemGiaPhong;
        private System.Windows.Forms.Button btnTaiLaiToanBoPhong;
    }
}