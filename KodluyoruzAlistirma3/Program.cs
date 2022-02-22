using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlistirma3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kısa Kenar:");
            double kisaKenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Uzun Kenar:");
            double uzunKenar = Convert.ToDouble(Console.ReadLine());
            double alan = kisaKenar * uzunKenar;
            double cevre = 2 * (kisaKenar + uzunKenar);
            Console.WriteLine("Alan:{0}", alan);
            Console.WriteLine("Çevre:{0}", cevre);


            Console.ReadKey();
        }
    }
}
