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
    public partial class LaoCongForm : Form
    {
        public LaoCongForm()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //test form ở program.cs
            //fLaoCong laoCongform = new fLaoCong() { Text = "Hoang An" };
            //laoCongform.StartPosition = FormStartPosition.CenterScreen;
            //Application.Run(laoCongform);

            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = true;
            //dùng để lưu thời gian checkin nếu cần
            string checkInTime = DateTime.Now.ToShortTimeString();
            MessageBox.Show(checkInTime, "Check in time",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            btnCheckIn.Enabled = true;
            btnCheckOut.Enabled = false;
            string checkOutTime = DateTime.Now.ToShortTimeString();
            MessageBox.Show(checkOutTime, "Check out time",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
