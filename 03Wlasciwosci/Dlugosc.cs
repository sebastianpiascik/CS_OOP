using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Wlasciwosci
{
    class Dlugosc
    {
        public Dlugosc(double metr) => Metr = metr;

        public double Metr { get; set; }

        public double Milimetr
        {
            set => Metr = 0.001 * value;
            get => Metr / 0.001;
        }

        public double Cal
        {
            set => Milimetr = 25.4 * value;
            get => Milimetr / 25.4;
        }

        public double Yard
        {
            set => Metr = 0.9144 * value;
            get => Metr / 0.9144;
        }

        public double MilaMorska
        {
            set => Metr = 1852 * value;
            get => Metr / 1852;
        }

        public double MilaAngielska
        {
            set => Metr = 1609.344 * value;
            get => Metr / 1609.344;
        }
    }
}
