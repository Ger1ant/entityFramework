using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EntityFramework.Entities
{
    public class Firma
    {
        public Guid ID { get; set; }
        public string Unvan { get; set; }

        public string Tel1 { get; set; }

        public string WebAdresi { get; set; }

        public string Email { get; set; }

        //Verinin Hızı açısından Kisi Tipinde Koleksiyon
        public ICollection<Kisi> Kisiler { get; set; }
    }
}
