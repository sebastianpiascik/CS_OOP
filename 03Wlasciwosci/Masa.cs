using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Wlasciwosci
{
    class Masa
    {
        public Masa(double kilogram) => Kilogram = kilogram;

        public double Kilogram { get; set; }

        public double Gram
        {
            set => Kilogram = 0.001 * value;
            get => Kilogram / 0.001;
        }
    }
}
