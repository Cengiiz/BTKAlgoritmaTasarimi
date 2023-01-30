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
    }
}
