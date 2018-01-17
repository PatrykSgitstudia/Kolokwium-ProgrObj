using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_PO
{
    interface ISerwis
    {
        void DodajPralke(Marka marka, int numerSeryjny, string usterka);
        void DodajLodowke(Marka marka, int numerSeryjny, string usterka);
        void GenerujRaport();
        void Napraw();
        void Napraw(int numerSeryjny);
    }
}
