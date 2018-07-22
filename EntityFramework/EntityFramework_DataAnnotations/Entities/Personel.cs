using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EntityFramework_DataAnnotations.Entities
{
    public class Personel
    {
        [Key]
        public Guid PersonelID { get; set; }

        public Guid FirmaFID { get; set; }


        public string Isim { get; set; }

        [ForeignKey("FirmaFID ")]
        public Firma firma { get; set; }
    }
}
