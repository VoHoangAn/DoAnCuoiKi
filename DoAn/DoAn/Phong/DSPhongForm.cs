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
    public partial class DSPhongForm : Form
    {
        public DSPhongForm()
        {
            InitializeComponent();
        }

        Phong phong = new Phong();

        private void DSPhongForm_Load(object sender, EventArgs e)
        {
            cbbLoaiPhong.DisplayMember = "LoaiPhong";
            cbbLoaiPhong.ValueMember = "LoaiPhong";
            cbbLoaiPhong.DataSource = phong.LayLoaiPhongTuTableGiaPhong();

            //Load hình đẹp vl
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = phong.LayTableDSPhong();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[2];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void rdbSoPhong_CheckedChanged(object sender, EventArgs e)
        {
            cbbLoaiPhong.Enabled = false;
            txbSoPhong.Enabled = true;
        }

        private void rdbLoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            cbbLoaiPhong.Enabled = true;
            txbSoPhong.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdbSoPhong.Checked)
            {
                if (txbSoPhong.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền số phòng cần tìm", "Tìm phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    int soPhong = Convert.ToInt32(txbSoPhong.Text);
                    dataGridView1.DataSource = phong.LayTableDSPhongTheoSoPhong(soPhong);
                }
            }
            else
            {
                string loaiPhong = cbbLoaiPhong.SelectedValue.ToString();
                dataGridView1.DataSource = phong.LayTableDSPhongTheoLoaiPhong(loaiPhong);
            }
        }

        private void btnXemGiaPhong_Click(object sender, EventArgs e)
        {
            SuaGiaPhongForm giaPhongForm = new SuaGiaPhongForm();
            giaPhongForm.StartPosition = FormStartPosition.CenterScreen;

            giaPhongForm.Show();
        }

        public Action<DataGridView> GetCurrentRowFromDataGridView;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataFromTable = sender as DataGridView;
            if (GetCurrentRowFromDataGridView != null)
            {
                GetCurrentRowFromDataGridView(dataFromTable);
                Close();
            }
        }

        private void btnTaiLaiToanBoPhong_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phong.LayTableDSPhong();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
