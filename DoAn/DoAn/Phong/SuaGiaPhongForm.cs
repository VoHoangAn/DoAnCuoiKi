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
    public partial class SuaGiaPhongForm : Form
    {
        public SuaGiaPhongForm()
        {
            InitializeComponent();
        }

        Phong phong = new Phong();

        private void btnGiaPhong_Click(object sender, EventArgs e)
        {
            GiaPhongForm giaPhongForm = new GiaPhongForm();
            giaPhongForm.GetCurrentRowOfDataGridView = new Action<DataGridView>(PassData);

            giaPhongForm.StartPosition = FormStartPosition.CenterScreen;
            giaPhongForm.Show();
        }

        private void PassData(DataGridView sender)
        {
            txbLoaiPhong.Text = sender.CurrentRow.Cells[0].Value.ToString();
            txbGiaPhong.Text = sender.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThemGiaPhong_Click(object sender, EventArgs e)
        {
            if (txbGiaPhong.Text == "" || txbLoaiPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin","Thêm giá phòng",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!phong.KiemTraLoaiPhongDaTonTaiTrongTableGiaPhong(txbLoaiPhong.Text))
            {
                double giaPhong = Convert.ToDouble(txbGiaPhong.Text);

                if (phong.ThemGiaPhongTrongTableGiaPhong(txbLoaiPhong.Text.Trim(), giaPhong))
                {
                    MessageBox.Show("Thêm giá phòng thành công", "Thêm giá phòng",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm giá phòng thất bại", "Thêm giá phòng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Loại phòng đã tồn tại rồi", "Thêm giá phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSuaGiaPhong_Click(object sender, EventArgs e)
        {
            if (txbGiaPhong.Text == "" || txbLoaiPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Sửa giá phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (phong.KiemTraLoaiPhongDaTonTaiTrongTableGiaPhong(txbLoaiPhong.Text))
            {
                double giaPhong = Convert.ToDouble(txbGiaPhong.Text);

                if (phong.SuaGiaPhongTrongTableGiaPhong(txbLoaiPhong.Text.Trim(), giaPhong))
                {
                    MessageBox.Show("Sửa giá phòng thành công", "Sửa giá phòng",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa giá phòng thất bại", "Sửa giá phòng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Loại phòng bạn muốn sửa không tồn tại", "Sửa giá phòng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaGiaPhong_Click(object sender, EventArgs e)
        {
            if (txbLoaiPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa điền loại phòng muốn xóa", "Xóa giá phòng", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (phong.KiemTraLoaiPhongDaTonTaiTrongTableGiaPhong(txbLoaiPhong.Text))
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa giá phòng này?", "Xóa giá phòng",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    double giaPhong = Convert.ToDouble(txbGiaPhong.Text);

                    if (phong.XoaGiaPhongTrongTableGiaPhong(txbLoaiPhong.Text.Trim()))
                    {
                        MessageBox.Show("Xóa giá phòng thành công", "Xóa giá phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa giá phòng thất bại", "Xóa giá phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Loại phòng bạn muốn xóa không tồn tại", "Xóa giá phòng",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
