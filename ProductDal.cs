using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EntityFrameworkDemo;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            //using : Blok bittiği anda nesneyi zorla bellekten atar 
            //Metod bitmeden bellekten temizler
            using (EtradeContext context = new EtradeContext())
            {
                //Entity Framework'de veri tabanındaki Tabloya Erişim
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            //using : Blok bittiği anda nesneyi zorla bellekten atar 
            //Metod bitmeden bellekten temizler
            using (EtradeContext context = new EtradeContext())
            {
                // Veritabanından Where koşulu atıyor
                // aranan isimlerdeki nesneleri listeliyor
                //Harf duyarlılığını kaldırmak için Name ve Anahtar değerlerini ToLower ile küçültebiliriz.
                return context.Products.Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            //using : Blok bittiği anda nesneyi zorla bellekten atar 
            //Metod bitmeden bellekten temizler
            using (EtradeContext context = new EtradeContext())
            {
                //Veri Tabanına SQL sorgusunu Atıyor
                return context.Products.Where(p=>p.UnitPrice>=price).ToList();
            }
        }

        // Sadece 1 eleman getireceği için Liste Döndürmez !!!
        public Product GetById(int id)
        {
            //using : Blok bittiği anda nesneyi zorla bellekten atar 
            //Metod bitmeden bellekten temizler
            using (EtradeContext context = new EtradeContext())
            {
                //Veri Tabanına SQL sorgusunu Atıyor
                //Sadece 1 eleman çekmek için FirstOrDefault

                //SingleOrDefault 1 den fazla aynı türden Kayıt Var ise
                // Hata VEriyor
                var result= context.Products.FirstOrDefault(p=>p.Id==id);
                return result;
            }
        }

        public void Add(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                //Entity Framework'de Ekleme İşlemi
                context.Products.Add(product);
                context.SaveChanges();
            }

        }

        public void Update(Product product)
        {
            using (EtradeContext context=new EtradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {

                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
