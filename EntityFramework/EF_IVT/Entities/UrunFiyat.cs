using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities
{
    public class UrunFiyat
    {
        public Guid ID { get; set; }
        
        public decimal AlisFiyat { get; set; }
        public decimal OzelFiyat { get; set; }
        public decimal SatisFiyat { get; set; }

        //1-1 yapı olduğu için ID değerleri AYnı olacak

        public Urun urun { get; set; }
    }
}
