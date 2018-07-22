using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EntityFramework.Entities
{
    public class Kisi
    {
        public Guid ID { get; set; }
        public Guid FirmaID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime dogumTarih { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public Firma firma { get; set; }

        
    }
}
