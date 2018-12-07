using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Test
{
    class A
    {
        private int R = 3;
        public int Q
        {
            get { return R - 1; }
            set { R = value * 2; }
        }
        public int this[int ind]
        {
            get { return Q - ind; }
            set { Q = value + ind; }
        }
    }
    class Zad1
    {
        static void Main()
        {
            A a = new A { Q = 5, R = 6 };
            a[1] = 1;
            Console.WriteLine($"{a.R} {a.Q} {a[2]}");
            a.Q = 4;
            Console.WriteLine($"{a.Q} {a[5]}");
        }
    }
}
