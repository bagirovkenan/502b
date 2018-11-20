using ATM.DB;
using ATM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Controller
{
    class KartConttreller
    {
        //yeni kart
        public static void Creat(int pin, string name, int sonatrix, string typ)
        {
            if (Db.ButunKartlar.Count == 0)
            {
                Random r = new Random();
                int s = r.Next(1000000, int.MaxValue);
                Kart YeniKart = new Kart(1, pin, name, s, sonatrix, typ);
                YeniKart.Balance = 0;
                Db.ButunKartlar.Add(YeniKart);
            }
            else
            {
                var maxId = Db.ButunKartlar.Max(m => m.ID);
                Random r = new Random();
                int s = r.Next(1000000, int.MaxValue);
                Kart YeniKart = new Kart(maxId + 1, pin, name, s, sonatrix, typ);
                Db.ButunKartlar.Add(YeniKart);

            }
        }
        //============================================================================


        //============================================================================
        //Balansi Gorsed
        public static void BalancGorsed()
        {
            var BalancGorsedilenKart = Db.ButunKartlar.AsParallel().FirstOrDefault (f => f.Session == true);
            if (BalancGorsedilenKart == null)
            {
                Console.WriteLine("Pin Kod sefdir ");
            }
            else
            {
                Emeliyyat yeniEmeliyyat = new Emeliyyat(BalancGorsedilenKart.ID, "Balans Gorsed", DateTime.Now);
                //EmeliyyatTarixi.Emeliyyatlar.Add(yeniEmeliyyat);
                //EmeliyyatTarixi.say++;
                Db.EmeliyyatLarTarixi.Add(yeniEmeliyyat);
                Console.WriteLine("Sizin Balanc {0} AZN teskil edir", BalancGorsedilenKart.Balance);
             

            }
        }


        //============================================================================

        public static void BalancArtir(int elaveMebleg)
        {
            var BalancArtirilanKart = Db.ButunKartlar.AsParallel().FirstOrDefault(f => f.Session == true);
            if (BalancArtirilanKart == null)
            {
                Console.WriteLine("Pin Kod Veya ID sefdir ");

            }
            else
            {
                if (BalancArtirilanKart.MaxEmeliyyat > 10)
                {
                    Console.WriteLine("Bu Gun Bu Kart Uzerinde Balansa Baxmaqdan Basqa bir emeliyyat apara bilmezsiniz");
                    Console.WriteLine("============================");
                }
                else
                {


                    BalancArtirilanKart.MaxEmeliyyat++;
                    Emeliyyat yeniEmeliyyat = new Emeliyyat(BalancArtirilanKart.ID, "Balans Artir", DateTime.Now);
                    //EmeliyyatTarixi.Emeliyyatlar.Add(yeniEmeliyyat);
                    //EmeliyyatTarixi.say++;
                    Db.EmeliyyatLarTarixi.Add(yeniEmeliyyat);

                    BalancArtirilanKart.Balance += elaveMebleg;
                    Console.WriteLine("Sizin Balansa {0} AZN  elave olundu", elaveMebleg);
                    Console.WriteLine("============================");
                    Console.WriteLine("Bu Gun Edilen Emeliyyat Sayi ==> {0}", BalancArtirilanKart.MaxEmeliyyat);
                }
            }
        }

        //============================================================================
        public static void BalancAzalt(int XerclenenMebleg)
        {
            var BalancKart = Db.ButunKartlar.AsParallel().FirstOrDefault(f => f.Session == true);


            if (BalancKart == null)
            {
                Console.WriteLine("Bele Kartiniz Yoxdur");
                Console.WriteLine("============================");

            }
            else
            {

                if (BalancKart.MaxEmeliyyat > 10)
                {
                    Console.WriteLine("Bu Gun Bu Kart Uzerinde Balansa Baxmaqdan Basqa bir emeliyyat apara bilmezsiniz");
                    Console.WriteLine("=========================================================================");
                }
                else
                {



                    if (XerclenenMebleg > 1000)
                    {
                        Console.WriteLine("Maxsimum 1000 AZN");
                        Console.WriteLine("============================");


                    }
                    else
                    {
                        if (BalancKart.Balance < XerclenenMebleg)
                        {
                            Console.WriteLine("Balans Yeterli Deyil");
                            Console.WriteLine("============================");

                        }
                        else
                        {
                            BalancKart.MaxEmeliyyat++;
                            Emeliyyat yeniEmeliyyat = new Emeliyyat(BalancKart.ID, "Nagd Avans", DateTime.Now);
                            //EmeliyyatTarixi.Emeliyyatlar.Add(yeniEmeliyyat);
                            //EmeliyyatTarixi.say++;
                            Db.EmeliyyatLarTarixi.Add(yeniEmeliyyat);

                            BalancKart.Balance -= XerclenenMebleg;
                            Console.WriteLine("Sizin Balansdan {0} AZN Cixildi ", XerclenenMebleg);
                            Console.WriteLine("============================");
                            Console.WriteLine("Bu Gun Edilen Emeliyyat Sayi ==> {0}", BalancKart.MaxEmeliyyat);
                        }

                    }
                }
            }
        }

        //==================================================================
       
        public static void BalansTarixcesi()
        {
            var BlnsTarix = Db.ButunKartlar.AsParallel().FirstOrDefault(f => f.Session == true);
            if (BlnsTarix == null)
            {
                Console.WriteLine("Tarixcesi Gosderilecek Kart Yoxdur");
                Console.WriteLine("============================");

            }
            else
            {
                if (Db.EmeliyyatLarTarixi == null)
                {
                    Console.WriteLine("Hec Bir Emeliyyat Tapilmadi");
                    Console.WriteLine("============================");

                }
                else
                {
                    var GorsedilenEmeliyyatlar = Db.EmeliyyatLarTarixi.AsParallel().Where(w => w.KartID == BlnsTarix.ID).ToList();
                    if (GorsedilenEmeliyyatlar==null)
                    {
                        Console.WriteLine("Kartiniz ucun Emeliyyat Tapilmadi");
                        Console.WriteLine("============================");

                    }
                    else
                    {
                        Console.WriteLine("Kartiniz Ucun  {0} Emeliyyat Tapildi", GorsedilenEmeliyyatlar.Count);
                        foreach (var i in GorsedilenEmeliyyatlar)
                        {
                            
                            Console.WriteLine(" ID=>{0}\n KartId=>{1}\n EmeLiyyatin Adi=>{2} \n Emeliyyatin Tarixi=>{3}",i.ID,i.KartID,i.Name,i.Date);
                            Console.WriteLine("============================");

                        };
                    }
                }
            }
        }
    }
}
