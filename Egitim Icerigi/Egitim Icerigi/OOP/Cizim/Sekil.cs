using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi.OOP.Cizim
{
    public class Pozisyon
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
    }
    public class Sekil
    {
        public Pozisyon pozisyon { get; set; } = new Pozisyon();
        public Boyut boyut { get; set; }=new Boyut();
        public virtual void Ciz() => Console.WriteLine($"Sekil{pozisyon}-{boyut}");
    }
}
