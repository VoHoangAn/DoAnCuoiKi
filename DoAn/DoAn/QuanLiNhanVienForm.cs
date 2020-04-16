using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace DoAn
{
    public partial class QuanLiNhanVienForm : Form
    {
        public QuanLiNhanVienForm()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        private void QuanLiNhanVienForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.doAnCuoiKiDataSet.NhanVien);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            AddTextBox(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
        private void AddTextBox(string id)
        {
            idTextBox.Text = id.ToString();
            SqlCommand cmd = new SqlCommand("SELECT MaNV,HoTen,GioiTinh,NgaySinh,DChi,ChucVu,Anh FROM NhanVien WHERE MaNV = " + id);
            DataTable tab = nv.getNhanVien(cmd);
            tenTextBox.Text = tab.Rows[0]["HoTen"].ToString();
            if (tab.Rows[0]["ChucVu"].ToString() == "Quan Li   ")
                cvComboBox.Text = "Quan Li";
            else if (tab.Rows[0]["ChucVu"].ToString() == "Tiep Tan  ")
                cvComboBox.Text = "Tiep tan";
            else
                cvComboBox.Text = "Lao Cong";
            if (tab.Rows[0]["GioiTinh"].ToString() == "Nam       ")
            {
                namButton.Checked = true;
            }
            else
            {
                nuButton.Checked = true;
            }
            dateTimePicker1.Value = (DateTime)tab.Rows[0]["NgaySinh"];
            dcTextBox.Text = tab.Rows[0]["DChi"].ToString();
            byte[] pic = (byte[])tab.Rows[0]["Anh"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*.gif| *.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("NhanVien_ " + idTextBox.Text);
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No imagine in picturebox!");
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save((svf.FileName + (".") + ImageFormat.Jpeg.ToString()));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string ten = tenTextBox.Text;
            string gt = "Nam";
            if (nuButton.Checked)
                gt = "Nu";
            DateTime ns = dateTimePicker1.Value;
            string dc = dcTextBox.Text;
            string cv = cvComboBox.Text;
            MemoryStream pic = new MemoryStream();
            int year = dateTimePicker1.Value.Year;
            int now = DateTime.Now.Year;
            int Luongcb = 0;
            if (cvComboBox.Text == "Tiep tan")
            {
                Luongcb = 120;
            }
            if (cvComboBox.Text == "Lao Cong")
            {
                Luongcb = 60;
            }
            if (now - year < 20 || now - year > 100)
            {
                MessageBox.Show("Tuoi khong hop le", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (ID() == false)
                {
                    MessageBox.Show("Ma NV da ton tai", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (nv.InsertNhanVien(id, ten, gt, ns, dc, cv,Luongcb, pic))
                    {
                        MessageBox.Show("Them nhan vien thanh cong", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien");
            LoadData(cmd);
        }
        bool ID()
        {
            int id = int.Parse(idTextBox.Text);
            SqlCommand cmd = new SqlCommand("SELECT MaNV,HoTen FROM NhanVien WHERE MaNV = " + id);
            DataTable tab = nv.getNhanVien(cmd);
            if (tab.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool verif()
        {
            if ((tenTextBox.Text.Trim() == "") || (dcTextBox.Text.Trim() == "") || idTextBox.Text.Trim() == "" || cvComboBox.Text.Trim() == "" || pictureBox1.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void LoadData(SqlCommand cmd)
        {

            dataGridView1.ReadOnly = true;// nap lai du lieu len datagrid view

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;

            dataGridView1.DataSource = nv.getNhanVien(cmd);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string ten = tenTextBox.Text;
            string gt = "Nam";
            if (nuButton.Checked)
                gt = "Nu";
            DateTime ns = dateTimePicker1.Value;
            string dc = dcTextBox.Text;
            string cv = cvComboBox.Text;
            MemoryStream pic = new MemoryStream();
            int year = dateTimePicker1.Value.Year;
            int now = DateTime.Now.Year;
            if (now - year < 20 || now - year > 100)
            {
                MessageBox.Show("Tuoi khong hop le", "Sua thong tin nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (nv.EditNhanVien(id, ten, gt, ns, dc, cv, pic))
                {
                    MessageBox.Show("Thay doi thanh cong", "Sua thong tin nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Sua thong tin nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Con thong tin chua nhap", "Sua thong tin nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            try
            {
                if (MessageBox.Show("Ban co chac muon xoa nhan vien nay khong?", "Xoa nhan vien", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (nv.DeleteNhanVien(id))
                    {
                        MessageBox.Show("Xoa nhan vien thanh cong", "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tenTextBox.Text = "";
                        idTextBox.Text = "";
                        namButton.Checked = nuButton.Checked = false;
                        dateTimePicker1.Value = DateTime.Now;
                        dcTextBox.Text = "";
                        cvComboBox.Text = "";
                        pictureBox1.Image = null;

                    }
                    else
                    {
                        MessageBox.Show("Nhan vien chua duoc xoa", "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ma nhan vien khong hop le", "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            tenTextBox.Text = "";
            idTextBox.Text = "";
            namButton.Checked = nuButton.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dcTextBox.Text = "";
            cvComboBox.Text = "";
            pictureBox1.Image = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien");
            LoadData(cmd);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE CONCAT(HoTen,ChucVu) LIKE'%" + findTextBox.Text.ToString() + "%'");
            LoadData(cmd);           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
