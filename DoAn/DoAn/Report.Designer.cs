namespace DoAn
{
    partial class Report
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSet2 = new DoAn.DoAnCuoiKiDataSet2();
            this.printButton = new System.Windows.Forms.Button();
            this.doAnCuoiKiDataSet4 = new DoAn.DoAnCuoiKiDataSet4();
            this.doAnCuoiKiDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableAdapter1 = new DoAn.DoAnCuoiKiDataSet2TableAdapters.LogTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bao cao chi tiet ngay:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormatString = "d";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(366, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 39);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.thoiGianLamDataGridViewTextBoxColumn,
            this.themDataGridViewTextBoxColumn,
            this.thieuDataGridViewTextBoxColumn,
            this.luongNgayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 395);
            this.dataGridView1.TabIndex = 2;
            // 
            // logBindingSource1
            // 
            this.logBindingSource1.DataMember = "Log";
            this.logBindingSource1.DataSource = this.doAnCuoiKiDataSet2;
            // 
            // doAnCuoiKiDataSet2
            // 
            this.doAnCuoiKiDataSet2.DataSetName = "DoAnCuoiKiDataSet2";
            this.doAnCuoiKiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printButton.Location = new System.Drawing.Point(42, 518);
            this.printButton.Margin = new System.Windows.Forms.Padding(4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(185, 56);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // doAnCuoiKiDataSet4
            // 
            this.doAnCuoiKiDataSet4.DataSetName = "DoAnCuoiKiDataSet4";
            this.doAnCuoiKiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doAnCuoiKiDataSet4BindingSource
            // 
            this.doAnCuoiKiDataSet4BindingSource.DataSource = this.doAnCuoiKiDataSet4;
            this.doAnCuoiKiDataSet4BindingSource.Position = 0;
            // 
            // logTableAdapter1
            // 
            this.logTableAdapter1.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Ma NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 70;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chuc Vu";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "Checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "Checkin";
            this.checkinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "Checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "Checkout";
            this.checkoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            this.checkoutDataGridViewTextBoxColumn.Width = 81;
            // 
            // thoiGianLamDataGridViewTextBoxColumn
            // 
            this.thoiGianLamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thoiGianLamDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianLam";
            this.thoiGianLamDataGridViewTextBoxColumn.HeaderText = "TongTG";
            this.thoiGianLamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianLamDataGridViewTextBoxColumn.Name = "thoiGianLamDataGridViewTextBoxColumn";
            // 
            // themDataGridViewTextBoxColumn
            // 
            this.themDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.themDataGridViewTextBoxColumn.DataPropertyName = "Them";
            this.themDataGridViewTextBoxColumn.HeaderText = "Them";
            this.themDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.themDataGridViewTextBoxColumn.Name = "themDataGridViewTextBoxColumn";
            // 
            // thieuDataGridViewTextBoxColumn
            // 
            this.thieuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thieuDataGridViewTextBoxColumn.DataPropertyName = "Thieu";
            this.thieuDataGridViewTextBoxColumn.HeaderText = "Thieu";
            this.thieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thieuDataGridViewTextBoxColumn.Name = "thieuDataGridViewTextBoxColumn";
            // 
            // luongNgayDataGridViewTextBoxColumn
            // 
            this.luongNgayDataGridViewTextBoxColumn.DataPropertyName = "LuongNgay";
            this.luongNgayDataGridViewTextBoxColumn.HeaderText = "LuongNgay";
            this.luongNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongNgayDataGridViewTextBoxColumn.Name = "luongNgayDataGridViewTextBoxColumn";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 589);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource logBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.BindingSource doAnCuoiKiDataSet4BindingSource;
        private DoAnCuoiKiDataSet4 doAnCuoiKiDataSet4;
        private DoAnCuoiKiDataSet2 doAnCuoiKiDataSet2;
        private System.Windows.Forms.BindingSource logBindingSource1;
        private DoAnCuoiKiDataSet2TableAdapters.LogTableAdapter logTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongNgayDataGridViewTextBoxColumn;
    }
}