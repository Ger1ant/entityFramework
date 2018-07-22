using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities.FluentMap
{
    public class UrunMap:EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            #region PK
            this.HasKey(I => I.ID);
            #endregion

            #region Property
            this.Property(I => I.ID)
                .HasColumnOrder(0);

            this.Property(I => I.Tanim)
                .HasColumnName("Tanim")
                .HasColumnOrder(1)
                .HasColumnType("nvarchar")
                .IsRequired();



            this.Property(I => I.Kod)
                .HasColumnName("UrunKod")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar")
                .HasMaxLength(15)
                .IsRequired();

            this.Property(I => I.Aciklama)
                .HasColumnName("Aciklama")
                .HasColumnOrder(3)
                .HasColumnType("ntext")
                .IsOptional();

            #endregion

            #region Relations(İlişkisel)
            //Urun Doldurulurken urunFiyat doldurulmak zorunda değil ama Fiyat oluşturduğumuzda ürüne bağlamamız
            //doldurmamız gerekiyor...
            this.HasOptional(I => I.urunFiyat)
                .WithRequired(I => I.urun);


            //N-N 
            //N-N ilişkilerde Map'leme işlemi yapıyoruz ve Yeni tablo oluşturuyoruz
            this.HasMany<Kampanya>(I => I.Kampanyalar)
                .WithMany(I => I.urunler)
                .Map(I =>
                {
                    //ürünü temsil etmekte
                    I.MapLeftKey("UrunKeyID");
                    //Kampanya 
                    I.MapRightKey("KampanyaKeyID");
                    //Değerleri tabloda tutacağız
                    I.ToTable("UrunToKampanya");
                });
            #endregion

            #region StoreProcedure
            //Mapping İle Insert,Delete,Update işlemlerini yaptı
            this.MapToStoredProcedures();


            #endregion

        }

    }
}
