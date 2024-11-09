using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab02
{
    internal class Student
    {
        string imie, nazwisko;
        List<double> oceny = new List<double>();

        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void DodajOcene(double ocena)
        {
            if (ocena >= 0 && ocena <= 5)
            {
                this.oceny.Add(ocena);
            }
            else { Console.WriteLine($"Podano nieprawidłową ocenę: {ocena}"); }
        }

        public double SredniaOcen()
        {
            return Math.Round((double)oceny.Average(), 2);
        }
    }
}
