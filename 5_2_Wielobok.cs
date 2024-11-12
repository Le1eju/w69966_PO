using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab05
{
    internal class Wielobok : ICloneable
    {
        List<Punkt> wierzcholki = new List<Punkt>();
        public List<Punkt> Wierzcholki { get => wierzcholki; set => wierzcholki = value; }
        string nazwa;
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public Wielobok() { }
        public Wielobok(List<Punkt> points, string nazwa)
        {
            foreach (Punkt p in points)
            {
                Wierzcholki.Add(p);
            }
            this.Nazwa = nazwa;
        }
        public Wielobok(Wielobok other)
        {
            this.Wierzcholki = other.Wierzcholki;
            this.Nazwa = other.Nazwa;
        }

        #region ICloneable Members
        public new Wielobok Clone() { return new Wielobok(this); }
        object ICloneable.Clone() { return Clone(); }

        #endregion

        public double GetCrc()
        {
            double sum = 0;
            for (int i = 0; i < Wierzcholki.Count - 1; i++)
            {
                sum += Wierzcholki[i].Distance(Wierzcholki[i + 1]);
            }
            sum += Wierzcholki[Wierzcholki.Count - 1].Distance(Wierzcholki[0]);
            return sum;
        }
        public void Move(double x, double y)
        {
            foreach (Punkt p in Wierzcholki)
            {
                p.X += x;
                p.Y += y;
            }
        }
        public override string ToString()
        {
            string result = $"{Wierzcholki.Count}-bok: {Nazwa}\n";
            int i = 1;
            foreach (Punkt p in Wierzcholki)
            {
                result += $"W{i}: X={p.X}, Y={p.Y}\n";
                i++;
            }
            return result;
        }
        public bool Equals(Wielobok t2)
        {
            bool result = true;
            for (int i = 0; i < this.Wierzcholki.Count; i++)
            {
                if (this.Wierzcholki[i].X == t2.Wierzcholki[i].X
                    && this.Wierzcholki[i].Y == t2.Wierzcholki[i].Y)
                { result = true; }
                else { result = false; break; }
            }
            return result;
        }
        public void DodajPunkt()
        {
            double x, y;
            Console.WriteLine("Podaj X punktu który chcesz dodać: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj Y punktu który chcesz dodać: ");
            y = Convert.ToDouble(Console.ReadLine());
            Wierzcholki.Add(new Punkt(x, y));
        }
        // Porównanie figur tego samego typu pod względem obwodu: poddałem się
    }
}
