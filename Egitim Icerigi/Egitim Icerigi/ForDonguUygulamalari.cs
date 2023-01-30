using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class ForDonguUygulamalari
    {
        public static void Fonk()
        {

        }
        public static void BirdenYuzKare()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i*i);
            }
        }
        public static void LimitYuzTekCiftToplam(int limit)
        {
            int ctoplam = 0, ttoplam = 0;
            for (int i = 0; i < limit; i++)
            {
                if (i%2==0)
                {
                    
                    ctoplam += i;
                }
                if (i % 2 == 1)
                {

                    ttoplam += i;
                }
            }
            Console.WriteLine("{0} {1}",ctoplam,ttoplam);
        }

        public static void BindenSifirBesKat()
        {
            int adet = 0;
            for (int i = 1000; i > 0; i--)
            {   
                if (i%5 == 0)
                {
                    Console.Write("{0,5}", i);
                    adet++;
                }
            }
            Console.WriteLine(adet);
            Console.ReadLine();
        }

        public static void CarpimTablosu()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine("{0}*{1}={2}",i,j,i*j);
                }
            }
            Console.ReadLine();
        }
    }
}
