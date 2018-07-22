using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities.FluentMap
{
    class UrunFiyatMap:EntityTypeConfiguration<UrunFiyat>
    {

        public UrunFiyatMap()
        {
            #region PK
            this.HasKey(I => I.ID);
            #endregion

            #region Property
            this.Property(I => I.ID)
                .HasColumnName("ID")
                .HasColumnOrder(0);
            #endregion
        }
    }
}
