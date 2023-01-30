using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class Cember
    {
        public const double pi = 3.14;
        public static double Cevresi(double r)
        {
            return 2*pi*r;
        }
        public static void Fonk()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Cevresi(r));
        }
    }
}
