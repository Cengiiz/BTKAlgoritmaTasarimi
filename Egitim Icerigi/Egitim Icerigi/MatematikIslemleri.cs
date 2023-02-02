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
            
            var deneme = MatematikIslemleri.BinaryToDecimal("11010001000111010010101011000101111101");

            Console.Write("{0,5}", deneme);

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
        public static long Fakt(long sayi)
        {
            long fakt = 1;
            while (sayi>0)
            {
                fakt *= sayi;
                sayi--;
            }
            return fakt;
        }
        public static double AralikliFakt(int sayi1,int sayi2)
        {
            long t = 0;
            int k = sayi1 > sayi2 ? sayi2 : sayi1;
            int b = sayi1 > sayi2 ? sayi1 : sayi2;
            for (int i = k; i < b+1; i++)
                t += Fakt(i);
            return t/((b-k)+1);
        }

        public static int[] StringToIntArr(string str)
        {
            string[] a = str.Split(',');
            int[] sayilar = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                sayilar[i] =Convert.ToInt32(a[i]);
            }


            return sayilar;
        }
        public static double BinaryToDecimal(string str)
        {
            string[] newStr = new string[str.Length];
            int i = 0;
            int a = 0;
            for (i = str.Length-1; i >=0 ; i--)
            {
                newStr[a] = str[i].ToString();
                a++;
            }
            double dcml = 0;
            for (i = 0; i < str.Length; i++)
            {
                dcml += (Convert.ToInt16(newStr[i]) * Math.Pow(2, i));
            }
            return dcml;
        }

    }
}
