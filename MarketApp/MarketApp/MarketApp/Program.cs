using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creat category

            Category ct1 = new Category();
            ct1.CategoryId = 1;
            ct1.CategoryName = "Ickiler";

            Category ct2 = new Category();
            ct2.CategoryId = 2;
            ct2.CategoryName = "Sirniyyat";

            Category ct3 = new Category();
            ct3.CategoryId = 3;
            ct3.CategoryName = "Elektronika";

            //////////////////////////////////////////////

            //creat praduct => ct1

            Product pr1 = new Product();
            pr1.ProductId = 1;
            pr1.PraductCategory = ct1;
            pr1.PraductName = "Fanta";
            pr1.StokSay = 6;
            pr1.Uruncod = 1234;
            pr1.Barkod = 2000040610;
            pr1.AlisQiymeti = 25;
            pr1.SatisQiymeti = pr1.satisiQiymetiHesabla();

            Product pr2 = new Product();
            pr2.ProductId = 2;
            pr2.PraductCategory = ct1;
            pr2.PraductName = "Cola";
            pr2.StokSay = 6;
            pr2.Uruncod = 1235;
            pr2.Barkod = 2000040611;
            pr2.AlisQiymeti = 15;
            pr2.SatisQiymeti = pr2.satisiQiymetiHesabla();


            Product pr3 = new Product();
            pr3.ProductId = 3;
            pr3.PraductCategory = ct1;
            pr3.PraductName = "Sprite";
            pr3.StokSay = 6;
            pr3.Uruncod = 1236;
            pr3.Barkod = 2000040616;
            pr3.AlisQiymeti = 24;
            pr3.SatisQiymeti = pr3.satisiQiymetiHesabla();

            //creat praduct => ct2


            Product pr4 = new Product();
            pr4.ProductId = 4;
            pr4.PraductCategory = ct2;
            pr4.PraductName = "Eti";
            pr4.StokSay = 6;
            pr4.Uruncod = 1237;
            pr4.Barkod = 2000040618;
            pr4.AlisQiymeti = 25;
            pr4.SatisQiymeti = pr4.satisiQiymetiHesabla();


            Product pr5 = new Product();
            pr5.ProductId = 5;
            pr5.PraductCategory = ct2;
            pr5.PraductName = "Roshen";
            pr5.StokSay = 2;
            pr5.Uruncod = 1238;
            pr5.Barkod = 2000040618;
            pr5.AlisQiymeti = 266;
            pr5.SatisQiymeti = pr5.satisiQiymetiHesabla();


            Product pr6 = new Product();
            pr6.ProductId = 6;
            pr6.PraductCategory = ct2;
            pr6.PraductName = "Nestle";
            pr6.StokSay = 3;
            pr6.Uruncod = 1239;
            pr6.Barkod = 2000040618;
            pr6.AlisQiymeti = 5;
            pr6.SatisQiymeti = pr6.satisiQiymetiHesabla();


            //creat praduct => ct3


            Product pr7 = new Product();
            pr7.ProductId = 7;
            pr7.PraductCategory = ct3;
            pr7.PraductName = "Samsung";
            pr7.Uruncod = 1244;
            pr7.StokSay = 5;
            pr7.Barkod = 2000040618;
            pr7.AlisQiymeti = 125;
            pr7.SatisQiymeti = pr7.satisiQiymetiHesabla();


            Product pr8 = new Product();
            pr8.ProductId = 8;
            pr8.PraductCategory = ct3;
            pr8.PraductName = "Sinbo";
            // pr8.Say = 9;
            pr8.Uruncod = 1245;
            pr8.StokSay = 5;
            pr8.Barkod = 2000040678;
            pr8.AlisQiymeti = 145;
            pr8.SatisQiymeti = pr8.satisiQiymetiHesabla();

            Product pr9 = new Product();
            pr9.ProductId = 9;
            pr9.PraductCategory = ct3;
            pr9.PraductName = "LG";
            pr9.Uruncod = 1246;
            pr9.StokSay = 5;
            pr9.Barkod = 2000040688;
            pr9.AlisQiymeti = 350;
            pr9.SatisQiymeti = pr9.satisiQiymetiHesabla();

            //creat market



            Market mr1 = new Market();
            mr1.Id = 1;
            mr1.Name = "Araz";
            mr1.SatilanMallar.Add(pr1);




            Market mr2 = new Market();
            mr2.Id = 2;
            mr2.Name = "Spar";
            mr2.SatilanMallar.Add(pr3);

            Market mr3 = new Market();
            mr3.Id = 3;
            mr3.Name = "Favorit";
            mr3.SatilanMallar.Add(pr4);

            mr1.StokArtir(pr1, 5);
            mr1.StokArtir(pr2, 5);
            mr1.StokArtir(pr4, 4);
            mr1.StokArtir(pr5, 7);
            mr1.StokArtir(pr6, 8);

            mr3.StokArtir(pr4, 5);
            mr3.StokArtir(pr3, 5);
            mr3.StokArtir(pr2, 4);
            mr3.StokArtir(pr5, 7);
            mr3.StokArtir(pr1, 8);

            mr2.StokArtir(pr3, 5);
            mr2.StokArtir(pr5, 5);
            mr2.StokArtir(pr6, 4);
            mr2.StokArtir(pr4, 7);
            mr2.StokArtir(pr9, 8);

            List<Market> Marketler = new List<Market>();
            Marketler.Add(mr1);
            Marketler.Add(mr2);
            Marketler.Add(mr3);

            List<Category> categorialar = new List<Category>();
            categorialar.Add(ct1);
            categorialar.Add(ct2);
            categorialar.Add(ct3);

            while (true)
            {


                Console.WriteLine("Etmek isdeyiniz emeliyyati secin");
                Console.WriteLine("1=>Alis Etmek");
                Console.WriteLine("2=>Mehsul Elave Etmek");

                // Emeliyyat Secmek  satis hissesi


                var secilnEmeliyyat = int.Parse(Console.ReadLine());

                if (secilnEmeliyyat == 1)
                {

                    foreach (var i in Marketler) //marketleri gorseden hissse
                    {

                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine(i.Id + "=>" + i.Name);

                    }
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Marketin Nomresin Secin");
                    var secilenMarket = int.Parse(Console.ReadLine());

                    foreach (var j in Marketler)
                    {
                        if (secilenMarket != j.Id)
                        {
                            Console.WriteLine("Duzgun secim edmediniz");
                        }

                        else     //secilen marketin stokunu gorsedilmesei ve satis hissesi
                                 
                        {
                            j.stokuGorsed();
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Isdediyiniz Mehulun Nomresin Secin");
                            var SecilenMehsulID = int.Parse(Console.ReadLine());

                            var SecilenMehsul = j.Stok.Find(f => f.ProductId == SecilenMehsulID);

                            if (SecilenMehsul == null)
                            {
                                Console.WriteLine("Duz secin");
                            }
                            else
                            {
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine("Alinacaq miqdari Girish edin ");
                                var SatilanMehsulSayi = int.Parse(Console.ReadLine());


                                j.Satis(SecilenMehsul, SatilanMehsulSayi);
                                j.Gelirihesabla();
                            }

                        }
                    }
                }
                //===========================================================================================================================

                ///stoka yeni mehsul artirmaq
                else if (secilnEmeliyyat == 2)
                {
                    foreach (var i in Marketler)
                    {

                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine(i.Id + "=>" + i.Name);

                    }
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Hara elave emek isdeyirsinizse Qarsisindaki reqemi secin");
                    var secilenMarket2 = int.Parse(Console.ReadLine());
                    foreach (var k in Marketler)
                    {
                        var sclnMarket = Marketler.FirstOrDefault(f => f.Id == secilenMarket2);
                        if (sclnMarket != null)
                        {
                            Console.WriteLine("Categoriani Secin");
                            foreach (var c in categorialar)
                            {
                                Console.WriteLine(c.CategoryId + "=>" + c.CategoryName);
                            }
                            Console.WriteLine("Isdediyiniz Categoriya yoxdursa 0 secin ve categoriya elave edin");

                            //categoriya elave edir              
                            var ctg = int.Parse(Console.ReadLine());
                            //if (ctg == 0)
                            //{
                            //    Console.WriteLine("Categoriyanin Adini Giris Edin");
                            //    var YenCtgiAd = Console.ReadLine();
                            //    Console.WriteLine("Mehsulun Sekil Adresin Daxil Edin");
                            //    var YeniSekil = Console.ReadLine();

                            //    Category yeniCategory = new Category();
                            //    yeniCategory.CategoryName = YenCtgiAd;
                            //    yeniCategory.Photo = YeniSekil;

                            //    var maxId = categorialar.Max(m => m.CategoryId);
                            //    yeniCategory.CategoryId = maxId + 1;
                            //    categorialar.Add(yeniCategory);

                            //    Console.WriteLine("Categoriani Secin");
                            //    foreach (var c in categorialar)
                            //    {
                            //        Console.WriteLine(c.CategoryId + "=>" + c.CategoryName);
                            //    }
                            //    var ctg0 = int.Parse(Console.ReadLine());
                            //    var sclnctg0 = categorialar.Find(f => f.CategoryId == ctg);


                            //}
                            var sclnctg = categorialar.Find(f => f.CategoryId == ctg);

                            Console.WriteLine("Mehsulun Adini Giris Edin");
                            var YeniAd = Console.ReadLine();
                            Console.WriteLine("Barkodu Daxil Edin (Xais edirik Reqem Daxil Edin)");
                            var yeniBarkod = int.Parse(Console.ReadLine());
                            Console.WriteLine("Alis Qiymeti Daxil Edin");
                            var yeniAlisQiymeti = double.Parse(Console.ReadLine());
                            Console.WriteLine("Mehsulun miqdarin Giris Edin");
                            var yeniMiqdar = int.Parse(Console.ReadLine());

                            var ynMEh = sclnMarket.YeniPraduct(YeniAd, yeniBarkod, yeniAlisQiymeti, sclnctg);
                            sclnMarket.StokArtir(ynMEh, yeniMiqdar);
                            sclnMarket.stokuGorsed();

                        }
                        else
                        {
                            Console.WriteLine("duzgun secim edin");
                        }
                    }

                }



                else
                {
                    Console.WriteLine("-------------------------------------");

                    Console.WriteLine("seciminiz duzgun deyil");
                }



            }

        }
    }

}