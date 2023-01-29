using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class MutlakDeger
    {
        public static int MutlakIslem(int n)
        {
            return n > 0 ? n : n * -1;
        }
        public static void Fonk()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (TPD1Sayi.Tekmi(n))
                Console.WriteLine("|{0}|={1} ", n,MutlakIslem(n));
            Console.Read();
        }
    }
}
