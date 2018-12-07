using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Polimorfizm
{
    class SmokWawelskiZaadoptowany : Zwierze
    {
        private SmokWawelski smokWawelski = new SmokWawelski();
        public override void WydajGlos()
        {
            Console.WriteLine(smokWawelski.WydajGlos());
        }
        public override string NazwaLacinska
        {
            get { return smokWawelski.PodajNazweLacinska(); }
        }
        public override string ToString()
        {
            return "smok wawelski";
        }
    }
}
