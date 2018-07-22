using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EntityFrameworkRepositoryPattern.Repository;

namespace Udemy.EntityFrameworkRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //RepositoryBase<Personeller> PersonelContext=new RepositoryBase<Personeller>();

            //Guid _personelId = Guid.NewGuid();

            //PersonelContext.CUDOperation(new Personeller()
            //{
            //    PersonelID = _personelId,
            //    Isim = "Berkay Yalçın",
            //    Email = "berkayyalcin7@icloud.com"
            //},EntityState.Added);

            //PersonelContext.SaveChange();

            //Personeller guncellenecekPersonel = PersonelContext.Find(_personelId);

            //guncellenecekPersonel.Isim = "Dante";

            //PersonelContext.SaveChange();

            //Personeller silinecekPersonel = PersonelContext.Find(_personelId);
            //PersonelContext.CUDOperation(silinecekPersonel,EntityState.Deleted);

            //PersonelContext.SaveChange();

            PersonelRepository RepoPersonel=new PersonelRepository();
            RepoPersonel.ApiPersonelBildir();

        }
    }
}
