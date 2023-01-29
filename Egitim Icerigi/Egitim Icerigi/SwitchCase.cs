using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    internal class SwitchCase
    {
        public enum Renkler { Kirmizi, Yesil, Mavi }
        public static void Fonk()
        {
            Renkler r=(Renkler) new Random().Next(0,10);
            switch (r)
            {
                case Renkler.Kirmizi:
                    Console.WriteLine("Renk Kirmizidir");
                    break;
                case Renkler.Yesil:
                    Console.WriteLine("Renk Yesildir");
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("Renk Mavidir");
                    break;
                default:
                    Console.WriteLine("Renk Bilinmiyor");
                    break;
            }

            Random rnd = new Random();  
            int caseSwitch=rnd.Next(1,10);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case{caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"Case{caseSwitch}");
                    break;
            }

        }

    }
}
