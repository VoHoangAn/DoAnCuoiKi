using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Globalization;

namespace DoAn
{
    class NhanVien
    {
        My_DB mydb = new My_DB();
        PhanCong pc = new PhanCong();
        public DataTable getNhanVien(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adp.Fill(table);
            return table;
        }
        public bool InsertNhanVien(int MaNV, string ho, string Ten, string GioiTinh, DateTime NSinh, string DChi, string ChucVu, int LuongCB, 
            MemoryStream pic)
        {
            pc.InsertFromNhanVienToBangPhanCong(MaNV, Ten, ChucVu);
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien(MaNV,Ho,Ten,GioiTinh,NgaySinh,DChi,ChucVu,Anh)" +
                "VALUES(@id,@ho,@ten,@gt,@ns,@dc,@cv,@pic)", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaNV;
            cmd.Parameters.Add("@ho", SqlDbType.VarChar).Value = ho;
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = Ten;
            cmd.Parameters.Add("@gt", SqlDbType.VarChar).Value = GioiTinh;
            cmd.Parameters.Add("@ns", SqlDbType.DateTime).Value = NSinh;
            cmd.Parameters.Add("lcb", SqlDbType.Int).Value = LuongCB;
            cmd.Parameters.Add("@dc", SqlDbType.VarChar).Value = DChi;
            cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = ChucVu;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }

        public bool EditNhanVien(int MaNV, string ho, string Ten, string GioiTinh, DateTime NSinh, string DChi, string ChucVu, MemoryStream pic)
        {
            pc.UpdateFromNhanVienToBangPhanCong(MaNV, Ten, ChucVu);
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET Ho=@ho,Ten=@ten,GioiTinh=@gt,NgaySinh=@ns,DChi=@dc,ChucVu=@cv,Anh=@pic WHERE MaNV = @id",
                mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaNV;
            cmd.Parameters.Add("@ho", SqlDbType.VarChar).Value = ho;
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = Ten;
            cmd.Parameters.Add("@gt", SqlDbType.VarChar).Value = GioiTinh;
            cmd.Parameters.Add("@ns", SqlDbType.DateTime).Value = NSinh;
            cmd.Parameters.Add("@dc", SqlDbType.VarChar).Value = DChi;
            cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = ChucVu;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool DeleteNhanVien(int MaNV)
        {
            pc.DeleteBangPhanCong(MaNV);
            SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaNV;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public bool UpdateLog(int MaNV, DateTime d2)
        {
            DateTime d1 = Globals.dtlogin;
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV = " + MaNV, mydb.getConnection);
            DataTable tab = getNhanVien(cmd);
            TimeSpan a = d2 - d1;
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Log(MaNV,Ten,ChucVu,Ngay,Checkin,Checkout,ThoiGianLam,Them,Thieu,LuongNgay)" + "VALUES(@manv,@ten,@cv,@ngay,@in,@out,@tg,@them,@thieu,@ln)", mydb.getConnection);
            cmd2.Parameters.Add("@manv", SqlDbType.Int).Value = MaNV;
            cmd2.Parameters.Add("@ten", SqlDbType.VarChar).Value = tab.Rows[0]["Ten"].ToString();
            cmd2.Parameters.Add("@cv", SqlDbType.VarChar).Value = tab.Rows[0]["ChucVu"].ToString();
            cmd2.Parameters.Add("@ngay", SqlDbType.Date).Value = d1.Date;
            cmd2.Parameters.Add("@in", SqlDbType.VarChar).Value = d1.ToShortTimeString();
            cmd2.Parameters.Add("@out", SqlDbType.VarChar).Value = d2.ToShortTimeString();
            cmd2.Parameters.Add("@tg", SqlDbType.Int).Value = a.TotalHours;
            cmd2.Parameters.Add("@ln", SqlDbType.Int).Value = a.TotalHours * Convert.ToInt32(tab.Rows[0]["LuongCB"]);
            Globals.setLuongNgay(a.TotalHours * Convert.ToDouble(tab.Rows[0]["LuongCB"]));
            if (a.TotalHours >= 8)
            {
                cmd2.Parameters.Add("@them", SqlDbType.Int).Value = a.TotalHours - 8;
                cmd2.Parameters.Add("@thieu", SqlDbType.Int).Value = 0;
            }

            else if (a.TotalHours < 7)
            {
                cmd2.Parameters.Add("@them", SqlDbType.Int).Value = 0;
                cmd2.Parameters.Add("@thieu", SqlDbType.Int).Value = 8 - a.TotalHours;
            }
            else
            {
                cmd2.Parameters.Add("@them", SqlDbType.Int).Value = 0;
                cmd2.Parameters.Add("@thieu", SqlDbType.Int).Value = 0;
            }
            SqlCommand cmd3 = new SqlCommand("UPDATE NhanVien SET LuongThang-@lt WHERE MaNv = @id");
            cmd3.Parameters.Add("@lt", SqlDbType.Int).Value = Convert.ToInt32(tab.Rows[0]["LuongThang"]) + Globals.LuongNgay;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1 || cmd2.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }



        //Xu li Log cua An
        public bool CheckInAndSaveToLog(int maNV, string hoTen, string chucVu)
        {
            string ngayHomNay = DateTime.Now.ToShortDateString();
       
            string checkInTime = DateTime.Now.ToShortTimeString();

            SqlCommand cmd = new SqlCommand("INSERT INTO Log (MaNV, Ten, ChucVu, Ngay, Checkin) VALUES " +
                "(@manv, @hoten, @chucvu, @ngay, @checkin)", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@hoten", SqlDbType.Text).Value = hoTen;
            cmd.Parameters.Add("@chucvu", SqlDbType.NChar).Value = chucVu;
            cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngayHomNay;
            cmd.Parameters.Add("@checkin", SqlDbType.Text).Value = checkInTime;
           

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable GetTableFromLogByMaNV(int maNV)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Log WHERE MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;

        }
        public bool CheckOutAndSaveLog(int maNV)
        {
            DataTable dataTable = GetTableFromLogByMaNV(maNV);

            //Tìm dòng trong table có checkin nhưng chưa checkout để điền vào
            int dongCanTimDeCheckOut = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string checkOutInRowHasSameMaNV = dataTable.Rows[i].Field<string>("Checkout");
                int id = Convert.ToInt32(dataTable.Rows[i].Field<Int32>("MaNV"));

                if (checkOutInRowHasSameMaNV == null && id == maNV)
                {
                    dongCanTimDeCheckOut = i;
                    break;
                }
            }
            string timeCheckIn = dataTable.Rows[dongCanTimDeCheckOut].Field<string>("Checkin");
            string dateCheckIn = dataTable.Rows[dongCanTimDeCheckOut].Field<DateTime>("Ngay").ToShortDateString();

            string stringThoiGianCheckIn = dateCheckIn + " " + timeCheckIn;

            DateTime thoiGianCheckIn = DateTime.ParseExact(stringThoiGianCheckIn, "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture);

            DateTime thoiGianHienTai = DateTime.Now;
            int thoiGianLamViec = (int)(thoiGianHienTai - thoiGianCheckIn).TotalHours;

            int thoiGianLamThem = 0;
            int thoiGianLamThieu = 0;

            if (thoiGianLamViec <= 7)
                thoiGianLamThieu = 8 - thoiGianLamViec;
            else
                thoiGianLamThem = thoiGianLamViec - 8;

            SqlCommand cmd = new SqlCommand("UPDATE Log SET Checkout=@checkout, ThoiGianLam=@thoigianlam, Them=@thoiGianLamThem, " +
                "Thieu=@thoiGianLamThieu WHERE MaNV=@manv AND CONVERT(VARCHAR,Checkin)=@checkin", mydb.getConnection);

            cmd.Parameters.Add("@checkout", SqlDbType.Text).Value = thoiGianHienTai.ToShortTimeString();
            cmd.Parameters.Add("@thoigianlam", SqlDbType.Int).Value = thoiGianLamViec;
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@thoiGianLamThem", SqlDbType.Int).Value = thoiGianLamThem;
            cmd.Parameters.Add("@thoiGianLamThieu", SqlDbType.Int).Value = thoiGianLamThieu;
            cmd.Parameters.Add("@checkin", SqlDbType.VarChar).Value = timeCheckIn;

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //DataTable QuanLiLaoCong
        public bool InsertIntoQuanLiLaoCong(int id, string hoTen)
        {
            string thoiGianLamViec = DateTime.Now.ToShortTimeString();

            SqlCommand cmd = new SqlCommand("INSERT INTO QuanLiLaoCong (Id, HoTen, ThoiGianLamViec) " +
                "VALUES (@id, @hoten, @thoigian)", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@hoten", SqlDbType.NChar).Value = hoTen;
            cmd.Parameters.Add("@thoigian", SqlDbType.NChar).Value = thoiGianLamViec;

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool DeleteQuanLiLaoCong(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM QuanLiLaoCong WHERE Id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
    }
}
