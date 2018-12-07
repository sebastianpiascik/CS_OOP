using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksator
{
    class Month
    {
        private int liczbaDni = 30;
        private String nazwa;

        public Month(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public int getLiczbaDni()
        {
            return this.liczbaDni;
        }

        public void setLiczbaDni(int liczbaDni)
        {
            this.liczbaDni = liczbaDni;
        }

        public string getNazwa()
        {
            return this.nazwa;
        }

        public void setNazwa(string nazwa)
        {
            this.nazwa = nazwa;
        }
    }

    class MonthsCollection
    {
        Month[] month = { new Month("Styczeń"), new Month("Luty") };

        private int GetMonth(string testMonth)
        {

            for (int j = 0; j < month.Length; j++)
            {
                if (month[j].getNazwa() == testMonth)
                {
                    return month[j].getLiczbaDni();
                }
            }
            return -1;
        }

        public int this[string month]
        {
            get => GetMonth(month);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection year = new MonthsCollection();
            Console.WriteLine(year["Styczeń"]);

            Console.WriteLine(year["Made-up Day"]);

            Console.ReadKey();
        }
    }
}
