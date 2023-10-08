using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectronice
{
    class Magazin
    {
        private string parolaCurenta = string.Empty;
        private List<Produs> produse = new List<Produs>();  
        private ManagerParole managerParole = new ManagerParole();

        public void AdaugareProduse(Produs produs) 
        {
            produse.Add(produs);
        }
        public void SchimbareParola(string parolaVeche, string parolaNoua)
        { 
            if (managerParole.SchimbareParola(parolaVeche , parolaNoua))
            {
               
                foreach(Produs produs in produse)
                { 
                 if (produs is Telefon)
                 {
                    (produs as Telefon).SchimbareParola(parolaVeche, parolaNoua);
                 }
                 
                }
                

            }
            else
            {
                Console.WriteLine("nu am schimbat parola , parola veche este gresita");
            }
        }

       
    }
} 
 