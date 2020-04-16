using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn
{
    class PhanCong
    {
        NhanVien nv = new NhanVien();
        My_DB mydb = new My_DB();
        public bool UpdateBangPhanCong(int MaPc, int id, string HoTen)
        {
            SqlCommand cmd = new SqlCommand("UPDATE BangPhanCong SET ID = @id, HoTen = @HoTen WHERE MaPhanCong = " + MaPc, mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@HoTen", SqlDbType.VarChar).Value = HoTen;
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

        public bool InsertBangPhanCong(int MaNV, string HoTen,string cv,int thu2,int thu3,int thu4,int thu5,int thu6,int thu7,int cn)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO BangPhanCong(MaNV,HoTen,ChucVu,ThuHai,ThuBa,ThuTu,ThuNam,ThuSau,ThuBay,ChuNhat" + "VALUES(@id,@ten,@cv,@t2,@t3,@t4,@t5,@t6,@t7,@cn",mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaNV;
            cmd.Parameters.Add("@t2", SqlDbType.Int).Value = thu2;
            cmd.Parameters.Add("@t3", SqlDbType.Int).Value = thu3;
            cmd.Parameters.Add("@t4", SqlDbType.Int).Value = thu4;
            cmd.Parameters.Add("@t5", SqlDbType.Int).Value = thu5;
            cmd.Parameters.Add("@t6", SqlDbType.Int).Value = thu6;
            cmd.Parameters.Add("@t7", SqlDbType.Int).Value = thu7;
            cmd.Parameters.Add("@cn", SqlDbType.Int).Value = cn;
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = HoTen;
            cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = cv;
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
