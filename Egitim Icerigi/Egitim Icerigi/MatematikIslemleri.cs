using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class MatematikIslemleri
    {
        public static double UstAlma(double taban,double kuvvet)
        {
            double s = 1;
            for (int i = 0; i < kuvvet; i++)
                s *= taban;
            return s;
        }
        public static int[] AsalCarpanlar(int sayi)
        {
            string carpanListesi = "";
            int sayi2 = sayi;
            int[] carpanlar_listesi;
            int i = 2;
            int a = 0;
            while (sayi2 > 1)
            {
                if (sayi2 % i == 0)
                {
                    sayi2 /= i;
                    a++;
                }
                else
                    i++;
                
            }
            int x=0;
            carpanlar_listesi = new int[a];
            for (i = 2; i <a; i++)
            {
                if (sayi % i == 0)
                {
                    sayi /= i;
                    x = i;
                    carpanlar_listesi[i] = x;
                }
                
            }
            
            return carpanlar_listesi;
        }
    }
}
