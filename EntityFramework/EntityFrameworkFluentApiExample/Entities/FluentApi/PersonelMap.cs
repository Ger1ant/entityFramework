using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFluentApiExample.Entities.FluentApi
{
    public class PersonelMap:EntityTypeConfiguration<Personel>
    {
       public  PersonelMap()
       {
            this.ToTable("Personeller", "FluentApi");

            this.Property(I => I.PersonelId).HasColumnName("PersonelKod").HasColumnOrder(0);

            //IsRequired : Zorunlu alan
            //Max Uzunluk : 11 karakter
            this.Property(I => I.tel).HasColumnName("TelefonNumarasi")
                .IsRequired()
                .HasMaxLength(12);


            //IsOptional : Boş geçilebilir
            this.Property(I => I.AdSoyad).HasColumnName("AdSoyad")
                .IsOptional();

            //Maas Bazında eşzamanlılık yapılmış oluyor
            this.Property(I => I.Maas).IsConcurrencyToken();

            //IsRowVersion için Byte türünde dizi tanımlanması gerek
            //Datalar korunacak DB ye eş zamanlı giden iki işlemden İlki alınacak.
            this.Property(I => I.PersonelRowVersion).IsRowVersion();
        }
           

    }
}
