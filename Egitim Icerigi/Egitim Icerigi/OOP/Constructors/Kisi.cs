using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi.OOP
{
    public class Kisi
    {
        public Kisi()
        {

        }
        public Kisi(string adi)
        {
            Adi= adi;
        }
        public Kisi(string adi, int yas)
        {
            Adi = adi;
            Yas = yas;
        }

        public string Adi { get; set; }
        public int Yas { get; set; }
    }
}
