using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EntityFramework_DataAnnotations.Entities
{
    [Table("Firma", Schema = "DataAnnotations")]
    public class Firma
    {
        //Order ' gözükeceği index değeri
        [Key]
        [Column("FirmaID",Order =0)]
        public Guid ID { get; set; }
        [Column("FirmaUnvan",Order =1)]
        public string Unvan { get; set; }
        //Adres'in type'ı : ntext
        [Column("FirmaAdres",TypeName ="ntext")]
        public string Adres { get; set; }
        public string Tel { get; set; }

        //Db'de oluşmayacak
        [NotMapped]
        public string KullaniciAdi { get; set; }

        [Timestamp]
        public byte[] RowVersiyonNo { get; set; }

        //Foreign Key 1. Kısım
        public ICollection<Personel> Personeller { get; set; }

    }
}
