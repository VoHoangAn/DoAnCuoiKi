using System;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLiPhongDaDatForm : Form
    {
        public QuanLiPhongDaDatForm()
        {
            InitializeComponent();
        }

        Phong phong = new Phong();

        private void QuanLiPhongForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = phong.LayTatCaTrongDSPhongDaDat();
        }

        private void btnTimPhongDaDat_Click(object sender, EventArgs e)
        {
            if (txbTenNguoiDat.Text == "" && txbSDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hoặc sđt của người đặt", "Tìm phòng đã đặt",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.DataSource = phong.LayTatCaTrongDSPhongDaDatTheoSDTHoacTenNguoiDat(
                txbTenNguoiDat.Text, txbSDT.Text);
        }

        private void btnDSPhongDaDat_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = phong.LayTatCaTrongDSPhongDaDat();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridview = sender as DataGridView;

            string soPhong = datagridview.CurrentRow.Cells[0].Value.ToString();
            string tenNguoiDat = datagridview.CurrentRow.Cells[1].Value.ToString();
            string sdt = datagridview.CurrentRow.Cells[2].Value.ToString();
            string ngayDat = datagridview.CurrentRow.Cells[3].Value.ToString();
            string ngayTra = datagridview.CurrentRow.Cells[4].Value.ToString();
            string loaiPhong = datagridview.CurrentRow.Cells[5].Value.ToString();
            string id = datagridview.CurrentRow.Cells[6].Value.ToString();

            SuaVaXoaPhongDaDatForm suaVaXoaPhongDaDatForm = new SuaVaXoaPhongDaDatForm(
                soPhong, tenNguoiDat, sdt, ngayDat, ngayTra, loaiPhong, id);
            suaVaXoaPhongDaDatForm.StartPosition = FormStartPosition.CenterScreen;

            suaVaXoaPhongDaDatForm.Show();
        }
    }
}
