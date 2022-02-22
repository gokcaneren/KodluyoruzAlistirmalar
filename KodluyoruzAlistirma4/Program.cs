using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlistirma4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi%2==0)
            {
                Console.WriteLine("Çift Sayı");
            }
            else 
            {
                Console.WriteLine("Tek Sayı");
            }

            Console.ReadKey();
        }
    }
}
