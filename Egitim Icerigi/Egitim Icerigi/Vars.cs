using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class Vars
    {
        public static void Fonk()
        {
            int max, min;
            max = System.Int16.MaxValue;
            min = System.Int16.MinValue;

            int max32 = System.Int32.MaxValue;
            int min32 = System.Int32.MinValue;

            byte minbyte = System.Byte.MinValue;
            byte maxbyte = System.Byte.MaxValue;

            int sayi = 23;
            sayi = sayi * 2;
            //Console.WriteLine(sayi);

            Console.WriteLine("-----Ilk ders uygulamasi-----");
            Console.WriteLine("Byte -> Min:{0} \t Max:{1}", minbyte, maxbyte);
            Console.WriteLine("Int16 -> Min:{0} \t Max:{1}", min, max);
            Console.WriteLine("Int32 -> Min:{0} \t Max:{1}", min32, max32);
            Console.Read();
        }
    }
}
