using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class Diziler
    {
        public static void Fonk()
        {

        }
        public static void DiziOlustur(int adet)
        {
            int[] sayilar = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);
            }
        }
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            foreach (var item in dizi)
            {
                if (eb < item)
                    eb = item;
            }
            return eb;
        }
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            foreach (var item in dizi)
            {
                if (ek < item)
                    ek = item;
            }
            return ek;
        }
        public static double AritmetikOrtalama(int[] dizi)
        {
            int toplam = 0;
            foreach (var item in dizi)
                toplam+= item;  
            return toplam / dizi.Length;
        }
        public static double StandartSapma(int[] dizi)
        {
            double aritmetik = AritmetikOrtalama(dizi);
            double toplam = 0;

            foreach (var item in dizi)
            {
                toplam+= Math.Pow(item-aritmetik,2);
            }
            return Math.Sqrt(toplam/(dizi.Length-1));

        }
        public static int TekSayilarinSayisi(int[] dizi)
        {
            int adet=0;
            foreach (var item in dizi)
            {
                if (item%2==1)
                {
                    adet++;
                }
            }
            return adet;
        }
        public static int CiftSayilarinSayisi(int[] dizi)
        {
            int adet = 0;
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    adet++;
                }
            }
            return adet;
        }

        public static int[] TekDiziOlustur(int[] dizi)
        {
            int[] tekDizi=new int[TekSayilarinSayisi(dizi)];
            int x = 0;
            foreach (var item in dizi)
            {
                if (item%2==1)
                {
                    tekDizi[x] = item;
                    x++;
                }
            }
            return tekDizi;
        }
        public static int[] CiftDiziOlustur(int[] dizi)
        {
            int[] ciftDizi = new int[CiftSayilarinSayisi(dizi)];
            int x = 0;
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    ciftDizi[x] = item;
                    x++;
                }
            }
            return ciftDizi;
        }

        public static void Yazdir(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}
