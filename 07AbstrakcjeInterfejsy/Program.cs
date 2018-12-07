using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07AbstrakcjeInterfejsy
{
    class Punkt
    {
        public int x, y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static double obliczOdleglosc(Punkt punkt1, Punkt punkt2)
        {
            return Math.Sqrt(Math.Pow(punkt2.x - punkt1.x, 2) + Math.Pow(punkt2.y - punkt1.y, 2));
        }
    }

    interface Wielokat
    {
        void wypiszNazwe();
    }

    //class Odcinek
    //{
    //    public override string ToString()
    //    {
    //        return "Odcinek";
    //    }
    //}

    //class Kolo
    //{
    //    public override string ToString()
    //    {
    //        return "Koło";
    //    }
    //}

    class Kwadrat : Wielokat
    {
        public int liczbaBokow;
        public double obwod;
        public double pole;
        public double[] dlugosciBokow;
        public Punkt[] wspolrzednePunktow;

        public Kwadrat(Punkt[] wspolrzednePunktow)
        {
            this.liczbaBokow = 4;
            dlugosciBokow = new double[liczbaBokow];
            this.wspolrzednePunktow = wspolrzednePunktow;
            this.obliczDlugosciBokow();
        }

        public void obliczDlugosciBokow()
        {
            for (int i = 0; i < liczbaBokow; i++)
            {
                dlugosciBokow[i] = Punkt.obliczOdleglosc(wspolrzednePunktow[0], wspolrzednePunktow[1]);
            }
        }

        public void obliczObwod()
        {
            this.obwod = liczbaBokow * dlugosciBokow[0];
        }

        public void obliczPole()
        {
            this.pole = dlugosciBokow[0] * dlugosciBokow[0];
        }

        public void wypiszNazwe()
        {
            Console.WriteLine("Kwadrat");
        }
    }

    class Trojkat : Wielokat
    {
        public int liczbaBokow;
        public double obwod;
        public double pole;
        public double[] dlugosciBokow;
        public Punkt[] wspolrzednePunktow;

        public Trojkat(Punkt[] wspolrzednePunktow)
        {
            this.liczbaBokow = 3;
            dlugosciBokow = new double[liczbaBokow];
            wspolrzednePunktow = new Punkt[liczbaBokow];
            this.wspolrzednePunktow = wspolrzednePunktow;

            this.obliczDlugosciBokow();
        }

        public void obliczDlugosciBokow()
        {

        }

        public void obliczObwod()
        {
            this.obwod = liczbaBokow * dlugosciBokow[0];
        }

        public void obliczPole()
        {
            this.pole = dlugosciBokow[0] * dlugosciBokow[0];
        }

        public void wypiszNazwe()
        {
            Console.WriteLine("Trójkąt");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punkt[] punkty = { new Punkt(0, 0), new Punkt(3, 0), new Punkt(0, 3), new Punkt(3, 3) };
            Kwadrat kwadrat = new Kwadrat(punkty);
            kwadrat.obliczObwod();
            kwadrat.obliczPole();
            Console.WriteLine($"Kwadrat: \n bok: {kwadrat.dlugosciBokow[0]} \n pole: {kwadrat.pole} \n obwód: {kwadrat.obwod}");

            //punkty = { new Punkt(0, 0), new Punkt(3, 0), new Punkt(0, 3)};
            //Trojkat trojkat = new Trojkat(punkty);
            //trojkat.obliczObwod();
            //trojkat.obliczPole();
            //Console.WriteLine($"Kwadrat: \n bok: {kwadrat.dlugosciBokow[0]} \n pole: {kwadrat.pole} \n obwód: {kwadrat.obwod}");

            Console.ReadKey();
        }
    }
}
