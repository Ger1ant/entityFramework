using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EntityFrameworkRepositoryPattern.Repository
{
    public class PersonelRepository:RepositoryBase<Personeller>
    {
        public void ApiPersonelBildir(Personeller P)
        {
            //Parametre olarak gelen Personel değerini api olarak belirtmiş olduğumuz noktaya
            //bildirir
        }
    }
}
