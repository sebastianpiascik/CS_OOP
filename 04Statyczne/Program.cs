using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Statyczne
{
    static class RozszerzenieTypuInteger
    {
        public static int Silnia(this int x)
        {
            if (x < 1)
                return 1;
            else
                return x * Silnia(x - 1);
        }

        public static int Dwumian(this int x, int y)
        {
            int Wynik = 1;
            int i;

            for (i = 1; i <= y; i++)
            {
                Wynik = Wynik * (x - i + 1) / i;
            }

            return Wynik;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5 silnia: {(5).Silnia()}");
            Console.WriteLine($"dwumian 10!/5!*5!: {(10).Dwumian(5)}");
            Console.ReadKey();
        }
    }
}
