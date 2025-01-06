using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab06
{
    public enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mnozenie,
        Dzielenie
    }

    internal class Kalkulator
    {
        private List<double> wyniki = new List<double>();

        public double Operacje(double liczba1, double liczba2, Operacja operacja)
        {
            switch (operacja)
            {
                case Operacja.Dodawanie:
                    return liczba1 + liczba2;
                case Operacja.Odejmowanie:
                    return liczba1 - liczba2;
                case Operacja.Mnozenie:
                    return liczba1 * liczba2;
                case Operacja.Dzielenie:
                    if (liczba2 == 0)
                        throw new DivideByZeroException("Nie można dzielić przez zero");
                    return liczba1 / liczba2;
                default:
                    throw new ArgumentException("Wybrano błędną operację");
            }
        }

        public void DodajWynik(double wynik)
        {
            wyniki.Add(wynik);
        }
        public void PokazWyniki()
        {
            Console.WriteLine("Poprzednie wyniki:");
            foreach (var wyniki in wyniki) { Console.WriteLine(wyniki); }
        }
    }
}
