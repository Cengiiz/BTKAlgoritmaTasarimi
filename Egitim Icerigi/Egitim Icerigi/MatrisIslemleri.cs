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
        



    }
}
