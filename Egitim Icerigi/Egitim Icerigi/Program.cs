﻿using System;
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
            //kutulama- boxing
            int i = 23;
            object o = (object)i;//explict boxing

            //kutudan cikarma-unboxing
            i *= 2;
            i = (int)o;//cast
            Console.WriteLine("Value type:{0}",i);
            Console.WriteLine("Reference type:{0}",o);
        }
    }
}
