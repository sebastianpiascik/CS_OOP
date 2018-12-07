using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Konstruktory
{
    class Samochod
    {
        private Punkt polozenieNaMapie;
        private string marka;
        private string model;
        private Silnik silnik;

        public Samochod(int pozycjaX, int pozycjaY, string marka, string model, double pojemnoscSilnika)
        {
            this.polozenieNaMapie = new Punkt(pozycjaX, pozycjaY);
            this.marka = marka;
            this.model = model;
            this.silnik = new Silnik(pojemnoscSilnika);
        }

        public Samochod(Punkt punkt, string marka, string model, Silnik silnik)
            : this(punkt.PobierzX(), punkt.PobierzY(), marka, model, silnik.PobierzPojemnosc())
        {
        }

        public Samochod(string marka, string model, double pojemnoscSilnika)
            : this(0, 0, marka, model, pojemnoscSilnika)
        {
        }

        public Samochod(string marka, string model)
            : this(marka, model, 20000.00)
        {
        }

        public Samochod(string marka)
            : this(marka, "Audi A4")
        {
        }

        public Samochod()
            : this("Audi")
        {
        }

        public string PobierzInformacje()
        {
            return $"Samochód\n Marka: {marka}\n Model: {model}\n Pojemność silnika: {silnik.PobierzPojemnosc()}\n Położenie: {polozenieNaMapie.PobierzX()},{polozenieNaMapie.PobierzY()}";
        }

    }
}
