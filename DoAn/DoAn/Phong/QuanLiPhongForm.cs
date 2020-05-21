using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLiPhongForm : Form
    {
        public QuanLiPhongForm()
        {
            InitializeComponent();
        }

        Phong phong = new Phong();

        private void btnDSPhong_Click_1(object sender, EventArgs e)
        {
            DSPhongForm dSPhongForm = new DSPhongForm();
            dSPhongForm.GetCurrentRowFromDataGridView = new Action<DataGridView>(PassData);

            dSPhongForm.StartPosition = FormStartPosition.CenterScreen;
            dSPhongForm.Show();
        }

        public void PassData(DataGridView sender)
        {
            txbSoPhong.Text = sender.CurrentRow.Cells[0].Value.ToString();
            cbbLoaiPhong.Text = sender.CurrentRow.Cells[1].Value.ToString();

            //load image
            Byte[] image = new Byte[0];
            image = (Byte[])(sender.CurrentRow.Cells[2].Value);
            MemoryStream memoryStream = new MemoryStream(image);
            pibHinhAnh.Image = Image.FromStream(memoryStream);
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.SelectedValue.ToString() == "" || txbSoPhong.Text == "" || pibHinhAnh.Image == null)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thêm phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string loaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            int soPhong = Convert.ToInt32(txbSoPhong.Text);
            MemoryStream saveImage = new MemoryStream();
            pibHinhAnh.Image.Save(saveImage, pibHinhAnh.Image.RawFormat);

            if (phong.KiemTraSoPhongDaTonTaiTrongTableDSPhong(soPhong))
            {
                if (phong.SuaPhongTrongTableDSPhong(soPhong, loaiPhong, saveImage))
                {
                    MessageBox.Show("Sửa phòng thành công", "Sửa phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa phòng thất bại", "Sửa phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Số phòng không tồn tại", "Sửa phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnAddPhong_Click(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.SelectedValue.ToString() == "" || txbSoPhong.Text == "" || pibHinhAnh.Image == null)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thêm phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string loaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            int soPhong = Convert.ToInt32(txbSoPhong.Text);
            MemoryStream saveImage = new MemoryStream();
            pibHinhAnh.Image.Save(saveImage, pibHinhAnh.Image.RawFormat);

            if (!phong.KiemTraSoPhongDaTonTaiTrongTableDSPhong(soPhong))
            {
                if (phong.ThemPhongTrongTableDSPhong(soPhong, loaiPhong, saveImage))
                {
                    MessageBox.Show("Thêm phòng thành công", "Thêm phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại", "Thêm phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Số phòng đã tồn tại", "Thêm phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (txbSoPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số phòng muốn xóa", "Xóa phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int soPhong = Convert.ToInt32(txbSoPhong.Text);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa số phòng này ?", "Xóa phòng", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (phong.XoaPhongTrongTableDSPhong(soPhong))
                {
                    MessageBox.Show("Đã xóa phòng", "Xóa phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại", "Xóa phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaiAnhLen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if ((openFileDialog.ShowDialog() == DialogResult.OK))
            {
                pibHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void cbbLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cbbLoaiPhong.SelectedValue == null)
            //    return;

            //MessageBox.Show(cbbLoaiPhong.SelectedValue.ToString()); 
        }

        private void QuanLiPhongForm_Load(object sender, EventArgs e)
        {
            cbbLoaiPhong.DisplayMember = "LoaiPhong";
            cbbLoaiPhong.ValueMember = "LoaiPhong";
            cbbLoaiPhong.DataSource = phong.LayLoaiPhongTuTableGiaPhong();
        }
    }
}
