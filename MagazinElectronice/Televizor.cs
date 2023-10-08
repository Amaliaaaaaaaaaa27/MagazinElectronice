using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectronice
{
     class Televizor:ProdusOem
    {
        private static int numarProduseTelevizoare = 0;
        public Televizor(string model, string producator, int pret):base(model,producator,pret)
        {
            Televizor.numarProduseTelevizoare++;
        }
        public void Porneste()
        {
            Console.WriteLine("Televizor se porneste");
        }
        public void Opreste()
        {
            Console.WriteLine("Televizorul se  opreste");
        }
        public static int  GetnumarProduseTelevizoare()
        {
            return Televizor.numarProduseTelevizoare;
        }
    }
}
