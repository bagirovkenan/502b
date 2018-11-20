using ATM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DB
{
    class Db
    {
        public static List<Kart> ButunKartlar { get; set; } = new List<Kart>();
        public static List<Isdifadeci> Isdifadeciler { get; set; } = new List<Isdifadeci>();
        public static List<Emeliyyat> EmeliyyatLarTarixi { get; set; } = new List<Emeliyyat>();


    }
}
