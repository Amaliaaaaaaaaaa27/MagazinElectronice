using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinElectronice
{
    class CasaDeMarcat
    {
        public int VanzariCurente { get; private set; } = 0;

        public void IncasareProdus(Produs produs)
        {
            this.VanzariCurente += produs.Pret;
        }

    }
}
