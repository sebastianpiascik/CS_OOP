﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Polimorfizm
{
    class Osiol : Zwierze
    {
        public override void WydajGlos()
        {
            Console.WriteLine("Ioo ioo...");
        }
        public override string NazwaLacinska
        {
            get => "Equus asinus";
        }
        public override string ToString()
        {
            return "osioł";
        }
    }
}
