using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_PO
{
    class Lodowka : Agd
    {
        public Lodowka(Marka marka, int numerSeryjny, string usterka)
            : base(marka, numerSeryjny, usterka) { }

        public override string ToString()
        {
            return "Lodówka: " + base.ToString();
        }
    }
}
