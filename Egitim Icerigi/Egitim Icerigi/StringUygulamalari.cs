using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class StringUygulamalari
    {
        public static int SesliHarfSayi(string str)
        {
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int adet=0;
            foreach (var item in str)
            {
                if (sesli.Contains(item))
                {
                    adet++;
                }
            }
            return adet;
        }
        public static void Desen1(char c='*',int n=5)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0.5}", new string(c, i));
            }
        }
        public static void Desen2(char c = '!', int n = 5)
        {
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}", new string(c, i));
            }
            Console.Read();
        }
        public static void KarakterSeti(int baslangicIndisi=65,int bitisIndisi=90,int satirkarakterSayisi=5)
        {
            for (int i = baslangicIndisi; i <= bitisIndisi; i++)
            {
                Console.Write("{0}", (char)i);
                if(i%satirkarakterSayisi==0)
                    Console.WriteLine();
            }
        }
        public static void StringHazirFonk(string ifade=" { Afacan } ")
        {
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.Trim().Length);
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('a','e'));

        }

    }
}
