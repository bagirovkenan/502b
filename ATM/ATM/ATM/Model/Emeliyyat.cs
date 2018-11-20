using ATM.Controller;
using ATM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
   public class Emeliyyat
    {
       public int ID { get; set; }
       public int KartID { get; set; }
       public string Name { get; set; }
       public DateTime Date { get; set; } = new DateTime();

       public Emeliyyat(int kID,string name,DateTime d )
        {
            var id = 0;
            if (Db.EmeliyyatLarTarixi.Count == 0)
            {
                id = 1;
            }
            else
            {
              var  maxId = Db.EmeliyyatLarTarixi.AsParallel().Max(m => m.ID);
              id = maxId + 1;
            }
            ID = id;
            KartID = kID;
            Name = name;
       //     Date = DateTime.Now;
        }
    }
}
