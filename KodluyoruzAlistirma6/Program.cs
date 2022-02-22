using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlistirma6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen kilonuzu giriniz:");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen boyunuzu giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());

            double vki = kilo / (boy * boy);
            if (vki<=18.4)
            {
                Console.WriteLine("{0} Zayıf",vki);
            }
            else if (vki>=18.5 && vki<=24.9)
            {
                Console.WriteLine("{0} Normal", vki);
            }
            else if (vki>=25 && vki<=29.9)
            {
                Console.WriteLine("{0} Fazla Kilolu", vki);
            }
            else if (vki>=30 && vki<=34.9)
            {
                Console.WriteLine("{0} Şişman(Obez) I.Sınıf", vki);
            }
            else if (vki>=35 && vki <= 44.9)
            {
                Console.WriteLine("{0} Şişman(Obez) II.Sınıf", vki);
            }
            else if (vki>=45)
            {
                Console.WriteLine("{0} Aşırı Şişman(Aşırı Obez) III.Sınıf", vki);
            }

            Console.ReadKey();
        }
    }
}
