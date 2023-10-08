using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectronice
{
     class Telefon:ProdusOem
    {
        private string parolaCurent = string.Empty; // initializeaza
        private bool esteBlocat = false;
        private static int nrTelefoane = 0;
        public Telefon(string model , string producator , int pret):base(model , producator , pret)
        {
            Telefon.nrTelefoane++;
        }
        public void Blocheaza()
        {
            Console.WriteLine("Am blocat telefonul");
            this.esteBlocat = true; 
        }
        public void Deblocheaza(string parola)
        {
            if (parola == parolaCurent)
            {
                this.esteBlocat = false;
                Console.WriteLine("Telefonul s a deblocat");
            }
            else
            {
                Console.WriteLine("Parola e gresita.Nu am deblocat telefonul");
            }
        }
        public void SchimbareParola(string parolaVeche, string parolaNoua)
        {
            if (parolaVeche == parolaCurent)
            {
                Console.WriteLine("Am schimbat parola");
            }
            
            else
            {
                Console.WriteLine("nu am schimbat parola , parola veche este gresita");
            }
        }
        public void Apeleaza(string  nrTelefon )
        {
            if(!esteBlocat)
            {
                Console.WriteLine($"apeleaza ... {nrTelefon}");
            }
            else
            {
                Console.WriteLine("Telefonul este blocat !");
            }
        }

        public static int GetNumarTelefoane()
        {
            return Telefon.nrTelefoane;
        }


    }
}
