using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Wlasciwosci
{
    class Ilosc
    {
        public Ilosc(double sztuka) => Sztuka = sztuka;

        public double Sztuka { get; set; }

        public double Kopa
        {
            set => Sztuka = 60 * value;
            get => Sztuka / 60;
        }

        public double Tuzin
        {
            set => Sztuka = 12 * value;
            get => Sztuka / 12;
        }

        public double Mendel
        {
            set => Sztuka = 15 * value;
            get => Sztuka / 15;
        }
    }
}
