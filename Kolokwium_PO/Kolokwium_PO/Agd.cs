using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_PO
{
    class Agd
    {
        private Marka marka;
        private int numerSeryjny;
        private string usterka;

        public Agd(Marka marka, int numerSeryjny, string usterka)
        {
            this.marka = marka;
            this.numerSeryjny = numerSeryjny;
            this.usterka = usterka;
        }

        public override string ToString()
        {
            return "Marka: " + marka + ", numer seryjny: " + numerSeryjny + ", usterka: " + usterka + ".";
        }

        public int PobierzNumerSeryjny()
        {
            return numerSeryjny;
        }
    }
}
