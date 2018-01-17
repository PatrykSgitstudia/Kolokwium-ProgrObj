using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kolokwium_PO
{
    class Serwis : ISerwis
    {
        private LinkedList<Agd> doNaprawy;
        private int zysk;

        public Serwis()
        {
            zysk = -15;
            doNaprawy = new LinkedList<Agd>();
        }

        public void DodajPralke(Marka marka, int numerSeryjny, string usterka)
        {
            doNaprawy.AddFirst(new Pralka(marka, numerSeryjny, usterka));
            zysk += 50;
        }
        public void DodajLodowke(Marka marka, int numerSeryjny, string usterka)
        {
            doNaprawy.AddFirst(new Lodowka(marka, numerSeryjny, usterka));
            zysk += 70;
        }

        public override string ToString()
        {
            string napisDoZwrocenia = "Lista:" + Environment.NewLine
                + "{" + Environment.NewLine;
            foreach (var wystapienieListy in doNaprawy)
                napisDoZwrocenia += wystapienieListy.ToString() + Environment.NewLine;
            return napisDoZwrocenia + "}" + Environment.NewLine
                + "Zysk: " + zysk;
        }

        public void GenerujRaport()
        {
            StreamWriter streamWriter = new StreamWriter(File.Open("usterki.txt", FileMode.Create, FileAccess.Write));
            streamWriter.Write(this.ToString());
            streamWriter.Close();
        }

        public void Napraw()
        {
            if (doNaprawy.Any())
                doNaprawy.RemoveFirst();
        }

        public void Napraw(int numerSeryjny)
        {
            foreach (var naprawiany in doNaprawy)
            {
                if (naprawiany.PobierzNumerSeryjny() == numerSeryjny)
                {
                    doNaprawy.Remove(naprawiany);
                    break;
                }
            }
        }
    }
}
