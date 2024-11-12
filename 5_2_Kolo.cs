using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SharpLab05
{
    internal class Kolo : ICloneable
    {
        // Konstruktor domyślny ✅
        // Konstruktor inicjujący parametryczny ✅
        // Metoda clone ✅
        // Metoda GetCrc() ✅
        // Metoda ToString() ✅
        // Metoda Equals() ✅
        // Metoda Move() ✅

        double r;
        string nazwa;
        Punkt middle;
        public Punkt Middle { get; set; }
        public double R { get => r; set => r = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }

        public Kolo()
        {
            Console.WriteLine("Podaj współrzędną X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj promień r: ");
            this.R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj nazwę figury: ");
            this.Nazwa = Console.ReadLine();
            this.Middle = new Punkt(x, y);
        }
        public Kolo(Punkt p1, double r, string nazwa)
        {
            this.R = r;
            this.Nazwa = nazwa;
            this.Middle = p1;
        }
        public Kolo(double x, double y, double r, string nazwa)
        {
            this.R = r;
            this.Nazwa = nazwa;
            this.Middle = new Punkt(x, y);
        }
        public Kolo (Kolo other)
        {
            this.R = other.R;
            this.Nazwa = other.Nazwa;
            this.Middle = other.Middle;
        }
        #region ICloneable Members

        public new Kolo Clone() { return new Kolo(this); }
        object ICloneable.Clone() { return Clone(); }

        #endregion

        public double GetCrc()
        {
            return 2 * Math.PI * R;
        }

        public void Move(double x, double y)
        {
            this.Middle.X += x;
            this.Middle.Y += y;
        }
        public override string ToString()
        {
            return $"Środek: {Middle.X},{Middle.Y}; Promień: {R}, Obiekt: {Nazwa}";
        }
        public bool Equals(Kolo Kolo2)
        {
            if (this.Middle.X == Kolo2.Middle.X &&
                this.Middle.Y == Kolo2.Middle.Y &&
                this.R == Kolo2.R) return true ;
            else return false ;
        }
    }
}
