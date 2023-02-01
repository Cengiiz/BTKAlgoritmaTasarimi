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

        public static int EKOK(int a,int b)
        {

            int a2 = a;
            int b2 = b;
            int i = 2;
            int k = 0;
            while (a2>1||b2>1)
            {
                if (a2 % i == 0 && b2 % i == 0)
                {
                    a2 /= i;
                    b2/=i;
                    k++;
                }
                else if (a2 % i == 0)
                {
                    a2 /= i;
                    k++;

                }
                else if (b2 % i == 0)
                {
                    b2 /= i;
                    k++;
                }
                else
                {
                    i++;
                }
            }
            int[] bolum=new int[k];
            i = 2;
            k = 0;
            while (a > 1 || b > 1)
            {
                if(a % i == 0 && b % i == 0)
                {
                    a /= i;
                    b /= i;
                    bolum[k] = i;
                    k++;
                }
                else if (a % i == 0)
                {
                    a /= i;
                    bolum[k] = i;
                    k++;

                }
                else if (b % i == 0)
                {
                    b /= i;
                    bolum[k] = i;
                    k++;
                }
                else
                {
                    i++;
                }
            }
            int ekok = 1;
            for ( i = 0; i < bolum.Length; i++)
            {
                ekok *= bolum[i];
            }


            return ekok;
        }

        public static int EBOB(int a,int b)
        {
            int a2 = a;
            int b2 = b;
            int i = 2;
            int k = 0;
            while (a2 > 1 || b2 > 1)
            {
                if (a2 % i == 0 && b2 % i == 0)
                {
                    a2 /= i;
                    b2 /= i;
                    k++;
                }
                else if (a2 % i == 0)
                {
                    a2 /= i;

                }
                else if (b2 % i == 0)
                {
                    b2 /= i;
                }
                else
                {
                    i++;
                }
            }
            int[] bolum = new int[k];
            i = 2;
            k = 0;
            while (a > 1 || b > 1)
            {
                if (a % i == 0 && b % i == 0)
                {
                    a /= i;
                    b /= i;
                    bolum[k] = i;
                    k++;
                }
                else if (a % i == 0)
                {
                    a /= i;

                }
                else if (b % i == 0)
                {
                    b /= i;
                }
                else
                {
                    i++;
                }
            }
            int ebob = 1;
            bolum = bolum.Distinct().ToArray();
            for (i = 0; i < bolum.Length; i++)
            {
                ebob *= bolum[i];
            }


            return ebob;
        }


    }
}
