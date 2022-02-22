using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAdSoyad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınız:");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Merhaba {0} {1}", ad, soyad);




            Console.ReadKey();
        }
    }
}
