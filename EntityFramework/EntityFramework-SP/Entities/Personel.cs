using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EntityFramework_SP.Entities
{
    public class Personel
    {
        [Key]
        public Guid ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

    }
}
