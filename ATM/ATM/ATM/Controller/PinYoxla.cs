using ATM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Controller
{
    class PinYoxla
    {
        public static bool KartYoxla(int pin)
        {
            var axtarilan = Db.ButunKartlar.AsParallel().FirstOrDefault(f => f.PIN == pin);

            if (axtarilan != null)
            {
                axtarilan.Session = true;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
