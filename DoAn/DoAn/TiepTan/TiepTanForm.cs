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

        private void tsmenuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon dang xuat?", "Dang xuat", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                NhanVien nv = new NhanVien();

                nv.CheckOutAndSaveLog(Globals.ID);

                Close();
            }
        }
    }
}
