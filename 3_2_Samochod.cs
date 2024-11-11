using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab03
{
    internal class Samochod
    {
        string marka, model, nadwozie, kolor;
        int rokProdukcji;
        double przebieg;
        public string Marka
        {
            get => marka; set => marka = value;
        }
        public string Model
        {
            get => model; set => model = value;
        }
        public string Nadwozie
        {
            get => nadwozie; set => nadwozie = value;
        }
        public string Kolor
        {
            get => kolor; set => kolor = value;
        }
        public int RokProdukcji
        {
            get => rokProdukcji; set => rokProdukcji = value;
        }
        public double Przebieg
        {
            get => przebieg;
            set
            {
                if (value >= 0) przebieg = value;
                else Console.WriteLine("Przebieg nie może być liczbą ujemną"); value = double.NaN;
            }
        }
        public Samochod()
        {
            Console.WriteLine("Podaj markę pojazdu: ");
            Marka = Console.ReadLine();
            Console.WriteLine("Podaj model pojazdu: ");
            Model = Console.ReadLine();
            Console.WriteLine("Podaj rodzaj nadwozia pojazdu: ");
            Nadwozie = Console.ReadLine();
            Console.WriteLine("Podaj kolor pojazdu: ");
            Kolor = Console.ReadLine();
            Console.WriteLine("Podaj rok produkcji pojazdu: ");
            RokProdukcji = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj przebieg pojazdu: ");
            Przebieg = Convert.ToDouble(Console.ReadLine());
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        public virtual string View()
        {
            return ($"\n - Marka:\t{Marka}\n - Model:\t{Model}\n - Nadwozie:\t{Nadwozie}\n - Kolor:\t{Kolor}\n - Rok Produkcji:\t{RokProdukcji}\n - Przebieg:\t{Przebieg}\n");
        }
    }
}
