using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class AlanCevre
    {
        public const double pi = 3.14;
        /// <summary>
        /// Cevre hesaplar
        /// </summary>
        /// <param name="r">Yaricap</param>
        /// <returns>Cevre degeridir</returns>
        public static double Cevresi(double r)
        {
            return 2*pi*r;
        }
        /// <summary>
        /// Alan hesaplar
        /// </summary>
        /// <param name="r">Yaricap</param>
        /// <returns>Alan degeridir</returns>
        public static double Alan(double r)
        {
            return pi*r*r;
        }
        /// <summary>
        /// Alanini hesaplar
        /// </summary>
        /// <param name="r">Yaricap</param>
        /// <param name="aci">Gordugu aci</param>
        /// <returns>Alan degeridir</returns>
        public static double Alan(double r,int aci)
        {
            return pi * r * r*aci/360;
        }
        public static void Fonk()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Cevresi(r));
        }

    }
}
