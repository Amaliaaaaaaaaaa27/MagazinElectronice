using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectronice
{
    class Bec:Produs
    {
        public Bec(int pret):base(pret)
        {
            
        }
        public void Aprinde()
        {
            Console.WriteLine("Se aprinde becul");
        }
        public void Stinge()
        {
            Console.WriteLine(" Se stinge becul");
        }
    }
}
