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
        My_DB mydb = new My_DB();
        public bool UpdateBangPhanCong(int MaPc, int id, string Ten)
        {
            SqlCommand cmd = new SqlCommand("UPDATE BangPhanCong SET ID = @id, Ten = @Ten WHERE MaPhanCong = " + MaPc, mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Ten", SqlDbType.VarChar).Value = Ten;
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

        public bool UpdateFromNhanVienToBangPhanCong(int id, string Ten,string ChucVu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE BangPhanCong SET Ten = @ten,ChucVu = @cv WHERE ID = @id", mydb.getConnection);
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = Ten;
            cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = ChucVu;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public bool InsertFromNhanVienToBangPhanCong(int id,string ten, string cv )
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO BangPhanCong(ID,Ten,ChucVu)" + "VALUES(@id,@ten,@cv)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = ten;
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
        
        public bool DeleteBangPhanCong(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM BangPhanCong WHERE ID = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public bool InsertBangChiaCa(int MaNV, string Ten,string cv,int thu2,int thu3,int thu4,int thu5,int thu6,int thu7,int cn)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO BangPhanCong(MaNV,Ten,ChucVu,ThuHai,ThuBa,ThuTu,ThuNam,ThuSau,ThuBay,ChuNhat) " +
                "VALUES(@id,@ten,@cv,@t2,@t3,@t4,@t5,@t6,@t7,@cn)",mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaNV;
            cmd.Parameters.Add("@t2", SqlDbType.Int).Value = thu2;
            cmd.Parameters.Add("@t3", SqlDbType.Int).Value = thu3;
            cmd.Parameters.Add("@t4", SqlDbType.Int).Value = thu4;
            cmd.Parameters.Add("@t5", SqlDbType.Int).Value = thu5;
            cmd.Parameters.Add("@t6", SqlDbType.Int).Value = thu6;
            cmd.Parameters.Add("@t7", SqlDbType.Int).Value = thu7;
            cmd.Parameters.Add("@cn", SqlDbType.Int).Value = cn;
            cmd.Parameters.Add("@ten", SqlDbType.VarChar).Value = Ten;
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

        public bool UpdateBangChiaCa(int MaNV,int thu2, int thu3, int thu4, int thu5, int thu6, int thu7, int cn)
        {
            SqlCommand cmd = new SqlCommand("UPDATE BangChiaCaTamThoi SET ThuHai=@t2,ThuBa =@t3," +
                                                "ThuTu=@t4,ThuNam=@t5,ThuSau=@t6,ThuBay=@t7,ChuNhat=@cn WHERE ID = " + MaNV, mydb.getConnection);

            cmd.Parameters.Add("@t2", SqlDbType.Int).Value = thu2;
            cmd.Parameters.Add("@t3", SqlDbType.Int).Value = thu3;
            cmd.Parameters.Add("@t4", SqlDbType.Int).Value = thu4;
            cmd.Parameters.Add("@t5", SqlDbType.Int).Value = thu5;
            cmd.Parameters.Add("@t6", SqlDbType.Int).Value = thu6;
            cmd.Parameters.Add("@t7", SqlDbType.Int).Value = thu7;
            cmd.Parameters.Add("@cn", SqlDbType.Int).Value = cn;

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

        public bool InsertBangPhanCongToBangChiaCaTamThoi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM DoAnCuoiKi.dbo.BangChiaCaTamThoi " +
                               "SET IDENTITY_INSERT DoAnCuoiKi.dbo.BangChiaCaTamThoi ON " +
                                "INSERT INTO DoAnCuoiKi.dbo.BangChiaCaTamThoi (MaPhanCong,ID,Ten,ChucVu,ThuHai,ThuBa,ThuTu,ThuNam,ThuSau,ThuBay,ChuNhat) " +
                                 "SELECT MaPhanCong, ID, Ten, ChucVu, ThuHai, ThuBa, ThuTu, ThuNam, ThuSau, ThuBay, ChuNhat FROM DoAnCuoiKi.dbo.BangPhanCong " +
                                  "SET IDENTITY_INSERT DoAnCuoiKi.dbo.BangChiaCaTamThoi OFF";

            cmd.Connection = mydb.getConnection;

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

        public bool UpBangTamThoiThanhChinhThuc()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM DoAnCuoiKi.dbo.BangPhanCong " +
                               "SET IDENTITY_INSERT DoAnCuoiKi.dbo.BangPhanCong ON " +
                                "INSERT INTO DoAnCuoiKi.dbo.BangPhanCong (MaPhanCong,ID,Ten,ChucVu,ThuHai,ThuBa,ThuTu,ThuNam,ThuSau,ThuBay,ChuNhat) " +
                                 "SELECT MaPhanCong, ID, Ten, ChucVu, ThuHai, ThuBa, ThuTu, ThuNam, ThuSau, ThuBay, ChuNhat " +
                                 "FROM DoAnCuoiKi.dbo.BangChiaCaTamThoi SET IDENTITY_INSERT DoAnCuoiKi.dbo.BangPhanCong OFF";

            cmd.Connection = mydb.getConnection;

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

        public DataTable GetPhanCong(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adp.Fill(table);

            return table;
        }
    }

}
