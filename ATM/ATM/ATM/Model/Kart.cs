using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Kart
    {
        public int ID { get; set; }
        public int PIN { get; set; }
      //public int MaxPIN { get; set; }
        public string KartName { get; set; }
        public int SeriaNomre { get; set; }
        public double Balance { get; set; }
        public int MaxEmeliyyat { get; set; }
        public int SonIstifade { get; set; }
        public string Type { get; set; }
        public string BankName { get; set; }
        public bool Session { get; set; }

        public Kart(int Id, int p, string name,int seriaN,int son,string typ)
        {
            ID = Id;
            PIN = p;
            KartName = name;
            SeriaNomre = seriaN;
            SonIstifade = son;
            Type = typ;
            Session = false;
        }
    }
}
