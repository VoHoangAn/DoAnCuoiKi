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

namespace DoAn
{
    public partial class ThayDoiNhanVien : Form
    {
        public ThayDoiNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        My_DB mydb = new My_DB();
        private void ThayDoiNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet1.BangPhanCong' table. You can move, or remove it, as needed.
            this.bangPhanCongTableAdapter.Fill(this.doAnCuoiKiDataSet1.BangPhanCong);
        }

        private void thayButton_Click(object sender, EventArgs e)
        {
            string ten1;
            string ten2;
            int mapc1 = 0;
            int mapc2 = 0;
            if (comboBox1.Text == null || comboBox2.Text == null)
                MessageBox.Show("Chon nhan vien de thay doi", "Doi nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SqlCommand cmd = new SqlCommand("SELECT * FROM BangPhanCong WHERE ID = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = comboBox1.Text;
            DataTable tab = nv.getNhanVien(cmd);
            ten1 = tab.Rows[0]["HoTen"].ToString();
            mapc1 = Convert.ToInt32(tab.Rows[0]["MaPhanCong"].ToString());
            cmd.CommandText = "SELECT * FROM BangPhanCong WHERE ChucVu = @cv AND ID = @id2";
            cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = tab.Rows[0]["ChucVu"].ToString();
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = comboBox2.Text;
            DataTable tab2 = nv.getNhanVien(cmd);    
            if(tab2.Rows.Count > 0)
            {
                ten2 = tab2.Rows[0]["HoTen"].ToString();
                mapc2 = Convert.ToInt32(tab2.Rows[0]["MaPhanCong"].ToString());
                if (mapc1 == mapc2)
                {
                    MessageBox.Show("Cung 1 nhan vien", "Doi Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SwapPhanCongNhanVien(Convert.ToInt32(comboBox1.Text), ten1, Convert.ToInt32(comboBox2.Text), ten2, mapc1, mapc2);
                    MessageBox.Show("Thay doi thanh cong", "Doi nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Khong the doi nhan vien vi chuc vu khong giong", "Doi Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SwapPhanCongNhanVien(int id1,string a,int id2,string b,int pc1,int pc2)
        {
            nv.UpdateBangPhanCong(pc1,id2, b);
            nv.UpdateBangPhanCong(pc2,id1, a);
        }
        public void AddComboBox(string id)
        {
            comboBox1.Text = id;
        }
    }
}
