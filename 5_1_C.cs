using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab05
{
    internal class C : B
    {
        public override void Metoda()
        {
            Console.WriteLine("To jest nadpisana metoda klasy C");
            base.Metoda(); // 1c)
        }
    }
}
