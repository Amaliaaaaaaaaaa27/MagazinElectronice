using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectronice
{
    class ManagerParole
    {

        private string parolaCurent = string.Empty;

        public ManagerParole()
        {
            
        }
        public bool SchimbareParola(string parolaVeche, string parolaNoua)
        {
            if (parolaVeche == parolaCurent)
            {
                this.parolaCurent = parolaNoua;
                Console.WriteLine("Am schimbat parola");
                return true;
            }

            else
            {
                Console.WriteLine("nu am schimbat parola , parola veche este gresita");
                return false;
            }
        }
    }
}
