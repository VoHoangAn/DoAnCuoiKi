namespace DoAn
{
    partial class QuanLiLaoCong
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
            this.datagvQuanLiLaoCong = new System.Windows.Forms.DataGridView();
            this.quanLiLaoCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSetQLLC = new DoAn.DoAnCuoiKiDataSetQLLC();
            this.cbbChooseIDToCheckInOut = new System.Windows.Forms.ComboBox();
            this.lblCheckInOut = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tbHoTenTuongUngIDChoose = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.quanLiLaoCongTableAdapter = new DoAn.DoAnCuoiKiDataSetQLLCTableAdapters.QuanLiLaoCongTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagvQuanLiLaoCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiLaoCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetQLLC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(136, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sach nhan vien dang lam viec";
            // 
            // datagvQuanLiLaoCong
            // 
            this.datagvQuanLiLaoCong.AllowUserToAddRows = false;
            this.datagvQuanLiLaoCong.AllowUserToDeleteRows = false;
            this.datagvQuanLiLaoCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagvQuanLiLaoCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvQuanLiLaoCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoTen,
            this.ThoiGianLamViec});
            this.datagvQuanLiLaoCong.Location = new System.Drawing.Point(87, 89);
            this.datagvQuanLiLaoCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagvQuanLiLaoCong.Name = "datagvQuanLiLaoCong";
            this.datagvQuanLiLaoCong.ReadOnly = true;
            this.datagvQuanLiLaoCong.RowHeadersWidth = 51;
            this.datagvQuanLiLaoCong.Size = new System.Drawing.Size(612, 391);
            this.datagvQuanLiLaoCong.TabIndex = 2;
            this.datagvQuanLiLaoCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvQuanLiLaoCong_CellClick);
            // 
            // quanLiLaoCongBindingSource
            // 
            this.quanLiLaoCongBindingSource.DataMember = "QuanLiLaoCong";
            this.quanLiLaoCongBindingSource.DataSource = this.doAnCuoiKiDataSetQLLC;
            // 
            // doAnCuoiKiDataSetQLLC
            // 
            this.doAnCuoiKiDataSetQLLC.DataSetName = "DoAnCuoiKiDataSetQLLC";
            this.doAnCuoiKiDataSetQLLC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbChooseIDToCheckInOut
            // 
            this.cbbChooseIDToCheckInOut.FormattingEnabled = true;
            this.cbbChooseIDToCheckInOut.Location = new System.Drawing.Point(204, 533);
            this.cbbChooseIDToCheckInOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbChooseIDToCheckInOut.Name = "cbbChooseIDToCheckInOut";
            this.cbbChooseIDToCheckInOut.Size = new System.Drawing.Size(75, 24);
            this.cbbChooseIDToCheckInOut.TabIndex = 3;
            this.cbbChooseIDToCheckInOut.SelectedValueChanged += new System.EventHandler(this.cbbChooseIDToCheckInOut_SelectedValueChanged);
            // 
            // lblCheckInOut
            // 
            this.lblCheckInOut.AutoSize = true;
            this.lblCheckInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCheckInOut.Location = new System.Drawing.Point(255, 497);
            this.lblCheckInOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInOut.Name = "lblCheckInOut";
            this.lblCheckInOut.Size = new System.Drawing.Size(238, 29);
            this.lblCheckInOut.TabIndex = 4;
            this.lblCheckInOut.Text = "Check in/Check out";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(504, 578);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(117, 54);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(159, 578);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(121, 54);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // tbHoTenTuongUngIDChoose
            // 
            this.tbHoTenTuongUngIDChoose.Location = new System.Drawing.Point(437, 534);
            this.tbHoTenTuongUngIDChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHoTenTuongUngIDChoose.Name = "tbHoTenTuongUngIDChoose";
            this.tbHoTenTuongUngIDChoose.Size = new System.Drawing.Size(260, 22);
            this.tbHoTenTuongUngIDChoose.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID.Location = new System.Drawing.Point(81, 534);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 25);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "Choose ID:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(343, 534);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(83, 25);
            this.lblHoTen.TabIndex = 9;
            this.lblHoTen.Text = "Ho Ten:";
            // 
            // quanLiLaoCongTableAdapter
            // 
            this.quanLiLaoCongTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "Ma NV";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Ten NV";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // ThoiGianLamViec
            // 
            this.ThoiGianLamViec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGianLamViec.DataPropertyName = "ThoiGianLamViec";
            this.ThoiGianLamViec.HeaderText = "ThoiGianLamViec";
            this.ThoiGianLamViec.MinimumWidth = 6;
            this.ThoiGianLamViec.Name = "ThoiGianLamViec";
            this.ThoiGianLamViec.ReadOnly = true;
            // 
            // QuanLiLaoCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 647);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbHoTenTuongUngIDChoose);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lblCheckInOut);
            this.Controls.Add(this.cbbChooseIDToCheckInOut);
            this.Controls.Add(this.datagvQuanLiLaoCong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLiLaoCong";
            this.Text = "QuanLiLaoCong";
            this.Load += new System.EventHandler(this.QuanLiLaoCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagvQuanLiLaoCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiLaoCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetQLLC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagvQuanLiLaoCong;
        private System.Windows.Forms.ComboBox cbbChooseIDToCheckInOut;
        private System.Windows.Forms.Label lblCheckInOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianLamViecDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbHoTenTuongUngIDChoose;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblHoTen;
        private DoAnCuoiKiDataSetQLLC doAnCuoiKiDataSetQLLC;
        private System.Windows.Forms.BindingSource quanLiLaoCongBindingSource;
        private DoAnCuoiKiDataSetQLLCTableAdapters.QuanLiLaoCongTableAdapter quanLiLaoCongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianLamViec;
        //  private System.Windows.Forms.BindingSource quanLiLaoCongBindingSource1;
        //private DoAnCuoiKiDataSet2TableAdapters.QuanLiLaoCongTableAdapter quanLiLaoCongTableAdapter1;
    }
}