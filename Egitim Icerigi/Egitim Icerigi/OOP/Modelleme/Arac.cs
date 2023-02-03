using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_Icerigi.OOP.Modelleme
{
    public class Arac
    {
        #region Fields Degiskenleri
        private string marka, model, renk;
        private int yil;
        #endregion
        #region Properties
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion
        #region Constructors
        public Arac()
        {

        }
        public Arac(string marka, string model, string reng, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = reng;
            Yil = yil;
        }
        #endregion
        #region Methods
        public void Calistir() => Console.WriteLine("Arac calisti");
        public void Durdur() => Console.WriteLine("Arac durdu");
        #endregion

    }
}
