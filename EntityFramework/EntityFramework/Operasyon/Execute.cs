using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EntityFramework.Contexts;
using Udemy.EntityFramework.Entities;

namespace Udemy.EntityFramework.Operasyon
{
    class Execute
    {
        #region DbSettings
        public static void DbOlustur()
        {
            using (EFCodeFirstContext _efc = new EFCodeFirstContext())
            {
                
                foreach (var item in _efc.Kullanicilar)
                {
                    Console.WriteLine(item.Isim);
                }
            }
        }

        public static void DbBaglantiYolu()
        {
            //Hangi Bağlantıya oluşturduğunu öğrenmek . . .
            using (EFCodeFirstContext EFC=new EFCodeFirstContext())
            {
                //yapıcı metot Using ile tetikleneceğinden Bu bölümde
                //bir şey yapmamıza gerek kalmıyor
                Console.ReadLine();
                Console.WriteLine("Bir tuşa Basınız  ...");
            }
        }

        public static void VarlikKontrol()
        {
            using (EFCodeFirstContext efc=new EFCodeFirstContext())
            {
                //Sql sunucuda verilen server ve DB nin varlığını
                //kontrol ediyor
                bool kontrol = efc.Database.Exists();
                if (kontrol)
                {
                    Console.WriteLine($"Database : {efc.Database.Connection.Database} - SQL sunucu içerisinde kayıtlı");
                }
                else
                {
                    Console.WriteLine("DB kayıtlı değil .... ");
                }
            }
        }

        public static void DbSil()
        {
            using (EFCodeFirstContext efc=new EFCodeFirstContext())
            {
                if (efc.Database.Exists())
                {
                    efc.Database.Delete();
                    Console.WriteLine("SQL Sunucu içerisinden DB silindi ...\nKontrol Ediniz.");
                }
            }
        }

        public static void DatabaseOlustur()
        {
            using (EFCodeFirstContext efc=new EFCodeFirstContext())
            {
                if (!efc.Database.Exists())
                {
                    efc.Database.Create();
                    Console.WriteLine("Database Oluşturma işlemi Tamamlandı ..\nKontrol Ediniz");
                }
            }
        }
        #endregion


        public static int KullaniciKayitEkle(Kullanici K)
        {
            int Sonuc = 0;
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                efc.Kullanicilar.Add(K);
                Sonuc=efc.SaveChanges();

                
            }
            return Sonuc;
        }

        public static int FirmaKayitEkle(Firma F)
        {
            int sonuc = 0;



            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                
                efc.Firmalar.Add(F);
                sonuc = efc.SaveChanges();

            }
            return sonuc;
        }

        //Birden Fazla Kayıt Ekleme List - Generic
        public static int FirmaKayitlarEkle(List<Firma> FList)
        {
            int sonuc = 0;
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {

                efc.Firmalar.AddRange(FList);
                sonuc = efc.SaveChanges();

            }
            return sonuc;

        }

        public static int KisiEkle(Kisi K)
        {
            int sonuc = 0;
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                efc.Kisiler.Add(K);
                sonuc = efc.SaveChanges();
            }
            return sonuc;
        }

        public static void KisiGuncelle(string isim,string soyisim)
        {
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                Kisi BulunanKisi = (from I in efc.Kisiler where I.Isim == "Emma" && I.Soyisim == "Buckley" select I).FirstOrDefault();
                if(BulunanKisi!=null)
                {
                    BulunanKisi.Telefon = "65648949";
                    efc.SaveChanges();
                }

                //Kisi BulunanKisi1 = efc.Kisiler.Find(Guid.Parse("{4E3EF687-CDEB-475A-B9D6-45C4CB796EF1}"));
                // if(BulunanKisi1!=null)
                // {
                //     BulunanKisi1.Telefon = "36549466";
                //     efc.SaveChanges();
                // }



            }


        }

        public static void KisiSil(Guid id)
        {
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                //LINQ ile : 
                //Kisi Silinecek = (from I in efc.Kisiler where I.ID == id select I).FirstOrDefault();


                Kisi Silinecek = efc.Kisiler.Find(Guid.Parse($"{id}"));
               if(Silinecek!=null)
                {
                    efc.Kisiler.Remove(Silinecek);
                    efc.SaveChanges();
                    Console.WriteLine($"{id} : Numaralı Kayıt Silindi ");
                }
               else
                {
                    Console.WriteLine("Kayıt Bulunamadı ...");
                }
            }
        }

        public static void SorgulamaTeknikleri()
        {
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                var Kisilerliste = (from I in efc.Kisiler select I);
                foreach(var item in Kisilerliste)
                {
                    Console.WriteLine($"{item.Isim}");
                }
            }
        }

        public static void IsimsizTipler()
        {
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                var Kisiler1 = (from i in efc.Kisiler where i.Isim.ToLower().Contains("a") select new
                {
                    IsimSoyisim=i.Isim+" "+i.Soyisim
                    
                });
                foreach(var item in Kisiler1)
                {
                    Console.WriteLine($"{item.IsimSoyisim}");
                }

            }
        }

        public static void OrderByIsim()
        {
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                var kisiler = (from I in efc.Kisiler where I.Isim.StartsWith("A") orderby I.Isim ascending select I);
                foreach(var item in kisiler)
                {
                    Console.WriteLine($"{item.Isim}");
                }

                var kisiler2=efc.Kisiler.Where(I=>I.Soyisim.StartsWith("B")).OrderBy(I=>I.Soyisim);
                foreach (var item in kisiler2)
                {
                    Console.WriteLine($"{item.Soyisim}");
                }
            }
        }

        public static void JoinKullanim()
        {
            //select
            //Firmas.Unvan,
            //Kisis.Isim
            // from Kisis
            //inner join Firmas
            //on Kisis.FirmaID = Firmas.ID
            //order by Firmas.Unvan
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                var Personeller = (from F in efc.Firmalar
                                   join K in efc.Kisiler on
                                   F.ID equals K.FirmaID
                                   orderby F.Unvan ascending
                                   select
                                   new
                                   {
                                       FirmaUnvan = F.Unvan,
                                       Isim = K.Isim,
                                       Soyisim = K.Soyisim
                                   });
                foreach(var item in Personeller)
                {
                    Console.WriteLine($"{item.FirmaUnvan } {item.Isim} {item.Soyisim} ");
                }

            }
        }

        
        public static void TSQLSelect()
        {
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                List<Kisi> kisiler = efc.Kisiler.SqlQuery("select * from Kisis where FirmaID=@id", new SqlParameter("@id", Guid.Parse("B7860AED-9974-4BF8-98D7-EEA79D101C87"))).ToList();
                foreach(var item in kisiler)
                {
                    Console.WriteLine(item.Isim + " " + item.Soyisim);
                }
            }
        }
        public static void TSQLInsert()
        {
            using (EFCodeFirstContext efc = new EFCodeFirstContext())
            {
                int kayitSayisi = efc.Database.ExecuteSqlCommand("insert into Kisis values()");

            }
        }

    }
} 
