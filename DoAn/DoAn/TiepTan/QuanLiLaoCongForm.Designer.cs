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
            ((System.ComponentModel.ISupportInitialize)(this.datagvQuanLiLaoCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiLaoCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetQLLC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sach nhan vien dang lam viec";
            // 
            // datagvQuanLiLaoCong
            // 
            this.datagvQuanLiLaoCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagvQuanLiLaoCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvQuanLiLaoCong.Location = new System.Drawing.Point(65, 72);
            this.datagvQuanLiLaoCong.Name = "datagvQuanLiLaoCong";
            this.datagvQuanLiLaoCong.Size = new System.Drawing.Size(459, 318);
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
            this.cbbChooseIDToCheckInOut.Location = new System.Drawing.Point(153, 433);
            this.cbbChooseIDToCheckInOut.Name = "cbbChooseIDToCheckInOut";
            this.cbbChooseIDToCheckInOut.Size = new System.Drawing.Size(57, 21);
            this.cbbChooseIDToCheckInOut.TabIndex = 3;
            this.cbbChooseIDToCheckInOut.SelectedValueChanged += new System.EventHandler(this.cbbChooseIDToCheckInOut_SelectedValueChanged);
            // 
            // lblCheckInOut
            // 
            this.lblCheckInOut.AutoSize = true;
            this.lblCheckInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCheckInOut.Location = new System.Drawing.Point(191, 404);
            this.lblCheckInOut.Name = "lblCheckInOut";
            this.lblCheckInOut.Size = new System.Drawing.Size(192, 24);
            this.lblCheckInOut.TabIndex = 4;
            this.lblCheckInOut.Text = "Check in/Check out";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckIn.Location = new System.Drawing.Point(378, 470);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(88, 44);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Lime;
            this.btnCheckOut.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.Location = new System.Drawing.Point(119, 470);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(91, 44);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // tbHoTenTuongUngIDChoose
            // 
            this.tbHoTenTuongUngIDChoose.Location = new System.Drawing.Point(328, 434);
            this.tbHoTenTuongUngIDChoose.Name = "tbHoTenTuongUngIDChoose";
            this.tbHoTenTuongUngIDChoose.Size = new System.Drawing.Size(196, 20);
            this.tbHoTenTuongUngIDChoose.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID.Location = new System.Drawing.Point(61, 434);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 20);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "Choose ID:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(257, 434);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(65, 20);
            this.lblHoTen.TabIndex = 9;
            this.lblHoTen.Text = "Ho Ten:";
            // 
            // quanLiLaoCongTableAdapter
            // 
            this.quanLiLaoCongTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLiLaoCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(597, 526);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbHoTenTuongUngIDChoose);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lblCheckInOut);
            this.Controls.Add(this.cbbChooseIDToCheckInOut);
            this.Controls.Add(this.datagvQuanLiLaoCong);
            this.Controls.Add(this.label1);
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
        //  private System.Windows.Forms.BindingSource quanLiLaoCongBindingSource1;
        //private DoAnCuoiKiDataSet2TableAdapters.QuanLiLaoCongTableAdapter quanLiLaoCongTableAdapter1;
    }
}