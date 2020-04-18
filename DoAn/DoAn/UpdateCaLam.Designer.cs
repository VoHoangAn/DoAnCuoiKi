namespace DoAn
{
    partial class UpdateCaLam
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
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.bangChiaCaTamThoiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSet1 = new DoAn.DoAnCuoiKiDataSet1();
            this.bangChiaCaTamThoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnCuoiKiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tenComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.thu2ComboBox = new System.Windows.Forms.ComboBox();
            this.thu3ComboBox = new System.Windows.Forms.ComboBox();
            this.t4ComboBox = new System.Windows.Forms.ComboBox();
            this.t5ComboBox = new System.Windows.Forms.ComboBox();
            this.t6ComboBox = new System.Windows.Forms.ComboBox();
            this.t7ComboBox = new System.Windows.Forms.ComboBox();
            this.cnComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.bangChiaCaTamThoiTableAdapter = new DoAn.DoAnCuoiKiDataSet1TableAdapters.BangChiaCaTamThoiTableAdapter();
            this.upButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bangChiaCaTamThoiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangChiaCaTamThoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idComboBox
            // 
            this.idComboBox.DataSource = this.bangChiaCaTamThoiBindingSource1;
            this.idComboBox.DisplayMember = "ID";
            this.idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(135, 46);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(121, 28);
            this.idComboBox.TabIndex = 0;
            this.idComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // bangChiaCaTamThoiBindingSource1
            // 
            this.bangChiaCaTamThoiBindingSource1.DataMember = "BangChiaCaTamThoi";
            this.bangChiaCaTamThoiBindingSource1.DataSource = this.doAnCuoiKiDataSet1;
            // 
            // doAnCuoiKiDataSet1
            // 
            this.doAnCuoiKiDataSet1.DataSetName = "DoAnCuoiKiDataSet1";
            this.doAnCuoiKiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma Nhan Vien";
            // 
            // tenComboBox
            // 
            this.tenComboBox.DataSource = this.bangChiaCaTamThoiBindingSource1;
            this.tenComboBox.DisplayMember = "Ten";
            this.tenComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenComboBox.FormattingEnabled = true;
            this.tenComboBox.Location = new System.Drawing.Point(135, 104);
            this.tenComboBox.Name = "tenComboBox";
            this.tenComboBox.Size = new System.Drawing.Size(121, 28);
            this.tenComboBox.TabIndex = 2;
            this.tenComboBox.SelectedValueChanged += new System.EventHandler(this.tenComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ten Nhan Vien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thu Hai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(91, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thu Ba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(160, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thu Tu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(223, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thu Nam";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(302, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Thu Sau";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(379, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Thu Bay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(456, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chu nhat";
            // 
            // thu2ComboBox
            // 
            this.thu2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thu2ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thu2ComboBox.FormattingEnabled = true;
            this.thu2ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.thu2ComboBox.Location = new System.Drawing.Point(25, 32);
            this.thu2ComboBox.Name = "thu2ComboBox";
            this.thu2ComboBox.Size = new System.Drawing.Size(55, 28);
            this.thu2ComboBox.TabIndex = 11;
            // 
            // thu3ComboBox
            // 
            this.thu3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thu3ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thu3ComboBox.FormattingEnabled = true;
            this.thu3ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.thu3ComboBox.Location = new System.Drawing.Point(95, 32);
            this.thu3ComboBox.Name = "thu3ComboBox";
            this.thu3ComboBox.Size = new System.Drawing.Size(59, 28);
            this.thu3ComboBox.TabIndex = 12;
            // 
            // t4ComboBox
            // 
            this.t4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t4ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.t4ComboBox.FormattingEnabled = true;
            this.t4ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.t4ComboBox.Location = new System.Drawing.Point(164, 32);
            this.t4ComboBox.Name = "t4ComboBox";
            this.t4ComboBox.Size = new System.Drawing.Size(57, 28);
            this.t4ComboBox.TabIndex = 13;
            // 
            // t5ComboBox
            // 
            this.t5ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t5ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.t5ComboBox.FormattingEnabled = true;
            this.t5ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.t5ComboBox.Location = new System.Drawing.Point(233, 32);
            this.t5ComboBox.Name = "t5ComboBox";
            this.t5ComboBox.Size = new System.Drawing.Size(63, 28);
            this.t5ComboBox.TabIndex = 14;
            // 
            // t6ComboBox
            // 
            this.t6ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t6ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.t6ComboBox.FormattingEnabled = true;
            this.t6ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.t6ComboBox.Location = new System.Drawing.Point(306, 32);
            this.t6ComboBox.Name = "t6ComboBox";
            this.t6ComboBox.Size = new System.Drawing.Size(59, 28);
            this.t6ComboBox.TabIndex = 15;
            // 
            // t7ComboBox
            // 
            this.t7ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t7ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.t7ComboBox.FormattingEnabled = true;
            this.t7ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.t7ComboBox.Location = new System.Drawing.Point(383, 32);
            this.t7ComboBox.Name = "t7ComboBox";
            this.t7ComboBox.Size = new System.Drawing.Size(58, 28);
            this.t7ComboBox.TabIndex = 16;
            // 
            // cnComboBox
            // 
            this.cnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cnComboBox.FormattingEnabled = true;
            this.cnComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cnComboBox.Location = new System.Drawing.Point(460, 32);
            this.cnComboBox.Name = "cnComboBox";
            this.cnComboBox.Size = new System.Drawing.Size(62, 28);
            this.cnComboBox.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.t5ComboBox);
            this.panel1.Controls.Add(this.cnComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.t7ComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.t6ComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.t4ComboBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.thu3ComboBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.thu2ComboBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(301, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 86);
            this.panel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(297, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ca Lam:";
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
            this.dataGridViewTextBoxColumn1,
            this.tenDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.bangChiaCaTamThoiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 221);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ma NV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn2.HeaderText = "ChucVu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ThuHai";
            this.dataGridViewTextBoxColumn3.HeaderText = "ThuHai";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThuBa";
            this.dataGridViewTextBoxColumn4.HeaderText = "ThuBa";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ThuTu";
            this.dataGridViewTextBoxColumn5.HeaderText = "ThuTu";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ThuNam";
            this.dataGridViewTextBoxColumn6.HeaderText = "ThuNam";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ThuSau";
            this.dataGridViewTextBoxColumn7.HeaderText = "ThuSau";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ThuBay";
            this.dataGridViewTextBoxColumn8.HeaderText = "ThuBay";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ChuNhat";
            this.dataGridViewTextBoxColumn9.HeaderText = "ChuNhat";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editButton.Location = new System.Drawing.Point(16, 403);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(165, 58);
            this.editButton.TabIndex = 21;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.refreshButton.Location = new System.Drawing.Point(187, 403);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(165, 58);
            this.refreshButton.TabIndex = 22;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printButton.Location = new System.Drawing.Point(358, 403);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(165, 58);
            this.printButton.TabIndex = 23;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Reset.Location = new System.Drawing.Point(528, 403);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(165, 58);
            this.Reset.TabIndex = 24;
            this.Reset.Text = "Reset Bang";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // bangChiaCaTamThoiTableAdapter
            // 
            this.bangChiaCaTamThoiTableAdapter.ClearBeforeFill = true;
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.upButton.Location = new System.Drawing.Point(705, 403);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(165, 58);
            this.upButton.TabIndex = 25;
            this.upButton.Text = "Up thanh Bang chinh thuc";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // UpdateCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 468);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idComboBox);
            this.Name = "UpdateCaLam";
            this.Text = "UpdateCaLam";
            this.Load += new System.EventHandler(this.UpdateCaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangChiaCaTamThoiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangChiaCaTamThoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnCuoiKiDataSet1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tenComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox thu2ComboBox;
        private System.Windows.Forms.ComboBox thu3ComboBox;
        private System.Windows.Forms.BindingSource doAnCuoiKiDataSet1BindingSource;
        private System.Windows.Forms.ComboBox t4ComboBox;
        private System.Windows.Forms.ComboBox t5ComboBox;
        private System.Windows.Forms.ComboBox t6ComboBox;
        private System.Windows.Forms.ComboBox t7ComboBox;
        private System.Windows.Forms.ComboBox cnComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.BindingSource bangChiaCaTamThoiBindingSource;
        private System.Windows.Forms.Button Reset;
        private DoAnCuoiKiDataSet1 doAnCuoiKiDataSet1;
        private System.Windows.Forms.BindingSource bangChiaCaTamThoiBindingSource1;
        private DoAnCuoiKiDataSet1TableAdapters.BangChiaCaTamThoiTableAdapter bangChiaCaTamThoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button upButton;
    }
}