using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public static class Globals
    {
        public static int ID { get; private set; }
        public static void SetID(int userID)
        {
            ID = userID;
        }
        public static DateTime dtlogin { get; private set; }
        public static void setdtLogin(DateTime dt)
        {
            dtlogin = dt;
        }
        public static Double LuongNgay { get; private set; }
        public static void setLuongNgay(double ln)
        {
            LuongNgay = ln;
        }

    }
}
