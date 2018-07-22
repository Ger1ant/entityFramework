using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EntityFramework.Contexts;
using Udemy.EntityFramework.Entities;
using Udemy.EntityFramework.Operasyon;

namespace Udemy.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            #region DB Ayar İşlemleri
            // 01 : EntityFramework ile DB oluşturma
            //Execute.DbOlustur(); //

            // 02: Otomatik olarak oluşan DB ' nin Connection String Bilgisi
            //Execute.DbBaglantiYolu();

            // 03 : Db ' nin olup olmadığının kontrolü
            //Execute.VarlikKontrol();


            //04 : 
            //Execute.DbSil();

            //Execute.DatabaseOlustur();
            #endregion


            #region C.R.U.D işlemleri
            //Ramde oluşan kayıt
            //Değeri DB ' ye eklemek için Metoda parametre olarak 
            //göndermemiz gerek
            //----------------------------------------------------------------------
            //Kullanici yeniKullanici = new Kullanici();
            //yeniKullanici.KullaniciID = Guid.NewGuid();
            //yeniKullanici.Isim = "Berkay";
            //yeniKullanici.Soyisim = "Yalçın";
            //yeniKullanici.KullaniciAdi = "Xtenc";
            //yeniKullanici.Sifre = "1111";
            //Execute.KullaniciKayitEkle(yeniKullanici);
            //---------------------------------------------------------------------------


            //--------------------------------------------------------------
            //Firma F = new Firma();
            //F.ID = Guid.NewGuid();
            //F.Unvan = "TRLOJ A.Ş";
            //F.Tel1 = "02826589966";
            //F.WebAdresi = "trloj.com";
            //int Sonuc = Execute.FirmaKayitEkle(F);

            //List<Firma> topluFirmaEkleme = new List<Firma>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Firma F = new Firma();
            //    F.ID = Guid.NewGuid();
            //    F.Unvan = "TRLOJ A.Ş -" + i.ToString();
            //    F.Tel1 = "02826589966 -";
            //    F.WebAdresi = "trloj.com";


            //    topluFirmaEkleme.Add(F);
            //}

            //Execute.FirmaKayitlarEkle(topluFirmaEkleme);

            //----------------------------------------

            //Kisi K = new Kisi();

            //K.ID = Guid.NewGuid();
            //K.FirmaID = Guid.Parse("0C9CD174-365C-4FCB-B956-17055A0117C8"); //Sorgulama ile ulaşılacak
            //K.Isim = "Test 1";
            //K.Soyisim = "Testtt";
            //K.dogumTarih = DateTime.Parse("01.01.1990");
            //K.Email = null;
            //K.Telefon = "5389966772";

            //Execute.KisiEkle(K);

            ////---------------------------------------------------------------------------


            #endregion


            #region FakeData Veri Yükleme
            //Firma F = new Firma();
            //Kisi K = new Kisi();
            //for (int i=0; i<10; i++)
            //{

            //    F.ID = Guid.NewGuid();
            //    F.Unvan = FakeData.NameData.GetCompanyName();
            //    F.Tel1 = FakeData.PhoneNumberData.GetPhoneNumber();
            //    F.WebAdresi = $"www.{F.Unvan.ToLower()}.com";
            //    F.Email = $"info@{F.Unvan.ToLower()}.com";
            //    int sonuc= Execute.FirmaKayitEkle(F);

            //    for(int j=0; j<30; j++)
            //    {
            //        K.ID = Guid.NewGuid();
            //        K.Isim = FakeData.NameData.GetFirstName();
            //        K.Soyisim = FakeData.NameData.GetSurname();
            //        K.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
            //        K.dogumTarih = FakeData.DateTimeData.GetDatetime();
            //        K.Email = $"{K.Isim}.{K.Soyisim}@hotmail.com";
            //        K.FirmaID = F.ID;
            //        Execute.KisiEkle(K);
            //    }

            //}
            //Console.WriteLine("Completed ...");
            //Console.ReadLine();







            #endregion


            #region Kayıt Güncelle
            //Execute.KisiGuncelle("Emma", "Buckley");
            #endregion


            #region Kayıt Sil
            //Execute.KisiSil(Guid.Parse("DEBB7627-D6F1-4E40-A9D0-3CDA0A741348"));
            #endregion


            #region Sorgulama Teknikleri

            //Execute.SorgulamaTeknikleri();
            //Execute.IsimsizTipler();
            //Execute.OrderByIsim();
            //Execute.JoinKullanim();
            Execute.TSQLSelect();
            #endregion



            Console.ReadLine();


        }
    }
}
