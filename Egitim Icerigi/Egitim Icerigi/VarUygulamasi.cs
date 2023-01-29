using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class VarUygulamasi
    {
        public static void Fonk()
        {
            Console.WriteLine("-----dorduncu ders uygulamasi-----");
            var x = 23;//implicitly typed
            int y = 23;//explicitly typed

            string[] meyveler = { "elma", "armut", "muz", "uzum", "seftali" };

            var meyve = from m in meyveler
                        where m[0] == 'a'
                        select m;
            foreach (string m in meyve)
                Console.WriteLine(m);
            
            

            Console.Read();


        }
    }
}
