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
    }
}
