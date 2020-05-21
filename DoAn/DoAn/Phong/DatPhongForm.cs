using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class DatPhongForm : Form
    {
        public DatPhongForm(string soPhong, string loaiPhong, string ngayDat, string ngayTra)
        {
            InitializeComponent();

            txbSoPhong.Text = soPhong;
            txbLoaiPhong.Text = loaiPhong;
            dtpNgayDat.Text = ngayDat;
            dtpNgayTra.Text = ngayTra;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();

            string ten = txbTenNguoiDat.Text;
            int soPhong = Convert.ToInt32(txbSoPhong.Text);
            string sdt = txbSDT.Text;
            string ngayDat = dtpNgayDat.Text;
            string ngayTra = dtpNgayTra.Text;
            string loaiPhong = txbLoaiPhong.Text;

            if (phong.ThemPhongDatTrongTableDSPhongDaDat(ten, soPhong, sdt, ngayDat, ngayTra, loaiPhong))
            {
                MessageBox.Show("Đã đặt phòng thành công", "Đặt phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể đặt phòng", "Đặt phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
