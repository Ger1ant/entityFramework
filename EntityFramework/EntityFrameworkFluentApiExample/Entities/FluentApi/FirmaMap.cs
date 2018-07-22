using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFluentApiExample.Entities.FluentApi
{
    //EntityTypeConfiguration'la ayarları yapacağız
    //Parametre Olarak EntityAdı Alır
    public class FirmaMap:EntityTypeConfiguration<Firma>
    {
        public FirmaMap()
        {
            this.ToTable("Firmalar","FluentApi");

            //Key Olarak Atadık...
            this.HasKey(I => I.FirmaKodu);
            

            //Index oluşturup aramayı hızlandırır.
            //Not String bir özelliğe Index eklerken Max Uzunluğun 900 Byte'dan büyük olmaması gerekiyor onun için index oluşturacağımız kolonun uzunluğunu kısıtlayacağız...
            this.HasIndex(I => I.Unvan);
            //Property ile Lambda Kullanarak Değiştireceğimiz Kolonu belirliyoruz.
            this.Property(I => I.FirmaKodu).HasColumnName("FirmaAnahtar").HasColumnOrder(0);
            this.Property(I => I.Unvan).HasColumnOrder(1).HasMaxLength(60);

            //NotMapped' ile aynı işlemi yapmaktadır.
            //DB ' de bu prop oluşmamıştır
            this.Ignore(I => I.FirmaLisans);




            
        }
    }
}
