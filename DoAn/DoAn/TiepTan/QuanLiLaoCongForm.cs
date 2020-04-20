using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLiLaoCong : Form
    {
        public QuanLiLaoCong()
        {
            InitializeComponent();

            UpdateFont();

        }

        My_DB db = new My_DB();
        NhanVien nv = new NhanVien();

        private void QuanLiLaoCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSetQLLC.QuanLiLaoCong' table. You can move, or remove it, as needed.
            this.quanLiLaoCongTableAdapter.Fill(this.doAnCuoiKiDataSetQLLC.QuanLiLaoCong);
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSetQLLC.QuanLiLaoCong' table. You can move, or remove it, as needed.
            this.quanLiLaoCongTableAdapter.Fill(this.doAnCuoiKiDataSetQLLC.QuanLiLaoCong);
            // TODO: This line of code loads data into the 'doAnCuoiKiDataSet2.QuanLiLaoCong' table. You can move, or remove it, as needed.
            //          this.quanLiLaoCongTableAdapter1.Fill(this.doAnCuoiKiDataSet2.QuanLiLaoCong);
            //Fill DataGridView bằng table QuanLiLaoCong
            SqlCommand cmdGetAllInQuanLiLaoCong = new SqlCommand("SELECT * FROM QuanLiLaoCong",
                db.getConnection);

            datagvQuanLiLaoCong.ReadOnly = true;
            datagvQuanLiLaoCong.DataSource = nv.getNhanVien(cmdGetAllInQuanLiLaoCong);
            datagvQuanLiLaoCong.AllowUserToAddRows = false;

            //Fill comboBox bằng ID các nhân viên lao công
            SqlCommand cmdGetLaoCongInNhanVien = new SqlCommand(
                "SELECT MaNV FROM NhanVien WHERE ChucVu = @chucVu", db.getConnection);
            cmdGetLaoCongInNhanVien.Parameters.Add("@chucvu", SqlDbType.NChar).Value = "Lao cong";

            cbbChooseIDToCheckInOut.DataSource = nv.getNhanVien(cmdGetLaoCongInNhanVien);
            cbbChooseIDToCheckInOut.DisplayMember = "MaNV";
            cbbChooseIDToCheckInOut.ValueMember = "MaNV";

        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn columns in datagvQuanLiLaoCong.Columns)
            {
                columns.DefaultCellStyle.Font = new Font("Arial", 18F, GraphicsUnit.Pixel);
            }
        }

        private void RefreshDataGridView()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLiLaoCong", db.getConnection);

            datagvQuanLiLaoCong.ReadOnly = true;
            datagvQuanLiLaoCong.DataSource = nv.getNhanVien(cmd);
            datagvQuanLiLaoCong.AllowUserToAddRows = false;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //Lấy id được chọn trong combobox
            int IdChooseToCheckIn = Int32.Parse(cbbChooseIDToCheckInOut.SelectedValue.ToString());


            if (KiemTraCheckIn2Lan())
            {
                if (nv.CheckInAndSaveToLog(IdChooseToCheckIn, tbHoTenTuongUngIDChoose.Text,"Lao Cong") &&
                    nv.InsertIntoQuanLiLaoCong(IdChooseToCheckIn, tbHoTenTuongUngIDChoose.Text))
                {
                    MessageBox.Show("Da check in thanh cong", "Check in", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Check in that bai", "Check in", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ban da check in roi", "Check in", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            RefreshDataGridView();
        }
        private bool KiemTraCheckIn2Lan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLiLaoCong");
            DataTable dataTable = nv.getNhanVien(cmd);

            int idChoose = Int32.Parse(cbbChooseIDToCheckInOut.SelectedValue.ToString());
            foreach (DataRow row in dataTable.Rows)
            {
                int test = row.Field<int>("Id");
                if (idChoose == test)
                    return false;
            }
            return true;

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Log WHERE MaNV=@id");
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            //DataTable dataTable = nv.getNhanVien(cmd);

            ////Kiểm tra nếu Checkin còn trống thì có thể checkin, còn không thì checkin rồi trả về false
            //if (dataTable.Rows[0]["Checkin"].ToString() == "")
            //    return true;
            //return false;
        }

        private void cbbChooseIDToCheckInOut_SelectedValueChanged(object sender, EventArgs e)
        {
            //Không hiểu tại sao lúc load form này thì event này được gọi luôn mà lúc đó chưa set
            //selectvalue nên nó chưa có kiểu int để ép kiểu, nên return event để form load xong
            //và selectvalue dc set = 0 trong method QuanLiLaoCong_Load()
            int idChoose;
            if (!int.TryParse(cbbChooseIDToCheckInOut.SelectedValue.ToString(), out idChoose))
                return;

            SqlCommand cmd = new SqlCommand("SELECT NhanVien.Ho, NhanVien.Ten FROM NhanVien WHERE MaNV=@id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idChoose;

            DataTable dataTable = nv.getNhanVien(cmd);
            string hoUser =dataTable.Rows[0]["Ho"].ToString().Trim();
            string tenUser= dataTable.Rows[0]["Ten"].ToString().Trim();
            string hoTenUser = hoUser+" "+ tenUser;

            tbHoTenTuongUngIDChoose.Text = hoTenUser;
        }

        //private void btnCheckOut_Click(object sender, EventArgs e)
        //{
        //    //Lấy id được chọn trong combobox
        //    int IdChooseToCheckOut = Int32.Parse(cbbChooseIDToCheckInOut.SelectedValue.ToString());

        //    string chuoiThoiGianCheckOut = DateTime.Now.ToShortTimeString();

        //    if (MessageBox.Show("Ban co chac muon check out?", "Check out", MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Asterisk) == DialogResult.Yes)
        //    {
        //        if (KiemTraCheckOut2Lan())
        //        {
        //            if (nv.UpdateCheckIn_OutByID(IdChooseToCheckOut, chuoiThoiGianCheckOut, false) &&
        //                nv.DeleteQuanLiLaoCong(IdChooseToCheckOut))
        //            {
        //                MessageBox.Show("Da check out thanh cong", "Check out", MessageBoxButtons.OK,
        //                    MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Check out that bai", "Check out", MessageBoxButtons.OK,
        //                    MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Ban chua check in nen khong the check out", "Check out",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    RefreshDataGridView();
        //}

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            //Lấy id được chọn trong combobox
            int IdChooseToCheckOut = Int32.Parse(cbbChooseIDToCheckInOut.SelectedValue.ToString());

            //string chuoiThoiGianCheckOut = DateTime.Now.ToShortTimeString();

            if (MessageBox.Show("Ban co chac muon check out?", "Check out", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (KiemTraCheckOut2Lan())
                {
                    if (nv.CheckOutAndSaveLog(IdChooseToCheckOut) &&
                        nv.DeleteQuanLiLaoCong(IdChooseToCheckOut))
                    {
                        MessageBox.Show("Da check out thanh cong", "Check out", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Check out that bai", "Check out", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ban chua check in nen khong the check out", "Check out",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            RefreshDataGridView();
        }

        private bool KiemTraCheckOut2Lan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLiLaoCong");
            DataTable dataTable = nv.getNhanVien(cmd);

            int idChoose = Int32.Parse(cbbChooseIDToCheckInOut.SelectedValue.ToString());
            foreach (DataRow row in dataTable.Rows)
            {
                int test = row.Field<int>("Id");
                if (idChoose == test)
                    return true;
            }
            return false;
        }

        private void datagvQuanLiLaoCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbChooseIDToCheckInOut.Text = datagvQuanLiLaoCong.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
