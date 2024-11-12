using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab05
{
    internal class A
    {
        public virtual void Metoda()
        {
            Console.WriteLine("To jest wirtualna metoda klasy A");
        }

        public void MetodaA()
        {
            Console.WriteLine("To jest wyjątkowa metoda klasy A");
        }
    }
}
