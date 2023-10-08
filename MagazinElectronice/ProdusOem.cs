﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectronice
{
     class ProdusOem:Produs
     {  
        public string Producator { get; private set; }
        public string Model { get; private set; }

        public ProdusOem(string model, string producator, int pret):base(pret)
        {
          this.Producator = producator; 
          this.Model = model;
        }
     }

}
