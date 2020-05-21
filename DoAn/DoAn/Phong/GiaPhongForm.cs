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
    public partial class GiaPhongForm : Form
    {
        public GiaPhongForm()
        {
            InitializeComponent();
        }
        public Action<DataGridView> GetCurrentRowOfDataGridView;
        private void GiaPhongForm_Load(object sender, EventArgs e)
        {
            Phong phong = new Phong();

            dataGridView1.DataSource = phong.LayTableGiaPhong();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataFromTable = sender as DataGridView;
            if (GetCurrentRowOfDataGridView != null)
            {
                GetCurrentRowOfDataGridView(dataFromTable);
                Close();
            }
        }
    }
}
