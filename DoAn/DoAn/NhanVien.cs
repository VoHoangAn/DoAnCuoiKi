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
        public bool InsertNhanVien(int MaNV,string HoTen,string GioiTinh,DateTime NSinh,string DChi,string ChucVu, MemoryStream pic)
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

        public bool EditNhanVien(int MaNV, string HoTen, string GioiTinh, DateTime NSinh, string DChi, string ChucVu,MemoryStream pic)
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
    }
}
