using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFluentApiExample.Entities
{
    public class Personel
    {

        public Guid PersonelId { get; set; }
        public Guid FirmaId { get; set; }
        public string AdSoyad { get; set; }
        public string tel { get; set; }
        public decimal Maas { get; set; }

        [ForeignKey("FirmaId")]
        public Firma firma { get; set; }
        public byte[] PersonelRowVersion { get; set; }

        
    }
}
