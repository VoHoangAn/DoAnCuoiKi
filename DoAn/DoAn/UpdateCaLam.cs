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
        private void UpdateCaLam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet1.BangPhanCong' table. You can move, or remove it, as needed.
            this.bangPhanCongTableAdapter.Fill(this.doAnCuoiKiDataSet1.BangPhanCong);
        }
        private void AddText(string id)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM BangPhanCong WHERE ID = " + id);
            DataTable tab = nv.getNhanVien(cmd);
            thu2ComboBox.Text = tab.Rows[0]["ThuHai"].ToString();
            thu3ComboBox.Text = tab.Rows[0]["ThuBa"].ToString();
            t4ComboBox.Text = tab.Rows[0]["ThuTu"].ToString();
            t5ComboBox.Text = tab.Rows[0]["ThuNam"].ToString();
            t6ComboBox.Text = tab.Rows[0]["ThuSau"].ToString();
            t7ComboBox.Text = tab.Rows[0]["ThuBay"].ToString();
            cnComboBox.Text = tab.Rows[0]["ChuNhat"].ToString();
            tenComboBox.Text = tab.Rows[0]["HoTen"].ToString();
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            AddText(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void tenComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            idComboBox.DataSource = tenComboBox.DataSource;
            idComboBox.DisplayMember = "ID";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BangPhanCong");
            DataTable tab = nv.getNhanVien(cmd);
            dataGridView1.DataSource = tab;
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

        }
    }
}
