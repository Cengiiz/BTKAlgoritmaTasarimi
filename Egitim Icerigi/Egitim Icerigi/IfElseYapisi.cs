using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class IfElseYapisi
    {
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
            Console.Read();
        }
    }
}
