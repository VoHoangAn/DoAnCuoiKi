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
    public partial class LoginForm : Form
    {
        My_DB db = new My_DB();
        public string cv;
        public Form cvForm = new Form();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.setdtLogin(DateTime.Now);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = usernameTextBox.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = passwordTextBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                string a = "Quan Li";
                cvForm = new MainForm();
                if(tieptanButton.Checked)
                {
                    a = "Tiep tan";
                    cvForm = new TiepTanForm();
                }
                int userid = Convert.ToInt16(table.Rows[0]["ID"].ToString());
                Globals.SetID(userid);
                if (CheckChucVu(a))
                {
                    cv = a;

                    //Nếu là tiếp tân thì checkin và lưu lại vào Log
                    if(cv=="Tiep tan")
                    {
                        NhanVien nv = new NhanVien();

                        SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV=" 
                            + Globals.ID.ToString());

                        DataTable dataTable= nv.getNhanVien(cmd);

                        string hoUser = dataTable.Rows[0].Field<string>("Ho").Trim();
                        string tenUser = dataTable.Rows[0].Field<string>("Ten").Trim();
                        string hoTen = hoUser + " " + tenUser;
                        nv.CheckInAndSaveToLog(Globals.ID, hoTen, cv);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ban khong phai la " + a.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        bool CheckChucVu(string a)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV = @id AND ChucVu = @cv ", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Globals.ID;
            cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = a;
            DataTable tab = new DataTable();
            adp.SelectCommand = cmd;
            adp.Fill(tab);
            if (tab.Rows.Count >0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            quanliButton.Checked = true;
        }
    }
}
