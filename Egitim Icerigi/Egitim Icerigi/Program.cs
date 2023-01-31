using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] deneme = MatematikIslemleri.AsalCarpanlar(60);
            for (int i = 0; i < deneme.Length; i++)
            {
                Console.Write("{0,5}", deneme[i]);
            }
            Console.ReadLine();
        }
    }
}
