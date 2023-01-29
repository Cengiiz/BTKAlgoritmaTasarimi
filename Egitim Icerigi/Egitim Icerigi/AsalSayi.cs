using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class AsalSayi
    {
        public static bool Asalmi(int n)
        {
            if (n<=1)
            {
                Console.WriteLine("En kucuk asal sayi 2'dir.");
                return false;
            }
            bool kontrol = true;
            for (int i = 2; i < n; i++)
            {
                if (n%i==0)
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;
        }
        public static void Fonk()
        {
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0}", Asalmi(x) ? "Sayi asaldir":"Sayisi asal degildir");
            Console.Read();
        }
    }
}
