using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkDemo
{
    public class EtradeContext:DbContext
    {
        //en Temel yapılandırma

        //Tablolarda Products diye bir şey Arıyor !!
        //Context Oluşturuldu
        public DbSet<Product> Products { get; set; }


    }
}
