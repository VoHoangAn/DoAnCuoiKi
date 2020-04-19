using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace DoAn
{
    public partial class UpdateCaLam : Form
    {
        public UpdateCaLam()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        PhanCong pc = new PhanCong();
        private void UpdateCaLam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet1.BangChiaCaTamThoi' table. You can move, or remove it, as needed.
            this.bangChiaCaTamThoiTableAdapter.Fill(this.doAnCuoiKiDataSet1.BangChiaCaTamThoi);
        }
        private void AddText(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BangChiaCaTamThoi WHERE ID = " + id);
            DataTable tab = pc.GetPhanCong(cmd);
            thu2ComboBox.Text = tab.Rows[0]["ThuHai"].ToString();
            thu3ComboBox.Text = tab.Rows[0]["ThuBa"].ToString();
            t4ComboBox.Text = tab.Rows[0]["ThuTu"].ToString();
            t5ComboBox.Text = tab.Rows[0]["ThuNam"].ToString();
            t6ComboBox.Text = tab.Rows[0]["ThuSau"].ToString();
            t7ComboBox.Text = tab.Rows[0]["ThuBay"].ToString();
            cnComboBox.Text = tab.Rows[0]["ChuNhat"].ToString();
            tenComboBox.Text = tab.Rows[0]["Ten"].ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            tenComboBox.DataSource = idComboBox.DataSource;
            tenComboBox.DisplayMember = "HoTen";
            if(idComboBox.Text != "")
            {
                AddText(idComboBox.Text);
            }
        }
        private void tenComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            idComboBox.DataSource = tenComboBox.DataSource;
            idComboBox.DisplayMember = "ID";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idComboBox.Text);
            int t2 = Convert.ToInt32(thu2ComboBox.Text);
            int t3 = Convert.ToInt32(thu3ComboBox.Text);
            int t4 = Convert.ToInt32(t4ComboBox.Text);
            int t5 = Convert.ToInt32(t5ComboBox.Text);
            int t6 = Convert.ToInt32(t6ComboBox.Text);
            int t7 = Convert.ToInt32(t7ComboBox.Text);
            int cn = Convert.ToInt32(cnComboBox.Text);
            if(verif())
            {
                if(pc.UpdateBangChiaCa(id,t2,t3,t4,t5,t6,t7,cn))
                {
                    MessageBox.Show("Update bang chia ca thanh cong", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Update khong thanh cong", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Con o de trong", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verif()
        {
            if (idComboBox.Text.Trim() == "" || tenComboBox.Text.Trim() == "")
                return false;
            else return true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac ban muon thay doi?", "Reset bang phan ca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pc.InsertBangPhanCongToBangChiaCaTamThoi();
                LoadData();
                MessageBox.Show("Thay doi thanh cong", "Reset bang phan ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BangChiaCaTamThoi");
            DataTable tab = pc.GetPhanCong(cmd);
            dataGridView1.DataSource = tab;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddText(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            pc.UpBangTamThoiThanhChinhThuc();
            MessageBox.Show("Thanh cong", "Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }
}
