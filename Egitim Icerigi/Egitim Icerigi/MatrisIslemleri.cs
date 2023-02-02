using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class MatrisIslemleri
    {
        public static void Fonk( )
        {
            var deneme = Olustur(3,4);
            Yazdir(deneme);
            var x=YenidenSekillendir(deneme,2,6);



        }
        public static int[,] Olustur(int satir = 3, int sutun = 3, int min = 1, int max = 9)
        {
            int[,] matris = new int[satir, sutun];
            int a = 0;
            for (int i = 0; i < satir; i++)
                for (int j = 0; j < sutun; j++)
                    matris[i, j] = a++;//new Random().Next(min, max);


            return matris;
        }

        public static void Yazdir(int[,] matris)
        {

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j]);

                }
                Console.WriteLine();
            }
        }
        public static void Yazdir(int[] matris)
        {

            for (int i = 0; i < matris.Length; i++)
            {
                    Console.Write("{0},",matris[i]);
            }
        }

        public static int[,] SifirMatrisi(int satir = 3, int sutun = 3)
        {
            int[,] matris = Olustur(satir, sutun, 0, 0);

            return matris;
        }
        public static int[,] BirlerMatrisi(int satir = 3, int sutun = 3)
        {
            int[,] matris = Olustur(satir, sutun, 1, 1);

            return matris;
        }
        public static int[,] KosegenMatris(int boyut = 3, int min = 1, int max = 9)
        {
            int[,] matris = SifirMatrisi(boyut, boyut);
            for (int i = 0; i < boyut; i++)
                matris[i, i] = new Random().Next(min, max);
            return matris;
        }
        public static int[,] SkalerMatris(int boyut = 3, int skaler = 1)
        {
            int x = skaler;
            int[,] matris = SifirMatrisi(boyut, boyut);
            for (int i = 0; i < boyut; i++)
                matris[i, i] = x;
            return matris;
        }
        public static int[,] SkalerMatris(int boyut = 3, int min = 1, int max = 9)
        {
            int x = new Random().Next(min, max);
            int[,] matris = SifirMatrisi(boyut, boyut);
            for (int i = 0; i < boyut; i++)
                matris[i, i] = x;
            return matris;
        }
        public static bool KareMatrisMi(int[,] matris)
        {
            return matris.GetLength(0) == matris.GetLength(1) ? true : false;
        }
        public static int[,] BirimMatrisOlustur(int boyut = 3)
        {
            return SkalerMatris(boyut, 1);
        }
        public static bool BirimMatrisMi(int[,] matris)
        {
            bool kose = false;
            bool diger = false;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        kose = (matris[i, j] == 1) ? true : false;
                    }
                    else
                    {
                        diger = (matris[i, j] == 0) ? true : false;
                    }
                }
            }
            return (kose == true && diger == true ? true : false);
        }
        public static int[] DiyagonelElemanlar(int[,] matris)
        {
            int[] arr = new int[matris.GetLength(0)];
            for (int i = 0; i < matris.GetLength(0); i++)
                arr[i] = matris[i, i];
            return arr;
        }
        public static int Izi(int[,] matris)
        {
            int toplam = 0;
            if (KareMatrisMi(matris))
            {
                int[] diyagonel = DiyagonelElemanlar(matris);
                for (int i = 0; i < diyagonel.Length; i++)
                    toplam += diyagonel[i];
                return toplam;
            }
            return 0;
        }
        public static int[,] Transpoz(int[,] matris)
        {
            int[,] tmp = new int[matris.GetLength(1), matris.GetLength(0)];
            for (int i = 0; i < matris.GetLength(0); i++)
                for (int j = 0; j < matris.GetLength(0); j++)
                    tmp[j, i] = matris[i, j];
            return tmp;
        }

        public static int[] MatristoArray(int[,] matris)
        {
            int[] degerler = new int[matris.Length];
            int sayac = 0;
            for (int i = 0; i < matris.GetLength(0); i++)
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    degerler[sayac] = matris[i,j];
                    sayac++;
                }

            Yazdir(degerler);
            return new int[1];
        }
        public static int[,] YenidenSekillendir(int[,] matris, int yeniSatir, int yeniSutun)
        {
            int[] degerler = MatristoArray(matris);
            int[,] newMatrix = new int[yeniSatir, yeniSutun];
            int index = 0;
            for (int i = 0; i < yeniSatir; i++)
                for (int j = 0; j < yeniSutun; j++)
                {
                    newMatrix[i, j] = degerler[index];
                    index++;
                }

            Yazdir(newMatrix);
            return matris;
        }
    }
}
