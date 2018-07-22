using EntityFrameworkFluentApiExample.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFluentApiExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFContext efc = new EFContext())
            {
                if(!efc.Database.Exists())
                {
                    efc.Database.Create();
                }
                       
                
            }
            Console.WriteLine("İşlem Tamam");

            Console.ReadLine();
        }
    }
}
