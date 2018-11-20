using ATM.Controller;
using ATM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Kart k1 = new Kart(1, 1234, "MasKarti", 123456789, 2019, "MasterCart");
            k1.Balance = 2500;
            k1.BankName = "Kapital";
            Db.ButunKartlar.Add(k1);

            Kart k2 = new Kart(2, 1235, "KreditKarti", 123456798, 2019, "MasterCart");
            k2.Balance = 5500;
            k2.BankName = "Kapital";
            Db.ButunKartlar.Add(k2);

          
            while (true)
            {


                Console.WriteLine("Emeliyyati sec");

                Console.WriteLine("1=>Kart Artir");
                Console.WriteLine("2=>Kart Uzerinde Emeliiyat apar");
                int a = int.Parse(Console.ReadLine());

                if (a == 1)
                {

                    Console.WriteLine("PIN girin:");
                    int Pin = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kart Statusun Yazin >>Kredit Karti ,Maas Karti...");
                    string status = Console.ReadLine();
                    Console.WriteLine("Son Istifade Tarixi:");
                    int SonTarix = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kartin Tipi >>Visa veya MasterCart");
                    string Tip = Console.ReadLine();

                    KartConttreller.Creat(Pin, status, SonTarix, Tip);


                }

                else if(a==2)
                {
                    KartEmeliyyati.yoxla = true;
                    KartEmeliyyati.EmeliyyatLar();
                }
                else
                {
                    Console.WriteLine("Emeliyyat Sefdir");
                }
            }
        }
    }
}
