namespace DoAn
{
    partial class ThongKeTheoNgay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartThongKeTheoNgay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayThongKe = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeTheoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThongKeTheoNgay
            // 
            this.chartThongKeTheoNgay.CausesValidation = false;
            chartArea1.Name = "ChartArea1";
            this.chartThongKeTheoNgay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKeTheoNgay.Legends.Add(legend1);
            this.chartThongKeTheoNgay.Location = new System.Drawing.Point(12, 12);
            this.chartThongKeTheoNgay.Name = "chartThongKeTheoNgay";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.MarkerStep = 10;
            series1.Name = "Tổng chi";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.MarkerStep = 10;
            series2.Name = "Tổng thu";
            this.chartThongKeTheoNgay.Series.Add(series1);
            this.chartThongKeTheoNgay.Series.Add(series2);
            this.chartThongKeTheoNgay.Size = new System.Drawing.Size(384, 300);
            this.chartThongKeTheoNgay.TabIndex = 0;
            this.chartThongKeTheoNgay.Text = "Thống kê theo ngày";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            this.chartThongKeTheoNgay.Titles.Add(title1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Location = new System.Drawing.Point(295, 332);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(86, 44);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(9, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày cần thống kê:";
            // 
            // dtpNgayThongKe
            // 
            this.dtpNgayThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThongKe.Location = new System.Drawing.Point(148, 339);
            this.dtpNgayThongKe.Name = "dtpNgayThongKe";
            this.dtpNgayThongKe.Size = new System.Drawing.Size(114, 24);
            this.dtpNgayThongKe.TabIndex = 3;
            // 
            // ThongKeTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 401);
            this.Controls.Add(this.dtpNgayThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.chartThongKeTheoNgay);
            this.Name = "ThongKeTheoNgay";
            this.Text = "ThongKeTheoNgay";
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeTheoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeTheoNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayThongKe;
    }
}