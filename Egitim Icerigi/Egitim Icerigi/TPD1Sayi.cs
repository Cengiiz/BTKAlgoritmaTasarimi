using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    public class TPD1Sayi
    {
        /// <summary>
        /// Parametre olarak aldigi sayinin tek olup olmadigini kontrol eder
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Tek ise true aksi durumda false donus yapar</returns>
        public static bool Tekmi(int n)
        {
            return n % 2 == 1 ? true : false;
        }
        /// <summary>
        /// Parametre olarak aldigi sayinin cift olup olmadigini kontrol eder
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool Ciftmi(int n)
        {
            return n % 2 == 0 ? true : false;
        }
        public static void Fonk()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (TPD1Sayi.Tekmi(n))
                Console.WriteLine("Girilen sayi={0} tek bir sayidir", n);
            if (TPD1Sayi.Ciftmi(n))
                Console.WriteLine("Girilen sayi={0} cift bir sayidir", n);
            Console.Read();

        }
    }
}
