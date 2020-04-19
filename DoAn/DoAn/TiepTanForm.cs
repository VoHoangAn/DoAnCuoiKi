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
    public partial class TiepTanForm : Form
    {
        public TiepTanForm()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d2 = DateTime.Now;
            MessageBox.Show(d2.ToShortTimeString(), "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nv.UpdateLog(Globals.ID, d2);
            MessageBox.Show(Globals.LuongNgay.ToString(), "Luong Ngay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
