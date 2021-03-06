﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();

        private void themNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNhanVienForm add = new AddNhanVienForm();
            add.Show();
        }

        private void danhSachNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteNhanVienForm up = new UpdateDeleteNhanVienForm();
            up.Show();
        }

        private void QuanLiNhanVien_Click(object sender, EventArgs e)
        {
            QuanLiNhanVienForm qlnv = new QuanLiNhanVienForm();
            qlnv.Show();
        }

        private void baoCaoCuoiNgayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangPhanCong bpc = new BangPhanCong();
            bpc.Show();
        }

        private void gioLamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCaLam up = new UpdateCaLam();
            up.Show();
        }

        private void nhatKyHeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime d = DateTime.Now;
            nv.UpdateLog(Globals.ID, d);
        }
    }
}
