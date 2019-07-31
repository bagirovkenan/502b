using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    class Market
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Category> Categorialar { get; set; } = new List<Category>();
        public List<Product> SatilanMallar { get; set; } = new List<Product>();
        public List<Product> Stok { get; set; } = new List<Product>();

        //public Market(Product pro1, Product pro2, Product pro3)
        //{
        //    Stok.Add(pro1);
        //    Stok.Add(pro2);
        //    Stok.Add(pro3);
        //}



        //stoka yeni mehsul  artirmaq 
        public void StokArtir(Product newProduct, int say)
        {

            if (Stok != null)
            {
                var elaveaOlunanMehsul = Stok.FirstOrDefault(f => f.PraductName == newProduct.PraductName && f.Uruncod == newProduct.Uruncod);

                if (elaveaOlunanMehsul != null)
                {
                    elaveaOlunanMehsul.StokSay = elaveaOlunanMehsul.StokSay + say;
                }
                else
                {
                    newProduct.StokSay = say;
                    Stok.Add(newProduct);
                }

            }
            else
            {
                newProduct.StokSay = say;
                Stok.Add(newProduct);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        //yeni mehsul isdifadeci terefinden yaratmaq ve stoka artirmaq
        public Product YeniPraduct(string _PraductName, int _Barkod, double _AlisQiymeti, Category _Categoriya)
        {
            Product yeniMehsul = new Product();
            var maxId = Stok.Max(m => m.ProductId);
            var maxUrunCod = Stok.Max(m => m.Uruncod);




            yeniMehsul.ProductId = maxId + 1;
            yeniMehsul.PraductName = _PraductName;
            yeniMehsul.Uruncod = maxUrunCod + 1;
            yeniMehsul.Barkod = _Barkod;
            yeniMehsul.AlisQiymeti = _AlisQiymeti;
            var yeniMehsulSatis = yeniMehsul.satisiQiymetiHesabla();
            yeniMehsul.SatisQiymeti = yeniMehsulSatis;
            yeniMehsul.PraductCategory = _Categoriya;


            return yeniMehsul;

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// stoku gorsedmek
        public void stokuGorsed()
        {
            var c = 0;
            foreach (var j in Stok)
            {
                c++;
                Console.WriteLine(j.ProductId + "=>" + j.PraductName + " " + "Sifaris Oluna bilen Maxsimum say "+j.StokSay + "-" + "eded" + " " + j.SatisSay + " " +" " +" Qiymeti=>" + j.SatisQiymeti + j.PraductCategory.CategoryName);

            }
        }
        ///////////////////////////////////////////////
        //satis hissesi 
        public void Satis(Product SatilanMehsul, int satilanSay)
        {
            if (Stok == null)
            {
                Console.WriteLine("Market Isdemir");
            }
            else
            {
                var StokdakiSatilanMehsul = Stok.Find(f => f.ProductId == SatilanMehsul.ProductId && f.Uruncod == SatilanMehsul.Uruncod);
               
               if (StokdakiSatilanMehsul == null)
                {
                    Console.WriteLine(" Bu Mehsul Bitib");
                }
                else
                {
                    if (StokdakiSatilanMehsul.StokSay < satilanSay)
                    {
                
                        Console.WriteLine("Bu Mehsuldan En Cox" + " " + StokdakiSatilanMehsul.StokSay + " sayda sifaris ede bilersiz");
                    }
                    else
                    {
                        StokdakiSatilanMehsul.StokSay -= satilanSay;
                        StokdakiSatilanMehsul.SatisSay += satilanSay;
                        if (StokdakiSatilanMehsul.StokSay == 0)
                        {
                            Stok.Remove(StokdakiSatilanMehsul);
                            if (SatilanMallar == null)
                            {
                                SatilanMallar.Add(StokdakiSatilanMehsul);
                            }
                            else
                            {
                                var SatilanMallardakiSatilanMehsul = SatilanMallar.Find(f => f.ProductId == SatilanMehsul.ProductId && f.Uruncod == SatilanMehsul.Uruncod);
                                if (SatilanMallardakiSatilanMehsul == null)
                                {
                                    SatilanMallar.Add(StokdakiSatilanMehsul);
                                }
                                else
                                {
                                    SatilanMallardakiSatilanMehsul.SatisSay = StokdakiSatilanMehsul.SatisSay;
                                }

                            }

                        }
                        else
                        {
                            if (SatilanMallar == null)
                            {
                                SatilanMallar.Add(StokdakiSatilanMehsul);
                            }
                            else
                            {
                                var SatilanMallardakiSatilanMehsul = SatilanMallar.Find(f => f.ProductId == SatilanMehsul.ProductId && f.Uruncod == SatilanMehsul.Uruncod);
                                if (SatilanMallardakiSatilanMehsul == null)
                                {
                                    SatilanMallar.Add(StokdakiSatilanMehsul);
                                }
                                else
                                {
                                    SatilanMallardakiSatilanMehsul.SatisSay = StokdakiSatilanMehsul.SatisSay;
                                }

                            }

                        }
                    }
                }
            }
        }

        //==========================================================================================================================================================================================
        public void SatilanlariGorsed()
        {
            foreach (var i in SatilanMallar)
            {
                Console.WriteLine(i.PraductName);
            }
        }

        //================================================================================
        public void Gelirihesabla()
        {
            double UmumiGelir = 0;

            if (SatilanMallar == null)
            {
                Console.WriteLine("Bankrod Olassan Az Qalib))))))");
            }
            else
            {
               
               foreach(var i in SatilanMallar)
                {
                    UmumiGelir += i.umumiSatis();

                }
                var qazanc = UmumiGelir * 14 / 100;
                Console.WriteLine(qazanc);
            }
        }

    }
}
