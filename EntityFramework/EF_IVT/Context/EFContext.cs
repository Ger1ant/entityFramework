using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EF_IVT.Entities;
using Udemy.EF_IVT.Entities.FluentMap;

namespace Udemy.EF_IVT.Context
{
    public class EFContext:DbContext
    {
        public DbSet<Kampanya> Kampanyalar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<UrunFiyat> UrunFiyatlar { get; set; }

        //AppConfig'deki ConnectionString name Baglantim'i base olarak çağırıyoruz.
        public EFContext():base("Baglantim")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new KampanyaMap());
            modelBuilder.Configurations.Add(new SiparisMap());

        }
    }
}
