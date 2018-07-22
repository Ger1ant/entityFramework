using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EntityFramework_DataAnnotations.Context;

namespace Udemy.EntityFramework_DataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EfContext efc = new EfContext())
            {
                Console.WriteLine("Finish");
            }
        }
    }
}
