namespace DoAn
{
    partial class BangPhanCong
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doAnCuoiKiDataSet1 = new DoAn.DoAnCuoiKiDataSet1();
            this.bangPhanCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangPhanCongTableAdapter = new DoAn.DoAnCuoiKiDataSet1TableAdapters.BangPhanCongTableAdapter();
            this.printButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuHaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuBaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuSauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuBayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuNhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qlButton = new System.Windows.Forms.RadioButton();
            this.ttButton = new System.Windows.Forms.RadioButton();
            this.lcButton = new System.Windows.Forms.RadioButton();
            this.cvallButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangPhanCongBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.thuHaiDataGridViewTextBoxColumn,
            this.thuBaDataGridViewTextBoxColumn,
            this.thuTuDataGridViewTextBoxColumn,
            this.thuNamDataGridViewTextBoxColumn,
            this.thuSauDataGridViewTextBoxColumn,
            this.thuBayDataGridViewTextBoxColumn,
            this.chuNhatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bangPhanCongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // doAnCuoiKiDataSet1
            // 
            this.doAnCuoiKiDataSet1.DataSetName = "DoAnCuoiKiDataSet1";
            this.doAnCuoiKiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangPhanCongBindingSource
            // 
            this.bangPhanCongBindingSource.DataMember = "BangPhanCong";
            this.bangPhanCongBindingSource.DataSource = this.doAnCuoiKiDataSet1;
            // 
            // bangPhanCongTableAdapter
            // 
            this.bangPhanCongTableAdapter.ClearBeforeFill = true;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Gainsboro;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printButton.Location = new System.Drawing.Point(12, 482);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(164, 43);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.checkButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 113);
            this.panel1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Ma NV";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Ho Ten";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chuc Vu";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // thuHaiDataGridViewTextBoxColumn
            // 
            this.thuHaiDataGridViewTextBoxColumn.DataPropertyName = "ThuHai";
            this.thuHaiDataGridViewTextBoxColumn.HeaderText = "Thu Hai";
            this.thuHaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuHaiDataGridViewTextBoxColumn.Name = "thuHaiDataGridViewTextBoxColumn";
            this.thuHaiDataGridViewTextBoxColumn.Width = 60;
            // 
            // thuBaDataGridViewTextBoxColumn
            // 
            this.thuBaDataGridViewTextBoxColumn.DataPropertyName = "ThuBa";
            this.thuBaDataGridViewTextBoxColumn.HeaderText = "Thu Ba";
            this.thuBaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuBaDataGridViewTextBoxColumn.Name = "thuBaDataGridViewTextBoxColumn";
            this.thuBaDataGridViewTextBoxColumn.Width = 60;
            // 
            // thuTuDataGridViewTextBoxColumn
            // 
            this.thuTuDataGridViewTextBoxColumn.DataPropertyName = "ThuTu";
            this.thuTuDataGridViewTextBoxColumn.HeaderText = "Thu Tu";
            this.thuTuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuTuDataGridViewTextBoxColumn.Name = "thuTuDataGridViewTextBoxColumn";
            this.thuTuDataGridViewTextBoxColumn.Width = 60;
            // 
            // thuNamDataGridViewTextBoxColumn
            // 
            this.thuNamDataGridViewTextBoxColumn.DataPropertyName = "ThuNam";
            this.thuNamDataGridViewTextBoxColumn.HeaderText = "Thu Nam";
            this.thuNamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuNamDataGridViewTextBoxColumn.Name = "thuNamDataGridViewTextBoxColumn";
            this.thuNamDataGridViewTextBoxColumn.Width = 70;
            // 
            // thuSauDataGridViewTextBoxColumn
            // 
            this.thuSauDataGridViewTextBoxColumn.DataPropertyName = "ThuSau";
            this.thuSauDataGridViewTextBoxColumn.HeaderText = "Thu Sau";
            this.thuSauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuSauDataGridViewTextBoxColumn.Name = "thuSauDataGridViewTextBoxColumn";
            this.thuSauDataGridViewTextBoxColumn.Width = 60;
            // 
            // thuBayDataGridViewTextBoxColumn
            // 
            this.thuBayDataGridViewTextBoxColumn.DataPropertyName = "ThuBay";
            this.thuBayDataGridViewTextBoxColumn.HeaderText = "Thu Bay";
            this.thuBayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuBayDataGridViewTextBoxColumn.Name = "thuBayDataGridViewTextBoxColumn";
            this.thuBayDataGridViewTextBoxColumn.Width = 60;
            // 
            // chuNhatDataGridViewTextBoxColumn
            // 
            this.chuNhatDataGridViewTextBoxColumn.DataPropertyName = "ChuNhat";
            this.chuNhatDataGridViewTextBoxColumn.HeaderText = "Chu Nhat";
            this.chuNhatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chuNhatDataGridViewTextBoxColumn.Name = "chuNhatDataGridViewTextBoxColumn";
            this.chuNhatDataGridViewTextBoxColumn.Width = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.cvallButton);
            this.panel2.Controls.Add(this.lcButton);
            this.panel2.Controls.Add(this.ttButton);
            this.panel2.Controls.Add(this.qlButton);
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 76);
            this.panel2.TabIndex = 3;
            // 
            // qlButton
            // 
            this.qlButton.AutoSize = true;
            this.qlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.qlButton.Location = new System.Drawing.Point(3, 24);
            this.qlButton.Name = "qlButton";
            this.qlButton.Size = new System.Drawing.Size(89, 24);
            this.qlButton.TabIndex = 0;
            this.qlButton.TabStop = true;
            this.qlButton.Text = "Quan Li";
            this.qlButton.UseVisualStyleBackColor = true;
            // 
            // ttButton
            // 
            this.ttButton.AutoSize = true;
            this.ttButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttButton.Location = new System.Drawing.Point(98, 24);
            this.ttButton.Name = "ttButton";
            this.ttButton.Size = new System.Drawing.Size(95, 24);
            this.ttButton.TabIndex = 1;
            this.ttButton.TabStop = true;
            this.ttButton.Text = "Tiep Tan";
            this.ttButton.UseVisualStyleBackColor = true;
            // 
            // lcButton
            // 
            this.lcButton.AutoSize = true;
            this.lcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lcButton.Location = new System.Drawing.Point(199, 24);
            this.lcButton.Name = "lcButton";
            this.lcButton.Size = new System.Drawing.Size(102, 24);
            this.lcButton.TabIndex = 2;
            this.lcButton.TabStop = true;
            this.lcButton.Text = "Lao Cong";
            this.lcButton.UseVisualStyleBackColor = true;
            // 
            // cvallButton
            // 
            this.cvallButton.AutoSize = true;
            this.cvallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cvallButton.Location = new System.Drawing.Point(301, 24);
            this.cvallButton.Name = "cvallButton";
            this.cvallButton.Size = new System.Drawing.Size(49, 24);
            this.cvallButton.TabIndex = 4;
            this.cvallButton.TabStop = true;
            this.cvallButton.Text = "All";
            this.cvallButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Goldenrod;
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkButton.Location = new System.Drawing.Point(385, 29);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(132, 47);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(571, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 113);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ca 1: 7h - 15h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(14, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ca 2: 11h - 19h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(14, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ca 3: 20h - 6h";
            // 
            // BangPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(764, 537);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BangPhanCong";
            this.Text = "BangPhanCong";
            this.Load += new System.EventHandler(this.BangPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangPhanCongBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DoAnCuoiKiDataSet1 doAnCuoiKiDataSet1;
        private System.Windows.Forms.BindingSource bangPhanCongBindingSource;
        private DoAnCuoiKiDataSet1TableAdapters.BangPhanCongTableAdapter bangPhanCongTableAdapter;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuHaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuBaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuNamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuSauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuBayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuNhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton cvallButton;
        private System.Windows.Forms.RadioButton lcButton;
        private System.Windows.Forms.RadioButton ttButton;
        private System.Windows.Forms.RadioButton qlButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}