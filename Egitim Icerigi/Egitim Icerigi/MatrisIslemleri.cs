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
            var deneme = Izi(Olustur());
        }
        public static int[,] Olustur(int satir = 3, int sutun = 3, int min = 1, int max = 9)
        {
            int[,] matris = new int[satir, sutun];

            for (int i = 0; i < sutun; i++)
                for (int j = 0; j < sutun; j++)
                    matris[i, j] = new Random().Next(min, max);


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
        

    }
}
