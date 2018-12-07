using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Dziedziczenie
{
    class Punkt
    {
        public double x;
        public double y;

        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void wypiszPunkt()
        {
            Console.WriteLine($"( {x} , {y} )");
        }
    }

    class Punkt3D : Punkt
    {
        public double z;

        public Punkt3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public void wypiszPunkt()
        {
            Console.WriteLine($"( {x} , {y} , {z} )");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt = new Punkt(2.0, 3.0);
            punkt.wypiszPunkt();
            Punkt3D punkt3d = new Punkt3D(2.5, 3.5, 4.5);
            punkt3d.wypiszPunkt();

            Console.ReadKey();
        }
    }
}
