using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Wlasciwosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Ilosc i1 = new Ilosc(120);
            Console.WriteLine($"Sztuki: {i1.Sztuka}, Kopa: {i1.Kopa}, Tuzin: {i1.Tuzin}, Mendel: {i1.Mendel}");
            i1.Mendel = 14;
            Console.WriteLine($"Sztuki: {i1.Sztuka}, Kopa: {i1.Kopa}, Tuzin: {i1.Tuzin}, Mendel: {i1.Mendel}\n");

            Dlugosc d1 = new Dlugosc(12);
            Console.WriteLine($"Metr: {d1.Metr}, Milimetr: {d1.Milimetr}, Cal: {d1.Cal}, Yard: {d1.Yard}, Mila morska: {d1.MilaMorska}, Mila Angielska: {d1.MilaAngielska}");
            d1.Cal = 32;
            Console.WriteLine($"Metr: {d1.Metr}, Milimetr: {d1.Milimetr}, Cal: {d1.Cal}, Yard: {d1.Yard}, Mila morska: {d1.MilaMorska}, Mila Angielska: {d1.MilaAngielska}\n");

            Masa m1 = new Masa(10);
            Console.WriteLine($"Kilogramy: {m1.Kilogram}, Gram: {m1.Gram}");
            m1.Kilogram = 1;
            Console.WriteLine($"Kilogramy: {m1.Kilogram}, Gram: {m1.Gram}");

            Console.ReadKey();
        }
    }
}
