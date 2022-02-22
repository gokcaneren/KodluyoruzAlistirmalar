using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlistirma5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi>=0 && sayi<=100)
            {
                Console.WriteLine("Sayı 0 ve 100 arasındadır!");
            }
            else
            {
                Console.WriteLine("Sayı 100`den büyüktür!");
            }

            Console.ReadLine();
        }
    }
}
