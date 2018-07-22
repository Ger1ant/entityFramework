using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities
{
    public class Kampanya
    {
        public Guid ID { get; set; }
        public string Tanim { get; set; }
        public string Aciklama { get; set; }

        //N-N
        public ICollection<Urun> urunler { get; set; }
    }
}
