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
    public partial class SuaVaXoaPhongDaDatForm : Form
    {
        public SuaVaXoaPhongDaDatForm(string soPhong, string tenNguoiDat, string sdt,
            string ngayDat, string ngayTra, string loaiPhong, string id)
        {
            InitializeComponent();

            txbTenNguoiDat.Text = tenNguoiDat;
            txbID.Text = id;
            txbSoPhong.Text = soPhong;
            txbLoaiPhong.Text = loaiPhong;
            txbSDT.Text = sdt;
            dtpNgayDat.Text = ngayDat;
            dtpNgayTra.Text = ngayTra;
        }

        Phong phong = new Phong();

        private void btnSuaPhongDat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaPhongDat_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ID đặt phòng để xóa phòng đặt", "Xóa phòng đặt",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idDatPhong = Convert.ToInt32(txbID.Text);
            if (phong.XoaPhongDatTrongTableDSPhongDaDat(idDatPhong))
            {
                MessageBox.Show("Đã xóa phòng theo ID đặt phòng bạn muốn", "Xóa phòng đặt",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID đặt phòng bạn nhập không tồn tại", "Xóa phòng đặt",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimPhongTrongDeSuaPhongDat_Click(object sender, EventArgs e)
        {
            TimPhongTrongForm timPhongTrongForm = new TimPhongTrongForm("SuaVaXoaPhongDaDatForm");
            timPhongTrongForm.GetCurrentRowFromDataGridView = new Action<string, string, string, string>(PassData);

            timPhongTrongForm.StartPosition = FormStartPosition.CenterScreen;

            timPhongTrongForm.Show();
        }
        private void PassData(string soPhong, string loaiPhong, string ngayDat, string ngayTra)
        {
            txbSoPhong.Text = soPhong;
            txbLoaiPhong.Text = loaiPhong;
            dtpNgayDat.Text = ngayDat;
            dtpNgayTra.Text = ngayTra;
        }
    }
}
