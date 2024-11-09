using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab02
{
    internal class Sumator
    {
        private List<double> Liczby = new List<double>();

        public double Suma()
        {
            double sum = 0;
            foreach (double num in Liczby)
            {
                sum += num;
            }
            return sum;
        }
        public double SumaPodziel2()
        {
            double sum = 0;
            foreach (double num in Liczby)
            {
                if (num % 2 == 0) { sum += num; }
            }
            return sum;
        }

        public int IleElementow()
        {
            Console.Write("Ilość elemetów: ");
            return Liczby.Count;
        }

        public void WypiszElementy()
        {
            foreach (double n in Liczby)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();
        }

        public void Parametrownia(int lowIndex, int highIndex)
        {
            if (lowIndex < 0) { lowIndex = 0; }
            else if (lowIndex > Liczby.Count - 1) { lowIndex = Liczby.Count - 1; }
            if (highIndex < 0) { highIndex = 0; }
            else if (highIndex > Liczby.Count - 1) { highIndex = Liczby.Count - 1; }

            if (highIndex<lowIndex) { highIndex = lowIndex; }
            if (lowIndex > highIndex) { lowIndex = highIndex; }

            for (int i = lowIndex; i <= highIndex; i++)
            {
                Console.Write($"{Liczby[i]}, ");
            }
            Console.WriteLine();
        }

        public Sumator(List<double> liczby)
        {
            this.Liczby = liczby;
        }
    }
}
