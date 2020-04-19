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
    public partial class AddNhanVienForm : Form
    {
        My_DB mydb = new My_DB();
        NhanVien nv = new NhanVien();
        public AddNhanVienForm()
        {
            InitializeComponent();
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
        private void addButton_Click(object sender, EventArgs e)
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
            int Luongcb = 0;
            if (cvComboBox.Text == "Tiep Tan")
            { 
                Luongcb = 120;
            }
            if(cvComboBox.Text == "Lao Cong")
            {
                Luongcb = 60;
            }
            if (now - year < 20 || now-year >100)
            {
                MessageBox.Show("Tuoi khong hop le", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( verif())
            {             
                    if (ID() == false)
                    {
                        MessageBox.Show("Ma NV da ton tai", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                        if (nv.InsertNhanVien(id,ho,ten,gt,ns,dc,cv,Luongcb, pic))
                        {
                            MessageBox.Show("Them nhan vien thanh cong", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Them Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }

        }
        bool verif()
        {
            if ((hoTextBox.Text.Trim() == "")||(tenTextBox.Text.Trim() == "") || (dcTextBox.Text.Trim() == "") || idTextBox.Text.Trim() == "" || cvComboBox.Text.Trim() == "" || pictureBox1.Image == null)
            {
                return false;
            }
            else
            {
                return true;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
