using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace MagazinElectronice
{
    class Produs
    {
      public int Pret { get; private set; }

      private static int numarProduse = 0;
        public Produs(int pret)
        {
           this.Pret = pret;
           Produs.numarProduse ++;  
        }
        public static int GetNrProduse()
        {
            return Produs.numarProduse;
        }

    }
}
