namespace DoAn
{
    partial class GiaPhongForm
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
            this.loaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSetGiaPhong = new DoAn.DoAnCuoiKiDataSetGiaPhong();
            this.label1 = new System.Windows.Forms.Label();
            this.giaPhongTableAdapter = new DoAn.DoAnCuoiKiDataSetGiaPhongTableAdapters.GiaPhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetGiaPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loaiPhongDataGridViewTextBoxColumn,
            this.giaPhongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giaPhongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // loaiPhongDataGridViewTextBoxColumn
            // 
            this.loaiPhongDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhong";
            this.loaiPhongDataGridViewTextBoxColumn.HeaderText = "LoaiPhong";
            this.loaiPhongDataGridViewTextBoxColumn.Name = "loaiPhongDataGridViewTextBoxColumn";
            // 
            // giaPhongDataGridViewTextBoxColumn
            // 
            this.giaPhongDataGridViewTextBoxColumn.DataPropertyName = "GiaPhong";
            this.giaPhongDataGridViewTextBoxColumn.HeaderText = "GiaPhong";
            this.giaPhongDataGridViewTextBoxColumn.Name = "giaPhongDataGridViewTextBoxColumn";
            // 
            // giaPhongBindingSource
            // 
            this.giaPhongBindingSource.DataMember = "GiaPhong";
            this.giaPhongBindingSource.DataSource = this.doAnCuoiKiDataSetGiaPhong;
            // 
            // doAnCuoiKiDataSetGiaPhong
            // 
            this.doAnCuoiKiDataSetGiaPhong.DataSetName = "DoAnCuoiKiDataSetGiaPhong";
            this.doAnCuoiKiDataSetGiaPhong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giá các loại phòng";
            // 
            // giaPhongTableAdapter
            // 
            this.giaPhongTableAdapter.ClearBeforeFill = true;
            // 
            // GiaPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GiaPhongForm";
            this.Text = "GiaPhongForm";
            this.Load += new System.EventHandler(this.GiaPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetGiaPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DoAnCuoiKiDataSetGiaPhong doAnCuoiKiDataSetGiaPhong;
        private System.Windows.Forms.BindingSource giaPhongBindingSource;
        private DoAnCuoiKiDataSetGiaPhongTableAdapters.GiaPhongTableAdapter giaPhongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhongDataGridViewTextBoxColumn;
    }
}