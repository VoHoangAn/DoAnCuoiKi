using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace DoAn
{
    class NhanVien
    {
        My_DB mydb = new My_DB();
        public DataTable getNhanVien(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adp.Fill(table);
            return table;
        }
        public bool InsertNhanVien(int MaNV, string HoTen, string GioiTinh, DateTime NSinh, string DChi, string ChucVu, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien(MaNV,HoTen,GioiTinh,NgaySinh,DChi,ChucVu,Anh)" + "VALUES(@id,@ten,@gt,@ns,@dc,@cv,@pic)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaNV;
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = HoTen;
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

        public bool EditNhanVien(int MaNV, string HoTen, string GioiTinh, DateTime NSinh, string DChi, string ChucVu, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET HoTen-@ten,GioiTinh-@gt,NgaySinh-@ns,DChi-@dc,ChucVu-@cv,Anh-@pic WHERE MaNV = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaNV;
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = HoTen;
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
            SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE id = @id", mydb.getConnection);
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
        public bool UpdateLog(int MaNV, DateTime d1, DateTime d2)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV = " + MaNV, mydb.getConnection);
            DataTable tab = getNhanVien(cmd);
            TimeSpan a = d2 - d1;
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Log(MaNV,HoTen,Ngay,Checkin,Checkout,ThoiGianLam,Them,Thieu)" + "VALUES(@manv,@ten,@ngay,@in,@out,@tg,@them,@thieu)", mydb.getConnection);
            cmd2.Parameters.Add("@manv", SqlDbType.Int).Value = MaNV;
            cmd2.Parameters.Add("@ten", SqlDbType.VarChar).Value = tab.Rows[0]["HoTen"].ToString();
            cmd2.Parameters.Add("@ngay", SqlDbType.Date).Value = d1.Date ;
            cmd2.Parameters.Add("@in", SqlDbType.VarChar).Value = d1.ToShortTimeString();
            cmd2.Parameters.Add("@out", SqlDbType.VarChar).Value = d2.ToShortTimeString();
            cmd2.Parameters.Add("@tg", SqlDbType.Int).Value = a.TotalHours;
            if(a.TotalHours >= 8)
            {
                cmd2.Parameters.Add("@them", SqlDbType.Int).Value = a.TotalHours - 8;
                cmd2.Parameters.Add("@thieu", SqlDbType.Int).Value = 0;
            }

            else if (a.TotalHours < 7 )
            {
                cmd2.Parameters.Add("@them", SqlDbType.Int).Value = 0;
                cmd2.Parameters.Add("@thieu", SqlDbType.Int).Value = 8 - a.TotalHours;
            }
            else
            {
                cmd2.Parameters.Add("@them", SqlDbType.Int).Value = 0;
                cmd2.Parameters.Add("@thieu", SqlDbType.Int).Value = 0;
            }
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
    }
}
