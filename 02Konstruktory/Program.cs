using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt();
            Silnik s1 = new Silnik(2000);
            Samochod samochod1 = new Samochod(p1, "Audi", "A4", s1);

            Console.WriteLine(samochod1.PobierzInformacje());

            Console.ReadKey();
        }
    }
}
