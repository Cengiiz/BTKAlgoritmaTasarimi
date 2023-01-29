using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class RakamlariTopla
    {
        public static int Islem(int n)
        {
            int toplam = 0,rakam=0;
            while (n>0)
            {
                rakam = n % 10;
                toplam += rakam;
                n/= 10;
            }

            return toplam;
        }
        public static void Fonk()
        {
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0}", Islem(x));
            Console.Read();
        }
    }
}
