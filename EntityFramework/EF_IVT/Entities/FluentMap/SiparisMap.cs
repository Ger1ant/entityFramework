using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities.FluentMap
{
    public class SiparisMap:EntityTypeConfiguration<Siparis>
    {
        public SiparisMap()
        {
            #region PK
            this.HasKey(I => I.ID);
            #endregion

            #region Property
            this.Property(I => I.ID)
                .HasColumnName("ID")
                .HasColumnOrder(0);
            #endregion

            #region Relationship
            //1 den çoğa ilişkide ürün kaydı olmak zorunda 1 Den Fazla Siparis olabilir ve Foreign Key Olarak UrunID ile bağlantı sağlanacaktır.
            this.HasRequired(I => I.urun)
                .WithMany(I => I.Siparisler)
                .HasForeignKey(I => I.UrunID);
            #endregion

            #region StoreProcedure
            //Mapping İle Insert,Delete,Update işlemlerini yaptı
            this.MapToStoredProcedures();


            #endregion

        }

    }
}
