using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EntityFramework_DataAnnotations.Entities;

namespace Udemy.EntityFramework_DataAnnotations.Context
{

    
    public class EfContext:DbContext
    {
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public EfContext():base ("Data Source=DESKTOP-E1RNG7D; Initial Catalog=DataAnnotations; user id=sa; password=1;")
        {
            if(!Database.Exists())
            {
                Database.Create();

            }
        }
    }
}
