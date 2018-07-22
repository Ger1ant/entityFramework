using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities
{
    public class Urun
    {
        public Guid ID { get; set; }
        public string Tanim { get; set; }
        public string Kod { get; set; }
        public string Aciklama { get; set; }

        //1-1
        public UrunFiyat urunFiyat { get; set; }

        //Generic liste alabilecek 1-N
        public ICollection<Siparis> Siparisler { get; set; }

        //N-N
        public ICollection<Kampanya> Kampanyalar { get; set; }


    }
}
