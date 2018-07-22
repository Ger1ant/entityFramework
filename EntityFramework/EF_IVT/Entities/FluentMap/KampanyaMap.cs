using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities.FluentMap
{
    class KampanyaMap:EntityTypeConfiguration<Kampanya>
    {
        public KampanyaMap()
        {
            #region PK
            this.HasKey(I => I.ID);
            #endregion

            #region Property
            this.Property(I => I.ID)
                .HasColumnName("ID")
                .HasColumnOrder(0);

            this.Property(I => I.Tanim)
                .HasColumnName("Tanim")
                .HasColumnOrder(1)
                .HasMaxLength(255)
                .IsRequired();

            this.Property(I => I.Aciklama)
                .HasColumnName("Aciklama")
                .HasColumnOrder(2)
                .IsOptional()
                .HasColumnType("ntext");
            #endregion

            #region StoreProcedure
            //Mapping İle Insert,Delete,Update işlemlerini yaptı
            this.MapToStoredProcedures();


            #endregion


        }


    }
}
