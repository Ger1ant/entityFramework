namespace Udemy.EntityFrameworkRepositoryPattern
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFContext : DbContext
    {
        public EFContext() : base("name=EFContext")
        {
           
        }

        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<SistemKullanici> SistemKullanici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
