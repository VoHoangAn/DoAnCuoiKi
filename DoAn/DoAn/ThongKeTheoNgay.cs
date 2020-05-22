using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn
{
    public partial class ThongKeTheoNgay : Form
    {
        public ThongKeTheoNgay()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //Vẽ line chart thì thêm dòng dưới vô nó sẽ chuyển charttype sang line
            //series.ChartType = SeriesChartType.Line;

            int kiemTraNgayNhap = DateTime.Compare(dtpNgayThongKe.Value, DateTime.Now);
            if (kiemTraNgayNhap > 0)
            {
                MessageBox.Show("Ngày thống kế phải là các ngày đã qua rồi", "Thống kê", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (dtpNgayThongKe.Text == DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("Ngày thống kế phải là các ngày đã qua rồi", "Thống kê", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string ngayThongKe = dtpNgayThongKe.Text;

            NhanVien nhanVien = new NhanVien();
            DataTable dataThongKe = nhanVien.LayTableThongKeTheoNgay(ngayThongKe);

            //Tiêu đề đồ thị
            chartThongKeTheoNgay.Titles[0].Text = "Thống kê ngày " + ngayThongKe;

            //Định dạng cột
            chartThongKeTheoNgay.Series["Tổng thu"].AxisLabel = ngayThongKe;
            chartThongKeTheoNgay.Series["Tổng thu"]["PixelPointWidth"] = "30";

            //Set giá trị cho các cột tổng thu
            chartThongKeTheoNgay.Series["Tổng thu"].XValueMember = "NgayThongKe";
            chartThongKeTheoNgay.Series["Tổng thu"].YValueMembers = "TongThu";

            //Set giá trị cho các cột tổng chi
            chartThongKeTheoNgay.Series["Tổng chi"].XValueMember = "NgayThongKe";
            chartThongKeTheoNgay.Series["Tổng chi"].YValueMembers = "TongChi";
            chartThongKeTheoNgay.Series["Tổng chi"]["PixelPointWidth"] = "30";

            //Load data
            chartThongKeTheoNgay.DataSource = dataThongKe;
            chartThongKeTheoNgay.DataBind();
        }
    }
}
