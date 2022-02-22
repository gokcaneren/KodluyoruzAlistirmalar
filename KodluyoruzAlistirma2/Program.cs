using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayı:");
            int s2= Convert.ToInt32(Console.ReadLine());
            int result = s1 + s2;
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", s1, s2, result);


            Console.ReadKey();
        }
    }
}
