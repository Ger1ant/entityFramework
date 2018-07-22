using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EF_IVT.Context;

namespace Udemy.EF_IVT
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFContext efc = new EFContext())
            {
                efc.Database.Create();
            }
            Console.WriteLine("İşlem Tamamlandı");
            Console.ReadLine();

        }
    }
}
