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
            SqlCommand cmd3 = new SqlCommand("UPDATE NhanVien SET LuongThang=@lt WHERE MaNv = @id");
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



        //Log của An
        public bool CheckInAndSaveToLog(int maNV, string hoTen, string chucVu)
        {
            string ngayHomNay = DateTime.Now.ToShortDateString();
            string checkInTime = DateTime.Now.ToShortTimeString();

            SqlCommand cmd = new SqlCommand("INSERT INTO Log (MaNV, HoTen, ChucVu, NgayLamViec, Checkin) " +
                "VALUES (@manv, @hoten, @chucvu, @ngaylamviec, @checkin)", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoTen;
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = chucVu;
            cmd.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngayHomNay;
            cmd.Parameters.Add("@checkin", SqlDbType.NChar).Value = checkInTime;

            if (!KiemTraDaTonTai(maNV, ngayHomNay))
            {
                if (InsertIntoLuongNV(maNV, hoTen, chucVu, ngayHomNay))
                {
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

                return false;
            }
            else
            {
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

        public DataTable GetTableFromLogByMaNV(int maNV)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Log WHERE MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
        public bool CheckOutAndSaveToLog(int maNV)
        {
            DataTable tableChuaLogMSNVCanTim = GetTableFromLogByMaNV(maNV);

            int logID = 0;
            string timeCheckIn = "0";

            //Tìm dòng trong table có checkin nhưng chưa checkout để lấy checkin và logid của dòng đó
            for (int i = 0; i < tableChuaLogMSNVCanTim.Rows.Count; i++)
            {
                string checkOutInRowHasSameMaNV = tableChuaLogMSNVCanTim.Rows[i].Field<string>("Checkout");

                if (checkOutInRowHasSameMaNV == null)
                {
                    logID = tableChuaLogMSNVCanTim.Rows[i].Field<int>("LogID");
                    timeCheckIn = tableChuaLogMSNVCanTim.Rows[i].Field<string>("Checkin");
                    break;
                }
            }

            DateTime thoiGianCheckIn = DateTime.ParseExact(timeCheckIn, "HH:mm",
                CultureInfo.InvariantCulture);

            DateTime thoiGianHienTai = DateTime.Now;
            int thoiGianLamViec = (int)(thoiGianHienTai - thoiGianCheckIn).TotalMinutes;

            SqlCommand cmd = new SqlCommand("UPDATE Log SET Checkout=@checkout, ThoiGianLamViec=@thoigianlamviec " +
                "WHERE LogID=@logid", mydb.getConnection);

            cmd.Parameters.Add("@checkout", SqlDbType.NChar).Value = thoiGianHienTai.ToShortTimeString();
            cmd.Parameters.Add("@thoigianlamviec", SqlDbType.Int).Value = thoiGianLamViec;
            cmd.Parameters.Add("@checkin", SqlDbType.VarChar).Value = timeCheckIn;
            cmd.Parameters.Add("@logid", SqlDbType.Int).Value = logID;

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

        //Table LuongNV
        public bool InsertIntoLuongNV(int maNV, string hoTen, string chucVu, string ngayLamViec)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO LuongNV (MaNV, HoTen, ChucVu, NgayLamViec) " +
                "VALUES (@manv, @hoten, @chucvu, @ngaylamviec)", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoTen;
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = chucVu;
            cmd.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngayLamViec;

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
        public bool KiemTraDaTonTai(int maNV, string ngayLamViec)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM LuongNV " +
                "WHERE MaNV=@manv AND NgayLamViec=@ngaylamviec", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngayLamViec;

            mydb.openConnection();
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
                return true;
            else
                return false;
        }
        public void UpdateToanBoLuongNV(string ngayCanTinh)
        {
            DataTable dsNV = DSNVCanTinhLuong(ngayCanTinh);

            string chucVu= dsNV.Rows[0].Field<string>("ChucVu");

            foreach (DataRow row in dsNV.Rows)
            {
                int maNV = row.Field<int>("MaNV");
                string ngayLamViec = row.Field<DateTime>("NgayLamViec").ToShortDateString();

                UpdateLuong1NV(maNV, ngayLamViec, chucVu);
            }

        }
        public bool UpdateLuong1NV(int maNV, string ngayLamViec, string chucVu)
        {
            int luong = 0;
            int thoiGianLamViec = TinhThoiGianLamViecTrong1Ngay(maNV, ngayLamViec);
            int lamThem = 0;
            int lamThieu = 0;

            if (chucVu == "Tiếp tân")
                luong = 60000;
            else
                luong = 40000;

            if (thoiGianLamViec > 8)
                lamThem = thoiGianLamViec - 8;
            else if (thoiGianLamViec == 8)
                lamThem = lamThieu = 0;
            else
                lamThieu = 8 - thoiGianLamViec;

            if (lamThem > 0)
                luong += luong * 8 + 2 * luong * lamThem;
            else if (lamThieu > 0)
                luong += luong * thoiGianLamViec - 2 * luong * lamThieu;
            else
                luong += luong * 8;

            SqlCommand cmd = new SqlCommand("UPDATE LuongNV SET ThoiGianLamViec=@thoigianlamviec, " +
                "LamThem=@lamthem, LamThieu=@lamthieu, Luong=@luong " +
                "WHERE MaNV=@manv AND NgayLamViec=@ngaylamviec", mydb.getConnection);

            cmd.Parameters.Add("@thoigianlamviec", SqlDbType.Int).Value = thoiGianLamViec;
            cmd.Parameters.Add("@lamthem", SqlDbType.Int).Value = lamThem;
            cmd.Parameters.Add("@lamthieu", SqlDbType.Int).Value = lamThieu;
            cmd.Parameters.Add("@luong", SqlDbType.Int).Value = luong;
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngayLamViec;

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
        public int TinhThoiGianLamViecTrong1Ngay(int maNV, string ngayLamViec)
        {
            int thoiGianLamViec = 0;

            SqlCommand cmd = new SqlCommand("SELECT ThoiGianLamViec FROM Log " +
                "WHERE MaNV=@manv AND NgayLamViec=@ngaylamviec", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngayLamViec;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tableLogTheoNgayVaMaNV = new DataTable();
            adapter.Fill(tableLogTheoNgayVaMaNV);

            foreach (DataRow row in tableLogTheoNgayVaMaNV.Rows)
            {
                thoiGianLamViec += row.Field<int>("ThoiGianLamViec");
            }
            thoiGianLamViec /= 60;

            return thoiGianLamViec;
        }
        public DataTable DSNVCanTinhLuong(string ngayCanTinh)
        {
            SqlCommand cmd = new SqlCommand("SELECT MaNV, ChucVu, NgayLamViec FROM LuongNV " +
                "WHERE NgayLamViec=@ngaylamviec ", mydb.getConnection);
            cmd.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = ngayCanTinh;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
        public DataTable GetLuongNVTheoNgay(string ngay)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LuongNV WHERE NgayLamViec=@ngay",
                mydb.getConnection);
            cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        //Table QuanLiLaoCong
        public bool InsertIntoQuanLiLaoCong(int id, string hoTen)
        {
            string thoiGianLamViec = DateTime.Now.ToShortTimeString();

            SqlCommand cmd = new SqlCommand("INSERT INTO QuanLiLaoCong (MaNV, HoTen, BatDauLamViec) " +
                "VALUES (@manv, @hoten, @batdaulamviec)", mydb.getConnection);

            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoTen;
            cmd.Parameters.Add("@batdaulamviec", SqlDbType.Time).Value = thoiGianLamViec;

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
            SqlCommand cmd = new SqlCommand("DELETE FROM QuanLiLaoCong WHERE MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.Int).Value = id;

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

        //Xuất dữ liệu
        public void XuatLuongNVIntoFile(string ngayCanXuat)
        {
            String path = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + @"\XuatLuong.txt";

            DataTable dt = GetLuongNVTheoNgay(ngayCanXuat);
            

            int[] maxLengths = new int[dt.Columns.Count];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                maxLengths[i] = dt.Columns[i].ColumnName.Length;

                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;

                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName.PadRight(maxLengths[i] + 5));
                }

                sw.WriteLine("----------------------------------------------------------------" +
                    "------------------------------------------------");

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))
                        {
                            sw.Write(row[i].ToString().PadRight(maxLengths[i] + 5));
                        }
                        else
                        {
                            sw.Write(new string(' ', maxLengths[i] + 5));
                        }
                    }

                    sw.WriteLine();
                }

                sw.Close();
            }
        }
        public DataTable LayTableThongKeTheoNgay(string ngay)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThongKeThuChi", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
