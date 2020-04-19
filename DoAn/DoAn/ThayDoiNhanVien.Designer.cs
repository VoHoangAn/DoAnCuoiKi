namespace DoAn
{
    partial class ThayDoiNhanVien
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bangPhanCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSet = new DoAn.DoAnCuoiKiDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.thayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bangPhanCongTableAdapter = new DoAn.DoAnCuoiKiDataSetTableAdapters.BangPhanCongTableAdapter();
            this.bangPhanCongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bangPhanCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangPhanCongBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bangPhanCongBindingSource;
            this.comboBox1.DisplayMember = "Ten";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bangPhanCongBindingSource
            // 
            this.bangPhanCongBindingSource.DataMember = "BangPhanCong";
            this.bangPhanCongBindingSource.DataSource = this.doAnCuoiKiDataSetBindingSource;
            // 
            // doAnCuoiKiDataSetBindingSource
            // 
            this.doAnCuoiKiDataSetBindingSource.DataSource = this.doAnCuoiKiDataSet;
            this.doAnCuoiKiDataSetBindingSource.Position = 0;
            // 
            // doAnCuoiKiDataSet
            // 
            this.doAnCuoiKiDataSet.DataSetName = "DoAnCuoiKiDataSet";
            this.doAnCuoiKiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.bangPhanCongBindingSource1;
            this.comboBox2.DisplayMember = "Ten";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(292, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ID";
            // 
            // thayButton
            // 
            this.thayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thayButton.Location = new System.Drawing.Point(419, 9);
            this.thayButton.Name = "thayButton";
            this.thayButton.Size = new System.Drawing.Size(91, 28);
            this.thayButton.TabIndex = 2;
            this.thayButton.Text = "Edit";
            this.thayButton.UseVisualStyleBackColor = true;
            this.thayButton.Click += new System.EventHandler(this.thayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doi nhan vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(256, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "voi";
            // 
            // bangPhanCongTableAdapter
            // 
            this.bangPhanCongTableAdapter.ClearBeforeFill = true;
            // 
            // bangPhanCongBindingSource1
            // 
            this.bangPhanCongBindingSource1.DataMember = "BangPhanCong";
            this.bangPhanCongBindingSource1.DataSource = this.doAnCuoiKiDataSetBindingSource;
            // 
            // ThayDoiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(524, 53);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thayButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "ThayDoiNhanVien";
            this.Text = "ThayDoiNhanVien";
            this.Load += new System.EventHandler(this.ThayDoiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangPhanCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangPhanCongBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button thayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource doAnCuoiKiDataSetBindingSource;
        private DoAnCuoiKiDataSet doAnCuoiKiDataSet;
        private System.Windows.Forms.BindingSource bangPhanCongBindingSource;
        private DoAnCuoiKiDataSetTableAdapters.BangPhanCongTableAdapter bangPhanCongTableAdapter;
        private System.Windows.Forms.BindingSource bangPhanCongBindingSource1;
    }
}