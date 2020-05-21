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
    public partial class TimPhongTrongForm : Form
    {
        public TimPhongTrongForm(string formCallThis)
        {
            InitializeComponent();
            FormCallThis = formCallThis;
        }

        string FormCallThis;
        public Action<string, string, string, string> GetCurrentRowFromDataGridView;

        Phong phong = new Phong();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormCallThis == "TiepTanForm")
            {
                string soPhong = ((DataGridView)sender).CurrentRow.Cells[0].Value.ToString();
                string loaiPhong = ((DataGridView)sender).CurrentRow.Cells[1].Value.ToString();

                DatPhongForm datPhongForm = new DatPhongForm(soPhong, loaiPhong, dtpNgayDat.Text, dtpNgayTra.Text);
                datPhongForm.StartPosition = FormStartPosition.CenterScreen;

                datPhongForm.Show();
            }
            else
            {
                if(GetCurrentRowFromDataGridView!=null)
                {
                    DataGridView dataFromDataGridView = sender as DataGridView;

                    string soPhong = dataFromDataGridView.CurrentRow.Cells[0].Value.ToString();
                    string loaiPhong = dataFromDataGridView.CurrentRow.Cells[1].Value.ToString();
                    string ngayDat = dtpNgayDat.Text;
                    string ngayTra = dtpNgayTra.Text;

                    GetCurrentRowFromDataGridView(soPhong, loaiPhong, ngayDat, ngayTra);
                    Close();
                }
            }
        }

        private void btnTimPhongTrong_Click(object sender, EventArgs e)
        {
            DateTime ngayDat = DateTime.ParseExact(dtpNgayDat.Text, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(dtpNgayTra.Text, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            if (DateTime.Compare(ngayDat, ngayTra) > 0)
            {
                MessageBox.Show("Ngày trả phòng không được bé hơn ngày đặt phòng",
                    "Tìm phòng trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.AllowUserToAddRows = false;

            string loaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            dataGridView1.DataSource = phong.LayDSPhongTrong(loaiPhong, dtpNgayDat.Text, dtpNgayTra.Text);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[2];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void TimPhongTrongForm_Load(object sender, EventArgs e)
        {
            DataTable dataForCombobox = phong.LayLoaiPhongTuTableGiaPhong();

            //Thêm item "Tất cả" vào combobox thông qua datatable nạp vào datasource của combobox
            DataRow newRow = dataForCombobox.NewRow();
            newRow["LoaiPhong"] = "Tất cả";
            dataForCombobox.Rows.InsertAt(newRow, 0);

            cbbLoaiPhong.DisplayMember = "LoaiPhong";
            cbbLoaiPhong.ValueMember = "LoaiPhong";
            cbbLoaiPhong.DataSource = dataForCombobox;
            cbbLoaiPhong.SelectedIndex = 0;
        }
    }
}
