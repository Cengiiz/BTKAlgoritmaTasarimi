using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class NeKadarToplam
    {
        public static void Fonk()
        {
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donguyle {0}",NKadarToplam(n1));
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Formulle {0}", NKadarFormulleToplam(n2));
        }
        public static int NKadarToplam(int n) 
        {
            int toplam = 0;
            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }
            return toplam;
        }
        public static int NKadarFormulleToplam(int n)
        {
            return n * (n + 1) / 2;
        }
        public static int NKadarTekToplam(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i%2==1)
                    toplam += i;
            }
            return toplam;
        }
        public static int NKadarTekAlernatiflToplam(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i+=2)
                    toplam += i;
            return toplam;
        }
        public static int NKadarTekFormulToplam(int n)
        {
            int toplam = 0;
            n++;
            n /= 2;
            return n*n;
        }
        public static int NKadarCiftToplam(int n)
        {
            int toplam = 0;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                    toplam += i;
            }
            return toplam;
        }
        public static int NKadarCiftAlernatiflToplam(int n)
        {
            int toplam = 0;
            for (int i = 2; i <= n; i += 2)
                toplam += i;
            return toplam;
        }
        public static int NKadarCiftFormulToplam(int n)
        {
            n = n / 2;
            return n * (n+1);
        }
        public static int BelirliAralikCiftToplam(int n,int f)
        {
            int t1=NKadarFormulleToplam(n);
            int t2 = NKadarFormulleToplam(f-2);
            return t1 - t2;
        }

    }
}
