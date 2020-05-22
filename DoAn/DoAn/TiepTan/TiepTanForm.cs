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

namespace DoAn
{
    public partial class TiepTanForm : Form
    {
        public TiepTanForm()
        {
            InitializeComponent();
        }

        private void tsmenuQuanLiLaoCong_Click(object sender, EventArgs e)
        {
            QuanLiLaoCong quanLiLaoCong = new QuanLiLaoCong();
            quanLiLaoCong.StartPosition = FormStartPosition.CenterScreen;
            quanLiLaoCong.Show();
        }

        private void TiepTanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo,
               MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                
                e.Cancel = true;
            }
            else
            {
                NhanVien nv = new NhanVien();

                nv.CheckOutAndSaveToLog(Globals.ID);
            }
        }

        private void tsmenuQuanLiPhongDaDat_Click(object sender, EventArgs e)
        {
            QuanLiPhongDaDatForm quanLiPhongDaDatForm = new QuanLiPhongDaDatForm();
            quanLiPhongDaDatForm.StartPosition = FormStartPosition.CenterScreen;

            quanLiPhongDaDatForm.Show();
        }

        private void tsmenuQuanLiPhong_Click(object sender, EventArgs e)
        {
            QuanLiPhongForm quanLiPhongForm = new QuanLiPhongForm();
            quanLiPhongForm.StartPosition = FormStartPosition.CenterScreen;

            quanLiPhongForm.Show();
        }

        private void tsmenuTimPhongTrong_Click(object sender, EventArgs e)
        {
            TimPhongTrongForm timPhongTrongForm = new TimPhongTrongForm("TiepTanForm");
            timPhongTrongForm.StartPosition = FormStartPosition.CenterScreen;

            timPhongTrongForm.Show();
        }

        private void tsmenuThongKeTheoNgay_Click(object sender, EventArgs e)
        {
            ThongKeTheoNgay thongKeTheoNgay = new ThongKeTheoNgay();
            thongKeTheoNgay.StartPosition = FormStartPosition.CenterScreen;

            thongKeTheoNgay.Show();
        }
    }
}
