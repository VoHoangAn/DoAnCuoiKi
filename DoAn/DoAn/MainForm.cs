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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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
    }
}
