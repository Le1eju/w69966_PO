using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab05
{
    internal class Trojkat : ICloneable
    {
        List<Punkt> wierzcholki = new List<Punkt>();
        public List<Punkt> Wierzcholki { get => wierzcholki; set => wierzcholki = value; }
        string nazwa;
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public Trojkat()
        {
            double x, y;
            Console.WriteLine("Wierzchołek 1: ");
            Console.WriteLine("Podaj P1.x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj P1.y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Wierzcholki.Add(new Punkt(x, y));
            Console.WriteLine("Wierzchołek 2: ");
            Console.WriteLine("Podaj P2.x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj P2.y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Wierzcholki.Add(new Punkt(x, y));
            Console.WriteLine("Wierzchołek 3: ");
            Console.WriteLine("Podaj P3.x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj P3.y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Wierzcholki.Add(new Punkt(x, y));
        }
        public Trojkat(List<Punkt> points, string nazwa)
        {
            foreach (Punkt p in points)
            {
                Wierzcholki.Add(p);
            }
            this.Nazwa = nazwa;
        }
        
        public Trojkat (Trojkat other)
        {
            this.Wierzcholki = other.Wierzcholki;
            this.Nazwa = other.Nazwa;
        }

        #region ICloneable Members

        public new Trojkat Clone() { return new Trojkat(this); }
        object ICloneable.Clone() { return Clone(); }

        #endregion

        public double GetCrc()
        {
            double sum = 0;
            for (int i = 0;i< Wierzcholki.Count-1; i++)
            {
                sum += Wierzcholki[i].Distance(Wierzcholki[i+1]);
            }
            sum += Wierzcholki[Wierzcholki.Count-1].Distance(Wierzcholki[0]);
            return sum;
        }
        public void Move(double x, double y)
        {
            foreach(Punkt p in Wierzcholki)
            {
                p.X += x;
                p.Y += y;
            }
        }
        public override string ToString()
        {
            string result = $"{Nazwa}\n";
            int i = 1;
            foreach(Punkt p in Wierzcholki)
            {
                result += $"W{i}: X={p.X}, Y={p.Y}\n";
                i++;
            }
            return result;
        }

        public bool Equals(Trojkat t2)
        {
            bool result = true;
            for (int i = 0;i<this.Wierzcholki.Count;i++)
            {
                if (this.Wierzcholki[i].X == t2.Wierzcholki[i].X
                    && this.Wierzcholki[i].Y == t2.Wierzcholki[i].Y)
                    result = true;
                else result = false; break;
            }
            return result;
        }

    }
}
