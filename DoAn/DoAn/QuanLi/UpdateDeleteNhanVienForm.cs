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

namespace DoAn
{
    public partial class UpdateDeleteNhanVienForm : Form
    {
        public UpdateDeleteNhanVienForm()
        {
            InitializeComponent();
        }

        NhanVien nv = new NhanVien();

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string ho = hoTextBox.Text;
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
                    if (nv.EditNhanVien(id,ho, ten, gt, ns, dc, cv, pic))
                    {
                        MessageBox.Show("Thay doi thanh cong", "Sua thong tin nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sua thong tin nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                
            }
        }

        bool verif()
        {
            if ((tenTextBox.Text.Trim() == "") || (dcTextBox.Text.Trim() == "") || idTextBox.Text.Trim() == "" || cvComboBox.Text.Trim() == "" 
                || pictureBox1.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool ID()
        {
            int id = int.Parse(idTextBox.Text);
            SqlCommand cmd = new SqlCommand("SELECT MaNV,Ten FROM NhanVien WHERE MaNV = " + id);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            try
            {
                if(MessageBox.Show("Ban co chac muon xoa nhan vien nay khong?","Xoa nhan vien",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (nv.DeleteNhanVien(id))
                    {
                        MessageBox.Show("Xoa nhan vien thanh cong", "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tenTextBox.Text = "";
                        idTextBox.Text = "";
                        hoTextBox.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);          
            SqlCommand cmd = new SqlCommand("SELECT MaNV,Ho,Ten,GioiTinh,NgaySinh,DChi,ChucVu,Anh FROM NhanVien WHERE MaNV = " + id);
            DataTable tab = nv.getNhanVien(cmd);
            if( tab.Rows.Count >0)
            {
                tenTextBox.Text = tab.Rows[0]["Ten"].ToString();
                hoTextBox.Text = tab.Rows[0]["Ho"].ToString();
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
                cvComboBox.Text = tab.Rows[0]["ChucVu"].ToString();
                byte[] pic = (byte[])tab.Rows[0]["Anh"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien", "Tim nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
