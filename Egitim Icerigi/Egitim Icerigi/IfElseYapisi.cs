using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class IfElseYapisi
    {
        /// <summary>
        /// if else yapisinin and or yapisinin kullanimi
        /// </summary>
        public static void Fonk()
        {
            Console.WriteLine("-----besinci ders uygulamasi-----");
            Console.WriteLine("Bir karakter giriniz:");
            char ch = (char)Console.Read();
            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Girilen karakter buyuk bir karakterdir.");
            }
            else if(Char.IsLower(ch))
            {
                Console.WriteLine("Girilen karakter kucuk bir karakterdir.");

            }
            else  if(Char.IsDigit(ch))
            {
                Console.WriteLine("Girilen karakter sayidir.");
            }
            else
            {
                Console.WriteLine("Karakter alfanumerik bir ifade degildir");
            }

            bool result = true;
            if (!result)
            {
                Console.WriteLine("Sonuc 1");
            }
            else
            {
                Console.WriteLine("Sonuc 2");
            }

            int m = 9;
            int n = 7;
            int p = 5;

            if (m>=n&&m>=p)
            {
                Console.WriteLine("En buyuk m");
            }
            if (m>n&&!(p>m))
            {
                Console.WriteLine("En buyuk m");
            }
            if (m>n||m>p)
            {
                Console.WriteLine("m en kucuk degil!");
            }
            m = 4;
            if (!(m>=n||m>p))
            {
                Console.WriteLine("m artik en kucuk");
            }


            Console.Read();





        }
    }
}
