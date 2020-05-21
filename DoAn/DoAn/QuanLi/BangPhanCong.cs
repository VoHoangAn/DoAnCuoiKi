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
using System.Drawing.Printing;

namespace DoAn
{
    public partial class BangPhanCong : Form
    {
        public BangPhanCong()
        {
            InitializeComponent();
        }
        PhanCong pc = new PhanCong();
        private void BangPhanCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet.BangPhanCong' table. You can move, or remove it, as needed.
            this.bangPhanCongTableAdapter.Fill(this.doAnCuoiKiDataSet.BangPhanCong);
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet1.BangPhanCong' table. You can move, or remove it, as needed.
            cvallButton.Checked = true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string cv = "*";
            SqlCommand cmd = new SqlCommand();
            if (qlButton.Checked == true)
                cv = "Quan Li";
            if (ttButton.Checked == true)
                cv = "Tiep Tan";
            if (lcButton.Checked == true)
                cv = "Lao Cong";
            if (cvallButton.Checked == true)
            {
                cmd.CommandText = "SELECT * FROM BangPhanCong";
                LoadData(cmd);
            }
            else
            {
                cmd.CommandText = "SELECT * FROM BangPhanCong WHERE ChucVu = @cv";
                cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = cv;
                LoadData(cmd);
            }
        }

        private void LoadData(SqlCommand cmd)
        {

            dataGridView1.ReadOnly = true;// nap lai du lieu len datagrid view

            dataGridView1.DataSource = pc.GetPhanCong(cmd);

            dataGridView1.AllowUserToAddRows = false;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ThayDoiNhanVien td = new ThayDoiNhanVien();
            td.AddComboBox(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            td.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BangPhanCong");
            LoadData(cmd);
        }
    }
}
