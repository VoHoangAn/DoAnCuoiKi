using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class Phong
    {
        My_DB mydb = new My_DB();


        //Table GiaPhong
        #region
        public DataTable LayLoaiPhongTuTableGiaPhong()
        {
            SqlCommand cmd = new SqlCommand("SELECT LoaiPhong FROM GiaPhong", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable LayTableGiaPhong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaPhong", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public bool XoaGiaPhongTrongTableGiaPhong(string loaiPhong)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM GiaPhong WHERE LoaiPhong=@loaiphong",
                mydb.getConnection);
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;

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
        public bool SuaGiaPhongTrongTableGiaPhong(string loaiPhong, double giaPhong)
        {
            SqlCommand cmd = new SqlCommand("UPDATE GiaPhong SET GiaPhong=@giaphong " +
                "WHERE LoaiPhong=@loaiphong", mydb.getConnection);
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;
            cmd.Parameters.Add("@giaphong", SqlDbType.Float).Value = giaPhong;

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
        public bool ThemGiaPhongTrongTableGiaPhong(string loaiPhong, double giaPhong)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO GiaPhong (LoaiPhong, GiaPhong) VALUES " +
                "(@loaiphong,@giaphong)", mydb.getConnection);
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;
            cmd.Parameters.Add("@giaphong", SqlDbType.Float).Value = giaPhong;

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
        public bool KiemTraLoaiPhongDaTonTaiTrongTableGiaPhong(string loaiPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GiaPhong " +
                "WHERE LoaiPhong=@loaiphong", mydb.getConnection);
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;

            mydb.openConnection();
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            mydb.closeConnection();

            if (count > 0)
                return true;
            return false;
        }
        #endregion

        //table DSPhong
        #region
        public bool ThemPhongTrongTableDSPhong(int soPhong, string loaiPhong, MemoryStream image)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DSPhong (SoPhong, LoaiPhong, HinhAnh) VALUES " +
                "(@sophong, @loaiphong, @hinhanh)", mydb.getConnection);
            cmd.Parameters.Add("@sophong", SqlDbType.Int).Value = soPhong;
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;
            cmd.Parameters.Add("@hinhanh", SqlDbType.Image).Value = image.ToArray();

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
        public bool SuaPhongTrongTableDSPhong(int soPhong, string loaiPhong, MemoryStream image)
        {
            SqlCommand cmd = new SqlCommand("UPDATE DSPhong SET LoaiPhong=@loaiphong, HinhAnh=@hinhanh " +
                "WHERE SoPhong=@sophong", mydb.getConnection);
            cmd.Parameters.Add("@sophong", SqlDbType.Int).Value = soPhong;
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;
            cmd.Parameters.Add("@hinhanh", SqlDbType.Image).Value = image.ToArray();

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
        public bool XoaPhongTrongTableDSPhong(int soPhong)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM DSPhong WHERE SoPhong=@sophong",
                mydb.getConnection);
            cmd.Parameters.Add("@sophong", SqlDbType.Int).Value = soPhong;

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
        public bool KiemTraSoPhongDaTonTaiTrongTableDSPhong(int soPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DSPhong " +
                "WHERE SoPhong=@sophong", mydb.getConnection);
            cmd.Parameters.Add("@sophong", SqlDbType.Int).Value = soPhong;

            mydb.openConnection();
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            mydb.closeConnection();

            if (count > 0)
                return true;
            return false;
        }
        public DataTable LayTableDSPhong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSPhong", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable LayTableDSPhongTheoSoPhong(int soPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSPhong WHERE SoPhong=@sophong",
                mydb.getConnection);
            cmd.Parameters.Add("@sophong", SqlDbType.Int).Value = soPhong;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable LayTableDSPhongTheoLoaiPhong(string loaiPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSPhong WHERE LoaiPhong=@loaiphong",
                mydb.getConnection);
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        #endregion

        //table DSPhongDaDat
        #region
        public DataTable LayTatCaTrongDSPhongDaDat()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSPhongDaDat ", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable LayTatCaTrongDSPhongDaDatTheoSDTHoacTenNguoiDat(string ten, string sdt)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSPhongDaDat " +
                "WHERE SDT=@sdt OR TenNguoiDat=@ten", mydb.getConnection);
            cmd.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public bool XoaPhongDatTrongTableDSPhongDaDat(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM DSPhongDaDat " +
                "WHERE IDDatPhong=@datphong", mydb.getConnection);
            cmd.Parameters.Add("@datphong", SqlDbType.Int).Value = id;

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
        public bool ThemPhongDatTrongTableDSPhongDaDat(string tenNguoiDat, int soPhong, string sdt,
            string ngayDat, string ngayTra, string loaiPhong)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DSPhongDaDat (SoPhong, TenNguoiDat, SDT, NgayDatPhong," +
                " NgayTraPhong, LoaiPhong) VALUES (@sophong, @tennguoidat, @sdt, @ngaydatphong, @ngaytraphong, " +
                "@loaiphong)", mydb.getConnection);

            cmd.Parameters.Add("@sophong", SqlDbType.Int).Value = soPhong;
            cmd.Parameters.Add("@tennguoidat", SqlDbType.NVarChar).Value = tenNguoiDat;
            cmd.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
            cmd.Parameters.Add("@ngaydatphong", SqlDbType.Date).Value = ngayDat;
            cmd.Parameters.Add("@ngaytraphong", SqlDbType.Date).Value = ngayTra;
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;

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
        public bool SuaPhongDatTrongTableDSPhongDaDat(int soPhong, string tenNguoiDat, string sdt,
            string ngayDatPhong, string ngayTraPhong, string loaiPhong, int iDDatPhong)
        {
            SqlCommand cmd = new SqlCommand("UPDATE DSPhongDaDat SET SoPhong=@sophong, " +
                "TenNguoiDat=@tennguoidat, SDT=@sdt, NgayDatPhong=@ngaydatphong, " +
                "NgayTraPhong=@ngaytraphong, LoaiPhong=@loaiphong WHERE IDDatPhong=@iddatphong", mydb.getConnection);

            cmd.Parameters.Add("@sophong", SqlDbType.Int).Value = soPhong;
            cmd.Parameters.Add("@tennguoidat", SqlDbType.NVarChar).Value = tenNguoiDat;
            cmd.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
            cmd.Parameters.Add("@ngaydatphong", SqlDbType.Date).Value = ngayDatPhong;
            cmd.Parameters.Add("@ngaytraphong", SqlDbType.Date).Value = ngayTraPhong;
            cmd.Parameters.Add("@iddatphong", SqlDbType.Int).Value = iDDatPhong;
            cmd.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiPhong;

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

        //Lấy phòng trống bằng đống dưới đây
        private List<int> TimPhongTrungTrongTableDSPhongDaDat(string loaiPhong,
            string tempNgayDat, string tempNgayTra)
        {
            DataTable dsPhongDaDat = LayTatCaTrongDSPhongDaDat();

            List<int> dsPhongTrung = new List<int>() { 0 };

            DateTime ngayDat = DateTime.ParseExact(tempNgayDat, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(tempNgayTra, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            //Kiểm tra số phòng đã nằm trong ds phòng trùng chưa, nếu rồi thì continue khỏi lm tốn tài nguyên
            for (int i = 0; i < dsPhongDaDat.Rows.Count; i++)
            {
                int soPhong = dsPhongDaDat.Rows[i].Field<int>("SoPhong");

                bool loopThrough = false;
                foreach (int item in dsPhongTrung)
                {
                    if (soPhong == item)
                    {
                        loopThrough = true;
                        break;
                    }
                }
                if (loopThrough)
                    continue;

                string loaiPhongFromTable = dsPhongDaDat.Rows[i].Field<string>("LoaiPhong");

                //string tempNgayDatFromTable = dsPhongDaDat.Rows[i].Field<DateTime>("NgayDatPhong");
                //string tempNgayTraFromTable = dsPhongDaDat.Rows[i].Field<string>("NgayTraPhong");

                //DateTime ngayDatFromTable = DateTime.ParseExact(tempNgayDatFromTable, "dd/MM/yyyy",
                //System.Globalization.CultureInfo.InvariantCulture);
                //DateTime ngayTraFromTable = DateTime.ParseExact(tempNgayTraFromTable, "dd/MM/yyyy",
                //    System.Globalization.CultureInfo.InvariantCulture);

                DateTime ngayDatFromTable = dsPhongDaDat.Rows[i].Field<DateTime>("NgayDatPhong");
                DateTime ngayTraFromTable = dsPhongDaDat.Rows[i].Field<DateTime>("NgayTraPhong");

                if (String.Compare(loaiPhong, "Tất cả") != 0)
                {
                    if (String.Compare(loaiPhong, loaiPhongFromTable) == 0)
                    {
                        //ở đây là so sánh ngày input với ngày trong table
                        int soSanh2NgayDat = DateTime.Compare(ngayDat, ngayDatFromTable);
                        int soSanh2NgayTra = DateTime.Compare(ngayTra, ngayTraFromTable);
                        int soSanhNgayDatvsNgayTraTrongTable = DateTime.Compare(ngayDat, ngayTraFromTable);
                        int soSanhNgayTravsNgayDatTrongTable = DateTime.Compare(ngayTra, ngayDatFromTable);

                        if (soSanh2NgayDat >= 0 && soSanh2NgayTra <= 0)
                        {
                            dsPhongTrung.Add(soPhong);
                            continue;
                        }

                        if (soSanh2NgayDat >= 0 && soSanhNgayDatvsNgayTraTrongTable <= 0)
                        {
                            dsPhongTrung.Add(soPhong);
                            continue;
                        }

                        if (soSanhNgayTravsNgayDatTrongTable >= 0 && soSanh2NgayTra <= 0)
                        {
                            dsPhongTrung.Add(soPhong);
                            continue;
                        }

                        if (soSanh2NgayDat <= 0 && soSanh2NgayTra >= 0)
                        {
                            dsPhongTrung.Add(soPhong);
                            continue;
                        }

                    }
                }
                else
                {
                    int soSanh2NgayDat = DateTime.Compare(ngayDat, ngayDatFromTable);
                    int soSanh2NgayTra = DateTime.Compare(ngayTra, ngayTraFromTable);
                    int soSanhNgayDatvsNgayTraTrongTable = DateTime.Compare(ngayDat, ngayTraFromTable);
                    int soSanhNgayTravsNgayDatTrongTable = DateTime.Compare(ngayTra, ngayDatFromTable);

                    if (soSanh2NgayDat >= 0 && soSanh2NgayTra <= 0)
                    {
                        dsPhongTrung.Add(soPhong);
                        continue;
                    }

                    if (soSanh2NgayDat >= 0 && soSanhNgayDatvsNgayTraTrongTable <= 0)
                    {
                        dsPhongTrung.Add(soPhong);
                        continue;
                    }

                    if (soSanhNgayTravsNgayDatTrongTable >= 0 && soSanh2NgayTra <= 0)
                    {
                        dsPhongTrung.Add(soPhong);
                        continue;
                    }

                    if (soSanh2NgayDat <= 0 && soSanh2NgayTra >= 0)
                    {
                        dsPhongTrung.Add(soPhong);
                        continue;
                    }
                }

                #region
                //if (loaiPhong != "Tất cả")
                //{
                //    if (String.Compare(loaiPhong, loaiPhongFromTable) == 0)
                //    {
                //        if (DateTime.Compare(ngayDat, ngayDatFromTable) > 0 ||
                //            DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //        {
                //            if (DateTime.Compare(ngayTra, ngayTraFromTable) < 0 ||
                //            DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //            {

                //                dsPhongTrung.Add(soPhong);
                //            }
                //        }

                //        if (DateTime.Compare(ngayDat, ngayDatFromTable) > 0 ||
                //            DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //        {
                //            if (DateTime.Compare(ngayDat, ngayDatFromTable) < 0 ||
                //            DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //            {

                //                dsPhongTrung.Add(soPhong);
                //            }
                //        }

                //        if (DateTime.Compare(ngayTra, ngayTraFromTable) > 0 ||
                //            DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //        {
                //            if (DateTime.Compare(ngayTra, ngayTraFromTable) < 0 ||
                //            DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //            {

                //                dsPhongTrung.Add(soPhong);
                //            }
                //        }

                //        if (DateTime.Compare(ngayDat, ngayDatFromTable) < 0 ||
                //            DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //        {
                //            if (DateTime.Compare(ngayTra, ngayTraFromTable) > 0 ||
                //            DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //            {

                //                dsPhongTrung.Add(soPhong);
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    if (DateTime.Compare(ngayDat, ngayDatFromTable) > 0 ||
                //            DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //    {
                //        if (DateTime.Compare(ngayTra, ngayTraFromTable) < 0 ||
                //        DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //        {

                //            dsPhongTrung.Add(soPhong);
                //        }
                //    }

                //    if (DateTime.Compare(ngayDat, ngayDatFromTable) > 0 ||
                //        DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //    {
                //        if (DateTime.Compare(ngayDat, ngayDatFromTable) < 0 ||
                //        DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //        {

                //            dsPhongTrung.Add(soPhong);
                //        }
                //    }

                //    if (DateTime.Compare(ngayTra, ngayTraFromTable) > 0 ||
                //        DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //    {
                //        if (DateTime.Compare(ngayTra, ngayTraFromTable) < 0 ||
                //        DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //        {

                //            dsPhongTrung.Add(soPhong);
                //        }
                //    }

                //    if (DateTime.Compare(ngayDat, ngayDatFromTable) < 0 ||
                //        DateTime.Compare(ngayDat, ngayDatFromTable) == 0)
                //    {
                //        if (DateTime.Compare(ngayTra, ngayTraFromTable) > 0 ||
                //        DateTime.Compare(ngayTra, ngayTraFromTable) == 0)
                //        {

                //            dsPhongTrung.Add(soPhong);
                //        }
                //    }
                //}
                #endregion
            }

            dsPhongTrung.Remove(0);
            return dsPhongTrung;
        }
        private List<int> LayDSPhongTrongTuDSPhongTrung(List<int> dsPhongTrung, string loaiPhong)
        {
            List<int> dsPhong = new List<int>();

            DataTable tablePhong;
            if (loaiPhong == "Tất cả")
                tablePhong = LayTableDSPhong();
            else
                tablePhong = LayTableDSPhongTheoLoaiPhong(loaiPhong);

            //Load tất cả số phòng từ table DSPhong có cùng loại phòng vào list 
            //(cách này ngáo, nên có cách lm hay hơn)
            foreach (DataRow row in tablePhong.Rows)
            {
                int soPhong = row.Field<int>("SoPhong");
                dsPhong.Add(soPhong);
            }

            //Loại trừ các phần tử có trong ds phòng trùng (cái này cũng ngáo nốt)
            foreach (int item in dsPhongTrung)
            {
                dsPhong.Remove(item);
            }
            return dsPhong;
        }
        public DataTable LayDSPhongTrong(string loaiPhong, string tempNgayDat, string tempNgayTra)
        {
            //TH: chưa có phòng nào được đặt, fix bug của func TimPhongTrungTrongTableDSPhongDaDat(loaiPhong,
            //tempNgayDat, tempNgayTra) vì khi vào vòng lặp for nếu count=0 thì nó bỏ qua vòng for đó
            //nên sẽ không lấy ds phòng trống theo loại dc
            DataTable soPhongDaDat = LayTatCaTrongDSPhongDaDat();
            if (soPhongDaDat.Rows.Count == 0)
            {
                DataTable tatCaPhongTheoLoaiPhong;
                if (loaiPhong == "Tất cả")
                    tatCaPhongTheoLoaiPhong = LayTableDSPhong();
                else
                    tatCaPhongTheoLoaiPhong = LayTableDSPhongTheoLoaiPhong(loaiPhong);

                return tatCaPhongTheoLoaiPhong;
            }
            else
            {
                List<int> dsPhongTrung = TimPhongTrungTrongTableDSPhongDaDat(loaiPhong,
                    tempNgayDat, tempNgayTra);

                List<int> dsPhongTrong = LayDSPhongTrongTuDSPhongTrung(dsPhongTrung, loaiPhong);

                DataTable dataTable = LayTableDSPhong();

                //Chỉ ra PK
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = dataTable.Columns["SoPhong"];
                dataTable.PrimaryKey = keyColumns;

                //Clone lại schema nếu không nó có thì lúc sau importrow sẽ không hoạt động
                DataTable tableDSPhongTrong = dataTable.Clone();

                foreach (int item in dsPhongTrong)
                {
                    DataRow newRow = tableDSPhongTrong.NewRow();
                    tableDSPhongTrong.ImportRow(dataTable.Rows.Find(item));
                }
                return tableDSPhongTrong;
            }

        }
        #endregion
    }
}
