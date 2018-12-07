﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Polimorfizm
{
    class WilkZaadoptowany : Zwierze
    {
        private Wilk wilk = new Wilk();
        public override void WydajGlos()
        {
            Console.WriteLine(wilk.Wyj());
        }
        public override string NazwaLacinska
        {
            get { return wilk.PodajNazweLacinska(); }
        }
        public override string ToString()
        {
            return "wilk";
        }
    }
}
