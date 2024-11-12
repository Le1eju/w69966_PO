using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SharpLab05
{
    internal class Punkt : ICloneable
    {
        double x, y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Punkt()
        {
            Console.WriteLine("Podaj współrzędną X: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną Y: ");
            Y = Convert.ToDouble(Console.ReadLine());
        }
        public Punkt(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Punkt(Punkt other)
        {
            this.X = other.X;
            this.Y = other.Y;
        }

        #region ICloneable Members

        public Punkt Clone() { return new Punkt(this); }
        object ICloneable.Clone() { return Clone(); }
        
        #endregion

        public virtual double GetCrc()
        {
            return 0;
        }
        public virtual double Distance(Punkt p2)
        {
            return Math.Sqrt(Math.Pow((this.X - p2.X), 2) + Math.Pow((this.Y - p2.Y), 2));
        }

        public virtual void Move(double x, double y)
        {
            this.X += x;
            this.Y += y;
        }

        public override string ToString()
        {
            return $"Współrzędne punktu: X={this.X}, Y={this.Y}";
        }

        public bool Equals(Punkt Point2)
        {
            if (this.X == Point2.X && this.Y == Point2.Y) return true;
            else return false;
        }
    }
}
