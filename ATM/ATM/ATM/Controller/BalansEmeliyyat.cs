using ATM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Controller
{
    class BalansEmeliyyat
    {
        public static void BalansEmeliyatlari(int a)
        {
           // bool w = true;

            if (a > 5)
            {
                Console.WriteLine("Bele Bir Emeliyyat Mocud Deyil");
                KartEmeliyyati.balancEmeliyatlariGorsed();
            }
            else
            {
                //>>>>>>>>>>>>Balansi Gorsed
                if (a == 1)
                {
                    KartConttreller.BalancGorsed();
                    Console.WriteLine("============================");
                    KartEmeliyyati.balancEmeliyatlariGorsed();
                }
                //>>>>>>>>>>>>Balansi Artir

                else if (a == 2)
                {
                    Console.WriteLine("Elave Olunacaq Meblegi Secin");
                    int Mebleg = int.Parse(Console.ReadLine());
                    KartConttreller.BalancArtir(Mebleg);
                    Console.WriteLine("============================");
                    KartEmeliyyati.balancEmeliyatlariGorsed();
                }
                //>>>>>>>>>>>>Balansi Azalt

                else if (a == 3)
                {
                    Console.WriteLine("Isdediyiniz Mebelegi Giris Edin (En Yuksek Nagd Avans 1000 AZN)");
                    int Mebleg = int.Parse(Console.ReadLine());
                    KartConttreller.BalancAzalt(Mebleg);
                    Console.WriteLine("============================");
                    KartEmeliyyati.balancEmeliyatlariGorsed();
                }
                //>>>>>>>>>>>>Balans Tarixcesi
                
                else if (a==4)
                {
                    KartConttreller.BalansTarixcesi();
                    Console.WriteLine("============================");
                    KartEmeliyyati.balancEmeliyatlariGorsed();
                }


                ///////x//////////////==>>>Cixis
                else if (a == 5)
                {
                    var ss = Db.ButunKartlar.AsParallel().FirstOrDefault(f => f.Session == true);
                    if (ss == null)
                    {
                        KartEmeliyyati.yoxla = false;

                    }
                    else
                    {
                        ss.Session = false;
                        KartEmeliyyati.yoxla = false;


                    }

                }
            }

        }
    }
}
