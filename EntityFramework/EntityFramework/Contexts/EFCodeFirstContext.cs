using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EntityFramework.Entities;

namespace Udemy.EntityFramework.Contexts
{
    class EFCodeFirstContext:DbContext
    {
        //Db içindeki Tabloyu Çağıracağız
        //Property İsmimiz Kullanicilar olarak ayarladık
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        //ConnectionStringe ulaşma

        //base olarak : Kendi Verdiğimiz connection String üzerine DB yi oluşturacaktır.

        public EFCodeFirstContext() : base("Data Source=DESKTOP-E1RNG7D; Initial Catalog=EFCodeFirstDB; user id=sa; password=1;")
        {
            Console.WriteLine($"Uygulama Bağlantı Yolu " +
                              $": {Database.Connection.ConnectionString} ");
            
        }
    }
}
