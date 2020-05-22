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
using System.Globalization;
using System.Drawing.Printing;

namespace DoAn
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet2.Log' table. You can move, or remove it, as needed.
            this.logTableAdapter1.Fill(this.doAnCuoiKiDataSet2.Log);
            SqlCommand cmd =new SqlCommand("SELECT Ngay FROM Log GROUP BY Ngay ORDER BY MAX(id) DESC");
            DataTable tab = new DataTable();
            tab = Filldb(cmd);
            comboBox1.DataSource = tab;
            comboBox1.DisplayMember = "Ngay";
            LoadData(comboBox1.Text);
        }
        private DataTable Filldb(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        private void LoadData(string text)
        {
            if (text != "System.Data.DataRowView")
            {
                comboBox1.ValueMember = "Ngay";
                DateTime a = Convert.ToDateTime(comboBox1.Text);
                SqlCommand cmd = new SqlCommand("SELECT MaNV,Ten,ChucVu,Checkin,Checkout,ThoiGianLam,Them,Thieu,Luongngay FROM Log WHERE Ngay = @n ");
                cmd.Parameters.Add("@n", SqlDbType.Date).Value = a.Date;
                DataTable tab = Filldb(cmd);
                dataGridView1.DataSource = tab;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData(comboBox1.SelectedValue.ToString());
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
