using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzAlistirma7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           + "abcçdefgğhiıjklmnoöprsştuüvyz";

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Yukarıdaki ifadede toplam {0} tane harf vardır.", sayac);
            Console.ReadLine();
        }
    }
}
