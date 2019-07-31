using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    class Product
    {
        public int ProductId { get; set; }
        public Category PraductCategory { get; set; }
        public string PraductName { get; set; }
        public int StokSay { get; set; }
        public int SatisSay { get; set; }
        public int Barkod { get; set; }
        public int Uruncod { get; set; }
        public double AlisQiymeti { get; set; }
        public double SatisQiymeti { get; set; }
        


        public double satisiQiymetiHesabla()
        {
            if (AlisQiymeti > 0)
            {
                return SatisQiymeti = AlisQiymeti + (AlisQiymeti * 20 / 100); 
            }
            else
            {
                return SatisQiymeti = 1;
            }
        }

        public Double umumiSatis()
        {
            return SatisQiymeti * SatisSay;
        }


    }

   
}
