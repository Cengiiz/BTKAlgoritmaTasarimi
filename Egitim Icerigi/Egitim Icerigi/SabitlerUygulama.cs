using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class SabitlerUygulama
    {
        readonly int c1;
        public static void Fonk()
        {
            Console.WriteLine("-----Ucuncu ders uygulamasi-----");
            //static const beraber kullanilmaz
            //static const int c = 23;
            /*int sayi = 5; //sabitlerle sabitler toplanir
            const int c1 = 3+5;*/

            //sabitler olusturuldugu yerde degeri verilmelidir
            /*const int c1;
            c1 = 3;*/
            var mC = new SampleClass(11,22);
            Console.WriteLine($"x={mC.x},y={mC.y}");
            Console.WriteLine($"C1={SampleClass.c1},C2={SampleClass.c2}");



            Console.Read();



        }
        public SabitlerUygulama()
        {
            c1 = 3;
        } 
    }
    class SampleClass
    {
        public int x;
        public int y;

        public const int c1 = 5;
        public const int c2 = c1+5;
        public SampleClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
