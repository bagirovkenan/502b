using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    class Isdifadeci
    {
        int IstifadeciID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int KartID { get; set; }
        public List<Kart> Kartlar { get; set; } = new List<Kart>();

    }
}
