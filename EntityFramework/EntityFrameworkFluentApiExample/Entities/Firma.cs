using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFluentApiExample.Entities
{
    //Entity Framework Key Olarak Sonu ID id , Id ile biten değerleri otomatik olarak alır 
    //Eğer public Guid BirincilAnahtar property'si alınsa Bunun Key olduğunu anlamayacak
    //Çözüm Data Annotations , Fluent Api
    public class Firma
    {
        public Guid FirmaKodu { get; set; }
        public string Unvan { get; set; }
        public string Iletisim { get; set; }
        public string Adres { get; set; }

        public string FirmaLisans { get; set; }
    }
}