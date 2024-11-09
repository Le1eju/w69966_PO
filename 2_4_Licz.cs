using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab02
{
    internal class Licz
    {
        private double value = 0;

        public void Dodaj(double add)
        {
            value += add;
        }
        public void Odejmij(double sub)
        {
            value -= sub;
        }
        public double Wypisz()
        {
            return value;
        }

        public Licz(double liczba)
        {
            value = liczba;
        }
    }
}
