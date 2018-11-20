using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Controller
{
    class KartEmeliyyati
    {
        

        public static bool yoxla { get; set; } = true; 


        public static void EmeliyyatLar()
        {
            bool p = false;
            int a = 0;
            
            while(yoxla)
            {
                Console.WriteLine("Pin Girin");
                var Pin = int.Parse(Console.ReadLine());
                p = PinYoxla.KartYoxla(Pin);
                if (p == false)
                {
                    a++;
                    if (a > 2)
                    {
                        yoxla = false;
                        throw new Exception();
                    }

                }
                else
                {
                    a = 0;
                    yoxla = true;
                    balancEmeliyatlariGorsed();

                }
            }
         

        }

        public static void balancEmeliyatlariGorsed()
        {
            


                Console.WriteLine("============================");
                Console.WriteLine("Emeliyyati Secin");
                Console.WriteLine("1=>Balans Gorsed");
                Console.WriteLine("2=>Balans Artir");
                Console.WriteLine("3=>Nagd Pul");
                Console.WriteLine("4=>Emeliyyat Tarixcesin Gorsed");//duzgun islemir
                Console.WriteLine("5=>Cixis");

                int v = int.Parse(Console.ReadLine());
                Console.WriteLine("============================");
                BalansEmeliyyat.BalansEmeliyatlari(v);
            
        }
    }
}
