using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Konstruktory
{
    struct Silnik
    {
        private double pojemnosc;

        public Silnik(double pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }

        public double PobierzPojemnosc()
        {
            return pojemnosc;
        }
        public void ZmienPojemnosc(double nowaPojemnosc)
        {
            pojemnosc = nowaPojemnosc;
        }

    }
}
