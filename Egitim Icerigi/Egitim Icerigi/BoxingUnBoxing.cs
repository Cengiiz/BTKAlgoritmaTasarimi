using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi
{
    class BoxingUnBoxing
    {
         public static void Fonk()
        {
            Console.WriteLine("-----Ikinci ders uygulamasi-----");
            //kutulama- boxing
            int i = 23;
            object o = (object)i;//explict boxing

            //kutudan cikarma-unboxing
            i *= 2;
            i = (int)o;//cast
            Console.WriteLine("Value type:{0}", i);
            Console.WriteLine("Reference type:{0}", o);
            Console.Read();
        }
    }
}
