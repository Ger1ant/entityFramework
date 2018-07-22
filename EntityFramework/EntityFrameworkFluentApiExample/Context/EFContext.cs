using EntityFrameworkFluentApiExample.Entities;
using EntityFrameworkFluentApiExample.Entities.FluentApi;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFluentApiExample.Context
{
    public class EFContext:DbContext
    {
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Personel> Personeller { get; set; }

        public EFContext() : base("Data Source=DESKTOP-E1RNG7D; Initial Catalog=EfContextFluentApi; User id=sa; Password=1;")
        {
            Console.WriteLine($"DB Oluşturulduğu Yer :  " +
                             $": {Database.Connection.ConnectionString} ");
        }

        //Fluent Api kodları buraya da yazılabilir
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Firma>().ToTable()
        //}

        //Ayarların EF 'nin görmesi için  OnModelCreating'i override ediyoruz.
        //FirmaMap'i örnekleyerek Etkinleştirmiş Oluyoruz
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FirmaMap());
            modelBuilder.Configurations.Add(new PersonelMap());
        }
    }
}
