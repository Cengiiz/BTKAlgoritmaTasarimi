using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class MatematikIslemleri
    {
        public static void Fonk()
        {
            int[] deneme = MatematikIslemleri.AsalCarpanlar(60);
            for (int i = 0; i < deneme.Length; i++)
            {
                Console.Write("{0,5}", deneme[i]);
            }
            Console.WriteLine("");
            Console.WriteLine(MatematikIslemleri.AsalCarpanlarToplami(60));
            Console.WriteLine(MatematikIslemleri.AsalCarpanlarCarpimi(60));
            Console.ReadLine();
        }
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
            int index = 0;
            int k = 2;
            carpanlar_listesi = new int[a];
            while(sayi>1)
            {
                if (sayi % k == 0)
                {
                    sayi /= k;
                    carpanlar_listesi[index] = k;
                    index++;
                }
                else
                    k++;
                
            }
            carpanlar_listesi = carpanlar_listesi.Distinct().ToArray();
            return carpanlar_listesi;
        }

        public static int AsalCarpanlarToplami(int sayi)
        {
            int toplam = 0;
            int[] asalcarpanlar=AsalCarpanlar(sayi);
            for (int i = 0; i < asalcarpanlar.Length; i++)
            {
                toplam += asalcarpanlar[i];
            }
            return toplam;
        }
        public static int AsalCarpanlarCarpimi(int sayi)
        {
            int carpim = 1;
            int[] asalcarpanlar = AsalCarpanlar(sayi);
            for (int i = 0; i < asalcarpanlar.Length; i++)
            {
                carpim *= asalcarpanlar[i];
            }
            return carpim;
        }
    }
}
